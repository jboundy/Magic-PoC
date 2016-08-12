using System;
using System.Net.Http;
using System.Threading.Tasks;
using DAL.Interface.Magic;
using DAL.Model.Magic;

namespace DAL.Repository.Magic
{
    public class CardsRepository : BaseRepository, ICardsRepository
    {
        public CardsRepository()
        {
            Client.BaseAddress = new Uri("https://api.magicthegathering.io/v1/");
        }

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
