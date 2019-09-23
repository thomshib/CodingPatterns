using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

/*
    Given a string and a pattern, find the smallest substring in the given string 
    which has all the characters of the given pattern.

    Input: String="aabdec", Pattern="abc"
    Output: "abdec"
    Explanation: The smallest substring having all characters of the pattern is "abdec"

    Input: String="abdabca", Pattern="abc"
    Output: "abc"
    Explanation: The smallest substring having all characters of the pattern is "abc".


    Input: String="adcad", Pattern="abc"
    Output: ""
    Explanation: No substring in the given string has all characters of the pattern.


    Approach : Sliding Window

    Similar to string permutation. See StringPermutation.cs with the following differences

    1. Keep a running count of every matching instance of a character.

    2. Whenever we have matched all the characters, we will try to shrink the window from the beginning,
     keeping track of the smallest substring that has all the matching characters.

    3. We will stop the shrinking process as soon as we remove a matched character from the sliding window.
      One thing to note here is that we could have redundant matching characters, 
      e.g., we might have two ‘a’ in the sliding window when we only need one ‘a’. 
      In that case, when we encounter the first ‘a’, we will simply shrink the window 
      without decrementing the matched count. We will decrement the matched count 
      when the second ‘a’ goes out of the window.

*/

public class MinimumWindowSubstring{

     public static String FindSubstring(String input, String pattern) {
        int windowStart = 0;
        int minLength = int.MaxValue;
        int substringStartIndex = 0;
        int matchedCount = 0;
        Dictionary<char,int> charFrequencyMap = new Dictionary<char, int>();

        foreach(var charItem in pattern){
            if(!charFrequencyMap.ContainsKey(charItem)){
                charFrequencyMap.Add(charItem,0);
            }
            charFrequencyMap[charItem]++;
        }

        for(int windowEnd = 0; windowEnd < input.Length; windowEnd++){

            var rightChar = input[windowEnd];
            if(charFrequencyMap.ContainsKey(rightChar)){
                charFrequencyMap[rightChar]--;

                //count every matching of a character
                if(charFrequencyMap[rightChar] >= 0 ){
                    matchedCount++;
                }
            }

            //shrink the window if we can, finish as soon as we remove a matched charater
            while(matchedCount == pattern.Length){


                //determine the min window
                if(minLength > windowEnd - windowStart + 1){
                    minLength = windowEnd - windowStart + 1;
                    substringStartIndex = windowStart;
                }

                //shrink the window
                var leftChar = input[windowStart];
                windowStart++;
                if(charFrequencyMap.ContainsKey(leftChar)){

                    if(charFrequencyMap[leftChar] == 0){
                        // count only when the last occurrence of a matched character is going out of the window
                        matchedCount--;
                    }
                    //add the char back
                    charFrequencyMap[leftChar]++;
                }
            }

        }

        return minLength == int.MaxValue ? string.Empty : input.Substring(substringStartIndex,minLength);

    }
}

}