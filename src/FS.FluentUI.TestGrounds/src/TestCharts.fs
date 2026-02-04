module TestCharts

open System
open Feliz
open FS.FluentUI
open FS.FluentUI.Charts

let areaChartDataList = [
    [
        lineChartPoints.opacity 1.0
        lineChartPoints.legend "legend1"
        lineChartPoints.color "green"
        lineChartPoints.lineOptions [
            lineChartLineOptions.curve.stepAfter
            lineChartLineOptions.mode.``text+Lines``
            lineChartLineOptions.strokeWidth 15
        ]
        lineChartPoints.data [
            [ lineChartDataPoint.x 20; lineChartDataPoint.y -9.0 ]
            [ lineChartDataPoint.x 25; lineChartDataPoint.y 14 ]
            [  lineChartDataPoint.x 30; lineChartDataPoint.y -14 ]
            [ lineChartDataPoint.x 35; lineChartDataPoint.y 23 ]
            [ lineChartDataPoint.x 40; lineChartDataPoint.y -20.0 ]
            [ lineChartDataPoint.x 45; lineChartDataPoint.y 31 ]
            [ lineChartDataPoint.x 50; lineChartDataPoint.y -29 ]
            [ lineChartDataPoint.x 55; lineChartDataPoint.y 27 ]
            [ lineChartDataPoint.x 60; lineChartDataPoint.y -37 ]
            [ lineChartDataPoint.x 65; lineChartDataPoint.y 51 ]
        ]
    ]
    [
        lineChartPoints.opacity 1.0
        lineChartPoints.color "orange"
        lineChartPoints.legend "legend2"
        lineChartPoints.data [
            [ lineChartDataPoint.x 20; lineChartDataPoint.y 21 ]
            [ lineChartDataPoint.x 25; lineChartDataPoint.y -25 ]
            [  lineChartDataPoint.x 30; lineChartDataPoint.y 10 ]
            [ lineChartDataPoint.x 35; lineChartDataPoint.y -10 ]
            [ lineChartDataPoint.x 40; lineChartDataPoint.y 14 ]
            [ lineChartDataPoint.x 45; lineChartDataPoint.y -18 ]
            [ lineChartDataPoint.x 50; lineChartDataPoint.y 9 ]
            [ lineChartDataPoint.x 55; lineChartDataPoint.y -23 ]
            [ lineChartDataPoint.x 60; lineChartDataPoint.y 7 ]
            [ lineChartDataPoint.x 65; lineChartDataPoint.y -55 ]
        ]
    ]
    [
        lineChartPoints.opacity 1.0
        lineChartPoints.color "purple"
        lineChartPoints.legend "legend3"
        lineChartPoints.data [
            [ lineChartDataPoint.x 20; lineChartDataPoint.y 30 ]
            [ lineChartDataPoint.x 25; lineChartDataPoint.y 35 ]
            [  lineChartDataPoint.x 30; lineChartDataPoint.y -33 ]
            [ lineChartDataPoint.x 35; lineChartDataPoint.y 40 ]
            [ lineChartDataPoint.x 40; lineChartDataPoint.y 10 ]
            [ lineChartDataPoint.x 45; lineChartDataPoint.y -40 ]
            [ lineChartDataPoint.x 50; lineChartDataPoint.y 34 ]
            [ lineChartDataPoint.x 55; lineChartDataPoint.y 40 ]
            [ lineChartDataPoint.x 60; lineChartDataPoint.y -60 ]
            [ lineChartDataPoint.x 65; lineChartDataPoint.y 40 ]
        ]
    ]
]

let ganttChartDataList = [
    [
        ganttChartDataPoint.x [
            xDataPoint.start (System.DateOnly.Parse "2009-01-01")
            xDataPoint.end' (System.DateOnly.Parse "2009-02-28")
        ]
        ganttChartDataPoint.y "Job A"
        ganttChartDataPoint.legend "Alex"
        ganttChartDataPoint.color Fui.dataVizPalette.color1
        ganttChartDataPoint.gradient ("#4760D5", "#637CEF")
    ]
    [
        ganttChartDataPoint.x [
            xDataPoint.start (System.DateOnly.Parse "2009-03-05")
            xDataPoint.end' (System.DateOnly.Parse "2009-04-15")
        ]
        ganttChartDataPoint.y "Job B"
        ganttChartDataPoint.legend "Alex"
        ganttChartDataPoint.color Fui.dataVizPalette.color1
        ganttChartDataPoint.gradient ("#4760D5", "#637CEF")
    ]
    [
        ganttChartDataPoint.x [
            xDataPoint.start (System.DateOnly.Parse "2009-02-20")
            xDataPoint.end' (System.DateOnly.Parse "2009-05-30")
        ]
        ganttChartDataPoint.y "Job C"
        ganttChartDataPoint.legend "Max"
        ganttChartDataPoint.color Fui.dataVizPalette.color2
        ganttChartDataPoint.gradient ("#E61C99", "#EE5FB7")
    ]
]

