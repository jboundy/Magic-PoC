using System.Net.Http;
using System.Threading.Tasks;
using Magic_PoC.DAL.Interface;
using Magic_PoC.DAL.Model;
using Newtonsoft.Json;

namespace Magic_PoC.DAL.Repository
{
    public class CardsRepository : BaseRepository, ICardsRepository
    {
        public async Task<CardModel> GetSpecificCard(string queryParameter, string cardInfo)
        {
            HttpResponseMessage response = await Client.GetAsync(CardModel.CardsQuery + queryParameter + "=" + cardInfo);
            if (!response.IsSuccessStatusCode) return new CardModel();
            var cards = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CardModel>(cards);
        }

        public async Task<CardModel> GetAllCards()
        {
            HttpResponseMessage response = await Client.GetAsync(CardModel.CardsQuery + "page=5");
            if (!response.IsSuccessStatusCode) return new CardModel();
            var cards = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CardModel>(cards);
        }
    }
}
