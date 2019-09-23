


using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class MinimumWindowSubstringTests{

    [Fact]
public void FindSubstringSuccess(){

    var result = MinimumWindowSubstring.FindSubstring("aabdec", "abc");
    Assert.Equal(result, "abdec");

    result = MinimumWindowSubstring.FindSubstring("abdabca", "abc");
    Assert.Equal(result, "abc");


    result = MinimumWindowSubstring.FindSubstring("adcad", "abc");
    Assert.Equal(result, String.Empty);

}
}

}