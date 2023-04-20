

namespace Model
{
    public class AliceResponse 
    {
        public ResponseModel response { get; set; }
        public SessionModel session { get; set; }
        public string version { get; set; } = "1.0";
        public int statusCode { get; set; }

        public AliceResponse()
        {
            response = new ResponseModel();
            session = new SessionModel();
        }
    }
}