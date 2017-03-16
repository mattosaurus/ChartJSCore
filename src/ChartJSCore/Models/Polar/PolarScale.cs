using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models.Polar
{
    public class PolarScale : Scale
    {
        /// <summary>
        /// When true, lines are circular.
        /// </summary>
        public bool? LineArc { get; set; }
    }
}
