using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class ToolTip
    {
        /// <summary>
        /// Are tooltips enabled.
        /// </summary>
        public bool? Enabled { get; set; }

        public string Custom { get; set; }

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
        public string ItemSort { get; set; }

        /// <summary>
        /// Allows filtering of tooltip items. Must implement at minimum a function that can be passed to Array.prototype.filter. This function can also accept a second parameter that is the data object passed to the ChartJSCore.
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// Background color of the tooltip.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Font family for tooltip title inherited from global font family.
        /// </summary>
        public string TitleFontFamily { get; set; }

        /// <summary>
        /// Font size for tooltip title inherited from global font size.
        /// </summary>
        public int? TitleFontSize { get; set; }

        /// <summary>
        /// Font style for tooltip title.
        /// </summary>
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Font color for tooltip title.
        /// </summary>
        public string TitleFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public int? TitleSpacing { get; set; }

        /// <summary>
        /// Margin to add on bottom of title section.
        /// </summary>
        public int? TitleMarginBottom { get; set; }

        /// <summary>
        /// Font family for tooltip items inherited from global font family.
        /// </summary>
        public string BodyFontFamily { get; set; }

        /// <summary>
        /// Font size for tooltip items inherited from global font size.
        /// </summary>
        public int? BodyFontSize { get; set; }

        /// <summary>
        /// Font style for tooltip body.
        /// </summary>
        public string BodyFontStyle { get; set; }

        /// <summary>
        /// Font color for tooltip items.
        /// </summary>
        public string BodyFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each tooltip item.
        /// </summary>
        public int? BodySpacing { get; set; }

        /// <summary>
        /// Font family for tooltip footer inherited from global font family.
        /// </summary>
        public string FooterFontFamily { get; set; }

        /// <summary>
        /// Font size for tooltip footer inherited from global font size.
        /// </summary>
        public int? FooterFontSize { get; set; }

        /// <summary>
        /// Font style for tooltip footer.
        /// </summary>
        public string FooterFontStyle { get; set; }

        /// <summary>
        /// Font color for tooltip footer.
        /// </summary>
        public string FooterFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each footer line.
        /// </summary>
        public int? FooterSpacing { get; set; }

        /// <summary>
        /// Margin to add before drawing the footer.
        /// </summary>
        public int? FooterMarginTop { get; set; }

        /// <summary>
        /// Padding to add on left and right of tooltip.
        /// </summary>
        public int? XPadding { get; set; }

        /// <summary>
        /// Padding to add on top and bottom of tooltip.
        /// </summary>
        public int? YPadding { get; set; }

        /// <summary>
        /// Size, in px, of the tooltip arrow.
        /// </summary>
        public int? CaretSize { get; set; }

        /// <summary>
        /// 	Radius of tooltip corner curves.
        /// </summary>
        public int? CornerRadius { get; set; }

        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip.
        /// </summary>
        public string MultiKeyBackground { get; set; }

        /// <summary>
        /// if true, color boxes are shown in the tooltip.
        /// </summary>
        public bool? DisplayColors { get; set; }

        public Callback Callbacks { get; set; }
    }
}
