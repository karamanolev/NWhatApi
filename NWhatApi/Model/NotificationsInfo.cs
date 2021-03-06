﻿using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi.Model
{
    public class NotificationsInfo
    {
        [JsonProperty("currentPages")]
        public int CurrentPage { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("numNew")]
        public int New { get; set; }

        [JsonProperty("results")]
        public NotificationTorrentInfo[] Results { get; set; }
    }
}
