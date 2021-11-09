using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorsMaster.Common;
using SensorsMaster.Common.Helpers;
using System.IO;
using System.Xml;

namespace SensorsMaster.AppSettings.Model.Tests
{
    [TestClass]
    public class SettingsTests
    {        
        [TestMethod]
        public void SaveSettingsToConfigFileTest()
        {
            if (File.Exists(FileManager.ConfigFile))
                File.Delete(FileManager.ConfigFile);

            var settings = Settings.GetInstance();
            var stream = SerializationHelper.XmlSerialize(settings);
            FileManager.SaveConfig(stream);

            Assert.IsTrue(File.Exists(FileManager.ConfigFile));

            var xml = new XmlDocument();
            xml.Load(FileManager.ConfigFile);
            var node = xml.SelectSingleNode("//ConfigPath");
            Assert.IsNotNull(node);
            
        }
    }
}