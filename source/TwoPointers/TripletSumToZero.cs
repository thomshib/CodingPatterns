
using System;
using System.Collections.Generic;

namespace Source.TwoPointers

{
    /*
    
    Given an array of unsorted numbers, find all unique triplets in it that add up to zero.

    Input: [-3, 0, 1, 2, -1, 1, -2]
    Output: [-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]
    Explanation: There are four unique triplets whose sum is equal to zero.
    
    
    Approach : Reduce this to a two pointer problem and then solve it using the approach in PairwithTargetSum.cs 
    1. Sort the array
    2. Iterate through it taking one number at a time. 
        Let’s say during our iteration we are at number ‘X’, so we need to find ‘Y’ and ‘Z’ 
        such that X + Y + Z = 0.
         At this stage, our problem translates into finding a pair whose sum is equal to
          “−X” (as from the above equation Y+Z = −X).
    
    
    */

public class TripletSumToZero{
    public static List<List<int>> SearchTriplets(int[] input) {

        List<List<int>> result = new List<List<int>>();
        int N = input.Length;

        Array.Sort(input);

        for(int i = 0 ; i < N - 2 ; i++){
            //skip same elements to avoid duplicates
            if( i > 0 && input[i] == input[i-1]) continue;

            SearchPair(input, -input[i], i+1,N, result);
        }

        return result;



    }

        private static void SearchPair(int[] input, int targetSum, int left, int N, List<List<int>> result)
        {
            int right = N - 1;
            while(left < right){
                // comparing the sum of two numbers to the 'targetSum' can cause integer overflow
                // so, we will try to find a target difference instead
                int targetDiff = targetSum - input[left];
                if(targetDiff == input[right]){
                    result.Add(new List<int>{-targetSum, input[left], input[right]});

                    left++;
                    right--;
                    while(left < right && input[left] == input[left - 1]){
                        left++; //avoid duplicates
                    }
                    while(left < right && input[right] == input[right + 1]){
                        right--; //avoid duplicates
                    }
                }else if(targetDiff > input[right]){
                    left++;  //need to pair with a bigger sum
                }else{
                    right--; //need to pair with a smaller sum
                }

            }
        }
    }

}