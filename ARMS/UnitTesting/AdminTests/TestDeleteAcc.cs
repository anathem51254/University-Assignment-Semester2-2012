using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    class TestzDeleteAcc
    {
        Customer cust;
        Staff staff;

        [SetUp]
        public void TestBookingManagementSetup()
        {
            cust = new Customer();
            staff = new Staff();
        }

        [Test]
        public void deleteCust()
        {
            Assert.AreEqual(true, cust.deleteCUSTacc("andres"));
        }
        [Test, ExpectedException(typeof(ArgumentException))]
        public void invalideleteCust()
        {
            cust.deleteCUSTacc("aaa");
        }

        [Test]
        public void deleteStaff()
        {
            Assert.AreEqual(true, staff.deleteSTAFFacc("testing"));
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void invalideleteStaff()
        {
            staff.deleteSTAFFacc("aaa");
        }
    }
}
