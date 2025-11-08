using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Geometry data
    /// </summary>
    public class Geometry
    {
        [JsonProperty("coordinates")]
        public double[][][][] Coordinates { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
    /// <summary>
    /// Properties data
    /// </summary>
    public class Properties
    {
        [JsonProperty("name")]
        public string Name { get; set; }

    }
    /// <summary>
    /// Features data
    /// </summary>
    public class Features
    {
        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("features")]
        public Features[] Features { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

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
