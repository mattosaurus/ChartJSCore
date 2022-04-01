namespace ChartJSCore.Models
{
    public class TimeScale : CartesianScale
    {
        /// <summary>
        /// How data is plotted.
        /// </summary>
        public string Distribution { get; set; }

        public Time Time { get; set; }
    }
}
