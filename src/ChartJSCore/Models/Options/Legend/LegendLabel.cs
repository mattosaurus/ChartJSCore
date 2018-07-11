using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class LegendLabel : Base
    {
        /// <summary>
        /// Width of coloured box.
        /// </summary>
        public int? BoxWidth { get; set; }

        /// <summary>
        /// Font size inherited from global configuration.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Font style inherited from global configuration.
        /// </summary>
        public int? FontStyle { get; set; }

        /// <summary>
        /// Font color inherited from global configuration.
        /// </summary>
        public int? FontColor { get; set; }

        /// <summary>
        /// Font family inherited from global configuration.
        /// </summary>
        public int? FontFamily { get; set; }

        /// <summary>
        /// Padding between rows of colored boxes.
        /// </summary>
        public int? Padding { get; set; }

        /// <summary>
        /// Generates legend items for each thing in the legend. Default implementation returns the text + styling for the color box.
        /// </summary>
        public int? GenerateLabels { get; set; }

        /// <summary>
        /// Label style will match corresponding point style (size is based on fontSize, boxWidth is not used in this case).
        /// </summary>
        public int? UsePointStyle { get; set; }
    }
}
