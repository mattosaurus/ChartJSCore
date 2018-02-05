using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class RadialScale : Scale
    {
        public AngleLine AngleLines { get; set; }

        public GridLine GridLines { get; set; }

        public PointLabel PointLabels { get; set; }

        public Tick Ticks { get; set; }
    }
}
