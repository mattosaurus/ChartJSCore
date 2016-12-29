using Chart.Helpers;
using Chart.Models.LineChart;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChartTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chart.Models.LineChart.Chart chart = new Chart.Models.LineChart.Chart();
            chart.Type = "line";

            Data data = new Data();
            data.Labels = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };

            Dataset dataset = new Dataset()
            {
                Label = "Daily Entries",
                BackgroundColor = "rgba(38, 185, 154, 0.31)",
                BorderColor = "rgba(38, 185, 154, 0.7)",
                PointBorderColor = new List<string>() { "rgba(38, 185, 154, 0.7)" },
                PointBackgroundColor = new List<string>() { "rgba(38, 185, 154, 0.7)" },
                PointHoverBackgroundColor = new List<string>() { "#fff" },
                PointHoverBorderColor = new List<string>() { "rgba(220,220,220,1)" },
                PointBorderWidth = new List<int>() { 1 },
                Data = new List<int>() { 65, 59, 80, 81, 56, 55, 40 }
            };

            chart.Data = data;

            // keys need to be camel case to match data contract so use custom serializer to alter
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelcaseContractResolver();

            string json = JsonConvert.SerializeObject(chart, settings);
        }
    }
}
