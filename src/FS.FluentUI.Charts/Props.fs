namespace FS.Charts

open System
open Fable.Core
open Fable.Core.JsInterop
open FS.Charts
open Feliz
open Browser.Types

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


// type [<Erase>] legendsStyles =
//     // Style set for the root of the legend component
//     static member inline root(value: string) = Interop.mkProperty<ILegendsStylesProp> "root" value
//     // Style set for Legend. This is a wrapping class for text of legend and the rectange box that represents a legend
//     static member inline legend(value: string) = Interop.mkProperty<ILegendsStylesProp> "legend" value
//     // Style set for the rectangle that represents a legend
//     static member inline rect(value: string) = Interop.mkProperty<ILegendsStylesProp> "rect" value
//     // styles set for the shape that represents a legend
//     static member inline shape(value: string) = Interop.mkProperty<ILegendsStylesProp> "shape" value
//     // Style set for the triangle that represents a legend
//     static member inline triangle(value: string) = Interop.mkProperty<ILegendsStylesProp> "triangle" value
//     // Style for the legend text
//     static member inline text(value: string) = Interop.mkProperty<ILegendsStylesProp> "text" value
//     // Style for the legend text
//     static member inline hoverChange(value: string) = Interop.mkProperty<ILegendsStylesProp> "hoverChange" value
//     // Style for the area that is resizable
//     static member inline resizableArea(value: string) = Interop.mkProperty<ILegendsStylesProp> "resizableArea" value

//     static member inline legendContainer(value: string) = Interop.mkProperty<ILegendsStylesProp> "legendContainer" value
//     // Style for the annotation that is used in the legend
//     static member inline annotation(value: string) = Interop.mkProperty<ILegendsStylesProp> "annotation" value

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
    type [<Erase>] shape =
        // The annotation for the legend, function returning a React node
        static member inline default' = Interop.mkProperty<ILegendProp> "shape" "default"
        static member inline circle = Interop.mkProperty<ILegendProp> "shape" "circle"
        static member inline square = Interop.mkProperty<ILegendProp> "shape" "square"
        static member inline triangle = Interop.mkProperty<ILegendProp> "shape" "triangle"
        static member inline pyramid = Interop.mkProperty<ILegendProp> "shape" "pyramid"
        static member inline hexagon = Interop.mkProperty<ILegendProp> "shape" "hexagon"
        static member inline pentagon = Interop.mkProperty<ILegendProp> "shape" "pentagon"
        static member inline octagon = Interop.mkProperty<ILegendProp> "shape" "octagon"
        static member inline dottedLine = Interop.mkProperty<ILegendProp> "shape" "dottedLine"

type [<Erase>] legendProp =
    /// Prop that takes list of legends
    static member inline legends(value: ILegendProp list list) =
                        let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                        Interop.mkProperty<ILegendPropProp> "legends" newValue
    /// Additional CSS class(es) to apply to the legends component
    static member inline className(value: string) = Interop.mkProperty<ILegendPropProp> "className" value
    /// Call to provide customized styling that will layer on top of the variant rules
    static member inline styles(value: ILegendsStylesProp list) = Interop.mkProperty<ILegendPropProp> "styles" (!!value |> createObj |> unbox)
    /// This prop makes the legends component align itself to the center in the container
    static member inline centerLegends(value: bool) = Interop.mkProperty<ILegendPropProp> "centerLegends" value
    /// Enable the legends to wrap lines if there is not enough space to show all legends on a single line
    static member inline enabledWrapLines(value: bool) = Interop.mkProperty<ILegendPropProp> "enabledWrapLines" value
    /// Style for the overflow component
    static member inline overflowStyles(value: IStyleAttribute list) = Interop.mkProperty<ILegendPropProp> "overflowStyles" (!!value |> createObj |> unbox)
    /// Text for overflow legends string
    static member inline overflowText(value: string) = Interop.mkProperty<ILegendPropProp> "overflowText" value
    /// Prop that decides if legends are focusable
    static member inline allowFocusOnLegends(value: bool) = Interop.mkProperty<ILegendPropProp> "allowFocusOnLegends" value
    /// Prop that decides if we can select multiple legends or single legend at a time
    static member inline canSelectMultipleLegends(value: bool) = Interop.mkProperty<ILegendPropProp> "canSelectMultipleLegends" value
    // Callback issued when the selected option changes
    static member inline onChange(value: string array -> MouseEvent -> Legend -> unit) = Interop.mkProperty<ILegendPropProp> "onChange" (System.Func<_,_,_,_> value)
    /// Keys (title) that will be initially used to set selected items. This prop is used for multi-select scenarios when
    /// canSelectMultipleLegends is true; for single-select, use defaultSelectedLegend.
    ///
    /// Updating this prop does not change the selection after the component has been initialized. For controlled
    /// selections, use selectedLegends instead.
    static member inline defaultSelectedLegends(value: string list) = Interop.mkProperty<ILegendPropProp> "defaultSelectedLegends" (value |> List.toArray)
    /// Key that will be initially used to set selected item. This prop is used for single-select scenarios when
    /// canSelectMultipleLegends is false or unspecified; for multi-select, use defaultSelectedLegends.
    ///
    /// Updating this prop does not change the selection after the component has been initialized. For controlled
    /// selections, use selectedLegend instead.
    static member inline defaultSelectedLegend(value: string) = Interop.mkProperty<ILegendPropProp> "defaultSelectedLegend" value
    /// Keys (title) that will be used to set selected items in multi-select scenarios when canSelectMultipleLegends is
    /// true. For single-select, use selectedLegend.
    ///
    /// When this prop is provided, the component is controlled and does not automatically update the selection based on
    /// user interactions; the parent component must update the value passed to this property by handling the onChange event.
    static member inline selectedLegends(value: string list) = Interop.mkProperty<ILegendPropProp> "selectedLegends" (value |> List.toArray)
    /// Key (title) that will be used to set the selected item in single-select scenarios when canSelectMultipleLegends is
    /// false or unspecified. For multi-select, use selectedLegends.
    ///
    /// When this prop is provided, the component is controlled and does not automatically update the selection based on
    /// user interactions; the parent component must update the value passed to this property by handling the onChange event.
    static member inline selectedLegend(value: string) = Interop.mkProperty<ILegendPropProp> "selectedLegend" value
    /// Reference to access the public methods and properties of the component
    static member inline legendRef(value: IRefValue<LegendContainer>) = Interop.mkProperty<ILegendPropProp> "legendRef" value

