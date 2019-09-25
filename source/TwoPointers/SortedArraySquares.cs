
using System;
using System.Collections.Generic;

namespace Source.TwoPointers

{
    /*
    
    Given a sorted array, 
    create a new array containing squares of all the number of the input array in the sorted order
    
    Input: [-2, -1, 0, 2, 3]
    Output: [0, 1, 4, 4, 9]

    Approach:
    Since the numbers at both the ends can give us the largest square, an alternate approach 
    could be to use two pointers starting at both the ends of the input array. 
    At any step, whichever pointer gives us the bigger square we add it to the result array 
    and move to the next/previous number according to the pointer
    
    
    
    */

public class SortedArraySquares
{
    public static int[] MakeSquares(int[] input) {
        int N = input.Length;
        var result = new int[N];
        int largestSquareIndex = N - 1;
        int left = 0;
        int right = N -1;

        while(left <= right){

            int leftSquare = input[left] * input[left];
            int rightSquare = input[right] * input[right];
            if(leftSquare > rightSquare){
                result[largestSquareIndex] = leftSquare;
                largestSquareIndex--;
                left++;
            }else{
                result[largestSquareIndex] = rightSquare;
                largestSquareIndex--;
                right--;
            }
        }

        return result;
    }


}
}