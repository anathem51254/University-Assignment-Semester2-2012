using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database_Access_Layer;

namespace Business_Layer
{
    public class Customer
    {
        string username;
        string pw;
        string email;
        string fname;
        string lname;
        string dob;
        string gender;
        //............

        private DatabaseController dbController;

        public Customer()
        {
            dbController = new DatabaseController();
            this.username = "";
            this.pw = "";
            this.email = "";
            this.fname = "";
            this.lname = "";
            this.dob = "";
            this.gender = "";
        }

        public Customer(int id, string userName, string PW, string fName, string lName, string DOB, string Gender, string email)
        {
            username = userName;
            pw = PW;
            this.email = email;
            fname = fName;
            lname = lName;
            dob = DOB;
            gender = Gender;
            //................
        }

        public bool createCUSTacc(string userNAME, string pwp, string fName, string lName, string DOB, string Gender, string email)
        {
            return dbController.CreateCustomerAccount(userNAME, pwp, fName, lName, DOB, Gender, email);
        }
        
        public bool checkeCUSTacc(string username)
        {
            return dbController.CheckCustUsername(username);
        }
        
        public bool deleteCUSTacc(string username)
        {
            if (dbController.CheckCustUsername(username) == true)
            {
                throw new ArgumentException();
            }
            return dbController.DeleteCustomerAccount(username);
        }

        public bool changeCUSTacc(string username, string pwp, string fName, string lName, string DOB, string Gender, string email)
        {
            return dbController.ChangeCustomerAccount(username, pwp, fName, lName, DOB, Gender, email);
        }

        public string[] readCustInfo(string username)
        {
            if (dbController.CheckCustUsername(username) == true)
            {
                throw new ArgumentException();
            }
            return dbController.ReadCustInfo(username);

        }
    }
}

