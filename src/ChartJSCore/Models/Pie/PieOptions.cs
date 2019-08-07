namespace ChartJSCore.Models
{
    public class PieOptions : Options
    {
        /// <summary>
        /// The percentage of the chart that is cut out of the middle.
        /// </summary>
        public int? CutoutPercentage { get; set; }

        /// <summary>
        /// Starting angle to draw arcs from.
        /// </summary>
        public double? Rotation { get; set; }

        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        public double? Circumference { get; set; }
    }
}
