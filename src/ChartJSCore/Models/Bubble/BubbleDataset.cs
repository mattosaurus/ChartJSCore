using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class BubbleDataset : Dataset
    {
        /// <summary>
        /// The fill color of the bubbles.
        /// </summary>
        public IList<string> BackgroundColor { get; set; }

        /// <summary>
        /// The stroke color of the bubbles.
        /// </summary>
        public IList<string> BorderColor { get; set; }

        /// <summary>
        /// The stroke width of bubble in pixels.
        /// </summary>
        public IList<int> BorderWidth { get; set; }

        /// <summary>
        /// The fill color of the bubbles when hovered.
        /// </summary>
        public IList<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// The stroke color of the bubbles when hovered.
        /// </summary>
        public IList<string> HoverBorderColor { get; set; }

        /// <summary>
        /// The stroke width of the bubbles when hovered.
        /// </summary>
        public IList<int> HoverBorderWidth { get; set; }

        /// <summary>
        /// Additional radius to add to data radius on hover.
        /// </summary>
        public IList<int> HoverRadius { get; set; }
    }
}
