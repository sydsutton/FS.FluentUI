namespace FS.Charts

open Fable.React
open Fable.Core
open Fable.Core.JsInterop

module Helpers =
    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement =
        reactElement el (!!props |> createObj)

type Fui =
    static member inline lineChart (props: ILineChartProp list) = Helpers.createElement (import "LineChart" "@fluentui/react-charts") props
    static member inline areaChart (props: IAreaChartProp list) = Helpers.createElement (import "AreaChart" "@fluentui/react-charts") props
    static member inline donutChart (props: IDonutChartProp list) = Helpers.createElement (import "DonutChart" "@fluentui/react-charts") props
    static member inline funnelChart (props: IFunnelChartProp list) = Helpers.createElement (import "FunnelChart" "@fluentui/react-charts") props
    static member inline gaugeChart (props: IGaugeChartProp list) = Helpers.createElement (import "GaugeChart" "@fluentui/react-charts") props
    static member inline ganttChart (props: IGanttChartProp list) = Helpers.createElement (import "GanttChart" "@fluentui/react-charts") props
    static member inline scatterChart (props: IScatterChartProp list) = Helpers.createElement (import "ScatterChart" "@fluentui/react-charts") props
    static member inline heatMapChart (props: IHeatMapChartProp list) = Helpers.createElement (import "HeatMapChart" "@fluentui/react-charts") props
    static member inline sankeyChart (props: ISankeyChartProp list) = Helpers.createElement (import "SankeyChart" "@fluentui/react-charts") props
    static member inline sparkline (props: ISparklineProp list) = Helpers.createElement (import "Sparkline" "@fluentui/react-charts") props
    static member inline groupedVerticalBarChart (props: IGroupedVerticalBarChartProp list) = Helpers.createElement (import "GroupedVerticalBarChart" "@fluentui/react-charts") props
    static member inline horizontalBarChart (props: IHorizontalBarChartProp list) = Helpers.createElement (import "HorizontalBarChart" "@fluentui/react-charts") props
    static member inline horizontalBarChartWithAxis (props: IHorizontalBarChartWithAxisProp list) = Helpers.createElement (import "HorizontalBarChartWithAxis" "@fluentui/react-charts") props
    static member inline verticalBarChart (props: IVerticalBarChartProp list) = Helpers.createElement (import "VerticalBarChart" "@fluentui/react-charts") props
    static member inline verticalStackedBarChart (props: IVerticalStackedBarChartProp list) = Helpers.createElement (import "VerticalStackedBarChart" "@fluentui/react-charts") props
    static member inline chartTable (props: IChartTableProp list) = Helpers.createElement (import "ChartTable" "@fluentui/react-charts") props
    static member inline dataVizPalette : DataVizPalette = import "DataVizPalette" "@fluentui/react-charts"
    static member inline getColorFromToken (color: string) : string = color |> import "getColorFromToken" "@fluentui/react-charts"
    static member inline getColorFromToken (color: string, isDarkTheme: bool) : string =
                        let args = color, isDarkTheme
                        import "getColorFromToken" "@fluentui/react-charts" (emitJsExpr args "$0[0], $0[1]")

    // static member ChartTableData(props: IChartTableDataProps list) = !! createObj props

    // static member legend(props: ILegend list) = !! createObj props
// TODO DeclarativeChart ??
// COMING? TreeChart
