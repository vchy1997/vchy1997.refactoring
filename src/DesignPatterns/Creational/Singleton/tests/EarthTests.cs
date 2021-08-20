using System;
using System.IO;
using Xunit;

namespace Design.Singleton.Tests
{
    public class EarthTests
    {
        [Fact]
        public void Runt_Earth_GetInstance_Success()
        {
            // arrange

            // act

            var earthA = Earth.GetInstance();

            var earthB = Earth.GetInstance();

            // assert

            Assert.Equal(earthA, earthB);
        }
    }
}
