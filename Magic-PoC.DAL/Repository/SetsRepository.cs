using System.Net.Http;
using System.Threading.Tasks;
using Magic_PoC.DAL.Interface;
using Magic_PoC.DAL.Model;

namespace Magic_PoC.DAL.Repository
{
    public class SetsRepository : BaseRepository, ISetsRepository
    {
        public async Task<SetModel> GetSet(string set)
        {
            HttpResponseMessage response = await Client.GetAsync(SetModel.SetsQuery + set);
            return await GetJsonResponse<SetModel>(response);
        }
    }
}
