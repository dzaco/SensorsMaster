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
            settings.SizeSettings.Width = 20;
            settings.SizeSettings.Height = 20;
            GridGenerator generator = new SquareGridGenerator(4, 2);
            var gridNodes = generator.Generate();
            gridNodes.Console();
        }
    }
}