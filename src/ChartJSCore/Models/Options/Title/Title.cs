using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.5.1/configuration/title.html
    public class Title : Base
    {
        /// <summary>
        /// Alignment of the title.
        /// </summary>
        public string Align { get; set; }

        /// <summary>
        /// Color of text.
        /// </summary>
        public ChartColor Color { get; set; }

        /// <summary>
        /// Is the legend title displayed.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Marks that this box should take the full width/height of the canvas. If false, the box is sized and placed above/beside the chart area.
        /// </summary>
        public bool? FullSize { get; set; }

        /// <summary>
        /// Position of title.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Font of the title.
        /// </summary>
        public Font Font { get; set; }

        /// <summary>
        /// Number of pixels to add above and below the title text.
        /// </summary>
        public int? Padding { get; set; }

        /// <summary>
        /// Title text.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> Text { get; set; }
    }
}
