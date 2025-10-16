namespace FS.Charts

open System
open Fable.Core
open Fable.Core.JsInterop
open FS.Charts
open Feliz
open Browser.Types

[<AutoOpen>]
module Helpers =
    let createObjArray value = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray

type [<Erase>] sharedCartesianChartStyles<'Property> =
    ///  Style for the root element
    static member inline root (value: string) = Interop.mkProperty<'Property> "root" value
    /// Style for the element containing the x-axis.
    static member inline xAxis (value: string) = Interop.mkProperty<'Property> "xAxis" value
    /// Style for the element containing the y-axis.
    static member inline yAxis (value: string) = Interop.mkProperty<'Property> "yAxis" value
    /// Style for legend container
    static member inline legendContainer (value: string) = Interop.mkProperty<'Property> "legendContainer" value
    /// line hover box css
    static member inline hover (value: string) = Interop.mkProperty<'Property> "hover" value
    /// styles for description message
    static member inline descriptionMessage (value: string) = Interop.mkProperty<'Property> "descriptionMessage" value
    /// styles for tooltip
    static member inline tooltip (value: string) = Interop.mkProperty<'Property> "tooltip" value
    /// styles for axis title
    static member inline axisTitle (value: string) = Interop.mkProperty<'Property> "axisTitle" value
    /// styles for axis annotation
    static member inline axisAnnotation (value: string) = Interop.mkProperty<'Property> "axisAnnotation" value
    /// Style for the chart Title.
    static member inline chartTitle (value: string) = Interop.mkProperty<'Property> "chartTitle" value
    /// Style to change the opacity of bars in dataviz when we hover on a single bar or legends
    static member inline opacityChangeOnHover (value: string) = Interop.mkProperty<'Property> "opacityChangeOnHover" value
    /// styles for the shape object in the callout
    static member inline shapeStyles (value: string) = Interop.mkProperty<'Property> "shapeStyles" value
    /// Styles for the chart wrapper div
    static member inline chartWrapper (value: string) = Interop.mkProperty<'Property> "chartWrapper" value
    /// Styles for the svg tooltip
    static member inline svgTooltip (value: string) = Interop.mkProperty<'Property> "svgTooltip" value
    /// Styles for the chart svg element
    static member inline chart (value: string) = Interop.mkProperty<'Property> "chart" value

type [<Erase>] sharedShapes<'Property> =
    static member inline default' = Interop.mkProperty<'Property> "shape" "default"
    static member inline circle = Interop.mkProperty<'Property> "shape" "circle"
    static member inline square = Interop.mkProperty<'Property> "shape" "square"
    static member inline triangle = Interop.mkProperty<'Property> "shape" "triangle"
    static member inline pyramid = Interop.mkProperty<'Property> "shape" "pyramid"
    static member inline hexagon = Interop.mkProperty<'Property> "shape" "hexagon"
    static member inline pentagon = Interop.mkProperty<'Property> "shape" "pentagon"
    static member inline octagon = Interop.mkProperty<'Property> "shape" "octagon"
    static member inline diamond = Interop.mkProperty<'Property> "shape" "diamond"
    static member inline dottedLine = Interop.mkProperty<'Property> "shape" "dottedLine"

type [<Erase>] baseDataPoint<'Property> =

    /// Defines the function that is executed on clicking  line
    static member inline onDataPointClick (value: string) = Interop.mkProperty<'Property> "onDataPointClick" value
    /// Callout data for x axis
    static member inline xAxisCalloutData (value: string) = Interop.mkProperty<'Property> "xAxisCalloutData" value
    /// Callout data for y axis
    static member inline yAxisCalloutData (value: string) = Interop.mkProperty<'Property> "yAxisCalloutData" value
    /// Callout data for y axis
    static member inline yAxisCalloutData (value: obj) = Interop.mkProperty<'Property> "yAxisCalloutData" value
    /// Whether to hide callout data for the point.
    static member inline hideCallout (value: bool) = Interop.mkProperty<'Property> "hideCallout" value
    /// Accessibility data for callout
    static member inline callOutAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<'Property> "callOutAccessibilityData" (!!value |> createObj |> unbox)
    /// X axis Accessibility data for callout
    static member inline xAxisCalloutAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<'Property> "xAxisCalloutAccessibilityData" (!!value |> createObj |> unbox)
    /// Marker size of the points
    static member inline markerSize (value: int) = Interop.mkProperty<'Property> "markerSize" value
    /// Marker size of the points
    static member inline markerSize (value: float) = Interop.mkProperty<'Property> "markerSize" value
    /// Marker size of the points
    static member inline markerSize (value: decimal) = Interop.mkProperty<'Property> "markerSize" value


type [<Erase>] legendsStyles =
    // Style set for the root of the legend component
    static member inline root(value: string) = Interop.mkProperty<ILegendsStylesProp> "root" value
    // Style set for Legend. This is a wrapping class for text of legend and the rectange box that represents a legend
    static member inline legend(value: string) = Interop.mkProperty<ILegendsStylesProp> "legend" value
    // Style set for the rectangle that represents a legend
    static member inline rect(value: string) = Interop.mkProperty<ILegendsStylesProp> "rect" value
    // styles set for the shape that represents a legend
    static member inline shape(value: string) = Interop.mkProperty<ILegendsStylesProp> "shape" value
    // Style set for the triangle that represents a legend
    static member inline triangle(value: string) = Interop.mkProperty<ILegendsStylesProp> "triangle" value
    // Style for the legend text
    static member inline text(value: string) = Interop.mkProperty<ILegendsStylesProp> "text" value
    // Style for the legend text
    static member inline hoverChange(value: string) = Interop.mkProperty<ILegendsStylesProp> "hoverChange" value
    // Style for the area that is resizable
    static member inline resizableArea(value: string) = Interop.mkProperty<ILegendsStylesProp> "resizableArea" value

    static member inline legendContainer(value: string) = Interop.mkProperty<ILegendsStylesProp> "legendContainer" value
    // Style for the annotation that is used in the legend
    static member inline annotation(value: string) = Interop.mkProperty<ILegendsStylesProp> "annotation" value

type [<Erase>] legend =
    // Defines the title of the legend
    static member inline title(value: string) = Interop.mkProperty<ILegendProp> "title" value
    // Defines the function that is executed on clicking this legend
    static member inline action(value: unit -> unit) = Interop.mkProperty<ILegendProp> "action" value
    // Defines the function that is executed upon hovering over the legend
    static member inline hoverAction(value: unit -> unit) = Interop.mkProperty<ILegendProp> "hoverAction" value
    // Defines the function that is executed upon moving the mouse away from the legend
    static member inline onMouseOutAction(value: bool -> unit) = Interop.mkProperty<ILegendProp> "onMouseOutAction" value
    // The color for the legend
    static member inline color(value: string) = Interop.mkProperty<ILegendProp> "color" value
    // The opacity of the legend color
    static member inline opacity(value: int) = Interop.mkProperty<ILegendProp> "opacity" value
    // The opacity of the legend color
    static member inline opacity(value: float) = Interop.mkProperty<ILegendProp> "opacity" value
    // The opacity of the legend color
    static member inline opacity(value: decimal) = Interop.mkProperty<ILegendProp> "opacity" value
    // The shape for the legend
    // Indicated whether or not to apply stripe pattern
    static member inline stripePattern(value: bool) = Interop.mkProperty<ILegendProp> "stripePattern" value
    // Indicates if the legend belongs to a line in the Bar Chart
    static member inline isLineLegendInBarChart(value: bool) = Interop.mkProperty<ILegendProp> "isLineLegendInBarChart" value
    static member inline nativeButtonProps(value: IReactProperty list) = Interop.mkProperty<ILegendProp> "nativeButtonProps" (!!value |> createObj |> unbox)
    // The annotation for the legend, function returning a React node
    static member inline legendAnnotation(value: unit -> ReactElement) = Interop.mkProperty<ILegendProp> "legendAnnotation" value

module legend =
    type [<Erase>] shape = sharedShapes<ILegendProp>
//-------------------------------------------------------- Legends ---------------------------------------
type [<Erase>] legends =
    /// Prop that takes list of legends
    static member inline legends(value: ILegendProp list list) = Interop.mkProperty<ILegendsProp> "legends" (value |> createObjArray)
    /// Additional CSS class(es) to apply to the legends component
    static member inline className(value: string) = Interop.mkProperty<ILegendsProp> "className" value
    /// Call to provide customized styling that will layer on top of the variant rules
    static member inline styles(value: ILegendsStylesProp list) = Interop.mkProperty<ILegendsProp> "styles" (!!value |> createObj |> unbox)
    /// This prop makes the legends component align itself to the center in the container
    static member inline centerLegends(value: bool) = Interop.mkProperty<ILegendsProp> "centerLegends" value
    /// Enable the legends to wrap lines if there is not enough space to show all legends on a single line
    static member inline enabledWrapLines(value: bool) = Interop.mkProperty<ILegendsProp> "enabledWrapLines" value
    /// Style for the overflow component
    static member inline overflowStyles(value: IStyleAttribute list) = Interop.mkProperty<ILegendsProp> "overflowStyles" (!!value |> createObj |> unbox)
    /// Text for overflow legends string
    static member inline overflowText(value: string) = Interop.mkProperty<ILegendsProp> "overflowText" value
    /// Prop that decides if legends are focusable
    static member inline allowFocusOnLegends(value: bool) = Interop.mkProperty<ILegendsProp> "allowFocusOnLegends" value
    /// Prop that decides if we can select multiple legends or single legend at a time
    static member inline canSelectMultipleLegends(value: bool) = Interop.mkProperty<ILegendsProp> "canSelectMultipleLegends" value
    // Callback issued when the selected option changes
    static member inline onChange(value: string array -> MouseEvent -> Legend -> unit) = Interop.mkProperty<ILegendsProp> "onChange" (System.Func<_,_,_,_> value)
    /// Keys (title) that will be initially used to set selected items. This prop is used for multi-select scenarios when
    /// canSelectMultipleLegends is true; for single-select, use defaultSelectedLegend.
    ///
    /// Updating this prop does not change the selection after the component has been initialized. For controlled
    /// selections, use selectedLegends instead.
    static member inline defaultSelectedLegends(value: string list) = Interop.mkProperty<ILegendsProp> "defaultSelectedLegends" (value |> List.toArray)
    /// Key that will be initially used to set selected item. This prop is used for single-select scenarios when
    /// canSelectMultipleLegends is false or unspecified; for multi-select, use defaultSelectedLegends.
    ///
    /// Updating this prop does not change the selection after the component has been initialized. For controlled
    /// selections, use selectedLegend instead.
    static member inline defaultSelectedLegend(value: string) = Interop.mkProperty<ILegendsProp> "defaultSelectedLegend" value
    /// Keys (title) that will be used to set selected items in multi-select scenarios when canSelectMultipleLegends is
    /// true. For single-select, use selectedLegend.
    ///
    /// When this prop is provided, the component is controlled and does not automatically update the selection based on
    /// user interactions; the parent component must update the value passed to this property by handling the onChange event.
    static member inline selectedLegends(value: string list) = Interop.mkProperty<ILegendsProp> "selectedLegends" (value |> List.toArray)
    /// Key (title) that will be used to set the selected item in single-select scenarios when canSelectMultipleLegends is
    /// false or unspecified. For multi-select, use selectedLegends.
    ///
    /// When this prop is provided, the component is controlled and does not automatically update the selection based on
    /// user interactions; the parent component must update the value passed to this property by handling the onChange event.
    static member inline selectedLegend(value: string) = Interop.mkProperty<ILegendsProp> "selectedLegend" value
    /// Reference to access the public methods and properties of the component
    static member inline legendRef(value: IRefValue<LegendContainer>) = Interop.mkProperty<ILegendsProp> "legendRef" value

module legends =
    type [<Erase>] shape = sharedShapes<ILegendsProp>

/// Props related to reflow behavior of the chart
/// Determines the reflow behavior of the chart.
/// When set to `'min-width'`, the chart will not shrink below a certain width and will enable scrolling if it overflows.
type [<Erase>] reflowProps<'Property> =
    static member inline modeNone = Interop.mkProperty<'Property> "reflowProps" {| mode = "none" |}
    static member inline modeMinWidth = Interop.mkProperty<'Property> "reflowProps" {| mode = "min-width" |}

type [<Erase>] xAxis<'Property> =
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: int) = Interop.mkProperty<'Property> "xAxis" {| tickStep = value |}
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: float) = Interop.mkProperty<'Property> "xAxis" {| tickStep = value |}
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: decimal) = Interop.mkProperty<'Property> "xAxis" {| tickStep = value |}
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: string) = Interop.mkProperty<'Property> "xAxis" {| tickStep = value |}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: int) = Interop.mkProperty<'Property> "xAxis" {| tick0 = value|}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: float) = Interop.mkProperty<'Property> "xAxis" {| tick0 = value|}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: decimal) = Interop.mkProperty<'Property> "xAxis" {| tick0 = value|}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: DateTime) = Interop.mkProperty<'Property> "xAxis" {| tick0 = value|}

type [<Erase>] yAxis<'Property> =
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: int) = Interop.mkProperty<'Property> "yAxis" {| tickStep = value |}
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: float) = Interop.mkProperty<'Property> "yAxis" {| tickStep = value |}
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: decimal) = Interop.mkProperty<'Property> "yAxis" {| tickStep = value |}
    /// Defines the step between tick marks on the axis.
    /// Works in combination with `tick0`.
    /// Must be a positive number.
    ///
    /// - **Log scale**:
    ///   - Ticks are placed at `10^(n * tickStep)` where `n` is the tick index.
    ///     - Example: `tickStep = 2` → ticks at 1, 100, 10,000...
    ///     - Example: `tickStep = log10(5)` → ticks at 1, 5, 25, 125...
    ///   - Special format `"L<f>"`: Creates ticks that are linearly spaced in value (not position).
    ///     - Example: `tick0 = 0.1`, `tickStep = "L0.5"` → ticks at 0.1, 0.6, 1.1, 1.6...
    ///
    /// - **Date axis**:
    ///   - Must be in milliseconds.
    ///     - Example: one day = `tickStep = 86400000`.
    ///   - Special format `"M<n>"`: Places ticks every `n` months.
    ///     - Example: `tick0 = "2000-01-15"`, `tickStep = "M3"` → ticks on the 15th every third month.
    ///     - Example: `tickStep = "M48"` → ticks every 4 years.
    static member inline tickStep (value: string) = Interop.mkProperty<'Property> "yAxis" {| tickStep = value |}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: int) = Interop.mkProperty<'Property> "yAxis" {| tick0 = value|}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: float) = Interop.mkProperty<'Property> "yAxis" {| tick0 = value|}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: decimal) = Interop.mkProperty<'Property> "yAxis" {| tick0 = value|}
    /// Sets the reference value for axis ticks.
    /// Works in combination with `tickStep`.
    ///
    /// - **Log scale**:
    ///   - `tick0` must be given as the logarithm of the reference tick.
    ///     - Example: to align ticks with 100, use `tick0 = 2`.
    ///   - Exception: when `tickStep` uses `"L<f>"`, you can specify the raw value directly.
    static member inline tick0 (value: DateTime) = Interop.mkProperty<'Property> "yAxis" {| tick0 = value|}

// type [<Erase>] timeLocaleDefinition =
//     static member inline dateTime(value: string) = Interop.mkProperty<ITimeLocaleDefinitionProp> "dateTime" value
//     static member inline date(value: string) = Interop.mkProperty<ITimeLocaleDefinitionProp> "date" value
//     static member inline time(value: string) = Interop.mkProperty<ITimeLocaleDefinitionProp> "time" value
//     static member inline periods(value: string list) = Interop.mkProperty<ITimeLocaleDefinitionProp> "periods" (value |> List.toArray)
//     /// The abbreviated names of the weekdays, starting with Sunday.
//     /// [string, string, string, string, string, string, string]
//     static member inline days(value: string list) = Interop.mkProperty<ITimeLocaleDefinitionProp> "days" (value |> List.toArray)
//     /// shortDays: [string, string, string, string, string, string, string]
//     /// The abbreviated names of the weekdays, starting with Sunday.
//     static member inline shortDays(value: string list) = Interop.mkProperty<ITimeLocaleDefinitionProp> "shortDays" (value |> List.toArray)
//     /// months: [string, string, string, string, string, string, string, string, string, string, string, string];
//     /// the abbreviated names of the months (starting with January).
//     static member inline months(value: string list) = Interop.mkProperty<ITimeLocaleDefinitionProp> "months" (value |> List.toArray)
//     /// shortMonths: [string, string, string, string, string, string, string, string, string, string, string, string];
//     static member inline shortMonths(value: string list) = Interop.mkProperty<ITimeLocaleDefinitionProp> "shortMonths" (value |> List.toArray)


// type [<Erase>] lineChartStyles =
//     inherit cartesianChartStyles<ILineChartStyles>
//     static member inline lineBorder(value: string) = Interop.mkProperty<ILineChartStyles> "lineBorder" value
//     static member inline markerLabel(value: string) = Interop.mkProperty<ILineChartStyles> "markerLabel" value

// type [<Erase>] lineChart =
//     inherit cartesianChartProps<ILineChartProps>
//     static member inline data(datasets: IChartProps list) = Interop.mkProperty<ILineChartProps> "data" (createObj !!datasets)
//     static member inline styles(value: ILineChartStyles list) = Interop.mkProperty<ILineChartProps> "styles" (value |> List.toArray)
//     // TODO static member inline eventAnnotationProps(value: 'a)
//     // TODO static member inline onRenderCalloutPerDataPoint(value: 'a)
//     // TODO static member inline onRenderCalloutPerStack(value: 'a)
//     // TODO static member inline getCalloutDescriptionMessage(value: 'a)
//     // TODO static member inline colorFillBars(value: 'a)
//     static member inline allowMultipleShapesForPoints(value: bool) = Interop.mkProperty<ILineChartProps> "allowMultipleShapesForPoints" value
//     static member inline optimizeLargeData(value: bool) = Interop.mkProperty<ILineChartProps> "optimizeLargeData" value
//     static member inline culture(value: string) = Interop.mkProperty<ILineChartProps> "culture" value
//     static member inline enablePerfOptimization(value: bool) = Interop.mkProperty<ILineChartProps> "enablePerfOptimization" value

// module scatterChartPoint =
//     type [<Erase>] legendShape =
//         class
//             inherit legendShape<IScatterChartPoints>
//         end

