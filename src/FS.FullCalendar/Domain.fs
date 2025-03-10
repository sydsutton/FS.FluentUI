namespace FS.FullCalendar

open Fable.Core
open Feliz
open System

type DateRangeInput = {
    start: System.DateTime
    ``end``: System.DateTime
}

type ViewApi = {
    calendar: CalendarApi
    ``type``: string
    title: string
    activeStart: System.DateTime
    activeEnd: System.DateTime
    currentStart: System.DateTime
    currentEnd: System.DateTime
    getOption: string -> unit
}

and CalendarApi = {
    view: ViewApi
    updateSize: unit -> unit
    setOption: string * obj -> unit //TODO
    getOption: string * obj //TODO
    getAvailableLocaleCodes: unit -> string array
    on: string * obj -> unit //TODO
    off: string * obj -> unit //TODO
    trigger: string * obj -> unit //TODO
    changeView: string -> DateRangeInput -> unit //TODO
    zoomTo: System.DateTime * string -> unit //TODO
    prev: unit -> unit
    next: unit -> unit
    prevYear: unit -> unit
    nextYear: unit -> unit
    today: unit -> unit
    gotoDate: System.DateTime -> unit
    incrementDate: string -> unit //TODO
    getDate: unit -> System.DateTime
    formatDate: System.DateTime * string -> unit //TODO
    formatRange: System.DateTime * System.DateTime * string -> unit //TODO
    formatIso: System.DateTime * bool -> string //TODO
    select: System.DateTime -> System.DateTime option -> unit
    unselect: unit -> unit
    addEvent: obj -> unit //TODO
    getEventById: string -> unit //TODO
    getEvents: unit -> string array //TODO
    removeAllEvents: unit -> unit
    getEventSources: unit -> obj //TODO
    getEventSourceById: string -> obj //TODO
    addEventSource: obj -> obj //TODO
    removeAllEventSources: unit -> unit
    refetchEvents: unit -> unit
    scrollToTime: obj -> unit //TODO
}

type CalendarEvent = {
    /// A unique identifier of an event. Useful for getEventById.
    id: string
    /// Events that share a groupId will be dragged and resized together automatically.
    groupId: string
    /// Determines if the event is shown in the “all-day” section of relevant views. In addition, if true the time text is not displayed with the event.
    allDay: bool
    /// Date object that obeys the current timeZone. When an event begins.
    start: DateTime
    /// Date oject that obeys the current timeZone. When an event ends. It could be null if an end wasn’t specified.
    /// Note: This value is exclusive. For example, an event with the end of 2018-09-03 will appear to span through 2018-09-02 but end before the start of 2018-09-03. See how events are are parsed from a plain object for further details.
    ``end``: DateTime
    /// An ISO8601 string representation of the start date. If the event is all-day, there will not be a time part.
    startStr: string
    /// An ISO8601 string representation of the end date. If the event is all-day, there will not be a time part.
    /// The text that will appear on an event.
    endStr: string
    title: string
    /// A URL that will be visited when this event is clicked by the user. For more information on controlling this behavior, see the eventClick callback.
    url: string
    /// An array of strings like [ 'myclass1', myclass2' ]. Determines which HTML classNames will be attached to the rendered event.
    classNames: string array
    /// The value overriding the editable setting for this specific event.
    editable: bool
    /// Boolean (true or false) or null.
    startEditable: bool
    /// The value overriding the eventDurationEditable setting for this specific event.
    durationEditable: bool
    /// The value overriding the eventResourceEditable setting for this specific event.
    resourceEditable: bool
    /// The rendering type of this event. Can be 'auto', 'block', 'list-item', 'background', 'inverse-background', or 'none'. See eventDisplay.
    display: string
    /// The value overriding the eventOverlap setting for this specific event. If false, prevents this event from being dragged/resized over other events. Also prevents other events from being dragged/resized over this event. Does not accept a function.
    overlap: bool
    /// The eventConstraint override for this specific event.
    ``constraint``: string array // TODO

    /// The eventBackgroundColor override for this specific event.
    backgroundColor: string

    /// The eventBorderColor override for this specific event.
    borderColor: string

    /// The eventTextColor override for this specific event.
    textColor: string

    /// A plain object holding miscellaneous other properties specified during parsing. Receives properties in the explicitly given extendedProps hash as well as other non-standard properties.
    extendedProps: obj

    /// A reference to the Event Source this event came from. If the event was added dynamically via addEvent, and the source parameter was not specified, this value will be null.
    source: obj
}

type DateSelectArg = {
    jsEvent: Browser.Types.UIEvent option
    view: ViewApi
    start: System.DateTime
    ``end``: System.DateTime
    startStr: string
    endStr: string
    allDay: bool
}

type EventAddData = {
    event: CalendarEvent
    relatedEvents: CalendarEvent array
    revert: unit -> unit //TODO
}

type SetStartOptions = {
    granularity: string
    maintainDuration: bool
}

