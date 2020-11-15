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
    public class MilitaryPlaneTest
    {
        [Test]
        public void GetPlaneTypeTest()
        {
            MilitaryPlane militaryPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            Assert.AreEqual(Aircompany.Models.MilitaryAirplaneType.Bomber, militaryPlane.GetPlaneType());
        }

        public void TrueEqualTest()
        {
            MilitaryPlane firstPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            MilitaryPlane secondPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);

            Assert.AreEqual(firstPlane, secondPlane);
        }

        public void FalseEqualTest()
        {
            MilitaryPlane firstPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            MilitaryPlane secondPlane = new MilitaryPlane("model1", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseSecondEqualTest()
        {
            MilitaryPlane firstPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            MilitaryPlane secondPlane = new MilitaryPlane("model", 9999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseThirdEqualTest()
        {
            MilitaryPlane firstPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            MilitaryPlane secondPlane = new MilitaryPlane("model", 999, 999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseFouthEqualTest()
        {
            MilitaryPlane firstPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            MilitaryPlane secondPlane = new MilitaryPlane("model", 999, 9999, 9999, Aircompany.Models.MilitaryAirplaneType.Bomber);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
        public void FalseFifthEqualTest()
        {
            MilitaryPlane firstPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Bomber);
            MilitaryPlane secondPlane = new MilitaryPlane("model", 999, 9999, 99999, Aircompany.Models.MilitaryAirplaneType.Transport);

            Assert.AreNotEqual(firstPlane, secondPlane);
        }
    }
}
