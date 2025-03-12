module TestGrounds

open Elmish
open Feliz
open FS.FluentUI
open FS.FluentUI.V8toV9
open FS.FullCalendar
open Browser.Types

type Msg = ChangeEmail of string

type Model = { Email: string }

let init () = { Email = "" }, Cmd.none

let update msg model =
    match msg with
    | ChangeEmail e -> { model with Email = e }, Cmd.none

let tokens = Theme.tokens

type Styles = {
    accordion: string
    useArrowNavigationGroup: string
    tooltip: string
    icon: string
    compoundButton: string
    splitButton: string
    skeletonStack: string
    day: string
    overflow: string
    breadcrumb: string
    portalContainer: string
    portal: string
    backgroundColor: string
    yellowText: string
    borderRadius: string
    root: string
    rectangle: string
    visible: string
    swatchExample: string
    swatchButton: string
    swatchInput: string
}

let useStyles =
    Fui.makeStyles<Styles> [
        "accordion",
        [
            style.color.red
            style.backgroundColor.darkGray
        ]
        "useArrowNavigationGroup",
        [
            style.display.flex
            style.columnGap 15
        ]
        "tooltip",
        [
            style.backgroundColor tokens.colorBrandBackground
            style.color tokens.colorNeutralForegroundInverted
        ]
        "icon", [ style.color.green ]
        "compoundButton", [ style.width (length.px 150) ]
        "splitButton", [ style.width (length.px 150) ]
        "skeletonStack",
        [
            style.backgroundColor tokens.colorBrandForegroundOnLight
            style.padding (length.px 50)
        ]
        "day", [ style.border (1, borderStyle.solid, "red") ]
        "overflow",
        [
            style.overflow.hidden
            style.display.flex
            style.flexWrap.nowrap
            style.minWidth (length.px 200)
            style.maxWidth (length.px 900)
            style.height (length.px 30)
            style.resize.horizontal
            style.border (1, borderStyle.solid, "lightGray")
            style.padding (length.px 16)
            style.zIndex 0
        ]
        "breadcrumb",
        [
            style.backgroundColor tokens.colorNeutralBackground2
            style.overflow.hidden
            style.padding (length.px 25)
            style.height (length.px 50)
            style.minWidth (length.px 150)
            style.zIndex 0
            style.resize.horizontal
            style.maxWidth (length.px 600)
        ]
        "portalContainer",
        [
            style.border (3, borderStyle.dashed, "gray")
            style.padding (length.px 5)
        ]
        "portal",
        [
            style.backgroundColor tokens.colorPaletteYellowBackground3
            style.border (3, borderStyle.dashed, "gray")
            style.padding (length.px 5)
        ]
        "backgroundColor", [ style.backgroundColor "red" ]
        "yellowText", [ style.color "yellow" ]
        "borderRadius", [ style.borderRadius (20, 5, 20, 5) ]
        "root",
        [
            style.height (length.px 180)
            style.display.flex
            style.flexDirection.column
            style.alignItems.center
            style.rowGap (length.px 24)
        ]
        "rectangle",
        [
            style.borderRadius (length.px 8)
            style.width (length.px 150)
            style.height (length.px 100)
            style.display.flex
            style.flexDirection.column
            style.alignContent.center
            style.justifyContent.center
            style.backgroundColor tokens.colorBrandBackground
            style.opacity 0
            style.transform.translate3D (0, 0, 0)
            style.transform.scale 0.25
            style.custom ("transitionDuration", $"{tokens.durationSlow}, {tokens.durationSlower}")
            style.transitionProperty "opacity, transform"
            style.custom ("willChange", "opacity, transform")
            style.color.white
            style.flexWrap.wrap
        ]
        "visible",
        [
            style.opacity 1
            style.transform.translate3D (0, 0, 0)
            style.transform.scale 1
        ]
        "swatchExample",
        [
            style.width (length.px 100)
            style.height (length.px 100)
            style.border (1, borderStyle.solid, "#ccc")
            style.margin (length.px 20)
        ]
        "swatchButton", [ style.marginRight (length.px 8) ]
        "swatchInput",
        [
            style.display.block
            style.margin (length.px 10)
        ]
    ]

