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
            var results =  await Task.Run(() => SetsRepository().GetSet("LEA").GetAwaiter().GetResult().Set);
            Assert.IsNotNull(results.Name);
        }

        private SetsRepository SetsRepository()
        {
            return new SetsRepository();
        }
    }
}
