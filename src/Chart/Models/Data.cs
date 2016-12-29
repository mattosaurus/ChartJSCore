using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    // TODO: Implement color object rather than using string.
    // TODO: Implement mixed chart types.
    public class Data
    {
        public IList<Dataset> Datasets { get; set; }

        public IList<string> Labels { get; set; }

        public IList<XLabel> XLabels { get; set; }

        public IList<YLabel> YLabels { get; set; }
    }
}
