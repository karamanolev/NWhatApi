﻿using Newtonsoft.Json;
using System;
using System.Linq;

namespace NWhatApi
{
    public class TorrentInfo
    {
        [JsonProperty("torrentId")]
        public string TorrentId { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("groupCategoryId")]
        public string GroupCategoryId { get; set; }

        [JsonProperty("torrentTags")]
        public string TorrentTags { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("fileCount")]
        public int FileCount { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("scene")]
        public bool Scene { get; set; }

        [JsonProperty("groupYear")]
        public int GroupYear { get; set; }

        [JsonProperty("remasterYear")]
        public int RemasterYear { get; set; }

        [JsonProperty("remasterTitle")]
        public string RemasterTitle { get; set; }

        [JsonProperty("snatched")]
        public int Snatched { get; set; }

        [JsonProperty("seeders")]
        public int Seeders { get; set; }

        [JsonProperty("leechers")]
        public int Leechers { get; set; }

        [JsonProperty("notificationTime")]
        public string NotificationTime { get; set; }

        [JsonProperty("hasLog")]
        public bool HasLog { get; set; }

        [JsonProperty("hasCue")]
        public bool HasCue { get; set; }

        [JsonProperty("logScore")]
        public int LogScore { get; set; }

        [JsonProperty("freeTorrent")]
        public bool FreeTorrent { get; set; }

        [JsonProperty("logInDb")]
        public bool LogInDb { get; set; }

        [JsonProperty("unread")]
        public bool Unread { get; set; }
    }
}
