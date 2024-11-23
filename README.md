# ChartJSCore v3.9.1

Implementation of Chart.js for use with ASP.NET MVC. This library allows Chart.js code to be generated in an MVC controller from a .NET object and injected into the desired view. 

ChartJSCore is a .NET Standard 2.0 library, and is compatible with all .NET versions that support .NET Standard 2.0 libraries.

[![Build status](https://ci.appveyor.com/api/projects/status/7n78iys8p8dhf9fm?svg=true)](https://ci.appveyor.com/project/perezLamed/chartjscore)

**This library has been updated to work with v3 of Chart.js, I have done minimal testing so there are likely to be bugs. If something doesn't work as expected please open a new issue with an example of the failing code and alink to the relevant Chart.js documentation.**

## Installation

To use ChartJSCore in your C# project, you can either download the ChartJSCore C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

* Nuget package: <https://www.nuget.org/packages/ChartJSCore/> [![NuGet Badge](https://buildstats.info/nuget/ChartJSCore)](https://www.nuget.org/packages/ChartJSCore/)

```powershell
PM> Install-Package ChartJSCore
```

Once you have the ChartJSCore libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using ChartJSCore.Models;
```

## Dependencies

This produces code for generating chart using Chart.js so Chart.js is required to render them, Chart.js also uses require.js so this is also needed. To install Chart.js using Bower on Visual Studio it is needed to update the registry in .bowerrc file, because the old heroku repository is deprecated as stated in [here](https://gist.github.com/sheerun/c04d856a7a368bad2896ff0c4958cb00). Otherwise you can download it directly to the project root folder wwwroot\lib\Chart.js.

If you don't feel like using a package manager, Chart.JS can also be linked directly to your page and hosted from [cdnjs](https://cdnjs.com/libraries/Chart.js). 

This package has been created and tested with version 3.9.1 of Chart.js, earlier versions may well be incompatible.

Require.js isn't available in the Bower package manager but can be added by directly updating the bower.json file.

```json
{
  "name": "asp.net",
  "private": true,
  "dependencies": {
    "bootstrap": "3.3.7",
    "jquery": "3.1.1",
    "jquery-validation": "1.16.0",
    "jquery-validation-unobtrusive": "3.2.6",
    "requirejs": "2.3.3",
    "chart.js": "2.5.0"
  }
}
```

## Usage

Once a project has been created a new Chart object can be created by using code similar to that below. In this example the Index method of the Home controller has been updated to generate a Chart and pass it through to the relevant view.

```C#
        public IActionResult Index()
        {
            Chart chart = new Chart();

            chart.Type = Enums.ChartType.Line;

            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();
            data.Labels = new List<string>() { "January", "February", "March", "April", "May", "June", "July" };

            LineDataset dataset = new LineDataset()
            {
                Label = "My First dataset",
                Data = new List<double?> { 65, 59, 80, 81, 56, 55, 40 },
                Fill = "false",
                Tension = 0.1,
                BackgroundColor = new List<ChartColor> { ChartColor.FromRgba(75, 192, 192, 0.4) },
                BorderColor = new List<ChartColor> { ChartColor.FromRgb(75,192,192) },
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<ChartColor> { ChartColor.FromRgb(75,192,192) },
                PointBackgroundColor = new List<ChartColor> { ChartColor.FromHexString("#ffffff") },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<ChartColor> { ChartColor.FromRgb(75,192,192) },
                PointHoverBorderColor = new List<ChartColor> { ChartColor.FromRgb(220,220,220) },
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

See the [demo project](https://github.com/mattosaurus/ChartJSCore/tree/master/src/ChartJSCore.Demo) for further examples.

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

## Plugins

ChartJSCore has built-in support for the popular [chartjs-plugin-zoom](https://github.com/chartjs/chartjs-plugin-zoom) plugin. See the [demo project](https://github.com/mattosaurus/ChartJSCore/tree/master/src/ChartJSCore.Demo) for an example of how to use this.

ChartJSCore als has built-in support for the color plugin that comes as part of ChartJS (https://www.chartjs.org/docs/latest/general/colors.html). This plugin is enabled by default within ChartJS and the plug-in allows to disable it using:

```C#
Options = new Options()
{
    Plugins = new Plugins()
    {                        
        Colors = new ColorPlugin()
        {
            Enabled = false // enabled by default
        },
```

You can also force using the pre-defined color scheme using:

```C#
Options = new Options()
{
    Plugins = new Plugins()
    {                        
        Colors = new ColorPlugin()
        {
            ForceOverride = true   // disabled by default
        },
```

Generally, the option 'ForceOverride' is the option you want to set for proper coloring of your datasets.


As there's a large number of plugins available for Chart.js and it's not feasible to create object representations of them all, I've added the "PluginDynamic" property to all chart objects to allow customisation. This is a ```Dictionary<string, object>``` in which the string is the name of the property and the object contains the object to be serialized, these will be added to the parent object as distinct properties.
