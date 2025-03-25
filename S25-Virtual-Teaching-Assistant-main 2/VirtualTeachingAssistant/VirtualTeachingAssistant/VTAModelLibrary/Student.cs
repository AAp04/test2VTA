using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class Student
    {
        private int id;
        private string year;
        private int accountID;

        //public field declarations
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        //constructors 
        public Student()
        {
            id = 0;
            year = "";
            accountID = 0;
        }
        public Student(int _id, string _year, int _accountID)
        {
            id = _id;
            year = _year;
            accountID = _accountID;
        }
    }
}
