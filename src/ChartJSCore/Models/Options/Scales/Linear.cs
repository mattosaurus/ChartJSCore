namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.7.1/axes/radial/linear.html#linear-radial-axis-specific-options
    public class Linear : Scale
    {
        /// <summary>
        /// Whether to animate scaling the chart from the centre.
        /// </summary>
        public bool? Animate { get; set; }

        /// <summary>
        /// Angle line configuration.
        /// </summary>
        public AngleLine AngleLines { get; set; }

        /// <summary>
        /// If true, scale will include 0 if it is not already included.
        /// </summary>
        public bool? BeginAtZero { get; set; }

        /// <summary>
        /// Point label configuration.
        /// </summary>
        public PointLabel PointLabels { get; set; }

        /// <summary>
        /// Starting angle of the scale. In degrees, 0 is at top.
        /// </summary>
        public int? StartAngle { get; set; }
    }
}