module legendProp =
    type [<Erase>] shape =
        static member inline default' = Interop.mkProperty<ILegendProp> "shape" "default"
        static member inline circle = Interop.mkProperty<ILegendProp> "shape" "circle"
        static member inline square = Interop.mkProperty<ILegendProp> "shape" "square"
        static member inline triangle = Interop.mkProperty<ILegendProp> "shape" "triangle"
        static member inline pyramid = Interop.mkProperty<ILegendProp> "shape" "pyramid"
        static member inline hexagon = Interop.mkProperty<ILegendProp> "shape" "hexagon"
        static member inline pentagon = Interop.mkProperty<ILegendProp> "shape" "pentagon"
        static member inline octagon = Interop.mkProperty<ILegendProp> "shape" "octagon"
        static member inline dottedLine = Interop.mkProperty<ILegendProp> "shape" "dottedLine"

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

// type [<Erase>] funnelChartDataPoint =
//     static member inline stage(value: string) =Interop.mkProperty<IFunnelChartDataPoint> "stage" value
//     static member inline subValues
//         (value:
//             {|
//                 category: string
//                 value: float
//                 color: string
//             |} list)
//         = Interop.mkProperty<IFunnelChartDataPoint> "subValues" (createObj !!value)
//     static member inline value(value: float) = Interop.mkProperty<IFunnelChartDataPoint> "value" value
//     static member inline color(value: string) = Interop.mkProperty<IFunnelChartDataPoint> "color" value

// type [<Erase>] funnelChartStyles =
//     static member inline root(value: string) = Interop.mkProperty<IFunnelChartStyles> "root" value
//     static member inline chart(value: string) = Interop.mkProperty<IFunnelChartStyles> "chart" value
//     static member inline text(value: string) = Interop.mkProperty<IFunnelChartStyles> "text" value
//     static member inline calloutContentRoot(value: string) = Interop.mkProperty<IFunnelChartStyles> "calloutContentRoot" value

// module funnelChart =
//     type [<Erase>] orientation =
//         static member inline horizontal = Interop.mkProperty<IFunnelChartProps> "orientation" "horizontal"
//         static member inline vertical = Interop.mkProperty<IFunnelChartProps> "orientation" "vertical"

// type [<Erase>] funnelChart =
//     static member inline data(value: IFunnelChartDataPoint list) = Interop.mkProperty<IFunnelChartProps> "data" (value |> List.toArray)
//     static member inline chartTitle(value: string) = Interop.mkProperty<IFunnelChartProps> "chartTitle" value
//     static member inline width(value: int) = Interop.mkProperty<IFunnelChartProps> "width" value
//     static member inline height(value: int) = Interop.mkProperty<IFunnelChartProps> "height" value
//     static member inline hideLegend(value: bool) = Interop.mkProperty<IFunnelChartProps> "hideLegend" value
//     static member inline legendProps(value: legendProps) = Interop.mkProperty<IFunnelChartProps> "legendProps" value
//     static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IFunnelChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
//     static member inline styles(value: IFunnelChartStyles list) = Interop.mkProperty<IFunnelChartProps> "styles" (value |> List.toArray)
//     static member inline culture(value: string) = Interop.mkProperty<IFunnelChartProps> "culture" value
//     static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<IFunnelChartProps> "componentRef" value
//     static member inline className(value: string) = Interop.mkProperty<IFunnelChartProps> "className" value

