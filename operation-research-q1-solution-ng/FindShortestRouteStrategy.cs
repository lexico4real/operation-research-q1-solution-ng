namespace operation_research_q1_solution_ng
{
    class FindShortestRouteStrategy : IGraphStrategy
    {
        public object Execute(Dictionary<string, List<(string, int)>> graph, string[] args)
        {
            string start = args[0];
            string end = args[1];

            var distances = new Dictionary<string, int>();
            var priorityQueue = new SortedSet<(int, string)>();

            foreach (var node in graph.Keys)
            {
                distances[node] = int.MaxValue;
            }

            distances[start] = 0;
            priorityQueue.Add((0, start));

            while (priorityQueue.Count > 0)
            {
                var (currentDistance, currentNode) = priorityQueue.First();
                priorityQueue.Remove(priorityQueue.First());

                if (currentNode == end && currentDistance != 0)
                {
                    return currentDistance;
                }

                if (graph.ContainsKey(currentNode))
                {
                    foreach (var (neighbor, weight) in graph[currentNode])
                    {
                        int newDist = currentDistance + weight;
                        if (newDist < distances[neighbor])
                        {
                            priorityQueue.Remove((distances[neighbor], neighbor));
                            distances[neighbor] = newDist;
                            priorityQueue.Add((newDist, neighbor));
                        }
                    }
                }
            }

            return "NO SUCH ROUTE";
        }
    }
}
