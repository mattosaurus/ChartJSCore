namespace ChartJSCore.Models
{
    public class LogarithmicTick : CartesianTick
    {
        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public double? Max { get; set; }
    }
}
