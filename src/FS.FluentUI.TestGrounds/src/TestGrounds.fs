module TestGrounds

open Elmish
open Feliz
open FS.FluentUI
open FS.FluentUI.V8toV9
open Browser.Types

type Msg =
    | DisableAll

type Model = {
    Disabled: bool
}

let init () =
    {
        Disabled = false
    },
    Cmd.none

let update msg model =
    match msg with
    | DisableAll ->
        {
            model with
                Disabled = not model.Disabled
        },
        Cmd.none

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
}

let useStyles: unit -> Styles = Fui.makeStyles [
    "accordion", [
        style.color.red
        style.backgroundColor.darkGray
    ]
    "useArrowNavigationGroup", [
        style.display.flex
        style.columnGap 15
    ]
    "tooltip", [
        style.backgroundColor tokens.colorBrandBackground
        style.color tokens.colorNeutralForegroundInverted
    ]
    "icon", [
        style.color.green
    ]
    "compoundButton", [
        style.width (length.px 150)
    ]
    "splitButton", [
        style.width (length.px 150)
    ]
    "skeletonStack", [
        style.backgroundColor tokens.colorBrandForegroundOnLight
        style.padding (length.px 50)
    ]
    "day", [
        style.border (1, borderStyle.solid, "red")
    ]
    "overflow", [
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
    "breadcrumb", [
        style.backgroundColor tokens.colorNeutralBackground2
        style.overflow.hidden
        style.padding (length.px 25)
        style.height (length.px 50)
        style.minWidth (length.px 150)
        style.zIndex 0
        style.resize.horizontal
        style.maxWidth (length.px 600)
    ]
]

[<ReactComponent>]
let Accordion () =
    let openItems, setOpenItems = React.useState [1]

    let styles = useStyles()
    let getIcon key =
        if openItems |> List.contains key then
            Fui.icon.subtractFilled []
        else
            Fui.icon.addFilled []

    Fui.accordion [
        accordion.collapsible true
        accordion.className styles.accordion
        accordion.openItems openItems
        accordion.defaultOpenItems openItems
        accordion.onToggle (fun (i: ValueProp<int>) ->
            if openItems |> List.contains i.value then
                setOpenItems (openItems |> List.except [i.value])
            else
            setOpenItems (openItems |> List.append [i.value])
        )
        accordion.multiple true
        accordion.children [
            Fui.accordionItem [
                accordionItem.key "a"
                accordionItem.value 1
                accordionItem.children [
                    Fui.accordionHeader [
                        accordionHeader.expandIcon (getIcon 1)
                        accordionHeader.expandIconPosition.end'
                        accordionHeader.children [
                            Fui.text "Header 1"
                        ]
                    ]
                    Fui.accordionPanel [
                        Fui.text "Panel 1"
                    ]
                ]
            ]
            Fui.accordionItem [
                accordionItem.key "b"
                accordionItem.value 2
                accordionItem.children [
                    Fui.accordionHeader [
                        accordionHeader.expandIcon (getIcon 2)
                        accordionHeader.children [
                            Fui.text "Header 2"
                        ]
                    ]
                    Fui.accordionPanel [
                        Fui.text "Panel 2"
                    ]
                ]
            ]
            Fui.accordionItem [
                accordionItem.key "c"
                accordionItem.value 3
                accordionItem.children [
                    Fui.accordionHeader [
                        accordionHeader.expandIcon (getIcon 3)
                        accordionHeader.children [
                            Fui.text "Header 3"
                        ]
                    ]
                    Fui.accordionPanel [
                        Fui.text "Panel 3"
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let Checkbox () =
    let isChecked1, setIsChecked1 = React.useState Checked
    let isChecked2, setIsChecked2 = React.useState Mixed

    Html.div [
        Fui.checkbox [
            checkbox.checked' isChecked1
            checkbox.onChange (fun i -> setIsChecked1 i)
            checkbox.size.large
            checkbox.label (
                Fui.text "This is a label"
            )
            checkbox.indicator (
                Fui.icon.alignStartHorizontalRegular []
            )
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
        avatar.badge [
            presenceBadge.status.outOfOffice
        ]
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
        button.iconPosition.after
        button.shape.circular
        button.onClick (fun (_: MouseEvent) -> printfn "hello")
    ]

let menuButtonTest =
    Fui.menuButton [
        menuButton.icon (Fui.icon.calendar3DayFilled [])
        menuButton.onClick (fun _ -> printfn "menuButton clicked")
        menuButton.shape.square
        menuButton.menuIcon (Fui.icon.arrowUpFilled [])
        menuButton.appearance.secondary
        menuButton.text "This is a menu button"
    ]

[<ReactComponent>]
let MenuTest() =
    let checkedValues, setCheckedValues = React.useState({| data = [|"add"|] |})
    let isOpen, setIsOpen = React.useState false
    let AddIcon = Fui.bundleIcon (Bundle.icon.addCircleFilled, Bundle.icon.addCircleRegular)
    let DataIcon = Fui.bundleIcon (Bundle.icon.dataAreaFilled, Bundle.icon.dataAreaRegular)
    let FunnelIcon = Fui.bundleIcon (Bundle.icon.dataFunnelFilled, Bundle.icon.dataFunnelRegular)

    Fui.menu [
        menu.checkedValues checkedValues
        menu.open' isOpen
        menu.positioning [
            positioning.coverTarget true
        ]
        menu.onOpenChange (fun (d: MenuOpenChangeData) -> setIsOpen d.``open``)
        menu.onCheckedValueChange (fun (_: MouseEvent) (d:MenuCheckedValueChangeData) -> setCheckedValues({| data = d.checkedItems |}))
        menu.children [
            Fui.menuTrigger [
                menuTrigger.disableButtonEnhancement true
                menuTrigger.children (
                    Fui.button [
                        button.text "Toggle menu"
                    ]
                )
            ]
            Fui.menuPopover [
                Fui.menuList [
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.icon (AddIcon [])
                        menuItemCheckbox.name "data"
                        menuItemCheckbox.value "add"
                        menuItemCheckbox.children [
                            Fui.text "Add Data"
                        ]
                    ]
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.icon (DataIcon [])
                        menuItemCheckbox.name "data"
                        menuItemCheckbox.value "trends"
                        menuItemCheckbox.children [
                            Fui.text "Show Trends"
                        ]
                    ]
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.icon (FunnelIcon [])
                        menuItemCheckbox.name "data"
                        menuItemCheckbox.value "filter"
                        menuItemCheckbox.children [
                            Fui.text "Filter Data"
                        ]
                    ]
                    Fui.menuItemCheckbox [
                        menuItemCheckbox.disabled true
                        menuItemCheckbox.icon (Fui.icon.editFilled [])
                        menuItemCheckbox.name "disabled"
                        menuItemCheckbox.value "disabled"
                        menuItemCheckbox.children [
                            Fui.text "Show Debug Panel"
                        ]
                    ]
                    Fui.menuDivider []
                    Fui.menu [
                        menu.children [
                            Fui.menuSplitGroup [
                                Fui.menuItem "Open"
                                Fui.menuTrigger [
                                    menuTrigger.disableButtonEnhancement true
                                    menuTrigger.children (
                                        Fui.menuItem [
                                            menuItem.ariaLabel "Open on platform"
                                        ]
                                    )
                                ]
                            ]
                            Fui.menuPopover [
                                menuPopover.children [
                                    Fui.menuList [
                                        Fui.menuItem "In Browser"
                                        Fui.menuItem "In Desktop App"
                                        Fui.menuItem "In Mobile"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let ToggleButtons () =
    let checkedIcon = Fui.bundleIcon(Bundle.icon.checkbox1Filled, Bundle.icon.checkbox1Regular)
    let isChecked1, setIsChecked1 = React.useState true
    let isChecked2, setIsChecked2 = React.useState false
    Html.div [
        Fui.toggleButton [
            toggleButton.icon (checkedIcon [])
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
        divider.style [ style.color.red; style.fontWeight 700 ]
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
            Fui.text.display [
                text.text "Display"
            ]
        ]
    ]

[<ReactComponent>]
let UseArrowNavigationGroup () =
    let keyboardNavAttr = Fui.useArrowNavigationGroup [
        useArrowNavigationGroupOptions.circular true
    ]

    let styles = useStyles()

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
                ]
                popover.onOpenChange (fun (data: OpenProp) -> if data.``open`` = false then setVisible false)
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (
                            Fui.button [
                                button.text "Toggle Popover"
                            ]
                        )
                    ]
                    Fui.popoverSurface [
                        popoverSurface.style [ style.display.flex; style.flexDirection.column; style.height 100; style.alignContent.center; style.justifyContent.center ]
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

[<ReactComponent>]
let TooltipTest ()=
    let styles = useStyles()

    Fui.tooltip [
        tooltip.withArrow true
        tooltip.content ( //TODO backgroundcolor from class doesn't fill width of tooltip
            Fui.text [
                text.className styles.tooltip
                text.text "Example tooltip"
            ]
        )
        tooltip.relationship.label
        tooltip.children (
            Fui.button [
                button.size.large
                button.icon (
                    Fui.icon.slideTextRegular []
                )
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
                label.required (
                    Fui.icon.alignStartVerticalRegular []
                )
                label.weight.semibold
                label.size.large
            ]
        ]
    ]

[<ReactComponent>]
let IconTest() =
    let styles = useStyles()

    Fui.stack [
        stack.horizontal true
        stack.children [
            Fui.icon.zoomFitFilled [
                icon.size.``48``
                icon.className styles.icon
            ]
        ]
    ]

let inputTest =
    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.stack [
                stack.horizontal false
                stack.children [
                    Fui.label [
                        label.htmlFor "emailId"
                        label.text "Email input"
                    ]
                    Fui.input [
                        input.type'.email
                        input.id "emailId"
                        input.value "lol@lol.com"
                        input.contentBefore (
                            Fui.icon.albumAddFilled []
                        )
                        input.size.large
                        input.appearance.filledDarkerShadow
                        input.contentAfter (
                            Fui.icon.airplaneRegular []
                        )
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
                        input.contentBefore (
                            Fui.icon.alertBadgeRegular []
                        )
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
let CompoundButtonTest() =
    let styles = useStyles()

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
let SplitButtonTest() =
    let styles = useStyles()

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
                        ]
                    )
                ]
                Fui.menuPopover [
                    Fui.menuList [
                        Fui.menuItem [
                            menuItem.text "Item a"
                        ]
                        Fui.menuItem [
                            menuItem.text "Item b"
                        ]
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
        textArea.onChange (fun (d: ValueProp<string>) -> if d.value.Length <= 20 then setValue d.value else setValue value)
        textArea.value value
        textArea.appearance.outline
        textArea.resize.both
    ]

[<ReactComponent>]
let SliderTest() =
    let id = Fui.useId(None, None)
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
let SwitchTest() =
    let checked', setChecked = React.useState false

    Fui.switch [
        switch.checked' checked'
        switch.label (if checked' then "With label above and checked" else "With label above and unchecked")
        switch.labelPosition.above
        switch.onChange (fun (d: SwitchOnChangeData) -> setChecked d.``checked``)
    ]

[<ReactComponent>]
let RadioGroupTest() =
    let value, setValue = React.useState "banana"
    let labelId = Fui.useId(Some "label-", None)
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
let TabListTest() =
    Fui.tabList [
        tabList.defaultSelectedValue "tab2"
        tabList.vertical true
        tabList.appearance.transparent
        tabList.onTabSelect (fun (d: ValueProp<string>) -> printfn "value %A" d.value )
        tabList.size.large
        tabList.children [
            Fui.tab [
                tab.value "tab1"
                tab.children [
                    Fui.text "First tab"
                ]
            ]
            Fui.tab [
                tab.value "tab2"
                tab.children [
                    Fui.text "Second tab"
                ]
            ]
            Fui.tab [
                tab.value "tab3"
                tab.children [
                    Fui.text "Third tab"
                ]
            ]
            Fui.tab [
                tab.value "tab4"
                tab.children [
                    Fui.text "Fourth tab"
                ]
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
let SpinButtonTest() =
    let id = Fui.useId(None, None)
    let value, setValue = React.useState(Some 0)
    let displayValue, setDisplayValue = React.useState("$0")
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
                spinButton.incrementButton  [
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
                        setDisplayValue $"{v}"
                )
            ]
        ]
    ]

let SelectTest() =
    let selectId = Fui.useId(None, None)
    let value, setValue = React.useState("Red")
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
                image.src "https://res-1.cdn.office.net/files/fabric-cdn-prod_20221209.001/office-ui-fabric-react-assets/persona-male.png"
            ]
        ]
    ]

[<ReactComponent>]
let DropdownTest() =
    let selected, setSelected = React.useState("Katri Athokas")
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
                dropdown.selectedOptions [|selected|]
                dropdown.onOptionSelect (fun (d: OptionOnSelectData) ->
                    match d.optionText with
                    | Some t ->
                        setSelected t
                    | None -> ()
                )
                dropdown.children [
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
                                        persona.presence [
                                            presenceBadge.status.available
                                        ]
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
                                        persona.presence [
                                            presenceBadge.status.busy
                                        ]
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
                                        persona.presence [
                                            presenceBadge.status.away
                                        ]
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
                                        persona.presence [
                                            presenceBadge.status.outOfOffice
                                        ]
                                        persona.secondaryText "Out of Office"
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let ComboBoxTest() =
    let seletedOptions, setSelectedOptions = React.useState([| |])
    let options = ["Cat"; "Dog"; "Ferret"; "Fish"; "Hamster"; "Snake"]
    Fui.stack [
        stack.horizontal false
        stack.children [
            Fui.label [
                label.id "comboBoxId"
                label.text "Best Pets"
            ]
            Fui.combobox [
                combobox.ariaLabelledBy "comboBoxId"
                combobox.multiselect true
                combobox.positioning [
                    positioning.offset {
                        crossAxis = Some 50
                        mainAxis = 50
                    }
                ]
                combobox.defaultSelectedOptions seletedOptions
                combobox.placeholder "Select one or more animals"
                combobox.onOptionSelect (fun (d: OptionOnSelectData) -> setSelectedOptions d.selectedOptions)
                // combobox.positioning.beforeBottom
                combobox.children (
                    options |> List.map (fun (o: string) ->
                        Fui.option [
                            option.key o
                            option.disabled (if o = "Ferret" then true else false)
                            option.value o
                            option.children [
                                Fui.text o
                            ]
                        ]
                    )
                )
            ]
            Fui.stack [
                stack.horizontal true
                stack.children [
                    Fui.text "Chosen pets: "
                    Fui.text (seletedOptions |> String.concat ", ")
                ]
            ]
        ]
    ]

[<ReactComponent>]
let ToolbarTest() =
    let isOpen, setIsOpen = React.useState(None)

    Fui.toolbar [
        toolbar.ariaLabel "with popover"
        toolbar.size.small
        toolbar.children [
            Fui.popover [
                popover.withArrow true
                popover.trapFocus true
                popover.open' (if isOpen = Some "first" then true else false)
                popover.onOpenChange (fun (d: OpenProp ) -> setIsOpen(if d.``open`` = true then Some "first" else None))
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
                                    button.onClick (fun (_: MouseEvent )-> setIsOpen None)
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
                popover.onOpenChange (fun (d: OpenProp ) -> setIsOpen(if d.``open`` = true then Some "second" else None))
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
                                    button.onClick (fun (_: MouseEvent )-> setIsOpen None)
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
                popover.onOpenChange (fun (d: OpenProp ) -> setIsOpen(if d.``open`` = true then Some "third" else None))
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
                                    button.onClick (fun (_: MouseEvent )-> setIsOpen None)
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
                popover.onOpenChange (fun (d: OpenProp ) -> setIsOpen(if d.``open`` = true then Some "fourth" else None))
                popover.children [
                    Fui.popoverTrigger [
                        popoverTrigger.disableButtonEnhancement true
                        popoverTrigger.children (
                            Fui.toolbarButton [
                                toolbarButton.ariaLabel "Quick Actions"
                                toolbarButton.children [
                                    Fui.text "Quick Actions"
                                ]
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
                                    button.onClick (fun (_: MouseEvent )-> setIsOpen None)
                                ]
                            ]
                        ]
                    ]
                ]
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

    let spreadPartition = Fui.partitionAvatarGroupItems [
        partitionAvatarGroupItemsOptions.items names
        partitionAvatarGroupItemsOptions.layout.spread
    ]

    let piePartition = Fui.partitionAvatarGroupItems [
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
                    yield! spreadPartition.inlineItems |> Array.map (fun n ->
                        Fui.avatarGroupItem [
                            avatarGroupItem.name n
                            avatarGroupItem.key n
                        ]
                    )
                    Fui.avatarGroupPopover [
                        yield! spreadPartition.overflowItems |> Array.map (fun n ->
                            Fui.avatarGroupItem [
                                avatarGroupItem.name n
                                avatarGroupItem.key n
                            ]
                        )
                    ]
                ]
            ]
            Fui.avatarGroup [
                avatarGroup.layout.pie
                avatarGroup.size.``56``
                avatarGroup.children [
                    yield! piePartition.inlineItems |> Array.map (fun n ->
                        Fui.avatarGroupItem [
                            avatarGroupItem.name n
                            avatarGroupItem.key n
                        ]
                    )
                    Fui.avatarGroupPopover [
                        yield! piePartition.overflowItems |> Array.map (fun n ->
                            Fui.avatarGroupItem [
                                avatarGroupItem.name n
                                avatarGroupItem.key n
                            ]
                        )
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
                field.children (
                    Fui.progressBar [
                        progressBar.thickness.large
                    ]
                )
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
let DialogTest() =
    let isOpen, setIsOpen = React.useState false
    Fui.dialog [
        dialog.open' isOpen
        dialog.onOpenChange (fun (d: DialogOpenChangeData) -> setIsOpen d.``open``)
        dialog.children [
            Fui.dialogTrigger [
                dialogTrigger.disableButtonEnhancement true
                dialogTrigger.children (
                    Fui.button [
                        button.text "Open dialog"
                    ]
                )
            ]
            Fui.dialogSurface [
                Fui.dialogBody [
                    Fui.dialogTitle [
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

let defaultToast =
    Fui.toast [
        toast.appearance.inverted
        toast.children [
            Fui.toastTitle [
                toastTitle.action (
                    Fui.link [
                        link.text "Undo"
                    ]
                )
                toastTitle.text "Email sent"
            ]
            Fui.toastBody [
                toastBody.subtitle "This is a subtitle"
                toastBody.text "This toast never closes"
            ]
            Fui.toastFooter [
                Fui.link [
                    link.text "Action1"
                ]
                Fui.link [
                    link.text "Action2"
                ]
            ]
        ]
    ]

//TODO Fable is transpiling the tuple passed to toastController.dispatchToast into a JS array, which is not what the function expects.
//TODO I have a feeling I need to pass the tuple to dispatchToast using partial application so that it doesn't have the chance to turn it into an array,
//TODO but I'm not sure how to do that.
[<ReactComponent>]
let ToastTest() =
    let toastId = Fui.useId (Some "toast", None)
    let toasterId = Fui.useId (Some "toaster", None)

    let mounted, setMounted = React.useState true

    let dispatchOptions = [
        dispatchToastOptions.toastId toastId
        dispatchToastOptions.intent.warning
        dispatchToastOptions.timeout  -1
        dispatchToastOptions.onStatusChange  (fun data -> setMounted(data.status = ToastStatus.unmounted))
    ]

    let updateOptions = [
        updateToastOptions.toastId toastId
        updateToastOptions.content (
            Fui.toast [
                Fui.toastTitle [
                    toastTitle.text "This toast will close soon"
                ]
            ]
        )
        updateToastOptions.timeout 2000
        updateToastOptions.intent.success
    ]

    let toastController = Fui.useToastController(toasterId)

    let notify = fun _ ->
        toastController.dispatchToast(defaultToast(*, Some (dispatchOptions |> dispatchToastOptions.toType)*)) //TODO
        setMounted false

    let update = fun _ -> toastController.updateToast(updateOptions |> updateToastOptions.toType) //TODO

    Fui.stack [
        stack.children [
            Fui.toaster [
                toaster.toasterId toasterId
            ]
            Fui.button [
                button.onClick (fun _ -> if mounted then notify() else update())
                button.text (if mounted then "Open Toast" else "Update Toast")
            ]
        ]
    ]

[<ReactComponent>]
let CardTest () =
    let selected, setSelected = React.useState(false)
    Fui.card [
        card.appearance.filled
        card.selected selected
        card.onSelectionChange (fun s -> setSelected s.selected)
        card.style [ style.width 400; style.maxWidth (length.percent 100); style.height.fitContent ]
        card.children [
            Fui.cardPreview [
                cardPreview.logo (
                    Fui.image [
                        image.style [ style.width 40 ]
                        image.src "https://cdn.sanity.io/images/599r6htc/localized/46a76c802176eb17b04e12108de7e7e0f3736dc6-1024x1024.png?w=804&h=804&q=75&fit=max&auto=format"
                        image.alt "Figma logo"
                    ]
                )
                cardPreview.children [
                    Fui.image [
                        image.src "https://i0.wp.com/www.smartprix.com/bytes/wp-content/uploads/2023/06/Untitled-design-88.jpg?fit=1200%2C675&ssl=1"
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
                cardHeader.description  "You created 53m ago"
                cardHeader.action (
                    Fui.button [
                        button.appearance.transparent
                        button.icon (
                            Fui.icon.moreHorizontalFilled []
                        )
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
let SkeletonTest() =
    let styles = useStyles()

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
                        skeleton.children [
                            Fui.skeletonItem [
                                skeletonItem.animation.wave
                            ]
                        ]
                    ]
                )
            ]
            Fui.field [
                field.validationMessage "Pulse animation"
                field.validationState.none
                field.children (
                    Fui.skeleton [
                        skeleton.style [ style.width 300 ]
                        skeleton.children [
                            Fui.skeletonItem [
                                skeletonItem.animation.pulse
                            ]
                        ]
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
        field.children (fun props ->
            Html.input [
                yield! props
            ]
        )
    ]

open System

[<ReactComponent>]
let DatePickerTest() =
    let styles = useStyles()
    let firstDayOfWeek, setFirstDayOfWeek = React.useState ("Sunday")
    let error, setError = React.useState (None)

    let days = [
        "Sunday";
        "Monday";
        "Tuesday";
        "Wednesday";
        "Thursday";
        "Friday";
        "Saturday";
    ]

    let validationMessage : string = error |> DatePickerErrorStrings.fromErrorTypeOption

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
                        datePicker.dateTimeFormatter ({ Fui.defaultDateFormatting with formatYear = fun d -> $"Year: {d.Year}"})
                        //TODO When customizing the formatted date with something other than built-in date functions, it conflicts with onValidationResult and doesn't render the date.
                        datePicker.formatDate (fun d -> d.ToShortDateString())
                        datePicker.onValidationResult (fun d -> setError d.error)
                        datePicker.calendar [
                            calendar.dateRangeType.workWeek
                            calendar.workWeekDays [| DayOfWeek.Monday; DayOfWeek.Tuesday; DayOfWeek.Wednesday; DayOfWeek.Thursday |]
                            calendar.isMonthPickerVisible false
                            calendar.calendarDayProps [
                                calendarDay.className styles.day
                            ]
                            calendar.strings ({
                                Fui.defaultDatePickerStrings with
                                    goToToday = "Pick Today"
                                    shortDays = [| "T"; "E"; "S"; "T"; "I"; "N"; "G"|]
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
                    | None -> ()
                )
                dropdown.defaultSelectedOptions [|firstDayOfWeek|]
                dropdown.value firstDayOfWeek
                dropdown.children (
                    days |> List.map (fun d ->
                        Fui.option [
                            option.key d
                            option.value d
                            option.children d
                        ]
                    )
                )
            ]
        ]
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
let OverflowMenuItem (key: string) (id: string)=

    let isVisible = Fui.useIsOverflowItemVisible(id)
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
            positioning.offset { crossAxis = Some 30; mainAxis = 35 }
        ]
        // menu.positioning.alignCenter
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
            Fui.menuPopover [
                Fui.menuList (
                    itemIds |> List.map (fun i ->
                        OverflowMenuItem i i
                    )
                )
            ]
        ]
    ]

[<ReactComponent>]
let OverflowTest ()=
    let itemIds = [ "0"; "1"; "2"; "3"; "4"; "5"; "6"; "7"]
    let styles = useStyles()

    Fui.overflow [
        overflow.children (
            Html.div [
                prop.className styles.overflow
                prop.children [
                    yield! itemIds |> List.map (fun i ->
                        Fui.overflowItem [
                            overflowItem.key i
                            overflowItem.id i
                            overflowItem.children (
                                Fui.button [
                                    button.text $"Item {i}"
                                ]
                            )
                        ]
                    )
                    yield OverflowMenu itemIds
                ]
            ]
        )
    ]

[<ReactComponent>]
let UseFocusableGroupTest ()=
    let attributes = Fui.useFocusableGroup [
        useFocusableGroupOptions.tabBehavior.limitedTrapFocus
    ]

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
                        prop.style [ style.display.flex; style.width 300 ]
                        prop.children [
                            Fui.button [
                                button.ariaLabel "Copy"
                                button.icon (
                                    Fui.icon.copyRegular []
                                )
                                button.size.small
                            ]
                            Fui.button [
                                button.ariaLabel "Delete"
                                button.icon (
                                    Fui.icon.deleteRegular []
                                )
                                button.size.small
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let InfoButtonTest() =
    let infobuttonInfoId = Fui.useId(Some "infobuton__info", None)
    let isOpen, setIsOpen = React.useState false

    Html.div [
        prop.ariaOwns (if isOpen then infobuttonInfoId else "")
        prop.children [
            Fui.label [
                label.size.large
                label.text "This is a large infoButton"
            ]
            Fui.infoButton [
                infoButton.size.large
                infoButton.info [
                    popoverSurface.id infobuttonInfoId
                    popoverSurface.text "This is example information for an InfoButton."
                ]
                infoButton.popover [
                    popover.onOpenChange (fun (d: OpenProp) -> setIsOpen d.``open``)
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
                        infoLabel.info "Example info"
                        infoLabel.text "Field with info label"
                        infoLabel.weight.semibold
                    ]
                )
                field.children (
                    Fui.input []
                )
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
                alert.icon [
                    prop.className "testing classname"
                ]
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
let VirtualizerTest() =
    let vm = Fui.useStaticVirtualizerMeasure [
        virtualizerMeasureProps.defaultItemSize 100
    ]

    let (vLength, bufferItems, bufferSize, scrollRef) = vm.virtualizerLength, vm.bufferItems, vm.bufferSize, vm.scrollRef

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
                // virtualizer.reversed true // TODO causes re-renders?
                virtualizer.before (
                    Fui.icon.bedFilled []
                )
                virtualizer.after (
                    Fui.icon.bedRegular []
                )
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
                        prop.children [
                            Fui.text $"Node-{index}"
                        ]
                    ]
                )
            ]
        ]
    ]

[<ReactComponent>]
let VirtualizerScrollViewTest() =
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
            ]
        )
    ]

[<ReactComponent>]
let DrawerTest() =
    let isOpen, setIsOpen = React.useState false
    Fui.stack [
        stack.children [
            Fui.drawerOverlay [
                drawerOverlay.modalType.nonModal
                drawerOverlay.open' isOpen
                drawerOverlay.onOpenChange (fun (_: KeyboardEvent) (data: DialogOpenChangeData) -> setIsOpen data.``open``)
                drawerOverlay.children [
                    Fui.drawerHeader [
                        Fui.drawerHeaderTitle [
                            drawerHeaderTitle.action (
                                Fui.button [
                                    button.appearance.subtle
                                    button.ariaLabel "subtle"
                                    button.icon (
                                        Fui.icon.dismissRegular [ icon.size.``48`` ]
                                    )
                                    button.onClick (fun _ -> setIsOpen false)
                                ]
                            )
                            drawerHeaderTitle.text "Overlay Drawer"
                        ]
                    ]
                    Fui.drawerBody [
                        Fui.text "Drawer content"
                    ]
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
            tree.defaultOpenItems ["subtree-1"]
            tree.ariaLabel "Default Layout"
            tree.children [
                Fui.treeItem [
                    treeItem.itemType.branch
                    treeItem.value "subtree-1"
                    treeItem.children [
                        Fui.treeItemLayout [
                            Fui.text "Tree using TreeItemLayout"
                        ]
                        Fui.tree [
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemLayout [
                                        Fui.text "level 2, item 1"
                                    ]
                                ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemLayout [
                                        Fui.text "level 2, item 2"
                                    ]
                                ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemLayout [
                                        Fui.text "level 2, item 3"
                                    ]
                                ]
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
                        Fui.treeItemPersonaLayout  [
                            treeItemPersonaLayout.media (
                                Fui.avatar [
                                    avatar.image [
                                        image.alt "avatar"
                                    ]
                                ]
                            )
                            treeItemPersonaLayout.children [
                                Fui.text "Tree using TreeItemLayout"
                            ]
                        ]
                        Fui.tree [
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemPersonaLayout [
                                        treeItemPersonaLayout.media (
                                            Fui.avatar [
                                                avatar.image [
                                                    image.alt "avatar"
                                                ]
                                            ]
                                        )
                                        treeItemPersonaLayout.description "with description"
                                        treeItemPersonaLayout.children [
                                            Fui.text "level 2, item 1"
                                        ]
                                    ]
                                ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemPersonaLayout [
                                        treeItemPersonaLayout.media (
                                            Fui.avatar [
                                                avatar.image [
                                                    image.alt "avatar"
                                                ]
                                                avatar.shape.square
                                            ]
                                        )
                                        treeItemPersonaLayout.description "square shape media"
                                        treeItemPersonaLayout.children [
                                            Fui.text "level 2, item 2"
                                        ]
                                    ]
                                ]
                            ]
                            Fui.treeItem [
                                treeItem.itemType.leaf
                                treeItem.children [
                                    Fui.treeItemPersonaLayout [
                                        treeItemPersonaLayout.description "without media"
                                        treeItemPersonaLayout.children [
                                            Fui.text "level 2, item 3"
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

type Column = { Columnkey: string; Label: string }
type Icon = { Label: string; Icon: ReactElement }
type Status = { Label: string; Status: IPresenceBadgeProp list }
type TimeStamp = { Label: string; TimeStamp: int }

type Item = {
    File: Icon
    Author: Status
    LastUpdated: TimeStamp
    LastUpdate: Icon
}

let items = [
    {
        File = { Label = "Meeting notes"; Icon = Fui.icon.documentRegular [] }
        Author = { Label = "Max Mustermann"; Status = [ presenceBadge.status.available; presenceBadge.size.extraSmall ] }
        LastUpdated = { Label = "7h ago"; TimeStamp = 1 }
        LastUpdate = { Label = "You edited this"; Icon = (Fui.icon.editRegular []) }
    }
    {
        File = { Label = "Thursday presentation"; Icon = Fui.icon.folderRegular [] }
        Author = { Label = "Erika Mustermann"; Status = [ presenceBadge.status.busy; presenceBadge.size.large ]  }
        LastUpdated = { Label = "Yesterday at 1:45pm"; TimeStamp = 2 }
        LastUpdate = { Label = "You recently opened this"; Icon = Fui.icon.openRegular [] }
    }
    {
        File = { Label = "Training recording"; Icon = Fui.icon.videoRegular [] }
        Author = { Label = "John Doe"; Status = [ presenceBadge.status.away; presenceBadge.size.small ]  }
        LastUpdated = { Label = "Yesterday at 1:45pm"; TimeStamp = 2 }
        LastUpdate = { Label = "You recently opened this"; Icon = Fui.icon.openRegular [] }
    }
    {
        File = { Label = "Purchase order"; Icon = Fui.icon.documentPdfRegular []  }
        Author = { Label = "Jane Doe"; Status = [ presenceBadge.status.offline; presenceBadge.size.tiny ] }
        LastUpdated = { Label = "Tue at 9:30 AM"; TimeStamp = 3 }
        LastUpdate = { Label = "You shared this in a Teams chat"; Icon = Fui.icon.peopleRegular []  }
    }
]

[<ReactComponent>]
let DataGridTest () =
    let selectedRows, setSelectedRows = React.useState (Set["Thursday Presentation"])

    let columns = [
        Fui.createTableColumn [
            createTableColumnOption.columnId "file"
            createTableColumnOption.compare (fun a b -> a.File.Label.CompareTo (Some b.File.Label))
            createTableColumnOption.renderHeaderCell (fun _ -> "File")
            createTableColumnOption.renderCell (fun item ->
                Fui.tableCellLayout [
                    tableCellLayout.key item.File.Label
                    tableCellLayout.media (
                        item.File.Icon
                    )
                    tableCellLayout.children [
                        Fui.text item.File.Label
                    ]
                ]
            )
        ]
        Fui.createTableColumn [
            createTableColumnOption.columnId  "author"
            createTableColumnOption.compare  (fun a b -> a.Author.Label.CompareTo (b.Author.Label))
            createTableColumnOption.renderHeaderCell  (fun _ -> "Author")
            createTableColumnOption.renderCell  (fun item ->
                Fui.tableCellLayout [
                    tableCellLayout.key item.Author.Label
                    tableCellLayout.media (
                        Fui.avatar [
                            avatar.ariaLabel item.Author.Label
                            avatar.name item.Author.Label
                            avatar.badge item.Author.Status
                        ]
                    )
                    tableCellLayout.children [
                        Fui.text item.Author.Label
                    ]
                ]
            )
        ]
        Fui.createTableColumn [
            createTableColumnOption.columnId "lastUpdated"
            createTableColumnOption.compare (fun a b -> a.LastUpdated.TimeStamp - b.LastUpdated.TimeStamp)
            createTableColumnOption.renderHeaderCell (fun _ -> "Last Updated")
            createTableColumnOption.renderCell (fun item -> item.LastUpdated.Label)
        ]
        Fui.createTableColumn [
            createTableColumnOption.columnId "lastUpdate"
            createTableColumnOption.compare (fun a b -> a.LastUpdate.Label.CompareTo (b.LastUpdate.Label))
            createTableColumnOption.renderHeaderCell (fun _ -> "Last Update")
            createTableColumnOption.renderCell (fun item ->
                Fui.tableCellLayout [
                    tableCellLayout.key item.LastUpdate.Label
                    tableCellLayout.media (
                        item.LastUpdate.Icon
                    )
                    tableCellLayout.children [
                        Fui.text item.LastUpdate.Label
                    ]
                ]
            )
        ]
    ]

    Fui.stack [
        stack.horizontal false
        stack.children [
            Html.ul (
                items |> List.map (fun i ->
                    Html.li [
                        prop.key i.File.Label
                        prop.children [
                            Fui.checkbox [
                                checkbox.label i.File.Label
                                checkbox.checked' (selectedRows |> Seq.contains i.File.Label)
                            ]
                        ]
                    ]
                )
            )
            Fui.dataGrid [
                dataGrid.items items
                dataGrid.columns columns
                dataGrid.sortable true
                dataGrid.selectionMode.multiselect
                dataGrid.selectedItems selectedRows
                dataGrid.getRowId (fun i -> i.File.Label)
                dataGrid.onSelectionChange (fun (data: {| selectedItems: Set<string> |}) -> setSelectedRows data.selectedItems)
                dataGrid.children [
                    Fui.dataGridHeader [
                        Fui.dataGridRow [
                            dataGridRow.selectionCell [
                                tableSelectionCell.ariaLabel "Select all rows"
                            ]
                            dataGridRow.children (fun tcd _ ->
                                Fui.dataGridHeaderCell [
                                    tcd.renderHeaderCell()
                                ]
                            )
                        ]
                    ]
                    Fui.dataGridBody [
                        dataGridBody.children (fun (trd: TableRowData<Item, int>) ->
                            Fui.dataGridRow [
                                dataGridRow.key trd.rowId
                                dataGridRow.selectionCell [
                                    tableSelectionCell.ariaLabel "Select row"
                                ]
                                dataGridRow.children (fun (tcd: TableColumnDefinition<Item, int>) _ ->
                                    Fui.dataGridCell [
                                        dataGridCell.key tcd.columnId
                                        dataGridCell.children [
                                            tcd.renderCell(trd.item)
                                        ]
                                    ]
                                )
                            ]
                        )
                    ]
                ]
            ]
        ]
    ]

[<ReactComponent>]
let SimpleTableTest () =
    let columns = [
        {| columnKey = "file"; label = "File" |}
        {| columnKey = "author"; label = "Author" |}
        {| columnKey = "lastUpdated"; label = "Last Updated" |}
        {| columnKey = "lastUpdate"; label = "Last Update" |}
    ]

    Fui.table [
        Fui.tableHeader [
            Fui.tableRow (
                columns |> List.map (fun c ->
                    Fui.tableHeaderCell [
                        tableHeaderCell.key c.columnKey
                        tableHeaderCell.children [
                            Fui.text c.label
                        ]
                    ]
                )
            )
        ]
        Fui.tableBody (
            items |> List.map (fun i ->
                Fui.tableRow [
                    tableRow.key i.File.Label
                    tableRow.children [
                        Fui.tableCell [
                            Fui.tableCellLayout [
                                tableCellLayout.media (
                                    i.File.Icon
                                )
                                tableCellLayout.children [
                                    Fui.text i.File.Label
                                ]
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
                        Fui.tableCell [
                            Fui.text i.LastUpdated.Label
                        ]
                        Fui.tableCell [
                            Fui.tableCellLayout [
                                tableCellLayout.media (
                                    i.LastUpdate.Icon
                                )
                                tableCellLayout.children [
                                    Fui.text i.LastUpdate.Label
                                ]
                            ]
                        ]
                    ]
                ]
            )
        )
    ]

[<ReactComponent>]
let UseFocusFindersTest() =
    let focusFinders = Fui.useFocusFinders()
    let findAllFocusable = focusFinders.findAllFocusable
    let count, setCount = React.useState 0
    let toolbarRef = React.useRef<HTMLDivElement option>(None)
    let attributes = Fui.useArrowNavigationGroup [
        useArrowNavigationGroupOptions.axis.horizontal
    ]

    let tokens = Theme.tokens

    React.useEffect((fun _ ->
        match toolbarRef.current with
        | Some ref ->
            let count = findAllFocusable ref None |> Seq.length
            setCount(count)
        | None -> ()

    ), [| unbox findAllFocusable |])

    Html.div [
        Html.div [
            prop.style [
                style.display.block
                style.backgroundColor tokens.colorBrandStroke1
                style.color tokens.colorNeutralForegroundOnBrand
                style.padding 4
                style.borderRadius 5
            ]
            prop.children [
                Fui.text.body1Stronger $"{count} focusable elements below"
            ]
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
                    button.icon (
                        Fui.icon.textBoldRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Underline"
                    button.icon (
                        Fui.icon.textUnderlineRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Italic"
                    button.icon (
                        Fui.icon.textItalicRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Align Left"
                    button.icon (
                        Fui.icon.textAlignLeftRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Align Right"
                    button.icon (
                        Fui.icon.textAlignRightRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Copy"
                    button.disabled true
                    button.icon (
                        Fui.icon.copyRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Cut"
                    button.disabled true
                    button.icon (
                        Fui.icon.cutRegular []
                    )
                ]
                Fui.button [
                    button.ariaLabel "Paste"
                    button.disabled true
                    button.icon (
                        Fui.icon.clipboardPasteRegular []
                    )
                ]
            ]
        ]
    ]

let dialogClass = Fui.makeResetStyles [
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
let UseModalAttributesOptionsTest() =
    let isOpen, setIsOpen = React.useState false
    let attributes = Fui.useModalAttributes [
        useModalAttributesOptions.trapFocus true
    ]
    let dialogClass = dialogClass()

    let triggerRef = React.useRef<HTMLButtonElement option>(None)
    let dialogRef = React.useRef<HTMLDivElement option>(None)

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
                    Html.div [
                        Fui.text "This is a dialog for example purposes - ⚠️DO NOT USE THIS CODE⚠️"
                    ]
                    Html.div [
                        Fui.button [
                            button.text "Action"
                        ]
                        Fui.button [
                            button.onClick (fun _ -> setIsOpen false)
                            button.text "Close"
                        ]
                    ]
                ]
            ]
    ]

[<ReactComponent>]
let FlatTreeTest() =
    let items = [
        [ headlessTreeItem.value "1" ]
        [ headlessTreeItem.value "1-1"; headlessTreeItem.parentValue "1" ]
        [ headlessTreeItem.value "1-2"; headlessTreeItem.parentValue "1" ]
        [ headlessTreeItem.value "2" ]
        [ headlessTreeItem.value "2-1"; headlessTreeItem.parentValue "2" ]
        [ headlessTreeItem.value "2-1-1"; headlessTreeItem.parentValue "2-1" ]
        [ headlessTreeItem.value "2-2"; headlessTreeItem.parentValue "2" ]
        [ headlessTreeItem.value "2-2-1"; headlessTreeItem.parentValue "2-2" ]
        [ headlessTreeItem.value "2-2-2"; headlessTreeItem.parentValue "2-2" ]
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

    let testFlatTree = Fui.useHeadlessFlatTree_unstable(items, [
            headlessFlatTreeOptions.defaultOpenItems ["1"; "2"; "2-1"; "2-2"]
            headlessFlatTreeOptions.defaultCheckedItems ["1-2"]
            headlessFlatTreeOptions.selectionMode.multiselect
        ]
    )

    let renderItem flatTreeItem =
        let treeItemProps = flatTreeItem.getTreeItemProps()

        Fui.treeItem [
            yield! treeItemProps |> treeItem.getProps
            treeItem.key flatTreeItem.value
            treeItem.children [
                Fui.treeItemLayout [
                    getContent treeItemProps.value
                ]
            ]
        ]

    Fui.flatTree [
        flatTree.ariaLabel "Selection"
        yield! testFlatTree.getTreeProps() |> flatTree.getProps
        flatTree.children [
            for flatTree in testFlatTree.items() do
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
                overflowDivider.children (
                    Fui.breadcrumbDivider [
                        breadcrumbDivider.custom ("data-group", button.key)
                    ]
                )
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
                        button.icon (
                            Fui.icon.moreHorizontalRegular []
                        )
                        button.ariaLabel $"{options.overflowCount} more tabs"
                        button.role "tab"
                    ]
                )
            ]
            Fui.menuPopover [
                Fui.menuList [
                    if options.isOverflowing then
                        yield! props.startDisplayedItems |> Seq.map (fun b ->
                            OverflowBreadcrumbButton (b.key |> string) b b.key
                        )
                    if props.overflowItems.Length <> 0 then
                        yield! props.overflowItems |> Seq.map (fun b ->
                            OverflowBreadcrumbButton (b.key |> string) b b.key
                        )
                    if options.isOverflowing && props.endDisplayedItems.Length <> 0 then
                        yield! props.endDisplayedItems |> Seq.map (fun b ->
                            OverflowBreadcrumbButton (b.key |> string) b b.key
                        )
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
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 2 was clicked")
        ]
    }
    {
        key = 3
        item = "Item 3"
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 3 was clicked")
        ]
    }
    {
        key = 4
        item= "Item 4"
        buttonProps= [
            breadcrumbButton.onClick (fun _ -> printfn "item 4 was clicked")
        ]
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
        buttonProps = [
            breadcrumbButton.onClick (fun _ -> printfn "item 7 was clicked")
        ]
    }
|]


[<ReactComponent>]
let BreadcrumbTest () =
    let styles = useStyles()

    let partitionBreadcrumbItems = Fui.partitionBreadcrumbItems [
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
                                    RenderButton b isLastItem
                                )
                                |> Array.toList
                    ]
                )
            ]
        ]
    ]

[<ReactComponent>]
let SearchBoxTest() =
    let value, setValue = React.useState ("initial value")
    let valid, setValid = React.useState true
    Fui.field [
        field.label "Controlled SearchBox limiting the value to 20 characters"
        if valid then field.validationState.none else field.validationState.warning
        field.validationMessage (if valid then "" else "Input is limited to 20 characters.")
        field.children (
            Fui.searchBox [
                searchBox.value value
                searchBox.contentBefore (
                    Fui.icon.searchInfoFilled [
                        icon.onClick (fun _ -> printfn "Search clicked")
                    ]
                )
                searchBox.onChange (fun (v: ValueProp<string>) ->
                    if v.value.Length <= 20 then
                        setValue v.value
                        setValid true
                    else
                        setValid false
                )
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
        tagGroup.onDismiss (fun data ->
            setVisibleTags (visibleTags |> List.filter (fun t -> t.value <> data.dismissedTagValue))
        )
        tagGroup.ariaLabel "Dismiss example"
        tagGroup.children [
            yield! visibleTags |> List.map (fun t ->
                Fui.tag [
                    tag.dismissible true
                    tag.dismissIcon [
                        prop.ariaLabel "Remove"
                    ]
                    tag.value t.value
                    tag.key t.value
                    tag.text t.children
                ]
            )
        ]
    ]

[<ReactComponent>]
let InteractionTagTest() =
    let liked, setLiked = React.useState false
    Fui.interactionTag [
        Fui.popover [
            Fui.popoverTrigger [
                popoverTrigger.children (
                    Fui.interactionTagPrimary [
                        interactionTagPrimary.hasSecondaryAction true
                        interactionTagPrimary.id "golden-retreiver-primary"
                        interactionTagPrimary.children [
                            Fui.text "Golden Retriever"
                        ]
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
                    Html.li "Coat: Luxurious double coat with a dense, water-repellent outer layer and a soft, dense undercoat."
                    Html.li "Color: Typically a luscious golden or cream color, with variations in shade."
                    Html.li "Build: Sturdy and well-proportioned body with a friendly and intelligent expression."
                ]
            ]
        ]
        Fui.tooltip [
            tooltip.content (if liked then "unlike" else "like")
            tooltip.relationship.label
            tooltip.children (
                Fui.interactionTagSecondary [
                    interactionTagSecondary.onClick (fun _ -> setLiked (liked |> not))
                    interactionTagSecondary.ariaLabelledBy "golden-retriever-primary golden-retriever-secondary"
                    interactionTagSecondary.id "golden-retriever-secondary"
                    interactionTagSecondary.children [
                        if liked then Fui.icon.heartFilled [] else Fui.icon.heartRegular []
                    ]
                ]
            )
        ]
    ]

let mainContent model dispatch =

    let newTokens = { Theme.tokens with colorBrandStroke1 = "#cbe82e" }

    Fui.stack [
        stack.horizontal false
        stack.tokens [ stack.tokens.childrenGap 16; stack.tokens.padding 32 ]
        stack.horizontalAlign.center
        stack.children [
            Html.div [
                prop.style [ style.height 200; style.width 200; style.backgroundColor newTokens.colorBrandStroke1]
                prop.children [
                    Fui.text [
                        text.text "Typography Styles"
                        text.style [
                            style.fontFamily Fui.typographyStyles.title2.fontFamily
                            style.color newTokens.colorBrandBackgroundHover
                            style.fontWeight Fui.typographyStyles.body1Strong.fontWeight
                        ]
                    ]
                ]
            ]
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
            TooltipTest()
            linkTest
            divider
            textTest
            UseArrowNavigationGroup()
            labelTest
            IconTest()
            inputTest
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
            DataGridTest ()
            SimpleTableTest()
            UseFocusFindersTest()
            UseModalAttributesOptionsTest()
            fieldPropsTest
            BreadcrumbTest()
            SearchBoxTest()
            TagTest()
            InteractionTagTest()
        ]
    ]


let view model dispatch =
    mainContent model dispatch
