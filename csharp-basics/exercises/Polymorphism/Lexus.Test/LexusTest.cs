using System;
using DragRace;
using Xunit;

namespace Lexus.Test
{
    public class LexusTest
    {
        [Fact]
        public void SpeedUp_ShouldIncreaseCurrentSpeedBy16()
        {
            //arrange
            var lexus = new DragRace.Lexus();
            var expected = 16;

            //act
            lexus.SpeedUp();
            var actual = lexus.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_ShouldDecreaseCurrentSpeedBy16()
        {
            //arrange
            var lexus = new DragRace.Lexus();
            lexus.Speed = 60;
            var expected = 44;

            //act
            lexus.SlowDown();
            var actual = lexus.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_ShouldReturn60AsString()
        {
            //arrange
            var lexus = new DragRace.Lexus();
            lexus.Speed = 60;
            var expected = "60";

            //act
            var actual = lexus.ShowCurrentSpeed();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowName_ShouldReturnBMW_AsString()
        {
            //arrange
            var lexus = new DragRace.Lexus();
            var expected = "Lexus";

            //act
            var actual = lexus.ShowName();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_ShouldReturnRrrrrrr()
        {
            //arrange
            var lexus = new DragRace.Lexus();
            var expected = "Rrrrrrr.....";

            //act
            var actual = lexus.StartEngine();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UseNitrousOxideEngine_ShouldIncreaseSpeedBy50()
        {
            //arrange
            var lexus = new DragRace.Lexus();
            lexus.Speed = 50;
            var expected = 100;

            //act
            lexus.UseNitrousOxideEngine();
            var actual = lexus.Speed;

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
