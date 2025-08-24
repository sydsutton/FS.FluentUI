namespace FS.Charts

open System
open Fable.Core
open Fable.Core.JsInterop
open FS.Charts
open Feliz

type [<Erase>] legendShape<'property> =
    static member inline ``default`` = Interop.mkProperty<'property> "legendShape" "default"
    static member inline circle = Interop.mkProperty<'property> "legendShape" "circle"
    static member inline square = Interop.mkProperty<'property> "legendShape" "square"
    static member inline triangle = Interop.mkProperty<'property> "legendShape" "triangle"
    static member inline diamond = Interop.mkProperty<'property> "legendShape" "diamond"
    static member inline pyramid = Interop.mkProperty<'property> "legendShape" "pyramid"
    static member inline hexagon = Interop.mkProperty<'property> "legendShape" "hexagon"
    static member inline pentagon = Interop.mkProperty<'property> "legendShape" "pentagon"
    static member inline octagon = Interop.mkProperty<'property> "legendShape" "octagon"

// Need this in order for legendProps type to create property 'shape', while all other types use 'legendShape'
type [<Erase>] shape<'property> =
    static member inline ``default`` = Interop.mkProperty<'property> "shape" "default"
    static member inline circle = Interop.mkProperty<'property> "shape" "circle"
    static member inline square = Interop.mkProperty<'property> "shape" "square"
    static member inline triangle = Interop.mkProperty<'property> "shape" "triangle"
    static member inline diamond = Interop.mkProperty<'property> "shape" "diamond"
    static member inline pyramid = Interop.mkProperty<'property> "shape" "pyramid"
    static member inline hexagon = Interop.mkProperty<'property> "shape" "hexagon"
    static member inline pentagon = Interop.mkProperty<'property> "shape" "pentagon"
    static member inline octagon = Interop.mkProperty<'property> "shape" "octagon"

type [<Erase>] legendsStyles =
    // Style set for the root of the legend component
    static member inline root(value: string) = Interop.mkProperty<ILegendsStyles> "root" value
    // Style set for Legend. This is a wrapping class for text of legend and the rectange box that represents a legend
    static member inline legend(value: string) = Interop.mkProperty<ILegendsStyles> "legend" value
    // Style set for the rectangle that represents a legend
    static member inline rect(value: string) = Interop.mkProperty<ILegendsStyles> "rect" value
    // styles set for the shape that represents a legend
    static member inline shape(value: string) = Interop.mkProperty<ILegendsStyles> "shape" value
    // Style set for the triangle that represents a legend
    static member inline triangle(value: string) = Interop.mkProperty<ILegendsStyles> "triangle" value
    // Style for the legend text
    static member inline text(value: string) = Interop.mkProperty<ILegendsStyles> "text" value
    // Style for the legend text
    static member inline hoverChange(value: string) = Interop.mkProperty<ILegendsStyles> "hoverChange" value
    // Style for the area that is resizable
    static member inline resizableArea(value: string) = Interop.mkProperty<ILegendsStyles> "resizableArea" value

    static member inline legendContainer(value: string) = Interop.mkProperty<ILegendsStyles> "legendContainer" value
    // Style for the annotation that is used in the legend
    static member inline annotation(value: string) = Interop.mkProperty<ILegendsStyles> "annotation" value

module legend =
    type [<Erase>] shape = class inherit shape<ILegend> end // Forgive me for using a class

type [<Erase>] legend =
    // Defines the title of the legend
    static member inline title(value: string) = Interop.mkProperty<ILegend> "title" value
    // Defines the function that is executed on clicking this legend
    static member inline action(value: unit -> unit) = Interop.mkProperty<ILegend> "action" value
    // Defines the function that is executed upon hovering over the legend
    static member inline hoverAction(value: unit -> unit) = Interop.mkProperty<ILegend> "hoverAction" value
    // Defines the function that is executed upon moving the mouse away from the legend
    static member inline onMouseOutAction(value: bool option -> unit) = Interop.mkProperty<ILegend> "onMouseOutAction" value
    // The color for the legend
    static member inline color(value: string) = Interop.mkProperty<ILegend> "color" value
    // The opacity of the legend color
    static member inline opacity(value: float) = Interop.mkProperty<ILegend> "opacity" value
    // The shape for the legend
    // Indicated whether or not to apply stripe pattern
    static member inline stripePattern(value: bool) = Interop.mkProperty<ILegend> "stripePattern" value
    // Indicates if the legend belongs to a line in the Bar Chart
    static member inline isLineLegendInBarChart(value: bool) = Interop.mkProperty<ILegend> "isLineLegendInBarChart" value
    // static member inline nativeButtonProps(value?: React_2) = Interop.mkProperty<ILegend> "" value.ButtonHTMLAttributes<HTMLButtonElement>;
    // The annotation for the legend, function returning a React node
    static member inline legendAnnotation(value: ReactElement -> unit ) = Interop.mkProperty<ILegend> "legendAnnotation" value

module legendProps =
    type [<Erase>] shape = class inherit shape<ILegendProp> end

type [<Erase>] legendProps =
    /// Prop that takes array of legends
    static member inline legends(value: ILegend list) = Interop.mkProperty<ILegendProp> "legends" (value |> List.toArray)
    /// Additional CSS class(es) to apply to the legends component
    static member inline className(value: string) = Interop.mkProperty<ILegendProp> "className" value
    /// Call to provide customized styling that will layer on top of the variant rules
    static member inline styles(value: ILegendsStyles list) = Interop.mkProperty<ILegendProp> "styles" (keyValueList CaseRules.LowerFirst value)
    /// This prop makes the legends component align itself to the center in the container
    static member inline centerLegends(value: bool) = Interop.mkProperty<ILegendProp> "centerLegends" value
    /// Enable the legends to wrap lines if there is not enough space to show all legends on a single line
    static member inline enabledWrapLines(value: bool) = Interop.mkProperty<ILegendProp> "enabledWrapLines" value
    /// Style for the overflow component
    static member inline overflowStyles(value: IStyleAttribute list) = Interop.mkProperty<ILegendProp> "overflowStyles" value
    /// Text for overflow legends string
    static member inline overflowText(value: string) = Interop.mkProperty<ILegendProp> "overflowText" value
    /// Prop that decides if legends are focusable
    static member inline allowFocusOnLegends(value: bool) = Interop.mkProperty<ILegendProp> "allowFocusOnLegends" value
    /// Prop that decides if we can select multiple legends or single legend at a time
    static member inline canSelectMultipleLegends(value: bool) = Interop.mkProperty<ILegendProp> "canSelectMultipleLegends" value
    // Callback issued when the selected option changes
    // TODO not sure how to handle this
    // static member inline onChange(selectedLegends: string[], event: React_2.MouseEvent<HTMLButtonElement>, currentLegend?: Legend) => void

    /// Keys (titles that will be initially used to set selected items for multi-select scenarios
    static member inline defaultSelectedLegends(value: string array) = Interop.mkProperty<ILegendProp> "defaultSelectedLegends" value
    /// Key that will be initially used to set selected item for single-select scenarios
    static member inline defaultSelectedLegend(value: string) = Interop.mkProperty<ILegendProp> "defaultSelectedLegend" value
    /// Keys (titles) that will be used to set selected items in multi-select scenarios
    static member inline selectedLegends(value: string array) = Interop.mkProperty<ILegendProp> "selectedLegends" value
    /// Key (title) that will be used to set the selected item in single-select scenarios
    static member inline selectedLegend(value: string) = Interop.mkProperty<ILegendProp> "selectedLegend" value

    /// Reference to access the public methods and properties of the component
    // TODO static member inline legendRef: React_2.RefObject<LegendContainer>

type [<Erase>] cartesianChartStyles<'Property> =
    //Additional CSS class(es) to apply to the Chart.
    static member inline className(value: string) = Interop.mkProperty<'Property> "className" value
    /// Width of the chart.
    static member inline width(value: int) = Interop.mkProperty<'Property> "width" value
    /// Height of the chart.
    static member inline height(value: int) = Interop.mkProperty<'Property> "height" value
    /// Color of the chart.
    static member inline color(value: string) = Interop.mkProperty<'Property> "color" value
    /// Link to redirect if click action for graph
    static member inline href(value: string) = Interop.mkProperty<'Property> "href" value
    /// Prop to check if the chart is selected or hovered upon to determine opacity
    static member inline shouldHighlight(value: bool) = Interop.mkProperty<'Property> "shouldHighlight" value
    /// Prop to check if the Page is in Rtl
    static member inline useRtl(value: bool) = Interop.mkProperty<'Property> "useRtl" value
    /// Color of the line
    static member inline lineColor(value: string) = Interop.mkProperty<'Property> "lineColor" value
    /// Boolean flag which determines if shape is drawn in callout
    static member inline toDrawShape(value: bool) = Interop.mkProperty<'Property> "toDrawShape" value
    /// Prop to disable shrinking of the chart beyond a certain limit and enable scrolling when the chart overflows
    /// [Deprecated: Use reflowProps instead]
    static member inline enableReflow(value: bool) = Interop.mkProperty<'Property> "enableReflow" value

type [<Erase>] axisProps =
    static member inline tickStep(value: float) = Interop.mkProperty<string> "tickStep" value
    static member inline tickStep(value: string) = Interop.mkProperty<string> "tickStep" value
    static member inline tick0(value: float) = Interop.mkProperty<string> "tick0" value
    static member inline tick0(value: DateTime) = Interop.mkProperty<string> "tick0" value

type [<Erase>] margins =
    static member inline left(value: float) = Interop.mkProperty<IMargins> "left" value
    static member inline right(value: float) = Interop.mkProperty<IMargins> "right" value
    static member inline top(value: float) = Interop.mkProperty<IMargins> "top" value
    static member inline bottom(value: float) = Interop.mkProperty<IMargins> "bottom" value

