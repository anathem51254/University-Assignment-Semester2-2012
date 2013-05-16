using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    [TestFixture]
    public class TestModify
    {
        CustomerDetail cd;

        [SetUp]
        public void TestCustomerDetailSetUp()
        {
            cd = new CustomerDetail();
        }

        [Test]
        public void Modify1()
        {
            cd.ModifyCustomerDetail("Mem001", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");
        }

        [Test]
        public void Modify2()
        {
            cd.ModifyCustomerDetail("", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");
        }

        [Test]
        public void Modify3()
        {
            cd.ModifyCustomerDetail("111111111", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");
        }

        [Test]
        public void Modify4()
        {
            cd.ModifyCustomerDetail("XXXXXXXXX", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");
        }
    }
}
