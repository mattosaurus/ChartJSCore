using ChartJSCore.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Plugins.Annotation
{
    /// <summary>
    /// Line annotations are used to draw lines on the chart area. This can be useful for highlighting information such as a threshold.
    /// </summary>
    public class LineAnnotation : Annotation
    {
        public string Type { get; private set; } = "line";
        public LabelAnnotation Label { get; set; }
        public bool Curve { get; set; }
        public string ScaleID { get; set; }
        public int BorderWidth { get; set; } = 2;        
    }
}
