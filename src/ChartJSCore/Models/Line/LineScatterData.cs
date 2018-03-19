using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class LineScatterData
    {
        [JsonConverter(typeof(DoubleStringConverter))]
        public string x { get; set; }

        [JsonConverter(typeof(DoubleStringConverter))]
        public string y { get; set; }
    }
}