let basicChartTableHeaders = [
    [ chartTableHeader.value "Product" ]
    [ chartTableHeader.value "Q1 Sales" ]
    [ chartTableHeader.value "Q2 Sales" ]
    [ chartTableHeader.value "Q3 Sales" ]
    [ chartTableHeader.value "Q4 Sales" ]
    [ chartTableHeader.value "Total" ]
]

let basicChartTableRows = [
    [
        [chartTableRow.value "Product A" ]
        [chartTableRow.value 25000 ]
        [chartTableRow.value 30000 ]
        [chartTableRow.value 28000 ]
        [chartTableRow.value 35000 ]
        [chartTableRow.value 118000 ]
    ]
    [
        [ chartTableRow.value "Product B" ]
        [ chartTableRow.value 18000 ]
        [ chartTableRow.value 22000 ]
        [ chartTableRow.value 25000 ]
        [ chartTableRow.value 27000 ]
        [ chartTableRow.value 9200 ]
    ]
    [
        [ chartTableRow.value "Product C" ]
        [ chartTableRow.value 32000 ]
        [ chartTableRow.value 28000 ]
        [ chartTableRow.value 31000 ]
        [ chartTableRow.value 29000 ]
        [ chartTableRow.value 12000 ]
    ]
    [
        [ chartTableRow.value "Product D" ]
        [ chartTableRow.value 15000 ]
        [ chartTableRow.value 19000 ]
        [ chartTableRow.value 21000 ]
        [ chartTableRow.value 23000 ]
        [ chartTableRow.value 780000 ]
    ]
]

let funnelChartStackedData = [
    [
        funnelChartDataPoint.stage "Visit"
        funnelChartDataPoint.subValues [
            [
                funnelChartDataPointSubValue.category "A"
                funnelChartDataPointSubValue.value 100
                funnelChartDataPointSubValue.color "red"
            ]
            [
                funnelChartDataPointSubValue.category "B"
                funnelChartDataPointSubValue.value 80
                funnelChartDataPointSubValue.color "blue"
            ]
            [
                funnelChartDataPointSubValue.category "C"
                funnelChartDataPointSubValue.value 50
                funnelChartDataPointSubValue.color "green"
            ]
            [
                funnelChartDataPointSubValue.category "D"
                funnelChartDataPointSubValue.value 30
                funnelChartDataPointSubValue.color "pink"
            ]
        ]
    ]
    [
        funnelChartDataPoint.stage "Sign-Up"
        funnelChartDataPoint.subValues [
            [
                funnelChartDataPointSubValue.category "A"
                funnelChartDataPointSubValue.value 60
                funnelChartDataPointSubValue.color "red"
            ]
            [
                funnelChartDataPointSubValue.category "B"
                funnelChartDataPointSubValue.value 40
                funnelChartDataPointSubValue.color "blue"
            ]
            [
                funnelChartDataPointSubValue.category "C"
                funnelChartDataPointSubValue.value 20
                funnelChartDataPointSubValue.color "green"
            ]
            [
                funnelChartDataPointSubValue.category "D"
                funnelChartDataPointSubValue.value 10
                funnelChartDataPointSubValue.color "pink"
            ]
        ]
    ]
    [
        funnelChartDataPoint.stage "Purchase"
        funnelChartDataPoint.subValues [
            [
                funnelChartDataPointSubValue.category "A"
                funnelChartDataPointSubValue.value 30
                funnelChartDataPointSubValue.color "red"
            ]
            [
                funnelChartDataPointSubValue.category "B"
                funnelChartDataPointSubValue.value 20
                funnelChartDataPointSubValue.color "blue"
            ]
            [
                funnelChartDataPointSubValue.category "C"
                funnelChartDataPointSubValue.value 10
                funnelChartDataPointSubValue.color "green"
            ]
            [
                funnelChartDataPointSubValue.category "D"
                funnelChartDataPointSubValue.value 5
                funnelChartDataPointSubValue.color "pink"
            ]
        ]
    ]
]

