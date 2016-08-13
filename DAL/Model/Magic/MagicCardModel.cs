using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL.Model.Magic
{
    public class MagicCardModel
    {
        public const string CardsQuery = "cards?";
        public const string AllCardsQuery = "cards";

        [JsonProperty(PropertyName = "cards")]
        public List<MagicCardItemModel> Cards { get; set; }
    }

    public class MagicCardItemModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "manaCost")]
        public string ManaCost { get; set; }

        [JsonProperty(PropertyName = "cmc")]
        public string CMC { get; set; }

        [JsonProperty(PropertyName = "colors")]
        public List<string> Colors { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "types")]
        public List<string> Types { get; set; }

        [JsonProperty(PropertyName = "subtypes")]
        public List<string> SubTypes { get; set; }

        [JsonProperty(PropertyName = "rarity")]
        public string Rarity { get; set; }

        [JsonProperty(PropertyName = "set")]
        public string Set { get; set; }

        [JsonProperty(PropertyName = "setName")]
        public string SetName { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "flavor")]
        public string Flavor { get; set; }

        [JsonProperty(PropertyName = "artist")]
        public string Artist { get; set; }

        [JsonProperty(PropertyName = "power")]
        public string Power { get; set; }

        [JsonProperty(PropertyName = "toughness")]
        public string Toughness { get; set; }

        [JsonProperty(PropertyName = "layout")]
        public string Layout { get; set; }

        [JsonProperty(PropertyName = "multiverseid")]
        public string MultiverseId { get; set; }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty(PropertyName = "printings")]
        public List<string> Printings { get; set; }

        [JsonProperty(PropertyName = "originalText")]
        public string OriginalText { get; set; }

        [JsonProperty(PropertyName = "originalType")]
        public string OriginalType { get; set; }

        [JsonProperty(PropertyName = "legalities")]
        public List<MagicLegalitiesModel> Legalities { get; set; }
    }
}
