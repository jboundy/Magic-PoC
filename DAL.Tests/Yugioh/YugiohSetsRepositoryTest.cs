using System.Threading.Tasks;
using DAL.Repository.Yugioh;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests.Yugioh
{
    [TestClass]
    public class YugiohSetsRepositoryTest
    {
        [TestMethod]
        public async Task CanGet_SetData()
        {
            
        }

        private YugiohSetsRepository YugiohSetsRepository()
        {
            return new YugiohSetsRepository();
        }
    }
}
