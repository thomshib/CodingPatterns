using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

/*
    Given a string, find the length of the longest substring in it with no more than K distinct characters.
    Input: String="araaci", K=2
    Output: 4
    Explanation: The longest substring with no more than '2' distinct characters is "araa".

    //Approach
    1. First, we will insert characters from the beginning of the string until we have ‘K’ distinct 
            characters in the HashMap.

    2. These characters will constitute our sliding window. We are asked to find the longest such window 
        having no more than ‘K’ distinct characters. We will remember the length of this window as the 
        longest window so far.

    3. After this, we will keep adding one character in the sliding window (i.e. slide the window ahead), 
    in a stepwise fashion.

    4. In each step, we will try to shrink the window from the beginning if the count of 
    distinct characters in the HashMap is larger than ‘K’. We will shrink the window until 
    we have no more than ‘K’ distinct characters in the HashMap. This is needed as we intend 
    to find the longest window.

    5. While shrinking, we’ll decrement the frequency of the character going out of the window 
    and remove it from the HashMap if its frequency becomes zero.

    6. At the end of each step, we’ll check if the current window length is the longest so far, 
    and if so, remember its length.



*/
public class LongestSubstringWithKChars{
     public static int FindLength(String input, int k) {
         int result = 0;
         int windowStart = 0;

         Dictionary<char,int> charFrequencyMap = new Dictionary<char, int>();

         for(int windowEnd = 0; windowEnd < input.Length ; windowEnd++){

             var rightChar = input[windowEnd];

             if(!charFrequencyMap.ContainsKey(rightChar)){
                  charFrequencyMap.Add(rightChar,0);
             }
             charFrequencyMap[rightChar]++;

             while(charFrequencyMap.Count > k){
                //shrink the sliding window untill we are left with 'K' distinct chars

                var leftChar = input[windowStart];
                charFrequencyMap[leftChar]--;
                if(charFrequencyMap[leftChar] == 0){
                    charFrequencyMap.Remove(leftChar);
                }
                //shrink the window
                windowStart++;
             }

             result = Math.Max(result, windowEnd - windowStart + 1);

         }

         return result;
    
  }
}
}