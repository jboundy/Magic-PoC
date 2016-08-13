using System;
using System.Net.Http;
using System.Threading.Tasks;
using DAL.Interface.Magic;
using DAL.Model.Magic;

namespace DAL.Repository.Magic
{
    public class MagicSetsRepository : BaseRepository, IMagicSetsRepository
    {
        public MagicSetsRepository()
        {
            Client.BaseAddress = new Uri("https://api.magicthegathering.io/v1/");
        }

        public async Task<MagicSetModel> GetSet(string set)
        {
            HttpResponseMessage response = await Client.GetAsync(MagicSetModel.SetsQuery + set);
            return await GetJsonResponse<MagicSetModel>(response);
        }
    }
}
