using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Magic_PoC.DAL
{
    public class SetsRepository
    {
        private HttpClient _client;
        public SetsRepository()
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.magicthegathering.io/v1/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _client = client;
            }
        }

        public async Task GetSetCards(string set)
        {
            HttpResponseMessage response = await _client.GetAsync("sets");
            if (response.IsSuccessStatusCode)
            {
                var cards = await response.Content.ReadAsAsync<Product>();
                Console.WriteLine("{0}\t${1}\t{2}", product.Name, product.Price, product.Category);
            }



        }
    }
}
