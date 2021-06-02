using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class BarScale : Scale
    {
        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category percentage. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double? BarPercentage { get; set; }

        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width.
        /// </summary>
        public double? CategoryPercentage { get; set; }

        /// <summary>
        /// Manually set width of each bar in pixels. If set to 'flex', it computes "optimal" sample widths that globally arrange bars side by side. If not set (default), bars are equally sized based on the smallest interval.
        /// </summary>
        public double? BarThickness { get; set; }

        /// <summary>
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        public double? MaxBarThickness { get; set; }

        /// <summary>
        /// Set this to ensure that bars have a minimum length in pixels.
        /// </summary>
        public double? MinBarLength { get; set; }

        public GridLine GridLines { get; set; }
    }
}
