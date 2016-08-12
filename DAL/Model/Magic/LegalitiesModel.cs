using Newtonsoft.Json;

namespace DAL.Model.Magic
{
    public class LegalitiesModel
    {
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }
        [JsonProperty(PropertyName = "legality")]
        public string Legality { get; set; }
    }
}
