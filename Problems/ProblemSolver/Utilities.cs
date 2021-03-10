using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolver{
    public static class Utilities{
        private static Dictionary<int, Type> problemsIndexes = new Dictionary<int, Type>();

        public static int ProblemsCount{
            get{
                return problemsIndexes.Count;
            }
        }

        static Utilities(){
            AddProblemsToTheList(typeof(MinTrainPlatformsCountFinder));
            AddProblemsToTheList(typeof(AlternateSorter));
            AddProblemsToTheList(typeof(Graph_BFS));
        }

        private static void AddProblemsToTheList(Type specificProblemSolver ){
            problemsIndexes.Add(problemsIndexes.Count + 1, specificProblemSolver);
        }

        public static string GetProblemsList(){
            StringBuilder problems = new StringBuilder();

            foreach(KeyValuePair<int, Type> problem in problemsIndexes){
                problems.Append(problem.Key + ". " + problem.Value.Name + "\n");
            }

            return problems.ToString();
        }

        public static IProblemSolver GetProblemBasedOn(int userPreference){
            return (IProblemSolver) Activator.CreateInstance(problemsIndexes[userPreference]);
        }
    }
}