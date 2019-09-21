using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

/*
Given a string, find the length of the longest substring which has no repeating characters.
Input: String="aabccbb"
Output: 3
Explanation: The longest substring without any repeating characters is "abc".


This problem follows the Sliding Window pattern and we can use a similar dynamic sliding window strategy
 as discussed in Longest Substring with K Distinct Characters. We can use a HashMap to remember the last 
 index of each character we have processed. Whenever we get a repeating character we will shrink our 
 sliding window to ensure that we always have distinct characters in the sliding window.

*/
public class NoRepeatSubsString{

    public static int FindLength(String input) {

        int result = 0;
        int windowStart = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();

        for(int windowEnd =0; windowEnd < input.Length; windowEnd++){
            var rightChar = input[windowEnd];
            //shrink the window so that there is only one occurence of rightChar
            if(charIndexMap.ContainsKey(rightChar)){
                //if windowsStart is ahead of the last index of rightChar, keep windowStart
                windowStart = Math.Max(windowStart, charIndexMap[rightChar] + 1) ;
            }else{
                //insert the rightChar with its index
                charIndexMap.Add(rightChar, windowEnd);
            }
            //remember the maxLength so far

            result = Math.Max(result, windowEnd - windowStart + 1);
        }

        return result;

    }
}

}