using System;
using Xunit;

namespace Tesla.Test
{
    public class TeslaTest
    {
        [Fact]
        public void SpeedUp_CurrentSpeedShouldIncreaseBy30()
        {
            //arrange
            var tesla = new DragRace.Tesla();
            tesla.Speed = 0;
            var expected = 30;

            //act
            tesla.SpeedUp();
            var actual = tesla.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_ShouldDecreaseCurrentSpeedBy30()
        {
            //arrange
            var tesla = new DragRace.Tesla();
            tesla.Speed = 60;
            var expected = 30;

            //act
            tesla.SlowDown();
            var actual = tesla.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_ShouldReturn80AsString()
        {
            //arrange
            var tesla = new DragRace.Tesla();
            tesla.Speed = 80;
            var expected = "80";

            //act
            var actual = tesla.ShowCurrentSpeed();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowName_ShoudReturnTesla_AsString()
        {
            //arrange
            var tesla = new DragRace.Tesla();
            var expected = "Tesla";

            //act
            var actual = tesla.ShowName();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_ShouldReturnSilence()
        {
            //arrange
            var tesla = new DragRace.Tesla();
            var expected = "-- silence ---";

            //act
            var actual = tesla.StartEngine();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
