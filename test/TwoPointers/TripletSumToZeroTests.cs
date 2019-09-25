using System;
using System.Collections.Generic;
using Source.TwoPointers;
using Xunit;
namespace Test.TwoPointers
{

public class TripletSumToZeroTests{

    [Fact]
    public void SearchTripletsSuccess(){

        var input  = new int[]{-3, 0, 1, 2, -1, 1, -2};
        var expectedResult = new List<List<int>>{
            new List<int>{-3, 1, 2},
            new List<int>{-2, 0, 2}, 
            new List<int>{-2, 1, 1}, 
            new List<int>{-1, 0, 1}
        };

        var result = TripletSumToZero.SearchTriplets(input);

        Assert.NotNull(result);


    }

}

}