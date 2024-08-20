using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("solarNoon")]
    public DateTime solarNoon { get; set; }

    [JsonProperty("sunrise")]
    public DateTime sunrise { get; set; }

    [JsonProperty("sunset")]
    public DateTime sunset { get; set; }

    [JsonProperty("sunriseEnd")]
    public DateTime sunriseEnd { get; set; }

    [JsonProperty("sunsetStart")]
    public DateTime sunsetStart { get; set; }

    [JsonProperty("dawn")]
    public DateTime dawn { get; set; }

    [JsonProperty("dusk")]
    public DateTime dusk { get; set; }

    [JsonProperty("nauticalDawn")]
    public DateTime nauticalDawn { get; set; }

    [JsonProperty("nauticalDusk")]
    public DateTime nauticalDusk { get; set; }

    [JsonProperty("nightEnd")]
    public DateTime nightEnd { get; set; }

    [JsonProperty("night")]
    public DateTime night { get; set; }

    [JsonProperty("goldenHourEnd")]
    public DateTime goldenHourEnd { get; set; }

    [JsonProperty("goldenHour")]
    public DateTime goldenHour { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
