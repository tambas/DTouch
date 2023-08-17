﻿using Newtonsoft.Json;

namespace Bolgrot.Core.Ankama.Protocol.Data
{
    public class Mounts
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }

        [JsonProperty("look")]
        public string Look { get; set; }
    }
}