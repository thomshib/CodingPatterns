using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class LongestSubstringWithKCharsTests{
      [Fact]
        public void FindLengthResultsInSuccess()
        {
            

            var result = LongestSubstringWithKChars.FindLength("araaci",2);

            Assert.Equal(result,4);

        }
}

}