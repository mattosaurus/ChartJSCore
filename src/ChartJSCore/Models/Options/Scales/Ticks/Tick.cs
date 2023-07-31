using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Security.Principal;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/#common-tick-options-to-all-axes
    public class Tick : Base
    {
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        public ChartColor BackdropColor { get; set; }

        /// <summary>
        /// Padding of label backdrop.
        /// </summary>
        public string BackdropPadding { get; set; }

        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Callback { get; set; }

        /// <summary>
        /// If true, show tick labels.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Color of ticks.
        /// </summary>
        public ChartColor Color { get; set; }

        public Font Font { get; set; }

        public MajorTick Major { get; set; }

        /// <summary>
        /// Sets the offset of the tick labels from the axis.
        /// </summary>
        public int? Padding { get; set; }

        /// <summary>
        /// If true, draw a background behind the tick labels.
        /// </summary>
        public bool? ShowLabelBackdrop { get; set; }

        /// <summary>
        /// The color of the stroke around the text.
        /// </summary>
        public ChartColor TextStrokeColor { get; set; }

        /// <summary>
        /// Stroke width around the text.
        /// </summary>
        public int? TextStrokeWidth { get; set; }

        /// <summary>
        /// z-index of tick layer. Useful when ticks are drawn on chart area. Values <= 0 are drawn under datasets, > 0 on top.
        /// </summary>
        public string Z { get; set; }

        /// <summary>
        /// if defined and stepSize is not specified, the step size will be rounded to this many decimal places.
        /// 
        /// Might only work with linear axis.
        /// </summary>
        public int? Precision { get; set; }

        /// <summary>
        /// User-defined fixed step size for the scale.
        /// </summary>
        public decimal? StepSize { get; set; }
    }
}
