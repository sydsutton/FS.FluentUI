# FS.FluentUI

## Microsoft's FluentUI V9 (React) made for F# in the style of Feliz

[![NuGet version (FS.FluentUI)](https://img.shields.io/nuget/v/FS.FluentUI.svg?style=flat-square)](https://www.nuget.org/packages/FS.FluentUI/)

### Please see all component examples in the [FS.FluentUI Wiki](https://github.com/sydsutton/FS.FluentUI/wiki)

Some components/ functions are incomplete or still considered `Preview Components` and/or `unstable` by Microsoft. Please feel free to send PR's in order to get this library as close to 100% as possible!

Place a `Fui.fluentProvider` at the root of your app and pass the theme in as a prop. You can use pre-determined themes, or create your own `BrandVariants` or `Tokens` to use for your theme. See `src/TestGrounds/src/Main.fs` for specific examples. `BrandVariants` can be generated and copied over from Microsoft's [Theme Designer](https://react.fluentui.dev/?path=/docs/themedesigner--page). Simply pick your "Key color value", choose your theme, click `Export`, and convert the TS `BrandVariants` into something more F#.

```fsharp
open Feliz
open Browser.Dom
open FS.FluentUI
open FS.FluentUI.V8toV9

[<ReactComponent>]
let ToggleButtons () =
    let isChecked1, setIsChecked1 = React.useState true
    let isChecked2, setIsChecked2 = React.useState false
    Fui.stack [
        stack.horizontal true
        stack.tokens [ stack.tokens.childrenGap 16 ]
        stack.children [
            Fui.toggleButton [
                toggleButton.icon (Fui.icon.checkbox1Filled [])
                toggleButton.checked' isChecked1
                toggleButton.onClick (fun _ -> setIsChecked1 (isChecked1 |> not))
                toggleButton.text "Checked state"
            ]
            Fui.toggleButton [
                toggleButton.appearance.primary
                toggleButton.checked' isChecked2
                toggleButton.onClick (fun _ -> setIsChecked2 (isChecked2 |> not))
                toggleButton.text "Unchecked state"
            ]
            Fui.toggleButton [
                toggleButton.shape.circular
                toggleButton.disabledFocusable true
                toggleButton.text "Disabled focusable"
            ]
        ]
    ]

let root = ReactDOM.createRoot (document.getElementById "feliz-app")
root.render (
    Fui.fluentProvider [
        fluentProvider.theme.webDarkTheme
        fluentProvider.children [
            ToggleButtons ()
        ]
    ]
)
```

## Installation

Install into your Client.fsproj project using [Femto](https://github.com/Zaid-Ajaj/Femto) (recommended)
```bash
cd ./{path to Client}

# when using femto as a global CLI tool
femto install FS.FluentUI --version {newest version}

# when using femto as a local CLI tool
dotnet femto install FS.FluentUI --version {newest version}
```
This will install the nuget package and afterwards automatically installs the required npm packages used by this binding.

> Femto will detect whether you are using paket and will install the package using paket into the dependency group of the project

You can install the library manually if you want by first installing the nuget package
```bash
cd ./{path to your project}
dotnet add package FS.FluentUI --version {newest version}
```
