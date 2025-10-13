namespace FS.Charts

open Fable.React
open Browser.Types

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
    y: int
    color: string
    data: string
    shouldDrawBorderBottom: bool
    yAxisCalloutData: string
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
    legend: string
    yCalloutValue: string
    YValue: string
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
