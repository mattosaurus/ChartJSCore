using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Models
{
    public class CartesianTick : Tick
    {
        /// <summary>
        /// If true, automatically calculates how many labels that can be shown and hides labels accordingly. Turn it off to show all labels no matter what.
        /// </summary>
        public bool? AutoSkip { get; set; }

        /// <summary>
        /// Padding between the ticks on the horizontal axis when autoSkip is enabled. Note: Only applicable to horizontal scales.
        /// </summary>
        public int? AutoSkipPadding { get; set; }

        /// <summary>
        /// Distance in pixels to offset the label from the centre point of the tick (in the y direction for the x axis, and the x direction for the y axis). Note: this can cause labels at the edges to be cropped by the edge of the canvas.
        /// </summary>
        public int? LabelOffset { get; set; }

        /// <summary>
        /// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales.
        /// </summary>
        public int? MaxRotation { get; set; }

        /// <summary>
        /// Minimum rotation for tick labels. Note: Only applicable to horizontal scales.
        /// </summary>
        public int? MinRotation { get; set; }

        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// </summary>
        public bool? Mirror { get; set; }

        /// <summary>
        /// Padding between the tick label and the axis. When set on a vertical axis, this applies in the horizontal (X) direction. When set on a horizontal axis, this applies in the vertical (Y) direction.
        /// </summary>
        public int? Padding { get; set; }
    }
}
