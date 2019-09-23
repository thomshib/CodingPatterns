using System;
using System.Collections.Generic;
using Source.SlidingWindow;
using Xunit;
namespace Test.SlidingWindow
{

public class StringAnagramsTests{


    [Fact]
    public void FindStringAnagrams(){

    var expectedResult = new List<int>{1,2};
    var result = StringAnagrams.FindStringAnagrams("ppqp", "pq");
    Assert.Equal(result, expectedResult);



    }

}

}