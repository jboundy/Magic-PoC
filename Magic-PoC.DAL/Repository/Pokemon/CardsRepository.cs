using System;
using System.Net.Http;
using System.Threading.Tasks;
using DAL.Interface.Pokemon;
using DAL.Model.Pokemon;

namespace DAL.Repository.Pokemon
{
    public class CardsRepository : BaseRepository, ICardsRepository
    {
        public CardsRepository()
        {
            Client.BaseAddress = new Uri("http://pokeprices.doeiqts.com/api/");
        }

        public async Task<CardModel> FindCard(string name)
        {
            HttpResponseMessage resposne = await Client.GetAsync(CardModel.FineCards + CardModel.CardName + name);
            return await GetJsonResponse<CardModel>(resposne);
        }

        public async Task<CardModel> GetSet(string name)
        {
            HttpResponseMessage response = await Client.GetAsync(CardModel.GetSet + CardModel.SetName + name);
            return await GetJsonResponse<CardModel>(response);
        }

        public async Task<CardModel> GetSets()
        {
            HttpResponseMessage response = await Client.GetAsync(CardModel.GetSets);
            return await GetJsonResponse<CardModel>(response);
        }
    }
}
