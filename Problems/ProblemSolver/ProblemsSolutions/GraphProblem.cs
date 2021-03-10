using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolver{
    public class GraphProblem{
        protected int nodesCount = 0, edgesCount;
        protected int [,] graph;
        protected void GetUserInput(){
            try{
                Console.WriteLine("Give the count of number of nodes and edges in the Graph (Comma seperated ,): \n");

                ReadTwoCommaSeperatedUserInput(out nodesCount, out edgesCount);
            
                graph = new int [nodesCount, nodesCount];

                Console.WriteLine("Share all the edges information using seperate commas , like 1,2 :");

                for(int edgeIndex = 0; edgeIndex < edgesCount; edgeIndex++){
                    int from, to;

                    ReadTwoCommaSeperatedUserInput(out from, out to);

                    graph[from, to] = 1;
                }

                PrintGraph();
            }
            catch{
                Console.WriteLine("Please, verify your input and share.");
                GetUserInput();
            }

        }

        protected void PrintGraph(){
            Console.WriteLine("\nThe Graph: \n");

            for(int rowIndex = 0; rowIndex < nodesCount; rowIndex++){
                for(int columnIndex = 0; columnIndex < nodesCount; columnIndex++){
                    Console.Write(graph[rowIndex, columnIndex] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        protected void ReadTwoCommaSeperatedUserInput(out int first, out int second){
            List<int> userInput = Console.ReadLine().Split(',').Select(Int32.Parse).ToList();
            
            first = userInput[0];
            second = userInput[1];
        }
        
    }
}