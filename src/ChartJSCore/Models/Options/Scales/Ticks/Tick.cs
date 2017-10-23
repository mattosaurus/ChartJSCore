using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Tick
    {
        public bool? AutoSkip { get; set; }

        public int? AutoSkipPadding { get; set; }

        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Callback { get; set; }

        public bool? Display { get; set; }

        public string FontColor { get; set; }

        public string FontFamily { get; set; }

        public int? FontSize { get; set; }

        public string FontStyle { get; set; }

        public int? LabelOffset { get; set; }

        public int? MaxRotation { get; set; }

        public int? MinRotation { get; set; }

        public bool? Mirror { get; set; }

        public int? Padding { get; set; }

        public bool? Reverse { get; set; }

        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        public string BackdropColor { get; set; }

        /// <summary>
        /// Horizontal padding of label backdrop.
        /// </summary>
        public int? BackdropPaddingX { get; set; }

        /// <summary>
        /// Vertical padding of label backdrop.
        /// </summary>
        public int? BackdropPaddingY { get; set; }

        /// <summary>
        /// If true, scale will include 0 if it is not already included.
        /// </summary>
        public bool? BeginAtZero { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        public int? Min { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public int? Max { get; set; }

        /// <summary>
        /// Maximum number of ticks and gridlines to show. If not defined, it will limit to 11 ticks but will show all gridlines.
        /// </summary>
        public int? MaxTicksLimit { get; set; }

        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// </summary>
        public bool? ShowLabelBackdrop { get; set; }

        /// <summary>
        /// User defined fixed step size for the scale. If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment. If not set, the ticks are labeled automatically using the nice numbers algorithm.
        /// </summary>
        public int? FixedStepSize { get; set; }

        /// <summary>
        /// If defined, it can be used along with the min and the max to give a custom number of steps.
        /// </summary>
        public int? StepSize { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value except for if it is lower than the maximum value.
        /// </summary>
        public int? SuggestedMax { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value except for if it is higher than the minimum value.
        /// </summary>
        public int? SuggestedMin { get; set; }
    }
}
