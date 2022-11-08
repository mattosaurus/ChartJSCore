using ChartJSCore.Helpers;
using ChartJSCore.Models;

namespace ChartJSCore.Plugins.Zoom
{
    /// <summary>
    /// Container for Drag-to-Zoom options
    /// </summary>
    /// <remarks>
    /// Note that <see cref="Pan">panning</see> and Drag-to-Zoom are mutually exclusive. To enable both, you must place a <see cref="ModifierKey"/> on one or both.
    /// </remarks>
    public class Drag
    {
        /// <summary>
        /// Boolean to enable drag-to-zoom.
        /// </summary>
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Fill color of drag-to-zoom selection area
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// Drag to zoom selection area stroke width.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// Stroke color of drag-to-zoom selection area
        /// </summary>
        public ChartColor BorderColor { get; set; }
        
        /// <summary>
        /// Minimal zoom distance required before actually applying zoom
        /// </summary>
        public double? Threshold { get; set; }
        
        /// <summary>
        /// Modifier key required for drag-to-zoom
        /// </summary>
        public Enums.ModifierKey? ModifierKey { get; set; }
    }
}