// type [<Erase>] gaugeChartStyles =
//     /// Styles for the root element
//     static member inline root(value: string) = Interop.mkProperty<IGaugeChartStyles> "root" value
//     /// Styles for the chart
//     static member inline chart(value: string) = Interop.mkProperty<IGaugeChartStyles> "chart" value
//     /// Styles for the min and max values
//     static member inline limits(value: string) = Interop.mkProperty<IGaugeChartStyles> "limits" value
//     /// Styles for the chart value
//     static member inline chartValue(value: string) = Interop.mkProperty<IGaugeChartStyles> "chartValue" value
//     /// Styles for the sublabel
//     static member inline sublabel(value: string) = Interop.mkProperty<IGaugeChartStyles> "sublabel" value
//     /// Styles for the needle
//     static member inline needle(value: string) = Interop.mkProperty<IGaugeChartStyles> "needle" value
//     /// Styles for the chart title
//     static member inline chartTitle(value: string) = Interop.mkProperty<IGaugeChartStyles> "chartTitle" value
//     /// Styles for the segments
//     static member inline segment(value: string) = Interop.mkProperty<IGaugeChartStyles> "segment" value
//     /// Styles for gradient segments
//     static member inline gradientSegment(value: string) = Interop.mkProperty<IGaugeChartStyles> "gradientSegment" value
//     /// Styles for the legends container
//     static member inline legendsContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "legendsContainer" value
//     /// Styles for callout root-content
//     static member inline calloutContentRoot(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutContentRoot" value
//     /// Styles for callout x-content
//     static member inline calloutContentX(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutContentX" value
//     /// Styles for callout y-content
//     static member inline calloutContentY(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutContentY" value
//     /// Styles for description message
//     static member inline descriptionMessage(value: string) = Interop.mkProperty<IGaugeChartStyles> "descriptionMessage" value
//     /// Styles for callout Date time container
//     static member inline calloutDateTimeContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutDateTimeContainer" value
//     /// Styles for callout info container
//     static member inline calloutInfoContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutInfoContainer" value
//     /// Styles for callout block container
//     static member inline calloutBlockContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutBlockContainer" value
//     /// Styles for callout legend text
//     static member inline calloutlegendText(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutlegendText" value
//     /// Styles for the shape object in the callout
//     static member inline shapeStyles(value: string) = Interop.mkProperty<IGaugeChartStyles> "shapeStyles" value
//     /// Styles for the chart wrapper div
//     static member inline chartWrapper(value: string) = Interop.mkProperty<IGaugeChartStyles> "chartWrapper" value

// type [<Erase>] gaugeChartSegment =
//     static member inline legend(value: string) =Interop.mkProperty<IGaugeChartSegment> "legend" value
//     static member inline size(value: float) =Interop.mkProperty<IGaugeChartSegment> "size" value
//     static member inline color(value: string) =Interop.mkProperty<IGaugeChartSegment> "color" value
//     static member inline gradient(value: string list) =Interop.mkProperty<IGaugeChartSegment> "gradient" (value |> List.toArray)
//     static member inline accessibilityData(value: IAccessibilityProps list) =Interop.mkProperty<IGaugeChartSegment> "accessibilityData" (value |> List.toArray)

// module gaugeChart =
//     type [<Erase>] variant =
//         static member inline singleSegment = Interop.mkProperty<IGaugeChartProps> "variant" "single-segment"
//         static member inline multipleSegment = Interop.mkProperty<IGaugeChartProps> "variant" "multiple-segment"

//     type [<Erase>] chartValueFormat =
//         static member inline percentage = Interop.mkProperty<IGaugeChartProps> "chartValueFormat" "percentage"
//         static member inline fraction = Interop.mkProperty<IGaugeChartProps> "chartValueFormat" "fraction"

// type [<Erase>] gaugeChart =
//     static member inline width(value: float) =Interop.mkProperty<IGaugeChartProps> "width" value
//     static member inline height(value: float) =Interop.mkProperty<IGaugeChartProps> "height" value
//     static member inline chartTitle(value: float) =Interop.mkProperty<IGaugeChartProps> "chartTitle" value
//     static member inline chartValue(value: float) =Interop.mkProperty<IGaugeChartProps> "chartValue" value
//     static member inline segments(value: IGaugeChartSegment list) =Interop.mkProperty<IGaugeChartProps> "segments" (value |> List.toArray)
//     static member inline minValue(value: float) =Interop.mkProperty<IGaugeChartProps> "minValue" value
//     static member inline maxValue(value: float) =Interop.mkProperty<IGaugeChartProps> "maxValue" value
//     static member inline subLabel(value: string) =Interop.mkProperty<IGaugeChartProps> "subLabel" value
//     static member inline hideMinMax(value: bool) =Interop.mkProperty<IGaugeChartProps> "hideMinMax" value
//     static member inline hideLegend(value: bool) =Interop.mkProperty<IGaugeChartProps> "hideLegend" value
//     static member inline legendProps(value: legendProps) =Interop.mkProperty<ILineChartProps> "legendProps" value
//     static member inline hideTooltip(value: bool) =Interop.mkProperty<IGaugeChartProps> "hideTooltip" value
//     static member inline styles(value: IGaugeChartStyles list) =Interop.mkProperty<IGaugeChartProps> "styles" (value |> List.toArray)
//     static member inline culture(value: string) =Interop.mkProperty<IGaugeChartProps> "culture" value
//     static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IGaugeChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
//     static member inline enableGradient(value: bool) =Interop.mkProperty<IGaugeChartProps> "enableGradient" value
//     static member inline roundCorners(value: bool) =Interop.mkProperty<IGaugeChartProps> "roundCorners" value

