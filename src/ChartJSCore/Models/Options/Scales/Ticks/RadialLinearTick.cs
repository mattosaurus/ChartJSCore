using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class RadialLinearTick : RadialTick
    {
        /// <summary>
        /// The number of ticks to generate. If specified, this overrides the automatic generation.
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// The Intl.NumberFormat options used by the default label formatter.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Format { get; set; }

        /// <summary>
        /// Maximum number of ticks and gridlines to show.
        /// </summary>
        public int? MaxTicksLimit { get; set; }

        /// <summary>
        /// If defined and stepSize is not specified, the step size will be rounded to this many decimal places.
        /// </summary>
        public int? Precision { get; set; }

        /// <summary>
        /// User defined fixed step size for the scale.
        /// </summary>
        public int? StepSize { get; set; }
    }
}
