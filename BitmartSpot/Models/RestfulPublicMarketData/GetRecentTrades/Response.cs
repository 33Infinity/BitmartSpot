﻿using Newtonsoft.Json;

namespace BitmartApiClient.Models.RestfulPublicMarketData.GetRecentTrades {
    public class Response : Model {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
