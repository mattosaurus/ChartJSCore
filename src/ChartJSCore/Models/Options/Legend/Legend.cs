using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Legend : Base
    {
        /// <summary>
        /// Is the legend displayed.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// 	Position of the legend. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes).
        /// </summary>
        public bool? FullWidth { get; set; }

        /// <summary>
        /// A callback that is called when a 'click' event is registered on top of a label item.
        /// </summary>
        public string OnClick { get; set; }

        /// <summary>
        /// Generates the HTML legend via calls to generateLegend.
        /// </summary>
        public string Callback { get; set; }

        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered on top of a label item.
        /// </summary>
        public string OnHover { get; set; }

        public LegendLabel Labels { get; set; }

        /// <summary>
        /// Legend will show datasets in reverse order
        /// </summary>
        public bool? Reverse { get; set; }
    }
}
