using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Layout
    {
        /// <summary>
        /// The padding to add inside the chart. If this value is a number, it is applied to all sides of the chart (left, top, right, bottom). If this value is an object, the left property defines the left padding. Similarly the right, top, and bottom properties can also be specified.
        /// </summary>
        public int? Padding { get; set; }
    }
}
