using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models.Polar
{
    public class PolarAnimation : Animation
    {
        /// <summary>
        /// If true, will animate the rotation of the chart.
        /// </summary>
        public bool? AnimateRotate { get; set; }

        /// <summary>
        /// If true, will animate scaling the chart.
        /// </summary>
        public bool? AnimateScale { get; set; }
    }
}
