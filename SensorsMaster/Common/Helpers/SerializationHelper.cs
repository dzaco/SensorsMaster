using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorsMaster.Common.Helpers
{
    public static class SerializationHelper
    {
        public static Stream Serialize(object source)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            formatter.Serialize(stream, source);
            return stream;
        }

        public static T Deserialize<T>(Stream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            stream.Position = 0;
            return (T)formatter.Deserialize(stream);
        }

        public static T Clone<T>(T source)
        {
            return Deserialize<T>(Serialize(source));
        }

        public static Stream XmlSerialize(object source)
        {
            var serializer = new XmlSerializer(source.GetType());
            var stream = new MemoryStream();
            serializer.Serialize(stream, source);
            return stream;
        }

        public static T XmlDeserialize<T>(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(T));
            stream.Seek(0, SeekOrigin.Begin);
            return (T)serializer.Deserialize(stream);
        }

        public static T XmlClone<T>(T source)
        {
            return XmlDeserialize<T>(XmlSerialize(source));
        }

        public static Stream JsonSerialize(object source)
        {
            var json = JsonConvert.SerializeObject(source);
            var bytes = Encoding.UTF8.GetBytes(json);
            var stream = new MemoryStream( bytes );
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
        public static T JsonDeserialize<T>(Stream stream)
        {
            string json;
            stream.Seek(0, SeekOrigin.Begin);
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
