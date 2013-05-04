using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using Business_Layer;

namespace ARMS
{
    public partial class Registration : Form
    {
        string regID;
        string memID;
        string name;
        string gender;
        string phoneNo;
        string dateOfBirth;
        string email;
        string address;

        public Registration()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string insertResult = "";
            regID = txtRegId.Text;
            memID = txtMemberId.Text;
            name = txtName.Text;
            gender = txtGender.Text;
            phoneNo = txtPhoneNo.Text;
            dateOfBirth = txtDateOfBirth.Text;
            email = txtEmail.Text;
            address = txtAddress.Text;
            
            CustomerDetail cd = new CustomerDetail();
            insertResult = cd.InsertCustomerDetail(regID, memID, name, gender, phoneNo, dateOfBirth, email, address);

            if (insertResult == "Repeat")
            {
                MessageBox.Show("The Register ID exsits, please enter another one.");
            }
            else if (insertResult == "Invalid formatting")
            {
                MessageBox.Show("Registration ID is invalid");
            }
            else
            {
                MessageBox.Show("Insert Sucessfully");

                txtMemberId.Text = "Mem" + regID.Substring(3);
                memID = txtMemberId.Text;

                cd.InsertMemID(regID, memID);

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }
    }
}
