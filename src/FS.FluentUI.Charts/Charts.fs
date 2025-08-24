namespace FS.Charts

open Fable.React
open Fable.Core
open Fable.Core.JsInterop

module Helpers =
    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement =
        reactElement el (!!props |> createObj)

    [<Import("LineChart", "@fluentui/react-charts")>]
    let LineChart: ReactElementType = jsNative

    [<Import("AreaChart", "@fluentui/react-charts")>]
    let AreaChart: ReactElementType = jsNative

    [<Import("DonutChart", "@fluentui/react-charts")>]
    let DonutChart: ReactElementType = jsNative

    [<Import("FunnelChart", "@fluentui/react-charts")>]
    let FunnelChart: ReactElementType = jsNative

    [<Import("GaugeChart", "@fluentui/react-charts")>]
    let GaugeChart: ReactElementType = jsNative

    [<Import("GanttChart", "@fluentui/react-charts")>]
    let GanttChart: ReactElementType = jsNative

    [<Import("ScatterChart", "@fluentui/react-charts")>]
    let ScatterChart: ReactElementType = jsNative

    [<Import("HeatMapChart", "@fluentui/react-charts")>]
    let HeatMapChart: ReactElementType = jsNative

    [<Import("SankeyChart", "@fluentui/react-charts")>]
    let SankeyChart: ReactElementType = jsNative

    [<Import("Sparkline", "@fluentui/react-charts")>]
    let Sparkline: ReactElementType = jsNative

    [<Import("GroupedVerticalBarChart", "@fluentui/react-charts")>]
    let GroupedVerticalBarChart: ReactElementType = jsNative

    [<Import("HorizontalBarChart", "@fluentui/react-charts")>]
    let HorizontalBarChart: ReactElementType = jsNative

    [<Import("HorizontalBarChartWithAxis", "@fluentui/react-charts")>]
    let HorizontalBarChartWithAxis: ReactElementType = jsNative

    [<Import("VerticalBarChart", "@fluentui/react-charts")>]
    let VerticalBarChart: ReactElementType = jsNative

    [<Import("VerticalStackedBarChart", "@fluentui/react-charts")>]
    let VerticalStackedBarChart: ReactElementType = jsNative

    [<Import("ChartTable", "@fluentui/react-charts")>]
    let ChartTable: ReactElementType = jsNative

type Charts =
    static member inline lineChart(props: ILineChartProps list) =
        Helpers.createElement Helpers.LineChart props

    static member inline lineChartData(props: ILineChartDataProp list) = !! createObj props
    static member inline lineChartDataPoint(props: ILineChartDataPoint list) = !! createObj props


    static member inline areaChart(props: IAreaChartProp list) =
        Helpers.createElement Helpers.AreaChart props

    static member inline donutChart(props: IDonutChartProps list) =
        Helpers.createElement Helpers.DonutChart props

    static member inline chartData(props: IChartDataPoint list) = !! createObj props

    static member inline funnelChart(props: IFunnelChartProps list) =
        Helpers.createElement Helpers.FunnelChart props

    static member inline funnelChartData(props: IFunnelChartDataPoint list) = !! createObj props

    static member inline gaugeChart(props: IGaugeChartProps list) =
        Helpers.createElement Helpers.GaugeChart props

    static member inline gaugeChartSegment(props: IGaugeChartSegment list) = !! createObj props

    static member inline ganttChart(props: IGanttChartProps list) =
        Helpers.createElement Helpers.GanttChart props

    static member inline ganttChartDataPoint(props: IGanttChartDataPoint list) = !! createObj props

    static member inline scatterChart(props: IScatterChartProps list) =
        Helpers.createElement Helpers.ScatterChart props

    static member inline scatterChartData(props: IScatterChartPoints list) = !! createObj props

    static member inline scatterChartDataPoint(props: IScatterChartDataPoint list) = !! createObj props

    static member inline heatMapChart(props: IHeatMapChartProps list) =
        Helpers.createElement Helpers.HeatMapChart props

    static member inline heatMapChartData(props: IHeatMapChartData list) = !! createObj props

    static member inline heatMapChartDatapoint(props: IHeatMapChartDataPointProp list) = !! createObj props

    static member sankeyChart(props: ISankeyChartProps list) =
        Helpers.createElement Helpers.SankeyChart props

    static member inline sankeyChartSNode(props: ISNode list) = !! createObj props

    static member inline sankeyChartSLink(props: ISLink list) = !! createObj props

    static member sparkLine(props: ISparklineProps list) =
        Helpers.createElement Helpers.Sparkline props

    static member groupedVerticalBarChart(props: ISGroupedVerticalBarChartProps list) =
        Helpers.createElement Helpers.GroupedVerticalBarChart props

    static member groupedVerticalBarChartData(props: IGroupedVerticalBarChartData list) = !! createObj props

    static member groupedVerticalBarChartDataPoint(props: IGVBarChartSeriesPoint list) = !! createObj props

    static member horizontalBarChart(props: IHorizontalBarChartProps list) =
        Helpers.createElement Helpers.HorizontalBarChart props

    static member horizontalBarChartDataProp(props: IChartProps list) = !! createObj props

    static member horizontalBarChartWithAxis(props: IHorizontalBarChartWithAxisProps list) =
        Helpers.createElement Helpers.HorizontalBarChartWithAxis props

    static member horizontalBarWithAxisChartDataProp(props: IHorizontalBarChartWithAxisDataPoint list) =
        !! createObj props

    static member verticalBarChart(props: IVerticalBarChartProps list) =
        Helpers.createElement Helpers.VerticalBarChart props

    static member verticalBarChartDataProp(props: IVerticalBarChartDataPoint list) = !! createObj props

    static member verticalStackedBarChart(props: IVerticalStackedBarChartProps list) =
        Helpers.createElement Helpers.VerticalStackedBarChart props

    static member verticalStackedBarChartProps(props: IVerticalStackedChartProps list) = !! createObj props

    static member vsChartDataPoint(props: IVSChartDataPoint list) = !! createObj props

    static member lineDataInVerticalStackedBarChart(props: ILineDataInVerticalStackedBarChart list) = !! createObj props

    static member chartTable(props: IChartTableProps list) =
        Helpers.createElement Helpers.ChartTable props

    static member ChartTableData(props: IChartTableDataProps list) = !! createObj props

    static member legend(props: ILegend list) = !! createObj props
// TODO DeclarativeChart ??
// COMING? TreeChart
