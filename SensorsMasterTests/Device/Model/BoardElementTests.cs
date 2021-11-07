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
    public class BoardElementTests
    {
        [TestMethod()]
        public void BoardElementTest()
        {
            var poi1 = new POI();
            var poi2 = new POI();
            var poi3 = new POI();

            Assert.AreEqual(2, poi3.Id);
        }
    }
}