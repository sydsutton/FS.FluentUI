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

[<AutoOpen>]
type FC =
    static member inline FullCalendar(props: IFullCalendarProp list) =
        Helpers.createElement Helpers.FullCalendar props
