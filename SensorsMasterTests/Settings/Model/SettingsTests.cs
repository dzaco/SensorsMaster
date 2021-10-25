using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorsMaster.Common;
using SensorsMaster.Common.Helpers;
using SensorsMaster.Settings.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Settings.Model.Tests
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

            Settings newSettings = SerializationHelper.XmlDeserialize<Settings>
                (FileManager.ReadStream(FileManager.ConfigFile));

            Assert.AreEqual(newSettings.SensorSettings.Range, settings.SensorSettings.Range);
        }
    }
}