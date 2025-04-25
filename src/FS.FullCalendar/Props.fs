namespace FS.FullCalendar

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

// Forcing a function to run in TestGrounds so that the XML documentation gets generated in Props
module Force =
    let toRun = printfn "ran"

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
    static member inline dateAlignment(value: string) =
        Interop.mkProperty<ICalendarProp> "dateAlignment" value

    /// Determines the first visible day of a custom view.
    static member inline validRange(value: IRangeProp list) =
        Interop.mkProperty<ICalendarProp> "validRange" (!!value |> createObj |> unbox)

    /// Programatically scroll the current view to the given time.
    static member inline scrollToTime(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "scrollToTime" (!!value |> createObj |> unbox)

    /// Programatically scroll the current view to the given time.
    static member inline scrollToTime(value: string) =
        Interop.mkProperty<ICalendarProp> "scrollToTime" value

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
    static member inline initialEvents(value: 'T list) =
        Interop.mkProperty<ICalendarProp> "initialEvents" (value |> List.toArray)

    /// An array of Event Objects that will be displayed on the calendar.
    static member inline events(value: IEventProp list list) =
        let events = value |> List.map (fun e -> !!e |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "events" events

    /// An array of Event Objects that will be displayed on the calendar.
    static member inline events(value: 'T list) =
        Interop.mkProperty<ICalendarProp> "events" (value |> List.toArray)

    /// A URL of a JSON feed that the calendar will fetch Event Objects from.
    static member inline events(value: string) =
        Interop.mkProperty<ICalendarProp> "events" value

    /// A custom function for programmatically generating Events.
    /// function( fetchInfo, successCallback, failureCallback ) { }
    static member inline events(value: FetchInfo -> (EventInput array -> unit) -> (CalendarError -> unit) -> unit) =
        Interop.mkProperty<ICalendarProp> "events" (System.Func<_, _, _, _> value)

    /// A way to specify multiple event sources.
    static member inline eventSources(value: IEventProp list list) =
        let events = value |> List.map (fun e -> !!e |> createObj) |> List.toArray
        Interop.mkProperty<ICalendarProp> "eventSources" events

    /// A way to specify multiple event sources.
    static member inline eventSources(value: string list) =
        Interop.mkProperty<ICalendarProp> "eventSources" (value |> Array.ofList)

    /// A function that gets called when fetching succeeds. It can transform the response. Gets called for any type of Event source.
    static member inline eventSourceSuccess(value: EventImpl -> Response -> EventInput array) =
        Interop.mkProperty<ICalendarProp> "eventSourceSuccess" (System.Func<_, _, _> value)

    /// Called when any of the event sources fails. Probably because an AJAX request failed.
    static member inline eventSourceFailure(value: CalendarError -> unit) =
        Interop.mkProperty<ICalendarProp> "eventSourceFailure" (System.Func<_, _> value)

    /// Defines the buttons and title at the top of the calendar.
    static member inline headerToolbar(value: IHeaderToolbarProp list) =
        Interop.mkProperty<ICalendarProp> "headerToolbar" (!!value |> createObj |> unbox)

    /// Defines the controls at the bottom of the calendar.
    static member inline footerToolbar(value: IFooterToolbarProp list) =
        Interop.mkProperty<ICalendarProp> "footerToolbar" (!!value |> createObj |> unbox)

    static member inline googleCalendarApiKey(value: string) =
        Interop.mkProperty<ICalendarProp> "googleCalendarApiKey" value

    /// Determines whether the events on the calendar can be modified.
    static member inline editable(value: bool) =
        Interop.mkProperty<ICalendarProp> "editable" value

    /// Allow events’ start times to be editable through dragging.
    static member inline eventStartEditable(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventStartEditable" value

    /// Whether the user can resize an event from its starting edge.
    static member inline eventResizableFromStart(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventResizableFromStart" value

    /// Allow events’ durations to be editable through resizing.
    static member inline eventDurationEditable(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventDurationEditable" value

    /// Determines whether the user can drag events between resources.
    static member inline eventResourceEditable(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventResourceEditable" value

    /// How many pixels the user’s mouse/touch must move before an event drag activates.
    static member inline eventDragMinDistance(value: int) =
        Interop.mkProperty<ICalendarProp> "eventDragMinDistance" value

    /// Time it takes for an event to revert to its original position after an unsuccessful drag.
    static member inline dragRevertDuration(value: int) =
        Interop.mkProperty<ICalendarProp> "dragRevertDuration" value

    /// Whether to automatically scoll the scroll-containers during event drag-and-drop and date selecting.
    static member inline dragScroll(value: bool) =
        Interop.mkProperty<ICalendarProp> "dragScroll" value

    /// Determines how an event’s duration should be mutated when it is dragged from a timed section to an all-day section and vice versa.
    static member inline allDayMaintainDuration(value: bool) =
        Interop.mkProperty<ICalendarProp> "allDayMaintainDuration" value

    /// The parent element that fixed-positioned event mirror elements are attached to while dragging.
    static member inline fixedMirrorParent(value: HTMLElement) =
        Interop.mkProperty<ICalendarProp> "fixedMirrorParent" value

    /// Determines if events being dragged and resized are allowed to overlap each other.
    static member inline eventOverlap(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventOverlap" value

    /// Limits event dragging and resizing to certain windows of time.
    static member inline eventConstraint(value: string list) =
        Interop.mkProperty<ICalendarProp> "eventConstraint" (value |> List.toArray)

    /// Limits event dragging and resizing to certain windows of time.
    static member inline eventConstraint(value: string) =
        Interop.mkProperty<ICalendarProp> "eventConstraint" value

    /// Limits event dragging and resizing to certain windows of time.
    static member inline eventConstraint(value: IBusinessDayProp list) =
        Interop.mkProperty<ICalendarProp> "eventConstraint" (!!value |> createObj |> unbox)

    /// Whether to draw a “placeholder” event while the user is dragging.
    static member inline selectMirror(value: bool) =
        Interop.mkProperty<ICalendarProp> "selectMirror" value

    /// In, dayGrid view, the max number of events within a given day, not counting the +more link. The rest will show up in a popover.
    static member inline dayMaxEvents(value: bool) =
        Interop.mkProperty<ICalendarProp> "dayMaxEvents" value

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
    static member inline eventsSet(value: EventImpl array -> unit) =
        Interop.mkProperty<ICalendarProp> "eventsSet" (System.Func<_, _> value)

    /// Triggered when dragging stops and the event has moved to a different day/time.
    static member inline eventDrop(value: EventDropInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventDrop" (System.Func<_, _> value)

    /// Determines if external draggable elements or events from other calendars can be dropped onto the calendar.
    static member inline droppable(value: bool) =
        Interop.mkProperty<ICalendarProp> "droppable" value

    /// Called when an external draggable element or an event from another calendar has been dropped onto the calendar.
    static member inline drop(value: DropInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "drop" (System.Func<_, _> value)

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

    /// The separator text used for date-formatting ranges throughout the API.
    static member inline defaultRangeSeparator(value: string) =
        Interop.mkProperty<ICalendarProp> "defaultRangeSeparator" value

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

    /// In list view, the “No events to display” message.
    static member inline noEventsClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "noEventsClassNames" value

    /// In list view, the “No events to display” message.
    static member inline noEventsClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "noEventsClassNames" (value |> List.toArray)

    /// In list view, the “No events to display” message.
    static member inline noEventsClassNames(value: NoEventsContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "noEventsClassNames" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsClassNames(value: NoEventsContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "noEventsClassNames" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: string) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" value

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" value

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" value

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: NoEventsContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: NoEventsContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: NoEventsContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: NoEventsContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "noEventsContent" value

    /// In list view, the “No events to display” message.
    static member inline noEventsDidMount(value: NoEventsMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "noEventsDidMount" (System.Func<_, _> value)

    /// In list view, the “No events to display” message.
    static member inline noEventsWillMount(value: NoEventsMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "noEventsWillMount" (System.Func<_, _> value)

    static member inline moreLinkClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "moreLinkClassNames" value

    static member inline moreLinkClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "moreLinkClassNames" (value |> List.toArray)

    static member inline moreLinkClassNames(value: MoreLinkContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "moreLinkClassNames" (System.Func<_, _> value)

    static member inline moreLinkClassNames(value: MoreLinkContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "moreLinkClassNames" (System.Func<_, _> value)

    static member inline moreLinkContent(value: string) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" value

    static member inline moreLinkContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" value

    static member inline moreLinkContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" value

    static member inline moreLinkContent(value: MoreLinkContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" (System.Func<_, _> value)

    static member inline moreLinkContent(value: MoreLinkContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" (System.Func<_, _> value)

    static member inline moreLinkContent(value: MoreLinkContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" (System.Func<_, _> value)

    static member inline moreLinkContent(value: MoreLinkContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" (System.Func<_, _> value)

    static member inline moreLinkContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "moreLinkContent" value

    static member inline moreLinkDidMount(value: MoreLinkMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "moreLinkDidMount" (System.Func<_, _> value)

    static member inline moreLinkWillUnmount(value: MoreLinkMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "moreLinkWillUnmount" (System.Func<_, _> value)

    /// a ClassName Input for adding classNames to the header <th> cell
    static member inline dayHeaderClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "dayHeaderClassNames" value

    /// a ClassName Input for adding classNames to the header <th> cell
    static member inline dayHeaderClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "dayHeaderClassNames" (value |> List.toArray)

    /// a ClassName Input for adding classNames to the header <th> cell
    static member inline dayHeaderClassNames(value: DayHeaderContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "dayHeaderClassNames" (System.Func<_, _> value)

    /// a ClassName Input for adding classNames to the header <th> cell
    static member inline dayHeaderClassNames(value: DayHeaderContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "dayHeaderClassNames" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: string) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" value

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" value

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" value

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: DayHeaderContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: DayHeaderContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: DayHeaderContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: DayHeaderContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the header cell. It does not replace the <th> cell.
    static member inline dayHeaderContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "dayHeaderContent" value

    /// called right after the <th> has been added to the DOM
    static member inline dayHeaderDidMount(value: DayHeaderMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "dayHeaderDidMount" (System.Func<_, _> value)

    /// called right before the <th> will be removed from the DOM
    static member inline dayHeaderWillUnmount(value: DayHeaderMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "dayHeaderWillUnmount" (System.Func<_, _> value)

    /// a ClassName Input for adding classNames to the <td> cell
    static member inline dayCellClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "dayCellClassNames" value

    /// a ClassName Input for adding classNames to the <td> cell
    static member inline dayCellClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "dayCellClassNames" (value |> List.toArray)

    /// a ClassName Input for adding classNames to the <td> cell
    static member inline dayCellClassNames(value: DayCellContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "dayCellClassNames" (System.Func<_, _> value)

    /// a ClassName Input for adding classNames to the <td> cell
    static member inline dayCellClassNames(value: DayCellContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "dayCellClassNames" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: string) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" value

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" value

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" value

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: DayCellContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: DayCellContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: DayCellContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: DayCellContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" (System.Func<_, _> value)

    /// a Content Injection Input. Generated content is inserted inside the inner-most wrapper of the day cell. It does not replace the <td> cell.
    static member inline dayCellContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "dayCellContent" value

    /// called right after the <td> has been added to the DOM
    static member inline dayCellDidMount(value: DayCellMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "dayCellDidMount" (System.Func<_, _> value)

    /// called right before the <td> will be removed from the DOM
    static member inline dayCellWillUnmount(value: DayCellMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "dayCellWillUnmount" (System.Func<_, _> value)

    static member inline nowIndicatorClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorClassNames" value

    static member inline nowIndicatorClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorClassNames" (value |> List.toArray)

    static member inline nowIndicatorClassNames(value: NowIndicatorContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorClassNames" (System.Func<_, _> value)

    static member inline nowIndicatorClassNames(value: NowIndicatorContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorClassNames" (System.Func<_, _> value)

    static member inline nowIndicatorContent(value: string) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" value

    static member inline nowIndicatorContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" value

    static member inline nowIndicatorContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" value

    static member inline nowIndicatorContent(value: NowIndicatorContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" (System.Func<_, _> value)

    static member inline nowIndicatorContent(value: NowIndicatorContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" (System.Func<_, _> value)

    static member inline nowIndicatorContent(value: NowIndicatorContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" (System.Func<_, _> value)

    static member inline nowIndicatorContent(value: NowIndicatorContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" (System.Func<_, _> value)

    static member inline nowIndicatorContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorContent" value

    static member inline nowIndicatorDidMount(value: NowIndicatorMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorDidMount" (System.Func<_, _> value)

    static member inline nowIndicatorWillUnmount(value: NowIndicatorMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "nowIndicatorWillUnmount" (System.Func<_, _> value)

    /// Determines the number of weeks displayed in a month view.
    static member inline fixedWeekCount(value: bool) =
        Interop.mkProperty<ICalendarProp> "fixedWeekCount" value

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

    /// Sets the exact date range that is visible in a view.
    static member inline visibleRange(value: DateRangeInput) =
        Interop.mkProperty<ICalendarProp> "visibleRange" value

    /// Sets the exact date range that is visible in a view.
    static member inline visibleRange(value: DateTime -> DateRangeInput) =
        Interop.mkProperty<ICalendarProp> "visibleRange" (System.Func<_, _> value)

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
    static member inline selectOverlap(value: EventImpl -> bool) =
        Interop.mkProperty<ICalendarProp> "selectOverlap" (System.Func<_, _> value)

    /// Limits user selection to certain windows of time.
    static member inline selectConstraint(value: string) =
        Interop.mkProperty<ICalendarProp> "selectConstraint" value

    /// Sets the exact number of days displayed in a custom view, regardless of weekends or hiddenDays.
    static member inline dayCount(value: int) =
        Interop.mkProperty<ICalendarProp> "dayCount" value

    /// The locale and locales options allow you to localize certain aspects of the calendar
    static member inline locale(value: string) =
        Interop.mkProperty<ICalendarProp> "locale" value

    /// The locale and locales options allow you to localize certain aspects of the calendar
    static member inline locale(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "locale" (!!value |> createObj |> unbox)

    /// The locale and locales options allow you to localize certain aspects of the calendar
    static member inline locale(value: DateTime -> int) =
        Interop.mkProperty<ICalendarProp> "locale" (System.Func<_, _> value)

    /// The locale and locales options allow you to localize certain aspects of the calendar
    static member inline locale(value: int) =
        Interop.mkProperty<ICalendarProp> "locale" value

    /// The locale and locales options allow you to localize certain aspects of the calendar
    static member inline locale(value: IDayProp) =
        Interop.mkProperty<ICalendarProp> "locale" value

    /// The day that each week begins.
    static member inline firstDay(value: IDayProp) =
        Interop.mkProperty<ICalendarProp> "firstDay" value

    /// The day that each week begins.
    static member inline firstDay(value: int) =
        Interop.mkProperty<ICalendarProp> "firstDay" value

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
    static member inline unselect(value: DateUnselectArg -> unit) =
        Interop.mkProperty<ICalendarProp> "unselect" (System.Func<_, _> value)

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

    static member inline ref(value: IRefValue<CalendarRoot option>) =
        Interop.mkProperty<ICalendarProp> "ref" value

    /// A hook for transforming custom data into a standard EventImpl object.
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
        Interop.mkProperty<ICalendarProp> "loading" (System.Func<_, _> value)

    /// Sets the background and border colors for all events on the calendar.
    static member inline eventColor(value: string) =
        Interop.mkProperty<ICalendarProp> "eventColor" value

    /// Sets the background color for all events on the calendar.
    static member inline eventBackgroundColor(value: string) =
        Interop.mkProperty<ICalendarProp> "eventBackgroundColor" value

    /// Sets the border color for all events on the calendar.
    static member inline eventBorderColor(value: string) =
        Interop.mkProperty<ICalendarProp> "eventBorderColor" value

    /// Sets the text color for all events on the calendar.
    static member inline eventTextColor(value: string) =
        Interop.mkProperty<ICalendarProp> "eventTextColor" value

    /// Determines the time-text that will be displayed on each event.
    static member inline eventTimeFormat(value: IDurationProp list) =
        Interop.mkProperty<ICalendarProp> "eventTimeFormat" (!!value |> createObj |> unbox)

    /// Whether or not to display the text for an event’s date/time.
    static member inline displayEventTime(value: bool) =
        Interop.mkProperty<ICalendarProp> "displayEventTime" value

    /// Whether or not to display an event’s end time.
    static member inline displayEventEnd(value: bool) =
        Interop.mkProperty<ICalendarProp> "displayEventEnd" value

    /// When an event’s end time spans into another day, the minimum time it must be in order for it to render as if it were on that day.
    static member inline nextDayThreshold(value: string) =
        Interop.mkProperty<ICalendarProp> "nextDayThreshold" value

    /// Determines the ordering events within the same day.
    static member inline eventOrder(value: string) =
        Interop.mkProperty<ICalendarProp> "eventOrder" value

    /// Determines the ordering events within the same day.
    static member inline eventOrder(value: string list) =
        Interop.mkProperty<ICalendarProp> "eventOrder" (value |> List.toArray)

    /// Determines the ordering events within the same day. A function that accepts two arguments and returns -1 or 1, similar to sort’s compare function
    static member inline eventOrder(value: EventImpl -> EventImpl -> int) =
        Interop.mkProperty<ICalendarProp> "eventOrder" (System.Func<_, _, _> value)

    /// Ensures the eventOrder setting is strictly followed.
    static member inline eventOrderStrict(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventOrderStrict" value

    /// When to render multiple asynchronous event sources in an individual or batched manner.
    static member inline progressiveEventRendering(value: bool) =
        Interop.mkProperty<ICalendarProp> "progressiveEventRendering" value

    /// Exact programmatic control over where an event can be dropped.
    static member inline eventAllow(value: DropInfo -> EventImpl -> bool) =
        Interop.mkProperty<ICalendarProp> "eventAllow" (System.Func<_, _, _> value)

    /// Provides a way to filter which external elements can be dropped onto the calendar.
    static member inline dropAccept(value: string) =
        Interop.mkProperty<ICalendarProp> "dropAccept" value

    /// Provides a way to filter which external elements can be dropped onto the calendar.
    static member inline dropAccept(value: HTMLElement -> bool) =
        Interop.mkProperty<ICalendarProp> "dropAccept" (System.Func<_, _> value)

    /// Triggered when event dragging begins.
    static member inline eventDragStart(value: EventDragInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventDragStart" (System.Func<_, _> value)

    /// Triggered when event dragging stops.
    static member inline eventDragStop(value: EventDragInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventDragStop" (System.Func<_, _> value)

    /// Called when an external draggable element with associated event data was dropped onto the calendar. Or an event from another calendar.
    static member inline eventReceive(value: EventInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventReceive" (System.Func<_, _> value)

    /// Triggered when on a calendar when one if its events is about to be dropped onto another calendar.
    static member inline eventLeave(value: EventInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventLeave" (System.Func<_, _> value)

    /// Triggered when event resizing begins.
    static member inline eventResizeStart(value: EventDragInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventResizeStart" (System.Func<_, _> value)

    /// Triggered when event resizing stops.
    static member inline eventResizeStop(value: EventDragInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventResizeStop" (System.Func<_, _> value)

    /// Triggered when resizing stops and the event has changed in duration.
    static member inline eventResize(value: EventResizeInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "eventResize" (System.Func<_, _> value)

    /// In dayGrid view, the max number of stacked event levels within a given day. This includes the +more link if present. The rest will show up in a popover.
    static member inline dayMaxEventRows(value: int) =
        Interop.mkProperty<ICalendarProp> "dayMaxEventRows" value

    /// In dayGrid view, the max number of stacked event levels within a given day. This includes the +more link if present. The rest will show up in a popover.
    static member inline dayMaxEventRows(value: bool) =
        Interop.mkProperty<ICalendarProp> "dayMaxEventRows" value

    /// For timeline view, the maximum number of events that stack top-to-bottom. For timeGrid view, the maximum number of events that stack left-to-right.
    static member inline eventMaxStack(value: int) =
        Interop.mkProperty<ICalendarProp> "eventMaxStack" value

    /// a ClassName Input for adding classNames to the root view element. called whenever the view changes.
    static member inline viewClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "viewClassNames" (value |> List.toArray)

    /// a ClassName Input for adding classNames to the root view element. called whenever the view changes.
    static member inline viewClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "viewClassNames" value

    /// a ClassName Input for adding classNames to the root view element. called whenever the view changes.
    static member inline viewClassNames(value: EventContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "viewClassNames" (System.Func<_, _> value)

    /// a ClassName Input for adding classNames to the root view element. called whenever the view changes.
    static member inline viewClassNames(value: EventContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "viewClassNames" (System.Func<_, _> value)

    /// called right after the view has been added to the DOM
    static member inline viewDidMount(value: MountInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "viewDidMount" (System.Func<_, _> value)

    /// called right before the view will be removed from the DOM
    static member inline viewWillUnmount(value: MountInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "viewWillUnmount" (System.Func<_, _> value)

    /// In, dayGrid view, the max number of events within a given day, not counting the +more link. The rest will show up in a popover.
    static member inline dayMaxEvents(value: int) =
        Interop.mkProperty<ICalendarProp> "dayMaxEvents" value

    /// Customize the rendering of event elements
    static member inline eventContent(value: string) =
        Interop.mkProperty<ICalendarProp> "eventContent" value

    /// Customize the rendering of event elements
    static member inline eventContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "eventContent" value

    /// Customize the rendering of event elements
    static member inline eventContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "eventContent" value

    /// Customize the rendering of event elements
    static member inline eventContent(value: EventContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "eventContent" (System.Func<_, _> value)

    /// Customize the rendering of event elements
    static member inline eventContent(value: EventContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "eventContent" (System.Func<_, _> value)

    /// Customize the rendering of event elements
    static member inline eventContent(value: EventContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "eventContent" (System.Func<_, _> value)

    /// Customize the rendering of event elements
    static member inline eventContent(value: EventContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "eventContent" (System.Func<_, _> value)

    /// Customize the rendering of event elements
    static member inline eventContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "eventContent" value

    /// CSS classNames can be injected into FullCalendar’s DOM in various places
    static member inline eventClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "eventClassNames" value

    /// CSS classNames can be injected into FullCalendar’s DOM in various places
    static member inline eventClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "eventClassNames" (value |> List.toArray)

    /// CSS classNames can be injected into FullCalendar’s DOM in various places
    static member inline eventClassNames(value: EventContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "eventClassNames" (System.Func<_, _> value)

    /// CSS classNames can be injected into FullCalendar’s DOM in various places
    static member inline eventClassNames(value: EventContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "eventClassNames" (System.Func<_, _> value)

    /// Called right after the element has been added to the DOM. If the event data changes, this is NOT called again.
    static member inline eventDidMount(value: EventMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "eventDidMount" (System.Func<_, _> value)

    /// Called right after the element has been added to the DOM. If the event data changes, this is NOT called again.
    static member inline eventWillUnmount(value: EventMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "eventWillUnmount" (System.Func<_, _> value)

    /// Sets the titles for the specified buttons.
    static member inline buttonHints(value: IButtonHintProp list) =
        Interop.mkProperty<ICalendarProp> "buttonHints" (!!value |> createObj |> unbox)

    /// Sets the title for the buttons that represent calendar views.
    static member inline viewHint(value: string) =
        Interop.mkProperty<ICalendarProp> "viewHint" value

    /// Sets the title for the buttons that represent calendar views.
    /// The first placeholder/function argument (info below) will be the localized buttonText, the second is the button name from the headerToolbar/footerToolbar options.
    static member inline viewHint(value: string -> string -> string) =
        Interop.mkProperty<ICalendarProp> "viewHint" (System.Func<_,_,_> value)

    /// Sets the title for the navLinks.
    static member inline navLinkHint(value: string) =
        Interop.mkProperty<ICalendarProp> "navLinkHint" value

    /// Sets the title for the navLinks.
    static member inline navLinkHint(value: string -> DateTime -> string) =
        Interop.mkProperty<ICalendarProp> "navLinkHint" (System.Func<_,_,_> value)

    /// Sets the title for the “+more” link opens an event popover.
    static member inline moreLinkHint(value: string) =
        Interop.mkProperty<ICalendarProp> "moreLinkHint" value

    /// Sets the title for the “+more” link opens an event popover.
    static member inline moreLinkHint(value: int -> string) =
        Interop.mkProperty<ICalendarProp> "moreLinkHint" value

    /// Sets the title for the “X” icon on the event popover. Default: "Close"
    static member inline closeHint(value: string) =
        Interop.mkProperty<ICalendarProp> "closeHint" value

    /// For list view’s non-visible table header, describes the column with days and times. Default: "Time"
    static member inline timeHint(value: string) =
        Interop.mkProperty<ICalendarProp> "timeHint" value

    /// For list view’s non-visible table header, describes the column with event names. Default: "Event"
    static member inline eventHint(value: string) =
        Interop.mkProperty<ICalendarProp> "eventHint" value

    /// Determines the action taken when the user clicks on a “more” link created by the dayMaxEventRows or dayMaxEvents options.
    static member inline moreLinkClick(value: string) =
        Interop.mkProperty<ICalendarProp> "moreLinkClick" value

    /// Determines the action taken when the user clicks on a “more” link created by the dayMaxEventRows or dayMaxEvents options.
    static member inline moreLinkClick(value: MoreLinkClickInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "moreLinkClick" (System.Func<_, _> value)

    /// Determines the date format of title of the popover created by the moreLinkClick option.
    static member inline dayPopoverFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICalendarProp> "dayPopoverFormat" (!!value |> createObj |> unbox)

    /// The license key you must enter to use premium features.
    static member inline schedulerLicenseKey(value: string) =
        Interop.mkProperty<ICalendarProp> "schedulerLicenseKey" value

    /// Visually groups resources by certain criteria. The given argument must be a field name that each resource object has
    static member inline resourceGroupField(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupField" value

    /// Determines the width of the area that contains the list of resources.
    static member inline resourceAreaWidth(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceAreaWidth" value

    /// Determines the width of the area that contains the list of resources.
    static member inline resourceAreaWidth(value: int) =
        Interop.mkProperty<ICalendarProp> "resourceAreaWidth" value

    /// Determines the width of the area that contains the list of resources.
    static member inline resourceAreaWidth(value: IStyleAttribute) =
        Interop.mkProperty<ICalendarProp> "resourceAreaWidth" value

    /// Turns the resource area from a plain list of titles into a grid of data.
    static member inline resourceAreaColumns(value: IResourceAreaColumnProp list list) =
        let cols = value |> List.map (fun c -> !!c |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "resourceAreaColumns" cols

    /// Whether child resources should be expanded when the view loads.
    static member inline resourcesInitiallyExpanded(value: bool) =
        Interop.mkProperty<ICalendarProp> "resourcesInitiallyExpanded" value

    /// Determines how wide each of the time-axis slots will be. Specified as a number of pixels.
    static member inline slotMinWidth(value: int) =
        Interop.mkProperty<ICalendarProp> "slotMinWidth" value

    /// In timeline view, the minimum width an event is allowed to be.
    static member inline eventMinWidth(value: int) =
        Interop.mkProperty<ICalendarProp> "eventMinWidth" value

    /// Determines if resourceTimeGrid or resourceDayGrid views should render their date headings above their resource headings.
    static member inline datesAboveResources(value: bool) =
        Interop.mkProperty<ICalendarProp> "datesAboveResources" value

    /// Tells the calendar to display resources from an array input.
    static member inline resources(value: IResourceProp list list) =
        let res = value |> List.map (fun r -> !!r |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "resources" res

    /// Tells the calendar to display resources from an array input.
    static member inline resources(value: 'T list) =
        Interop.mkProperty<ICalendarProp> "resources" (value |> List.toArray)

    /// Whether to refetch and rerender resources when the user navigates to a different date or changes the view.
    static member inline refetchResourcesOnNavigate(value: bool) =
        Interop.mkProperty<ICalendarProp> "refetchResourcesOnNavigate" value

    /// Tells the calendar to display resources from an array input.
    static member inline resources(value: string) =
        Interop.mkProperty<ICalendarProp> "resources" value

    /// This is exactly like specifying resources as an array except that if the supplied value changes, the calendar will NOT be updated to reflect. Only applicable to declarative front-end frameworks such as React, Vue, and Angular.
    static member inline initialResources(value: IResourceProp list list) =
        let res = value |> List.map (fun r -> !!r |> createObj) |> List.toArray

        Interop.mkProperty<ICalendarProp> "initialResources" res

    /// Called after a resource has been added to the calendar.
    static member inline resourceAdd(value: AddInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceAdd" (System.Func<_, _> value)

    /// This is exactly like specifying resources as an array except that if the supplied value changes, the calendar will NOT be updated to reflect. Only applicable to declarative front-end frameworks such as React, Vue, and Angular.
    static member inline initialResources(value: 'T list) =
        Interop.mkProperty<ICalendarProp> "initialResources" (!!value |> createObj |> unbox)

    /// This is exactly like specifying resources as an array except that if the supplied value changes, the calendar will NOT be updated to reflect. Only applicable to declarative front-end frameworks such as React, Vue, and Angular.
    static member inline initialResources(value: string) =
        Interop.mkProperty<ICalendarProp> "initialResources" value

    /// A custom function for programmatically generating raw Resources objects. This allows for any sort of asynchronous means of obtaining the resource list.
    /// function( fetchInfo, successCallback, failureCallback ) { }
    static member inline resources(value: FetchInfo -> (obj array -> unit) -> (CalendarError -> unit) -> unit) =
        Interop.mkProperty<ICalendarProp> "resources" (System.Func<_, _, _, _> value)

    /// Called after a resource has been modified in some way.
    static member inline resourceChange(value: ResourceChangeInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceChange" (System.Func<_, _> value)

    /// Called after a resource has been removed from the calendar.
    static member inline resourceRemove(value: ResourceChangeInfo -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceRemove" (System.Func<_, _> value)

    /// Called after resource data is initialized OR changed in any way.
    static member inline resourcesSet(value: ResourceApi array -> unit) =
        Interop.mkProperty<ICalendarProp> "resourcesSet" (System.Func<_, _> value)

    /// Determines the ordering of the resource list.
    static member inline resourceOrder(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceOrder" value

    /// When this setting is activated, only resources that have associated events will be displayed.
    static member inline filterResourcesWithEvents(value: bool) =
        Interop.mkProperty<ICalendarProp> "filterResourcesWithEvents" value

    /// a ClassName Input
    static member inline resourceLabelClassNames(value: ResourceLabelContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceLabelClassNames" (System.Func<_, _> value)

    /// a ClassName Input
    static member inline resourceLabelClassNames(value: ResourceLabelContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "resourceLabelClassNames" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLabelContent(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" value

    /// a Content Injection Input
    static member inline resourceLabelContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" value

    /// a Content Injection Input
    static member inline resourceLabelContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" value

    /// a Content Injection Input
    static member inline resourceLabelContent(value: ResourceLabelContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLabelContent(value: ResourceLabelContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLabelContent(value: ResourceLabelContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLabelContent(value: ResourceLabelContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLabelContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceLabelContent" value

    static member inline resourceLabelDidMount(value: ResourceLabelMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceLabelDidMount" (System.Func<_, _> value)

    static member inline resourceLabelWillUnmount(value: ResourceLabelMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceLabelWillUnmount" (System.Func<_, _> value)

    /// a ClassName Input
    static member inline resourceLaneClassNames(value: ResourceLabelContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceLaneClassNames" (System.Func<_, _> value)

    /// a ClassName Input
    static member inline resourceLaneClassNames(value: ResourceLabelContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "resourceLaneClassNames" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLaneContent(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" value

    /// a Content Injection Input
    static member inline resourceLaneContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" value

    /// a Content Injection Input
    static member inline resourceLaneContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" value

    /// a Content Injection Input
    static member inline resourceLaneContent(value: ResourceLabelContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLaneContent(value: ResourceLabelContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLaneContent(value: ResourceLabelContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLaneContent(value: ResourceLabelContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" (System.Func<_, _> value)

    /// a Content Injection Input
    static member inline resourceLaneContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceLaneContent" value

    static member inline resourceLaneDidMount(value: ResourceLabelMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceLaneDidMount" (System.Func<_, _> value)

    static member inline resourceLaneWillUnmount(value: ResourceLabelMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceLaneWillUnmount" (System.Func<_, _> value)

    static member inline resourceGroupLabelClassNames(value: ColCellContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelClassNames" (System.Func<_, _> value)

    static member inline resourceGroupLabelClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelClassNames" value

    static member inline resourceGroupLaneClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneClassNames" value

    static member inline resourceGroupLaneClassNames(value: ColCellContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneClassNames" (System.Func<_, _> value)

    static member inline resourceGroupLabelContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" value

    static member inline resourceGroupLabelContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" value

    static member inline resourceGroupLabelContent(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" value

    static member inline resourceGroupLabelContent(value: ColCellContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" (System.Func<_, _> value)

    static member inline resourceGroupLabelContent(value: ColCellContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" (System.Func<_, _> value)

    static member inline resourceGroupLabelContent(value: ColCellContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" (System.Func<_, _> value)

    static member inline resourceGroupLabelContent(value: ColCellContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" (System.Func<_, _> value)

    static member inline resourceGroupLabelContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelContent" value

    static member inline resourceGroupLabelDidMount(value: ColCellMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelDidMount" (System.Func<_, _> value)

    static member inline resourceGroupLabelWillUnmount(value: ColCellMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLabelWillUnmount" (System.Func<_, _> value)

    static member inline resourceGroupLaneClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneClassNames" (value |> List.toArray)

    static member inline resourceGroupLaneClassNames(value: ColCellContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneClassNames" (System.Func<_, _> value)

    static member inline resourceGroupLaneContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" value

    static member inline resourceGroupLaneContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" value

    static member inline resourceGroupLaneContent(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" value

    static member inline resourceGroupLaneContent(value: ColCellContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" (System.Func<_, _> value)

    static member inline resourceGroupLaneContent(value: ColCellContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" (System.Func<_, _> value)

    static member inline resourceGroupLaneContent(value: ColCellContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" (System.Func<_, _> value)

    static member inline resourceGroupLaneContent(value: ColCellContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" (System.Func<_, _> value)

    static member inline resourceGroupLaneContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneContent" value

    static member inline resourceGroupLaneDidMount(value: ColCellMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneDidMount" (System.Func<_, _> value)

    static member inline resourceGroupLaneWillUnmount(value: ColCellMountArg -> unit) =
        Interop.mkProperty<ICalendarProp> "resourceGroupLaneWillUnmount" (System.Func<_, _> value)

    static member inline resourceAreaHeaderClassNames(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderClassNames" value

    static member inline resourceAreaHeaderClassNames(value: string list) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderClassNames" (value |> List.toArray)

    static member inline resourceAreaHeaderClassNames(value: ColHeaderContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderClassNames" (System.Func<_, _> value)

    static member inline resourceAreaHeaderClassNames(value: ColHeaderContentArg -> string array) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderClassNames" (System.Func<_, _> value)

    static member inline resourceAreaHeaderContent(value: HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" value

    static member inline resourceAreaHeaderContent(value: DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" value

    static member inline resourceAreaHeaderContent(value: string) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" value

    static member inline resourceAreaHeaderContent(value: ColHeaderContentArg -> HtmlProp) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" (System.Func<_, _> value)

    static member inline resourceAreaHeaderContent(value: ColHeaderContentArg -> DomNodesProp) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" (System.Func<_, _> value)

    static member inline resourceAreaHeaderContent(value: ColHeaderContentArg -> string) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" (System.Func<_, _> value)

    static member inline resourceAreaHeaderContent(value: ColHeaderContentArg -> ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" (System.Func<_, _> value)

    static member inline resourceAreaHeaderContent(value: ReactElement) =
        Interop.mkProperty<ICalendarProp> "resourceAreaHeaderContent" value

    static member inline initialView(value: string) =
        Interop.mkProperty<ICalendarProp> "initialView" value

    /// Setting to true will cause all events to be focusable/tabbable. By default, only events that have an event.url property are tabbable.
    static member inline eventInteractive(value: bool) =
        Interop.mkProperty<ICalendarProp> "eventInteractive" value

    /// Defines custom buttons that can be used in the headerToolbar/footerToolbar.
    static member inline customButtons(value: (string * ICustomButtonProp list) list) =
        let buttons =
            match value with
            | [] -> {| |} |> unbox
            | buttons ->
                [
                    for (name, props) in buttons do
                        name, !!props |> createObj
                ]
                |> createObj
                |> unbox

        Interop.mkProperty<ICalendarProp> "customButtons" buttons

    /// Defines custom buttons that can be used in the headerToolbar/footerToolbar.
    static member inline views(value: (string * ICustomViewProp list) list) =
        let views =
            match value with
            | [] -> {| |} |> unbox
            | views ->
                [
                    for (name, props) in views do
                        name, !!props |> createObj
                ]
                |> createObj
                |> unbox

        Interop.mkProperty<ICalendarProp> "views" views

module calendar =
    /// The initial view when the calendar loads.
    [<Erase>]
    type initialView =
        static member inline dayGridMonth =
            Interop.mkProperty<ICalendarProp> "initialView" "dayGridMonth"

        static member inline dayGridWeek =
            Interop.mkProperty<ICalendarProp> "initialView" "dayGridWeek"

        static member inline timeGridDay =
            Interop.mkProperty<ICalendarProp> "initialView" "timeGridDay"

        static member inline timelineWeek =
            Interop.mkProperty<ICalendarProp> "initialView" "timelineWeek"

        static member inline listWeek = Interop.mkProperty<ICalendarProp> "initialView" "listWeek"

        static member inline multiMonthYear =
            Interop.mkProperty<ICalendarProp> "initialView" "multiMonthYear"

        static member inline resourceTimelineWeek =
            Interop.mkProperty<ICalendarProp> "initialView" "resourceTimelineWeek"

        static member inline resourceTimeline =
            Interop.mkProperty<ICalendarProp> "initialView" "resourceTimeline"

        static member inline resourceTimeGridDay =
            Interop.mkProperty<ICalendarProp> "initialView" "resourceTimeGridDay"

        static member inline resourceTimelineDay =
            Interop.mkProperty<ICalendarProp> "initialView" "resourceTimelineDay"

    /// The method for calculating week numbers that are displayed with the weekNumbers setting.
    [<Erase>]
    type weekNumberCalculation =
        /// Specifying "local" causes the locale-specific calculation to be used, as determined by the calendar’s locale setting. This is the default.
        static member inline local = Interop.mkProperty<ICalendarProp> "weekNumberCalculation" "local"

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
        static member inline bootstrap5 = Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// To use this theme, you must use the Bootstrap plugin, as well as add this code to the head of your index.html file.
        /// <br/>
        /// <code>
        /// `<link href='https://cdn.jsdelivr.net/npm/bootstrap@4.5.0/dist/css/bootstrap.css' rel='stylesheet'>`
        /// <br/>
        /// `<link href='https://cdn.jsdelivr.net/npm/@fortawesome/fontawesome-free@5.13.1/css/all.css' rel='stylesheet'>`
        /// </code>
        static member inline bootstrap = Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline cerulean =
            importSideEffects "bootswatch/dist/cerulean/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline cosmo =
            importSideEffects "bootswatch/dist/cosmo/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline cyborg =
            importSideEffects "bootswatch/dist/cyborg/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline darkly =
            importSideEffects "bootswatch/dist/darkly/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline flatly =
            importSideEffects "bootswatch/dist/flatly/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline journal =
            importSideEffects "bootswatch/dist/journal/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline litera =
            importSideEffects "bootswatch/dist/litera/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline lumen =
            importSideEffects "bootswatch/dist/lumen/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline lux =
            importSideEffects "bootswatch/dist/lux/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline materia =
            importSideEffects "bootswatch/dist/materia/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline minty =
            importSideEffects "bootswatch/dist/minty/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline morph =
            importSideEffects "bootswatch/dist/morph/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline pulse =
            importSideEffects "bootswatch/dist/pulse/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline quartz =
            importSideEffects "bootswatch/dist/quartz/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline sandstone =
            importSideEffects "bootswatch/dist/sandstone/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline simplex =
            importSideEffects "bootswatch/dist/simplex/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline sketchy =
            importSideEffects "bootswatch/dist/sketchy/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline slate =
            importSideEffects "bootswatch/dist/slate/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline solar =
            importSideEffects "bootswatch/dist/solar/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline spacelab =
            importSideEffects "bootswatch/dist/spacelab/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline superhero =
            importSideEffects "bootswatch/dist/superhero/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline united =
            importSideEffects "bootswatch/dist/united/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline vapor =
            importSideEffects "bootswatch/dist/vapor/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline yeti =
            importSideEffects "bootswatch/dist/yeti/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

        /// User must have bootswatch install, as well as use the Bootstrap5 plugin, in order to use this theme.
        /// <br/>
        /// **NOTE**: If FS.FullCalendar is being used in conjunction with FS.FluentUI, the Calendar must be placed <u>outside</u> of a `Fui.fluentProvider`
        /// in order for this theme to take full effect. If placed inside of a `fluentProvider`, the custom theme will not override styles like fontFamily.
        static member inline zephyr =
            importSideEffects "bootswatch/dist/zephyr/bootstrap.min.css" |> ignore
            Interop.mkProperty<ICalendarProp> "themeSystem" "bootstrap5"

    /// A time zone is a region of the world that serves as a context for displaying dates.
    [<Erase>]
    type timezone =
        static member inline local = Interop.mkProperty<ICalendarProp> "timezone" "local"
        static member inline UTC = Interop.mkProperty<ICalendarProp> "timezone" "UTC"

    /// Controls which preset rendering style events use
    [<Erase>]
    type eventDisplay =
        /// When in daygrid, renders the event as a solid rectangle if it is all-day or multi-day. If a timed event, will render it with a dot. When in other views, will render normally.
        static member inline auto = Interop.mkProperty<ICalendarProp> "eventDisplay" "auto"
        /// When in daygrid, renders the event as a solid rectangle. When in other views, will render normally.
        static member inline block = Interop.mkProperty<ICalendarProp> "eventDisplay" "block"
        /// When in daygrid, renders the event with a dot. When in other views, will render normally.
        static member inline listItem = Interop.mkProperty<ICalendarProp> "eventDisplay" "list-item"

        static member inline background =
            Interop.mkProperty<ICalendarProp> "eventDisplay" "background"

        /// Like 'background', but fills the reverse space
        static member inline inverseBackground =
            Interop.mkProperty<ICalendarProp> "eventDisplay" "inverse-background"

        /// Won’t render the event at all.
        static member inline none = Interop.mkProperty<ICalendarProp> "eventDisplay" "none"

    [<Erase>]
    type eventConstraint =
        static member inline businessHours =
            Interop.mkProperty<ICalendarProp> "eventConstraint" "businessHours"

    /// The direction that elements in the calendar are rendered. Either left-to-right or right-to-left.
    [<Erase>]
    type direction =
        static member inline ltr = Interop.mkProperty<ICalendarProp> "direction" "ltr"
        static member inline rtl = Interop.mkProperty<ICalendarProp> "direction" "rtl"

    /// Whether to fix the date-headers at the top of the calendar to the viewport while scrolling.
    [<Erase>]
    type stickyHeaderDates =
        static member inline auto = Interop.mkProperty<ICalendarProp> "stickyHeaderDates" "auto"

    /// Determines the action taken when the user clicks on a “more” link created by the dayMaxEventRows or dayMaxEvents options.
    [<Erase>]
    type moreLinkClick =
        static member inline popover = Interop.mkProperty<ICalendarProp> "moreLinkClick" "popover"
        static member inline week = Interop.mkProperty<ICalendarProp> "moreLinkClick" "week"
        static member inline day = Interop.mkProperty<ICalendarProp> "moreLinkClick" "day"
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

    static member inline daysOfWeek(value: IDayProp list) =
        Interop.mkProperty<IEventProp> "daysOfWeek" (value |> List.toArray)

    static member inline startTime(value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "startTime" (!!value |> createObj |> unbox)

    static member inline endTime(value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "endTime" (!!value |> createObj |> unbox)

    static member inline startRecur(value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "startRecur" (!!value |> createObj |> unbox)

    static member inline endRecur(value: IDurationProp list) =
        Interop.mkProperty<IEventProp> "endRecur" (!!value |> createObj |> unbox)

    static member inline interactive(value: bool) =
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

    static member inline constraint'(value: ResourceIdsProp) =
        Interop.mkProperty<IEventProp> "constraint" value

    static member inline color(value: string) =
        Interop.mkProperty<IEventProp> "color" value

    static member inline backgroundColor(value: string) =
        Interop.mkProperty<IEventProp> "backgroundColor" value

    static member inline borderColor(value: string) =
        Interop.mkProperty<IEventProp> "borderColor" value

    static member inline textColor(value: string) =
        Interop.mkProperty<IEventProp> "textColor" value

    /// An “event source” is anything that provides FullCalendar with data about events. It can be a simple array,
    /// an event-generating function that you define, a URL to a json feed, or a Google Calendar feed.
    static member inline source(value: string) =
        Interop.mkProperty<IEventProp> "source" value

    /// An “event source” is anything that provides FullCalendar with data about events. It can be a simple array,
    /// an event-generating function that you define, a URL to a json feed, or a Google Calendar feed.
    static member inline source(value: 'T list) =
        Interop.mkProperty<IEventProp> "source" (value |> List.toArray)

    /// An “event source” is anything that provides FullCalendar with data about events. It can be a simple array,
    /// an event-generating function that you define, a URL to a json feed, or a Google Calendar feed.
    static member inline source(value: IEventProp list) =
        Interop.mkProperty<IEventProp> "source" (!!value |> createObj |> unbox)

    /// A custom function for programmatically generating Events.
    static member inline source(value: FetchInfo -> (EventInput array -> unit) -> (CalendarError -> unit) -> unit) =
        Interop.mkProperty<IEventProp> "source" (System.Func<_, _, _, _> value)

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

    static member inline bootstrapFontAwesome(value: string) =
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

    static member inline close(value: string) =
        Interop.mkProperty<IButtonIconProp> "close" value

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

// ----------------------------------------------------- Draggable ----------------------------------------------------------------------
[<Erase>]
type draggable =
    /// A CSS selector that matches draggable elements within a container element.
    static member inline itemSelector(value: string) =
        Interop.mkProperty<IDraggableProp> "itemSelector" value

    /// An object or a function that returns an object. Exact properties explained below.
    static member inline eventData(handler: HTMLElement -> IEventProp list) =
        Interop.mkProperty<IDraggableProp> "eventData" (fun value -> !!(handler value) |> createObj |> unbox)

    /// An object or a function that returns an object. Exact properties explained below.
    static member inline eventData(value: IEventProp list) =
        Interop.mkProperty<IDraggableProp> "eventData" (!!value |> createObj |> unbox)

    /// For touch devices, the amount of time the user must hold down before an event becomes draggable.
    static member inline longPressDelay(value: int) =
        Interop.mkProperty<IDraggableProp> "longPressDelay" value

    /// For touch devices, the amount of time the user must hold down before an event becomes draggable.
    static member inline eventLongPressDelay(value: int) =
        Interop.mkProperty<IDraggableProp> "eventLongPressDelay" value

    /// For touch devices, the amount of time the user must hold down before a date becomes selectable.
    static member inline selectLongPressDelay(value: int) =
        Interop.mkProperty<IDraggableProp> "selectLongPressDelay" value

    /// How many pixels the user’s mouse/touch must move before an event drag activates.
    static member inline minDistance(value: int) =
        Interop.mkProperty<IDraggableProp> "minDistance" value

    /// An HTML element that will be the parent of the “mirror” element that follows the mouse while dragging. Defaults to the <body>.
    static member inline appendTo(value: int) =
        Interop.mkProperty<IDraggableProp> "appendTo" value

// ----------------------------------------------------- ResourceAreaColumn ----------------------------------------------------------------------
[<Erase>]
type resourceAreaColumn =
    /// the property of the Resource Object where the data will come from. The data is displayed in the cell of the grid.
    static member inline field(value: string) =
        Interop.mkProperty<IResourceAreaColumnProp> "field" value

    /// If specified as true, resources will be grouped by this column.
    static member inline group(value: bool) =
        Interop.mkProperty<IResourceAreaColumnProp> "group" value

    /// the width of the column, either in a number of pixels or a string percentage like `"50%"`
    static member inline width(value: string) =
        Interop.mkProperty<IResourceAreaColumnProp> "width" value

    /// the width of the column, either in a number of pixels or a string percentage like `"50%"`
    static member inline width(value: int) =
        Interop.mkProperty<IResourceAreaColumnProp> "width" value

    /// the width of the column, either in a number of pixels or a string percentage like `"50%"`
    static member inline width(value: IStyleAttribute) =
        Interop.mkProperty<IResourceAreaColumnProp> "width" value

    /// a ClassName Input for the <th> at the top
    static member inline headerClassNames(value: string) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerClassNames" value

    /// a ClassName Input for the <th> at the top
    static member inline headerClassNames(value: string list) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerClassNames" (value |> List.toArray)

    /// a ClassName Input for the <th> at the top
    static member inline headerClassNames(value: ResourceContentArg -> string) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerClassNames" (System.Func<_,_> value)

    /// a ClassName Input for the <th> at the top
    static member inline headerClassNames(value: ResourceContentArg -> string array) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerClassNames" (System.Func<_,_> value)

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: string) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" value

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: HtmlProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" value

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: DomNodesProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" value

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: ResourceContentArg -> string) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: ResourceContentArg -> HtmlProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: ResourceContentArg -> DomNodesProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: ResourceContentArg -> ReactElement) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <th> at the top
    static member inline headerContent(value: ReactElement) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerContent" value

    /// called right after the <th> was added to the DOM
    static member inline headerDidMount(value: ResourceMountArg -> unit) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerDidMount" (System.Func<_,_> value)

    /// called right before the <th> will be removed from the DOM
    static member inline headerWillUnmount(value: ResourceMountArg -> unit) =
        Interop.mkProperty<IResourceAreaColumnProp> "headerWillUnmount" (System.Func<_,_> value)

    /// a ClassName Input for the <td> in the body
    static member inline cellClassNames(value: string) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellClassNames" value

    /// a ClassName Input for the <td> in the body
    static member inline cellClassNames(value: string list) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellClassNames" (value |> List.toArray)

    /// a ClassName Input for the <td> in the body
    static member inline cellClassNames(value: ColCellContentArg -> string) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellClassNames" (System.Func<_,_> value)

    /// a ClassName Input for the <td> in the body
    static member inline cellClassNames(value: ColCellContentArg -> string array) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellClassNames" (System.Func<_,_> value)

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: string) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" value

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: HtmlProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" value

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: DomNodesProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" value

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: ColCellContentArg -> string) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: ColCellContentArg -> HtmlProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: ColCellContentArg -> DomNodesProp) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: ColCellContentArg -> ReactElement) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" (System.Func<_,_> value)

    /// a Content Injection Input for the <td> in the body
    static member inline cellContent(value: ReactElement) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellContent" value

    /// called right after the <td> was added to the DOM
    static member inline cellDidMount(value: ColCellMountArg -> unit) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellDidMount" (System.Func<_,_> value)

    /// called right before the <td> will be removed from the DOM
    static member inline cellWillUnmount(value: ColCellMountArg -> unit) =
        Interop.mkProperty<IResourceAreaColumnProp> "cellWillUnmount" (System.Func<_,_> value)

// ----------------------------------------------------- Resource ----------------------------------------------------------------------
[<Erase>]
type resource =
    /// the unique string identifier for this resource
    static member inline id(value: string) =
        Interop.mkProperty<IResourceProp> "id" value

    static member inline groupId(value: string) =
        Interop.mkProperty<IResourceProp> "groupId" value

    /// the string title of this resource
    static member inline title(value: string) =
        Interop.mkProperty<IResourceProp> "title" value

    /// a hash of non-standard props that were specified during parsing
    static member inline extendedProps(value: obj) =
        Interop.mkProperty<IResourceProp> "extendedProps" value

    /// The eventConstraint setting for associated events.
    static member inline eventConstraint(value: string) =
        Interop.mkProperty<IResourceProp> "eventConstraint" value

    static member inline children(value: IResourceProp list list) =
        let children = value |> List.map (fun c -> !!c |> createObj) |> List.toArray
        Interop.mkProperty<IResourceProp> "children" children

    /// The eventConstraint setting for associated events.
    static member inline eventConstraint(value: string list) =
        Interop.mkProperty<IResourceProp> "eventConstraint" (value |> List.toArray)

    static member inline eventOverlap(value: bool) =
        Interop.mkProperty<IResourceProp> "eventOverlap" value

    /// The eventAllow setting for associated events.
    static member inline eventAllow(value: DateSpanApi -> EventImpl -> bool) =
        Interop.mkProperty<IResourceProp> "eventAllow" (System.Func<_, _, _> value)

    static member inline eventBackgroundColor(value: string) =
        Interop.mkProperty<IResourceProp> "eventBackgroundColor" value

    static member inline eventBorderColor(value: string) =
        Interop.mkProperty<IResourceProp> "eventBorderColor" value

    static member inline eventTextColor(value: string) =
        Interop.mkProperty<IResourceProp> "eventTextColor" value

    /// Events associated with this resources will have their backgrounds and borders colored.
    /// Any CSS string color format can be specified, like "#f00" or "rgb(255,0,0)".
    /// This value will take precedence over the global eventColor option and the Event Source Object color option,
    /// but it will not take precedence over the Event Object color option.
    static member inline eventColor(value: string) =
        Interop.mkProperty<IResourceProp> "eventColor" value

    static member inline eventClassNames(value: string list) =
        Interop.mkProperty<IResourceProp> "eventClassNames" (value |> List.toArray)

    static member inline getParent(value: unit -> ResourceApi option) =
        Interop.mkProperty<IResourceProp> "getParent" (System.Func<_, _> value)

    static member inline getChildren(value: unit -> ResourceApi array) =
        Interop.mkProperty<IResourceProp> "getChildren" (System.Func<_, _> value)

    static member inline getEvents(value: unit -> EventImpl array) =
        Interop.mkProperty<IResourceProp> "getEvents" (System.Func<_, _> value)

    static member inline remove(value: unit -> unit) =
        Interop.mkProperty<IResourceProp> "remove" (System.Func<_, _> value)

    static member inline url(value: string) =
        Interop.mkProperty<IResourceProp> "url" value

    static member inline method(value: string) =
        Interop.mkProperty<IResourceProp> "method" value

    static member inline parentId(value: string) =
        Interop.mkProperty<IResourceProp> "parentId" value

    /// A businessHours declaration that will only apply to this resource
    static member inline businessHours(value: IBusinessDayProp list) =
        Interop.mkProperty<IResourceProp> "businessHours" (!!value |> createObj |> unbox)

// ----------------------------------------------------- CustomView ----------------------------------------------------------------------
[<Erase>]
type customView =
    static member inline buttonText(value: string) =
        Interop.mkProperty<ICustomViewProp> "buttonText" value

    static member inline duration(value: IDurationProp list) =
        Interop.mkProperty<ICustomViewProp> "duration" (!!value |> createObj |> unbox)

    static member inline titleFormat(value: IDateFormatProp list) =
        Interop.mkProperty<ICustomViewProp> "titleFormat" (!!value |> createObj |> unbox)

    static member inline dayCount(value: int) =
        Interop.mkProperty<ICustomViewProp> "dayCount" value

    static member inline visibleRange(value: DateRangeInput) =
        Interop.mkProperty<ICustomViewProp> "visibleRange" value

    /// Sets the exact date range that is visible in a view.
    static member inline visibleRange(value: DateTime -> DateRangeInput) =
        Interop.mkProperty<ICustomViewProp> "visibleRange" (System.Func<_, _> value)

    static member inline slotDuration(value: string) =
        Interop.mkProperty<ICustomViewProp> "slotDuration" value

    static member inline dayMaxEventRows(value: int) =
        Interop.mkProperty<ICustomViewProp> "dayMaxEventRows" value

module customView =
    [<Erase>]
    type type' =
        static member inline timeGrid = Interop.mkProperty<ICustomViewProp> "type" "timeGrid"
        static member inline dayGrid = Interop.mkProperty<ICustomViewProp> "type" "dayGrid"
        static member inline dayGridMonth = Interop.mkProperty<ICustomViewProp> "type" "dayGridMonth"
        static member inline dayGridWeek = Interop.mkProperty<ICustomViewProp> "type" "dayGridWeek"
        static member inline timeGridDay = Interop.mkProperty<ICustomViewProp> "type" "timeGridDay"
        static member inline listWeek = Interop.mkProperty<ICustomViewProp> "type" "listWeek"

        static member inline multiMonthYear =
            Interop.mkProperty<ICustomViewProp> "type" "multiMonthYear"

        static member inline resourceTimelineWeek =
            Interop.mkProperty<ICustomViewProp> "type" "resourceTimelineWeek"

        static member inline resourceTimeline =
            Interop.mkProperty<ICustomViewProp> "type" "resourceTimeline"

        static member inline resourceTimeGridDay =
            Interop.mkProperty<ICustomViewProp> "type" "resourceTimeGridDay"

        static member inline resourceTimelineDay =
            Interop.mkProperty<ICustomViewProp> "type" "resourceTimelineDay"

// ----------------------------------------------------- ButtonHint ----------------------------------------------------------------------
[<Erase>]
type buttonHint =
    static member inline prev(value: string) =
        Interop.mkProperty<IButtonHintProp> "prev" value

    static member inline next(value: string) =
        Interop.mkProperty<IButtonHintProp> "next" value

    static member inline prevYear(value: string) =
        Interop.mkProperty<IButtonHintProp> "prevYear" value

    static member inline nextYear(value: string) =
        Interop.mkProperty<IButtonHintProp> "nextYear" value

    static member inline today(value: string) =
        Interop.mkProperty<IButtonHintProp> "today" value

    static member inline month(value: string) =
        Interop.mkProperty<IButtonHintProp> "month" value

    static member inline week(value: string) =
        Interop.mkProperty<IButtonHintProp> "week" value

    static member inline day(value: string) =
        Interop.mkProperty<IButtonHintProp> "day" value