let groupedVerticalBarChartData = [
    [
        groupedVerticalBarChartData.name "Jan - Mar"
        groupedVerticalBarChartData.series [
            [
                gvBarChartSeriesPoint.key "series1"
                gvBarChartSeriesPoint.data 33000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color3))
                gvBarChartSeriesPoint.legend "2022"
                gvBarChartSeriesPoint.xAxisCalloutData "2022/04/30"
                gvBarChartSeriesPoint.yAxisCalloutData "29%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jan - Mar 1 of 4, Bar series 1 of 2 2022, x value 2022/04/30, y value 29%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series2"
                gvBarChartSeriesPoint.data 44000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color4))
                gvBarChartSeriesPoint.legend "2023"
                gvBarChartSeriesPoint.xAxisCalloutData "2023/04/30"
                gvBarChartSeriesPoint.yAxisCalloutData "44%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jan - Mar 1 of 4, Bar series 2 of 2 2023, x value 2023/04/30, y value 44%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series3"
                gvBarChartSeriesPoint.data 54000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color5))
                gvBarChartSeriesPoint.legend "2024"
                gvBarChartSeriesPoint.xAxisCalloutData "2024/04/30"
                gvBarChartSeriesPoint.yAxisCalloutData "44%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jan - Mar 1 of 4, Bar series 3 of 4 2022, x value 2024/04/30, y value 44%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series4"
                gvBarChartSeriesPoint.data 24000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color6))
                gvBarChartSeriesPoint.legend "2021"
                gvBarChartSeriesPoint.xAxisCalloutData "2021/04/30"
                gvBarChartSeriesPoint.yAxisCalloutData "44%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jan - Mar 1 of 4, Bar series 4 of 4 2021, x value 2021/04/30, y value 44%"
                ]
            ]
        ]
    ]
    [
        groupedVerticalBarChartData.name "Apr - Jun"
        groupedVerticalBarChartData.series [
            [
                gvBarChartSeriesPoint.key "series1"
                gvBarChartSeriesPoint.data 33000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color3))
                gvBarChartSeriesPoint.legend "2022"
                gvBarChartSeriesPoint.xAxisCalloutData "2022/05/30"
                gvBarChartSeriesPoint.yAxisCalloutData "29%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Apr - Jun 2 of 4, Bar series 1 of 2 2022, x value 2022/05/30, y value 29%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series2"
                gvBarChartSeriesPoint.data 3000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color4))
                gvBarChartSeriesPoint.legend "2023"
                gvBarChartSeriesPoint.xAxisCalloutData "2023/05/30"
                gvBarChartSeriesPoint.yAxisCalloutData "3%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Apr - Jun 2 of 4, Bar series 2 of 2 2023, x value 2023/05/30, y value 3%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series3"
                gvBarChartSeriesPoint.data 9000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color5))
                gvBarChartSeriesPoint.legend "2024"
                gvBarChartSeriesPoint.xAxisCalloutData "2024/05/30"
                gvBarChartSeriesPoint.yAxisCalloutData "3%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Apr - Jun 2 of 4, Bar series 3 of 4 2024, x value 2024/05/30, y value 3%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series4"
                gvBarChartSeriesPoint.data 12000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color6))
                gvBarChartSeriesPoint.legend "2021"
                gvBarChartSeriesPoint.xAxisCalloutData "2021/05/30"
                gvBarChartSeriesPoint.yAxisCalloutData "3%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Apr - Jun 2 of 4, Bar series 4 of 4 2021, x value 2021/05/30, y value 3%"
                ]
            ]
        ]
    ]
    [
        groupedVerticalBarChartData.name "Jul - Sep"
        groupedVerticalBarChartData.series [
            [
                gvBarChartSeriesPoint.key "series1"
                gvBarChartSeriesPoint.data 14000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color3))
                gvBarChartSeriesPoint.legend "2022"
                gvBarChartSeriesPoint.xAxisCalloutData "2022/06/30"
                gvBarChartSeriesPoint.yAxisCalloutData "13%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jul - Sep 3 of 4, Bar series 1 of 2 2022, x value 2022/06/30, y value 13%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series2"
                gvBarChartSeriesPoint.data 50000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color4))
                gvBarChartSeriesPoint.legend "2023"
                gvBarChartSeriesPoint.xAxisCalloutData "2023/06/30"
                gvBarChartSeriesPoint.yAxisCalloutData "50%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jul - Sep 3 of 4, Bar series 2 of 2 2023, x value 2023/06/30, y value 50%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series3"
                gvBarChartSeriesPoint.data 60000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color5))
                gvBarChartSeriesPoint.legend "2024"
                gvBarChartSeriesPoint.xAxisCalloutData "2024/06/30"
                gvBarChartSeriesPoint.yAxisCalloutData "50%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jul - Sep 3 of 4, Bar series 3 of 4 2024, x value 2024/06/30, y value 50%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series4"
                gvBarChartSeriesPoint.data 10000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color6))
                gvBarChartSeriesPoint.legend "2021"
                gvBarChartSeriesPoint.xAxisCalloutData "2021/06/30"
                gvBarChartSeriesPoint.yAxisCalloutData "50%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Jul - Sep 3 of 4, Bar series 4 of 4 2021, x value 2021/06/30, y value 50%"
                ]
            ]
        ]
    ]
    [
        groupedVerticalBarChartData.name "Oct - Dec"
        groupedVerticalBarChartData.series [
            [
                gvBarChartSeriesPoint.key "series1"
                gvBarChartSeriesPoint.data 14000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color3, true))
                gvBarChartSeriesPoint.legend "2022"
                gvBarChartSeriesPoint.xAxisCalloutData "2022/07/30"
                gvBarChartSeriesPoint.yAxisCalloutData "29%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Oct - Dec 4 of 4, Bar series 1 of 2 2022, x value 2022/07/30, y value 29%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series2"
                gvBarChartSeriesPoint.data 50000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color4, true))
                gvBarChartSeriesPoint.legend "2023"
                gvBarChartSeriesPoint.xAxisCalloutData "2023/07/30"
                gvBarChartSeriesPoint.yAxisCalloutData "3%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Oct - Dec 4 of 4, Bar series 2 of 2 2023, x value 2023/07/30, y value 3%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series3"
                gvBarChartSeriesPoint.data 60000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color5, true))
                gvBarChartSeriesPoint.legend "2024"
                gvBarChartSeriesPoint.xAxisCalloutData "2024/07/30"
                gvBarChartSeriesPoint.yAxisCalloutData "3%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Oct - Dec 4 of 4, Bar series 3 of 4 2024, x value 2024/07/30, y value 3%"
                ]
            ]
            [
                gvBarChartSeriesPoint.key "series4"
                gvBarChartSeriesPoint.data 10000
                gvBarChartSeriesPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color6, true))
                gvBarChartSeriesPoint.legend "2021"
                gvBarChartSeriesPoint.xAxisCalloutData "2021/07/30"
                gvBarChartSeriesPoint.yAxisCalloutData "3%"
                gvBarChartSeriesPoint.callOutAccessibilityData [
                    accessibility.ariaLabel "Group Oct - Dec 4 of 4, Bar series 4 of 4 2021, x value 2021/07/30, y value 3%"
                ]
            ]
        ]
    ]
]

