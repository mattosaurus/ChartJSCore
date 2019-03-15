namespace ChartJSCore.Models
{
    public class PointLabel : Base
    {
        /// <summary>
        /// Callback function to transform data label to axis label.
        /// </summary>
        public string Callback { get; set; }

        /// <summary>
        /// Font color.
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Font family to render.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Font size in pixels.
        /// </summary>
        public int FontSize { get; set; }

        /// <summary>
        /// Font Style to use.
        /// </summary>
        public string FontStyle { get; set; }
    }
}
