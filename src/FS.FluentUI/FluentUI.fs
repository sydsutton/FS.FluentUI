namespace FS.FluentUI

open Fable.React
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open FS.FluentUI
open System

module internal Shorthand =

    let expand (style): obj = import "expand" "./inline-style-expand-shorthand.js"

module internal DateFormat =
    let default': DateFormatting = import "DEFAULT_DATE_FORMATTING" "./DateFormatting.js"

[<AutoOpen; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module FuiHelpers =

    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement = reactElement el (!!props |> createObj)

    let [<Literal>] FluentUIv9 = "@fluentui/react-components"
    let [<Literal>] FluentIcons = "@fluentui/react-icons"
    let [<Literal>] DatePickerCompat = "@fluentui/react-datepicker-compat"
    let [<Literal>] CalendarCompat = "@fluentui/react-calendar-compat"
    let [<Literal>] TimepickerCompat = "@fluentui/react-timepicker-compat"
    let [<Literal>] ReactWindow = "@fluentui-contrib/react-data-grid-react-window"

    // Preview components
    let [<Literal>] Alert_unstable = "@fluentui/react-alert"
    let [<Literal>] Virtualizer_unstable = "@fluentui/react-virtualizer"
    let [<Literal>] Nav_unstable = "@fluentui/react-nav-preview"

// Added because I need the classNames going into mergeClasses to stay as a tuple.
//TODO Find a way to dynamically create the "jsCode" string without it creating incorrect JS when compiled.
[<RequireQualifiedAccess>]
type [<Erase>] JSTuple =
    static member inline from2Args (args: 'T) = emitJsExpr args "$0[0], $0[1]"
    static member inline from3Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2]"
    static member inline from4Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3]"
    static member inline from5Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4]"
    static member inline from6Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5]"
    static member inline from7Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6]"
    static member inline from8Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6], $0[7]"
    static member inline from9Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6], $0[7], $0[8]"
    static member inline from10Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6], $0[7], $0[8], $0[9]"

