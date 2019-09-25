using System;
using System.Collections.Generic;
using Source.TwoPointers;
using Xunit;
namespace Test.TwoPointers
{



public class SortedArraySquaresTests{

    [Fact]
 public void MakeSquaresSucess(){

     var input = new int[]{-2, -1, 0, 2, 3};
     var expectedResult = new int[]{0, 1, 4, 4, 9};

     var result = SortedArraySquares.MakeSquares(input);
     Assert.Equal(result,expectedResult);
     
      }

}

}