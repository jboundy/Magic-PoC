using System.Threading.Tasks;
using DAL.Model.Pokemon;

namespace DAL.Interface.Pokemon
{
    public interface IPokemonCardsRepository
    {
        Task<PokemonCardModel> FindCard(string name);
        Task<PokemonCardModel> GetSet(string name);
        Task<PokemonCardModel> GetSets();
    }
}
