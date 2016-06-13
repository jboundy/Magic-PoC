using System.Net.Http;
using System.Threading.Tasks;
using Magic_PoC.DAL.Interface;
using Magic_PoC.DAL.Model;
using Newtonsoft.Json;

namespace Magic_PoC.DAL.Repository
{
    public class SetsRepository : BaseRepository, ISetsRepository
    {
        public async Task<SetModel> GetSet(string set)
        {
            HttpResponseMessage response = await _client.GetAsync("sets/" + set);
            if (!response.IsSuccessStatusCode) return new SetModel();
            var sets = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SetModel>(sets);
        }
    }
}
