using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business_Layer;

namespace ARMS
{
    public class AdminGuiController
    {

        Customer cust = new Customer();
        Staff staff = new Staff();

        //create account
        public bool createAccountC(string username, string pw, string fName, string lName, string DOB, string gender, string email)
        {
            return cust.createCUSTacc(username, pw, fName, lName, DOB, gender, email);
        }

        public bool createAccountS(string username, string f_name, string l_name, string password, string DOB, string gender)
        {
            return staff.createSTAFFacc(username, f_name, l_name, password, DOB, gender);
        }

        //change account info
        public bool modifyCInfo(string username, string pw, string fName, string lName, string DOB, string gender, string email)
        {
            return cust.changeCUSTacc(username, pw, fName, lName, DOB, gender, email);
        }

        public bool modifySInfo(string username, string f_name, string l_name, string password, string DOB, string gender)
        {
            return staff.changeSTAFFacc(username, f_name, l_name, password, DOB, gender);
        }

        //delete account
        public bool deleteCInfo(string username)
        {
            return cust.deleteCUSTacc(username);
        }

        public bool deleteSInfo(string username)
        {
            return staff.deleteSTAFFacc(username);
        }

        //check username
        public bool checkCusername(string username)
        {
            return cust.checkeCUSTacc(username);
        }

        public bool checkSusername(string username)
        {
            return staff.checkSTAFFacc(username);
        }

        //read account info
        public string[] readCinfo(string username)
        {
            return cust.readCustInfo(username);
        }

        public string[] readSinfo(string username)
        {
            return staff.readSaffInfo(username);
        }
    }
}
