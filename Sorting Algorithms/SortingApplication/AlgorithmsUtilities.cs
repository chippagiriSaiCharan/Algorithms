using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms{
    public static class AlgorithmsUtilities{
        private static Dictionary<int, Type> sortingAlgorithmIndexer = new Dictionary<int, Type>{{1, typeof(InsertionSorter)}};

        public static int AlgorithmsCount{
            get{
                return sortingAlgorithmIndexer.Count;
            }
        }
        public static string FindAlgorithmsNames(){
            StringBuilder algorithmsNames = new StringBuilder();

            foreach(KeyValuePair<int, Type> algorithmIndexAndName in sortingAlgorithmIndexer){
                algorithmsNames.Append(algorithmIndexAndName.Key.ToString() + ". ");
                algorithmsNames.Append(algorithmIndexAndName.Value.Name + "\n");
            }
            return algorithmsNames.ToString();
        }   
        public static Isorter FindSortingAlgorithmBasedOn(int userPreference){
            Type algorithmType = sortingAlgorithmIndexer[userPreference];
            
            return (Isorter)Activator.CreateInstance(algorithmType);
        }
    }
}