using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    [TestFixture] public class TestInsert
    {
        CustomerDetail cd;

        [SetUp]
        public void TestCustomerDetailSetUp()
        {
            cd = new CustomerDetail();
        }

        [Test]
        public void Insert1()
        {
            cd.InsertCustomerDetail("Reg001", "Mem001", "Z1", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");
        }

        [Test]
        public void Insert2()
        {
            cd.InsertCustomerDetail("Reg001", "Mem001", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");

            cd.InsertCustomerDetail("Reg001", "Mem001", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra.edu.au", "19 Mick cct Bruce ACT");
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void Insert3()
        {
            cd.InsertCustomerDetail("", "Mem001", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra", "19 Mick cct Bruce ACT");

        }

        [Test]
        public void Insert4()
        {
            cd.InsertCustomerDetail("Reg001", "XXXXXXXXXXXX", "Zou", "Male", "0424997087", "1988-10-27", "ice@uni.canberra", "19 Mick cct Bruce ACT");

        }
    }
 }
