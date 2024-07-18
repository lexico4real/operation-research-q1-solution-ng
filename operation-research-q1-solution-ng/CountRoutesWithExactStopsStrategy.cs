namespace operation_research_q1_solution_ng
{
    class CountRoutesWithExactStopsStrategy : IGraphStrategy
    {
        public object Execute(Dictionary<string, List<(string, int)>> graph, string[] args)
        {
            string start = args[0];
            string end = args[1];
            int exactStops = int.Parse(args[2]);

            return CountRoutesWithExactStopsHelper(graph, start, end, exactStops, 0);
        }

        private int CountRoutesWithExactStopsHelper(Dictionary<string, List<(string, int)>> graph, string current, string end, int exactStops, int stops)
        {
            if (stops > exactStops) return 0;
            if (current == end && stops == exactStops) return 1;

            int count = 0;
            if (graph.ContainsKey(current))
            {
                foreach (var (next, _) in graph[current])
                {
                    count += CountRoutesWithExactStopsHelper(graph, next, end, exactStops, stops + 1);
                }
            }
            return count;
        }
    }
}
