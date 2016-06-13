using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic_PoC.DAL.Model;

namespace Magic_PoC.DAL.Interface
{
    public interface ICardsRepository
    {
        Task<CardModel> GetAllCards();
    }
}
