using ChartJSCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Plugins.Zoom
{
    /// <summary>
    /// Requires Zoom and Pan plugin.
    /// https://github.com/chartjs/chartjs-plugin-zoom
    /// </summary>
    public class ZoomRadarOptions : RadarOptions
    {
        public Pan Pan { get; set; }

        public Zoom Zoom { get; set; }
    }
}
