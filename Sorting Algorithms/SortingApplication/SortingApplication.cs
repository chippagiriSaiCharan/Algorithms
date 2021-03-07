using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms{
    enum SortingAlgorithmNames{
        InsertionSort
    }
    public class SortingApplication{
        public static void Main(string[] args){
            
            int userChoiceOfAlgorithm = 0;
            List<int> numbersToSort; 
        
            TakeUserInput(ref userChoiceOfAlgorithm, out numbersToSort);

            SortAndDisplayList(numbersToSort, userChoiceOfAlgorithm);
        }

        private static void TakeUserInput(ref int userChoiceOfAlgorithm,out List<int> numbersToSort){

            Console.WriteLine("Choose the index of the algorithm from the following: \n" + AlgorithmsUtilities.FindAlgorithmsNames());
        
            Int32.TryParse(Console.ReadLine(),out userChoiceOfAlgorithm);

            if(userChoiceOfAlgorithm < 1 || userChoiceOfAlgorithm > AlgorithmsUtilities.AlgorithmsCount){
                userChoiceOfAlgorithm = 1;
            }

            numbersToSort =  TakeInputOfNumbersToSort();
        }

        private static List<int> TakeInputOfNumbersToSort(){
            Console.WriteLine("Please, share the input of numbers in single line with commas to Sort");

            return Console.ReadLine().Split(',').Select(Int32.Parse).ToList();
        }

        private static void SortAndDisplayList(List<int> numbersToSort, int  userChoiceOfAlgorithm){

            Isorter sorter = AlgorithmsUtilities.FindSortingAlgorithmBasedOn(userChoiceOfAlgorithm);
        
            List<int> result = new List<int>(0);

            if(sorter != null){
                result = sorter.Sort(numbersToSort);
            }

            DisplayTheSortedList(result);
        }

        public static void DisplayTheSortedList(List<int> sortedNumbers){
            StringBuilder sortedList = new StringBuilder();
            sortedList.Append("Sorted List:\t");

            foreach(int number in sortedNumbers){
                sortedList.Append(number + ",");
            }

            sortedList.Remove(sortedList.Length - 1, 1);
            Console.WriteLine(sortedList);
        }
    }
}