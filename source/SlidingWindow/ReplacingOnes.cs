
using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

    /*
    Given an array containing 0s and 1s, if you are allowed to replace no more than ‘k’ 0s with 1s, 
    find the length of the longest subarray having all 1s.
    
    Input: Array=[0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1], k=2
    Output: 6
    Explanation: Replace the '0' at index 5 and 8 to have the longest subarray of 1s having length 6.
    
    Input: Array=[0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1], k=3
    Output: 9
    Explanation: Replace the '0' at index 6, 9, and 10 to have the longest subarray of 1s having length 9.
    
    Approach:
        Iterate through the array to add one number at a time in the window. 

        Keep track of the maximum number of repeating 1s in the current window (let’s call it maxOnesCount).

        At any time, we know that we can have a window which has 1s repeating maxOnesCount time, 
        so we should try to replace the remaining 0s. 

        If we have more than ‘k’ remaining 0s, we should shrink the window as we are not allowed to replace 
        more than ‘k’ 0s.

    */

public class ReplacingOnes{

     public static int FindLength(int[] input, int k) {
        int maxOnesCount = 0;
        int windowStart = 0;
        int result = 0;

        for(int windowEnd =0; windowEnd < input.Length; windowEnd++){
            
            if(input[windowEnd] == 1){
                maxOnesCount++;
            }
            int windowLength = windowEnd - windowStart + 1;

            // current window size is from windowStart to windowEnd, overall we have a maximum of 1s
            // repeating a maximum of 'maxOnesCount' times, this means that we can have a window with
            // 'maxOnesCount' 1s and the remaining are 0s which should replace with 1s.
            // now, if the remaining 0s are more than 'k', it is the time to shrink the window as we
            // are not allowed to replace more than 'k' Os
            if(windowLength - maxOnesCount > k){

                if(input[windowStart] == 1){
                    maxOnesCount--;
                }
                windowStart++;
            }
            result = Math.Max(result, windowLength);
        }

        return result;

     }

}


}