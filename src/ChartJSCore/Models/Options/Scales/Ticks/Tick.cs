using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class Tick : Base
    {
        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Callback { get; set; }

        /// <summary>
        /// If true, show tick marks.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Font color for tick labels.
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Font family for the tick labels, follows CSS font-family options.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Font size for the tick labels.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Font style for the tick labels, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// Reverses order of tick labels.
        /// </summary>
        public bool? Reverse { get; set; }

        /// <summary>
        /// Minor ticks configuration. Ommited options are inherited from options above.
        /// </summary>
        public MinorTick Minor { get; set; }

        /// <summary>
        /// Major ticks configuration. Ommited options are inherited from options above.
        /// </summary>
        public MajorTick Major { get; set; }
    }
}
