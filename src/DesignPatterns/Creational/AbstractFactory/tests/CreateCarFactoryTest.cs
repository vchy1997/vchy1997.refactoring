using System;
using Xunit;

namespace Design.AbstractFactory.Tests
{
    public class CreateCarFactoryTest
    {
        [Fact]
        public void Run_GetChinaCarFactory_Success()
        {
            //arrange
            var expected = "china";
            CarFactory factory = new ChinaCarFactory();
            var car = factory.GetCar();

            //act

            var actual = car.GetCarOrigin();

            //assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Run_GetAmericaCarFactory_Success()
        {
            //arrange
            var expected = "america";
            CarFactory factory = new AmericaCarFacotry();
            var car = factory.GetCar();

            //act

            var actual = car.GetCarOrigin();

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
