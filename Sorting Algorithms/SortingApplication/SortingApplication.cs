using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SortingAlgorithms;

enum SortingAlgorithmNames{
    InsertionSort
}

public class SortingApplication{

    public static void Main(string[] args){
        List<int> numbersToSort = TakeInputOfNumbersToSort();

        SortAndDisplayList(numbersToSort, SortingAlgorithmNames.InsertionSort);
    }

    private static List<int> TakeInputOfNumbersToSort(){

        Console.WriteLine("Please, share the input of numbers in single line with commas to Sort");

        return Console.ReadLine().Split(',').Select(Int32.Parse).ToList();
    }

    private static void SortAndDisplayList(List<int> numbersToSort, SortingAlgorithmNames algorithmName){
        Isorter sorter = null;
        List<int> result = new List<int>(0);

        switch (algorithmName)
        {
            case SortingAlgorithmNames.InsertionSort:
                sorter = new InsertionSorter();
                break;
            default:
                break;
        }

        if(sorter != null){
            result = sorter.Sort(numbersToSort);
        }

        DisplayTheSortedList(result);
    }

    public static void DisplayTheSortedList(List<int> sortedNumbers){
        StringBuilder sortedList = new StringBuilder();

        foreach(int number in sortedNumbers){
            sortedList.Append(number + ",");
        }

        sortedList.Remove(sortedList.Length - 1, 1);
        Console.WriteLine(sortedList);
    }
}