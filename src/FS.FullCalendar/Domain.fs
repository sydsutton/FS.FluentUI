namespace FS.FullCalendar

open System
open Browser.Types

type DateRangeInput = { start: DateTime; ``end``: DateTime }

type SetAllDayOptions = { maintainDuration: bool }

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
    datesDelta: Duration
    startDelta: Duration
    endDelta: Duration
    standardProps: obj
    extendedProps: obj
}

type DateRange = { start: DateTime; ``end``: DateTime }

type DateSpanApi = {
    allDay: bool
    start: DateTime
    ``end``: DateTime
    startStr: string
    endStr: string
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

type SetStartOptions = {
    granularity: string
    maintainDuration: bool
}

type SetEndOptions = { granularity: string }

type StartInputOptions = { allDay: bool; granularity: string }


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
    ``constraint``: string

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

type CalendarError = {
    name: string
    message: string
    stack: string
}

type DateSelectArg = {
    jsEvent: UIEvent option
    view: ViewApi
    start: DateTime
    ``end``: DateTime
    startStr: string
    endStr: string
    allDay: bool
}

and EventAddData = {
    event: CalendarEvent
    relatedEvents: CalendarEvent array
    revert: unit -> unit
}

and EventApi = {
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
    setProp: string -> obj -> unit
    setExtendedProp: string -> obj -> unit
    setStart: DateTime -> SetStartOptions -> unit
    setEnd: DateTime option -> SetEndOptions -> unit
    setDates: DateTime -> DateTime option -> StartInputOptions -> unit
    moveStart: DurationObjectInput -> unit
    moveEnd: DurationObjectInput -> unit
    moveDates: DurationObjectInput -> unit
    setAllDay: bool -> SetAllDayOptions -> unit
    formatRange: FormatterInput -> obj
    remove: unit -> unit
    toPlainObject: ToPlainObjectSettings -> obj
    toJSON: unit -> obj
}

and EventSourceSuccessResponseHandler = obj * obj * obj -> obj array

and ViewApi = {
    calendar: CalendarApi
    ``type``: string
    title: string
    activeStart: DateTime
    activeEnd: DateTime
    currentStart: DateTime
    currentEnd: DateTime
    getOption: string -> unit
}
and DateUnselectArg = {
    jsEvent: MouseEvent
    view: ViewApi
}
and CalendarApi = {
    view: ViewApi
    updateSize: unit -> unit
    setOption: string -> obj -> unit
    getOption: string -> obj
    getAvailableLocaleCodes: unit -> string array
    on: string -> obj -> unit
    off: string -> obj -> unit
    trigger: string -> obj -> unit
    changeView: string -> DateRangeInput -> unit
    zoomTo: DateTime -> string -> unit
    prev: unit -> unit
    next: unit -> unit
    prevYear: unit -> unit
    nextYear: unit -> unit
    today: unit -> unit
    gotoDate: DateTime -> unit
    incrementDate: DurationObjectInput -> unit
    getDate: unit -> DateTime
    formatDate: DateTime -> FormatterInput -> unit
    formatRange: DateTime -> DateTime -> obj -> unit
    formatIso: DateTime -> bool -> string
    select: DateTime -> DateTime option -> unit
    unselect: DateUnselectArg -> unit
    addEvent: obj -> EventSourceImpl option -> EventImpl option
    getEventById: string -> EventImpl option
    getEvents: unit -> EventImpl array
    removeAllEvents: unit -> unit
    getEventSources: unit -> EventSourceImpl array
    getEventSourceById: string -> EventSourceImpl option
    addEventSource: obj -> EventSourceImpl
    removeAllEventSources: unit -> unit
    refetchEvents: unit -> unit
    scrollToTime: DurationObjectInput -> unit
}
and  DropInfo = {
    /// true or false whether dropped on one of the all-day cells.
    allDay: bool
    /// The Date of where the draggable was dropped.
    date: DateTime
    /// The ISO8601 string representation of where the draggable was dropped.
    dateStr: string
    /// The HTML element that was being dragged.
    draggedEl: HTMLElement
    /// The native JavaScript event with low-level information such as click coordinates.
    jsEvent: UIEvent
    /// If the current view is a resource-view, the Resource Object the element was dropped on. Must be using one of the resource plugins.
    resource: Resource
    /// The current View Object.
    view: ViewApi
}
and EventSource = {
    id: string
    url: string
    format: string
    color: string
    backgroundColor: string
    borderColor: string
    textColor: string
    className: string
    editable: bool
    startEditable: bool
    durationEditable: bool
    resourceEditable: bool
    display: string
    overlap: bool
    ``constraint``: string
    allow: DropInfo -> HTMLElement -> unit
    defaultAllDay: bool option
    success: EventSourceSuccessResponseHandler option
    failure: (CalendarError -> unit) option
    eventDataTransform: obj -> obj
    sourceId: string
    sourceDefId: int
    meta: obj
    publicId: string
    isFetching: bool
    latestFetchId: string
    fetchRange: DateRange option
    ui: EventUi
    extendedProps: obj
}

and EventSourceImpl = {
    internalEventSource: EventSource
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
    setProp: string -> obj -> unit
    setExtendedProp: string -> obj -> unit
    setStart: DateTime -> SetStartOptions -> unit
    setEnd: DateTime option -> SetEndOptions -> unit
    setDates: DateTime -> DateTime option -> StartInputOptions -> unit
    moveStart: DurationObjectInput -> unit
    moveEnd: DurationObjectInput -> unit
    moveDates: DurationObjectInput -> unit
    setAllDay: bool -> SetAllDayOptions -> unit
    formatRange: FormatterInput -> obj
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
and Resource = {
    /// the unique string identifier for this resource
    id: string
    /// the string title of this resource
    title: string
    /// a hash of non-standard props that were specified during parsing
    extendedProps: obj
    eventConstraint: string
    eventOverlap: bool
    eventAllow: bool
    eventBackgroundColor: string
    eventBorderColor: string
    eventTextColor: string
    eventClassNames: string array
    getParent: unit -> Resource
    getChildren: unit -> Resource array
    getEvents: unit -> CalendarEvent array
    remove: unit -> unit
}

type EventClickArg = {
    el: HTMLElement
    event: EventImpl
    jsEvent: UIEvent
    view: ViewApi
}

type EventDragInfo = {
    event: EventImpl
    jsEvent: UIEvent
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
    origEvent: UIEvent
    isTouch: bool
    subjectEl: EventTarget
    pageX: int
    pageY: int
    deltaX: int
    deltaY: int
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
    el: HTMLElement
    /// The native JavaScript event with low-level information such as click coordinates.
    jsEvent: UIEvent
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
    jsEvent: UIEvent
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
    dayEl: HTMLElement
    /// The native JavaScript event with low-level information such as click coordinates.
    jsEvent: UIEvent
    /// The current View Object.
    view: ViewApi
    /// If the current view is a resource-view, the Resource Object that owns this date. Must be using one of the resource plugins.
    resource: Resource
}

type CalendarRoot = {
    render: unit -> Fable.React.ReactElement
    componentDidMount: unit -> unit
    componentDidUpdate: unit -> unit
    componentWillUnmount: unit -> unit
    requestResize: unit -> unit
    doResize: unit -> unit
    cancelResize: unit -> unit
    getApi: unit -> CalendarApi
}

type EventInput = {
    extendedProps: obj
    start: DateTime
    ``end``: DateTime
    date: DateTime
    allDay: bool
    id: string
    groupId: string
    title: string
    url: string
    interactive: bool
}

type MouseInfo = {
    /// The associated Event Object.
    event: CalendarEvent
    /// The HTML element for this event.
    el: HTMLElement
    /// The native JavaScript event with low-level information such as click coordinates.
    jsEvent: UIEvent
    /// The current View Object.
    view: ViewApi
}
type EventInfo = {
    event: EventImpl
    relatedEvents: EventImpl array
    revert: unit -> unit
    draggedEl: HTMLElement
    view: ViewApi
}

type EventResizeInfo = {
    event: EventImpl
    relatedEvents: EventImpl array
    oldEvent: EventImpl
    endDelta: DurationObjectInput
    startDelta: DurationObjectInput
    revert: unit -> unit
    view: ViewApi
    el: HTMLElement
    jsEvent: UIEvent
}

type EventSegment = {
    event: EventImpl
    start: DateTime
    ``end``: DateTime
    isStart: bool
    isEnd: bool
}

type MoreLinkClickInfo = {
    date: DateTime
    allSegs: EventSegment array
    jsEvent: UIEvent
}