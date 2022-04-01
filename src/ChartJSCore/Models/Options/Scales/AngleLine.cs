using ChartJSCore.Helpers;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/radial/linear.html#angle-line-options
    public class AngleLine : Base
    {
        /// <summary>
        /// If true, angle lines are shown.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Color of angled lines.
        /// </summary>
        public ChartColor Color { get; set; }

        /// <summary>
        /// Width of angled lines.
        /// </summary>
        public int? LineWidth { get; set; }

        /// <summary>
        /// Length and spacing of dashes on angled lines.
        /// </summary>
        public IEnumerable<int> BorderDash { get; set; }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public int? BorderDashOffset { get; set; }
    }
}
