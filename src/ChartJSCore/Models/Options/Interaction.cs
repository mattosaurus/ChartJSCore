using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class Interaction
    {
        /// <summary>
        /// Sets which elements appear in the interaction. See Interaction Modes for details.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// If true, the interaction mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        public bool? Intersect { get; set; }

        /// <summary>
        /// Can be set to 'x', 'y', or 'xy' to define which directions are used in calculating distances. Defaults to 'x' for 'index' mode and 'xy' in dataset and 'nearest' modes.
        /// </summary>
        public string Axis { get; set; }
    }
}
