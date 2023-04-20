using System.Collections.Generic;


namespace Model
{
    public class NluModel
    {
        public List<string> tokens { get; set; }
        public List<object> entities { get; set; }
        public IntentsModel intents { get; set; }
    }
}