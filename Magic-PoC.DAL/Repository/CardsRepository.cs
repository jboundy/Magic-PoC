using System.Net.Http;
using System.Threading.Tasks;
using Magic_PoC.DAL.Interface;
using Magic_PoC.DAL.Model;

namespace Magic_PoC.DAL.Repository
{
    public class CardsRepository : BaseRepository, ICardsRepository
    {
        public async Task<CardModel> GetSpecificCard(string queryParameter, string cardInfo)
        {
            HttpResponseMessage response = await Client.GetAsync(CardModel.CardsQuery + queryParameter + "=" + cardInfo);
            return await GetJsonResponse<CardModel>(response);
        }

        public async Task<CardModel> GetAllCards()
        {
            HttpResponseMessage response = await Client.GetAsync(CardModel.CardsQuery + "page=5");
            return await GetJsonResponse<CardModel>(response);
        }
    }
}
