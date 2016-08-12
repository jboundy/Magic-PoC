using System.Threading.Tasks;
using DAL.Repository.Magic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests.Magic
{
    [TestClass]
    public class CardRepositoryTest
    {
        [TestMethod]
        public async Task CanGet_AllCards()
        {
            var results = await Task.Run(() => CardsRepository().GetAllCards().GetAwaiter().GetResult().Cards);
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public async Task CanGet_AnyCard_ThruParameter()
        {
            var results = await Task.Run(() => CardsRepository().GetSpecificCard("name", "Narset, Enlightened Master").GetAwaiter().GetResult().Cards);
            Assert.IsNotNull(results);
        }

        private CardsRepository CardsRepository()
        {
            return new CardsRepository();
        }
    }
}
