using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;

namespace ARMS
{
    public partial class Search : Form
    {
        string memID;
        string regID;
        string name;
        string gender;
        string phoneNo;
        string dateOfBirth;
        string email;
        string address;

        string temp;
        
        string[] elements;

        public Search()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            memID = txtMemId.Text;

            CustomerDetail cd = new CustomerDetail();
            temp = cd.SearchCustomerDetail(memID);

            if (temp == "NULL")
            {
                txtRegId.Clear();
                txtName.Clear();
                txtGender.Clear();
                txtPhoneNo.Clear();
                txtDateOfBirth.Clear();
                txtEmail.Clear();
                txtAddress.Clear();

                MessageBox.Show("No this member!!!");
            }
            else
            {
                elements = temp.Split(';');
                regID = elements[0];
                name = elements[1];
                gender = elements[2];
                phoneNo = elements[3];
                dateOfBirth = elements[4];
                email = elements[5];
                address = elements[6];

                txtRegId.Text = regID;
                txtName.Text = name;
                txtGender.Text = gender;
                txtPhoneNo.Text = phoneNo;
                txtDateOfBirth.Text = dateOfBirth;
                txtEmail.Text = email;
                txtAddress.Text = address;
                txtReceive.Text = email;
            }

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            memID = txtMemId.Text;
            name = txtName.Text;
            gender = txtGender.Text;
            phoneNo = txtPhoneNo.Text;
            dateOfBirth = txtDateOfBirth.Text;
            email = txtEmail.Text;
            address = txtAddress.Text;
            
            CustomerDetail cd = new CustomerDetail();
            temp = cd.ModifyCustomerDetail(memID, name, gender, phoneNo, dateOfBirth, email, address);

            if (temp == "NULL")
            {
                MessageBox.Show("No this member");

            }
            else
            {
                MessageBox.Show("Modify successful!!!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            memID = txtMemId.Text;

            CustomerDetail cd = new CustomerDetail();
            temp = cd.DeleteCustomerDetail(memID);

            if (temp == "NULL")
            {
                MessageBox.Show("No this member");
            }
            else
            {
                MessageBox.Show("Delete successful!!!");
            }

            txtRegId.Clear();
            txtName.Clear();
            txtGender.Clear();
            txtPhoneNo.Clear();
            txtDateOfBirth.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Email myEmail = new Email();


            if (txtReceive.Text == "")
            {
                MessageBox.Show("No receiver address at moment");
                return;
            }

            if (txtReceive.Text.Contains('@') == false)
            {
                MessageBox.Show("The email is not valid");
                return;
            }
            

            if (txtTopic.Text == "")
            {
                MessageBox.Show("No topic at moment");
                return;
            }

            if (txtContent.Text == "")
            {
                MessageBox.Show("No content at moment");
                return;
            }

            myEmail.SendGEmail(txtReceive.Text, txtTopic.Text, txtContent.Text);

            MessageBox.Show("Send completed !!!");
        }
    }
}
