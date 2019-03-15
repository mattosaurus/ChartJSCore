namespace ChartJSCore.Models
{
    public class PieAnimation : Animation
    {
        /// <summary>
        /// If true, will animate the rotation of the chart.
        /// </summary>
        public bool? AnimateRotate { get; set; }

        /// <summary>
        /// If true, will animate scaling of the chart from the centre.
        /// </summary>
        public bool? AnimateScale { get; set; }
    }
}
