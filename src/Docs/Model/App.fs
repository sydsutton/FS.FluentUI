module Docs.Model.App

open Elmish

type Model = {
    CurrentUrl : string list
}

[<RequireQualifiedAccess>]
type Msg =
    | DoNothing

let init () =
    { CurrentUrl = [""] }, Cmd.none
