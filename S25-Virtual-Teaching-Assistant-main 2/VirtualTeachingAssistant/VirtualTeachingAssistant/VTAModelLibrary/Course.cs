using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class Course
    {
        private int id;
        private string title;
        private string subject;
        private string semester;
        private int year;

        //public field declarations
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public int Year { 
            get { return year; }
            set { year = value; }
        }

        //constructors 
        public Course() { 
            id = 0;
            title = string.Empty;
            subject = string.Empty;
            semester = string.Empty;
            year = 0;
        }
        public Course (int _id, string _title, string _subject, string _semester, int _year)
        {
            id = _id;
            title = _title;
            subject = _subject;
            semester = _semester;
            year = _year;
        }
    }
}
