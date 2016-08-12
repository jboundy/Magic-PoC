using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DAL.Model.Yugioh
{
    public class SetModel
    {
        [JsonProperty]
        public string[] Sets { get; set; }
    }
}
