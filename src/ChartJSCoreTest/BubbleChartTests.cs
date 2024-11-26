using System.Collections.Generic;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class BubbleChartTests
    {
        private const string KNOWN_GOOD_CHART = "var bubbleChartElement = document.getElementById(\"bubbleChart\");\r\nvar bubbleChart = new Chart(bubbleChartElement, {\"type\":\"bubble\",\"data\":{\"datasets\":[{\"type\":\"bubble\",\"data\":[{\"x\":20.0,\"y\":30.0,\"r\":15.0},{\"x\":40.0,\"y\":10.0,\"r\":10.0}],\"backgroundColor\":\"rgba(255, 99, 132, 1)\",\"hoverBackgroundColor\":\"rgba(255, 99, 132, 1)\",\"label\":\"Bubble Dataset\"}]},\"options\":{}}\r\n);";

        [Test]
        public void Generate_BubbleChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GenerateBubbleChart().CreateChartCode("bubbleChart");

            Assert.Equals(expected, actual);
        }

        private static Chart GenerateBubbleChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Bubble };

            var data = new Data();

            var dataset = new BubbleDataset
            {
                Label = "Bubble Dataset",
                Data = new List<BubbleData>()
            };

            var bubbleData1 = new BubbleData();
            var bubbleData2 = new BubbleData();

            bubbleData1.X = 20;
            bubbleData1.Y = 30;
            bubbleData1.R = 15;
            dataset.Data.Add(bubbleData1);

            bubbleData2.X = 40;
            bubbleData2.Y = 10;
            bubbleData2.R = 10;
            dataset.Data.Add(bubbleData2);

            data.Datasets = new List<Dataset> { dataset };

            dataset.BackgroundColor = new List<ChartColor> { ChartColor.FromRgb(255, 99, 132) };
            dataset.HoverBackgroundColor = new List<ChartColor> { ChartColor.FromRgb(255, 99, 132) };

            chart.Data = data;

            return chart;
        }
    }

}
