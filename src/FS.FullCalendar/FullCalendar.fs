namespace FS.FullCalendar

open Fable.React
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open FS.FullCalendar
open System

[<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module Helpers =
    [<ImportDefault("@fullcalendar/react")>]
    let FullCalendar: ReactElementType = jsNative

    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement =
        reactElement el (!!props |> createObj)

[<RequireQualifiedAccess>]
[<Erase>]
type JSTuple =
    static member inline from2Args(args: 'T) = emitJsExpr args "$0[0], $0[1]"

[<System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module Plugin =

    [<ImportDefault("@fullcalendar/daygrid")>]
    let dayGridPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/timegrid")>]
    let timeGridPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/interaction")>]
    let interactionPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/bootstrap5")>]
    let bootstrap5Plugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/bootstrap")>]
    let bootstrapPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/multimonth")>]
    let multimonthPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/list")>]
    let listPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/moment")>]
    let momentPlugin: IPlugin = jsNative

    [<ImportDefault("@fullcalendar/moment-timezone")>]
    let momentTimezonePlugin: IPlugin = jsNative

type FullCalendar =
    static member inline Calendar(props: ICalendarProp list) =
        Helpers.createElement Helpers.FullCalendar props

    static member inline Draggable(el: Browser.Types.HTMLElement, props: IDraggableProp list) : unit =
        let props = !!props |> createObj |> unbox
        let draggable = import "Draggable" "@fullcalendar/interaction"
        createNew draggable (JSTuple.from2Args (el, props)) |> ignore

    static member inline Draggable(el: Browser.Types.HTMLElement) : unit =
        let draggable = import "Draggable" "@fullcalendar/interaction"
        createNew draggable el |> ignore
