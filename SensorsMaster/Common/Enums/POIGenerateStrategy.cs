using SensorsMaster.Generators.GridGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsMaster.Common.Enums
{
    public class POIGenerateStrategy
    {
        public POIPositionStrategy PositionStrategy { get; set; }      
        public FillNodesStrategy FillNodesStrategy { get; set; }      

        public POIGenerateStrategy()
        {
            this.PositionStrategy = POIPositionStrategy.AlongEdges;
            FillNodesStrategy = FillNodesStrategy.RandomNodes;
        }
    }

    
}
