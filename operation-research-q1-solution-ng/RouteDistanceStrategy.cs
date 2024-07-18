namespace operation_research_q1_solution_ng
{
    class RouteDistanceStrategy : IGraphStrategy
    {
        public object Execute(Dictionary<string, List<(string, int)>> graph, string[] args)
        {
            string route = args[0];
            var stops = route.Split('-');
            int totalDistance = 0;

            for (int i = 0; i < stops.Length - 1; i++)
            {
                string start = stops[i];
                string end = stops[i + 1];
                var edge = graph[start].FirstOrDefault(e => e.Item1 == end);

                if (edge == default)
                {
                    return "NO SUCH ROUTE";
                }
                totalDistance += edge.Item2;
            }

            return totalDistance;
        }
    }
}
