using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

/*
    Given a string and a list of words, find all the starting indices of substrings in the given string that are a 
    concatenation of all the given words exactly once without any overlapping of words. 
    It is given that all words are of the same length.

    Input: String="catfoxcat", Words=["cat", "fox"]
    Output: [0, 3]
    Explanation: The two substring containing both the words are "catfox" & "foxcat".

    Input: String="catcatfoxfox", Words=["cat", "fox"]
    Output: [3]
    Explanation: The only substring containing both the words is "catfox".

    Approach : Sliding Window

    1. Keep the frequency of every word in a HashMap.
    2. Starting from every index in the string, try to match all the words.
    3. In each iteration, keep track of all the words that we have already seen in another HashMap.
    4. If a word is not found or has a higher frequency than required, we can move on to the next character in the string.
    5. Store the index if we have found all the words.


*/

public class WordConcatenation
{
     public static List<int> FindWordConcatenation(String input, String[] words) {

         List<int> result = new List<int>();
         Dictionary<string,int> wordFrequencyMap = new Dictionary<string, int>();

         foreach(var strItem in words){
             if(!wordFrequencyMap.ContainsKey(strItem)){
                 wordFrequencyMap.Add(strItem,0);
             }
             wordFrequencyMap[strItem]++;
         }

         int wordLength = words[0].Length;
         int stringLength = input.Length;
         int wordCount = words.Length;

         //fixed size sliding window
         int left = 0;
         int right = stringLength -  wordLength * wordCount + 1;
         while(left < right){
             
             int windowEnd = left + wordLength * wordCount;
             if(IsConcat(input,left,windowEnd,wordLength,wordCount,wordFrequencyMap) ){
                 result.Add(left);
               
             }
            left++;
            

         }

        return result;
     }

        private static bool IsConcat(string input, int start, int end, int wordLength,int wordCount, Dictionary<string, int> wordFrequencyMap)
        {
            int matchedCount = 0;
            for(int i = start; i <end; i += wordLength){
                string subString = input.Substring(i,wordLength);
                if(wordFrequencyMap.ContainsKey(subString)){

                    matchedCount++;

                    if(matchedCount == wordCount){
                        break;
                    }
                   
                }
               
            }
            return matchedCount == wordCount;
        }
    }
}