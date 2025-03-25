
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTAModelLibrary
{
    public class Account
    {
        private int id;
        private string accountName;
        private string password;
        private string firstName;
        private string lastName;
        private string email;

        //public field declarations
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email { 
            get { return email; }
            set { email = value; }
        }

        //constructors
        public Account() 
        {
            id = 0;
            accountName = "";
            password = "";
            firstName = "";
            lastName = "";
            email = "";
        }
        public Account(int _id, string _accountName, string _password, string _firstName, string _lastName, string _email)
        {
            id = _id;
            accountName = _accountName;
            password = _password;
            firstName = _firstName;
            lastName = _lastName;
            email = _email;
        }

    }
}