[<ReactComponent>]
let Accordion () =
    let openItems, setOpenItems = React.useState [ 1 ]

    let getIcon key =
        if openItems |> List.contains key then
            Fui.icon.subtractFilled []
        else
            Fui.icon.addFilled []

    Fui.accordion [
        accordion.collapsible true
        accordion.openItems openItems
        accordion.onToggle (fun (i: AccordionToggleData<int>) -> setOpenItems (i.openItems |> Array.toList))
        accordion.multiple true
        accordion.children [
            Fui.accordionItem [
                accordionItem.key "a"
                accordionItem.value 1
                accordionItem.children [
                    Fui.accordionHeader [
                        accordionHeader.expandIcon (getIcon 1)
                        accordionHeader.expandIconPosition.end'
                        accordionHeader.children [ Fui.text "Header 1" ]
                    ]
                    Fui.accordionPanel [ Fui.text "Panel 1" ]
                ]
            ]
            Fui.accordionItem [
                accordionItem.key "b"
                accordionItem.value 2
                accordionItem.children [
                    Fui.accordionHeader [
                        accordionHeader.expandIcon (getIcon 2)
                        accordionHeader.children [ Fui.text "Header 2" ]
                    ]
                    Fui.accordionPanel [ Fui.text "Panel 2" ]
                ]
            ]
            Fui.accordionItem [
                accordionItem.key "c"
                accordionItem.value 3
                accordionItem.children [
                    Fui.accordionHeader [
                        accordionHeader.expandIcon (getIcon 3)
                        accordionHeader.children [ Fui.text "Header 3" ]
                    ]
                    Fui.accordionPanel [ Fui.text "Panel 3" ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let Checkbox () =
    let isChecked1, setIsChecked1 = React.useState true
    let isChecked2, setIsChecked2 = React.useState Mixed

    Html.div [
        Fui.checkbox [
            checkbox.checked' isChecked1
            checkbox.onChange (fun i -> setIsChecked1 i)
            checkbox.size.large
            checkbox.label (Fui.text "This is a label")
            checkbox.indicator (Fui.icon.alignStartHorizontalRegular [])
            checkbox.shape.circular
            checkbox.labelPosition.before
        ]
        Fui.checkbox [
            checkbox.label "Hello"
            checkbox.checked' isChecked2
            checkbox.onChange (fun ev i -> setIsChecked2 i)
            checkbox.size.medium
            checkbox.labelPosition.after
        ]
    ]

let avatarTest =
    Fui.avatar [
        avatar.image [
            image.src "https://fabricweb.azureedge.net/fabric-website/assets/images/avatar/KatriAthokas.jpg"
        ]
        avatar.name "Katri Athokas"
        avatar.color.forest
        avatar.size.``96``
        avatar.shape.circular
        avatar.badge [ presenceBadge.status.outOfOffice ]
    ]

let buttonTest =
    Fui.button [
        button.text "Testing"
        button.icon (
            Fui.icon.accessTimeFilled [
                icon.primaryFill "orange"
                icon.title "Testing title"
                icon.className "Test-classname"
            ]
        )
        button.appearance.primary
        button.size.large
        button.iconPosition.before
        button.shape.circular
        button.onClick (fun (_: MouseEvent) -> printfn "hello")
    ]

let menuButtonTest =
    Fui.menuButton [
        menuButton.icon (Fui.icon.import "AddFilled" [])
        menuButton.onClick (fun _ -> printfn "menuButton clicked")
        menuButton.shape.square
        menuButton.menuIcon (Fui.icon.arrowUpFilled [])
        menuButton.appearance.secondary
        menuButton.text "This is a menu button"
    ]

let AccessTimeIcon =
    Fui.bundleIcon { Filled = bundleIcons.import "LayoutColumnThreeFocusLeftFilled"; Regular = bundleIcons.accessTime.Regular }

let DataIcon =
    Fui.bundleIcon bundleIcons.dataArea

let FunnelIcon =
    Fui.bundleIcon bundleIcons.dataFunnel

[<ReactComponent>]
let MenuTest () =
    let checkedValues, setCheckedValues =
        React.useState (
            [
                "data", [| "add" |]
                "info", [| "filterInfo" |]
            ]
        )
    let isOpen, setIsOpen = React.useState false
    let iconStyles = icon.style [ style.fontSize (length.rem 1)]

    Fui.menu [
        menu.checkedValues checkedValues
        menu.open' isOpen
        menu.positioning [
            positioning.coverTarget true
        ]
        menu.onOpenChange (fun (d: MenuOpenChangeData) -> setIsOpen d.``open``)
        menu.onCheckedValueChange (fun (_: MouseEvent) (d: MenuCheckedValueChangeData) ->
            setCheckedValues ([ d.name, d.checkedItems ] |> List.append checkedValues))
        menu.children [
            Fui.menuTrigger [
                menuTrigger.disableButtonEnhancement true
                menuTrigger.children (Fui.button [ button.text "Toggle menu" ])
            ]
            Fui.menuPopover [
                Fui.menuList [
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.compact
                        menuItemCheckbox.icon (AccessTimeIcon [ iconStyles ])
                        menuItemCheckbox.name "data"
                        menuItemCheckbox.value "add"
                        menuItemCheckbox.text "Add Data"
                    ]
                    Fui.menuItemLink [
                        menuItemLink.compact
                        menuItemLink.icon (DataIcon [ iconStyles ])
                        menuItemLink.name "data"
                        menuItemLink.value "trends"
                        menuItemLink.text "Show Trends"
                    ]
                    Fui.menuItemRadio [
                        menuItemRadio.compact
                        menuItemRadio.icon (FunnelIcon [ iconStyles ])
                        menuItemRadio.name "data"
                        menuItemRadio.value "filter"
                        menuItemRadio.text "Filter Data"
                    ]
                    Fui.menuDivider []
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.compact
                        menuItemCheckbox.icon (AccessTimeIcon [ iconStyles ])
                        menuItemCheckbox.name "info"
                        menuItemCheckbox.value "addInfo"
                        menuItemCheckbox.text "Add Info"
                    ]
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.compact
                        menuItemCheckbox.icon (DataIcon [ iconStyles ])
                        menuItemCheckbox.name "info"
                        menuItemCheckbox.value "infoTrends"
                        menuItemCheckbox.text "Show Info Trends"
                    ]
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.compact
                        menuItemCheckbox.icon (FunnelIcon [ iconStyles ])
                        menuItemCheckbox.name "info"
                        menuItemCheckbox.value "filterInfo"
                        menuItemCheckbox.text "Filter Info"
                    ]
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.compact
                        menuItemCheckbox.disabled true
                        menuItemCheckbox.icon (Fui.icon.editFilled [ iconStyles ])
                        menuItemCheckbox.name "disabled"
                        menuItemCheckbox.value "disabled"
                        menuItemCheckbox.text "Show Debug Panel"
                    ]
                    Fui.menuItemSwitch [
                        menuItemSwitch.compact
                        menuItemSwitch.name "new-explorer"
                        menuItemSwitch.value "new-explorer"
                        menuItemSwitch.text "Try V2"
                    ]
                    Fui.menuDivider []
                    Fui.menu [
                        menu.children [
                            Fui.menuSplitGroup [
                                Fui.menuItem [
                                    menuItem.compact
                                    menuItem.text "Open"
                                ]
                                Fui.menuTrigger [
                                    menuTrigger.disableButtonEnhancement true
                                    menuTrigger.children (Fui.menuItem [ menuItem.compact; menuItem.ariaLabel "Open on platform" ])
                                ]
                            ]
                            Fui.menuPopover [
                                menuPopover.children [
                                    Fui.menuList [
                                        Fui.menuItem [
                                            menuItem.compact
                                            menuItem.text "In Browser"
                                        ]
                                        Fui.menuItem [
                                            menuItem.compact
                                            menuItem.text "In Desktop App"
                                        ]
                                        Fui.menuItem [
                                            menuItem.compact
                                            menuItem.text "In Mobile"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let CheckedIcon =
    Fui.bundleIcon bundleIcons.checkbox1

[<ReactComponent>]
let ToggleButtons () =
    let isChecked1, setIsChecked1 = React.useState true
    let isChecked2, setIsChecked2 = React.useState false

    Html.div [
        Fui.toggleButton [
            toggleButton.icon (CheckedIcon [])
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

let imageTest =
    Fui.image [
        image.src "https://fabricweb.azureedge.net/fabric-website/assets/images/avatar/KatriAthokas.jpg"
        image.bordered true
        image.alt "Person"
        image.shape.rounded
        image.fit.default'
        image.height 100
        image.width 100
    ]

let presenceBadgeTest =
    Fui.presenceBadge [
        presenceBadge.status.doNotDisturb
        presenceBadge.size.extraLarge
    ]

let counterBadge =
    Html.div [
        Fui.counterBadge [
            counterBadge.count 5
            counterBadge.appearance.filled
            counterBadge.color.brand
        ]
        Fui.counterBadge [
            counterBadge.count 5
            counterBadge.appearance.filled
            counterBadge.color.danger
        ]
        Fui.counterBadge [
            counterBadge.count 5
            counterBadge.appearance.filled
            counterBadge.color.important
        ]
        Fui.counterBadge [
            counterBadge.count 5
            counterBadge.appearance.filled
            counterBadge.color.informative
        ]
        Fui.counterBadge [
            counterBadge.count 0
            counterBadge.dot true
        ]
    ]

let linkTest =
    Fui.link [
        link.appearance.subtle
        link.href "/#"
        link.text "Home link"
        link.as'.button
    ]

let divider =
    Fui.divider [
        divider.vertical false
        divider.appearance.brand
        divider.style [
            style.color.red
            style.fontWeight 700
        ]
        divider.text "Divider"
    ]

let textTest =
    Fui.stack [
        stack.horizontal true
        stack.tokens [ stack.tokens.childrenGap 16 ]
        stack.children [
            Fui.text [
                text.text "Test 1"
                text.italic true
                text.font.base'
                text.size.``500``
                text.weight.medium
            ]
            Fui.text [
                text.text "Test 2"
                text.strikeThrough true
                text.font.monospace
                text.size.``1000``
                text.weight.regular
            ]
            Fui.text [
                text.text "This is test 3 and the text should wrap"
                text.style [ style.maxWidth 150 ]
                text.underline true
                text.wrap true
                text.font.numeric
                text.size.``200``
                text.weight.semibold
                text.align.end'
            ]
            Fui.text [
                text.text "This is test 4 and the text should NOT wrap"
                text.style [ style.maxWidth 150 ]
                text.underline false
                text.wrap false
                text.size.``200``
                text.weight.bold
                text.truncate true
            ]
            Fui.text.body1 [
                text.italic true
                text.text "Body 1"
            ]
            Fui.text.body1Strong [
                text.underline true
                text.text "Body 1 Strong"
            ]
            Fui.text.display [ text.text "Display" ]
        ]
    ]

[<ReactComponent>]
let UseArrowNavigationGroup () =
    let keyboardNavAttr =
        Fui.useArrowNavigationGroup [
            useArrowNavigationGroupOptions.circular true
            useArrowNavigationGroupOptions.ignoreDefaultKeydown [
                ignoreKeyDown.arrowDown true
                ignoreKeyDown.end' false
            ]
        ]

    let styles = useStyles ()

    Html.div [
        prop.ariaLabel "Editor toolbar example"
        prop.role "toolbar"
        prop.className styles.useArrowNavigationGroup
        keyboardNavAttr
        prop.children [
            Fui.button [
                button.icon (Fui.icon.textBoldRegular [])
                button.ariaLabel "Bold"
            ]
            Fui.button [
                button.icon (Fui.icon.textUnderlineRegular [])
                button.ariaLabel "Underline"
            ]
            Fui.button [
                button.icon (Fui.icon.textUnderlineRegular [])
                button.ariaLabel "Underline"
            ]
            Fui.button [
                button.icon (Fui.icon.textItalicRegular [])
                button.ariaLabel "Italic"
            ]
            Fui.button [
                button.icon (Fui.icon.textAlignLeftRegular [])
                button.ariaLabel "Align Left"
            ]
            Fui.button [
                button.icon (Fui.icon.textAlignCenterRegular [])
                button.ariaLabel "Align Center"
            ]
            Fui.button [
                button.icon (Fui.icon.textAlignRightRegular [])
                button.ariaLabel "Align Right"
            ]
            Fui.button [
                button.icon (Fui.icon.copyRegular [])
                button.ariaLabel "Copy"
            ]
            Fui.button [
                button.icon (Fui.icon.cutRegular [])
                button.ariaLabel "Cut"
            ]
            Fui.button [
                button.icon (Fui.icon.clipboardPasteRegular [])
                button.ariaLabel "Paste"
            ]
        ]
    ]

[<ReactComponent>]
let PopoverTest () =
    let visible, setVisible = React.useState false
    let target, setTarget = React.useState None

    Fui.stack [
        stack.horizontal true
        stack.tokens [ stack.tokens.childrenGap 16 ]
        stack.children [
            // trigger button
            Fui.popover [
                popover.appearance.brand
                popover.positioning [
                    positioning.position.above
                    positioning.align.start
                    positioning.target target
                    positioning.coverTarget true
                    positioning.offset [ offset.crossAxis 25 ]
                ]
                popover.onOpenChange (fun (data: OpenProp) ->
                    if data.``open`` = false then
                        setVisible false)
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (Fui.button [ button.text "Toggle Popover" ])
                    ]
                    Fui.popoverSurface [
                        popoverSurface.style [
                            style.display.flex
                            style.flexDirection.column
                            style.height 100
                            style.alignContent.center
                            style.justifyContent.center
                        ]
                        popoverSurface.children [
                            Fui.text "This is example content"
                            if visible then
                                Fui.text "This is the more stuff LOL"
                            else
                                Fui.button [
                                    button.text "Show more stuff"
                                    button.onClick (fun _ -> setVisible true)
                                ]
                        ]
                    ]
                ]
            ]
            // target button
            Fui.button [
                button.ref (fun t -> setTarget (Some t))
                button.text "Custom target"
            ]
        ]
    ]

let tooltipTest =
    Fui.tooltip [
        tooltip.withArrow true
        tooltip.content (Fui.text "Example tooltip")
        tooltip.relationship.label
        tooltip.positioning.belowStart
        tooltip.onVisibleChange (fun (v: OnVisibleChangeData) -> printfn "v %A" v.visible)
        tooltip.children (
            Fui.button [
                button.size.large
                button.icon (Fui.icon.slideTextRegular [])
            ]
        )
    ]

let labelTest =
    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.label [
                label.text "This is a label"
                label.required true
                label.weight.semibold
                label.size.small
            ]
            Fui.label [
                label.text "This is a label"
                label.required "**!**"
                label.weight.semibold
                label.size.large
            ]
            Fui.label [
                label.text "This is a label"
                label.required (Fui.icon.alignStartVerticalRegular [])
                label.weight.semibold
                label.size.large
            ]
        ]
    ]

let findIconsWithoutFilledOrRegularVersions (icons: string list) =
    let filledIcons = icons |> List.filter (fun i -> i.EndsWith "Filled")
    let regularIcons = icons |> List.filter (fun i -> i.EndsWith "Regular")

    let baseFilled = filledIcons |> List.map (fun i -> i.Replace("Filled", ""))
    let baseRegular = regularIcons |> List.map (fun i -> i.Replace("Regular", ""))

    let missingRegular = baseFilled |> List.filter (fun i -> baseRegular |> List.contains i |> not)
    let missingFilled = baseRegular |> List.filter (fun i -> baseFilled |> List.contains i |> not)

    printfn "Missing regular: %A" missingRegular
    printfn "Missing filled: %A" missingFilled

[<ReactComponent>]
let IconTest () =
    let styles = useStyles ()

    Fui.stack [
        stack.horizontal true
        stack.children [
            Fui.icon.zoomFitFilled [
                icon.size.``48``
                icon.className styles.icon
            ]
        ]
    ]

let inputTest model dispatch =
    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.stack [
                stack.horizontal false
                stack.children [
                    Fui.label [
                        label.htmlFor "emailId"
                        label.text "Email input"
                        label.required true
                    ]
                    Fui.input [
                        input.type'.email
                        input.id "emailId"
                        input.value model.Email
                        input.onChange (fun (v: ValueProp<string>) -> ChangeEmail v.value |> dispatch)
                        input.contentBefore (Fui.icon.albumAddFilled [])
                        input.contentAfter (Fui.icon.airplaneRegular [])
                        input.size.large
                        input.appearance.outline
                    ]
                ]
            ]
            Fui.stack [
                stack.horizontal false
                stack.children [
                    Fui.label [
                        label.htmlFor "urlId"
                        label.text "URL input"
                    ]
                    Fui.input [
                        input.type'.url
                        input.size.small
                        input.contentBefore (Fui.icon.alertBadgeRegular [])
                        input.id "urlId"
                        input.appearance.underline
                    ]
                ]
            ]
            Fui.stack [
                stack.horizontal false
                stack.children [
                    Fui.label [
                        label.htmlFor "passwordId"
                        label.text "Password input"
                    ]
                    Fui.input [
                        input.appearance.filledLighterShadow
                        input.type'.password
                        input.id "passwordId"
                        input.disabled true
                        input.defaultValue "password123"
                        input.onChange (fun (d: ValueProp<string>) -> printfn "d %A" d.value)
                    ]
                ]
            ]
            Fui.stack [
                stack.horizontal false
                stack.children [
                    Fui.label [
                        label.htmlFor "weekId"
                        label.text "Week input"
                    ]
                    Fui.input [
                        input.appearance.outline
                        input.type'.week
                        input.id "weekId"
                        input.onChange (fun (ev: Event) (w: ValueProp<string>) -> printfn "value: %A" w.value)
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let CompoundButtonTest () =
    let styles = useStyles ()

    Fui.compoundButton [
        compoundButton.appearance.primary
        compoundButton.className styles.compoundButton
        compoundButton.text "This should be the main text"
        compoundButton.secondaryContent "This should be the secondary text"
        compoundButton.icon (Fui.icon.calendarMonthRegular [])
        compoundButton.size.large
        compoundButton.as'.button
    ]

[<ReactComponent>]
let SplitButtonTest () =
    let styles = useStyles ()

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.menu [
                Fui.menuTrigger [
                    menuTrigger.disableButtonEnhancement true
                    menuTrigger.children (fun p ->
                        Fui.splitButton [
                            splitButton.menuButton p
                            splitButton.primaryActionButton [
                                button.className styles.splitButton
                                button.size.small
                                button.text "Primary action button"
                            ]
                            splitButton.icon (Fui.icon.shareAndroidRegular [])
                        ])
                ]
                Fui.menuPopover [
                    Fui.menuList [
                        Fui.menuItem [ menuItem.text "Item a" ]
                        Fui.menuItem [ menuItem.text "Item b" ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let TextAreaTest () =
    let value, setValue = React.useState "Not past 20 chars"

    Fui.textArea [
        textArea.size.large
        textArea.onChange (fun (d: ValueProp<string>) ->
            if d.value.Length <= 20 then
                setValue d.value
            else
                setValue value)
        textArea.value value
        textArea.appearance.outline
        textArea.resize.both
    ]

[<ReactComponent>]
let SliderTest () =
    let id = Fui.useId ()
    let value, setValue = React.useState (100)
    let valueText = $"Current Value: {value}"

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.label [
                label.htmlFor "sliderId"
                label.text valueText
            ]
            Fui.slider [
                slider.ariaValueText valueText
                slider.value value
                slider.min 0
                slider.max 200
                slider.size.medium
                slider.step 20
                slider.id id
                slider.onChange (fun (d: ValueProp<int>) -> setValue d.value)
            ]
            Fui.button [
                button.text "Reset"
                button.onClick (fun (e: MouseEvent) -> setValue 100)
            ]
        ]
    ]

[<ReactComponent>]
let SwitchTest () =
    let checked', setChecked = React.useState false

    Fui.switch [
        switch.checked' checked'
        switch.label (
            if checked' then
                "With label above and checked"
            else
                "With label above and unchecked"
        )
        switch.labelPosition.above
        switch.onChange (fun (d: SwitchOnChangeData) -> setChecked d.``checked``)
    ]

[<ReactComponent>]
let RadioGroupTest () =
    let value, setValue = React.useState "banana"
    let labelId = Fui.useId "label-"

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.label [
                label.text "Favorite Fruit"
                label.id labelId
                label.required true
            ]
            Fui.radioGroup [
                radioGroup.value value
                radioGroup.ariaLabelledBy labelId
                radioGroup.onChange (fun (_: Event) (d: ValueProp<string>) -> setValue d.value)
                radioGroup.layout.horizontalStacked
                radioGroup.required true
                radioGroup.children [
                    Fui.radio [
                        radio.value "apple"
                        radio.label "Apple"
                    ]
                    Fui.radio [
                        radio.value "pear"
                        radio.label "Pear"
                    ]
                    Fui.radio [
                        radio.value "banana"
                        radio.label "Banana"
                    ]
                    Fui.radio [
                        radio.value "orange"
                        radio.label "Orange"
                    ]
                ]
            ]
            Fui.text [
                text.style [ style.width 200 ]
                text.text $"Favorite fruit: {value}"
            ]
        ]
    ]

[<ReactComponent>]
let TabListTest () =
    Fui.tabList [
        tabList.defaultSelectedValue "tab2"
        tabList.vertical true
        tabList.appearance.subtleCircular
        tabList.onTabSelect (fun (d: ValueProp<string>) -> printfn "value %A" d.value)
        tabList.size.large
        tabList.children [
            Fui.tab [
                tab.value "tab1"
                tab.children [ Fui.text "First tab" ]
            ]
            Fui.tab [
                tab.value "tab2"
                tab.children [ Fui.text "Second tab" ]
            ]
            Fui.tab [
                tab.value "tab3"
                tab.children [ Fui.text "Third tab" ]
            ]
            Fui.tab [
                tab.value "tab4"
                tab.children [ Fui.text "Fourth tab" ]
            ]
        ]
    ]

let spinnerTest =
    Fui.stack [
        stack.horizontal false
        stack.children [
            Html.div [
                prop.style [ style.backgroundColor.royalBlue ]
                prop.children [
                    Fui.spinner [
                        spinner.appearance.inverted
                        spinner.labelPosition.above
                        spinner.label "Extra tiny"
                        spinner.size.extraTiny
                        spinner.delay 1000
                    ]
                ]
            ]
            Fui.spinner [
                spinner.appearance.primary
                spinner.labelPosition.before
                spinner.label "Medium"
                spinner.size.medium
            ]
            Fui.spinner [
                spinner.appearance.primary
                spinner.labelPosition.before
                spinner.label "Huge"
                spinner.size.huge
            ]
        ]
    ]

[<ReactComponent>]
let SpinButtonTest () =
    let id = Fui.useId (None, None)
    let value, setValue = React.useState (Some 0)
    let displayValue, setDisplayValue = React.useState ("$0")

    Fui.stack [
        stack.horizontal true
        stack.children [
            Fui.label [
                label.htmlFor id
                label.text "Display Value"
            ]
            Fui.spinButton [
                spinButton.value value
                spinButton.displayValue displayValue
                spinButton.appearance.underline
                spinButton.incrementButton [
                    button.icon (Fui.icon.arrowUpFilled [])
                    button.size.small
                ]
                spinButton.decrementButton [
                    button.icon (Fui.icon.arrowDownFilled [])
                    button.size.small
                ]
                spinButton.id id
                spinButton.step 9
                spinButton.onChange (fun (d: SpinButtonOnChangeData) ->
                    match d.value with
                    | None ->
                        setValue None
                        setDisplayValue "null"
                    | Some v ->
                        setValue (Some v)
                        setDisplayValue $"{v}")
            ]
        ]
    ]

let SelectTest () =
    let selectId = Fui.useId (None, None)
    let value, setValue = React.useState ("Red")

    Fui.stack [
        stack.horizontal false
        stack.tokens [ stack.tokens.childrenGap 16 ]
        stack.children [
            Fui.label [
                label.htmlFor selectId
                label.text "Color"
            ]
            Fui.select [
                select.id selectId
                select.value value
                select.size.large
                select.appearance.filledDarker
                select.icon (Fui.icon.arrowUpFilled [])
                select.onChange (fun (d: ValueProp<string>) -> setValue d.value)
                select.children [
                    Html.option "Red"
                    Html.option "Green"
                    Html.option "Blue"
                ]
            ]
            Fui.button [
                button.text "Select 'blue'"
                button.onClick (fun _ -> setValue "Blue")
            ]
        ]
    ]

let personaTest =
    Fui.persona [
        persona.name "Kevin Sturgis"
        persona.secondaryText "Availabe"
        persona.presence [
            presenceBadge.status.blocked
            presenceBadge.size.large
        ]
        persona.size.extraLarge
        persona.avatar [
            avatar.image [
                image.src
                    "https://res-1.cdn.office.net/files/fabric-cdn-prod_20221209.001/office-ui-fabric-react-assets/persona-male.png"
            ]
        ]
    ]

let optionGroup =
    Fui.optionGroup [
        optionGroup.label "People"
        optionGroup.children [
            Fui.option [
                option.text "Katri Athokas"
                option.children [
                    Fui.persona [
                        persona.avatar [
                            avatar.color.colorful
                            avatar.ariaHidden true
                        ]
                        persona.name "Katri Athokas"
                        persona.presence [ presenceBadge.status.available ]
                        persona.secondaryText "Available"
                    ]
                ]
            ]
            Fui.option [
                option.text "Elvia Atkins"
                option.children [
                    Fui.persona [
                        persona.avatar [
                            avatar.color.colorful
                            avatar.ariaHidden true
                        ]
                        persona.name "Elvia Atkins"
                        persona.presence [ presenceBadge.status.busy ]
                        persona.secondaryText "Busy"
                    ]
                ]
            ]
            Fui.option [
                option.text "Cameron Evans"
                option.children [
                    Fui.persona [
                        persona.avatar [
                            avatar.color.colorful
                            avatar.ariaHidden true
                        ]
                        persona.name "Cameron Evans"
                        persona.presence [ presenceBadge.status.away ]
                        persona.secondaryText "Away"
                    ]
                ]
            ]
            Fui.option [
                option.text "Wanda Howard"
                option.children [
                    Fui.persona [
                        persona.avatar [
                            avatar.color.colorful
                            avatar.ariaHidden true
                        ]
                        persona.name "Wanda Howard"
                        persona.presence [ presenceBadge.status.outOfOffice ]
                        persona.secondaryText "Out of Office"
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let DropdownTest () =
    let selected, setSelected = React.useState ("Katri Athokas")

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.label [
                label.text "Schedule a Meeting"
                label.id "dropdownId"
            ]
            Fui.dropdown [
                dropdown.ariaLabelledBy "dropdownId"
                dropdown.value selected
                dropdown.selectedOptions [| selected |]
                dropdown.onOptionSelect (fun (d: OptionOnSelectData) ->
                    match d.optionText with
                    | Some t -> setSelected t
                    | None -> ())
                dropdown.children [ optionGroup ]
            ]
        ]
    ]

type ComboboxOption<'U> = {
    children: 'U
    value: string
    disabled: bool
}

let mkOptionChild (s: string) =
    Fui.text [
        text.style [ style.color.orange ]
        text.text s
    ]

// `children` is the text that will appear for each option in the dropdown
// `value` is the text that will be used for the filtering based on user's input
let comboboxOptions = [
    {
        children = mkOptionChild "Alligator"
        value = "alligator"
        disabled = false
    }
    {
        children = mkOptionChild "Bee"
        value = "bee"
        disabled = false
    }
    {
        children = mkOptionChild "Bird"
        value = "bird"
        disabled = false
    }
    {
        children = mkOptionChild "Cheetah"
        value = "cheetah"
        disabled = false
    }
    {
        children = mkOptionChild "Dog"
        value = "dog"
        disabled = true
    }
    {
        children = mkOptionChild "Dolphin"
        value = "dolphin"
        disabled = false
    }
    {
        children = mkOptionChild "Ferret"
        value = "ferret"
        disabled = false
    }
    {
        children = mkOptionChild "Firefly"
        value = "firefly"
        disabled = false
    }
]

[<ReactComponent>]
let ComboBoxTest () =
    let selectedAnimals, setSelectedAnimals = React.useState [||]
    let query, setQuery = React.useState ("")

    let children =
        Fui.useComboboxFilter (
            query,
            comboboxOptions,
            [
                comboboxFilterConfig.noOptionsMessage (
                    Fui.text [
                        text.style [ style.color "red" ]
                        text.text "No animals match your search"
                    ]
                )
                // Always showing firefly when filtering
                comboboxFilterConfig.filter (fun value input -> value.Contains(input) || value = "text-firefly")
                comboboxFilterConfig.optionToText (fun (v: ComboboxOption<ReactElement>) -> $"text-{v.value}")
            ]
        )

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.label [
                label.id "comboBoxId"
                label.text "Best Pets"
            ]
            Fui.combobox [
                combobox.ariaLabelledBy "comboBoxId"
                combobox.selectedOptions selectedAnimals
                combobox.onActiveOptionChange (fun changeData ->
                    printfn
                        "changeData %A"
                        (match changeData.nextOption with
                         | Some v -> v.text
                         | None -> "Nothing"))
                combobox.value (
                    if query = "" then
                        selectedAnimals |> String.concat ", "
                    else
                        query
                )
                combobox.placeholder "Select one or more animals"
                combobox.onTextChange (fun s -> setQuery s)
                combobox.onOptionSelect (fun (d: OptionOnSelectData) ->
                    setSelectedAnimals d.selectedOptions
                    setQuery "")
                combobox.children children
            ]
        ]
    ]

[<ReactComponent>]
let ToolbarTest () =
    let isOpen, setIsOpen = React.useState (None)

    Fui.toolbar [
        toolbar.ariaLabel "with popover"
        toolbar.size.small
        toolbar.children [
            Fui.popover [
                popover.withArrow true
                popover.trapFocus true
                popover.open' (if isOpen = Some "first" then true else false)
                popover.onOpenChange (fun (d: OpenProp) -> setIsOpen (if d.``open`` = true then Some "first" else None))
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (
                            Fui.toolbarButton [
                                toolbarButton.ariaLabel "Insert Image"
                                toolbarButton.icon (Fui.icon.imageAddFilled [])
                            ]
                        )
                    ]
                    Fui.popoverSurface [
                        Fui.stack [
                            stack.horizontal false
                            stack.children [
                                Fui.text [
                                    text.size.``300``
                                    text.text "Insert Image"
                                ]
                                Fui.button [
                                    button.text "Close"
                                    button.onClick (fun (_: MouseEvent) -> setIsOpen None)
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Fui.popover [
                popover.withArrow true
                popover.trapFocus true
                popover.open' (if isOpen = Some "second" then true else false)
                popover.onOpenChange (fun (d: OpenProp) ->
                    setIsOpen (if d.``open`` = true then Some "second" else None))
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (
                            Fui.toolbarButton [
                                toolbarButton.ariaLabel "Insert Table"
                                toolbarButton.icon (Fui.icon.tableAddFilled [])
                            ]
                        )
                    ]
                    Fui.popoverSurface [
                        Fui.stack [
                            stack.horizontal false
                            stack.children [
                                Fui.text [
                                    text.size.``300``
                                    text.text "Insert Table"
                                ]
                                Fui.button [
                                    button.text "Close"
                                    button.onClick (fun (_: MouseEvent) -> setIsOpen None)
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Fui.popover [
                popover.withArrow true
                popover.trapFocus true
                popover.open' (if isOpen = Some "third" then true else false)
                popover.onOpenChange (fun (d: OpenProp) -> setIsOpen (if d.``open`` = true then Some "third" else None))
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (
                            Fui.toolbarButton [
                                toolbarButton.ariaLabel "Insert Formula"
                                toolbarButton.icon (Fui.icon.mathFormatLinearFilled [])
                            ]
                        )
                    ]
                    Fui.popoverSurface [
                        Fui.stack [
                            stack.horizontal false
                            stack.children [
                                Fui.text [
                                    text.size.``300``
                                    text.text "Insert Formula"
                                ]
                                Fui.button [
                                    button.text "Close"
                                    button.onClick (fun (_: MouseEvent) -> setIsOpen None)
                                ]
                            ]
                        ]
                    ]
                ]
            ]
            Fui.toolbarDivider []
            Fui.popover [
                popover.withArrow true
                popover.trapFocus true
                popover.open' (if isOpen = Some "fourth" then true else false)
                popover.onOpenChange (fun (d: OpenProp) ->
                    setIsOpen (if d.``open`` = true then Some "fourth" else None))
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (
                            Fui.toolbarButton [
                                toolbarButton.ariaLabel "Quick Actions"
                                toolbarButton.children [ Fui.text "Quick Actions" ]
                            ]
                        )
                    ]
                    Fui.popoverSurface [
                        Fui.stack [
                            stack.horizontal false
                            stack.children [
                                Fui.text [
                                    text.size.``300``
                                    text.text "Quick Actions"
                                ]
                                Fui.button [
                                    button.text "Close"
                                    button.onClick (fun (_: MouseEvent) -> setIsOpen None)
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let AlertIcon = Fui.bundleIcon bundleIcons.alert

let AlertOnIcon =
    Fui.bundleIcon bundleIcons.alertOn

let AlertOffIcon =
    Fui.bundleIcon bundleIcons.alertOff

[<ReactComponent>]
let ControlledToolbarTest () =
    let checkedValues, setCheckedValues =
        React.useState [
            "alert",
            [|
                "on"
                "off"
            |]
        ]


    Fui.toolbar [
        toolbar.checkedValues checkedValues
        toolbar.onCheckedValueChange (fun d ->
            setCheckedValues ([ d.name, d.checkedItems ] |> List.append checkedValues))
        toolbar.children [
            Fui.toolbarToggleButton [
                toolbarToggleButton.ariaLabel "Alert"
                toolbarToggleButton.icon (AlertIcon [])
                toolbarToggleButton.name "alert"
                toolbarToggleButton.value "alert"
            ]
            Fui.toolbarToggleButton [
                toolbarToggleButton.ariaLabel "Alert On"
                toolbarToggleButton.icon (AlertOnIcon [])
                toolbarToggleButton.name "alert"
                toolbarToggleButton.value "on"
            ]
            Fui.toolbarToggleButton [
                toolbarToggleButton.ariaLabel "Alert Off"
                toolbarToggleButton.icon (AlertOffIcon [])
                toolbarToggleButton.name "alert"
                toolbarToggleButton.value "off"
            ]
        ]
    ]

let avatarGroupTest =
    let names = [|
        "Johnie McConnell"
        "Allan Munger"
        "Erik Nason"
        "Kristin Patterson"
        "Daisy Phillips"
        "Carole Poland"
        "Carlos Slattery"
        "Robert Tolbert"
        "Kevin Sturgis"
        "Charlotte Waltson"
        "Elliot Woodward"
    |]

    let spreadPartition =
        Fui.partitionAvatarGroupItems [
            partitionAvatarGroupItemsOptions.items names
            partitionAvatarGroupItemsOptions.layout.spread
        ]

    let piePartition =
        Fui.partitionAvatarGroupItems [
            partitionAvatarGroupItemsOptions.items names
            partitionAvatarGroupItemsOptions.layout.pie
            partitionAvatarGroupItemsOptions.maxInlineItems 10
        ]

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.avatarGroup [
                avatarGroup.layout.spread
                avatarGroup.size.``56``
                avatarGroup.children [
                    yield!
                        spreadPartition.inlineItems
                        |> Array.map (fun n ->
                            Fui.avatarGroupItem [
                                avatarGroupItem.name n
                                avatarGroupItem.key n
                            ])
                    Fui.avatarGroupPopover [
                        yield!
                            spreadPartition.overflowItems
                            |> Array.map (fun n ->
                                Fui.avatarGroupItem [
                                    avatarGroupItem.name n
                                    avatarGroupItem.key n
                                ])
                    ]
                ]
            ]
            Fui.avatarGroup [
                avatarGroup.layout.pie
                avatarGroup.size.``56``
                avatarGroup.children [
                    yield!
                        piePartition.inlineItems
                        |> Array.map (fun n ->
                            Fui.avatarGroupItem [
                                avatarGroupItem.name n
                                avatarGroupItem.key n
                            ])
                    Fui.avatarGroupPopover [
                        yield!
                            piePartition.overflowItems
                            |> Array.map (fun n ->
                                Fui.avatarGroupItem [
                                    avatarGroupItem.name n
                                    avatarGroupItem.key n
                                ])
                    ]
                ]
            ]

        ]
    ]

let progressBarTest =
    Fui.stack [
        stack.horizontal false
        stack.tokens [ stack.tokens.childrenGap 8 ]
        stack.children [
            Fui.field [
                field.validationMessage "Indeterminate ProgressBar"
                field.validationState.none
                field.children (Fui.progressBar [ progressBar.thickness.large ])
            ]
            Fui.field [
                field.validationMessage (Fui.text "Error progressbar")
                field.validationMessageIcon (Fui.icon.errorCircleFilled [])
                field.validationState.error
                field.children (
                    Fui.progressBar [
                        progressBar.value 0.25
                        progressBar.color.error
                        progressBar.shape.square
                    ]
                )
            ]
            Fui.field [
                field.validationMessage (Fui.text "Warning progressbar")
                field.validationState.warning
                field.validationMessageIcon (Fui.icon.warningFilled [])
                field.children (
                    Fui.progressBar [
                        progressBar.value 0.87
                        progressBar.color.warning
                        progressBar.shape.rounded
                    ]
                )
            ]
            Fui.field [
                field.validationMessage (Fui.text "Success progressbar")
                field.validationMessageIcon (Fui.icon.checkmarkCircleFilled [])
                field.validationState.success
                field.children (
                    Fui.progressBar [
                        progressBar.value 1
                        progressBar.color.success
                    ]
                )
            ]
        ]
    ]

[<ReactComponent>]
let DialogTest () =
    let isOpen, setIsOpen = React.useState false

    Fui.dialog [
        dialog.open' isOpen
        dialog.onOpenChange (fun (d: DialogOpenChangeData<MouseEvent>) -> setIsOpen d.``open``)
        dialog.surfaceMotion [
            presenceMotionSlot.onMotionStart (fun (d: OnMotionData) -> printfn "surfaceMotion start %A" d.direction)
            presenceMotionSlot.onMotionFinish (fun (d: OnMotionData) -> printfn "surfaceMotion finish %A" d.direction)
        ]
        dialog.children [
            Fui.dialogTrigger [
                dialogTrigger.disableButtonEnhancement true
                dialogTrigger.children (Fui.button [ button.text "Open dialog" ])
            ]
            Fui.dialogSurface [
                dialogSurface.backdropMotion [
                    presenceMotionSlot.onMotionStart (fun (d: OnMotionData) ->
                        printfn "backdropMotion start %A" d.direction)
                    presenceMotionSlot.onMotionFinish (fun (d: OnMotionData) ->
                        printfn "backdropMotion finish %A" d.direction)
                ]
                dialogSurface.children [
                    Fui.dialogBody [
                        Fui.dialogTitle [
                            dialogTitle.action (
                                Fui.dialogTrigger [
                                    dialogTrigger.action.open'
                                    dialogTrigger.children (
                                        Fui.button [ button.children [ Fui.icon.dismissRegular [] ] ]
                                    )
                                ]
                            )
                            dialogTitle.as'.h1
                            dialogTitle.text "Dialog Title"
                        ]
                        Fui.dialogContent [
                            dialogContent.text "This dialog focus on the second button instead of the first"
                        ]
                        Fui.dialogActions [
                            dialogActions.position.start
                            dialogActions.children [
                                Fui.button [
                                    button.appearance.outline
                                    button.text "Third Action"
                                ]
                            ]
                        ]
                        Fui.dialogActions [
                            dialogActions.position.end'
                            dialogActions.children [
                                Fui.dialogTrigger [
                                    dialogTrigger.disableButtonEnhancement true
                                    dialogTrigger.children (
                                        Fui.button [
                                            button.appearance.secondary
                                            button.text "Close"
                                        ]
                                    )
                                ]
                                Fui.button [
                                    button.appearance.primary
                                    button.text "Do Something"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let ToastTest () =
    let unmounted, setUnmounted = React.useState true
    let toastId = Fui.useId (Some "toast", None)
    let toasterId = Fui.useId (Some "toaster", None)

    let toastController = Fui.useToastController (Some toasterId)

    let notify =
        fun _ ->
            setUnmounted false

            toastController.dispatchToast (
                Fui.toast [
                    toast.appearance.inverted
                    toast.children [
                        Fui.toastTitle [
                            toastTitle.action (Fui.link [ link.text "Undo" ])
                            toastTitle.text "Email sent"
                        ]
                        Fui.toastBody [
                            toastBody.subtitle "This is a subtitle"
                            toastBody.text "This toast never closes"
                        ]
                        Fui.toastFooter [
                            Fui.link [ link.text "Action1" ]
                            Fui.link [ link.text "Action2" ]
                        ]
                    ]
                ],
                [
                    dispatchToastOptions.timeout -1
                    dispatchToastOptions.toastId toastId
                    dispatchToastOptions.intent.error
                    dispatchToastOptions.position.bottom
                ]
            )

    let update =
        fun _ ->
            toastController.updateToast [
                updateToastOptions.timeout 2000
                updateToastOptions.toastId toastId
                updateToastOptions.content (
                    Fui.toast [ Fui.toastTitle [ toastTitle.text "This toast will close soon" ] ]
                )
                updateToastOptions.intent.success
                updateToastOptions.position.top
            ]

    Fui.stack [
        stack.children [
            Fui.toaster [
                toaster.toasterId toasterId
                toaster.offset [
                    toastOffset.horizontal 300
                    toastOffset.vertical 400
                ]
                toaster.shortcuts {
                    focus = fun d -> d.ctrlKey && d.key = "m"
                }
            ]
            Fui.button [
                button.onClick (fun _ -> if unmounted then notify () else update ())
                button.text (if unmounted then "Open Toast" else "Update toast")
            ]
        ]
    ]

[<ReactComponent>]
let CardTest () =
    let selected, setSelected = React.useState (false)

    Fui.card [
        card.appearance.filled
        card.selected selected
        card.onSelectionChange (fun s -> setSelected s.selected)
        card.style [
            style.width 400
            style.maxWidth (length.percent 100)
            style.height.fitContent
        ]
        card.children [
            Fui.cardPreview [
                cardPreview.logo (
                    Fui.image [
                        image.style [ style.width 40 ]
                        image.src
                            "https://cdn.sanity.io/images/599r6htc/localized/46a76c802176eb17b04e12108de7e7e0f3736dc6-1024x1024.png?w=804&h=804&q=75&fit=max&auto=format"
                        image.alt "Figma logo"
                    ]
                )
                cardPreview.children [
                    Fui.image [
                        image.src
                            "https://i0.wp.com/www.smartprix.com/bytes/wp-content/uploads/2023/06/Untitled-design-88.jpg?fit=1200%2C675&ssl=1"
                        image.alt "Presentation Preview"
                    ]
                ]
            ]
            Fui.cardHeader [
                cardHeader.header (
                    Fui.text [
                        text.weight.semibold
                        text.text "iOS App Prototype"
                    ]
                )
                cardHeader.description "You created 53m ago"
                cardHeader.action (
                    Fui.button [
                        button.appearance.transparent
                        button.icon (Fui.icon.moreHorizontalFilled [])
                        button.ariaLabel "More Actions"
                    ]
                )
            ]
            Fui.cardFooter [
                cardFooter.action (
                    Fui.button [
                        button.appearance.transparent
                        button.icon (Fui.icon.moreHorizontalFilled [])
                    ]
                )
                cardFooter.children [
                    Fui.button [
                        button.icon (Fui.icon.arrowReplyAllRegular [])
                        button.text "Reply"
                    ]
                    Fui.button [
                        button.icon (Fui.icon.shareIosRegular [])
                        button.text "Share"
                    ]
                ]
            ]
        ]
    ]


[<ReactComponent>]
let SkeletonTest () =
    let styles = useStyles ()

    Fui.stack [
        stack.tokens [ stack.tokens.childrenGap 16 ]
        stack.className styles.skeletonStack
        stack.children [
            Fui.field [
                field.validationMessage "Wave animation"
                field.validationState.none
                field.children (
                    Fui.skeleton [
                        skeleton.style [ style.width 300 ]
                        skeleton.children [ Fui.skeletonItem [ skeletonItem.animation.wave ] ]
                    ]
                )
            ]
            Fui.field [
                field.validationMessage "Pulse animation"
                field.validationState.none
                field.children (
                    Fui.skeleton [
                        skeleton.style [ style.width 300 ]
                        skeleton.children [ Fui.skeletonItem [ skeletonItem.animation.pulse ] ]
                    ]
                )
            ]
            Fui.field [
                field.validationMessage "Pulse animation"
                field.validationState.none
                field.children (
                    Fui.skeleton [
                        skeleton.children [
                            Fui.skeletonItem [
                                skeletonItem.shape.circle
                                skeletonItem.animation.pulse
                            ]
                        ]
                    ]
                )
            ]
        ]
    ]

let fieldPropsTest =
    Fui.field [
        field.label "Third party input"
        field.hint "Use a render function to properly associate the label with the control."
        field.children (fun props -> Html.input [ yield! props ])
    ]

open System

[<ReactComponent>]
let DatePickerTest () =
    let firstDayOfWeek, setFirstDayOfWeek = React.useState ("Sunday")
    let error, setError = React.useState (None)

    let days = [
        "Sunday"
        "Monday"
        "Tuesday"
        "Wednesday"
        "Thursday"
        "Friday"
        "Saturday"
    ]

    let validationMessage: string = error |> DatePickerErrorStrings.fromErrorTypeOption

    let selectedFirstDayOfWeek =
        match firstDayOfWeek with
        | "Sunday" -> datePicker.firstDayOfWeek.sunday
        | "Monday" -> datePicker.firstDayOfWeek.monday
        | "Tuesday" -> datePicker.firstDayOfWeek.tuesday
        | "Wednesday" -> datePicker.firstDayOfWeek.wednesday
        | "Thursday" -> datePicker.firstDayOfWeek.thursday
        | "Friday" -> datePicker.firstDayOfWeek.friday
        | "Saturday" -> datePicker.firstDayOfWeek.saturday
        | _ -> datePicker.firstDayOfWeek.sunday

    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.field [
                field.label "Start Date"
                field.required true
                field.validationMessage validationMessage
                match error with
                | None -> field.validationState.none
                | _ -> field.validationState.error
                field.children (
                    Fui.datePicker [
                        datePicker.placeholder "Select a date..."
                        selectedFirstDayOfWeek
                        datePicker.borderless true
                        datePicker.showWeekNumbers true
                        datePicker.showMonthPickerAsOverlay true
                        datePicker.showGoToToday true
                        datePicker.allowTextInput true
                        datePicker.maxDate (DateTime.Today.AddDays(8))
                        datePicker.dateTimeFormatter (
                            {
                                Fui.defaultDateFormatting with
                                    formatYear = fun d -> $"Year: {d.Year}"
                            }
                        )
                        //TODO When customizing the formatted date with something other than built-in date functions, it conflicts with onValidationResult and doesn't render the date.
                        datePicker.formatDate (fun d -> d.ToShortDateString())
                        datePicker.onValidationResult (fun d -> setError d.error)
                        datePicker.calendar [
                            calendar.dateRangeType.workWeek
                            calendar.workWeekDays [
                                DayOfWeek.Monday
                                DayOfWeek.Tuesday
                                DayOfWeek.Wednesday
                                DayOfWeek.Thursday
                            ]
                            calendar.isMonthPickerVisible false
                            calendar.strings (
                                {
                                    Fui.defaultDatePickerStrings with
                                        goToToday = "Pick Today"
                                        shortDays = [|
                                            "T"
                                            "E"
                                            "S"
                                            "T"
                                            "I"
                                            "N"
                                            "G"
                                        |]
                                }
                            )
                        ]
                    ]
                )
            ]
            Fui.label [
                label.text "Select the first day of week"
                label.id "label"
            ]
            Fui.dropdown [
                dropdown.ariaLabelledBy "label"
                dropdown.onOptionSelect (fun (_: MouseEvent) (d: OptionOnSelectData) ->
                    match d.optionValue with
                    | Some v -> setFirstDayOfWeek v
                    | None -> ())
                dropdown.selectedOptions [| firstDayOfWeek |]
                dropdown.value firstDayOfWeek
                dropdown.children (
                    days
                    |> List.map (fun d ->
                        Fui.option [
                            option.key d
                            option.value d
                            option.children d
                        ])
                )
            ]
        ]
    ]

[<ReactComponent>]
let Portal () =
    let styles = useStyles ()
    let rootElement, setRootElement = React.useState (None)

    Html.div [
        Html.div [
            prop.className styles.portalContainer
            prop.style [ style.overflow.hidden ]
            prop.children [
                Fui.text "Clipping parent container"
                Fui.portal [
                    portal.mountNode rootElement
                    portal.children [
                        Html.div [
                            prop.className styles.portal
                            prop.text "Portal content"
                        ]
                    ]
                ]
            ]
        ]
        Html.div [ prop.ref (fun e -> setRootElement (Some e)) ]
    ]

let badgeTest =
    Fui.badge [
        badge.size.extraLarge
        badge.icon (Fui.icon.clipboard3DayRegular [])
        badge.iconPosition.after
        badge.color.important
        badge.shape.square
    ]


[<ReactComponent>]
let OverflowMenuItem (key: string) (id: string) =

    let isVisible = Fui.useIsOverflowItemVisible (id)

    if isVisible then
        Html.none
    else
        Fui.menuItem [
            menuItem.key key
            menuItem.text $"Item {id}"
        ]

[<ReactComponent>]
let OverflowMenu itemIds =
    let options = Fui.useOverflowMenu (None)

    if options.isOverflowing |> not then
        Html.none
    else
        Fui.menu [
            // menu.positioning.afterBottom
            menu.positioning [
                positioning.offset [
                    offset.crossAxis 30
                    offset.mainAxis 35
                ]
            ]
            menu.children [
                Fui.menuTrigger [
                    menuTrigger.disableButtonEnhancement true
                    menuTrigger.children (
                        Fui.menuButton [
                            menuButton.ref options.ref
                            menuButton.text $"+{options.overflowCount} items"
                        ]
                    )
                ]
                Fui.menuPopover [ Fui.menuList (itemIds |> List.map (fun i -> OverflowMenuItem i i)) ]
            ]
        ]

type ItemVisibility = {
    ``0``: bool
    ``1``: bool
    ``2``: bool
    ``3``: bool
    ``4``: bool
    ``5``: bool
    ``6``: bool
    ``7``: bool
}

type GroupVisibility = {
    ``0``: OverflowGroupState
    ``1``: OverflowGroupState
    ``2``: OverflowGroupState
    ``3``: OverflowGroupState
    ``4``: OverflowGroupState
    ``5``: OverflowGroupState
    ``6``: OverflowGroupState
    ``7``: OverflowGroupState
}

[<ReactComponent>]
let OverflowTest () =
    let itemIds = [
        "0"
        "1"
        "2"
        "3"
        "4"
        "5"
        "6"
        "7"
    ]

    let (overflowState: (ItemVisibility option)), setOverflowState =
        React.useState (None)

    let styles = useStyles ()

    Html.div [
        prop.children [
            if overflowState.IsSome then
                Fui.text ($"{overflowState.Value.``7``}")
            Fui.overflow [
                overflow.onOverflowChange<ItemVisibility, GroupVisibility> (fun data ->
                    setOverflowState (Some data.itemVisibility))
                overflow.children (
                    Html.div [
                        prop.className styles.overflow
                        prop.children [
                            yield!
                                itemIds
                                |> List.map (fun i ->
                                    Fui.overflowItem [
                                        overflowItem.key i
                                        overflowItem.id i
                                        overflowItem.children (Fui.button [ button.text $"Item {i}" ])
                                    ])
                            yield OverflowMenu itemIds
                        ]
                    ]
                )
            ]

        ]
    ]

[<ReactComponent>]
let UseFocusableGroupTest () =
    let attributes =
        Fui.useFocusableGroup [ useFocusableGroupOptions.tabBehavior.limitedTrapFocus ]

    Fui.stack [
        stack.horizontal false
        stack.children [
            Html.div [
                prop.tabIndex 0
                attributes
                prop.style [ style.width 500 ]
                prop.children [
                    Fui.text "Hello world!"
                    Html.div [
                        prop.style [
                            style.display.flex
                            style.width 300
                        ]
                        prop.children [
                            Fui.button [
                                button.ariaLabel "Copy"
                                button.icon (Fui.icon.copyRegular [])
                                button.size.small
                            ]
                            Fui.button [
                                button.ariaLabel "Delete"
                                button.icon (Fui.icon.deleteRegular [])
                                button.size.small
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let InfoButtonTest () =
    let infobuttonInfoId = Fui.useId (Some "infobuton__info", None)
    let isOpen, setIsOpen = React.useState false

    Html.div [
        prop.ariaOwns (if isOpen then infobuttonInfoId else "")
        prop.children [
            Fui.infoButton [
                infoButton.size.large
                infoButton.info [
                    popoverSurface.id infobuttonInfoId
                    popoverSurface.text "This is example information for an InfoButton."
                ]
                infoButton.popover [
                    popover.onOpenChange (fun (d: OpenProp) ->
                        printfn $"infoButton popover open? {d.``open``}"
                        setIsOpen d.``open``)
                ]
            ]
        ]
    ]

let infoLabelTest =
    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.field [
                field.label (
                    Fui.infoLabel [
                        infoLabel.infoButton [
                            infoButton.size.small
                            infoButton.popover [ popover.positioning [ positioning.offset [ offset.mainAxis 200 ] ] ]
                        ]
                        infoLabel.text "Field with info label"
                        infoLabel.weight.semibold
                        infoLabel.info [
                            popoverSurface.text "This is info about something"
                            popoverSurface.id "popoverSurfaceId"
                        ]
                    ]
                )
                field.children (Fui.input [])
            ]
        ]
    ]

let alertTest =
    Fui.stack [
        stack.horizontal false
        stack.tokens [ stack.tokens.childrenGap 8 ]
        stack.children [
            Fui.alert [
                alert.appearance.inverted
                alert.intent.success
                alert.action "Undo"
            ]
            Fui.alert [
                alert.appearance.primary
                alert.intent.warning
                alert.icon [ prop.className "testing classname" ]
            ]
            Fui.alert [
                alert.appearance.primary
                alert.intent.error
                alert.action [
                    button.appearance.primary
                    button.text "Review"
                    button.icon (Fui.icon.addRegular [ icon.primaryFill "orange" ])
                ]
            ]
        ]
    ]

[<ReactComponent>]
let VirtualizerTest () =
    let vm =
        Fui.useStaticVirtualizerMeasure [ virtualizerMeasureProps.defaultItemSize 100 ]

    let (vLength, bufferItems, bufferSize, scrollRef, containerSizeRef) =
        vm.virtualizerLength, vm.bufferItems, vm.bufferSize, vm.scrollRef, vm.containerSizeRef

    Html.div [
        prop.ariaLabel "Virtualizer Example"
        prop.role "list"
        prop.ref scrollRef
        prop.style [
            style.display.flex
            style.flexDirection.column
            style.overflowY.auto
            style.width 500
            style.height (length.percent 100)
            style.maxHeight 750
        ]
        prop.children [
            Fui.virtualizer [
                virtualizer.numItems 1000
                virtualizer.virtualizerLength vLength
                virtualizer.bufferItems bufferItems
                virtualizer.bufferSize bufferSize
                virtualizer.containerSizeRef containerSizeRef
                virtualizer.before (Fui.icon.bedFilled [])
                virtualizer.after (Fui.icon.bedRegular [])
                virtualizer.itemSize 100
                virtualizer.children (fun index _ ->
                    Html.span [
                        prop.role "listitem"
                        prop.ariaPosInSet index
                        prop.ariaSetSize 1000
                        prop.style [
                            style.height 100
                            style.lineHeight 100
                            style.width (length.percent 100)
                        ]
                        prop.key $"test-virtualizer-child-{index}"
                        prop.children [ Fui.text $"Node-{index}-XXX" ]
                    ])
            ]
        ]
    ]

[<ReactComponent>]
let VirtualizerScrollViewTest () =
    Fui.virtualizerScrollView [
        virtualizerScrollView.numItems 1000
        virtualizerScrollView.itemSize 100
        virtualizerScrollView.axis.horizontal
        virtualizerScrollView.container [
            prop.role "list"
            prop.style [
                style.height 300
                style.width (length.percent 100)
                style.padding (10, 2)
                style.gap 10
            ]
        ]
        virtualizerScrollView.children (fun (index: float) _ ->
            Fui.button [
                button.style [
                    style.width (length.percent 100)
                    style.height (length.percent 100)
                ]
                button.text $"Node-{index}"
            ])
    ]

[<ReactComponent>]
let DrawerTest () =
    let isOpen, setIsOpen = React.useState false

    Fui.stack [
        stack.children [
            Fui.overlayDrawer [
                overlayDrawer.position.end'
                overlayDrawer.modalType.alert
                overlayDrawer.open' isOpen
                overlayDrawer.onOpenChange (fun (_: MouseEvent) (data: DialogOpenChangeData<MouseEvent>) ->
                    setIsOpen data.``open``)
                overlayDrawer.children [
                    Fui.drawerHeader [
                        Fui.drawerHeaderTitle [
                            drawerHeaderTitle.action (
                                Fui.button [
                                    button.appearance.subtle
                                    button.ariaLabel "subtle"
                                    button.icon (Fui.icon.dismissRegular [ icon.size.``48`` ])
                                    button.onClick (fun _ -> setIsOpen false)
                                ]
                            )
                            drawerHeaderTitle.text "Overlay Drawer"
                        ]
                    ]
                    Fui.drawerBody [ Fui.text "Drawer content" ]
                    Fui.drawerFooter [ Fui.text "Footer content" ]
                ]
            ]
            Fui.button [
                button.appearance.primary
                button.onClick (fun _ -> setIsOpen (isOpen |> not))
                button.text "Toggle"
            ]
        ]
    ]

let simpleTreeTest =
    Html.div [
        Fui.tree [
            tree.defaultOpenItems [ "subtree-1" ]
            tree.ariaLabel "Default Layout"
            tree.children [
                Fui.treeItem [
                    treeItem.itemType.branch
                    treeItem.onOpenChange (fun (v: TreeItemOpenChangeData<string, MouseEvent>) ->
                        printfn "%A" v.``type``)
                    treeItem.value "subtree-1"
                    treeItem.children [
                        Fui.treeItemLayout [ Fui.text "Tree using TreeItemLayout" ]
                        Fui.tree [
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [ Fui.treeItemLayout [ Fui.text "level 2, item 1" ] ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [ Fui.treeItemLayout [ Fui.text "level 2, item 2" ] ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [ Fui.treeItemLayout [ Fui.text "level 2, item 3" ] ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

        Fui.tree [
            tree.ariaLabel "Persona Layout"
            tree.defaultOpenItems []
            tree.children [
                Fui.treeItem [
                    treeItem.itemType.branch
                    treeItem.children [
                        Fui.treeItemPersonaLayout [
                            treeItemPersonaLayout.media (Fui.avatar [ avatar.image [ image.alt "avatar" ] ])
                            treeItemPersonaLayout.children [ Fui.text "Tree using TreeItemLayout" ]
                        ]
                        Fui.tree [
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemPersonaLayout [
                                        treeItemPersonaLayout.media (Fui.avatar [ avatar.image [ image.alt "avatar" ] ])
                                        treeItemPersonaLayout.description "with description"
                                        treeItemPersonaLayout.children [ Fui.text "level 2, item 1" ]
                                    ]
                                ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemPersonaLayout [
                                        treeItemPersonaLayout.media (
                                            Fui.avatar [
                                                avatar.image [ image.alt "avatar" ]
                                                avatar.shape.square
                                            ]
                                        )
                                        treeItemPersonaLayout.description "square shape media"
                                        treeItemPersonaLayout.children [ Fui.text "level 2, item 2" ]
                                    ]
                                ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemPersonaLayout [
                                        treeItemPersonaLayout.description "without media"
                                        treeItemPersonaLayout.children [ Fui.text "level 2, item 3" ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

type Column = { Columnkey: string; Label: string }
type Icon = { Label: string; Icon: ReactElement }

type Status = {
    Label: string
    Status: IPresenceBadgeProp list
}

type TimeStamp = { Label: string; TimeStamp: int }

type Item = {
    File: Icon
    Author: Status
    LastUpdated: TimeStamp
    LastUpdate: Icon
    Index: int
}

let items = [
    for index in [ 1..500 ] do
        {
            File = {
                Label = "Meeting notes"
                Icon = Fui.icon.documentRegular []
            }
            Author = {
                Label = "Max Mustermann"
                Status = [
                    presenceBadge.status.available
                    presenceBadge.size.extraSmall
                ]
            }
            LastUpdated = { Label = "7h ago"; TimeStamp = 1 }
            LastUpdate = {
                Label = "You edited this"
                Icon = (Fui.icon.editRegular [])
            }
            Index = index
        }

        {
            File = {
                Label = "Thursday presentation"
                Icon = Fui.icon.folderRegular []
            }
            Author = {
                Label = "Erika Mustermann"
                Status = [
                    presenceBadge.status.busy
                    presenceBadge.size.large
                ]
            }
            LastUpdated = {
                Label = "Yesterday at 1:45pm"
                TimeStamp = 2
            }
            LastUpdate = {
                Label = "You recently opened this"
                Icon = Fui.icon.openRegular []
            }
            Index = index
        }

        {
            File = {
                Label = "Training recording"
                Icon = Fui.icon.videoRegular []
            }
            Author = {
                Label = "John Doe"
                Status = [
                    presenceBadge.status.away
                    presenceBadge.size.small
                ]
            }
            LastUpdated = {
                Label = "Yesterday at 1:45pm"
                TimeStamp = 2
            }
            LastUpdate = {
                Label = "You recently opened this"
                Icon = Fui.icon.openRegular []
            }
            Index = index
        }

        {
            File = {
                Label = "Purchase order"
                Icon = Fui.icon.documentPdfRegular []
            }
            Author = {
                Label = "Jane Doe"
                Status = [
                    presenceBadge.status.offline
                    presenceBadge.size.tiny
                ]
            }
            LastUpdated = {
                Label = "Tue at 9:30 AM"
                TimeStamp = 3
            }
            LastUpdate = {
                Label = "You shared this in a Teams chat"
                Icon = Fui.icon.peopleRegular []
            }
            Index = index
        }
]

[<ReactComponent>]
let RenderRow (trd: TableRowData<Item, int>) (style: obj) (index: int) =
    Fui.virtualized.dataGridRow [
        dataGridRow.style style
        dataGridRow.key trd.rowId
        dataGridRow.children (fun (tcd: TableColumnDefinition<Item, int>) _ ->
            Fui.virtualized.dataGridCell [
                dataGridCell.focusMode.group
                dataGridCell.children [ tcd.renderCell (trd.item) ]
            ])
    ]

[<ReactComponent>]
let DataGridTest () =
    let selectedRows, setSelectedRows = React.useState ([])
    let sortState, setSortState = React.useState ((None, SortDirection.ascending))

    let columnSizingOptions = [
        tableColumnSizingOptions.staticColumnWidth ("file", 200)
        tableColumnSizingOptions.staticColumnWidth ("lastUpdate", 120)
        tableColumnSizingOptions.staticColumnWidth ("lastUpdated", 200)
        tableColumnSizingOptions.staticColumnWidth ("author", 150)
    ]

    let columns = [
        Fui.createTableColumn [
            createTableColumnOption.columnId "file"
            createTableColumnOption.compare (fun (a: Item) (b: Item) ->
                let a = $"{a.Index}-{a.File.Label}"
                let b = $"{b.Index}-{b.File.Label}"
                a.CompareTo(Some b))
            createTableColumnOption.renderHeaderCell (fun _ -> "File")
            createTableColumnOption.renderCell (fun item ->
                let key: string = $"[{item.Index}]-{item.File.Label}"

                Fui.tableCellLayout [
                    tableCellLayout.key key
                    tableCellLayout.media (item.File.Icon)
                    tableCellLayout.children [ Fui.text key ]
                ])
        ]
        Fui.createTableColumn [
            createTableColumnOption.columnId "author"
            createTableColumnOption.compare (fun a b -> a.Author.Label.CompareTo(b.Author.Label))
            createTableColumnOption.renderHeaderCell (fun _ -> "Author")
            createTableColumnOption.renderCell (fun item ->
                Fui.tableCellLayout [
                    tableCellLayout.key item.Author.Label
                    tableCellLayout.media (
                        Fui.avatar [
                            avatar.ariaLabel item.Author.Label
                            avatar.name item.Author.Label
                            avatar.badge item.Author.Status
                        ]
                    )
                    tableCellLayout.children [ Fui.text item.Author.Label ]
                ])
        ]
        Fui.createTableColumn [
            createTableColumnOption.columnId "lastUpdated"
            createTableColumnOption.compare (fun a b -> a.LastUpdated.TimeStamp - b.LastUpdated.TimeStamp)
            createTableColumnOption.renderHeaderCell (fun _ -> "Last Updated")
            createTableColumnOption.renderCell (fun item -> item.LastUpdated.Label)
        ]
        Fui.createTableColumn [
            createTableColumnOption.columnId "lastUpdate"
            createTableColumnOption.compare (fun a b -> a.LastUpdate.Label.CompareTo(b.LastUpdate.Label))
            createTableColumnOption.renderHeaderCell (fun _ -> "Last Update")
            createTableColumnOption.renderCell (fun item ->
                Fui.tableCellLayout [
                    tableCellLayout.key item.LastUpdate.Label
                    tableCellLayout.media (item.LastUpdate.Icon)
                    tableCellLayout.children [ Fui.text item.LastUpdate.Label ]
                ])
        ]
    ]

    Fui.virtualized.dataGrid [
        dataGrid.items items
        dataGrid.columns columns
        dataGrid.sortable true
        dataGrid.selectionAppearance.brand
        dataGrid.selectionMode.multiselect
        dataGrid.resizableColumnsOptions [ resizableColumnsOptions.autoFitColumns false ]
        dataGrid.selectedItems (selectedRows: list<string>)
        dataGrid.sortState sortState
        dataGrid.onSortChange (fun s -> setSortState s)
        dataGrid.resizableColumns true
        dataGrid.columnSizingOptions columnSizingOptions
        dataGrid.onSelectionChange (fun (data: OnSelectionChangeData<string>) -> setSelectedRows data.selectedItems)
        dataGrid.children [
            Fui.virtualized.dataGridHeader [
                Fui.virtualized.dataGridRow [
                    dataGridRow.children (fun tcd _ -> Fui.virtualized.dataGridHeaderCell [ tcd.renderHeaderCell () ])
                ]
            ]
            Fui.virtualized.dataGridBody [
                dataGridBody.itemSize 50
                dataGridBody.height 400
                dataGridBody.children (fun trd style index -> RenderRow trd style index)
            ]
        ]
    ]

[<ReactComponent>]
let SimpleTableTest () =
    let columns = [
        {| columnKey = "file"; label = "File" |}
        {|
            columnKey = "author"
            label = "Author"
        |}
        {|
            columnKey = "lastUpdated"
            label = "Last Updated"
        |}
        {|
            columnKey = "lastUpdate"
            label = "Last Update"
        |}
    ]

    Fui.table [
        Fui.tableHeader [
            Fui.tableRow (
                columns
                |> List.map (fun c ->
                    Fui.tableHeaderCell [
                        tableHeaderCell.key c.columnKey
                        tableHeaderCell.children [ Fui.text c.label ]
                    ])
            )
        ]
        Fui.tableBody (
            items
            |> List.map (fun i ->
                Fui.tableRow [
                    tableRow.key i.File.Label
                    tableRow.children [
                        Fui.tableCell [
                            Fui.tableCellLayout [
                                tableCellLayout.media (i.File.Icon)
                                tableCellLayout.children [ Fui.text i.File.Label ]
                            ]
                        ]
                        Fui.tableCell [
                            Fui.tableCellLayout [
                                tableCellLayout.media (
                                    Fui.avatar [
                                        avatar.ariaLabel i.Author.Label
                                        avatar.name i.Author.Label
                                        avatar.badge i.Author.Status
                                    ]
                                )
                            ]
                        ]
                        Fui.tableCell [ Fui.text i.LastUpdated.Label ]
                        Fui.tableCell [
                            Fui.tableCellLayout [
                                tableCellLayout.media (i.LastUpdate.Icon)
                                tableCellLayout.children [ Fui.text i.LastUpdate.Label ]
                            ]
                        ]
                    ]
                ])
        )
    ]

[<ReactComponent>]
let UseFocusFindersTest () =
    let focusFinders = Fui.useFocusFinders ()
    let findAllFocusable = focusFinders.findAllFocusable
    let count, setCount = React.useState 0
    let toolbarRef = React.useRef<HTMLDivElement option> (None)

    let attributes =
        Fui.useArrowNavigationGroup [ useArrowNavigationGroupOptions.axis.horizontal ]

    let tokens = Theme.tokens

    React.useEffect (
        (fun _ ->
            match toolbarRef.current with
            | Some ref ->
                let count = findAllFocusable ref None |> Seq.length
                setCount (count)
            | None -> ()

        ),
        [| unbox findAllFocusable |]
    )

    Html.div [
        Html.div [
            prop.style [
                style.display.block
                style.backgroundColor tokens.colorBrandStroke1
                style.color tokens.colorNeutralForegroundOnBrand
                style.padding 4
                style.borderRadius 5
            ]
            prop.children [ Fui.text.body1Stronger $"{count} focusable elements below" ]
        ]
        Html.div [
            prop.ref toolbarRef
            prop.ariaLabel "Editor toolbar example"
            prop.role "toolbar"
            attributes
            prop.style [
                style.display.flex
                style.gap 5
                style.padding 10
                style.border (2, borderStyle.solid, tokens.colorBrandStroke1)
                style.borderRadius 5
            ]
            prop.children [
                Fui.button [
                    button.ariaLabel "Bold"
                    button.icon (Fui.icon.textBoldRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Underline"
                    button.icon (Fui.icon.textUnderlineRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Italic"
                    button.icon (Fui.icon.textItalicRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Align Left"
                    button.icon (Fui.icon.textAlignLeftRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Align Right"
                    button.icon (Fui.icon.textAlignRightRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Copy"
                    button.disabled true
                    button.icon (Fui.icon.copyRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Cut"
                    button.disabled true
                    button.icon (Fui.icon.cutRegular [])
                ]
                Fui.button [
                    button.ariaLabel "Paste"
                    button.disabled true
                    button.icon (Fui.icon.clipboardPasteRegular [])
                ]
            ]
        ]
    ]

let dialogClass =
    Fui.makeResetStyles [
        style.position.fixedRelativeToWindow
        style.top (length.px 200)
        style.backgroundColor tokens.colorBrandBackground2
        style.margin (length.auto)
        style.borderStyle.none
        style.padding (10, 50)
        style.boxShadow (5, 5, tokens.shadow16)
        style.width (length.px 450)
        style.height (length.px 200)
        style.display.flex
        style.flexDirection.column
        style.zIndex 100
    ]

[<ReactComponent>]
let UseModalAttributesOptionsTest () =
    let isOpen, setIsOpen = React.useState false
    let attributes = Fui.useModalAttributes [ useModalAttributesOptions.trapFocus true ]
    let dialogClass = dialogClass ()

    let triggerRef = React.useRef<HTMLButtonElement option> (None)
    let dialogRef = React.useRef<HTMLDivElement option> (None)

    Html.div [
        Fui.button [
            button.ref triggerRef
            (attributes.triggerAttributes |> unbox<IButtonProp>)
            button.onClick (fun _ -> setIsOpen true)
            button.text "Open dialog"
        ]
        if isOpen then
            Html.div [
                prop.ref dialogRef
                attributes.modalAttributes
                prop.role "dialog"
                prop.className dialogClass
                prop.ariaLabel "Example dialog"
                prop.children [
                    Fui.text.title2 [
                        text.as'.h2
                        text.text "Example dialog"
                    ]
                    Html.div [ Fui.text "This is a dialog for example purposes" ]
                    Html.div [
                        Fui.button [ button.text "Action" ]
                        Fui.button [
                            button.onClick (fun _ -> setIsOpen false)
                            button.text "Close"
                        ]
                    ]
                ]
            ]
    ]

[<ReactComponent>]
let FlatTreeTest () =
    let items = [
        [ headlessTreeItem.value "1" ]
        [
            headlessTreeItem.value "1-1"
            headlessTreeItem.parentValue "1"
        ]
        [
            headlessTreeItem.value "1-2"
            headlessTreeItem.parentValue "1"
        ]
        [ headlessTreeItem.value "2" ]
        [
            headlessTreeItem.value "2-1"
            headlessTreeItem.parentValue "2"
        ]
        [
            headlessTreeItem.value "2-1-1"
            headlessTreeItem.parentValue "2-1"
        ]
        [
            headlessTreeItem.value "2-2"
            headlessTreeItem.parentValue "2"
        ]
        [
            headlessTreeItem.value "2-2-1"
            headlessTreeItem.parentValue "2-2"
        ]
        [
            headlessTreeItem.value "2-2-2"
            headlessTreeItem.parentValue "2-2"
        ]
        [ headlessTreeItem.value "3" ]
    ]

    let getContent value =
        match value with
        | "1" -> Fui.text "Level 1, item 1"
        | "1-1" -> Fui.text "Level 2, item 1"
        | "1-2" -> Fui.text "Level 2, item 2"
        | "2" -> Fui.text "Level 1, item 2"
        | "2-1" -> Fui.text "Level 2, item 1"
        | "2-1-1" -> Fui.text "Level 3, item 1"
        | "2-2" -> Fui.text "Level 2, item 2"
        | "2-2-1" -> Fui.text "Level 3, item 1"
        | "2-2-2" -> Fui.text "Level 3, item 2"
        | "3" -> Fui.text "Level 1, item 3"
        | _ -> Html.none

    let testFlatTree =
        Fui.useHeadlessFlatTree_unstable (
            items,
            [
                headlessFlatTreeOptions.defaultOpenItems [
                    "1"
                    "2"
                    "2-1"
                    "2-2"
                ]
                headlessFlatTreeOptions.defaultCheckedItems [ "1-2" ]
                headlessFlatTreeOptions.selectionMode.multiselect
            ]
        )

    let renderItem flatTreeItem =
        let treeItemProps = flatTreeItem.getTreeItemProps ()

        Fui.treeItem [
            yield! treeItemProps |> treeItem.getProps
            treeItem.key flatTreeItem.value
            treeItem.children [ Fui.treeItemLayout [ getContent treeItemProps.value ] ]
        ]

    Fui.flatTree [
        flatTree.ariaLabel "Selection"
        yield! testFlatTree.getTreeProps () |> flatTree.getProps
        flatTree.children [
            for flatTree in testFlatTree.items () do
                yield renderItem flatTree
        ]
    ]

type ButtonProps = {
    onClick: MouseEvent -> unit
    icon: ReactElement
    disabled: bool
}

type ButtonItem = {
    key: int
    item: string
    buttonProps: IBreadcrumbButtonProp list
}

[<ReactComponent>]
let RenderButton (button: ButtonItem) (isLastItem: bool) =
    React.fragment [
        Fui.overflowItem [
            overflowItem.key (button.key |> string)
            overflowItem.priority (if isLastItem then button.key else 0)
            overflowItem.groupId (button.key |> string)
            overflowItem.children (
                Fui.breadcrumbItem [
                    Fui.breadcrumbButton [
                        yield! button.buttonProps
                        breadcrumbButton.current isLastItem
                        breadcrumbButton.text button.item
                    ]
                ]
            )
        ]
        if isLastItem |> not then
            Fui.overflowDivider [
                overflowDivider.groupId button.key
                overflowDivider.children (Fui.breadcrumbDivider [ breadcrumbDivider.custom ("data-group", button.key) ])
            ]
    ]

[<ReactComponent>]
let OverflowBreadcrumbButton id item (key: int) =
    let isVisible = Fui.useIsOverflowItemVisible (id)

    if isVisible then
        Html.none
    else
        Fui.menuItem [
            yield! (item.buttonProps |> unbox<IMenuItemProp list>)
            menuItem.text item.item
            menuItem.key key
        ]

[<ReactComponent>]
let ControlledOverflowMenu (props: PartitionBreadcrumbItems<ButtonItem>) =
    let options = Fui.useOverflowMenu (None) //TODO isOverflowing stays false

    if options.isOverflowing |> not && props.overflowItems.Length = 0 then
        Html.none
    else
        Fui.menu [
            menu.hasIcons true
            menu.children [
                Fui.menuTrigger [
                    menuTrigger.disableButtonEnhancement true
                    menuTrigger.children (
                        Fui.button [
                            button.style [ style.alignSelf.center ]
                            button.appearance.transparent
                            button.ref options.ref
                            button.icon (Fui.icon.moreHorizontalRegular [])
                            button.ariaLabel $"{options.overflowCount} more tabs"
                            button.role "tab"
                        ]
                    )
                ]
                Fui.menuPopover [
                    Fui.menuList [
                        if options.isOverflowing then
                            yield!
                                props.startDisplayedItems
                                |> Seq.map (fun b -> OverflowBreadcrumbButton (b.key |> string) b b.key)
                        if props.overflowItems.Length <> 0 then
                            yield!
                                props.overflowItems
                                |> Seq.map (fun b -> OverflowBreadcrumbButton (b.key |> string) b b.key)
                        if options.isOverflowing && props.endDisplayedItems.Length <> 0 then
                            yield!
                                props.endDisplayedItems
                                |> Seq.map (fun b -> OverflowBreadcrumbButton (b.key |> string) b b.key)
                    ]
                ]
            ]
        ]

let buttonItems = [|
    {
        key = 0
        item = "Item 0"
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 0 was clicked")
            breadcrumbButton.icon Html.none
        ]
    }
    {
        key = 1
        item = "Item 1"
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 1 was clicked")
            breadcrumbButton.icon (Fui.icon.calendarMonthRegular [])
        ]
    }
    {
        key = 2
        item = "Item 2"
        buttonProps = [ breadcrumbButton.onClick (fun _ -> printfn "item 2 was clicked") ]
    }
    {
        key = 3
        item = "Item 3"
        buttonProps = [ breadcrumbButton.onClick (fun _ -> printfn "item 3 was clicked") ]
    }
    {
        key = 4
        item = "Item 4"
        buttonProps = [ breadcrumbButton.onClick (fun _ -> printfn "item 4 was clicked") ]
    }
    {
        key = 5
        item = "Item 5"
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 5 was clicked")
            breadcrumbButton.icon (Fui.icon.calendarMonthRegular [])
        ]
    }
    {
        key = 6
        item = "Item 6"
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 6 was clicked")
            breadcrumbButton.disabled true
        ]
    }
    {
        key = 7
        item = "Item 7"
        buttonProps = [ breadcrumbButton.onClick (fun _ -> printfn "item 7 was clicked") ]
    }
|]


[<ReactComponent>]
let BreadcrumbTest () =
    let styles = useStyles ()

    let partitionBreadcrumbItems =
        Fui.partitionBreadcrumbItems [
            partitionBreadcrumbItemsOptions.items buttonItems
            partitionBreadcrumbItemsOptions.maxDisplayedItems 4
        ]

    let startItems, overflowItems, endItems =
        partitionBreadcrumbItems.startDisplayedItems,
        partitionBreadcrumbItems.overflowItems,
        partitionBreadcrumbItems.endDisplayedItems

    Fui.stack [
        stack.horizontal true
        stack.className styles.breadcrumb
        stack.children [
            Fui.overflow [
                overflow.children (
                    Fui.breadcrumb [
                        yield! startItems |> Array.map (fun b -> RenderButton b false) |> Array.toList
                        ControlledOverflowMenu partitionBreadcrumbItems
                        Fui.breadcrumbDivider []
                        if endItems.Length <> 0 then
                            yield!
                                endItems
                                |> Array.map (fun b ->
                                    let isLastItem = b.key = buttonItems.Length - 1
                                    RenderButton b isLastItem)
                                |> Array.toList
                    ]
                )
            ]
        ]
    ]

[<ReactComponent>]
let SearchBoxTest () =
    let value, setValue = React.useState ("initial value")
    let valid, setValid = React.useState true

    Fui.field [
        field.label "Controlled SearchBox limiting the value to 20 characters"
        if valid then
            field.validationState.none
        else
            field.validationState.warning
        field.validationMessage (if valid then "" else "Input is limited to 20 characters.")
        field.children (
            Fui.searchBox [
                searchBox.value value
                searchBox.contentBefore (Fui.icon.searchInfoFilled [ icon.onClick (fun _ -> printfn "Search clicked") ])
                searchBox.onChange (fun (v: ValueProp<string>) ->
                    if v.value.Length <= 20 then
                        setValue v.value
                        setValid true
                    else
                        setValid false)
            ]
        )
    ]

let initialTags = [
    {| value = "1"; children = "Tag 1" |}
    {| value = "2"; children = "Tag 2" |}
    {| value = "3"; children = "Tag 3" |}
]

[<ReactComponent>]
let TagTest () =
    let visibleTags, setVisibleTags = React.useState initialTags

    Fui.tagGroup [
        tagGroup.onDismiss (fun (data: ValueProp<string>) ->
            setVisibleTags (visibleTags |> List.filter (fun t -> t.value <> data.value)))
        tagGroup.ariaLabel "Dismiss example"
        tagGroup.children [
            yield!
                visibleTags
                |> List.map (fun t ->
                    Fui.tag [
                        tag.dismissible true
                        tag.dismissIcon [ prop.ariaLabel "Remove" ]
                        tag.value t.value
                        tag.key t.value
                        tag.text t.children
                    ])
        ]
    ]

[<ReactComponent>]
let InteractionTagTest () =
    let liked, setLiked = React.useState false

    Fui.interactionTag [
        Fui.popover [
            Fui.popoverTrigger [
                popoverTrigger.children (
                    Fui.interactionTagPrimary [
                        interactionTagPrimary.hasSecondaryAction true
                        interactionTagPrimary.id "golden-retreiver-primary"
                        interactionTagPrimary.children [ Fui.text "Golden Retriever" ]
                    ]
                )
            ]
            Fui.popoverSurface [
                Fui.link [
                    link.href "https://en.wikipedia.org/wiki/Golden_Retriever"
                    link.text "Find out more on wiki"
                ]
                Html.ul [
                    Html.li "Size: Medium to large-sized dog breed."
                    Html.li
                        "Coat: Luxurious double coat with a dense, water-repellent outer layer and a soft, dense undercoat."
                    Html.li "Color: Typically a luscious golden or cream color, with variations in shade."
                    Html.li "Build: Sturdy and well-proportioned body with a friendly and intelligent expression."
                ]
            ]
        ]
        Fui.tooltip [
            tooltip.content (if liked then "unlike" else "like")
            tooltip.relationship.label
            tooltip.children [
                Fui.interactionTagSecondary [
                    interactionTagSecondary.onClick (fun _ -> setLiked (liked |> not))
                    interactionTagSecondary.ariaLabelledBy "golden-retriever-primary golden-retriever-secondary"
                    interactionTagSecondary.id "golden-retriever-secondary"
                    interactionTagSecondary.children [
                        if liked then
                            Fui.icon.heartFilled []
                        else
                            Fui.icon.heartRegular []
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let MessageBarTest () =
    let intentIndex, setIntentIndex = React.useState 0
    let messageIntents, setMessageIntents = React.useState []

    let intents = [
        messageBar.intent.error
        messageBar.intent.info
        messageBar.intent.success
        messageBar.intent.warning
    ]

    Html.div [
        prop.style [
            style.width 600
            style.height 200
            style.overflowY.scroll
        ]
        prop.children [
            Fui.button [
                button.onClick (fun _ ->
                    let index = if intentIndex = 3 then 0 else intentIndex + 1
                    setMessageIntents (intents.[intentIndex] :: messageIntents)
                    setIntentIndex index)
                button.text "Notify"
            ]
            Fui.messageBarGroup [
                messageBarGroup.animate.both
                messageBarGroup.children [
                    yield!
                        messageIntents
                        |> List.mapi (fun index intent ->
                            Fui.messageBar [
                                messageBar.shape.square
                                messageBar.layout.multiline
                                messageBar.politeness.assertive
                                intent
                                messageBar.children [
                                    Fui.messageBarBody [
                                        Fui.messageBarTitle "Descriptive title"
                                        Fui.link [ link.text "Link" ]
                                        Fui.text "Message providing information to the user with actionable"
                                    ]
                                    Fui.messageBarActions [
                                        messageBarActions.containerAction (
                                            Fui.button [
                                                button.onClick (fun _ ->
                                                    setMessageIntents (
                                                        messageIntents |> List.except [ messageIntents.[index] ]
                                                    ))
                                                button.appearance.transparent
                                                button.icon (Fui.icon.dismissRegular [])
                                            ]
                                        )
                                    ]
                                ]
                            ])
                ]
            ]
        ]
    ]

[<ReactComponent>]
let MergeClassesTest isYellow =
    let styles = useStyles ()

    Html.div [
        prop.className (
            Fui.mergeClasses (
                styles.backgroundColor,
                styles.borderRadius,
                (if isYellow then styles.yellowText else ""),
                "testSize"
            )
        )
        prop.children [ Fui.text "Merge Classes Div" ]
    ]

[<ReactComponent>]
let CalendarTest () =
    let date, setDate = React.useState DateTime.Today

    Fui.calendar [
        calendar.showGoToToday true
        calendar.onSelectDate (fun d _ -> setDate d)
        calendar.value date
        calendar.highlightSelectedMonth true
        calendar.restrictedDates [
            DateTime.Today
            DateTime.Today.AddDays(1)
        ]
        calendar.strings (
            {
                Fui.defaultDatePickerStrings with
                    goToToday = "Pick Me!"
            }
        )
        calendar.calendarDayProps [
            calendarDay.navigationIcons [
                calendarNavigationIcons.downNavigation (Fui.icon.doubleSwipeDownFilled [])
                calendarNavigationIcons.upNavigation (Fui.icon.doubleSwipeUpFilled [])
            ]
            calendarDay.firstDayOfWeek.saturday
            calendarDay.getMarkedDays (fun sd _ -> [|
                Fui.addDays (sd, 3)
                Fui.addDays (sd, 4)
            |])
            calendarDay.customDayCellRef (fun element dt classNames ->
                match element with
                | Some el ->
                    el.title <- $"Custom title from customDayCellRef: {dt.ToString()}"
                    // Disables Saturdays and Sundays
                    if dt.DayOfWeek = DayOfWeek.Sunday || dt.DayOfWeek = DayOfWeek.Saturday then
                        el.classList.add (classNames.dayOutsideBounds.Split(" "))
                    else
                        ()
                | None -> ())
        ]
    ]

let getErrorMessage =
    function
    | Some TimePickerErrorType.``invalid-input`` -> "Time is invalid"
    | Some TimePickerErrorType.``out-of-bounds`` -> "Time is out of bounds"
    | Some TimePickerErrorType.``required-input`` -> "Time is required"
    | _ -> ""

[<ReactComponent>]
let TimePickerTest () =
    let errorType, setErrorType = React.useState None

    Fui.field [
        field.required true
        field.label
            "Type a time outside of 10:00 to 19:59, type an invalid time, or leave the input empty and close the TimePicker."
        field.validationMessage (getErrorMessage errorType)
        field.children (
            Fui.timePicker [
                timePicker.freeform true
                timePicker.style [ style.maxWidth 300 ]
                timePicker.startHour.``10``
                timePicker.clearable true
                timePicker.endHour.``20``
                timePicker.appearance.filledDarker
                timePicker.onTimeChange (fun (data: TimeSelectionData) -> setErrorType data.errorType)
            ]
        )
    ]

[<ReactComponent>]
let TeachingPopoverTest () =
    Fui.teachingPopover [
        teachingPopover.appearance.brand
        teachingPopover.withArrow true
        teachingPopover.positioning [ positioning.offset [ offset.crossAxis 200 ] ]
        teachingPopover.openOnHover true
        teachingPopover.children [
            Fui.teachingPopoverTrigger (Fui.button [ button.text "Teaching Popover Trigger" ])
            Fui.teachingPopoverSurface [
                Fui.teachingPopoverHeader "Tips"
                Fui.teachingPopoverCarousel [
                    teachingPopoverCarousel.defaultValue "test-0"
                    teachingPopoverCarousel.announcement (fun _ -> "TESTING?!")
                    teachingPopoverCarousel.children [
                        Fui.teachingPopoverCarouselCard [
                            teachingPopoverCarouselCard.value "test-0"
                            teachingPopoverCarouselCard.children [
                                Fui.teachingPopoverBody [
                                    teachingPopoverBody.media (
                                        Fui.image [
                                            image.fit.cover
                                            image.src
                                                "https://i0.wp.com/www.smartprix.com/bytes/wp-content/uploads/2023/06/Untitled-design-88.jpg?fit=1200%2C675&ssl=1"
                                        ]
                                    )
                                    teachingPopoverBody.children [
                                        Fui.teachingPopoverTitle "Teaching Bubble Title"
                                        Fui.text "This is page 1"
                                    ]
                                ]
                            ]
                        ]
                        Fui.teachingPopoverCarouselCard [
                            teachingPopoverCarouselCard.value "test-1"
                            teachingPopoverCarouselCard.children [
                                Fui.teachingPopoverBody [
                                    teachingPopoverBody.media (
                                        Fui.image [
                                            image.fit.cover
                                            image.src
                                                "https://i0.wp.com/www.smartprix.com/bytes/wp-content/uploads/2023/06/Untitled-design-88.jpg?fit=1200%2C675&ssl=1"
                                        ]
                                    )
                                    teachingPopoverBody.children [
                                        Fui.teachingPopoverTitle "Teaching Bubble Title"
                                        Fui.text "This is page 2"
                                    ]
                                ]
                            ]
                        ]
                        Fui.teachingPopoverCarouselCard [
                            teachingPopoverCarouselCard.value "test-2"
                            teachingPopoverCarouselCard.children [
                                Fui.teachingPopoverBody [
                                    teachingPopoverBody.media (
                                        Fui.image [
                                            image.fit.cover
                                            image.src
                                                "https://i0.wp.com/www.smartprix.com/bytes/wp-content/uploads/2023/06/Untitled-design-88.jpg?fit=1200%2C675&ssl=1"
                                        ]
                                    )
                                    teachingPopoverBody.children [
                                        Fui.teachingPopoverTitle "Teaching Bubble Title"
                                        Fui.text "This is page 3"
                                    ]
                                ]
                            ]
                        ]
                        Fui.teachingPopoverCarouselFooter [
                            teachingPopoverCarouselFooter.next "Next"
                            teachingPopoverCarouselFooter.previous "Previous"
                            teachingPopoverCarouselFooter.initialStepText "Close"
                            teachingPopoverCarouselFooter.finalStepText "Finish"
                            teachingPopoverCarouselFooter.children [
                                Fui.teachingPopoverCarouselNav [
                                    teachingPopoverCarouselNav.children (fun _ ->
                                        Fui.teachingPopoverCarouselNavButton [])
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let ratingTest () =
    Fui.rating [
        rating.step.``0.5``
        rating.defaultValue 4.5M
        rating.onChange (fun (v: RatingOnChangeEventData<int>) -> printfn "value %A" (v.value, v.event, v.``type``))
        rating.iconFilled bundleIcons.circle.Filled
        rating.iconOutline bundleIcons.circle.Regular
        rating.size.large
        rating.max 7
        rating.color.marigold
    ]

let ratingDisplayTest =
    Fui.ratingDisplay [
        ratingDisplay.compact true
        ratingDisplay.value 4.3
        ratingDisplay.max 10
        ratingDisplay.icon bundleIcons.circle.Filled
        ratingDisplay.color.marigold
        ratingDisplay.size.extraLarge
    ]

let ratingItemTest =
    Fui.ratingItem [
        ratingItem.value 4
        ratingItem.selectedIcon (Fui.icon.addFilled [])
    ]

[<ReactComponent>]
let TagPickerTest () =

    let options = [
        "John Doe"
        "Jane Doe"
        "Max Mustermann"
        "Erika Mustermann"
        "Pierre Dupont"
        "Amelie Dupont"
        "Mario Rossi"
        "Maria Rossi"
    ]

    let query, setQuery = React.useState ""
    let selectedOptions, setSelectedOptions = React.useState []

    let children =
        Fui.useTagPickerFilter [
            useTagPickerFilter.query query
            useTagPickerFilter.options options
            useTagPickerFilter.noOptionsElement (
                Fui.tagPickerOption [
                    tagPickerOption.value "no-matches"
                    tagPickerOption.children "We couldn't find any matches"
                ]
            )
            useTagPickerFilter.renderOption (fun option ->
                Fui.tagPickerOption [
                    tagPickerOption.secondaryContent (Fui.text "Microsoft FTE")
                    tagPickerOption.key option
                    tagPickerOption.media (
                        Fui.avatar [
                            avatar.shape.square
                            avatar.ariaHidden true
                            avatar.name option
                            avatar.color.colorful
                            avatar.value option
                        ]
                    )
                    tagPickerOption.value option
                    tagPickerOption.children option
                ])
            useTagPickerFilter.filter (fun (option: string) ->
                selectedOptions |> List.contains option |> not
                && option.ToLower().Contains(query.ToLower()))
        ]

    Fui.field [
        field.label "Select Employees"
        field.style [ style.maxWidth 100 ]
        field.children [
            Fui.tagPicker [
                tagPicker.noPopover false
                tagPicker.onOptionSelect (fun (data: TagPickerOnOptionSelectData<MouseEvent>) ->
                    if data.value = "no-matches" then
                        ()
                    else
                        setSelectedOptions (data.selectedOptions |> Array.toList)
                        setQuery "")
                tagPicker.selectedOptions selectedOptions
                tagPicker.children [
                    Fui.tagPickerControl [
                        Fui.tagPickerGroup [
                            yield!
                                selectedOptions
                                |> List.map (fun option ->
                                    Fui.tag [
                                        tag.key option
                                        tag.shape.rounded
                                        tag.media (
                                            Fui.avatar [
                                                avatar.ariaHidden true
                                                avatar.name option
                                                avatar.color.colorful
                                            ]
                                        )
                                        tag.value option
                                        tag.children [ Fui.text option ]
                                    ])
                        ]
                        Fui.tagPickerInput [
                            tagPickerInput.ariaLabel "Select Employees"
                            tagPickerInput.value query
                            tagPickerInput.onTextChange (fun s -> setQuery s)
                        ]
                    ]
                    Fui.tagPickerList children
                ]
            ]
        ]
    ]

type Swatch = {
    color: string
    value: string
    ``aria-label``: string
}

[<ReactComponent>]
let SwatchPickerTest () =
    let styles = useStyles ()
    let selectedValue, setSelectedValue = React.useState "00B053"
    let selectedColor, setSelectedColor = React.useState "#00B053"

    let defaultItems = [
        {
            color = "#FF1921"
            value = "FF1921"
            ``aria-label`` = "red"
        }
        {
            color = "#FF7A00"
            value = "FF7A00"
            ``aria-label`` = "dark orange"
        }
        {
            color = "#90D057"
            value = "90D057"
            ``aria-label`` = "light green"
        }
        {
            color = "#00B053"
            value = "00B053"
            ``aria-label`` = "green"
        }
    ]

    let inputRef: IRefValue<HTMLInputElement option> = React.useRef None
    let items, setItems = React.useState defaultItems
    let ITEMS_LIMIT = 8
    let emptyItems = ITEMS_LIMIT - items.Length

    let handleAddColor =
        fun _ ->
            let newColor =
                match inputRef.current with
                | Some ref -> ref.value
                | None -> ""

            let newValue = $"custom-{newColor} [{items.Length - ITEMS_LIMIT}]"

            setItems (
                [
                    {
                        color = newColor
                        value = newValue
                        ``aria-label`` = newColor
                    }
                ]
                |> List.append items
            )

    Html.div [
        Fui.swatchPicker [
            swatchPicker.ariaLabel "SwatchPicker with empty swatch"
            swatchPicker.selectedValue selectedValue
            swatchPicker.onSelectionChange (fun (data: SwatchPickerOnSelectionChangeData) ->
                setSelectedValue data.selectedValue
                setSelectedColor data.selectedSwatch)
            swatchPicker.children [
                yield!
                    items
                    |> List.map (fun item ->
                        Fui.colorSwatch [
                            colorSwatch.key item.value
                            colorSwatch.value item.value
                            colorSwatch.ariaLabel item.``aria-label``
                            colorSwatch.color item.color
                        ])
                for i in 1..emptyItems do
                    Fui.emptySwatch [
                        emptySwatch.disabled true
                        emptySwatch.key i
                        emptySwatch.ariaLabel $"empty-swatch-{i}"
                    ]
            ]
        ]
        Html.div [
            prop.className styles.swatchExample
            prop.style [
                style.backgroundColor selectedColor
                style.custom ("@media (forcedColors: active)", [ "forcedColorAdjust", "none" ])
            ]
        ]
        Fui.label [
            label.htmlFor "color-select"
            label.text "Add more colors:"
        ]
        Html.input [
            prop.className styles.swatchInput
            prop.ref inputRef
            prop.type'.color
            prop.id "color-select"
            prop.name "color-select"
        ]
        Fui.button [
            button.className styles.swatchButton
            button.appearance.primary
            button.disabled (items.Length >= ITEMS_LIMIT)
            button.onClick handleAddColor
            button.text "Add new color"
        ]
        Fui.button [
            button.className styles.swatchButton
            button.onClick (fun _ -> setItems defaultItems)
            button.text "Reset example"
        ]
        Html.div [ prop.style [ style.margin 25 ] ]
        Fui.swatchPicker [
            swatchPicker.layout.grid
            swatchPicker.children [
                yield!
                    Fui.renderSwatchPickerGrid [
                        swatchPickerGrid.items items
                        swatchPickerGrid.columnCount 2
                        swatchPickerGrid.renderSwatch (fun (item: Swatch) ->
                            if item.color = "#FF7A00" then
                                Fui.text "Orange"
                            else
                                Fui.colorSwatch [
                                    colorSwatch.key item.value
                                    colorSwatch.value item.value
                                    colorSwatch.ariaLabel item.``aria-label``
                                    colorSwatch.color item.color
                                ])
                    ]
            ]
        ]
    ]

type MotionStyles = {
    container: string
    card: string
    item: string
    description: string
    controls: string
}

let useMotionStyles =
    Fui.makeStyles<MotionStyles> [
        "container",
        [
            style.display.grid
            style.gridTemplateColumns [ (length.fr 1) ]
            style.gap (length.px 10)
        ]
        "card",
        [
            style.display.flex
            style.flexDirection.column
            style.border (tokens.strokeWidthThicker, borderStyle.solid, tokens.colorNeutralForeground3)
            style.borderRadius (length.px 5)
            style.padding (length.px 10)
            style.alignItems.center
        ]
        "item",
        [
            style.backgroundColor tokens.colorBrandBackground
            style.border (tokens.strokeWidthThicker, borderStyle.solid, tokens.colorTransparentStroke)
            style.borderRadius (length.percent 50)
            style.width (length.px 100)
            style.height (length.px 100)
        ]
        "description", [ style.margin (length.px 5) ]
        "controls",
        [
            style.display.flex
            style.flexDirection.column
            style.marginTop (length.px 20)
            style.border (tokens.strokeWidthThicker, borderStyle.solid, tokens.colorNeutralForeground3)
            style.borderRadius (length.px 5)
            style.padding (length.px 10)
        ]
    ]

[<ReactComponent>]
let PresenceComponentTest () =
    let styles = useMotionStyles ()
    let motionRef: IRefValue<MotionImperativeRef option> = React.useRef (None)
    let visible, setVisible = React.useState false

    let DropIn =
        Fui.createPresenceComponent {
            enter = [
                atomMotion.keyframes [
                    [
                        style.transform [
                            transform.rotate -30
                            transform.translateY (length.percent -100)
                        ]
                        style.opacity 0.0
                    ]
                    [
                        style.transform [
                            transform.rotate -90
                            transform.translateX (length.percent -50)
                        ]
                        style.opacity 0.5
                    ]
                    [
                        style.transform [
                            transform.rotate 0
                            transform.translateY (length.percent 0)
                        ]
                        style.opacity 1.0
                    ]
                ]
                atomMotion.duration 2000
            ]
            exit = [
                atomMotion.keyframes [
                    [
                        style.opacity 1.0
                        style.opacity 0.0
                    ]
                ]
                atomMotion.duration 1000
            ]
        }

    Html.div [
        Html.div [
            prop.className styles.container
            prop.children [
                Html.div [
                    prop.className styles.card
                    prop.children [
                        DropIn [
                            presenceComponent.imperativeRef motionRef
                            presenceComponent.visible visible
                            presenceComponent.children [ Html.div [ prop.className styles.item ] ]
                        ]
                        Html.code [
                            prop.className styles.description
                            prop.text "Drop in"
                        ]
                    ]
                ]
            ]
        ]

        Html.div [
            prop.className styles.controls
            prop.children [
                Html.div [
                    Fui.checkbox [
                        checkbox.label (Html.code "visible")
                        checkbox.checked' visible
                        checkbox.onChange (fun (_: bool) -> setVisible (visible |> not))
                    ]
                ]
            ]
        ]
    ]

type MotionComponentStyles = {
    container: string
    card: string
    item: string
    description: string
}

let useMotionComponentStyles =
    Fui.makeStyles<MotionComponentStyles> [
        "container",
        [
            style.display.grid
            style.gridTemplateColumns [ (length.fr 1) ]
            style.gap (length.px 10)
        ]
        "card",
        [
            style.display.flex
            style.flexDirection.column
            style.alignItems.center
            style.justifyContent.end'
            style.gridArea "card"
            style.border (tokens.strokeWidthThicker, borderStyle.solid, tokens.colorNeutralForeground3)
            style.borderRadius (length.px 5)
            style.padding (length.px 10)
        ]
        "item",
        [
            style.backgroundColor tokens.colorBrandBackground
            style.borderRadius (length.percent 50)
            style.width (length.px 100)
            style.height (length.px 100)
            style.custom ("forcedColorAdjust", "none")
        ]
        "description",
        [
            style.fontFamily Theme.tokens.fontFamilyMonospace
            style.borderRadius (length.px 15)
            style.marginTop (length.px 10)
            style.padding (length.px 5)
            style.backgroundColor Theme.tokens.colorNeutralBackground1Pressed
        ]
    ]

[<ReactComponent>]
let MotionComponentTest () =
    let styles = useMotionComponentStyles ()

    let BackgroundChange =
        Fui.createMotionComponent [
            atomMotion.keyframes [
                [ style.backgroundColor Theme.tokens.colorStatusDangerBackground3 ]
                [ style.backgroundColor Theme.tokens.colorStatusSuccessBackground3 ]
            ]
            atomMotion.duration 3000
            atomMotion.iterations.infinity
        ]

    Html.div [
        Html.div [
            prop.className styles.container
            prop.children [
                Html.div [
                    prop.className styles.card
                    prop.children [
                        BackgroundChange [ presenceComponent.children [ Html.div [ prop.className styles.item ] ] ]
                        Html.div "Custom background color motion"
                    ]
                ]
            ]
        ]
    ]

let useCarouselClasses =
    Fui.makeStyles<{|
        slider: string
        card: string
        image: string
        viewport: string
    |}>
        [
            "slider",
            [
                style.marginBottom (length.px 72)
                style.width (length.px 500)
            ]
            "card",
            [
                style.boxSizing.borderBox
                style.width (length.px 400)
                style.paddingLeft (length.px 52)
                style.paddingRight (length.px 52)
                style.overflow.hidden
                style.alignItems.center
            ]
            "image",
            [
                style.alignSelf.center
                style.width (length.percent 100)
            ]
            "viewport", [ style.marginBottom (length.px 72) ]
        ]

type ImageDefinition = {
    previewUrl: string
    url: string

    label: string
}

let images = [
    {
        previewUrl = "https://fabricweb.azureedge.net/fabric-website/assets/images/swatch-picker/sea-swatch.jpg"
        url = "https://fabricweb.azureedge.net/fabric-website/assets/images/swatch-picker/sea-full-img.jpg"
        label = "sea"
    }
    {
        previewUrl = "https://fabricweb.azureedge.net/fabric-website/assets/images/swatch-picker/bridge-swatch.jpg"
        url = "https://fabricweb.azureedge.net/fabric-website/assets/images/swatch-picker/bridge-full-img.jpg"
        label = "bridge"
    }
    {
        previewUrl = "https://fabricweb.azureedge.net/fabric-website/assets/images/swatch-picker/park-swatch.jpg"
        url = "https://fabricweb.azureedge.net/fabric-website/assets/images/swatch-picker/park-full-img.jpg"
        label = "park"
    }
]

[<ReactComponent>]
let CarouselTest () =
    let classes = useCarouselClasses ()

    Fui.carousel [
        carousel.groupSize 1
        carousel.align.center
        carousel.motion.slideWithDuration 50
        carousel.announcement (fun index totalSlides slideGroupList -> $"Carousel {index + 1} of {totalSlides}")
        carousel.children [
            Fui.carouselViewport [
                carouselViewport.className classes.viewport
                carouselViewport.children [
                    Fui.carouselSlider [
                        carouselSlider.className classes.slider
                        carouselSlider.children [
                            yield!
                                images
                                |> List.mapi (fun index img ->
                                    Fui.carouselCard [
                                        carouselCard.key img.url
                                        carouselCard.className classes.card
                                        carouselCard.ariaLabel $"{index + 1} of {images.Length}"
                                        carouselCard.children [
                                            Fui.image [
                                                image.className classes.image
                                                image.src img.url
                                                image.role "presentation"
                                            ]
                                        ]
                                    ])
                        ]
                    ]
                ]
            ]

            Fui.carouselNavContainer [
                carouselNavContainer.layout.overlayExpanded
                carouselNavContainer.next [ carouselButton.ariaLabel "go to next" ]
                carouselNavContainer.prev [ carouselButton.ariaLabel "go to prev" ]
                carouselNavContainer.children [
                    Fui.carouselNav [
                        carouselNav.children (fun index ->
                            Fui.carouselNavImageButton [
                                carouselNavImageButton.image [
                                    prop.src images.[index].previewUrl
                                    prop.ariaLabel $"Carousel Nav Button {index}"
                                ]
                            ])
                    ]
                ]
            ]
        ]
    ]

let navStyles = Fui.makeStyles<{| root: string; content: string; field: string |}> [
    "root", [
        style.overflow.hidden
        style.display.flex
        style.height (length.px 600)
    ]
    "content", [
        style.custom ("flex", "1")
        style.padding (length.px 16)
        style.display.grid
        style.justifyContent.flexStart
        style.alignItems.flexStart
    ]
]

let Person = Fui.bundleIcon bundleIcons.person
let Dashboard = Fui.bundleIcon bundleIcons.board
let Announcements = Fui.bundleIcon bundleIcons.megaphoneLoud
let EmployeeSpotlight = Fui.bundleIcon bundleIcons.personLightbulb
let Search = Fui.bundleIcon bundleIcons.personSearch
let PerformanceReviews = Fui.bundleIcon bundleIcons.previewLink
let JobPostings = Fui.bundleIcon bundleIcons.notePin
let Interviews = Fui.bundleIcon bundleIcons.people
let HealthPlans = Fui.bundleIcon bundleIcons.heartPulse
let TrainingPrograms = Fui.bundleIcon bundleIcons.boxMultiple
let CareerDevelopment = Fui.bundleIcon bundleIcons.peopleStar
let Analytics = Fui.bundleIcon bundleIcons.dataArea
let Reports = Fui.bundleIcon bundleIcons.documentBulletListMultiple

[<ReactComponent>]
let NavTest () =
    let styles = navStyles ()
    let isOpen, setIsOpen = React.useState true

    let renderHamburderWithTooltip () =
        Fui.tooltip [
            tooltip.content "Navigation"
            tooltip.relationship.label
            tooltip.children [
                Fui.hamburger [
                    hamburger.onClick (fun _ -> setIsOpen (isOpen |> not))
                ]
            ]
        ]

    Html.div [
        prop.className styles.root
        prop.children [
            Fui.navDrawer [
                navDrawer.defaultSelectedValue "2"
                navDrawer.defaultSelectedCategoryValue ""
                navDrawer.open' isOpen
                navDrawer.type'.inline'
                navDrawer.multiple true
                navDrawer.density.small
                navDrawer.size.medium
                navDrawer.children [
                    Fui.navDrawerHeader [ renderHamburderWithTooltip () ]
                    Fui.navDrawerBody [
                        Fui.appItem [
                            appItem.icon (Fui.icon.personCircleRegular [icon.size.``28``])
                            appItem.as'.a
                            appItem.href ""
                            appItem.children [
                                Html.text "Contoso HR"
                            ]
                        ]
                        Fui.navItem [
                            navItem.href ""
                            navItem.icon (Dashboard [icon.size.``28``])
                            navItem.value "1"
                            navItem.children [
                                Html.text "Dashboard"
                            ]
                        ]
                        Fui.navItem [
                            navItem.href ""
                            navItem.icon (Announcements [icon.size.``28``])
                            navItem.value "2"
                            navItem.children [
                                Html.text "Announcements"
                            ]
                        ]
                        Fui.navItem [
                            navItem.href ""
                            navItem.icon (EmployeeSpotlight [icon.size.``28``])
                            navItem.value "3"
                            navItem.children [
                                Html.text "Employee Spotlight"
                            ]
                        ]
                        Fui.navItem [
                            navItem.href ""
                            navItem.icon (Search [icon.size.``28``])
                            navItem.value "4"
                            navItem.children [
                                Html.text "Profile Search"
                            ]
                        ]
                        Fui.navItem [
                            navItem.href ""
                            navItem.icon (PerformanceReviews [icon.size.``28``])
                            navItem.value "5"
                            navItem.children [
                                Html.text "Performance Reviews"
                            ]
                        ]
                        Fui.navSectionHeader [
                            navSectionHeader.text "Employee Management"
                        ]
                        Fui.navCategory [
                            navCategory.value "6"
                            navCategory.children [
                                Fui.navCategoryItem [
                                    navCategoryItem.icon (JobPostings [icon.size.``28``])
                                    navCategoryItem.text "Job Postings"
                                ]
                                Fui.navSubItemGroup [
                                    Fui.navSubItem [
                                        navSubItem.href ""
                                        navSubItem.value "7"
                                        navSubItem.text "Openings"
                                    ]
                                    Fui.navSubItem [
                                        navSubItem.href ""
                                        navSubItem.value "8"
                                        navSubItem.text "Submissions"
                                    ]
                                ]
                            ]
                        ]
                        Fui.navItem [
                            navItem.icon (Interviews [icon.size.``28``])
                            navItem.value "9"
                            navItem.text "Interviews"
                        ]
                        Fui.navSectionHeader [
                            navSectionHeader.text "Benefits"
                        ]
                        Fui.navItem [
                            navItem.icon (HealthPlans [icon.size.``28``])
                            navItem.value "10"
                            navItem.text "Health Plans"
                        ]
                        Fui.navCategory [
                            navCategory.value "11"
                            navCategory.children [
                                Fui.navCategoryItem [
                                    navCategoryItem.icon (Person [icon.size.``28``])
                                    navCategoryItem.value "12"
                                    navCategoryItem.text "Retirement"
                                ]
                                Fui.navSubItemGroup [
                                    navSubItemGroup.children [
                                        Fui.navSubItem [
                                            navSubItem.href ""
                                            navSubItem.value "13"
                                            navSubItem.text "Plan Information"
                                        ]
                                        Fui.navSubItem [
                                            navSubItem.href ""
                                            navSubItem.value "14"
                                            navSubItem.text "Fund Performance"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Fui.navSectionHeader [
                            navSectionHeader.text "Learning"
                        ]
                        Fui.navItem [
                            navItem.icon (TrainingPrograms [icon.size.``28``])
                            navItem.value "15"
                            navItem.text "Training Programs"
                        ]
                        Fui.navCategory [
                            navCategory.value "16"
                            navCategory.children [
                                Fui.navCategoryItem [
                                    navCategoryItem.icon (CareerDevelopment [icon.size.``28``])
                                    navCategoryItem.text "Career Development"
                                ]
                                Fui.navSubItemGroup [
                                    Fui.navSubItem [
                                        navSubItem.href ""
                                        navSubItem.value "17"
                                        navSubItem.text "Career Paths"
                                    ]
                                    Fui.navSubItem [
                                        navSubItem.href ""
                                        navSubItem.value "18"
                                        navSubItem.text "Planning"
                                    ]
                                ]
                            ]
                        ]
                        Fui.navDivider []
                        Fui.navItem [
                            navItem.target "_blank"
                            navItem.icon (Analytics [icon.size.``28``])
                            navItem.value "19"
                            navItem.text "Workforce Data"
                        ]
                        Fui.navItem [
                            navItem.href ""
                            navItem.icon (Reports [icon.size.``28``])
                            navItem.value "20"
                            navItem.text "Reports"
                        ]
                    ]
                    Fui.navDrawerFooter [
                        navDrawerFooter.children [
                            Fui.button [
                                button.text "Close"
                            ]
                        ]
                    ]
                ]
            ]
            Html.div [
                prop.className styles.content
                prop.children [
                    if isOpen |> not then
                        renderHamburderWithTooltip ()
                    else
                        Html.none
                ]
            ]
        ]
    ]

[<ReactComponent>]
let UseRestoreFocusSource () =
    let restoreFocusSourceAttribute = Fui.useRestoreFocusSource()
    let restoreFocusTargetAttribute = Fui.useRestoreFocusTarget()
    let feedbackSent, setFeedbackSent = React.useState false

    React.useEffect (fun _ ->
        if feedbackSent then
            let setFeedback ()= async{
                do! Async.Sleep 5000
                setFeedbackSent false
            }

            setFeedback() |> Async.StartImmediate
        else
            ()
    , [| box feedbackSent |])

    Html.div [
        prop.children [
            Fui.field [
                field.label "Compose message"
                field.children [
                    Fui.textArea []
                ]
            ]
            Html.br []
            Fui.button [
                restoreFocusTargetAttribute |> unbox
                button.text "Send Message"
            ]
            if feedbackSent |> not then
                Html.div [
                    restoreFocusSourceAttribute
                    prop.children [
                        Html.text "How was your experience completing this task?"
                        Fui.button [
                            button.appearance.subtle
                            button.onClick (fun _ -> setFeedbackSent true)
                            button.icon (
                                Fui.icon.thumbLikeRegular []
                            )
                        ]
                        Fui.button [
                            button.appearance.subtle
                            button.onClick (fun _ -> setFeedbackSent true)
                            button.icon (
                                Fui.icon.thumbDislikeRegular []
                            )
                        ]
                    ]
                ]
            else
                Html.text "Thanks for submitting feedback!"
        ]
    ]
let useListItemRootStyles = Fui.makeResetStyles [
    style.position.relative
    style.flexGrow 1
    style.gap 8
    style.border (1, borderStyle.solid, "grey")
    style.alignItems.center
    style.borderRadius 8
    style.gridTemplate """ "preview preview preview" auto
      "header action secondary_action" auto / 1fr auto auto
    """
]

let useListStyles = Fui.makeStyles<{| list: string; listItem: string; caption: string; image: string; title: string; preview: string; header: string; action: string; secondaryAction: string |}> [
    "list", [
        style.display.flex
        style.flexDirection.column
        style.gap (length.px 16)
        style.maxWidth (length.px 300)
    ]
    "listItem", [
        style.display.grid
        style.padding (length.px 8)
    ]
    "caption", [
        style.color tokens.colorNeutralForeground3
    ]
    "image", [
        style.height (length.px 160)
        style.maxWidth (length.percent 100)
        style.borderRadius (length.px 5)
    ]
    "title", [
        style.color tokens.colorNeutralForeground1
        style.fontWeight 600
        style.display.block
    ]
    "preview", [
        style.gridArea "preview"
        style.overflow.hidden
    ]
    "header", [ style.gridArea "header" ]
    "action", [ style.gridArea "action" ]
    "secondaryAction", [ style.gridArea "secondary_action" ]
]

[<ReactComponent>]
let CustomListItem (title: string) (value: string) =
    let listItemStyles = useListItemRootStyles()
    let styles = useListStyles()

    Fui.listItem [
        listItem.value value
        listItem.className (Fui.mergeClasses(listItemStyles, styles.listItem))
        listItem.ariaLabel value
        listItem.onAction (fun (event: MouseEvent) (data: ListItemActionEventData<string, MouseEvent>) ->
            event.preventDefault()
            printfn $"ALERT: {data.value}"
        )
        listItem.children [
            Html.div [
                prop.role.gridCell
                prop.className styles.preview
                prop.children [
                    Fui.image [
                        image.fit.cover
                        image.className styles.image
                        image.src "https://fabricweb.azureedge.net/fabric-website/assets/images/wireframe/image.png"
                        image.alt "Presentation Preview"
                    ]
                ]
            ]
            Html.div [
                prop.role.gridCell
                prop.className styles.header
                prop.children [
                    Fui.text [
                        text.className styles.title
                        text.text title
                    ]
                    Fui.text.caption1 [
                        text.className styles.caption
                        text.text "You created 53m ago"
                    ]
                ]
            ]
            Html.div [
                prop.role.gridCell
                prop.className styles.action
                prop.children [
                    Fui.button [
                        button.appearance.primary
                        button.ariaLabel "Install"
                        button.onClick (fun (e: MouseEvent) ->
                            e.preventDefault()
                            printf "Installing!"
                        )
                        button.text "Install"
                    ]
                ]
            ]
            Html.div [
                prop.role.gridCell
                prop.className styles.secondaryAction
                prop.children [
                    Fui.menu [
                        Fui.menuTrigger [
                            menuTrigger.disableButtonEnhancement true
                            menuTrigger.children (
                                Fui.button [
                                    button.appearance.transparent
                                    button.icon (Fui.icon.moreHorizontalRegular [])
                                    button.onClick (fun e -> e.preventDefault())
                                    button.ariaLabel "More actions"
                                ]
                            )
                        ]
                        Fui.menuPopover [
                            Fui.menuList [
                                Fui.menuItem [
                                    menuItem.onClick (fun e ->
                                        e.preventDefault()
                                        printfn "Clicked menu item!"
                                    )
                                    menuItem.text "About"
                                ]
                                Fui.menuItem [
                                    menuItem.onClick (fun e ->
                                        e.preventDefault()
                                        printfn "Clicked menu item!"
                                    )
                                    menuItem.text "Uninstall"
                                ]
                                Fui.menuItem [
                                    menuItem.onClick (fun e ->
                                        e.preventDefault()
                                        printfn "Clicked menu item!"
                                    )
                                    menuItem.text "Block"
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

type Country = { Name: string; Id: int }

let countries = [
    { Name = "Afghanistan"; Id = 1 }
    { Name = "Albania"; Id = 2 }
    { Name = "Algeria"; Id = 3 }
    { Name = "Andorra"; Id = 4 }
    { Name = "Angola"; Id = 5 }
    { Name = "Antigua & Deps"; Id = 6 }
    { Name = "Argentina"; Id = 7 }
    { Name = "Armenia"; Id = 8 }
    { Name = "Australia"; Id = 9 }
    { Name = "Austria"; Id = 10 }
    { Name = "Azerbaijan"; Id = 11 }
    { Name = "Bahamas"; Id = 12 }
    { Name = "Bahrain"; Id = 13 }
    { Name = "Bangladesh"; Id = 14 }
    { Name = "Barbados"; Id = 15 }
    { Name = "Belarus"; Id = 16 }
]

[<ReactComponent>]
let ListTest () =
    Fui.fixedSizeList [
        fixedSizeList.width 400
        fixedSizeList.height 100
        fixedSizeList.itemData countries
        fixedSizeList.itemSize 100
        fixedSizeList.itemCount countries.Length
        fixedSizeList.layout.horizontal
        fixedSizeList.useIsScrolling true
        fixedSizeList.itemKey (fun index (data: Country array) ->
            let country = data.[index]
            country.Id
        )
        fixedSizeList.onItemsRendered (fun (oir: OnFixedSizeListItemsRendered) ->
                printfn "oir %A" (oir.overscanStartIndex, oir.overscanStopIndex, oir.visibleStartIndex, oir.visibleStopIndex)
        )
        fixedSizeList.onScroll (fun (os: OnFixedSizeListScroll) ->
                printfn "os %A" (os.scrollDirection, os.scrollOffset)
        )
        fixedSizeList.overscanCount 3
        fixedSizeList.children (fun (props: FixedSizeListRenderProps<Country>) ->
            let country = props.data[props.index]
            Fui.listItem [
                listItem.style props.style
                listItem.ariaSetSize countries.Length
                listItem.ariaPosInSet (props.index + 1)
                listItem.children [
                    Fui.text country.Name
                ]
            ]
        )
    ]

type Event =
    | Presenter
    | Break
    | ``Team Bonding``

module Event =
    let getColors = function
        | Presenter -> "black", "orange"
        | Break -> "white", "green"
        | ``Team Bonding`` -> "black", "yellow"
        | _ -> "black", "white"

    let fromText = function
        | Some "Presenter" -> Presenter
        | Some "Break" -> Break
        | Some "Team Bonding" -> ``Team Bonding``
        | _ -> Presenter

open Fable.Core.JsInterop

[<ReactComponent>]
let FullCalendar () =
    let isDialogOpen, setIsDialogOpen = React.useState false
    let newEventTitle, setNewEventTitle = React.useState ""
    let (selectedDate: DateSelectArg option), setSelectedDate = React.useState None
    let startTime, setStartTime = React.useState None
    let endTime, setEndTime = React.useState None
    let (dayEvent: Event), setDayEvent = React.useState Presenter
    let allDay, setAllDay = React.useState false
    let (calRef: IRefValue<FullCalendar option>) = React.useRef None
    let containerEl = Browser.Dom.document.getElementById "external-events"
    let checkboxEl = Browser.Dom.document.getElementById "drop-remove"

    if containerEl <> null then
        Draggable (containerEl, [
            draggable.itemSelector ".fc-event"
            draggable.eventData (fun el -> [
                    event.title el.innerText
                    event.backgroundColor "green"
                ]
            )
        ])

    let handleDateSelect =
        (fun selected ->
            let calendarApi = calRef.current.Value.getApi()
            let events = calendarApi.getEvents()
            printfn "calRef %A" (events |> Array.map (fun t -> t.title))
            setSelectedDate (Some selected)
            setIsDialogOpen true
            setStartTime (Some selected.start)
            setEndTime (Some selected.``end``)
        )

    let handleCloseDialog =
        fun _ ->
            setIsDialogOpen false
            setNewEventTitle ""
            setStartTime None
            setEndTime None
            setDayEvent Presenter

    let handleEventClick =
        fun (selected: EventClickArg) ->
            if Browser.Dom.window.confirm $"Are you sure you want to delete the event {selected.event.title}" then
                selected.event.remove ()

    let handleAddEvent =
        (fun (e: Browser.Types.Event) ->
            e.preventDefault ()

            match startTime, endTime with
            | Some startTime, Some endTime ->
                if newEventTitle <> "" && selectedDate.IsSome then
                    let calendarApi = selectedDate.Value.view.calendar
                    calendarApi.unselect ()

                    let (textColor, backgrounColor) = dayEvent |> Event.getColors

                    let newEvent = [
                        event.id newEventTitle
                        event.title newEventTitle
                        event.start startTime
                        event.end' endTime
                        event.allDay allDay
                        event.backgroundColor backgrounColor
                        event.textColor textColor
                    ]

                    let added = calendarApi.addEvent (!!newEvent |> createObj |> unbox)
                    printfn "added %A" added
                    added
                    handleCloseDialog ()
            | _, _ -> ()
        )

    let getTimePickerStartHour = function
        | 1 -> timePicker.startHour.``1``
        | 2 -> timePicker.startHour.``2``
        | 3 -> timePicker.startHour.``3``
        | 4 -> timePicker.startHour.``4``
        | 5 -> timePicker.startHour.``5``
        | 6 -> timePicker.startHour.``6``
        | 7 -> timePicker.startHour.``7``
        | 8 -> timePicker.startHour.``8``
        | 9 -> timePicker.startHour.``9``
        | 10 -> timePicker.startHour.``10``
        | 11 -> timePicker.startHour.``11``
        | 12 -> timePicker.startHour.``12``
        | 13 -> timePicker.startHour.``13``
        | 14 -> timePicker.startHour.``14``
        | 15 -> timePicker.startHour.``15``
        | 16 -> timePicker.startHour.``16``
        | 17 -> timePicker.startHour.``17``
        | 18 -> timePicker.startHour.``18``
        | 19 -> timePicker.startHour.``19``
        | 20 -> timePicker.startHour.``20``
        | 21 -> timePicker.startHour.``21``
        | 22 -> timePicker.startHour.``22``
        | 23 -> timePicker.startHour.``23``
        | 0
        | _ -> timePicker.startHour.``0``

    Html.div [
        prop.style [ style.width (length.vw 70) ]
        prop.children [
            Html.div [
                prop.id "external-events"
                prop.children [
                    for i in [1..5] do
                        Html.div [
                            prop.key i
                            prop.className "fc-event fc-h-event fc-daygrid-event fc-daygrid-block-event"
                            prop.children [
                                Html.div [
                                    prop.className "fc-event-main"
                                    prop.children [
                                        Html.text $"My Event {i}"
                                    ]
                                ]
                            ]
                        ]
                    Html.p [
                        Fui.checkbox [
                            checkbox.id "drop-remove"
                            checkbox.label "Remove after drop"
                        ]
                    ]
                ]
            ]
            Calendar [
                calendar.plugins [
                    Plugin.dayGridPlugin
                    Plugin.timeGridPlugin
                    Plugin.interactionPlugin
                    Plugin.bootstrap5Plugin
                    Plugin.listPlugin
                    Plugin.multimonthPlugin
                    // Plugin.momentTimezonePlugin
                ]
                calendar.ref calRef
                calendar.droppable true
                calendar.initialView.dayGridMonth
                calendar.eventDrop (fun i -> printfn "i %A" (i.delta.days) )
                calendar.eventChange (fun c -> printfn "event %A oldEvent %A" c.event.start c.oldEvent.start)
                calendar.editable true
                calendar.drop (fun (info: DropInfo) ->
                    if checkboxEl?checked = true then
                        info.draggedEl.parentNode.removeChild(info.draggedEl) |> ignore
                    else
                        ()
                )
                calendar.selectMirror true
                calendar.nowIndicator true
                // calendar.timezone "Europe/Moscow"
                calendar.unselectAuto true
                calendar.unselect (fun ev view -> printfn "view %A" view) //TODO
                // calendar.validRange [ range.start DateTime.Today; range.end' (DateTime.Today.AddDays 4)]
                // calendar.slotMinTime [
                //     duration.hour 9
                // ]
                calendar.selectable true
                calendar.select handleDateSelect
                calendar.eventClick handleEventClick
                calendar.themeSystem.bootstrap5
                calendar.dayMaxEvents true
                calendar.eventAdd (fun e -> printfn "e %A" (e.event.title))
                calendar.loading (fun b -> printfn "isLoading %A" b)
                calendar.buttonIcons [
                    buttonIcon.prev "chevron-left"
                ]
                calendar.eventsSet (fun (e: CalendarEvent array) -> printfn "eventsSet %A" (e |> Array.map (fun e -> e.title)))
                calendar.headerToolbar [
                    headerToolbar.start "today prev,next"
                    headerToolbar.center "title"
                    headerToolbar.end' "myCustomButton, dayGridMonth,timeGridWeek,timeGridDay,list"
                ]
                calendar.dayHeaderFormat [
                    dateFormat.weekday.short
                ]
                calendar.customButtons [
                    "myCustomButton",
                    [
                        customButton.text "Add event"
                        customButton.icon "plus-circle"
                        // customButton.click handleAddEventClick
                    ]
                ]
                // calendar.events "https://calendar.io/api/demo-feeds/events.json"
                calendar.initialEvents [
                    [
                        event.id "1"
                        event.title "All-day event"
                        event.start (System.DateTime.Parse "3/13/2025 11:00:00 AM")
                        event.end' (System.DateTime.Parse "3/13/2025 12:00:00 PM")
                        event.backgroundColor "red"
                        event.allDay true
                    ]
                    [
                        event.id "2"
                        event.title "Timed event"
                        event.allDay false
                        event.start (System.DateTime.Parse "3/11/2025 11:00:00 AM")
                        event.end' (System.DateTime.Parse "3/11/2025 12:00:00 PM")
                        prop.custom("displayEventTime", "false") |> unbox
                    ]
                ]
            ]
            Fui.dialog [
                dialog.open' isDialogOpen
                dialog.onOpenChange (fun (d: DialogOpenChangeData<Browser.Types.MouseEvent>) ->
                    d.``open`` |> setIsDialogOpen)
                dialog.children [
                    Fui.dialogSurface [
                        Fui.dialogContent [
                            dialogContent.children [
                                Html.form [
                                    prop.onSubmit handleAddEvent
                                    prop.children [
                                        Fui.stack [
                                            stack.tokens [ stack.tokens.childrenGap 8 ]
                                            stack.horizontal false
                                            stack.children [
                                                Fui.dropdown [
                                                    dropdown.value $"{dayEvent}"
                                                    dropdown.onOptionSelect (fun (d: OptionOnSelectData) -> d.optionValue |> Event.fromText |> setDayEvent)
                                                    dropdown.children [
                                                        for event in [ Presenter; Break; ``Team Bonding``] do
                                                            Fui.option [
                                                                option.value $"{event}"
                                                                option.text $"{event}"
                                                                option.children [
                                                                    Fui.text $"{event}"
                                                                ]
                                                            ]
                                                    ]
                                                ]
                                                Fui.input [
                                                    input.type' "text"
                                                    input.placeholder "Event Title"
                                                    input.value newEventTitle
                                                    input.onChange (fun e -> setNewEventTitle e)
                                                    input.required true
                                                ]
                                                Fui.timePicker [
                                                    timePicker.selectedTime startTime
                                                    timePicker.onTimeChange (fun (t: TimeSelectionData) -> setStartTime t.selectedTime)
                                                ]
                                                Fui.timePicker [
                                                    timePicker.selectedTime endTime
                                                    match selectedDate with
                                                    | Some sd ->
                                                        timePicker.dateAnchor sd.start
                                                        getTimePickerStartHour sd.start.Hour
                                                    | None ->
                                                        prop.custom ("", "") |> unbox
                                                    timePicker.onTimeChange (fun (t: TimeSelectionData) -> setEndTime t.selectedTime)
                                                ]
                                                Fui.checkbox [
                                                    checkbox.isChecked allDay
                                                    checkbox.onCheckedChange (fun c -> setAllDay c)
                                                    checkbox.label "All Day Event"
                                                ]
                                                Fui.button [
                                                    button.type' "submit"
                                                    button.text "Add"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let mainContent model dispatch =

    // findIconsWithoutFilledOrRegularVersions IconsToTest.icons

    let newTokens = {
        Theme.tokens with
            colorBrandStroke1 = "#cbe82e"
    }

    let typographyStyles = Fui.typographyStyles

    Fui.stack [
        stack.horizontal false
        stack.tokens [
            stack.tokens.childrenGap 16
            stack.tokens.padding 32
        ]
        stack.horizontalAlign.center
        stack.children [
            FullCalendar()
            Html.div [
                prop.style [
                    style.height 200
                    style.width 200
                    style.backgroundColor newTokens.colorBrandStroke1
                ]
                prop.children [
                    Fui.text [
                        text.text "Typography Styles"
                        text.style [
                            style.fontSize typographyStyles.title1.felizFontSize
                            style.fontFamily typographyStyles.title1.fontFamily
                            style.color newTokens.colorBrandBackgroundHover
                            style.lineHeight typographyStyles.title1.lineHeight
                            style.fontWeight typographyStyles.title1.fontWeight
                        ]
                    ]
                ]
            ]
            ListTest ()
            UseRestoreFocusSource ()
            NavTest ()
            CarouselTest()
            PresenceComponentTest()
            MotionComponentTest()
            SwatchPickerTest()
            TagPickerTest()
            ratingTest ()
            ratingDisplayTest
            ratingItemTest
            TeachingPopoverTest()
            TimePickerTest()
            MergeClassesTest true
            MergeClassesTest false
            Accordion()
            Checkbox()
            avatarTest
            ToggleButtons()
            buttonTest
            menuButtonTest
            MenuTest()
            imageTest
            presenceBadgeTest
            counterBadge
            PopoverTest()
            tooltipTest
            linkTest
            divider
            textTest
            UseArrowNavigationGroup()
            labelTest
            IconTest()
            inputTest model dispatch
            CompoundButtonTest()
            SplitButtonTest()
            TextAreaTest()
            SliderTest()
            SwitchTest()
            RadioGroupTest()
            TabListTest()
            spinnerTest
            SpinButtonTest()
            SelectTest()
            personaTest
            DropdownTest()
            ComboBoxTest()
            ToolbarTest()
            ControlledToolbarTest()
            avatarGroupTest
            progressBarTest
            DialogTest()
            ToastTest()
            CardTest()
            SkeletonTest()
            DatePickerTest()
            badgeTest
            OverflowTest()
            UseFocusableGroupTest()
            InfoButtonTest()
            infoLabelTest
            alertTest
            VirtualizerTest()
            VirtualizerScrollViewTest()
            DrawerTest()
            simpleTreeTest
            FlatTreeTest()
            DataGridTest()
            // SimpleTableTest()
            UseFocusFindersTest()
            UseModalAttributesOptionsTest()
            fieldPropsTest
            BreadcrumbTest()
            SearchBoxTest()
            TagTest()
            InteractionTagTest()
            Portal()
            MessageBarTest()
            CalendarTest()
        ]
    ]


let view model dispatch = mainContent model dispatch