// type [<Erase>] scatterChartPoint =
//     static member inline legend(value: string) = Interop.mkProperty<IScatterChartPoints> "legend" value
//     static member inline data(value: IScatterChartDataPoint list) = Interop.mkProperty<IScatterChartPoints> "data" (value |> List.toArray)
//     static member inline color(value: string) = Interop.mkProperty<IScatterChartPoints> "color" value
//     static member inline opacity(value: float) = Interop.mkProperty<IScatterChartPoints> "opacity" value
//     static member inline hideNonActiveDots(value: bool) = Interop.mkProperty<IScatterChartPoints> "hideNonActiveDots" value
//     static member inline onLegendClick(value: string option -> unit) = Interop.mkProperty<IScatterChartPoints> "onLegendClick" value
//     static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<IScatterChartPoints> "useSecondaryYScale" value

// type [<Erase>] scatterChartStyles =
//     inherit cartesianChartStyles<IScatterChartStyles>
//     static member inline markerLabel(value: string) = Interop.mkProperty<IScatterChartStyles> "markerLabel" value

// type [<Erase>] scatterChart =
//     static member inline data(datasets: IChartProps list) = Interop.mkProperty<IScatterChartProps> "data" (createObj !!datasets)
//     static member inline styles(value: IScatterChartStyles list) = Interop.mkProperty<IScatterChartProps> "data" (value |> List.toArray)

//     // TODO onRenderCalloutPerDataPoint
//     // TODO getCalloutDescriptionMessage

//     static member inline culture(value: string) = Interop.mkProperty<IScatterChartPoints> "culture" value
//     static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IScatterChartPoints> "showYAxisLablesTooltip" value

// type [<Erase>] sankeyChartPoint =
//     static member inline nodes(value: ISankeyChartPoint list) = Interop.mkProperty<ISankeyChartData> "nodes" (value |> List.toArray)
//     static member inline links(value: ISankeyChartPoint list) = Interop.mkProperty<ISankeyChartData> "links" (value |> List.toArray)

// type [<Erase>] sankeyChartAccessibility =
//     /// Aria label for when the chart is empty.
//     static member inline emptyAriaLabel(value: string) = Interop.mkProperty<ISankeyChartAccessibility> "emptyAriaLabel" value
//     /// A value similar to "node \{0\} with weight \{1\}".
//     /// \{0\} is the name of the node.
//     /// \{1\} is the weight of the node (as computed by the sankey layout engine via the links to or from this node).
//     static member inline nodeAriaLabel(value: string) = Interop.mkProperty<ISankeyChartAccessibility> "nodeAriaLabel" value
//     /// A value similar to "link from \{0\} to $\{1\} with weight $\{2\}".
//     /// \{0\} is the source node, \{1\} is the target node, and \{2\} is the value of the link.
//     static member inline linkAriaLabel(value: string) = Interop.mkProperty<ISankeyChartAccessibility> "linkAriaLabel" value

// module sankeyChart =
//     type [<Erase>] reflowProps =
//         static member inline none = Interop.mkProperty<ISankeyChartProps> "mode" "none"
//         static member inline minWidth = Interop.mkProperty<ISankeyChartProps> "mode" "min-width"

// type [<Erase>] sankeyChart =
//     static member inline data(value: IChartProps list) = Interop.mkProperty<ISankeyChartProps> "data" (createObj !!value)
//     static member inline width(value: float) = Interop.mkProperty<ISankeyChartProps> "width" value
//     static member inline height(value: float) = Interop.mkProperty<ISankeyChartProps> "height" value
//     static member inline className(value: string) = Interop.mkProperty<ISankeyChartProps> "className" value

//     // TODO styles

//     static member inline parentRef(value: Browser.Types.HTMLElement option) = Interop.mkProperty<ISankeyChartProps> "parentRef" value
//     static member inline shouldResize(value: bool) = Interop.mkProperty<ISankeyChartProps> "shouldResize" value
//     static member inline pathColor(value: string) = Interop.mkProperty<ISankeyChartProps> "pathColor" value
//     static member inline colorsForNodes(value: string list) = Interop.mkProperty<ISankeyChartProps> "colorsForNodes" (value |> List.toArray)
//     static member inline borderColorsForNodes(value: string list) = Interop.mkProperty<ISankeyChartProps> "borderColorsForNodes" (value |> List.toArray)
//     static member inline strings(value: SankeyChartStrings list) = Interop.mkProperty<ISankeyChartProps> "strings" (value |> List.toArray)
//     static member inline accessibility(value: ISankeyChartAccessibility list) = Interop.mkProperty<ISankeyChartProps> "accessibility" (value |> List.toArray)

//     // TODO formatNumberOptions

//     static member inline enableReflow(value: bool) = Interop.mkProperty<ISankeyChartProps> "enableReflow" value
//     static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<ISankeyChartProps> "componentRef" value
//     static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<ISankeyChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
//     static member inline culture(value: string) = Interop.mkProperty<ISankeyChartProps> "culture" value

// type [<Erase>] sparklineStyles =
//     static member inline inlineBlock(value: string) = Interop.mkProperty<ISankeyChartProps> "inlineBlock" value
//     static member inline valueText(value: string) = Interop.mkProperty<ISankeyChartProps> "valueText" value

// type [<Erase>] sparkline =
//     static member inline data(value: IChartProps list) = Interop.mkProperty<ISparklineProps> "data" (createObj !!value)
//     static member inline width(value: float) = Interop.mkProperty<ISparklineProps> "width" value
//     static member inline height(value: float) = Interop.mkProperty<ISparklineProps> "height" value
//     static member inline valueTextWidth(value: float) = Interop.mkProperty<ISparklineProps> "valueTextWidth" value
//     static member inline className(value: string) = Interop.mkProperty<ISparklineProps> "className" value
//     static member inline culture(value: string) = Interop.mkProperty<ISparklineProps> "culture" value
//     static member inline showLegend(value: bool) = Interop.mkProperty<ISparklineProps> "showLegend" value
//     static member inline styles(value: sparklineStyles list) = Interop.mkProperty<ISparklineProps> "styles" (value |> List.toArray)

// type [<Erase>] GVBarChartSeriesPoint =
//     static member inline key(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "key" value
//     static member inline data(value: float) = Interop.mkProperty<IGVBarChartSeriesPoint> "data" value
//     static member inline color(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "color" value
//     static member inline legend(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "legend" value
//     static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "xAxisCalloutData" value
//     static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "yAxisCalloutData" value
//     static member inline onClick(value: unit -> unit) = Interop.mkProperty<IGVBarChartSeriesPoint> "onClick" value
//     static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IGVBarChartSeriesPoint> "callOutAccessibilityData" (value |> List.toArray)
//     static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<IGVBarChartSeriesPoint> "useSecondaryYScale" value

type [<Erase>] horizontalDataPoint =
    /// Independent value of the data point, rendered along the x-axis.
    /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
    /// If x is a string, then the data is evenly spaced along the x-axis.
    static member inline x(value: int) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
    /// If x is a string, then the data is evenly spaced along the x-axis.
    static member inline x(value: decimal) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
    /// If x is a string, then the data is evenly spaced along the x-axis.
    static member inline x(value: float) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
    /// Total value of a single point bar chart.
    static member inline total(value: int) = Interop.mkProperty<IHorizontalDataPointProp> "total" value
    /// Total value of a single point bar chart.
    static member inline total(value: float) = Interop.mkProperty<IHorizontalDataPointProp> "total" value
    /// Total value of a single point bar chart.
    static member inline total(value: decimal) = Interop.mkProperty<IHorizontalDataPointProp> "total" value

// type [<Erase>] verticalBarChartDataPoint =
//     static member inline x(value: float) = Interop.mkProperty<IVerticalBarChartDataPoint> "x" value

//     static member inline x(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "x" value
//     static member inline x(value: DateTime) = Interop.mkProperty<IVerticalBarChartDataPoint> "x" value
//     static member inline y(value: float) = Interop.mkProperty<IVerticalBarChartDataPoint> "y" value
//     static member inline legend(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "legend" value
//     static member inline color(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "color" value
//     static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "xAxisCalloutData" value
//     static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "yAxisCalloutData" value
//     static member inline enableReflow(value: bool) = Interop.mkProperty "enableReflow" value
//     static member inline onClick(value: unit -> unit) = Interop.mkProperty<IVerticalBarChartDataPoint> "onClick" value
//     static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IVerticalBarChartDataPoint> "callOutAccessibilityData" (value |> List.toArray)

// module verticalBarChart =
//     type [<Erase>] barWidth =
//         static member inline ``default`` = Interop.mkProperty<IVerticalBarChartProps> "barWidth" "default"
//         static member inline auto = Interop.mkProperty<IVerticalBarChartProps> "barWidth" "auto"

//     type [<Erase>] mode =
//         static member inline ``default`` = Interop.mkProperty<IVerticalBarChartProps> "mode" "default"
//         static member inline plotly = Interop.mkProperty<IVerticalBarChartProps> "mode" "plotly"
//         static member inline histogram = Interop.mkProperty<IVerticalBarChartProps> "mode" "histogram"

//     type [<Erase>] style =
//         inherit cartesianChartStyles<IVerticalBarChartStyles>
//         static member inline barLabel(value: string) = Interop.mkProperty<IVerticalBarChartStyles> "barLabel" value
//         static member inline lineBorder(value: string) = Interop.mkProperty<IVerticalBarChartStyles> "lineBorder" value

// type [<Erase>] verticalBarChart =
//     static member inline data(value: IVerticalBarChartDataPoint list) = Interop.mkProperty<IVerticalBarChartProps> "data" (value |> List.toArray)

//     // TODO onRenderCalloutPerDataPoint

//     static member inline colors(value: string list) = Interop.mkProperty<IVerticalBarChartProps> "colors" (value |> List.toArray)
//     static member inline chartTitle(value: string) = Interop.mkProperty<IVerticalBarChartProps> "chartTitle" value
//     static member inline lineLegendText(value: string) = Interop.mkProperty<IVerticalBarChartProps> "lineLegendText" value
//     static member inline lineLegendColor(value: string) = Interop.mkProperty<IVerticalBarChartProps> "lineLegendColor" value
//     static member inline useSingleColor(value: string) = Interop.mkProperty<IVerticalBarChartProps> "useSingleColor" value
//     static member inline styles(value: IVerticalBarChartStyles list) = Interop.mkProperty<IVerticalBarChartProps> "styles" (value |> List.toArray)
//     static member inline culture(value: string) = Interop.mkProperty<IVerticalBarChartProps> "culture" value
//     static member inline xAxisPadding(value: float) = Interop.mkProperty<IVerticalBarChartProps> "xAxisPadding" value
//     static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "lineOptions" (keyValueList CaseRules.LowerFirst value)
//     static member inline hideLabels(value: bool) = Interop.mkProperty<IVerticalBarChartProps> "hideLabels" value
//     static member inline maxBarWidth(value: float) = Interop.mkProperty<IVerticalBarChartProps> "maxBarWidth" value
//     static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<IVerticalBarChartProps> "xAxisInnerPadding" value
//     static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<IVerticalBarChartProps> "xAxisOuterPadding" value
//     static member inline enableGradient(value: bool) = Interop.mkProperty<IVerticalBarChartProps> "enableGradient" value
//     static member inline roundCorners(value: bool) = Interop.mkProperty<IVerticalBarChartProps> "roundCorners" value

// type [<Erase>] VSChartDataPoint =
//     /// data the datapoint in the chart
//     static member inline data(value: float) = Interop.mkProperty<IVSChartDataPoint> "data" value
//     /// data the datapoint in the chart
//     static member inline data(value: string) = Interop.mkProperty<IVSChartDataPoint> "data" value
//     /// Legend text for the datapoint in the chart
//     static member inline legend(value: string) = Interop.mkProperty<IVSChartDataPoint> "legend" value
//     /// color for the legend in the chart
//     static member inline color(value: string) = Interop.mkProperty<IVSChartDataPoint> "color" value
//     /// Callout data for x axis
//     /// This is an optional prop, If haven't given legend will take
//     static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IVSChartDataPoint> "xAxisCalloutData" value
//     /// Accessibility data for callout
//     static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IVSChartDataPoint> "callOutAccessibilityData" (value |> List.toArray)
//     /// Callout data for y axis
//     /// This is an optional prop, If haven't given data will take
//     static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IVSChartDataPoint> "yAxisCalloutData" value
//     /// The prop used to define the culture to localized the numbers
//     static member inline culture(value: string) = Interop.mkProperty<IVSChartDataPoint> "culture" value

// module lineDataInVerticalStackedBarChart =
//     type [<Erase>] legendShape =
//         class
//             inherit legendShape<ILineDataInVerticalStackedBarChart>
//         end

// type [<Erase>] lineDataInVerticalStackedBarChart =
//     static member inline y(value: float) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "y" value
//     static member inline y(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "y" value
//     static member inline legend(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "legend" value
//     static member inline color(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "color" value
//     static member inline data(value: float) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "data" value
//     static member inline data(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "data" value
//     static member inline yAxisCalloutData(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "yAxisCalloutData" value
//     static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "useSecondaryYScale" value
//     static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "lineOptions" (keyValueList CaseRules.LowerFirst value)

// type [<Erase>] verticalStackBarChartProps =
//     static member inline chartData(value: IVSChartDataPoint list) = Interop.mkProperty<IVerticalStackedChartProps> "chartData" (value |> List.toArray)
//     static member inline xAxisPoint(value: float) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisPoint" value
//     static member inline xAxisPoint(value: string) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisPoint" value
//     static member inline xAxisPoint(value: DateTime) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisPoint" value
//     static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisCalloutData" value
//     static member inline lineData(value: ILineDataInVerticalStackedBarChart list) = Interop.mkProperty<IVerticalStackedChartProps> "lineData" (value |> List.toArray)
//     static member inline stackCallOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IVerticalStackedChartProps> "stackCallOutAccessibilityData" (value |> List.toArray)

// module verticalStackedBarChart =
//     type [<Erase>] barWidth =
//         static member inline ``default`` = Interop.mkProperty<IVerticalStackedBarChartProps> "barWidth" "default"
//         static member inline auto = Interop.mkProperty<IVerticalStackedBarChartProps> "barWidth" "auto"

//     type [<Erase>] mode =
//         static member inline ``default`` = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "default"
//         static member inline plotly = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "plotly"

//     type [<Erase>] styles =
//         inherit cartesianChartStyles<IVerticalStackedBarChartStyles>
//         static member inline opacityChangeOnHover(value: string) = Interop.mkProperty<IVerticalStackedBarChartStyles> "opacityChangeOnHover" value
//         static member inline barLabel(value: string) = Interop.mkProperty<IVerticalStackedBarChartStyles> "barLabel" value

//     type [<Erase>] reflowProps =
//         static member inline none = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "none"
//         static member inline minWidth = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "min-width"

// type [<Erase>] verticalStackedBarChart =
//     inherit cartesianChartProps<IVerticalStackedBarChartProps>
//     static member inline data(value: IVerticalStackedChartProps list) = Interop.mkProperty<IVerticalStackedBarChartProps> "data" (value |> List.toArray)
//     static member inline barGapMax(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "barGapMax" value
//     static member inline barCornerRadius(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "barCornerRadius" value
//     static member inline barMinimumHeight(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "barMinimumHeight" value //
//     static member inline chartTitle(value: string) = Interop.mkProperty<IVerticalStackedBarChartProps> "chartTitle" value
//     static member inline isCalloutForStack(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "isCalloutForStack" value
//     static member inline styles(value: IVerticalStackedBarChartStyles list) = Interop.mkProperty<IVerticalStackedBarChartProps> "styles" (value |> List.toArray)

//     // TODO onRenderCalloutPerStack
//     // TODO onRenderCalloutPerDataPoint

//     static member inline yMinValue(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "yMinValue" value
//     static member inline allowHoverOnLegend(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "allowHoverOnLegend" value
//     static member inline onBarClick(value: obj) =  Interop.mkProperty<IVerticalStackedBarChartProps> "onBarClick" value // TODO, use types instead of obj
//     static member inline culture(value: string) = Interop.mkProperty<IVerticalStackedBarChartProps> "culture" value
//     static member inline xAxisPadding(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "xAxisPadding" value
//     static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<IVerticalStackedBarChartProps> "lineOptions" (keyValueList CaseRules.LowerFirst value)
//     static member inline hideLabels(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "hideLabels" value
//     static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "xAxisInnerPadding" value
//     static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "xAxisOuterPadding" value
//     static member inline enableGradient(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "enableGradient" value
//     static member inline roundCorners(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "roundCorners" value
//     static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "showYAxisLablesTooltip" value
//     static member inline showYAxisLables(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "showYAxisLables" value

// type [<Erase>] chartTableData =
//     static member inline value(value: string) = Interop.mkProperty<IChartTableDataProps> "value" value
//     static member inline value(value: float) = Interop.mkProperty<IChartTableDataProps> "value" value
//     static member inline value(value: bool) = Interop.mkProperty<IChartTableDataProps> "value" value
//     static member inline value() = Interop.mkProperty<IChartTableDataProps> "value" null
//     static member inline style(properties: IStyleAttribute list) = Interop.mkProperty<IChartTableDataProps> "style" (createObj !!properties)

// type [<Erase>] chartTable =
//     static member inline headers(value: IChartTableDataProps list) = Interop.mkProperty<IChartTableProps> "headers" (value |> List.toArray)
//     static member inline rows(value: List<IChartTableDataProps list>) =
//         value
//         |> List.map List.toArray
//         |> Array.ofList
//         |> Interop.mkProperty<IChartTableProps> "rows"

//     static member inline width(value: string) = Interop.mkProperty<IChartTableProps> "width" value
//     static member inline width(value: float) = Interop.mkProperty<IChartTableProps> "width" value
//     static member inline height(value: string) = Interop.mkProperty<IChartTableProps> "height" value
//     static member inline height(value: float) = Interop.mkProperty<IChartTableProps> "height" value
//     static member inline className(value: string) = Interop.mkProperty<IChartTableProps> "className" value
//     static member inline styles(value: IChartTableStyles list) = Interop.mkProperty<IChartTableProps> "headers" (value |> List.toArray)

//     // TODO componentRef?: React_2.RefObject<Chart>; this correct?

//     static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<IChartTableProps> "componentRef" value

