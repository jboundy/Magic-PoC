using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class YugiohSetModel
    {
        [JsonProperty]
        public string[] Sets { get; set; }
    }
}
