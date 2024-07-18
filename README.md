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
7. 9
8. 7
