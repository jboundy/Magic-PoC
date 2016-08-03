using System.Threading.Tasks;
using Magic_PoC.DAL.Model;

namespace Magic_PoC.DAL.Interface
{
    public interface ISetsRepository
    {
        Task<SetModel> GetSet(string set);
    }
}