let heatChartMappings = [
    "p1", "Ohio"
    "p2", "Alaska"
    "p3", "Texas"
    "p4", "DC"
    "p5", "NYC"
]
let yPointMapping (s: string) =
    let (_, state) = heatChartMappings |> List.find (fun (yPoint, _) -> yPoint = s)
    state

let yPoint = heatChartMappings |> List.map fst

let xPoint = [
    DateOnly.Parse ("2020-03-03")
    DateOnly.Parse ("2020-03-04")
    DateOnly.Parse ("2020-03-05")
    DateOnly.Parse ("2020-03-06")
    DateOnly.Parse ("2020-03-07")
    DateOnly.Parse ("2020-03-08")
    DateOnly.Parse ("2020-03-09")
    DateOnly.Parse ("2020-03-10")
]

let heatMapChartData = [
    [
        heatMapChartData.value 100
        heatMapChartData.legend "Excellent (0-200)"
        heatMapChartData.data [
            [
                heatMapChartDataPoint.x xPoint.[2]
                heatMapChartDataPoint.y yPoint.[2]
                heatMapChartDataPoint.value 46
                heatMapChartDataPoint.rectText 46
                heatMapChartDataPoint.ratio (46, 2391)
                heatMapChartDataPoint.descriptionMessage "air quality seems to be excellent today"
            ]
        ]
    ]
    [
        heatMapChartData.value 250
        heatMapChartData.legend "Good (201-300)"
        heatMapChartData.data [
            [
                heatMapChartDataPoint.x xPoint.[0]
                heatMapChartDataPoint.y yPoint.[1]
                heatMapChartDataPoint.value 265
                heatMapChartDataPoint.rectText 265
                heatMapChartDataPoint.ratio (265, 2479)
                heatMapChartDataPoint.descriptionMessage "today we have good air quality in Alaska"
            ]
            [
                heatMapChartDataPoint.x xPoint.[1]
                heatMapChartDataPoint.y yPoint.[0]
                heatMapChartDataPoint.value 250
                heatMapChartDataPoint.rectText 250
                heatMapChartDataPoint.ratio (250, 2043)
                heatMapChartDataPoint.descriptionMessage "a sudden rise of 150 units in Ohio today"
            ]
            [
                heatMapChartDataPoint.x xPoint.[2]
                heatMapChartDataPoint.y yPoint.[0]
                heatMapChartDataPoint.value 235
                heatMapChartDataPoint.rectText 235
                heatMapChartDataPoint.ratio (235, 2043)
                heatMapChartDataPoint.descriptionMessage "air quality seems to have decreased by only 15 units from yesterday"
            ]
            [
                heatMapChartDataPoint.x xPoint.[6]
                heatMapChartDataPoint.y yPoint.[2]
                heatMapChartDataPoint.value 300
                heatMapChartDataPoint.rectText 300
                heatMapChartDataPoint.ratio (300, 2391)
                heatMapChartDataPoint.descriptionMessage "air comes to control a little bit more than yesterday"
            ]
            [
                heatMapChartDataPoint.x xPoint.[0]
                heatMapChartDataPoint.y yPoint.[3]
                heatMapChartDataPoint.value 290
                heatMapChartDataPoint.rectText 290
                heatMapChartDataPoint.ratio (290, 2462)
                heatMapChartDataPoint.descriptionMessage "1st day in the week, DC witnesses good air quality"
            ]
            [
                heatMapChartDataPoint.x xPoint.[4]
                heatMapChartDataPoint.y yPoint.[4]
                heatMapChartDataPoint.value 280
                heatMapChartDataPoint.rectText 280
                heatMapChartDataPoint.ratio (280, 2486)
                heatMapChartDataPoint.descriptionMessage "Air quality index decreases by exactly 300 units, giving the people of NYC good hope"
            ]
            [
                heatMapChartDataPoint.x xPoint.[5]
                heatMapChartDataPoint.y yPoint.[3]
                heatMapChartDataPoint.value 300
                heatMapChartDataPoint.rectText 300
                heatMapChartDataPoint.ratio (300, 2462)
                heatMapChartDataPoint.descriptionMessage "60 units decreased from yesterday."
            ]
        ]
    ]
]

