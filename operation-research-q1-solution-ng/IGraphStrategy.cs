namespace operation_research_q1_solution_ng
{
    interface IGraphStrategy
    {
        object Execute(Dictionary<string, List<(string, int)>> graph, string[] args);
    }
}
