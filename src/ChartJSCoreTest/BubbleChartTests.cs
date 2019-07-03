using System.Collections.Generic;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class BubbleChartTests
    {
        private const string KNOWN_GOOD_CHART = "var bubbleChartElement = document.getElementById(\"bubbleChart\");\r\nvar bubbleChart = new Chart(bubbleChartElement, {\"type\":\"bubble\",\"data\":{\"datasets\":[{\"type\":\"bubble\",\"data\":[{\"x\":20.0,\"y\":30.0,\"r\":15.0},{\"x\":40.0,\"y\":10.0,\"r\":10.0}],\"backgroundColor\":\"#FF6384\",\"hoverBackgroundColor\":\"#FF6384\",\"label\":\"Bubble Dataset\"}]},\"options\":{}}\r\n);";

        [Test]
        public void Generate_BubbleChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GenerateBubbleChart().CreateChartCode("bubbleChart");

            Assert.AreEqual(expected, actual);
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

            bubbleData1.x = 20;
            bubbleData1.y = 30;
            bubbleData1.r = 15;
            dataset.Data.Add(bubbleData1);

            bubbleData2.x = 40;
            bubbleData2.y = 10;
            bubbleData2.r = 10;
            dataset.Data.Add(bubbleData2);

            data.Datasets = new List<Dataset> { dataset };

            dataset.BackgroundColor = new List<string> { "#FF6384" };
            dataset.HoverBackgroundColor = new List<string> { "#FF6384" };

            chart.Data = data;

            return chart;
        }
    }

}
