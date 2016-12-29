using ChartJSCore.Helpers;
using ChartJSCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCoreTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chart chart = new Chart();
            chart.Type = "line";

            Data data = new Data();
            data.Labels = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };

            LineDataset dataset = new LineDataset()
            {
                Label = "Daily Entries",
                BackgroundColor = "rgba(38, 185, 154, 0.31)",
                BorderColor = "rgba(38, 185, 154, 0.7)",
                PointBorderColor = new List<string>() { "rgba(38, 185, 154, 0.7)" },
                PointBackgroundColor = new List<string>() { "rgba(38, 185, 154, 0.7)" },
                PointHoverBackgroundColor = new List<string>() { "#fff" },
                PointHoverBorderColor = new List<string>() { "rgba(220,220,220,1)" },
                PointBorderWidth = new List<int>() { 1 },
                Data = new List<double>() { 65, 59, 80, 81, 56, 55, 40 }
            };

            LineOptions options = new LineOptions();
            options.ShowLines = false;
            chart.Options = options;

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);
            chart.Data = data;

            // keys need to be camel case to match data contract so use custom serializer to alter
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ContractResolver = new CamelcaseContractResolver();
            settings.NullValueHandling = NullValueHandling.Ignore;

            string json = JsonConvert.SerializeObject(chart, settings);
        }
    }
}
