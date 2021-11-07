using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorsMaster.Device.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Device.Model.Tests
{
    [TestClass()]
    public class CoordinatesTests
    {
        [TestMethod()]
        public void DistanceTest()
        {
            var expectedDistance = 3.4;
            var poi1 = new POI();
            var poi2 = new POI(new Coordinates(expectedDistance, 0));

            Assert.AreEqual(expectedDistance, poi1.Coordinates.Distance(poi2.Coordinates));
        }

        [TestMethod()]
        public void BoardElementDistanceTest()
        {
            var expectedDistance = 3.4;
            var poi1 = new POI();
            var poi2 = new POI(new Coordinates(expectedDistance, 0));

            Assert.AreEqual(expectedDistance, poi1.Distance(poi2));
        }
    }
}