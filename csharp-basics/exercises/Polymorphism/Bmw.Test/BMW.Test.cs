using System;
using System.ComponentModel;
using System.Collections.Generic;
using DragRace;
using Xunit;

namespace BMW.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SpeedUp_ShouldIncreaseCurrentSpeedBy20()
        {
            //arrange
            Bmw bmw = new Bmw();
            var expected = 20;

            //act
            bmw.SpeedUp();
            var actual = bmw.Speed;

            //assert
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void SlowDown_ShouldDecreaseCurrentSpeedBy20()
        {
            //arrange
            Bmw bmw = new Bmw();
            bmw.Speed = 60;
            var expected = 40;

            //act
            bmw.SlowDown();
            var actual = bmw.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_ShouldReturn40AsString()
        {
            //arrange
            Bmw bmw = new Bmw();
            bmw.Speed = 60;
            var expected = "60";

            //act
            var actual = bmw.ShowCurrentSpeed();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowName_ShouldReturnBMW_AsString()
        {
            //arrange
            Bmw bmw = new Bmw();
            var expected = "BMW";

            //act
            var actual = bmw.ShowName();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_ShouldReturnRrrrrrr()
        {
            //arrange
            Bmw bmw = new Bmw();
            var expected = "Rrrrrrr.....";

            //act
            var actual = bmw.StartEngine();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UseNitrousOxideEngine_ShouldIncreaseSpeedBy50()
        {
            //arrange
            Bmw bmw2 = new Bmw();
            bmw2.Speed = 50;
            var expected = 100;

            //act
            bmw2.UseNitrousOxideEngine();
            var actual = bmw2.Speed;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
