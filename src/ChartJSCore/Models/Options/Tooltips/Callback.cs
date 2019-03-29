using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    //TODO: Create correct tooltip item object rather than using string
    public class Callback : Base
    {
        /// <summary>
        /// Text to render before the title.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeTitle { get; set; }

        /// <summary>
        /// Text to render as the title.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Title { get; set; }

        /// <summary>
        /// Text to render after the title.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterTitle { get; set; }

        /// <summary>
        /// Text to render before the body section.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeBody { get; set; }

        /// <summary>
        /// Text to render before an individual label.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeLabel { get; set; }

        /// <summary>
        /// Text to render for an individual item in the tooltip.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Label { get; set; }

        /// <summary>
        /// Returns the colors to render for the tooltip item. Return as an object containing two parameters: borderColor and backgroundColor.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string LabelColor { get; set; }

        /// <summary>
        /// Text to render after an individual label.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterLabel { get; set; }

        /// <summary>
        /// Text to render after the body section.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterBody { get; set; }

        /// <summary>
        /// Text to render before the footer section.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string BeforeFooter { get; set; }

        /// <summary>
        /// Text to render as the footer.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Footer { get; set; }

        /// <summary>
        /// Text to render after the footer section.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string AfterFooter { get; set; }

        /// <summary>
        /// List of matching point informations.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string DataPoints { get; set; }
    }
}
