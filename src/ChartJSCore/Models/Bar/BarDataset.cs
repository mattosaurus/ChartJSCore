using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class BarDataset : Dataset
    {
        /// <summary>
        /// The type of the dataset
        /// </summary>
        public Enums.ChartType Type { get; set; } = Enums.ChartType.Bar;

        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID { get; set; }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID { get; set; }

        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category percentage. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double? BarPercentage { get; set; }

        /// <summary>
        /// Manually set width of each bar in pixels. If set to 'flex', it computes "optimal" sample widths that globally arrange bars side by side. If not set (default), bars are equally sized based on the smallest interval.
        /// </summary>
        public double? BarThickness { get; set; }

        /// <summary>
        /// The fill color of the bars.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> BackgroundColor { get; set; }

        /// <summary>
        /// Bar border color.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> BorderColor { get; set; }

        /// <summary>
        /// Border width of bar in pixels.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> BorderWidth { get; set; }

        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> BorderSkipped { get; set; }

        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width.
        /// </summary>
        public double? CategoryPercentage { get; set; }

        /// <summary>
        /// Set this to ensure that bars have a minimum length in pixels.
        /// </summary>
        public double? MinBarLength { get; set; }

        /// <summary>
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        public double? MaxBarThickness { get; set; }

        /// <summary>
        /// Bar background color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Bar border color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> HoverBorderColor { get; set; }

        /// <summary>
        /// Border width of bar when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> HoverBorderWidth { get; set; }

        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack)
        /// </summary>
        public string Stack { get; set; }
    }
}