using SensorsMaster.AppSettings;
using SensorsMaster.Common.Enums;
using SensorsMaster.Common.Exceptions;
using SensorsMaster.Common.Extensions;
using SensorsMaster.Device.Model;
using SensorsMaster.Generators.GridGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorsMaster.Generators.POIGenerators
{
    public class POIGenerator
    {
        private Settings settings => Settings.GetInstance();
        public GridNodes Grid { get; }
        private Random random;

        public POIGenerator(GridNodes grid)
        {
            Grid = grid;
            random = new Random();
        }
        public POICollection Generate()
        {
            var collection = new POICollection();
            IEnumerable<GridNode> selectedNodes = SelectNodesForStrategy(settings.POIGenerateStrategy.FillNodesStrategy);
            var selectedNodesCount = selectedNodes.Count();
            var gridCount = Grid.Count();
            var pers = (double)selectedNodesCount / (double)gridCount;


            foreach(var node in selectedNodes)
            {
                POI poi = RandPOIForStrategy(settings.POIGenerateStrategy.PositionStrategy, node);
                collection.Add(poi);
            }
            
            return collection;
        }

        private POI RandPOIForStrategy(POIPositionStrategy positionStrategy, GridNode node)
        {
            if(positionStrategy == POIPositionStrategy.AlongEdges)
            {
                double distanceFormNode = Grid.Distance * ((double)random.Next(-100, 100) / 100);
                bool XOrY = random.Next() > (Int32.MaxValue / 2);

                var point = XOrY ? 
                    node.Point.Shift(distanceFormNode, 0) : 
                    node.Point.Shift(0, distanceFormNode);
                return new POI(point);
            }
            else
            {
                double xDistanceFormNode = Grid.Distance * ((double)random.Next(-100, 100) / 100);
                double yDistanceFormNode = Grid.Distance * ((double)random.Next(-100, 100) / 100);
                return new POI(node.Point.Shift(xDistanceFormNode,yDistanceFormNode));
            }
        }

        private IEnumerable<GridNode> SelectNodesForStrategy(FillNodesStrategy fillNodesStrategy)
        {
            if (fillNodesStrategy is null)
                throw new SettingsExeption("FillNodesStrategy not set");

            if (fillNodesStrategy is FillNodesWithProbabilityStrategy)
                return SelectNodesWithProbability((fillNodesStrategy as FillNodesWithProbabilityStrategy).Probability);
            else if (fillNodesStrategy is FillRandomNodesStrategy)
                return SelectKRandomNodes((fillNodesStrategy as FillRandomNodesStrategy).NodesCount);
            else
                return Grid;
        }

        private IEnumerable<GridNode> SelectKRandomNodes(int nodesCount)
        {
            return Grid.OrderBy(arg => Guid.NewGuid()).Take(nodesCount);
        }

        private IEnumerable<GridNode> SelectNodesWithProbability(double probability)
        {
            return Grid.Where(node => random.NextDouble() < probability);
        }
    }
}
