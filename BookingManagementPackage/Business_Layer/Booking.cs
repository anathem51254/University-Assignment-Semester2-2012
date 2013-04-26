using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Business_Layer
{
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
