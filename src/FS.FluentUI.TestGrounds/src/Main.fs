module Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open Feliz.UseElmish
open FS.FluentUI
open FS.FluentUI.V8toV9

importSideEffects "./styles/global.scss"

let brandVariants = {
    ``10`` = "#050205"
    ``20`` = "#231120"
    ``30`` = "#3C1838"
    ``40`` = "#511C4B"
    ``50`` = "#67205F"
    ``60`` = "#7D2374"
    ``70`` = "#94258A"
    ``80`` = "#AC26A0"
    ``90`` = "#B83FAB"
    ``100`` = "#C156B4"
    ``110`` = "#CA6CBD"
    ``120`` = "#D280C6"
    ``130`` = "#DA94CF"
    ``140`` = "#E1A7D7"
    ``150`` = "#E9BAE0"
    ``160`` = "#EFCEE9"
}

let tokens = Theme.tokens

type Styles = { example: string; text: string }

let useStyles: unit -> Styles =
    Fui.makeStyles [
        "example",
        [
            style.backgroundColor tokens.colorBrandBackground2
            style.color tokens.colorBrandForeground2
            style.border (length.px 5, borderStyle.solid, tokens.colorBrandStroke1)
            style.borderRadius (length.px 5)
            style.margin (length.px 5)
            style.width (length.px 350)
            style.margin (length.auto)
        ]
        "text",
        [
            style.padding (length.px 5)
            style.fontSize (length.px 18)
        ]
    ]

[<ReactComponent>]
let TestGrounds () =
    let styles = useStyles ()

    let customTokens =
        {|
            colorBrandStroke1 = "#780510"
            colorBrandBackground2 = "#fa8072"
            colorBrandForeground2 = "#780510"
        |}
        |> unbox<Tokens>

    let model, dispatch = React.useElmish (TestGrounds.init, TestGrounds.update, [||])

    Fui.fluentProvider [
        fluentProvider.theme.webLightTheme
        fluentProvider.children [
            Fui.fluentProvider [
                fluentProvider.theme customTokens
                fluentProvider.children [
                    Html.div [
                        prop.className styles.example
                        prop.children [
                            Fui.text [
                                text.className styles.text
                                text.text "Nested FluentProvider with partial theme"
                            ]
                        ]
                    ]
                ]
            ]
            TestGrounds.view model dispatch
        ]
    ]

let root = ReactDOM.createRoot (document.getElementById "feliz-app")
root.render (TestGrounds())
