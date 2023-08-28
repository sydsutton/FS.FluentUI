namespace FS.FluentUI

open Fable.Core
open Feliz

type DataTabster = {
    ``data-tabster``: string
}

type IgnoreKeyDown = {
    Tab: bool
    Escape: bool
    Enter: bool
    ArrowUp: bool
    ArrowDown: bool
    ArrowLeft: bool
    ArrowRight: bool
    PageUp: bool
    PageDown: bool
    Home: bool
    End: bool
}

type ModalAttributes = {
    modalAttributes: IReactProperty
    triggerAttributes: IReactProperty
}

type ModalTabsters = {
    modalAttributes: DataTabster
    triggerAttributes: DataTabster
}

type SyntheticEvent = {
    nativeEvent: Browser.Types.MouseEvent
    currentTarget: Browser.Types.HTMLElement
    target: Browser.Types.HTMLElement
    bubbles: bool
    cancelable: bool
    defaultPrevented: bool
    eventPhase: int
    isTrusted: bool
    preventDefault: unit -> unit
    isDefaultPrevented: unit -> bool
    stopPropagation: unit -> unit
    isPropagationStopped: unit -> bool
    persist: unit -> unit
    timeStamp: int
    ``type``: string
}

type RefObject<'T> = {
    current: 'T option
}

/// Render function interface for providing overrideable render callbacks.
type [<Erase>] IRenderFunction<'P> = 'P -> ('P -> ReactElement) -> ReactElement

type ValueProp<'t> = { value: 't }

type OpenProp = { ``open``: bool }

type SelectedProp = { selected: bool }

type MenuCheckedValueChangeData = {
    /// The items for this value that are checked
    checkedItems: string array
    /// The name of the value
    name: string
}

type MenuOpenChangeData = {
    /// indicates whether the request for the open state was bubbled from a nested menu
    bubble: bool option
    /// Indicates whether the change of state was a keyboard interaction
    /// @deprecated
    /// This should not be used, since `Enter`, `Space` and click should be interpreted as the same thing as a click
    keyboard: bool option
    ``open``: bool
}

type MenuTriggerChildProps = {
    ``aria-haspopup``: string option
    ``aria-expanded``: bool option
    id: string
    ref: IRefValue<obj>
    onMouseEnter: Browser.Types.MouseEvent -> unit
    onMouseLeave: Browser.Types.MouseEvent -> unit
    onMouseMove: Browser.Types.MouseEvent -> unit
    onContextMenu: Browser.Types.MouseEvent -> unit
}

type PopoverTriggerChildProps = {
    ``aria-expanded``: bool
    ref: IRefValue<obj>
    onMouseEnter: Browser.Types.MouseEvent -> unit
    onMouseLeave: Browser.Types.MouseEvent -> unit
    onContextMenu: Browser.Types.MouseEvent -> unit
}

type OffsetObject = {
    crossAxis: int option
    mainAxis: int
}

type OverflowBoundaryPadding = {
    top: int
    ``end``: int
    bottom: int
    start: int
}

type PositioningImperativeRef = {
    /// Updates the position imperatively.
    /// Useful when the position of the target changes from other factors than scrolling of window resize.
    updatePosition: unit -> unit
    /// Sets the target and updates positioning imperatively.
    /// Useful for avoiding double renders with the target option.
    setTarget: Browser.Types.HTMLElement option -> unit
}

type OnVisibleChangeData = {
    visible: bool
}

type MountNode = {
    element: Browser.Types.HTMLElement option
    className: string option
}

type ChangeEvent = {
    target: Browser.Types.EventTarget
}

type CheckState = | Checked | Unchecked | Mixed

module CheckState =
    let fromData (arg: {| ``checked``: U2<string, bool> |}) =
        match arg.``checked`` with
        | U2.Case1 _ -> Mixed
        | U2.Case2 b -> if b then Checked else Unchecked

type InputOnChangeData = {
    /// Updated input value from the user
    value: string
}

type TextareaOnChangeData = {
    value: string
}

type SliderOnChangeData = {
    value: int
}

type SwitchOnChangeData = {
    ``checked``: bool
}

type RadioOnChangeData = {
    /// The value prop of this Radio item.
    value: string
}

type RadioGroupOnChangeData = {
    /// The value of the newly selected Radio item.
    value: string
}

type SpinButtonOnChangeData = {
    value: int option
    displayValue: string
}

type OptionOnSelectData = {
    optionValue: string option
    optionText: string option
    selectedOptions: string array
}

type ToolbarCheckedValueChangeData = {
    /// The items for this value that are checked
    checkedItems: string array
    /// The name of the value
    name: string
}

type PartitionAvatarGroupItems<'T> = {
    inlineItems: array<'T>
    overflowItems: array<'T>
}

type [<RequireQualifiedAccess>] DialogChange = | ``escapeKeyDown`` | ``backdropClick`` | ``triggerClick``
type DialogOpenChangeData<'Event> = {
    ``type``: DialogChange
    ``open``: bool
    event: 'Event
}

type [<RequireQualifiedAccess>] DialogTriggerAction = ``open`` | ``close``


type FocusProp = {
    focus: unit -> unit
}

type OverflowMenuOptions = {
    ref: IRefValue<Browser.Types.HTMLElement option>
    overflowCount: int
    isOverflowing: bool
}

type [<RequireQualifiedAccess>] OverflowGroupState = visible | hidden | overflow

type VirtualizerContextProps = {
    contextIndex:  int
    setContextIndex: int -> unit
}

type VirtualizerDataRef = {
    progressiveSizes: RefObject<int array>
    nodeSizes: RefObject<int array>
    setFlaggedIndex: int option -> unit
    currentIndex: RefObject<int>
}

type VirtualizerMeasure = {
    virtualizerLength: int
    bufferItems: int
    bufferSize: int
    scrollRef: Browser.Types.Element -> unit
}
type MutableRefObject<'T> = {
    current: 'T
}

type [<RequireQualifiedAccess>] ScrollBehavior = ``auto`` | ``instant`` | ``smooth``

type ScrollToInterface = {
    scrollTo: int -> ScrollBehavior -> (int -> unit) -> unit
    virtualizerLength: RefObject<int>
    currentIndex: RefObject<int> option
}

type [<RequireQualifiedAccess>] AriaLivePoliteness = ``polite`` | ``assertive``

type AnnounceOptions = {
    politeness: AriaLivePoliteness
}

//-------------------------------------------------------------------------- DataGrid / Table Types ---------------------------------------------------------------


type [<RequireQualifiedAccess>] SortDirection = | ``ascending`` | ``descending``

type SortState<'TKeyType> = {
    sortColumn: 'TKeyType option
    sortDirection: SortDirection
}

type TableColumnSizingOptions<'TKeyType> = { //TODO
    columnId: 'TKeyType
    width: int
    minWidth: int
    idealWidth: int
    padding: int
    defaultWidth: int option
}

type ColumnResizeData<'TKeyType> = {
    columnId: 'TKeyType
    width: int
}


type [<RequireQualifiedAccess>] TableSelectionMode = | single | multiselect

type TableRowData<'T, 'TKeyType> = {
    /// User provided data
    item: 'T
    /// The row id, defaults to index position in the collection
    rowId: 'TKeyType
}

type TableColumnDefinition<'T, 'TKeyType> = {
    columnId: 'TKeyType
    compare: ('T * 'T) -> int
    renderHeaderCell: unit -> ReactElement
    renderCell: 'T -> ReactElement
}


type [<RequireQualifiedAccess>] DataGridFocusMode = ``none`` | ``cell`` | ``row_unstable`` | ``composite``

type [<RequireQualifiedAccess>] Appearance = ``brand`` | ``neutral`` | ``none``

type TableRowProps = {
    /// A table row can have different variants. These appearances are
    /// intended to be used with selection.
    appearance: Appearance
}

