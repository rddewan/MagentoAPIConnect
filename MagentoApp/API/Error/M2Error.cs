using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoApp.API.Error
{
    class M2Error
    {
        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("trace")]
        public string trace { get; set; }
    }
}
