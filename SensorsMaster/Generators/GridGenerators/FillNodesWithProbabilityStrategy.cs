namespace SensorsMaster.Generators.GridGenerators
{
    public class FillNodesWithProbabilityStrategy : FillNodesStrategy
    {
        public FillNodesWithProbabilityStrategy()
        {
            this.Probability = 0.7;
        }

        public double Probability { get; set; }
    }
}