using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Database_Access_Layer;

namespace Business_Layer
{
    public class BookingManagement
    {
        private DatabaseController dbController = new DatabaseController();

        private Booking bookingObj;

        private int modifyBookingState = 0;

        /// <summary>
        /// Processes the requests from the GUIController in the BookingManagementPackage
        /// </summary>
        /// <param name="btnId">Request Id</param>
        /// <param name="data">Information needed to complete request</param>
        /// <returns></returns>
        public int BusinessLogicController(string btnId, Object data)
        {
            try
            {
                switch (btnId)
                {
                    case "01":
                        return ProcessFindBooking(data);
                    case "02":
                        return ProcessCreateBooking(data);
                    case "03":
                        return ProcessModifyBooking(data);
                    case "10":
                        // test
                        dbController.HandleRequest("10", (string)data);
                        return 1;
                    default:
                        return 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + "\n");
                return 0;
            }
        }

        public int ProcessFindBooking(Object data)
        {
            string bookingId = data.ToString();
            Match m = Regex.Match(bookingId, @"(\bb\d{7}$)", RegexOptions.None);
            if (m.Success)
            {
                return FindBooking(bookingId);
            }
            else
            {
                Debug.WriteLine("ERROR[INPUTFIELD]\n");
                return -1;
            }
        }

        public int ProcessCreateBooking(Object data)
        {
            string[] newBooking = (string[])data;

            /// Check booking detail textbox's and make sure they have data in them
            /// and print out which boxes need data

            if (newBooking[0] == "" && newBooking[1] == "")
                return 2;
            else if (newBooking[0] == "")
                return 3;
            else if (newBooking[1] == "")
                return 4;

            return CreateBooking(data);
        }

        public int ProcessModifyBooking(Object data)
        {
            string[] newBooking = (string[])data;

            /// Check booking detail textbox's and make sure they have data in them
            /// and print out which boxes need data

            if (newBooking[0] == "" && newBooking[1] == "")
                return 2;
            else if (newBooking[0] == "")
                return 3;
            else if (newBooking[1] == "")
                return 4;

            string[] tempData = new string[3];
            tempData[0] = newBooking[0];
            tempData[1] = newBooking[1];
            tempData[2] = bookingObj.bookingId;

            return ModifyBooking(tempData);
        }

        public int ProcessDeleteBooking(Object data)
        {
            string bookingId = data.ToString();
            Match m = Regex.Match(bookingId, @"(\bb\d{7}$)", RegexOptions.None);
            if (m.Success)
            {
                return FindBooking(bookingId);
            }
            else
            {
                Debug.WriteLine("ERROR[INPUTFIELD]\n");
                return -1;
            }
        }

        /// Refactoring Idea:
        /// Combine FindBooking, CreateBooking, ModifyBooking
        /// using flags to switch to the required operation
        
        /// <summary>
        /// Find an existing booking in the database
        /// </summary>
        /// <param name="data">the booking id</param>
        /// <returns>booking details</returns>
        private int FindBooking(string data)
        {
            try
            {
                if (data.Length == 8)
                {
                    ArrayList BookingDetailsData = (ArrayList)dbController.HandleRequest("01", data);
                    if (BookingDetailsData != null)
                    {
                        BuildBookingObject(BookingDetailsData);
                        return 1;
                    }
                    else
                        return 0;
                }
                else
                    return -1;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message + "\n");
                return 0;
            }
        }
        
        /// <summary>
        /// Insert a new booking into the database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private int CreateBooking(Object data)
        {
            try
            {
                ArrayList BookingDetailsData = (ArrayList)dbController.HandleRequest("02", data);
                if (BookingDetailsData != null)
                {
                    BuildBookingObject(BookingDetailsData);
                    return 1;
                }
                else
                {
                    Debug.WriteLine("ERROR[CREATEBOOKING]");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + "\n");
                return 0;
            } 
        }

