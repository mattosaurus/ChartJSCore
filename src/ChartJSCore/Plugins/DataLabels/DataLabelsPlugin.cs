using ChartJSCore.Helpers;
using ChartJSCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ChartJSCore.Plugins.DataLabels
{
    public class DataLabelsPlugin: Models.Options
    {
        /// <summary>
        /// The align option defines the position of the label relative to the anchor point position and orientation. 
        /// Its value can be expressed either by a number representing the clockwise angle (in degree) or by one 
        /// of the following string presets:
        /// 
        /// 'center' (default): the label is centered on the anchor point
        /// 'start': the label is positioned before the anchor point, following the same direction
        /// 'end': the label is positioned after the anchor point, following the same direction
        /// 'right': the label is positioned to the right of the anchor point(0°)
        /// 'bottom': the label is positioned to the bottom of the anchor point(90°)
        /// 'left': the label is positioned to the left of the anchor point(180°)
        /// 'top': the label is positioned to the top of the anchor point(270°)
        /// </summary>
        public string Align { get; set; } = "center";

        /// <summary>
        /// An anchor point is defined by an orientation vector and a position on the data element. 
        /// The orientation depends on the scale type (vertical, horizontal or radial). The position 
        /// is calculated based on the anchor option and the orientation vector.
        /// 
        /// Supported values for anchor:
        /// 
        /// 'center' (default): element center
        /// 'start': lowest element boundary
        /// 'end': highest element boundary
        /// </summary>
        public string Anchor { get; set; } = "center";
        public ChartColor BackgroundColor { get; set; }
        public ChartColor BorderColor { get; set; }
        public int BorderRadius { get; set; } = 0;
        public int BorderWidth { get; set; } = 0;

        /// <summary>
        /// The clamp option, when true, enforces the anchor position to be calculated based on 
        /// the visible geometry of the associated element (i.e. part inside the chart area).
        /// </summary>
        public bool Clamp { get; set; } = false;

        /// <summary>
        /// When the clip option is true, the part of the label which is outside the chart 
        /// area will be masked (see CanvasRenderingContext2D.clip() )
        /// </summary>
        public bool Clip { get; set; } = false;
        public ChartColor Color { get; set; }
        public bool Display { get; set; } = true;
        public Font Font { get; set; }
        public string Formatter { get; set; }

        /// <summary>
        /// The offset represents the distance (in pixels) to pull the label away from the anchor point. 
        /// This option is not applicable when align is 'center'. Also note that if align is 'start', 
        /// the label is moved in the opposite direction. The default value is 4.
        /// </summary>
        public int Offset { get; set; } = 4;
        public int Opacity { get; set; } = 1;
        public Padding Padding { get; set; }
        public int Rotation { get; set; } = 0;
        public string TextAlign { get; set; } = "start";
        public ChartColor TextStrokeColor { get; set; }

        public int TextStrokeWidth { get; set; } = 0;
        public int TextShadowBlur { get; set; } = 0;
        public ChartColor TextShadowColor { get; set; }                      
    }
}
