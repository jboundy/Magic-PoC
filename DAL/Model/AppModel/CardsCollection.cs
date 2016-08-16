using System;
using DAL.DataModel;

namespace DAL.Model.AppModel
{
    public class CardsCollection
    {
        public int Id { get; set; }
        public CardType CardType { get; set; }
        public string Name { get; set; }
        public string OwnedBy { get; set; }
        public DateTime Created { get; set; }
        
    }
}
