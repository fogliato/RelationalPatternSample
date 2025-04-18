using RelationalPattern;
using Xunit;

namespace RelationalPatternTest
{
    public class RainLevelTest
    {
        [Fact]
        public void GetRainLevel_NegativeValue_ReturnsInvalid()
        {
            Assert.Equal(RainLevelType.Invalid, RainLevel.GetRainLevel(-1));
        }

        [Fact]
        public void GetRainLevel_Zero_ReturnsNoRain()
        {
            Assert.Equal(RainLevelType.NoRain, RainLevel.GetRainLevel(0));
        }

        [Fact]
        public void GetRainLevel_LightRainRange_ReturnsLightRain()
        {
            Assert.Equal(RainLevelType.LightRain, RainLevel.GetRainLevel(2.5m));
            Assert.Equal(RainLevelType.LightRain, RainLevel.GetRainLevel(5));
        }

        [Fact]
        public void GetRainLevel_ModerateRainRange_ReturnsModerateRain()
        {
            Assert.Equal(RainLevelType.ModerateRain, RainLevel.GetRainLevel(15));
            Assert.Equal(RainLevelType.ModerateRain, RainLevel.GetRainLevel(25));
        }

        [Fact]
        public void GetRainLevel_HeavyRainRange_ReturnsHeavyRain()
        {
            Assert.Equal(RainLevelType.HeavyRain, RainLevel.GetRainLevel(35));
            Assert.Equal(RainLevelType.HeavyRain, RainLevel.GetRainLevel(50));
        }

        [Fact]
        public void GetRainLevel_VeryHeavyRainRange_ReturnsVeryHeavyRain()
        {
            Assert.Equal(RainLevelType.VeryHeavyRain, RainLevel.GetRainLevel(75));
            Assert.Equal(RainLevelType.VeryHeavyRain, RainLevel.GetRainLevel(100));
        }

        [Fact]
        public void GetRainLevel_ExtremeRain_ReturnsExtremeRain()
        {
            Assert.Equal(RainLevelType.ExtremeRain, RainLevel.GetRainLevel(101));
        }
    }
}
