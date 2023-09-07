namespace FS.FluentUI.V8toV9

open Fable.Core

type [<Erase>] IStackProp = interface end
type [<Erase>] IStackItemProp = interface end
type [<Erase>] IStackTokensProp = interface end
type [<Erase>] IStackTokens = interface end


[<RequireQualifiedAccess>]
type Interop =
    static member inline mkProperty<'ControlProperty> (key:string) (value:obj) : 'ControlProperty = unbox (key, value)
