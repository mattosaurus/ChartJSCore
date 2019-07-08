using System.Collections.Generic;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class PieChartTests
    {
        private const string KNOWN_GOOD_CHART = "var pieChartElement = document.getElementById(\"pieChart\");\r\nvar pieChart = new Chart(pieChartElement, {\"type\":\"pie\",\"data\":{\"datasets\":[{\"type\":\"pie\",\"backgroundColor\":[\"rgba(255, 99, 132, 1)\",\"rgba(54, 162, 235, 1)\",\"rgba(255, 206, 86, 1)\"],\"hoverBackgroundColor\":[\"rgba(255, 99, 132, 1)\",\"rgba(54, 162, 235, 1)\",\"rgba(255, 206, 86, 1)\"],\"data\":[300.0,50.0,100.0],\"label\":\"My dataset\"}],\"labels\":[\"Red\",\"Blue\",\"Yellow\"]},\"options\":{}}\r\n);";

        [Test]
        public void Generate_PieChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GeneratePieChart().CreateChartCode("pieChart");

            Assert.AreEqual(expected, actual);
        }

        private static Chart GeneratePieChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Pie };

            var data = new Data { Labels = new List<string> { "Red", "Blue", "Yellow" } };

            var dataset = new PieDataset
            {
                Label = "My dataset",
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromHexString("#FF6384"),
                    ChartColor.FromHexString("#36A2EB"),
                    ChartColor.FromHexString("#FFCE56")
                },
                HoverBackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromHexString("#FF6384"),
                    ChartColor.FromHexString("#36A2EB"),
                    ChartColor.FromHexString("#FFCE56")
                },
                Data = new List<double> { 300, 50, 100 }
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            return chart;
        }
    }

}
