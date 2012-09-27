using System;
using System.Linq;
using Newtonsoft.Json;

namespace NWhatApi
{
    class WhatResponse<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("response")]
        public T Response { get; set; }
    }
}
