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

namespace ARMS
{
    public partial class BookingManagementMainForm : Form
    {
        private GuiController guiController;
        private BookingManagement bookingManagement;
        private ModifyBooking modifyBookingForm;
        
        public BookingManagementMainForm()
        {
            InitializeComponent();
            guiController = new GuiController();
            bookingManagement = new BookingManagement();

            DateTimePicker.Format = DateTimePickerFormat.Custom;
            DateTimePicker.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";

            bookingIdTxtBox.Text = "b1000001";
        }

        private int GuiController(int btnId, Object data)
        {
            return bookingManagement.BusinessLogicController(btnId, data);
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
                           bookingIdTxtBox.Text = guiController.GetBookingDetails("0" + i.ToString());
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Object data = (Object)bookingIdTxtBox.Text;

            string msg = guiController.SearchBtnClick(data);
            if (guiController.resetBookingDetails == 1)
            {
                FillBookingDetailsTxtBox();
            }
            MessageBox.Show(msg);

            //bookingIdTxtBox.Text = "";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            /// array of data in textbox
            string[] txtBoxData = new string[2];

            /// gets the data from the textboxes, ready to process
            txtBoxData[0] = DateTimePicker.Value.ToString();
            txtBoxData[1] = ServiceDetailsComboBox.Text;

            string msg = guiController.CreateBtnClick(txtBoxData);
            if (guiController.resetBookingDetails == 1)
            {
                FillBookingDetailsTxtBox();
            }
            MessageBox.Show(msg);    
        }

        private void modifyBookingBtn_Click(object sender, EventArgs e)
        {
            modifyBookingForm = new ModifyBooking(guiController);
            int updateMade = -1;
            modifyBookingForm.ShowDialog(out updateMade);
            if (updateMade == 1)
            {
                FillBookingDetailsTxtBox();
            }
        }

        private void deleteBookingBtn_Click(object sender, EventArgs e)
        {
            Object data = (Object)bookingIdTxtBox.Text;

            string msg = guiController.DeleteBookingBtnClick(data);
            if (guiController.resetBookingDetails == 1)
            {
                BookingDetailsTxtBox.Text = "";
                guiController._ClearBookingDetails();    
            }
            MessageBox.Show(msg);  
            
        }

        private void autoCreateBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int n = rnd.Next(0, 9);
                string[] bookData = new string[2];
                //RandomDay();
                bookData[0] = guiController.RandomDateTime();
                bookData[1] = guiController.GetBookingType(n);
                string msg = guiController.CreateBtnClick(bookData);
            }
        }
    }
}
