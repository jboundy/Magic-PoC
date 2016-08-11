using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Magic_PoC.DAL.Model;
using Newtonsoft.Json;

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

        protected async Task<T> GetJsonResponse<T>(HttpResponseMessage response) where T : new()
        {    
            if (!response.IsSuccessStatusCode) return new T();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        public void Dispose()
        {
            Client.Dispose();
        }
    }
}
