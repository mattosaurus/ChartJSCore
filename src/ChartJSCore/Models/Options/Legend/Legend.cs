namespace ChartJSCore.Models
{
    // https://www.chartjs.org/docs/3.5.1/configuration/legend.html
    public class Legend : Base
    {
        /// <summary>
        /// Is the legend displayed.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// 	Position of the legend. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Alignment of the legend.
        /// </summary>
        public string Align { get; set; }

        /// <summary>
        /// Maximum height of the legend, in pixels.
        /// </summary>
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Maximum width of the legend, in pixels.
        /// </summary>
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Marks that this box should take the full width/height of the canvas (moving other boxes). This is unlikely to need to be changed in day-to-day use.
        /// </summary>
        public bool? FullSize { get; set; }

        /// <summary>
        /// A callback that is called when a 'click' event is registered on top of a label item.
        /// </summary>
        public string OnClick { get; set; }

        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered on top of a label item.
        /// </summary>
        public string OnHover { get; set; }

        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered outside of a previously hovered label item. Arguments: [event, legendItem, legend].
        /// </summary>
        public string OnLeave { get; set; }

        /// <summary>
        /// Legend will show datasets in reverse order
        /// </summary>
        public bool? Reverse { get; set; }

        public LegendLabel Labels { get; set; }

        /// <summary>
        /// true for rendering the legends from right to left.
        /// </summary>
        public bool? Rtl { get; set; }

        /// <summary>
        /// This will force the text direction 'rtl' or 'ltr' on the canvas for rendering the legend, regardless of the css specified on the canvas
        /// </summary>
        public string TextDirection { get; set; }

        public Title Title { get; set; }
    }
}
