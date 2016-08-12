using System.Threading.Tasks;
using DAL.Model.Magic;

namespace DAL.Interface.Magic
{
    public interface ICardsRepository
    {
        Task<CardModel> GetSpecificCard(string queryParameter, string cardInfo);
        Task<CardModel> GetAllCards();
    }
}
