using ChartJSCore.Helpers;

namespace ChartJSCore.Models
{
    public class ScaleLabel : Base
    {
        public bool Display { get; set; }

        /// <summary>
        /// The text for the title. (i.e. "# of People", "Response Choices").
        /// </summary>
        public string LabelString { get; set; }

        /// <summary>
        /// Font color for the scale title.
        /// </summary>
        public ChartColor FontColor { get; set; }

        /// <summary>
        /// Font family for the scale title, follows CSS font-family options.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Font size for the scale title.
        /// </summary>
        public int FontSize { get; set; }

        /// <summary>
        /// Font style for the scale title, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle { get; set; }
    }
}
