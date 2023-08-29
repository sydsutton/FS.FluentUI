# FS.FluentUI
F# Bindings for Microsoft's FluentUI (React)

## ⚠️This repo is in beta. Some components/ functions are incomplete. Please feel free to send PR's and messages in order to get this library as close to 100% as possible!⚠️
Components and functions: 

| Complete Components    |                |                  | Complete Functions / Hooks            | Incomplete |
| ------------- | -------------  |-------------     |-------------           |------------- |
| Accordion     | Dropdown       | Tablist          |useArrowNavigationGroup |Breadcrumb |
| Avatar        | Field          | Text             |useFocusableGroup       |Searchbox |
| AvatarGroup   | FluentProvider | Textarea         |useId                   | Tag  |
| Badge         | Image          | Toast            |partitionAvatarGroupItems| InteractionTag |
| CounterBadge  | Input          |Toolbar           |makeResetStyles         | TagGroup |
| PresenceBadge | Label          |Tree              |useOverflowMenu         | Rating |
| Button        | Link           | Tooltip          |DatePicker              | BasicList |
| CompoundButton| Menu           |Alert (Preview)   |useIsOverflowItemVisible| TeachingCallout |
| MenuButton    |  MenuList      | Drawer (Preview) |useIsOverflowGroupVisible| Coachmark |
| SplitButton   | Overflow       |InfoLabel (Preview|createTableColumn       | MessageBar |
| ToggleButton  | Persona        | Virtualizer (Preview)|useStaticVirtualizerMeasure| PeoplePicker | 
| Card          | Popover        | VirtualizerScrollView (Preview)|useModalAttributes| Nav |
| CardFooter    | Portal         | VirtualizerScrollViewDynamic (Preview)|useObservedElement| SwatchColorPicker |
| CardHeader    | ProgressBar    |DatePicker        |useHeadlessFlatTree_unstable|ColorPicker |
| CardPreview   | Radio          |                  |useFocusFinders          | TimePicker|
| Checkbox      | RadioGroup     |                  |useOverflowCount         | bundleIcon|
| Combobox      | Select         |                  |                         |useToastController| 
| DataGrid      | Skeleton       |                  |                         |createFluentIcon |
| Dialog        | Slider         |                  |                         |makeStyles |
| Divider       | SpinButton     |                  |                         | Table |
| Divider       | Switch         |                  |                         |

Microsoft Documentation: [Docs](https://react.fluentui.dev/?path=/docs/concepts-introduction--page)
# Installation

Install into your Client.fsproj project using [Femto](https://github.com/Zaid-Ajaj/Femto) (recommended)
```bash
cd ./{path to Client}

# when using femto as a global CLI tool
femto install FS.FluentUI

# when using femto as a local CLI tool
dotnet femto install FS.FluentUI
```
This will install the nuget package and afterwards automatically installs the required npm packages used by this binding.

> Femto will detect whether you are using paket and will install the package using paket into the dependency group of the project

You can install the library manually if you want by first installing the nuget package
```bash
cd ./{path to your project}
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
