using System;

namespace ProblemSolver
{
    class ProblemSolverApplication
    {
        static void Main(string[] args)
        {
            int userPreference = 0;
    
            while(true){
                userPreference = GetUserInput();

                if(userPreference == 100){
                    break;
                }

                IProblemSolver problemSolver =  Utilities.GetProblemBasedOn(userPreference);

                problemSolver.SolveProblem();   
            }
        }

        static int GetUserInput(){
            Console.WriteLine("Select the index of the problem from the following: \n" + Utilities.GetProblemsList() + "100. Exit");
            
            int userPreference = 1;

            Int32.TryParse(Console.ReadLine(), out userPreference);

            if(userPreference < 1 || userPreference > Utilities.ProblemsCount){
                return 1;
            }

            return userPreference;
        }
    }
}
