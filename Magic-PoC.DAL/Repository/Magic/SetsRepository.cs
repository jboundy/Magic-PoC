using System;
using System.Net.Http;
using System.Threading.Tasks;
using DAL.Interface.Magic;
using DAL.Model.Magic;

namespace DAL.Repository.Magic
{
    public class SetsRepository : BaseRepository, ISetsRepository
    {
        public SetsRepository()
        {
            Client.BaseAddress = new Uri("https://api.magicthegathering.io/v1/");
        }

        public async Task<SetModel> GetSet(string set)
        {
            HttpResponseMessage response = await Client.GetAsync(SetModel.SetsQuery + set);
            return await GetJsonResponse<SetModel>(response);
        }
    }
}