        /// <summary>
        /// Update an existing booking into the database
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private int ModifyBooking(Object data)
        {
            try
            {
                ArrayList BookingDetailsData = (ArrayList)dbController.HandleRequest("03", data);
                if (BookingDetailsData != null)
                {
                    BuildBookingObject(BookingDetailsData);
                    modifyBookingState = 1;
                    return 1;
                }
                else
                {
                    Debug.WriteLine("ERROR[MODIFYBOOKING]");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + "\n");
                return 0;
            }
        }
        
        /// <summary>
        /// Build a new Booking Object from data retrieved from database
        /// </summary>
        /// <param name="BookingDetailsData"></param>
        private void BuildBookingObject(ArrayList BookingDetailsData)
        {
            bookingObj = new Booking(BookingDetailsData);
            Debug.WriteLine("BuildBookingObject(): Booking Id: " + bookingObj.bookingId + "\n");
            Debug.WriteLine("BuildBookingObject(): Member Id: " + bookingObj.memberId + "\n");
            Debug.WriteLine("BuildBookingObject(): Date Time: " + bookingObj.dateTime + "\n");
            Debug.WriteLine("BuildBookingObject(): Service Details: " + bookingObj.serviceDetails + "\n");
            Debug.WriteLine("BuildBookingObject(): Date Booked: " + bookingObj.dateBooked + "\n");
            Debug.WriteLine("BuildBookingObject(): Status: " + bookingObj.status + "\n");
            Debug.WriteLine("BuildBookingObject(): Service Log: " + bookingObj.serviceLog + "\n");
        }

        /// <summary>
        /// Pass individual details about the booking currently being managed to the GUIController
        /// </summary>
        /// <param name="op">id for the booking detail requested</param>
        /// <returns></returns>
        public string GetBookingDetail(string op)
        {
            switch (op)
            {
                case "01":
                    return bookingObj.bookingId;
                case "02":
                    return bookingObj.memberId;
                case "03":
                    return bookingObj.dateTime;
                case "04":
                    return bookingObj.serviceDetails;
                case "05":
                    return bookingObj.dateBooked;
                case "06":
                    return bookingObj.status;
                case "07":
                    return bookingObj.serviceLog;
                default:
                    Debug.WriteLine("Invalid Op!\n");
                    return "";
            }
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

    /// <summary>
    /// Booking class to store details about a booking
    /// </summary>
    public class Booking
    {
        private string BookingId;
        private string MemberId;
        private string DateTime;
        private string ServiceDetails;
        private string DateBooked;
        private string Status;
        //temp holder for key pair data structure
        private string ServiceLog;

        public Booking()
        {
            BookingId = "";
            MemberId = "";
            DateTime = "";
            ServiceDetails = "";
            DateBooked = "";
            Status = "";
            ServiceLog = "";
        }

        public Booking(ArrayList BookingDetailsData)
        {
            BookingId = BookingDetailsData[0].ToString();
            MemberId = BookingDetailsData[1].ToString();
            DateTime = BookingDetailsData[2].ToString();
            ServiceDetails = BookingDetailsData[3].ToString();
            DateBooked = BookingDetailsData[4].ToString();
            Status = BookingDetailsData[5].ToString();
            ServiceLog = BookingDetailsData[6].ToString();
        }

        public string bookingId
        {
            get
            {
                return BookingId;
            }
            set
            {
                BookingId = bookingId;
            }
        }

        public string memberId
        {
            get
            {
                return MemberId;
            }
            set
            {
                MemberId = memberId;
            }
        }

        public string dateTime
        {
            get
            {
                return DateTime;
            }
            set
            {
                DateTime = dateTime;
            }
        }

        public string serviceDetails
        {
            get
            {
                return ServiceDetails;
            }
            set
            {
                ServiceDetails = serviceDetails;
            }
        }

        public string dateBooked
        {
            get
            {
                return DateBooked;
            }
            set
            {
                DateBooked = dateBooked;
            }
        }

        public string status
        {
            get
            {
                return Status;
            }
            set
            {
                Status = status;
            }
        }

        public string serviceLog
        {
            get
            {
                return ServiceLog;
            }
            set
            {
                ServiceLog = serviceLog;
            }
        }

    }
}
