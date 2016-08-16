using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Interface.Yugioh;

namespace DAL.Repository.Yugioh
{
    public class YugiohSetsRepository: BaseRepository, IYugiohSetsRepository
    {
        public YugiohSetsRepository()
        {
            Client.BaseAddress = new Uri("http://yugiohprices.com/api/");
        }
    }
}
