using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi
{
    public class TorrentGroupInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("musicInfo")]
        public MusicInfo MusicInfo { get; set; }
    }
}