type [<Erase>] chartPopoverProps =
    static member inline clickPosition(value: {|x: float; y:float|}) = Interop.mkProperty<IChartPopoverProps> "clickPosition" value
    static member inline isPopoverOpen(value: bool) = Interop.mkProperty<IChartPopoverProps> "isPopoverOpen" value
    static member inline xCalloutValue(value: string) = Interop.mkProperty<IChartPopoverProps> "xCalloutValue" value
    static member inline legend(value: string) = Interop.mkProperty<IChartPopoverProps> "legend" value
    static member inline legend(value: float) = Interop.mkProperty<IChartPopoverProps> "legend" value
    static member inline legend(value: DateTime) = Interop.mkProperty<IChartPopoverProps> "legend" value
    static member inline yCalloutValue(value: string) = Interop.mkProperty<IChartPopoverProps> "yCalloutValue" value
    static member inline YValue(value: string) = Interop.mkProperty<IChartPopoverProps> "YValue" value
    static member inline YValue(value: float) = Interop.mkProperty<IChartPopoverProps> "YValue" value
    static member inline YValue(value: DateTime) = Interop.mkProperty<IChartPopoverProps> "YValue" value
    static member inline XValue(value: string) = Interop.mkProperty<IChartPopoverProps> "XValue" value
    static member inline color(value: string) = Interop.mkProperty<IChartPopoverProps> "color" value
    static member inline culture(value: string) = Interop.mkProperty<IChartPopoverProps> "culture" value
    // TODO static member inline customCallout(: {
    //     customizedCallout?: JSXElement;
    //     customCalloutProps?: ChartPopoverProps;
    // };
    static member inline isCalloutForStack(value: bool) = Interop.mkProperty<IChartPopoverProps> "isCalloutForStack" value

    // TODO xAxisCalloutAccessibilityData?: {
    //     ariaLabel?: string;
    //     data?: string;
    // };
    static member inline hoverXValue(value: string) = Interop.mkProperty<IChartPopoverProps> "hoverXValue" value
    static member inline hoverXValue(value: float) = Interop.mkProperty<IChartPopoverProps> "hoverXValue" value

    // TODO YValueHover?: YValueHover[];
    static member inline descriptionMessage(value: string) = Interop.mkProperty<IChartPopoverProps> "descriptionMessage" value
    static member inline ratio(value: float list) = Interop.mkProperty<IChartPopoverProps> "ratio" (value |> List.toArray)
    static member inline isCartesian(value: bool) = Interop.mkProperty<IChartPopoverProps> "isCartesian" value

    // TODO styles?: Partial<PopoverComponentStyles>;

