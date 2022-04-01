using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/labelling.html#scale-title-configuration
    public class ScaleTitle : Base
    {
        /// <summary>
        /// If true, display the axis title.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Alignment of the axis title. Possible options are 'start', 'center' and 'end'
        /// </summary>
        public string Align { get; set; }

        /// <summary>
        /// The text for the title. (i.e. "# of People" or "Response Choices").
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public string Text { get; set; }

        /// <summary>
        /// Color of label.
        /// </summary>
        public ChartColor Color { get; set; }

        public Font Font { get; set; }

        /// <summary>
        /// Padding to apply around scale labels. Only top, bottom and y are implemented.
        /// </summary>
        public int? Padding { get; set; }
    }
}
