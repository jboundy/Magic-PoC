using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Magic_PoC.DAL.Repository
{
    public class BaseRepository : IDisposable
    {
        protected readonly HttpClient Client;

        protected BaseRepository()
        {
            var client = new HttpClient { BaseAddress = new Uri("https://api.magicthegathering.io/v1/") };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client = client;
        }
        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
