namespace ChartJSCore.Plugins.Zoom
{
    public class Zoom
    {
        /// <summary>
        /// Boolean to enable zooming.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Enable drag-to-zoom behavior.
        /// </summary>
        public bool? Drag { get; set; }

        /// <summary>
        /// Zooming directions. Remove the appropriate direction to disable Eg. 'y' would only allow zooming in the y direction.
        /// </summary>
        public string Mode { get; set; }

        public double? Speed { get; set; }

        public double? Threshold { get; set; }

        /// <summary>
        /// Format the min zoom range depending on scale type.
        /// </summary>
        public Range RangeMin { get; set; }

        /// <summary>
        /// Format the max zoom range depending on scale type.
        /// </summary>
        public Range RangeMax { get; set; }
    }
}
