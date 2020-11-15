using Aircompany.Planes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircompanyTests.Tests.Planes
{
    [TestFixture]
    public class PassengerPlaneTest
    {

        [Test]
        public void GetPassengersCapacityTest()
        {
            PassengerPlane passengerPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            Assert.AreEqual(123, passengerPlane.GetPassengersCapacity());
        }

        public void TrueEqualTest()
        {
            PassengerPlane firstPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            PassengerPlane secondPlane = new PassengerPlane("model", 999, 9999, 99999, 123);

            Assert.AreEqual(firstPlane, secondPlane);
        }

        public void FalseEqualTest()
        {
            PassengerPlane firstPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            PassengerPlane secondPlane = new PassengerPlane("model1", 999, 9999, 99999, 123);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseSecondEqualTest()
        {
            PassengerPlane firstPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            PassengerPlane secondPlane = new PassengerPlane("model", 9999, 9999, 99999, 123);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseThirdEqualTest()
        {
            PassengerPlane firstPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            PassengerPlane secondPlane = new PassengerPlane("model", 999, 999, 99999, 123);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseFouthEqualTest()
        {
            PassengerPlane firstPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            PassengerPlane secondPlane = new PassengerPlane("model", 999, 9999, 9999, 123);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseFifthEqualTest()
        {
            PassengerPlane firstPlane = new PassengerPlane("model", 999, 9999, 99999, 123);
            PassengerPlane secondPlane = new PassengerPlane("model", 999, 9999, 99999, 1234);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
    }
}