type FocusFinders = {
    findAllFocusable: Browser.Types.HTMLElement -> ((Browser.Types.HTMLElement -> bool) option) -> Browser.Types.HTMLElement array
    findFirstFocusable: Browser.Types.HTMLElement -> Browser.Types.HTMLElement option
    findLastFocusable: Browser.Types.HTMLElement -> Browser.Types.HTMLElement option
    findNextFocusable: Browser.Types.HTMLElement  -> Browser.Types.HTMLElement -> Browser.Types.HTMLElement option
    findPrevFocusable: Browser.Types.HTMLElement -> Browser.Types.HTMLElement -> Browser.Types.HTMLElement
}

type DataGridContextValue = {
    /// How focus navigation will work in the datagrid
    focusMode: DataGridFocusMode
    /// Lets child components know if rows selection is enabled
    /// selectionMode prop enables row selection on the component
    selectableRows: bool
    /// Enables subtle selection style
    subtleSelection: bool
    /// Row appearance when selected
    selectionAppearance: TableRowProps
    /// Enables column resizing
    resizableColumns: bool option
    compositeRowTabsterAttribute: obj
}

// --------------------------------------------------------------------- Toast Types -----------------------------------------------------------------------------------

type ToasterShortcuts = {
    focus: Browser.Types.KeyboardEvent -> bool
}

// export declare type ToastOffset = Partial<Record<ToastPosition, ToastOffsetObject>> | ToastOffsetObject; //TODO

// declare interface ToastOffsetObject { //TODO
//     horizontal?: number;
//     vertical?: number;
// }

type ToastOffset = { //TODO see above
    horizontal: int option
    vertical: int option
}

module ToastOffset =
    let none = {
        horizontal = None
        vertical = None
    }

type [<RequireQualifiedAccess>] ToastPosition = ``top-end`` | ``top-start`` | ``bottom-end`` | ``bottom-start``

type [<RequireQualifiedAccess>] ToastPoliteness = ``assertive`` | ``polite``

type [<RequireQualifiedAccess>] ToastIntent = ``info`` | ``success`` | ``error`` | ``warning``

type [<RequireQualifiedAccess>] ToastStatus = ``queued`` | ``visible`` | ``dismissed`` | ``unmounted``

type DispatchToastOptions = {
    /// Uniquely identifies a toast, used for update and dismiss operations
    toastId: string
    /// The position the toast should render to
    position: ToastPosition
    /// Toast content
    content: ReactElement
    /// Auto dismiss timeout in milliseconds
    timeout: int
    /// Toast timeout pauses while focus is on another window
    pauseOnWindowBlur: bool
    /// Toast timeout pauses while user cursor is on the toast
    pauseOnHover: bool
    /// Higher priority toasts will be rendered before lower priority toasts
    priority: int
    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    politeness: ToastPoliteness
    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    intent: ToastIntent
    /// Additional data that needs to be passed to the toast
    data: obj
    /// Reports changes to the Toast lifecycle
    onStatusChange: (unit ->  ToastChangeData -> unit) option
}
and ToastChangeData = {
    root: IReactProperty list option
    /// Uniquely identifies a toast, used for update and dismiss operations
    toastId: string
    /// The position the toast should render to
    position: ToastPosition
    /// Toast content
    content: ReactElement
    /// Auto dismiss timeout in milliseconds
    /// @default 3000
    timeout: int
    /// Toast timeout pauses while focus is on another window
    /// @default false
    pauseOnWindowBlur: bool
    /// Toast timeout pauses while user cursor is on the toast
    /// @default false
    pauseOnHover: bool
    /// Toast belongs to a specific toaster
    toasterId: string
    /// Higher priority toasts will be rendered before lower priority toasts
    priority: int
    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    politeness: ToastPoliteness
    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    /// @default info
    intent: ToastIntent
    /// Additional data that needs to be passed to the toast
    data: obj //TODO
    /// Reports changes to the Toast lifecycle
    onStatusChange: ToastChangeHandler option
    status: ToastStatus
    updateId: int
}
and ToastChangeHandler = Browser.Types.MouseEvent -> ToastChangeData -> unit //TODO the first of the tuple is "null" in the docs

type UpdateToastOptions = {
    root: IReactProperty list
    /// Uniquely identifies a toast, used for update and dismiss operations
    toastId: string
    /// The position the toast should render to
    position: ToastPosition
    /// Toast content
    content: ReactElement
    /// Auto dismiss timeout in milliseconds
    /// @default 3000
    timeout: int
    /// Toast timeout pauses while focus is on another window
    /// @default false
    pauseOnWindowBlur: bool
    /// Toast timeout pauses while user cursor is on the toast
    /// @default false
    pauseOnHover: bool
    /// Toast belongs to a specific toaster
    toasterId: string
    /// Higher priority toasts will be rendered before lower priority toasts
    priority: int
    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    politeness: ToastPoliteness
    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    /// @default info
    intent: ToastIntent
    /// Additional data that needs to be passed to the toast
    data: obj
    /// Reports changes to the Toast lifecycle
    onStatusChange: ToastChangeHandler option
}

//TODO Fable is transpiling the tuple passed to toastController.dispatchToast into a JS array, which is not what the function expects.
//TODO I have a feeling I need to pass the tuple to dispatchToast using partial application so that it doesn't have the chance to turn it into an array,
//TODO but I'm not sure how to do that.
type ToastController = {
    /// When dispatching toast, only pass the ReactElement that you want the toast content to be.
    /// In the Microsoft docs, DispatchToastOptions is passed as a second parameter, but instead, dynamically style the <code>Fui.toaster</code>.
    /// i.e.- <code>if mounted then toaster.intent.success else toaster.intent.error</code>
    dispatchToast: ReactElement (*-> DispatchToastOptions option*) -> unit
    dismissToast: string -> unit
    dismissAllToasts: unit -> unit
    updateToast: UpdateToastOptions -> unit
    pauseToast: string -> unit
    playToast: string -> unit
}

// --------------------------------------------------------------------------------- Calendar / Date Types ------------------------------------------------------------------

type DateRangeType = | Day | Week | Month | WorkWeek


type [<RequireQualifiedAccess>] DatePickerErrorType = | ``invalid-input`` | ``out-of-bounds`` | ``required-input``

type DatePickerValidationResultData = {
    /// The error found when validating the input.
    error: DatePickerErrorType option
}

type DateGridStrings = {
    /// An array of strings for the full names of months.
    /// The array is 0-based, so months[0] should be the full name of January.
    months: string array
    /// An array of strings for the short names of months.
    /// The array is 0-based, so shortMonths[0] should be the short name of January.
    shortMonths: string array
    /// An array of strings for the full names of days of the week.
    /// The array is 0-based, so days[0] should be the full name of Sunday.
    days: string array
    /// An array of strings for the initials of the days of the week.
    /// The array is 0-based, so days[0] should be the initial of Sunday.
    shortDays: string array
}

type DateFormatting = {
    /// Get a localized string for a day.
    /// The text for each day of the month
    formatDay: System.DateTime -> string
    /// Get a localized string for a month.
    formatMonth: System.DateTime -> DateGridStrings -> string
    /// Get a localized string for a year.
    /// The "2023" text at top of month picker
    formatYear: System.DateTime -> string
    /// Get a localized string for a month, day, and year.
    formatMonthDayYear: System.DateTime -> DateGridStrings -> string
    /// Get a localized string for a month and year.
    /// The "September 2023" text at top of calendar
    formatMonthYear: System.DateTime -> DateGridStrings -> string
}

module DateFormatting =
    let default' = {
        formatDay = (fun d -> sprintf "%A" d.Day)
        formatMonth = (fun d ds -> sprintf "%A" ds.months.[d.Month - 1]) //TODO figure out where this text is being rendered
        formatYear = (fun d -> sprintf "%A" d.Year)
        formatMonthDayYear = (fun d ds -> sprintf "%A %A %A" ds.months.[d.Month - 1] d.Day d.Year) //TODO figure out where this text is being rendered
        formatMonthYear = (fun d ds -> sprintf "%A %A" ds.months.[d.Month - 1] d.Year)
    }

