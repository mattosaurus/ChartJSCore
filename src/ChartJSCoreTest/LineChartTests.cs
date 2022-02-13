using System.Collections.Generic;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class LineChartTests
    {
        private const string KNOWN_GOOD_CHART = "var lineChartElement = document.getElementById(\"lineChart\");\r\nvar lineChart = new Chart(lineChartElement, {\"type\":\"line\",\"data\":{\"datasets\":[{\"type\":\"line\",\"fill\":false,\"lineTension\":0.1,\"backgroundColor\":\"rgba(75, 192, 192, 0.4)\",\"borderColor\":\"rgba(75, 192, 192, 1)\",\"borderCapStyle\":\"butt\",\"borderDash\":[],\"borderDashOffset\":0.0,\"borderJoinStyle\":\"miter\",\"pointBorderColor\":\"rgba(75, 192, 192, 1)\",\"pointBackgroundColor\":\"rgba(255, 255, 255, 1)\",\"pointBorderWidth\":1,\"pointRadius\":1,\"pointHoverRadius\":5,\"pointHitRadius\":10,\"pointHoverBackgroundColor\":\"rgba(75, 192, 192, 1)\",\"pointHoverBorderColor\":\"rgba(220, 220, 220, 1)\",\"pointHoverBorderWidth\":2,\"spanGaps\":false,\"data\":[65.0,59.0,80.0,81.0,56.0,55.0,40.0],\"label\":\"My First dataset\"}],\"labels\":[\"January\",\"February\",\"March\",\"April\",\"May\",\"June\",\"July\"]},\"options\":{\"scales\":{\"y\":{\"ticks\":{\"callback\":function(value, index, values) {return '$' + value;}}}}}}\r\n);";

        [Test]
        public void Generate_LineChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GenerateLineChart().CreateChartCode("lineChart");

            Assert.AreEqual(expected, actual);
        }

        private static Chart GenerateLineChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Line };

            var data = new Data
            {
                Labels = new List<string>
                {
                    "January",
                    "February",
                    "March",
                    "April",
                    "May",
                    "June",
                    "July"
                }
            };

            var dataset = new LineDataset
            {
                Label = "My First dataset",
                Data = new List<double?> { 65, 59, 80, 81, 56, 55, 40 },
                Fill = "false",
                Tension = 0.1,
                BackgroundColor = new List<ChartColor> { ChartColor.FromRgba(75, 192, 192, 0.4) },
                BorderColor = new List<ChartColor> { ChartColor.FromRgb(75, 192, 192) },
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<ChartColor> { ChartColor.FromRgb(75, 192, 192) },
                PointBackgroundColor = new List<ChartColor> { ChartColor.FromHexString("#ffffff") },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<ChartColor> { ChartColor.FromRgb(75, 192, 192) },
                PointHoverBorderColor = new List<ChartColor> { ChartColor.FromRgb(220, 220, 220) },
                PointHoverBorderWidth = new List<int> { 2 },
                PointRadius = new List<int> { 1 },
                PointHitRadius = new List<int> { 10 },
                SpanGaps = false
            };

            data.Datasets = new List<Dataset> { dataset };

            var options = new Options
            {
                Scales = new Dictionary<string, Scale>()
            };

            var scales = new Dictionary<string, Scale>
            {
                {
                    "y", new CartesianScale
                    {
                        Ticks = new Tick
                        {
                            Callback = "function(value, index, values) {return '$' + value;}"
                        }
                    }
                }
            };

            options.Scales = scales;
            chart.Options = options;

            chart.Data = data;
            return chart;
        }
    }
}