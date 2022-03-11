using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class Grid : Base
    {
        /// <summary>
        /// If false, do not display grid lines for this axis.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// If true, gridlines are circular (on radar chart only).
        /// </summary>
        public bool? Circular { get; set; }

        /// <summary>
        /// Color of the grid lines.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> Color { get; set; }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        public IList<int> BorderDash { get; set; }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public double? BorderDashOffset { get; set; }

        /// <summary>
        /// Stroke width of grid lines.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> LineWidth { get; set; }

        /// <summary>
        /// If true draw border on the edge of the chart.
        /// </summary>
        public bool? DrawBorder { get; set; }

        /// <summary>
        /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn.
        /// </summary>
        public bool? DrawOnChartArea { get; set; }

        /// <summary>
        /// If true, draw lines beside the ticks in the axis area beside the chart.
        /// </summary>
        public bool? DrawTicks { get; set; }

        /// <summary>
        /// Length in pixels that the grid lines will draw into the axis area.
        /// </summary>
        public int? TickMarkLength { get; set; }

        /// <summary>
        /// Stroke width of the grid line for the first index (index 0).
        /// </summary>
        public int? ZeroLineWidth { get; set; }

        /// <summary>
        /// Stroke color of the grid line for the first index (index 0).
        /// </summary>
        public ChartColor ZeroLineColor { get; set; }

        /// <summary>
        /// Length and spacing of dashes of the grid line for the first index (index 0).
        /// </summary>
        public IList<int> ZeroLineBorderDash { get; set; }

        /// <summary>
        /// Offset for line dashes of the grid line for the first index (index 0).
        /// </summary>
        public double? ZeroLineBorderDashOffset { get; set; }

        /// <summary>
        /// If true, labels are shifted to be between grid lines. This is used in the bar chart.
        /// </summary>
        public bool? OffsetGridLines { get; set; }
    }
}
