using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    //TODO: Create correct tooltip item object rather than using string
    public class Callback
    {
        /// <summary>
        /// Text to render before the title.
        /// </summary>
        public string BeforeTitle { get; set; }

        /// <summary>
        /// Text to render as the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Text to render after the title.
        /// </summary>
        public string AfterTitle { get; set; }

        /// <summary>
        /// Text to render before the body section.
        /// </summary>
        public string BeforeBody { get; set; }

        /// <summary>
        /// Text to render before an individual label.
        /// </summary>
        public string BeforeLabel { get; set; }

        /// <summary>
        /// Text to render for an individual item in the tooltip.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Returns the colors to render for the tooltip item. Return as an object containing two parameters: borderColor and backgroundColor.
        /// </summary>
        public string LabelColor { get; set; }

        /// <summary>
        /// Text to render after an individual label.
        /// </summary>
        public string AfterLabel { get; set; }

        /// <summary>
        /// Text to render after the body section.
        /// </summary>
        public string AfterBody { get; set; }

        /// <summary>
        /// Text to render before the footer section.
        /// </summary>
        public string BeforeFooter { get; set; }

        /// <summary>
        /// Text to render as the footer.
        /// </summary>
        public string Footer { get; set; }

        /// <summary>
        /// Text to render after the footer section.
        /// </summary>
        public string AfterFooter { get; set; }

        /// <summary>
        /// List of matching point informations.
        /// </summary>
        public string DataPoints { get; set; }
    }
}
