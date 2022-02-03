using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class BorderRadius : Base
    {
        /// <summary>
        /// Border radius applied to all corners of the rectangle (topLeft, topRight, bottomLeft, bottomRight), except corners touching the borderSkipped.
        /// </summary>
        public int? BorderRadiusIntInt { get; set; }

        /// <summary>
        /// The border radius applied to the specified edges, the topLeft property defines the top-left corners border radius. Similarly, the topRight, bottomLeft, and bottomRight properties can also be specified. Omitted corners and those touching the borderSkipped are skipped. For example if the top border is skipped, the border radius for the corners topLeft and topRight will be skipped as well.
        /// </summary>
        public BorderRadiusObject BorderRadiusObject { get; set; }
    }
}
