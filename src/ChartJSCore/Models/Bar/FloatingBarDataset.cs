using System.Collections.Generic;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/latest/samples/bar/floating.html
    /// <summary>
    /// Dataset for a Floating Bar chart
    /// </summary>
    public class FloatingBarDataset : BarDataset
    {
        /// <summary>
        /// The data to plot. Must be in the form of a List containing pairs of values (lower and upper value) for each bar.
        /// </summary>
        public new List<List<double>> Data { get; set; }
    }
}