using System;
namespace Source.SlidingWindow
{
    

//Given an array, find the average of all subarrays of size ‘K’ in it.
//Array: [1, 3, 2, 6, -1, 4, 1, 8, 2], K=5
//Output: [2.2, 2.8, 2.4, 3.6, 2.8]

// Approach: Sliding Window Pattern

public class AvgSubArrayofSizeK{

    public static double[] FindAverage(int k, int[] input){
        
        int N = input.Length;
        double[] result = new double[N - k + 1];

        double windowSum = 0;
        int windowStart = 0;
        for(int windowEnd = 0; windowEnd < N ; windowEnd++){

            windowSum += input[windowEnd] ; //add the next element

            //slide the window; don't slide until the window size is of size k
            if(windowEnd >= k-1){
                result[windowStart] = windowSum / k; //caculate the average
                windowSum -= input[windowStart]; //substract the element going out
                windowStart++; //slide the window ahead

            }
        }

        return result;


    }
}

}