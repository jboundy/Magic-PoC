using System.Threading.Tasks;
using DAL.Model.Magic;

namespace DAL.Interface.Magic
{
    public interface ISetsRepository
    {
        Task<SetModel> GetSet(string set);
    }
}
