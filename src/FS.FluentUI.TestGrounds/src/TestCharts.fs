module TestCharts

open System
open Feliz
open FS.FluentUI
open FS.Charts

type LineChartDataPoint = { x: float; y: float }

type LineChartData = {
    Name: string
    Opacity: float
    Color: string
    Data: LineChartDataPoint list
}

let lineChartDataList: LineChartData list = [
    {
        Name = "Testing"
        Opacity = 0.3
        Color = "orange"
        Data = [
            { x = 0.0; y = 1000.0 }
            { x = 1.0; y = 1200.0 }
            { x = 2.0; y = 1400.0 }
            { x = 4.0; y = 1600.0 }
            { x = 5.0; y = 1800.0 }
            { x = 6.0; y = 1500.0 }
        ]
    }
    {
        Name = "Protein Intake"
        Opacity = 0.5
        Color = "#0078D4"
        Data = [
            { x = 0.0; y = 500.0 }
            { x = 1.0; y = 750.0 }
            { x = 2.0; y = 800.0 }
            { x = 3.0; y = 700.0 }
            { x = 4.0; y = 900.0 }
            { x = 5.0; y = 950.0 }
            { x = 6.0; y = 1000.0 }
        ]
    }
    {
        Name = "Water Consumption"
        Opacity = 1.0 // Default opacity since it wasn't specified in the original
        Color = "red" // You'll need to replace this with the actual color value from Theme.tokens.colorStatusDangerBackground2
        Data = [
            { x = 0.0; y = 1500.0 }
            { x = 1.0; y = 1600.0 }
            { x = 2.0; y = 1550.0 }
            { x = 3.0; y = 1650.0 }
            { x = 4.0; y = 1700.0 }
            { x = 6.0; y = 1750.0 }
            { x = 7.0; y = 1800.0 }
        ]
    }
]

// let lineChartDataSet = [
//     Charts.lineChartData [
//         lineChartData.legendShape.triangle
//         lineChartData.opacity 0.3
//         lineChartData.data [
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 0.0
//                 lineChartDataPoint.y 1000.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 1.0
//                 lineChartDataPoint.y 1200.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 2.0
//                 lineChartDataPoint.y 1400.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 4.0
//                 lineChartDataPoint.y 1600.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 5.0
//                 lineChartDataPoint.y 1800.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 6.0
//                 lineChartDataPoint.y 1500.0
//             ]
//         ]
//
//     ]
//     Charts.lineChartData [
//         lineChartData.legendShape.triangle
//         lineChartData.legend "Protein Intake"
//         lineChartData.color "#0078D4"
//         lineChartData.opacity 0.5
//
//         lineChartData.data [
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 0.0
//                 lineChartDataPoint.y 500.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 1.0
//                 lineChartDataPoint.y 750.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 2.0
//                 lineChartDataPoint.y 800.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 3.0
//                 lineChartDataPoint.y 700.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 4.0
//                 lineChartDataPoint.y 900.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 5.0
//                 lineChartDataPoint.y 950.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 6.0
//                 lineChartDataPoint.y 1000.0
//             ]
//         ]
//
//         lineChartData.lineOptions [
//             lineChartLineOptions.strokeWidth 2.0
//             lineChartLineOptions.lineBorderWidth 2.0
//             lineChartLineOptions.strokeLinecap.square
//         ]
//     ]
//     Charts.lineChartData [
//         lineChartData.onLineCLick (fun _ -> printfn "test")
//         lineChartData.onLegendClick (fun s -> printfn $"TESTING: {s}")
//         lineChartData.legend "Water Consumption"
//         lineChartData.color Theme.tokens.colorStatusDangerBackground2
//         lineChartData.gaps [
//             { startIndex = 4.0; endIndex = 5.0 } // simulate missing data
//         ]
//         lineChartData.data [
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 0.0
//                 lineChartDataPoint.y 1500.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 1.0
//                 lineChartDataPoint.y 1600.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 2.0
//                 lineChartDataPoint.y 1550.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 3.0
//                 lineChartDataPoint.y 1650.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 4.0
//                 lineChartDataPoint.y 1700.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 6.0
//                 lineChartDataPoint.y 1750.0
//             ]
//             Charts.lineChartDataPoint [
//                 lineChartDataPoint.x 7.0
//                 lineChartDataPoint.y 1800.0
//             ]
//         ]
//         lineChartData.lineOptions [
//             lineChartLineOptions.strokeWidth 2.0
//             lineChartLineOptions.strokeLinecap.square
//         ]
//     ]
// ]

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

