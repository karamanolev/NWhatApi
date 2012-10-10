using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi.Model
{
    public class MusicInfo
    {
        [JsonProperty("composers")]
        public ArtistReference[] Composers { get; set; }

        [JsonProperty("dj")]
        public ArtistReference[] DJ { get; set; }

        [JsonProperty("artists")]
        public ArtistReference[] Artists { get; set; }

        [JsonProperty("with")]
        public ArtistReference[] With { get; set; }

        [JsonProperty("conductor")]
        public ArtistReference[] Conductor { get; set; }

        [JsonProperty("remixedBy")]
        public ArtistReference[] RemixedBy { get; set; }

        [JsonProperty("producer")]
        public ArtistReference[] Producer { get; set; }

        [JsonIgnore]
        public string JoinedArtists
        {
            get
            {
                if (this.Artists.Length == 1)
                {
                    return this.Artists[0].Name;
                }
                else if (this.Artists.Length > 1)
                {
                    return "Various Artists";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
