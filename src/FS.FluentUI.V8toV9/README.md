# FS.FluentUI.V8toV9

### Migration for Microsoft's FluentUI V8 to V9 (React) made for F#

#### This project leverages V8 to V9 Shims in order to give usage of components like Stack and StackItem in conjunction with FS.FluentUI

```fsharp

open FS.FluentUI
open FS.FluentUI.V8toV9

[<ReactComponent>]
let ToggleButtons () =
    let isChecked1, setIsChecked1 = React.useState true
    let isChecked2, setIsChecked2 = React.useState false
    Fui.stack [
        stack.horizontal false
        stack.horizontalAlign.center
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

## Contributing
### Before sending PR's, please test what you've added in the "TestGrounds".
```bash
cd src/FS.FluentUI.TestGrounds
npm install
npm start
```

## Installation

Install into your Client.fsproj project using [Femto](https://github.com/Zaid-Ajaj/Femto) (recommended)
```bash
cd ./{path to Client}

# when using femto as a global CLI tool
femto install FS.FluentUI.V8toV9 --version 0.0.1-beta01

# when using femto as a local CLI tool
dotnet femto install FS.FluentUI.V8toV9 --version 0.0.1-beta01
```
This will install the nuget package and afterwards automatically installs the required npm packages used by this binding.

> Femto will detect whether you are using paket and will install the package using paket into the dependency group of the project

You can install the library manually if you want by first installing the nuget package
```bash
cd ./{path to your project}
dotnet add package FS.FluentUI.V8toV9 --version 0.0.1-beta01
```
