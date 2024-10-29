# NewGlobe Programming Challenge

## Overview
Below are two programming problems. Please read both problems, then create a program to solve **ONE** of the problems. Though NewGlobe values polyglot developers, we request that you use **C#** for your solution. You may not use any external libraries to solve this problem, but you may use external libraries or tools for building or testing purposes, such as NUnit.

System security is important to us, and certain file extensions will be blocked for security purposes – you should NOT include any executables, such as `.exes` or `.msis`. We need to be able to run and build your code, so please submit your code as a zipped file of source code and supporting files, without any compiled code.

Please include a brief explanation of your design and assumptions, along with your code, as well as instructions on how to run your application.

We assess a number of things, including the design of your solution and your programming skills, and accordingly we expect you to submit what you believe is production-quality code – code that you’d be able to run, maintain, and evolve, including any tests that you would normally write as part of the development process; and, of course, the program should do something useful for the specified user. You don’t need to gold plate your solution; however, we are looking for something more than a bare-bones algorithm.

As a general rule, we allow three days from the date that you receive these instructions to submit your code, but you may request more time if needed. If you have any questions about the code as it relates to your interview process, please contact us.

## Project #1: Teacher Computer Retrieval

### Problem Description
Within each global region (e.g., East Africa), the IT team is responsible for retrieving teacher computers that are broken and returning them to HQ for repair and replacement. Because of road conditions, construction, and one-way traffic, the routes are defined in a single direction – a direct route from Rongai to Kiserian does not imply the existence of a direct route from Kiserian to Rongai. If both of these routes do happen to exist, they are distinct and are not necessarily the same distance.

The purpose of this program is to provide the IT team with information about possible routes between academies to help plan their teacher computer retrievals. To do this, the IT team will need to be able to calculate:
1. The distance along certain routes.
2. The number of different routes between two academies.
3. The shortest route between two academies.

### Input Format
The input to the program should consist of tuples, consisting of the starting academy, ending academy, and the directed distance between the academies. A given route should never appear more than once, and for a given route, the starting and ending academy will not be the same academy. In the sample input, the academies are named A to E. A route from A to B with a distance of 3 is represented as AB3.

### Example Questions (Continued)
The program should be able to answer questions such as the following (based on the provided sample data):

1. **The distance of the route A-B-C:** Expected Output: 9
2. **The distance of the route A-E-B-C-D:** Expected Output: 22
3. **The distance of the route A-E-D:** Expected Output: NO SUCH ROUTE
4. **The number of trips starting at C and ending at C with a maximum of 3 stops:** Expected Output: 2
5. **The number of trips starting at A and ending at C with exactly 4 stops:** Expected Output: 3
6. **The length of the shortest route (in terms of distance to travel) from A to C:** Expected Output: 9
7. **The length of the shortest route (in terms of distance to travel) from B to B:** Expected Output: 9
8. **The number of different routes from C to C with a distance of less than 30:** Expected Output: 7

### Test Input
AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7

### Expected Test Output
1. 9
2. 22
3. NO SUCH ROUTE
4. 2
5. 3
6. 9
7. NO SUCH ROUTE
8. 7

# My Solution

This solutiom leverages concepts and techniques from operations research, specifically graph theory and network optimization, to solve the problem of retrieving routes between different academies.

## Contexts
- [Distance Calculation](#distance-calculation)
- [Route Counting](#route-counting)
- [Shortest Route Calculation](#shortest-route-calculation)
- [Route Counting with Distance Constraint](#route-counting-with-distance-constraint)
- [Design and Assumptions](#design-and-assumptions)
- [Running the Application](#running-the-application)

## Distance Calculation
- **Graph Representation**: The graph is represented using a dictionary where each key is a node (academy) and the value is a list of tuples representing the edges (routes) and their weights (distances).
- **Route Calculation**: To calculate the distance of a specific route, the algorithm traverses the graph, summing the distances. If any segment of the route does not exist, it returns "NO SUCH ROUTE".

## Route Counting
- **Depth-First Search (DFS)**: DFS is utilized to explore all possible routes from a starting node to an ending node, counting those that satisfy constraints such as a maximum number of stops or an exact number of stops.
- **Recursive Approach**: The recursive nature of DFS aids in exploring all potential paths in the graph, making it suitable for counting routes under specific constraints.

## Shortest Route Calculation
- **Dijkstra’s Algorithm**: This algorithm finds the shortest path between two nodes in a graph, a classic operations research technique for solving shortest path problems.
- **Priority Queue**: A priority queue is employed to always expand the shortest known distance, ensuring efficient discovery of the shortest path.

## Route Counting with Distance Constraint
- **Modified DFS**: A variant of DFS is implemented to count all possible routes from a starting node to an ending node where the total distance is less than a specified maximum distance. This involves tracking cumulative distance as routes are explored.

## Design and Assumptions
### Design Overview
- The solution utilizes the Strategy design pattern to encapsulate different graph algorithms for various operations such as:
  - Calculating route distance
  - Counting routes with specific constraints (stops, distance)
  - Finding the shortest route

### Interface
- **IGraphStrategy**: Provides a common interface for all concrete strategies, ensuring they implement the `Execute` method.

### Concrete Strategies
- **RouteDistanceStrategy**: Calculates the distance of a specified route.
- **CountRoutesWithMaxStopsStrategy**: Counts routes with a maximum number of stops between two nodes.
- **CountRoutesWithExactStopsStrategy**: Counts routes with an exact number of stops between two nodes.
- **FindShortestRouteStrategy**: Identifies the shortest route (minimum distance) between two nodes using Dijkstra's algorithm.
- **CountRoutesWithMaxDistanceStrategy**: Counts routes within a maximum distance between two nodes.

### Context
- **GraphContext**: This class utilizes the selected strategy to execute the corresponding graph algorithm based on the user's query.

### Assumptions
- The input graph is represented as a directed graph where edges have weights (distances).
- Input routes are provided as a comma-separated string where each route specifies a start node, end node, and distance. Check Program.cs file.
- Queries are handled as specified in the examples, returning appropriate outputs (distances, counts, or error messages for invalid routes).

## Running the Application
1. Ensure you have .NET installed.
2. Open a terminal/command prompt on your computer.
3. Clone the repository:
   ```bash
   git clone https://github.com/lexico4real/operation-research-q1-solution-ng.git

