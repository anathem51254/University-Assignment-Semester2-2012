using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    class TestModifyAcc
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
        public void changeCust()
        {
            Assert.AreEqual(true, cust.changeCUSTacc("andres", "789789789", "Andres", "McDonalds", "01/12/1989", "Female", "testing@123"));
        }
        [Test, ExpectedException(typeof(ArgumentException))]
        public void invalichangeCust()
        {
            cust.changeCUSTacc("aaa", "789789789", "Andres", "McDonalds", "01/12/1989", "Female", "testing@123");
        }

        [Test]
        public void changeStaff()
        {
            Assert.AreEqual(true, staff.changeSTAFFacc("testing", "random", "things", "heissleepy", "12/12/2000", "Male"));
        }
        [Test, ExpectedException(typeof(ArgumentException))]
        public void invalichangeStaff()
        {
            staff.changeSTAFFacc("aaa", "random", "things", "heissleepy", "12/12/2000", "Male");
        }
    }
}
