using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace TestBusiness_Layer
{
    [TestFixture] 
    public class TestFixtureFindBooking
    {
        BookingManagement bookingManagement;

        [SetUp]
        public void TestBookingManagementSetup()
        {
            bookingManagement = new BookingManagement();
        }

        #region Test Methods
        /// <summary>
        /// Find a booking in the database
        /// </summary>
        [Test]
        public void Find_Booking_Test_1()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("b1000002");
        }

        /// <summary>
        /// Find a Booking not in the database
        /// </summary>
        [Test]
        public void Find_Booking_Test_2()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("b9999999");
        }

        /// <summary>
        /// Test booking Id correct length
        /// </summary>
        [Test]
        public void Find_Booking_Test_3()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("adsjklasjdlkja");
        }

        /// <summary>
        /// Test booking Id correct format ( 1 letter followed by 7 digits )
        /// </summary>
        [Test]
        public void Find_Booking_Test_4()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("z9191zzz");
        }

        #endregion
    }

    [TestFixture]
    public class TestFixtureCreateBooking
    {
        BookingManagement bookingManagement;

        [SetUp]
        public void TestBookingManagementSetup()
        {
            bookingManagement = new BookingManagement();
        }

        #region Test Methods
        /// <summary>
        /// Test creation of a booking with correct information
        /// As well as testing it is valid information (not fully implemented)
        /// </summary>
        [Test]
        public void Create_Booking_Test_1()
        {
            string[] str = new string[2];
            str[0] = "25/5/2013 1:30 PM";
            str[1] = "General Service";

            bookingManagement.ProcessCreateBooking(str);
        }

        /// <summary>
        /// Test creation of a booking with some information blank
        /// </summary>
        [Test]
        public void Create_Booking_Test_2()
        {
            string[] str = new string[2];
            str[0] = "";
            str[1] = "General Service";

            bookingManagement.ProcessCreateBooking(str);
        }

        /// <summary>
        /// Test creation of a booking with some information blank
        /// </summary>
        [Test]
        public void Create_Booking_Test_3()
        {
            string[] str = new string[2];
            str[0] = "25/5/2013 1:30 PM";
            str[1] = "";

            bookingManagement.ProcessCreateBooking(str);
        }

        /// <summary>
        /// Test creation of a booking with all information blank
        /// </summary>
        [Test]
        public void Create_Booking_Test_4()
        {
            string[] str = new string[2];
            str[0] = "";
            str[1] = "";

            bookingManagement.ProcessCreateBooking(str);
        }

        /// <summary>
        /// Test the information is the the correct format
        /// Not yet inplemented
        /// </summary>
        [Test]
        [Ignore("Ignore: Not Implemented")]
        public void Create_Booking_Test_5()
        {
            string[] str = new string[2];
            str[0] = "";
            str[1] = "";

            bookingManagement.ProcessCreateBooking(str);
        }
        #endregion
    }

    [TestFixture]
    public class TestFixtureModifyBooking
    {
        BookingManagement bookingManagement;
        string[] bookingTypes;
        Random rnd;

        [SetUp]
        public void TestBookingManagementSetup()
        {
            bookingManagement = new BookingManagement();
            rnd = new Random();
            bookingTypes = new string[10];
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

        #region Test Methods
        /// <summary>
        /// Test modification of a booking with correct information
        /// </summary>
        [Test]
        public void Modify_Booking_Test_1()
        {
            string[] str = new string[3];
            str[0] = RandomDateTime();
            str[1] = GetBookingType(rnd.Next(0, 9));
            str[2] = "b1000002";

            bookingManagement.ProcessModifyBooking(str, 1);
        }

        /// <summary>
        /// Test modification of a booking with some information blank
        /// </summary>
        [Test]
        public void Modify_Booking_Test_2()
        {
            string[] str = new string[3];
            str[0] = "";
            str[1] = GetBookingType(rnd.Next(0, 9));
            str[2] = "b1000002";

            bookingManagement.ProcessModifyBooking(str, 1);
        }

        /// <summary>
        /// Test modifcation of a booking with some information blank
        /// </summary>
        [Test]
        public void Modify_Booking_Test_3()
        {
            string[] str = new string[3];
            str[0] = RandomDateTime();
            str[1] = "";
            str[2] = "b1000002";

            bookingManagement.ProcessModifyBooking(str, 1);
        }

        /// <summary>
        /// Test modify of a booking with all information blank
        /// </summary>
        [Test]
        public void Modify_Booking_Test_4()
        {
            string[] str = new string[3];
            str[0] = "";
            str[1] = "";
            str[2] = "b1000002";

            bookingManagement.ProcessModifyBooking(str, 1);
        }

        /// <summary>
        /// Test the information is the the correct format
        /// Not Implemented
        /// </summary>
        [Test]
        [Ignore("Ignore: Not Implemented")]
        public void Modify_Booking_Test_5()
        {
            string[] str = new string[3];
            str[0] = RandomDateTime();
            str[1] = GetBookingType(rnd.Next(0, 9));
            str[2] = "";

            bookingManagement.ProcessModifyBooking(str, 1);
        }
        #endregion

        #region helpers
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
        #endregion
    }

    [TestFixture]
    public class TestFixtureDeleteBooking
    {
        BookingManagement bookingManagement;

        [SetUp]
        public void TestBookingManagementSetup()
        {
            bookingManagement = new BookingManagement();
        }

        #region Test Methods
        /// <summary>
        /// Delete a booking in the database
        /// </summary>
        [Test]
        public void Delete_Booking_Test_1()
        {
            string bookingId = "b1000005";
            bookingManagement.ProcessDeleteBooking(bookingId);
        }

        /// <summary>
        /// Delete a booking not in the database
        /// </summary>
        [Test]
        public void Delete_Booking_Test_2()
        {
            string bookingId = "b1000200";
            bookingManagement.ProcessDeleteBooking(bookingId);
        }

        /// <summary>
        /// Test booking id is correct length
        /// </summary>
        [Test]
        public void Delete_Booking_Test_3()
        {
            string bookingId = "ahjldasldkjalskjdlkjsalkdj";
            bookingManagement.ProcessDeleteBooking(bookingId);
        }

        /// <summary>
        /// Test booking Id correct format ( 1 letter followed by 7 digits )
        /// </summary>
        [Test]
        public void Delete_Booking_Test_4()
        {
            string bookingId = "z9191zzz";
            bookingManagement.ProcessDeleteBooking(bookingId);
        }
        #endregion
    }
}
