using ChartJSCore.Helpers;
using ChartJSCore.Models;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class LegendLabel : Base
    {
        /// <summary>
        /// Width of coloured box.
        /// </summary>
        public int? BoxWidth { get; set; }

        /// <summary>
        /// Height of coloured box.
        /// </summary>
        public int? BoxHeight { get; set; }

        /// <summary>
        /// Color of label and the strikethrough.
        /// </summary>
        public ChartColor Color { get; set; }

        /// <summary>
        /// Font style inherited from global configuration.
        /// </summary>
        public Font Font { get; set; }

        /// <summary>
        /// Padding between rows of colored boxes.
        /// </summary>
        public int? Padding { get; set; }

        /// <summary>
        /// Generates legend items for each thing in the legend. Default implementation returns the text + styling for the color box.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string GenerateLabels { get; set; }

        /// <summary>
        /// Filters legend items out of the legend. Receives 2 parameters, a Legend Item and the chart data.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Filter { get; set; }

        /// <summary>
        /// Sorts legend items. Receives 3 parameters, two Legend Items and the chart data.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Sort { get; set; }

        /// <summary>
        /// If specified, this style of point is used for the legend. Only used if usePointStyle is true.
        /// </summary>
        public string PointStyle { get; set; }

        /// <summary>
        /// Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'.
        /// </summary>
        public string TextAlign { get; set; }

        /// <summary>
        /// Label style will match corresponding point style (size is based on fontSize, boxWidth is not used in this case).
        /// </summary>
        public bool? UsePointStyle { get; set; }
    }
}
