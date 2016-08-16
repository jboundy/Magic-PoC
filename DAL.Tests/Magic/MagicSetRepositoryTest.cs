using System.Threading.Tasks;
using DAL.Repository.Magic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL.Tests.Magic
{
    [TestClass]
    public class MagicSetRepositoryTest
    {

        [TestMethod]
        public async Task CanGet_CardSetData()
        {
            var results =  await Task.Run(() => SetsRepository().GetSet("LEA").GetAwaiter().GetResult().Set);
            Assert.IsNotNull(results.Name);
        }

        private MagicSetsRepository SetsRepository()
        {
            return new MagicSetsRepository();
        }
    }
}
