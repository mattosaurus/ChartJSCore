namespace ChartJSCore.Models
{
    public class RadarLine : Line
    {
        /// <summary>
        /// Tension exhibited by lines when calculating splineCurve. Setting to 0 creates straight lines.
        /// </summary>
        public int? LineTension { get; set; }
    }
}
