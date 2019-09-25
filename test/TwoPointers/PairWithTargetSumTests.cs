using System;
using System.Collections.Generic;
using Source.TwoPointers;
using Xunit;
namespace Test.TwoPointers
{

public class PairWithTargetSumTests{

    [Fact]
    public void SearchSuccess(){

        var input = new int[]{1, 2, 3, 4, 6};
        var targetSum = 6;
        var expectedResult = new int[]{1, 3};

        var result = PairWithTargetSum.Search(input,targetSum);
        Assert.Equal(result,expectedResult);


        input = new int[]{2, 5, 9, 11};
        targetSum = 11;
        expectedResult = new int[]{0,2};

        result = PairWithTargetSum.Search(input,targetSum);
        Assert.Equal(result,expectedResult);





    }


     [Fact]
    public void SearchDictionaryApproachSuccess(){

        var input = new int[]{1, 2, 3, 4, 6};
        var targetSum = 6;
        var expectedResult = new int[]{1, 3};

        var result = PairWithTargetSum.SearchDictionaryApproach(input,targetSum);
        Assert.Equal(result,expectedResult);


        input = new int[]{2, 5, 9, 11};
        targetSum = 11;
        expectedResult = new int[]{0,2};

        result = PairWithTargetSum.SearchDictionaryApproach(input,targetSum);
        Assert.Equal(result,expectedResult);





    }

}
}