

using System;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{


public class StringPermutationTests{

[Fact]
public void FindPermutationSuccess(){

    var result = StringPermutation.FindPermutation("oidbcaf", "abc");
    Assert.Equal(result, true);


    result = StringPermutation.FindPermutation("oidbcaf", "abc");
    Assert.Equal(result, true);


    result = StringPermutation.FindPermutation("bcdxabcdy", "bcdyabcdx");
    Assert.Equal(result, true);



}

}

}