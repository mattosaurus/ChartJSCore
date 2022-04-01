using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class CartesianCategoryScale : CartesianScale
    {
        /// <summary>
        /// The minimum item to display.
        /// </summary>
        [JsonConverter(typeof(IntStringConverter))]
        public new string Min { get; set; }

        /// <summary>
        /// The maximum item to display.
        /// </summary>
        [JsonConverter(typeof(IntStringConverter))]
        public new string Max { get; set; }

        /// <summary>
        /// An array of labels to display. When an individual label is an array of strings, each item is rendered on a new line.
        /// </summary>
        public IEnumerable<string> Labels { get; set; }
    }
}
