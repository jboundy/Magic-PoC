using System.Threading.Tasks;
using DAL.Model.Magic;

namespace DAL.Interface.Magic
{
    public interface IMagicSetsRepository
    {
        Task<MagicSetModel> GetSet(string set);
    }
}
