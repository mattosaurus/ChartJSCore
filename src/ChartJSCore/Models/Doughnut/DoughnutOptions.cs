using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/latest/charts/doughnut.html#config-options
    public class DoughnutOptions : Options
    {
        /// <summary>
        /// The portion of the chart that is cut out of the middle. If string and ending with '%', percentage of the chart radius. number is considered to be pixels.
        /// </summary>
        [JsonConverter(typeof(DoubleStringConverter))]
        public string Cutout { get; set; }

        /// <summary>
        /// The outer radius of the chart. If string and ending with '%', percentage of the maximum radius. number is considered to be pixels.
        /// </summary>
        [JsonConverter(typeof(DoubleStringConverter))]
        public string Radius { get; set; }

        /// <summary>
        /// Starting angle to draw arcs from.
        /// </summary>
        public int? Rotation { get; set; }

        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        public int? Circumference { get; set; }
    }
}
