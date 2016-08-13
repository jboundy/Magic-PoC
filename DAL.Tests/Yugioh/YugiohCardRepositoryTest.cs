using DAL.Repository.Yugioh;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests.Yugioh
{
    [TestClass]
    public class YugiohCardRepositoryTest
    {

        [TestMethod]
        public async Task CanGet_CardsData_ByName()
        {
            var result = await Task.Run(() => CardsRepository().GetCardData("Blue-Eyes White Dragon").GetAwaiter().GetResult().Card);
            Assert.AreEqual(result.Name, "Blue-Eyes White Dragon");
        }

        [TestMethod]
        public async Task CanGet_CardImage_ByName()
        {
            var result = await Task.Run(() => CardsRepository().GetCardPicture("Blue-Eyes White Dragon").GetAwaiter().GetResult().Image);
            Assert.IsNotNull(result);
        }

        private YugiohCardsRepository CardsRepository()
        {
            return new YugiohCardsRepository();
        }
    }
}
