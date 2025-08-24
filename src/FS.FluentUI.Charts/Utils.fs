namespace FS.Charts

open Fable.Core

[<RequireQualifiedAccess>]
type Interop =
    static member inline mkProperty<'ControlProperty> (key: string) (value: obj) : 'ControlProperty = unbox (key, value)

type [<Erase>] ILegend = interface end
type [<Erase>] ILegendProp = interface end
type [<Erase>] ILegendsStyles = interface end
type [<Erase>] ILegendShape = interface end
type [<Erase>] IMargins = interface end
type [<Erase>] IDateTimeFormatOptionsProp = interface end
type [<Erase>] ITimeLocaleDefinition = interface end
type [<Erase>] ICartesianChartStyles = interface end
type [<Erase>] ICartesianChartStyleProps = interface end
type [<Erase>] IChartProps = interface end
type [<Erase>] IChartPopoverProps = interface end
type [<Erase>] ILineChartProps = interface end
type [<Erase>] ILineChartDataProp = interface end
type [<Erase>] ILineChartLineOptions = interface end
type [<Erase>] ILineChartStyles = interface end
type [<Erase>] ILineChartDataPoint = interface end
type [<Erase>] IAccessibilityProps = interface end
type [<Erase>] IAxisCategoryOrder = interface end
type [<Erase>] IAreaChartProp = interface end
type [<Erase>] IAreaChartDataProp = interface end
type [<Erase>] IDonutChartProps = interface end
type [<Erase>] IChartDataPoint = interface end
type [<Erase>] IDonutChartStyles = interface end
type [<Erase>] IFunnelChartProps = interface end
type [<Erase>] IFunnelChartStyles = interface end
type [<Erase>] IFunnelChartDataPoint = interface end
type [<Erase>] IGaugeChartProps = interface end
type [<Erase>] IGaugeChartSegment = interface end
type [<Erase>] IGaugeChartStyles = interface end
type [<Erase>] IGanttChartProps = interface end
type [<Erase>] IGanttChartDataPoint = interface end
type [<Erase>] IScatterChartProps = interface end
type [<Erase>] IScatterChartPoints = interface end
type [<Erase>] IScatterChartDataPoint = interface end
type [<Erase>] IScatterChartStyles = interface end
type [<Erase>] IHeatMapChartProps = interface end
type [<Erase>] IHeatMapChartData = interface end
type [<Erase>] IHeatMapChartDataPointProp = interface end
type [<Erase>] IHeatMapChartStyles = interface end
type [<Erase>] ISankeyChartProps = interface end
type [<Erase>] ISankeyChartData = interface end
type [<Erase>] ISankeyChartPoint = interface end
type [<Erase>] ISNode = interface end
type [<Erase>] ISLink = interface end
type [<Erase>] ISankeyChartAccessibility = interface end
type [<Erase>] ISparklineProps = interface end
type [<Erase>] ISGroupedVerticalBarChartProps = interface end
type [<Erase>] IGroupedVerticalBarChartData = interface end
type [<Erase>] IGVBarChartSeriesPoint = interface end
type [<Erase>] IGroupedVerticalBarChartStyles = interface end
type [<Erase>] IHorizontalBarChartProps = interface end
type [<Erase>] IHorizontalDataPointProp = interface end
type [<Erase>] IHorizontalBarChartStyles = interface end
type [<Erase>] IHorizontalBarChartWithAxisProps = interface end
type [<Erase>] IHorizontalBarChartWithAxisDataPoint = interface end
type [<Erase>] IHorizontalBarChartWithAxisStyles = interface end
type [<Erase>] IVerticalBarChartProps = interface end
type [<Erase>] IVerticalBarChartDataPoint = interface end
type [<Erase>] IVerticalBarChartStyles = interface end
type [<Erase>] IVerticalStackedBarChartProps = interface end
type [<Erase>] IVerticalStackedChartProps = interface end
type [<Erase>] IVSChartDataPoint = interface end
type [<Erase>] ILineDataInVerticalStackedBarChart = interface end
type [<Erase>] IVerticalStackedBarChartStyles = interface end
type [<Erase>] IChartTableProps = interface end
type [<Erase>] IChartTableDataProps = interface end
type [<Erase>] IChartTableStyles = interface end

