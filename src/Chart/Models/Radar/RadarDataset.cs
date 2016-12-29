using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    public class RadarDataset : Dataset
    {
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
        public int? BorderDashOffset { get; set; }

        /// <summary>
        /// Line joint style.
        /// </summary>
        public string BorderJoinStyle { get; set; }

        /// <summary>
        /// The border color for points.
        /// </summary>
        public IList<string> PointBorderColor { get; set; }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        public IList<string> PointBackgroundColor { get; set; }

        /// <summary>
        /// The width of the point border in pixels.
        /// </summary>
        public IList<int> PointBorderWidth { get; set; }

        /// <summary>
        /// The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        public IList<int> PointRadius { get; set; }

        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        public IList<int> PointHoverRadius { get; set; }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        public IList<int> HitRadius { get; set; }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        public IList<string> PointHoverBackgroundColor { get; set; }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        public IList<string> PointHoverBorderColor { get; set; }

        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        public IList<int> PointHoverBorderWidth { get; set; }

        // TODO: Allow images as well as strings.
        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'. If the option is an image, that image is drawn on the canvas using drawImage.
        /// </summary>
        public IList<string> PointStyle { get; set; }
    }
}
