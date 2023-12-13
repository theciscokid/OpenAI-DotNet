using System.Text.Json.Serialization;

namespace OpenAI
{
    public sealed class ImageFile
    {
        [JsonConstructor]
        public ImageFile(string id)
        {
            Id = id;
        }

        [JsonInclude]
        [JsonPropertyName("file_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Id { get; private set; }
    }
}