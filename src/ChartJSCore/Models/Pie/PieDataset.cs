using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class PieDataset : Dataset
    {
        /// <summary>
        /// The type of the dataset
        /// </summary>
        public Enums.ChartType Type { get; set; } = Enums.ChartType.Pie;

        /// <summary>
        /// The fill color of the arcs.
        /// </summary>
        public IList<string> BackgroundColor { get; set; }

        /// <summary>
        /// Arc border color.
        /// </summary>
        public IList<string> BorderColor { get; set; }

        /// <summary>
        /// Border width of arcs in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Arc background color when hovered.
        /// </summary>
        public IList<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Arc border color when hovered.
        /// </summary>
        public IList<string> HoverBorderColor { get; set; }

        /// <summary>
        /// Border width of arc when hovered.
        /// </summary>
        public int? HoverBorderWidth { get; set; }
    }
}
