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

        public new IList<BubbleData> Data { get; set; }

        #region General
        // https://www.chartjs.org/docs/latest/charts/bubble.html#general
        /// <summary>
        /// Draw the active points of a dataset over the other points of the dataset
        /// </summary>
        public bool? DrawActiveElementsOnTop { get; set; }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        public int? Order { get; set; }
        #endregion General

        #region Styling
        // https://www.chartjs.org/docs/latest/charts/bubble.html#styling
        /// <summary>
        /// Bubble shape style.
        /// </summary>
        public string PointStyle { get; set; }

        /// <summary>
        /// Bubble rotation (in degrees).
        /// </summary>
        public int? Rotation { get; set; }

        /// <summary>
        /// Bubble radius (in pixels).
        /// </summary>
        public int? Radius { get; set; }
        #endregion Styling

        #region Interactions
        // https://www.chartjs.org/docs/latest/charts/bubble.html#interactions
        /// <summary>
        /// Bubble additional radius for hit detection (in pixels).
        /// </summary>
        public int? HitRadius { get; set; }

        /// <summary>
        /// Bubble border width when hovered (in pixels).
        /// </summary>
        public int? HoverBorderWidth { get; set; }

        /// <summary>
        /// Bubble additional radius when hovered (in pixels).
        /// </summary>
        public int? HoverRadius { get; set; }
        #endregion Interactions
    }
}