let horizontalBarChartData = [
    [
        chart.chartTitle "one"
        chart.chartData [
            [
                chartDataPoint.legend "One.One"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 1543
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color1))
            ]
            [
                chartDataPoint.legend "One.Two"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 1000
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color2))
            ]
            [
                chartDataPoint.legend "One.Three"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 547
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color3))
            ]
        ]
    ]
    [
        chart.chartTitle "two"
        chart.chartData [
            [
                chartDataPoint.legend "Two.One"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 987
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color4))
            ]
            [
                chartDataPoint.legend "Two.Two"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 1987
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color5))
            ]
        ]
    ]
    [
        chart.chartTitle "three"
        chart.chartData [
            [
                chartDataPoint.legend "Three.One"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 872
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color6))
            ]
            [
                chartDataPoint.legend "Three.Two"
                chartDataPoint.horizontalBarChartdata [
                    horizontalDataPoint.x 128
                ]
                chartDataPoint.color (Fui.getColorFromToken(Fui.dataVizPalette.color7))
            ]
        ]
    ]
]

let horizontalBarWithAxisData = [
    [
        horizontalBarChartWithAxisDataPoint.y "String One"
        horizontalBarChartWithAxisDataPoint.x 1000
        horizontalBarChartWithAxisDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color1)
    ]
    [
        horizontalBarChartWithAxisDataPoint.y "String Two"
        horizontalBarChartWithAxisDataPoint.x 5000
        horizontalBarChartWithAxisDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color2)
    ]
    [
        horizontalBarChartWithAxisDataPoint.y "String Three"
        horizontalBarChartWithAxisDataPoint.x 3000
        horizontalBarChartWithAxisDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color3)
    ]
    [
        horizontalBarChartWithAxisDataPoint.y "String Four"
        horizontalBarChartWithAxisDataPoint.x 2000
        horizontalBarChartWithAxisDataPoint.color (Fui.getColorFromToken Fui.dataVizPalette.color4)
    ]
]

type LegendData = {
    title: string
    color: string
    action: unit -> unit
    onMouseOutAction: unit -> unit
    hoverAction: unit -> unit
    shape: string
}
let legendsData = [
    {
        title = "Legend 1"
        color = (Fui.getColorFromToken Fui.dataVizPalette.color1)
        action = (fun _ -> printfn "click from legends pages")
        onMouseOutAction = (fun _ -> printfn "on mouse out action")
        hoverAction = (fun _ -> printfn "hover action")
        shape = "default"
    }
    {
        title = "Legend 2"
        color = (Fui.getColorFromToken Fui.dataVizPalette.color2)
        action = (fun _ -> printfn "click from legends pages")
        onMouseOutAction = (fun _ -> printfn "on mouse out action")
        hoverAction = (fun _ -> printfn "hover action")
        shape = "default"
    }
    {
        title = "Legend 3"
        color = (Fui.getColorFromToken Fui.dataVizPalette.color3)
        action = (fun _ -> printfn "click from legends pages")
        onMouseOutAction = (fun _ -> printfn "on mouse out action")
        hoverAction = (fun _ -> printfn "hover action")
        shape = "diamond"
    }
    {
        title = "Legend 4"
        color = (Fui.getColorFromToken Fui.dataVizPalette.color4)
        action = (fun _ -> printfn "click from legends pages")
        onMouseOutAction = (fun _ -> printfn "on mouse out action")
        hoverAction = (fun _ -> printfn "hover action")
        shape = "triangle"
    }
]

let lineChartPointsData = [
    chart.chartTitle "Line Chart"
    chart.lineChartData [
        [
            lineChartPoints.data [
                [ lineChartDataPoint.x (DateOnly.Parse "2018/01/06"); lineChartDataPoint.y 10; lineChartDataPoint.xAxisCalloutData "Appointment 1" ]
                [ lineChartDataPoint.x (DateOnly.Parse "2018/01/16"); lineChartDataPoint.y 18; lineChartDataPoint.xAxisCalloutData "Appointment 2" ]
                [ lineChartDataPoint.x (DateOnly.Parse "2018/01/20"); lineChartDataPoint.y 24; lineChartDataPoint.xAxisCalloutData "Appointment 3" ]
                [ lineChartDataPoint.x (DateOnly.Parse "2018/01/24"); lineChartDataPoint.y 35; lineChartDataPoint.xAxisCalloutData "Appointment 4" ]
                [ lineChartDataPoint.x (DateOnly.Parse "2018/01/26"); lineChartDataPoint.y 35; lineChartDataPoint.xAxisCalloutData "Appointment 5" ]
                [ lineChartDataPoint.x (DateOnly.Parse "2018/01/29"); lineChartDataPoint.y 90; lineChartDataPoint.xAxisCalloutData "Appointment 6" ]
            ]
            lineChartPoints.legend "first legend"
            lineChartPoints.lineOptions [
                lineChartLineOptions.lineBorderWidth "4"
            ]
            lineChartPoints.color Fui.dataVizPalette.color10
        ]
    ]
]

