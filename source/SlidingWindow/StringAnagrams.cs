using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

public class StringAnagrams
{

    /*
        Given a string and a pattern, find all anagrams of the pattern in the given string.
        Anagram is actually a Permutation of a string. 
        For example, “abc” has the following six anagrams:

        abc
        acb
        bac
        bca
        cab
        cba

        Write a function to return a list of starting indices of the anagrams of the pattern in the given string.

        Input: String="ppqp", Pattern="pq"
        Output: [1, 2]
        Explanation: The two anagrams of the pattern in the given string are "pq" and "qp".

        Input: String="abbcabc", Pattern="abc"
        Output: [2, 3, 4]
        Explanation: The three anagrams of the pattern in the given string are "bca", "cab", and "abc".

        Approach : Sliding Window Pattern

        This is similar to StringPermutation approach see StringPermutations.cs file
    
    
    
    */
     public static List<int> FindStringAnagrams(String input, String pattern) {

         int matchCount = 0;
         int windowStart = 0;
         List<int> result = new List<int>();
         Dictionary<char,int> charFrequencyMap = new Dictionary<char, int>();

        //initialize
         foreach(var charItem in pattern){
             if(!charFrequencyMap.ContainsKey(charItem)){
                 charFrequencyMap.Add(charItem,0);
             }
             charFrequencyMap[charItem]++;
         }


         for(int windowEnd = 0; windowEnd < input.Length; windowEnd++){
            char rightChar = input[windowEnd];

            if(charFrequencyMap.ContainsKey(rightChar)){
                charFrequencyMap[rightChar]--;

                if(charFrequencyMap[rightChar] == 0){
                    matchCount++;
                }
            }

            //have we found an anagram
            if(matchCount == charFrequencyMap.Count){
                result.Add(windowStart);
            }

            //shrink the window
            if(windowEnd >= pattern.Length - 1){
                var leftChar = input[windowStart];

                if(charFrequencyMap.ContainsKey(leftChar)){
                    if(charFrequencyMap[leftChar] == 0){
                        matchCount--;
                    }
                    //put the char back
                    charFrequencyMap[leftChar]++;
                }
                windowStart++;
            }


         }
         
         
         
        return result;

     }

}

}