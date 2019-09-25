using System;
using System.Collections.Generic;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class WordConcatenationTests{

    [Fact]
    public void FindWordConcatenationSuccess(){
        var input ="catfoxcat";
        var words = new string[]{"cat", "fox"};
        var expectedResult = new List<int>{0, 3};

        var result = WordConcatenation.FindWordConcatenation(input,words);

        Assert.Equal(result,expectedResult);
        

    }

}

}