type CalendarStrings = {
    /// String to render for button to direct the user to today's date.
    goToToday: string
    /// Aria-label for the "previous month" button in day picker.
    prevMonthAriaLabel: string option
    /// Aria-label for the "next month" button in day picker.
    nextMonthAriaLabel: string option
    /// Aria-label for the "previous year" button in month picker.
    prevYearAriaLabel: string option
    /// Aria-label for the "next year" button in month picker.
    nextYearAriaLabel: string option
    /// Aria-label for the "previous year range" button in year picker.
    prevYearRangeAriaLabel: string option
    /// Aria-label for the "next year range" button in year picker.
    nextYearRangeAriaLabel: string option
    /// Aria-label format string for the header button in the month picker. Should have 1 string param, e.g. "`{0}`,
    /// select to change the year". This aria-label will only be applied if the year picker is enabled; otherwise
    /// the label will default to the header string, e.g. "2019".
    monthPickerHeaderAriaLabel: string option
    /// Aria-label format string for the header button in the year picker.
    /// Should have 1 string param, e.g. "`{0}`, select to change the month"
    yearPickerHeaderAriaLabel: string option
    /// Aria-label for the "close" button.
    closeButtonAriaLabel: string option
    /// Aria-label format string for the week number header. Should have 1 string param, e.g. "week number `{0}`"
    weekNumberFormatString: string option
    /// Aria-label format string for the currently selected date. Should have 1 string param, e.g. "Selected date `{0}`"
    selectedDateFormatString: string option
    /// Aria-label format string for today's date. Should have 1 string param, e.g. "Today's date `{0}`"
    todayDateFormatString: string option
    /// Aria-label for when a date is marked
    dayMarkedAriaLabel: string option
    months: string array
    shortMonths: string array
    days: string array
    shortDays: string array
}

module CalendarStrings =
    let default' = {
        goToToday = "Go To Today"
        prevMonthAriaLabel = Some "Previous month"
        nextMonthAriaLabel = Some "Next month"
        prevYearAriaLabel = Some "Previous year"
        nextYearAriaLabel = Some "Next year"
        prevYearRangeAriaLabel = Some "Previous year range"
        nextYearRangeAriaLabel = Some "Next year range"
        monthPickerHeaderAriaLabel = None
        yearPickerHeaderAriaLabel = None
        closeButtonAriaLabel = Some "Close"
        weekNumberFormatString = None
        selectedDateFormatString = None
        todayDateFormatString = None
        dayMarkedAriaLabel = None
        months = [| "January"; "February"; "March"; "April"; "May"; "June"; "July"; "August"; "September"; "October"; "November"; "December" |]
        shortMonths = [| "Jan"; "Feb"; "Mar"; "Apr"; "May"; "Jun"; "Jul"; "Aug"; "Sep"; "Oct"; "Nov"; "Dec" |]
        days = [| "Sunday"; "Monday"; "Tuesday"; "Wednesday"; "Thursday"; "Friday"; "Saturday" |]
        shortDays = [| "S"; "M"; "T"; "W"; "T"; "F"; "S" |]
    }


// ----------------------------------------------------------------------------- Theme Types ---------------------------------------------------------------------------
type [<AllowNullLiteral; Erase>] IPalette =
    /// Color code for themeDarker.
    abstract themeDarker: string with get, set
    /// Color code for themeDark.
    abstract themeDark: string with get, set
    /// Color code for themeDarkAlt.
    abstract themeDarkAlt: string with get, set
    /// Color code for themePrimary.
    abstract themePrimary: string with get, set
    /// Color code for themeSecondary.
    abstract themeSecondary: string with get, set
    /// Color code for themeTertiary.
    abstract themeTertiary: string with get, set
    /// Color code for themeLight.
    abstract themeLight: string with get, set
    /// Color code for themeLighter.
    abstract themeLighter: string with get, set
    /// Color code for themeLighterAlt.
    abstract themeLighterAlt: string with get, set
    /// Color code for the strongest color, which is black in the default theme.
    /// This is a very light color in inverted themes.
    abstract black: string with get, set
    /// Color code for blackTranslucent40.
    abstract blackTranslucent40: string with get, set
    /// Color code for neutralDark.
    abstract neutralDark: string with get, set
    /// Color code for neutralPrimary.
    abstract neutralPrimary: string with get, set
    /// Color code for neutralPrimaryAlt.
    abstract neutralPrimaryAlt: string with get, set
    /// Color code for neutralSecondary.
    abstract neutralSecondary: string with get, set
    /// Color code for neutralSecondaryAlt.
    abstract neutralSecondaryAlt: string with get, set
    /// Color code for neutralTertiary.
    abstract neutralTertiary: string with get, set
    /// Color code for neutralTertiaryAlt.
    abstract neutralTertiaryAlt: string with get, set
    /// Color code for neutralQuaternary.
    abstract neutralQuaternary: string with get, set
    /// Color code for neutralQuaternaryAlt.
    abstract neutralQuaternaryAlt: string with get, set
    /// Color code for neutralLight.
    abstract neutralLight: string with get, set
    /// Color code for neutralLighter.
    abstract neutralLighter: string with get, set
    /// Color code for neutralLighterAlt.
    abstract neutralLighterAlt: string with get, set
    /// Color code for the accent.
    abstract accent: string with get, set
    /// Color code for the softest color, which is white in the default theme. This is a very dark color in dark themes.
    /// This is the page background.
    abstract white: string with get, set
    /// Color code for whiteTranslucent40
    abstract whiteTranslucent40: string with get, set
    /// Color code for yellowDark.
    abstract yellowDark: string with get, set
    /// Color code for yellow.
    abstract yellow: string with get, set
    /// Color code for yellowLight.
    abstract yellowLight: string with get, set
    /// Color code for orange.
    abstract orange: string with get, set
    /// Color code for orangeLight.
    abstract orangeLight: string with get, set
    /// Color code for orangeLighter.
    abstract orangeLighter: string with get, set
    /// Color code for redDark.
    abstract redDark: string with get, set
    /// Color code for red.
    abstract red: string with get, set
    /// Color code for magentaDark.
    abstract magentaDark: string with get, set
    /// Color code for magenta.
    abstract magenta: string with get, set
    /// Color code for magentaLight.
    abstract magentaLight: string with get, set
    /// Color code for purpleDark.
    abstract purpleDark: string with get, set
    /// Color code for purple.
    abstract purple: string with get, set
    /// Color code for purpleLight.
    abstract purpleLight: string with get, set
    /// Color code for blueDark.
    abstract blueDark: string with get, set
    /// Color code for blueMid.
    abstract blueMid: string with get, set
    /// Color code for blue.
    abstract blue: string with get, set
    /// Color code for blueLight.
    abstract blueLight: string with get, set
    /// Color code for tealDark.
    abstract tealDark: string with get, set
    /// Color code for teal.
    abstract teal: string with get, set
    /// Color code for tealLight.
    abstract tealLight: string with get, set
    /// Color code for greenDark.
    abstract greenDark: string with get, set
    /// Color code for green.
    abstract green: string with get, set
    /// Color code for greenLight.
    abstract greenLight: string with get, set


type [<RequireQualifiedAccess>] Interpolation = | pairs | primaryAndEnds

/// Fluent UI font set.
/// {@docCategory IFontStyles}
type [<Erase>] IFontStyles =
    | Tiny // abstract tiny: IRawStyle with get, set
    | XSmall // abstract xSmall: IRawStyle with get, set
    | Small // abstract small: IRawStyle with get, set
    | SmallPlus // abstract smallPlus: IRawStyle with get, set
    | Medium // abstract medium: IRawStyle with get, set
    | MediumPlus // abstract mediumPlus: IRawStyle with get, set
    | Large // abstract large: IRawStyle with get, set
    | XLarge // abstract xLarge: IRawStyle with get, set
    | XLargePlus // abstract xLargePlus: IRawStyle with get, set
    | XxLarge // abstract xxLarge: IRawStyle with get, set
    | XxLargePlus // abstract xxLargePlus: IRawStyle with get, set
    | SuperLarge // abstract superLarge: IRawStyle with get, set
    | Mega // abstract mega: IRawStyle with get, set

