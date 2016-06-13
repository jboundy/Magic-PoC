using System.Threading.Tasks;
using Magic_PoC.DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magic_PoC.DAL.Tests
{
    [TestClass]
    public class CardRepositoryTest
    {
        [TestMethod]
        public async Task CanGet_AllCards()
        {
            var result = await CardsRepository().GetAllCards();
            Assert.IsNotNull(result);
        }

        private CardsRepository CardsRepository()
        {
            return new CardsRepository();
        }
    }
}
