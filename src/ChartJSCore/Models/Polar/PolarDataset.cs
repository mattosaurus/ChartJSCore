using System.Collections.Generic;
using ChartJSCore.Helpers;

namespace ChartJSCore.Models
{
    public class PolarDataset : Dataset
    {
        /// <summary>
        /// The type of the dataset
        /// </summary>
        public Enums.ChartType Type { get; set; } = Enums.ChartType.PolarArea;

        #region Styling
        // https://www.chartjs.org/docs/latest/charts/polar.html#styling
        /// <summary>
        /// Arc border join style.
        /// </summary>
        public string BorderJoinStyle { get; set; }
        #endregion Styling

        #region BorderAlign
        // https://www.chartjs.org/docs/latest/charts/polar.html#border-alignment
        /// <summary>
        /// The following values are supported for borderAlign.
        /// 'center' (default)
        /// 'inner'
        /// When 'center' is set, the borders of arcs next to each other will overlap.When 'inner' is set, it is guaranteed that all the borders do not overlap.
        /// </summary>
        public string BorderAlign { get; set; }
        #endregion BorderAlign

        #region Interactions
        // https://www.chartjs.org/docs/latest/charts/polar.html#interactions
        /// <summary>
        /// Arc border join style when hovered.
        /// </summary>
        public string HoverBorderJoinStyle { get; set; }

        /// <summary>
        /// Arc border width when hovered (in pixels).
        /// </summary>
        public int? HoverBorderWidth { get; set; }
        #endregion Interactions
    }
}
