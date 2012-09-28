using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi
{
    public class MusicInfo
    {
        [JsonProperty("composers")]
        public ArtistReference[] Composers { get; set; }

        [JsonProperty("dj")]
        public ArtistReference[] DJ { get; set; }

        [JsonProperty("artists")]
        public ArtistReference[] Artists { get; set; }

        [JsonIgnore]
        public string JoinedArtists
        {
            get
            {
                return string.Join(", ", this.Artists.Select(a => a.Name));
            }
        }
    }
}
