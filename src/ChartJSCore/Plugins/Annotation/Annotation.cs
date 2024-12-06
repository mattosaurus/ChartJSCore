using ChartJSCore.Helpers;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ChartJSCore.Plugins.Annotation
{
    public class Annotation
    {
        /// <summary>
        /// Should the scale range be adjusted if this annotation is out of range.
        /// </summary>
        public bool? AdjustScaleRange { get; set; }

        /// <summary>
        /// Fill color.
        /// </summary>
        public ChartColor BackgroundColor { get; set; } 

        /// <summary>
        /// Stroke color.
        /// </summary>
        public ChartColor BorderColor { get; set; } 
        public List<int> BorderDash { get; set; } = new List<int>();
        public int? BorderDashOffset { get; set; }
        public ChartColor BorderShadowColor { get; set; }
        public bool Display { get; set; } = true;
        public string DrawTime { get; set; }

        /// <summary>
        /// Identifies a unique id for the annotation and it will be stored in the element context. 
        /// When the annotations are defined by an object, the id is automatically set using the key 
        /// used to store the annotations in the object. When the annotations are configured by an 
        /// array, the id, passed by this option in the annotation, will be used.
        /// </summary>
        public string Id { get; set; }
        public int? ShadowBlur { get; set; }
        public int? ShadowOffsetX { get; set; }
        public int? ShadowOffsetY { get; set; }

        /// <summary>
        /// Left edge of the box in units along the x axis.
        /// </summary>
        public double? xMin { get; set; }

        /// <summary>
        /// Right edge of the box in units along the x axis.
        /// </summary>
        public double? xMax { get; set; }

        /// <summary>
        /// Top edge of the box in units along the y axis.
        /// </summary>
        public double? yMin { get; set; }

        /// <summary>
        /// Bottom edge of the box in units along the y axis.
        /// </summary>
        public double? yMax { get; set; }

        /// <summary>
        /// Adjustment along x-axis (left-right) of label relative to computed position. Negative values move the label left, positive right.
        /// </summary>
        public double? xAdjust { get; set; }

        /// <summary>
        /// Adjustment along y-axis (top-bottom) of label relative to computed position. Negative values move the label up, positive down.
        /// </summary>
        public double? yAdjust { get; set; }

        /// <summary>
        ///  ID of the X scale to bind onto. If missing, the plugin will try to use the scale of the chart, 
        ///  configured as 'x' axis. If more than one scale has been defined in the chart as 'x' axis, the
        ///  option is mandatory to select the right scale.
        /// </summary>
        public string xScaleID { get; set; }

        /// <summary>
        ///  ID of the Y scale to bind onto. If missing, the plugin will try to use the scale of the chart, configured as 
        ///  'y' axis. If more than one scale has been defined in the chart as 'y' axis, the option is mandatory 
        ///  to select the right scale.
        /// </summary>
        public string yScaleID { get; set; }

        /// <summary>
        ///  The z property determines the drawing stack level of the label annotation element. 
        ///  All visible elements will be drawn in ascending order of z option, with the same drawTime option.
        /// </summary>
        public double? z { get; set; }
        public double? Width { get; set; }

        /// <summary>
        /// Overrides the height of the image or canvas element. Could be set in 
        /// pixel by a number, or in percentage of current height of image or 
        /// canvas element by a string. If undefined, uses the height of the 
        /// image or canvas element. It is used only when the content is an image or canvas element.
        /// </summary>
        public double? Height { get; set; }

        /// <summary>
        /// Anchor position of label on line. Options are: 'left', 'right' or 'center'.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'.
        /// </summary>
        public string TextPosition { get; set; }

        /// <summary>
        /// Rotation of the label in degrees.
        /// </summary>
        public int Rotation { get; set; } = 0;
        
        
    }
}
