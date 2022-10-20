using System;

namespace ChartJSCore.Plugins.Zoom
{
    /// <summary>
    /// Container for Zoom Options
    /// </summary>
    public class Zoom
    {
        /// <summary>
        /// Boolean to enable zooming. Currently does nothing - to remove in a future release.
        /// </summary>
        [Obsolete("Use Enable flags on Wheel, Drag, and Pinch to enable/disable specific zoom behaviors")]
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Container for Wheel options
        /// </summary>
        public Wheel Wheel { get; set; }

        /// <summary>
        /// Container for Pinch options
        /// </summary>
        public Pinch Pinch { get; set; }

        /// <summary>
        /// Container for drag-to-zoom options
        /// </summary>
        public Drag Drag { get; set; }

        /// <summary>
        /// Zooming directions. Remove the appropriate direction to disable Eg. 'y' would only allow zooming in the y direction.
        /// </summary>
        public string Mode { get; set; }
        
        /// <summary>
        /// Which of the enabled zooming directions should only be available when the mouse cursor is over a scale for that axis
        /// </summary>
        public string OverScaleMode { get; set; }

        [Obsolete("Use settings on Wheel, Drag, and Pinch to control specific zoom behaviors ")]
        public double? Speed { get; set; }

        [Obsolete("Use settings on Wheel, Drag, and Pinch to control specific zoom behaviors ")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Format the min zoom range depending on scale type. Obsolete - remove in future release.
        /// </summary>
        [Obsolete("Use settings on Wheel, Drag, and Pinch to control specific zoom behaviors ")]
        public Range RangeMin { get; set; }

        /// <summary>
        /// Format the max zoom range depending on scale type. Obsolete - remove in future release
        /// </summary>
        [Obsolete("Use settings on Wheel, Drag, and Pinch to control specific zoom behaviors ")]
        public Range RangeMax { get; set; }
    }
}
