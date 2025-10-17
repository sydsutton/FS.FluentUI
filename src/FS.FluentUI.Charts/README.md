# FS.FullCalendar

## [FluentUI V9 Charts (React)](https://storybooks.fluentui.dev/react/?path=/docs/charts_introduction--docs) made for F# in the style of Feliz

[![NuGet version (FS.FluentUI.Charts)](https://img.shields.io/nuget/v/FS.FullCalendar.svg?style=flat-square)](https://www.nuget.org/packages/FS.FluentUI.Charts/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/FS.FluentUI.Charts.svg)](https://www.nuget.org/packages/FS.FluentUI.Charts/)

<a href="https://www.buymeacoffee.com/andrewsydsh" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-yellow.png" alt="Buy Me A Coffee" height="50" width="200"></a>

### Please check [all Charts docs](https://storybooks.fluentui.dev/react/?path=/docs/charts_introduction--docs) for further component usage and properties


### An example of a Charting component implementation:


```fsharp
open FS.FluentUI.Charts

type ChartPoints = {
    legend: string
    data: float
    color: string
}

/// You can `.` into specific properties
let firstChartPoints = [
    [ vsChartDataPoint.legend "MetaData1"; vsChartDataPoint.data 2; vsChartDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color1) ]
    [ vsChartDataPoint.legend "MetaData2"; vsChartDataPoint.data 0.5; vsChartDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color2) ]
    [ vsChartDataPoint.legend "MetaData3"; vsChartDataPoint.data 0; vsChartDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color6) ]
]

// You can use anonymous types that include specific fields
let secondChartPoints = [
    {| legend = "MetaData1"; data = 30; color = Fui.getColorFromToken Fui.dataVizPalette.color1 |}
    {| legend = "MetaData2"; data = 3; color = Fui.getColorFromToken Fui.dataVizPalette.color2 |}
    {| legend = "MetaData3"; data = 40; color = Fui.getColorFromToken Fui.dataVizPalette.color6 |}
]

// Or you can use custom data types
let thirdChartPoints = [
    { legend = "MetaData1"; data = 10; color = Fui.getColorFromToken Fui.dataVizPalette.color1 }
    { legend = "MetaData2"; data = 60; color = Fui.getColorFromToken Fui.dataVizPalette.color2 }
    { legend = "MetaData3"; data = 30; color = Fui.getColorFromToken Fui.dataVizPalette.color6 }
]

let verticalStackedBarChartDataList = [
    [ verticalStackedChart.chartData firstChartPoints; verticalStackedChart.xAxisPoint "Simple Data" ]
    [ verticalStackedChart.chartData secondChartPoints; verticalStackedChart.xAxisPoint "Long text will disaply all text" ]
    [ verticalStackedChart.chartData thirdChartPoints; verticalStackedChart.xAxisPoint "Data" ]
]

Fui.verticalStackedBarChart [
    verticalStackedBarChart.data verticalStackedBarChartDataList
    verticalStackedBarChart.chartTitle "Vertical stacked bar chart axis tooltip example"
    verticalStackedBarChart.height 400
    verticalStackedBarChart.width 600
    verticalStackedBarChart.showYAxisLablesTooltip true
    verticalStackedBarChart.wrapXAxisLables true
    verticalStackedBarChart.barWidth.auto
    verticalStackedBarChart.maxBarWidth 50
    verticalStackedBarChart.xAxisInnerPadding 0.25
    verticalStackedBarChart.enableGradient true
    verticalStackedBarChart.roundCorners true
    verticalStackedBarChart.barGapMax 0.5
]
```

## Installation

Current NPM dependencies:
#### Primary dependency:
* @fluentui/react-charts


Install into your Client.fsproj project using [Femto](https://github.com/Zaid-Ajaj/Femto) (recommended)
```bash
cd ./{path to Client}

# when using femto as a global CLI tool
femto install FS.FluentUI.Charts

# when using femto as a local CLI tool
dotnet femto install FS.FluentUI.Charts
```
This will install the nuget package and afterwards automatically installs the required npm packages used by this binding.

> Femto will detect whether you are using paket and will install the package using paket into the dependency group of the project

You can install the library manually if you want by first installing the nuget package
```bash
cd ./{path to your project}
dotnet add package FS.FluentUI.Charts
npm install @fluentui/react-charts
```
