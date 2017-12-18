using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class TimeScale : CartesianScale
    {
        /// <summary>
        /// How data is plotted.
        /// </summary>
        public string Distribution { get; set; }

        /// <summary>
        /// Determines the scale bounds.
        /// </summary>
        public string Bounds { get; set; }

        public Time Time { get; set; }
    }
}
