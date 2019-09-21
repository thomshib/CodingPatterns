using System;
using System.Collections.Generic;

namespace Source.SlidingWindow
{

    /*
    Given a string with lowercase letters only, if you are allowed to replace no more than ‘k’ letters with any letter, 
    find the length of the longest substring having the same letters after replacement.

    Input: String="aabccbb", k=2
    Output: 5
    Explanation: Replace the two 'c' with 'b' to have a longest repeating substring "bbbbb".

    Input: String="abbcb", k=1
    Output: 4
    Explanation: Replace the 'c' with 'b' to have a longest repeating substring "bbbb".

    Input: String="abccde", k=1
    Output: 3
    Explanation: Replace the 'b' or 'd' with 'c' to have the longest repeating substring "ccc".
    
    Approach
    1. Iterate through the string to add one letter at a time in the window.

    2. Keep track of the count of the maximum repeating letter in any window 
        (let’s call it maxRepeatLetterCount). 
        So at any time, we know that we can have a window which has one letter 
        repeating maxRepeatLetterCount times, this means we should try to replace the remaining letters. 
        
    3. If we have more than ‘k’ remaining letters, we should shrink the window as we are not allowed to replace more than ‘k’ letters.
    
    
    */

public class CharacterReplacement{
    public static int FindLength(String input, int k) {

        int result = 0;
        int maxRepeatLetterCount = 0;
        int windowStart = 0;
        Dictionary<char, int> charFrequencyMap = new Dictionary<char, int>();

        for(int windowEnd =0; windowEnd < input.Length; windowEnd++){
            var rightChar = input[windowEnd];
            if(!charFrequencyMap.ContainsKey(rightChar)){
                charFrequencyMap.Add(rightChar,0);
            }
            charFrequencyMap[rightChar]++;
            maxRepeatLetterCount = Math.Max(maxRepeatLetterCount,charFrequencyMap[rightChar]);

            // current window size is from windowStart to windowEnd, 
            // we have a letter which is repeating 'maxRepeatLetterCount' times, 
            // this means we can have a window which has one letter repeating 'maxRepeatLetterCount' times 
            // and the remaining letters we should replace.
            // if the remaining letters are more than 'k', it is the time to shrink the window as we
            // are not allowed to replace more than 'k' letters
            int windowLength = windowEnd - windowStart + 1;
            if(windowLength - maxRepeatLetterCount > k){
                var leftChar = input[windowStart];
                charFrequencyMap[leftChar]--;
                windowStart++;
            }

            result = Math.Max(result, windowLength);

        }



        return result;

    }

}
}