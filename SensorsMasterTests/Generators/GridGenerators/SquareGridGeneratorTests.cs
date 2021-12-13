using Microsoft.VisualStudio.TestTools.UnitTesting;
using SensorsMaster.AppSettings;
using SensorsMaster.Generators.GridGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Generators.GridGenerators.Tests
{
    [TestClass()]
    public class SquareGridGeneratorTests
    {
        [TestMethod()]
        public void GenerateTest()
        {
            var settings = Settings.GetInstance();
            settings.SizeSettings.Width = 10;
            settings.SizeSettings.Height = 10;
            GridGenerator generator = new SquareGridGenerator(distance:2);
            var gridNodes = generator.Generate();
            gridNodes.Console();
        }
    }
}