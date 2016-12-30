using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    // TODO: Implement color object rather than using string.
    // TODO: Implement mixed chart types.
    public class Data
    {
        public IList<Dataset> Datasets { get; set; }

        public IList<string> Labels { get; set; }

        public IList<string> XLabels { get; set; }

        public IList<string> YLabels { get; set; }
    }
}
