namespace FS.FullCalendar

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

// ----------------------------------------------------- Calendar ----------------------------------------------------------------------
[<Erase>]
type calendar =
    static member inline plugins(value: IPlugin list) =
        Interop.mkProperty<ICalendarProp> "plugins" (value |> Array.ofList)

    /// Whether to include Saturday/Sunday columns in any of the calendar views.
    static member inline weekends(value: bool) =
        Interop.mkProperty<ICalendarProp> "weekends" value

    /// Exclude certain days-of-the-week from being displayed.
    static member inline hiddenDays(value: IDayProp list) =
        Interop.mkProperty<ICalendarProp> "hiddenDays" (value |> List.toSeq)

    /// Whether the day headers should appear. For the Month, TimeGrid, and DayGrid views.
    static member inline dayHeaders(value: bool) =
        Interop.mkProperty<ICalendarProp> "dayHeaders" value

    /// Determines the text that will be displayed on the calendar’s column headings.
    static member inline dayHeaderFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "dayHeaderFormat" (!!value |> createObj |> unbox)

    /// If specified, when the calendar gets narrow enough where day cells can no longer meet their dayMinWidth, horizontal scrollbars will appear.
    static member inline dayMinWidth(value: int) =
        Interop.mkProperty<ICalendarProp> "dayMinWidth" value

    /// The frequency for displaying time slots. default: '00:30:00' (30 minutes)
    static member inline slotDuration(value: string) =
        Interop.mkProperty<ICalendarProp> "slotDuration" value

    /// The frequency that the time slots should be labelled with text.
    static member inline slotLabelInterval(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "slotLabelInterval" (!!value |> createObj |> unbox)

    /// The frequency that the time slots should be labelled with text.
    /// A string in the format hh:mm:ss.sss, hh:mm:sss or hh:mm. For example, '05:00' signifies 5 hours.
    static member inline slotLabelInterval(value: string) =
        Interop.mkProperty<ICalendarProp> "slotLabelInterval" value

    /// The frequency that the time slots should be labelled with text.
    /// A total number of milliseconds
    static member inline slotLabelInterval(value: int) =
        Interop.mkProperty<ICalendarProp> "slotLabelInterval" value

    /// Determines the text that will be displayed within a time slot.
    static member inline slotLabelFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "slotLabelFormat" (!!value |> createObj |> unbox)

    /// Determines the first time slot that will be displayed for each day.
    static member inline slotMinTime(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "slotMinTime" (!!value |> createObj |> unbox)

    /// Determines the first time slot that will be displayed for each day.
    static member inline slotMinTime(value: string) =
        Interop.mkProperty<ICalendarProp> "slotMinTime" value

    /// Determines the last time slot that will be displayed for each day.
    static member inline slotMaxTime(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "slotMaxTime" (!!value |> createObj |> unbox)

    /// Determines the last time slot that will be displayed for each day.
    static member inline slotMaxTime(value: string) =
        Interop.mkProperty<ICalendarProp> "slotMaxTime" value

    /// Determines how far forward the scroll pane is initially scrolled.
    static member inline scrollTime(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "scrollTime" (!!value |> createObj |> unbox)

    /// Determines how far forward the scroll pane is initially scrolled.
    static member inline scrollTime(value: string) =
        Interop.mkProperty<ICalendarProp> "scrollTime" value

    /// Whether the view should scroll to scrollTime every time the date range changes.
    static member inline scrollTimeReset(value: bool) =
        Interop.mkProperty<ICalendarProp> "scrollTimeReset" value

    /// The initial date displayed when the calendar first loads.
    static member inline initialDate(value: DateTime) =
        Interop.mkProperty<ICalendarProp> "initialDate" value

    /// How far into the future/past the calendar navigates when prev/next is executed.
    static member inline dateIncrement(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "dateIncrement" (!!value |> createObj |> unbox)

    /// Determines the first visible day of a custom view.
    static member inline dateAlignmnent(value: string) =
        Interop.mkProperty<ICalendarProp> "dateAlignmnent" value

    /// Determines the first visible day of a custom view.
    static member inline validRange(value: IRangeProp list) =
        Interop.mkProperty<ICalendarProp> "validRange" (!!value |> createObj |> unbox)

    /// Programatically scroll the current view to the given time.
    static member inline scrollToTime(value: IDurationProp list) = //TODO
        Interop.mkProperty<ICalendarProp> "scrollToTime" (!!value |> createObj |> unbox)

    /// Allows a user to highlight multiple days or timeslots by clicking and dragging.
    static member inline selectable(value: bool) =
        Interop.mkProperty<ICalendarProp> "selectable" value

    /// Called after an event has been added to the calendar.
    static member inline eventAdd(value: EventAddData -> unit) =
        Interop.mkProperty<ICalendarProp> "eventAdd" (System.Func<_, _> value)

    /// Called after an event has been modified in some way.
    static member inline eventChange(value: ChangeInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventChange" (System.Func<_, _> value)

    /// Called after an event has been removed from the calendar.
    static member inline eventRemove(value: RemoveInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventRemove" (System.Func<_, _> value)

    /// This is exactly like specifying event as an array except that if the supplied value changes, the calendar will NOT be updated to reflect.
    static member inline initialEvents(value: IEventProp list list) =
        let events = value |> List.map (fun e -> !!e |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "initialEvents" events
    /// This is exactly like specifying event as an array except that if the supplied value changes, the calendar will NOT be updated to reflect.
    static member inline initialEvents(value: 'T list) = Interop.mkProperty<ICalendarProp> "initialEvents" (value |> List.toArray)

    /// An array of Event Objects that will be displayed on the calendar.
    static member inline events(value: IEventProp list list) =
        let events = value |> List.map (fun e -> !!e |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "events" events

    /// An array of Event Objects that will be displayed on the calendar.
    static member inline events(value: 'T list) = Interop.mkProperty<ICalendarProp> "events" (value |> List.toArray)

    /// A URL of a JSON feed that the calendar will fetch Event Objects from.
    static member inline events(value: string) =
        Interop.mkProperty<ICalendarProp> "events" value

    /// A custom function for programmatically generating Events.
    /// function( fetchInfo, successCallback, failureCallback ) { }
    static member inline events
        (handler: IFetchInfoProp list -> (EventInput array -> unit) -> (FS.FullCalendar.Error -> unit) -> unit)
        =
        Interop.mkProperty<ICalendarProp>
            "events"
            (System.Func<_, _, _, _>(fun (value: IFetchInfoProp list) success failure ->
                handler (!!value |> createObj |> unbox) success failure))

    /// A custom function for programmatically generating Events.
    /// function( fetchInfo, successCallback, failureCallback ) { }
    static member inline eventSources
        (handler: IFetchInfoProp list -> (EventInput array -> unit) -> (FS.FullCalendar.Error -> unit) -> unit)
        =
        Interop.mkProperty<ICalendarProp>
            "eventSources"
            (System.Func<_, _, _, _>(fun (value: IFetchInfoProp list) success failure ->
                handler (!!value |> createObj |> unbox) success failure))

    /// A way to specify multiple event sources.
    static member inline eventSources(value: IEventProp list list) =
        let events = value |> List.map (fun e -> !!e |> createObj) |> List.toArray
        Interop.mkProperty<ICalendarProp> "eventSources" events

    /// A way to specify multiple event sources.
    static member inline eventSources(value: string list) =
        Interop.mkProperty<ICalendarProp> "eventSources" (value |> Array.ofList)

    /// Defines the buttons and title at the top of the calendar.
    static member inline headerToolbar(value: IHeaderToolbarProp list) =
        Interop.mkProperty<ICalendarProp> "headerToolbar" (!!value |> createObj |> unbox)

    static member inline googleCalendarApiKey(value: string) =
        Interop.mkProperty<ICalendarProp> "googleCalendarApiKey" value

    static member inline editable(value: bool) =
        Interop.mkProperty<ICalendarProp> "editable" value

    static member inline selectMirror(value: bool) =
        Interop.mkProperty<ICalendarProp> "selectMirror" value

    static member inline dayMaxEvents(value: bool) =
        Interop.mkProperty<ICalendarProp> "dayMaxEvents" value

    static member inline select(value: DateSelectArg -> unit) =
        Interop.mkProperty<ICalendarProp> "select" (System.Func<_, _> value)
    /// Triggered when the user clicks an event.
    static member inline eventClick(value: EventClickArg -> unit) =
        Interop.mkProperty<ICalendarProp> "eventClick" (System.Func<_, _> value)
    /// Triggered when the user mouses over an event. Similar to the native mouseenter.
    static member inline eventMouseEnter(value: MouseInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventMouseEnter" (System.Func<_, _> value)
    /// Triggered when the user mouses out of an event. Similar to the native mouseleave.
    static member inline eventMouseLeave(value: MouseInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventMouseLeave" (System.Func<_, _> value)

    /// Called after event data is initialized OR changed in any way.
    static member inline eventsSet(value: CalendarEvent array -> unit) =
        Interop.mkProperty<ICalendarProp> "eventsSet" (System.Func<_, _> value)

    /// Triggered when dragging stops and the event has moved to a different day/time.
    static member inline eventDrop(value: EventDropInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventDrop" (System.Func<_, _> value)

    /// Triggered when dragging stops and the event has moved to a different day/time.
    static member inline droppable(value: bool) =
        Interop.mkProperty<ICalendarProp> "droppable" value

    /// Called when an external draggable element or an event from another calendar has been dropped onto the calendar.
    static member inline drop(value: DropInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "drop" (System.Func<_,_> value)

    /// Determines the text that will be displayed in the headerToolbar’s title.
    static member inline titleFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "titleFormat" (!!value |> createObj |> unbox)

    /// Determines the text that will be displayed in the headerToolbar’s title.
    /// Must use momentPlugin for this property
    static member inline titleFormat(value: string) =
        Interop.mkProperty<ICalendarProp> "titleFormat" value

    /// Determines the separator text when formatting the date range in the toolbar title.
    static member inline titleRangeSeparator(value: string) =
        Interop.mkProperty<ICalendarProp> "titleRangeSeparator" value

    /// Text that will be displayed on buttons of the headerToolbar/footerToolbar.
    static member inline buttonText(value: IButtonTextProp list) =
        Interop.mkProperty<ICalendarProp> "buttonText" (!!value |> createObj |> unbox)

    /// Icons that will be displayed in buttons of the headerToolbar/footerToolbar.
    static member inline buttonIcons(value: IButtonIconProp list) =
        Interop.mkProperty<ICalendarProp> "buttonIcons" (!!value |> createObj |> unbox)

    /// Sets the height of the entire calendar, including header and footer.
    static member inline height(value: int) =
        Interop.mkProperty<ICalendarProp> "height" value

    /// Sets the height of the entire calendar, including header and footer.
    static member inline height(value: IStyleAttribute) =
        Interop.mkProperty<ICalendarProp> "height" value

    /// Sets the height of the entire calendar, including header and footer.
    static member inline height(value: string) =
        Interop.mkProperty<ICalendarProp> "height" value

    /// Sets the height of the view area of the calendar.
    static member inline contentHeight(value: int) =
        Interop.mkProperty<ICalendarProp> "contentHeight" value

    /// Sets the height of the view area of the calendar.
    static member inline contentHeight(value: IStyleAttribute) =
        Interop.mkProperty<ICalendarProp> "contentHeight" value

    /// Sets the height of the view area of the calendar.
    static member inline contentHeight(value: string) =
        Interop.mkProperty<ICalendarProp> "contentHeight" value

    /// Sets the width-to-height aspect ratio of the calendar.
    static member inline aspectRatio(value: float) =
        Interop.mkProperty<ICalendarProp> "aspectRatio" value

    /// Sets the width-to-height aspect ratio of the calendar.
    static member inline aspectRatio(value: int) =
        Interop.mkProperty<ICalendarProp> "aspectRatio" value

    /// Sets the width-to-height aspect ratio of the calendar.
    static member inline aspectRatio(value: decimal) =
        Interop.mkProperty<ICalendarProp> "aspectRatio" value

    /// If the rows of a given view don’t take up the entire height, they will expand to fit.
    static member inline expandRows(value: bool) =
        Interop.mkProperty<ICalendarProp> "expandRows" value

    /// Whether to automatically resize the calendar when the browser window resizes.
    static member inline handleWindowResize(value: bool) =
        Interop.mkProperty<ICalendarProp> "handleWindowResize" value

    /// The time the calendar will wait to adjust its size after a window resize occurs, in milliseconds.
    static member inline windowResizeDelay(value: int) =
        Interop.mkProperty<ICalendarProp> "windowResizeDelay" value

    /// Whether to fix the date-headers at the top of the calendar to the viewport while scrolling.
    static member inline stickyHeaderDates(value: bool) =
        Interop.mkProperty<ICalendarProp> "stickyHeaderDates" value

    /// Whether to fix the view’s horizontal scrollbar to the bottom of the viewport while scrolling.
    static member inline stickyFooterScrollbar(value: bool) =
        Interop.mkProperty<ICalendarProp> "stickyFooterScrollbar" value

    /// Whether to fix the view’s horizontal scrollbar to the bottom of the viewport while scrolling.
    static member inline windowResize(value: ViewApi -> unit) =
        Interop.mkProperty<ICalendarProp> "windowResize" (System.Func<_, _> value)

    /// In month view, whether dates in the previous or next month should be rendered at all.
    static member inline showNonCurrentDates(value: bool) =
        Interop.mkProperty<ICalendarProp> "showNonCurrentDates" value

    /// In timeGrid view, the minimum height an event is allowed to be.
    static member inline eventMinHeight(value: int) =
        Interop.mkProperty<ICalendarProp> "eventMinHeight" value

    /// In timeGrid view, the height threshold for when an event has a “short” style.
    static member inline eventShortHeight(value: int) =
        Interop.mkProperty<ICalendarProp> "eventShortHeight" value

    /// Determines if timed events in TimeGrid view should visually overlap.
    static member inline slotEventOverlap(value: bool) =
        Interop.mkProperty<ICalendarProp> "slotEventOverlap" value

    /// Determines if the “all-day” slot is displayed at the top of the calendar.
    static member inline allDaySlot(value: bool) =
        Interop.mkProperty<ICalendarProp> "allDaySlot" value

    /// A Date Formatter that affects the text on the left side of the day headings in list view.
    static member inline listDayFormat(value: string) =
        Interop.mkProperty<ICalendarProp> "listDayFormat" value

    /// A Date Formatter that affects the text on the left side of the day headings in list view.
    static member inline listDayFormat(value: bool) =
        Interop.mkProperty<ICalendarProp> "listDayFormat" value

    /// A Date Formatter that affects the text on the right side of the day headings in list view.
    static member inline listDaySideFormat(value: string) =
        Interop.mkProperty<ICalendarProp> "listDaySideFormat" value

    /// A Date Formatter that affects the text on the right side of the day headings in list view.
    static member inline listDaySideFormat(value: bool) =
        Interop.mkProperty<ICalendarProp> "listDaySideFormat" value

    /// A Date Formatter that affects the text on the right side of the day headings in list view.
    static member inline monthStartFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "monthStartFormat" (!!value |> createObj |> unbox)

    /// The maximum columns of months that Multi-Month Grid will attempt to render.
    static member inline multiMonthMaxColumns(value: int) =
        Interop.mkProperty<ICalendarProp> "multiMonthMaxColumns" value

    /// Multi-Month Grid will not allow each mini-month to be become smaller than this pixel value.
    static member inline multiMonthMinWidth(value: int) =
        Interop.mkProperty<ICalendarProp> "multiMonthMinWidth" value

    /// Determines if day names and week names are clickable.
    static member inline navLinks(value: bool) =
        Interop.mkProperty<ICalendarProp> "navLinks" value

    /// Determines what happens upon a day heading nav-link click.
    static member inline navLinkDayClick(value: DateTime -> PointerDragEvent -> unit) =
        Interop.mkProperty<ICalendarProp> "navLinkDayClick" (System.Func<_, _, _> value)

    /// Determines what happens upon a week-number nav-link click.
    static member inline navLinkWeekClick(value: DateTime -> PointerDragEvent -> unit) =
        Interop.mkProperty<ICalendarProp> "navLinkWeekClick" (System.Func<_, _, _> value)

    /// Multi-Month Grid will not allow each mini-month to be become smaller than this pixel value.
    static member inline multiMonthTitleFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "multiMonthTitleFormat" (!!value |> createObj |> unbox)

    /// Determines if week numbers should be displayed on the calendar.
    static member inline weekNumbers(value: bool) =
        Interop.mkProperty<ICalendarProp> "weekNumbers" value

    /// The method for calculating week numbers that are displayed with the weekNumbers setting.
    /// You may also specify a function, which must accept a single Date and return an integer week number.
    static member inline weekNumberCalculation(value: DateTime -> int) =
        Interop.mkProperty<ICalendarProp> "weekNumberCalculation" (System.Func<_, _> value)

    /// The heading text for week numbers. Also affects weeks in date formatting.
    static member inline weekText(value: string) =
        Interop.mkProperty<ICalendarProp> "weekText" value

    /// Like weekText but only used when the date-formatting week setting is set to 'long'.
    static member inline weekTextLong(value: string) =
        Interop.mkProperty<ICalendarProp> "weekTextLong" value

    /// Controls the week number text.
    static member inline weekNumberFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "weekNumberFormat" (!!value |> createObj |> unbox)

    /// Whether clicking elsewhere on the page will cause the current selection to be cleared.
    static member inline unselectAuto(value: bool) =
        Interop.mkProperty<ICalendarProp> "unselectAuto" value

    /// A way to specify elements that will ignore the unselectAuto option.
    static member inline unselectCancel(value: string) =
        Interop.mkProperty<ICalendarProp> "unselectCancel" value

    /// Determines whether the user is allowed to select periods of time that are occupied by events.
    static member inline selectOverlap(value: bool) =
        Interop.mkProperty<ICalendarProp> "selectOverlap" value

    /// Determines whether the user is allowed to select periods of time that are occupied by events.
    static member inline selectOverlap(value: CalendarEvent -> bool) =
        Interop.mkProperty<ICalendarProp> "selectOverlap" (System.Func<_, _> value)

    /// Limits user selection to certain windows of time.
    static member inline selectConstraint(value: string) =
        Interop.mkProperty<ICalendarProp> "selectConstraint" value

    /// Exact programmatic control over where the user can select.
    static member inline selectAllow(value: SelectInfo -> bool) =
        Interop.mkProperty<ICalendarProp> "selectAllow" (System.Func<_, _> value)

    /// The minimum distance the user’s mouse must travel after a mousedown, before a selection is allowed.
    static member inline selectMinDistance(value: int) =
        Interop.mkProperty<ICalendarProp> "selectMinDistance" value

    /// Triggered when the user clicks on a date or a time.
    static member inline dateClick(value: DateClickInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "dateClick" (System.Func<_, _> value)

    /// Triggered when a date/time selection is made
    static member inline select(value: SelectInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "select" (System.Func<_, _> value)

    /// Triggered when the current selection is cleared.
    static member inline unselect(value: UIEvent -> ViewApi -> unit) =
        Interop.mkProperty<ICalendarProp> "unselect" (System.Func<_, _, _> value)

    /// Whether or not to display a marker indicating the current time.
    static member inline nowIndicator(value: bool) =
        Interop.mkProperty<ICalendarProp> "nowIndicator" value

    /// Explicitly sets the “today” date of the calendar. This is the day that is normally highlighted in yellow.
    static member inline now(value: DateTime) =
        Interop.mkProperty<ICalendarProp> "now" value

    /// Emphasizes certain time slots on the calendar. By default, Monday-Friday, 9am-5pm.
    static member inline businessHours(value: bool) =
        Interop.mkProperty<ICalendarProp> "businessHours" value

    /// Emphasizes certain time slots on the calendar. By default, Monday-Friday, 9am-5pm.
    static member inline businessHours(value: IBusinessDayProp list list) =
        let bds = value |> List.map (fun e -> !!e |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "businessHours" bds

    /// A time zone is a region of the world that serves as a context for displaying dates.
    static member inline timezone(value: string) =
        Interop.mkProperty<ICalendarProp> "timezone" value

    static member inline ref(value: IRefValue<FullCalendar option>) =
        Interop.mkProperty<ICalendarProp> "ref" value
    /// A hook for transforming custom data into a standard CalendarEvent object.
    static member inline eventDataTransform(value: 'T) =
        Interop.mkProperty<ICalendarProp> "eventDataTransform" value

    /// Determines the default value for each Event Object’s allDay property when it is unspecified.
    static member inline defaultAllDay(value: bool) =
        Interop.mkProperty<ICalendarProp> "defaultAllDay" value

    /// A fallback duration for all-day Event Objects without a specified end value.
    static member inline defaultAllDayEventDuration(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "defaultAllDayEventDuration" (!!value |> createObj |> unbox)

    /// A fallback duration for timed Event Objects without a specified end value.
    static member inline defaultTimedEventDuration(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "defaultTimedEventDuration" (!!value |> createObj |> unbox)

    /// A flag to force assignment of an event’s end if it is unspecified.
    static member inline forceEventDuration(value: bool) =
        Interop.mkProperty<ICalendarProp> "forceEventDuration" value

    /// A parameter of this name will be sent to each JSON event feed. It describes the start of the interval being fetched.
    static member inline startParam(value: string) =
        Interop.mkProperty<ICalendarProp> "startParam" value
    /// A parameter of this name will be sent to each JSON event feed. It describes the exclusive end of the interval being fetched.
    static member inline endParam(value: string) =
        Interop.mkProperty<ICalendarProp> "endParam" value
    /// A parameter of this name will be sent to each JSON event feed. It describes the timezone of the startParam and endParam values, as well as the desired timezone of the returned events.
    static member inline timeZoneParam(value: string) =
        Interop.mkProperty<ICalendarProp> "timeZoneParam" value
    /// Determines when event fetching should occur.
    static member inline lazyFetching(value: bool) =
        Interop.mkProperty<ICalendarProp> "lazyFetching" value
    /// Triggered when event or resource fetching starts/stops.
    static member inline loading(value: bool -> unit) =
        Interop.mkProperty<ICalendarProp> "loading" (System.Func<_,_> value)

    /// Defines custom buttons that can be used in the headerToolbar/footerToolbar.
    static member inline customButtons(value: (string * ICustomButtonProp list) list) =
        let buttons =
            match value with
            | [] -> {| |} |> unbox
            | buttons ->
                [
                    for (name, styles) in buttons do
                        name, !!styles |> createObj
                ]
                |> createObj
                |> unbox

        Interop.mkProperty<ICalendarProp> "customButtons" buttons

module calendar =    /// The initial view when the calendar loads.
    [<Erase>]
    type initialView =
        static member inline dayGridMonth =
            Interop.mkProperty<ICalendarProp> "initialView" "dayGridMonth"

        static member inline dayGridWeek =
            Interop.mkProperty<ICalendarProp> "initialView" "dayGridWeek"

        static member inline timeGridDay =
            Interop.mkProperty<ICalendarProp> "initialView" "timeGridDay"

        static member inline listWeek = Interop.mkProperty<ICalendarProp> "initialView" "listWeek"

        static member inline multiMonthYear =
            Interop.mkProperty<ICalendarProp> "initialView" "multiMonthYear"

    /// The method for calculating week numbers that are displayed with the weekNumbers setting.
    [<Erase>]
    type weekNumberCalculation =
        /// Specifying "local" causes the locale-specific calculation to be used, as determined by the calendar’s locale setting. This is the default.
        static member inline local =
            Interop.mkProperty<ICalendarProp> "weekNumberCalculation" "local"

        /// Specifiying "ISO" results in ISO8601 week numbers. Specifying "ISO" changes the default value of firstDay to 1 (Monday).
        static member inline ISO = Interop.mkProperty<ICalendarProp> "weekNumberCalculation" "ISO"

    [<Erase>]
    type themeSystem =
        static member inline standard = Interop.mkProperty<ICalendarProp> "themeSystem" "standard"

        /// To use this theme, you must use the Bootstrap5 plugin, as well as add this code to the head of your index.html file.
        /// <code>
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css' rel='stylesheet'>`
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css' rel='stylesheet'>`
        /// </code>
        static member inline bootstrap5 =
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// To use this theme, you must use the Bootstrap plugin, as well as add this code to the head of your index.html file.
        /// <br/>
        /// <code>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.0/dist/css/bootstrap.css' rel='stylesheet'>`
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.1/css/all.css' rel='stylesheet'>`
        /// </code>
        static member inline bootstrap =
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap"

    /// A time zone is a region of the world that serves as a context for displaying dates.
    [<Erase>]
    type timezone =
        static member inline local = Interop.mkProperty<ICalendarProp> "timezone" "local"
        static member inline UTC = Interop.mkProperty<ICalendarProp> "timezone" "UTC"

// ----------------------------------------------------- Event ----------------------------------------------------------------------
[<Erase>]
type event =
    static member inline id(value: string) =
        Interop.mkProperty<IEventProp> "id" value

    static member inline groupId(value: string) =
        Interop.mkProperty<IEventProp> "groupId" value

    static member inline allDay(value: bool) =
        Interop.mkProperty<IEventProp> "allDay" value

    static member inline start(value: System.DateTime) =
        Interop.mkProperty<IEventProp> "start" value

    static member inline end'(value: System.DateTime) =
        Interop.mkProperty<IEventProp> "end" value

    static member inline daysOfWeek (value: IDayProp list) =
        Interop.mkProperty<IEventProp> "daysOfWeek" (value |> List.toArray)

    static member inline startTime (value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "startTime" (!!value |> createObj |> unbox)
    static member inline endTime (value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "endTime" (!!value |> createObj |> unbox)
    static member inline startRecur (value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "startRecur" (!!value |> createObj |> unbox)
    static member inline endRecur (value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "endRecur" (!!value |> createObj |> unbox)
    static member inline interactive (value: bool) =
        Interop.mkProperty<IEventProp> "interactive" value

    static member inline startStr(value: string) =
        Interop.mkProperty<IEventProp> "startStr" value

    static member inline endStr'(value: string) =
        Interop.mkProperty<IEventProp> "endStr" value

    static member inline title(value: string) =
        Interop.mkProperty<IEventProp> "title" value

    static member inline url(value: string) =
        Interop.mkProperty<IEventProp> "url" value

    static member inline classNames(value: string list) =
        Interop.mkProperty<IEventProp> "className" (value |> Array.ofList)
    static member inline className(value: string) =
        Interop.mkProperty<IEventProp> "className" value

    static member inline editable(value: bool) =
        Interop.mkProperty<IEventProp> "editable" value

    static member inline startEditable(value: bool) =
        Interop.mkProperty<IEventProp> "startEditable" value

    static member inline duration(value: string) =
        Interop.mkProperty<IEventProp> "duration" value

    static member inline duration(value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "duration" (!!value |> createObj |> unbox)
    static member inline durationEditable(value: bool) =
        Interop.mkProperty<IEventProp> "durationEditable" value
    static member inline resourceEditable(value: bool) =
        Interop.mkProperty<IEventProp> "resourceEditable" value
    static member inline resourceId(value: string) =
        Interop.mkProperty<IEventProp> "resourceId" value
    static member inline resourceIds(value: string list) =
        Interop.mkProperty<IEventProp> "resourceIds" (value |> List.toArray)

    static member inline overlap(value: bool) =
        Interop.mkProperty<IEventProp> "overlap" value

    static member inline constraint'(value: {| resourceIds: string array |}) =
        Interop.mkProperty<IEventProp> "constraint" value

    static member inline color(value: string) =
        Interop.mkProperty<IEventProp> "color" value
    static member inline backgroundColor(value: string) =
        Interop.mkProperty<IEventProp> "backgroundColor" value

    static member inline borderColor(value: string) =
        Interop.mkProperty<IEventProp> "borderColor" value

    static member inline textColor(value: string) =
        Interop.mkProperty<IEventProp> "textColor" value

    static member inline source(value: 'T) =
        Interop.mkProperty<IEventProp> "source" value //TODO

    static member inline googleCalendarId(value: string) =
        Interop.mkProperty<IEventProp> "googleCalendarId" value
    static member inline extendedProps(value: obj) =
        Interop.mkProperty<IEventProp> "extendedProps" value
    /// Enter false if you do not want an event to be created upon drop. You might want to do this to simply draw an “event mirror” while dragging. true by default.
    static member inline create(value: bool) =
        Interop.mkProperty<IEventProp> "create" value

module event =
    [<Erase>]
    type display =
        static member inline auto = Interop.mkProperty<IEventProp> "display" "auto"
        static member inline block = Interop.mkProperty<IEventProp> "display" "block"
        static member inline listItem = Interop.mkProperty<IEventProp> "display" "list-item"
        static member inline background = Interop.mkProperty<IEventProp> "display" "background"

        static member inline inverseBackground =
            Interop.mkProperty<IEventProp> "display" "inverse-background"

        static member inline none = Interop.mkProperty<IEventProp> "display" "none"
// ----------------------------------------------------- CustomButton ----------------------------------------------------------------------
[<Erase>]
type customButton =
    static member inline text(value: string) =
        Interop.mkProperty<ICustomButtonProp> "text" value

    static member inline hint(value: string) =
        Interop.mkProperty<ICustomButtonProp> "hint" value

    static member inline click(value: MouseEvent -> HTMLElement -> unit) =
        Interop.mkProperty<ICustomButtonProp> "click" (System.Func<_, _, _> value)

    static member inline icon(value: string) =
        Interop.mkProperty<ICustomButtonProp> "icon" value

    static member inline bootstrapFontAwesome(value: string) = //TODO
        Interop.mkProperty<ICustomButtonProp> "bootstrapFontAwesome" value

// ----------------------------------------------------- HeaderToolbar ----------------------------------------------------------------------
[<Erase>]
type headerToolbar =
    static member inline start(value: string) =
        Interop.mkProperty<IHeaderToolbarProp> "start" value

    static member inline center(value: string) =
        Interop.mkProperty<IHeaderToolbarProp> "center" value

    static member inline end'(value: string) =
        Interop.mkProperty<IHeaderToolbarProp> "end" value
// ----------------------------------------------------- FooterToolbar ----------------------------------------------------------------------
[<Erase>]
type footerToolbar =
    static member inline start(value: string) =
        Interop.mkProperty<IFooterToolbarProp> "start" value

    static member inline center(value: string) =
        Interop.mkProperty<IFooterToolbarProp> "center" value

    static member inline end'(value: string) =
        Interop.mkProperty<IFooterToolbarProp> "end" value
// ----------------------------------------------------- DateFormat ----------------------------------------------------------------------
module dateFormat =

    [<Erase>]
    type year =
        static member inline numeric = Interop.mkProperty<IDateFormatProp> "year" "numeric"
        static member inline ``2digit`` = Interop.mkProperty<IDateFormatProp> "year" "2-digit"

    [<Erase>]
    type month =
        static member inline short = Interop.mkProperty<IDateFormatProp> "month" "short"
        static member inline long = Interop.mkProperty<IDateFormatProp> "month" "long"
        static member inline narrow = Interop.mkProperty<IDateFormatProp> "month" "narrow"
        static member inline numeric = Interop.mkProperty<IDateFormatProp> "month" "numeric"
        static member inline ``2digit`` = Interop.mkProperty<IDateFormatProp> "month" "2-digit"

    [<Erase>]
    type day =
        static member inline numeric = Interop.mkProperty<IDateFormatProp> "day" "numeric"
        static member inline ``2digit`` = Interop.mkProperty<IDateFormatProp> "day" "2-digit"

    [<Erase>]
    type weekday =
        static member inline long = Interop.mkProperty<IDateFormatProp> "weekday" "long"
        static member inline short = Interop.mkProperty<IDateFormatProp> "weekday" "short"
        static member inline narrow = Interop.mkProperty<IDateFormatProp> "weekday" "narrow"

    [<Erase>]
    type hour =
        static member inline numberic = Interop.mkProperty<IDateFormatProp> "hour" "numberic"
        static member inline ``2digit`` = Interop.mkProperty<IDateFormatProp> "hour" "2-digit"

    [<Erase>]
    type minute =
        static member inline numberic = Interop.mkProperty<IDateFormatProp> "minute" "numberic"
        static member inline ``2digit`` = Interop.mkProperty<IDateFormatProp> "minute" "2-digit"

    [<Erase>]
    type second =
        static member inline numberic = Interop.mkProperty<IDateFormatProp> "second" "numberic"
        static member inline ``2digit`` = Interop.mkProperty<IDateFormatProp> "second" "2-digit"

    [<Erase>]
    type hour12 =
        static member inline true' = Interop.mkProperty<IDateFormatProp> "hour12" "numberic"
        static member inline false' = Interop.mkProperty<IDateFormatProp> "hour12" "false"

    [<Erase>]
    type timeZoneName =
        static member inline short = Interop.mkProperty<IDateFormatProp> "timeZoneName" "short"

    /// This flag cannot be combined with any other flags!
    [<Erase>]
    type week =
        static member inline long = Interop.mkProperty<IDateFormatProp> "week" "long"
        static member inline short = Interop.mkProperty<IDateFormatProp> "week" "short"
        static member inline narrow = Interop.mkProperty<IDateFormatProp> "week" "narrow"
        static member inline numeric = Interop.mkProperty<IDateFormatProp> "week" "numeric"

    [<Erase>]
    type meridiem =
        static member inline lowercase = Interop.mkProperty<IDateFormatProp> "meridiem" "lowercase"
        static member inline short = Interop.mkProperty<IDateFormatProp> "meridiem" "short"
        static member inline narrow = Interop.mkProperty<IDateFormatProp> "meridiem" "narrow"
        static member inline false' = Interop.mkProperty<IDateFormatProp> "meridiem" "false"

    [<Erase>]
    type omitZeroMinute =
        static member inline true' = Interop.mkProperty<IDateFormatProp> "omitZeroMinute" "true"

    [<Erase>]
    type omitCommas =
        static member inline true' = Interop.mkProperty<IDateFormatProp> "omitCommas" "true"

// ----------------------------------------------------- ButtonText ----------------------------------------------------------------------
[<Erase>]
type buttonText =
    static member inline today(value: string) =
        Interop.mkProperty<IButtonTextProp> "today" value

    static member inline month(value: string) =
        Interop.mkProperty<IButtonTextProp> "month" value

    static member inline week(value: string) =
        Interop.mkProperty<IButtonTextProp> "week" value

    static member inline day(value: string) =
        Interop.mkProperty<IButtonTextProp> "day" value

    static member inline year(value: string) =
        Interop.mkProperty<IButtonTextProp> "year" value

// ----------------------------------------------------- Day ----------------------------------------------------------------------
[<Erase>]
type day =
    static member inline sunday = 0 |> unbox<IDayProp>
    static member inline monday = 1 |> unbox<IDayProp>
    static member inline tuesday = 2 |> unbox<IDayProp>
    static member inline wednesday = 3 |> unbox<IDayProp>
    static member inline thursday = 4 |> unbox<IDayProp>
    static member inline friday = 5 |> unbox<IDayProp>
    static member inline saturday = 6 |> unbox<IDayProp>

// ----------------------------------------------------- ButtonIcon ----------------------------------------------------------------------
[<Erase>]
type buttonIcon =
    static member inline prev(value: string) =
        Interop.mkProperty<IButtonIconProp> "prev" value

    static member inline next(value: string) =
        Interop.mkProperty<IButtonIconProp> "next" value

    static member inline prevYear(value: string) =
        Interop.mkProperty<IButtonIconProp> "prevYear" value

    static member inline nextYear(value: string) =
        Interop.mkProperty<IButtonIconProp> "nextYear" value

// ----------------------------------------------------- Duration ----------------------------------------------------------------------
[<Erase>]
type duration =
    static member inline year(value: int) =
        Interop.mkProperty<IDurationProp> "year" value

    static member inline years(value: int) =
        Interop.mkProperty<IDurationProp> "years" value

    static member inline month(value: int) =
        Interop.mkProperty<IDurationProp> "month" value

    static member inline months(value: int) =
        Interop.mkProperty<IDurationProp> "months" value

    static member inline day(value: int) =
        Interop.mkProperty<IDurationProp> "day" value

    static member inline days(value: int) =
        Interop.mkProperty<IDurationProp> "days" value

    static member inline hour(value: int) =
        Interop.mkProperty<IDurationProp> "hour" value

    static member inline hours(value: int) =
        Interop.mkProperty<IDurationProp> "hours" value

    static member inline minute(value: int) =
        Interop.mkProperty<IDurationProp> "minute" value

    static member inline minutes(value: int) =
        Interop.mkProperty<IDurationProp> "minutes" value

    static member inline second(value: int) =
        Interop.mkProperty<IDurationProp> "second" value

    static member inline seconds(value: int) =
        Interop.mkProperty<IDurationProp> "seconds" value

    static member inline millisecond(value: int) =
        Interop.mkProperty<IDurationProp> "millisecond" value

    static member inline milliseconds(value: int) =
        Interop.mkProperty<IDurationProp> "milliseconds" value

    static member inline ms(value: int) =
        Interop.mkProperty<IDurationProp> "ms" value

// ----------------------------------------------------- Range ----------------------------------------------------------------------
[<Erase>]
type range =
    static member inline start(value: DateTime) =
        Interop.mkProperty<IRangeProp> "start" value

    static member inline start(value: string) =
        Interop.mkProperty<IRangeProp> "start" value

    static member inline end'(value: DateTime) =
        Interop.mkProperty<IRangeProp> "end" value

    static member inline end'(value: string) =
        Interop.mkProperty<IRangeProp> "end" value

// ----------------------------------------------------- BusinessDay ----------------------------------------------------------------------
[<Erase>]
type businessDay =
    static member inline start(value: string) =
        Interop.mkProperty<IBusinessDayProp> "start" value

    static member inline end'(value: string) =
        Interop.mkProperty<IBusinessDayProp> "end" value

    static member inline daysOfWeek(value: IDayProp list) =
        Interop.mkProperty<IBusinessDayProp> "daysOfWeek" (value |> List.toArray)

// ----------------------------------------------------- FetchInfo ----------------------------------------------------------------------
[<Erase>]
type fetchInfo =
    static member inline start(value: DateTime) =
        Interop.mkProperty<IFetchInfoProp> "start" value

    static member inline end'(value: DateTime) =
        Interop.mkProperty<IFetchInfoProp> "end" value

    static member inline startStr(value: string) =
        Interop.mkProperty<IFetchInfoProp> "startStr" value

    static member inline endStr(value: string) =
        Interop.mkProperty<IFetchInfoProp> "endStr" value

    static member inline timeZone(value: string) =
        Interop.mkProperty<IFetchInfoProp> "timeZone" value

// ----------------------------------------------------- Draggable ----------------------------------------------------------------------
[<Erase>]
type draggable =
    /// A CSS selector that matches draggable elements within a container element.
    static member inline itemSelector(value: string) =
        Interop.mkProperty<IDraggableProp> "itemSelector" value
    /// An object or a function that returns an object. Exact properties explained below.
    static member inline eventData (handler: HTMLElement -> IEventProp list) =
        Interop.mkProperty<IDraggableProp> "eventData" (fun value -> !!(handler value) |> createObj |> unbox)
    /// An object or a function that returns an object. Exact properties explained below.
    static member inline eventData (value: IEventProp list) =
        Interop.mkProperty<IDraggableProp> "eventData" (!!value |> createObj |> unbox)
    /// For touch devices, the amount of time the user must hold down before an event becomes draggable.
    static member inline longPressDelay (value: int) =
        Interop.mkProperty<IDraggableProp> "longPressDelay" value
    /// How many pixels the user’s mouse/touch must move before an event drag activates.
    static member inline minDistance (value: int) =
        Interop.mkProperty<IDraggableProp> "minDistance" value
    /// An HTML element that will be the parent of the “mirror” element that follows the mouse while dragging. Defaults to the <body>.
    static member inline appendTo (value: int) =
        Interop.mkProperty<IDraggableProp> "appendTo" value
