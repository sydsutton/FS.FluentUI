# FS.FluentUI

## [V9 of Microsoft's FluentUI (React)](https://react.fluentui.dev/?path=/docs/concepts-introduction--page) made for F# in the style of Feliz

[![NuGet version (FS.FluentUI)](https://img.shields.io/nuget/v/FS.FluentUI.svg?style=flat-square)](https://www.nuget.org/packages/FS.FluentUI/)

![DataGridGif](https://github.com/sydsutton/FS.FluentUI/assets/83406605/e98ec82f-b0b1-4ae3-ba3e-ea0a94b462ab)

### Please see all F# component examples in the [FS.FluentUI Wiki](https://github.com/sydsutton/FS.FluentUI/wiki)
### Please check [Microsoft's documentation](https://react.fluentui.dev/?path=/docs/concepts-introduction--page) for further component usage and descriptions

## Overview
Fluent UI React Components is a set of UI components and utilities resulting from an effort to converge the set of React based component libraries in production today: @fluentui/react and @fluentui/react-northstar.

Each component is designed to adhere to the following standards:
* **Customizable**: Fluent-styled components by default, but easy to integrate your own brand and theme
* **Performance**: Optimized for render performance
* **Bundle size**: Refactored and slimmed down components that allow you to include the packages and dependencies you need
* **Accessibility**: WCAG 2.1 compliant and tested by trusted testers
* **Design to Code**: Stay up to date with Fluent Design Language changes via Design Tokens
  
**NOTE:** Some components/ functions are incomplete or still considered `Preview Components` and/or `unstable` by Microsoft. Please feel free to send PR's in order to get this library as close to 100% as possible!

Place a `Fui.fluentProvider` at the root of your app and pass the theme in as a prop. You can use pre-determined themes, or create your own `BrandVariants` or `Tokens` to use for your theme. See the [wiki](https://github.com/sydsutton/FS.FluentUI/wiki/FluentProvider---BrandVariants) for specific examples.

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
