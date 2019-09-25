using System;
using System.Collections.Generic;

namespace Source.TwoPointers

{
    /*
    
    Given an array of sorted numbers, remove all duplicates from it. 
    You should not use any extra space; 
    after removing the duplicates in-place return the new length of the array.

    Input: [2, 3, 3, 3, 6, 9, 9]
    Output: 4
    Explanation: The first four elements after removing the duplicates will be [2, 3, 6, 9].


    Approach:
     As the input array is sorted, therefore, one way to do this is to shift the elements left 
     whenever we encounter duplicates. In other words, we will keep one pointer for iterating the array 
     and one pointer for placing the next non-duplicate number.
    
    
    
    
    
    */

public class RemoveDuplicates{

    public static int Remove(int[] input) {
        int nextNonDuplicateIndex = 1;

        for(int i = 1; i < input.Length; i++){

            if(input[i] != input[i-1]){
                input[nextNonDuplicateIndex]  = input[i];
                nextNonDuplicateIndex++;
            }
        }

        return nextNonDuplicateIndex;
    }

}

}