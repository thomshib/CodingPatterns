using System;
using System.Collections.Generic;

namespace Source.TwoPointers

{
    /*
    Given an array of sorted numbers and a target sum, find a pair in the array whose sum is equal to the given target.

    Write a function to return the indices of the two numbers (i.e. the pair) such that they add up to the given target.

    Input: [1, 2, 3, 4, 6], target=6
    Output: [1, 3]
    Explanation: The numbers at index 1 and 3 add up to 6: 2+4=6


    Input: [2, 5, 9, 11], target=11
    Output: [0, 2]
    Explanation: The numbers at index 0 and 2 add up to 11: 2+9=11

    Approach : Two Pointers

    Start with one pointer pointing to the beginning of the array and another pointing at the end. 
    At every step, we will see if the numbers pointed by the two pointers add up to the target sum. 
    If they do, we have found our pair. Otherwise, we will do one of two things:

    1. If the sum of the two numbers pointed by the two pointers is greater than the target sum, 
    this means that we need a pair with a smaller sum. So, to try more pairs, we can decrement the end-pointer.

    2. If the sum of the two numbers pointed by the two pointers is smaller than the target sum, 
    this means that we need a pair with a larger sum. So, to try more pairs, we can increment the start-pointer.
    
    Analysis: Time complexity i O(N); Space Complexity is O(1)
    
    
    */

public class PairWithTargetSum{
     public static int[] Search(int[] input, int targetSum) {
         int left = 0;
         int right = input.Length - 1;

         while(left < right){
             // comparing the sum of two numbers to the 'targetSum' can cause integer overflow
             // so, we will try to find a target difference instead

             int targetDiff = targetSum - input[left];

             if(targetDiff == input[right]){
                 return new int[]{left,right};
             }else if(targetDiff > input[right]){
                 //we need a pair with bigger sum
                 left++;
             }else{
                 right --;
             }
         }


        return new int[]{-1,-1};
     }


     //Alternate approach
     /*
     Utilize a HashTable to search for the required pair. We can iterate through the array one number 
     at a time. Let’s say during our iteration we are at number ‘X’, so we need to find ‘Y’ such that 
     “X + Y == TargetX+Y==Target”. We will do two things here:

    1. Search for ‘Y’ (which is equivalent to “Target - X”) in the HashTable. If it is there, we have found the required pair.
    2.    Otherwise, insert “X” in the HashTable, so that we can search it for the later numbers.
     
     Analysis: Time complexity i O(N); Space Complexity is O(N)
     
     */

     public static int[] SearchDictionaryApproach(int[] input, int targetSum) {
         Dictionary<int,int> numberIndexMap = new Dictionary<int, int>();

         for(int i = 0; i < input.Length; i++){
             var y = targetSum - input[i];

             if(numberIndexMap.ContainsKey(y)){
                 return new int[]{numberIndexMap[y],i};
             }
             numberIndexMap.Add(input[i],i);

         }

         return new int[]{-1,-1};
     }
}

}