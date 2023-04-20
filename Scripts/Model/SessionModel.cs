

namespace Model
{
    public class SessionModel 
    {
        public bool @new { get; set; }
        public string session_id { get; set; }
        public int message_id { get; set; }
        public string skill_id { get; set; }
        public string user_id { get; set; }
        public ApplicationModel application { get; set; }

        public SessionModel()
        {
            application = new ApplicationModel();
        }
    }
}