using System;
using System.Linq;
using NWhatApi;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        async Task Main()
        {
            WhatClient client = new WhatClient();
            await client.Login("karamanolev", "foo");
            var nots = await client.GetNotifications();
            var group1 = await client.GetTorrentGroupInfo(nots.Results[0].GroupId);

            GroupTorrentInfo groupInfo = group1.Torrents.Where(t => t.Id == nots.Results[0].TorrentId).First();
        }

        static void Main(string[] args)
        {
            new Program().Main().Wait();
        }
    }
}
