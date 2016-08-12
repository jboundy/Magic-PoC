using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL.Model.Pokemon
{
    public class CardModel
    {
        public const string FineCards = "findcards?";
        public const string CardName = "cardname=";
        public const string GetSet = "getset?";
        public const string SetName = "setname=";
        public const string GetSets = "getsets";
        [JsonProperty(PropertyName = "cards")]
        public List<CardItemModel> Cards { get; set; }
    }

    public class CardItemModel
    {
        [JsonProperty(PropertyName = "set")]
        public string Set { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "URL")]
        public string Picture { get; set; }
        
        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "number")]
        public string SetNumber { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }

        [JsonProperty(PropertyName = "smallURL")]
        public string TinyPicture { get; set; }
    }
}
