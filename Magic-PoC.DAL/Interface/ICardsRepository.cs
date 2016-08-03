using System.Threading.Tasks;
using Magic_PoC.DAL.Model;

namespace Magic_PoC.DAL.Interface
{
    public interface ICardsRepository
    {
        Task<CardModel> GetSpecificCard(string queryParameter, string cardInfo);
        Task<CardModel> GetAllCards();
    }
}
