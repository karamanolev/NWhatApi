using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi
{
    public class ArtistReference
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
