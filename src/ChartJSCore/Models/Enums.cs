using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public static class Enums
    {
        public enum ChartType : byte
        {
            Bar = 0,
            Bubble = 1,
            Radar = 2,
            PolarArea = 3,
            Pie = 4,
            Line = 5,
            Doughnut = 6,
            HorizontalBar = 7,
            Scatter = 8
        }

        public enum Easing
        {
            Linear,
            EaseInQuad,
            EaseOutQuad,
            EaseInOutQuad,
            EaseInCubic,
            EaseOutCubic,
            EaseInOutCubic,
            EaseInQuart,
            EaseOutQuart,
            EaseInOutQuart,
            EaseInQuint,
            EaseOutQuint,
            EaseInOutQuint,
            EaseInSine,
            EaseOutSine,
            EaseInOutSine,
            EaseInExpo,
            EaseOutExpo,
            EaseInOutExpo,
            EaseInCirc,
            EaseOutCirc,
            EaseInOutCirc,
            EaseInElastic,
            EaseOutElastic,
            EaseInOutElastic,
            EaseInBack,
            EaseOutBack,
            EaseInOutBack,
            EaseInBounce,
            EaseOutBounce,
            EaseInOutBounce
        }

        public enum ModifierKey
        {
            ctrl,
            alt,
            shift,
            meta
        }
    }
}
