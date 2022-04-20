using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class VerticalBarDataPoint
    {
        public VerticalBarDataPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}
