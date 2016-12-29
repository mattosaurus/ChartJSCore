using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class LineOptions : Options
    {
        public bool? ShowLines { get; set; }

        public bool? SpanGaps { get; set; }
    }
}
