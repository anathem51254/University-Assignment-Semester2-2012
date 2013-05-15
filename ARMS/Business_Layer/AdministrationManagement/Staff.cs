using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database_Access_Layer;

namespace Business_Layer
{
   public class Staff
   {
       string username;
       string f_name;
       string l_name;
       string gender;
       string DOB;
       string password;

       private DatabaseController dbController;

       public Staff()
       {
           dbController = new DatabaseController();
           this.username = "";
           this.f_name = "";
           this.l_name = "";
           this.gender = "";
           this.DOB = "";
           this.password = "";
       }

       public Staff(string username, string f_name, string l_name, string password, string DOB, string gender)
       {
           this.username = username;
           this.f_name = f_name;
           this.l_name = l_name;
           this.gender = gender;
           this.DOB = DOB;
           this.password = password;

       }

       public bool createSTAFFacc(string username, string f_name, string l_name, string password, string DOB, string gender)
       {
           return dbController.CreateStaffAccount(username, f_name, l_name, password, DOB, gender);
       }

       public bool deleteSTAFFacc(string username)
       {
           if (dbController.CheckStaffUsername(username) == true)
           {
               throw new ArgumentException();
           }
           return dbController.DeleteStaffAccount(username);
       }

       public bool changeSTAFFacc(string username, string f_name, string l_name, string password, string DOB, string gender)
       {
           return dbController.ChangeStaffAccount(username, f_name, l_name, password, DOB, gender);
       }

       public bool checkSTAFFacc(string username)
       {
           return dbController.CheckStaffUsername(username);
       }

       public string[] readSaffInfo(string username)
       {
           if (dbController.CheckStaffUsername(username) == true)
           {
               throw new ArgumentException();
           }
           return dbController.readStaffInfo(username);

       }
    }
}
