using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    [TestFixture]
    public class TestSearch
    {
        CustomerDetail cd;

        [SetUp]
        public void TestCustomerDetailSetUp()
        {
            cd = new CustomerDetail();
        }

        [Test]
        public void Search1()
        {
            cd.SearchCustomerDetail("Mem001");
        }

        [Test]
        public void Search2()
        {
            cd.SearchCustomerDetail("XXXXXXXXXX");
        }

        [Test]
        public void Search3()
        {
            cd.SearchCustomerDetail("11111111111");
        }

        [Test]
        public void Search4()
        {
            cd.SearchCustomerDetail("");
        }       
    }
}
