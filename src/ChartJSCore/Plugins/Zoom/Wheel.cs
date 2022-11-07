using ChartJSCore.Models;

namespace ChartJSCore.Plugins.Zoom
{
    /// <summary>
    /// Container for mouse wheel Zoom Options
    /// </summary>
    public class Wheel
    {
        /// <summary>
        /// Boolean to enable zooming via mouse wheel.
        /// </summary>
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Factor of zoom speed via mouse wheel
        /// </summary>
        public double? Speed { get; set; }
        
        /// <summary>
        /// Modifier key required for zooming via mouse wheel
        /// </summary>
        public Enums.ModifierKey? ModifierKey { get; set; }
    }
}