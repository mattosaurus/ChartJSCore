using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Chart
    {
        public string Type { get; set; }

        public Data Data { get; set; }

        // TODO: Update to only accept options and derived classes
        public Object Options { get; set; }

        public string SerializeBody()
        {
            // keys need to be camel case to match data contract so use custom serializer to alter
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelcaseContractResolver();
            settings.NullValueHandling = NullValueHandling.Ignore;

            string json = JsonConvert.SerializeObject(this, settings);

            return json;
        }

        public string CreateChartCode(string canvasId)
        {
            string code = "var " + canvasId + "Element = document.getElementById(\"" + canvasId + "\");\r\n";
            code += "var " + canvasId + " = new Chart(" + canvasId + "Element, ";

            // keys need to be camel case to match data contract so use custom serializer to alter
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelcaseContractResolver();
            settings.NullValueHandling = NullValueHandling.Ignore;

            string json = JsonConvert.SerializeObject(this, settings);

            code += json + "\r\n";
            code += ");";

            return code;
        }
    }
}
