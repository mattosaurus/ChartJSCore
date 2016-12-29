using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class RadarOptions : Options
    {
        /// <summary>
        /// The number of degrees to rotate the chart clockwise.
        /// </summary>
        public int? StartAngle { get; set; }
    }
}
