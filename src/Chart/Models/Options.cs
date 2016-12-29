using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Options
    {
        /// <summary>
        /// Resizes the chart canvas when its container does.
        /// </summary>
        public bool? Responsive { get; set; }

        /// <summary>
        /// Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        public int? ResponsiveAnimationDuration { get; set; }

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        public bool? MaintainAspectRatio { get; set; }

        /// <summary>
        /// Events that the chart should listen to for tooltips and hovering.
        /// </summary>
        public IList<string> Events { get; set; }

        /// <summary>
        /// Called if the event is of type 'mouseup' or 'click'. Called in the context of the chart and passed an array of active elements.
        /// </summary>
        public string OnClick { get; set; }

        /// <summary>
        /// Function to generate a legend. Receives the chart object to generate a legend from. Default implementation returns an HTML string.
        /// </summary>
        public string LegendCallback { get; set; }

        /// <summary>
        /// Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
        /// </summary>
        public string OnResize { get; set; }

        public Layout Layout { get; set; }

        public Title Title { get; set; }

        public Legend Legend { get; set; }

        public ToolTip Tooltips { get; set; }

        public Hover Hover { get; set; }

        public Animation Animation { get; set; }

        /// <summary>
        /// Options can be configured for four different types of elements: arc, lines, points, and rectangles. When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset.
        /// </summary>
        public Elements Elements { get; set; }
    }
}
