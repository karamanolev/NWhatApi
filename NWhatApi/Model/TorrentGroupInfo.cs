using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi.Model
{
    /// <summary>
    /// Information about a torrent group.
    /// </summary>
    public class TorrentGroupInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("wikiBody")]
        public string WikiBody { get; set; }

        [JsonProperty("wikiImage")]
        public string WikiImage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("recordLabel")]
        public string RecordLabel { get; set; }

        [JsonProperty("catalogueNumber")]
        public string CatalogueNumber { get; set; }

        [JsonProperty("releaseType")]
        public int ReleaseType { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("vanityHouse")]
        public bool VanityHouse { get; set; }

        [JsonProperty("musicInfo")]
        public MusicInfo MusicInfo { get; set; }
    }
}
