using System.Text.Json.Serialization;

namespace Model
{
    public class RequestModel 
    {
        public string command { get; set; }
        public string original_utterance { get; set; }
        public NluModel nlu { get; set; }
        public MarkupModel markup { get; set; }
        public RequestType type { get; set; }
        
    }
}