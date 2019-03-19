using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class LineScatterData : Base
    {
        [JsonConverter(typeof(DoubleStringConverter))]
        public string x { get; set; }

        [JsonConverter(typeof(DoubleStringConverter))]
        public string y { get; set; }
    }
}