//     // TODO componentRef?: React.RefObject<Chart>;

// type [<Erase>] ganttChartDataPoint =
//     static member inline x(value: {| start: float; end': float |}) =
//         let jsObj =
//             createObj [
//                 "start" ==> value.start
//                 "end" ==> value.end' // end is reserved, therefore recreate object with correct key
//             ]
//         Interop.mkProperty<IGanttChartDataPoint> "x" jsObj

//     // Dependent value of the data point, rendered along the x-axis.
//     static member inline x(value: {| start: DateTime; end': DateTime |}) =
//         let jsObj =
//             createObj [
//                 "start" ==> value.start
//                 "end" ==> value.end'
//             ]
//         Interop.mkProperty<IGanttChartDataPoint> "x" jsObj

//     /// Independent value of the data point, rendered along the y-axis.
//     /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
//     /// If y is a string, then the data is evenly spaced along the y-axis.
//     static member inline y(value: float) = Interop.mkProperty<IGanttChartDataPoint> "y" value
//     static member inline y(value: string) = Interop.mkProperty<IGanttChartDataPoint> "y" value
//     /// Legend text for the datapoint in the chart
//     static member inline legend(value: string) = Interop.mkProperty<IGanttChartDataPoint> "legend" value
//     /// color for the legend in the chart
//     static member inline color(value: string) = Interop.mkProperty<IGanttChartDataPoint> "color" value
//     /// Gradient for the legend in the chart. If not provided, it will fallback on the default color palette.
//     /// If provided, it will override the color prop. granted `enableGradient` is set to true for the chart.
//     static member inline gradient(value: string list) = Interop.mkProperty<IGanttChartDataPoint> "gradient" (value |> List.toArray)
//     /// Callout data for x axis
//     /// This is an optional prop, If haven't given legend will take
//     static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IGanttChartDataPoint> "xAxisCalloutData" value
//     /// Callout data for y axis
//     /// This is an optional prop, If haven't given data will take
//     static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IGanttChartDataPoint> "yAxisCalloutData" value
//     /// onClick action for each datapoint in the chart
//     static member inline onClick(value: unit -> unit) = Interop.mkProperty<IGanttChartDataPoint> "onClick" value
//     /// Accessibility data for callout
//     static member inline accessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IGanttChartDataPoint> "accessibilityData" (value |> List.toArray)

// type [<Erase>] ganttChart =
//     inherit cartesianChartProps<IGanttChartProps>
//     static member inline data(value: ganttChartDataPoint list) = Interop.mkProperty<IGanttChartProps> "data" (value |> List.toArray)

//     // TODO onRenderCalloutPerDataPoint?: RenderFunction<GanttChartDataPoint>;

//     static member inline barHeight(value: float) = Interop.mkProperty<IGanttChartProps> "barHeight" value
//     static member inline chartTitle(value: string) = Interop.mkProperty<IGanttChartProps> "chartTitle" value
//     static member inline culture(value: string) = Interop.mkProperty<IGanttChartProps> "culture" value
//     static member inline yAxisPadding(value: float) = Interop.mkProperty<IGanttChartProps> "yAxisPadding" value
//     static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IGanttChartProps> "showYAxisLablesTooltip" value
//     static member inline showYAxisLables(value: bool) = Interop.mkProperty<IGanttChartProps> "showYAxisLables" value
//     static member inline enableGradient(value: bool) = Interop.mkProperty<IGanttChartProps> "enableGradient" value
//     static member inline roundCorners(value: bool) = Interop.mkProperty<IGanttChartProps> "roundCorners" value
//     static member inline maxBarHeight(value: float) = Interop.mkProperty<IGanttChartProps> "maxBarHeight" value

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

// type [<Erase>] heatMapChartDataPoint =
//     static member inline x(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
//     static member inline x(value: DateTime) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
//     static member inline x(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
//     static member inline y(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
//     static member inline y(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
//     static member inline y(value: DateTime) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
//     static member inline value(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "value" value
//     static member inline rectText(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
//     static member inline rectText(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
//     static member inline ratio(value: float list) = Interop.mkProperty<IHeatMapChartDataPointProp> "ratio" value
//     static member inline descriptionMessage(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "descriptionMessage" value
//     static member inline onClick(value: unit -> unit) = Interop.mkProperty<IHeatMapChartDataPointProp> "onClick" value
//     static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IHeatMapChartDataPointProp> "callOutAccessibilityData" (value |> List.toArray)

