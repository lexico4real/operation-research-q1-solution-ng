namespace operation_research_q1_solution_ng
{
    class CountRoutesWithMaxDistanceStrategy : IGraphStrategy
    {
        public object Execute(Dictionary<string, List<(string, int)>> graph, string[] args)
        {
            string start = args[0];
            string end = args[1];
            int maxDistance = int.Parse(args[2]);

            return CountRoutesWithMaxDistanceHelper(graph, start, end, maxDistance, 0);
        }

        private int CountRoutesWithMaxDistanceHelper(Dictionary<string, List<(string, int)>> graph, string current, string end, int maxDistance, int distance)
        {
            if (distance >= maxDistance) return 0;
            int count = 0;
            if (current == end && distance > 0) count++;

            if (graph.ContainsKey(current))
            {
                foreach (var (next, weight) in graph[current])
                {
                    count += CountRoutesWithMaxDistanceHelper(graph, next, end, maxDistance, distance + weight);
                }
            }

            return count;
        }
    }
}
