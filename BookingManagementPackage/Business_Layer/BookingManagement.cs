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
        private DatabaseController dbController;

        private Booking bookingObj;

        public BookingManagement()
        {
            dbController = new DatabaseController();          
        }

        /// <summary>
        /// Processes the requests from the GUIController in the BookingManagementPackage
        /// </summary>
        /// <param name="btnId">Request Id</param>
        /// <param name="data">Information needed to complete request</param>
        /// <returns></returns>
        public int BusinessLogicController(int btnId, Object data)
        {
            try
            {
                switch (btnId)
                {
                    case 1:
                        return ProcessFindBooking(data);
                    case 2:
                        return ProcessCreateBooking(data);
                    case 3:
                        return ProcessModifyBooking(data);
                    case 4:
                        return ProcessDeleteBooking(data);
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

        /// <summary>
        /// Processes the finding of a booking
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Processes the creation of a booking
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int ProcessCreateBooking(Object data)
        {
            string[] newBooking = (string[])data;

            /// Check booking detail textbox's and make sure they have data in them
            /// and print out which boxes need data
            /// "MM'/'dd'/'yyyy hh':'mm tt"

            Match m = Regex.Match(newBooking[0], @"(?n:^(?=\d)((?<month>(0?[13578])|1[02]|(0?[469]|11)(?!.31)|0?2(?(.29)(?=.29.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00))|(?!.3[01])))(?<sep>[-./])(?<day>0?[1-9]|[12]\d|3[01])\k<sep>(?<year>(1[6-9]|[2-9]\d)\d{2})(?(?=\x20\d)\x20|$))?(?<time>((0?[1-9]|1[012])(:[0-5]\d){0,2}(?i:\x20[AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$)", RegexOptions.None);
            if (m.Success && newBooking[1] != "")
            {
                return CreateBooking(data);
            }
            else if (newBooking[0] == "" && newBooking[1] == "")
                return 2;
            else if (newBooking[0] == "")
                return 3;
            else if (newBooking[1] == "")
                return 4;
            else
                return 5;
        }

        /// <summary>
        /// Processes the modification of a booking
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int ProcessModifyBooking(Object data)
        {
            string[] newBooking = (string[])data;

            /// Check booking detail textbox's and make sure they have data in them
            /// and print out which boxes need data

            Match m = Regex.Match(newBooking[0], @"(?n:^(?=\d)((?<month>(0?[13578])|1[02]|(0?[469]|11)(?!.31)|0?2(?(.29)(?=.29.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00))|(?!.3[01])))(?<sep>[-./])(?<day>0?[1-9]|[12]\d|3[01])\k<sep>(?<year>(1[6-9]|[2-9]\d)\d{2})(?(?=\x20\d)\x20|$))?(?<time>((0?[1-9]|1[012])(:[0-5]\d){0,2}(?i:\x20[AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$)", RegexOptions.None);
            if (m.Success && newBooking[1] != "")
            {
                string[] tempData = new string[3];
                tempData[0] = newBooking[0];
                tempData[1] = newBooking[1];
                tempData[2] = bookingObj.bookingId;

                return ModifyBooking(tempData);
            }
            else if (newBooking[0] == "" && newBooking[1] == "")
                return 2;
            else if (newBooking[0] == "")
                return 3;
            else if (newBooking[1] == "")
                return 4;
            else
                return 5;
        }

        /// <summary>
        /// For Testing
        /// </summary>
        /// <param name="data"></param>
        /// <param name="test"></param>
        /// <returns></returns>
        public int ProcessModifyBooking(Object data, int test)
        {
            string[] newBooking = (string[])data;

            /// Check booking detail textbox's and make sure they have data in them
            /// and print out which boxes need data

            Match m = Regex.Match(newBooking[0], @"(?n:^(?=\d)((?<month>(0?[13578])|1[02]|(0?[469]|11)(?!.31)|0?2(?(.29)(?=.29.((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|(16|[2468][048]|[3579][26])00))|(?!.3[01])))(?<sep>[-./])(?<day>0?[1-9]|[12]\d|3[01])\k<sep>(?<year>(1[6-9]|[2-9]\d)\d{2})(?(?=\x20\d)\x20|$))?(?<time>((0?[1-9]|1[012])(:[0-5]\d){0,2}(?i:\x20[AP]M))|([01]\d|2[0-3])(:[0-5]\d){1,2})?$)", RegexOptions.None);
            if (m.Success && newBooking[1] != "")
            {
                string[] tempData = new string[3];
                tempData[0] = newBooking[0];
                tempData[1] = newBooking[1];
                tempData[2] = bookingObj.bookingId;

                return ModifyBooking(tempData);
            }
            else if (newBooking[0] == "" && newBooking[1] == "")
                return 2;
            else if (newBooking[0] == "")
                return 3;
            else if (newBooking[1] == "")
                return 4;
            else
                return 5;
        }

        /// <summary>
        /// Processes the deletion of a booking
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int ProcessDeleteBooking(Object data)
        {
            string bookingId = data.ToString();
            Match m = Regex.Match(bookingId, @"(\bb\d{7}$)", RegexOptions.None);
            if (m.Success)
            {
                return DeleteBooking(bookingId);
            }
            else
            {
                Debug.WriteLine("ERROR[INPUTFIELD]\n");
                return -1;
            }
        }

        /// Refactoring Idea:
        /// Combine FindBooking, CreateBooking, ModifyBooking, DeleteBooking
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
                ArrayList BookingDetailsData = (ArrayList)dbController.HandleRequest("01", data);
                if (BookingDetailsData != null)
                {
                    BuildBookingObject(BookingDetailsData);
                    return 1;
                }
                else
                    return 0;
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
        /// Find an existing booking in the database
        /// </summary>
        /// <param name="data">the booking id</param>
        /// <returns>booking details</returns>
        private int DeleteBooking(string data)
        {
            try
            {
                ArrayList BookingDetailsData = (ArrayList)dbController.HandleRequest("04", data);
                if (BookingDetailsData != null)
                {
                    BuildBookingObject(BookingDetailsData);
                    return 1;
                }
                else
                    return 0;
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
    }
}
