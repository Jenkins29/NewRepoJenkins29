using System;
using Xunit;

namespace Mitsubishi.Test
{
    public class MitsubishiTest
    {
        [Fact]
        public void SpeedUp_CurrentSpeedShouldIncreaseBy25()
        {
            //arrange
            var mitsu = new DragRace.Mitsubishi();
            mitsu.Speed = 0;
            var expected = 25;

            //act
            mitsu.SpeedUp();
            var actual = mitsu.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_ShouldDecreaseCurrentSpeedBy25()
        {
            //arrange
            var mitsu = new DragRace.Mitsubishi();
            mitsu.Speed = 60;
            var expected = 35;

            //act
            mitsu.SlowDown();
            var actual = mitsu.Speed;

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_ShouldReturn35AsString()
        {
            //arrange
            var mitsu = new DragRace.Mitsubishi();
            mitsu.Speed = 35;
            var expected = "35";

            //act
            var actual = mitsu.ShowCurrentSpeed();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowName_ShoudReturnTesla_AsString()
        {
            //arrange
            var mitsu = new DragRace.Mitsubishi();
            var expected = "Mitsubishi";

            //act
            var actual = mitsu.ShowName();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_ShouldReturnSilence()
        {
            //arrange
            var mitsu = new DragRace.Mitsubishi();
            var expected = "....ZZzhhhhhhhh..";

            //act
            var actual = mitsu.StartEngine();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
