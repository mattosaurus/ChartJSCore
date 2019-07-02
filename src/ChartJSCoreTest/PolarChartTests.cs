using System.Collections.Generic;
using ChartJSCore.Models;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class PolarChartTests
    {
        private const string KNOWN_GOOD_CHART = "var polarChartElement = document.getElementById(\"polarChart\");\r\nvar polarChart = new Chart(polarChartElement, {\"type\":\"polarArea\",\"data\":{\"datasets\":[{\"type\":\"polarArea\",\"backgroundColor\":[\"#FF6384\",\"#4BC0C0\",\"#FFCE56\",\"#E7E9ED\",\"#36A2EB\"],\"data\":[11.0,16.0,7.0,3.0,14.0],\"label\":\"My dataset\"}],\"labels\":[\"Red\",\"Green\",\"Yellow\",\"Grey\",\"Blue\"]},\"options\":{}}\r\n);";

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
                BackgroundColor = new List<string> { "#FF6384", "#4BC0C0", "#FFCE56", "#E7E9ED", "#36A2EB" },
                Data = new List<double> { 11, 16, 7, 3, 14 }
            };

            data.Datasets = new List<Dataset> { dataset };

            chart.Data = data;

            return chart;
        }
    }

}
