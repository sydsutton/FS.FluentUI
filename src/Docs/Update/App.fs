module Docs.Update.App

open Elmish
open Docs.Model

let update msg model =
    match msg with
    | App.Msg.DoNothing -> model, Cmd.none
