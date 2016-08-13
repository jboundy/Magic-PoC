using System;
using System.Net.Http;
using System.Threading.Tasks;
using DAL.Interface.Pokemon;
using DAL.Model.Pokemon;

namespace DAL.Repository.Pokemon
{
    public class PokemonCardsRepository : BaseRepository, IPokemonCardsRepository
    {
        public PokemonCardsRepository()
        {
            Client.BaseAddress = new Uri("http://pokeprices.doeiqts.com/api/");
        }

        public async Task<PokemonCardModel> FindCard(string name)
        {
            HttpResponseMessage resposne = await Client.GetAsync(PokemonCardModel.FineCards + PokemonCardModel.CardName + name);
            return await GetJsonResponse<PokemonCardModel>(resposne);
        }

        public async Task<PokemonCardModel> GetSet(string name)
        {
            HttpResponseMessage response = await Client.GetAsync(PokemonCardModel.GetSet + PokemonCardModel.SetName + name);
            return await GetJsonResponse<PokemonCardModel>(response);
        }

        public async Task<PokemonCardModel> GetSets()
        {
            HttpResponseMessage response = await Client.GetAsync(PokemonCardModel.GetSets);
            return await GetJsonResponse<PokemonCardModel>(response);
        }
    }
}
