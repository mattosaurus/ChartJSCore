using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Helpers {
    public class LineChartFill {
        [JsonConverter(typeof(BoolIntStringConverter))]
        public string target { get; set; }
        public ChartColor above { get; set; }
        public ChartColor below { get; set; }
    }
}
