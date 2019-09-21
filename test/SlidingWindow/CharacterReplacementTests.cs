using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class CharacterReplacementTests{

    [Fact]
    public void FindLengthResultsInSuccess(){

        var result = CharacterReplacement.FindLength("aabccbb", 2);

        Assert.Equal(result,5);

        result = CharacterReplacement.FindLength("abbcb", 1);
        Assert.Equal(result,4);
      
    }

}

}
