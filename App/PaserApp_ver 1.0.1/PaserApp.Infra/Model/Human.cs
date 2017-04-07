
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaserApp.Infra.Model
{
    public class Human
    {

        // JsonProperty
        //

        [JsonProperty("@Name")]
        public string Name { get; set; }

        [JsonProperty("Age")]
        public int Age { get; set; }
    }
}
