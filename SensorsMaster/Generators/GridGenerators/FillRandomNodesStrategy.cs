using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Generators.GridGenerators
{
    public class FillRandomNodesStrategy : FillNodesStrategy
    {
        public FillRandomNodesStrategy()
        {
            this.NodesCount = 10;
        }

        public int NodesCount { get; set; }
    }
}
