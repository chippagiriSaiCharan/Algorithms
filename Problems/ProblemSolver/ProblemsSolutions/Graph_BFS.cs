using System;
using System.Collections.Generic;

namespace ProblemSolver
{
    public class Graph_BFS : GraphProblem, IProblemSolver{
        public virtual void SolveProblem(){
            GetUserInput();

            int sourceIndex;

            Console.WriteLine("Give the source node(1 indexed format\n");
            Int32.TryParse(Console.ReadLine(), out sourceIndex);
            BFSTraversal(graph, sourceIndex);
        }

        private void BFSTraversal(int[,] graph, int sourceIndex){
            Queue<int> traversalPath = new Queue<int>();
            bool [] visited= new bool[nodesCount];

            traversalPath.Enqueue(sourceIndex);
            visited[sourceIndex] = true;

            Console.Write("BFS Traversal of the graph: ");
            while(traversalPath.Count != 0){
                int currentIndex = traversalPath.Dequeue();
                Console.Write(currentIndex + " ");

                for(int columnIndex = 0; columnIndex < nodesCount; columnIndex++){
                    if(graph[currentIndex, columnIndex] == 1 && !visited[columnIndex]){
                        visited[columnIndex] = true;
                        traversalPath.Enqueue(columnIndex);
                    }
                }
            }
            Console.WriteLine("\n");
        }
        
    }
}