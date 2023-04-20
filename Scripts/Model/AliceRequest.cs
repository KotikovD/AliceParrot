

namespace Model
{
    public class AliceRequest 
    {
        public MetaModel meta { get; set; }
        public RequestModel request { get; set; }
        public SessionModel session { get; set; }
        public string version { get; set; }
    }
}