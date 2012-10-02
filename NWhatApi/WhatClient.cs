using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NWhatApi.Model;
using Newtonsoft.Json;

namespace NWhatApi
{
    public class WhatClient
    {
        private const string TorrentsUri = "https://what.cd/torrents.php";
        private const string LoginUri = "https://what.cd/login.php";
        private const string ApiUri = "https://what.cd/ajax.php";
        private static readonly TimeSpan Interval = TimeSpan.FromSeconds(2);

        private JsonSerializer serializer;
        private HttpClient client;
        private DateTime lastRequest = DateTime.MinValue;

        public WhatClient()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.AllowAutoRedirect = false;
            this.client = new HttpClient(clientHandler, true);
            this.serializer = new JsonSerializer();
        }

        private async Task ObserveCallInterval()
        {
            if (DateTime.Now.Subtract(this.lastRequest) < Interval)
            {
                await Task.Delay(Interval - DateTime.Now.Subtract(this.lastRequest));
            }
            this.lastRequest = DateTime.Now;
        }

        private async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            await this.ObserveCallInterval();
            return await this.client.PostAsync(requestUri, content);
        }

        private async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            await this.ObserveCallInterval();
            return await this.client.GetAsync(requestUri);
        }

        public async Task Login(string username, string password)
        {
            FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"username", username},
                {"password", password}
            });
            HttpResponseMessage response = await this.PostAsync(LoginUri, content);
            if (response.StatusCode != HttpStatusCode.Found)
            {
                throw new WhatAuthenticationException();
            }
        }

        public async Task<HttpResponseMessage> GetHttpResponse(string baseUri, Dictionary<string, string> parms)
        {
            StringBuilder queryString = new StringBuilder();
            queryString.Append(baseUri);
            if (parms.Count > 0)
            {
                queryString.Append("?");
                bool appendAmp = false;
                foreach (var parm in parms)
                {
                    queryString.Append(appendAmp ? "&" : "");
                    appendAmp = true;
                    queryString.Append(parm.Key);
                    queryString.Append("=");
                    queryString.Append(Uri.EscapeDataString(parm.Value));
                }
            }
            return await this.GetAsync(queryString.ToString());
        }

        private async Task<T> GetJson<T>(Dictionary<string, string> parms)
        {
            HttpResponseMessage response = await this.GetHttpResponse(ApiUri, parms);
            if (response.StatusCode == HttpStatusCode.Found)
            {
                throw new WhatAuthenticationException("Call login before making API calls.");
            }
            response.EnsureSuccessStatusCode();
            using (Stream responseStream = await response.Content.ReadAsStreamAsync())
            {
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    using (JsonReader jsonReader = new JsonTextReader(reader))
                    {
                        WhatResponse<T> responseData = this.serializer.Deserialize<WhatResponse<T>>(jsonReader);
                        if (responseData.Status != "success")
                        {
                            throw new WhatException(responseData.Status);
                        }
                        return responseData.Response;
                    }
                }
            }
        }

        public async Task<NotificationsInfo> GetNotifications(int page = 1)
        {
            return await this.GetJson<NotificationsInfo>(new Dictionary<string, string>
            {
                {"action", "notifications"},
                {"page", page.ToString()}
            });
        }

        public async Task<TorrentGroupResponse> GetTorrentGroupInfo(long groupId)
        {
            return await this.GetJson<TorrentGroupResponse>(new Dictionary<string, string>
            {
                {"action", "torrentgroup"},
                {"id", groupId.ToString()}
            });
        }

        public async Task<byte[]> DownloadTorrent(long torrentId)
        {
            HttpResponseMessage response = await this.GetHttpResponse(TorrentsUri, new Dictionary<string, string>
            {
                {"action", "download"},
                {"id", torrentId.ToString()}
            });
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
