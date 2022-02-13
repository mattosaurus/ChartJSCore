using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public abstract class Base
    {
        [JsonExtensionData]
        public Dictionary<string, object> PluginDynamic { get; set; }
    }
}
