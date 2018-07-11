using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class Base
    {
        [JsonExtensionData]
        public Dictionary<string, object> PluginDynamic { get; set; }
    }
}
