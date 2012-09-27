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
            var data = await client.DownloadTorrent("1507783");
        }

        static void Main(string[] args)
        {
            new Program().Main().Wait();
        }
    }
}
