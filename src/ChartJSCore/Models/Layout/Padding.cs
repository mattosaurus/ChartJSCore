namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.5.1/general/padding.html
    public class Padding : Base
    {
        /// <summary>
        /// The padding to add inside the ChartJSCore. If this value is a number, it is applied to all sides of the chart (left, top, right, bottom).
        /// </summary>
        public int? PaddingInt { get; set; }

        /// <summary>
        /// The padding to add inside the ChartJSCore. If this value is an object, the left property defines the left padding. Similarly the right, top, and bottom properties can also be specified.
        /// </summary>
        public PaddingObject PaddingObject { get; set; }
    }
}
