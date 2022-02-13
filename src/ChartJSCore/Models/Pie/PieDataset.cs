using System.Collections.Generic;
using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class PieDataset : Dataset
    {
        /// <summary>
        /// The type of the dataset
        /// </summary>
        public Enums.ChartType Type { get; set; } = Enums.ChartType.Pie;

        #region General
        // https://www.chartjs.org/docs/latest/charts/doughnut.html#general
        /// <summary>
        /// Per-dataset override for the sweep that the arcs cover.
        /// </summary>
        public int? Circumference { get; set; }

        /// <summary>
        /// Per-dataset override for the starting angle to draw arcs from.
        /// </summary>
        public int? Rotation { get; set; }
        #endregion General

        #region Styling
        // https://www.chartjs.org/docs/latest/charts/doughnut.html#styling
        // TODO: Allow images as well as strings.
        /// <summary>
        /// Arc border join style..
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> BorderJoinStyle { get; set; }

        /// <summary>
        /// Arc offset (in pixels).
        /// </summary>
        public int? Offset { get; set; }

        /// <summary>
        /// Fixed arc offset (in pixels). Similar to offset but applies to all arcs.
        /// </summary>
        public int? Spacing { get; set; }

        /// <summary>
        /// The relative thickness of the dataset. Providing a value for weight will cause the pie or doughnut dataset to be drawn with a thickness relative to the sum of all the dataset weight values.
        /// </summary>
        public int? Weight { get; set; }
        #endregion Styling

        #region BorderAlign
        // https://www.chartjs.org/docs/latest/charts/doughnut.html#border-alignment
        /// <summary>
        /// The following values are supported for borderAlign.
        /// 'center' (default)
        /// 'inner'
        /// When 'center' is set, the borders of arcs next to each other will overlap.When 'inner' is set, it is guaranteed that all borders will not overlap.
        /// </summary>
        public string BorderAlign { get; set; }
        #endregion BorderAlign

        #region BorderRadius
        // https://www.chartjs.org/docs/latest/charts/doughnut.html#border-radius
        /// <summary>
        /// If this value is a number, it is applied to all corners of the arc (outerStart, outerEnd, innerStart, innerRight). If this value is an object, the outerStart property defines the outer-start corner's border radius. Similarly, the outerEnd, innerStart, and innerEnd properties can also be specified.
        /// </summary>
        [JsonConverter(typeof(BorderRadiusConverter))]
        public BorderRadius BorderRadius { get; set; }
        #endregion BorderRadius

        #region Interactions
        // https://www.chartjs.org/docs/latest/charts/doughnut.html#interactions
        /// <summary>
        /// Arc border join style when hovered.
        /// </summary>
        public string HoverBorderJoinStyle { get; set; }

        /// <summary>
        /// Arc border width when hovered (in pixels).
        /// </summary>
        public int? HoverBorderWidth { get; set; }

        /// <summary>
        /// Arc offset when hovered (in pixels).
        /// </summary>
        public int? HoverOffset { get; set; }
        #endregion Interactions
    }
}
