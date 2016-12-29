using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Line
    {
        /// <summary>
        /// Default bezier curve tension. Set to 0 for no bezier curves.
        /// </summary>
        public double? Tension { get; set; }

        /// <summary>
        /// Default line fill color.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Default line stroke width.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Default line stroke color.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Default line cap style.
        /// </summary>
        public string BorderCapStyle { get; set; }

        // TODO: Convert to an array.
        /// <summary>
        /// Default line dash.
        /// </summary>
        public string BorderDash { get; set; }

        /// <summary>
        /// Default line dash offset.
        /// </summary>
        public double? BorderDashOffset { get; set; }

        /// <summary>
        /// Default line join style.
        /// </summary>
        public string BorderJoinStyle { get; set; }

        /// <summary>
        /// If true, bezier control points are kept inside the chart. If false, no restriction is enforced.
        /// </summary>
        public bool? CapBezierPoints { get; set; }

        // TODO: Allow string or boolean values.
        /// <summary>
        /// If true, the fill is assumed to be to zero. String values are 'zero', 'top', and 'bottom' to fill to different locations. If false, no fill is added.
        /// </summary>
        public string Fill { get; set; }

        /// <summary>
        /// If true, the line is shown as a stepped line and 'tension' will be ignored.
        /// </summary>
        public bool? Stepped { get; set; }
    }
}
