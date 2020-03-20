using Newtonsoft.Json;

namespace NovodApp.Model
{
    public class Item
    {
        [JsonProperty("country")]
        public string country;

        [JsonProperty("cases")]
        public string cases;

        [JsonProperty("todayCases")]
        public string todayCases;

        [JsonProperty("deaths")]
        public string deaths;

        [JsonProperty("recovered")]
        public string recovered;

        [JsonProperty("active")]
        public string active;

        [JsonProperty("critical")]
        public string critical;



    }
}
