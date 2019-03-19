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

        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID { get; set; }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID { get; set; }

        /// <summary>
        /// If true, fill the area under the line.
        /// </summary>
        [JsonConverter(typeof(BoolIntStringConverter))]
        public string Fill { get; set; }

        /// <summary>
        /// Algorithm used to interpolate a smooth curve from the discrete data points. Options are 'default' and 'monotone'. The 'default' algorithm uses a custom weighted cubic interpolation, which produces pleasant curves for all types of datasets. The 'monotone' algorithm is more suited to y = f(x) datasets : it preserves monotonicity (or piecewise monotonicity) of the dataset being interpolated, and ensures local extremums (if any) stay at input data points. If left untouched (undefined), the global options.elements.line.cubicInterpolationMode property is used.
        /// </summary>
        public string CubicInterpolationMode { get; set; }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public double? LineTension { get; set; }

        /// <summary>
        /// The fill color under the line.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// The width of the line in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// The color of the line.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        public string BorderCapStyle { get; set; }

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
        /// The border color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointBorderColor { get; set; }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointBackgroundColor { get; set; }

        /// <summary>
        /// The width of the point border in pixels.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointBorderWidth { get; set; }

        /// <summary>
        /// The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointRadius { get; set; }

        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointHoverRadius { get; set; }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointHitRadius { get; set; }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointHoverBorderColor { get; set; }

        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointHoverBorderWidth { get; set; }

        // TODO: Allow images as well as strings.
        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'. If the option is an image, that image is drawn on the canvas using drawImage.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointStyle { get; set; }

        /// <summary>
        /// If false, the line is not drawn for this dataset.
        /// </summary>
        public bool? ShowLine { get; set; }

        /// <summary>
        /// If true, lines will be drawn between points with no or null data.
        /// </summary>
        public bool? SpanGaps { get; set; }

        /// <summary>
        /// If true, the line is shown as a stepped line and 'lineTension' will be ignored.
        /// </summary>
        [JsonConverter(typeof(BoolIntStringConverter))]
        public string SteppedLine { get; set; }
    }
}
