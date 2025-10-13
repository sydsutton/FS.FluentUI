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

type GanttChartData = {
    Name: string
    Y: string
    X: {| start: DateTime; end': DateTime |}
}

let ganttChartDataList = [
    {
        Name = "Project Planning"
        Y = "Phase 1"
        X = {|
            start = DateTime(2024, 1, 15)
            end' = DateTime(2024, 2, 15)
        |}
    }
    {
        Name = "Requirements Analysis"
        Y = "Phase 1"
        X = {|
            start = DateTime(2024, 2, 1)
            end' = DateTime(2024, 2, 28)
        |}
    }
    {
        Name = "System Design"
        Y = "Phase 2"
        X = {|
            start = DateTime(2024, 2, 20)
            end' = DateTime(2024, 3, 20)
        |}
    }
    {
        Name = "Database Setup"
        Y = "Phase 2"
        X = {|
            start = DateTime(2024, 3, 1)
            end' = DateTime(2024, 3, 15)
        |}
    }
    {
        Name = "Frontend Development"
        Y = "Phase 3"
        X = {|
            start = DateTime(2024, 3, 10)
            end' = DateTime(2024, 5, 15)
        |}
    }
    {
        Name = "Backend Development"
        Y = "Phase 3"
        X = {|
            start = DateTime(2024, 3, 15)
            end' = DateTime(2024, 5, 30)
        |}
    }
    {
        Name = "Testing & QA"
        Y = "Phase 4"
        X = {|
            start = DateTime(2024, 5, 1)
            end' = DateTime(2024, 6, 15)
        |}
    }
    {
        Name = "Deployment & Launch"
        Y = "Phase 4"
        X = {|
            start = DateTime(2024, 6, 10)
            end' = DateTime(2024, 6, 30)
        |}
    }
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


type ChartTableDataCell = {
    Color: string option
    FontSize: int option
    BorderColor: string option
    Height: int option
    Value: float
}

type ChartTableData = {
    Header: string
    Data: ChartTableDataCell list
}

let chartTableDataList: ChartTableData list = [
    {
        Header = "Quarter"
        Data = [
            {
                Color = Some "#2563eb"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 1.0
            }
            {
                Color = Some "#2563eb"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 2.0
            }
            {
                Color = Some "#2563eb"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 3.0
            }
            {
                Color = Some "#2563eb"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 4.0
            }
        ]
    }
    {
        Header = "Revenue (M)"
        Data = [
            {
                Color = Some "#16a34a"
                FontSize = Some 16
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 145.7
            }
            {
                Color = Some "#dc2626"
                FontSize = Some 16
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 132.4
            }
            {
                Color = Some "#16a34a"
                FontSize = Some 16
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 168.9
            }
            {
                Color = Some "#16a34a"
                FontSize = Some 16
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 189.2
            }
        ]
    }
    {
        Header = "Growth %"
        Data = [
            {
                Color = Some "#059669"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 12.3
            }
            {
                Color = Some "#dc2626"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = -9.1
            }
            {
                Color = Some "#059669"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 27.6
            }
            {
                Color = Some "#059669"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 12.0
            }
        ]
    }
    {
        Header = "Customers"
        Data = [
            {
                Color = Some "#7c3aed"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 8450.0
            }
            {
                Color = Some "#7c3aed"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 8720.0
            }
            {
                Color = Some "#7c3aed"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 9180.0
            }
            {
                Color = Some "#7c3aed"
                FontSize = Some 14
                BorderColor = Some "#e5e7eb"
                Height = Some 32
                Value = 9650.0
            }
        ]
    }
]



[<ReactComponent>]
let TestChartsComponent () =
    Fui.areaChart [
        areaChart.mode.tonexty
        areaChart.height 300
        areaChart.width 600
        areaChart.legendsOverflowText "Overflow Items"
        areaChart.yAxisTickFormat (fun (s:string) -> $"${s}")
        areaChart.svgProps [ prop.ariaLabel "This is another test?!"]
        areaChart.enableGradient true
        areaChart.enablePerfOptimization true
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
                                    // Charts.chartTable [
                                    //     chartTable.height 250
                                    //     chartTable.headers (
                                    //         chartTableDataList
                                    //         |> List.map (fun d ->
                                    //             Charts.ChartTableData [
                                    //                 chartTableData.value d.Header
                                    //                 chartTableData.style [ style.height 10 ]
                                    //             ])
                                    //     )
                                    //     chartTable.rows [
                                    //         yield!
                                    //             chartTableDataList
                                    //             |> List.map (fun d ->
                                    //                 d.Data
                                    //                 |> List.map (fun dd ->
                                    //                     Charts.ChartTableData [
                                    //                         chartTableData.style [
                                    //                             match dd.Color with
                                    //                             | Some c -> style.color c
                                    //                             | _ -> ()
                                    //                             match dd.FontSize with
                                    //                             | Some c -> style.fontSize c
                                    //                             | _ -> ()
                                    //                             match dd.BorderColor with
                                    //                             | Some c -> style.borderColor c
                                    //                             | _ -> ()
                                    //                             match dd.Height with
                                    //                             | Some c -> style.height 12
                                    //                             | _ -> ()
                                    //                         ]
                                    //                         chartTableData.value dd.Value
                                    //                     ]))
                                    //     ]
                                    // ]

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
                            // Charts.horizontalBarChartWithAxis [
                            //     horizontalBarChartWithAxis.chartTitle "title"
                            //     horizontalBarChartWithAxis.data [
                            //         Charts.horizontalBarWithAxisChartDataProp [
                            //             horizontalBarChartWithAxisDataPoint.legend "test"
                            //             horizontalBarChartWithAxisDataPoint.color "orange"
                            //             horizontalBarChartWithAxisDataPoint.x 10
                            //             horizontalBarChartWithAxisDataPoint.y 2
                            //         ]
                            //         Charts.horizontalBarWithAxisChartDataProp [
                            //             horizontalBarChartWithAxisDataPoint.legend "test2"
                            //             horizontalBarChartWithAxisDataPoint.color "green"
                            //             horizontalBarChartWithAxisDataPoint.x 13
                            //             horizontalBarChartWithAxisDataPoint.y 5
                            //         ]
                            //     ]
                            // ]
                            // Charts.horizontalBarChart [
                            //     horizontalBarChart.chartDataMode.percentage
                            //     horizontalBarChart.variant.AbsoluteScale
                            //     horizontalBarChart.styles [ styles.root "" ]
                            //     horizontalBarChart.color "green"
                            //     horizontalBarChart.data [
                            //         Charts.horizontalBarChartDataProp [
                            //             chartProps.chartTitle "testing"
                            //             chartProps.chartData [
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "test"
                            //                     chartDataPoint.color "purple"
                            //                     chartDataPoint.horizontalBarChartdata [
                            //                         horizontalDataPoint.x 7.
                            //                         horizontalDataPoint.total 11.
                            //                     ]
                            //                 ]
                            //             ]
                            //         ]
                            //         Charts.horizontalBarChartDataProp [
                            //             chartProps.chartTitle "test"
                            //             chartProps.chartData [
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "test"
                            //                     chartDataPoint.color "red"
                            //                     chartDataPoint.horizontalBarChartdata [ horizontalDataPoint.x 10. ]
                            //                 ]
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "moreTest"
                            //                     chartDataPoint.color "blue"
                            //                     chartDataPoint.horizontalBarChartdata [ horizontalDataPoint.x 2. ]
                            //                 ]
                            //             ]
                            //         ]
                            //         Charts.horizontalBarChartDataProp [
                            //             chartProps.chartTitle "test3"
                            //             chartProps.chartData [
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "moreTests"
                            //                     chartDataPoint.color "yellow"
                            //                     chartDataPoint.horizontalBarChartdata [ horizontalDataPoint.x 10. ]
                            //                 ]
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "evenMoreTest"
                            //                     chartDataPoint.color "green"
                            //                     chartDataPoint.horizontalBarChartdata [ horizontalDataPoint.x 2. ]
                            //                 ]
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "evenevenMoreTest"
                            //                     chartDataPoint.color "purple"
                            //                     chartDataPoint.horizontalBarChartdata [ horizontalDataPoint.x 15 ]
                            //                 ]
                            //                 Charts.chartData [
                            //                     chartDataPoint.legend "evenevenMoreTest"
                            //                     chartDataPoint.color "orange"
                            //                     chartDataPoint.horizontalBarChartdata [ horizontalDataPoint.x 3 ]
                            //                 ]
                            //             ]
                            //         ]
                            //     ]
                            // ]

                            // Charts.groupedVerticalBarChart [
                            //     groupedVerticalBarChart.chartTitle "sd"
                            //     groupedVerticalBarChart.colors [
                            //         "red"
                            //         "green"
                            //         "blue"
                            //         "gray"
                            //         "cyan"
                            //     ]
                            //     groupedVerticalBarChart.data [
                            //         Charts.groupedVerticalBarChartData [
                            //             groupedVerticalBarChartData.name "Testing"
                            //             groupedVerticalBarChartData.series [
                            //                 Charts.groupedVerticalBarChartDataPoint [
                            //                     GVBarChartSeriesPoint.key "key1"
                            //                     GVBarChartSeriesPoint.data 4.0
                            //                     // GVBarChartSeriesPoint.color "red"
                            //                     GVBarChartSeriesPoint.legend "redValue"
                            //                 ]
                            //                 Charts.groupedVerticalBarChartDataPoint [

                            //                     GVBarChartSeriesPoint.key "key1"
                            //                     GVBarChartSeriesPoint.data 4.0
                            //                     // GVBarChartSeriesPoint.color "red"
                            //                     GVBarChartSeriesPoint.legend "redValue"
                            //                 ]
                            //                 Charts.groupedVerticalBarChartDataPoint [
                            //                     GVBarChartSeriesPoint.key "key2"
                            //                     GVBarChartSeriesPoint.data 3.0
                            //                     // GVBarChartSeriesPoint.color "blue"
                            //                     GVBarChartSeriesPoint.legend "blueValue"
                            //                 ]
                            //                 Charts.groupedVerticalBarChartDataPoint [
                            //                     GVBarChartSeriesPoint.key "key3"
                            //                     GVBarChartSeriesPoint.data 5.6
                            //                     // GVBarChartSeriesPoint.color "green"
                            //                     GVBarChartSeriesPoint.legend "greenValue"
                            //                 ]
                            //             ]
                            //         ]
                            //         Charts.groupedVerticalBarChartData [
                            //             groupedVerticalBarChartData.name "Ship it"
                            //             groupedVerticalBarChartData.series [
                            //                 Charts.groupedVerticalBarChartDataPoint [
                            //                     GVBarChartSeriesPoint.key "key1"
                            //                     GVBarChartSeriesPoint.data 7.7
                            //                     // GVBarChartSeriesPoint.color "purple"
                            //                     GVBarChartSeriesPoint.legend "purpleValue"
                            //                 ]
                            //                 Charts.groupedVerticalBarChartDataPoint [
                            //                     GVBarChartSeriesPoint.key "key2"
                            //                     GVBarChartSeriesPoint.data 3.3
                            //                     // GVBarChartSeriesPoint.color "yellow"
                            //                     GVBarChartSeriesPoint.legend "yellowValue"
                            //                 ]
                            //                 Charts.groupedVerticalBarChartDataPoint [
                            //                     GVBarChartSeriesPoint.key "key3"
                            //                     GVBarChartSeriesPoint.data 4.45
                            //                     // GVBarChartSeriesPoint.color "orange"
                            //                     GVBarChartSeriesPoint.legend "orangeValue"
                            //                 ]
                            //             ]
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

                                    //         Charts.heatMapChart [
                                    //             heatMapChart.legendProps [
                                    //                 // TODO validate legends work
                                    //                 legendProps.legends [
                                    //                     Charts.legend [
                                    //                         legend.color "red"
                                    //                         legend.title "TestLegend"
                                    //                         legend.shape.triangle
                                    //                     ]
                                    //                 ]
                                    //             ]
                                    //             heatMapChart.sortOrder.none
                                    //             heatMapChart.chartTitle "Air Quality Heatmap"
                                    //             heatMapChart.domainValuesForColorScale [
                                    //                 0
                                    //                 200
                                    //                 400
                                    //                 600
                                    //             ]
                                    //             heatMapChart.rangeValuesForColorScale [
                                    //                 "#00FF00" // Bright green for excellent
                                    //                 "#FFD700" // Golden yellow for good
                                    //                 "#FF8C00" // Dark orange for medium
                                    //                 "#FF0000" // Red for danger
                                    //                 "#8B0000" // Dark red for very dangerous
                                    //             ]
                                    //             heatMapChart.data [
                                    //                 yield!
                                    //                     heatMapDataPointsList
                                    //                     |> List.map (fun d ->
                                    //                         Charts.heatMapChartData [
                                    //                             heatMapChartData.legend d.Name
                                    //                             heatMapChartData.value d.Value
                                    //                             heatMapChartData.data [
                                    //                                 yield!
                                    //                                     d.Data
                                    //                                     |> List.map (fun dd ->
                                    //                                         Charts.heatMapChartDatapoint [
                                    //                                             heatMapChartDataPoint.x dd.X
                                    //                                             heatMapChartDataPoint.y dd.Y
                                    //                                             heatMapChartDataPoint.value dd.Value
                                    //                                             heatMapChartDataPoint.rectText
                                    //                                                 dd.RectText
                                    //                                             heatMapChartDataPoint.descriptionMessage
                                    //                                                 dd.Description
                                    //                                         ])
                                    //                             ]
                                    //                         ])
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
                                    // Charts.ganttChart [
                                    //     ganttChart.chartTitle "Testing gant"
                                    //     ganttChart.data [
                                    //         yield!
                                    //             ganttChartDataList
                                    //             |> List.map (fun d ->
                                    //                 Charts.ganttChartDataPoint [
                                    //                     ganttChartDataPoint.legend d.Name
                                    //                     ganttChartDataPoint.x d.X
                                    //                     ganttChartDataPoint.y d.Y
                                    //                 ])

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
                            //         Charts.funnelChart [
                            //             funnelChart.width 750
                            //             funnelChart.chartTitle "Funnel chart"
                            //             funnelChart.orientation.horizontal
                            //             funnelChart.data [
                            //                 Charts.funnelChartData [
                            //                     funnelChartDataPoint.value 1000
                            //                     funnelChartDataPoint.color "#13a10e"
                            //                     funnelChartDataPoint.stage "visitor"
                            //                     funnelChartDataPoint.subValues [
                            //                         {|
                            //                             category = ""
                            //                             value = 1.
                            //                             color = ""
                            //                         |}
                            //                         {|
                            //                             category = ""
                            //                             value = 1.
                            //                             color = ""
                            //                         |}
                            //                         {|
                            //                             category = ""
                            //                             value = 1.
                            //                             color = ""
                            //                         |}
                            //                         {|
                            //                             category = ""
                            //                             value = 1.
                            //                             color = ""
                            //                         |}
                            //                     ]
                            //                 ]
                            //                 Charts.funnelChartData [
                            //                     funnelChartDataPoint.value 600
                            //                     funnelChartDataPoint.color "#3a96dd"
                            //                     funnelChartDataPoint.stage "Signups"
                            //                 ]
                            //                 Charts.funnelChartData [
                            //                     funnelChartDataPoint.value 300
                            //                     funnelChartDataPoint.color "#ca5010"
                            //                     funnelChartDataPoint.stage "Trials"
                            //                 ]
                            //                 Charts.funnelChartData [
                            //                     funnelChartDataPoint.value 250
                            //                     funnelChartDataPoint.color "#ae8c00"
                            //                     funnelChartDataPoint.stage "Customers"
                            //                 ]
                            //             ]
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
