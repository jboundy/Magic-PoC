using System.Threading.Tasks;
using DAL.Model.Pokemon;

namespace DAL.Interface.Pokemon
{
    public interface ICardsRepository
    {
        Task<CardModel> FindCard(string name);
        Task<CardModel> GetSet(string name);
        Task<CardModel> GetSets();
    }
}
