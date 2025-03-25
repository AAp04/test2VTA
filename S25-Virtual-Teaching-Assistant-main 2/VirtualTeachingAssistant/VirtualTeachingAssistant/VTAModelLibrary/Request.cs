namespace VTAModelLibrary
{
    public class Request
    {
        private int id;
        private string body;
        private string type;
        private DateTime dateCreated;
        private string status;
        private int chatID;
        private int courseID;

        //public field declarations
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int ChatID
        {
            get { return chatID; }
            set { chatID = value; }
        }
        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        //constructors
        public Request()
        {
            id = 0;
            body = "";
            type = "";
            dateCreated = DateTime.Now;
            status = "";
            chatID = 0;
            courseID = 0;
        }
        public Request(int requestID, string requestBody, string requestType, DateTime creationDate, string requestStatus, int chatId, int courseId)
        {
            id = requestID;
            body = requestBody;
            type = requestType;
            dateCreated = creationDate;
            status = requestStatus;
            chatID = chatId;
            courseID = courseId;
        }

    }
}
