using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Rectangle
    {
        /// <summary>
        /// Default bar fill color.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Default bar stroke width.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Default bar stroke color.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Default skipped (excluded) border for rectangle. Can be one of bottom, left, top, right.
        /// </summary>
        public string BorderSkipped { get; set; }
    }
}
