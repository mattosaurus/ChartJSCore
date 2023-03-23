using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class ColorPlugin
    {
        /// <summary>
        /// The color plugin is enabled by default, It might be disabled if necessary.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// You can force ChartJS to use your own colors instead of the standard colors
        /// </summary>
        public bool? ForceOverride { get; set; }
    }
}
