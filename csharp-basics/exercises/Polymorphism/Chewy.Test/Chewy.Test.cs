using System;
using System.ComponentModel;
using System.Collections.Generic;
using Xunit;
using DragRace;

namespace Chewy.Test
{
    public class UnitTest1
    {
        [Fact]
        public void SpeedUp_ShouldIncreaseCurrentSpeedBy2()
        {
            //arrange
            var chewy = new DragRace.Chewy();
            var expected = 2;

            //act
            chewy.SpeedUp();
            var actual = chewy.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_ShouldDecreaseCurrentSpeedBy2()
        {
            //arrange
            var chewy = new DragRace.Chewy();
            chewy.Speed = 60;
            var expected = 58;

            //act
            chewy.SlowDown();
            var actual = chewy.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_ShouldReturn60AsString()
        {
            //arrange
            var chewy = new DragRace.Chewy();
            chewy.Speed = 60;
            var expected = "60";

            //act
            var actual = chewy.ShowCurrentSpeed();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowName_ShoudReturnChewy_AsString()
        {
            //arrange
            var chewy = new DragRace.Chewy();
            var expected = "Chewy";

            //act
            var actual = chewy.ShowName();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_ShouldReturnAchooo()
        {
            //arrange
            var chewy = new DragRace.Chewy();
            var expected = "..achooo...";

            //act
            var actual = chewy.StartEngine();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
