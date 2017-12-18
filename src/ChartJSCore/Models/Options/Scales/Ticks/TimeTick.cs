using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class TimeTick : CartesianTick
    {
        /// <summary>
        /// How ticks are generated.
        /// </summary>
        public string Source { get; set; }
    }
}
