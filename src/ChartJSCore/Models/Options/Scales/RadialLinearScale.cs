using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class RadialLinearScale : Scale
    {
        public bool LineArc { get; set; }

        public AngleLine AngleLines { get; set; }

        public PointLabel PointLabels { get; set; }
    }
}