//------------------------------------------------------------------------- CartesianChart ----------------------------------------------------------------------
type [<Erase>] cartesianChart<'Property> =
    /// Below height used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: int) = Interop.mkProperty<'Property> "height" value
    /// Below height used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: decimal) = Interop.mkProperty<'Property> "height" value
    /// Below height used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: float) = Interop.mkProperty<'Property> "height" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: int) = Interop.mkProperty<'Property> "width" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: decimal) = Interop.mkProperty<'Property> "width" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: float) = Interop.mkProperty<'Property> "width" value
    /// This prop takes its parent as a HTML element to define the width and height of the chart
    static member inline parentRef(value: HTMLElement option) = Interop.mkProperty<'Property> "parentRef" value
    /// Additional CSS class(es) to apply to the Chart.
    static member inline className(value: string) = Interop.mkProperty<'Property> "className" value
    /// Margins for the chart
    /// @default `{ top: 20, bottom: 35, left: 40, right: 20 }`
    /// To avoid edge cuttings to the chart, we recommend you use default values or greater then default values
    static member inline margins(value: IMarginProp list) = Interop.mkProperty<'Property> "margins" (!!value |> createObj |> unbox)
    /// decides wether to show/hide legends
    static member inline hideLegend(value: bool) = Interop.mkProperty<'Property> "hideLegend" value
    /// Do not show tooltips in chart
    static member inline hideTooltip(value: bool) = Interop.mkProperty<'Property> "hideTooltip" value
    /// this prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    /// Please look at https://github.com/d3/d3-scale for more information on how D3 decides what data to appear on the axis of chart
    static member inline tickValues(value: int list) = Interop.mkProperty<'Property> "tickValues" (value |> List.toArray)
    /// this prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    /// Please look at https://github.com/d3/d3-scale for more information on how D3 decides what data to appear on the axis of chart
    static member inline tickValues(value: float list) = Interop.mkProperty<'Property> "tickValues" (value |> List.toArray)
    /// this prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    /// Please look at https://github.com/d3/d3-scale for more information on how D3 decides what data to appear on the axis of chart
    static member inline tickValues(value: decimal list) = Interop.mkProperty<'Property> "tickValues" (value |> List.toArray)
    /// this prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    /// Please look at https://github.com/d3/d3-scale for more information on how D3 decides what data to appear on the axis of chart
    static member inline tickValues(value: DateTime list) = Interop.mkProperty<'Property> "tickValues" (value |> List.toArray)
    /// this prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    /// Please look at https://github.com/d3/d3-scale for more information on how D3 decides what data to appear on the axis of chart
    static member inline tickValues(value: DateOnly list) = Interop.mkProperty<'Property> "tickValues" (value |> List.toArray)
    /// this prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    /// Please look at https://github.com/d3/d3-scale for more information on how D3 decides what data to appear on the axis of chart
    static member inline tickValues(value: string list) = Interop.mkProperty<'Property> "tickValues" (value |> List.toArray)
    /// the format for the data on x-axis. For date object this can be specified to your requirement. Eg: '%m/%d', '%d'
    /// Please look at https://github.com/d3/d3-time-format for all the formats supported for date axis
    /// Only applicable for date axis. For y-axis format use yAxisTickFormat prop.
    static member inline tickFormat(value: string) = Interop.mkProperty<'Property> "tickFormat" value
    /// Width of line stroke
    static member inline strokeWidth(value: int) = Interop.mkProperty<'Property> "strokeWidth" value
    /// Width of line stroke
    static member inline strokeWidth(value: float) = Interop.mkProperty<'Property> "strokeWidth" value
    /// Width of line stroke
    static member inline strokeWidth(value: decimal) = Interop.mkProperty<'Property> "strokeWidth" value
    /// x Axis labels tick padding. This defines the gap between tick labels and tick lines.
    static member inline xAxisTickPadding(value: int) = Interop.mkProperty<'Property> "xAxisTickPadding" value
    /// x Axis labels tick padding. This defines the gap between tick labels and tick lines.
    static member inline xAxisTickPadding(value: decimal) = Interop.mkProperty<'Property> "xAxisTickPadding" value
    /// x Axis labels tick padding. This defines the gap between tick labels and tick lines.
    static member inline xAxisTickPadding(value: float) = Interop.mkProperty<'Property> "xAxisTickPadding" value
    /// the format in for the data on y-axis. For data object this can be specified to your requirement.
    ///  Eg: d3.format(".0%")(0.123),d3.format("+20")(42);
    /// Please look at https://github.com/d3/d3-format for all the formats supported
    static member inline yAxisTickFormat(value: 'T) = Interop.mkProperty<'Property> "yAxisTickFormat" value
    /// Secondary y-scale options
    /// By default this is not defined, meaning there will be no secondary y-scale.
    static member inline secondaryYScaleOptions(value: ISecondaryYScaleOptionProp list) = Interop.mkProperty<'Property> "secondaryYScaleOptions" (!!value |> createObj |> unbox)
    /// minimum  data value point in y-axis
    static member inline yMinValue(value: int) = Interop.mkProperty<'Property> "yMinValue" value
    /// minimum  data value point in y-axis
    static member inline yMinValue(value: decimal) = Interop.mkProperty<'Property> "yMinValue" value
    /// minimum  data value point in y-axis
    static member inline yMinValue(value: float) = Interop.mkProperty<'Property> "yMinValue" value
    /// maximum  data value point in y-axis
    static member inline yMaxValue(value: int) = Interop.mkProperty<'Property> "yMaxValue" value
    /// maximum  data value point in y-axis
    static member inline yMaxValue(value: decimal) = Interop.mkProperty<'Property> "yMaxValue" value
    /// maximum  data value point in y-axis
    static member inline yMaxValue(value: float) = Interop.mkProperty<'Property> "yMaxValue" value
    /// maximum  data value point in x-axis
    static member inline xMaxValue(value: int) = Interop.mkProperty<'Property> "xMaxValue" value
    /// maximum  data value point in x-axis
    static member inline xMaxValue(value: decimal) = Interop.mkProperty<'Property> "xMaxValue" value
    /// maximum  data value point in x-axis
    static member inline xMaxValue(value: float) = Interop.mkProperty<'Property> "xMaxValue" value
    /// Number of ticks on the y-axis.
    /// Tick count should be factor of difference between (yMinValue, yMaxValue)?
    static member inline yAxisTickCount(value: int) = Interop.mkProperty<'Property> "yAxisTickCount" value
    /// Number of ticks on the y-axis.
    /// Tick count should be factor of difference between (yMinValue, yMaxValue)?
    static member inline yAxisTickCount(value: decimal) = Interop.mkProperty<'Property> "yAxisTickCount" value
    /// Number of ticks on the y-axis.
    /// Tick count should be factor of difference between (yMinValue, yMaxValue)?
    static member inline yAxisTickCount(value: float) = Interop.mkProperty<'Property> "yAxisTickCount" value
    /// defines the number of ticks on the x-axis. Tries to match the nearest interval satisfying the count.
    /// Does not work for string axis.
    static member inline xAxisTickCount(value: int) = Interop.mkProperty<'Property> "xAxisTickCount" value
    /// defines the number of ticks on the x-axis. Tries to match the nearest interval satisfying the count.
    /// Does not work for string axis.
    static member inline xAxisTickCount(value: decimal) = Interop.mkProperty<'Property> "xAxisTickCount" value
    /// defines the number of ticks on the x-axis. Tries to match the nearest interval satisfying the count.
    /// Does not work for string axis.
    static member inline xAxisTickCount(value: float) = Interop.mkProperty<'Property> "xAxisTickCount" value
    /// define the size of the tick lines on the x-axis
    static member inline xAxistickSize(value: int) = Interop.mkProperty<'Property> "xAxistickSize" value
    /// define the size of the tick lines on the x-axis
    static member inline xAxistickSize(value: decimal) = Interop.mkProperty<'Property> "xAxistickSize" value
    /// define the size of the tick lines on the x-axis
    static member inline xAxistickSize(value: float) = Interop.mkProperty<'Property> "xAxistickSize" value
    /// defines the space between the tick line and the data label
    static member inline tickPadding(value: int) = Interop.mkProperty<'Property> "tickPadding" value
    /// defines the space between the tick line and the data label
    static member inline tickPadding(value: decimal) = Interop.mkProperty<'Property> "tickPadding" value
    /// defines the space between the tick line and the data label
    static member inline tickPadding(value: float) = Interop.mkProperty<'Property> "tickPadding" value
    /// Url that the data-viz needs to redirect to upon clicking on it
    static member inline href(value: string) = Interop.mkProperty<'Property> "href" value
    static member inline legendsOverflowText(value: 'T) = Interop.mkProperty<'Property> "legendsOverflowText" value
    /// Enable the legends to wrap lines if there is not enough space to show all legends on a single line
    static member inline enabledLegendsWrapLines(value: bool) = Interop.mkProperty<'Property> "enabledLegendsWrapLines" value
    static member inline legendProps(value: ILegendsProp list) = Interop.mkProperty<'Property> "legendProps" (!!value |> createObj |> unbox)
    /// Used for to elipse x axis labes and show tooltip on x axis labels
    static member inline showXAxisLablesTooltip(value: bool) = Interop.mkProperty<'Property> "showXAxisLablesTooltip" value
    /// Used for X axis labels. While Giving showXAxisLablesTooltip prop, need to define after how many chars, we need to truncate the word.
    static member inline noOfCharsToTruncate(value: int) = Interop.mkProperty<'Property> "noOfCharsToTruncate" value
    /// Used for X axis labels. While Giving showXAxisLablesTooltip prop, need to define after how many chars, we need to truncate the word.
    static member inline noOfCharsToTruncate(value: float) = Interop.mkProperty<'Property> "noOfCharsToTruncate" value
    /// Used for X axis labels. While Giving showXAxisLablesTooltip prop, need to define after how many chars, we need to truncate the word.
    static member inline noOfCharsToTruncate(value: decimal) = Interop.mkProperty<'Property> "noOfCharsToTruncate" value
    /// Used to wrap x axis labels values (whole value)
    static member inline wrapXAxisLables(value: bool) = Interop.mkProperty<'Property> "wrapXAxisLables" value
    /// Used to rotate x axis labels by 45 degrees
    static member inline rotateXAxisLables(value: bool) = Interop.mkProperty<'Property> "rotateXAxisLables" value
    /// The prop used to define the date time localization options
    static member inline dateLocalizeOptions(value: IDateTimeFormatOptionsProp list) = Interop.mkProperty<'Property> "dateLocalizeOptions" (!!value |> createObj |> unbox)
    /// The prop used to define a custom locale for the date time format.
    static member inline timeFormatLocale(value: ITimeLocaleDefinitionProp list) = Interop.mkProperty<'Property> "timeFormatLocale" (!!value |> createObj |> unbox)
    /// The prop used to define a custom datetime formatter for date axis.
    static member inline customDateTimeFormatter(value: DateTime -> string) = Interop.mkProperty<'Property> "customDateTimeFormatter" (System.Func<_,_> value)
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: ICartesianChartStylesProp list) = Interop.mkProperty<'Property> "styles" (!!value |> createObj |> unbox)
    /// Callout customization props
    static member inline calloutProps(value: IChartPopoverProp list) = Interop.mkProperty<'Property> "calloutProps" (!!value |> createObj |> unbox)
    /// props for the svg; use this to include aria-* or other attributes on the tag
    static member inline svgProps(value: IReactProperty list) = Interop.mkProperty<'Property> "svgProps" (!!value |> createObj |> unbox)
    /// Prop to disable shrinking of the chart beyond a certain limit and enable scrolling when the chart overflows
    static member inline enableReflow(value: bool) = Interop.mkProperty<'Property> "enableReflow" value
    /// Prop to set the x axis title. Minimum bottom margin required for x axis title is 55px
    static member inline xAxisTitle(value: string) = Interop.mkProperty<'Property> "xAxisTitle" value
    /// Prop to set the y axis title
    /// Minimum left margin required for y axis title is 60px and for RTL is 40px
    /// Minimum right margin required for y axis title is 40px and for RTL is 60px
    static member inline yAxisTitle(value: string) = Interop.mkProperty<'Property> "yAxisTitle" value
    /// Prop to set the secondary y axis title
    /// If RTL is enabled, minimum left and right margins required for secondary y axis title is 60px
    static member inline secondaryYAxistitle(value: string) = Interop.mkProperty<'Property> "secondaryYAxistitle" value
    /// Whether to use UTC time for axis scale, ticks, and the time display in callouts.
    /// When set to `true`, time is displayed equally, regardless of the user's timezone settings.
    static member inline useUTC(value: string) = Interop.mkProperty<'Property> "useUTC" value
    /// Whether to use UTC time for axis scale, ticks, and the time display in callouts.
    /// When set to `true`, time is displayed equally, regardless of the user's timezone settings.
    static member inline useUTC(value: bool) = Interop.mkProperty<'Property> "useUTC" value
    /// The prop used to decide rounded ticks on y axis
    static member inline roundedTicks(value: bool) = Interop.mkProperty<'Property> "roundedTicks" value
    /// Determines whether overlapping x-axis tick labels should be hidden.
    static member inline hideTickOverlap(value: bool) = Interop.mkProperty<'Property> "hideTickOverlap" value
    /// Define a custom callout props override
    static member inline calloutPropsPerDataPoint (value: 'T -> ChartPopoverProps) = Interop.mkProperty<'Property> "calloutPropsPerDataPoint" (System.Func<_,_> value)
    /// Optional callback to access the Chart interface. Use this instead of ref for accessing the public methods and properties of the component.
    static member inline componentRef (value: RefObject<Chart>) = Interop.mkProperty<'Property> "componentRef" value
    /// Prop to set the x axis annotation. Used to display additional information on the x-axis.
    /// This is shown on the top of the chart.
    static member inline xAxisAnnotation (value: string) = Interop.mkProperty<'Property> "xAxisAnnotation" value
    /// Prop to set the y axis annotation. Used to display additional information on the y-axis.
    /// This is shown on the right side of the chart. Not shown if secondary y-axis is enabled.
    static member inline yAxisAnnotation (value: string) = Interop.mkProperty<'Property> "yAxisAnnotation" value
    /// Specifies the ordering logic for categories (or string tick labels) on the x-axis.
    static member inline xAxisCategoryOrder (value: AxisCategoryOrder) = Interop.mkProperty<'Property> "xAxisCategoryOrder" value
    /// Specifies the ordering logic for categories (or string tick labels) on the y-axis.
    static member inline yAxisCategoryOrder (value: AxisCategoryOrder) = Interop.mkProperty<'Property> "yAxisCategoryOrder" value
    /// Defines the scale type for the x-axis.
    static member inline xScaleType (value: AxisScaleType) = Interop.mkProperty<'Property> "xScaleType" value
    /// Defines the scale type for the y-axis.
    static member inline yScaleType (value: AxisScaleType) = Interop.mkProperty<'Property> "yScaleType" value
    /// Defines the scale type for the secondary y-axis.
    static member inline secondaryYScaleType (value: AxisScaleType) = Interop.mkProperty<'Property> "secondaryYScaleType" value
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation.
    static member inline yAxisTickValues (value: int list) = Interop.mkProperty<'Property> "yAxisTickValues" (value |> List.toArray)
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation.
    static member inline yAxisTickValues (value: float list) = Interop.mkProperty<'Property> "yAxisTickValues" (value |> List.toArray)
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation.
    static member inline yAxisTickValues (value: decimal list) = Interop.mkProperty<'Property> "yAxisTickValues" (value |> List.toArray)
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation.
    static member inline yAxisTickValues (value: DateTime list) = Interop.mkProperty<'Property> "yAxisTickValues" (value |> List.toArray)
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation.
    static member inline yAxisTickValues (value: string list) = Interop.mkProperty<'Property> "yAxisTickValues" (value |> List.toArray)
    /// If provided, these values override automatic tick generation.
    static member inline xAxis (value: string list) = Interop.mkProperty<'Property> "xAxis" (value |> List.toArray)

//----------------------------------------------------------------- Margins -------------------------------------------------
type [<Erase>] margin =
    /// Left margin for the chart.
    static member inline left(value: int) = Interop.mkProperty<IMarginProp> "left" value
    /// Left margin for the chart.
    static member inline left(value: decimal) = Interop.mkProperty<IMarginProp> "left" value
    /// Left margin for the chart.
    static member inline left(value: float) = Interop.mkProperty<IMarginProp> "left" value
    /// Right margin for the chart.
    static member inline right(value: int) = Interop.mkProperty<IMarginProp> "right" value
    /// Right margin for the chart.
    static member inline right(value: decimal) = Interop.mkProperty<IMarginProp> "right" value
    /// Right margin for the chart.
    static member inline right(value: float) = Interop.mkProperty<IMarginProp> "right" value
    /// Top margin for the chart.
    static member inline top(value: int) = Interop.mkProperty<IMarginProp> "top" value
    /// Top margin for the chart.
    static member inline top(value: decimal) = Interop.mkProperty<IMarginProp> "top" value
    /// Top margin for the chart.
    static member inline top(value: float) = Interop.mkProperty<IMarginProp> "top" value
    /// Bottom margin for the chart.
    static member inline bottom(value: int) = Interop.mkProperty<IMarginProp> "bottom" value
    /// Bottom margin for the chart.
    static member inline bottom(value: decimal) = Interop.mkProperty<IMarginProp> "bottom" value
    /// Bottom margin for the chart.
    static member inline bottom(value: float) = Interop.mkProperty<IMarginProp> "bottom" value

//----------------------------------------------------------------- SecondaryYScaleOption -------------------------------------------------
type [<Erase>] secondaryYScaleOption =
    static member inline yMinValue(value: int) = Interop.mkProperty<ISecondaryYScaleOptionProp> "yMinValue" value
    static member inline yMinValue(value: decimal) = Interop.mkProperty<ISecondaryYScaleOptionProp> "yMinValue" value
    static member inline yMinValue(value: float) = Interop.mkProperty<ISecondaryYScaleOptionProp> "yMinValue" value
    static member inline yMaxValue(value: int) = Interop.mkProperty<ISecondaryYScaleOptionProp> "yMaxValue" value
    static member inline yMaxValue(value: decimal) = Interop.mkProperty<ISecondaryYScaleOptionProp> "yMaxValue" value
    static member inline yMaxValue(value: float) = Interop.mkProperty<ISecondaryYScaleOptionProp> "yMaxValue" value

//----------------------------------------------------------------- DateTimeFormatOptions -------------------------------------------------
type [<Erase>] dateTimeFormatOptions =
    static member inline calendar (value: string) = Interop.mkProperty<IDateTimeFormatOptionsProp> "calendar" value
    static member inline numberingSystem (value: string) = Interop.mkProperty<IDateTimeFormatOptionsProp> "numberingSystem" value

module dateTimeFormatOptions =
    type [<Erase>] dayPeriod =
        static member inline narrow = Interop.mkProperty<IDateTimeFormatOptionsProp> "dayPeriod" "narrow"
        static member inline short = Interop.mkProperty<IDateTimeFormatOptionsProp> "dayPeriod" "short"
        static member inline long = Interop.mkProperty<IDateTimeFormatOptionsProp> "dayPeriod" "long"
    type [<Erase>] dateStyle =
        static member inline full = Interop.mkProperty<IDateTimeFormatOptionsProp> "dateStyle" "full"
        static member inline long = Interop.mkProperty<IDateTimeFormatOptionsProp> "dateStyle" "long"
        static member inline medium = Interop.mkProperty<IDateTimeFormatOptionsProp> "dateStyle" "medium"
        static member inline short = Interop.mkProperty<IDateTimeFormatOptionsProp> "dateStyle" "short"
    type [<Erase>] timeStyle =
        static member inline full = Interop.mkProperty<IDateTimeFormatOptionsProp> "timeStyle" "full"
        static member inline long = Interop.mkProperty<IDateTimeFormatOptionsProp> "timeStyle" "long"
        static member inline medium = Interop.mkProperty<IDateTimeFormatOptionsProp> "timeStyle" "medium"
        static member inline short = Interop.mkProperty<IDateTimeFormatOptionsProp> "timeStyle" "short"
    type [<Erase>] hourCycle =
        static member inline h11 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h11"
        static member inline h12 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h12"
        static member inline h23 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h23"
        static member inline h24 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h24"

//----------------------------------------------------------------- CartesianChartStyles -------------------------------------------------
type [<Erase>] cartesianChartStyles = sharedCartesianChartStyles<ICartesianChartStylesProp>

//----------------------------------------------------------------- ChartPopoverProps -------------------------------------------------
type [<Erase>] chartPopoverProp =
    ///  Style for the root element
    static member inline clickPosition (value: ClickPosition) = Interop.mkProperty<IChartPopoverProp> "clickPosition" value
    static member inline isPopoverOpen (value: bool) = Interop.mkProperty<IChartPopoverProp> "isPopoverOpen" value
    static member inline xCalloutValue (value: string) = Interop.mkProperty<IChartPopoverProp> "xCalloutValue" value
    static member inline legend (value: string) = Interop.mkProperty<IChartPopoverProp> "legend" value
    static member inline legend (value: int) = Interop.mkProperty<IChartPopoverProp> "legend" value
    static member inline legend (value: float) = Interop.mkProperty<IChartPopoverProp> "legend" value
    static member inline legend (value: decimal) = Interop.mkProperty<IChartPopoverProp> "legend" value
    static member inline legend (value: DateTime) = Interop.mkProperty<IChartPopoverProp> "legend" value
    static member inline yCalloutValue (value: string) = Interop.mkProperty<IChartPopoverProp> "yCalloutValue" value
    static member inline yValue (value: string) = Interop.mkProperty<IChartPopoverProp> "YValue" value
    static member inline yValue (value: int) = Interop.mkProperty<IChartPopoverProp> "YValue" value
    static member inline yValue (value: float) = Interop.mkProperty<IChartPopoverProp> "YValue" value
    static member inline yValue (value: decimal) = Interop.mkProperty<IChartPopoverProp> "YValue" value
    static member inline yValue (value: DateTime) = Interop.mkProperty<IChartPopoverProp> "YValue" value
    static member inline XValue (value: string) = Interop.mkProperty<IChartPopoverProp> "XValue" value
    static member inline color (value: string) = Interop.mkProperty<IChartPopoverProp> "color" value
    static member inline culture (value: string) = Interop.mkProperty<IChartPopoverProp> "culture" value
    static member inline isCalloutForStack (value: bool) = Interop.mkProperty<IChartPopoverProp> "isCalloutForStack" value
    static member inline hoverXValue (value: string) = Interop.mkProperty<IChartPopoverProp> "hoverXValue" value
    static member inline hoverXValue (value: int) = Interop.mkProperty<IChartPopoverProp> "hoverXValue" value
    static member inline hoverXValue (value: decimal) = Interop.mkProperty<IChartPopoverProp> "hoverXValue" value
    static member inline hoverXValue (value: float) = Interop.mkProperty<IChartPopoverProp> "hoverXValue" value
    static member inline YValueHover (value: IYValueHoverProp list list) = Interop.mkProperty<IChartPopoverProp> "YValueHover" (value |> createObjArray)
    static member inline descriptionMessage (value: string) = Interop.mkProperty<IChartPopoverProp> "descriptionMessage" value
    static member inline ratio (value: list<int * int>) = Interop.mkProperty<IChartPopoverProp> "ratio" (value |> List.toArray)
    static member inline ratio (value: list<float * float>) = Interop.mkProperty<IChartPopoverProp> "ratio" (value |> List.toArray)
    static member inline ratio (value: list<decimal * decimal>) = Interop.mkProperty<IChartPopoverProp> "ratio" (value |> List.toArray)
    static member inline isCartesian (value: bool) = Interop.mkProperty<IChartPopoverProp> "isCartesian" value
    static member inline styles (value: IPopoverComponentStylesProp list) = Interop.mkProperty<IChartPopoverProp> "styles" (!!value |> createObj |> unbox)

module chartPopoverProp =
    type [<Erase>] customCallout =
        static member inline customizedCallout (value: ReactElement) = Interop.mkProperty<IChartPopoverProp> "customCallout" {| customizedCallout = value|}
        static member inline customCalloutProps (value: IChartPopoverProp list) = Interop.mkProperty<IChartPopoverProp> "customCallout" {| customCalloutProps = (!!value |> createObj |> unbox)|}
    type [<Erase>] xAxisCalloutAccessibilityData =
        static member inline ariaLabel (value: string) = Interop.mkProperty<IChartPopoverProp> "xAxisCalloutAccessibilityData" {| ariaLabel = value |}
        static member inline data (value: string) = Interop.mkProperty<IChartPopoverProp> "xAxisCalloutAccessibilityData" {| data = value |}

//----------------------------------------------------------------- YValueHover -------------------------------------------------
type [<Erase>] yValueHover =
    static member inline legend (value: string) = Interop.mkProperty<IYValueHoverProp> "legend" value
    static member inline y (value: string) = Interop.mkProperty<IYValueHoverProp> "y" value
    static member inline y (value: int) = Interop.mkProperty<IYValueHoverProp> "y" value
    static member inline y (value: decimal) = Interop.mkProperty<IYValueHoverProp> "y" value
    static member inline y (value: float) = Interop.mkProperty<IYValueHoverProp> "y" value
    static member inline color (value: string) = Interop.mkProperty<IYValueHoverProp> "color" value
    static member inline data (value: string) = Interop.mkProperty<IYValueHoverProp> "data" value
    static member inline data (value: int) = Interop.mkProperty<IYValueHoverProp> "data" value
    static member inline data (value: float) = Interop.mkProperty<IYValueHoverProp> "data" value
    static member inline data (value: decimal) = Interop.mkProperty<IYValueHoverProp> "data" value
    static member inline shouldDrawBorderBottom (value: bool) = Interop.mkProperty<IYValueHoverProp> "shouldDrawBorderBottom" value
    static member inline yAxisCalloutData (value: bool) = Interop.mkProperty<IYValueHoverProp> "yAxisCalloutData" value
    static member inline index (value: int) = Interop.mkProperty<IYValueHoverProp> "index" value
    static member inline index (value: float) = Interop.mkProperty<IYValueHoverProp> "index" value
    static member inline index (value: decimal) = Interop.mkProperty<IYValueHoverProp> "index" value
    static member inline callOutAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<IYValueHoverProp> "callOutAccessibilityData" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- AccessibilityProp -------------------------------------------------
type [<Erase>] accessibility =
    static member inline ariaLabel (value: string) = Interop.mkProperty<IAccessibilityProp> "ariaLabel" value
    static member inline ariaLabelledBy (value: string) = Interop.mkProperty<IAccessibilityProp> "ariaLabelledBy" value
    static member inline ariaDescribedBy (value: string) = Interop.mkProperty<IAccessibilityProp> "ariaDescribedBy" value

//----------------------------------------------------------------- PopoverComponentStyles -------------------------------------------------
type [<Erase>] popoverComponentStyles =
    static member inline calloutContentRoot (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutContentRoot" value
    static member inline calloutDateTimeContainer (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutDateTimeContainer" value
    static member inline calloutContentX (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutContentX" value
    static member inline calloutBlockContainer (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutBlockContainer" value
    static member inline calloutBlockContainertoDrawShapefalse (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutBlockContainertoDrawShapefalse" value
    static member inline calloutBlockContainertoDrawShapetrue (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutBlockContainertoDrawShapetrue" value
    static member inline shapeStyles (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "shapeStyles" value
    static member inline calloutlegendText (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutlegendText" value
    static member inline calloutContentY (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutContentY" value
    static member inline descriptionMessage (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "descriptionMessage" value
    static member inline ratio (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "ratio" value
    static member inline numerator (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "numerator" value
    static member inline denominator (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "denominator" value
    static member inline calloutInfoContainer (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutInfoContainer" value
    static member inline calloutContainer (value: string) = Interop.mkProperty<IPopoverComponentStylesProp> "calloutContainer" value

//----------------------------------------------------------------- AreaChart -------------------------------------------------
type [<Erase>] areaChart =
    inherit cartesianChart<IAreaChartProp>
    /// Data to render in the chart.
    static member inline data(value: IChartProp list) = Interop.mkProperty<IAreaChartProp> "data" (!!value |> createObj |> unbox)
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: ICartesianChartStylesProp list) = Interop.mkProperty<IAreaChartProp> "styles" (!!value |> createObj |> unbox)
    /// Define a custom callout renderer for a data point
    static member inline onRenderCalloutPerDataPoint (handler: CustomizedCalloutData option -> ReactElement) =
                            Interop.mkProperty<IAreaChartProp> "onRenderCalloutPerDataPoint" (System.Func<_,_,_> (fun value _ -> handler value))
    /// Define a custom callout renderer for a stack; default is to render per data point
    static member inline onRenderCalloutPerStack (handler: CustomizedCalloutData option -> ReactElement) =
                            Interop.mkProperty<IAreaChartProp> "onRenderCalloutPerStack" (System.Func<_,_,_> (fun value _ -> handler value))
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IAreaChartProp> "culture" value
    static member inline enablePerfOptimization(value: bool) = Interop.mkProperty<IAreaChartProp> "enablePerfOptimization" value
    /// The prop used to enable the perf optimization
    static member inline optimizeLargeData(value: bool) = Interop.mkProperty<IAreaChartProp> "optimizeLargeData" value
    /// The prop used to enable gradient fill color for the chart.
    static member inline enableGradient(value: bool) = Interop.mkProperty<IAreaChartProp> "enableGradient" value

module areaChart =
    type [<Erase>] reflowProps = reflowProps<IAreaChartProp>
    type [<Erase>] xAxis = xAxis<IAreaChartProp>
    type [<Erase>] yAxis = yAxis<IAreaChartProp>
    /// The prop used to define the Y axis mode (tonexty or tozeroy)
    type [<Erase>] mode =
        static member inline tozeroy = Interop.mkProperty<IAreaChartProp> "mode" "tozeroy"
        static member inline tonexty = Interop.mkProperty<IAreaChartProp> "mode" "tonexty"

//----------------------------------------------------------------- Chart -------------------------------------------------
type [<Erase>] chart =
    /// Chart title for the chart
    static member inline chartTitle (value: string) = Interop.mkProperty<IChartProp> "chartTitle" value
    /// Accessibility data for chart title
    static member inline chartTitleAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<IChartProp> "chartTitleAccessibilityData" (!!value |> createObj |> unbox)
    /// data for the points in the chart
    static member inline chartData (value: IChartDataPointProp list list) = Interop.mkProperty<IChartProp> "chartData" (value |> createObjArray)
    /// Accessibility data for chart data
    static member inline chartDataAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<IChartProp> "chartDataAccessibilityData" (!!value |> createObj |> unbox)
    /// data for the points in the line chart
    static member inline lineChartData (value: ILineChartPointsProp list list) = Interop.mkProperty<IChartProp> "lineChartData" (value |> createObjArray)
    /// data for the points in the scatter chart
    static member inline scatterChartData (value: IScatterChartPointsProp list list) = Interop.mkProperty<IChartProp> "scatterChartData" (value |> createObjArray)
    /// data for the points in the line chart
    static member inline sankeyChartData (value: ISankeyChartDataProp list list) = Interop.mkProperty<IChartProp> "SankeyChartData" (value |> createObjArray)
    /// data for the points in the line chart
    static member inline pointOptions (value: IReactProperty list) = Interop.mkProperty<IChartProp> "pointOptions" (!!value |> createObj |> unbox)
    /// data for the dotted line on hovering the point
    static member inline pointLineOptions (value: IReactProperty list) = Interop.mkProperty<IChartProp> "pointLineOptions" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- ChartDataPoint -------------------------------------------------
type [<Erase>] chartDataPoint =
    /// Legend text for the datapoint in the chart
    static member inline legend (value: string) = Interop.mkProperty<IChartDataPointProp> "legend" value
    /// data the datapoint in the chart
    static member inline data (value: int) = Interop.mkProperty<IChartDataPointProp> "data" value
    /// data the datapoint in the chart
    static member inline data (value: float) = Interop.mkProperty<IChartDataPointProp> "data" value
    /// data the datapoint in the chart
    static member inline data (value: decimal) = Interop.mkProperty<IChartDataPointProp> "data" value
    /// data the datapoint in the chart
    static member inline horizontalBarChartdata (value: IHorizontalDataPointProp list) = Interop.mkProperty<IChartDataPointProp> "horizontalBarChartdata" (!!value |> createObj |> unbox)
    /// onClick action for each datapoint in the chart
    static member inline onClick (value: unit -> unit) = Interop.mkProperty<IChartDataPointProp> "onClick" (System.Func<_,_> value)
    /// Color for the legend in the chart. If not provided, it will fallback on the default color palette.
    static member inline color (value: string) = Interop.mkProperty<IChartDataPointProp> "color" value
    /// placeholder data point
    static member inline placeHolder (value: bool) = Interop.mkProperty<IChartDataPointProp> "placeHolder" value
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData (value: string) = Interop.mkProperty<IChartDataPointProp> "xAxisCalloutData" value
    /// Callout data for y axis
    /// This is an optional prop, If haven't given legend will take
    static member inline yAxisCalloutData (value: string) = Interop.mkProperty<IChartDataPointProp> "yAxisCalloutData" value
    static member inline callOutAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<IChartDataPointProp> "callOutAccessibilityData" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- LineChartPoints -------------------------------------------------
type [<Erase>] lineChartPoints =
    /// Legend text for the datapoint in the chart
    static member inline legend (value: string) = Interop.mkProperty<ILineChartPointsProp> "legend" value
    /// dataPoints for the line chart
    static member inline data (value: ILineChartDataPointProp list list) = Interop.mkProperty<ILineChartPointsProp> "data" (value |> createObjArray)
    /// dataPoints for the line chart
    static member inline data (value: IScatterChartDataPointProp list list) = Interop.mkProperty<ILineChartPointsProp> "data" (value |> createObjArray)
    /// dataPoints for the line chart
    static member inline data (value: 'T list) = Interop.mkProperty<ILineChartPointsProp> "data" (value |> List.toArray)
    /// Legend text for the datapoint in the chart
    static member inline gaps (value: ILineChartGapProp list list) = Interop.mkProperty<ILineChartPointsProp> "gaps" (value |> createObjArray)
    /// color for the legend in the chart
    static member inline color (value: string) = Interop.mkProperty<ILineChartPointsProp> "color" value
    /// opacity for chart fill color
    static member inline opacity (value: int) = Interop.mkProperty<ILineChartPointsProp> "opacity" value
    /// opacity for chart fill color
    static member inline opacity (value: float) = Interop.mkProperty<ILineChartPointsProp> "opacity" value
    /// opacity for chart fill color
    static member inline opacity (value: decimal) = Interop.mkProperty<ILineChartPointsProp> "opacity" value
    /// options for the line drawn
    static member inline lineOptions (value: ILineChartLineOptionsProp list) = Interop.mkProperty<ILineChartPointsProp> "lineOptions" (!!value |> createObj |> unbox)
    /// options for the line drawn
    static member inline hideNonActiveDots (value: bool) = Interop.mkProperty<ILineChartPointsProp> "hideNonActiveDots" value
    /// Defines the function that is executed on clicking this legend
    static member inline onLegendClick (value: string -> unit) = Interop.mkProperty<ILineChartPointsProp> "onLegendClick" (System.Func<_,_> value)
    /// Defines the function that is executed on clicking this legend
    static member inline onLegendClick (value: string array -> unit) = Interop.mkProperty<ILineChartPointsProp> "onLegendClick" (System.Func<_,_> value)
    /// Defines the function that is executed on clicking  line
    static member inline onLineClick (value: unit -> unit) = Interop.mkProperty<ILineChartPointsProp> "onLineClick" (System.Func<_,_> value)
    /// Whether to use the secondary y scale or not
    static member inline useSecondaryYScale (value: bool) = Interop.mkProperty<ILineChartPointsProp> "useSecondaryYScale" value

module lineChartPoints =

    /// The shape for the legend
    type [<Erase>] legendShape =
        static member inline default' = Interop.mkProperty<ILineChartPointsProp> "legendShape" "default"
        static member inline circle = Interop.mkProperty<ILineChartPointsProp> "legendShape" "circle"
        static member inline square = Interop.mkProperty<ILineChartPointsProp> "legendShape" "square"
        static member inline triangle = Interop.mkProperty<ILineChartPointsProp> "legendShape" "triangle"
        static member inline pyramid = Interop.mkProperty<ILineChartPointsProp> "legendShape" "pyramid"
        static member inline hexagon = Interop.mkProperty<ILineChartPointsProp> "legendShape" "hexagon"
        static member inline pentagon = Interop.mkProperty<ILineChartPointsProp> "legendShape" "pentagon"
        static member inline octagon = Interop.mkProperty<ILineChartPointsProp> "legendShape" "octagon"
        static member inline diamond = Interop.mkProperty<ILineChartPointsProp> "legendShape" "diamond"
        static member inline dottedLine = Interop.mkProperty<ILineChartPointsProp> "legendShape" "dottedLine"

//----------------------------------------------------------------- LineChartDataPoint -------------------------------------------------
type [<Erase>] lineChartDataPoint =
    inherit baseDataPoint<ILineChartDataPointProp>
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: int) = Interop.mkProperty<ILineChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: decimal) = Interop.mkProperty<ILineChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: float) = Interop.mkProperty<ILineChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: DateTime) = Interop.mkProperty<ILineChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: DateOnly) = Interop.mkProperty<ILineChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: int) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: decimal) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: float) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: DateTime) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: DateOnly) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// text labels of marker points
    static member inline text (value: string) = Interop.mkProperty<ILineChartDataPointProp> "text" value

//----------------------------------------------------------------- ScatterChartDataPoint -------------------------------------------------
type [<Erase>] scatterChartDataPoint =
    inherit baseDataPoint<IScatterChartDataPointProp>
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: int) = Interop.mkProperty<IScatterChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: decimal) = Interop.mkProperty<IScatterChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: float) = Interop.mkProperty<IScatterChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: DateTime) = Interop.mkProperty<IScatterChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the x-axis.
    static member inline x (value: string) = Interop.mkProperty<IScatterChartDataPointProp> "x" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: string) = Interop.mkProperty<IScatterChartDataPointProp> "y" value
    /// text labels of marker points
    static member inline text (value: string) = Interop.mkProperty<IScatterChartDataPointProp> "text" value
    /// Marker size of the points
    static member inline markerSize (value: int) = Interop.mkProperty<IScatterChartDataPointProp> "markerSize" value
    /// Marker size of the points
    static member inline markerSize (value: float) = Interop.mkProperty<IScatterChartDataPointProp> "markerSize" value
    /// Marker size of the points
    static member inline markerSize (value: decimal) = Interop.mkProperty<IScatterChartDataPointProp> "markerSize" value

//----------------------------------------------------------------- LineChartGap -------------------------------------------------
type [<Erase>] lineChartGap =
    /// Starting index of the gap.
    static member inline startIndex (value: int) = Interop.mkProperty<ILineChartGapProp> "startIndex" value
    /// Starting index of the gap.
    static member inline startIndex (value: decimal) = Interop.mkProperty<ILineChartGapProp> "startIndex" value
    /// Starting index of the gap.
    static member inline startIndex (value: float) = Interop.mkProperty<ILineChartGapProp> "startIndex" value
    /// Ending index of the gap.
    static member inline endIndex (value: int) = Interop.mkProperty<ILineChartGapProp> "endIndex" value
    /// Ending index of the gap.
    static member inline endIndex (value: decimal) = Interop.mkProperty<ILineChartGapProp> "endIndex" value
    /// Ending index of the gap.
    static member inline endIndex (value: float) = Interop.mkProperty<ILineChartGapProp> "endIndex" value

//----------------------------------------------------------------- LineChartLineOptions -------------------------------------------------
type [<Erase>] lineChartLineOptions =
    /// Width of the line/stroke.
    static member inline strokeWidth (value: string) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeWidth" value
    /// Width of the line/stroke.
    static member inline strokeWidth (value: int) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeWidth" value
    /// Width of the line/stroke.
    static member inline strokeWidth (value: decimal) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeWidth" value
    /// Width of the line/stroke.
    static member inline strokeWidth (value: float) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeWidth" value
    /// Pattern of dashes and gaps.
    static member inline strokeDasharray (value: string) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDasharray" value
    /// Pattern of dashes and gaps.
    static member inline strokeDasharray (value: int) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDasharray" value
    /// Pattern of dashes and gaps.
    static member inline strokeDasharray (value: decimal) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDasharray" value
    /// Pattern of dashes and gaps.
    static member inline strokeDasharray (value: float) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDasharray" value
    /// Offset on rendering of stroke dash array.
    static member inline strokeDashoffset (value: string) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDashoffset" value
    /// Offset on rendering of stroke dash array.
    static member inline strokeDashoffset (value: int) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDashoffset" value
    /// Offset on rendering of stroke dash array.
    static member inline strokeDashoffset (value: decimal) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDashoffset" value
    /// Offset on rendering of stroke dash array.
    static member inline strokeDashoffset (value: float) = Interop.mkProperty<ILineChartLineOptionsProp> "strokeDashoffset" value
    /// Width of border around the line. Default no border.
    static member inline lineBorderWidth (value: string) = Interop.mkProperty<ILineChartLineOptionsProp> "lineBorderWidth" value
    /// Width of border around the line. Default no border.
    static member inline lineBorderWidth (value: int) = Interop.mkProperty<ILineChartLineOptionsProp> "lineBorderWidth" value
    /// Width of border around the line. Default no border.
    static member inline lineBorderWidth (value: decimal) = Interop.mkProperty<ILineChartLineOptionsProp> "lineBorderWidth" value
    /// Width of border around the line. Default no border.
    static member inline lineBorderWidth (value: float) = Interop.mkProperty<ILineChartLineOptionsProp> "lineBorderWidth" value
    /// Color of border around the line. Default white.
    static member inline lineBorderColor (value: string) = Interop.mkProperty<ILineChartLineOptionsProp> "lineBorderColor" value

module lineChartLineOptions =
    /// Shape at the end of a subpath.
    type [<Erase>] strokeLinecap =
        static member inline butt = Interop.mkProperty<ILineChartLineOptionsProp> "strokeLinecap" "butt"
        static member inline round = Interop.mkProperty<ILineChartLineOptionsProp> "strokeLinecap" "round"
        static member inline square = Interop.mkProperty<ILineChartLineOptionsProp> "strokeLinecap" "square"
        static member inline inherit' = Interop.mkProperty<ILineChartLineOptionsProp> "strokeLinecap" "inherit"
    /// Defines the type of interpolation used to render the line.
    type [<Erase>] curve =
        static member inline linear = Interop.mkProperty<ILineChartLineOptionsProp> "curve" "linear"
        static member inline natural = Interop.mkProperty<ILineChartLineOptionsProp> "curve" "natural"
        static member inline step = Interop.mkProperty<ILineChartLineOptionsProp> "curve" "step"
        static member inline stepAfter = Interop.mkProperty<ILineChartLineOptionsProp> "curve" "stepAfter"
        static member inline stepBefore = Interop.mkProperty<ILineChartLineOptionsProp> "curve" "stepBefore"
    type [<Erase>] mode =
        static member inline lines = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "lines"
        static member inline markers = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "markers"
        static member inline text = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "text"
        static member inline ``lines+markers`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "lines+markers"
        static member inline ``text+markers`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "text+markers"
        static member inline ``text+Lines`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "text+lines"
        static member inline ``text+lines+markers`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "text+lines+markers"
        static member inline none = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "none"
        static member inline gauge = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "gauge"
        static member inline number = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "number"
        static member inline delta = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "delta"
        static member inline ``number+delta`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "number+delta"
        static member inline ``gauge+number`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "gauge+number"
        static member inline ``gauge+number+delta`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "gauge+number+delta"
        static member inline ``gauge+delta`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "gauge+delta"
        static member inline ``markers+text`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "markers+text"
        static member inline ``lines+text`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "lines+text"
        static member inline ``lines+markers+text`` = Interop.mkProperty<ILineChartLineOptionsProp> "mode" "lines+markers+text"

//----------------------------------------------------------------- SankyChartData -------------------------------------------------
type [<Erase>] sankyChartData =
    /// Width of the line/stroke.
    static member inline nodes (value: ISNodeProp list list) = Interop.mkProperty<ISankeyChartDataProp> "nodes" (value |> createObjArray)
    static member inline links (value: ISLinkProp list list) = Interop.mkProperty<ISankeyChartDataProp> "links" (value |> createObjArray)

//----------------------------------------------------------------- SNode -------------------------------------------------
type [<Erase>] sNode =
    ///  A unique identifier for this node.
    static member inline nodeId (value: int) = Interop.mkProperty<ISNodeProp> "nodeId" value
    ///  A unique identifier for this node.
    static member inline nodeId (value: float) = Interop.mkProperty<ISNodeProp> "nodeId" value
    ///  A unique identifier for this node.
    static member inline nodeId (value: decimal) = Interop.mkProperty<ISNodeProp> "nodeId" value
    /// The display name for this node in the UX.
    static member inline name (value: string) = Interop.mkProperty<ISNodeProp> "name" value
    static member inline color (value: string) = Interop.mkProperty<ISNodeProp> "color" value
    static member inline borderColor (value: string) = Interop.mkProperty<ISNodeProp> "borderColor" value
    static member inline actualValue (value: int) = Interop.mkProperty<ISNodeProp> "actualValue" value
    static member inline actualValue (value: float) = Interop.mkProperty<ISNodeProp> "actualValue" value
    static member inline actualValue (value: decimal) = Interop.mkProperty<ISNodeProp> "actualValue" value
    static member inline layer (value: int) = Interop.mkProperty<ISNodeProp> "layer" value
    static member inline layer (value: float) = Interop.mkProperty<ISNodeProp> "layer" value
    static member inline layer (value: decimal) = Interop.mkProperty<ISNodeProp> "layer" value

//----------------------------------------------------------------- SLink -------------------------------------------------
type [<Erase>] sLink =
    ///  The index within `ISankeyChartData.nodes` of the source node.
    static member inline source (value: int) = Interop.mkProperty<ISLinkProp> "source" value
    ///  The index within `ISankeyChartData.nodes` of the source node.
    static member inline source (value: float) = Interop.mkProperty<ISLinkProp> "source" value
    ///  The index within `ISankeyChartData.nodes` of the source node.
    static member inline source (value: decimal) = Interop.mkProperty<ISLinkProp> "source" value
    /// The index within `ISankeyChartData.nodes` of the target node.
    static member inline target (value: int) = Interop.mkProperty<ISLinkProp> "target" value
    /// The index within `ISankeyChartData.nodes` of the target node.
    static member inline target (value: float) = Interop.mkProperty<ISLinkProp> "target" value
    /// The index within `ISankeyChartData.nodes` of the target node.
    static member inline target (value: decimal) = Interop.mkProperty<ISLinkProp> "target" value
    /// The weight of this link between the two nodes.
    static member inline value (value: int) = Interop.mkProperty<ISLinkProp> "value" value
    /// The weight of this link between the two nodes.
    static member inline value (value: float) = Interop.mkProperty<ISLinkProp> "value" value
    /// The weight of this link between the two nodes.
    static member inline value (value: decimal) = Interop.mkProperty<ISLinkProp> "value" value
    static member inline unnormalizedValue (value: int) = Interop.mkProperty<ISLinkProp> "unnormalizedValue" value
    static member inline unnormalizedValue (value: float) = Interop.mkProperty<ISLinkProp> "unnormalizedValue" value
    static member inline unnormalizedValue (value: decimal) = Interop.mkProperty<ISLinkProp> "unnormalizedValue" value

//----------------------------------------------------------------- ChartTableHeader -------------------------------------------------
type [<Erase>] chartTableHeader =
    /// 1d or 2d Array of header values.
    static member inline value (value: string) = Interop.mkProperty<IChartTableHeaderProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: int) = Interop.mkProperty<IChartTableHeaderProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: decimal) = Interop.mkProperty<IChartTableHeaderProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: float) = Interop.mkProperty<IChartTableHeaderProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: bool) = Interop.mkProperty<IChartTableHeaderProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline style (value: IStyleAttribute list) = Interop.mkProperty<IChartTableHeaderProp> "style" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- ChartTableRow -------------------------------------------------
