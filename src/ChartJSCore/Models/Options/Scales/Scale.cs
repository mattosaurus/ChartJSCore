using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Scale : Base
    {
        /// <summary>
        /// If true, show the scale including gridlines, ticks, and labels. Overrides gridLines.display, scaleLabel.display, and ticks.display.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Callback called before the update process starts. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeUpdate { get; set; }

        /// <summary>
        /// Callback that runs before dimensions are set. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs after dimensions are set. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs before data limits are determined. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeDataLimits { get; set; }

        /// <summary>
        /// Callback that runs after data limits are determined. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterDataLimits { get; set; }

        /// <summary>
        /// Callback that runs before ticks are created. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs before ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs after ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs before tick rotation is determined. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeCalculateTickRotation { get; set; }

        /// <summary>
        /// Callback that runs after tick rotation is determined. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterCalculateTickRotation { get; set; }

        /// <summary>
        /// Callback that runs before the scale fits to the canvas. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeFit { get; set; }

        /// <summary>
        /// Callback that runs after the scale fits to the canvas. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterFit { get; set; }

        /// <summary>
        /// Callback that runs at the end of the update process. Passed a single argument, the scale instance.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterUpdate { get; set; }

        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        public int? Weight { get; set; }

        /// <summary>
        /// If true datasets are stacked on top of each other
        /// </summary>
        public bool? Stacked { get; set; }
    }
}
