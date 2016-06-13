using System.Threading.Tasks;
using Magic_PoC.DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magic_PoC.DAL.Tests
{
    [TestClass]
    public class SetRepositoryTests
    {

        [TestMethod]
        public async Task CanGet_CardSetData()
        {
            var result =  await SetsRepository().GetSet("LEA");
            Assert.IsNotNull(result);
        }

        private SetsRepository SetsRepository()
        {
            return new SetsRepository();
        }
    }
}
