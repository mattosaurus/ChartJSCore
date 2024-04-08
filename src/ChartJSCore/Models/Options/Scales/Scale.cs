using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/#common-options-to-all-axes
    public class Scale : Base
    {
        /// <summary>
        /// Type of scale being employed. Custom scales can be created and registered with a string key. This allows changing the type of an axis for a chart.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Align pixel values to device pixels.
        /// </summary>
        public bool? AlignToPixels { get; set; }

        /// <summary>
        /// Background color of the scale area.
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// Controls the axis global visibility (visible when true, hidden when false). When display: 'auto', the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Grid line configuration.
        /// </summary>
        public Grid Grid { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        public int? Min { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public int? Max { get; set; }

        /// <summary>
        /// Reverse the scale.
        /// </summary>
        public bool? Reverse { get; set; }

        /// <summary>
        /// Should the data be stacked.
        /// </summary>
        public bool? Stacked { get; set; }

        /// <summary>
        /// Adjustment used when calculating the maximum data value.
        /// </summary>
        public int? SuggestedMax { get; set; }

        /// <summary>
        /// Adjustment used when calculating the minimum data value.
        /// </summary>
        public int? SuggestedMin { get; set; }

        /// <summary>
        /// Tick configuration.
        /// </summary>
        public Tick Ticks { get; set; }

        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Position of the axis. Valid values: 'left' and 'right'.
        /// 
        /// In case of using multiple y axis, it is useful to place one y axis on the left and the other on the right
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Callback called before the update process starts.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeUpdate { get; set; }

        /// <summary>
        /// Callback that runs before dimensions are set.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs after dimensions are set.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs before data limits are determined.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeDataLimits { get; set; }

        /// <summary>
        /// Callback that runs after data limits are determined.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterDataLimits { get; set; }

        /// <summary>
        /// Callback that runs before ticks are created.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs before ticks are converted into strings.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs after ticks are converted into strings.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs before tick rotation is determined.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeCalculateLabelRotation { get; set; }

        /// <summary>
        /// Callback that runs after tick rotation is determined.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterCalculateLabelRotation { get; set; }

        /// <summary>
        /// Callback that runs before the scale fits to the canvas.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeFit { get; set; }

        /// <summary>
        /// Callback that runs after the scale fits to the canvas.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterFit { get; set; }

        /// <summary>
        /// Callback that runs at the end of the update process.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterUpdate { get; set; }

        /// <summary>
        /// Border-specific settings
        /// </summary>
        public Border Border { get; set; }
    }
}