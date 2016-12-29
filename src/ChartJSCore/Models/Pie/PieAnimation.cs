using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class PieAnimation : Animation
    {
        /// <summary>
        /// If true, will animate the rotation of the ChartJSCore.
        /// </summary>
        public bool? AnimateRotate { get; set; }

        /// <summary>
        /// If true, will animate scaling the Doughnut from the centre.
        /// </summary>
        public bool? AnimateScale { get; set; }
    }
}
