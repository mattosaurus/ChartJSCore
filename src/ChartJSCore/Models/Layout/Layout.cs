using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Layout
    {
        /// <summary>
        /// The padding to add inside the ChartJSCore. If this value is a number, it is applied to all sides of the chart (left, top, right, bottom).
        /// </summary>
        [JsonProperty("padding")]
        public int? Padding { get; set; }

        /// <summary>
        /// The padding to add inside the ChartJSCore. If this value is an object, the left property defines the left padding. Similarly the right, top, and bottom properties can also be specified.
        /// </summary>
        [JsonProperty("padding")]
        public Padding PaddingObject { get; set; }
    }
}
