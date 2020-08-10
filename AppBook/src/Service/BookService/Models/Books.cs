using Newtonsoft.Json;

namespace BookService.Models
{
    public class Books
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("specifications")]
        public Specifications Specifications { get; set; }
    }
}
