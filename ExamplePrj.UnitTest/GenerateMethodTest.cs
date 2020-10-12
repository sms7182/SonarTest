

using Xunit;

namespace ExamplePrj.UnitTest
{
    public class GenerateMethodTest
    {

        [Fact]
        public void SumOperatorTest()
        {
           
            var d=GenerateMethod.Sum(1, 3);
            Assert.Equal(1+3, d);
        }
        [Fact]
        public void SubOperatorTest()
        {

            var d = GenerateMethod.Sub(1, 3);
            Assert.Equal(1 -3, d);
        }
    }
}