type [<Erase>] Fui =
//---------------------------------------------------------------- Functions --------------------------------------------------------------------------------

    /// A hook that returns the necessary tabster attributes to support arrow key navigation
    /// @param options - Options to configure keyboard navigation
    [<Hook>]
    static member inline useArrowNavigationGroup (options: IUseArrowNavigationGroupOptionsProp list): IReactProperty =
        let useArrowNavigationGroup = import "useArrowNavigationGroup" FluentUIv9
        let dataTabster : DataTabster = !!options |> createObj |> useArrowNavigationGroup
        prop.custom ("data-tabster", dataTabster.``data-tabster``)

    /// A hook that returns the necessary tabster attributes to support groupping.
    /// @param options - Options to configure keyboard navigation
    [<Hook>]
    static member inline useFocusableGroup (options: IUseFocusableGroupOptionsProp list): IReactProperty =
        let useFocusableGroup = import "useFocusableGroup" FluentUIv9
        let dataTabster : DataTabster = !!options |> createObj |> useFocusableGroup
        prop.custom ("data-tabster", dataTabster.``data-tabster``)

    /// Returns a set of helper functions that will traverse focusable elements in the context of a root DOM element
    [<Hook>]
    static member inline useFocusFinders (): FocusFinders = import "useFocusFinders" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (prefix: string option, providedId: string option): string = import "useId" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (prefix: string): string = import "useId" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (prefix: string, providedId: string): string = import "useId" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (): string = import "useId" FluentUIv9

    /// If an id is provided all imperative methods control that specific toaster
    /// Returns Imperative methods to control toasts
    static member inline useToastController (toasterId: string option): ToastController =
        let controller : ToastController = toasterId |> import "useToastController" FluentUIv9

        {
            dispatchToast = fun (element, options) ->
                let options = !!options |> createObj |> unbox<DispatchToastOptions>
                emitJsExpr (element, options) "$0, $1"
                |> controller.dispatchToast
            dismissToast = fun props -> controller.dismissToast props
            dismissAllToasts = fun props -> controller.dismissAllToasts props
            updateToast = fun props -> !!props |> createObj |> unbox |> controller.updateToast
            pauseToast = fun props -> controller.pauseToast props
            playToast = fun props -> controller.playToast props
        }

    static member inline partitionAvatarGroupItems (options: IPartitionAvatarGroupItemsOptionsProp list): PartitionAvatarGroupItems<'T> =
        let partitionAvatarGroupItems = import "partitionAvatarGroupItems" FluentUIv9
        !!options |> createObj |> partitionAvatarGroupItems


    /// `makeStyles` is used to define style permutations in components and is used for style overrides. It returns a React hook that should be called inside a component.
    /// The call returns an object with classes mapped to these unique identifiers.
    ///
    /// **Note:** When using IStyleAttributes with single numeric values ie: style.width 150, specify the unit of measurement ie: style.width (length.px 150)
    ///
    /// *outside of component*
    /// ```
    ///type Styles = { root: string }
    ///let useStyles = Fui.makeStyles<Styles> [ "root", [ style.width (length.px 200) ] ]
    /// ```
    /// OR
    /// ```
    ///let useStyles: unit -> Styles = Fui.makeStyles [ "root", [ style.width (length.px 200) ] ]
    ///```
    ///
    ///*inside of component*
    ///
    /// ```
    ///let styles = useStyles()
    ///{component}.className styles.root
    /// ```
    static member makeStyles<'T> (stylesBySlots: list<string * list<IStyleAttribute>>): unit -> 'T =
        let makeStyles = import "makeStyles" FluentUIv9

        match stylesBySlots with
        | [] -> fun _ -> {||} |> unbox
        | stylesBySlots ->
            [
                for (name, styles) in stylesBySlots do
                    // Using hard-coded files from inline-style-expand-shorthand. Otherwise you run into an issue where
                    // mixed shorthand and longhand properties are applied in an unexpected way due to the rendering order of CSS classes.
                    name, !!styles |> createObj |> Shorthand.expand
            ]
            |> unbox
            |> createObj
            |> makeStyles

    /// This API works similarly to `makeStyles` and is used to generate styles as a single monolithic class to avoid the "CSS rules explosion" problem.
    ///
    /// **Note:** When using IStyleAttributes with single numeric values ie: style.width 150, specify the unit of measurement ie: style.width (length.px 150)
    ///
    /// **Note:** Only one class generated by `makeResetStyles()` can be applied to an element. Otherwise, behavior will be non-deterministic since styles are not merged and deduplicated, the results will depend on order of insertion.
    ///
    /// We recommend using `makeResetStyles` to define the base styles for a component and use `makeStyles` to override or enhance the base styles at runtime.
    ///
    /// Example:
    ///```
    /// *outside of component*
    ///let componentClassName = Fui.makeResetStyles [ style.display.flex; style.flexDirection.row ]
    ///
    ///*inside of component*
    ///let componentClassName = componentClassName()
    ///{component}.className componentClassName
    /// ```
    static member makeResetStyles (styles: IStyleAttribute list): unit -> string =
        let makeResetStyles = import "makeResetStyles" FluentUIv9

        !!styles
        |> createObj
        |> Shorthand.expand
        |> makeResetStyles

    [<Hook>]
    static member inline useOverflowMenu (id: string option): OverflowMenuOptions<'Element> = import "useOverflowMenu" FluentUIv9

    /// Number of items that are overflowing
    [<Hook>]
    static member inline useOverflowCount (): int = import "useOverflowCount" FluentUIv9

    /// Param id - unique identifier for the item used by the overflow manager
    /// Teturns visibility state of an overflow item
    [<Hook>]
    static member inline useIsOverflowItemVisible (id: string): bool = import "useIsOverflowItemVisible" FluentUIv9

    /// Param id - unique identifier for a group of overflow items
    /// Returns visibility state of the group
    [<Hook>]
    static member inline useIsOverflowGroupVisible (id: string): OverflowGroupState = import "useIsOverflowGroupVisible" FluentUIv9

    /// The `bundleIcon` method bundles a `filled` and `unfilled` version of an icon and combines them into one icon.
    /// You can also add additional styles to the bundled icon after the method call.
    ///
    /// `let AddIcon = Fui.bundleIcon(bundleIcon.addCircleFilled, bundleIcon.addCircleRegular)`
    ///
    /// `{component}.icon (AddIcon [ icon.style [ style.color.yellow ] ])`
    static member inline bundleIcon (filledIcon: BundleIcon, regularIcon: BundleIcon) (iconProps: IIconProp list): ReactElement =
        let icons = (filledIcon, regularIcon)

        !!iconProps |> createObj |> import "bundleIcon" FluentIcons (icons |> JSTuple.from2Args)

    /// Helper function to create column definition with defaults
    /// options - column definition options
    /// Returns - column definition with defaults
    static member inline createTableColumn (options: ICreateTableColumnOptionProp list): TableColumnDefinition<'T, 'TKeyType> =
        let createTableColumn = import "createTableColumn" FluentUIv9
        !!options |> createObj |> createTableColumn

    /// React hook that measures virtualized space based on a static size to ensure optimized virtualization length.
    /// This hook is a helper to create modal dialog like experiences. The hook creates accessible focus traps that set aria-hidden. The focus trap can only be activated with explicit HTMLElement.focus() call in javscript code.
    /// The hook returns two sets of attributes to spread to elements. This represents the two concepts of a modal dialog
    /// trigger - button that opens a dialog
    /// modal - the modal dialog surface itself
    /// The hook will also handle reverting focus back to the trigger once the modal dialog is unmounted from DOM.
    /// ⚠️ Do not use this hook without appropriate guidance from your accessibility champ. Focus trap is only one of many requirements to consider when creating a modal dialog. Consider the Dialog and Popover components if you need modal dialog like components.
    [<Hook>]
    static member inline useModalAttributes (options: IUseModalAttributesOptionsProp list): ModalAttributes =
        let useModalAttributes = import "useModalAttributes" FluentUIv9
        let attributes = !!options |> createObj |> useModalAttributes

        {
            modalAttributes = prop.custom("data-tabster", attributes.modalAttributes.``data-tabster``)
            triggerAttributes = prop.custom("data-tabster", attributes.triggerAttributes.``data-tabster``)
        }

    /// The useObservedElement hook assigns a name to an element and should be used alongside useFocusObserved that will actually return the imperative method to focus the element.
    [<Hook>]
    static member inline useObservedElement (name: string): IReactProperty =
        let useObservedElement = import "useObservedElement" FluentUIv9
        let dataTabster : DataTabster = name |> useObservedElement
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// this hook provides FlatTree API to manage all required mechanisms to convert a list of items into renderable TreeItems
    /// in multiple scenarios including virtualization.
    /// !!A flat tree is an unofficial spec for tree!!
    /// It should be used on cases where more complex interactions with a Tree is required.
    /// On simple scenarios it is advised to simply use a nested structure instead.
    /// @param props - a list of tree items
    /// @param options - in case control over the internal openItems is required
    [<Hook>]
    static member inline useHeadlessFlatTree_unstable (props: IHeadlessTreeItemProp list list, options: IHeadlessFlatTreeOptionsProp list) =
        let props =
            props
            |> List.map (fun p -> !!p |> createObj)
            |> List.toArray

        let options = !!options |> createObj

        (props, options) |> JSTuple.from2Args |> import "useHeadlessFlatTree_unstable" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string): string =
        JSTuple.from2Args (v1, v2) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string): string =
        JSTuple.from3Args (v1, v2, v3) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string): string =
        JSTuple.from4Args (v1, v2, v3, v4) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string): string =
        JSTuple.from5Args (v1, v2, v3, v4, v5) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string): string =
        JSTuple.from6Args (v1, v2, v3, v4, v5, v6) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string): string =
        JSTuple.from7Args (v1, v2, v3, v4, v5, v6, v7) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string, v8: string): string =
        JSTuple.from8Args (v1, v2, v3, v4, v5, v6, v7, v8) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string, v8: string, v9: string): string =
        JSTuple.from9Args (v1, v2, v3, v4, v5, v6, v7, v8, v9) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string, v8: string, v9: string, v10: string): string =
        JSTuple.from10Args (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) |> import "mergeClasses" FluentUIv9
    /// Returns a date offset from the given date by the specified number of days.
    /// date - The origin date
    /// days - The number of days to offset. 'days' can be negative.
    static member inline addDays (date: System.DateTime, days: int): System.DateTime = import "addDays" CalendarCompat
    /// Returns a date offset from the given date by the specified number of months.
    /// The method tries to preserve the day-of-month; however, if the new month does not have enough days to contain the original day-of-month, we'll use the last day of the new month.
    /// date - The origin date
    /// months - The number of months to offset. 'months' can be negative.
    static member inline addMonths (date: System.DateTime, months: int): System.DateTime = import "addMonths" CalendarCompat
    /// Returns a date offset from the given date by the specified number of weeks.
    /// date - The origin date
    /// weeks - The number of weeks to offset. 'weeks' can be negative.
    static member inline addWeeks (date: System.DateTime, weeks: int): System.DateTime = import "addWeeks" CalendarCompat
    /// Returns a date offset from the given date by the specified number of years.
    /// The method tries to preserve the day-of-month; however, if the new month does not have enough days to contain the original day-of-month, we'll use the last day of the new month.
    /// date - The origin date
    /// years - The number of years to offset. 'years' can be negative.
    static member inline addYears (date: System.DateTime, years: int): System.DateTime = import "addYears" CalendarCompat
    /// Returns a date that is a copy of the given date, aside from the month changing to the given month.
    /// The method tries to preserve the day-of-month; however, if the new month does not have enough days to contain the original day-of-month, we'll use the last day of the new month.
    /// date - The origin date
    /// month - The 0-based index of the month to set on the date.
    static member inline setMonth (date: System.DateTime, month: int): System.DateTime = import "setMonth" CalendarCompat
    /// Checks whether the specified date is in the given date range.
    /// @param date - The origin date
    /// @param dateRange - An array of dates to do the lookup on
    static member inline isInDateRangeArray (date: System.DateTime, dateRange: System.DateTime array): bool = import "isInDateRangeArray" CalendarCompat
    /// Returns a date that is the first day of the year of the provided date.
    /// date - The origin date
    static member inline getYearStart (date: System.DateTime): System.DateTime = import "getYearStart" CalendarCompat
    /// Returns a date that is the last day of the year of the provided date.
    /// date - The origin date
    static member inline getYearEnd (date: System.DateTime): System.DateTime = import "getYearEnd" CalendarCompat
    /// Returns the week number for a date. Week numbers are 1 - 52 (53) in a year
    /// navigatedDate - A date to find the week number for.
    /// firstDayOfWeek - The first day of the week (0-6, Sunday = 0)
    /// firstWeekOfYear - The first week of the year (1-2)
    static member inline getWeekNumbersInMonth (weeksInMonth: int, firstDayOfWeek: System.DayOfWeek, firstWeekOfYear: FirstWeekOfYear, navigatedDate: System.DateTime): int =
        let firstWeekOfYear =
            match firstWeekOfYear with
            | FirstDay -> 0
            | FirstFullWeek -> 1
            | FirstFourDayWeek -> 2
        (weeksInMonth, firstDayOfWeek, firstWeekOfYear, navigatedDate) |> JSTuple.from4Args |> import "getWeekNumbersInMonth" CalendarCompat
    /// Returns the week number for a date. Week numbers are 1 - 52 (53) in a year
    /// date - A date to find the week number for.
    /// firstDayOfWeek - The first day of the week (0-6, Sunday = 0)
    /// firstWeekOfYear - The first week of the year (1-2)
    static member inline getWeekNumber (date: System.DateTime, firstDayOfWeek: System.DayOfWeek, firstWeekOfYear: FirstWeekOfYear): int =
        let firstWeekOfYear =
            match firstWeekOfYear with
            | FirstDay -> 0
            | FirstFullWeek -> 1
            | FirstFourDayWeek -> 2
        (date, firstDayOfWeek, firstWeekOfYear) |> JSTuple.from3Args |> import "getWeekNumber" CalendarCompat
    /// Gets the date for the first day of the week based on the given date assuming the specified first day of the week.
    /// date - The date to find the beginning of the week date for.
    static member inline getStartDateOfWeek (date: System.DateTime, firstDayOfWeek: System.DayOfWeek): System.DateTime = import "getStartDateOfWeek" CalendarCompat
    /// Returns a date that is the first day of the month of the provided date.
    /// date - The origin date
    static member inline getMonthStart (date: System.DateTime): System.DateTime = import "getMonthStart" CalendarCompat
    /// Returns a date that is the last day of the month of the provided date.
    /// date - The origin date
    static member inline getMonthEnd (date: System.DateTime): System.DateTime = import "getMonthEnd" CalendarCompat
    /// Gets the date for the last day of the week based on the given date assuming the specified first day of the week.
    /// date - The date to find the beginning of the week date for.
    static member inline getEndDateOfWeek (date: System.DateTime, firstDayOfWeek: System.DayOfWeek): System.DateTime = import "getEndDateOfWeek" CalendarCompat
    /// Gets the date for the last day of the week based on the given date assuming the specified first day of the week.
    /// date - The date to find the beginning of the week date for.
    static member inline getDateRangeArray (date: System.DateTime, dateRangeType: DateRangeType, firstDayOfWeek: System.DayOfWeek, workWeekDays: System.DayOfWeek array, daysToSelectInDayView: int): System.DateTime array =
        let dateRangeType =
            match dateRangeType with
            | Day -> 0
            | Week -> 1
            | Month -> 2
            | WorkWeek -> 3
        (date, dateRangeType, firstDayOfWeek, workWeekDays, daysToSelectInDayView) |> JSTuple.from5Args |> import "getDateRangeArray" CalendarCompat
    /// Compares two dates, and returns true if the two dates (not accounting for time-of-day) are equal.
    static member inline compareDates (date1: System.DateTime, date2: System.DateTime): bool = import "compareDates" CalendarCompat
    /// Compare the date parts of two dates
    /// date1 - The first date to compare
    /// date2 - The second date to compare
    /// Returns A negative value if date1 is earlier than date2, 0 if the dates are equal, or a positive value if date1 is later than date2.
    static member inline compareDatePart (date1: System.DateTime, date2: System.DateTime): int = import "compareDatePart" CalendarCompat

    /// React hook that measures virtualized space based on a static size to ensure optimized virtualization length.
    [<Hook>]
    static member inline useStaticVirtualizerMeasure (virtualizerProps: IVirtualizerMeasurePropsProp list): VirtualizerMeasure =
        let useStaticVirtualizerMeasure = import "useStaticVirtualizerMeasure" Virtualizer_unstable
        !!virtualizerProps |> createObj |> useStaticVirtualizerMeasure

    /// A hook that returns the visibility status of all items and groups.
    ///
    /// ⚠️ Heads up!
    ///
    /// This hook will cause the component it is in to re-render for every single time an item overflows or becomes
    /// visible - use with caution
    /// Returns visibility status of all items and groups
    [<Hook>]
    static member inline useOverflowVisibility (): OverflowVisibility = import "useOverflowVisibility" FluentUIv9

    /// Designates an area where tabster does not control focus
    /// Returns Attribute to apply to the target element that should be uncontrolled by tabster
    static member inline useUncontrolledFocus (): IReactProperty =
        let useUncontrolledFocus = import "useUncontrolledFocus" FluentUIv9
        let dataTabster : DataTabster = useUncontrolledFocus ()
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// Focus will be restored to the most recent target element when it is lost from a source
    /// Returns Attribute to apply to the element that might lose focus
    static member inline useRestoreFocusSource (): IReactProperty =
        let useRestoreFocusSource = import "useRestoreFocusSource" FluentUIv9
        let dataTabster : DataTabster = useRestoreFocusSource ()
        prop.custom("data-tabster", dataTabster.``data-tabster``)
    /// A hook to filter the options based on the user-typed string. It can be configured for a custom filter function, custom message, and custom render function.
    /// We recommend using filtering when creating a freeform Combobox.
    ///
    /// **'T must be a type or object that includes `children` and `value` properties. Using a type or object without these properties will cause `Fui.useComboboxFilter` to not filter correctly.**
    ///
    /// **`children` is the text/component that will appear for each option in the dropdown**
    ///
    /// **`value` is the text that will be used for the filtering based on user's input**
    [<Hook>]
    static member inline useComboboxFilter (query: string, options: 'T list, config: IComboboxFilterConfigProp list): ReactElement list =
        let options = options |> List.toArray
        let config = !!config |> createObj

        JSTuple.from3Args (query, options, config) |> import "useComboboxFilter" FluentUIv9

    static member inline useTagPickerFilter (filters: IUseTagPickerFilterProp list): ReactElement list =
        let useTagPickerFilter = import "useTagPickerFilter" FluentUIv9

        !!filters |> createObj |> unbox |> useTagPickerFilter

    static member inline renderSwatchPickerGrid  (filters: ISwatchPickerGridProp list): ReactElement list =
        let renderSwatchPickerGrid  = import "renderSwatchPickerGrid" FluentUIv9

        !!filters |> createObj |> unbox |> renderSwatchPickerGrid

    /// `createPresenceComponent` is a factory function that creates a React component based on the provided presence definition.
    /// This component can be used to animate any element and intended to have a state via the visible prop.
    static member inline createPresenceComponent (value: PresenceMotion) (props: IPresenceComponentProp list): ReactElement =
        let enter = !!value.enter |> createObj |> unbox
        let exit = !!value.exit |> createObj |> unbox

        let newValue = {|
            enter = enter
            exit = exit
        |}

        let comp = newValue |> import "createPresenceComponent" FluentUIv9
        let newProps = !!props |> createObj |> unbox

        newProps |> comp

    /// `createMotionComponent` is a factory function that creates a custom motion component powered by Web Animations API.
    static member inline createMotionComponent (value: IAtomMotionProp list) (props: IPresenceComponentProp list): ReactElement =
        let newValue = !!value |> createObj |> unbox
        let comp = newValue |> import "createMotionComponent" FluentUIv9
        let newProps = !!props |> createObj |> unbox

        newProps |> comp

//---------------------------------------------------------------- Components --------------------------------------------------------------------------------
    /// The FluentProvider transforms a passed theme to CSS variables and passes other settings to Fluent UI components.
    static member inline fluentProvider (props: IFluentProviderProp list) = createElement (import "FluentProvider" FluentUIv9) props
    /// An Avatar is a graphical representation of a user, team, or entity.
    /// Avatar can display an image, icon, or initials, and supports various sizes and shapes.
    static member inline avatar (props: IAvatarProp list) = createElement (import "Avatar" FluentUIv9) props
    /// A button triggers an action or event when activated.
    static member inline button (props: IButtonProp list) = createElement (import "Button" FluentUIv9) props
    /// A toggle button is a button that can be checked on and off.
    static member inline toggleButton (props: IToggleButtonProp list) = createElement (import "ToggleButton" FluentUIv9) props
    /// An accordion allows users to toggle the display of content by expanding or collapsing sections.
    static member inline accordion (props: IAccordionProp list) = createElement (import "Accordion" FluentUIv9) props
    static member inline accordionHeader (props: IAccordionHeaderProp list) = createElement (import "AccordionHeader" FluentUIv9) props
    static member inline accordionHeader (text: string) = createElement (import "AccordionHeader" FluentUIv9) [prop.text text]
    static member inline accordionItem (props: IAccordionItemProp list) = createElement (import "AccordionItem" FluentUIv9) props
    static member inline accordionPanel (props: ReactElement list) = Interop.reactElementWithChildren (import "AccordionPanel" FluentUIv9) props
    static member inline accordionPanel (props: IAccordionPanelProp list) = createElement (import "AccordionPanel" FluentUIv9) props
    /// Checkboxes give people a way to select one or more items from a group, or switch between two mutually exclusive options (checked or unchecked).
    static member inline checkbox (props: ICheckboxProp list) = createElement (import "Checkbox" FluentUIv9) props
    /// An image displays graphical content such as a photo or illustration.
    static member inline image (props: IImageProp list) = createElement (import "Image" FluentUIv9) props
    /// A badge is a visual decoration for UI elements.
    /// Badge displays text and/or an icon
    static member inline badge (props: IBadgeProp list) = createElement (import "Badge" FluentUIv9) props
    /// A badge is a visual decoration for UI elements.
    /// CounterBadge displays numerical values
    static member inline counterBadge (props: ICounterBadgeProp list) = createElement (import "CounterBadge" FluentUIv9) props
    /// A badge is a visual decoration for UI elements.
    /// PresenceBadge displays status
    static member inline presenceBadge (props: IPresenceBadgeProp list) = createElement (import "PresenceBadge" FluentUIv9) props
    /// Links allow users to navigate between different locations. They can be used as standalone controls or inline with text.
    static member inline link (props: ILinkProp list) = createElement (import "Link" FluentUIv9) props
    /// A divider visually separates two pieces of content.
    static member inline divider (props: IDividerProp list) = createElement (import "Divider" FluentUIv9) props
    /// Typography and styling abstraction component used to ensure consistency and standardize text throughout your application.
    static member inline text (text:string) = createElement (import "Text" FluentUIv9) [ prop.text text ]
    /// Typography and styling abstraction component used to ensure consistency and standardize text throughout your application.
    static member inline text (props: ITextProp list) = createElement (import "Text" FluentUIv9) props
    /// A label provides a name or title for an input.
    static member inline label (props: ILabelProp list) = createElement (import "Label" FluentUIv9) props
    /// A popover displays content on top of other content.
    /// WARNING: Popover can contain no more than two children including PopoverTrigger and PopoverSurface.
    /// If you try to use more than two children, only the first two you pass to this function will be used.
    /// Alternatively can only contain PopoverSurface if using a custom target.
    static member inline popover (props: ReactElement list) =
        let propsToUse =
            match props |> List.length with
            | l when l <= 2 -> props
            | _ -> props |> List.take 2
        Interop.reactElementWithChildren (import "Popover" FluentUIv9) propsToUse
    /// A popover displays content on top of other content.
    static member inline popover (props: IPopoverProp list) = createElement (import "Popover" FluentUIv9) props
    static member inline popoverTrigger (props: IPopoverTriggerProp list) = createElement (import "PopoverTrigger" FluentUIv9) props
    static member inline popoverSurface (props: ReactElement list) = Interop.reactElementWithChildren (import "PopoverSurface" FluentUIv9) props
    static member inline popoverSurface (props: IPopoverSurfaceProp list) = createElement (import "PopoverSurface" FluentUIv9) props
    static member inline popoverProvider (props: IPopoverProviderProp list) = createElement (import "PopoverProvider" FluentUIv9) props
    /// A tooltip displays additional information about another component. The information is displayed above and near the target component.
    /// Tooltip is not expected to handle interactive content. If this is necessary behavior, an expand/collapse button + popover should be used instead.
    /// Hover or focus the buttons in the examples to see their tooltips.
    static member inline tooltip (props: ITooltipProp list) = createElement (import "Tooltip" FluentUIv9) props
    /// Input allows the user to enter and edit text.
    static member inline input (props: IInputProp list) = createElement (import "Input" FluentUIv9) props
    /// A compound button is a button with an additional slot for secondary textual content.
    /// Since both primary and secondary textual contents are part of a compound button's name they should be kept concise.
    static member inline compoundButton (props: ICompoundButtonProp list) = createElement (import "CompoundButton" FluentUIv9) props
    /// A split button is a button with a primary action and a secondary action primarily used for opening a menu.
    static member inline splitButton (props: ISplitButtonProp list) = createElement (import "SplitButton" FluentUIv9) props
    /// Textarea allows the user to enter and edit multiline text.
    static member inline textArea (props: ITextAreaProp list) = createElement (import "Textarea" FluentUIv9) props
    /// A Slider represents an input that allows user to choose a value from within a specific range.
    static member inline slider (props: ISliderProp list) = createElement (import "Slider" FluentUIv9) props
    /// A switch represents a physical switch that allows someone to choose between two mutually exclusive options. For example, "On/Off" and "Show/Hide". Choosing an option should produce an immediate result.
    static member inline switch (props: ISwitchProp list) = createElement (import "Switch" FluentUIv9) props
    /// Radio is a single item in a RadioGroup. It is strongly recommended to use them inside a RadioGroup or RadioGroupField. However, they can also be used on their own: any Radio items with the same name will be treated as part of the same group.
    static member inline radio (props: IRadioProp list) = createElement (import "Radio" FluentUIv9) props
    /// RadioGroup lets people select a single option from two or more Radio items. Use RadioGroup to present all available choices if there's enough space. For more than 5 choices, consider using a different component such as Dropdown.
    static member inline radioGroup (props: IRadioGroupProp list) = createElement (import "RadioGroup" FluentUIv9) props
    /// A portal renders content outside of a DOM tree, at the end of the document.
    /// This allows content to escape traditional boundaries caused by "overflow: hidden" CSS rules and keeps it on the top without using z-index rules. This is useful for example in Menu and Tooltip scenarios, where the content should always overlay everything else.
    static member inline portal (props: IPortalProp list) = createElement (import "Portal" FluentUIv9) props
    /// A tab list provides single selection from tabs. When a tab is selected, the application displays content associated with the selected tab and hides other content.
    /// Each tab typically contains a text header and often includes an icon.
    static member inline tabList (props: ITabListProp list) = createElement (import "TabList" FluentUIv9) props
    static member inline tab (props: ITabProp list) = createElement (import "Tab" FluentUIv9) props
    /// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
    static member inline spinner (props: ISpinnerProp list) = createElement (import "Spinner" FluentUIv9) props
    /// SpinButtons are used to allow numerical and non-numerical input bounded between minimum and maximum values with buttons to increment and decrement the input value. Values can also be manipulated via the keyboard.
    static member inline spinButton (props: ISpinButtonProp list) = createElement (import "SpinButton" FluentUIv9) props
    /// A Select allows one option to be selected from multiple options. The Select component is a wrapper around the native <select> element.
    static member inline select (props: ISelectProp list) = createElement (import "Select" FluentUIv9) props
    /// A Dropdown is a selection component composed of a button and a list of options. The button displays the current selected item or a placeholder, and the list is visible on demand by clicking the button. Dropdowns are typically used in forms.
    static member inline dropdown (props: IDropdownProp list) = createElement (import "Dropdown" FluentUIv9) props
    static member inline option (props: IOptionProp list) = createElement (import "Option" FluentUIv9) props
    static member inline listbox (props: IListboxProp list) = createElement (import "Listbox" FluentUIv9) props
    /// A Persona is a visual representation of a person or status that showcases an Avatar, PresenceBadge, or an Avatar with a PresenceBadge.
    static member inline persona (props: IPersonaProp list) = createElement (import "Persona" FluentUIv9) props
    /// A combobox (Combobox) combines a text field and a dropdown giving people a way to select an option from a list or enter their own choice.
    static member inline combobox (props: IComboboxProp list) = createElement (import "Combobox" FluentUIv9) props
    /// A Progress provides a visual representation of content being loaded or processed.
    static member inline progressBar (props: IProgressBarProp list) = createElement (import "ProgressBar" FluentUIv9) props
    /// Field adds a label, validation message, and hint text to a control.
    static member inline field (props: IFieldProp list) = createElement (import "Field" FluentUIv9) props
    static member inline optionGroup (props: IOptionGroupProp list) = createElement (import "OptionGroup" FluentUIv9) props
    /// The Skeleton component is a temporary animation placeholder for when a service call takes time to return data and we don't want to block rendering the rest of the UI.
    static member inline skeleton (props: ReactElement list) = Interop.reactElementWithChildren (import "Skeleton" FluentUIv9) props
    /// The Skeleton component is a temporary animation placeholder for when a service call takes time to return data and we don't want to block rendering the rest of the UI.
    static member inline skeleton (props: ISkeletonProp list) = createElement (import "Skeleton" FluentUIv9) props
    static member inline skeletonItem (props: ISkeletonItemProp list) = createElement (import "SkeletonItem" FluentUIv9) props
    /// The Overflow and OverflowItem components, are low level utilities that enable users to create overflow experiences with any component. The components will detect and hide overflowing elements in DOM and manage the overflow state. Additional overflow hooks can be used to handle overflowing items. In the reference examples below the overflowing items are handled using a Menu.
    /// Additional hooks will be needed to create your specific overflow scenario. Please refer to the reference implementations below, which will use the additional utilities:
    /// useOverflowMenu- returns a ref that registers and overflow menu element.
    /// useIsOverflowItemVisible- returns whether an overflow item is visible.
    /// useOverflowCount- returns the number of overflowing items.
    /// useIsOverflowGroupVisible- return the visibility of an overflow group.
    static member inline overflow (props: IOverflowProp list) = createElement (import "Overflow" FluentUIv9) props
    /// The Overflow and OverflowItem components, are low level utilities that enable users to create overflow experiences with any component. The components will detect and hide overflowing elements in DOM and manage the overflow state. Additional overflow hooks can be used to handle overflowing items. In the reference examples below the overflowing items are handled using a Menu.
    /// Additional hooks will be needed to create your specific overflow scenario. Please refer to the reference implementations below, which will use the additional utilities:
    /// useOverflowMenu- returns a ref that registers and overflow menu element.
    /// useIsOverflowItemVisible- returns whether an overflow item is visible.
    /// useOverflowCount- returns the number of overflowing items.
    /// useIsOverflowGroupVisible- return the visibility of an overflow group.
    static member inline overflowItem (props: IOverflowItemProp list) = createElement (import "OverflowItem" FluentUIv9) props
    static member inline overflowDivider (props: IOverflowDividerProp list) = createElement (import "OverflowDivider" FluentUIv9) props
    /// Picking a date can be tough without context. A date picker (DatePicker) offers a popup control that’s optimized for picking a single date from a calendar view where contextual information like the day of the week or fullness of the calendar is important. You can modify the calendar to provide additional context or to limit available dates.
    /// Note: DatePicker is a compat component - its internal architecture does not follow all the principles regular Fluent UI v9 components follow - it is not composed of atomic hooks and it might be more difficult to tweak its appearance and behavior. It however follows Fluent 2 design and uses design tokens, it is production ready and it is stable.
    static member inline datePicker (props: IDatePickerProp list) = createElement (import "DatePicker" DatePickerCompat) props

    static member inline defaultDatePickerStrings : CalendarStrings = import "defaultDatePickerStrings" DatePickerCompat
    static member defaultDateFormatting : DateFormatting = DateFormat.default'

    /// As of 10/23/23, this component is not in Microsoft's documentation but is completely usable.
    /// This could be used in place of an InfoLabel component where no label is needed?
    static member inline infoButton (props: IInfoButtonProp list) = createElement (import "InfoButton" "@fluentui/react-infobutton") props
    /// An InfoLabel is a Label with an InfoButton at the end, properly handling layout and accessibility properties. It can be used as a drop-in replacement for Label when an InfoButton is also needed.
    static member inline infoLabel (props: IInfoLabelProp list) = createElement (import "InfoLabel" FluentUIv9) props
    /// An Alert displays a brief, important message to attract a user's attention without interrupting their current task.
    ///
    /// WARNING: This API is deprecated. Please use the Toast or MessageBar component instead.
    [<Obsolete>] static member inline alert (props: IAlertProp list) = createElement (import "Alert" Alert_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline virtualizer (props: IVirtualizerProp list) = createElement (import "Virtualizer" Virtualizer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline virtualizerScrollView (props: IVirtualizerScrollViewProp list) = createElement (import "VirtualizerScrollView" Virtualizer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline virtualizerScrollViewDynamic (props: IVirtualizerScrollViewDynamicProp list) = createElement (import "VirtualizerScrollViewDynamic" Virtualizer_unstable) props
    /// The Drawer gives users a quick entry point to configuration and information. It should be used when retaining context is beneficial to users.
    /// There are three main components to represent a Drawer:
    /// DrawerOverlay: Represents an overlay Drawer. This component renders on top of the whole page. By default blocks the screen and will require users full attention. Uses Dialog component under the hood.
    /// DrawerInline: Represents an inline Drawer. This is rendered within a container and can be placed next to any content.
    /// Drawer: It is a combination of DrawerOverlay and DrawerInline. Used when toggling between the two modes is necessary. Often used for responsiveness.
    static member inline drawer (props: IDrawerProp list) = createElement (import "Drawer" FluentUIv9) props
    /// Represents an overlay Drawer. This component renders on top of the whole page. By default blocks the screen and will require users full attention. Uses Dialog component under the hood.
    static member inline overlayDrawer (props: IOverlayDrawerProp list) = createElement (import "OverlayDrawer" FluentUIv9) props
    /// Represents an inline Drawer. This is rendered within a container and can be placed next to any content.
    static member inline inlineDrawer (props: IInlineDrawerProp list) = createElement (import "InlineDrawer" FluentUIv9) props
    static member inline drawerHeader (props: IDrawerHeaderProp list) = createElement (import "DrawerHeader" FluentUIv9) props
    static member inline drawerHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DrawerHeader" FluentUIv9) props
    static member inline drawerHeaderTitle (props: IDrawerHeaderTitleProp list) = createElement (import "DrawerHeaderTitle" FluentUIv9) props
    static member inline drawerHeaderNavigation (props: IDrawerHeaderNavigationProp list) = createElement (import "DrawerHeaderNavigation" FluentUIv9) props
    static member inline drawerBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DrawerBody" FluentUIv9) props
    static member inline drawerBody (props: IDrawerBodyProp list) = createElement (import "DrawerBody" FluentUIv9) props
    // Card
    /// A card is a container that holds information and actions related to a single concept or object, like a document or a contact.
    /// Cards can give information prominence and create predictable patterns. While they're very flexible, it's important to use them consistently for particular use cases across experiences.
    static member inline card (props: ReactElement list) = Interop.reactElementWithChildren (import "Card" FluentUIv9) props
    /// A card is a container that holds information and actions related to a single concept or object, like a document or a contact.
    /// Cards can give information prominence and create predictable patterns. While they're very flexible, it's important to use them consistently for particular use cases across experiences.
    static member inline card (props: ICardProp list) = createElement (import "Card" FluentUIv9) props
    /// The CardFooter component, used inside of a Card, uses a flex layout to organize actions the user can take with a Card, like sharing the contents or replying to a message.
    static member inline cardFooter (props: ReactElement list) = Interop.reactElementWithChildren (import "CardFooter" FluentUIv9) props
    /// The CardFooter component, used inside of a Card, uses a flex layout to organize actions the user can take with a Card, like sharing the contents or replying to a message.
    static member inline cardFooter (props: ICardFooterProp list) = createElement (import "CardFooter" FluentUIv9) props
    /// The CardHeader component, used inside of a Card, represents a Fluent UI compliant card header.
    static member inline cardHeader (props: ICardHeaderProp list) = createElement (import "CardHeader" FluentUIv9) props
    /// The CardPreview component, used inside of a Card, allows the user to better visualize what the card's contents are.
    static member inline cardPreview (props: ReactElement list) = Interop.reactElementWithChildren (import "CardPreview" FluentUIv9) props
    /// The CardPreview component, used inside of a Card, allows the user to better visualize what the card's contents are.
    static member inline cardPreview (props: ICardPreviewProp list) = createElement (import "CardPreview" FluentUIv9) props
    // Toast
    /// A Toasts displays temporary content to the user. Toasts are rendered as a separate surface that can be dismissed by user action or a application timeout. Toasts are typically used in the following situations:
    /// Update the user on the status of a task
    /// Display the progress of a task
    /// Notify the user to take an action
    /// Notify the user of an application update
    /// Warn the user of an error
    /// The Fluent UI Toast component uses an imperative API. Once a Toaster has been rendered, you can use the useToastController hook to get access to imperative methods to dispatch a Toast. The Toast component itself is simply a layout component.
    static member inline toast (props: ReactElement list) = Interop.reactElementWithChildren (import "Toast" FluentUIv9) props
    /// A Toasts displays temporary content to the user. Toasts are rendered as a separate surface that can be dismissed by user action or a application timeout. Toasts are typically used in the following situations:
    /// Update the user on the status of a task
    /// Display the progress of a task
    /// Notify the user to take an action
    /// Notify the user of an application update
    /// Warn the user of an error
    /// The Fluent UI Toast component uses an imperative API. Once a Toaster has been rendered, you can use the useToastController hook to get access to imperative methods to dispatch a Toast. The Toast component itself is simply a layout component.
    static member inline toast (props: IToastProp list) = createElement (import "Toast" FluentUIv9) props
    static member inline toastTitle (props: IToastTitleProp list) = createElement (import "ToastTitle" FluentUIv9) props
    static member inline toastTitle (text: string) = createElement (import "ToastTitle" FluentUIv9) [ prop.text text ]
    static member inline toastBody (props: IToastBodyProp list) = createElement (import "ToastBody" FluentUIv9) props
    static member inline toastFooter (props: ReactElement list) = Interop.reactElementWithChildren (import "ToastFooter" FluentUIv9) props
    static member inline toastFooter (props: IToastFooterProp list) = createElement (import "ToastFooter" FluentUIv9) props
    static member inline toaster (props: IToasterProp list) = createElement (import "Toaster" FluentUIv9) props
    // Dialog
    /// Dialog is a window overlaid on either the primary window or another dialog window. Windows under a modal dialog are inert. That is, users cannot interact with content outside an active dialog window. Inert content outside an active dialog is typically visually obscured or dimmed so it is difficult to discern, and in some implementations, attempts to interact with the inert content cause the dialog to close.
    static member inline dialog (props: IDialogProp list) = createElement (import "Dialog" FluentUIv9) props
    static member inline dialogTrigger (props: IDialogTriggerProp list) = createElement (import "DialogTrigger" FluentUIv9) props
    static member inline dialogSurface (props: ReactElement list) = Interop.reactElementWithChildren (import "DialogSurface" FluentUIv9) props
    static member inline dialogSurface (props: IDialogSurfaceProp list) = createElement (import "DialogSurface" FluentUIv9) props
    static member inline dialogTitle (props: IDialogTitleProp list) = createElement (import "DialogTitle" FluentUIv9) props
    static member inline dialogTitle (text: string) = createElement (import "DialogTitle" FluentUIv9) [ prop.text text ]
    static member inline dialogActions (props: IDialogActionsProp list) = createElement (import "DialogActions" FluentUIv9) props
    static member inline dialogBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DialogBody" FluentUIv9) props
    static member inline dialogBody (props: IDialogBodyProp list) = createElement (import "DialogBody" FluentUIv9) props
    static member inline dialogContent (props: IDialogContentProp list) = createElement (import "DialogContent" FluentUIv9) props
    // AvatarGroup
    /// An AvatarGroup is a graphical representation of multiple people associated with a given entity. AvatarGroup leverages the Avatar component, with each Avatar representing a person and containing their image, initials, or an icon. An AvatarGroup can be represented in a spread, stack, or pie layout.
    static member inline avatarGroup (props: IAvatarGroupProp list) = createElement (import "AvatarGroup" FluentUIv9) props
    static member inline avatarGroupItem (props: IAvatarGroupItemProp list) = createElement (import "AvatarGroupItem" FluentUIv9) props
    static member inline avatarGroupPopover (props: ReactElement list) = Interop.reactElementWithChildren (import "AvatarGroupPopover" FluentUIv9) props
    static member inline avatarGroupPopover (props: IAvatarGroupPopoverProp list) = createElement (import "AvatarGroupPopover" FluentUIv9) props

    // Toolbar
    /// A toolbar is a container for grouping a set of controls, such as buttons, menu buttons, or checkboxes.
    static member inline toolbar (props: IToolbarProp list) = createElement (import "Toolbar" FluentUIv9) props
    static member inline toolbarButton (props: IToolbarButtonProp list) = createElement (import "ToolbarButton" FluentUIv9) props
    static member inline toolbarDivider (props: IToolbarDividerProp list) = createElement (import "ToolbarDivider" FluentUIv9) props
    static member inline toolbarGroup (props: ReactElement list) = Interop.reactElementWithChildren  (import "ToolbarGroup" FluentUIv9) props
    static member inline toolbarGroup (props: IToolbarGroupProp list) = createElement (import "ToolbarGroup" FluentUIv9) props
    static member inline toolbarRadioButton (props: IToolbarRadioButtonProp list) = createElement (import "ToolbarRadioButton" FluentUIv9) props
    static member inline toolbarRadioGroup (props: ReactElement list) = Interop.reactElementWithChildren  (import "ToolbarRadioGroup" FluentUIv9) props
    static member inline toolbarRadioGroup (props: IToolbarRadioGroupProp list) = createElement (import "ToolbarRadioGroup" FluentUIv9) props
    static member inline toolbarToggleButton (props: IToolbarToggleButtonProp list) = createElement (import "ToolbarToggleButton" FluentUIv9) props
    /// A menu button is a button with a chevron icon after the text typically used to trigger a menu.
    static member inline menuButton (props: IMenuButtonProp list) = createElement (import "MenuButton" FluentUIv9) props
    /// A menu displays a list of actions. The Menu component handles the state management of the passed in list of actions.
    /// WARNING: Menu can contain no more than two children including MenuTrigger and MenuPopover.
    /// If you try to use more than two children, only the first two you pass to this function will be used
    /// Alternatively can only contain MenuPopover if using a custom target.
    static member inline menu (props: ReactElement list) =
        let propsToUse =
            match props |> List.length with
            | l when l <= 2 -> props
            | _ -> props |> List.take 2
        Interop.reactElementWithChildren  (import "Menu" FluentUIv9) propsToUse
    /// A menu displays a list of actions. The Menu component handles the state management of the passed in list of actions.
    static member inline menu (props: IMenuProp list) = createElement (import "Menu" FluentUIv9) props
    /// A menu list displays a list of actions. It is usually rendered inside of the Menu component.
    static member inline menuList (props: ReactElement list) = Interop.reactElementWithChildren  (import "MenuList" FluentUIv9) props
    /// A menu list displays a list of actions. It is usually rendered inside of the Menu component.
    static member inline menuList (props: IMenuListProp list) = createElement (import "MenuList" FluentUIv9) props
    static member inline menuItem (text: string) = createElement (import "MenuItem" FluentUIv9) [ prop.text text ]
    static member inline menuItem (props: IMenuItemProp list) = createElement (import "MenuItem" FluentUIv9) props
    static member inline menuItemCheckbox (props: IMenuItemCheckboxProp list) = createElement (import "MenuItemCheckbox" FluentUIv9) props
    static member inline menuItemRadio (props: IMenuItemRadioProp list) = createElement (import "MenuItemRadio" FluentUIv9) props
    static member inline menuPopover (props: ReactElement list) = Interop.reactElementWithChildren  (import "MenuPopover" FluentUIv9) props
    static member inline menuPopover (props: IMenuPopoverProp list) = createElement (import "MenuPopover" FluentUIv9) props
    static member inline menuTrigger (props: IMenuTriggerProp list) = createElement (import "MenuTrigger" FluentUIv9) props
    static member inline menuSplitGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "MenuSplitGroup" FluentUIv9) props
    static member inline menuSplitGroup (props: IMenuSplitGroupProp list) = createElement (import "MenuSplitGroup" FluentUIv9) props
    static member inline menuGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "MenuGroup" FluentUIv9) props
    static member inline menuGroup (props: IMenuGroupProp list) = createElement (import "MenuGroup" FluentUIv9) props
    static member inline menuDivider (props: IMenuDividerProp list) = createElement (import "MenuDivider" FluentUIv9) props
    static member inline menuItemLink (props: IMenuItemLinkProp list) = createElement (import "MenuItemLink" FluentUIv9) props
    static member inline menuItemSwitch (props: IMenuItemSwitchProp list) = createElement (import "MenuItemSwitch" FluentUIv9) props
    // Table
    /// This component is considered low-level and should be used when there is a need for more customization and support for non-standard features. Please check out the DataGrid component if you don't need lots of customization and rely on common features. There is less work involved and you will benefit from first class Microsoft design and accessibility support.
    ///
    /// WARNING: Hooks for this component are incomplete. Please use ```Fui.dataGrid``` instead.
    static member inline table (props: ReactElement list) = Interop.reactElementWithChildren (import "Table" FluentUIv9) props
    /// This component is considered low-level and should be used when there is a need for more customization and support for non-standard features. Please check out the DataGrid component if you don't need lots of customization and rely on common features. There is less work involved and you will benefit from first class Microsoft design and accessibility support.
    ///
    /// WARNING: Hooks for this component are incomplete. Please use ```Fui.dataGrid``` instead.
    static member inline table (props: ITableProp list) = createElement (import "Table" FluentUIv9) props
    static member inline tableHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "TableHeader" FluentUIv9) props
    static member inline tableHeader (props: ITableHeaderProp list) = createElement (import "TableHeader" FluentUIv9) props
    static member inline tableHeaderCell (props: ReactElement list) = Interop.reactElementWithChildren (import "TableHeaderCell" FluentUIv9) props
    static member inline tableHeaderCell (props: ITableHeaderCellProp list) = createElement (import "TableHeaderCell" FluentUIv9) props
    static member inline tableBody (props: ReactElement list) = Interop.reactElementWithChildren (import "TableBody" FluentUIv9) props
    static member inline tableBody (props: ITableBodyProp list) = createElement (import "TableBody" FluentUIv9) props
    static member inline tableRow (props: ReactElement list) = Interop.reactElementWithChildren (import "TableRow" FluentUIv9) props
    static member inline tableRow (props: ITableRowProp list) = createElement (import "TableRow" FluentUIv9) props
    static member inline tableCell (props: ReactElement list) = Interop.reactElementWithChildren (import "TableCell" FluentUIv9) props
    static member inline tableCell (props: ITableCellProp list) = createElement (import "TableCell" FluentUIv9) props
    static member inline tableSelectionCell (props: ITableSelectionCellProp list) = createElement (import "TableSelectionCell" FluentUIv9) props
    static member inline tableCellLayout (props: ReactElement list) = Interop.reactElementWithChildren (import "TableCellLayout" FluentUIv9) props
    static member inline tableCellLayout (props: ITableCellLayoutProp list) = createElement (import "TableCellLayout" FluentUIv9) props
    static member inline tableCellActions (props: ReactElement list) = Interop.reactElementWithChildren (import "TableCellActions" FluentUIv9) props
    static member inline tableCellActions (props: ITableCellActionsProp list) = createElement (import "TableCellActions" FluentUIv9) props
    static member inline tableResizeHandle (props: ITableResizeHandleProp list) = createElement (import "TableResizeHandle" FluentUIv9) props

    // DataGrid
    /// This component is a higher level extension of the Table primitive components and the useTableFeatures hook. DataGrid is a feature-rich component that uses useTableFeatures internally, so there should always be full feature parity with what can be achieved with primitives. This component is opinionated and this is intentional. If the desired scenario can be achieved easily and does not vary too much from documented examples, it can be very convenient. If the desired scenario varies a lot from the documented examples please use the Table components with useTableFeatures (or another state management solution of choice).
    /// Feature requests will be accepted, but the team will prioritize overall API scalability and extensibility over uncommon features and scenarios.
    static member inline dataGrid (props: IDataGridProp list) = createElement (import "DataGrid" FluentUIv9) props
    static member inline dataGridHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeader" FluentUIv9) props
    static member inline dataGridHeader (props: IDataGridHeaderProp list) = createElement (import "DataGridHeader" FluentUIv9) props
    static member inline dataGridHeaderCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeaderCell" FluentUIv9) props
    static member inline dataGridHeaderCell (props: IDataGridHeaderCellProp list) = createElement (import "DataGridHeaderCell" FluentUIv9) props
    static member inline dataGridRow (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridRow" FluentUIv9) props
    static member inline dataGridRow (props: IDataGridRowProp list) = createElement (import "DataGridRow" FluentUIv9) props
    static member inline dataGridBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridBody" FluentUIv9) props
    static member inline dataGridBody (props: IDataGridBodyProp list) = createElement (import "DataGridBody" FluentUIv9) props
    static member inline dataGridCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridCell" FluentUIv9) props
    static member inline dataGridCell (props: IDataGridCellProp list) = createElement (import "DataGridCell" FluentUIv9) props
    static member inline dataGridSelectionCell (props: IDataGridSelectionCellProp list) = createElement (import "DataGridSelectionCell" FluentUIv9) props

    // Tree
    /// A hierarchical list structure component for displaying data in a collapsible and expandable way
    /// Use this component when you need to present your users with a clear visual structure of content or data, allowing them to efficiently interact and navigate through the information. If the information is less hierarchical or node-based, consider using a list or table instead.
    static member inline tree (props: ReactElement list) = Interop.reactElementWithChildren (import "Tree" FluentUIv9) props
    /// A hierarchical list structure component for displaying data in a collapsible and expandable way
    /// Use this component when you need to present your users with a clear visual structure of content or data, allowing them to efficiently interact and navigate through the information. If the information is less hierarchical or node-based, consider using a list or table instead.
    static member inline tree (props: ITreeProp list) = createElement (import "Tree" FluentUIv9) props
    static member inline flatTree (props: IFlatTreeProp list) = createElement (import "FlatTree" FluentUIv9) props
    static member inline treeItem (props: ITreeItemProp list) = createElement (import "TreeItem" FluentUIv9) props
    static member inline treeItemLayout (props: ReactElement list) = Interop.reactElementWithChildren (import "TreeItemLayout" FluentUIv9) props
    static member inline treeItemLayout (props: ITreeItemLayoutProp list) = createElement (import "TreeItemLayout" FluentUIv9) props
    static member inline treeItemPersonaLayout (props: ITreeItemPersonaLayoutProp list) = createElement (import "TreeItemPersonaLayout" FluentUIv9) props
    // Breadcrumb
    static member inline breadcrumb (props: IBreadcrumbProp list) = createElement (import "Breadcrumb" FluentUIv9) props
    static member inline breadcrumb (props: ReactElement list) = Interop.reactElementWithChildren (import "Breadcrumb" FluentUIv9) props
    static member inline breadcrumbItem (props: IBreadcrumbItemProp list) = createElement (import "BreadcrumbItem" FluentUIv9) props
    static member inline breadcrumbItem (props: ReactElement list) = Interop.reactElementWithChildren (import "BreadcrumbItem" FluentUIv9) props
    static member inline breadcrumbButton (props: IBreadcrumbButtonProp list) = createElement (import "BreadcrumbButton" FluentUIv9) props
    static member inline breadcrumbDivider (props: IBreadcrumbDividerProp list) = createElement (import "BreadcrumbDivider" FluentUIv9) props
    static member inline partitionBreadcrumbItems (options: IPartitionBreadcrumbItemsOptionsProp list): PartitionBreadcrumbItems<'T> =
        let partitionBreadcrumbItems = import "partitionBreadcrumbItems" FluentUIv9

        !!options
        |> createObj
        |> unbox<PartitionBreadcrumbItemsOptions<'T>>
        |> partitionBreadcrumbItems

    static member inline searchBox (props: ISearchBoxProp list) = createElement (import "SearchBox" FluentUIv9) props
    static member inline tag (props: ITagProp list) = createElement (import "Tag" FluentUIv9) props
    static member inline tagGroup (props: ITagGroupProp list) = createElement (import "TagGroup" FluentUIv9) props
    static member inline interactionTag (props: IInteractionTagProp list) = createElement (import "InteractionTag" FluentUIv9) props
    static member inline interactionTag (props: ReactElement list) = Interop.reactElementWithChildren (import "InteractionTag" FluentUIv9) props
    static member inline interactionTagPrimary (props: IInteractionTagPrimaryProp list) = createElement (import "InteractionTagPrimary" FluentUIv9) props
    static member inline interactionTagSecondary (props: IInteractionTagSecondaryProp list) = createElement (import "InteractionTagSecondary" FluentUIv9) props
    // MessageBar
    /// Communicates important information about the state of the entire application or surface. For example, the status of a page, panel, dialog or card.
    /// The information shouldn't require someone to take immediate action, but should persist until the user performs one of the required actions.
    static member inline messageBar (props: IMessageBarProp list) = createElement (import "MessageBar" FluentUIv9) props
    /// Communicates important information about the state of the entire application or surface. For example, the status of a page, panel, dialog or card.
    /// The information shouldn't require someone to take immediate action, but should persist until the user performs one of the required actions.
    static member inline messageBar (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBar" FluentUIv9) props
    static member inline messageBarBody (props: IMessageBarBodyProp list) = createElement (import "MessageBarBody" FluentUIv9) props
    static member inline messageBarBody (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBarBody" FluentUIv9) props
    static member inline messageBarTitle (props: IMessageBarTitleProp list) = createElement (import "MessageBarTitle" FluentUIv9) props
    static member inline messageBarTitle (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBarTitle" FluentUIv9) props
    static member inline messageBarTitle (text: string) = createElement (import "MessageBarTitle" FluentUIv9) [ prop.text text ]
    static member inline messageBarActions (props: IMessageBarActionsProp list) = createElement (import "MessageBarActions" FluentUIv9) props
    static member inline messageBarGroup (props: IMessageBarGroupProp list) = createElement (import "MessageBarGroup" FluentUIv9) props
    static member inline messageBarGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBarGroup" FluentUIv9) props

    // Calendar
    static member inline calendar (props: ICalendarProp list) = createElement (import "Calendar" CalendarCompat) props

    static member inline timePicker (props: ITimePickerProp list) = createElement (import "TimePicker" TimepickerCompat) props

    static member inline typographyStyles: TypographyStyles = import "typographyStyles" FluentUIv9

    // TeachingPopover
    static member inline teachingPopover (props: ITeachingPopoverProp list) = createElement (import "TeachingPopover" FluentUIv9) props
    static member inline teachingPopover (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopover" FluentUIv9) props
    static member inline teachingPopoverTrigger (props: ReactElement) = createElement (import "TeachingPopoverTrigger" FluentUIv9) [prop.children (props)]
    static member inline teachingPopoverTrigger (props: ITeachingPopoverTriggerProp list) = createElement (import "TeachingPopoverTrigger" FluentUIv9) props
    static member inline teachingPopoverSurface (props: ITeachingPopoverSurfaceProp list) = createElement (import "TeachingPopoverSurface" FluentUIv9) props
    static member inline teachingPopoverSurface (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverSurface" FluentUIv9) props
    static member inline teachingPopoverHeader (props: ITeachingPopoverHeaderProp list) = createElement (import "TeachingPopoverHeader" FluentUIv9) props
    static member inline teachingPopoverHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverHeader" FluentUIv9) props
    static member inline teachingPopoverHeader (text: string) = createElement (import "TeachingPopoverHeader" FluentUIv9) [ prop.text text ]
    static member inline teachingPopoverBody (props: ITeachingPopoverBodyProp list) = createElement (import "TeachingPopoverBody" FluentUIv9) props
    static member inline teachingPopoverTitle (props: ITeachingPopoverTitleProp list) = createElement (import "TeachingPopoverTitle" FluentUIv9) props
    static member inline teachingPopoverTitle (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverTitle" FluentUIv9) props
    static member inline teachingPopoverTitle (text: string) = createElement (import "TeachingPopoverTitle" FluentUIv9) [ prop.text text ]
    static member inline teachingPopoverCarousel (props: ITeachingPopoverCarouselProp list) = createElement (import "TeachingPopoverCarousel" FluentUIv9) props
    static member inline teachingPopoverCarousel (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarousel" FluentUIv9) props
    static member inline teachingPopoverCarouselCard (props: ITeachingPopoverCarouselCardProp list) = createElement (import "TeachingPopoverCarouselCard" FluentUIv9) props
    static member inline teachingPopoverCarouselCard (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarouselCard" FluentUIv9) props
    static member inline teachingPopoverCarouselFooter (props: ITeachingPopoverCarouselFooterProp list) = createElement (import "TeachingPopoverCarouselFooter" FluentUIv9) props
    static member inline teachingPopoverCarouselFooter (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarouselFooter" FluentUIv9) props
    static member inline teachingPopoverCarouselNav (props: ITeachingPopoverCarouselNavProp list) = createElement (import "TeachingPopoverCarouselNav" FluentUIv9) props
    static member inline teachingPopoverCarouselNav (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarouselNav" FluentUIv9) props
    static member inline teachingPopoverCarouselNavButton (props: ITeachingPopoverCarouselNavButtonProp list) = createElement (import "TeachingPopoverCarouselNavButton" FluentUIv9) props

    static member inline rating (props: IRatingProp list) = createElement (import "Rating" FluentUIv9) props
    static member inline ratingItem (props: IRatingItemProp list) = createElement (import "RatingItem" FluentUIv9) props
    static member inline ratingDisplay (props: IRatingDisplayProp list) = createElement (import "RatingDisplay" FluentUIv9) props

    static member inline tagPicker (props: ITagPickerProp list) = createElement (import "TagPicker" FluentUIv9) props
    static member inline tagPicker (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPicker" FluentUIv9) props
    static member inline tagPickerControl (props: ITagPickerControlProp list) = createElement (import "TagPickerControl" FluentUIv9) props
    static member inline tagPickerControl (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerControl" FluentUIv9) props
    static member inline tagPickerGroup (props: ITagPickerGroupProp list) = createElement (import "TagPickerGroup" FluentUIv9) props
    static member inline tagPickerGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerGroup" FluentUIv9) props
    static member inline tagPickerButton (props: ITagPickerButtonProp list) = createElement (import "TagPickerButton" FluentUIv9) props
    static member inline tagPickerButton (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerButton" FluentUIv9) props
    static member inline tagPickerInput (props: ITagPickerInputProp list) = createElement (import "TagPickerInput" FluentUIv9) props
    static member inline tagPickerInput (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerInput" FluentUIv9) props
    static member inline tagPickerList (props: ITagPickerListProp list) = createElement (import "TagPickerList" FluentUIv9) props
    static member inline tagPickerList (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerList" FluentUIv9) props
    static member inline tagPickerOption (props: ITagPickerOptionProp list) = createElement (import "TagPickerOption" FluentUIv9) props
    static member inline tagPickerOption (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerOption" FluentUIv9) props
    static member inline tagPickerOptionGroup (props: ITagPickerOptionGroupProp list) = createElement (import "TagPickerOptionGroup" FluentUIv9) props
    static member inline tagPickerOptionGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerOptionGroup" FluentUIv9) props
    static member inline swatchPicker (props: ISwatchPickerProp list) = createElement (import "SwatchPicker" FluentUIv9) props
    static member inline colorSwatch (props: IColorSwatchProp list) = createElement (import "ColorSwatch" FluentUIv9) props
    static member inline swatchPickerRow (props: ISwatchPickerRowProp list) = createElement (import "SwatchPickerRow" FluentUIv9) props
    static member inline imageSwatch (props: IImageSwatchProp list) = createElement (import "ImageSwatch" FluentUIv9) props
    static member inline emptySwatch (props: IEmptySwatchProp list) = createElement (import "EmptySwatch" FluentUIv9) props
    static member inline carousel (props: ICarouselProp list) = createElement (import "Carousel" FluentUIv9) props
    static member inline carouselButton (props: ICarouselButtonProp list) = createElement (import "CarouselButton" FluentUIv9) props
    static member inline carouselCard (props: ICarouselCardProp list) = createElement (import "CarouselCard" FluentUIv9) props
    static member inline carouselCard (props: ReactElement list) = Interop.reactElementWithChildren (import "CarouselCard" FluentUIv9) props
    static member inline carouselNav (props: ICarouselNavProp list) = createElement (import "CarouselNav" FluentUIv9) props
    static member inline carouselNav (props: ReactElement list) = Interop.reactElementWithChildren (import "CarouselNav" FluentUIv9) props
    static member inline carouselNavButton (props: ICarouselNavButtonProp list) = createElement (import "CarouselNavButton" FluentUIv9) props
    static member inline carouselNavContainer (props: ICarouselNavContainerProp list) = createElement (import "CarouselNavContainer" FluentUIv9) props
    static member inline carouselNavImageButton (props: ICarouselNavImageButtonProp list) = createElement (import "CarouselNavImageButton" FluentUIv9) props
    static member inline carouselSlider (props: ICarouselSliderProp list) = createElement (import "CarouselSlider" FluentUIv9) props
    static member inline carouselSlider (props: ReactElement list) = Interop.reactElementWithChildren (import "CarouselSlider" FluentUIv9) props
    static member inline carouselAutoplayButton (props: ICarouselAutoplayButtonProp list) = createElement (import "CarouselAutoplayButton" FluentUIv9) props
    static member inline carouselViewport (props: ICarouselViewportProp list) = createElement (import "CarouselViewport" FluentUIv9) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline appItem (props: IAppItemProp list) = createElement (import "AppItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline hamburger (props: IHamburgerProp list) = createElement (import "Hamburger" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navCategory (props: INavCategoryProp list) = createElement (import "NavCategory" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navCategoryItem (props: INavCategoryItemProp list) = createElement (import "NavCategoryItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDivider (props: INavDividerProp list) = createElement (import "NavDivider" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawer (props: INavDrawerProp list) = createElement (import "NavDrawer" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerBody (props: INavDrawerBodyProp list) = createElement (import "NavDrawerBody" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerBody (props: ReactElement list) = Interop.reactElementWithChildren (import "NavDrawerBody" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerHeader (props: INavDrawerHeaderProp list) = createElement (import "NavDrawerHeader" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerHeader (props: ReactElement list) =  Interop.reactElementWithChildren (import "NavDrawerHeader" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navItem (props: INavItemProp list) = createElement (import "NavItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSectionHeader (props: INavSectionHeaderProp list) = createElement (import "NavSectionHeader" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSubItem (props: INavSubItemProp list) = createElement (import "NavSubItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSubItemGroup (props: INavSubItemGroupProp list) = createElement (import "NavSubItemGroup" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSubItemGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "NavSubItemGroup" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline appItemStatic (props: IAppItemStaticProp list) = createElement (import "AppItemStatic" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline splitNavItem (props: ISplitNavItemProp list) = createElement (import "SplitNavItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerFooter (props: INavDrawerFooterProp list) = createElement (import "NavDrawerFooter" Nav_unstable) props

type [<Erase>] Theme =
    static member inline teamsLightTheme : Tokens = import "teamsLightTheme" FluentUIv9
    static member inline teamsDarkTheme : Tokens = import "teamsDarkTheme" FluentUIv9
    static member inline teamsHighContrastTheme : Tokens = import "teamsHighContrastTheme" FluentUIv9
    static member inline webLightTheme : Tokens = import "webLightTheme" FluentUIv9
    static member inline webDarkTheme : Tokens = import "webDarkTheme" FluentUIv9
    /// Warning: Although overriding tokens with 'let newTokens = { Theme.tokens with colorBrandStroke1 = "#cbe82e" }' is possible,
    /// it's not recommended-- if the existing tokens do not fulfill your needs, you should create a custom theme instead of overriding tokens.
    static member inline tokens: Tokens = import "tokens" FluentUIv9
    static member inline motionTokens: MotionTokens = import "motionTokens" FluentUIv9
    /// Programmatically generates a tokens to css variables mapping object from the keys in a theme.
    /// This helps with ease of use as a user of a custom theme does not have to manually construct this object, but it could
    /// affect tree-shaking since bundlers do not know the shape of the output.
    /// @param theme - Theme from which to get the keys to generate the tokens to css variables mapping object
    /// @returns Tokens to css variables mapping object corresponding to the passed theme
    static member inline themeToTokensObject (theme: Tokens): Tokens = import "themeToTokensObject" FluentUIv9

module Fui =
    type [<Erase>] virtualized =
        static member inline dataGrid (props: IDataGridProp list) = createElement (import "DataGrid" ReactWindow) props
        static member inline dataGridHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeader" ReactWindow) props
        static member inline dataGridHeader (props: IDataGridHeaderProp list) = createElement (import "DataGridHeader" ReactWindow) props
        static member inline dataGridHeaderCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeaderCell" ReactWindow) props
        static member inline dataGridHeaderCell (props: IDataGridHeaderCellProp list) = createElement (import "DataGridHeaderCell" ReactWindow) props
        static member inline dataGridRow (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridRow" ReactWindow) props
        static member inline dataGridRow (props: IDataGridRowProp list) = createElement (import "DataGridRow" ReactWindow) props
        static member inline dataGridBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridBody" ReactWindow) props
        static member inline dataGridBody (props: IDataGridBodyProp list) = createElement (import "DataGridBody" ReactWindow) props
        static member inline dataGridCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridCell" ReactWindow) props
        static member inline dataGridCell (props: IDataGridCellProp list) = createElement (import "DataGridCell" ReactWindow) props
        static member inline dataGridSelectionCell (props: IDataGridSelectionCellProp list) = createElement (import "DataGridSelectionCell" ReactWindow) props

    type [<Erase>] text =
        static member inline body1 (text: string) = createElement (import "Body1" FluentUIv9) [prop.text text]
        static member inline body1 (props: ITextProp list) = createElement (import "Body1" FluentUIv9) props
        static member inline body1Strong (text: string) = createElement (import "Body1Strong" FluentUIv9) [prop.text text]
        static member inline body1Strong (props: ITextProp list) = createElement (import "Body1Strong" FluentUIv9) props
        static member inline body1Stronger (text: string) = createElement (import "Body1Stronger" FluentUIv9) [prop.text text]
        static member inline body1Stronger (props: ITextProp list) = createElement (import "Body1Stronger" FluentUIv9) props
        static member inline body2 (text: string) = createElement (import "Body2" FluentUIv9) [prop.text text]
        static member inline body2 (props: ITextProp list) = createElement (import "Body2" FluentUIv9) props
        static member inline caption1 (text: string) = createElement (import "Caption1" FluentUIv9) [prop.text text]
        static member inline caption1 (props: ITextProp list) = createElement (import "Caption1" FluentUIv9) props
        static member inline caption1Strong (text: string) = createElement (import "Caption1Strong" FluentUIv9) [prop.text text]
        static member inline caption1Strong (props: ITextProp list) = createElement (import "Caption1Strong" FluentUIv9) props
        static member inline caption1Stronger (text: string) = createElement (import "Caption1Stronger" FluentUIv9) [prop.text text]
        static member inline caption1Stronger (props: ITextProp list) = createElement (import "Caption1Stronger" FluentUIv9) props
        static member inline caption2 (text: string) = createElement (import "Caption2" FluentUIv9) [prop.text text]
        static member inline caption2 (props: ITextProp list) = createElement (import "Caption2" FluentUIv9) props
        static member inline caption2Strong (text: string) = createElement (import "Caption2Strong" FluentUIv9) [prop.text text]
        static member inline caption2Strong (props: ITextProp list) = createElement (import "Caption2Strong" FluentUIv9) props
        static member inline display (text: string) = createElement (import "Display" FluentUIv9) [prop.text text]
        static member inline display (props: ITextProp list) = createElement (import "Display" FluentUIv9) props
        static member inline largeTitle (text: string) = createElement (import "LargeTitle" FluentUIv9) [prop.text text]
        static member inline largeTitle (props: ITextProp list) = createElement (import "LargeTitle" FluentUIv9) props
        static member inline subtitle1 (text: string) = createElement (import "Subtitle1" FluentUIv9) [prop.text text]
        static member inline subtitle1 (props: ITextProp list) = createElement (import "Subtitle1" FluentUIv9) props
        static member inline subtitle2 (text: string) = createElement (import "Subtitle2" FluentUIv9) [prop.text text]
        static member inline subtitle2 (props: ITextProp list) = createElement (import "Subtitle2" FluentUIv9) props
        static member inline subtitle2Stronger (text: string) = createElement (import "Subtitle2Stronger" FluentUIv9) [prop.text text]
        static member inline subtitle2Stronger (props: ITextProp list) = createElement (import "Subtitle2Stronger" FluentUIv9) props
        static member inline title1 (text: string) = createElement (import "Title1" FluentUIv9) [prop.text text]
        static member inline title1 (props: ITextProp list) = createElement (import "Title1" FluentUIv9) props
        static member inline title2 (text: string) = createElement (import "Title2" FluentUIv9) [prop.text text]
        static member inline title2 (props: ITextProp list) = createElement (import "Title2" FluentUIv9) props
        static member inline title3 (text: string) = createElement (import "Title3" FluentUIv9) [prop.text text]
        static member inline title3 (props: ITextProp list) = createElement (import "Title3" FluentUIv9) props