// type [<Erase>] heatMapChartData =
//     static member inline legend(value: string) = Interop.mkProperty<IHeatMapChartData> "legend" value
//     static member inline data(value: IHeatMapChartDataPointProp list) = Interop.mkProperty<IHeatMapChartData> "data" (value |> List.toArray)
//     static member inline value(value: float) = Interop.mkProperty<IHeatMapChartData> "value" value

// type [<Erase>] heatMapChartStyles =
//     inherit cartesianChartStyles<IHeatMapChartStyles>
//     static member inline root(value: string) = Interop.mkProperty<IHeatMapChartStyles> "root" value
//     static member inline text(value: string) = Interop.mkProperty<IHeatMapChartStyles> "text" value
//     static member inline calloutContentRoot(value: string) = Interop.mkProperty<IHeatMapChartStyles> "calloutContentRoot" value

// module heatMapChart =
//     type [<Erase>] sortOrder =
//         static member inline none = Interop.mkProperty<IHeatMapChartProps> "sortOrder" "none"
//         static member inline alphabetical = Interop.mkProperty<IHeatMapChartProps> "sortOrder" "alphabetical"

// type [<Erase>] heatMapChart =
//     inherit cartesianChartProps<IHeatMapChartProps>
//     static member inline chartTitle(value: string) =Interop.mkProperty<IHeatMapChartProps> "chartTitle" value
//     static member inline data(value: heatMapChartData list) =Interop.mkProperty<IHeatMapChartProps> "data" (value |> List.toArray)
//     static member inline domainValuesForColorScale(value: float list) =Interop.mkProperty<IHeatMapChartProps> "domainValuesForColorScale" (value |> List.toArray)
//     static member inline rangeValuesForColorScale(value: string list) =Interop.mkProperty<IHeatMapChartProps> "rangeValuesForColorScale" (value |> List.toArray)
//     static member inline xAxisDateFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "xAxisDateFormatString" value
//     static member inline yAxisDateFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "yAxisDateFormatString" value
//     static member inline xAxisNumberFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "xAxisNumberFormatString" value
//     static member inline yAxisNumberFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "yAxisNumberFormatString" value
//     static member inline xAxisStringFormatter(value: string -> string) =Interop.mkProperty<IHeatMapChartProps> "xAxisStringFormatter" value
//     static member inline yAxisStringFormatter(value: string -> string) =Interop.mkProperty<IHeatMapChartProps> "yAxisStringFormatter" value
//     static member inline styles(value: IHeatMapChartStyles list) =Interop.mkProperty<IHeatMapChartProps> "styles" (value |> List.toArray)
//     static member inline culture(value: string) =Interop.mkProperty<IHeatMapChartProps> "culture" value
//     static member inline showYAxisLablesTooltip(value: bool) =Interop.mkProperty<IHeatMapChartProps> "showYAxisLablesTooltip" value
//     static member inline showYAxisLables(value: bool) =Interop.mkProperty<IHeatMapChartProps> "showYAxisLables" value

// type [<Erase>] sNode =
//     static member inline nodeId(value: float) = Interop.mkProperty<ISNode> "nodeId" value
//     static member inline nodeId(value: string) = Interop.mkProperty<ISNode> "nodeId" value
//     static member inline name(value: string) = Interop.mkProperty<ISNode> "name" value
//     static member inline color(value: string) =Interop.mkProperty<ISNode> "color" value
//     static member inline borderColor(value: string) =Interop.mkProperty<ISNode> "borderColor" value
//     static member inline actualValue(value: float) =Interop.mkProperty<ISNode> "actualValue" value
//     static member inline layer(value: float) =Interop.mkProperty<ISNode> "layer" value

// type [<Erase>] sLink =
//     static member inline source(value: float) =Interop.mkProperty<ISLink> "source" value
//     static member inline target(value: float) =Interop.mkProperty<ISLink> "target" value
//     static member inline value(value: float) =Interop.mkProperty<ISLink> "value" value
//     static member inline unnormalizedValue(value: float) =Interop.mkProperty<ISLink> "unnormalizedValue" value

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

// type [<Erase>] groupedVerticalBarChartData =
//     static member inline name(value: string) = Interop.mkProperty<IGroupedVerticalBarChartData> "name" value
//     static member inline series(value: GVBarChartSeriesPoint list) = Interop.mkProperty<IGroupedVerticalBarChartData> "series" (value |> List.toArray)
//     static member inline stackCallOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IGroupedVerticalBarChartData> "stackCallOutAccessibilityData" (value |> List.toArray)

// module groupedVerticalBarChart =
//     type [<Erase>] barWidth =
//         static member inline ``default`` = Interop.mkProperty<ISGroupedVerticalBarChartProps> "barWidth" "default"
//         static member inline auto = Interop.mkProperty<ISGroupedVerticalBarChartProps> "barWidth" "auto"

//     type [<Erase>] mode =
//         static member inline ``default`` = Interop.mkProperty<ISGroupedVerticalBarChartProps> "mode" "default"
//         static member inline plotly = Interop.mkProperty<ISGroupedVerticalBarChartProps> "mode" "plotly"

