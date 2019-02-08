using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = 5.0;
            var a = 10;
            var b = 2;
            var actual = Divide(a, b);
            Assert.Equal(expected, atual);
        }

        [Theory]
        [InlineData(2.0,8,4)]
        [InlineData(3.0,6,2)]
        [InlineData(7.5,15,2)]
        public void DivideTest(double exp, int n1, int n2)
            {
            Assert.Equal(exp, Divide(n1, n2));
}
        double Divide(int x, int y)
            {
            return x/y;

}
    }
}