type [<AllowNullLiteral; Erase>] ComponentsStyles = interface end

type [<AllowNullLiteral; Erase>] ISemanticTextColors =
    /// The default color for text.
    abstract bodyText: string with get, set
    /// Checked text color, e.g. selected menu item text.
    abstract bodyTextChecked: string with get, set
    /// De-emphasized text; e.g. metadata, captions, placeholder text.
    abstract bodySubtext: string with get, set
    /// Neutral colored links and links for action buttons.
    abstract actionLink: string with get, set
    /// Hover state for neutral colored links and links for action buttons.
    abstract actionLinkHovered: string with get, set
    /// The color of a link.
    abstract link: string with get, set
    /// The color of a hovered link. Also used when the link is active.
    abstract linkHovered: string with get, set
    /// The default color for disabled text on top of disabledBackground; e.g. text in a disabled text field or
    /// disabled button text.
    abstract disabledText: string with get, set
    /// The default color for disabled text on the default background (bodyBackground).
    abstract disabledBodyText: string with get, set
    /// Disabled de-emphasized text, for use on disabledBackground.
    abstract disabledSubtext: string with get, set
    /// Disabled de-emphasized text, for use on the default background (bodyBackground).
    abstract disabledBodySubtext: string with get, set
    /// The default color of error text on bodyBackground.
    abstract errorText: string with get, set
    /// The default color of text in a message bar.
    abstract messageText: string with get, set
    /// The color of input text.
    abstract inputText: string with get, set
    /// The color of input text on hover.
    abstract inputTextHovered: string with get, set
    /// The color of placeholder text.
    abstract inputPlaceholderText: string with get, set
    /// Color of text in a standard button
    abstract buttonText: string with get, set
    /// Color of text in a hovered standard button
    abstract buttonTextHovered: string with get, set
    /// Color of text in a checked standard button
    abstract buttonTextChecked: string with get, set
    /// Color of text in a checked and hovered standard button
    abstract buttonTextCheckedHovered: string with get, set
    /// Color of text in a pressed standard button; i.e. currently being clicked by mouse
    abstract buttonTextPressed: string with get, set
    /// Color of text in a disabled standard button
    abstract buttonTextDisabled: string with get, set
    /// Color of text in a primary button
    abstract primaryButtonText: string with get, set
    /// Color of text in a hovered primary button
    abstract primaryButtonTextHovered: string with get, set
    /// Color of text in a pressed primary button; i.e. currently being clicked by mouse
    abstract primaryButtonTextPressed: string with get, set
    /// Color of text in a disabled primary button
    abstract primaryButtonTextDisabled: string with get, set
    /// Color of text for accent button (kicker)
    abstract accentButtonText: string with get, set
    /// The default text color for list item titles and text in column fields.
    abstract listText: string with get, set
    abstract listTextColor: string with get, set
    abstract warningText: string with get, set
    abstract successText: string with get, set

type [<AllowNullLiteral; Erase>] ISemanticColors =
    inherit ISemanticTextColors
    /// The default color for backgrounds.
    abstract bodyBackground: string with get, set
    /// The default hover color for the backgrounds of interactable elements that don't have their own backgrounds.
    /// e.g. if links had hover backgrounds, they'd use this
    abstract bodyBackgroundHovered: string with get, set
    /// The default background color of selected interactable elements that don't have their own backgrounds.
    /// e.g. indicates in the nav which page you're currently on
    abstract bodyBackgroundChecked: string with get, set
    /// The standout color for highlighted content backgrounds.
    /// For highlighted content when there is no emphasis, use the neutral variant instead.
    /// This should be a shade darker than bodyBackground in light themes, and a shade lighter in inverted themes.
    abstract bodyStandoutBackground: string with get, set
    /// The color for chrome adjacent to an area with bodyBackground.
    /// This can be used to provide visual separation of zones when using stronger colors, when using a divider line
    /// is not desired.
    /// In most themes, this should match the color of bodyBackground.
    /// See also: bodyFrameDivider
    abstract bodyFrameBackground: string with get, set
    /// Used as the border between a zone with bodyFrameBackground and a zone with bodyBackground.
    /// If bodyBackground and bodyFrameBackground are different, this should be the same color as bodyFrameBackground
    /// in order to visually disappear.
    /// See also: bodyFrameBackground
    abstract bodyFrameDivider: string with get, set
    /// Divider lines; e.g. lines that separate sections in a menu, an <HR> element.
    abstract bodyDivider: string with get, set
    /// The default color for backgrounds of disabled controls; e.g. disabled text field.
    abstract disabledBackground: string with get, set
    /// The default color for border of disabled controls; e.g. disabled slider, disabled toggle border.
    abstract disabledBorder: string with get, set
    /// The color of the outline around focused controls that don't already have a border; e.g. menu items
    abstract focusBorder: string with get, set
    /// The background color of a card (or other surface) on a standout background.
    /// Cards usually have shadows, but the variantBorder slots can be used for a solid border.
    /// e.g. cards on a carousel of highlighted articles
    abstract cardStandoutBackground: string with get, set
    /// The default box-shadow for a card. In inverted themes, by default, this is set to `none` since shadows do not work
    /// well on dark backgrounds. If the card could be the same color as the background, it is recommended that
    /// `variantBorder` is used instead, so the card doesn't disappear in inverted themes.
    /// For use with `box-shadow`.
    abstract cardShadow: string with get, set
    /// The default box-shadow when hovering on a card. Generally, this is a deeper shadow than `cardShadow`, to give
    /// the effect that the card is lifting off the page.
    /// In inverted themes, this should be set to a box-shadow that looks like a solid border, because shadows are not
    /// visible on dark themes.
    /// For use with `box-shadow`.
    abstract cardShadowHovered: string with get, set
    /// The color of the border that provides contrast between an element, such as a card, and a standout background.
    abstract variantBorder: string with get, set
    /// Hover color of border that provides contrast between an element, such as a card, and a standout background.
    abstract variantBorderHovered: string with get, set
    /// Background color for default/empty state graphical elements; eg default icons, empty section that
    /// needs user to fill in content, placeholder graphics, empty seats, etc.
    abstract defaultStateBackground: string with get, set
    /// Background for informational messages.
    abstract infoBackground: string with get, set
    /// The background for errors, if necessary, or highlighting the section of the page where the error is present.
    abstract errorBackground: string with get, set
    /// Background for blocking issues, which is more severe than a warning, but not as bad as an error.
    abstract blockingBackground: string with get, set
    /// Background for warning messages.
    abstract warningBackground: string with get, set
    /// Background for severe warning messages.
    abstract severeWarningBackground: string with get, set
    /// Background for success
    abstract successBackground: string with get, set
    /// Color for icons on infoBackground.
    abstract infoIcon: string with get, set
    /// Color for icons on errorBackground.
    abstract errorIcon: string with get, set
    /// Color for icons on blockingBackground.
    abstract blockingIcon: string with get, set
    /// Color for icons on warningBackground.
    abstract warningIcon: string with get, set
    /// Color for icons on severeWarningBackground.
    abstract severeWarningIcon: string with get, set
    /// Color for icons on successBackground.
    abstract successIcon: string with get, set
    /// Color of links within a message.
    abstract messageLink: string with get, set
    /// Color of links within a message when hovered.
    abstract messageLinkHovered: string with get, set
    /// The border of a large input control in its resting, state; e.g. the box of dropdown.
    abstract inputBorder: string with get, set
    /// The border of a small input control in its resting unchecked state; e.g. the box of an unchecked checkbox.
    abstract smallInputBorder: string with get, set
    /// The border color of a large hovered input control, such as textbox.
    abstract inputBorderHovered: string with get, set
    /// The background color of an input, e.g. textbox background.
    abstract inputBackground: string with get, set
    /// The background of a checked control; e.g. checked radio button's dot, checked toggle's background.
    abstract inputBackgroundChecked: string with get, set
    /// The background of a checked and hovered control; e.g. checked checkbox's background color on hover.
    abstract inputBackgroundCheckedHovered: string with get, set
    /// The placeholder background color of a checked control, e.g. slider background, spinner background.
    abstract inputPlaceholderBackgroundChecked: string with get, set
    /// The foreground of a checked control; e.g. checked checkbox's checkmark color, checked toggle's thumb color,
    /// radio button's background color around the dot.
    abstract inputForegroundChecked: string with get, set
    /// The alternate focus border color for elements that already have a border; e.g. text field borders on focus.
    abstract inputFocusBorderAlt: string with get, set
    /// The color for disabled icon ; e.g. SearchBox magnifying glass in disabled state.
    abstract inputIconDisabled: string with get, set
    /// The color for icon ; e.g. SearchBox magnifying glass in rest state.
    abstract inputIcon: string with get, set
    /// The color for hovered icon ; e.g. SearchBox magnifying glass in hovered state.
    abstract inputIconHovered: string with get, set
    /// Background of a standard button
    abstract buttonBackground: string with get, set
    /// Background of a checked standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundChecked: string with get, set
    /// Background of a hovered standard button
    abstract buttonBackgroundHovered: string with get, set
    /// Background of a checked and hovered standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundCheckedHovered: string with get, set
    /// Background of a disabled standard button
    abstract buttonBackgroundDisabled: string with get, set
    /// Background of a pressed standard button; i.e. currently being clicked by mouse
    abstract buttonBackgroundPressed: string with get, set
    /// Border of a standard button
    abstract buttonBorder: string with get, set
    /// Border of a disabled standard button
    abstract buttonBorderDisabled: string with get, set
    /// Background of a primary button
    abstract primaryButtonBackground: string with get, set
    /// Background of a hovered primary button
    abstract primaryButtonBackgroundHovered: string with get, set
    /// Background of a pressed primary button; i.e. currently being clicked by mouse
    abstract primaryButtonBackgroundPressed: string with get, set
    /// Background of a disabled primary button
    abstract primaryButtonBackgroundDisabled: string with get, set
    /// Border of a primary button
    abstract primaryButtonBorder: string with get, set
    /// Background of an accent button (kicker)
    abstract accentButtonBackground: string with get, set
    /// The background of a menu.
    abstract menuBackground: string with get, set
    /// The divider between menu items.
    abstract menuDivider: string with get, set
    /// The default colors of icons in menus.
    abstract menuIcon: string with get, set
    /// The headers in menus that denote title of a section.
    abstract menuHeader: string with get, set
    /// The background of a hovered menu item.
    abstract menuItemBackgroundHovered: string with get, set
    /// The background of a pressed menu item.
    abstract menuItemBackgroundPressed: string with get, set
    /// The text color of a menu item.
    abstract menuItemText: string with get, set
    /// The text color of a hovered menu item.
    abstract menuItemTextHovered: string with get, set
    /// The background color for the entire list.
    abstract listBackground: string with get, set
    /// The default text color for list item titles and text in column fields.
    abstract listText: string with get, set
    /// The background color of a hovered list item.
    abstract listItemBackgroundHovered: string with get, set
    /// The background color of a checked list item.
    abstract listItemBackgroundChecked: string with get, set
    /// The background color of a checked and hovered list item.
    abstract listItemBackgroundCheckedHovered: string with get, set
    /// The background color for a hovered list header.
    abstract listHeaderBackgroundHovered: string with get, set
    /// The background color for a pressed list header.
    abstract listHeaderBackgroundPressed: string with get, set
    abstract menuItemBackgroundChecked: string with get, set
    abstract warningHighlight: string with get, set

