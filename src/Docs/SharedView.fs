module Docs.SharedView

open FS.FluentUI
open Feliz
open Router

type menuItem
    with
        static member inline href (p:Page) = Interop.mkProperty<IMenuItemProp> "href" (p |> Page.toUrlSegments |> Router.format)
