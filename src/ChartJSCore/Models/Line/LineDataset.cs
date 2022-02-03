using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class LineDataset : Dataset
    {
        /// <summary>
        /// The type of the dataset
        /// </summary>
        public Enums.ChartType Type { get; set; } = Enums.ChartType.Line;

        #region General
        // https://www.chartjs.org/docs/latest/charts/line.html#general
        /// <summary>
        /// The base axis of the dataset. 'x' for horizontal lines and 'y' for vertical lines.
        /// </summary>
        public string IndexAxis { get; set; }

        // https://www.chartjs.org/docs/latest/charts/bar.html#general
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID { get; set; }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID { get; set; }
        #endregion General

        #region PointStyling
        // https://www.chartjs.org/docs/latest/charts/line.html#point-styling
        /// <summary>
        /// The fill color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> PointBackgroundColor { get; set; }

        /// <summary>
        /// The border color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> PointBorderColor { get; set; }

        /// <summary>
        /// The width of the point border in pixels.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointBorderWidth { get; set; }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointHitRadius { get; set; }

        /// <summary>
        /// The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointRadius { get; set; }

        /// <summary>
        /// The rotation of the point in degrees.
        /// </summary>
        public int? PointRotation { get; set; }

        // TODO: Allow images as well as strings.
        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'. If the option is an image, that image is drawn on the canvas using drawImage.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointStyle { get; set; }

        /// <summary>
        /// Draw the active points of a dataset over the other points of the dataset
        /// </summary>
        public bool? DrawActiveElementsOnTop { get; set; }
        #endregion PointStyling

        #region LineStyling
        // https://www.chartjs.org/docs/latest/charts/line.html#line-styling
        /// <summary>
        /// The fill color under the line.
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        public string BorderCapStyle { get; set; }

        /// <summary>
        /// The color of the line.
        /// </summary>
        public ChartColor BorderColor { get; set; }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        public IList<int> BorderDash { get; set; }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public double? BorderDashOffset { get; set; }

        /// <summary>
        /// Line joint style.
        /// </summary>
        public string BorderJoinStyle { get; set; }

        /// <summary>
        /// The width of the line in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// If true, fill the area under the line.
        /// </summary>
        [JsonConverter(typeof(BoolIntStringConverter))]
        public string Fill { get; set; }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public double? Tension { get; set; }

        /// <summary>
        /// If false, the line is not drawn for this dataset.
        /// </summary>
        public bool? ShowLine { get; set; }

        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with null data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        public bool? SpanGaps { get; set; }
        #endregion LineStyling

        #region Interactions
        // https://www.chartjs.org/docs/latest/charts/line.html#interactions
        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        public ChartColor PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        public ChartColor PointHoverBorderColor { get; set; }

        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        public int? PointHoverBorderWidth { get; set; }

        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        public int? PointHoverRadius { get; set; }
        #endregion Interactions

        #region CubicInterpolationMode
        // https://www.chartjs.org/docs/latest/charts/line.html#cubicinterpolationmode
        /// <summary>
        /// Algorithm used to interpolate a smooth curve from the discrete data points. Options are 'default' and 'monotone'. The 'default' algorithm uses a custom weighted cubic interpolation, which produces pleasant curves for all types of datasets. The 'monotone' algorithm is more suited to y = f(x) datasets : it preserves monotonicity (or piecewise monotonicity) of the dataset being interpolated, and ensures local extremums (if any) stay at input data points. If left untouched (undefined), the global options.elements.line.cubicInterpolationMode property is used.
        /// </summary>
        public string CubicInterpolationMode { get; set; }
        #endregion CubicInterpolationMode

        #region Stepped
        // https://www.chartjs.org/docs/latest/charts/line.html#stepped
        /// <summary>
        /// The following values are supported for stepped.
        /// false: No Step Interpolation (default)
        /// true: Step-before Interpolation(eq. 'before')
        /// 'before': Step-before Interpolation
        /// 'after': Step-after Interpolation
        /// 'middle': Step-middle Interpolation
        /// If the stepped value is set to anything other than false, tension will be ignored.
        /// </summary>
        [JsonConverter(typeof(BoolStringConverter))]
        public string SteppedLine { get; set; }
        #endregion Stepped
    }
}
