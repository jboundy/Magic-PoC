using System;
using System.Net.Http;
using System.Threading.Tasks;
using DAL.Interface.Magic;
using DAL.Model.Magic;

namespace DAL.Repository.Magic
{
    public class MagicCardsRepository : BaseRepository, IMagicCardsRepository
    {
        public MagicCardsRepository()
        {
            Client.BaseAddress = new Uri("https://api.magicthegathering.io/v1/");
        }

        public async Task<MagicCardModel> GetSpecificCard(string queryParameter, string cardInfo)
        {
            HttpResponseMessage response = await Client.GetAsync(MagicCardModel.CardsQuery + queryParameter + "=" + cardInfo);
            return await GetJsonResponse<MagicCardModel>(response);
        }

        public async Task<MagicCardModel> GetAllCards()
        {
            HttpResponseMessage response = await Client.GetAsync(MagicCardModel.CardsQuery + "page=5");
            return await GetJsonResponse<MagicCardModel>(response);
        }
    }
}