type HeatMapChartDataPoint = {
    X: float
    Y: string
    Value: float
    RectText: float
    Description: string
}

type HeatMapChartData = {
    Name: string
    Value: float
    Data: HeatMapChartDataPoint list
}

let heatMapDataPointsList: HeatMapChartData list = [
    {
        Name = "Excellent (0-200)"
        Value = 100.0
        Data = [
            {
                X = 2.0
                Y = "2"
                Value = 46.0
                RectText = 46.0
                Description = "air quality seems to be excellent today"
            }
        ]
    }
    {
        Name = "Good (201-300)"
        Value = 250.0
        Data = [
            {
                X = 0.0
                Y = "1"
                Value = 265.0
                RectText = 265.0
                Description = "today we have good air quality in Alaska"
            }
            {
                X = 1.0
                Y = "0"
                Value = 250.0
                RectText = 250.0
                Description = "a sudden rise of 150 units in Ohio today"
            }
            {
                X = 2.0
                Y = "0"
                Value = 235.0
                RectText = 235.0
                Description = "air quality seems to have decreased by only 15 units from yesterday"
            }
            {
                X = 6.0
                Y = "2"
                Value = 300.0
                RectText = 300.0
                Description = "air comes to control a little bit more than yesterday"
            }
            {
                X = 0.0
                Y = "3"
                Value = 290.0
                RectText = 290.0
                Description = "1st day in the week, DC witnesses good air quality"
            }
            {
                X = 4.0
                Y = "4"
                Value = 280.0
                RectText = 280.0
                Description = "Air quality index decreases by exactly 300 units, giving the people of NYC good hope"
            }
            {
                X = 5.0
                Y = "3"
                Value = 300.0
                RectText = 300.0
                Description = "60 units decreased from yesterday."
            }
        ]
    }
    {
        Name = "Medium (301-400)"
        Value = 350.0
        Data = [
            {
                X = 1.0
                Y = "1"
                Value = 345.0
                RectText = 345.0
                Description = "Alaska has just reported nearly 100 units hike in air quality"
            }
            {
                X = 6.0
                Y = "1"
                Value = 325.0
                RectText = 325.0
                Description = "Alaska to 300"
            }
            {
                X = 5.0
                Y = "2"
                Value = 390.0
                RectText = 390.0
                Description = "air comes to control a little bit"
            }
            {
                X = 1.0
                Y = "3"
                Value = 385.0
                RectText = 385.0
                Description = "Washington DC witnesses a hike of nearly 100 units in air quality"
            }
            {
                X = 4.0
                Y = "3"
                Value = 360.0
                RectText = 360.0
                Description = "a 200% hike in the air quality index"
            }
            {
                X = 1.0
                Y = "2"
                Value = 400.0
                RectText = 400.0
                Description = "a sudden spike in the badness of the air quality"
            }
            {
                X = 3.0
                Y = "0"
                Value = 400.0
                RectText = 400.0
                Description = "situation got worse in air quality due to industrial smoke"
            }
        ]
    }
    {
        Name = "Danger (401-500)"
        Value = 450.0
        Data = [
            {
                X = 4.0
                Y = "0"
                Value = 423.0
                RectText = 423.0
                Description = "we can see an increase of 23 units"
            }
            {
                X = 2.0
                Y = "1"
                Value = 463.0
                RectText = 463.0
                Description = "day by day, situation is getting worse in Alaska"
            }
            {
                X = 3.0
                Y = "2"
                Value = 480.0
                RectText = 480.0
                Description = "same story, today also air quality decreases. a bad day in Texas"
            }
            {
                X = 2.0
                Y = "3"
                Value = 491.0
                RectText = 491.0
                Description = "Day by day, 100 units are increasing in air quality"
            }
            {
                X = 1.0
                Y = "4"
                Value = 433.0
                RectText = 433.0
                Description =
                    "They say good things stay for a short time, today this saying became reality. New York has witnessed nearly 300% bad air quality"
            }
            {
                X = 5.0
                Y = "4"
                Value = 473.0
                RectText = 473.0
                Description = "Today is the same fate as the 2nd day. still, air quality stays above 400"
            }
        ]
    }
    {
        Name = "Very Danger (501-600)"
        Value = 550.0
        Data = [
            {
                X = 5.0
                Y = "0"
                Value = 600.0
                RectText = 600.0
                Description = "looks like god has cursed us with poisonous air. worst air quality index"
            }
            {
                X = 5.0
                Y = "1"
                Value = 536.0
                RectText = 536.0
                Description =
                    "shh!, all the hopes were washed away in the rain yesterday, with another hike of 400% in air quality"
            }
            {
                X = 3.0
                Y = "1"
                Value = 520.0
                RectText = 520.0
                Description = "Alaska planning to build air purifier to control the air quality"
            }
            {
                X = 4.0
                Y = "2"
                Value = 525.0
                RectText = 525.0
                Description = "air worsens badly today due to farmers burning the harvest"
            }
            {
                X = 6.0
                Y = "3"
                Value = 560.0
                RectText = 560.0
                Description =
                    "Due to industrial pollution and the burning of harvest, it resulted in bad air quality in Washington DC"
            }
            {
                X = 3.0
                Y = "4"
                Value = 580.0
                RectText = 580.0
                Description =
                    "Air quality index is becoming worse day by day, leaving the people of NYC in very bad medical conditions."
            }
            {
                X = 6.0
                Y = "4"
                Value = 590.0
                RectText = 590.0
                Description = "finally, the weekend ends with very bad air quality in New York City"
            }
        ]
    }
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
        chartProp.chartTitle "one"
        chartProp.chartData [
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
        chartProp.chartTitle "two"
        chartProp.chartData [
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
        chartProp.chartTitle "three"
        chartProp.chartData [
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

[<ReactComponent>]
let TestChartsComponent () =
    let sliderValue, setSliderValue = React.useState 50
    Html.div [
        prop.style [ style.width 600; style.margin 36 ]
        prop.children [
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
                    legendProp.allowFocusOnLegends true
                    legendProp.canSelectMultipleLegends true
                    legendProp.centerLegends true
                ]
                areaChart.data [
                    chartProp.chartTitle "Areachart"
                    chartProp.lineChartData [
                        yield! areaChartDataList
                    ]
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
                    chartProp.chartTitle "Pai sjart"
                    chartProp.chartData [
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
                    legendProp.canSelectMultipleLegends true
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
        ]
    ]

                            //         Charts.verticalStackedBarChart [
                            //             verticalStackedBarChart.styles [ styles.barLabel "" ]
                            //             verticalStackedBarChart.chartTitle "stacked title"
                            //             verticalStackedBarChart.data [
                            //                 Charts.verticalStackedBarChartProps [
                            //                     verticalStackBarChartProps.xAxisPoint 2
                            //                     verticalStackBarChartProps.chartData [
                            //                         Charts.vsChartDataPoint [
                            //                             VSChartDataPoint.data 40
                            //                             VSChartDataPoint.legend "Metadata1"
                            //                             VSChartDataPoint.color
                            //                                 Theme.tokens.colorStatusWarningForeground1
                            //                         ]
                            //                         Charts.vsChartDataPoint [
                            //                             VSChartDataPoint.data 4
                            //                             VSChartDataPoint.legend "Metadata2"
                            //                             VSChartDataPoint.color
                            //                                 Theme.tokens.colorPalettePlatinumForeground2
                            //                         ]
                            //                     ]
                            //                     verticalStackBarChartProps.lineData [
                            //                         Charts.lineDataInVerticalStackedBarChart [
                            //                             lineDataInVerticalStackedBarChart.y 25
                            //                             lineDataInVerticalStackedBarChart.legend "Supported"
                            //                         ]
                            //                     ]
                            //                 ]
                            //                 Charts.verticalStackedBarChartProps [
                            //                     verticalStackBarChartProps.xAxisPoint 3
                            //                     verticalStackBarChartProps.chartData [
                            //                         Charts.vsChartDataPoint [
                            //                             VSChartDataPoint.data 30
                            //                             VSChartDataPoint.color Theme.tokens.colorBrandBackground2
                            //                             VSChartDataPoint.legend "Metadata5"
                            //                         ]
                            //                         Charts.vsChartDataPoint [
                            //                             VSChartDataPoint.data 20
                            //                             VSChartDataPoint.legend "Metadata6"
                            //                             VSChartDataPoint.color Theme.tokens.colorBrandForegroundInverted
                            //                         ]
                            //                     ]
                            //                     verticalStackBarChartProps.lineData [
                            //                         Charts.lineDataInVerticalStackedBarChart [
                            //                             lineDataInVerticalStackedBarChart.y 21
                            //                             lineDataInVerticalStackedBarChart.color
                            //                                 Theme.tokens.colorPalettePurpleBorderActive
                            //                             lineDataInVerticalStackedBarChart.legend "Supported"
                            //                         ]
                            //                     ]
                            //                 ]
                            //                 Charts.verticalStackedBarChartProps [
                            //                     verticalStackBarChartProps.xAxisPoint 4
                            //                     verticalStackBarChartProps.chartData [
                            //                         Charts.vsChartDataPoint [
                            //                             VSChartDataPoint.data 30
                            //                             VSChartDataPoint.color
                            //                                 Theme.tokens.colorStatusSuccessBackground3
                            //                             VSChartDataPoint.legend "Metadata3"
                            //                         ]
                            //                         Charts.vsChartDataPoint [
                            //                             VSChartDataPoint.data 20
                            //                             VSChartDataPoint.legend "Metadata4"
                            //                             VSChartDataPoint.color
                            //                                 Theme.tokens.colorStatusWarningBackground3
                            //                         ]
                            //                     ]
                            //                     verticalStackBarChartProps.lineData [
                            //                         Charts.lineDataInVerticalStackedBarChart [
                            //                             lineDataInVerticalStackedBarChart.lineOptions [
                            //                                 lineChartLineOptions.lineBorderColor "red"
                            //                             ]
                            //                             lineDataInVerticalStackedBarChart.y 35
                            //                             lineDataInVerticalStackedBarChart.color
                            //                                 Theme.tokens.colorPalettePurpleBorderActive
                            //                             lineDataInVerticalStackedBarChart.legend "Supported"

                            //                         ]
                            //                     ]
                            //                 ]
                            //             ]
                            //             verticalStackedBarChart.height 200
                            //             verticalStackedBarChart.width 350
                            //             verticalStackedBarChart.lineOptions [
                            //                 lineChartLineOptions.strokeWidth 2.0
                            //                 lineChartLineOptions.strokeLinecap.square
                            //                 lineChartLineOptions.lineBorderWidth 2
                            //             ]
                            //             verticalStackedBarChart.hideLabels true
                            //             verticalStackedBarChart.roundCorners false
                            //             verticalStackedBarChart.roundedTicks true
                            //         ]
                            //     ]
                            // ]


                            // Charts.verticalBarChart [
                            //     verticalBarChart.chartTitle "vertical normal"
                            //     verticalBarChart.enableGradient true
                            //     verticalBarChart.data [
                            //         Charts.verticalBarChartDataProp [
                            //             verticalBarChartDataPoint.x 8.
                            //             verticalBarChartDataPoint.y 2
                            //             verticalBarChartDataPoint.legend "legend"
                            //         ]
                            //         Charts.verticalBarChartDataProp [
                            //             verticalBarChartDataPoint.x 5.
                            //             verticalBarChartDataPoint.y 7
                            //             verticalBarChartDataPoint.legend "legend2"
                            //         ]
                            //         Charts.verticalBarChartDataProp [
                            //             verticalBarChartDataPoint.x 7.
                            //             verticalBarChartDataPoint.y 4
                            //             verticalBarChartDataPoint.legend "legend3"
                            //         ]
                            //         Charts.verticalBarChartDataProp [
                            //             verticalBarChartDataPoint.x 4.
                            //             verticalBarChartDataPoint.y 15
                            //             verticalBarChartDataPoint.color "red"
                            //             verticalBarChartDataPoint.legend "legend4"
                            //         ]
                            //         Charts.verticalBarChartDataProp [
                            //             verticalBarChartDataPoint.x 4.
                            //             verticalBarChartDataPoint.y 13
                            //             verticalBarChartDataPoint.color "purple"
                            //             verticalBarChartDataPoint.legend "legend5"
                            //         ]
                            //     ]
                            // ]

                            // Html.div [
                            //     prop.style [
                            //         style.display.flex
                            //         style.gap 10
                            //     ]
                            //     prop.children [
                            //         Charts.sparkLine [
                            //             sparkline.height 200
                            //             sparkline.width 250
                            //             sparkline.showLegend true
                            //             sparkline.data [
                            //                 chartProps.chartTitle "sparkline 34"
                            //                 chartProps.lineChartData (
                            //                     lineChartDataList
                            //                     |> List.map (fun d ->
                            //                         Charts.lineChartData [
                            //                             lineChartData.legendShape.triangle
                            //                             lineChartData.opacity d.Opacity
                            //                             lineChartData.color d.Color
                            //                             lineChartData.data [
                            //                                 yield!
                            //                                     d.Data
                            //                                     |> List.map (fun dd ->
                            //                                         Charts.lineChartDataPoint [
                            //                                             lineChartDataPoint.x dd.x
                            //                                             lineChartDataPoint.y dd.y
                            //                                         ])
                            //                             ]
                            //                         ])
                            //                 )
                            //             ]
                            //         ]
                            //         Charts.sparkLine [
                            //             sparkline.height 200
                            //             sparkline.width 250
                            //             sparkline.showLegend true
                            //             sparkline.data [
                            //                 chartProps.chartTitle "sparkline 34"
                            //                 chartProps.lineChartData (
                            //                     lineChartDataList
                            //                     |> List.map (fun d ->
                            //                         Charts.lineChartData [
                            //                             lineChartData.legendShape.triangle
                            //                             lineChartData.opacity d.Opacity
                            //                             lineChartData.color Theme.tokens.colorStatusSuccessBackground3
                            //                             lineChartData.data [
                            //                                 yield!
                            //                                     d.Data
                            //                                     |> List.map (fun dd ->
                            //                                         Charts.lineChartDataPoint [
                            //                                             lineChartDataPoint.x dd.x
                            //                                             lineChartDataPoint.y dd.y
                            //                                         ])
                            //                             ]
                            //                         ])
                            //                 )
                            //             ]
                            //         ]
                            //         Charts.sparkLine [
                            //             sparkline.height 200
                            //             sparkline.width 250
                            //             sparkline.showLegend true
                            //             sparkline.data [
                            //                 chartProps.chartTitle "sparkline title123"
                            //                 chartProps.lineChartData (
                            //                     lineChartDataList
                            //                     |> List.map (fun d ->
                            //                         Charts.lineChartData [
                            //                             lineChartData.legendShape.triangle
                            //                             lineChartData.opacity d.Opacity
                            //                             lineChartData.color Theme.tokens.colorBrandBackground2Pressed
                            //                             lineChartData.data [
                            //                                 yield!
                            //                                     d.Data
                            //                                     |> List.map (fun dd ->
                            //                                         Charts.lineChartDataPoint [
                            //                                             lineChartDataPoint.x dd.x
                            //                                             lineChartDataPoint.y dd.y
                            //                                         ])
                            //                             ]
                            //                         ])
                            //                 )
                            //             ]
                            //         ]
                            //     ]
                            // ]
                            // Html.div [
                            //     prop.style [ style.marginBottom 50 ]
                            //     prop.children [
                            //         Html.div [
                            //             prop.children [
                                            // Charts.sankeyChart [
                                            //     sankeyChart.data [
                                            //         chartProps.chartTitle "Sankey title"
                                            //         chartProps.sankeyChartData [
                                            //             sankeyChartPoint.nodes [
                                            //                 Charts.sankeyChartSNode [
                                            //                     sNode.nodeId 0
                                            //                     sNode.name "node0"
                                            //                     sNode.color "red"
                                            //                 ]
                                            //                 Charts.sankeyChartSNode [
                                            //                     sNode.nodeId 1
                                            //                     sNode.name "node1"
                                            //                     sNode.color "blue"
                                            //                 ]
                                            //                 Charts.sankeyChartSNode [
                                            //                     sNode.nodeId 2
                                            //                     sNode.name "node2"
                                            //                     sNode.color "green"
                                            //                 ]
                                            //                 Charts.sankeyChartSNode [
                                            //                     sNode.nodeId 3
                                            //                     sNode.name "node3"
                                            //                     sNode.color "orange"
                                            //                 ]
                                            //                 Charts.sankeyChartSNode [
                                            //                     sNode.nodeId 4
                                            //                     sNode.name "node4"
                                            //                     sNode.color "yellow"
                                            //                 ]
                                            //                 Charts.sankeyChartSNode [
                                            //                     sNode.nodeId 5
                                            //                     sNode.name "node5"
                                            //                     sNode.color "pink"
                                            //                 ]
                                            //             ]
                                            //             sankeyChartPoint.links [
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 0
                                            //                     sLink.target 2
                                            //                     sLink.value 2
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 1
                                            //                     sLink.target 2
                                            //                     sLink.value 2
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 1
                                            //                     sLink.target 3
                                            //                     sLink.value 2
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 0
                                            //                     sLink.target 4
                                            //                     sLink.value 2
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 2
                                            //                     sLink.target 3
                                            //                     sLink.value 2
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 2
                                            //                     sLink.target 4
                                            //                     sLink.value 2
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 3
                                            //                     sLink.target 4
                                            //                     sLink.value 4
                                            //                 ]
                                            //                 Charts.sankeyChartSLink [
                                            //                     sLink.source 3
                                            //                     sLink.target 5
                                            //                     sLink.value 4
                                            //                 ]
                                            //             ]
                                            //         ]
                                            //     ]
                                            // ]
                                    // Charts.scatterChart [
                                    //     scatterChart.data [
                                    //         chartProps.scatterChartData [
                                    //             Charts.scatterChartData [
                                    //                 scatterChartPoint.legend "Testing"
                                    //                 scatterChartPoint.legendShape.hexagon
                                    //                 scatterChartPoint.data [
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 1
                                    //                         scatterChartDataPoint.y 2
                                    //                         scatterChartDataPoint.markerSize 3
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 2
                                    //                         scatterChartDataPoint.y 6
                                    //                         scatterChartDataPoint.markerSize 1
                                    //                         scatterChartDataPoint.text "testPoint"
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 3
                                    //                         scatterChartDataPoint.y 7
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 4
                                    //                         scatterChartDataPoint.y 5
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 5
                                    //                         scatterChartDataPoint.y 11
                                    //                     ]
                                    //                 ]
                                    //             ]
                                    //             Charts.scatterChartData [
                                    //                 scatterChartPoint.legend "Other"
                                    //                 scatterChartPoint.color "green"
                                    //                 scatterChartPoint.legendShape.pyramid
                                    //                 scatterChartPoint.data [
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 1
                                    //                         scatterChartDataPoint.y 5
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 12
                                    //                         scatterChartDataPoint.y 23
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 10
                                    //                         scatterChartDataPoint.y 7
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 14
                                    //                         scatterChartDataPoint.y 5
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.text "max point"
                                    //                         scatterChartDataPoint.x 17
                                    //                         scatterChartDataPoint.y 11
                                    //                     ]
                                    //                 ]
                                    //             ]
                                    //             Charts.scatterChartData [
                                    //                 scatterChartPoint.legend "Performance A"
                                    //                 scatterChartPoint.color "magenta"
                                    //                 scatterChartPoint.legendShape.pentagon
                                    //                 scatterChartPoint.data [
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 1
                                    //                         scatterChartDataPoint.y 1
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 2
                                    //                         scatterChartDataPoint.y 4
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 3
                                    //                         scatterChartDataPoint.y 9
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 4
                                    //                         scatterChartDataPoint.y 16
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 5
                                    //                         scatterChartDataPoint.y 25
                                    //                         scatterChartDataPoint.text "peak"
                                    //                     ]
                                    //                 ]
                                    //             ]
                                    //             Charts.scatterChartData [
                                    //                 scatterChartPoint.legend "Performance B"
                                    //                 scatterChartPoint.color "orange"
                                    //                 scatterChartPoint.legendShape.pentagon
                                    //                 scatterChartPoint.data [
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 1
                                    //                         scatterChartDataPoint.y 2
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 2
                                    //                         scatterChartDataPoint.y 3.5
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 3
                                    //                         scatterChartDataPoint.y 5.2
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 4
                                    //                         scatterChartDataPoint.y 6.1
                                    //                     ]
                                    //                     Charts.scatterChartDataPoint [
                                    //                         scatterChartDataPoint.x 5
                                    //                         scatterChartDataPoint.y 7.3
                                    //                         scatterChartDataPoint.text "stable growth"
                                    //                     ]
                                    //                 ]
                                    //             ]
                                    //         ]
                                    //     ]
                                    // ]
                                    // Charts.gaugeChart [
                                    //     gaugeChart.enableGradient true
                                    //     gaugeChart.chartValue 67.7
                                    //     gaugeChart.variant.multipleSegment
                                    //     gaugeChart.segments [
                                    //         Charts.gaugeChartSegment [
                                    //             gaugeChartSegment.legend "test1"
                                    //             gaugeChartSegment.color "green"
                                    //             gaugeChartSegment.size 50
                                    //         ]
                                    //         Charts.gaugeChartSegment [
                                    //             gaugeChartSegment.legend "test2"
                                    //             gaugeChartSegment.color "blue"
                                    //             gaugeChartSegment.size 10
                                    //         ]
                                    //         Charts.gaugeChartSegment [
                                    //             gaugeChartSegment.legend "test3"
                                    //             gaugeChartSegment.color "red"
                                    //             gaugeChartSegment.size 40
                                    //         ]
                                    //     ]

                                    // ]
                            //         ]
                            //     ]
                            // ]
                            // Charts.donutChart [
                            //     donutChart.data [
                            //         chartProps.chartTitle "Pai sjart"
                            //         chartProps.chartData [
                            //             Charts.chartData [
                            //                 chartDataPoint.legend "test"
                            //                 chartDataPoint.color "green"
                            //                 chartDataPoint.data 65.
                            //             ]
                            //             Charts.chartData [
                            //                 chartDataPoint.legend "test2"
                            //                 chartDataPoint.color "blue"
                            //                 chartDataPoint.data 35.
                            //             ]
                            //         ]
                            //     ]
                            // ]
                            // Charts.lineChart [
                            //     lineChart.legendProps [
                            //         legendProps.centerLegends true
                            //         legendProps.canSelectMultipleLegends true
                            //     ]
                            //     lineChart.customDateTimeFormatter (fun dt -> "")
                            //     lineChart.height 200
                            //     lineChart.width 250
                            //     lineChart.styles [ lineChartStyles.lineBorder "" ]
                            //     lineChart.data [
                            //         chartProps.chartTitle "Linechart"
                            //         chartProps.lineChartData (
                            //             lineChartDataList
                            //             |> List.map (fun d ->
                            //                 Charts.lineChartData [
                            //                     lineChartData.legendShape.triangle
                            //                     lineChartData.opacity d.Opacity
                            //                     lineChartData.legend d.Name
                            //                     lineChartData.color d.Color
                            //                     lineChartData.data [
                            //                         yield!
                            //                             d.Data
                            //                             |> List.map (fun dd ->
                            //                                 Charts.lineChartDataPoint [
                            //                                     lineChartDataPoint.x dd.x
                            //                                     lineChartDataPoint.y dd.y
                            //                                 ])
                            //                     ]
                            //                 ])
                            //         )
                            //     ]
                            // ]
    //                 ]
    //             ]
    //         ]
    //     ]
    // ]
