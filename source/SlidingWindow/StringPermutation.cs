
using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{
/*
    Given a string and a pattern, find out if the string contains any permutation of the pattern.

    Input: String="oidbcaf", Pattern="abc"
    Output: true
    Explanation: The string contains "bca" which is a permutation of the given pattern.

    Input: String="odicf", Pattern="dc"
    Output: false
    Explanation: No permutation of the pattern is present in the given string as a substring.

    Input: String="bcdxabcdy", Pattern="bcdyabcdx"
    Output: true
    Explanation: Both the string and the pattern are a permutation of each other.


    Approach: Sliding Window Pattern
    1. Create a HashMap to calculate the frequencies of all characters in the pattern.

    2. Iterate through the string, adding one character at a time in the sliding window.

    3. If the character being added matches a character in the HashMap, decrement its frequency in the map. 
        If the character frequency becomes zero, we got a complete match.
    
    4. If at any time, the number of characters matched is equal to the number of distinct characters in the pattern 
        (i.e., total characters in the HashMap), we have gotten our required permutation.
    
    5. If the window size is greater than the length of the pattern, shrink the window to make it equal to the size of the pattern.
     At the same time, if the character going out was part of the pattern, put it back in the frequency HashMap.







*/

public class StringPermutation{

    public static bool FindPermutation(String input, String pattern) {
       
        int windowStart = 0;
        int matchCount = 0;

        Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();

        //intialize charMap with pattern
        foreach(var charItem in pattern){

            if(!charFrequencyMap.ContainsKey(charItem)){
                charFrequencyMap.Add(charItem,0);
            }
            charFrequencyMap[charItem]++;
        }

        for(int windowEnd = 0; windowEnd < input.Length; windowEnd++){

            var rightChar = input[windowEnd];

            if(charFrequencyMap.ContainsKey(rightChar)){

                //decrement the frequency
                charFrequencyMap[rightChar]--;
                if(charFrequencyMap[rightChar] == 0){
                    matchCount++;
                }
            }

            if(matchCount == charFrequencyMap.Count){
                return true;
            }

            //shrink the window

            if(windowEnd >= pattern.Length - 1){
                char leftChar = input[windowStart];

                if(charFrequencyMap.ContainsKey(leftChar)){

                    if(charFrequencyMap[leftChar] == 0){
                        matchCount--; 
                    }
                    charFrequencyMap[leftChar]++;
                }
                windowStart++;
            }

        }



        return false;

    }

}

}