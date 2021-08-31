using ChartJSCore.Helpers;
using Newtonsoft.Json;

namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.5.1/configuration/tooltip.html
    public class ToolTip : Base
    {
        /// <summary>
        /// Are on-canvas tooltips enabled?
        /// </summary>
        public bool? Enabled { get; set; }

        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string External { get; set; }

        /// <summary>
        /// Sets which elements appear in the tooltip.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// If true, the tooltip mode applies only when the mouse position intersects with an element. If false, the mode will be applied at all times.
        /// </summary>
        public bool? Intersect { get; set; }

        /// <summary>
        /// The mode for positioning the tooltip. 'average' mode will place the tooltip at the average position of the items displayed in the tooltip. 'nearest' will place the tooltip at the position of the element closest to the event position. New modes can be defined by adding functions to the ChartJSCore.Tooltip.positioners map.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Allows sorting of tooltip items. Must implement at minimum a function that can be passed to Array.prototype.sort. This function can also accept a third parameter that is the data object passed to the ChartJSCore.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string ItemSort { get; set; }

        /// <summary>
        /// Allows filtering of tooltip items. Must implement at minimum a function that can be passed to Array.prototype.filter. This function can also accept a second parameter that is the data object passed to the ChartJSCore.
        /// </summary>
        [JsonConverter(typeof(PlainJsonStringConverter))]
        public string Filter { get; set; }

        /// <summary>
        /// Background color of the tooltip.
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// Color of title text.
        /// </summary>
        public ChartColor TitleColor { get; set; }

        /// <summary>
        /// Font of the tooltip.
        /// </summary>
        public Font TitleFont { get; set; }

        /// <summary>
        /// Horizontal alignment of the title text lines.
        /// </summary>
        public string TitleAlign { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public int? TitleSpacing { get; set; }

        /// <summary>
        /// Margin to add on bottom of title section.
        /// </summary>
        public int? TitleMarginBottom { get; set; }

        /// <summary>
        /// Color of body text.
        /// </summary>
        public ChartColor BodyColor { get; set; }

        /// <summary>
        /// Font of the tooltip body.
        /// </summary>
        public Font BodyFont { get; set; }

        /// <summary>
        /// Horizontal alignment of the body text lines.
        /// </summary>
        public string BodyAlign { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each tooltip item.
        /// </summary>
        public int? BodySpacing { get; set; }

        /// <summary>
        /// Color of footer text.
        /// </summary>
        public ChartColor FooterColor { get; set; }

        /// <summary>
        /// Horizontal alignment of the footer text lines.
        /// </summary>
        public string FooterAlign { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each footer line.
        /// </summary>
        public int? FooterSpacing { get; set; }

        /// <summary>
        /// Margin to add before drawing the footer.
        /// </summary>
        public int? FooterMarginTop { get; set; }

        /// <summary>
        /// Padding inside the tooltip.
        /// </summary>
        [JsonConverter(typeof(PaddingConverter))]
        public Padding Padding { get; set; }

        /// <summary>
        /// Extra distance to move the end of the tooltip arrow away from the tooltip point.
        /// </summary>
        public int? CaretPadding { get; set; }

        /// <summary>
        /// Size, in px, of the tooltip arrow.
        /// </summary>
        public int? CaretSize { get; set; }

        /// <summary>
        /// Radius of tooltip corner curves.
        /// </summary>
        public int? CornerRadius { get; set; }

        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip.
        /// </summary>
        public ChartColor MultiKeyBackground { get; set; }

        /// <summary>
        /// if true, color boxes are shown in the tooltip.
        /// </summary>
        public bool? DisplayColors { get; set; }

        /// <summary>
        /// Width of the color box if displayColors is true.
        /// </summary>
        public int? BoxWidth { get; set; }

        /// <summary>
        /// Height of the color box if displayColors is true.
        /// </summary>
        public int? BoxHeight { get; set; }

        /// <summary>
        /// Use the corresponding point style (from dataset options) instead of color boxes, ex: star, triangle etc. (size is based on the minimum value between boxWidth and boxHeight).
        /// </summary>
        public bool? UsePointStyle { get; set; }

        /// <summary>
        /// Color of the border.
        /// </summary>
        public ChartColor BorderColor { get; set; }

        /// <summary>
        /// Size of the border.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// true for rendering the tooltip from right to left.
        /// </summary>
        public bool? Rtl { get; set; }

        public string TextDirection { get; set; }

        /// <summary>
        /// Position of the tooltip caret in the X direction.
        /// </summary>
        public string XAlign { get; set; }

        /// <summary>
        /// Position of the tooltip caret in the Y direction.
        /// </summary>
        public string YAlign { get; set; }

        public Callback Callbacks { get; set; }
    }
}
