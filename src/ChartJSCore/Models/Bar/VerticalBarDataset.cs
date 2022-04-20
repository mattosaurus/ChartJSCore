using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class VerticalBarDataset : BarDataset
    {
        public new IList<VerticalBarDataPoint> Data { get; set; }
    }
}
