using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models.Bar
{
    public class BarScale : Scale
    {
        /// <summary>
        /// If true, bars are stacked.
        /// </summary>
        public bool? Stacked { get; set; }

        /// <summary>
        /// Manually set thickness of each bar in pixels. If not set, the bars are sized automatically.
        /// </summary>
        public double? BarThickness { get; set; }

        /// <summary>
        /// Percent (0-1) of the available width (the space between the gridlines for small datasets) for each data-point to use for the bars.
        /// </summary>
        public double? CategoryPercentage { get; set; }

        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category percentage. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double? BarPercentage { get; set; }
    }
}
