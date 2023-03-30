using ChartJSCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJSCore.Plugins.LegenFocus
{
    /// <summary>
    /// Code was copied from here:
    /// https://stackoverflow.com/questions/42555513/chart-js-change-legend-toggle-behaviour
    /// </summary>
    public class LegendFocus : Legend
    {
        public LegendFocus()
        {
            Display = true;
            OnClick = @"function(e, legendItem) {
                                    var index = legendItem.datasetIndex;
                                    var ci = this.chart;
                                    var alreadyHidden = (ci.getDatasetMeta(index).hidden === null) ? false : ci.getDatasetMeta(index).hidden;

                                    ci.data.datasets.forEach(function(e, i) {
                                        var meta = ci.getDatasetMeta(i);

                                        if (i !== index) {
                                            if (!alreadyHidden) {
                                                meta.hidden = meta.hidden === null ? !meta.hidden : null;
                                            } 
                                            else if (meta.hidden === null) 
                                            {
                                                meta.hidden = true;
                                            }
                                        }
                                        else if (i === index) {
                                            meta.hidden = null;
                                        }
                                    });
                                    ci.update();
                                }";
        }
    }
}
