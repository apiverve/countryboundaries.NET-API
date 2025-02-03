using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class geometry
{
    [JsonProperty("coordinates")]
    public double[][][][] coordinates { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

}

public class properties
{
    [JsonProperty("name")]
    public string name { get; set; }

}

public class features
{
    [JsonProperty("geometry")]
    public geometry geometry { get; set; }

    [JsonProperty("id")]
    public string id { get; set; }

    [JsonProperty("properties")]
    public properties properties { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

}

public class data
{
    [JsonProperty("features")]
    public features[] features { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

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
