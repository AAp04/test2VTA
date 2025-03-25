using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class CourseFile
    {
        private int id;
        private int courseID;
        private string fileLink;
        private string assignmentCategory;

        //public field declarations
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        public string FileLink
        {
            get { return fileLink; }
            set { fileLink = value; }
        }
        public string AssignmentCategory
        {
            get { return assignmentCategory; }
            set { assignmentCategory = value; }
        }

        //constructors
        public CourseFile() {
            id = 0;
            courseID = 0;
            fileLink = "";
            assignmentCategory = "";
        }
        public CourseFile(int _fileID, int _courseID, string _fileLink, string _assignmentCategory)
        {
            id = _fileID;
            courseID = _courseID;
            fileLink = _fileLink;
            assignmentCategory = _assignmentCategory;
        }

    }
}
