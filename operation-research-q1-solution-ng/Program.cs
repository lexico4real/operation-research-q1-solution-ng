using operation_research_q1_solution_ng;

class Program
{
    static Dictionary<string, List<(string, int)>> graph = new Dictionary<string, List<(string, int)>>();

    static void Main(string[] args)
    {
        string input = "AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7";
        ParseInput(input);

        var context = new GraphContext(new RouteDistanceStrategy());

        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "A-B-C" })); // Output: 9
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "A-E-B-C-D" })); // Output: 22
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "A-E-D" })); // Output: NO SUCH ROUTE

        context = new GraphContext(new CountRoutesWithMaxStopsStrategy());
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "C", "C", "3" })); // Output: 2

        context = new GraphContext(new CountRoutesWithExactStopsStrategy());
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "A", "C", "4" })); // Output: 3

        context = new GraphContext(new FindShortestRouteStrategy());
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "A", "C" })); // Output: 9
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "B", "B" })); // Output: NO SUCH ROUTE

        context = new GraphContext(new CountRoutesWithMaxDistanceStrategy());
        Console.WriteLine(context.ExecuteStrategy(graph, new string[] { "C", "C", "30" })); // Output: 7
    }

    static void ParseInput(string input)
    {
        var routes = input.Split(", ");
        foreach (var route in routes)
        {
            string start = route[0].ToString();
            string end = route[1].ToString();
            int distance = int.Parse(route.Substring(2));

            if (!graph.ContainsKey(start))
            {
                graph[start] = new List<(string, int)>();
            }
            graph[start].Add((end, distance));
        }
    }
}
