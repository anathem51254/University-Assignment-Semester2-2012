using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Business_Layer;

namespace UnitTesting
{
    [TestFixture] public class TestEmail
    {
        Email email;

        [SetUp]
        public void TestEmailSetUp()
        {
            email = new Email();
        }

        //This test needs to connect to the internet, otherwise, it won't work. 
        [Test]
        public void SendGEmail1()
        {
            email.SendGEmail("ice@uni.canberra.edu.au", "Aussie Auto Repairs", "Hi, Mr/Miss XXX The best booking time is next Tuesday 8 o'clock for your car service. Is that ok for you? Regards Aussie Auto Repairs");
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void SendGEmail2()
        {
            email.SendGEmail("", "Aussie Auto Repairs", "Hi, Mr/Miss XXX The best booking time is next Tuesday 8 o'clock for your car service. Is that ok for you? Regards Aussie Auto Repairs");
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void SendGEmail3()
        {
            email.SendGEmail("XXXXXXXXXXXXXXXX", "Aussie Auto Repairs", "Hi, Mr/Miss XXX The best booking time is next Tuesday 8 o'clock for your car service. Is that ok for you? Regards Aussie Auto Repairs");
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void SendGEmail4()
        {
            email.SendGEmail("1111111111111111", "Aussie Auto Repairs", "Hi, Mr/Miss XXX The best booking time is next Tuesday 8 o'clock for your car service. Is that ok for you? Regards Aussie Auto Repairs");
        }
    }
}
