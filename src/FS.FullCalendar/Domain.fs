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

type ResourceMutation = {
    matchResourceId: string
    setResourceId: string
}

type EventMutation = {
    datesDelta: Duration
    startDelta: Duration
    endDelta: Duration
    standardProps: obj
    extendedProps: obj
    resourceMutation: ResourceMutation
}

type DateRange = { start: DateTime; ``end``: DateTime }

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
    resource: ResourceApi
}

and EventAddData = {
    event: EventImpl
    relatedEvents: EventImpl array
    revert: unit -> unit
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

and DateUnselectArg = { jsEvent: MouseEvent; view: ViewApi }

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
    unselect: unit -> unit
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
    ///  method that retrieves only top-level Resources.
    getTopLevelResources: unit -> ResourceApi array
    /// Causes the resource data to be fetched and freshly rerendered.
    refetchResources: unit -> unit
    /// A method that retrieves only top-level Resources.
    getResources: unit -> ResourceApi array
    /// A method that retrieves a specific Resource Object in memory.
    getResourceById: string -> ResourceApi option
    /// Allows programmatic rendering of a new resource on the calendar after the initial set of resources has already been displayed.
    addResource: obj -> bool -> ResourceApi
}

and DropInfo = {
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
    resource: ResourceApi
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

and EventDef = {
    allDay: bool
    defId: string
    extendedProps: obj
    groupId: string
    hasEnd: bool
    interactive: bool
    publicId: string
    recurringDef: RecurringDef option
    resourceIds: string array
    sourceId: string
    title: string
    url: string
    ui: EventUi
}

and EventInstance = {
    instanceId: string
    defId: string
    range: DateRange
    forcedStartTzo: int option
    forcedEndTzo: int option
}

and RecurringDef = {
    typeId: int
    typeData: obj
    duration: Duration option
}

and EventImpl = {
    getResources: unit -> ResourceApi array
    setResources: ResourceApi array -> unit
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
    _def: EventDef
    _instance: EventInstance option
    view: ViewApi
    editable: bool
    resourceEditable: bool
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

and ResourceApi = {
    remove: unit -> unit
    getParent: unit -> ResourceApi option
    getChildren: unit -> ResourceApi array
    getEvents: unit -> EventImpl array
    id: string
    title: string
    eventConstraint: string
    children: ResourceApi array
    eventOverlap: bool
    eventAllow: obj
    eventBackgroundColor: string
    eventBorderColor: string
    eventTextColor: string
    eventClassNames: string array
    extendedProps: obj
    toPlainObject: PlainObjectSettings -> obj
    toJSON: unit -> obj
    setProp: string -> obj -> unit
    setExtendedProp: string -> obj -> unit
    getResources: unit -> ResourceApi array
    setResources: ResourceApi array -> unit
}

and PlainObjectSettings = {
    collapseExtendedProps: bool
    collapseEventColor: bool
}

and DateSpanApi = {
    allDay: bool
    start: DateTime
    ``end``: DateTime
    startStr: string
    endStr: string
    resource: ResourceApi
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
    event: EventImpl
    /// An array of other related Event Objects that were also affected. an event might have other recurring event instances or might be linked to other events with the same groupId
    relatedEvents: EventImpl array
    /// An Event Object with data prior to the change
    oldEvent: EventImpl
    /// A function that can be called to reverse this action
    revert: unit -> unit
}

type RemoveInfo = {
    /// An Event Object with the updated changed data
    event: EventImpl
    /// An array of other related Event Objects that were also affected. an event might have other recurring event instances or might be linked to other events with the same groupId
    relatedEvents: EventImpl array
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
    event: EventImpl
    /// An array of other related Event Objects that were also dropped. an event might have other recurring event instances or might be linked to other events with the same groupId
    relatedEvents: EventImpl array
    /// An Event Object that holds information about the event before the drop.
    oldEvent: EventImpl
    /// If the resource has changed, this is the Resource Object the event came from. If the resource has not changed, this will be undefined. For use with the resource plugins only.
    oldResource: ResourceApi
    /// If the resource has changed, this is the Resource Object the event went to. If the resource has not changed, this will be undefined. For use with the resource plugins only.
    newResource: ResourceApi
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
    resource: ResourceApi
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
    resource: ResourceApi
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
    event: EventImpl
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

type FetchInfo = {
    start: DateTime
    ``end``: DateTime
    startStr: string
    endStr: string
    timeZone: string
}

type ResourceChangeInfo = {
    resource: ResourceApi
    oldResource: ResourceApi
    revert: unit -> unit
}

type ResourceRemoveInfo = {
    resource: ResourceApi
    revert: unit -> unit
}

type ResourceLabelContentArg = {
    resource: ResourceApi
    date: DateTime
    view: ViewApi
}

type ResourceLabelMountArg = {
    resource: ResourceApi
    date: DateTime
    view: ViewApi
    el: HTMLElement
}

type AddInfo = {
    resource: ResourceApi
    revert: unit -> unit
}

type MountInfo = { el: HTMLElement; view: ViewApi }

type EventContentArg = {
    event: EventImpl
    timeText: string
    backgroundColor: string
    borderColor: string
    textColor: string
    isDraggable: bool
    isStartResizable: bool
    isEndResizable: bool
    isMirror: bool
    isStart: bool
    isEnd: bool
    isPast: bool
    isFuture: bool
    isToday: bool
    isSelected: bool
    isDragging: bool
    isResizing: bool
    view: ViewApi
}
