using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class StudentRequest
    {
        private int studentID;
        private int requestID;
        private string priorityLevel;

        //public field declarations
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public int RequestID 
        { 
            get { return requestID; } 
            set { requestID = value; } 
        }
        public string PriorityLevel
        {
            get { return priorityLevel; }
            set { priorityLevel = value; }
        }

        //constructors
        public StudentRequest() {
            studentID = 0;
            requestID = 0;
            priorityLevel = "";
        }
        public StudentRequest(int _studentID, int _requestID, string _priorityLevel )
        {
            studentID = _studentID;
            requestID = _requestID;
            priorityLevel = _priorityLevel;
        }
    }
}
