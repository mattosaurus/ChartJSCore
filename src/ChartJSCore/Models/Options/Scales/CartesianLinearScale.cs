using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class CartesianLinearScale : CartesianScale
    {
        /// <summary>
        /// If true, scale will include 0 if it is not already included.
        /// </summary>
        public bool? BeginAtZero { get; set; }

        /// <summary>
        /// Percentage (string ending with %) or amount (number) for added room in the scale range above and below data.
        /// </summary>
        [JsonConverter(typeof(IntStringConverter))]
        public string Grace { get; set; }
    }
}
