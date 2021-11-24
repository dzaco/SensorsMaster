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
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using SensorsMasterTests.Factory;

namespace SensorsMaster.Common.Tests
{
    [TestClass()]
    public class FileManagerTests
    {
        private bool FileContains(string val, string path)
        {
            return File.ReadAllText(path).Contains(val);
        }
        [TestMethod()]
        public void SensorCollectionSerializationTest()
        {
            var path = @"C:\Users\Dzaco\source\repos\SensorsMaster\SensorsMaster\Resources\SensorCollection.json";
            if (File.Exists(path))
                File.Delete(path);

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

            var json = JsonConvert.SerializeObject(collection);
            Debug.WriteLine(json);

            FileManager.SaveStream(SerializationHelper.JsonSerialize(collection), path);

            Assert.IsTrue(FileContains("Battery", path));

        }

        [TestMethod]
        public void SensorCollectionDeserializationTest()
        {
            var path = @"C:\Users\Dzaco\source\repos\SensorsMaster\SensorsMaster\Resources\SensorCollection.json";
            if (File.Exists(path))
                File.Delete(path);

            var builder = new SensorCollectionBuilder();
            SensorCollection collection = builder.AddSensors(3)
                .WithBatteryOn(1)
                .BuildAndSave(path);

            var testCollection = SerializationHelper
                .JsonDeserialize<SensorCollection>
                (FileManager.ReadStream(path));

            Assert.IsTrue(
                testCollection.Count == 3 &&
                testCollection.Where(s =>
                    s.Battery.Power == Power.On).Count() == 1);
        }
    }
}