// type [<Erase>] groupedVerticalBarChartStyles =
//     inherit cartesianChartStyles<IGroupedVerticalBarChartStyles>
//     static member inline barLabel(value: string) = Interop.mkProperty<IGroupedVerticalBarChartStyles> "barLabel" value

// type [<Erase>] groupedVerticalBarChart =
//     inherit cartesianChartProps<ISGroupedVerticalBarChartProps>
//     static member inline data(value: groupedVerticalBarChartData list) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "data" (value |> List.toArray)
//     static member inline barWidth(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "barWidth" value
//     static member inline colors(value: string list) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "colors" (value |> List.toArray)
//     static member inline chartTitle(value: string) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "chartTitle" value
//     static member inline useSingleColor(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "useSingleColor" value
//     static member inline culture(value: string) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "culture" value
//     static member inline styles(value: IGroupedVerticalBarChartStyles list) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "styles" value
//     static member inline isCalloutForStack(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "isCalloutForStack" value
//     static member inline hideLabels(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "hideLabels" value
//     static member inline maxBarWidth(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "maxBarWidth" value
//     static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "xAxisInnerPadding" value
//     static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "xAxisOuterPadding" value
//     static member inline roundCorners(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "roundCorners" value

// type [<Erase>] horizontalDataPoint =
//     /// Independent value of the data point, rendered along the x-axis.
//     /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
//     /// If x is a string, then the data is evenly spaced along the x-axis.
//     static member inline x(value: int) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
//     /// Independent value of the data point, rendered along the x-axis.
//     /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
//     /// If x is a string, then the data is evenly spaced along the x-axis.
//     static member inline x(value: decimal) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
//     /// Independent value of the data point, rendered along the x-axis.
//     /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
//     /// If x is a string, then the data is evenly spaced along the x-axis.
//     static member inline x(value: float) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
//     /// Total value of a single point bar chart.
//     static member inline total(value: float) = Interop.mkProperty<IHorizontalDataPointProp> "total" value
//     /// Total value of a single point bar chart.
//     static member inline total(value: int) = Interop.mkProperty<IHorizontalDataPointProp> "total" value
//     /// Total value of a single point bar chart.
//     static member inline decimal(value: int) = Interop.mkProperty<IHorizontalDataPointProp> "total" value

// module horizontalBarChart =
//     type [<Erase>] chartDataMode =
//         static member inline ``default`` = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "default"
//         static member inline fraction = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "fraction"
//         static member inline percentage = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "percentage"
//         static member inline hidden = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "hidden"

//     type [<Erase>] variant =
//         static member inline PartToWhole = Interop.mkProperty<IHorizontalBarChartProps> "PartToWhole" "part-to-whole"
//         static member inline AbsoluteScale = Interop.mkProperty<IHorizontalBarChartProps> "AbsoluteScale" "absolute-scale"

//     type [<Erase>] styles =
//         static member inline root(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "root" value
//         static member inline items(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "items" value
//         static member inline chart(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chart" value
//         static member inline chartTitle(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartTitle" value
//         static member inline barWrapper(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "barWrapper" value
//         static member inline chartTitleLeft(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartTitleLeft" value
//         static member inline chartTitleRight(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartTitleRight" value
//         static member inline chartDataTextDenominator(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartDataTextDenominator" value
//         static member inline benchmarkContainer(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "benchmarkContainer" value
//         static member inline triangle(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "triangle" value
//         static member inline barLabel(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "barLabel" value
//         static member inline chartWrapper(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartWrapper" value
//         static member inline legendContainer(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "legendContainer" value

// type [<Erase>] horizontalBarChart =
//     static member inline data(value: IChartProps list) = Interop.mkProperty<IHorizontalBarChartProps> "data" (value |> List.toArray)
//     static member inline width(value: float) = Interop.mkProperty<IHorizontalBarChartProps> "width" value
//     static member inline barHeight(value: float) = Interop.mkProperty<IHorizontalBarChartProps> "barHeight" value
//     static member inline className(value: string) = Interop.mkProperty<IHorizontalBarChartProps> "className" value
//     static member inline hideRatio(value: bool list) = Interop.mkProperty<IHorizontalBarChartProps> "hideRatio" (value |> List.toArray)
//     static member inline hideTooltip(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "hideTooltip" value
//     static member inline styles(value: IHorizontalBarChartStyles list) = Interop.mkProperty<IHorizontalBarChartProps> "styles" (value |> List.toArray)
//     static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IHorizontalBarChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
//     static member inline culture(value: string) = Interop.mkProperty<IHorizontalBarChartProps> "culture" value
//     static member inline hideLabels(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "hideLabels" value
//     static member inline color(value: string) = Interop.mkProperty<IHorizontalBarChartProps> "color" value
//     static member inline showTriangle(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "showTriangle" value
//     static member inline legendsOverflowText(value: 'a) = Interop.mkProperty<IHorizontalBarChartProps> "showTriangle" value // TS any prop
//     static member inline legendProps(value: legendProps) = Interop.mkProperty<IHorizontalBarChartProps> "legendProps" value

