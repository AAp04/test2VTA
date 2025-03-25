using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class Professor
    {
        private int id;
        private int year;
        private int accountID;

        //public field declarations
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        //constructors 
        public Professor()
        {
            id = 0;
            year = DateTime.Now.Year;
            accountID = 0;
        }
        public Professor(int _id, int _year, int _accountID)
        {
            id = _id;
            year = _year;
            accountID = _accountID;
        }
    }
}
