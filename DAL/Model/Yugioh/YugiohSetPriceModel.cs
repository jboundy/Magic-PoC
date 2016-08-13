using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class YugiohSetPriceModel
    {
        [JsonProperty(PropertyName = "data")]
        public List<YugiohSetRaritiesModel> SetRaritiesPriceData { get; set; }

        [JsonProperty(PropertyName = "average")]
        public string Average { get; set; }

        [JsonProperty(PropertyName = "lowest")]
        public string Lowest { get; set; }

        [JsonProperty(PropertyName = "highest")]
        public string Highest { get; set; }

    }

    public class YugiohSetRaritiesModel
    {
        [JsonProperty(PropertyName = "Rare")]
        public string Rare { get; set; }

        [JsonProperty(PropertyName = "Common")]
        public string Common { get; set; }

        [JsonProperty(PropertyName = "Super Rare")]
        public string SuperRare { get; set; }

        [JsonProperty(PropertyName = "Secret Rare")]
        public string SecretRare { get; set; }

        [JsonProperty(PropertyName = "Ultimate Rare")]
        public string UltimateRare { get; set; }

        [JsonProperty(PropertyName = "Ultra Rare")]
        public string UltraRare { get; set; }

        [JsonProperty(PropertyName = "Ghost Rare")]
        public string GhostRare { get; set; }

        [JsonProperty(PropertyName = "Short Print")]
        public string ShortPrint { get; set; }
    }
}
