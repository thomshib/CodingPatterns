using System;
using System.Collections.Generic;
using Source.TwoPointers;
using Xunit;
namespace Test.TwoPointers
{

public class RemoveDuplicatesTests{

    [Fact]
    public void FindDuplicateSuccess(){

        var input = new int[]{2, 3, 3, 3, 6, 9, 9};

        var result = RemoveDuplicates.Remove(input);

        Assert.Equal(result,4);
    }

}

}