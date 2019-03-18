using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GithubAPI.Models
{
    public class Search
    {
        [JsonProperty("total_count")]
        public int total_count { get; set; }
        [JsonProperty("incomplete_results")]
        public bool incomplete_results { get; set; }
        [JsonProperty("items")]
        public List<Repository> items { get; set; }
    }
}