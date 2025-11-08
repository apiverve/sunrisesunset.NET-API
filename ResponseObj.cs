using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("solarNoon")]
        public string SolarNoon { get; set; }

        [JsonProperty("sunrise")]
        public string Sunrise { get; set; }

        [JsonProperty("sunset")]
        public string Sunset { get; set; }

        [JsonProperty("sunriseEnd")]
        public string SunriseEnd { get; set; }

        [JsonProperty("sunsetStart")]
        public string SunsetStart { get; set; }

        [JsonProperty("dawn")]
        public string Dawn { get; set; }

        [JsonProperty("dusk")]
        public string Dusk { get; set; }

        [JsonProperty("nauticalDawn")]
        public string NauticalDawn { get; set; }

        [JsonProperty("nauticalDusk")]
        public string NauticalDusk { get; set; }

        [JsonProperty("nightEnd")]
        public string NightEnd { get; set; }

        [JsonProperty("night")]
        public string Night { get; set; }

        [JsonProperty("goldenHourEnd")]
        public string GoldenHourEnd { get; set; }

        [JsonProperty("goldenHour")]
        public string GoldenHour { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
