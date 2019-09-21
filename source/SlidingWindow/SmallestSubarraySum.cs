using System;

namespace Source.SlidingWindow
{

/*

Problem Statement
Given an array of positive numbers and a positive number ‘S’, find the length of the smallest subarray whose sum is greater than or equal to ‘S’. Return 0, if no such subarray exists.

Input: [2, 1, 5, 2, 3, 2], S=7 
Output: 2
Explanation: The smallest subarray with a sum great than or equal to '7' is [5, 2].


*/
    public class SmallestSubArraySum{

         public static int FindMinSubArray(int total, int[] input) {

            int N = input.Length;
            int result = int.MaxValue;
            int sum = 0;
            int windowStart = 0;
            for(int windowEnd = 0; windowEnd < N; windowEnd++){
                sum += input[windowEnd];

                while(sum >= total){
                    result = Math.Min(result, windowEnd - windowStart + 1);
                    //reduce sum by the element going out
                    sum -= input[windowStart];
                    //slide the window ahead
                    windowStart++;
                    
                }
            }
            
             
             return result == int.MaxValue ? 0: result;

         }
    }

}