let sankeyChartDataList = [
    chart.chartTitle "Sankey Chart"
    chart.sankeyChartData [
        sankeyChartData.nodes [
            [ sNode.nodeId 0; sNode.name "node0"; sNode.color (Fui.getColorFromToken Fui.dataVizPalette.color3); sNode.borderColor (Fui.getColorFromToken Fui.dataVizPalette.color23)]
            [ sNode.nodeId 1; sNode.name "node1"; sNode.color (Fui.getColorFromToken Fui.dataVizPalette.color22); sNode.borderColor (Fui.getColorFromToken Fui.dataVizPalette.color2)]
            [ sNode.nodeId 2; sNode.name "node2"; sNode.color (Fui.getColorFromToken Fui.dataVizPalette.color1); sNode.borderColor (Fui.getColorFromToken Fui.dataVizPalette.color21)]
            [ sNode.nodeId 3; sNode.name "node3"; sNode.color (Fui.getColorFromToken Fui.dataVizPalette.color27); sNode.borderColor (Fui.getColorFromToken Fui.dataVizPalette.color7)]
            [ sNode.nodeId 4; sNode.name "node4"; sNode.color (Fui.getColorFromToken Fui.dataVizPalette.color28); sNode.borderColor (Fui.getColorFromToken Fui.dataVizPalette.color8)]
            [ sNode.nodeId 5; sNode.name "node5"; sNode.color (Fui.getColorFromToken Fui.dataVizPalette.color4); sNode.borderColor (Fui.getColorFromToken Fui.dataVizPalette.color24)]
        ]
        sankeyChartData.links [
            [ sLink.source 0; sLink.target 2; sLink.value 2 ]
            [ sLink.source 1; sLink.target 2; sLink.value 2 ]
            [ sLink.source 1; sLink.target 3; sLink.value 2 ]
            [ sLink.source 0; sLink.target 4; sLink.value 2 ]
            [ sLink.source 2; sLink.target 3; sLink.value 2 ]
            [ sLink.source 2; sLink.target 4; sLink.value 2 ]
            [ sLink.source 3; sLink.target 4; sLink.value 4 ]
            [ sLink.source 3; sLink.target 5; sLink.value 4 ]
        ]
    ]
]

let scatterChartData = [
    chart.chartTitle "Sales Performance by Category"
    chart.scatterChartData [
        [
            scatterChartPoints.legend "Region 1"
            scatterChartPoints.color Fui.dataVizPalette.color3
            scatterChartPoints.data [
                [ scatterChartDataPoint.x "Electronics"; scatterChartDataPoint.y 50000; scatterChartDataPoint.markerSize 25 ]
                [ scatterChartDataPoint.x "Furniture"; scatterChartDataPoint.y 30000; scatterChartDataPoint.markerSize 20 ]
                [ scatterChartDataPoint.x "Clothing"; scatterChartDataPoint.y 20000; scatterChartDataPoint.markerSize 15 ]
                [ scatterChartDataPoint.x "Toys"; scatterChartDataPoint.y 15000; scatterChartDataPoint.markerSize 10 ]
                [ scatterChartDataPoint.x "Books"; scatterChartDataPoint.y 10000; scatterChartDataPoint.markerSize 8 ]
            ]
        ]
        [
            scatterChartPoints.legend "Region 2"
            scatterChartPoints.color Fui.dataVizPalette.color4
            scatterChartPoints.data [
                [ scatterChartDataPoint.x "Electronics"; scatterChartDataPoint.y 60000; scatterChartDataPoint.markerSize 30 ]
                [ scatterChartDataPoint.x "Furniture"; scatterChartDataPoint.y 25000; scatterChartDataPoint.markerSize 18 ]
                [ scatterChartDataPoint.x "Clothing"; scatterChartDataPoint.y 22000; scatterChartDataPoint.markerSize 16 ]
                [ scatterChartDataPoint.x "Toys"; scatterChartDataPoint.y 12000; scatterChartDataPoint.markerSize 12 ]
                [ scatterChartDataPoint.x "Books"; scatterChartDataPoint.y 8000; scatterChartDataPoint.markerSize 6 ]
            ]
        ]
    ]
]

let sparklineData = [
    chart.chartTitle "10.21"
    chart.lineChartData [
        [
            lineChartPoints.legend "19.64"
            lineChartPoints.color (Fui.getColorFromToken Fui.dataVizPalette.color1)
            lineChartPoints.data [
                [ lineChartDataPoint.x 1; lineChartDataPoint.y 58.13 ]
                [ lineChartDataPoint.x 2; lineChartDataPoint.y 140.98 ]
                [ lineChartDataPoint.x 3; lineChartDataPoint.y 20 ]
                [ lineChartDataPoint.x 4; lineChartDataPoint.y 89.7 ]
                [ lineChartDataPoint.x 5; lineChartDataPoint.y 99 ]
                [ lineChartDataPoint.x 6; lineChartDataPoint.y 13.28 ]
                [ lineChartDataPoint.x 7; lineChartDataPoint.y 31.32 ]
                [ lineChartDataPoint.x 8; lineChartDataPoint.y 10.21 ]
            ]
        ]
    ]
]

