using System;
using System.Collections.Generic;
using DragRace;
using Xunit;

namespace Audi.Test
{
    public class AudiTest
    {
        [Fact]
        public void SpeedUp_CurrentSpeedShouldIncreaseBy10()
        {
            //arrange
            var audi = new DragRace.Audi();
            audi.Speed = 0;
            var expected = 10;

            //act
            audi.SpeedUp();
            var actual = audi.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_ShouldDecreaseCurrentSpeedBy10()
        {
            //arrange
            var audi = new DragRace.Audi();
            audi.Speed = 60;
            var expected = 50;

            //act
            audi.SlowDown();
            var actual = audi.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_ShouldReturn45AsString()
        {
            //arrange
            var audi = new DragRace.Audi();
            audi.Speed = 45;
            var expected = "45";

            //act
            var actual = audi.ShowCurrentSpeed();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowName_ShoudReturnAudi_AsString()
        {
            //arrange
            var audi = new DragRace.Audi();
            var expected = "Audi";

            //act
            var actual = audi.ShowName();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_ShouldReturnRrrrrrr()
        {
            //arrange
            var audi = new DragRace.Audi();
            var expected = "Rrrrrrr.....";

            //act
            var actual = audi.StartEngine();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
