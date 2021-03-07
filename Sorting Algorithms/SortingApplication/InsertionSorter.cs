using System.Collections.Generic;

namespace SortingAlgorithms{
    public class InsertionSorter : Isorter{
        public List<int>  Sort(List<int> numbersToSort){

            for(int keyIndex = 1; keyIndex < numbersToSort.Count; keyIndex++){
        
                int key = numbersToSort[keyIndex];
                int updateIndex = keyIndex;

                for(int predecessorIndex = keyIndex - 1; predecessorIndex >= 0; predecessorIndex--){

                    if(key > numbersToSort[predecessorIndex]){
                        break;
                    }

                    numbersToSort[predecessorIndex + 1] = numbersToSort[predecessorIndex];
                    updateIndex = predecessorIndex;
                }

                numbersToSort[updateIndex] = key;
            }

            return numbersToSort;
        } 
    }
}

