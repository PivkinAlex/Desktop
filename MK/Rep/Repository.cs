using MK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MK.Rep
{
    public class Repository : HttpClientMK
    {
        private readonly string RegistrationUrl = "/api/authentication/registration";
        private readonly string LoginUrl = "/api/authentication/login";
        private readonly HttpClient _httpClient;
        public Repository() 
        {
            _httpClient = GetHttpClient();
        }
        public async Task<HttpResponseMessage> PostAuthenticationRegister(UserForRegistration login)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync(RegistrationUrl, login);
            return responseMessage;
        }
        public async Task<HttpResponseMessage> PostAuthenticationLogin(UserForLogin login)
        {
            var responseMessage = await _httpClient.PostAsJsonAsync(LoginUrl, login);
            dynamic responseData = Newtonsoft.Json.JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync());
            TokenStorage.Key = responseData.access_token;
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenStorage.Key);
            return responseMessage;
        }
    }
}