type [<Erase>] chartTableRow =
    /// 1d or 2d Array of header values.
    static member inline value (value: string) = Interop.mkProperty<IChartTableRowProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: int) = Interop.mkProperty<IChartTableRowProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: decimal) = Interop.mkProperty<IChartTableRowProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: float) = Interop.mkProperty<IChartTableRowProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline value (value: bool) = Interop.mkProperty<IChartTableRowProp> "value" value
    /// 1d or 2d Array of header values.
    static member inline style (value: IStyleAttribute list) = Interop.mkProperty<IChartTableRowProp> "style" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- ChartTable -------------------------------------------------
type [<Erase>] chartTable =
    /// 1d or 2d Array of header values.
    static member inline headers (value: IChartTableHeaderProp list list) = Interop.mkProperty<IChartTableProp> "headers" (value |> createObjArray)
    /// Array of rows. Each row corresponds to one data entry under each column.
    static member inline rows (value: IChartTableRowProp list list list) =
                            let newValue =
                                value
                                |> List.map (fun rows ->
                                    rows
                                    |> List.map (fun props -> !!props |> createObj |> unbox)
                                    |> List.toArray
                                )
                                |> List.toArray
                            Interop.mkProperty<IChartTableProp> "rows" newValue
    /// Optional width for the table
    static member inline width (value: string) = Interop.mkProperty<IChartTableProp> "width" value
    /// Optional width for the table
    static member inline width (value: int) = Interop.mkProperty<IChartTableProp> "width" value
    /// Optional width for the table
    static member inline width (value: float) = Interop.mkProperty<IChartTableProp> "width" value
    /// Optional width for the table
    static member inline width (value: decimal) = Interop.mkProperty<IChartTableProp> "width" value
    /// Optional height for the table
    static member inline height (value: string) = Interop.mkProperty<IChartTableProp> "height" value
    /// Optional height for the table
    static member inline height (value: int) = Interop.mkProperty<IChartTableProp> "height" value
    /// Optional height for the table
    static member inline height (value: float) = Interop.mkProperty<IChartTableProp> "height" value
    /// Optional height for the table
    static member inline height (value: decimal) = Interop.mkProperty<IChartTableProp> "height" value
    /// Additional class name(s) to apply to the table chart
    static member inline className (value: string) = Interop.mkProperty<IChartTableProp> "className" value
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles (value: IChartTableStylesProp list) = Interop.mkProperty<IChartTableProp> "styles" (!!value |> createObj |> unbox)
    /// Optional callback to access the Chart interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    static member inline componentRef (value: RefObject<Chart>) = Interop.mkProperty<IChartTableProp> "componentRef" value

