using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class BorderWidth : Base
    {
        /// <summary>
        /// The border width applied to all sides of the rectangle (left, top, right, bottom), except borderSkipped.
        /// </summary>
        public int? BorderWidthInt { get; set; }

        /// <summary>
        /// The border width applied to the specified sides, the left property defines the left border width. Similarly, the right, top, and bottom properties can also be specified. Omitted borders and borderSkipped are skipped.
        /// </summary>
        public BorderWidthObject BorderWidthObject { get; set; }
    }
}