type [<Erase>] cartesianChartProps<'property> =
    // Below height used for resizing of the chart
    // Wrap chart in your container and send the updated height and width to these props.
    // These values decide wheather chart re render or not. Please check examples for reference
    static member inline height(value: float) = Interop.mkProperty<'property> "height" value
    /// Below width used for resizing of the chart
    /// Wrap chart in your container and send the updated height and width to these props.
    /// These values decide wheather chart re render or not. Please check examples for reference
    static member inline width(value: float) = Interop.mkProperty<'property> "width" value
    /// This prop takes its parent as a HTML element to define the width and height of the chart
    static member inline parentRef(value: Browser.Types.HTMLElement option) = Interop.mkProperty<'property> "parentRef" value
    /// Additional CSS class(es) to apply to the Chart
    static member inline className(value: string) = Interop.mkProperty<'property> "className" value
    /// Margins for the chart
    /// Default: { top: 20, bottom: 35, left: 40, right: 20 }
    /// To avoid edge cuttings to the chart, we recommend you use default values or greater then default values
    static member inline margins(value: IMargins list) = Interop.mkProperty<'property> "margins" (createObj !!value)
    /// Decides whether to show/hide legends
    // Default: false
    static member inline hideLegend(value: bool) = Interop.mkProperty<'property> "hideLegend" value
    /// Do not show tooltips in chart
    /// Default: false
    static member inline hideTooltip(value: bool) = Interop.mkProperty<'property> "hideTooltip" value
    /// This prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    static member inline tickValues(value: float list) = Interop.mkProperty<'property> "tickValues" (value |> List.toArray)
    /// This prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    static member inline tickValues(value: DateTime list) = Interop.mkProperty<'property> "tickValues" (value |> List.toArray)
    /// This prop takes values that you want the chart to render on x-axis
    /// This is a optional parameter if not specified D3 will decide which values appear on the x-axis for you
    static member inline tickValues(value: string list) = Interop.mkProperty<'property> "tickValues" (value |> List.toArray)
    /// The format for the data on x-axis. For date object this can be specified to your requirement. Eg: '%m/%d', '%d'
    /// Please look at https://github.com/d3/d3-time-format for all the formats supported for date axis
    /// Only applicable for date axis. For y-axis format use yAxisTickFormat prop.
    static member inline tickFormat(value: string) = Interop.mkProperty<'property> "tickFormat" value
    /// Width of line stroke
    static member inline strokeWidth(value: float) = Interop.mkProperty<'property> "strokeWidth" value
    /// x Axis labels tick padding. This defines the gap between tick labels and tick lines.
    /// Default: 10
    static member inline xAxisTickPadding(value: float) = Interop.mkProperty<'property> "xAxisTickPadding" value
    /// The format in for the data on y-axis. For data object this can be specified to your requirement.
    /// Eg: d3.format(".0%")(0.123),d3.format("+20")(42);
    /// Please look at https://github.com/d3/d3-format for all the formats supported
    static member inline yAxisTickFormat(value: obj) = Interop.mkProperty<'property> "yAxisTickFormat" value
    /// Secondary y-scale options
    /// By default this is not defined, meaning there will be no secondary y-scale.
    static member inline secondaryYScaleOptions(value: obj) = Interop.mkProperty<'property> "secondaryYScaleOptions" value // TODO
    /// Minimum data value point in y-axis
    static member inline yMinValue(value: float) = Interop.mkProperty<'property> "yMinValue" value
    /// Maximum data value point in y-axis
    static member inline yMaxValue(value: float) = Interop.mkProperty<'property> "yMaxValue" value
    /// Maximum data value point in x-axis
    static member inline xMaxValue(value: float) = Interop.mkProperty<'property> "xMaxValue" value
    /// Number of ticks on the y-axis.
    /// Tick count should be factor of difference between (yMinValue, yMaxValue)?
    /// Default: 4
    static member inline yAxisTickCount(value: int) = Interop.mkProperty<'property> "yAxisTickCount" value
    /// Defines the number of ticks on the x-axis. Tries to match the nearest interval satisfying the count.
    /// Does not work for string axis.
    /// Default: 6
    static member inline xAxisTickCount(value: int) = Interop.mkProperty<'property> "xAxisTickCount" value
    /// Define the size of the tick lines on the x-axis
    /// Default: 10
    static member inline xAxistickSize(value: float) = Interop.mkProperty<'property> "xAxistickSize" value
    /// Defines the space between the tick line and the data label
    /// Default: 10
    static member inline tickPadding(value: float) = Interop.mkProperty<'property> "tickPadding" value
    /// Url that the data-viz needs to redirect to upon clicking on it
    static member inline href(value: string) = Interop.mkProperty<'property> "href" value
    /// Legends overflow text
    static member inline legendsOverflowText(value: obj) = Interop.mkProperty<'property> "legendsOverflowText" value
    /// Enable the legends to wrap lines if there is not enough space to show all legends on a single line
    static member inline enabledLegendsWrapLines(value: bool) = Interop.mkProperty<'property> "enabledLegendsWrapLines" value
    /// Legend properties
    static member inline legendProps(value: ILegendProp list) = Interop.mkProperty<'property> "legendProps" (keyValueList CaseRules.LowerFirst value)
    /// Default: false
    /// Used for to elipse x axis labes and show tooltip on x axis labels
    static member inline showXAxisLablesTooltip(value: bool) = Interop.mkProperty<'property> "showXAxisLablesTooltip" value
    /// Default: 4
    /// Used for X axis labels
    /// While Giving showXAxisLablesTooltip prop, need to define after how many chars, we need to truncate the word.
    static member inline noOfCharsToTruncate(value: int) = Interop.mkProperty<'property> "noOfCharsToTruncate" value
    /// Default: false
    /// Used to wrap x axis labels values (whole value)
    static member inline wrapXAxisLables(value: bool) = Interop.mkProperty<'property> "wrapXAxisLables" value
    /// Default: false
    /// Used to rotate x axis labels by 45 degrees
    static member inline rotateXAxisLables(value: bool) = Interop.mkProperty<'property> "rotateXAxisLables" value
    // The prop used to define the date time localization options
    static member inline dateLocalizeOptions(value: obj) = Interop.mkProperty<'property> "dateLocalizeOptions" value // Intl.DateTimeFormatOptions
    // The prop used to define a custom locale for the date time format
    static member inline timeFormatLocale(value: obj) = Interop.mkProperty<'property> "timeFormatLocale" value // TimeLocaleDefinition
    /// The prop used to define a custom datetime formatter for date axis
    static member inline customDateTimeFormatter(value: DateTime -> string) = Interop.mkProperty<'property> "customDateTimeFormatter" value
    /// Call to provide customized styling that will layer on top of the variant rules
    static member inline styles(value: cartesianChartStyles<'property> list) = Interop.mkProperty<'property> "styles" (keyValueList CaseRules.LowerFirst value)

    // Callout customization props
    static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<'property> "calloutProps" (keyValueList CaseRules.LowerFirst value)

    // Props for the svg; use this to include aria-* or other attributes on the tag
    // TODO static member inline svgProps(value: obj) = Interop.mkProperty<'property> "svgProps" value
    // Prop to disable shrinking of the chart beyond a certain limit and enable scrolling when the chart overflows
    // Deprecated: Use reflowProps instead

    static member inline enableReflow(value: bool) = Interop.mkProperty<'property> "enableReflow" value

    // Props related to reflow behavior of the chart
    // TODO static member inline reflowProps(value: string) = Interop.mkProperty<'property> "reflowProps" value
    // Prop to set the x axis title
    // Default: undefined
    // Minimum bottom margin required for x axis title is 55px

    static member inline xAxisTitle(value: string) = Interop.mkProperty<'property> "xAxisTitle" value
    /// Prop to set the y axis title
    /// Default: undefined
    /// Minimum left margin required for y axis title is 60px and for RTL is 40px
    /// Minimum right margin required for y axis title is 40px and for RTL is 60px
    static member inline yAxisTitle(value: string) = Interop.mkProperty<'property> "yAxisTitle" value
    /// Prop to set the secondary y axis title
    /// Default: undefined
    /// If RTL is enabled, minimum left and right margins required for secondary y axis title is 60px
    static member inline secondaryYAxistitle(value: string) = Interop.mkProperty<'property> "secondaryYAxistitle" value
    /// Whether to use UTC time for axis scale, ticks, and the time display in callouts.
    /// When set to true, time is displayed equally, regardless of the user's timezone settings.
    /// Default: true
    static member inline useUTC(value: string) = Interop.mkProperty<'property> "useUTC" value
    /// Whether to use UTC time for axis scale, ticks, and the time display in callouts.
    /// When set to true, time is displayed equally, regardless of the user's timezone settings.
    /// Default: true
    static member inline useUTC(value: bool) = Interop.mkProperty<'property> "useUTC" value
    /// Default: false
    /// The prop used to decide rounded ticks on y axis
    static member inline roundedTicks(value: bool) = Interop.mkProperty<'property> "roundedTicks" value
    /// Determines whether overlapping x-axis tick labels should be hidden
    /// Default: true
    static member inline hideTickOverlap(value: bool) = Interop.mkProperty<'property> "hideTickOverlap" value
    /// Define a custom callout props override
    static member inline calloutPropsPerDataPoint(value: obj -> obj) = Interop.mkProperty<'property> "calloutPropsPerDataPoint" value // TODO
    /// Optional callback to access the Chart interface. Use this instead of ref for accessing
    /// the public methods and properties of the component
    static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<'property> "componentRef" value
    /// Prop to set the x axis annotation. Used to display additional information on the x-axis.
    /// This is shown on the top of the chart.
    /// Default: undefined
    static member inline xAxisAnnotation(value: string) = Interop.mkProperty<'property> "xAxisAnnotation" value
    /// Prop to set the y axis annotation. Used to display additional information on the y-axis.
    /// This is shown on the right side of the chart. Not shown if secondary y-axis is enabled.
    /// Default: undefined
    static member inline yAxisAnnotation(value: string) = Interop.mkProperty<'property> "yAxisAnnotation" value
    /// Specifies the ordering logic for categories (or string tick labels) on the x-axis
    /// Default: 'default'
    static member inline xAxisCategoryOrder(value: IAxisCategoryOrder) = Interop.mkProperty<'property> "xAxisCategoryOrder" value
    /// Specifies the ordering logic for categories (or string tick labels) on the y-axis
    /// Default: 'default'
    static member inline yAxisCategoryOrder(value: IAxisCategoryOrder) = Interop.mkProperty<'property> "yAxisCategoryOrder" value
    /// Defines the scale type for the x-axis
    /// Default: 'default'
    /// default or 'log'
    static member inline xScaleType(value: string) = Interop.mkProperty<'property> "xScaleType" value
    /// Defines the scale type for the primary y-axis
    /// Default: 'default'
    /// default or 'log'
    static member inline yScaleType(value: string) = Interop.mkProperty<'property> "yScaleType" value
    /// Defines the scale type for the secondary y-axis
    /// Default: 'default'
    /// default or 'log'
    static member inline secondaryYScaleType(value: string) = Interop.mkProperty<'property> "secondaryYScaleType" value
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation
    static member inline yAxisTickValues(value: float list) = Interop.mkProperty<'property> "yAxisTickValues" (value |> List.toArray)
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation
    static member inline yAxisTickValues(value: DateTime list) = Interop.mkProperty<'property> "yAxisTickValues" (value |> List.toArray)
    /// Explicit set of tick values for the y-axis.
    /// If provided, these values override automatic tick generation
    static member inline yAxisTickValues(value: string list) = Interop.mkProperty<'property> "yAxisTickValues" (value |> List.toArray)
    /// Configuration for the x-axis.
    /// Use this to control tickStep, tick0, etc.
    static member inline xAxis(value: axisProps list) = Interop.mkProperty<'property> "xAxis" (value |> List.toArray)
    /// Configuration for the y-axis.
    /// Use this to control tickStep, tick0, etc.
    static member inline yAxis(value: axisProps list) = Interop.mkProperty<'property> "yAxis" (value |> List.toArray)

type [<Erase>] chartDataPoint =
    /// Legen text for the datapoint in the chart
    static member inline legend(value: string) = Interop.mkProperty<IChartDataPoint> "legend" value
    /// data the datapoint in the chart
    static member inline data(value: float) = Interop.mkProperty<IChartDataPoint> "data" value
    /// data the datapoint in the chart
    static member inline horizontalBarChartdata(value: IHorizontalDataPointProp list) = Interop.mkProperty<IChartDataPoint> "horizontalBarChartdata" (createObj !!value)
    /// onClick action for each datapoint in the chart
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IChartDataPoint> "onClick" value
    /// Color for the legend in the chart. If not provided, it will fallback on the default color palette.
    static member inline color(value: string) = Interop.mkProperty<IChartDataPoint> "color" value
    /// placeholder data point
    static member inline placeHolder(value: bool) = Interop.mkProperty<IChartDataPoint> "placeHolder" value
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IChartDataPoint> "xAxisCalloutData" value
    /// This is an optional prop, If haven't given data will take
    /// Callout data for y axis
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IChartDataPoint> "yAxisCalloutData" value
    /// Accessibility data for callout
    static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IChartDataPoint> "callOutAccessibilityData" (value |> List.toArray)

type [<Erase>] lineChartLineOptions =
    /// Width of the line/stroke.
    /// Overrides the strokeWidth set on ICartesianChartProps level.
    /// @see https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/stroke-width
    static member strokeWidth(value: float) = Interop.mkProperty<ILineChartLineOptions> "strokeWidth" value
    /// Pattern of dashes and gaps.
    /// @see https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/stroke-dasharray
    static member strokeDasharray(value: float) = Interop.mkProperty<ILineChartLineOptions> "strokeDasharray" value
    /// Offset on rendering of stroke dash array.
    /// @see https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/stroke-dashoffset
    static member strokeDashoffset(value: float) = Interop.mkProperty<ILineChartLineOptions> "strokeDashoffset" value
    /// Width of border around the line. Default no border.
    static member lineBorderWidth(value: float) = Interop.mkProperty<ILineChartLineOptions> "lineBorderWidth" value
    /// Color of border around the line. Default white.
    static member lineBorderColor(value: string) = Interop.mkProperty<ILineChartLineOptions> "lineBorderColor" value

module lineChartLineOptions =
    type [<Erase>] curve =
        static member inline linear = Interop.mkProperty<ILineChartLineOptions> "curve" "linear"
        static member inline natural = Interop.mkProperty<ILineChartLineOptions> "curve" "natural"
        static member inline step = Interop.mkProperty<ILineChartLineOptions> "curve" "step"
        static member inline stepAfter = Interop.mkProperty<ILineChartLineOptions> "curve" "stepAfter"
        static member inline stepBefore = Interop.mkProperty<ILineChartLineOptions> "curve" "stepBefore"

    type [<Erase>] strokeLinecap =
        static member inline butt = Interop.mkProperty<ILineChartLineOptions> "strokeLinecap" "butt"
        static member inline round = Interop.mkProperty<ILineChartLineOptions> "strokeLinecap" "round"
        static member inline square = Interop.mkProperty<ILineChartLineOptions> "strokeLinecap" "square"
        static member inline ``inherit`` = Interop.mkProperty<ILineChartLineOptions> "strokeLinecap" "inherit"

    type [<Erase>] mode =
        static member inline lines = Interop.mkProperty<ILineChartLineOptions> "mode" "lines"
        static member inline markers = Interop.mkProperty<ILineChartLineOptions> "mode" "markers"
        static member inline text = Interop.mkProperty<ILineChartLineOptions> "mode" "text"
        static member inline linesMarkers = Interop.mkProperty<ILineChartLineOptions> "mode" "lines+markers"
        static member inline textMarkers = Interop.mkProperty<ILineChartLineOptions> "mode" "text+markers"
        static member inline textLines = Interop.mkProperty<ILineChartLineOptions> "mode" "text+lines"
        static member inline textLinesMarkers = Interop.mkProperty<ILineChartLineOptions> "mode" "text+lines+markers"
        static member inline none = Interop.mkProperty<ILineChartLineOptions> "mode" "none"
        static member inline gauge = Interop.mkProperty<ILineChartLineOptions> "mode" "gauge"
        static member inline number = Interop.mkProperty<ILineChartLineOptions> "mode" "number"
        static member inline delta = Interop.mkProperty<ILineChartLineOptions> "mode" "delta"
        static member inline numberDelta = Interop.mkProperty<ILineChartLineOptions> "mode" "number+delta"
        static member inline gaugeNumber = Interop.mkProperty<ILineChartLineOptions> "mode" "gauge+number"
        static member inline gaugeNumberDelta = Interop.mkProperty<ILineChartLineOptions> "mode" "gauge+number+delta"
        static member inline gaugeDelta = Interop.mkProperty<ILineChartLineOptions> "mode" "gauge+delta"
        static member inline markersText = Interop.mkProperty<ILineChartLineOptions> "mode" "markers+text"
        static member inline linesText = Interop.mkProperty<ILineChartLineOptions> "mode" "lines+text"
        static member inline linesMarkersText = Interop.mkProperty<ILineChartLineOptions> "mode" "lines+markers+text"

type [<Erase>] lineChartDataPoint =
    static member inline x(value: float) = Interop.mkProperty<ILineChartDataPoint> "x" value
    static member inline x(value: DateTime) = Interop.mkProperty<ILineChartDataPoint> "x" value
    static member inline y(value: float) = Interop.mkProperty<ILineChartDataPoint> "y" value
    static member inline text(value: string) = Interop.mkProperty<ILineChartDataPoint> "string" value

module lineChartData =
    type [<Erase>] legendShape =
        class
            inherit legendShape<ILineChartDataProp>
        end

type [<Erase>] lineChartData =
    static member inline legend(value: string) = Interop.mkProperty<ILineChartDataProp> "legend" value
    static member inline data(value: ILineChartDataPoint list) = Interop.mkProperty<ILineChartDataProp> "data" (value |> List.toArray)
    static member inline color(value: string) = Interop.mkProperty<ILineChartDataProp> "color" value
    static member inline opacity(value: float) = Interop.mkProperty<ILineChartDataProp> "opacity" value
    static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<ILineChartDataProp> "lineOptions" (keyValueList CaseRules.LowerFirst value)
    static member inline gaps(value: ILineChartGap list) = Interop.mkProperty<ILineChartDataProp> "gaps" (value |> List.toArray)
    static member inline hideNonActiveDots(value: bool) = Interop.mkProperty<ILineChartDataProp> "hideNonActiveDots" value
    static member inline onLegendClick(value: string option -> unit) = Interop.mkProperty<ILineChartDataProp> "onLegendClick" value
    static member inline onLineCLick(value: unit -> unit) = Interop.mkProperty<ILineChartDataProp> "onLineClick" value
    static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<ILineChartDataProp> "useSecondaryYScale" value

type [<Erase>] accessibilityProps =
    static member inline ariaLabel(value: string) = Interop.mkProperty<IAccessibilityProps> "ariaLabel" value
    static member inline ariaLabelledBy(value: string) = Interop.mkProperty<IAccessibilityProps> "ariaLabelledBy" value
    static member inline ariaDescribedBy(value: string) = Interop.mkProperty<IAccessibilityProps> "ariaDescribedBy" value

type [<Erase>] chartProps =
    ///chart title for the chart
    static member inline chartTitle(value: string) = Interop.mkProperty<IChartProps> "chartTitle" value
    /// Accessibility data for chart title
    static member inline chartTitleAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IChartProps> "chartTitleAccessibilityData" (value |> List.toArray)
    /// data for the points in the chart
    static member inline chartData(value: IChartDataPoint list) = Interop.mkProperty<IChartProps> "chartData" (value |> List.toArray)
    /// Accessibility data for chart data
    static member inline chartDataAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IChartProps> "chartDataAccessibilityData" (value |> List.toArray)
    /// data for the points in the line chart
    /// LineChart data is also used for areacharts
    static member inline lineChartData(value: ILineChartDataProp list) = Interop.mkProperty<IChartProps> "lineChartData" (value |> List.toArray)
    /// data for the points in the scatter chart
    static member inline scatterChartData(value: IScatterChartPoints list) = Interop.mkProperty<IChartProps> "scatterChartData" (value |> List.toArray)
    /// data for the points in the line chart
    static member inline sankeyChartData(value: ISankeyChartData list) = Interop.mkProperty<IChartProps> "SankeyChartData" (keyValueList CaseRules.LowerFirst value)
    /// data for the points in the line chart
    static member inline pointOptions(value: obj) = Interop.mkProperty<IChartProps> "pointOptions" value
    /// data for the dotted line on hovering the point
    static member inline pointLineOptions(value: obj) = Interop.mkProperty<IChartProps> "SankeyChartData" value

type [<Erase>] dateLocalizeOptions =
    static member inline calendar(value: string) = Interop.mkProperty<IDateTimeFormatOptionsProp> "calendar" value
    static member inline numberingSystem(value: string) = Interop.mkProperty<IDateTimeFormatOptionsProp> "numberingSystem" value

module dateLocalizeOptions =
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
        static member inline short =
            Interop.mkProperty<IDateTimeFormatOptionsProp> "timeStyle" "short"

type [<Erase>] hourCycle =
    static member inline h11 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h11"
    static member inline h12 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h12"
    static member inline h23 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h23"
    static member inline h24 = Interop.mkProperty<IDateTimeFormatOptionsProp> "hourCycle" "h24"

type [<Erase>] timeFormatLocale =
    static member inline dateTime(value: string) = Interop.mkProperty<ITimeLocaleDefinition> "dateTime" value
    static member inline date(value: string) = Interop.mkProperty<ITimeLocaleDefinition> "date" value
    static member inline time(value: string) = Interop.mkProperty<ITimeLocaleDefinition> "time" value
    static member inline periods(value: string array) = Interop.mkProperty<ITimeLocaleDefinition> "periods" value
    /// The abbreviated names of the weekdays, starting with Sunday.
    /// [string, string, string, string, string, string, string]
    static member inline days(value: string array) = Interop.mkProperty<ITimeLocaleDefinition> "days" value
    /// shortDays: [string, string, string, string, string, string, string]
    /// The abbreviated names of the weekdays, starting with Sunday.
    static member inline shortDays(value: string array) = Interop.mkProperty<ITimeLocaleDefinition> "shortDays" value
    /// months: [string, string, string, string, string, string, string, string, string, string, string, string];
    /// the abbreviated names of the months (starting with January).
    static member inline months(value: string array) = Interop.mkProperty<ITimeLocaleDefinition> "months" value
    /// shortMonths: [string, string, string, string, string, string, string, string, string, string, string, string];
    static member inline shortMonths(value: string array) = Interop.mkProperty<ITimeLocaleDefinition> "shortMonths" value

type [<Erase>] AxisCategoryOrder =
    static member inline ``default`` = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "default"
    static member inline data = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "data"
    static member inline categoryAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "category ascending"
    static member inline categoryDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "category descending"
    static member inline totalAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "total ascending"
    static member inline totalDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "total descending"
    static member inline minAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "min ascending"
    static member inline minDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "min descending"
    static member inline maxAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "max ascending"
    static member inline maxDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "max descending"
    static member inline sumAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "sum ascending"
    static member inline sumDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "sum descending"
    static member inline meanAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "mean ascending"
    static member inline meanDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "mean descending"
    static member inline medianAscending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "median ascending"
    static member inline medianDescending = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" "median descending"
    static member inline custom(categories: string array) = Interop.mkProperty<IAxisCategoryOrder> "xAxisCategoryOrder" categories

type [<Erase>] lineChartStyles =
    inherit cartesianChartStyles<ILineChartStyles>
    static member inline lineBorder(value: string) = Interop.mkProperty<ILineChartStyles> "lineBorder" value
    static member inline markerLabel(value: string) = Interop.mkProperty<ILineChartStyles> "markerLabel" value

type [<Erase>] lineChart =
    inherit cartesianChartProps<ILineChartProps>
    static member inline data(datasets: IChartProps list) = Interop.mkProperty<ILineChartProps> "data" (createObj !!datasets)
    static member inline styles(value: ILineChartStyles list) = Interop.mkProperty<ILineChartProps> "styles" (value |> List.toArray)
    // TODO static member inline eventAnnotationProps(value: 'a)
    // TODO static member inline onRenderCalloutPerDataPoint(value: 'a)
    // TODO static member inline onRenderCalloutPerStack(value: 'a)
    // TODO static member inline getCalloutDescriptionMessage(value: 'a)
    // TODO static member inline colorFillBars(value: 'a)
    static member inline allowMultipleShapesForPoints(value: bool) = Interop.mkProperty<ILineChartProps> "allowMultipleShapesForPoints" value
    static member inline optimizeLargeData(value: bool) = Interop.mkProperty<ILineChartProps> "optimizeLargeData" value
    static member inline culture(value: string) = Interop.mkProperty<ILineChartProps> "culture" value
    static member inline enablePerfOptimization(value: bool) = Interop.mkProperty<ILineChartProps> "enablePerfOptimization" value

module areaChartData =
    type [<Erase>] legendShape =
        class
            inherit legendShape<IAreaChartDataProp>
        end

type [<Erase>] areaChartData =
    static member inline legend(value: string) = Interop.mkProperty<IAreaChartDataProp> "legend" value
    static member inline data(value: ILineChartDataPoint list) = Interop.mkProperty<IAreaChartDataProp> "data" (value |> List.toArray)
    static member inline color(value: string) = Interop.mkProperty<IAreaChartDataProp> "color" value
    static member inline opacity(value: float) = Interop.mkProperty<IAreaChartDataProp> "opacity" value
    static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<IAreaChartDataProp> "lineOptions" (keyValueList CaseRules.LowerFirst value)
    static member inline gaps(value: ILineChartGap list) = Interop.mkProperty<IAreaChartDataProp> "gaps" (value |> List.toArray)
    static member inline hideNonActiveDots(value: bool) = Interop.mkProperty<IAreaChartDataProp> "hideNonActiveDots" value
    static member inline onLegendClick(value: string option -> unit) = Interop.mkProperty<IAreaChartDataProp> "onLegendClick" value
    static member inline onLineCLick(value: unit -> unit) = Interop.mkProperty<IAreaChartDataProp> "onLineClick" value
    static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<IAreaChartDataProp> "useSecondaryYScale" value

module areaChart =
    /// The prop used to define the Y axis mode (tonexty or tozeroy)
    type [<Erase>] mode =
        static member inline tozeroy = Interop.mkProperty<IAreaChartProp> "mode" "tozeroy"
        static member inline tonexty = Interop.mkProperty<IAreaChartProp> "mode" "tonexty"

    type [<Erase>] styles =
        class
            inherit cartesianChartStyles<ICartesianChartStyles>
        end

type [<Erase>] areaChart =
    inherit cartesianChartProps<IAreaChartProp>
    static member inline data(datasets: IChartProps list) = Interop.mkProperty<IAreaChartProp> "data" (createObj !!datasets)

    // TODO static member inline onRenderCalloutPerDataPoint(value: 'a)
    // TODO static member inline onRenderCalloutPerStack(value: 'a)

    static member inline styles(value: ICartesianChartStyles list) = Interop.mkProperty<IAreaChartProp> "styles" (keyValueList CaseRules.LowerFirst value)
    static member inline culture(value: string) = Interop.mkProperty<IAreaChartProp> "culture" value
    static member inline enablePerfOptimization(value: bool) = Interop.mkProperty<IAreaChartProp> "enablePerfOptimization" value
    static member inline optimizeLargeData(value: bool) = Interop.mkProperty<IAreaChartProp> "optimizeLargeData" value
    static member inline enableGradient(value: bool) = Interop.mkProperty<IAreaChartProp> "enableGradient" value

type [<Erase>] donutChartStyles =
    /// Style for the root element.
    static member inline root(value: string) = Interop.mkProperty<IDonutChartStyles> "root" value
    /// Style for the chart.
    static member inline chart(value: string) = Interop.mkProperty<IDonutChartStyles> "chart" value
    /// Style for the legend container.
    static member inline legendContainer(value: string) = Interop.mkProperty<IDonutChartStyles> "legendContainer" value
    /// styles for axis annotation
    static member inline axisAnnotationh(value: string) = Interop.mkProperty<IDonutChartStyles> "axisAnnotationh" value
    /// Styles for the chart wrapper div
    static member inline chartWrapper(value: string) = Interop.mkProperty<IDonutChartStyles> "chartWrapper" value

type [<Erase>] donutChart =
    inherit cartesianChartProps<IDonutChartProps>
    static member inline data(value: IChartProps list) = Interop.mkProperty<IDonutChartProps> "data" (createObj !!value)
    static member inline innerRadius(value: float) = Interop.mkProperty<IDonutChartProps> "innerRadius" value
    static member inline styles(value: IDonutChartStyles list) = Interop.mkProperty<IDonutChartProps> "styles" (value |> List.toArray)
    static member inline valueInsideDonut(value: string) = Interop.mkProperty<IDonutChartProps> "valueInsideDonut" value
    static member inline valueInsideDonut(value: float) = Interop.mkProperty<IDonutChartProps> "valueInsideDonut" value

    // TODO onRenderCalloutPerDataPoint
    // TODO calloutPropsPerDataPoint
    static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IDonutChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
    static member inline culture(value: string) =Interop.mkProperty<IDonutChartProps> "culture" value
    static member inline showLabelsInPercent(value: bool) =Interop.mkProperty<IDonutChartProps> "showLabelsInPercent" value
    static member inline hideLabels(value: bool) =Interop.mkProperty<IDonutChartProps> "hideLabels" value
    static member inline height(value: float) =Interop.mkProperty<IDonutChartProps> "height" value
    static member inline width(value: float) =Interop.mkProperty<IDonutChartProps> "width" value
    static member inline parentRef(value: Browser.Types.HTMLElement) =Interop.mkProperty<IDonutChartProps> "parentRef" value
    static member inline className(value: string) =Interop.mkProperty<IDonutChartProps> "className" value
    static member inline legendsOverflowText(value: 'a) =Interop.mkProperty<IDonutChartProps> "showTriangle" value // TS any prop
    static member inline legendProps(value: legendProps) =Interop.mkProperty<IDonutChartProps> "legendProps" value
    static member inline hideLegend(value: bool) =Interop.mkProperty<IDonutChartProps> "hideLegend" value
    static member inline href(value: string) =Interop.mkProperty<IDonutChartProps> "hideLegend" value
    static member inline hideTooltip(value: bool) =Interop.mkProperty<IDonutChartProps> "hideLegend" value
    static member inline componentRef(value: IRefValue<FocusProp>) =Interop.mkProperty<IDonutChartProps> "componentRef" value
    static member inline roundCorners(value: bool) =Interop.mkProperty<IDonutChartProps> "roundCorners" value

type [<Erase>] funnelChartDataPoint =
    static member inline stage(value: string) =Interop.mkProperty<IFunnelChartDataPoint> "stage" value
    static member inline subValues
        (value:
            {|
                category: string
                value: float
                color: string
            |} list)
        = Interop.mkProperty<IFunnelChartDataPoint> "subValues" (createObj !!value)
    static member inline value(value: float) = Interop.mkProperty<IFunnelChartDataPoint> "value" value
    static member inline color(value: string) = Interop.mkProperty<IFunnelChartDataPoint> "color" value

type [<Erase>] funnelChartStyles =
    static member inline root(value: string) = Interop.mkProperty<IFunnelChartStyles> "root" value
    static member inline chart(value: string) = Interop.mkProperty<IFunnelChartStyles> "chart" value
    static member inline text(value: string) = Interop.mkProperty<IFunnelChartStyles> "text" value
    static member inline calloutContentRoot(value: string) = Interop.mkProperty<IFunnelChartStyles> "calloutContentRoot" value

module funnelChart =
    type [<Erase>] orientation =
        static member inline horizontal = Interop.mkProperty<IFunnelChartProps> "orientation" "horizontal"
        static member inline vertical = Interop.mkProperty<IFunnelChartProps> "orientation" "vertical"

type [<Erase>] funnelChart =
    static member inline data(value: IFunnelChartDataPoint list) = Interop.mkProperty<IFunnelChartProps> "data" (value |> List.toArray)
    static member inline chartTitle(value: string) = Interop.mkProperty<IFunnelChartProps> "chartTitle" value
    static member inline width(value: int) = Interop.mkProperty<IFunnelChartProps> "width" value
    static member inline height(value: int) = Interop.mkProperty<IFunnelChartProps> "height" value
    static member inline hideLegend(value: bool) = Interop.mkProperty<IFunnelChartProps> "hideLegend" value
    static member inline legendProps(value: legendProps) = Interop.mkProperty<IFunnelChartProps> "legendProps" value
    static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IFunnelChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
    static member inline styles(value: IFunnelChartStyles list) = Interop.mkProperty<IFunnelChartProps> "styles" (value |> List.toArray)
    static member inline culture(value: string) = Interop.mkProperty<IFunnelChartProps> "culture" value
    static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<IFunnelChartProps> "componentRef" value
    static member inline className(value: string) = Interop.mkProperty<IFunnelChartProps> "className" value

type [<Erase>] gaugeChartStyles =
    /// Styles for the root element
    static member inline root(value: string) = Interop.mkProperty<IGaugeChartStyles> "root" value
    /// Styles for the chart
    static member inline chart(value: string) = Interop.mkProperty<IGaugeChartStyles> "chart" value
    /// Styles for the min and max values
    static member inline limits(value: string) = Interop.mkProperty<IGaugeChartStyles> "limits" value
    /// Styles for the chart value
    static member inline chartValue(value: string) = Interop.mkProperty<IGaugeChartStyles> "chartValue" value
    /// Styles for the sublabel
    static member inline sublabel(value: string) = Interop.mkProperty<IGaugeChartStyles> "sublabel" value
    /// Styles for the needle
    static member inline needle(value: string) = Interop.mkProperty<IGaugeChartStyles> "needle" value
    /// Styles for the chart title
    static member inline chartTitle(value: string) = Interop.mkProperty<IGaugeChartStyles> "chartTitle" value
    /// Styles for the segments
    static member inline segment(value: string) = Interop.mkProperty<IGaugeChartStyles> "segment" value
    /// Styles for gradient segments
    static member inline gradientSegment(value: string) = Interop.mkProperty<IGaugeChartStyles> "gradientSegment" value
    /// Styles for the legends container
    static member inline legendsContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "legendsContainer" value
    /// Styles for callout root-content
    static member inline calloutContentRoot(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutContentRoot" value
    /// Styles for callout x-content
    static member inline calloutContentX(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutContentX" value
    /// Styles for callout y-content
    static member inline calloutContentY(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutContentY" value
    /// Styles for description message
    static member inline descriptionMessage(value: string) = Interop.mkProperty<IGaugeChartStyles> "descriptionMessage" value
    /// Styles for callout Date time container
    static member inline calloutDateTimeContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutDateTimeContainer" value
    /// Styles for callout info container
    static member inline calloutInfoContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutInfoContainer" value
    /// Styles for callout block container
    static member inline calloutBlockContainer(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutBlockContainer" value
    /// Styles for callout legend text
    static member inline calloutlegendText(value: string) = Interop.mkProperty<IGaugeChartStyles> "calloutlegendText" value
    /// Styles for the shape object in the callout
    static member inline shapeStyles(value: string) = Interop.mkProperty<IGaugeChartStyles> "shapeStyles" value
    /// Styles for the chart wrapper div
    static member inline chartWrapper(value: string) = Interop.mkProperty<IGaugeChartStyles> "chartWrapper" value

type [<Erase>] gaugeChartSegment =
    static member inline legend(value: string) =Interop.mkProperty<IGaugeChartSegment> "legend" value
    static member inline size(value: float) =Interop.mkProperty<IGaugeChartSegment> "size" value
    static member inline color(value: string) =Interop.mkProperty<IGaugeChartSegment> "color" value
    static member inline gradient(value: string list) =Interop.mkProperty<IGaugeChartSegment> "gradient" (value |> List.toArray)
    static member inline accessibilityData(value: IAccessibilityProps list) =Interop.mkProperty<IGaugeChartSegment> "accessibilityData" (value |> List.toArray)

module gaugeChart =
    type [<Erase>] variant =
        static member inline singleSegment = Interop.mkProperty<IGaugeChartProps> "variant" "single-segment"
        static member inline multipleSegment = Interop.mkProperty<IGaugeChartProps> "variant" "multiple-segment"

    type [<Erase>] chartValueFormat =
        static member inline percentage = Interop.mkProperty<IGaugeChartProps> "chartValueFormat" "percentage"
        static member inline fraction = Interop.mkProperty<IGaugeChartProps> "chartValueFormat" "fraction"

type [<Erase>] gaugeChart =
    static member inline width(value: float) =Interop.mkProperty<IGaugeChartProps> "width" value
    static member inline height(value: float) =Interop.mkProperty<IGaugeChartProps> "height" value
    static member inline chartTitle(value: float) =Interop.mkProperty<IGaugeChartProps> "chartTitle" value
    static member inline chartValue(value: float) =Interop.mkProperty<IGaugeChartProps> "chartValue" value
    static member inline segments(value: IGaugeChartSegment list) =Interop.mkProperty<IGaugeChartProps> "segments" (value |> List.toArray)
    static member inline minValue(value: float) =Interop.mkProperty<IGaugeChartProps> "minValue" value
    static member inline maxValue(value: float) =Interop.mkProperty<IGaugeChartProps> "maxValue" value
    static member inline subLabel(value: string) =Interop.mkProperty<IGaugeChartProps> "subLabel" value
    static member inline hideMinMax(value: bool) =Interop.mkProperty<IGaugeChartProps> "hideMinMax" value
    static member inline hideLegend(value: bool) =Interop.mkProperty<IGaugeChartProps> "hideLegend" value
    static member inline legendProps(value: legendProps) =Interop.mkProperty<ILineChartProps> "legendProps" value
    static member inline hideTooltip(value: bool) =Interop.mkProperty<IGaugeChartProps> "hideTooltip" value
    static member inline styles(value: IGaugeChartStyles list) =Interop.mkProperty<IGaugeChartProps> "styles" (value |> List.toArray)
    static member inline culture(value: string) =Interop.mkProperty<IGaugeChartProps> "culture" value
    static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IGaugeChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
    static member inline enableGradient(value: bool) =Interop.mkProperty<IGaugeChartProps> "enableGradient" value
    static member inline roundCorners(value: bool) =Interop.mkProperty<IGaugeChartProps> "roundCorners" value

    // TODO componentRef?: React.RefObject<Chart>;

type [<Erase>] ganttChartDataPoint =
    static member inline x(value: {| start: float; end': float |}) =
        let jsObj =
            createObj [
                "start" ==> value.start
                "end" ==> value.end' // end is reserved, therefore recreate object with correct key
            ]
        Interop.mkProperty<IGanttChartDataPoint> "x" jsObj

    // Dependent value of the data point, rendered along the x-axis.
    static member inline x(value: {| start: DateTime; end': DateTime |}) =
        let jsObj =
            createObj [
                "start" ==> value.start
                "end" ==> value.end'
            ]
        Interop.mkProperty<IGanttChartDataPoint> "x" jsObj

    /// Independent value of the data point, rendered along the y-axis.
    /// If y is a number, then each y-coordinate is plotted at its y-coordinate.
    /// If y is a string, then the data is evenly spaced along the y-axis.
    static member inline y(value: float) = Interop.mkProperty<IGanttChartDataPoint> "y" value
    static member inline y(value: string) = Interop.mkProperty<IGanttChartDataPoint> "y" value
    /// Legend text for the datapoint in the chart
    static member inline legend(value: string) = Interop.mkProperty<IGanttChartDataPoint> "legend" value
    /// color for the legend in the chart
    static member inline color(value: string) = Interop.mkProperty<IGanttChartDataPoint> "color" value
    /// Gradient for the legend in the chart. If not provided, it will fallback on the default color palette.
    /// If provided, it will override the color prop. granted `enableGradient` is set to true for the chart.
    static member inline gradient(value: string list) = Interop.mkProperty<IGanttChartDataPoint> "gradient" (value |> List.toArray)
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IGanttChartDataPoint> "xAxisCalloutData" value
    /// Callout data for y axis
    /// This is an optional prop, If haven't given data will take
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IGanttChartDataPoint> "yAxisCalloutData" value
    /// onClick action for each datapoint in the chart
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IGanttChartDataPoint> "onClick" value
    /// Accessibility data for callout
    static member inline accessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IGanttChartDataPoint> "accessibilityData" (value |> List.toArray)

type [<Erase>] ganttChart =
    inherit cartesianChartProps<IGanttChartProps>
    static member inline data(value: ganttChartDataPoint list) = Interop.mkProperty<IGanttChartProps> "data" (value |> List.toArray)

    // TODO onRenderCalloutPerDataPoint?: RenderFunction<GanttChartDataPoint>;

    static member inline barHeight(value: float) = Interop.mkProperty<IGanttChartProps> "barHeight" value
    static member inline chartTitle(value: string) = Interop.mkProperty<IGanttChartProps> "chartTitle" value
    static member inline culture(value: string) = Interop.mkProperty<IGanttChartProps> "culture" value
    static member inline yAxisPadding(value: float) = Interop.mkProperty<IGanttChartProps> "yAxisPadding" value
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IGanttChartProps> "showYAxisLablesTooltip" value
    static member inline showYAxisLables(value: bool) = Interop.mkProperty<IGanttChartProps> "showYAxisLables" value
    static member inline enableGradient(value: bool) = Interop.mkProperty<IGanttChartProps> "enableGradient" value
    static member inline roundCorners(value: bool) = Interop.mkProperty<IGanttChartProps> "roundCorners" value
    static member inline maxBarHeight(value: float) = Interop.mkProperty<IGanttChartProps> "maxBarHeight" value

module scatterChartPoint =
    type [<Erase>] legendShape =
        class
            inherit legendShape<IScatterChartPoints>
        end

type [<Erase>] scatterChartDataPoint =
    static member inline x(value: string) = Interop.mkProperty<IScatterChartDataPoint> "x" value
    static member inline x(value: float) = Interop.mkProperty<IScatterChartDataPoint> "x" value
    static member inline x(value: DateTime) = Interop.mkProperty<IScatterChartDataPoint> "x" value
    static member inline y(value: float) = Interop.mkProperty<IScatterChartDataPoint> "y" value
    static member inline markerSize(value: float) = Interop.mkProperty<IScatterChartDataPoint> "markerSize" value
    static member inline text(value: string) = Interop.mkProperty<IScatterChartDataPoint> "text" value

type [<Erase>] scatterChartPoint =
    static member inline legend(value: string) = Interop.mkProperty<IScatterChartPoints> "legend" value
    static member inline data(value: IScatterChartDataPoint list) = Interop.mkProperty<IScatterChartPoints> "data" (value |> List.toArray)
    static member inline color(value: string) = Interop.mkProperty<IScatterChartPoints> "color" value
    static member inline opacity(value: float) = Interop.mkProperty<IScatterChartPoints> "opacity" value
    static member inline hideNonActiveDots(value: bool) = Interop.mkProperty<IScatterChartPoints> "hideNonActiveDots" value
    static member inline onLegendClick(value: string option -> unit) = Interop.mkProperty<IScatterChartPoints> "onLegendClick" value
    static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<IScatterChartPoints> "useSecondaryYScale" value

type [<Erase>] scatterChartStyles =
    inherit cartesianChartStyles<IScatterChartStyles>
    static member inline markerLabel(value: string) = Interop.mkProperty<IScatterChartStyles> "markerLabel" value

type [<Erase>] scatterChart =
    static member inline data(datasets: IChartProps list) = Interop.mkProperty<IScatterChartProps> "data" (createObj !!datasets)
    static member inline styles(value: IScatterChartStyles list) = Interop.mkProperty<IScatterChartProps> "data" (value |> List.toArray)

    // TODO onRenderCalloutPerDataPoint
    // TODO getCalloutDescriptionMessage

    static member inline culture(value: string) = Interop.mkProperty<IScatterChartPoints> "culture" value
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IScatterChartPoints> "showYAxisLablesTooltip" value

type [<Erase>] heatMapChartDataPoint =
    static member inline x(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: DateTime) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline x(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "x" value
    static member inline y(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline y(value: DateTime) = Interop.mkProperty<IHeatMapChartDataPointProp> "y" value
    static member inline value(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "value" value
    static member inline rectText(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
    static member inline rectText(value: float) = Interop.mkProperty<IHeatMapChartDataPointProp> "rectText" value
    static member inline ratio(value: float list) = Interop.mkProperty<IHeatMapChartDataPointProp> "ratio" value
    static member inline descriptionMessage(value: string) = Interop.mkProperty<IHeatMapChartDataPointProp> "descriptionMessage" value
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IHeatMapChartDataPointProp> "onClick" value
    static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IHeatMapChartDataPointProp> "callOutAccessibilityData" (value |> List.toArray)

type [<Erase>] heatMapChartData =
    static member inline legend(value: string) = Interop.mkProperty<IHeatMapChartData> "legend" value
    static member inline data(value: IHeatMapChartDataPointProp list) = Interop.mkProperty<IHeatMapChartData> "data" (value |> List.toArray)
    static member inline value(value: float) = Interop.mkProperty<IHeatMapChartData> "value" value

type [<Erase>] heatMapChartStyles =
    inherit cartesianChartStyles<IHeatMapChartStyles>
    static member inline root(value: string) = Interop.mkProperty<IHeatMapChartStyles> "root" value
    static member inline text(value: string) = Interop.mkProperty<IHeatMapChartStyles> "text" value
    static member inline calloutContentRoot(value: string) = Interop.mkProperty<IHeatMapChartStyles> "calloutContentRoot" value

module heatMapChart =
    type [<Erase>] sortOrder =
        static member inline none = Interop.mkProperty<IHeatMapChartProps> "sortOrder" "none"
        static member inline alphabetical = Interop.mkProperty<IHeatMapChartProps> "sortOrder" "alphabetical"

type [<Erase>] heatMapChart =
    inherit cartesianChartProps<IHeatMapChartProps>
    static member inline chartTitle(value: string) =Interop.mkProperty<IHeatMapChartProps> "chartTitle" value
    static member inline data(value: heatMapChartData list) =Interop.mkProperty<IHeatMapChartProps> "data" (value |> List.toArray)
    static member inline domainValuesForColorScale(value: float list) =Interop.mkProperty<IHeatMapChartProps> "domainValuesForColorScale" (value |> List.toArray)
    static member inline rangeValuesForColorScale(value: string list) =Interop.mkProperty<IHeatMapChartProps> "rangeValuesForColorScale" (value |> List.toArray)
    static member inline xAxisDateFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "xAxisDateFormatString" value
    static member inline yAxisDateFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "yAxisDateFormatString" value
    static member inline xAxisNumberFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "xAxisNumberFormatString" value
    static member inline yAxisNumberFormatString(value: string) =Interop.mkProperty<IHeatMapChartProps> "yAxisNumberFormatString" value
    static member inline xAxisStringFormatter(value: string -> string) =Interop.mkProperty<IHeatMapChartProps> "xAxisStringFormatter" value
    static member inline yAxisStringFormatter(value: string -> string) =Interop.mkProperty<IHeatMapChartProps> "yAxisStringFormatter" value
    static member inline styles(value: IHeatMapChartStyles list) =Interop.mkProperty<IHeatMapChartProps> "styles" (value |> List.toArray)
    static member inline culture(value: string) =Interop.mkProperty<IHeatMapChartProps> "culture" value
    static member inline showYAxisLablesTooltip(value: bool) =Interop.mkProperty<IHeatMapChartProps> "showYAxisLablesTooltip" value
    static member inline showYAxisLables(value: bool) =Interop.mkProperty<IHeatMapChartProps> "showYAxisLables" value

type [<Erase>] sNode =
    static member inline nodeId(value: float) = Interop.mkProperty<ISNode> "nodeId" value
    static member inline nodeId(value: string) = Interop.mkProperty<ISNode> "nodeId" value
    static member inline name(value: string) = Interop.mkProperty<ISNode> "name" value
    static member inline color(value: string) =Interop.mkProperty<ISNode> "color" value
    static member inline borderColor(value: string) =Interop.mkProperty<ISNode> "borderColor" value
    static member inline actualValue(value: float) =Interop.mkProperty<ISNode> "actualValue" value
    static member inline layer(value: float) =Interop.mkProperty<ISNode> "layer" value

type [<Erase>] sLink =
    static member inline source(value: float) =Interop.mkProperty<ISLink> "source" value
    static member inline target(value: float) =Interop.mkProperty<ISLink> "target" value
    static member inline value(value: float) =Interop.mkProperty<ISLink> "value" value
    static member inline unnormalizedValue(value: float) =Interop.mkProperty<ISLink> "unnormalizedValue" value

type [<Erase>] sankeyChartPoint =
    static member inline nodes(value: ISankeyChartPoint list) = Interop.mkProperty<ISankeyChartData> "nodes" (value |> List.toArray)
    static member inline links(value: ISankeyChartPoint list) = Interop.mkProperty<ISankeyChartData> "links" (value |> List.toArray)

type [<Erase>] sankeyChartAccessibility =
    /// Aria label for when the chart is empty.
    static member inline emptyAriaLabel(value: string) = Interop.mkProperty<ISankeyChartAccessibility> "emptyAriaLabel" value
    /// A value similar to "node \{0\} with weight \{1\}".
    /// \{0\} is the name of the node.
    /// \{1\} is the weight of the node (as computed by the sankey layout engine via the links to or from this node).
    static member inline nodeAriaLabel(value: string) = Interop.mkProperty<ISankeyChartAccessibility> "nodeAriaLabel" value
    /// A value similar to "link from \{0\} to $\{1\} with weight $\{2\}".
    /// \{0\} is the source node, \{1\} is the target node, and \{2\} is the value of the link.
    static member inline linkAriaLabel(value: string) = Interop.mkProperty<ISankeyChartAccessibility> "linkAriaLabel" value

module sankeyChart =
    type [<Erase>] reflowProps =
        static member inline none = Interop.mkProperty<ISankeyChartProps> "mode" "none"
        static member inline minWidth = Interop.mkProperty<ISankeyChartProps> "mode" "min-width"

type [<Erase>] sankeyChart =
    static member inline data(value: IChartProps list) = Interop.mkProperty<ISankeyChartProps> "data" (createObj !!value)
    static member inline width(value: float) = Interop.mkProperty<ISankeyChartProps> "width" value
    static member inline height(value: float) = Interop.mkProperty<ISankeyChartProps> "height" value
    static member inline className(value: string) = Interop.mkProperty<ISankeyChartProps> "className" value

    // TODO styles

    static member inline parentRef(value: Browser.Types.HTMLElement option) = Interop.mkProperty<ISankeyChartProps> "parentRef" value
    static member inline shouldResize(value: bool) = Interop.mkProperty<ISankeyChartProps> "shouldResize" value
    static member inline pathColor(value: string) = Interop.mkProperty<ISankeyChartProps> "pathColor" value
    static member inline colorsForNodes(value: string list) = Interop.mkProperty<ISankeyChartProps> "colorsForNodes" (value |> List.toArray)
    static member inline borderColorsForNodes(value: string list) = Interop.mkProperty<ISankeyChartProps> "borderColorsForNodes" (value |> List.toArray)
    static member inline strings(value: SankeyChartStrings list) = Interop.mkProperty<ISankeyChartProps> "strings" (value |> List.toArray)
    static member inline accessibility(value: ISankeyChartAccessibility list) = Interop.mkProperty<ISankeyChartProps> "accessibility" (value |> List.toArray)

    // TODO formatNumberOptions

    static member inline enableReflow(value: bool) = Interop.mkProperty<ISankeyChartProps> "enableReflow" value
    static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<ISankeyChartProps> "componentRef" value
    static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<ISankeyChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
    static member inline culture(value: string) = Interop.mkProperty<ISankeyChartProps> "culture" value

type [<Erase>] sparklineStyles =
    static member inline inlineBlock(value: string) = Interop.mkProperty<ISankeyChartProps> "inlineBlock" value
    static member inline valueText(value: string) = Interop.mkProperty<ISankeyChartProps> "valueText" value

type [<Erase>] sparkline =
    static member inline data(value: IChartProps list) = Interop.mkProperty<ISparklineProps> "data" (createObj !!value)
    static member inline width(value: float) = Interop.mkProperty<ISparklineProps> "width" value
    static member inline height(value: float) = Interop.mkProperty<ISparklineProps> "height" value
    static member inline valueTextWidth(value: float) = Interop.mkProperty<ISparklineProps> "valueTextWidth" value
    static member inline className(value: string) = Interop.mkProperty<ISparklineProps> "className" value
    static member inline culture(value: string) = Interop.mkProperty<ISparklineProps> "culture" value
    static member inline showLegend(value: bool) = Interop.mkProperty<ISparklineProps> "showLegend" value
    static member inline styles(value: sparklineStyles list) = Interop.mkProperty<ISparklineProps> "styles" (value |> List.toArray)

type [<Erase>] GVBarChartSeriesPoint =
    static member inline key(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "key" value
    static member inline data(value: float) = Interop.mkProperty<IGVBarChartSeriesPoint> "data" value
    static member inline color(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "color" value
    static member inline legend(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "legend" value
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "xAxisCalloutData" value
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IGVBarChartSeriesPoint> "yAxisCalloutData" value
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IGVBarChartSeriesPoint> "onClick" value
    static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IGVBarChartSeriesPoint> "callOutAccessibilityData" (value |> List.toArray)
    static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<IGVBarChartSeriesPoint> "useSecondaryYScale" value

type [<Erase>] groupedVerticalBarChartData =
    static member inline name(value: string) = Interop.mkProperty<IGroupedVerticalBarChartData> "name" value
    static member inline series(value: GVBarChartSeriesPoint list) = Interop.mkProperty<IGroupedVerticalBarChartData> "series" (value |> List.toArray)
    static member inline stackCallOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IGroupedVerticalBarChartData> "stackCallOutAccessibilityData" (value |> List.toArray)

module groupedVerticalBarChart =
    type [<Erase>] barWidth =
        static member inline ``default`` = Interop.mkProperty<ISGroupedVerticalBarChartProps> "barWidth" "default"
        static member inline auto = Interop.mkProperty<ISGroupedVerticalBarChartProps> "barWidth" "auto"

    type [<Erase>] mode =
        static member inline ``default`` = Interop.mkProperty<ISGroupedVerticalBarChartProps> "mode" "default"
        static member inline plotly = Interop.mkProperty<ISGroupedVerticalBarChartProps> "mode" "plotly"

type [<Erase>] groupedVerticalBarChartStyles =
    inherit cartesianChartStyles<IGroupedVerticalBarChartStyles>
    static member inline barLabel(value: string) = Interop.mkProperty<IGroupedVerticalBarChartStyles> "barLabel" value

type [<Erase>] groupedVerticalBarChart =
    inherit cartesianChartProps<ISGroupedVerticalBarChartProps>
    static member inline data(value: groupedVerticalBarChartData list) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "data" (value |> List.toArray)
    static member inline barWidth(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "barWidth" value
    static member inline colors(value: string list) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "colors" (value |> List.toArray)
    static member inline chartTitle(value: string) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "chartTitle" value
    static member inline useSingleColor(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "useSingleColor" value
    static member inline culture(value: string) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "culture" value
    static member inline styles(value: IGroupedVerticalBarChartStyles list) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "styles" value
    static member inline isCalloutForStack(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "isCalloutForStack" value
    static member inline hideLabels(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "hideLabels" value
    static member inline maxBarWidth(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "maxBarWidth" value
    static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "xAxisInnerPadding" value
    static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "xAxisOuterPadding" value
    static member inline roundCorners(value: bool) = Interop.mkProperty<ISGroupedVerticalBarChartProps> "roundCorners" value

type [<Erase>] horizontalDataPoint =
    /// Independent value of the data point, rendered along the x-axis.
    /// If x is a number, then each y-coordinate is plotted at its x-coordinate.
    /// If x is a string, then the data is evenly spaced along the x-axis.
    static member inline x(value: float) = Interop.mkProperty<IHorizontalDataPointProp> "x" value
    /// Total value of a single point bar chart.
    static member inline total(value: float) = Interop.mkProperty<IHorizontalDataPointProp> "total" value

module horizontalBarChart =
    type [<Erase>] chartDataMode =
        static member inline ``default`` = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "default"
        static member inline fraction = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "fraction"
        static member inline percentage = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "percentage"
        static member inline hidden = Interop.mkProperty<IHorizontalBarChartProps> "chartDataMode" "hidden"

    type [<Erase>] variant =
        static member inline PartToWhole = Interop.mkProperty<IHorizontalBarChartProps> "PartToWhole" "part-to-whole"
        static member inline AbsoluteScale = Interop.mkProperty<IHorizontalBarChartProps> "AbsoluteScale" "absolute-scale"

    type [<Erase>] styles =
        static member inline root(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "root" value
        static member inline items(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "items" value
        static member inline chart(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chart" value
        static member inline chartTitle(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartTitle" value
        static member inline barWrapper(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "barWrapper" value
        static member inline chartTitleLeft(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartTitleLeft" value
        static member inline chartTitleRight(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartTitleRight" value
        static member inline chartDataTextDenominator(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartDataTextDenominator" value
        static member inline benchmarkContainer(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "benchmarkContainer" value
        static member inline triangle(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "triangle" value
        static member inline barLabel(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "barLabel" value
        static member inline chartWrapper(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "chartWrapper" value
        static member inline legendContainer(value: string) = Interop.mkProperty<IHorizontalBarChartStyles> "legendContainer" value

type [<Erase>] horizontalBarChart =
    static member inline data(value: IChartProps list) = Interop.mkProperty<IHorizontalBarChartProps> "data" (value |> List.toArray)
    static member inline width(value: float) = Interop.mkProperty<IHorizontalBarChartProps> "width" value
    static member inline barHeight(value: float) = Interop.mkProperty<IHorizontalBarChartProps> "barHeight" value
    static member inline className(value: string) = Interop.mkProperty<IHorizontalBarChartProps> "className" value
    static member inline hideRatio(value: bool list) = Interop.mkProperty<IHorizontalBarChartProps> "hideRatio" (value |> List.toArray)
    static member inline hideTooltip(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "hideTooltip" value
    static member inline styles(value: IHorizontalBarChartStyles list) = Interop.mkProperty<IHorizontalBarChartProps> "styles" (value |> List.toArray)
    static member inline calloutProps(value: IChartPopoverProps list) = Interop.mkProperty<IHorizontalBarChartProps> "calloutProps" (keyValueList CaseRules.LowerFirst value)
    static member inline culture(value: string) = Interop.mkProperty<IHorizontalBarChartProps> "culture" value
    static member inline hideLabels(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "hideLabels" value
    static member inline color(value: string) = Interop.mkProperty<IHorizontalBarChartProps> "color" value
    static member inline showTriangle(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "showTriangle" value
    static member inline legendsOverflowText(value: 'a) = Interop.mkProperty<IHorizontalBarChartProps> "showTriangle" value // TS any prop
    static member inline legendProps(value: legendProps) = Interop.mkProperty<IHorizontalBarChartProps> "legendProps" value

    // TODO how to return a type [<Erase>] that is defined through static members through an interface?
    // static member inline onRenderCallutPerHorizontalBar(props: ??) =
    // Interop.mkProperty<IHorizontalBarChartProp> "onRenderCalloutPerHorizontalBar" value

    // TODO how to return a type [<Erase>] that is defined through static members through an interface?
    // TODO calloutPropsPerDataPoint

    static member inline showLegendForSinglePointBar(value: bool) = Interop.mkProperty<IHorizontalBarChartProps> "showLegendForSinglePointBar" value

type [<Erase>] horizontalBarChartWithAxisDataPoint =
    static member inline x(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "x" value
    static member inline y(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "y" value
    static member inline y(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "y" value
    static member inline legend(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "legend" value
    static member inline color(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "color" value
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "xAxisCalloutData" value
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "yAxisCalloutData" value
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "onClick" value
    static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IHorizontalBarChartWithAxisDataPoint> "callOutAccessibilityData" (value |> List.toArray)

module horizontalBarChartWithAxis =
    type [<Erase>] styles =
        inherit cartesianChartStyles<IHorizontalBarChartWithAxisStyles>

        static member inline chartLabel(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "chartLabel" value
        static member inline xAxisDomain(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "xAxisDomain" value
        static member inline xAxisTicks(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "xAxisTicks" value
        static member inline xAxisText(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "xAxisText" value
        static member inline yAxisDomain(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "yAxisDomain" value
        static member inline yAxisTicks(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "yAxisTicks" value
        static member inline yAxisText(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "yAxisText" value
        static member inline opacityChangeOnHover(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisStyles> "opacityChangeOnHover" value

type [<Erase>] horizontalBarChartWithAxis =
    inherit cartesianChartProps<IHorizontalBarChartWithAxisProps>

    static member inline data(value: IHorizontalBarChartWithAxisDataPoint list) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "data" (value |> List.toArray)

    // TODO onRenderCalloutPerDataPoint

    static member inline barHeight(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "barHeight" value
    static member inline colors(value: string list) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "colors" (value |> List.toArray)
    static member inline chartTitle(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "chartTitle" value
    static member inline useSingleColor(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "useSingleColor" value
    static member inline styles(value: IHorizontalBarChartStyles list) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "styles" (value |> List.toArray)
    static member inline culture(value: string) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "culture" value
    static member inline yAxisPadding(value: float) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "yAxisPadding" value
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "showYAxisLablesTooltip" value
    static member inline showYAxisLables(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "showYAxisLables" value
    static member inline enableGradient(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "enableGradient" value
    static member inline roundCorners(value: bool) = Interop.mkProperty<IHorizontalBarChartWithAxisProps> "roundCorners" value

type [<Erase>] verticalBarChartDataPoint =
    static member inline x(value: float) = Interop.mkProperty<IVerticalBarChartDataPoint> "x" value

    static member inline x(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "x" value
    static member inline x(value: DateTime) = Interop.mkProperty<IVerticalBarChartDataPoint> "x" value
    static member inline y(value: float) = Interop.mkProperty<IVerticalBarChartDataPoint> "y" value
    static member inline legend(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "legend" value
    static member inline color(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "color" value
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "xAxisCalloutData" value
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IVerticalBarChartDataPoint> "yAxisCalloutData" value
    static member inline enableReflow(value: bool) = Interop.mkProperty "enableReflow" value
    static member inline onClick(value: unit -> unit) = Interop.mkProperty<IVerticalBarChartDataPoint> "onClick" value
    static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IVerticalBarChartDataPoint> "callOutAccessibilityData" (value |> List.toArray)

module verticalBarChart =
    type [<Erase>] barWidth =
        static member inline ``default`` = Interop.mkProperty<IVerticalBarChartProps> "barWidth" "default"
        static member inline auto = Interop.mkProperty<IVerticalBarChartProps> "barWidth" "auto"

    type [<Erase>] mode =
        static member inline ``default`` = Interop.mkProperty<IVerticalBarChartProps> "mode" "default"
        static member inline plotly = Interop.mkProperty<IVerticalBarChartProps> "mode" "plotly"
        static member inline histogram = Interop.mkProperty<IVerticalBarChartProps> "mode" "histogram"

    type [<Erase>] style =
        inherit cartesianChartStyles<IVerticalBarChartStyles>
        static member inline barLabel(value: string) = Interop.mkProperty<IVerticalBarChartStyles> "barLabel" value
        static member inline lineBorder(value: string) = Interop.mkProperty<IVerticalBarChartStyles> "lineBorder" value

type [<Erase>] verticalBarChart =
    static member inline data(value: IVerticalBarChartDataPoint list) = Interop.mkProperty<IVerticalBarChartProps> "data" (value |> List.toArray)

    // TODO onRenderCalloutPerDataPoint

    static member inline colors(value: string list) = Interop.mkProperty<IVerticalBarChartProps> "colors" (value |> List.toArray)
    static member inline chartTitle(value: string) = Interop.mkProperty<IVerticalBarChartProps> "chartTitle" value
    static member inline lineLegendText(value: string) = Interop.mkProperty<IVerticalBarChartProps> "lineLegendText" value
    static member inline lineLegendColor(value: string) = Interop.mkProperty<IVerticalBarChartProps> "lineLegendColor" value
    static member inline useSingleColor(value: string) = Interop.mkProperty<IVerticalBarChartProps> "useSingleColor" value
    static member inline styles(value: IVerticalBarChartStyles list) = Interop.mkProperty<IVerticalBarChartProps> "styles" (value |> List.toArray)
    static member inline culture(value: string) = Interop.mkProperty<IVerticalBarChartProps> "culture" value
    static member inline xAxisPadding(value: float) = Interop.mkProperty<IVerticalBarChartProps> "xAxisPadding" value
    static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "lineOptions" (keyValueList CaseRules.LowerFirst value)
    static member inline hideLabels(value: bool) = Interop.mkProperty<IVerticalBarChartProps> "hideLabels" value
    static member inline maxBarWidth(value: float) = Interop.mkProperty<IVerticalBarChartProps> "maxBarWidth" value
    static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<IVerticalBarChartProps> "xAxisInnerPadding" value
    static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<IVerticalBarChartProps> "xAxisOuterPadding" value
    static member inline enableGradient(value: bool) = Interop.mkProperty<IVerticalBarChartProps> "enableGradient" value
    static member inline roundCorners(value: bool) = Interop.mkProperty<IVerticalBarChartProps> "roundCorners" value

type [<Erase>] VSChartDataPoint =
    /// data the datapoint in the chart
    static member inline data(value: float) = Interop.mkProperty<IVSChartDataPoint> "data" value
    /// data the datapoint in the chart
    static member inline data(value: string) = Interop.mkProperty<IVSChartDataPoint> "data" value
    /// Legend text for the datapoint in the chart
    static member inline legend(value: string) = Interop.mkProperty<IVSChartDataPoint> "legend" value
    /// color for the legend in the chart
    static member inline color(value: string) = Interop.mkProperty<IVSChartDataPoint> "color" value
    /// Callout data for x axis
    /// This is an optional prop, If haven't given legend will take
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IVSChartDataPoint> "xAxisCalloutData" value
    /// Accessibility data for callout
    static member inline callOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IVSChartDataPoint> "callOutAccessibilityData" (value |> List.toArray)
    /// Callout data for y axis
    /// This is an optional prop, If haven't given data will take
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<IVSChartDataPoint> "yAxisCalloutData" value
    /// The prop used to define the culture to localized the numbers
    static member inline culture(value: string) = Interop.mkProperty<IVSChartDataPoint> "culture" value

module lineDataInVerticalStackedBarChart =
    type [<Erase>] legendShape =
        class
            inherit legendShape<ILineDataInVerticalStackedBarChart>
        end

type [<Erase>] lineDataInVerticalStackedBarChart =
    static member inline y(value: float) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "y" value
    static member inline y(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "y" value
    static member inline legend(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "legend" value
    static member inline color(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "color" value
    static member inline data(value: float) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "data" value
    static member inline data(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "data" value
    static member inline yAxisCalloutData(value: string) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "yAxisCalloutData" value
    static member inline useSecondaryYScale(value: bool) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "useSecondaryYScale" value
    static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<ILineDataInVerticalStackedBarChart> "lineOptions" (keyValueList CaseRules.LowerFirst value)

type [<Erase>] verticalStackBarChartProps =
    static member inline chartData(value: IVSChartDataPoint list) = Interop.mkProperty<IVerticalStackedChartProps> "chartData" (value |> List.toArray)
    static member inline xAxisPoint(value: float) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisPoint" value
    static member inline xAxisPoint(value: string) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisPoint" value
    static member inline xAxisPoint(value: DateTime) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisPoint" value
    static member inline xAxisCalloutData(value: string) = Interop.mkProperty<IVerticalStackedChartProps> "xAxisCalloutData" value
    static member inline lineData(value: ILineDataInVerticalStackedBarChart list) = Interop.mkProperty<IVerticalStackedChartProps> "lineData" (value |> List.toArray)
    static member inline stackCallOutAccessibilityData(value: IAccessibilityProps list) = Interop.mkProperty<IVerticalStackedChartProps> "stackCallOutAccessibilityData" (value |> List.toArray)

module verticalStackedBarChart =
    type [<Erase>] barWidth =
        static member inline ``default`` = Interop.mkProperty<IVerticalStackedBarChartProps> "barWidth" "default"
        static member inline auto = Interop.mkProperty<IVerticalStackedBarChartProps> "barWidth" "auto"

    type [<Erase>] mode =
        static member inline ``default`` = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "default"
        static member inline plotly = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "plotly"

    type [<Erase>] styles =
        inherit cartesianChartStyles<IVerticalStackedBarChartStyles>
        static member inline opacityChangeOnHover(value: string) = Interop.mkProperty<IVerticalStackedBarChartStyles> "opacityChangeOnHover" value
        static member inline barLabel(value: string) = Interop.mkProperty<IVerticalStackedBarChartStyles> "barLabel" value

    type [<Erase>] reflowProps =
        static member inline none = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "none"
        static member inline minWidth = Interop.mkProperty<IVerticalStackedBarChartProps> "mode" "min-width"

type [<Erase>] verticalStackedBarChart =
    inherit cartesianChartProps<IVerticalStackedBarChartProps>
    static member inline data(value: IVerticalStackedChartProps list) = Interop.mkProperty<IVerticalStackedBarChartProps> "data" (value |> List.toArray)
    static member inline barGapMax(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "barGapMax" value
    static member inline barCornerRadius(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "barCornerRadius" value
    static member inline barMinimumHeight(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "barMinimumHeight" value //
    static member inline chartTitle(value: string) = Interop.mkProperty<IVerticalStackedBarChartProps> "chartTitle" value
    static member inline isCalloutForStack(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "isCalloutForStack" value
    static member inline styles(value: IVerticalStackedBarChartStyles list) = Interop.mkProperty<IVerticalStackedBarChartProps> "styles" (value |> List.toArray)

    // TODO onRenderCalloutPerStack
    // TODO onRenderCalloutPerDataPoint

    static member inline yMinValue(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "yMinValue" value
    static member inline allowHoverOnLegend(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "allowHoverOnLegend" value
    static member inline onBarClick(value: obj) =  Interop.mkProperty<IVerticalStackedBarChartProps> "onBarClick" value // TODO, use types instead of obj
    static member inline culture(value: string) = Interop.mkProperty<IVerticalStackedBarChartProps> "culture" value
    static member inline xAxisPadding(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "xAxisPadding" value
    static member inline lineOptions(value: ILineChartLineOptions list) = Interop.mkProperty<IVerticalStackedBarChartProps> "lineOptions" (keyValueList CaseRules.LowerFirst value)
    static member inline hideLabels(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "hideLabels" value
    static member inline xAxisInnerPadding(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "xAxisInnerPadding" value
    static member inline xAxisOuterPadding(value: float) = Interop.mkProperty<IVerticalStackedBarChartProps> "xAxisOuterPadding" value
    static member inline enableGradient(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "enableGradient" value
    static member inline roundCorners(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "roundCorners" value
    static member inline showYAxisLablesTooltip(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "showYAxisLablesTooltip" value
    static member inline showYAxisLables(value: bool) = Interop.mkProperty<IVerticalStackedBarChartProps> "showYAxisLables" value

type [<Erase>] chartTableData =
    static member inline value(value: string) = Interop.mkProperty<IChartTableDataProps> "value" value
    static member inline value(value: float) = Interop.mkProperty<IChartTableDataProps> "value" value
    static member inline value(value: bool) = Interop.mkProperty<IChartTableDataProps> "value" value
    static member inline value() = Interop.mkProperty<IChartTableDataProps> "value" null
    static member inline style(properties: IStyleAttribute list) = Interop.mkProperty<IChartTableDataProps> "style" (createObj !!properties)

type [<Erase>] chartTableStyles =
    static member inline root(value: string) = Interop.mkProperty<IChartTableStyles> "root" value
    static member inline table(value: string) = Interop.mkProperty<IChartTableStyles> "table" value
    static member inline headerCell(value: string) = Interop.mkProperty<IChartTableStyles> "headerCell" value
    static member inline bodyCell(value: string) = Interop.mkProperty<IChartTableStyles> "bodyCell" value
    static member inline chart(value: string) = Interop.mkProperty<IChartTableStyles> "chart" value

type [<Erase>] chartTable =
    static member inline headers(value: IChartTableDataProps list) = Interop.mkProperty<IChartTableProps> "headers" (value |> List.toArray)
    static member inline rows(value: List<IChartTableDataProps list>) =
        value
        |> List.map List.toArray
        |> Array.ofList
        |> Interop.mkProperty<IChartTableProps> "rows"

    static member inline width(value: string) = Interop.mkProperty<IChartTableProps> "width" value
    static member inline width(value: float) = Interop.mkProperty<IChartTableProps> "width" value
    static member inline height(value: string) = Interop.mkProperty<IChartTableProps> "height" value
    static member inline height(value: float) = Interop.mkProperty<IChartTableProps> "height" value
    static member inline className(value: string) = Interop.mkProperty<IChartTableProps> "className" value
    static member inline styles(value: IChartTableStyles list) = Interop.mkProperty<IChartTableProps> "headers" (value |> List.toArray)

    // TODO componentRef?: React_2.RefObject<Chart>; this correct?

    static member inline componentRef(value: IRefValue<FocusProp>) = Interop.mkProperty<IChartTableProps> "componentRef" value
