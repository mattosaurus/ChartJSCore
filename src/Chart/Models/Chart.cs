using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class Chart
    {
        public string Type { get; set; }

        public Data Data { get; set; }

        public Options Options { get; set; }
    }
}
