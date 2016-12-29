using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Tick
    {
        public bool? AutoSkip { get; set; }

        public int? AutoSkipPadding { get; set; }

        public string Callback { get; set; }

        public bool? Display { get; set; }

        public string FontColor { get; set; }

        public string FontFamily { get; set; }

        public int? FontSize { get; set; }

        public string FontStyle { get; set; }

        public int? LabelOffset { get; set; }

        public int? MaxRotation { get; set; }

        public int? MinRotation { get; set; }

        public bool? Mirror { get; set; }

        public int? Padding { get; set; }

        public bool? Reverse { get; set; }
    }
}
