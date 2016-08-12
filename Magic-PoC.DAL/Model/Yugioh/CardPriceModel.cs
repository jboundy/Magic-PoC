using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class CheckPriceModel
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public List<CardModel> Prices { get; set; }
    }

    public class CardPriceDataModel
    {
        [JsonProperty(PropertyName = "data")]
        public List<CardPriceDataDetailModel> Data { get; set; }
    }

    public class CardPriceDataDetailModel
    {
        [JsonProperty(PropertyName = "listings")]
        public string[] Listings { get; set; }

        [JsonProperty(PropertyName = "prices")]
        public List<CardPriceModel> Prices { get; set; }
    }

    public class CardPriceModel
    {
        [JsonProperty(PropertyName = "high")]
        public string High { get; set; }

        [JsonProperty(PropertyName = "low")]
        public string Low { get; set; }

        [JsonProperty(PropertyName = "average")]
        public string Average { get; set; }

        [JsonProperty(PropertyName = "shift")]
        public string Shift { get; set; }

        [JsonProperty(PropertyName = "shift_3")]
        public string Shift3Days { get; set; }

        [JsonProperty(PropertyName = "shift_7")]
        public string ShiftWeek { get; set; }

        [JsonProperty(PropertyName = "shift_30")]
        public string ShiftMonth { get; set; }

        [JsonProperty(PropertyName = "shift_90")]
        public string Shift90Days { get; set; }

        [JsonProperty(PropertyName = "shift_180")]
        public string ShiftMidYear { get; set; }

        [JsonProperty(PropertyName = "shift_365")]
        public string ShiftYear { get; set; }

        [JsonProperty(PropertyName = "updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
