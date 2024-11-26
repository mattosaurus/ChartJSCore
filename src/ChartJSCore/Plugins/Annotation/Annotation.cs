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
        public bool AdjustScaleRange { get; set; } = true;

        /// <summary>
        /// Fill color.
        /// </summary>
        public ChartColor BackgroundColor { get; set; } = ChartColor.FromRgba(255, 99, 132, 1);

        /// <summary>
        /// Stroke color.
        /// </summary>
        public ChartColor BorderColor { get; set; } = ChartColor.FromRgba(255, 99, 132, 1);
        public List<int> BorderDash { get; set; } = new List<int>();
        public int BorderDashOffset { get; set; }
        public ChartColor BorderShadowColor { get; set; }
        public bool Display { get; set; } = true;
        public string DrawTime { get; set; } = "afterDatasetsDraw";

        /// <summary>
        /// Identifies a unique id for the annotation and it will be stored in the element context. 
        /// When the annotations are defined by an object, the id is automatically set using the key 
        /// used to store the annotations in the object. When the annotations are configured by an 
        /// array, the id, passed by this option in the annotation, will be used.
        /// </summary>
        public string Id { get; set; }
        public int ShadowBlur { get; set; } = 0;
        public int ShadowOffsetX { get; set; } = 0;
        public int ShadowOffsetY { get; set; } = 0;

        /// <summary>
        /// Left edge of the box in units along the x axis.
        /// </summary>
        public decimal xMin { get; set; }

        /// <summary>
        /// Right edge of the box in units along the x axis.
        /// </summary>
        public decimal xMax { get; set; }


        /// <summary>
        /// Top edge of the box in units along the y axis.
        /// </summary>
        public decimal yMin { get; set; }

        /// <summary>
        /// Bottom edge of the box in units along the y axis.
        /// </summary>
        public decimal yMax { get; set; }

        /// <summary>
        /// Adjustment along x-axis (left-right) of label relative to computed position. Negative values move the label left, positive right.
        /// </summary>
        public decimal xAdjust { get; set; } = 0;

        /// <summary>
        /// Adjustment along y-axis (top-bottom) of label relative to computed position. Negative values move the label up, positive down.
        /// </summary>
        public decimal yAdjust { get; set; } = 0;

        /// <summary>
        ///  ID of the X scale to bind onto. If missing, the plugin will try to use the scale of the chart, 
        ///  configured as 'x' axis. If more than one scale has been defined in the chart as 'x' axis, the
        ///  option is mandatory to select the right scale.
        /// </summary>
        public decimal xScaleID { get; set; } = 0;

        /// <summary>
        ///  ID of the Y scale to bind onto. If missing, the plugin will try to use the scale of the chart, configured as 
        ///  'y' axis. If more than one scale has been defined in the chart as 'y' axis, the option is mandatory 
        ///  to select the right scale.
        /// </summary>
        public decimal yScaleID { get; set; } = 0;

        /// <summary>
        ///  The z property determines the drawing stack level of the label annotation element. 
        ///  All visible elements will be drawn in ascending order of z option, with the same drawTime option.
        /// </summary>
        public decimal z { get; set; } = 0;
        public decimal? Width { get; set; }

        /// <summary>
        /// Overrides the height of the image or canvas element. Could be set in 
        /// pixel by a number, or in percentage of current height of image or 
        /// canvas element by a string. If undefined, uses the height of the 
        /// image or canvas element. It is used only when the content is an image or canvas element.
        /// </summary>
        public decimal? Height { get; set; }

        /// <summary>
        /// Anchor position of label on line. Options are: 'left', 'right' or 'center'.
        /// </summary>
        public string Position { get; set; } = "center";

        /// <summary>
        /// Horizontal alignment of the label text. Options are: 'left', 'right' or 'center'.
        /// </summary>
        public string TextPosition { get; set; } = "center";

        /// <summary>
        /// Rotation of the label in degrees.
        /// </summary>
        public int Rotation { get; set; } = 0;
        
        
    }
}
