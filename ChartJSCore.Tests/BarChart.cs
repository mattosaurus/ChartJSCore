using System;
using ChartJSCore.Helpers;
using ChartJSCore.Models;
using System.Collections.Generic;
using Xunit;

namespace ChartJSCore.Tests
{
    public class BarChart
    {
        private readonly string KNOWN_GOOD_CHART = "var barChartElement = document.getElementById(\"barChart\");" +
                                                Environment.NewLine +
                                                "var barChart = new Chart(barChartElement, {\"type\":\"bar\",\"data\":{\"datasets\":[{\"type\":\"bar\",\"backgroundColor\":[\"rgba(255, 99, 132, 0.2)\",\"rgba(255, 159, 64, 0.2)\",\"rgba(255, 205, 86, 0.2)\",\"rgba(75, 192, 192, 0.2)\",\"rgba(54, 162, 235, 0.2)\",\"rgba(153, 102, 255, 0.2)\",\"rgba(201, 203, 207, 0.2)\"],\"borderColor\":[\"rgba(255, 99, 132, 1)\",\"rgba(255, 159, 64, 1)\",\"rgba(255, 205, 86, 1)\",\"rgba(75, 192, 192, 1)\",\"rgba(54, 162, 235, 1)\",\"rgba(153, 102, 255, 1)\",\"rgba(201, 203, 207, 1)\"],\"borderWidth\":1,\"data\":[65.0,59.0,80.0,81.0,56.0,55.0,40.0],\"label\":\"My First Dataset\"}],\"labels\":[\"January\",\"February\",\"March\",\"April\",\"May\",\"June\",\"July\"]},\"options\":{\"scales\":{\"y\":{\"beginAtZero\":true}}}}\r\n);";

        [Fact]
        public void Generate_VerticalBarChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GenerateVerticalBarChart().CreateChartCode("barChart");

            Assert.Equal(expected, actual);
        }

        private static Chart GenerateVerticalBarChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Bar };

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

            var dataset = new BarDataset
            {
                Label = "My First Dataset",
                Data = new List<double?> { 65, 59, 80, 81, 56, 55, 40 },
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgba(255, 99, 132, 0.2),
                    ChartColor.FromRgba(255, 159, 64, 0.2),
                    ChartColor.FromRgba(255, 205, 86, 0.2),
                    ChartColor.FromRgba(75, 192, 192, 0.2),
                    ChartColor.FromRgba(54, 162, 235, 0.2),
                    ChartColor.FromRgba(153, 102, 255, 0.2),
                    ChartColor.FromRgba(201, 203, 207, 0.2)
                },
                BorderColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(255, 99, 132),
                    ChartColor.FromRgb(255, 159, 64),
                    ChartColor.FromRgb(255, 205, 86),
                    ChartColor.FromRgb(75, 192, 192),
                    ChartColor.FromRgb(54, 162, 235),
                    ChartColor.FromRgb(153, 102, 255),
                    ChartColor.FromRgb(201, 203, 207)
                },
                BorderWidth = new List<int> { 1 }
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            var options = new Options
            {
                Scales = new Dictionary<string, Scale>()
            };

            var scales = new Dictionary<string, Scale>
            {
                {
                    "y", new CartesianLinearScale
                    {
                        BeginAtZero = true
                    }
                }
            };

            options.Scales = scales;

            chart.Options = options;

            return chart;
        }

        private static Chart GenerateHorizontalBarChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Bar };

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

            var dataset = new BarDataset
            {
                Label = "My First Dataset",
                Data = new List<double?> { 65, 59, 80, 81, 56, 55, 40 },
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgba(255, 99, 132, 0.2),
                    ChartColor.FromRgba(255, 159, 64, 0.2),
                    ChartColor.FromRgba(255, 205, 86, 0.2),
                    ChartColor.FromRgba(75, 192, 192, 0.2),
                    ChartColor.FromRgba(54, 162, 235, 0.2),
                    ChartColor.FromRgba(153, 102, 255, 0.2),
                    ChartColor.FromRgba(201, 203, 207, 0.2)
                },
                BorderColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(255, 99, 132),
                    ChartColor.FromRgb(255, 159, 64),
                    ChartColor.FromRgb(255, 205, 86),
                    ChartColor.FromRgb(75, 192, 192),
                    ChartColor.FromRgb(54, 162, 235),
                    ChartColor.FromRgb(153, 102, 255),
                    ChartColor.FromRgb(201, 203, 207)
                },
                BorderWidth = new List<int> { 1 },
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            var options = new Options
            {
                Scales = new Dictionary<string, Scale>()
            };

            var scales = new Dictionary<string, Scale>
            {
                {
                    "y", new CartesianLinearScale
                    {
                        BeginAtZero = true
                    }
                }
            };

            options.Scales = scales;

            chart.Options = options;

            return chart;
        }
    }
}