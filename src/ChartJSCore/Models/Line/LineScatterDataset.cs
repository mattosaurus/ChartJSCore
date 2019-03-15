using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class LineScatterDataset : LineDataset
    {
        /// <summary>
        /// The scatter data to plot in a line.
        /// </summary>
        public new IList<LineScatterData> Data { get; set; }
    }
}
