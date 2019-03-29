using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class CategoryTick : CartesianTick
    {
        /// <summary>
        /// The minimum item to display.
        /// </summary>
        public string Min { get; set; }

        /// <summary>
        /// The maximum item to display.
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        /// An array of labels to display.
        /// </summary>
        public List<string> Labels { get; set; }
    }
}