//----------------------------------------------------------------- ChartTableStyles ----------------
type [<Erase>] chartTableStyles =
    static member inline root(value: string) = Interop.mkProperty<IChartTableStylesProp> "root" value
    static member inline root(value: IStyleAttribute list) = Interop.mkProperty<IChartTableStylesProp> "root" (!!value |> createObj |> unbox)
    static member inline table(value: string) = Interop.mkProperty<IChartTableStylesProp> "table" value
    static member inline headerCell(value: string) = Interop.mkProperty<IChartTableStylesProp> "headerCell" value
    static member inline bodyCell(value: string) = Interop.mkProperty<IChartTableStylesProp> "bodyCell" value
    static member inline chart(value: string) = Interop.mkProperty<IChartTableStylesProp> "chart" value

//----------------------------------------------------------------- DonutChart -------------------------------------------------
type [<Erase>] donutChart =
    inherit cartesianChart<IDonutChartProp>
    /// Data to render in the chart.
    static member inline data(value: IChartProp list) = Interop.mkProperty<IDonutChartProp> "data" (!!value |> createObj |> unbox)
    /// inner radius for donut size
    static member inline innerRadius(value: int) = Interop.mkProperty<IDonutChartProp> "innerRadius" value
    /// inner radius for donut size
    static member inline innerRadius(value: float) = Interop.mkProperty<IDonutChartProp> "innerRadius" value
    /// inner radius for donut size
    static member inline innerRadius(value: decimal) = Interop.mkProperty<IDonutChartProp> "innerRadius" value
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: IDonutChartStylesProp list) = Interop.mkProperty<IDonutChartProp> "styles" (!!value |> createObj |> unbox)
    /// props for inside donut value
    static member inline valueInsideDonut(value: string) = Interop.mkProperty<IDonutChartProp> "valueInsideDonut" value
    /// props for inside donut value
    static member inline valueInsideDonut(value: int) = Interop.mkProperty<IDonutChartProp> "valueInsideDonut" value
    /// props for inside donut value
    static member inline valueInsideDonut(value: float) = Interop.mkProperty<IDonutChartProp> "valueInsideDonut" value
    /// props for inside donut value
    static member inline valueInsideDonut(value: decimal) = Interop.mkProperty<IDonutChartProp> "valueInsideDonut" value
    /// Define a custom callout renderer for a data point
    static member inline onRenderCalloutPerDataPoint(value: ChartDataPoint -> ReactElement option) = Interop.mkProperty<IDonutChartProp> "onRenderCalloutPerDataPoint" (System.Func<_,_> value)
    /// Define a custom callout props override
    static member inline calloutPropsPerDataPoint(handler: ChartDataPoint -> IChartPopoverProp list) = Interop.mkProperty<IDonutChartProp> "calloutPropsPerDataPoint" (System.Func<_,_> (fun _ value -> handler (!!value |> createObj |> unbox)))
    /// Define a custom callout props override
    static member inline calloutProps(value: IChartPopoverProp list) = Interop.mkProperty<IDonutChartProp> "calloutProps" (!!value |> createObj |> unbox)
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IDonutChartProp> "culture" value
    /// Prop to show the arc labels in percentage format
    static member inline showLabelsInPercent(value: bool) = Interop.mkProperty<IDonutChartProp> "showLabelsInPercent" value
    /// Prop to hide the arc labels
    static member inline hideLabels(value: bool) = Interop.mkProperty<IDonutChartProp> "hideLabels" value
    /// Below height used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: int) = Interop.mkProperty<IDonutChartProp> "height" value
    /// Below height used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: float) = Interop.mkProperty<IDonutChartProp> "height" value
    /// Below height used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: decimal) = Interop.mkProperty<IDonutChartProp> "height" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: int) = Interop.mkProperty<IDonutChartProp> "width" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: float) = Interop.mkProperty<IDonutChartProp> "width" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: decimal) = Interop.mkProperty<IDonutChartProp> "width" value
    /// this prop takes its parent as a HTML element to define the width and height of the chart
    static member inline parentRef(value: HTMLElement option) = Interop.mkProperty<IDonutChartProp> "parentRef" value
    /// Additional CSS class(es) to apply to the Chart.
    static member inline className(value: string) = Interop.mkProperty<IDonutChartProp> "className" value
    /// Additional CSS class(es) to apply to the Chart.
    static member inline legendsOverflowText(value: 'T) = Interop.mkProperty<IDonutChartProp> "legendsOverflowText" value
    /// Additional CSS class(es) to apply to the Chart.
    static member inline legendProps(value: ILegendsProp list) = Interop.mkProperty<IDonutChartProp> "legendProps" (!!value |> createObj |> unbox)
    /// decides wether to show/hide legends
    static member inline hideLegend(value: bool) = Interop.mkProperty<IDonutChartProp> "hideLegend" value
    /// Url that the data-viz needs to redirect to upon clicking on it
    static member inline href(value: string) = Interop.mkProperty<IDonutChartProp> "href" value
    /// Do not show tooltips in chart
    static member inline hideTooltip(value: bool) = Interop.mkProperty<IDonutChartProp> "hideTooltip" value
    /// Optional callback to access the Chart interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    static member inline componentRef(value: RefObject<Chart>) = Interop.mkProperty<IDonutChartProp> "componentRef" value
    /// Prop to enable the round corners in the chart
    static member inline roundCorners(value: bool) = Interop.mkProperty<IDonutChartProp> "roundCorners" value

module donutChart =
    type [<Erase>] reflowProps = reflowProps<IDonutChartProp>
    type [<Erase>] xAxis = xAxis<IDonutChartProp>
    type [<Erase>] yAxis = yAxis<IDonutChartProp>
//----------------------------------------------------------------- DonutChartStyles -------------------------------------------------
type [<Erase>] donutChartStyles =
    /// Style for the root element.
    static member inline root(value: string) = Interop.mkProperty<IDonutChartStylesProp> "root" value
    /// Style for the chart.
    static member inline chart(value: string) = Interop.mkProperty<IDonutChartStylesProp> "chart" value
    /// Style for the legend container.
    static member inline legendContainer(value: string) = Interop.mkProperty<IDonutChartStylesProp> "legendContainer" value
    /// styles for axis annotation
    static member inline axisAnnotation(value: string) = Interop.mkProperty<IDonutChartStylesProp> "axisAnnotation" value
    /// Styles for the chart wrapper div
    static member inline chartWrapper(value: string) = Interop.mkProperty<IDonutChartStylesProp> "chartWrapper" value

//----------------------------------------------------------------- FunnelChart -------------------------------------------------
type [<Erase>] funnelChart =
    /// Data points for the funnel chart
    static member inline data(value: IFunnelChartDataPointProp list list) = Interop.mkProperty<IFunnelChartProp> "data" (value |> createObjArray)
    /// Title for the chart
    static member inline chartTitle(value: string) = Interop.mkProperty<IFunnelChartProp> "chartTitle" value
    /// Width of the chart
    static member inline width(value: int) = Interop.mkProperty<IFunnelChartProp> "width" value
    /// Width of the chart
    static member inline width(value: float) = Interop.mkProperty<IFunnelChartProp> "width" value
    /// Width of the chart
    static member inline width(value: decimal) = Interop.mkProperty<IFunnelChartProp> "width" value
    /// Height of the chart
    static member inline height(value: int) = Interop.mkProperty<IFunnelChartProp> "height" value
    /// Height of the chart
    static member inline height(value: float) = Interop.mkProperty<IFunnelChartProp> "height" value
    /// Height of the chart
    static member inline height(value: decimal) = Interop.mkProperty<IFunnelChartProp> "height" value
    /// Decides whether to show/hide legends
    static member inline hideLegend(value: bool) = Interop.mkProperty<IFunnelChartProp> "hideLegend" value
    /// Props for the legends in the chart
    static member inline legendProps(value: ILegendsProp list) = Interop.mkProperty<IFunnelChartProp> "legendProps" (!!value |> createObj |> unbox)
    /// Props for the callout in the chart
    static member inline calloutProps(value: IChartPopoverProp list) = Interop.mkProperty<IFunnelChartProp> "calloutProps" (!!value |> createObj |> unbox)
    /// Call to provide customized styling that will layer on top of the variant rules
    static member inline styles(value: IFunnelChartStylesProp list) = Interop.mkProperty<IFunnelChartProp> "styles" (!!value |> createObj |> unbox)
    /// Defines the culture to localize the numbers and dates
    static member inline culture(value: string) = Interop.mkProperty<IFunnelChartProp> "culture" value
    /// Reference to the chart component
    static member inline componentRef(value: RefObject<'T>) = Interop.mkProperty<IFunnelChartProp> "componentRef" value
    /// Additional CSS class(es) to apply to the chart
    static member inline className(value: string) = Interop.mkProperty<IFunnelChartProp> "className" value

module funnelChart =
    type [<Erase>] orientation =
        static member inline horizontal = Interop.mkProperty<IFunnelChartProp> "orientation" "horizontal"
        static member inline vertical = Interop.mkProperty<IFunnelChartProp> "orientation" "vertical"

//----------------------------------------------------------------- FunnelChartDataPoint -------------------------------------------------
type [<Erase>] funnelChartDataPoint =
    /// Stage name or identifier
    static member inline stage(value: string) = Interop.mkProperty<IFunnelChartDataPointProp> "stage" value
    /// Stage name or identifier
    static member inline stage(value: int) = Interop.mkProperty<IFunnelChartDataPointProp> "stage" value
    /// Stage name or identifier
    static member inline stage(value: decimal) = Interop.mkProperty<IFunnelChartDataPointProp> "stage" value
    /// Stage name or identifier
    static member inline stage(value: float) = Interop.mkProperty<IFunnelChartDataPointProp> "stage" value
    /// Stage name or identifier
    static member inline subValues(value: IFunnelChartDataPointSubValueProp list list) = Interop.mkProperty<IFunnelChartDataPointProp> "subValues" (value |> createObjArray)
    /// Value for the stage (used for non-stacked funnel charts)
    static member inline value(value: int) = Interop.mkProperty<IFunnelChartDataPointProp> "value" value
    /// Value for the stage (used for non-stacked funnel charts)
    static member inline value(value: decimal) = Interop.mkProperty<IFunnelChartDataPointProp> "value" value
    /// Value for the stage (used for non-stacked funnel charts)
    static member inline value(value: float) = Interop.mkProperty<IFunnelChartDataPointProp> "value" value
    /// Color for the stage (used for non-stacked funnel charts)
    static member inline color(value: string) = Interop.mkProperty<IFunnelChartDataPointProp> "color" value

//----------------------------------------------------------------- FunnelChartDataPointSubValue -------------------------------------------------
type [<Erase>] funnelChartDataPointSubValue =
    static member inline category(value: string) = Interop.mkProperty<IFunnelChartDataPointSubValueProp> "category" value
    static member inline value(value: int) = Interop.mkProperty<IFunnelChartDataPointSubValueProp> "value" value
    static member inline value(value: decimal) = Interop.mkProperty<IFunnelChartDataPointSubValueProp> "value" value
    static member inline value(value: float) = Interop.mkProperty<IFunnelChartDataPointSubValueProp> "value" value
    static member inline color(value: string) = Interop.mkProperty<IFunnelChartDataPointSubValueProp> "color" value

//----------------------------------------------------------------- FunnelChartStyles -------------------------------------------------
type [<Erase>] funnelChartStyles =
    /// Styles for the root element
    static member inline root(value: string) = Interop.mkProperty<IFunnelChartStylesProp> "root" value
    /// Styles for the chart
    static member inline chart(value: string) = Interop.mkProperty<IFunnelChartStylesProp> "chart" value
    /// Styles for text elements
    static member inline text(value: string) = Interop.mkProperty<IFunnelChartStylesProp> "text" value
    /// Styles for the callout root element
    static member inline calloutContentRoot(value: string) = Interop.mkProperty<IFunnelChartStylesProp> "calloutContentRoot" value
    static member inline color(value: string) = Interop.mkProperty<IFunnelChartDataPointSubValueProp> "color" value

//----------------------------------------------------------------- GanttChart -------------------------------------------------
type [<Erase>] ganttChart =
    inherit cartesianChart<IGanttChartProp>
    /// An array of data points to be rendered in the chart.
    static member inline data(value: IGanttChartDataPointProp list list) = Interop.mkProperty<IGanttChartProp> "data" (value |> createObjArray)
    /// Callback function to render a custom callout for each data point.
    static member inline onRenderCalloutPerDataPoint(handler: GanttChartDataPoint option -> ReactElement) = Interop.mkProperty<IGanttChartProp> "onRenderCalloutPerDataPoint" (System.Func<_,_,_> (fun value _ -> handler value))
    /// Height of each bar, in pixels.
    static member inline barHeight(value: int) = Interop.mkProperty<IGanttChartProp> "barHeight" value
    /// Height of each bar, in pixels.
    static member inline barHeight(value: float) = Interop.mkProperty<IGanttChartProp> "barHeight" value
    /// Height of each bar, in pixels.
    static member inline barHeight(value: decimal) = Interop.mkProperty<IGanttChartProp> "barHeight" value
    /// Height of each bar, in pixels.
    static member inline chartTitle(value: string) = Interop.mkProperty<IGanttChartProp> "chartTitle" value
    /// Locale identifier string used to format numbers and dates according to the specified culture.
    /// Example: 'en-US', 'fr-FR'.
    static member inline culture(value: string) = Interop.mkProperty<IGanttChartProp> "culture" value
    /// Padding between bars as a fraction of the [step](https://d3js.org/d3-scale/band#band_step).
    /// Takes a number in the range [0, 1].
    static member inline yAxisPadding(value: int) = Interop.mkProperty<IGanttChartProp> "yAxisPadding" value
    /// Padding between bars as a fraction of the [step](https://d3js.org/d3-scale/band#band_step).
    /// Takes a number in the range [0, 1].
    static member inline yAxisPadding(value: decimal) = Interop.mkProperty<IGanttChartProp> "yAxisPadding" value
    /// Padding between bars as a fraction of the [step](https://d3js.org/d3-scale/band#band_step).
    /// Takes a number in the range [0, 1].
    static member inline yAxisPadding(value: float) = Interop.mkProperty<IGanttChartProp> "yAxisPadding" value
    /// If true, truncates y-axis tick labels longer than `noOfCharsToTruncate` with ellipses
    /// and displays them in a tooltip on hover.
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IGanttChartProp> "showYAxisLablesTooltip" value
    /// If true, renders full y-axis tick labels without truncation.
    static member inline showYAxisLables(value: bool) = Interop.mkProperty<IGanttChartProp> "showYAxisLables" value
    /// If true, enables gradient fills for the bars.
    static member inline enableGradient(value: bool) = Interop.mkProperty<IGanttChartProp> "enableGradient" value
    /// If true, applies rounded corners to the bars.
    static member inline roundCorners(value: bool) = Interop.mkProperty<IGanttChartProp> "roundCorners" value
    /// Maximum height of each bar, in pixels.
    static member inline maxBarHeight(value: bool) = Interop.mkProperty<IGanttChartProp> "maxBarHeight" value

module ganttChart =
    type [<Erase>] reflowProps = reflowProps<IGanttChartProp>
    type [<Erase>] xAxis = xAxis<IGanttChartProp>
    type [<Erase>] yAxis = yAxis<IGanttChartProp>
//----------------------------------------------------------------- GanttChartDataPoint -------------------------------------------------
type [<Erase>] ganttChartDataPoint =
    /// Dependent value of the data point, rendered along the x-axis.
    static member inline x (value: IXDataPointProp list) = Interop.mkProperty<IGanttChartDataPointProp> "x" (!!value |> createObj |> unbox)
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y (value: int) = Interop.mkProperty<IGanttChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y (value: float) = Interop.mkProperty<IGanttChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y (value: decimal) = Interop.mkProperty<IGanttChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y (value: string) = Interop.mkProperty<IGanttChartDataPointProp> "y" value
    /// Legend text for the datapoint in the chart
    static member inline legend (value: string) = Interop.mkProperty<IGanttChartDataPointProp> "legend" value
    /// color for the legend in the chart
    static member inline color (value: string) = Interop.mkProperty<IGanttChartDataPointProp> "color" value
    /// Gradient for the legend in the chart. If not provided, it will fallback on the default color palette.
    /// If provided, it will override the color prop. granted `enableGradient` is set to true for the chart.
    static member inline gradient (value: string * string) = Interop.mkProperty<IGanttChartDataPointProp> "gradient" value
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData (value: string) = Interop.mkProperty<IGanttChartDataPointProp> "xAxisCalloutData" value
    /// Callout data for y axis
    /// This is an optional prop, If haven't given legend will take
    static member inline yAxisCalloutData (value: string) = Interop.mkProperty<IGanttChartDataPointProp> "yAxisCalloutData" value
    /// onClick action for each datapoint in the chart
    static member inline onClick (value: unit -> unit) = Interop.mkProperty<IGanttChartDataPointProp> "onClick" value
    /// onClick action for each datapoint in the chart
    static member inline callOutAccessibilityData (value:  IAccessibilityProp list) = Interop.mkProperty<IGanttChartDataPointProp> "callOutAccessibilityData" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- XDataPoint -------------------------------------------------
type [<Erase>] xDataPoint =
    static member inline start (value: DateTime) = Interop.mkProperty<IXDataPointProp> "start" value
    static member inline start (value: DateOnly) = Interop.mkProperty<IXDataPointProp> "start" value
    static member inline start (value: int) = Interop.mkProperty<IXDataPointProp> "start" value
    static member inline start (value: decimal) = Interop.mkProperty<IXDataPointProp> "start" value
    static member inline start (value: float) = Interop.mkProperty<IXDataPointProp> "start" value
    static member inline end' (value: DateTime) = Interop.mkProperty<IXDataPointProp> "end" value
    static member inline end' (value: DateOnly) = Interop.mkProperty<IXDataPointProp> "end" value
    static member inline end' (value: int) = Interop.mkProperty<IXDataPointProp> "end" value
    static member inline end' (value: decimal) = Interop.mkProperty<IXDataPointProp> "end" value
    static member inline end' (value: float) = Interop.mkProperty<IXDataPointProp> "end" value

//----------------------------------------------------------------- GaugeChart -------------------------------------------------
type [<Erase>] gaugeChart =
    /// Width of the chart
    static member inline width(value: int) = Interop.mkProperty<IGaugeChartProp> "width" value
    /// Width of the chart
    static member inline width(value: float) = Interop.mkProperty<IGaugeChartProp> "width" value
    /// Width of the chart
    static member inline width(value: decimal) = Interop.mkProperty<IGaugeChartProp> "width" value
    /// Height of the chart
    static member inline height(value: int) = Interop.mkProperty<IGaugeChartProp> "height" value
    /// Height of the chart
    static member inline height(value: float) = Interop.mkProperty<IGaugeChartProp> "height" value
    /// Height of the chart
    static member inline height(value: decimal) = Interop.mkProperty<IGaugeChartProp> "height" value
    /// Title of the chart
    static member inline chartTitle(value: string) = Interop.mkProperty<IGaugeChartProp> "chartTitle" value
    /// Current value of the gauge
    static member inline chartValue(value: int) = Interop.mkProperty<IGaugeChartProp> "chartValue" value
    /// Current value of the gauge
    static member inline chartValue(value: decimal) = Interop.mkProperty<IGaugeChartProp> "chartValue" value
    /// Current value of the gauge
    static member inline chartValue(value: float) = Interop.mkProperty<IGaugeChartProp> "chartValue" value
    /// Sections of the gauge
    static member inline segments(value: IGaugeChartSegmentProp list list) = Interop.mkProperty<IGaugeChartProp> "segments" (value |> createObjArray)
    /// Minimum value of the gauge
    static member inline minValue(value: int) = Interop.mkProperty<IGaugeChartProp> "minValue" value
    /// Minimum value of the gauge
    static member inline minValue(value: decimal) = Interop.mkProperty<IGaugeChartProp> "minValue" value
    /// Minimum value of the gauge
    static member inline minValue(value: float) = Interop.mkProperty<IGaugeChartProp> "minValue" value
    /// Maximum value of the gauge
    static member inline maxValue(value: int) = Interop.mkProperty<IGaugeChartProp> "maxValue" value
    /// Maximum value of the gauge
    static member inline maxValue(value: decimal) = Interop.mkProperty<IGaugeChartProp> "maxValue" value
    /// Maximum value of the gauge
    static member inline maxValue(value: float) = Interop.mkProperty<IGaugeChartProp> "maxValue" value
    /// Additional text to display below the chart value
    static member inline sublabel(value: string) = Interop.mkProperty<IGaugeChartProp> "sublabel" value
    /// Hide the min and max values of the gauge
    static member inline hideMinMax(value: bool) = Interop.mkProperty<IGaugeChartProp> "hideMinMax" value
    /// Format of the chart value
    static member inline chartValueFormat(value: int * int -> string) = Interop.mkProperty<IGaugeChartProp> "chartValueFormat" (System.Func<_,_> value)
    /// Decides whether to show/hide legends
    static member inline hideLegend(value: bool) = Interop.mkProperty<IGaugeChartProp> "hideLegend" value
    static member inline legendProps(value: ILegendsProp list) = Interop.mkProperty<IGaugeChartProp> "legendProps" (!!value |> createObj |> unbox)
    /// Do not show tooltips in chart
    static member inline hideTooltip(value: bool) = Interop.mkProperty<IGaugeChartProp> "hideTooltip" value
    /// Call to provide customized styling that will layer on top of the variant rules
    static member inline styles(value: IGaugeChartStylesProp list) = Interop.mkProperty<IGaugeChartProp> "styles" (!!value |> createObj |> unbox)
    /// Defines the culture to localize the numbers and dates
    static member inline culture(value: string) = Interop.mkProperty<IGaugeChartProp> "culture" value
    /// Props for the callout in the chart
    static member inline calloutProps(value: IChartPopoverProp list) = Interop.mkProperty<IGaugeChartProp> "calloutProps" (!!value |> createObj |> unbox)
    /// Prop to enable the gradient in the chart
    static member inline enableGradient(value: bool) = Interop.mkProperty<IGaugeChartProp> "enableGradient" value
    /// Prop to enable the round corners in the chart
    static member inline roundCorners(value: bool) = Interop.mkProperty<IGaugeChartProp> "roundCorners" value
    /// Optional callback to access the Chart interface. Use this instead of ref for accessing
    /// the public methods and properties of the component.
    static member inline componentRef(value: RefObject<Chart>) = Interop.mkProperty<IGaugeChartProp> "componentRef" value

module gaugeChart =
    /// Specifies the variant of GaugeChart to be rendered
    type [<Erase>] variant =
        static member inline singleSegment = Interop.mkProperty<IGaugeChartProp> "variant" "single-segment"
        static member inline multipleSegments = Interop.mkProperty<IGaugeChartProp> "variant" "multiple-segments"
    /// Format of the chart value
    type [<Erase>] chartValueFormat =
        static member inline percentage = Interop.mkProperty<IGaugeChartProp> "chartValueFormat" "percentage"
        static member inline fraction = Interop.mkProperty<IGaugeChartProp> "chartValueFormat" "fraction"
//----------------------------------------------------------------- GaugeChartSegment -------------------------------------------------
type [<Erase>] gaugeChartSegment =
    /// Legend text for a segment
    static member inline legend(value: string) = Interop.mkProperty<IGaugeChartSegmentProp> "legend" value
    /// Size of the segment
    static member inline size(value: int) = Interop.mkProperty<IGaugeChartSegmentProp> "size" value
    /// Size of the segment
    static member inline size(value: float) = Interop.mkProperty<IGaugeChartSegmentProp> "size" value
    /// Size of the segment
    static member inline size(value: decimal) = Interop.mkProperty<IGaugeChartSegmentProp> "size" value
    /// Color of the segment
    static member inline color(value: string) = Interop.mkProperty<IGaugeChartSegmentProp> "color" value
    /// Gradient color of the segment
    static member inline gradient(value: string * string) = Interop.mkProperty<IGaugeChartSegmentProp> "gradient" value
    /// Accessibility data for the segment
    static member inline accessibilityData(value: IAccessibilityProp list) = Interop.mkProperty<IGaugeChartSegmentProp> "accessibilityData" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- GaugeChartStyles -------------------------------------------------
type [<Erase>] gaugeChartStyles =
    /// Styles for the root element
    static member inline root(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "root" value
    /// Styles for the chart
    static member inline chart(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "chart" value
    /// Styles for the min and max values
    static member inline limits(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "limits" value
    /// Styles for the chart value
    static member inline chartValue(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "chartValue" value
    /// Styles for the sublabel
    static member inline sublabel(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "sublabel" value
    /// Styles for the needle
    static member inline needle(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "needle" value
    /// Styles for the chart title
    static member inline chartTitle(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "chartTitle" value
    /// Styles for the segments
    static member inline segment(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "segment" value
    /// Styles for gradient segments
    static member inline gradientSegment(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "gradientSegment" value
    /// Styles for the legends container
    static member inline legendsContainer(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "legendsContainer" value
    /// Styles for callout root-content
    static member inline calloutContentRoot(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutContentRoot" value
    /// Styles for callout x-content
    static member inline calloutContentX(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutContentX" value
    /// Styles for callout y-content
    static member inline calloutContentY(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutContentY" value
    /// Styles for description message
    static member inline descriptionMessage(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "descriptionMessage" value
    /// Styles for callout Date time container
    static member inline calloutDateTimeContainer(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutDateTimeContainer" value
    /// Styles for callout info container
    static member inline calloutInfoContainer(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutInfoContainer" value
    /// Styles for callout block container
    static member inline calloutBlockContainer(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutBlockContainer" value
    /// Styles for callout legend text
    static member inline calloutlegendText(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "calloutlegendText" value
    /// Styles for the shape object in the callout
    static member inline shapeStyles(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "shapeStyles" value
    /// Styles for the chart wrapper div
    static member inline chartWrapper(value: string) = Interop.mkProperty<IGaugeChartStylesProp> "chartWrapper" value

//----------------------------------------------------------------- GroupedVerticalBarChart -------------------------------------------------
type [<Erase>] groupedVerticalBarChart =
    inherit cartesianChart<IGroupedVerticalBarChartProp>
    /// Data to render in the chart.
    static member inline data(value: IGroupedVerticalBarChartDataProp list list) = Interop.mkProperty<IGroupedVerticalBarChartProp> "data" (value |> createObjArray)
    /// Width of each bar in the chart. When set to `undefined` or `'default'`, the bar width defaults to 16px,
    /// which may decrease to prevent overlap. When set to `'auto'`, the bar width is calculated from padding values.
    static member inline barWidth(value: int) = Interop.mkProperty<IGroupedVerticalBarChartProp> "barWidth" value
    /// Width of each bar in the chart. When set to `undefined` or `'default'`, the bar width defaults to 16px,
    /// which may decrease to prevent overlap. When set to `'auto'`, the bar width is calculated from padding values.
    static member inline barWidth(value: float) = Interop.mkProperty<IGroupedVerticalBarChartProp> "barWidth" value
    /// Width of each bar in the chart. When set to `undefined` or `'default'`, the bar width defaults to 16px,
    /// which may decrease to prevent overlap. When set to `'auto'`, the bar width is calculated from padding values.
    static member inline barWidth(value: decimal) = Interop.mkProperty<IGroupedVerticalBarChartProp> "barWidth" value
    /// Colors from which to select the color of each bar.
    static member inline colors(value: string list) = Interop.mkProperty<IGroupedVerticalBarChartProp> "colors" (value |> List.toArray)
    /// chart title for the chart
    static member inline chartTitle(value: string) = Interop.mkProperty<IGroupedVerticalBarChartProp> "chartTitle" value
    /// This prop makes sure that all the bars are of same color.
    /// it will take the first color from the array of colors in
    /// prop `colors` or if  `colors` prop is not given then default color is  palette.blueLight
    static member inline useSingleColor(value: bool) = Interop.mkProperty<IGroupedVerticalBarChartProp> "useSingleColor" value
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: IGroupedVerticalBarChartStylesProp list) = Interop.mkProperty<IGroupedVerticalBarChartProp> "styles" (!!value |> createObj |> unbox)
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IGroupedVerticalBarChartProp> "culture" value
    /// To display multi stack callout or single callout
    static member inline isCalloutForStack(value: bool) = Interop.mkProperty<IGroupedVerticalBarChartProp> "isCalloutForStack" value
    /// Prop to hide the bar labels
    static member inline hideLabels(value: bool) = Interop.mkProperty<IGroupedVerticalBarChartProp> "hideLabels" value
    /// Maximum width of a bar, in pixels.
    static member inline maxBarWidth(value: int) = Interop.mkProperty<IGroupedVerticalBarChartProp> "maxBarWidth" value
    /// Maximum width of a bar, in pixels.
    static member inline maxBarWidth(value: float) = Interop.mkProperty<IGroupedVerticalBarChartProp> "maxBarWidth" value
    /// Maximum width of a bar, in pixels.
    static member inline maxBarWidth(value: decimal) = Interop.mkProperty<IGroupedVerticalBarChartProp> "maxBarWidth" value
    /// Padding between bars as a fraction of the [step](https://d3js.org/d3-scale/band#band_step).
    /// Takes a number in the range [0, 1]. Only applicable to string x-axis.
    static member inline xAxisInnerPadding(value: int) = Interop.mkProperty<IGroupedVerticalBarChartProp> "xAxisInnerPadding" value
    /// Padding between bars as a fraction of the [step](https://d3js.org/d3-scale/band#band_step).
    /// Takes a number in the range [0, 1]. Only applicable to string x-axis.
    static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<IGroupedVerticalBarChartProp> "xAxisInnerPadding" value
    /// Padding between bars as a fraction of the [step](https://d3js.org/d3-scale/band#band_step).
    /// Takes a number in the range [0, 1]. Only applicable to string x-axis.
    static member inline xAxisInnerPadding(value: decimal) = Interop.mkProperty<IGroupedVerticalBarChartProp> "xAxisInnerPadding" value
    /// Padding before the first bar and after the last bar as a fraction of
    /// the [step](https://d3js.org/d3-scale/band#band_step). Takes a number in the range [0, 1].
    /// Only applicable to string x-axis.
    static member inline xAxisOuterPadding(value: int) = Interop.mkProperty<IGroupedVerticalBarChartProp> "xAxisOuterPadding" value
    /// Padding before the first bar and after the last bar as a fraction of
    /// the [step](https://d3js.org/d3-scale/band#band_step). Takes a number in the range [0, 1].
    /// Only applicable to string x-axis.
    static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<IGroupedVerticalBarChartProp> "xAxisOuterPadding" value
    /// Padding before the first bar and after the last bar as a fraction of
    /// the [step](https://d3js.org/d3-scale/band#band_step). Takes a number in the range [0, 1].
    /// Only applicable to string x-axis.
    static member inline xAxisOuterPadding(value: decimal) = Interop.mkProperty<IGroupedVerticalBarChartProp> "xAxisOuterPadding" value
    /// The prop used to enable rounded corners for the chart.
    static member inline roundCorners(value: bool) = Interop.mkProperty<IGroupedVerticalBarChartProp> "roundCorners" value

module groupedVerticalBarChart =
    type [<Erase>] reflowProps = reflowProps<IGroupedVerticalBarChartProp>
    type [<Erase>] xAxis = xAxis<IGroupedVerticalBarChartProp>
    type [<Erase>] yAxis = yAxis<IGroupedVerticalBarChartProp>
    /// Width of each bar in the chart. When set to `undefined` or `'default'`, the bar width defaults to 16px,
    /// which may decrease to prevent overlap. When set to `'auto'`, the bar width is calculated from padding values.
    type [<Erase>] barWidth =
        static member inline default'  = Interop.mkProperty<IGroupedVerticalBarChartProp> "barWidth" "default"
        static member inline auto  = Interop.mkProperty<IGroupedVerticalBarChartProp> "barWidth" "auto"
    /// Specifies the mode of the chart.
    type [<Erase>] mode =
        static member inline default'  = Interop.mkProperty<IGroupedVerticalBarChartProp> "mode" "default"
        static member inline plotly  = Interop.mkProperty<IGroupedVerticalBarChartProp> "mode" "plotly"

//----------------------------------------------------------------- GroupedVerticalBarChartData -------------------------------------------------
type [<Erase>] groupedVerticalBarChartData =
    /// Data for X axis label
    static member inline name(value: string) = Interop.mkProperty<IGroupedVerticalBarChartDataProp> "name" value
    /// Data points for Grouped vertical bar chart
    static member inline series(value: IGVBarChartSeriesPointProp list list) = Interop.mkProperty<IGroupedVerticalBarChartDataProp> "series" (value |> createObjArray)
    /// Accessibility data for Group Bars Stack Callout
    static member inline stackCallOutAccessibilityData(value: IAccessibilityProp list) = Interop.mkProperty<IGroupedVerticalBarChartDataProp> "stackCallOutAccessibilityData" (!!value |> createObj |> unbox)

//----------------------------------------------------------------- GVBarChartSeriesPoint -------------------------------------------------
type [<Erase>] gvBarChartSeriesPoint =
    /// Text for // need to check use of this
    static member inline key(value: string) = Interop.mkProperty<IGVBarChartSeriesPointProp> "key" value
    /// Data for bar height of Grouped vertical bar chart
    static member inline data(value: int) = Interop.mkProperty<IGVBarChartSeriesPointProp> "data" value
    /// Data for bar height of Grouped vertical bar chart
    static member inline data(value: decimal) = Interop.mkProperty<IGVBarChartSeriesPointProp> "data" value
    /// Data for bar height of Grouped vertical bar chart
    static member inline data(value: float) = Interop.mkProperty<IGVBarChartSeriesPointProp> "data" value
    /// Color for the legend in the chart
    static member inline color(value: string) = Interop.mkProperty<IGVBarChartSeriesPointProp> "color" value
    /// Legend text in the chart
    static member inline legend(value: string) = Interop.mkProperty<IGVBarChartSeriesPointProp> "legend" value
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IGVBarChartSeriesPointProp> "xAxisCalloutData" value
    /// Callout data for y axis
    /// This is an optional prop, If haven't given data will take
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IGVBarChartSeriesPointProp> "yAxisCalloutData" value
    /// onClick action for each datapoint in the chart
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IGVBarChartSeriesPointProp> "onClick" (System.Func<_,_> value)
    /// Accessibility data for callout
    static member inline callOutAccessibilityData(value: IAccessibilityProp list) = Interop.mkProperty<IGVBarChartSeriesPointProp> "callOutAccessibilityData" (!!value |> createObj |> unbox)
    /// Whether to use the secondary y scale or not
    static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<IGVBarChartSeriesPointProp> "useSecondaryYScale" value

//----------------------------------------------------------------- GroupedVerticalBarChartStyles -------------------------------------------------
type [<Erase>] groupedVerticalBarChartStyles =
    inherit sharedCartesianChartStyles<IGroupedVerticalBarChartStylesProp>
    /// Style for the bar labels
    static member inline barLabel(value: string) = Interop.mkProperty<IGroupedVerticalBarChartStylesProp> "barLabel" value

//----------------------------------------------------------------- HeatMapChart -------------------------------------------------
type [<Erase>] heatMapChart =
    inherit cartesianChart<IHeatMapChartProp>
    /// chart title for the chart
    static member inline chartTitle(value: string) = Interop.mkProperty<IHeatMapChartProp> "chartTitle" value
    /// data to provide for Heat Map
    static member inline data(value: IHeatMapChartDataProp list list) = Interop.mkProperty<IHeatMapChartProp> "data" (value |> createObjArray)
    /// The domain value for the color scale
    static member inline domainValuesForColorScale(value: int list) = Interop.mkProperty<IHeatMapChartProp> "domainValuesForColorScale" (value |> List.toArray)
    /// The domain value for the color scale
    static member inline domainValuesForColorScale(value: float list) = Interop.mkProperty<IHeatMapChartProp> "domainValuesForColorScale" (value |> List.toArray)
    /// The domain value for the color scale
    static member inline domainValuesForColorScale(value: decimal list) = Interop.mkProperty<IHeatMapChartProp> "domainValuesForColorScale" (value |> List.toArray)
    /// The range values for the color scale,
    /// fill the array with colors in hex format
    /// note:- it should contain values exactly as many as values in the array
    static member inline rangeValuesForColorScale(value: string list) = Interop.mkProperty<IHeatMapChartProp> "rangeValuesForColorScale" (value |> List.toArray)
    /// note:- it should contain values exactly as many as values in the array
    static member inline xAxisDateFormatString(value: string) = Interop.mkProperty<IHeatMapChartProp> "xAxisDateFormatString" value
    /// date formatter of y axis,
    /// if the y-axis data point are or date type then user can use this
    /// prop to format the date
    /// refer to https://github.com/d3/d3-time-format for string values
    static member inline yAxisDateFormatString(value: string) = Interop.mkProperty<IHeatMapChartProp> "yAxisDateFormatString" value
    /// number formatter of x axis
    /// if the x-axis data pints are of number type then user can
    /// use this prop to format the number
    static member inline xAxisNumberFormatString(value: string) = Interop.mkProperty<IHeatMapChartProp> "xAxisNumberFormatString" value
    /// number formatter of y axis
    /// if the y-axis data pints are of number type then user can
    /// use this prop to format the number
    static member inline yAxisNumberFormatString(value: string) = Interop.mkProperty<IHeatMapChartProp> "yAxisNumberFormatString" value
    /// string formatter for x-axis.
    /// This prop only applies if the x-axis is of string type
    ///
    /// For the accessiblity reason we sort the x-axis data point given by the consumer in ascending
    /// order and then render in the x-axis. this behaviour would force the order of the data points.
    /// to overcome , user can give x-axis point names as p1 p2...etc and map those p1 and p2 to custom name.
    /// behind the scene the charting will actually sort the p1 and p2 and then we can attach the custom
    /// name to that point by using this prop, hence giving the us the flexiblity of the order in which
    /// label should render
    static member inline xAxisStringFormatter(value: string -> string) = Interop.mkProperty<IHeatMapChartProp> "xAxisStringFormatter" (System.Func<_,_> value)
    /// string formatter for y-axis.
    /// This prop only applies if the y-axis is of string type
    ///
    /// For the accessiblity reason we sort the x-axis data point given by the consumer in ascending
    /// order and then render in the y-axis. this behaviour would force the order of the data points.
    /// to overcome , user can give y-axis point names as p1 p2...etc and map those p1 and p2 to custom name.
    /// behind the scene the charting will actually sort the p1 and p2 and then we can attach the custom
    /// name to that point by using this prop, hence giving the us the flexiblity of the order in which
    /// label should render
    static member inline yAxisStringFormatter(value: string -> string) = Interop.mkProperty<IHeatMapChartProp> "yAxisStringFormatter" (System.Func<_,_> value)
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: IHeatMapChartStylesProp list) = Interop.mkProperty<IHeatMapChartProp> "styles" (!!value |> createObj |> unbox)
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IHeatMapChartProp> "culture" value
    /// Used for showing complete y axis lables
    static member inline showYAxisLables(value: bool) = Interop.mkProperty<IHeatMapChartProp> "showYAxisLables" value
    /// Used for to elipse y axis labes and show tooltip on x axis labels
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IHeatMapChartProp> "showYAxisLablesTooltip" value

module heatMapChart =
    type [<Erase>] reflowProps = reflowProps<IHeatMapChartProp>
    type [<Erase>] xAxis = xAxis<IHeatMapChartProp>
    type [<Erase>] yAxis = yAxis<IHeatMapChartProp>
    /// The prop used to decide order of string axis labels
    type [<Erase>] sortOrder =
        static member inline none = Interop.mkProperty<IHeatMapChartProp> "sortOrder" "none"
        static member inline alphabetical = Interop.mkProperty<IHeatMapChartProp> "sortOrder" "alphabetical"

//----------------------------------------------------------------- HeatMapChartData -------------------------------------------------
type [<Erase>] heatMapChartData =
    /// name of the legend
    static member inline legend(value: string) = Interop.mkProperty<IHeatMapChartDataProp> "legend" value
    /// name of the legend
    static member inline data(value: IHeatMapChartDataPointProp list list) = Interop.mkProperty<IHeatMapChartDataProp> "data" (value |> createObjArray)
    /// This  number will be used to get the color for the legend
    static member inline value(value: int) = Interop.mkProperty<IHeatMapChartDataProp> "value" value
    /// This  number will be used to get the color for the legend
    static member inline value(value: float) = Interop.mkProperty<IHeatMapChartDataProp> "value" value
    /// This  number will be used to get the color for the legend
    static member inline value(value: decimal) = Interop.mkProperty<IHeatMapChartDataProp> "value" value

//----------------------------------------------------------------- HeatMapChartDataPoint -------------------------------------------------
type [<Erase>] heatMapChartDataPoint =
    static member inline x(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: DateTime) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: DateOnly) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: int) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: decimal) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline y(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: DateTime) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: DateOnly) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: int) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: decimal) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline value(value: int) = Interop.mkProperty<IHeatMapChartDataPointProp> "value" value
    static member inline value(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "value" value
    static member inline value(value: decimal) = Interop.mkProperty<IHeatMapChartDataPointProp> "value" value
    /// The value/ text to be rendered in the rectange
    static member inline rectText(value: int) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
    /// The value/ text to be rendered in the rectange
    static member inline rectText(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
    /// The value/ text to be rendered in the rectange
    static member inline rectText(value: decimal) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
    /// The value/ text to be rendered in the rectange
    static member inline rectText(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
    /// denomination to show in the callout
    static member inline ratio(value: int * int) = Interop.mkProperty<IHeatMapChartDataPointProp> "ratio" value
    /// description message to the callout
    static member inline descriptionMessage(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "descriptionMessage" value
    /// onClick action for each datapoint in the chart
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IHeatMapChartDataPointProp> "onClick" (System.Func<_,_> value)
    /// Accessibility data for callout
    static member inline callOutAccessibilityData(value: IAccessibilityProp list) = Interop.mkProperty<IHeatMapChartDataPointProp> "callOutAccessibilityData" (!!value |> createObj |> unbox)


//----------------------------------------------------------------- HeatMapChartStyles -------------------------------------------------
type [<Erase>] heatMapChartStyles =
    inherit sharedCartesianChartStyles<IHeatMapChartStylesProp>
    static member inline root(value: string) = Interop.mkProperty<IHeatMapChartStylesProp> "root" value
    static member inline text(value: string) = Interop.mkProperty<IHeatMapChartStylesProp> "text" value
    static member inline calloutContentRoot(value: string) = Interop.mkProperty<IHeatMapChartStylesProp> "calloutContentRoot" value

//----------------------------------------------------------------- HorizontalBarChart -------------------------------------------------
type [<Erase>] horizontalBarChart =
    /// An array of chart data points for the Horizontal bar chart
    static member inline data(value: IChartProp list list) = Interop.mkProperty<IHorizontalBarChartProp> "data" (value |> createObjArray)
    /// Width of bar chart
    static member inline width(value: int) = Interop.mkProperty<IHorizontalBarChartProp> "width" value
    /// Width of bar chart
    static member inline width(value: float) = Interop.mkProperty<IHorizontalBarChartProp> "width" value
    /// Width of bar chart
    static member inline width(value: decimal) = Interop.mkProperty<IHorizontalBarChartProp> "width" value
    /// Height of bar chart
    static member inline barHeight(value: int) = Interop.mkProperty<IHorizontalBarChartProp> "barHeight" value
    /// Height of bar chart
    static member inline barHeight(value: float) = Interop.mkProperty<IHorizontalBarChartProp> "barHeight" value
    /// Height of bar chart
    static member inline barHeight(value: decimal) = Interop.mkProperty<IHorizontalBarChartProp> "barHeight" value
    /// Additional CSS class(es) to apply to the StackedBarChart.
    static member inline className(value: string) = Interop.mkProperty<IHorizontalBarChartProp> "className" value
    /// This property tells whether to show ratio on top of stacked bar chart or not.
    static member inline hideRatio(value: bool seq) = Interop.mkProperty<IHorizontalBarChartProp> "hideRatio" (value |> Seq.toArray)
    /// Do not show tooltips in chart
    static member inline hideTooltip(value: bool) = Interop.mkProperty<IHorizontalBarChartProp> "hideTooltip" value
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: IHorizontalBarChartStylesProp list) = Interop.mkProperty<IHorizontalBarChartProp> "styles" (!!value |> createObj |> unbox)
    /// props for the callout in the chart
    static member inline calloutProps(value: IChartPopoverProp list) = Interop.mkProperty<IHorizontalBarChartProp> "calloutProps" (!!value |> createObj |> unbox)
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IHorizontalBarChartProp> "culture" value
    /// Prop to hide the bar labels
    static member inline hideLabels(value: bool) = Interop.mkProperty<IHorizontalBarChartProp> "hideLabels" value
    /// line color for callout
    static member inline color(value: string) = Interop.mkProperty<IHorizontalBarChartProp> "color" value
    /// prop to check if benchmark data is provided
    static member inline showTriangle(value: bool) = Interop.mkProperty<IHorizontalBarChartProp> "showTriangle" value
    static member inline legendsOverflowText(value: 'T) = Interop.mkProperty<IHorizontalBarChartProp> "legendsOverflowText" value
    static member inline legendProps(value: ILegendsProp list) = Interop.mkProperty<IHorizontalBarChartProp> "legendProps" (!!value |> createObj |> unbox)
    /// prop to render the custom callout
    static member inline onRenderCalloutPerHorizontalBar(value: ChartDataPoint -> ReactElement option) = Interop.mkProperty<IHorizontalBarChartProp> "onRenderCalloutPerHorizontalBar" (System.Func<_,_> value)
    /// Define a custom callout props override
    static member inline calloutPropsPerDataPoint(handler: ChartDataPoint -> IChartPopoverProp list) = Interop.mkProperty<IHorizontalBarChartProp> "calloutPropsPerDataPoint" (System.Func<_,_> (fun _ value -> handler (!!value |> createObj |> unbox)))
    /// When true, chart will display legends even if a bar ( row ) has only one data point.
    static member inline showLegendForSinglePointBar(value: bool) = Interop.mkProperty<IHorizontalBarChartProp> "showLegendForSinglePointBar" value

module horizontalBarChart =
    /// Prop to define the variant of HorizontalBarChart to render
    type [<Erase>] variant =
        static member inline partToWhole = Interop.mkProperty<IHorizontalBarChartProp> "variant" "part-to-whole"
        static member inline absoluteScale = Interop.mkProperty<IHorizontalBarChartProp> "variant" "absolute-scale"
    /// This property tells how to show data text on top right of bar chart.
    /// If barChartCustomData props added, then this props will be overrided.
    type [<Erase>] chartDataMode =
        static member inline default' = Interop.mkProperty<IHorizontalBarChartProp> "chartDataMode" "default"
        static member inline fraction = Interop.mkProperty<IHorizontalBarChartProp> "chartDataMode" "fraction"
        static member inline percentage = Interop.mkProperty<IHorizontalBarChartProp> "chartDataMode" "percentage"
        static member inline hidden = Interop.mkProperty<IHorizontalBarChartProp> "chartDataMode" "hidden"

//------------------------------------------------------------ HorizontalBarChartStyles ---------------------------------------------

type [<Erase>] horizontalBarChartStyles =
    /// Styling for the root container
    static member inline root(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "root" value
    /// Styling for each item in the container
    static member inline items(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "items" value
    /// Style for the chart.
    static member inline chart(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "chart" value
    /// Style for the chart Title.
    static member inline chartTitle(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "chartTitle" value
    /// Style for the bars.
    static member inline barWrapper(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "barWrapper" value
    /// Style for left side text of the chart title
    static member inline chartTitleLeft(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "chartTitleLeft" value
    /// Style for right side text of the chart title
    static member inline chartTitleRight(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "chartTitleRight" value
    /// Style for the chart data text denominator.
    static member inline chartDataTextDenominator(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "chartDataTextDenominator" value
    /// Style for the benchmark container
    static member inline benchmarkContainer(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "benchmarkContainer" value
    /// Style for the benchmark triangle
    static member inline triangle(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "triangle" value
    /// Style for the bar labels
    static member inline barLabel(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "barLabel" value
    /// Style for the div containing the chart
    static member inline chartWrapper(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "chartWrapper" value
    /// Style for the legend container.
    static member inline legendContainer(value: string) = Interop.mkProperty<IHorizontalBarChartStylesProp> "legendContainer" value

//------------------------------------------------------------ HorizontalBarChartWithAxis ---------------------------------------------

type [<Erase>] horizontalBarChartWithAxis =
    inherit cartesianChart<IHorizontalBarChartWithAxisProp>
    /// Data to render in the chart.
    static member inline data(value: IHorizontalBarChartWithAxisDataPointProp list list) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "data" (value |> createObjArray)
    /// Define a custom callout renderer for a data point.
    static member inline onRenderCalloutPerDataPoint (handler: HorizontalBarChartWithAxisDataPoint option -> ReactElement) =
                            Interop.mkProperty<IHorizontalBarChartWithAxisProp> "onRenderCalloutPerDataPoint" (System.Func<_,_,_> (fun value _ -> handler value))
    /// Width of each bar in the chart.
    static member inline barHeight(value: int) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "barHeight" value
    /// Width of each bar in the chart.
    static member inline barHeight(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "barHeight" value
    /// Width of each bar in the chart.
    static member inline barHeight(value: decimal) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "barHeight" value
    /// Colors from which to select the color of each bar.
    static member inline colors(value: string list) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "colors" (value |> List.toArray)
    /// chart title for the chart
    static member inline chartTitle(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "chartTitle" value
    /// This prop makes sure that all the bars are of same color.
    /// it will take the first color from the array of colors in
    /// prop `colors` or if  `colors` prop is not given then default color is  palette.blueLight
    static member inline useSingleColor(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "useSingleColor" value
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: IHorizontalBarChartWithAxisStylesProp list) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "styles" (!!value |> createObj |> unbox)
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "culture" value
    /// it's padding between bar's or lines in the graph
    static member inline yAxisPadding(value: int) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "yAxisPadding" value
    /// it's padding between bar's or lines in the graph
    static member inline yAxisPadding(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "yAxisPadding" value
    /// it's padding between bar's or lines in the graph
    static member inline yAxisPadding(value: decimal) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "yAxisPadding" value
    /// Used for to elipse y axis labes and show tooltip on x axis labels
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "showYAxisLablesTooltip" value
    /// Used for showing complete y axis lables
    static member inline showYAxisLables(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "showYAxisLables" value
    /// The prop used to enable gradient fill color for the chart.
    static member inline enableGradient(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "enableGradient" value
    /// The prop used to enable rounded corners for the bars.
    static member inline roundCorners(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProp> "roundCorners" value

//-------------------------------------------------------- HorizontalBarChartWithAxisDataPoint ---------------------------------------

type [<Erase>] horizontalBarChartWithAxisDataPoint =
    ///Dependent value of the data point, rendered along the x-axis.
    static member inline x(value: int) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "x" value
    ///Dependent value of the data point, rendered along the x-axis.
    static member inline x(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "x" value
    ///Dependent value of the data point, rendered along the x-axis.
    static member inline x(value: decimal) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "x" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y(value: int) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y(value: decimal) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "y" value
    /// Legend text for the datapoint in the chart
    static member inline legend(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "legend" value
    /// color for the legend in the chart
    static member inline color(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "color" value
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "xAxisCalloutData" value
    /// Callout data for y axis
    /// This is an optional prop, If haven't given legend will take
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "yAxisCalloutData" value
    /// onClick action for each datapoint in the chart
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "onClick" (System.Func<_,_> value)
    /// Accessibility data for callout
    static member inline callOutAccessibilityData(value: IAccessibilityProp list) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPointProp> "callOutAccessibilityData" (!!value |> createObj |> unbox)

//-------------------------------------------------------- HorizontalBarChartWithAxisStyles ---------------------------------------

type [<Erase>] horizontalBarChartWithAxisStyles =
    inherit sharedCartesianChartStyles<IHorizontalBarChartWithAxisStylesProp>
    /// Style for the chart label.
    static member inline chartLabel(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "chartLabel" value
    /// Style for the line representing the domain of the x-axis.
    static member inline xAxisDomain(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "xAxisDomain" value
    /// Style for the lines representing the ticks along the x-axis.
    static member inline xAxisTicks(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "xAxisTicks" value
    /// Style for the text labeling each tick along the x-axis.
    static member inline xAxisText(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "xAxisText" value
    /// Style for the line representing the domain of the y-axis.
    static member inline yAxisDomain(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "yAxisDomain" value
    /// Style for the lines representing the ticks along the y-axis.
    static member inline yAxisTicks(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "yAxisTicks" value
    /// Style for the text labeling each tick along the y-axis.
    static member inline yAxisText(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "yAxisText" value
    /// Style to change the opacity of bars in dataviz when we hover on a single bar or legends
    static member inline opacityChangeOnHover(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStylesProp> "opacityChangeOnHover" value

//-------------------------------------------------------- LineChart ---------------------------------------

type [<Erase>] lineChart =
    inherit cartesianChart<ILineChartProp>

    /// Data to render in the chart.
    static member inline data(value: IChartProp list) = Interop.mkProperty<ILineChartProp> "data" (!!value |> createObj |> unbox)
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: ILineChartStylesProp list) = Interop.mkProperty<ILineChartProp> "styles" (!!value |> createObj |> unbox)
    /// Show event annotation
    static member inline eventAnnotationProps(value: IEventsAnnotationProp list) = Interop.mkProperty<ILineChartProp> "eventAnnotationProps" (!!value |> createObj |> unbox)
    /// Define a custom callout renderer for a data point
    static member inline onRenderCalloutPerDataPoint (handler: CustomizedCalloutData option -> ReactElement) =
                            Interop.mkProperty<ILineChartProp> "onRenderCalloutPerDataPoint" (System.Func<_,_,_> (fun value _ -> handler value))
    /// Define a custom callout renderer for a stack; default is to render per data point
    static member inline onRenderCalloutPerStack (handler: CustomizedCalloutData option -> ReactElement) =
                            Interop.mkProperty<ILineChartProp> "onRenderCalloutPerStack" (System.Func<_,_,_> (fun value _ -> handler value))
    /// Callback for getting callout description message
    static member inline getCalloutDescriptionMessage (value: CustomizedCalloutData -> string option) = Interop.mkProperty<ILineChartProp> "getCalloutDescriptionMessage" (System.Func<_,_> value)
    /// Callback for getting callout description message
    static member inline colorFillBars (value: IColorFillBarsProp list list) = Interop.mkProperty<ILineChartProp> "colorFillBars" (value |> createObjArray)
    /// if this is set to true, then for each line there will be a unique shape assigned to the point,
    /// there are total 8 shapes which are as follow circle, square, triangele, diamond, pyramid,
    ///  hexagon, pentagon and octagon, which will get assigned as respectively, if there are more
    /// than 8 lines in the line chart then it will again start from cicle to octagon.
    /// setting this flag to true will also change the behavior of the points, like for a
    /// line, last point shape and first point shape will be visible all the times, and all
    /// other points will get enlarge only when hovered over them
    /// if set to false default shape will be circle, with the existing behavior
    static member inline allowMultipleShapesForPoints (value: bool) = Interop.mkProperty<ILineChartProp> "allowMultipleShapesForPoints" value
    static member inline optimizeLargeData (value: bool) = Interop.mkProperty<ILineChartProp> "optimizeLargeData" value
    /// The prop used to define the culture to localized the numbers
    static member inline culture (value: string) = Interop.mkProperty<ILineChartProp> "culture" value
    /// The prop used to enable the perf optimization
    static member inline enablePerfOptimization (value: bool) = Interop.mkProperty<ILineChartProp> "enablePerfOptimization" value
    /// To enable callout for individual line or complete stack.
    static member inline isCalloutForStack (value: bool) = Interop.mkProperty<ILineChartProp> "isCalloutForStack" value

//-------------------------------------------------------- LineChartStyles ---------------------------------------
type [<Erase>] lineChartStyles =
    inherit sharedCartesianChartStyles<ILineChartStylesProp>

    /// styles for line border
    static member inline lineBorder(value: string) = Interop.mkProperty<ILineChartStylesProp> "lineBorder" value
    /// styles for marker label
    static member inline markerLabel(value: string) = Interop.mkProperty<ILineChartStylesProp> "markerLabel" value

//-------------------------------------------------------- EventsAnnotation ---------------------------------------

type [<Erase>] eventsAnnotation =
    static member inline events(value: IEventAnnotationProp list list) = Interop.mkProperty<IEventsAnnotationProp> "events" (value |> createObjArray)
    static member inline strokeColor(value: string) = Interop.mkProperty<IEventsAnnotationProp> "strokeColor" value
    static member inline labelColor(value: string) = Interop.mkProperty<IEventsAnnotationProp> "labelColor" value
    static member inline labelHeight(value: int) = Interop.mkProperty<IEventsAnnotationProp> "labelHeight" value
    static member inline labelHeight(value: float) = Interop.mkProperty<IEventsAnnotationProp> "labelHeight" value
    static member inline labelHeight(value: decimal) = Interop.mkProperty<IEventsAnnotationProp> "labelHeight" value
    static member inline labelWidth(value: int) = Interop.mkProperty<IEventsAnnotationProp> "labelWidth" value
    static member inline labelWidth(value: float) = Interop.mkProperty<IEventsAnnotationProp> "labelWidth" value
    static member inline labelWidth(value: decimal) = Interop.mkProperty<IEventsAnnotationProp> "labelWidth" value
    static member inline mergedLabel(value: int -> string) = Interop.mkProperty<IEventsAnnotationProp> "mergedLabel" (System.Func<_,_> value)
    static member inline mergedLabel(value: float -> string) = Interop.mkProperty<IEventsAnnotationProp> "mergedLabel" (System.Func<_,_> value)
    static member inline mergedLabel(value: decimal -> string) = Interop.mkProperty<IEventsAnnotationProp> "mergedLabel" (System.Func<_,_> value)

//-------------------------------------------------------- EventAnnotation ---------------------------------------

type [<Erase>] eventAnnotation =
    static member inline date(value: DateTime) = Interop.mkProperty<IEventAnnotationProp> "date" value
    static member inline date(value: DateOnly) = Interop.mkProperty<IEventAnnotationProp> "date" value
    static member inline event(value: string) = Interop.mkProperty<IEventAnnotationProp> "event" value
    static member inline onRenderCard(value: unit -> ReactElement) = Interop.mkProperty<IEventAnnotationProp> "onRenderCard" (System.Func<_,_> value)

//-------------------------------------------------------- ColorFillBars ---------------------------------------
type [<Erase>] colorFillBars =
    static member inline legend(value: string) = Interop.mkProperty<IColorFillBarsProp> "legend" value
    static member inline color(value: string) = Interop.mkProperty<IColorFillBarsProp> "color" value
    static member inline data(value: IColorFillBarDataProp list list) = Interop.mkProperty<IColorFillBarsProp> "data" (value |> createObjArray)
    static member inline applyPattern(value: bool) = Interop.mkProperty<IColorFillBarsProp> "applyPattern" value
    static member inline onLegendClick(value: string -> unit) = Interop.mkProperty<IColorFillBarsProp> "onLegendClick" value
    static member inline onLegendClick(value: string array -> unit) = Interop.mkProperty<IColorFillBarsProp> "onLegendClick" value

//-------------------------------------------------------- ColorFillBarData ---------------------------------------
type [<Erase>] colorFillBarData =
    static member inline startX(value: int) = Interop.mkProperty<IColorFillBarDataProp> "startX" value
    static member inline startX(value: float) = Interop.mkProperty<IColorFillBarDataProp> "startX" value
    static member inline startX(value: decimal) = Interop.mkProperty<IColorFillBarDataProp> "startX" value
    static member inline startX(value: DateTime) = Interop.mkProperty<IColorFillBarDataProp> "startX" value
    static member inline startX(value: DateOnly) = Interop.mkProperty<IColorFillBarDataProp> "startX" value
    static member inline endX(value: int) = Interop.mkProperty<IColorFillBarDataProp> "endX" value
    static member inline endX(value: float) = Interop.mkProperty<IColorFillBarDataProp> "endX" value
    static member inline endX(value: decimal) = Interop.mkProperty<IColorFillBarDataProp> "endX" value
    static member inline endX(value: DateTime) = Interop.mkProperty<IColorFillBarDataProp> "endX" value
    static member inline endX(value: DateOnly) = Interop.mkProperty<IColorFillBarDataProp> "endX" value
