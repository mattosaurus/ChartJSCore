using System.Collections.Generic;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class RadarChartTests
    {
        private const string KNOWN_GOOD_CHART = "var radarChartElement = document.getElementById(\"radarChart\");\r\nvar radarChart = new Chart(radarChartElement, {\"type\":\"radar\",\"data\":{\"datasets\":[{\"type\":\"radar\",\"backgroundColor\":\"rgba(179,181,198,0.2)\",\"borderColor\":\"rgba(179,181,198,1)\",\"pointBorderColor\":\"#fff\",\"pointBackgroundColor\":\"rgba(179,181,198,1)\",\"pointHoverBackgroundColor\":\"#fff\",\"pointHoverBorderColor\":\"rgba(179,181,198,1)\",\"data\":[65.0,59.0,80.0,81.0,56.0,55.0,40.0],\"label\":\"My First dataset\"},{\"type\":\"radar\",\"backgroundColor\":\"rgba(255,99,132,0.2)\",\"borderColor\":\"rgba(255,99,132,1)\",\"pointBorderColor\":\"#fff\",\"pointBackgroundColor\":\"rgba(255,99,132,1)\",\"pointHoverBackgroundColor\":\"#fff\",\"pointHoverBorderColor\":\"rgba(255,99,132,1)\",\"data\":[28.0,48.0,40.0,19.0,96.0,27.0,100.0],\"label\":\"My Second dataset\"}],\"labels\":[\"Eating\",\"Drinking\",\"Sleeping\",\"Designing\",\"Coding\",\"Cycling\",\"Running\"]},\"options\":{}}\r\n);";

        [Test]
        public void Generate_RadarChart_Generates_Valid_Chart()
        {
            string expected = KNOWN_GOOD_CHART;

            string actual = GenerateRadarChart().CreateChartCode("radarChart");

            Assert.AreEqual(expected, actual);
        }

        private static Chart GenerateRadarChart()
        {
            var chart = new Chart { Type = Enums.ChartType.Radar };

            var data = new Data
            {
                Labels = new List<string>
                {
                    "Eating",
                    "Drinking",
                    "Sleeping",
                    "Designing",
                    "Coding",
                    "Cycling",
                    "Running"
                }
            };

            var dataset1 = new RadarDataset
            {
                Label = "My First dataset",
                BackgroundColor = "rgba(179,181,198,0.2)",
                BorderColor = "rgba(179,181,198,1)",
                PointBackgroundColor = new List<string> { "rgba(179,181,198,1)" },
                PointBorderColor = new List<string> { "#fff" },
                PointHoverBackgroundColor = new List<string> { "#fff" },
                PointHoverBorderColor = new List<string> { "rgba(179,181,198,1)" },
                Data = new List<double> { 65, 59, 80, 81, 56, 55, 40 }
            };

            var dataset2 = new RadarDataset
            {
                Label = "My Second dataset",
                BackgroundColor = "rgba(255,99,132,0.2)",
                BorderColor = "rgba(255,99,132,1)",
                PointBackgroundColor = new List<string> { "rgba(255,99,132,1)" },
                PointBorderColor = new List<string> { "#fff" },
                PointHoverBackgroundColor = new List<string> { "#fff" },
                PointHoverBorderColor = new List<string> { "rgba(255,99,132,1)" },
                Data = new List<double> { 28, 48, 40, 19, 96, 27, 100 }
            };

            data.Datasets = new List<Dataset> { dataset1, dataset2 };

            chart.Data = data;

            return chart;
        }
    }

}
