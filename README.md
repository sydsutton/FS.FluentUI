# FS.FluentUI
F# Bindings for Microsoft's FluentUI (React)

# Installation

Install into your Client.fsproj project using [Femto](https://github.com/Zaid-Ajaj/Femto) (recommended)
```bash
cd ./path/to/{Client.fsproj folder}

# when using femto as a global CLI tool
femto install FS.FluentUI

# when using femto as a local CLI tool
dotnet femto install FS.FluentUI
```
This will install the nuget package and afterwards automatically installs the required npm packages used by this binding.

> Femto will detect whether you are using paket and will install the package using paket into the dependency group of the project

You can install the library manually if you want by first installing the nuget package
```bash
cd ./path/to/YourProject
dotnet add package FS.FluentUI
```

## Local Project Usage
This is a work-in-progress!

To use the project locally (without nuget):

- Clone the project
- Add *ProjectReference* to your fable project
- Add *FS.FluentUI.fsproj* as content
- Open *FS.FluentUI* and use the components

# Examples

### Please see ```src/FS.FluentUI.TestGrounds/src/TestGrounds.fs``` for examples of every component
```fsharp

[<ReactComponent>]
let ToggleButtons () =
    let isChecked1, setIsChecked1 = React.useState true
    let isChecked2, setIsChecked2 = React.useState false
    Html.div [
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

```
