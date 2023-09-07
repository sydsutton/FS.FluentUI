module Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop
open Feliz.UseElmish
open FS.FluentUI
open FS.FluentUI.V8toV9

importSideEffects "./styles/global.scss"

let brandVariants = {
    ``10``= "#050205"
    ``20``= "#231120"
    ``30``= "#3C1838"
    ``40``= "#511C4B"
    ``50``= "#67205F"
    ``60``= "#7D2374"
    ``70``= "#94258A"
    ``80``= "#AC26A0"
    ``90``= "#B83FAB"
    ``100``= "#C156B4"
    ``110``= "#CA6CBD"
    ``120``= "#D280C6"
    ``130``= "#DA94CF"
    ``140``= "#E1A7D7"
    ``150``= "#E9BAE0"
    ``160``= "#EFCEE9"
}

let mediumDarkShadeBlue = {|
    themePrimary = "#343677"
    themeLighterAlt = "#f4f4fa"
    themeLighter = "#d4d5e9"
    themeLight = "#b2b4d6"
    themeTertiary = "#7375ae"
    themeSecondary = "#454788"
    themeDarkAlt = "#2f316c"
    themeDark = "#282a5b"
    themeDarker = "#1e1f43"
    neutralLighterAlt = "#faf9f8"
    neutralLighter = "#f3f2f1"
    neutralLight = "#edebe9"
    neutralQuaternaryAlt = "#e1dfdd"
    neutralQuaternary = "#d0d0d0"
    neutralTertiaryAlt = "#c8c6c4"
    neutralTertiary = "#595653"
    neutralSecondary = "#373532"
    neutralPrimaryAlt = "#2f2d2b"
    neutralPrimary = "#000000"
    neutralDark = "#151413"
    black = "#0b0a0a"
    white = "#ffffff"
|}

let v8Theme = ({| palette = mediumDarkShadeBlue |} |> unbox<IPartialTheme>)

let brandVarsFromV8Theme =
    match v8Theme.palette with
    | Some p -> Fui.createBrandVariants (p, None)
    | None -> brandVariants

[<ReactComponent>]
let TestGrounds () =
    let model, dispatch =
        React.useElmish (TestGrounds.init, TestGrounds.update, [||])

    TestGrounds.view model dispatch

let root = ReactDOM.createRoot (document.getElementById "feliz-app")
root.render (
    Fui.fluentProvider [
        fluentProvider.theme.customDarkTheme brandVarsFromV8Theme
        fluentProvider.children [
            TestGrounds()
        ]
    ]
)
