using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class NoRepeatSubsStringTests{
        [Fact]
        public void FindLengthResultsInSuccess()
        {
            

            var result = NoRepeatSubsString.FindLength("aabccbb");

            Assert.Equal(result,3);

        }
}

}