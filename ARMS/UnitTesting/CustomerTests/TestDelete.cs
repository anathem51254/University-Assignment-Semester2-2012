using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    [TestFixture]
    public class TestDelete
    {
        CustomerDetail cd;

        [SetUp]
        public void TestCustomerDetailSetUp()
        {
            cd = new CustomerDetail();
        }

        [Test]
        public void Delete1()
        {
            cd.DeleteCustomerDetail("Mem001");
        }

        [Test]
        public void Delete2()
        {
            cd.DeleteCustomerDetail("Mem001");

            cd.DeleteCustomerDetail("Mem001");
        }

        [Test]
        public void Delete3()
        {
            cd.DeleteCustomerDetail("XXXXXXXXXXXXX");
        }

        [Test]
        public void Delete4()
        {
            cd.DeleteCustomerDetail("11111111111111");
        }

        [Test]
        public void Delete5()
        {
            cd.DeleteCustomerDetail("");
        }
    }
}
