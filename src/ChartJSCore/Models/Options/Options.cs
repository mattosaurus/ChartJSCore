using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class Options : Base
    {
        /// <summary>
        /// Resizes the chart canvas when its container does.
        /// </summary>
        public bool? Responsive { get; set; }

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        public bool? MaintainAspectRatio { get; set; }

        /// <summary>
        /// Canvas aspect ratio (i.e. width / height, a value of 1 representing a square canvas). Note that this option is ignored if the height is explicitly defined either as attribute or via the style.
        /// </summary>
        public int? AspectRatio { get; set; }

        /// <summary>
        /// Called when a resize occurs. Gets passed two arguments: the chart instance and the new size.
        /// </summary>
        public string OnResize { get; set; }

        /// <summary>
        /// Delay the resize update by give amount of milliseconds. This can ease the resize process by debouncing update of the elements.
        /// </summary>
        public int? ResizeDelay { get; set; }

        /// <summary>
        /// Override the window's default devicePixelRatio.
        /// </summary>
        public int? DevicePixelRatio { get; set; }

        /// <summary>
        /// A string with a BCP 47 language tag, leveraging on INTL NumberFormat
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Configure which events trigger chart interactions
        /// </summary>
        public Interaction Interaction { get; set; }

        /// <summary>
        /// Events that the chart should listen to for tooltips and hovering.
        /// </summary>
        public IList<string> Events { get; set; }

        /// <summary>
        /// Called when any of the events fire over chartArea. Passed the event, an array of active elements (bars, points, etc), and the chart.
        /// </summary>
        public string OnHover { get; set; }

        /// <summary>
        /// Called if the event is of type 'mouseup' or 'click'. Called in the context of the chart and passed an array of active elements.
        /// </summary>
        public string OnClick { get; set; }

        public Animation Animation { get; set; }

        public Layout Layout { get; set; }

        ///// <summary>
        ///// Function to generate a legend. Receives the chart object to generate a legend from. Default implementation returns an HTML string.
        ///// </summary>
        //[JsonConverter(typeof(PlainJsonStringConverter))]
        //public string LegendCallback { get; set; }

        //

        //public ToolTip Tooltips { get; set; }

        //public Hover Hover { get; set; }

        ///// <summary>
        ///// Options can be configured for four different types of elements: arc, lines, points, and rectangles. When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset.
        ///// </summary>
        //public Elements Elements { get; set; }

        //public Scales Scales { get; set; }
    }
}
