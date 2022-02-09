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

        #region General
        /// <summary>
        /// Base value for the bar in data units along the value axis. If not set, defaults to the value axis base value.
        /// </summary>
        public int? Base { get; set; }

        // https://www.chartjs.org/docs/latest/charts/bar.html#general
        /// <summary>
        /// Should the bars be grouped on index axis. When true, all the datasets at same index value will be placed next to each other centering on that index value. When false, each bar is placed on its actual index-axis value.
        /// </summary>
        public bool? Grouped { get; set; }

        /// <summary>
        /// The base axis of the dataset. 'x' for vertical bars and 'y' for horizontal bars.
        /// </summary>
        public string IndexAxis { get; set; }

        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// If true, null or undefined values will not be used for spacing calculations when determining bar size.
        /// </summary>
        public bool? SkipNull { get; set; }

        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack). Defaults to dataset type.
        /// </summary>
        public string Stack { get; set; }

        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID { get; set; }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID { get; set; }
        #endregion General

        #region Styling
        // https://www.chartjs.org/docs/latest/charts/bar.html#styling
        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> BorderSkipped { get; set; }

        /// <summary>
        /// The bar border radius (in pixels).
        /// </summary>
        [JsonConverter(typeof(BorderRadiusConverter))]
        public BorderRadius BorderRadius { get; set; }

        /// <summary>
        /// Set this to ensure that bars have a minimum length in pixels.
        /// </summary>
        public double? MinBarLength { get; set; }

        /// <summary>
        /// Style of the point for legend.
        /// </summary>
        public string PointStyle { get; set; }
        #endregion Styling

        #region Interactions
        // https://www.chartjs.org/docs/latest/charts/bar.html#interactions
        /// <summary>
        /// The bar border width when hovered (in pixels).
        /// </summary>
        public int? HoverBorderWidth { get; set; }

        /// <summary>
        /// The bar border radius when hovered (in pixels).
        /// </summary>
        public int? HoverBorderRadius { get; set; }
        #endregion Interactions

        #region BarPercentage
        // https://www.chartjs.org/docs/latest/charts/bar.html#barpercentage
        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category percentage. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double? BarPercentage { get; set; }
        #endregion BarPercentage

        #region CategoryPercentage
        // https://www.chartjs.org/docs/latest/charts/bar.html#categorypercentage
        /// <summary>
        /// Percent (0-1) of the available width each category should be within the sample width.
        /// </summary>
        public double? CategoryPercentage { get; set; }
        #endregion CategoryPercentage

        #region BarThickness
        // https://www.chartjs.org/docs/latest/charts/bar.html#barthickness
        /// <summary>
        /// Manually set width of each bar in pixels. If set to 'flex', it computes "optimal" sample widths that globally arrange bars side by side. If not set (default), bars are equally sized based on the smallest interval.
        /// </summary>
        public double? BarThickness { get; set; }
        #endregion BarThickness

        #region MaxBarThickness
        // https://www.chartjs.org/docs/latest/charts/bar.html#maxbarthickness
        /// <summary>
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        public double? MaxBarThickness { get; set; }
        #endregion MaxBarThickness

        public Scale Scale { get; set; }
    }
}