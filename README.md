# FS.FluentUI

### Microsoft's FluentUI V9 (React) made for F#

## ⚠️This repo is in beta. Some components/ functions are incomplete. Please feel free to send PR's and messages in order to get this library as close to 100% as possible!⚠️

If you don't see a component/ hook in this list.... just wait longer! 

| Complete Components| Complete Hooks / Functions | Components w/ TODO's or are unstable | Hooks / Functions w/ TODO's  |  Feature-complete but unstable         | Needs help with    |  Upcoming         |
| ------------- | -------------                   | -------------                        |-------------                 |        -------------                   |-------------       |    -------------  |
| Accordion     | useArrowNavigationGroup         |        Toast                         |  useToastController          | VirtualizerScrollViewDynamic (Preview) |  bundleIcon        |InteractionTag     |
| Avatar        |                useId            |                DatePicker            | createFluentIcon             |   useHeadlessFlatTree_unstable         |  makeStyles        |TagGroup           |
| AvatarGroup   |           useFocusableGroup     |     Table                            |                              |  Virtualizer (Preview)                 |useTableFeatures    | Tag               |
| Badge         |   partitionAvatarGroupItems     |                                       |                              |  Alert (Preview)                       |                    |   Rating           |
| CounterBadge  |           useOverflowMenu       |                                       |                              |  Drawer (Preview)                      |                    | BasicList         |
| PresenceBadge |      useIsOverflowItemVisible   |                                      |                               |InfoLabel (Preview)                     |                    | Breadcrumb         |
| Button        |   createTableColumn             |                                       |                              | VirtualizerScrollView (Preview)        |                    |    TeachingCallout |
| CompoundButton|  useStaticVirtualizerMeasure    |                                       |                              |                                        |                      |       Coachmark     |
| MenuButton    | useModalAttributes              |                                       |                              |                                        |                      |    MessageBar       |
| SplitButton   |       useObservedElement        |                                       |                              |                                         |                     |    PeoplePicker     |
| ToggleButton  |           useFocusFinders       |                                       |                              |                                        |                      |     Searchbox       |
| Card          |         useOverflowCount        |                                       |                              |                                        |                      | makeResetStyles     |
| CardFooter    |                                 |                                       |                              |                                        |                      |    Nav              |
| CardHeader    |                                 |                                       |                              |                                        |                      |  SwatchColorPicker  |
| CardPreview   |                                 |                                       |                              |                                         |                     | ColorPicker         |
| Checkbox      |                                 |                                       |                               |                                        |                      |  TimePicker         |
| Combobox      |                                 |                                       ||
| DataGrid      |                                  |                                      ||
| Dialog        |                                 |      
| Divider       |                                 |         
| Divider       |                                 |          
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

### Before sending PR's, please test what you've added in the "TestGrounds". 
`cd src/FS.FluentUI.TestGrounds`
`npm install`
`npm start`

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
