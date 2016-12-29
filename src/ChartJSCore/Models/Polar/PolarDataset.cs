using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class PolarDataset : Dataset
    {
        /// <summary>
        /// The fill color of the arcs.
        /// </summary>
        public IList<string> BackgroundColor { get; set; }

        /// <summary>
        /// Arc border color.
        /// </summary>
        public IList<string> BorderColor { get; set; }

        /// <summary>
        /// Border width of arcs in pixels.
        /// </summary>
        public IList<int> BorderWidth { get; set; }

        /// <summary>
        /// Arc background color when hovered.
        /// </summary>
        public IList<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Arc border color when hovered.
        /// </summary>
        public IList<string> HoverBorderColor { get; set; }

        /// <summary>
        /// Border width of arc when hovered.
        /// </summary>
        public IList<int> HoverBorderWidth { get; set; }
    }
}
