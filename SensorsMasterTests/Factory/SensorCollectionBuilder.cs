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

namespace SensorsMasterTests.Factory
{
    public class SensorCollectionBuilder
    {
        SensorCollection collection;

        public SensorCollectionBuilder()
        {
            collection = new SensorCollection();
        }

        internal SensorCollectionBuilder AddSensors(int count)
        {
            for(int i = 0; i < count; i++)
            {
                collection.Add( new Sensor() );
            }
            return this;
        }

        internal SensorCollection Build()
        {
            return collection;
        }

        internal SensorCollectionBuilder WithBatteryOn(int? count = null)
        {
            if (count is null || count < 0 || count > collection.Count)
                count = collection.Count;
            for(int i = 0; i < count; i++)
            {
                collection[i].Battery.Power = Power.On;
            }
            return this;
        }

        internal SensorCollection BuildAndSave(string path)
        {
            FileManager.SaveStream(SerializationHelper.JsonSerialize(collection), path);
            return Build();
        }
    }
}
