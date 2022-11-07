using System;
using ChartJSCore.Models;

namespace ChartJSCore.Plugins.Zoom
{
    /// <summary>
    /// Container for Panning Options
    /// </summary>
    public class Pan
    {
        /// <summary>
        /// Boolean to enable panning.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Panning directions. Remove the appropriate direction to disable Eg. 'y' would only allow panning in the y direction.
        /// </summary>
        public string Mode { get; set; }
        
        /// <summary>
        /// Which of the enabled panning directions should only be available when the mouse cursor is over a scale for that axis
        /// </summary>
        public string OverScaleMode { get; set; }
        
        /// <summary>
        /// Minimal pan distance required before actually applying pan
        /// </summary>
        public double? Threshold { get; set; }
        
        /// <summary>
        /// Modifier key required for panning via mouse
        /// </summary>
        public Enums.ModifierKey? ModifierKey { get; set; }

        /// <summary>
        ///  Obsolete - remove in future release.
        /// </summary>
        [Obsolete]
        public double? Sensitivity { get; set; }

        /// <summary>
        /// Format the min pan range depending on scale type. Obsolete - remove in future release.
        /// </summary>
        [Obsolete("Use Threshold")]
        public Range RangeMin { get; set; }

        /// <summary>
        /// Format the max pan range depending on scale type. Obsolete - remove in future release.
        /// </summary>
        [Obsolete("Use Threshold")]
        public Range RangeMax { get; set; }
    }
}
