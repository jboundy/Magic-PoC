using System.Data.Entity;
using DAL.Model.AppModel;

namespace DAL.DataModel
{
    public class CardsCollectionContext : DbContext
    {
        public DbSet<CardsCollection> CardsCollection { get; set; }
    }
}
