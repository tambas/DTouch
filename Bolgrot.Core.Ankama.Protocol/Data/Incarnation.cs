﻿using Newtonsoft.Json;

namespace Bolgrot.Core.Ankama.Protocol.Data
{
    public class Incarnation
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("lookMale")]
        public string LookMale { get; set; }

        [JsonProperty("lookFemale")]
        public string LookFemale { get; set; }
    }
}