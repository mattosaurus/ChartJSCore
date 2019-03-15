using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    public class Layout : Base
    {
        [JsonConverter(typeof(PaddingConverter))]
        public Padding Padding { get; set; }
    }
}
