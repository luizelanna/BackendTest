using BookService.Converter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BookService.Models
{
    public class Specifications
    {
        [JsonProperty("Originally published")]
        public DateTime OriginallyPublished { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }

        [JsonProperty("Page count")]
        public int PageCount { get; set; }

        [JsonProperty("Illustrator")]
        [JsonConverter(typeof(CustomConverter<string>))]
        public ICollection<string> Illustrators { get; set; }

        [JsonProperty("Genres")]
        [JsonConverter(typeof(CustomConverter<string>))]
        public ICollection<string> Genres { get; set; }
    }
}