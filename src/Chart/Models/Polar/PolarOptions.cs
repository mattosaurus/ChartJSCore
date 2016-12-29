using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class PolarOptions : Options
    {
        /// <summary>
        /// Sets the starting angle for the first item in a dataset
        /// </summary>
        public double? StartAngle { get; set; }
    }
}
