namespace operation_research_q1_solution_ng
{
    class CountRoutesWithMaxStopsStrategy : IGraphStrategy
    {
        public object Execute(Dictionary<string, List<(string, int)>> graph, string[] args)
        {
            string start = args[0];
            string end = args[1];
            int maxStops = int.Parse(args[2]);

            return CountRoutesWithMaxStopsHelper(graph, start, end, maxStops, 0);
        }

        private int CountRoutesWithMaxStopsHelper(Dictionary<string, List<(string, int)>> graph, string current, string end, int maxStops, int stops)
        {
            if (stops > maxStops) return 0;
            if (current == end && stops > 0) return 1;

            int count = 0;
            if (graph.ContainsKey(current))
            {
                foreach (var (next, _) in graph[current])
                {
                    count += CountRoutesWithMaxStopsHelper(graph, next, end, maxStops, stops + 1);
                }
            }
            return count;
        }
    }
}
