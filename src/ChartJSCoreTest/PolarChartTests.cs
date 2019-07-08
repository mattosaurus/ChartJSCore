using System.Collections.Generic;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class PolarChartTests
    {
        private const string KNOWN_GOOD_CHART = "var polarChartElement = document.getElementById(\"polarChart\");\r\nvar polarChart = new Chart(polarChartElement, {\"type\":\"polarArea\",\"data\":{\"datasets\":[{\"type\":\"polarArea\",\"backgroundColor\":[\"rgba(255, 99, 132, 1)\",\"rgba(75, 192, 192, 1)\",\"rgba(255, 206, 86, 1)\",\"rgba(231, 233, 237, 1)\",\"rgba(54, 162, 235, 1)\"],\"data\":[11.0,16.0,7.0,3.0,14.0],\"label\":\"My dataset\"}],\"labels\":[\"Red\",\"Green\",\"Yellow\",\"Grey\",\"Blue\"]},\"options\":{}}\r\n);";

        [Test]
        public void Generate_PolarChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GeneratePolarChart().CreateChartCode("polarChart");

            Assert.AreEqual(expected, actual);
        }

        private static Chart GeneratePolarChart()
        {
            var chart = new Chart { Type = Enums.ChartType.PolarArea };

            var data = new Data
            {
                Labels = new List<string>
                {
                    "Red",
                    "Green",
                    "Yellow",
                    "Grey",
                    "Blue"
                }
            };

            var dataset = new PolarDataset
            {
                Label = "My dataset",
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromHexString("#FF6384"),
                    ChartColor.FromHexString("#4BC0C0"),
                    ChartColor.FromHexString("#FFCE56"),
                    ChartColor.FromHexString("#E7E9ED"),
                    ChartColor.FromHexString("#36A2EB")
                },
                Data = new List<double> { 11, 16, 7, 3, 14 }
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            return chart;
        }
    }

}
