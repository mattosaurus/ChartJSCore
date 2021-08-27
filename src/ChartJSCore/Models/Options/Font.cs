using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class Font
    {
        /// <summary>
        /// Default font family for all text, follows CSS font-family options.
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
        /// </summary>
        public int? Size { get; set; }

        /// <summary>
        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title. Follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// Default font weight (boldness).
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// Height of an individual line of text.
        /// </summary>
        [JsonConverter(typeof(DoubleStringConverter))]
        public string LineHeight { get; set; }
    }
}
