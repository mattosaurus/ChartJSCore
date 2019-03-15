namespace ChartJSCore.Models
{
    /// <summary>
    /// Options can be configured for four different types of elements: arc, lines, points, and rectangles. When set, these options apply to all objects of that type unless specifically overridden by the configuration attached to a dataset.
    /// </summary>
    public class Elements : Base
    {
        /// <summary>
        /// Arcs are used in the polar area, doughnut and pie charts.
        /// </summary>
        public Arc Arc { get; set; }

        /// <summary>
        /// Line elements are used to represent the line in a line ChartJSCore.
        /// </summary>
        public Line Line { get; set; }

        /// <summary>
        /// Point elements are used to represent the points in a line chart or a bubble ChartJSCore.
        /// </summary>
        public Point Point { get; set; }

        /// <summary>
        /// Rectangle elements are used to represent the bars in a bar ChartJSCore.
        /// </summary>
        public Rectangle Rectangle { get; set; }
    }
}
