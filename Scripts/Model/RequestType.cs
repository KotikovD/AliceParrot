using System.Text.Json.Serialization;

namespace Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequestType 
    {
        SimpleUtterance,
        ButtonPressed
    }
}