type [<AllowNullLiteral; Erase>] ISpacing =
    abstract s2: string with get, set
    abstract s1: string with get, set
    abstract m: string with get, set
    abstract l1: string with get, set
    abstract l2: string with get, set

/// Decorative styles in a theme
type [<AllowNullLiteral; Erase>] IEffects =
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: cards, grid items
    abstract elevation4: string with get, set
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: menus, command surfaces
    abstract elevation8: string with get, set
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: search result dropdowns, hover cards, tooltips, help bubbles
    abstract elevation16: string with get, set
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: Panels, Dialogs
    abstract elevation64: string with get, set
    /// Rounded corner value, for use with border-radius. Smaller values indicate less rounding.
    /// Smaller elements should get less rounding than larger elements.
    /// Used for: buttons
    abstract roundedCorner2: string with get, set
    /// Rounded corner value, for use with border-radius. Smaller values indicate less rounding.
    /// Smaller elements should get less rounding than larger elements.
    /// Used for: cards
    abstract roundedCorner4: string with get, set
    /// Rounded corner value, for use with border-radius. Smaller values indicate less rounding.
    /// Smaller elements should get less rounding than larger elements.
    /// Used for: surfaces
    abstract roundedCorner6: string with get, set

type [<Erase>] IRawStyle = interface end

type [<AllowNullLiteral; Erase>] IScheme =
    abstract rtl: bool option with get, set
    abstract palette: IPalette with get, set
    abstract fonts: IFontStyles with get, set
    abstract semanticColors: ISemanticColors with get, set
    abstract isInverted: bool with get, set
    /// This setting is for a very narrow use case and you probably don't need to worry about,
    /// unless you share a environment with others that also use fabric.
    /// It is used for disabling global styles on fabric components. This will prevent global
    /// overrides that might have been set by other fabric users from applying to your components.
    /// When you set this setting to `true` on your theme the components in the subtree of your
    /// Customizer will not get the global styles applied to them.
    abstract disableGlobalClassNames: bool with get, set
    abstract spacing: ISpacing with get, set
    abstract effects: IEffects with get, set

//   / {@docCategory Theme}
//   / A partial theme.
type [<AllowNullLiteral; Erase>] IPartialTheme =
    abstract components: ComponentsStyles option with get, set
    abstract palette: IPalette option with get, set
    abstract fonts: IFontStyles option with get, set
    abstract semanticColors: ISemanticColors option with get, set
    abstract isInverted: bool option with get, set
    abstract disableGlobalClassNames: bool option with get, set
    abstract rtl: bool option with get, set
    abstract spacing: ISpacing option with get, set
    abstract effects: IEffects option with get, set
    /// Use this property to specify font property defaults.
    abstract defaultFontStyle: IRawStyle option with get, set
    abstract schemes: IScheme option with get, set

type [<AllowNullLiteral>] StylesClassMapping<'TStyleSet> = interface end

type MakeStyle = { displayName: string; styles: IStyleAttribute list }

type BrandVariants = {
    ``10``: string
    ``20``: string
    ``30``: string
    ``40``: string
    ``50``: string
    ``60``: string
    ``70``: string
    ``80``: string
    ``90``: string
    ``100``: string
    ``110``: string
    ``120``: string
    ``130``: string
    ``140``: string
    ``150``: string
    ``160``: string
}

