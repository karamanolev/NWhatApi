using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi.Model
{
    public class GroupTorrentInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("remastered")]
        public string Remastered { get; set; }

        [JsonProperty("remasterYear")]
        public int RemasterYear { get; set; }

        [JsonProperty("remasterTitle")]
        public string RemasterTitle { get; set; }

        [JsonProperty("remasterRecordLabel")]
        public string RemasterRecordLabel { get; set; }

        [JsonProperty("remasterCatalogueNumber")]
        public string RemasterCatalogueNumber { get; set; }

        [JsonProperty("scene")]
        public bool Scene { get; set; }

        [JsonProperty("hasLog")]
        public bool HasLog { get; set; }

        [JsonProperty("hasCue")]
        public bool HasCue { get; set; }

        [JsonProperty("logScore")]
        public int LogScore { get; set; }

        [JsonProperty("fileCount")]
        public int FileCount { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("seeders")]
        public int Seeders { get; set; }

        [JsonProperty("leechers")]
        public int Leechers { get; set; }

        [JsonProperty("snatched")]
        public int Snatched { get; set; }

        [JsonProperty("freeTorrent")]
        public bool FreeTorrent { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fileList")]
        public string FileList { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("userId")]
        public long UserId { get; set; }
    }
}
