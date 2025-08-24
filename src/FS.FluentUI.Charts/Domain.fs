namespace FS.Charts

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