//     // TODO how to return a type [<Erase>] that is defined through static members through an interface?
//     // static member inline onRenderCallutPerHorizontalBar(props: ??) =
//     // Interop.mkProperty<IHorizontalBarChartProp> "onRenderCalloutPerHorizontalBar" value

//     // TODO how to return a type [<Erase>] that is defined through static members through an interface?
//     // TODO calloutPropsPerDataPoint

//     static member inline showLegendForSinglePointBar(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "showLegendForSinglePointBar" value

// type [<Erase>] horizontalBarChartWithAxisDataPoint =
//     static member inline x(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "x" value
//     static member inline y(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "y" value
//     static member inline y(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "y" value
//     static member inline legend(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "legend" value
//     static member inline color(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "color" value
//     static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "xAxisCalloutData" value
//     static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "yAxisCalloutData" value
//     static member inline onClick(value: unit -> unit) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "onClick" value
//     static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "callOutAccessibilityData" (value |> List.toArray)

// module horizontalBarChartWithAxis =
//     type [<Erase>] styles =
//         inherit cartesianChartStyles<IHorizontalBarChartWithAxisStyles>

//         static member inline chartLabel(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "chartLabel" value
//         static member inline xAxisDomain(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "xAxisDomain" value
//         static member inline xAxisTicks(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "xAxisTicks" value
//         static member inline xAxisText(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "xAxisText" value
//         static member inline yAxisDomain(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "yAxisDomain" value
//         static member inline yAxisTicks(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "yAxisTicks" value
//         static member inline yAxisText(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "yAxisText" value
//         static member inline opacityChangeOnHover(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "opacityChangeOnHover" value

// type [<Erase>] horizontalBarChartWithAxis =
//     inherit cartesianChartProps<IHorizontalBarChartWithAxisProps>

//     static member inline data(value: IHorizontalBarChartWithAxisDataPoint list) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "data" (value |> List.toArray)

//     // TODO onRenderCalloutPerDataPoint

