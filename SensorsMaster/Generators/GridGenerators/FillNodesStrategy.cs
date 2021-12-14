using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Generators.GridGenerators
{
    public abstract class FillNodesStrategy
    {
        public static FillNodesStrategy RandomNodes => new FillRandomNodesStrategy();
        public static FillNodesStrategy FillWithProbability => new FillNodesWithProbabilityStrategy();
    }
}
