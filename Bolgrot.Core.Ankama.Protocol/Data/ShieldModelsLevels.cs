﻿using Newtonsoft.Json;

namespace Bolgrot.Core.Ankama.Protocol.Data
{
    public class ShieldModelsLevels
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("requiredXpLevels")]
        public long[] RequiredXpLevels { get; set; }
    }
}