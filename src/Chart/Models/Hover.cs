using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Hover
    {
        public string Mode { get; set; }

        public bool? Intersect { get; set; }

        public int? AnimationDuration { get; set; }

        public string OnHover { get; set; }
    }
}
