using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class GridLine : Base
    {
        public bool Display { get; set; }

        /// <summary>
        /// Color of the grid lines.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> Color { get; set; }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        public IList<int> BorderDash { get; set; }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public double BorderDashOffset { get; set; }

        /// <summary>
        /// Stroke width of grid lines.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> LineWidth { get; set; }

        /// <summary>
        /// If true draw border on the edge of the chart.
        /// </summary>
        public bool DrawBorder { get; set; }

        /// <summary>
        /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn.
        /// </summary>
        public bool DrawOnChartArea { get; set; }

        /// <summary>
        /// If true, draw lines beside the ticks in the axis area beside the chart.
        /// </summary>
        public bool DrawTicks { get; set; }

        /// <summary>
        /// Length in pixels that the grid lines will draw into the axis area.
        /// </summary>
        public int TickMarkLength { get; set; }

        /// <summary>
        /// Stroke width of the grid line for the first index (index 0).
        /// </summary>
        public int ZeroLineWidth { get; set; }

        /// <summary>
        /// Stroke color of the grid line for the first index (index 0).
        /// </summary>
        public string ZeroLineColor { get; set; }

        /// <summary>
        /// If true, labels are shifted to be between grid lines. This is used in the bar chart.
        /// </summary>
        public bool OffsetGridLines { get; set; }
    }
}
