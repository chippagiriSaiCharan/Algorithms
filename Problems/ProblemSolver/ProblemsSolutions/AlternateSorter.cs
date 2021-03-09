using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolver{
    public class AlternateSorter : IProblemSolver{
        List<int> numbersToSort;

        public void GetUserInput(){
            Console.WriteLine("Please, enter the list of numbers to sort(Seperated in commas , :");

            numbersToSort =  Console.ReadLine().Split(',').Select(Int32.Parse).ToList();
        }

        public void SolveProblem(){
            GetUserInput();

            List<int> sortedList = new List<int>(numbersToSort);

            if(numbersToSort.Count == 0){
                Console.WriteLine("Please, Try again with different input\n");
                return;
            }

            sortedList = sortedList.OrderByDescending(number => number).ToList();
            
            for(int moveIndex = 1, count = 0; count < (sortedList.Count / 2); moveIndex += 2, count++){
                MoveNumber(sortedList, sortedList.Count - 1, moveIndex);
            }
            
            PrintList(sortedList);
        }

        private void PrintList(List<int> numbersList){
            Console.Write("Sorted list of numbers: ");
            
            for(int index = 0; index < numbersList.Count - 1; index++){
                Console.Write(numbersList[index] + ", ");
            }

            Console.Write(numbersList[numbersList.Count - 1] + "\n\n");
        }

        private void MoveNumber(List<int> sortedList, int removeIndex, int insertIndex){
            int number = sortedList[removeIndex];

            sortedList.RemoveAt(removeIndex);
            sortedList.Insert(insertIndex, number);
        }
    }
}