type SetEndOptions = {
    granularity: string
}

type StartInputOptions = {
    allDay: bool
    granularity: string
}

type DurationObjectInput = {
    years: int
    year: int
    months: int
    month: int
    weeks: int
    week: int
    days: int
    day: int
    hours: int
    hour: int
    minutes: int
    minute: int
    seconds: int
    second: int
    milliseconds: int
    millisecond: int
    ms: int
}

type SetAllDayOptions = {
    maintainDuration: bool
}

type FormatterInput = {
    week: string
    meridiem: string
    omitZeroMinute: bool
    omitCommas: bool
    separator: string
}

type Duration = {
    years: int
    months: int
    days: int
    milliseconds: int
    specifiedWeeks: bool
}
type EventMutation = {
    datesDelta: Duration;
    startDelta: Duration
    endDelta: Duration
    standardProps: obj
    extendedProps: obj
}

type DateRange = {
    start: DateTime
    ``end``: DateTime
}

type DateSpanApi = {
    allDay: bool
    start: DateTime
    ``end``: DateTime
    startStr: string
    endStr: string
}

type CalendarContext = { //TODO
    dateEnv: obj
    options: obj
    pluginHooks: obj
    emitter: obj
    dispatch: obj
    getCurrentData: obj
    calendarApi: obj
}

type ToPlainObjectSettings = {
    collapseExtendedProps: bool
    collapseColor: bool
}

type EventSourceApi = {
    id: string
    url: string
    format: string
    remove: unit -> unit
    refetch: unit -> unit
}

type EventApi = {
    source: EventSourceApi option
    start: DateTime option
    ``end``: DateTime option
    startStr: string
    endStr: string
    id: string
    groupId: string
    allDay: bool
    title: string
    url: string
    display: string
    startEditable: bool
    durationEditable: bool
    ``constraint``: string
    overlap: bool
    allow: string
    backgroundColor: string
    borderColor: string
    textColor: string
    classNames: string array
    extendedProps: obj
    setProp: string -> obj -> unit // TODO (name: string, val: any): void;
    setExtendedProp: string -> obj -> unit //TODO (name: string, val: any): void;
    setStart: DateTime -> SetStartOptions -> unit
    setEnd: DateTime option -> SetEndOptions -> unit
    setDates: DateTime -> DateTime option -> StartInputOptions -> unit
    moveStart: DurationObjectInput -> unit
    moveEnd: DurationObjectInput -> unit
    moveDates: DurationObjectInput -> unit
    setAllDay: bool -> SetAllDayOptions -> unit
    formatRange: FormatterInput -> obj //TODO : any
    remove: unit -> unit
    toPlainObject: ToPlainObjectSettings -> obj
    toJSON: unit -> obj
}

type EventSourceSuccessResponseHandler = obj * obj * obj -> obj array //TODO
type EventSource = {
    sourceId: string
    sourceDefId: int
    meta: obj // TODO
    publicId: string
    isFetching: bool
    latestFetchId: string
    fetchRange: DateRange option
    defaultAllDay: bool option
    eventDataTransform: obj -> obj //TODO
    ui: EventUi;
    success: EventSourceSuccessResponseHandler option
    failure: (obj -> unit) option //TODO
    extendedProps: obj
}
and EventSourceImpl = {
    internalEventSource: EventSource
    constructor: CalendarContext * obj //TODO (context: CalendarContext, internalEventSource: EventSource<any>);
    id: string
    url: string
    format: string
    remove: unit -> unit
    refetch: unit -> unit
}
and EventImpl = {
    mutate: EventMutation -> unit
    source: EventSourceApi option
    start: DateTime option
    ``end``: DateTime option
    startStr: string
    endStr: string
    id: string
    groupId: string
    allDay: bool
    title: string
    url: string
    display: string
    startEditable: bool
    durationEditable: bool
    ``constraint``: string
    overlap: bool
    allow: string
    backgroundColor: string
    borderColor: string
    textColor: string
    classNames: string array
    extendedProps: obj
    setProp: string -> obj -> unit // TODO (name: string, val: any): void;
    setExtendedProp: string -> obj -> unit //TODO (name: string, val: any): void;
    setStart: DateTime -> SetStartOptions -> unit
    setEnd: DateTime option -> SetEndOptions -> unit
    setDates: DateTime -> DateTime option -> StartInputOptions -> unit
    moveStart: DurationObjectInput -> unit
    moveEnd: DurationObjectInput -> unit
    moveDates: DurationObjectInput -> unit
    setAllDay: bool -> SetAllDayOptions -> unit
    formatRange: FormatterInput -> obj //TODO : any
    remove: unit -> unit
    toPlainObject: ToPlainObjectSettings -> obj
    toJSON: unit -> obj
}
and AllowFunc = DateSpanApi * EventImpl option -> bool
and EventUi = {
    display: string option
    startEditable: bool option
    durationEditable: bool option
    constraints: string array
    overlap: bool option
    allows: AllowFunc array
    backgroundColor: string
    borderColor: string
    textColor: string
    classNames: string array
}

