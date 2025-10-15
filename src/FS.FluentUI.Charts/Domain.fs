namespace FS.Charts

open Fable.React
open Browser.Types
open System
open Fable.Core

type ILineChartGap = { startIndex: float; endIndex: float }

type FocusProp = { focus: unit -> unit }

type IFunnelChartDataPoint = {
    category: string
    value: float
    color: string
}

/// <summary>
/// Set of strings which are used when rendering the chart.
/// </summary>
type SankeyChartStrings = {

    /// <summary>
    /// A value similar to "from \{0\}" where \{0\} is the name of the source node for a link.
    /// This is shown in the `ChartHoverCard` when the user hovers the mouse over a link.
    /// </summary>
    linkFrom: string
}

type Promise<'T> = {
    // Attaches a callback that is invoked when the Promise is settled (fulfilled or rejected). The
    // resolved value cannot be modified from the callback.
    // @param onfinally The callback to execute when the Promise is settled (fulfilled or rejected).
    // @returns A Promise for the completion of the callback.
    ``finally``: (unit -> unit) option -> Promise<'T>
}

type Legend = {
    title: string
    action: unit -> unit
    hoverAction: unit -> unit
    onMouseOutAction: bool -> unit
    color: string
    opacity: float
    shape: string
    stripePattern: bool
    isLineLegendInBarChart: bool
    nativeButtonProps: obj
    legendAnnotation: unit -> ReactElement
}

type SVG = {
    node: Browser.Types.Element option
    width: int
    height: int
}

type ToSVG = int -> bool -> SVG

type LegendContainer = {
    toSVG: ToSVG
}

type ClickPosition = {
    x: int
    y: int
}

type PopoverComponentStyles = {
    calloutContentRoot: string
    calloutDateTimeContainer: string
    calloutContentX: string
    calloutBlockContainer: string
    calloutBlockContainertoDrawShapefalse: string
    calloutBlockContainertoDrawShapetrue: string
    shapeStyles: string
    calloutlegendText: string
    calloutContentY: string
    descriptionMessage: string
    ratio: string
    numerator: string
    denominator: string
    calloutInfoContainer: string
    calloutContainer: string
}

type AccessibilityProps = {
    ariaLabel: string
    ariaLabelledBy: string
    ariaDescribedBy: string
}

type YValueHover = {
    legend: string
    y: U2<int, string>
    color: string
    data: U2<int, string>
    shouldDrawBorderBottom: bool
    yAxisCalloutData: U2<string, obj>
    index: int
    callOutAccessibilityData: AccessibilityProps
}

type XAxisCalloutAccessibilityData = {
    ariaLabel: string
    data: string
}
type CustomCallout = {
        customizedCallout: ReactElement
        customCalloutProps: ChartPopoverProps
    }
and ChartPopoverProps = {
    clickPosition: ClickPosition
    isPopoverOpen: bool
    xCalloutValue: string
    legend: U3<string, int, DateTime>
    yCalloutValue: string
    YValue: U3<string, int, DateTime>
    XValue: string
    color: string
    culture: string
    customCallout: CustomCallout
    isCalloutForStack: bool
    xAxisCalloutAccessibilityData: XAxisCalloutAccessibilityData
    hoverXValue: string
    YValueHover: YValueHover array
    descriptionMessage: string
    ratio: array<int * int>
    isCartesian: bool
    styles: PopoverComponentStyles
}

type RefObject<'T> = {
    current: 'T option
}

type ImageExportOptions = {
    width: int
    height: int
    scale: int
    background: string
}

type Chart = {
    chartContainer: HTMLElement option
    toImage: ImageExportOptions -> Promise<string>
}

type [<RequireQualifiedAccess>] AxisCategoryOrder =
    | ``default``
    | ``data``
    | ``category ascending``
    | ``category descending``
    | ``total ascending``
    | ``total descending``
    | ``min ascending``
    | ``min descending``
    | ``max ascending``
    | ``max descending``
    | ``sum ascending``
    | ``sum descending``
    | ``mean ascending``
    | ``mean descending``
    | ``median ascending``
    | ``median descending``

type [<RequireQualifiedAccess>] AxisScaleType =
    | ``default``
    | ``log``

/// Translated from (props?: P, defaultRender?: (props?: P) => JSXElement | null) => JSXElement | null
type RenderFunction<'P> =
    'P option ->
      (('P option -> ReactElement option) option) ->
        ReactElement option

type CustomizedCalloutDataPoint = {
    legend: string
    y: int
    color: string
    xAxisCalloutData: string
    yAxisCalloutData: string
}

type CustomizedCalloutData = {
    x: U3<int, string, DateTime>
    values: CustomizedCalloutDataPoint array
}

type HorizontalDataPoint = {
    x: int
    total: int
}

type ChartDataPoint = {
    legend: string
    data: int
    horizontalBarChartdata: HorizontalDataPoint
    onClick: unit -> unit
    color: string
    placeHolder: bool
    xAxisCalloutData: string
    yAxisCalloutData: string
    callOutAccessibilityData: AccessibilityProps
}

type X = {
    start: U2<DateTime, int>
    ``end``: U2<DateTime, int>
}

type GanttChartDataPoint = {
    x: X
    y: U2<int, string>
    legend: string
    color: string
    gradient: array<string * string>
    xAxisCalloutData: string
    yAxisCalloutData: string
    onClick: unit -> unit
    callOutAccessibilityData: AccessibilityProps
}

type DataVizPalette = {
    color1: string
    color2: string
    color3: string
    color4: string
    color5: string
    color6: string
    color7: string
    color8: string
    color9: string
    color10: string
    color11: string
    color12: string
    color13: string
    color14: string
    color15: string
    color16: string
    color17: string
    color18: string
    color19: string
    color20: string
    color21: string
    color22: string
    color23: string
    color24: string
    color25: string
    color26: string
    color27: string
    color28: string
    color29: string
    color30: string
    color31: string
    color32: string
    color33: string
    color34: string
    color35: string
    color36: string
    color37: string
    color38: string
    color39: string
    color40: string
    info: string
    disabled: string
    highError: string
    error: string
    warning: string
    success: string
    highSuccess: string
}

type HorizontalBarChartWithAxisDataPoint = {
    x: int
    y: U2<int, string>
    legend: string
    color: string
    xAxisCalloutData: string
    yAxisCalloutData: string
    onClick: unit -> unit
    callOutAccessibilityData: AccessibilityProps
}
