using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolver{
    public class MinTrainPlatformsCountFinder : IProblemSolver{
        List<float> arrivalInformation = new List<float>();
        List<float> departureInformation = new List<float>();

        public void GetUserInput(){
            try{
                Console.WriteLine("Share Trains arrival information - seperated by commas , :" );

                arrivalInformation = Console.ReadLine().Split(",").Select(float.Parse).ToList();

                Console.WriteLine("Share Trains departure information - seperated by commas , :" );

                departureInformation = Console.ReadLine().Split(",").Select(float.Parse).ToList();
            }
            catch{
                Console.WriteLine("Please, verify your input and share.");
                GetUserInput();
            }
                        
        }

        public void SolveProblem(){
            GetUserInput();

            int minPlatformsRequired = 1;

            for(int arrivalIndex = 1, departureIndex = 0, platfromsCount = 1; arrivalIndex < arrivalInformation.Count && departureIndex < departureInformation.Count; ){
                if(arrivalInformation[arrivalIndex] <= departureInformation[departureIndex]){

                    platfromsCount++;
                    arrivalIndex++;

                }else if(arrivalInformation[arrivalIndex] > departureInformation[departureIndex]){

                    platfromsCount--;
                    departureIndex++;
                    
                }

                if(platfromsCount > minPlatformsRequired){
                    minPlatformsRequired = platfromsCount;
                }
            }

            Console.WriteLine("Minimum platforms required are : " + minPlatformsRequired);
        }
    }
}