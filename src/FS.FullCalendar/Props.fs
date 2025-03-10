namespace FS.FullCalendar

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

// ----------------------------------------------------- FullCalendar ----------------------------------------------------------------------
[<Erase>]
type fullCalendar =
    static member inline plugins(value: IPlugin list) =
        Interop.mkProperty<IFullCalendarProp> "plugins" (value |> Array.ofList)

    /// Whether to include Saturday/Sunday columns in any of the calendar views.
    static member inline weekends(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "weekends" value
    /// Exclude certain days-of-the-week from being displayed.
    static member inline hiddenDays(value: IDayProp list) =
        Interop.mkProperty<IFullCalendarProp> "hiddenDays" (value |> List.toSeq)
    /// Whether the day headers should appear. For the Month, TimeGrid, and DayGrid views.
    static member inline dayHeaders(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "dayHeaders" value
    /// Determines the text that will be displayed on the calendar’s column headings.
    static member inline dayHeaderFormat(value: IDateFormatProp list) =
        Interop.mkProperty<IFullCalendarProp> "dayHeaderFormat" (!!value |> createObj |> unbox)
    /// If specified, when the calendar gets narrow enough where day cells can no longer meet their dayMinWidth, horizontal scrollbars will appear.
    static member inline dayMinWidth(value: int) =
        Interop.mkProperty<IFullCalendarProp> "dayMinWidth" value
    /// The frequency for displaying time slots. default: '00:30:00' (30 minutes)
    static member inline slotDuration(value: string) =
        Interop.mkProperty<IFullCalendarProp> "slotDuration" value
    /// The frequency that the time slots should be labelled with text.
    static member inline slotLabelInterval(value: IDurationProp list) =
        Interop.mkProperty<IFullCalendarProp> "slotLabelInterval" (!!value |> createObj |> unbox)
    /// The frequency that the time slots should be labelled with text.
    /// A string in the format hh:mm:ss.sss, hh:mm:sss or hh:mm. For example, '05:00' signifies 5 hours.
    static member inline slotLabelInterval(value: string) =
        Interop.mkProperty<IFullCalendarProp> "slotLabelInterval" value
    /// The frequency that the time slots should be labelled with text.
    /// A total number of milliseconds
    static member inline slotLabelInterval(value: int) =
        Interop.mkProperty<IFullCalendarProp> "slotLabelInterval" value
    /// Determines the text that will be displayed within a time slot.
    static member inline slotLabelFormat(value: IDateFormatProp list) =
        Interop.mkProperty<IFullCalendarProp> "slotLabelFormat" (!!value |> createObj |> unbox)
    /// Determines the first time slot that will be displayed for each day.
    static member inline slotMinTime(value: IDurationProp list) =
        Interop.mkProperty<IFullCalendarProp> "slotMinTime" (!!value |> createObj |> unbox)
    /// Determines the first time slot that will be displayed for each day.
    static member inline slotMinTime(value: string) =
        Interop.mkProperty<IFullCalendarProp> "slotMinTime" value
    /// Determines the last time slot that will be displayed for each day.
    static member inline slotMaxTime (value: IDurationProp list) =
        Interop.mkProperty<IFullCalendarProp> "slotMaxTime" (!!value |> createObj |> unbox)
    /// Determines the last time slot that will be displayed for each day.
    static member inline slotMaxTime (value: string) =
        Interop.mkProperty<IFullCalendarProp> "slotMaxTime" value
    /// Determines how far forward the scroll pane is initially scrolled.
    static member inline scrollTime (value: IDurationProp list) =
        Interop.mkProperty<IFullCalendarProp> "scrollTime" (!!value |> createObj |> unbox)
    /// Determines how far forward the scroll pane is initially scrolled.
    static member inline scrollTime (value: string) =
        Interop.mkProperty<IFullCalendarProp> "scrollTime" value
    /// Whether the view should scroll to scrollTime every time the date range changes.
    static member inline scrollTimeReset (value: bool) =
        Interop.mkProperty<IFullCalendarProp> "scrollTimeReset" value
    /// The initial date displayed when the calendar first loads.
    static member inline initialDate (value: DateTime) =
        Interop.mkProperty<IFullCalendarProp> "initialDate" value
    /// The initial date displayed when the calendar first loads.
    static member inline initialDate (value: string) =
        Interop.mkProperty<IFullCalendarProp> "initialDate" value
    /// How far into the future/past the calendar navigates when prev/next is executed.
    static member inline dateIncrement (value: IDurationProp list) =
        Interop.mkProperty<IFullCalendarProp> "dateIncrement" (!!value |> createObj |> unbox)
    /// Determines the first visible day of a custom view.
    static member inline dateAlignmnent (value: string) =
        Interop.mkProperty<IFullCalendarProp> "dateAlignmnent" value
    /// Determines the first visible day of a custom view.
    static member inline validRange (value: IRangeProp list) =
        Interop.mkProperty<IFullCalendarProp> "validRange" (!!value |> createObj |> unbox)
    /// Programatically scroll the current view to the given time.
    static member inline scrollToTime (value: IDurationProp list) = //TODO
        Interop.mkProperty<IFullCalendarProp> "scrollToTime" (!!value |> createObj |> unbox)

    /// Allows a user to highlight multiple days or timeslots by clicking and dragging.
    static member inline selectable(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "selectable" value

    /// Called after an event has been added to the calendar.
    static member inline eventAdd(value: EventAddData -> unit) =
        Interop.mkProperty<IFullCalendarProp> "eventAdd" (System.Func<_, _> value)

    /// Called after an event has been modified in some way.
    static member inline eventChange (value: ChangeInfo -> unit) =
        Interop.mkProperty<IFullCalendarProp> "eventChange" (System.Func<_, _> value)

    /// Called after an event has been removed from the calendar.
    static member inline eventRemove (value: RemoveInfo -> unit) =
        Interop.mkProperty<IFullCalendarProp> "eventRemove" (System.Func<_, _> value)

    /// This is exactly like specifying event as an array except that if the supplied value changes, the calendar will NOT be updated to reflect.
    static member inline initialEvents(value: IEventProp list list) =
        let events = value |> List.map (fun e -> !!e |> createObj) |> List.toArray

        Interop.mkProperty<IFullCalendarProp> "initialEvents" events

    /// Defines the buttons and title at the top of the calendar.
    static member inline headerToolbar(value: IHeaderToolbarProp list) =
        Interop.mkProperty<IFullCalendarProp> "headerToolbar" (!!value |> createObj |> unbox)

    static member inline editable(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "editable" value

    static member inline selectMirror(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "selectMirror" value

    static member inline dayMaxEvents(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "dayMaxEvents" value

    static member inline select(value: DateSelectArg -> unit) =
        Interop.mkProperty<IFullCalendarProp> "select" (System.Func<_, _> value)

    static member inline eventClick(value: EventClickArg -> unit) =
        Interop.mkProperty<IFullCalendarProp> "eventClick" (System.Func<_, _> value)
    /// Called after event data is initialized OR changed in any way.
    static member inline eventsSet(value: CalendarEvent array -> unit) =
        Interop.mkProperty<IFullCalendarProp> "eventsSet" (System.Func<_, _> value)
    /// Triggered when dragging stops and the event has moved to a different day/time.
    static member inline eventDrop(value: EventDropInfo -> unit) =
        Interop.mkProperty<IFullCalendarProp> "eventDrop" (System.Func<_, _> value)

    /// Determines the text that will be displayed in the headerToolbar’s title.
    static member inline titleFormat(value: IDateFormatProp list) =
        Interop.mkProperty<IFullCalendarProp> "titleFormat" (!!value |> createObj |> unbox)
    /// Determines the text that will be displayed in the headerToolbar’s title.
    /// Must use momentPlugin for this property
    static member inline titleFormat(value: string) =
        Interop.mkProperty<IFullCalendarProp> "titleFormat" value

    /// Determines the separator text when formatting the date range in the toolbar title.
    static member inline titleRangeSeparator(value: string) =
        Interop.mkProperty<IFullCalendarProp> "titleRangeSeparator" value

    /// Text that will be displayed on buttons of the headerToolbar/footerToolbar.
    static member inline buttonText(value: IButtonTextProp list) =
        Interop.mkProperty<IFullCalendarProp> "buttonText" (!!value |> createObj |> unbox)

    /// Icons that will be displayed in buttons of the headerToolbar/footerToolbar.
    static member inline buttonIcons(value: IButtonIconProp list) =
        Interop.mkProperty<IFullCalendarProp> "buttonIcons" (!!value |> createObj |> unbox)

    /// Sets the height of the entire calendar, including header and footer.
    static member inline height(value: int) =
        Interop.mkProperty<IFullCalendarProp> "height" value

    /// Sets the height of the entire calendar, including header and footer.
    static member inline height(value: IStyleAttribute) =
        Interop.mkProperty<IFullCalendarProp> "height" value

    /// Sets the height of the entire calendar, including header and footer.
    static member inline height(value: string) =
        Interop.mkProperty<IFullCalendarProp> "height" value

    /// Sets the height of the view area of the calendar.
    static member inline contentHeight(value: int) =
        Interop.mkProperty<IFullCalendarProp> "contentHeight" value

    /// Sets the height of the view area of the calendar.
    static member inline contentHeight(value: IStyleAttribute) =
        Interop.mkProperty<IFullCalendarProp> "contentHeight" value

    /// Sets the height of the view area of the calendar.
    static member inline contentHeight(value: string) =
        Interop.mkProperty<IFullCalendarProp> "contentHeight" value

    /// Sets the width-to-height aspect ratio of the calendar.
    static member inline aspectRatio(value: float) =
        Interop.mkProperty<IFullCalendarProp> "aspectRatio" value

    /// Sets the width-to-height aspect ratio of the calendar.
    static member inline aspectRatio(value: int) =
        Interop.mkProperty<IFullCalendarProp> "aspectRatio" value

    /// Sets the width-to-height aspect ratio of the calendar.
    static member inline aspectRatio(value: decimal) =
        Interop.mkProperty<IFullCalendarProp> "aspectRatio" value

    /// If the rows of a given view don’t take up the entire height, they will expand to fit.
    static member inline expandRows(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "expandRows" value

    /// Whether to automatically resize the calendar when the browser window resizes.
    static member inline handleWindowResize(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "handleWindowResize" value

    /// The time the calendar will wait to adjust its size after a window resize occurs, in milliseconds.
    static member inline windowResizeDelay(value: int) =
        Interop.mkProperty<IFullCalendarProp> "windowResizeDelay" value

    /// Whether to fix the date-headers at the top of the calendar to the viewport while scrolling.
    static member inline stickyHeaderDates(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "stickyHeaderDates" value

    /// Whether to fix the view’s horizontal scrollbar to the bottom of the viewport while scrolling.
    static member inline stickyFooterScrollbar(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "stickyFooterScrollbar" value

    /// Whether to fix the view’s horizontal scrollbar to the bottom of the viewport while scrolling.
    static member inline windowResize(value: ViewApi -> unit) =
        Interop.mkProperty<IFullCalendarProp> "windowResize" (System.Func<_, _> value)

    /// In month view, whether dates in the previous or next month should be rendered at all.
    static member inline showNonCurrentDates(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "showNonCurrentDates" value

    /// In timeGrid view, the minimum height an event is allowed to be.
    static member inline eventMinHeight(value: int) =
        Interop.mkProperty<IFullCalendarProp> "eventMinHeight" value

    /// In timeGrid view, the height threshold for when an event has a “short” style.
    static member inline eventShortHeight(value: int) =
        Interop.mkProperty<IFullCalendarProp> "eventShortHeight" value

    /// Determines if timed events in TimeGrid view should visually overlap.
    static member inline slotEventOverlap(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "slotEventOverlap" value

    /// Determines if the “all-day” slot is displayed at the top of the calendar.
    static member inline allDaySlot(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "allDaySlot" value

    /// A Date Formatter that affects the text on the left side of the day headings in list view.
    static member inline listDayFormat(value: string) =
        Interop.mkProperty<IFullCalendarProp> "listDayFormat" value

    /// A Date Formatter that affects the text on the left side of the day headings in list view.
    static member inline listDayFormat(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "listDayFormat" value

    /// A Date Formatter that affects the text on the right side of the day headings in list view.
    static member inline listDaySideFormat(value: string) =
        Interop.mkProperty<IFullCalendarProp> "listDaySideFormat" value

    /// A Date Formatter that affects the text on the right side of the day headings in list view.
    static member inline listDaySideFormat(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "listDaySideFormat" value

    /// A Date Formatter that affects the text on the right side of the day headings in list view.
    static member inline monthStartFormat(value: IDateFormatProp list) =
        Interop.mkProperty<IFullCalendarProp> "monthStartFormat" (!!value |> createObj |> unbox)

    /// The maximum columns of months that Multi-Month Grid will attempt to render.
    static member inline multiMonthMaxColumns(value: int) =
        Interop.mkProperty<IFullCalendarProp> "multiMonthMaxColumns" value

    /// Multi-Month Grid will not allow each mini-month to be become smaller than this pixel value.
    static member inline multiMonthMinWidth(value: int) =
        Interop.mkProperty<IFullCalendarProp> "multiMonthMinWidth" value
    /// Determines if day names and week names are clickable.
    static member inline navLinks(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "navLinks" value
    /// Determines what happens upon a day heading nav-link click.
    static member inline navLinkDayClick(value: DateTime -> PointerDragEvent -> unit) =
        Interop.mkProperty<IFullCalendarProp> "navLinkDayClick" (System.Func<_,_,_> value)
    /// Determines what happens upon a week-number nav-link click.
    static member inline navLinkWeekClick(value: DateTime -> PointerDragEvent -> unit) =
        Interop.mkProperty<IFullCalendarProp> "navLinkWeekClick" (System.Func<_,_,_> value)

    /// Multi-Month Grid will not allow each mini-month to be become smaller than this pixel value.
    static member inline multiMonthTitleFormat(value: IDateFormatProp list) =
        Interop.mkProperty<IFullCalendarProp> "multiMonthTitleFormat" (!!value |> createObj |> unbox)
    /// Determines if week numbers should be displayed on the calendar.
    static member inline weekNumbers(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "weekNumbers" value
    /// The method for calculating week numbers that are displayed with the weekNumbers setting.
    /// You may also specify a function, which must accept a single Date and return an integer week number.
    static member inline weekNumberCalculation(value: DateTime -> int) =
        Interop.mkProperty<IFullCalendarProp> "weekNumberCalculation" (System.Func<_,_> value)
    /// The heading text for week numbers. Also affects weeks in date formatting.
    static member inline weekText(value: string) =
        Interop.mkProperty<IFullCalendarProp> "weekText" value
    /// Like weekText but only used when the date-formatting week setting is set to 'long'.
    static member inline weekTextLong(value: string) =
        Interop.mkProperty<IFullCalendarProp> "weekTextLong" value
    /// Controls the week number text.
    static member inline weekNumberFormat(value: IDateFormatProp list) =
        Interop.mkProperty<IFullCalendarProp> "weekNumberFormat" (!!value |> createObj |> unbox)
    /// Whether clicking elsewhere on the page will cause the current selection to be cleared.
    static member inline unselectAuto(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "unselectAuto" value
    /// A way to specify elements that will ignore the unselectAuto option.
    static member inline unselectCancel(value: string) =
        Interop.mkProperty<IFullCalendarProp> "unselectCancel" value
    /// Determines whether the user is allowed to select periods of time that are occupied by events.
    static member inline selectOverlap(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "selectOverlap" value
    /// Determines whether the user is allowed to select periods of time that are occupied by events.
    static member inline selectOverlap(value: CalendarEvent -> bool) =
        Interop.mkProperty<IFullCalendarProp> "selectOverlap" (System.Func<_,_> value)
    /// Limits user selection to certain windows of time.
    static member inline selectConstraint(value: string) =
        Interop.mkProperty<IFullCalendarProp> "selectConstraint" value
    /// Exact programmatic control over where the user can select.
    static member inline selectAllow(value: SelectInfo -> bool) =
        Interop.mkProperty<IFullCalendarProp> "selectAllow" (System.Func<_,_> value)
    /// The minimum distance the user’s mouse must travel after a mousedown, before a selection is allowed.
    static member inline selectMinDistance(value: int) =
        Interop.mkProperty<IFullCalendarProp> "selectMinDistance" value
    /// Triggered when the user clicks on a date or a time.
    static member inline dateClick(value: DateClickInfo -> unit) =
        Interop.mkProperty<IFullCalendarProp> "dateClick" (System.Func<_,_> value)
    /// Triggered when a date/time selection is made
    static member inline select(value: SelectInfo -> unit) =
        Interop.mkProperty<IFullCalendarProp> "select" (System.Func<_,_> value)
    /// Triggered when the current selection is cleared.
    static member inline unselect(value: UIEvent -> ViewApi -> unit) =
        Interop.mkProperty<IFullCalendarProp> "unselect" (System.Func<_,_,_> value)
    /// Whether or not to display a marker indicating the current time.
    static member inline nowIndicator(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "nowIndicator" value
    /// Explicitly sets the “today” date of the calendar. This is the day that is normally highlighted in yellow.
    static member inline now(value: DateTime) =
        Interop.mkProperty<IFullCalendarProp> "now" value
    /// Emphasizes certain time slots on the calendar. By default, Monday-Friday, 9am-5pm.
    static member inline businessHours(value: bool) =
        Interop.mkProperty<IFullCalendarProp> "businessHours" value
    /// Emphasizes certain time slots on the calendar. By default, Monday-Friday, 9am-5pm.
    static member inline businessHours(value: IBusinessDayProp list list) =
        let bds = value |> List.map (fun e -> !!e |> createObj) |> List.toArray

        Interop.mkProperty<IFullCalendarProp> "businessHours" bds

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

        Interop.mkProperty<IFullCalendarProp> "customButtons" buttons

module fullCalendar =
    /// The initial view when the calendar loads.
    [<Erase>]
    type initialView =
        static member inline dayGridMonth =
            Interop.mkProperty<IFullCalendarProp> "initialView" "dayGridMonth"

        static member inline dayGridWeek =
            Interop.mkProperty<IFullCalendarProp> "initialView" "dayGridWeek"

        static member inline timeGridDay =
            Interop.mkProperty<IFullCalendarProp> "initialView" "timeGridDay"

        static member inline listWeek = Interop.mkProperty<IFullCalendarProp> "initialView" "listWeek"

        static member inline multiMonthYear =
            Interop.mkProperty<IFullCalendarProp> "initialView" "multiMonthYear"
    /// The method for calculating week numbers that are displayed with the weekNumbers setting.
    [<Erase>]
    type weekNumberCalculation =
        /// Specifying "local" causes the locale-specific calculation to be used, as determined by the calendar’s locale setting. This is the default.
        static member inline local =
            Interop.mkProperty<IFullCalendarProp> "weekNumberCalculation" "local"
        /// Specifiying "ISO" results in ISO8601 week numbers. Specifying "ISO" changes the default value of firstDay to 1 (Monday).
        static member inline ISO =
            Interop.mkProperty<IFullCalendarProp> "weekNumberCalculation" "ISO"
    [<Erase>]
    type themeSystem =
        static member inline standard = Interop.mkProperty<IFullCalendarProp> "themeSystem" "standard"

        /// To use this theme, you must use the Bootstrap5 plugin, as well as add this code to the head of your index.html file.
        /// <code>
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css' rel='stylesheet'>`
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css' rel='stylesheet'>`
        /// </code>
        static member inline bootstrap5 =
            Interop.mkProperty<IFullCalendarProp> "themeSystem" "bootstrap5"

        /// To use this theme, you must use the Bootstrap plugin, as well as add this code to the head of your index.html file.
        /// <br/>
        /// <code>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.0/dist/css/bootstrap.css' rel='stylesheet'>`
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.1/css/all.css' rel='stylesheet'>`
        /// </code>
        static member inline bootstrap =
            Interop.mkProperty<IFullCalendarProp> "themeSystem" "bootstrap"

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

    static member inline startStr(value: string) =
        Interop.mkProperty<IEventProp> "startStr" value

    static member inline endStr'(value: string) =
        Interop.mkProperty<IEventProp> "endStr" value

    static member inline title(value: string) =
        Interop.mkProperty<IEventProp> "title" value

    static member inline url(value: string) =
        Interop.mkProperty<IEventProp> "url" value

    static member inline className(value: string list) =
        Interop.mkProperty<IEventProp> "className" (value |> Array.ofList)

    static member inline editable(value: bool) =
        Interop.mkProperty<IEventProp> "editable" value

    static member inline startEditable(value: bool) =
        Interop.mkProperty<IEventProp> "startEditable" value

    static member inline durationEditable(value: bool) =
        Interop.mkProperty<IEventProp> "durationEditable" value

    static member inline overlap(value: bool) =
        Interop.mkProperty<IEventProp> "overlap" value

    static member inline constraint'(value: {| resourceIds: string array |}) =
        Interop.mkProperty<IEventProp> "constraint" value

    static member inline backgroundColor(value: string) =
        Interop.mkProperty<IEventProp> "backgroundColor" value

    static member inline borderColor(value: string) =
        Interop.mkProperty<IEventProp> "borderColor" value

    static member inline textColor(value: string) =
        Interop.mkProperty<IEventProp> "textColor" value

    static member inline source(value: 'T) =
        Interop.mkProperty<IEventProp> "source" value //TODO

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
        static member inline numberic = Interop.mkProperty<IDateFormatProp> "day" "numberic"
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

    type [<Erase>] omitZeroMinute =
        static member inline true' = Interop.mkProperty<IDateFormatProp> "omitZeroMinute" "true"

    type [<Erase>] omitCommas =
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
    static member inline daysOfWeek (value: IDayProp list) =
        Interop.mkProperty<IBusinessDayProp> "daysOfWeek" (value |> List.toArray)
