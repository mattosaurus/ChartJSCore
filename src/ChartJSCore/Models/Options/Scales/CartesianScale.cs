namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/latest/axes/cartesian/linear.html
    public class CartesianScale : Scale
    {
        /// <summary>
        /// Determines the scale bounds.
        /// </summary>
        public string Bounds { get; set; }

        /// <summary>
        /// Position of the axis.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Stack group. Axes at the same position with same stack are stacked.
        /// </summary>
        public string Stack { get; set; }

        /// <summary>
        /// Weight of the scale in stack group. Used to determine the amount of allocated space for the scale within the group.
        /// </summary>
        public int? StackWeight { get; set; }

        /// <summary>
        /// Which type of axis this is. Possible values are: 'x', 'y'. If not set, this is inferred from the first character of the ID which should be 'x' or 'y'.
        /// </summary>
        public string Axis { get; set; }

        /// <summary>
        /// If true, extra space is added to the both edges and the axis is scaled to fit into the chart area. This is set to true for a bar chart by default.
        /// </summary>
        public bool? Offset { get; set; }

        /// <summary>
        /// Scale title configuration.
        /// </summary>
        public Title Title { get; set; }
    }
}