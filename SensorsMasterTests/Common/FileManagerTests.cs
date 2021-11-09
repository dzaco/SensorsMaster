using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorsMaster.Common;
using SensorsMaster.Common.Enums;
using SensorsMaster.Common.Helpers;
using SensorsMaster.Device.Model;
using SensorsMaster.Device.Model.Collection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SensorsMaster.Common.Tests
{
    [TestClass()]
    public class FileManagerTests
    {
        [TestMethod()]
        public void SensorCollectionSerializationTest()
        {
            var poi1 = new POI(new Coordinates(1.2, 3.5));
            var poi2 = new POI();

            var sensor = new Sensor();
            sensor.POIInRange.Add(poi1, true);
            sensor.POIInRange.Add(poi2);

            var poi3 = new POI(new Coordinates(1.2, 3.5));

            var sensor2 = new Sensor(new Coordinates(10, 12.45), 12.3, Power.On);
            sensor2.POIInRange.Add(poi3, true);

            var collection = new SensorCollection();
            collection.Add(sensor);
            collection.Add(sensor2);

            var stream = SerializationHelper.XmlSerialize(collection);
            var path = @"C:\Users\Dzaco\source\repos\SensorsMaster\SensorsMaster\Resources\SensorCollection.xml";
            FileManager.SaveStream(stream, path);

            var xml = new XmlDocument();
            xml.Load(path);
            var node = xml.SelectSingleNode("//SensorCollection");
            Assert.IsNotNull(node);
            
        }
    }
}