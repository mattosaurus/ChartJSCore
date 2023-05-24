using ChartJSCore.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ChartJSHelper.TagHelpers
{

    [HtmlTargetElement("chart-script", Attributes = ForAttributeName +", " + nameof(Canvas))]
    public class ChartTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";

        /// <summary>
        /// ModelExpression referencing the ChartJSCore.Models.Chart object that specifies the chart to generate.
        /// </summary>
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; } = default!;

        /// <summary>
        /// Id attribute of the Canvas where the chart should be shown.
        /// </summary>
        public string Canvas { get; set; } = "";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (For.Model is Chart chart)
            {
                output.TagName = "script";
                output.TagMode = TagMode.StartTagAndEndTag;
                output.Attributes.Clear();
                output.Content.SetHTMLContent(chart.CreateChartCode(Canvas));
            }
            else
            { throw new ArgumentException(); }
        }
    }
}