type Tokens = {
    borderRadiusCircular: string
    borderRadiusLarge: string
    borderRadiusMedium: string
    borderRadiusNone: string
    borderRadiusSmall: string
    borderRadiusXLarge: string
    colorBackgroundOverlay: string
    colorBrandBackground: string
    colorBrandBackground2: string
    colorBrandBackground2Hover: string
    colorBrandBackground2Pressed: string
    colorBrandBackgroundHover: string
    colorBrandBackgroundInverted: string
    colorBrandBackgroundInvertedHover: string
    colorBrandBackgroundInvertedPressed: string
    colorBrandBackgroundInvertedSelected: string
    colorBrandBackgroundPressed: string
    colorBrandBackgroundSelected: string
    colorBrandBackgroundStatic: string
    colorBrandForeground1: string
    colorBrandForeground2: string
    colorBrandForeground2Hover: string
    colorBrandForeground2Pressed: string
    colorBrandForegroundInverted: string
    colorBrandForegroundInvertedHover: string
    colorBrandForegroundInvertedPressed: string
    colorBrandForegroundLink: string
    colorBrandForegroundLinkHover: string
    colorBrandForegroundLinkPressed: string
    colorBrandForegroundLinkSelected: string
    colorBrandForegroundOnLight: string
    colorBrandForegroundOnLightHover: string
    colorBrandForegroundOnLightPressed: string
    colorBrandForegroundOnLightSelected: string
    colorBrandShadowAmbient: string
    colorBrandShadowKey: string
    colorBrandStroke1: string
    colorBrandStroke2: string
    colorBrandStroke2Hover: string
    colorBrandStroke2Pressed: string
    colorCompoundBrandBackground: string
    colorCompoundBrandBackgroundHover: string
    colorCompoundBrandBackgroundPressed: string
    colorCompoundBrandForeground1: string
    colorCompoundBrandForeground1Hover: string
    colorCompoundBrandForeground1Pressed: string
    colorCompoundBrandStroke: string
    colorCompoundBrandStrokeHover: string
    colorCompoundBrandStrokePressed: string
    colorNeutralBackground1: string
    colorNeutralBackground1Hover: string
    colorNeutralBackground1Pressed: string
    colorNeutralBackground1Selected: string
    colorNeutralBackground2: string
    colorNeutralBackground2Hover: string
    colorNeutralBackground2Pressed: string
    colorNeutralBackground2Selected: string
    colorNeutralBackground3: string
    colorNeutralBackground3Hover: string
    colorNeutralBackground3Pressed: string
    colorNeutralBackground3Selected: string
    colorNeutralBackground4: string
    colorNeutralBackground4Hover: string
    colorNeutralBackground4Pressed: string
    colorNeutralBackground4Selected: string
    colorNeutralBackground5: string
    colorNeutralBackground5Hover: string
    colorNeutralBackground5Pressed: string
    colorNeutralBackground5Selected: string
    colorNeutralBackground6: string
    colorNeutralBackgroundAlpha: string
    colorNeutralBackgroundAlpha2: string
    colorNeutralBackgroundDisabled: string
    colorNeutralBackgroundInverted: string
    colorNeutralBackgroundInvertedDisabled: string
    colorNeutralBackgroundStatic: string
    colorNeutralForeground1: string
    colorNeutralForeground1Hover: string
    colorNeutralForeground1Pressed: string
    colorNeutralForeground1Selected: string
    colorNeutralForeground1Static: string
    colorNeutralForeground2: string
    colorNeutralForeground2BrandHover: string
    colorNeutralForeground2BrandPressed: string
    colorNeutralForeground2BrandSelected: string
    colorNeutralForeground2Hover: string
    colorNeutralForeground2Link: string
    colorNeutralForeground2LinkHover: string
    colorNeutralForeground2LinkPressed: string
    colorNeutralForeground2LinkSelected: string
    colorNeutralForeground2Pressed: string
    colorNeutralForeground2Selected: string
    colorNeutralForeground3: string
    colorNeutralForeground3BrandHover: string
    colorNeutralForeground3BrandPressed: string
    colorNeutralForeground3BrandSelected: string
    colorNeutralForeground3Hover: string
    colorNeutralForeground3Pressed: string
    colorNeutralForeground3Selected: string
    colorNeutralForeground4: string
    colorNeutralForegroundDisabled: string
    colorNeutralForegroundInverted: string
    colorNeutralForegroundInverted2: string
    colorNeutralForegroundInvertedDisabled: string
    colorNeutralForegroundInvertedHover: string
    colorNeutralForegroundInvertedLink: string
    colorNeutralForegroundInvertedLinkHover: string
    colorNeutralForegroundInvertedLinkPressed: string
    colorNeutralForegroundInvertedLinkSelected: string
    colorNeutralForegroundInvertedPressed: string
    colorNeutralForegroundInvertedSelected: string
    colorNeutralForegroundOnBrand: string
    colorNeutralForegroundStaticInverted: string
    colorNeutralShadowAmbient: string
    colorNeutralShadowAmbientDarker: string
    colorNeutralShadowAmbientLighter: string
    colorNeutralShadowKey: string
    colorNeutralShadowKeyDarker: string
    colorNeutralShadowKeyLighter: string
    colorNeutralStencil1: string
    colorNeutralStencil1Alpha: string
    colorNeutralStencil2: string
    colorNeutralStencil2Alpha: string
    colorNeutralStroke1: string
    colorNeutralStroke1Hover: string
    colorNeutralStroke1Pressed: string
    colorNeutralStroke1Selected: string
    colorNeutralStroke2: string
    colorNeutralStroke3: string
    colorNeutralStrokeAccessible: string
    colorNeutralStrokeAccessibleHover: string
    colorNeutralStrokeAccessiblePressed: string
    colorNeutralStrokeAccessibleSelected: string
    colorNeutralStrokeAlpha: string
    colorNeutralStrokeDisabled: string
    colorNeutralStrokeInvertedDisabled: string
    colorNeutralStrokeOnBrand: string
    colorNeutralStrokeOnBrand2: string
    colorNeutralStrokeOnBrand2Hover: string
    colorNeutralStrokeOnBrand2Pressed: string
    colorNeutralStrokeOnBrand2Selected: string
    colorNeutralStrokeSubtle: string
    colorPaletteAnchorBackground2: string
    colorPaletteAnchorBorderActive: string
    colorPaletteAnchorForeground2: string
    colorPaletteBeigeBackground2: string
    colorPaletteBeigeBorderActive: string
    colorPaletteBeigeForeground2: string
    colorPaletteBerryBackground1: string
    colorPaletteBerryBackground2: string
    colorPaletteBerryBackground3: string
    colorPaletteBerryBorder1: string
    colorPaletteBerryBorder2: string
    colorPaletteBerryBorderActive: string
    colorPaletteBerryForeground1: string
    colorPaletteBerryForeground2: string
    colorPaletteBerryForeground3: string
    colorPaletteBlueBackground2: string
    colorPaletteBlueBorderActive: string
    colorPaletteBlueForeground2: string
    colorPaletteBrassBackground2: string
    colorPaletteBrassBorderActive: string
    colorPaletteBrassForeground2: string
    colorPaletteBrownBackground2: string
    colorPaletteBrownBorderActive: string
    colorPaletteBrownForeground2: string
    colorPaletteCornflowerBackground2: string
    colorPaletteCornflowerBorderActive: string
    colorPaletteCornflowerForeground2: string
    colorPaletteCranberryBackground2: string
    colorPaletteCranberryBorderActive: string
    colorPaletteCranberryForeground2: string
    colorPaletteDarkGreenBackground2: string
    colorPaletteDarkGreenBorderActive: string
    colorPaletteDarkGreenForeground2: string
    colorPaletteDarkOrangeBackground1: string
    colorPaletteDarkOrangeBackground2: string
    colorPaletteDarkOrangeBackground3: string
    colorPaletteDarkOrangeBorder1: string
    colorPaletteDarkOrangeBorder2: string
    colorPaletteDarkOrangeBorderActive: string
    colorPaletteDarkOrangeForeground1: string
    colorPaletteDarkOrangeForeground2: string
    colorPaletteDarkOrangeForeground3: string
    colorPaletteDarkRedBackground2: string
    colorPaletteDarkRedBorderActive: string
    colorPaletteDarkRedForeground2: string
    colorPaletteForestBackground2: string
    colorPaletteForestBorderActive: string
    colorPaletteForestForeground2: string
    colorPaletteGoldBackground2: string
    colorPaletteGoldBorderActive: string
    colorPaletteGoldForeground2: string
    colorPaletteGrapeBackground2: string
    colorPaletteGrapeBorderActive: string
    colorPaletteGrapeForeground2: string
    colorPaletteGreenBackground1: string
    colorPaletteGreenBackground2: string
    colorPaletteGreenBackground3: string
    colorPaletteGreenBorder1: string
    colorPaletteGreenBorder2: string
    colorPaletteGreenBorderActive: string
    colorPaletteGreenForeground1: string
    colorPaletteGreenForeground2: string
    colorPaletteGreenForeground3: string
    colorPaletteGreenForegroundInverted: string
    colorPaletteLavenderBackground2: string
    colorPaletteLavenderBorderActive: string
    colorPaletteLavenderForeground2: string
    colorPaletteLightGreenBackground1: string
    colorPaletteLightGreenBackground2: string
    colorPaletteLightGreenBackground3: string
    colorPaletteLightGreenBorder1: string
    colorPaletteLightGreenBorder2: string
    colorPaletteLightGreenBorderActive: string
    colorPaletteLightGreenForeground1: string
    colorPaletteLightGreenForeground2: string
    colorPaletteLightGreenForeground3: string
    colorPaletteLightTealBackground2: string
    colorPaletteLightTealBorderActive: string
    colorPaletteLightTealForeground2: string
    colorPaletteLilacBackground2: string
    colorPaletteLilacBorderActive: string
    colorPaletteLilacForeground2: string
    colorPaletteMagentaBackground2: string
    colorPaletteMagentaBorderActive: string
    colorPaletteMagentaForeground2: string
    colorPaletteMarigoldBackground1: string
    colorPaletteMarigoldBackground2: string
    colorPaletteMarigoldBackground3: string
    colorPaletteMarigoldBorder1: string
    colorPaletteMarigoldBorder2: string
    colorPaletteMarigoldBorderActive: string
    colorPaletteMarigoldForeground1: string
    colorPaletteMarigoldForeground2: string
    colorPaletteMarigoldForeground3: string
    colorPaletteMinkBackground2: string
    colorPaletteMinkBorderActive: string
    colorPaletteMinkForeground2: string
    colorPaletteNavyBackground2: string
    colorPaletteNavyBorderActive: string
    colorPaletteNavyForeground2: string
    colorPalettePeachBackground2: string
    colorPalettePeachBorderActive: string
    colorPalettePeachForeground2: string
    colorPalettePinkBackground2: string
    colorPalettePinkBorderActive: string
    colorPalettePinkForeground2: string
    colorPalettePlatinumBackground2: string
    colorPalettePlatinumBorderActive: string
    colorPalettePlatinumForeground2: string
    colorPalettePlumBackground2: string
    colorPalettePlumBorderActive: string
    colorPalettePlumForeground2: string
    colorPalettePumpkinBackground2: string
    colorPalettePumpkinBorderActive: string
    colorPalettePumpkinForeground2: string
    colorPalettePurpleBackground2: string
    colorPalettePurpleBorderActive: string
    colorPalettePurpleForeground2: string
    colorPaletteRedBackground1: string
    colorPaletteRedBackground2: string
    colorPaletteRedBackground3: string
    colorPaletteRedBorder1: string
    colorPaletteRedBorder2: string
    colorPaletteRedBorderActive: string
    colorPaletteRedForeground1: string
    colorPaletteRedForeground2: string
    colorPaletteRedForeground3: string
    colorPaletteRedForegroundInverted: string
    colorPaletteRoyalBlueBackground2: string
    colorPaletteRoyalBlueBorderActive: string
    colorPaletteRoyalBlueForeground2: string
    colorPaletteSeafoamBackground2: string
    colorPaletteSeafoamBorderActive: string
    colorPaletteSeafoamForeground2: string
    colorPaletteSteelBackground2: string
    colorPaletteSteelBorderActive: string
    colorPaletteSteelForeground2: string
    colorPaletteTealBackground2: string
    colorPaletteTealBorderActive: string
    colorPaletteTealForeground2: string
    colorPaletteYellowBackground1: string
    colorPaletteYellowBackground2: string
    colorPaletteYellowBackground3: string
    colorPaletteYellowBorder1: string
    colorPaletteYellowBorder2: string
    colorPaletteYellowBorderActive: string
    colorPaletteYellowForeground1: string
    colorPaletteYellowForeground2: string
    colorPaletteYellowForeground3:string
    colorPaletteYellowForegroundInverted:string
    colorScrollbarOverlay:string
    colorStrokeFocus1:string
    colorStrokeFocus2:string
    colorSubtleBackground:string
    colorSubtleBackgroundHover: string
    colorSubtleBackgroundInverted: string
    colorSubtleBackgroundInvertedHover: string
    colorSubtleBackgroundInvertedPressed: string
    colorSubtleBackgroundInvertedSelected: string
    colorSubtleBackgroundLightAlphaHover: string
    colorSubtleBackgroundLightAlphaPressed: string
    colorSubtleBackgroundLightAlphaSelected: string
    colorSubtleBackgroundPressed: string
    colorSubtleBackgroundSelected: string
    colorTransparentBackground: string
    colorTransparentBackgroundHover: string
    colorTransparentBackgroundPressed: string
    colorTransparentBackgroundSelected: string
    colorTransparentStroke: string
    colorTransparentStrokeDisabled: string
    colorTransparentStrokeInteractive: string
    curveAccelerateMax: string
    curveAccelerateMid: string
    curveAccelerateMin: string
    curveDecelerateMax: string
    curveDecelerateMid: string
    curveDecelerateMin: string
    curveEasyEase: string
    curveEasyEaseMax: string
    curveLinear: string
    durationFast: string
    durationFaster: string
    durationNormal: string
    durationSlow: string
    durationSlower: string
    durationUltraFast: string
    durationUltraSlow: string
    fontFamilyBase: string
    fontFamilyMonospace: string
    fontFamilyNumeric: string
    fontSizeBase100: string
    fontSizeBase200: string
    fontSizeBase300: string
    fontSizeBase400: string
    fontSizeBase500: string
    fontSizeBase600: string
    fontSizeHero700: string
    fontSizeHero800: string
    fontSizeHero900: string
    fontSizeHero1000: string
    fontWeightBold: string
    fontWeightMedium: string
    fontWeightRegular: string
    fontWeightSemibold: string
    lineHeightBase100: string
    lineHeightBase200: string
    lineHeightBase300: string
    lineHeightBase400: string
    lineHeightBase500: string
    lineHeightBase600: string
    lineHeightHero700: string
    lineHeightHero800: string
    lineHeightHero900: string
    lineHeightHero1000: string
    shadow2: string
    shadow2Brand: string
    shadow4: string
    shadow4Brand: string
    shadow8: string
    shadow8Brand: string
    shadow16: string
    shadow16Brand: string
    shadow28: string
    shadow28Brand: string
    shadow64: string
    shadow64Brand: string
    spacingHorizontalL: string
    spacingHorizontalM: string
    spacingHorizontalMNudge: string
    spacingHorizontalNone: string
    spacingHorizontalS: string
    spacingHorizontalSNudge: string
    spacingHorizontalXL: string
    spacingHorizontalXS: string
    spacingHorizontalXXL: string
    spacingHorizontalXXS: string
    spacingHorizontalXXXL: string
    spacingVerticalL: string
    spacingVerticalM: string
    spacingVerticalMNudge: string
    spacingVerticalNone: string
    spacingVerticalS: string
    spacingVerticalSNudge: string
    spacingVerticalXL: string
    spacingVerticalXS: string
    spacingVerticalXXL: string
    spacingVerticalXXS: string
    spacingVerticalXXXL: string
    strokeWidthThick: string
    strokeWidthThicker: string
    strokeWidthThickest: string
    strokeWidthThin: string
}

