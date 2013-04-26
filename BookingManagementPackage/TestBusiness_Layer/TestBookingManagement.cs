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
            // if 1 is returned then the booking was found.
            int bookingFound = bookingManagement.ProcessFindBooking("b1000002");
            
            //if (bookingFound == 1)
            //for (int i = 1; i <= 7; i++)
            //{
            //    Console.Out.WriteLine(bookingManagement.GetBookingDetail("0" + i.ToString()) + "\n");
            //}
            //else
            //    Console.Out.WriteLine(bookingFound.ToString() + ": Booking was not found.");
        }

        /// <summary>
        /// Find a Booking not in the database
        /// </summary>
        [Test]
        public void Find_Booking_Test_2()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("b9999999");
            //if (bookingFound == 1)
            //    for (int i = 1; i <= 6; i++)
            //        Console.Out.WriteLine(bookingManagement.GetBookingDetail("0" + i.ToString()) + "\n");
            //else
            //    Console.Out.WriteLine(bookingFound.ToString() + ": Booking was not found.");
        }

        /// <summary>
        /// Test booking Id correct length
        /// </summary>
        [Test]
        public void Find_Booking_Test_3()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("adsjklasjdlkja");
            //if (bookingFound == 1)
            //    for (int i = 1; i <= 6; i++)
            //        Console.Out.WriteLine(bookingManagement.GetBookingDetail("0" + i.ToString()) + "\n");
            //else
            //    Console.Out.WriteLine(bookingFound.ToString() + ": Incorrect Booking Id.");
        }

        /// <summary>
        /// Test booking Id correct format ( 1 letter followed by 7 digits
        /// </summary>
        [Test]
        public void Find_Booking_Test_4()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("z9191zzz");
            //if (bookingFound == 1)
            //    for (int i = 1; i <= 6; i++)
            //        Console.Out.WriteLine(bookingManagement.GetBookingDetail("0" + i.ToString()) + "\n");
            //else
            //    Console.Out.WriteLine(bookingFound.ToString() + ": Incorrect Booking Id.");
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
        /// Test creation of a booking with correct information
        /// As well as testing it is valid information (not fully implemented)
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
        /// Test creation of a booking with some information blank
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
        /// Test creation of a booking with some information blank
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
        /// </summary>
        [Test]
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
}
