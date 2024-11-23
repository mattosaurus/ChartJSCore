using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Plugins.Annotation
{
    public class AnnotationPlugin
    {
        public Dictionary<string, ChartJSCore.Plugins.Annotation.Annotation> Annotations { get; set; } = new Dictionary<string, Annotation>();
    }
}
