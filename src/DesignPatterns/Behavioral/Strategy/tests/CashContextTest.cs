using System;
using Xunit;

namespace Design.Strategy.Tests
{
    public class CashContextTest
    {

        [Theory]
        [InlineData("Normal", 100, 100)]
        [InlineData("Rebate", 100, 80)]
        [InlineData("Return", 300, 200)]
        [InlineData("Return", 301, 201)]
        [InlineData("Return", 600, 400)]
        public void Run_ContextInterface_Success(string type, double money, double expected)
        {
            // arrange

            var context = new CashContext(type);

            // act

            var actual = context.ContextInterface(money);

            // assert

            Assert.Equal(expected, actual);
        }
    }
}
