using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{

    public class SmallestSubArraySumTests{

         [Fact]
        public void FindMinSubArraySuccess()
        {
            var input = new int[]{
                2, 1, 5, 2, 3, 2
            };

            var result = SmallestSubArraySum.FindMinSubArray(7,input);

            Assert.Equal(2,result);



        }
    }


}