type TypographyStyle = {
    fontFamily: string
    fontSize: string
    fontWeight: string
    lineHeight: string
}

type TypographyStyles = {
    body1: TypographyStyle
    body1Strong: TypographyStyle
    body1Stronger: TypographyStyle
    body2: TypographyStyle
    caption1: TypographyStyle
    caption1Strong: TypographyStyle
    caption1Stronger: TypographyStyle
    caption2: TypographyStyle
    caption2Strong: TypographyStyle
    subtitle1: TypographyStyle
    subtitle2: TypographyStyle
    subtitle2Stronger: TypographyStyle
    title1: TypographyStyle
    title2: TypographyStyle
    title3: TypographyStyle
    largeTitle: TypographyStyle
    display: TypographyStyle
}

//---------------------------------------------------------------------- Tree/ FlatTree Type -----------------------------------------------------------------------------


type TreeOpen = | ExpandIconClick | Click | Enter | ArrowRight | ArrowLeft

type TreeOpenChangeData<'T, 'TEvent> = {
    ``open``: bool
    openItems: seq<'T>
    value: 'T
    target: Browser.Types.HTMLElement
    event: 'TEvent
    ``type``: TreeOpen
}

type TreeNavigationData_unstable<'T, 'TEvent> = {
    target: Browser.Types.HTMLElement
    value: 'T
    event: 'TEvent
    type': TreeOpen
}

