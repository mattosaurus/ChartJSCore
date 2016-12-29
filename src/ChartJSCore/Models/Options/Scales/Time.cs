using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Time
    {
        /// <summary>
        /// The following display formats are used to configure how different time units are formed into strings for the axis tick marks. 
        /// </summary>
        public TimeDisplayFormat DisplayFormats { get; set; }

        /// <summary>
        /// If true and the unit is set to 'week', iso weekdays will be used.
        /// </summary>
        public bool? IsoWeekday { get; set; }

        /// <summary>
        /// If defined, this will override the data maximum.
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        /// If defined, this will override the data minimum.
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        /// If defined as a string, it is interpreted as a custom format to be used by moment to parse the date. If this is a function, it must return a moment.js object given the appropriate data value.
        /// </summary>
        public string Parser { get; set; }

        /// <summary>
        /// If defined, dates will be rounded to the start of this unit.
        /// </summary>
        public string Round { get; set; }

        /// <summary>
        /// The moment js format string to use for the tooltip.
        /// </summary>
        public string TooltipFormat { get; set; }

        /// <summary>
        /// If defined, will force the unit to be a certain type.
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// The number of units between grid lines.
        /// </summary>
        public int? UnitStepSize { get; set; }

        /// <summary>
        /// The minimum display format to be used for a time unit.
        /// </summary>
        public string MinUnit { get; set; }
    }
}
