using ChartJSCore.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class Border : Base
    {
        /// <summary>
        /// If true, draw a border at the edge between the axis and the chart area.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// The color of the border line.
        /// </summary>
        public ChartColor Color{ get; set; }

        /// <summary>
        /// The width of the border line.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Length and spacing of dashes on grid lines.
        /// </summary>
        public IList<int> Dash { get; set; }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public int DashOffset { get; set; }

        /// <summary>
        /// z-index of the border layer. Values <= 0 are drawn under datasets, > 0 on top.
        /// </summary>
        public int Z { get; set; }
    }
}
