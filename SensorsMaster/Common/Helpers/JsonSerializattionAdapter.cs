using SensorsMaster.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Common.Helpers
{
    public class JsonSerializattionAdapter
    {
        public static TResult JsonDeserializeAdapter<TResult, TAdapter> (Stream stream) where TAdapter : IJsonAdapter<TResult>
        {
            var adapter = SerializationHelper.JsonDeserialize<TAdapter>(stream);
            return adapter.Convert();
        }

    }
}
