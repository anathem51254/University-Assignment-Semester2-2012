using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;

namespace BookingManagementPackage
{
    public partial class ModifyBooking : Form
    {
        private GuiController guiController;

        public ModifyBooking()
        {
            InitializeComponent();
        }

        public ModifyBooking(GuiController _guicontroller)
        {
            InitializeComponent();
            guiController = _guicontroller;
        }

        public DialogResult ShowDialog(out int updateMainForm)
        {
            DialogResult dialogResult = base.ShowDialog();

            updateMainForm = guiController.ModifyBookingState;
            return dialogResult;
        }

        private void FillBookingDetailsTxtBox()
        {
            BookingDetailsTxtBox.Text = "";
            for (int i = 1; i <= 7; i++)
            {
                switch (i)
                {
                    case 1:
                        BookingDetailsTxtBox.Text += "Booking Id: ";
                        break;
                    case 2:
                        BookingDetailsTxtBox.Text += "Member Id: ";
                        break;
                    case 3:
                        BookingDetailsTxtBox.Text += "Date Time: ";
                        break;
                    case 4:
                        BookingDetailsTxtBox.Text += "Service Details: ";
                        break;
                    case 5:
                        BookingDetailsTxtBox.Text += "Date Booked: ";
                        break;
                    case 6:
                        BookingDetailsTxtBox.Text += "Status: \t";
                        break;
                    case 7:
                        BookingDetailsTxtBox.Text += "Service Log: ";
                        break;
                }
                BookingDetailsTxtBox.Text += "\t" + guiController.GetBookingDetails("0" + i.ToString()) + "\r\n";
            }
        }

        private void ModifyBooking_Load(object sender, EventArgs e)
        {
            FillBookingDetailsTxtBox();
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            /// array of data in textbox
            string[] txtBoxData = new string[2];

            /// gets the data from the textboxes, ready to process
            txtBoxData[0] = dateTimeTxtBox.Text;
            txtBoxData[1] = serviceDetailsTxtBox.Text;

            string msg = guiController.SaveChangesBtnClick(txtBoxData);
            if (guiController.resetBookingDetails == 1)
            {
                FillBookingDetailsTxtBox();
            }
            MessageBox.Show(msg);   
        }
    }
}
