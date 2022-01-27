using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class Plugins
    {
        /// <summary>
        /// The chart legend displays data about the datasets that are appearing on the chart.
        /// </summary>
        public Legend Legend { get; set; }

        /// <summary>
        /// The chart title defines text to draw at the top of the chart.
        /// </summary>
        public Title Title { get; set; }

        /// <summary>
        /// Subtitle is a second title placed under the main title, by default.
        /// </summary>
        public Title Subtitle { get; set; }

        /// <summary>
        /// The global options for the chart tooltips.
        /// </summary>
        public ToolTip Tooltip { get; set; }
    }
}
