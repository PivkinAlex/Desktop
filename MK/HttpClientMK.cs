using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MK
{
    public abstract class HttpClientMK
    {
        private readonly Uri _baseUri;
        protected HttpClientMK() 
        {
            _baseUri = new Uri("http://");
        }
        protected HttpClient GetHttpClient() 
        {
            var client = new HttpClient();
            client.BaseAddress = _baseUri;
            return client;
        }
    }
}
