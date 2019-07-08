using ChartJSCore.Helpers;

namespace ChartJSCore.Models
{
    public class Arc : Base
    {
        /// <summary>
        /// Default fill color for arcs. Inherited from the global default.
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// Default stroke color for arcs.
        /// </summary>
        public ChartColor BorderColor { get; set; }

        /// <summary>
        /// Default stroke width for arcs.
        /// </summary>
        public int? BorderWidth { get; set; }
    }
}
