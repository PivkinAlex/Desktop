using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MK.Repository
{
    public class Repository : HttpClientMK
    {
        private readonly string RegistrationUrl = "/api/authentication/registration";
        private readonly HttpClient _httpClient;
        public Repository() 
        {
            _httpClient = GetHttpClient();
        }
    }
}
