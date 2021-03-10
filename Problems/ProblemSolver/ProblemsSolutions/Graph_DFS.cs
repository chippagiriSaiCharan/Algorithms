using System;

namespace ProblemSolver{
    public class Graph_DFS : GraphProblem, IProblemSolver{
        public void SolveProblem(){
            GetUserInput();
            
            int sourceIndex;

            Console.WriteLine("Please, enter the source index: \n");
            Int32.TryParse(Console.ReadLine(), out sourceIndex);

            Console.Write("DFS Traversal of the graph: ");
            DFSTraversal(sourceIndex, new bool[nodesCount]);
            Console.WriteLine("\n");
        }

        private void DFSTraversal(int sourceIndex, bool [] visited){
            visited[sourceIndex] = true;
            Console.Write(sourceIndex + " ");

            for(int columnIndex = 0; columnIndex < nodesCount; columnIndex++){
                if(graph[sourceIndex, columnIndex] == 1 && !visited[columnIndex]){
                    DFSTraversal(columnIndex, visited);
                }
            }

        }
    }
}