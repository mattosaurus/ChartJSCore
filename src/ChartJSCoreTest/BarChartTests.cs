using System.Collections.Generic;
using ChartJSCore.Models;
using ChartJSCore.Models.Bar;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class BarChartTests
    {
        private const string KNOWN_GOOD_CHART = "var barChartElement = document.getElementById(\"barChart\");\r\nvar barChart = new Chart(barChartElement, {\"type\":\"bar\",\"data\":{\"datasets\":[{\"type\":\"bar\",\"backgroundColor\":[\"rgba(255, 99, 132, 0.2)\",\"rgba(54, 162, 235, 0.2)\",\"rgba(255, 206, 86, 0.2)\",\"rgba(75, 192, 192, 0.2)\",\"rgba(153, 102, 255, 0.2)\",\"rgba(255, 159, 64, 0.2)\"],\"borderColor\":[\"rgba(255,99,132,1)\",\"rgba(54, 162, 235, 1)\",\"rgba(255, 206, 86, 1)\",\"rgba(75, 192, 192, 1)\",\"rgba(153, 102, 255, 1)\",\"rgba(255, 159, 64, 1)\"],\"borderWidth\":1,\"data\":[12.0,19.0,3.0,5.0,2.0,3.0],\"label\":\"# of Votes\"}],\"labels\":[\"Red\",\"Blue\",\"Yellow\",\"Green\",\"Purple\",\"Orange\"]},\"options\":{\"barPercentage\":0.7,\"layout\":{\"padding\":{\"left\":10,\"right\":12}},\"scales\":{\"yAxes\":[{\"ticks\":{\"beginAtZero\":true}}]}}}\r\n);";

        [Test]
        public void Generate_BarChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GenerateBarChart().CreateChartCode("barChart");

            Assert.AreEqual(expected, actual);
        }

        private static Chart GenerateBarChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Bar };

            var data = new Data
            {
                Labels = new List<string>
                {
                    "Red",
                    "Blue",
                    "Yellow",
                    "Green",
                    "Purple",
                    "Orange"
                }
            };

            var dataset = new BarDataset
            {
                Label = "# of Votes",
                Data = new List<double> { 12, 19, 3, 5, 2, 3 },
                BackgroundColor = new List<string>
                {
                        "rgba(255, 99, 132, 0.2)",
                        "rgba(54, 162, 235, 0.2)",
                        "rgba(255, 206, 86, 0.2)",
                        "rgba(75, 192, 192, 0.2)",
                        "rgba(153, 102, 255, 0.2)",
                        "rgba(255, 159, 64, 0.2)"
                        },
                BorderColor = new List<string>
                {
                        "rgba(255,99,132,1)",
                        "rgba(54, 162, 235, 1)",
                        "rgba(255, 206, 86, 1)",
                        "rgba(75, 192, 192, 1)",
                        "rgba(153, 102, 255, 1)",
                        "rgba(255, 159, 64, 1)"
                        },
                BorderWidth = new List<int> { 1 }
            };

            data.Datasets = new List<Dataset> {dataset};

            chart.Data = data;

            var options = new BarOptions
            {
                Scales = new Scales(),
                BarPercentage = 0.7
            };

            var scales = new Scales
            {
                YAxes = new List<Scale>
                {
                    new CartesianScale
                    {
                        Ticks = new CartesianLinearTick
                        {
                            BeginAtZero = true
                        }
                    }
                }
            };

            options.Scales = scales;

            chart.Options = options;

            chart.Options.Layout = new Layout
            {
                Padding = new Padding
                {
                    PaddingObject = new PaddingObject
                    {
                        Left = 10,
                        Right = 12
                    }
                }
            };

            return chart;
        }
    }

}
