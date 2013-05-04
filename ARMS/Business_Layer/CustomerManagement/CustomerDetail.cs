using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Database_Access_Layer;

namespace Business_Layer
{
    public class CustomerDetail
    {
        public string InsertCustomerDetail(string regID, string memID, string name, string gender, string phoneNo, string dateOfBirth, string email, string address)
        {
            bool temp;
            string insertResult = "";

            try
            {
                if (regID.Substring(0, 3) == "Reg")
                {
                    DatabaseController db = new DatabaseController();
                    temp = db.ReadDatabase(regID);

                    if (temp)
                    {
                        insertResult = "Repeat";
                    }
                    else
                    {
                        db.InsertCustomerDetail(regID, memID, name, gender, phoneNo, dateOfBirth, email, address);
                        insertResult = "Valid";
                    }
                }
                else
                {
                    insertResult = "Invalid formatting";                  
                }
            }
            catch
            {
                throw new ArgumentException();
            }

            return insertResult;
        }

        public void InsertMemID(string insertRegID, string insertMemID)
        {
            try
            {
                DatabaseController db = new DatabaseController();
                db.InsertMemID(insertRegID, insertMemID);
            }
            catch
            {
                throw new ArgumentException();
            }
          
        }

        public string SearchCustomerDetail(string memberID)
        {
            string temp;

            try
            {
                DatabaseController db = new DatabaseController();
                temp = db.SearchCustomerDetail(memberID);
            }
            catch
            {
                throw new ArgumentException();
            }

            return temp;
        }

        public string ModifyCustomerDetail(string memID, string name, string gender, string phoneNo, string dateOfBirth, string email, string address)
        {
            string temp;

            try
            {
                DatabaseController db = new DatabaseController();
                temp = db.ModifyCustomerDetail(memID, name, gender, phoneNo, dateOfBirth, email, address);
            }
            catch
            {
                throw new ArgumentException();
            }

            return temp;
           
        }

        public string DeleteCustomerDetail(string memID)
        {
            string temp;
            try
            {
                DatabaseController db = new DatabaseController();
                temp = db.DeleteCustomerDetail(memID);
            }
            catch
            {
                throw new ArgumentException();
            }

            return temp;
          
        }
    }
}
