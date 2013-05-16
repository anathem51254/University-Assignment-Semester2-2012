using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    class TestCheckAcc
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
        public void checkiCust()
        {
            Assert.AreEqual(true, cust.checkeCUSTacc("qaz"));
        }

        [Test]
        public void invalicheckCust()
        {
            Assert.AreEqual(false, cust.checkeCUSTacc("qqq"));
        }

        [Test]
        public void checkStaffUsername()
        {
            Assert.AreEqual(true, staff.checkSTAFFacc("5423"));
        }

        [Test]
        public void invalicheckStaff()
        {
            Assert.AreEqual(false, staff.checkSTAFFacc("used"));
        }
    }
}