type [<RequireQualifiedAccess>] TreeItemType = | leaf | branch

type HeadlessTreeItemProps<'T> = {
    value: 'T
    itemType: TreeItemType
    parentValue: 'T option
    ``aria-level``: int
    ``aria-setsize``: int
    ``aria-posinset``: int
}

type TreeCheckedChangeData<'T, 'TEvent> = {
    value: 'T
    checkedItems: 'T list //TODO
    target: Browser.Types.HTMLElement
    event: 'TEvent
    ``type``: TreeOpen
    selectionMode: string
    ``checked``: string
}

type FlatTreeProps<'T, 'TEvent, 'K> = {
    // This refers to a list of ids of opened tree items.
    // Controls the state of the open tree items.
    // These property is ignored for subtrees.
    openItems: seq<'T>
    //  Callback fired when the component changes value from open state.
    //  These property is ignored for subtrees.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information, such as open value and type of interaction that created the event.
    onOpenChange: 'TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit
    //  Callback fired when navigation happens inside the component.
    //  These property is ignored for subtrees.
    //  FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information,

    onNavigation: 'TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit
    // This refers to the selection mode of the tree.
    // - undefined: No selection can be done.
    // - 'single': Only one tree item can be selected, radio buttons are rendered.
    // - 'multiselect': Multiple tree items can be selected, checkboxes are rendered.
    selectionMode: string
    //  This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    //  Controls the state of the checked tree items.
    //  These property is ignored for subtrees.
    checkedItems: seq<'K>
    onCheckedChange: 'TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit
    ref: IRefValue<Browser.Types.HTMLDivElement>
}

type HeadlessTreeItem<'T> = {
    level: int
    index: int
    position: int
    childrenValues: 'T array
    value: 'T
    parentValue: 'T
    itemType: TreeItemType
    getTreeItemProps: unit -> HeadlessTreeItemProps<'T>
}

type HeadlessFlatTree<'T, 'TEvent, 'K> = {
    /// returns the properties required for the Tree component to work properly.
    /// That includes:
    /// `openItems`, `onOpenChange`, `onNavigation_unstable` and `ref`
    getTreeProps: unit -> FlatTreeProps<'T, 'TEvent, 'K>
    /// internal method used to react to an `onNavigation` event.
    /// This method ensures proper navigation on keyboard and mouse interaction.
    /// In case of virtualization it might be required to cancel default provided `onNavigation`
    /// event and then call this method manually.
    /// const handleNavigation = (event, data) => {
    ///   event.preventDefault();
    ///   const nextItem = tree.getNextNavigableItem(data);
    ///   // scroll to item using virtualization scroll mechanism
    ///   if (nextItem && tree.getElementFromItem(nextItem)) {
    ///     listRef.current.scrollToItem(nextItem.index);
    ///   }
    ///   // wait for scrolling to happen and then invoke navigate method
    ///   requestAnimationFrame(() => {
    ///     tree.navigate(data);
    ///   });
    /// };
    navigate: TreeNavigationData_unstable<'T, 'TEvent> -> unit
    /// returns next item to be focused on a navigation.
    /// This method is provided to decouple the element that needs to be focused from
    ///  the action of focusing it itself.
    /// On the case of TypeAhead navigation this method returns the current item.
    getNextNavigableItem: HeadlessTreeItem<'T> array -> TreeNavigationData_unstable<'T, 'TEvent> -> HeadlessTreeItem<'T> option
    /// similar to getElementById but for FlatTreeItems
    getElementFromItem: HeadlessTreeItem<'T> -> Browser.Types.HTMLElement
    /// an iterable containing all visually available flat tree items
    items: unit -> seq<HeadlessTreeItem<'T>>
}


type [<AllowNullLiteral; Erase>] HeadlessFlatTreeOptions<'T, 'TEvent> =
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    /// @param event - a React's Synthetic event
    /// @param data - A data object with relevant information,
    /// such as open value and type of interaction that created the event.
    abstract onOpenChange: ('TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit) with get, set
    /// Callback fired when navigation happens inside the component.
    /// These property is ignored for subtrees.
    /// FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    /// @param event - a React's Synthetic event
    /// @param data - A data object with relevant information,
    abstract onNavigation: ('TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit) with get, set
    /// This refers to the selection mode of the tree.
    /// - undefined: No selection can be done.
    /// - 'single': Only one tree item can be selected, radio buttons are rendered.
    /// - 'multiselect': Multiple tree items can be selected, checkboxes are rendered.
    /// @default undefined
    abstract selectionMode: string with get, set
    /// Callback fired when the component changes value from checked state.
    /// These property is ignored for subtrees.
    /// @param event - a React's Synthetic event
    /// @param data - A data object with relevant information,
    /// such as checked value and type of interaction that created the event.
    abstract onCheckedChange: ('TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit) with get, set
    /// This refers to a list of ids of opened tree items.
    /// Controls the state of the open tree items.
    /// These property is ignored for subtrees.
    abstract openItems: seq<'T> with get, set
    /// This refers to a list of ids of default opened items.
    /// This property is ignored for subtrees.
    abstract defaultOpenItems: seq<'T> with get, set
    /// This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    /// Controls the state of the checked tree items.
    /// These property is ignored for subtrees.
    abstract checkedItems: seq<'T * string> with get, set
    abstract defaultCheckedItems: seq<'T * string> with get, set

type HeadlessFlatTree<'T, 'TEvent> = {
    /// returns the properties required for the Tree component to work properly.
    /// That includes:
    /// `openItems`, `onOpenChange`, `onNavigation_unstable` and `ref`
    getTreeProps: unit -> HeadlessFlatTreeOptions<'T, 'TEvent>
    /// internal method used to react to an `onNavigation` event.
    /// This method ensures proper navigation on keyboard and mouse interaction.
    /// In case of virtualization it might be required to cancel default provided `onNavigation`
    /// event and then call this method manually.
    /// const handleNavigation = (event, data) => {
    ///   event.preventDefault();
    ///   const nextItem = tree.getNextNavigableItem(data);
    ///   // scroll to item using virtualization scroll mechanism
    ///   if (nextItem && tree.getElementFromItem(nextItem)) {
    ///     listRef.current.scrollToItem(nextItem.index);
    ///   }
    ///   // wait for scrolling to happen and then invoke navigate method
    ///   requestAnimationFrame(() => {
    ///     tree.navigate(data);
    ///   });
    /// };
    navigate: TreeNavigationData_unstable<'T, 'TEvent> -> unit
    /// returns next item to be focused on a navigation.
    /// This method is provided to decouple the element that needs to be focused from
    ///  the action of focusing it itself.
    /// On the case of TypeAhead navigation this method returns the current item.
    getNextNavigableItem: HeadlessTreeItem<'T> array -> TreeNavigationData_unstable<'T, 'TEvent> -> HeadlessTreeItem<'T> option
    /// similar to getElementById but for FlatTreeItems
    getElementFromItem: HeadlessTreeItem<'T> -> Browser.Types.HTMLElement
    /// an iterable containing all visually available flat tree items
    items: unit -> seq<HeadlessTreeItem<'T>>
}
