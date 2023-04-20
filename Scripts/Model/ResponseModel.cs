

namespace Model
{
    public class ResponseModel 
    {
        public string text { get; set; }
        public string tts { get; set; }
        public bool end_session { get; set; }
        public ButtonModel[] buttons { get; set; }
    }
}