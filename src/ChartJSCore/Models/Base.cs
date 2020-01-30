using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class Base
    {
        [JsonExtensionData]
        public Dictionary<string, dynamic> PluginDynamic { get; set; }
    }
}
