﻿using ChartJSCore.Helpers;
using ChartJSCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Plugins.Annotation
{
    /// <summary>
    ///  Label annotations are used to add contents on the chart area. This can be useful for describing values that are of interest.
    /// </summary>
    public class LabelAnnotation : Annotation
    {
        public string Type { get; private set; } = "label";
        public double? xValue { get; set; }
        public double? yValue { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public List<string> Content { get; set; } = new List<string>();
        public Font Font { get; set; }
        public ChartColor Color { get; set; }       
    }
}
