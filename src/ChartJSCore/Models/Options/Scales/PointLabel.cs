using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/radial/linear.html#point-label-options
    public class PointLabel : Base
    {
        /// <summary>
        /// Background color of the point label.
        /// </summary>
        public ChartColor BackdropColor { get; set; }

        /// <summary>
        /// Padding of label backdrop.
        /// </summary>
        public Padding BackdropPadding { get; set; }

        /// <summary>
        /// If true, point labels are shown.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Callback function to transform data labels to point labels. The default implementation simply returns the current string.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Callback { get; set; }

        /// <summary>
        /// Color of label.
        /// </summary>
        public ChartColor Color { get; set; }

        public Font Font { get; set; }

        /// <summary>
        /// Padding between chart and point labels.
        /// </summary>
        public int? Padding { get; set; }

        /// <summary>
        /// If true, point labels are centered.
        /// </summary>
        public bool? CenterPointLabels { get; set; }
    }
}
