namespace FS.FluentUI.V8toV9

open Fable.React
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open FS.FluentUI.V8toV9

[<AutoOpen; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module FuiHelpers =
    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement = reactElement el (!!props |> createObj)
    let [<Literal>] FluentUIMigration = "@fluentui/react-migration-v8-v9"

type [<Erase>] Fui =

    /// Creates v9 brand colors from a v8 palette using interpolation.
    /// A v8 palette has nine colors and v9 has sixteen colors.
    static member inline createBrandVariants (theme: IPalette, interpolation: Interpolation option): 'T = import "createBrandVariants" FluentUIMigration

    // Stack
    static member inline stack (props: IStackProp list) = createElement (import "StackShim" FluentUIMigration) props
    static member inline stackItem (props: IStackItemProp list) = createElement (import "StackItemShim" FluentUIMigration) props
