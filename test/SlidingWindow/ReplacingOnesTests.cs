
using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class ReplacingOnesTests{

    [Fact]
    public void FindLengthResultsInSuccess(){

        var input = new int[]{0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1};
        var result = ReplacingOnes.FindLength(input, 2);
          Assert.Equal(result,6);

        input = new int[]{0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1};
        result = ReplacingOnes.FindLength(input, 3);
        Assert.Equal(result,9);


    }


}
}
