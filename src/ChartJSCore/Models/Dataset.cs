using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.5.1/general/data-structures.html
    // TODO: Allow scatter datasets to be accepted as data.
    public class Dataset : Base
    {
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// How to clip relative to chartArea. Positive value allows overflow, negative value clips that many pixels inside chartArea. 0 = clip at chartArea. Clipping can also be configured per side: clip: {left: 5, top: false, right: -2, bottom: 0}
        /// </summary>
        [JsonConverter(typeof(ClipConverter))]
        public Clip Clip { get; set; }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        public int? Order { get; set; }

        /// <summary>
        /// The ID of the group to which this dataset belongs to (when stacked, each group will be a separate stack). Defaults to dataset type.
        /// </summary>
        public virtual string Stack { get; set; }

        /// <summary>
        /// The data to plot in a line.
        /// </summary>
        public IList<double?> Data { get; set; }

        /// <summary>
        /// How to parse the dataset. The parsing can be disabled by specifying parsing: false at chart options or dataset. If parsing is disabled, data must be sorted and in the formats the associated chart type and scales use internally.
        /// </summary>
        public virtual bool? Parsing { get; set; }

        /// <summary>
        /// Start Dataset Disabled if set to True
        /// </summary>
        public bool? Hidden { get; set; }
    }
}
