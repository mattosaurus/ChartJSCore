using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class BubbleDataset : Dataset
    {
		/// <summary>
		/// The type of the dataset
		/// </summary>
		public Enums.ChartType Type { get; set; } = Enums.ChartType.Bubble;

        /// <summary>
        /// The data to plot in the bubble chart.
        /// </summary>
        public new IList<BubbleData> Data { get; set; }

        /// <summary>
        /// The fill color of the bubbles.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> BackgroundColor { get; set; }

        /// <summary>
        /// The stroke color of the bubbles.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> BorderColor { get; set; }

        /// <summary>
        /// The stroke width of bubble in pixels.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> BorderWidth { get; set; }

        /// <summary>
        /// The fill color of the bubbles when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// The stroke color of the bubbles when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> HoverBorderColor { get; set; }

        /// <summary>
        /// The stroke width of the bubbles when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> HoverBorderWidth { get; set; }

        /// <summary>
        /// Additional radius to add to data radius on hover.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> HoverRadius { get; set; }
    }
}
