module Docs.App

open Elmish
open Elmish.React
open Docs.Model
open Docs.Update
open Docs.View

Program.mkProgram App.init App.update App.view
|> Program.withReactSynchronous "elmish-app"
|> Program.withConsoleTrace
|> Program.run
