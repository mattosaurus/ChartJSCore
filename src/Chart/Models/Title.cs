using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Title
    {
        /// <summary>
        /// Display the title block.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Position of the title. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes).
        /// </summary>
        public bool? FullWidth { get; set; }

        /// <summary>
        /// Font size inherited from global configuration.
        /// </summary>
        public int? FontSize { get; set; }

        /// <summary>
        /// Font family inherited from global configuration.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Font color inherited from global configuration.
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Font styling of the title.
        /// </summary>
        public string FontStyle { get; set; }

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
