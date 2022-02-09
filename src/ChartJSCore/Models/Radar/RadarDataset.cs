using ChartJSCore.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartJSCore.Models
{
    public class RadarDataset : Dataset
    {
        /// <summary>
        /// The type of the dataset
        /// </summary>
        public Enums.ChartType Type { get; set; } = Enums.ChartType.Radar;

        #region General
        // https://www.chartjs.org/docs/latest/charts/radar.html#general
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The drawing order of dataset. Also affects order for stacking, tooltip and legend.
        /// </summary>
        public int? Order { get; set; }
        #endregion General

        #region PointStyling
        // https://www.chartjs.org/docs/latest/charts/radar.html#point-styling
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
        #endregion PointStyling

        #region LineStyling
        // https://www.chartjs.org/docs/latest/charts/radar.html#line-styling
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
        /// If true, fill the area under the line.
        /// </summary>
        [JsonConverter(typeof(BoolIntStringConverter))]
        public string Fill { get; set; }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public double? Tension { get; set; }

        /// <summary>
        /// If true, lines will be drawn between points with no or null data. If false, points with null data will create a break in the line. Can also be a number specifying the maximum gap length to span. The unit of the value depends on the scale used.
        /// </summary>
        public bool? SpanGaps { get; set; }
        #endregion LineStyling

        #region Interactions
        // https://www.chartjs.org/docs/latest/charts/radar.html#interactions
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

        #region Scale
        // https://www.chartjs.org/docs/latest/charts/radar.html#scale-options
        /// <summary>
        /// The radar chart supports only a single scale. The options for this scale are defined in the scales.r property
        /// </summary>
        public Scale Scale { get; set; }
        #endregion Scale
























        /// <summary>
        /// If true, fill the area under the line.
        /// </summary>
        public bool? Fill { get; set; }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public double? LineTension { get; set; }

        /// <summary>
        /// The fill color under the line.
        /// </summary>
        public ChartColor BackgroundColor { get; set; }

        /// <summary>
        /// The width of the line in pixels.
        /// </summary>
        public int? BorderWidth { get; set; }

        /// <summary>
        /// The color of the line.
        /// </summary>
        public ChartColor BorderColor { get; set; }

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
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> PointBorderColor { get; set; }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> PointBackgroundColor { get; set; }

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
        public IList<int> HitRadius { get; set; }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<ChartColor>))]
        public IList<ChartColor> PointHoverBorderColor { get; set; }

        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        public IList<int> PointHoverBorderWidth { get; set; }

        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'. If the option is an image, that image is drawn on the canvas using drawImage.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        public IList<string> PointStyle { get; set; }
    }
}
