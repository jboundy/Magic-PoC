using System.Threading.Tasks;
using DAL.Model.Magic;

namespace DAL.Interface.Magic
{
    public interface IMagicCardsRepository
    {
        Task<MagicCardModel> GetSpecificCard(string queryParameter, string cardInfo);
        Task<MagicCardModel> GetAllCards();
    }
}