type EventClickArg = {
    el: Browser.Types.HTMLElement
    event: EventImpl
    jsEvent: Browser.Types.UIEvent
    view: ViewApi
}

type ChangeInfo = {
    /// An Event Object with the updated changed data
    event: CalendarEvent
    /// An array of other related Event Objects that were also affected. an event might have other recurring event instances or might be linked to other events with the same groupId
    relatedEvents: CalendarEvent array
    /// An Event Object with data prior to the change
    oldEvent: CalendarEvent
    /// A function that can be called to reverse this action
    revert: unit -> unit
}

type RemoveInfo = {
    /// An Event Object with the updated changed data
    event: CalendarEvent
    /// An array of other related Event Objects that were also affected. an event might have other recurring event instances or might be linked to other events with the same groupId
    relatedEvents: CalendarEvent array
    /// A function that can be called to reverse this action
    revert: unit -> unit
}

type PointerDragEvent = {
    origEvent: Browser.Types.UIEvent
    isTouch: bool
    subjectEl: Browser.Types.EventTarget
    pageX: int
    pageY: int
    deltaX: int
    deltaY: int
}

type Resource = {
    /// the unique string identifier for this resource
    id: string
    /// the string title of this resource
    title: string
    /// a hash of non-standard props that were specified during parsing
    extendedProps: obj
    eventConstraint: string //TODO
    eventOverlap: bool
    eventAllow: bool
    eventBackgroundColor: string
    eventBorderColor: string
    eventTextColor: string
    eventClassNames: string array
    getParent: unit -> obj //TODO
    getChildren: unit -> obj //TODO
    getEvents: unit -> CalendarEvent array
    remove: unit -> unit
}

type EventDropInfo = {
    /// An Event Object that holds information about the event (date, title, etc) after the drop.
    event: CalendarEvent
    /// An array of other related Event Objects that were also dropped. an event might have other recurring event instances or might be linked to other events with the same groupId
    relatedEvents: CalendarEvent array
    /// An Event Object that holds information about the event before the drop.
    oldEvent: CalendarEvent
    /// If the resource has changed, this is the Resource Object the event came from. If the resource has not changed, this will be undefined. For use with the resource plugins only.
    oldResource: Resource
    /// If the resource has changed, this is the Resource Object the event went to. If the resource has not changed, this will be undefined. For use with the resource plugins only.
    newResource: Resource
    /// A Duration Object that represents the amount of time the event was moved by.
    delta: DurationObjectInput
    /// A function that, if called, reverts the event’s start/end date to the values before the drag. This is useful if an ajax call should fail.
    revert: unit -> unit
    /// The current View Object.
    view: ViewApi
    /// The HTML element that was dragged.
    el: Browser.Types.HTMLElement
    /// The native JavaScript event with low-level information such as click coordinates.
    jsEvent: Browser.Types.UIEvent
}

type SelectInfo = {
/// Date. A date indicating the beginning of the selection.
start: DateTime
/// Date. A date indicating the end of the selection.
/// In line with the discussion about the Event object, it is important to stress that the end date property is exclusive. For example, if the selection is all-day and the last day is a Thursday, end will be Friday.
``end``: DateTime
/// String. An ISO8601 string representation of the start date. It will have a timezone offset similar to the calendar’s timeZone e.g. 2018-09-01T12:30:00-05:00. If selecting all-day cells, it won’t have a time nor timezone part e.g. 2018-09-01.
startStr: string
/// String. An ISO8601 string representation of the end date. It will have a timezone offset similar to the calendar’s timeZone e.g. 2018-09-02T12:30:00-05:00. If selecting all-day cells, it won’t have a time nor timezone part e.g. 2018-09-02.
endStr: string
/// Boolean. true or false whether the selection happened on all-day cells.
allDay: bool
/// The native JavaScript event with low-level information such as click coordinates.
jsEvent: Browser.Types.UIEvent
/// View object. The current Calendar view.
View: ViewApi
/// Resource object. If the current view is a resource view, this is the Resource object that was selected. This is only available when using one of the resource plugins.
resource: Resource
}

type DateClickInfo = {
/// a Date for the clicked day/time.
date: DateTime
/// An ISO8601 string representation of the date. Will have a time zone offset according to the calendar’s timeZone like 2018-09-01T12:30:00-05:00. If clicked on an all-day cell, won’t have a time part nor a time zone part, like 2018-09-01.
dateStr: string
/// true or false whether the click happened on an all-day cell.
allDay: bool
/// An HTML element that represents the whole-day that was clicked on.
dayEl: Browser.Types.HTMLElement
/// The native JavaScript event with low-level information such as click coordinates.
jsEvent: Browser.Types.UIEvent
/// The current View Object.
view: ViewApi
/// If the current view is a resource-view, the Resource Object that owns this date. Must be using one of the resource plugins.
resource: Resource
}
