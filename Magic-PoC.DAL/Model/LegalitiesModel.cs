using Newtonsoft.Json;

namespace Magic_PoC.DAL.Model
{
    public class LegalitiesModel
    {
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }
        [JsonProperty(PropertyName = "legality")]
        public string Legality { get; set; }
    }
}
