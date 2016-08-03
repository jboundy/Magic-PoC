using Newtonsoft.Json;

namespace Magic_PoC.DAL.Model
{
    public class SetModel
    {
        public const string SetsQuery = "sets/";

        [JsonProperty(PropertyName = "set")]
        public SetItemModel Set { get; set; }
    }

    public class SetItemModel
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "border")]
        public string Border { get; set; }
        [JsonProperty(PropertyName = "mkm_id")]
        public string MkmId { get; set; }
        [JsonProperty(PropertyName = "mkm_name")]
        public string MkmName { get; set; }
        [JsonProperty(PropertyName = "releaseDate")]
        public string ReleaseDate { get; set; }
        [JsonProperty(PropertyName = "booster")]
        public string[] Booster { get; set; }
        [JsonProperty(PropertyName = "gathererCode")]
        public string GathererCode { get; set; }
        [JsonProperty(PropertyName = "magicCardsInfoCode")]
        public string MagicCardsInfoCode { get; set; }
    }
}
