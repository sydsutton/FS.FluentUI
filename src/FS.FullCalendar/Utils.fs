namespace FS.FullCalendar

open Fable.Core

[<RequireQualifiedAccess>]
type Interop =
    static member inline mkProperty<'ControlProperty> (key: string) (value: obj) : 'ControlProperty = unbox (key, value)

[<Erase>]
type IFullCalendarProp = interface end

[<Erase>]
type IPlugin = interface end

[<Erase>]
type IEventProp = interface end

[<Erase>]
type ICustomButtonProp = interface end

[<Erase>]
type IHeaderToolbarProp = interface end

[<Erase>]
type IFooterToolbarProp = interface end

[<Erase>]
type IDateFormatProp = interface end

[<Erase>]
type IButtonTextProp = interface end

[<Erase>]
type IButtonIconProp = interface end

[<Erase>]
type IDayProp = interface end

[<Erase>]
type IDurationProp = interface end

[<Erase>]
type IRangeProp = interface end

[<Erase>]
type IBusinessDayProp = interface end
