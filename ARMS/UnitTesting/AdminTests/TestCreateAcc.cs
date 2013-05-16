using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    class TestCreateAcc
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
        public void createCust()
        {
            Assert.AreEqual(true, cust.createCUSTacc("andres", "789789789", "Chris", "Thomas", "12/12/1912", "Male", "ansdk@anana"));
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void invalicreateCust1()
        {
            cust.createCUSTacc("qqq", "789789789", "testing", "testing", "12/12/1945", "Male", "testing@123");
        }

        [Test]
        public void createstaff()
        {
            Assert.AreEqual(true, staff.createSTAFFacc("testing", "Sleepy", "Someone", "heissleepy", "12/12/2000", "F"));
        }
        [Test, ExpectedException(typeof(ArgumentException))]
        public void invalicreateStaff()
        {
            staff.createSTAFFacc("qqq", "789789789", "testing", "", "12/12/1945", "Male");
        }
    }
}
