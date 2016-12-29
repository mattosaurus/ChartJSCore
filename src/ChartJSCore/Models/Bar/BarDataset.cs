using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class BarDataset : Dataset
    {
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID { get; set; }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxesID { get; set; }

        /// <summary>
        /// The fill color of the bars.
        /// </summary>
        public IList<string> BackgroundColor { get; set; }

        /// <summary>
        /// Bar border color.
        /// </summary>
        public IList<string> BorderColor { get; set; }

        /// <summary>
        /// Border width of bar in pixels.
        /// </summary>
        public IList<int> BorderWidth { get; set; }

        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        public IList<string> BorderSkipped { get; set; }

        /// <summary>
        /// Bar background color when hovered.
        /// </summary>
        public IList<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Bar border color when hovered.
        /// </summary>
        public IList<string> HoverBorderColor { get; set; }

        /// <summary>
        /// Border width of bar when hovered.
        /// </summary>
        public IList<int> HoverBorderWidth { get; set; }
    }
}
