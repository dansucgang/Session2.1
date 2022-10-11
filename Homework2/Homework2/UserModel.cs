using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    public class UserModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photoUrls")]
        public string[] PhotoUrls { get; set; }

        [JsonProperty("tags")]
        public Category[] Tags { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
