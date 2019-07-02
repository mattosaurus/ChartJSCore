using System.Collections.Generic;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class PieChartTests
    {
        private const string KNOWN_GOOD_CHART = "var pieChartElement = document.getElementById(\"pieChart\");\r\nvar pieChart = new Chart(pieChartElement, {\"type\":\"pie\",\"data\":{\"datasets\":[{\"type\":\"pie\",\"backgroundColor\":[\"#FF6384\",\"#36A2EB\",\"#FFCE56\"],\"hoverBackgroundColor\":[\"#FF6384\",\"#36A2EB\",\"#FFCE56\"],\"data\":[300.0,50.0,100.0],\"label\":\"My dataset\"}],\"labels\":[\"Red\",\"Blue\",\"Yellow\"]},\"options\":{}}\r\n);";

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
                BackgroundColor = new List<string> { "#FF6384", "#36A2EB", "#FFCE56" },
                HoverBackgroundColor = new List<string> { "#FF6384", "#36A2EB", "#FFCE56" },
                Data = new List<double> { 300, 50, 100 }
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            return chart;
        }
    }

}
