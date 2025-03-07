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
    changeVie: string * DateRangeInput -> unit //TODO
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
    select: System.DateTime * System.DateTime -> unit //TODO
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

type Event = {
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
    jsEvent: Browser.Types.MouseEvent option
    view: ViewApi
    start: System.DateTime
    ``end``: System.DateTime
    startStr: string
    endStr: string
    allDay: bool
}

type EventAddData = {
    event: Event
    relatedEvents: Event array
    revert: unit -> unit //TODO
}

type EventClickArg = {
    el: Browser.Types.HTMLElement
    event: {|
        title: string
        remove: unit -> unit
    |} //TODO
    jsEvent: Browser.Types.MouseEvent
    view: ViewApi
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
