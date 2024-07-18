namespace operation_research_q1_solution_ng
{
    class GraphContext
    {
        private IGraphStrategy _strategy;

        public GraphContext(IGraphStrategy strategy)
        {
            _strategy = strategy;
        }

        public object ExecuteStrategy(Dictionary<string, List<(string, int)>> graph, string[] args)
        {
            return _strategy.Execute(graph, args);
        }
    }
}
