using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class LogarithmicTick : Tick
    {
        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public string Max { get; set; }
    }
}
