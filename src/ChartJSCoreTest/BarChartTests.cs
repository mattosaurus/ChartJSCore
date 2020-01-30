using System.Collections.Generic;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class BarChartTests
    {
        private const string KNOWN_GOOD_CHART = "var barChartElement = document.getElementById(\"barChart\");\r\nvar barChart = new Chart(barChartElement, {\"type\":\"bar\",\"data\":{\"datasets\":[{\"type\":\"bar\",\"backgroundColor\":[\"rgba(255, 99, 132, 0.2)\",\"rgba(54, 162, 235, 0.2)\",\"rgba(255, 206, 86, 0.2)\",\"rgba(75, 192, 192, 0.2)\",\"rgba(153, 102, 255, 0.2)\",\"rgba(255, 159, 64, 0.2)\"],\"borderColor\":[\"rgba(255, 99, 132, 1)\",\"rgba(54, 162, 235, 1)\",\"rgba(255, 206, 86, 1)\",\"rgba(75, 192, 192, 1)\",\"rgba(153, 102, 255, 1)\",\"rgba(255, 159, 64, 1)\"],\"borderWidth\":1,\"data\":[12.0,19.0,3.0,null,2.0,3.0],\"label\":\"# of Votes\"}],\"labels\":[\"Red\",\"Blue\",\"Yellow\",\"Green\",\"Purple\",\"Orange\"]},\"options\":{\"layout\":{\"padding\":{\"left\":10,\"right\":12}},\"scales\":{\"xAxes\":[{\"barPercentage\":0.5,\"barThickness\":6.0,\"maxBarThickness\":8.0,\"minBarLength\":2.0,\"gridLines\":{\"offsetGridLines\":true}}],\"yAxes\":[{\"ticks\":{\"beginAtZero\":true}}]}}}\r\n);";

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
                Data = new List<double?> { 12, 19, 3, null, 2, 3 },
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgba(255, 99, 132, 0.2),
                    ChartColor.FromRgba(54, 162, 235, 0.2),
                    ChartColor.FromRgba(255, 206, 86, 0.2),
                    ChartColor.FromRgba(75, 192, 192, 0.2),
                    ChartColor.FromRgba(153, 102, 255, 0.2),
                    ChartColor.FromRgba(255, 159, 64, 0.2)
                },
                BorderColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(255, 99, 132),
                    ChartColor.FromRgb(54, 162, 235),
                    ChartColor.FromRgb(255, 206, 86),
                    ChartColor.FromRgb(75, 192, 192),
                    ChartColor.FromRgb(153, 102, 255),
                    ChartColor.FromRgb(255, 159, 64)
                },
                BorderWidth = new List<int> { 1 }
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            var options = new Options
            {
                Scales = new Scales()
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
                },
                XAxes = new List<Scale>
                {
                    new BarScale
                    {
                        BarPercentage = 0.5,
                        BarThickness = 6,
                        MaxBarThickness = 8,
                        MinBarLength = 2,
                        GridLines = new GridLine()
                        {
                            OffsetGridLines = true
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
