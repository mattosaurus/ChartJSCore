# ChartJSCore
Implementation of Chart.js for use with .NET Core. This libary allows Chart.js code to be generated in an MVC controller from a .NET object and injected into the desired view.

# Installaton
To use ChartJSCore in your C# project, you can either download the ChartJSCore C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package ChartJSCore
```
Once you have the ChartJSCore libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using ChartJSCore.Models;
```
# Dependencies
This produces code for generating chart using Chart.js so Chart.js is required to render them, Chart.js also uses require.js so this is also needed. Chart.js seems to no longer support the Bower package manager in Visual Studio so needs to be downloaded directly to the project root folder wwwroot\lib\Chart.js.

Require.js isn't available in the Bower package manager but can be added by directly updating the bower.json file.

```
{
  "name": "asp.net",
  "private": true,
  "dependencies": {
    "bootstrap": "3.3.7",
    "jquery": "3.1.1",
    "jquery-validation": "1.16.0",
    "jquery-validation-unobtrusive": "3.2.6",
    "requirejs": "2.3.2"
  }
}
```

# Usage
This is intended for usage in ASP.NET 5 Core MVC projects.

Once a project has been created a nwe Chart object can be created by using code similar to that below. In this example the Index method of the Home controller has been updated to generate a Chart and pass it through to the relevant view.

```C#
        public IActionResult Index()
        {
            Chart chart = new Chart();

            chart.Type = "line";

            Data data = new Data();
            data.Labels = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };

            LineDataset dataset = new LineDataset()
            {
                Label = "My First dataset",
                Data = new List<double>() { 65, 59, 80, 81, 56, 55, 40 },
                Fill = false,
                LineTension = 0.1,
                BackgroundColor = "rgba(75, 192, 192, 0.4)",
                BorderColor = "rgba(75,192,192,1)",
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<string>() { "rgba(75,192,192,1)" },
                PointBackgroundColor = new List<string>() { "#fff" },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<string>() { "rgba(75,192,192,1)" },
                PointHoverBorderColor = new List<string>() { "rgba(220,220,220,1)" },
                PointHoverBorderWidth = new List<int> { 2 },
                PointRadius = new List<int> { 1 },
                PointHitRadius = new List<int> { 10 },
                SpanGaps = false
            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(dataset);

            chart.Data = data;

            ViewData["chart"] = chart;

            return View();
        }
```

Within the Index view the Chart can then be accessed and rendered.

```HTML
@{
    ViewData["Title"] = "Home Page";
}

<div><canvas id="lineChart"></canvas></div>

@{ChartJSCore.Models.Chart chart = (ChartJSCore.Models.Chart)ViewData["chart"]; }

@section Scripts {
    <script src="~/lib/Chart.js/dist/Chart.js"></script>
    <script>
        @Html.Raw(chart.CreateChartCode("lineChart"));
    </script>
}
```
