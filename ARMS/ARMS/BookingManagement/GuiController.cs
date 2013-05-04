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

namespace ARMS
{
    public class GuiController
    {
        private BookingManagement bookingManagement;

        private int ResetBookingDetails = 0;
        private int ClearBookingDetails = 0;
        private int modifyBookingState = 0;

        private string[] bookingTypes = new string[10];

        public GuiController()
        {
            bookingManagement = new BookingManagement();

            bookingTypes[0] = "General Service";
            bookingTypes[1] = "Oil Change";
            bookingTypes[2] = "Tire Change";
            bookingTypes[3] = "Wheel Alignment";
            bookingTypes[4] = "Stereo Install";
            bookingTypes[5] = "Glass Replacement";
            bookingTypes[6] = "Light Replacement";
            bookingTypes[7] = "Battery Replacement";
            bookingTypes[8] = "Lock Change";
            bookingTypes[9] = "Spark Plug Replacement";
        }

        private int GuiControlHandler(int btnId, Object data)
        {
            return bookingManagement.BusinessLogicController(btnId, data); ;
        }

        public string SearchBtnClick(Object data)
        {
            int bookingFound = GuiControlHandler(1, data);

            if (bookingFound == 1)
            {
                ResetBookingDetails = 1;
                return "Successfully Found!!";
            }
            else if (bookingFound == 0)
                return "Could not find Booking!!";
            else if (bookingFound == -1)
                return "Booking Id formatted incorrectly!!";
            else
                return "Something went wrong :\\";
        }

        public string CreateBtnClick(Object data)
        {
            int creationSuccess = GuiControlHandler(2, data);

            /// Notifies the client of any invalid or missing information
            switch (creationSuccess)
            {
                case 0:
                    return "Could not create booking!";
                case 1:
                    ResetBookingDetails = 1;
                    return "Successfully Created!!";
                case 2:
                    return "The Following are Empty Or have invalid Input:\n\n \t\"Date Time\"\n\t\"Service Details\"";
                case 3:
                    return "The Following are Empty Or have invalid Input:\n\n \t\"Date Time\"";
                case 4:
                    return "The Following are Empty Or have invalid Input:\n\n \t\"Service Details\"";
                default:
                    return "Something Went Wrong! :<";
            }
        }

        public string SaveChangesBtnClick(Object data)
        {
            int updateSuccess = GuiControlHandler(3, data);

            /// Notifies the client of any invalid or missing information
            switch (updateSuccess)
            {
                case 0:
                    return "Could not update booking!";
                case 1:
                    ResetBookingDetails = 1;
                    modifyBookingState = 1;
                    return "Successfully Updates!!";
                case 2:
                    return "The Following are Empty Or have invalid Input:\n\n \t\"Date Time\"\n\t\"Service Details\"";
                case 3:
                    return "The Following are Empty Or have invalid Input:\n\n \t\"Date Time\"";
                case 4:
                    return "The Following are Empty Or have invalid Input:\n\n \t\"Service Details\"";
                default:
                    return "Something Went Wrong! :<";
            }
        }

        public string DeleteBookingBtnClick(Object data)
        {
            int bookingFound = GuiControlHandler(4, data);

            if (bookingFound == 1)
                return "Could not Delete Booking!!";
            else if (bookingFound == 0)
            {
                ResetBookingDetails = 1;
                return "Booking Deleted Successfully!!";
            }
            else if (bookingFound == -1)
                return"Booking Id formatted incorrectly!!";
            else
                return "Something Went Wrong! :<";
        }

        public string GetBookingDetails(string detailId)
        {
            ResetBookingDetails = 0;
            return bookingManagement.GetBookingDetail(detailId);
        }

        public void _ClearBookingDetails()
        {
            ClearBookingDetails = 0;
        }

        public string GetBookingType(int i)
        {
            return bookingTypes[i];
        }

        public string RandomDateTime()
        {
            Random rnd = new Random();

            if (rnd.Next(2) == 1)
            {
                // AM

                int day = rnd.Next(31);
                int month = rnd.Next(1, 12);
                int year = 2013;
                int hour = rnd.Next(7, 12);
                int minute = 30;

                string dateTime = day.ToString() + "/" + month.ToString() + "/" + year.ToString() + " " + hour.ToString() + ":" + minute.ToString() + " AM";

                return dateTime;
            }
            else
            {
                // PM

                int day = rnd.Next(31);
                int month = rnd.Next(12);
                int year = 2013;
                int hour = rnd.Next(1, 6);
                int minute = 30;

                string dateTime = day.ToString() + "/" + month.ToString() + "/" + year.ToString() + " " + hour.ToString() + ":" + minute.ToString() + " PM";

                return dateTime;
            }
        }

        public int resetBookingDetails
        {
            get { return ResetBookingDetails; }
        }

        public int clearBookingDetails
        {
            get { return ClearBookingDetails; }
        }
       
        /// <summary>
        /// Property used for updating booking information
        /// </summary>
        public int ModifyBookingState
        {
            get
            {
                return modifyBookingState;
            }
        }

    }
}
