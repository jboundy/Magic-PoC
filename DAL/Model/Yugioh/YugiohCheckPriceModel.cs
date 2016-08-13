using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class YugiohCheckPriceModel
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<YugiohCardModel> Prices { get; set; }
    }
}
