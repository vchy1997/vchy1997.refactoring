using Design.FactoryMehtod;
using System;
using Xunit;

namespace Design.FactoryMethod.Tests
{
    public class CarFactoryTest
    {
        [Theory]
        [InlineData("porsche", "porsche")]
        [InlineData("bmw", "bmw")]
        public void Run_GetCarBrand_Success(string brand, string expected)
        {
            // arrange
            var car = CarFactory.GetCar(brand);

            //act

            var actual = car.GetCarBrand();

            //assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("audi", "invalid argument audi")]
        public void Run_GetCarBrand_ArgumanetException(string brand, string expected)
        {
            // arrange

            //act

            Func<Car> act = () => CarFactory.GetCar(brand);

            //assert

            var actual = Assert.Throws<ArgumentException>(act).Message;
            Assert.Equal(expected, actual);
        }
    }
}
