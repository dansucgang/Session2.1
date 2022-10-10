using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public class Tags
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
