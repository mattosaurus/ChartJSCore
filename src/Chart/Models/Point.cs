using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Point
    {
        /// <summary>
        /// Default point radius.
        /// </summary>
        public int? Radius { get; set; }

        /// <summary>
        /// Default point style.
        /// </summary>
        public string PointStyle { get; set; }

        /// <summary>
        /// Default point fill color.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Default point stroke width.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Default point stroke color.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Extra radius added to point radius for hit detection.
        /// </summary>
        public int? HitRadius { get; set; }

        /// <summary>
        /// Default point radius when hovered.
        /// </summary>
        public int? HoverRadius { get; set; }

        /// <summary>
        /// Default stroke width when hovered.
        /// </summary>
        public int? HoverBorderWidth { get; set; }
    }
}
