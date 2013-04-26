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
        private BookingManagement bookingManagement;

        public ModifyBooking()
        {
            InitializeComponent();
        }

        public ModifyBooking(BookingManagement _bookingManagement)
        {
            InitializeComponent();
            bookingManagement = _bookingManagement;
        }

        public DialogResult ShowDialog(out int updateMainForm)
        {
            DialogResult dialogResult = base.ShowDialog();

            updateMainForm = bookingManagement.ModifyBookingState;
            return dialogResult;
        }

        private int GuiController(string btnId, Object data)
        {
            return bookingManagement.BusinessLogicController(btnId, data); ;
        }

        private void ModifyBooking_Load(object sender, EventArgs e)
        {
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

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            /// array of data in textbox
            string[] txtBoxData = new string[2];

            /// gets the data from the textboxes, ready to process
            txtBoxData[0] = dateTimeTxtBox.Text;
            txtBoxData[1] = serviceDetailsTxtBox.Text;

            int updateSuccess = GuiController("03", txtBoxData);

            /// Notifies the client of any invalid or missing information
            switch (updateSuccess)
            {
                case 0:
                    MessageBox.Show("Could not update booking!");
                    break;

                case 1:
                    MessageBox.Show("Successfully Updates!!");
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
    }
}
