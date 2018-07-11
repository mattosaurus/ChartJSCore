using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Arc : Base
    {
        /// <summary>
        /// Default fill color for arcs. Inherited from the global default.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Default stroke color for arcs.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Default stroke width for arcs.
        /// </summary>
        public int? BorderWidth { get; set; }
    }
}
