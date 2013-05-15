using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ARMS
{
    public partial class AdministrationManagementPackage : Form
    {
        private AdminGuiController adminGuiCon = new AdminGuiController();

        public AdministrationManagementPackage()
        {
            InitializeComponent();
        }
        #region Delete account
        private void Srbtn_CheckedChanged(object sender, EventArgs e)
        {
            emaillabel.Visible = false;
            textBoxemail.Visible = false;
            textBoxuname.Text = String.Empty;
            textBoxfname.Text = String.Empty;
            textBoxlname.Text = String.Empty;
            textBoxpw.Text = String.Empty;
            textBoxdob.Text = String.Empty;
            textBoxgender.Text = String.Empty;
            textBoxID.Text = String.Empty;
            buttonLoad.Visible = true;

            textBoxuname.Enabled = true;
            textBoxfname.Enabled = false;
            textBoxlname.Enabled = false;
            textBoxpw.Enabled = false;
            textBoxdob.Enabled = false;
            textBoxgender.Enabled = false;
            textBoxemail.Enabled = false;
        }

        private void rbtnCD_CheckedChanged(object sender, EventArgs e)
        {
            emaillabel.Visible = true;
            textBoxemail.Visible = true;
            textBoxuname.Text = String.Empty;
            textBoxfname.Text = String.Empty;
            textBoxlname.Text = String.Empty;
            textBoxpw.Text = String.Empty;
            textBoxdob.Text = String.Empty;
            textBoxgender.Text = String.Empty;
            textBoxID.Text = String.Empty;
            buttonLoad.Visible = true;
            textBoxemail.Text = String.Empty;

            textBoxuname.Enabled = true;
            textBoxfname.Enabled = false;
            textBoxlname.Enabled = false;
            textBoxpw.Enabled = false;
            textBoxdob.Enabled = false;
            textBoxgender.Enabled = false;
            textBoxemail.Enabled = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string uname = textBoxuname.Text.ToString();
            if (Crbtn.Checked && uname != "")
            {
                if (adminGuiCon.checkCusername(uname) == false)
                {
                    string[] Cinfo = new string[7];
                    Cinfo = adminGuiCon.readCinfo(uname);
                    textBoxuname.Text = Cinfo[1];
                    textBoxID.Text = Cinfo[0];
                    textBoxfname.Text = Cinfo[2];
                    textBoxlname.Text = Cinfo[3];
                    textBoxdob.Text = Cinfo[4];
                    textBoxgender.Text = Cinfo[5];
                    textBoxemail.Text = Cinfo[6];
                    textBoxpw.Text = Cinfo[7];
                    buttonLoad.Visible = false;
                    textBoxuname.Enabled = false;
                    buttondelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sorry, please check if you entered the right username.","Error");
                }
            }

            if (Srbtn.Checked && uname != "")
            {
                if (adminGuiCon.checkSusername(uname) == false)
                {
                    string[] Sinfo = new string[7];
                    Sinfo = adminGuiCon.readSinfo(uname);
                    textBoxuname.Text = Sinfo[1];
                    textBoxID.Text = Sinfo[0];
                    textBoxfname.Text = Sinfo[2];
                    textBoxlname.Text = Sinfo[3];
                    textBoxdob.Text = Sinfo[4];
                    textBoxgender.Text = Sinfo[5];
                    textBoxpw.Text = Sinfo[6];
                    buttonLoad.Visible = false;
                    textBoxuname.Enabled = false;
                    buttondelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sorry, please check if you entered the right username.", "Error");
                }
            }

            if (uname == "")
            {
                MessageBox.Show("Please enter an username!", "Error"); 
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxuname.Text = String.Empty;
            textBoxfname.Text = String.Empty;
            textBoxlname.Text = String.Empty;
            textBoxpw.Text = String.Empty;
            textBoxdob.Text = String.Empty;
            textBoxgender.Text = String.Empty;
            textBoxID.Text = String.Empty;
            buttonLoad.Visible = true;
            textBoxemail.Text = String.Empty;

            textBoxuname.Enabled = true;
            textBoxfname.Enabled = false;
            textBoxlname.Enabled = false;
            textBoxpw.Enabled = false;
            textBoxdob.Enabled = false;
            textBoxgender.Enabled = false;
            textBoxemail.Enabled = false;
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            string uname = textBoxuname.Text.ToString();
            if (Crbtn.Checked)
            {
                adminGuiCon.deleteCInfo(uname);
                MessageBox.Show("The account has been successfully deleted!", "Deleted");
                textBoxuname.Text = String.Empty;
                textBoxfname.Text = String.Empty;
                textBoxlname.Text = String.Empty;
                textBoxpw.Text = String.Empty;
                textBoxdob.Text = String.Empty;
                textBoxgender.Text = String.Empty;
                textBoxID.Text = String.Empty;
                buttonLoad.Visible = true;
                textBoxemail.Text = String.Empty;

                textBoxuname.Enabled = true;
                textBoxfname.Enabled = false;
                textBoxlname.Enabled = false;
                textBoxpw.Enabled = false;
                textBoxdob.Enabled = false;
                textBoxgender.Enabled = false;
                textBoxemail.Enabled = false;
            }
            else if (Srbtn.Checked)
            {
                adminGuiCon.deleteSInfo(uname);
                MessageBox.Show("The account has been successfully deleted!", "Deleted");
                textBoxuname.Text = String.Empty;
                textBoxfname.Text = String.Empty;
                textBoxlname.Text = String.Empty;
                textBoxpw.Text = String.Empty;
                textBoxdob.Text = String.Empty;
                textBoxgender.Text = String.Empty;
                textBoxID.Text = String.Empty;
                buttonLoad.Visible = true;
                textBoxemail.Text = String.Empty;

                textBoxuname.Enabled = true;
                textBoxfname.Enabled = false;
                textBoxlname.Enabled = false;
                textBoxpw.Enabled = false;
                textBoxdob.Enabled = false;
                textBoxgender.Enabled = false;
                textBoxemail.Enabled = false;
            }
        }
        #endregion

        #region Modify account information
        private void rbtnCM_CheckedChanged(object sender, EventArgs e)
        {
            labelemailM.Visible = true;
            tbEmailM.Visible = true;
            tbUNM.Text = String.Empty;
            tbFNM.Text = String.Empty;
            tbLNM.Text = String.Empty;
            tbPWM.Text = String.Empty;
            tbDOBM.Text = String.Empty;
            tbgenderM.Text = String.Empty;
            tbIDM.Text = String.Empty;
            btnLoadM.Visible = true;
            tbEmailM.Text = String.Empty;

            tbUNM.Enabled = true;
            tbFNM.Enabled = false;
            tbLNM.Enabled = false;
            tbPWM.Enabled = false;
            tbDOBM.Enabled = false;
            tbgenderM.Enabled = false;
            tbEmailM.Enabled = false;
            enablebtn.Visible = false;
            buttonmodify.Enabled = false;
        }

        private void rbtnSM_CheckedChanged(object sender, EventArgs e)
        {
            labelemailM.Visible = false;
            tbEmailM.Visible = false;
            tbUNM.Text = String.Empty;
            tbFNM.Text = String.Empty;
            tbLNM.Text = String.Empty;
            tbPWM.Text = String.Empty;
            tbDOBM.Text = String.Empty;
            tbgenderM.Text = String.Empty;
            tbIDM.Text = String.Empty;
            btnLoadM.Visible = true;

            tbUNM.Enabled = true;
            tbFNM.Enabled = false;
            tbLNM.Enabled = false;
            tbPWM.Enabled = false;
            tbDOBM.Enabled = false;
            tbgenderM.Enabled = false;
            tbEmailM.Enabled = false;
            enablebtn.Visible = false;
            buttonmodify.Enabled = false;
        }

        private void btnLoadM_Click(object sender, EventArgs e)
        {
            string uname = tbUNM.Text.ToString();

            if (uname == "")
            {
                MessageBox.Show("Please enter an username!", "Error");
            }

            if (rbtnCM.Checked && uname != "")
            {
                if (adminGuiCon.checkCusername(uname) == false)
                {
                    string[] Cinfo = new string[7];
                    Cinfo = adminGuiCon.readCinfo(uname);
                    tbUNM.Text = Cinfo[1];
                    tbIDM.Text = Cinfo[0];
                    tbFNM.Text = Cinfo[2];
                    tbLNM.Text = Cinfo[3];
                    tbDOBM.Text = Cinfo[4];
                    tbgenderM.Text = Cinfo[5];
                    tbEmailM.Text = Cinfo[6];
                    tbPWM.Text = Cinfo[7];
                    btnLoadM.Visible = false;
                    tbUNM.Enabled = false;
                    enablebtn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sorry, please check if you entered the right username.", "Error");
                }
            }

            if (rbtnSM.Checked && uname != "")
            {
                if (adminGuiCon.checkSusername(uname) == false)
                {
                    string[] Sinfo = new string[7];
                    Sinfo = adminGuiCon.readSinfo(uname);
                    tbUNM.Text = Sinfo[1];
                    tbIDM.Text = Sinfo[0];
                    tbFNM.Text = Sinfo[2];
                    tbLNM.Text = Sinfo[3];
                    tbDOBM.Text = Sinfo[4];
                    tbgenderM.Text = Sinfo[5];
                    tbPWM.Text = Sinfo[6];
                    btnLoadM.Visible = false;
                    tbUNM.Enabled = false;
                    enablebtn.Visible = true;
                }
                else
                {
                    MessageBox.Show("Sorry, please check if you entered the right username.", "Error");
                }
            }

        }

        private void btnCancelM_Click(object sender, EventArgs e)
        {
            tbUNM.Text = String.Empty;
            tbFNM.Text = String.Empty;
            tbLNM.Text = String.Empty;
            tbPWM.Text = String.Empty;
            tbDOBM.Text = String.Empty;
            tbgenderM.Text = String.Empty;
            tbIDM.Text = String.Empty;
            btnLoadM.Visible = true;
            tbEmailM.Text = String.Empty;

            tbUNM.Enabled = true;
            tbFNM.Enabled = false;
            tbLNM.Enabled = false;
            tbPWM.Enabled = false;
            tbDOBM.Enabled = false;
            tbgenderM.Enabled = false;
            tbEmailM.Enabled = false;
            enablebtn.Visible = false;
            buttonmodify.Enabled = false;
        }

        private void buttonmodify_Click(object sender, EventArgs e)
        {
            string uname = tbUNM.Text.ToString();
            string fname = tbFNM.Text.ToString();
            string lname = tbLNM.Text.ToString();
            string pw = tbPWM.Text.ToString();
            string DOB = tbDOBM.Text.ToString();
            string gender = tbgenderM.Text.ToString();


            if (rbtnCM.Checked)
            {
                string email = tbEmailM.Text.ToString();
                if (pw == "" || fname == "" || lname == "" || DOB == "" || gender == "" || email == "")
                {
                    MessageBox.Show("Please fill up all the information!", "Error");
                }
                else
                {
                    adminGuiCon.modifyCInfo(uname, pw, fname, lname, DOB, gender, email);
                    MessageBox.Show("The account information has been successfully updated!", "Update");
                    tbUNM.Text = String.Empty;
                    tbFNM.Text = String.Empty;
                    tbLNM.Text = String.Empty;
                    tbPWM.Text = String.Empty;
                    tbDOBM.Text = String.Empty;
                    tbgenderM.Text = String.Empty;
                    tbIDM.Text = String.Empty;
                    btnLoadM.Visible = true;
                    tbEmailM.Text = String.Empty;

                    tbUNM.Enabled = true;
                    tbFNM.Enabled = false;
                    tbLNM.Enabled = false;
                    tbPWM.Enabled = false;
                    tbDOBM.Enabled = false;
                    tbgenderM.Enabled = false;
                    tbEmailM.Enabled = false;
                    enablebtn.Visible = false;
                    buttonmodify.Enabled = false;
                }
            }
            else if (rbtnSM.Checked)
            {
                if (pw == "" || fname == "" || lname == "" || DOB == "" || gender == "")
                {
                    MessageBox.Show("Please fill up all the information!", "Error");
                }
                else
                {
                    adminGuiCon.modifySInfo(uname, fname, lname, pw, DOB, gender);
                    MessageBox.Show("The account information has been successfully updated!", "Update");
                    tbUNM.Text = String.Empty;
                    tbFNM.Text = String.Empty;
                    tbLNM.Text = String.Empty;
                    tbPWM.Text = String.Empty;
                    tbDOBM.Text = String.Empty;
                    tbgenderM.Text = String.Empty;
                    tbIDM.Text = String.Empty;
                    btnLoadM.Visible = true;
                    tbEmailM.Text = String.Empty;

                    tbUNM.Enabled = true;
                    tbFNM.Enabled = false;
                    tbLNM.Enabled = false;
                    tbPWM.Enabled = false;
                    tbDOBM.Enabled = false;
                    tbgenderM.Enabled = false;
                    tbEmailM.Enabled = false;
                    enablebtn.Visible = false;
                    buttonmodify.Enabled = false;
                }
            }
        }

        private void enablebtn_Click(object sender, EventArgs e)
        {
            enablebtn.Visible = false;
            buttonmodify.Enabled = true;

            tbUNM.Enabled = false;
            tbFNM.Enabled = true;
            tbLNM.Enabled = true;
            tbPWM.Enabled = true;
            tbDOBM.Enabled = true;
            tbgenderM.Enabled = true;
            tbEmailM.Enabled = true;
        }
        #endregion

        #region Create Account
        private void rbtnCC_CheckedChanged(object sender, EventArgs e)
        {
            labelemailC.Visible = true;
            tbemailC.Visible = true;
            tbUNC.Text = String.Empty;
            tbFNC.Text = String.Empty;
            tbLNC.Text = String.Empty;
            tbPWC.Text = String.Empty;
            tbD.Text = String.Empty;
            tbM.Text = String.Empty;
            tbY.Text = String.Empty;

            buttonCheck.Visible = true;
            tbemailC.Text = String.Empty;
        }

        private void rbtnSC_CheckedChanged(object sender, EventArgs e)
        {
            labelemailC.Visible = false;
            tbemailC.Visible = false;
            tbUNC.Text = String.Empty;
            tbFNC.Text = String.Empty;
            tbLNC.Text = String.Empty;
            tbPWC.Text = String.Empty;
            tbD.Text = String.Empty;
            tbM.Text = String.Empty;
            tbY.Text = String.Empty;
            buttonCheck.Visible = true;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string uname = tbUNC.Text.ToString();
            if (rbtnCC.Checked && uname != "")
            {
                if (adminGuiCon.checkCusername(uname) == true)
                {
                    MessageBox.Show("This username is available.", "Valid");
                    buttonCreate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sorry, this username is used. Please try another one!", "Invalid");
                    buttonCreate.Enabled = false;
                }
            }

            if (rbtnSC.Checked && uname != "")
            {
                if (adminGuiCon.checkSusername(uname) == true)
                {
                    MessageBox.Show("This username is available.", "Valid");
                    buttonCreate.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sorry, this username is used. Please try another one!", "Error");
                    buttonCreate.Enabled = false;
                }
            }

            if (uname == "")
            {
                MessageBox.Show("Please enter an username!", "Error");
            }
        }

        private void buttonCancelC_Click(object sender, EventArgs e)
        {
            tbUNC.Text = String.Empty;
            tbFNC.Text = String.Empty;
            tbLNC.Text = String.Empty;
            tbPWC.Text = String.Empty;
            tbD.Text = String.Empty;
            tbM.Text = String.Empty;
            tbY.Text = String.Empty;
            buttonCreate.Enabled = false;
            tbemailC.Text = String.Empty;

        }       

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string uname = tbUNC.Text.ToString();
            string fname = tbFNC.Text.ToString();
            string lname = tbLNC.Text.ToString();
            string pw = tbPWC.Text.ToString();
            string DOB = tbD.Text.ToString() + "/" + tbM.Text.ToString() + "/" + tbY.Text.ToString();
            string gender = "";

                if (rbtnMale.Checked)
                {
                    gender = "Male";
                }
                else if (rbtnFemale.Checked)
                {
                    gender = "Female";
                }

            if (rbtnCC.Checked)
            {
                if (adminGuiCon.checkCusername(uname) == false)
                {
                    MessageBox.Show("This username is invalid, please change to another one!", "Error");
                }

                else
                {
                    string email = tbemailC.Text.ToString();
                    if (pw == "" || fname == "" || lname == "" || DOB == "" || gender == "" || email == "" || adminGuiCon.checkCusername(uname) == false)
                    {
                        MessageBox.Show("Please fill up all the information!", "Error");
                    }
                    else
                    {
                        adminGuiCon.createAccountC(uname, pw, fname, lname, DOB, gender, email);
                        MessageBox.Show("The Customer Account has been created successfully!", "Created");
                        tbUNC.Text = String.Empty;
                        tbFNC.Text = String.Empty;
                        tbLNC.Text = String.Empty;
                        tbPWC.Text = String.Empty;
                        tbD.Text = String.Empty;
                        tbM.Text = String.Empty;
                        tbY.Text = String.Empty;
                        buttonCreate.Enabled = false;
                        tbemailC.Text = String.Empty;
                    }
                }
            }
            else if (rbtnSC.Checked)
            {
                if (adminGuiCon.checkSusername(uname) == false)
                {
                    MessageBox.Show("This username is invalid, please change to another one!", "Error");
                }
                else
                {
                    if (pw == "" || fname == "" || lname == "" || DOB == "" || gender == "")
                    {
                        MessageBox.Show("Please fill up all the information!", "Error");
                    }
                    else
                    {
                        adminGuiCon.createAccountS(uname, fname, lname, pw, DOB, gender);
                        MessageBox.Show("The Staff Account has been created successfully!", "Created");
                        tbUNC.Text = String.Empty;
                        tbFNC.Text = String.Empty;
                        tbLNC.Text = String.Empty;
                        tbPWC.Text = String.Empty;
                        tbD.Text = String.Empty;
                        tbM.Text = String.Empty;
                        tbY.Text = String.Empty;
                        buttonCreate.Enabled = false;
                        tbemailC.Text = String.Empty;
                    }
                }
            }
        }
        #endregion
    }
}
