using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
