using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class Animation : Base
    {
        /// <summary>
        /// The number of milliseconds an animation takes.
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Easing function to use. Available options are: 'linear', 'easeInQuad', 'easeOutQuad', 'easeInOutQuad', 'easeInCubic', 'easeOutCubic', 'easeInOutCubic', 'easeInQuart', 'easeOutQuart', 'easeInOutQuart', 'easeInQuint', 'easeOutQuint', 'easeInOutQuint', 'easeInSine', 'easeOutSine', 'easeInOutSine', 'easeInExpo', 'easeOutExpo', 'easeInOutExpo', 'easeInCirc', 'easeOutCirc', 'easeInOutCirc', 'easeInElastic', 'easeOutElastic', 'easeInOutElastic', 'easeInBack', 'easeOutBack', 'easeInOutBack', 'easeInBounce', 'easeOutBounce', 'easeInOutBounce'.
        /// </summary>
        public int? Easing { get; set; }

        /// <summary>
        /// Callback called on each step of an animation. Passed a single argument, an object, containing the chart instance and an object with details of the animation.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string OnProgress { get; set; }

        /// <summary>
        /// Callback called at the end of an animation. Passed the same arguments as onProgress.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string OnComplete { get; set; }
    }
}
