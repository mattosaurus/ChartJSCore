using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class Clip : Base
    {
        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}.
        /// </summary>
        public int? ClipInt { get; set; }

        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. If this value is an object, the left property defines the left cliping. Similarly the right, top, and bottom properties can also be specified.
        /// </summary>
        public ClipObject ClipObject { get; set; }
    }
}
