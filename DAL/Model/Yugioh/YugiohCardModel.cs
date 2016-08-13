using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class YugiohCardModel
    {
        public const string CardData = "card_data/";

        public const string QueryParameter = "?";

        public const string CardName = "card_name=";

        [JsonProperty(PropertyName = "data")]
        public YugiohCardItemModel Card { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "print_tag")]
        public string PrintTag { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }

        [JsonProperty(PropertyName = "price_data")]
        public YugiohCardPriceDataModel PriceData { get; set; }
    }

   public class YugiohCardItemModel
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
