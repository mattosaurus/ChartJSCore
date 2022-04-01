using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/cartesian/logarithmic.html#logarithmic-axis-specific-options
    public class CartesianLogarithmicTick : CartesianTick
    {
        /// <summary>
        /// The Intl.NumberFormat options used by the default label formatter.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Format { get; set; }
    }
}
