using System;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.IO;

namespace NWhatApi.Model
{
    /// <summary>
    /// A wrapper for a torrent group - contains the group info and the group torrents.
    /// </summary>
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
            int year = torrentInfo.RemasterYear != 0 ? torrentInfo.RemasterYear : this.Group.Year;
            string suggestedName = this.Group.MusicInfo.JoinedArtists + " - " + this.Group.Name + " - " + year + " (" + torrentInfo.Media + " - " + torrentInfo.Format + " - " + torrentInfo.Encoding + ").torrent";
            StringBuilder finalName = new StringBuilder();
            char[] invalidChars = Path.GetInvalidFileNameChars();
            foreach (char c in suggestedName)
            {
                if (!invalidChars.Contains(c))
                {
                    finalName.Append(c);
                }
            }
            return finalName.ToString();
        }
    }
}
