using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Layout : Base
    {
        [JsonConverter(typeof(PaddingConverter))]
        public Padding Padding { get; set; }
    }
}
