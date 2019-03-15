using ChartJSCore.Models;

namespace ChartJSCore.Plugins.Zoom
{
    /// <summary>
    /// Requires Zoom and Pan plugin.
    /// https://github.com/chartjs/chartjs-plugin-zoom
    /// </summary>
    public class ZoomPieOptions : PieOptions
    {
        public Pan Pan { get; set; }

        public Zoom Zoom { get; set; }
    }
}
