using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class CardModel
    {
        [JsonProperty(PropertyName = "data")]
        public List<CardItemModel> Card { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "print_tag")]
        public string PrintTag { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }
        [JsonProperty(PropertyName = "price_data")]
        public List<CardPriceDataModel> PriceData { get; set; }
    }

    public class CardItemModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "card_type")]
        public string CardType { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        [JsonProperty(PropertyName = "atk")]
        public string Attack { get; set; }

        [JsonProperty(PropertyName = "def")]
        public string Defense { get; set; }

        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        [JsonProperty(PropertyName = "property")]
        public string Property { get; set; }

    }
}
