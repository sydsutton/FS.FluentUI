# FS.FluentUI

### Microsoft's FluentUI V9 (React) made for F#

[![NuGet version (FS.FluentUI)](https://img.shields.io/nuget/v/FS.FluentUI.svg?style=flat-square)](https://www.nuget.org/packages/FS.FluentUI/)

### ⚠️This repo is in beta. Some components/ functions are incomplete. Please feel free to send PR's and messages in order to get this library as close to 100% as possible!⚠️

#### Please see ```src/FS.FluentUI.TestGrounds/src/TestGrounds.fs``` for examples of every component
```fsharp
open FS.FluentUI

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
## Components / Hooks
If you don't see a component/ hook in this list.... just wait longer!

| Complete Components| Complete Hooks / Functions | Has TODO's or are unstable          |  Upcoming         |
| ------------- | -------------                   | -------------                        |    -------------  |
| Accordion     | useArrowNavigationGroup         |        Toast                         |    TimePicker     |
| Avatar        |                useId            |                DatePicker            |     ColorPicker    |
| AvatarGroup   |           useFocusableGroup     |     Table                            |   SwatchColorPicker  |
| Badge         |   partitionAvatarGroupItems     |VirtualizerScrollViewDynamic (Preview) |     Rating           |
| CounterBadge  |           useOverflowMenu       | Virtualizer (Preview)                |   BasicList         |
| PresenceBadge |      useIsOverflowItemVisible   |   Alert (Preview)                    |    makeResetStyles   |
| Button        |   createTableColumn             |       Drawer (Preview)               |   TeachingCallout |
| CompoundButton|  useStaticVirtualizerMeasure    |      InfoLabel (Preview)             |      Coachmark     |
| MenuButton    | useModalAttributes              |  VirtualizerScrollView (Preview)      |     MessageBar       |
| SplitButton   |       useObservedElement        |  InteractionTag (Preview)         |    PeoplePicker     |
| ToggleButton  |           useFocusFinders       |        TagGroup (Preview)             |                         |
| Card          |         useOverflowCount        |        Tag (Preview)             |                         |
| CardFooter    |                                 |         Breadcrumb (Preview)        |                        |
| CardHeader    |                                 |         Searchbox (Preview)         |                       |
| CardPreview   |                                 |                                       |                      |
| Checkbox      |                                 |       useToastController               |                     |
| Combobox      |                                 |        createFluentIcon               |                        |
| DataGrid      |                                  |    useHeadlessFlatTree_unstable    |                          |
| Dialog        |                                 |bundleIcon                           |
| Divider       |                                 |makeStyles                           |
| Divider       |                                 |useTableFeatures                     |
| Dropdown      |
| Tablist       |
| Field|
| FluentProvider|
| Image|
| Input|
| Label|
| Link|
| Menu |
| Overflow|
| Persona|
| Popover|
| Portal |
| ProgressBar|
| Radio |
| RadioGroup|
| Select|
| Skeleton|
| Slider|
| SpinButton|
| Switch|
| Text |
| Textarea|
| Toolbar|
| Tree|
| Tooltip|

I have done my best so far to keep usage of these similar to Typescript usage in the docs. See docs for more usage examples:
Microsoft Documentation: [Docs](https://react.fluentui.dev/?path=/docs/concepts-introduction--page)

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
