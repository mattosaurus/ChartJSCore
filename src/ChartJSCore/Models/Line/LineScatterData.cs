using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class LineScatterData : Base
    {
        [JsonConverter(typeof(DoubleStringConverter))]
        public string X { get; set; }

        [JsonConverter(typeof(DoubleStringConverter))]
        public string Y { get; set; }
    }
}
