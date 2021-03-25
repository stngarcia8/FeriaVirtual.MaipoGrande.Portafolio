using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FeriaVirtual.App.Desktop.SeedWork.Protocols
{
    public static class ClientHttp
    {
        private const string BASEURL = "https://localhost:44315";


        public static HttpClient GetHttpClient()
        {
            HttpClient _client = new HttpClient
            {
                BaseAddress = new Uri(BASEURL)
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            return _client;
        }




    }
}
