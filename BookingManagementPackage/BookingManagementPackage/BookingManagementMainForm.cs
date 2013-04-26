using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Business_Layer;

namespace BookingManagementPackage
{
    public partial class BookingManagementMainForm : Form
    {
        private BookingManagement bookingManagement;
        private ModifyBooking modifyBookingForm;
        
        public BookingManagementMainForm()
        {
            InitializeComponent();
            bookingManagement = new BookingManagement();

            bookingIdTxtBox.Text = "b1000001";
        }

        private int GuiController(string btnId, Object data)
        {
            return bookingManagement.BusinessLogicController(btnId, data); ;
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
                   BookingDetailsTxtBox.Text += "\t" + bookingManagement.GetBookingDetail("0" + i.ToString()) + "\r\n";
                }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Object data = (Object)bookingIdTxtBox.Text;

            int bookingFound = GuiController("01", data);

            if (bookingFound == 1)
            {
                MessageBox.Show("Successfully Found!!");
                FillBookingDetailsTxtBox();
            }
            else if (bookingFound == 0)
                MessageBox.Show("Could not find Booking!!");
            else if (bookingFound == -1)
                MessageBox.Show("Booking Id formatted incorrectly!!");
       
            //bookingIdTxtBox.Text = "";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            /// array of data in textbox
            string[] txtBoxData = new string[2];

            /// gets the data from the textboxes, ready to process
            txtBoxData[0] = dateTimeTxtBox.Text;
            txtBoxData[1] = serviceDetailsTxtBox.Text;

            int creationSuccess = GuiController("02", txtBoxData);

            /// Notifies the client of any invalid or missing information
            switch (creationSuccess)
            {
                case 0:
                    MessageBox.Show("Could not create booking!");
                    break;

                case 1:
                    MessageBox.Show("Successfully Created!!");
                    break;

                case 2:
                    MessageBox.Show("The Following are Empty Or have invalid Input:\n\n \t\"Date Time\"\n\t\"Service Details\"");
                    break;

                case 3:
                    MessageBox.Show("The Following are Empty Or have invalid Input:\n\n \t\"Date Time\"");
                    break;

                case 4:
                    MessageBox.Show("The Following are Empty Or have invalid Input:\n\n \t\"Service Details\"");
                    break;

                default:
                    MessageBox.Show("Something Went Wrong! :<");
                    break;
            }
        }

        private void textBtn_Click(object sender, EventArgs e)
        {
            Object data = null;
            int i = GuiController("10", data);

            if (i == 1)
            {
                MessageBox.Show("Done!!");
            }
        }

        private void modifyBookingBtn_Click(object sender, EventArgs e)
        {
            modifyBookingForm = new ModifyBooking(bookingManagement);
            int updateMade = -1;
            modifyBookingForm.ShowDialog(out updateMade);

            if (updateMade == 1)
            {
                BookingDetailsTxtBox.Text = "";
                FillBookingDetailsTxtBox();
            }
        }
    }
}
