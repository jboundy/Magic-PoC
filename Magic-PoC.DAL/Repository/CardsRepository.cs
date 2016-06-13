using System.Net.Http;
using System.Threading.Tasks;
using Magic_PoC.DAL.Interface;
using Magic_PoC.DAL.Model;
using Newtonsoft.Json;

namespace Magic_PoC.DAL.Repository
{
    public class CardsRepository : BaseRepository, ICardsRepository
    {
        public async Task<CardModel> GetAllCards()
        {
            HttpResponseMessage response = await _client.GetAsync("cards");
            if (!response.IsSuccessStatusCode) return new CardModel();
            var cards = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CardModel>(cards);
        }
    }
}
