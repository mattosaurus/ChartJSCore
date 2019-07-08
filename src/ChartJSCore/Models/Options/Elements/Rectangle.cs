using ChartJSCore.Helpers;

namespace ChartJSCore.Models
{
    public class Rectangle : Base
    {
        /// <summary>
        /// Default bar fill color.
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// Default bar stroke width.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Default bar stroke color.
        /// </summary>
        public ChartColor BorderColor { get; set; }

        /// <summary>
        /// Default skipped (excluded) border for rectangle. Can be one of bottom, left, top, right.
        /// </summary>
        public string BorderSkipped { get; set; }
    }
}
