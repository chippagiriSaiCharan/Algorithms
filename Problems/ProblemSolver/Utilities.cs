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
            InitializeProblemsList();
        } 

        private static void InitializeProblemsList(){
            problemsIndexes.Add(1, typeof(AlternateSorter));
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