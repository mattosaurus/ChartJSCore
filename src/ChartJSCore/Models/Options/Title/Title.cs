using ChartJSCore.Helpers;

namespace ChartJSCore.Models
{
    public class Title : Base
    {
        /// <summary>
        /// Color of text.
        /// </summary>
        public ChartColor Color { get; set; }

        /// <summary>
        /// Is the legend title displayed.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Font of the title.
        /// </summary>
        public Font Font { get; set; }

        /// <summary>
        /// Number of pixels to add above and below the title text.
        /// </summary>
        public int? Padding { get; set; }

        /// <summary>
        /// Title text.
        /// </summary>
        public string Text { get; set; }
    }
}