let verticalBarChartDataList = [
    [
        verticalBarChartDataPoint.x "This is a medium long label."
        verticalBarChartDataPoint.y 3500
        verticalBarChartDataPoint.color "#627CEF"
    ]
    [
        verticalBarChartDataPoint.x "This is a long label This is a long label"
        verticalBarChartDataPoint.y 2500
        verticalBarChartDataPoint.color "#C19C00"
    ]
    [
        verticalBarChartDataPoint.x "This label is as long as the previous one"
        verticalBarChartDataPoint.y 1900
        verticalBarChartDataPoint.color "#E650AF"
    ]
    [
        verticalBarChartDataPoint.x "A short label"
        verticalBarChartDataPoint.y 2800
        verticalBarChartDataPoint.color "#0E7878"
    ]
]

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

let polarChartData = [
    [
        areaPolarSeries.type'.areapolar
        areaPolarSeries.legend "Mike"
        areaPolarSeries.color "#8884d8"
        areaPolarSeries.data [
            [ polarDataPoint.r 120;  polarDataPoint.theta "Math"]
            [ polarDataPoint.r 98; polarDataPoint.theta "Chinese"]
            [ polarDataPoint.r 86; polarDataPoint.theta "English" ]
            [ polarDataPoint.r 99; polarDataPoint.theta "Geography" ]
            [ polarDataPoint.r 85; polarDataPoint.theta "Physics" ]
            [ polarDataPoint.r 65; polarDataPoint.theta "History" ]
        ]
    ]
    [
        areaPolarSeries.type'.areapolar
        areaPolarSeries.legend "Lily"
        areaPolarSeries.color "#82ca9d"
        areaPolarSeries.data [
            [ polarDataPoint.r 110;  polarDataPoint.theta "Math"]
            [ polarDataPoint.r 130; polarDataPoint.theta "Chinese"]
            [ polarDataPoint.r 130; polarDataPoint.theta "English" ]
            [ polarDataPoint.r 100; polarDataPoint.theta "Geography" ]
            [ polarDataPoint.r 90; polarDataPoint.theta "Physics" ]
            [ polarDataPoint.r 85; polarDataPoint.theta "History" ]
        ]
    ]
]