//     static member inline barHeight(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "barHeight" value
//     static member inline colors(value: string list) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "colors" (value |> List.toArray)
//     static member inline chartTitle(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "chartTitle" value
//     static member inline useSingleColor(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "useSingleColor" value
//     static member inline styles(value: IHorizontalBarChartStyles list) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "styles" (value |> List.toArray)
//     static member inline culture(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "culture" value
//     static member inline yAxisPadding(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "yAxisPadding" value
//     static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "showYAxisLablesTooltip" value
//     static member inline showYAxisLables(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "showYAxisLables" value
//     static member inline enableGradient(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "enableGradient" value
//     static member inline roundCorners(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "roundCorners" value

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
    static member inline legendProps(value: ILegendPropProp list) = Interop.mkProperty<'Property> "legendProps" (!!value |> createObj |> unbox)
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
type [<Erase>] cartesianChartStyles =
    ///  Style for the root element
    static member inline root (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "root" value
    /// Style for the element containing the x-axis.
    static member inline xAxis (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "xAxis" value
    /// Style for the element containing the y-axis.
    static member inline yAxis (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "yAxis" value
    /// Style for legend container
    static member inline legendContainer (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "legendContainer" value
    /// line hover box css
    static member inline hover (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "hover" value
    /// styles for description message
    static member inline descriptionMessage (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "descriptionMessage" value
    /// styles for tooltip
    static member inline tooltip (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "tooltip" value
    /// styles for axis title
    static member inline axisTitle (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "axisTitle" value
    /// styles for axis annotation
    static member inline axisAnnotation (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "axisAnnotation" value
    /// Style for the chart Title.
    static member inline chartTitle (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "chartTitle" value
    /// Style to change the opacity of bars in dataviz when we hover on a single bar or legends
    static member inline opacityChangeOnHover (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "opacityChangeOnHover" value
    /// styles for the shape object in the callout
    static member inline shapeStyles (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "shapeStyles" value
    /// Styles for the chart wrapper div
    static member inline chartWrapper (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "chartWrapper" value
    /// Styles for the svg tooltip
    static member inline svgTooltip (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "svgTooltip" value
    /// Styles for the chart svg element
    static member inline chart (value: string) = Interop.mkProperty<ICartesianChartStylesProp> "chart" value

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
    static member inline YValueHover (value: IYValueHoverProp list) = Interop.mkProperty<IChartPopoverProp> "YValueHover" (value |> List.toArray) //TODO maybe won't work?
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
type [<Erase>] accessibilityProp =
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
    static member inline data(value: IChartPropProp list) = Interop.mkProperty<IAreaChartProp> "data" (!!value |> createObj |> unbox)
    // TODO static member inline onRenderCalloutPerDataPoint(value: 'a)
    // TODO static member inline onRenderCalloutPerStack(value: 'a)
    /// Call to provide customized styling that will layer on top of the variant rules.
    static member inline styles(value: ICartesianChartStylesProp list) = Interop.mkProperty<IAreaChartProp> "styles" (!!value |> createObj |> unbox)
    /// Define a custom callout renderer for a data point
    static member inline onRenderCalloutPerDataPoint(value: RenderFunction<CustomizedCalloutData>) = Interop.mkProperty<IAreaChartProp> "onRenderCalloutPerDataPoint" (System.Func<_,_,_> value)
    /// Define a custom callout renderer for a stack; default is to render per data point
    static member inline onRenderCalloutPerStack(value: RenderFunction<CustomizedCalloutData>) = Interop.mkProperty<IAreaChartProp> "onRenderCalloutPerStack" (System.Func<_,_,_> value)
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

//----------------------------------------------------------------- ChartProp -------------------------------------------------
type [<Erase>] chartProp =
    /// Chart title for the chart
    static member inline chartTitle (value: string) = Interop.mkProperty<IChartPropProp> "chartTitle" value
    /// Accessibility data for chart title
    static member inline chartTitleAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<IChartPropProp> "chartTitleAccessibilityData" (!!value |> createObj |> unbox)
    /// data for the points in the chart
    static member inline chartData (value: IChartDataPointProp list list) =
                            let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                            Interop.mkProperty<IChartPropProp> "chartData" newValue
    /// Accessibility data for chart data
    static member inline chartDataAccessibilityData (value: IAccessibilityProp list) = Interop.mkProperty<IChartPropProp> "chartDataAccessibilityData" (!!value |> createObj |> unbox)
    /// data for the points in the line chart
    static member inline lineChartData (value: ILineChartPointsProp list list) =
                    let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                    Interop.mkProperty<IChartPropProp> "lineChartData" newValue
    /// data for the points in the scatter chart
    static member inline scatterChartData (value: IScatterChartPointsProp list list) =
                    let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                    Interop.mkProperty<IChartPropProp> "scatterChartData" newValue
    /// data for the points in the line chart
    static member inline sankeyChartData (value: ISankeyChartDataProp list list) =
                    let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                    Interop.mkProperty<IChartPropProp> "SankeyChartData" newValue
    /// data for the points in the line chart
    static member inline pointOptions (value: obj) = Interop.mkProperty<IChartPropProp> "pointOptions" value //TODO
    /// data for the dotted line on hovering the point
    static member inline pointLineOptions (value: obj) = Interop.mkProperty<IChartPropProp> "pointLineOptions" value //TODO

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
    static member inline horizontalBarChartdata (value: IHorizontalDataPointProp) = Interop.mkProperty<IChartDataPointProp> "horizontalBarChartdata" value
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
    static member inline data (value: ILineChartDataPointProp list list) =
                    let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                    Interop.mkProperty<ILineChartPointsProp> "data" newValue
    /// dataPoints for the line chart
    static member inline data (value: IScatterChartDataPointProp list list) =
                    let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                    Interop.mkProperty<ILineChartPointsProp> "data" newValue
    /// dataPoints for the line chart
    static member inline data (value: 'T list) = Interop.mkProperty<ILineChartPointsProp> "data" (value |> List.toArray)
    /// Legend text for the datapoint in the chart
    static member inline gaps (value: ILineChartGapProp list list) =
                    let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                    Interop.mkProperty<ILineChartPointsProp> "gaps" newValue
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
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: int) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: decimal) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: float) = Interop.mkProperty<ILineChartDataPointProp> "y" value
    /// Independent value of the data point, rendered along the y-axis.
    static member inline y (value: DateTime) = Interop.mkProperty<ILineChartDataPointProp> "y" value
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
    static member inline nodes (value: ISNodeProp list list) =
                        let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                        Interop.mkProperty<ISankeyChartDataProp> "nodes" newValue
    static member inline links (value: ISLinkProp list list) =
                        let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                        Interop.mkProperty<ISankeyChartDataProp> "links" newValue

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
    static member inline headers (value: IChartTableHeaderProp list list) =
                            let newValue = value |> List.map (fun props -> !!props |> createObj |> unbox) |> List.toArray
                            Interop.mkProperty<IChartTableProp> "headers" newValue
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
    static member inline root(value: IStyleAttribute list) = Interop.mkProperty<IChartTableStylesProp> "root" (!!value |> createObj |> unbox) //TODO ?
    static member inline table(value: string) = Interop.mkProperty<IChartTableStylesProp> "table" value
    static member inline headerCell(value: string) = Interop.mkProperty<IChartTableStylesProp> "headerCell" value
    static member inline bodyCell(value: string) = Interop.mkProperty<IChartTableStylesProp> "bodyCell" value
    static member inline chart(value: string) = Interop.mkProperty<IChartTableStylesProp> "chart" value

//----------------------------------------------------------------- DonutChart -------------------------------------------------
type [<Erase>] donutChart =
    inherit cartesianChart<IDonutChartProp>
    /// Data to render in the chart.
    static member inline data(value: IChartPropProp list) = Interop.mkProperty<IDonutChartProp> "data" (!!value |> createObj |> unbox)
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
    static member inline legendProps(value: ILegendPropProp list) = Interop.mkProperty<IDonutChartProp> "legendProps" (!!value |> createObj |> unbox)
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
