namespace RelationalPattern;

public enum RainLevelType
{
    Invalid,
    NoRain,
    LightRain,
    ModerateRain,
    HeavyRain,
    VeryHeavyRain,
    ExtremeRain
}

public static class RainLevel
{
    public static RainLevelType GetRainLevelWithouPattern(decimal accumulatedMillimetersInOneHour)
    {
        if (accumulatedMillimetersInOneHour < 0)
            return RainLevelType.Invalid;
        if (accumulatedMillimetersInOneHour == 0)
            return RainLevelType.NoRain;
        if (accumulatedMillimetersInOneHour <= 5)
            return RainLevelType.LightRain;
        if (accumulatedMillimetersInOneHour <= 25)
            return RainLevelType.ModerateRain;
        if (accumulatedMillimetersInOneHour <= 50)
            return RainLevelType.HeavyRain;
        if (accumulatedMillimetersInOneHour <= 100)
            return RainLevelType.VeryHeavyRain;
        return RainLevelType.ExtremeRain;
    }


    public static RainLevelType GetRainLevel(decimal accumulatedMillimetersInOneHour)
    {
        return accumulatedMillimetersInOneHour switch
        {
            < 0 => RainLevelType.Invalid,
            0 => RainLevelType.NoRain,
            <= 5 => RainLevelType.LightRain,
            <= 25 => RainLevelType.ModerateRain,
            <= 50 => RainLevelType.HeavyRain,
            <= 100 => RainLevelType.VeryHeavyRain,
            > 100 => RainLevelType.ExtremeRain
        };
    }

}
