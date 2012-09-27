using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi
{
    public class GetNotificationsResponse
    {
        [JsonProperty("currentPages")]
        public int CurrentPage { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("numNew")]
        public int New { get; set; }

        [JsonProperty("results")]
        public TorrentInfo[] Results { get; set; }
    }
}