[<ReactComponent>]
let TestChartsComponent () =
    let sliderValue, setSliderValue = React.useState 50
    Html.div [
        prop.style [ style.width 1000; style.margin 36 ]
        prop.children [
            Fui.polarChart [
                polarChart.data polarChartData
                polarChart.width 300
                polarChart.height 300
                polarChart.shape.polygon
                polarChart.direction.clockwise
            ]
            Fui.areaChart [
                areaChart.mode.tonexty
                areaChart.height 300
                areaChart.width 600
                areaChart.legendsOverflowText "Overflow Items"
                areaChart.yAxisTickFormat (fun (s:string) -> $"${s}")
                areaChart.svgProps [ prop.ariaLabel "This is another test?!"]
                areaChart.enableGradient true
                areaChart.enablePerfOptimization true
                areaChart.reflowProps.modeNone
                areaChart.xAxis.tickStep 5
                areaChart.xAxis.tick0 5
                areaChart.legendProps [
                    legends.allowFocusOnLegends true
                    legends.canSelectMultipleLegends true
                    legends.centerLegends true
                ]
                areaChart.data [
                    chart.chartTitle "Areachart"
                    chart.lineChartData areaChartDataList
                ]
            ]
            Fui.chartTable [
                chartTable.height 250
                chartTable.width 600
                chartTable.headers basicChartTableHeaders
                chartTable.rows basicChartTableRows
            ]
            Fui.donutChart [
                donutChart.valueInsideDonut 65
                donutChart.innerRadius 50
                donutChart.data [
                    chart.chartTitle "Donut Chart"
                    chart.chartData [
                        [
                            chartDataPoint.legend "legend 1"
                            chartDataPoint.color "green"
                            chartDataPoint.data 65
                            chartDataPoint.xAxisCalloutData "2025/10/14"
                        ]
                        [
                            chartDataPoint.legend "legend 2"
                            chartDataPoint.color "blue"
                            chartDataPoint.data 35
                            chartDataPoint.xAxisCalloutData "2025/10/09"
                        ]
                    ]
                ]
            ]
            Fui.funnelChart [
                funnelChart.data funnelChartStackedData
                funnelChart.chartTitle "Stacked Funnel Chart"
                funnelChart.width 600
                funnelChart.height 400
                funnelChart.hideLegend false
                funnelChart.orientation.horizontal
                funnelChart.legendProps [
                    legends.canSelectMultipleLegends true
                ]
            ]
            Fui.ganttChart [
                ganttChart.data ganttChartDataList
                ganttChart.showYAxisLables true
                ganttChart.width 500
                ganttChart.height 300
                ganttChart.enableGradient true
                ganttChart.roundCorners true
            ]
            Fui.slider [
                slider.min 0
                slider.max 100
                slider.onChange (fun (prop: ValueProp<int>) -> setSliderValue prop.value)
                slider.value sliderValue
            ]
            Fui.gaugeChart [
                gaugeChart.width 500
                gaugeChart.height 300
                gaugeChart.segments [
                    [
                        gaugeChartSegment.size sliderValue
                        gaugeChartSegment.legend "Used"
                    ]
                    [
                        gaugeChartSegment.size (100 - sliderValue)
                        gaugeChartSegment.color Fui.dataVizPalette.color5
                        gaugeChartSegment.legend "Available"
                    ]
                ]
                gaugeChart.chartValue sliderValue
                gaugeChart.chartTitle "Storage capacity"
                gaugeChart.sublabel "used"
                gaugeChart.variant.singleSegment
                gaugeChart.enableGradient true
                gaugeChart.roundCorners true
            ]
            Fui.groupedVerticalBarChart [
                groupedVerticalBarChart.chartTitle "Grouped vertical bar chart basic example"
                groupedVerticalBarChart.height 400
                groupedVerticalBarChart.width 500
                groupedVerticalBarChart.hideLabels false
                groupedVerticalBarChart.data groupedVerticalBarChartData
            ]
            Fui.heatMapChart [
                heatMapChart.data heatMapChartData
                heatMapChart.chartTitle "Heat map chart basic example"
                heatMapChart.yAxisStringFormatter yPointMapping
                heatMapChart.xAxisNumberFormatString ".7s"
                heatMapChart.yAxisNumberFormatString ".3s"
                heatMapChart.width 400
                heatMapChart.height 400
                heatMapChart.domainValuesForColorScale [0; 200; 400; 600]
                heatMapChart.rangeValuesForColorScale [
                    Fui.getColorFromToken Fui.dataVizPalette.success
                    Fui.getColorFromToken Fui.dataVizPalette.warning
                    Fui.getColorFromToken Fui.dataVizPalette.error
                    Fui.getColorFromToken Fui.dataVizPalette.highError
                ]
                heatMapChart.reflowProps.modeMinWidth
            ]
            Fui.horizontalBarChart [
                horizontalBarChart.data horizontalBarChartData
                horizontalBarChart.chartDataMode.default'
                horizontalBarChart.className "hbcstacked"
                horizontalBarChart.variant.partToWhole
            ]
            Fui.horizontalBarChartWithAxis [
                horizontalBarChartWithAxis.data horizontalBarWithAxisData
                horizontalBarChartWithAxis.chartTitle "Horizontal bar chart axis tooltip example"
                horizontalBarChartWithAxis.height 350
                horizontalBarChartWithAxis.width 650
                horizontalBarChartWithAxis.hideLegend true
                horizontalBarChartWithAxis.hideTooltip false
                horizontalBarChartWithAxis.showYAxisLablesTooltip false
                horizontalBarChartWithAxis.showYAxisLables true
                horizontalBarChartWithAxis.enableGradient true
                horizontalBarChartWithAxis.roundCorners true
                horizontalBarChartWithAxis.onRenderCalloutPerDataPoint (fun props ->
                    Fui.text $"{props.y}: {props.x}")
            ]
            Html.div [
                prop.style [ style.margin 32 ]
                prop.children [
                    Fui.legends [ legends.legends legendsData ]
                ]
            ]
            Fui.lineChart [
                lineChart.data lineChartPointsData
                lineChart.strokeWidth 6
                lineChart.yMaxValue 90
                lineChart.showXAxisLablesTooltip true
                lineChart.height 400
                lineChart.width 400
                lineChart.tickFormat "%m/%d"
                lineChart.tickValues [
                    DateOnly.Parse "2018-01-01"
                    DateOnly.Parse "2018-02-09"
                ]
                lineChart.enablePerfOptimization true
            ]
            Fui.sankeyChart [
                sankeyChart.data sankeyChartDataList
                sankeyChart.height 300
                sankeyChart.width 600
                sankeyChart.shouldResize 900
                sankeyChart.reflowProps.modeMinWidth
            ]
            Fui.scatterChart [
                scatterChart.data scatterChartData
                scatterChart.height 400
                scatterChart.width 500
                scatterChart.xAxisTitle "Product Category"
                scatterChart.yAxisTitle "Revenue in dollars"
                scatterChart.styles [
                    scatterChartStyles.svgTooltip "test-svg-styles"
                ]
            ]
            Fui.sparkline [
                sparkline.data sparklineData
                sparkline.showLegend true
            ]
            Fui.verticalBarChart [
                verticalBarChart.chartTitle "Vertical bar chart rotated labels example"
                verticalBarChart.data verticalBarChartDataList
                verticalBarChart.height 350
                verticalBarChart.width 650
                verticalBarChart.hideLegend true
                verticalBarChart.rotateXAxisLables true
                verticalBarChart.annotations [
                    [
                        annotation.text "Test Annotation"
                        annotation.coordinates [
                            chartAnnotationCoordinate.x 100
                            chartAnnotationCoordinate.y 100
                            chartAnnotationCoordinate.type'.pixel
                        ]
                    ]
                ]
            ]
            Fui.verticalStackedBarChart [
                verticalStackedBarChart.onRenderCalloutPerDataPoint (fun (props: VSChartDataPoint) ->
                    Fui.text $"Test Render: {props.data} - {props.color}")
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
        ]
    ]
