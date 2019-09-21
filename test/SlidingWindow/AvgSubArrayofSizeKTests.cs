using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{
    
    public class AvgSubArrayofSizeKTests{

        [Fact]
        public void FindAverageResultsInSuccess()
        {
            var input = new int[]{
                1, 3, 2, 6, -1, 4, 1, 8, 2
            };

            var result = AvgSubArrayofSizeK.FindAverage(5,input);

            Assert.NotNull(result);

        }

    }
}