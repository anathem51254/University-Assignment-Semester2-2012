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
        /// Test correct length for booking id
        /// </summary>
        [Test]
        public void Find_Booking_Test_3()
        {
            int bookingFound = bookingManagement.ProcessFindBooking("b99999999");
            //if (bookingFound == 1)
            //    for (int i = 1; i <= 6; i++)
            //        Console.Out.WriteLine(bookingManagement.GetBookingDetail("0" + i.ToString()) + "\n");
            //else
            //    Console.Out.WriteLine(bookingFound.ToString() + ": Incorrect Booking Id.");
        }
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
}
