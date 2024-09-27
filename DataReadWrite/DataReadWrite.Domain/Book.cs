using System.Text.Json.Serialization;

namespace DataReadWrite.Domain
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("pub")]
        public Publisher Publisher { get; set; }
    }

    public class BookWithPublisher
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
        public string PubCity { get; set; }
        public string PubName { get; set; }
    }
}
