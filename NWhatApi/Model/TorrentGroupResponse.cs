using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi.Model
{
    public class TorrentGroupResponse
    {
        [JsonProperty("group")]
        public TorrentGroupInfo Group { get; set; }

        [JsonProperty("torrents")]
        public GroupTorrentInfo[] Torrents { get; set; }

        public GroupTorrentInfo GetGroupTorrentInfoById(long torrentId)
        {
            return this.Torrents.Where(t => t.Id == torrentId).FirstOrDefault();
        }

        public string GetTorrentFileName(GroupTorrentInfo torrentInfo)
        {
            return this.Group.MusicInfo.JoinedArtists + " - " + this.Group.Name + " - " + this.Group.Year + " (" + torrentInfo.Media + " - " + torrentInfo.Format + " - " + torrentInfo.Encoding + ").torrent";
        }
    }
}
