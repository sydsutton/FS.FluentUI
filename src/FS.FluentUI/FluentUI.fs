namespace FS.FluentUI

open Fable.React
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open FS.FluentUI
open System


[<AutoOpen; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module FuiHelpers =

    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement = reactElement el (!!props |> createObj)

    let [<Literal>] FluentUIv9 = "@fluentui/react-components"
    let [<Literal>] FluentIcons = "@fluentui/react-icons"
    let [<Literal>] FluentUIMigration = "@fluentui/react-migration-v8-v9"
    let [<Literal>] DatePickerCompat = "@fluentui/react-datepicker-compat"

    let [<Literal>] InfoButton_unstable = "@fluentui/react-infobutton"
    let [<Literal>] Alert_unstable = "@fluentui/react-alert"
    let [<Literal>] Virtualizer_unstable = "@fluentui/react-virtualizer"
    let [<Literal>] Drawer_unstable = "@fluentui/react-drawer"

type [<Erase>] Fui =

//---------------------------------------------------------------- Functions --------------------------------------------------------------------------------

    static member inline mergeStyles (displayName:string, styles:IStyleAttribute list) =
        let mergeStyles : ResizeArray<IStyle> -> string = import "mergeStyles" "@fluentui/merge-styles"

        !!styles
        |> List.append [ "displayName" ==> displayName ]
        |> createObj
        |> unbox<ResizeArray<IStyle>>
        |> mergeStyles

    static member inline mergeStyles (styles:IStyleAttribute list) =
        let mergeStyles : ResizeArray<IStyle> -> string = import "mergeStyles" "@fluentui/merge-styles"

        !!styles
        |> createObj
        |> unbox<ResizeArray<IStyle>>
        |> mergeStyles

    static member inline mkMergeStyles (styles:list<IStyleAttribute>, ?displayName:string) =
        let mergeStyles : ResizeArray<IStyle> -> string = import "mergeStyles" "@fluentui/merge-styles"

        match displayName, styles with
        | None, s -> s
        | Some d, s -> s |> List.append [ !!("displayName", d) ]
        |> unbox<seq<string*obj>>
        |> createObj
        |> unbox<ResizeArray<IStyle>>
        |> mergeStyles

    /// A hook that returns the necessary tabster attributes to support arrow key navigation
    /// @param options - Options to configure keyboard navigation
    [<Hook>]
    static member inline useArrowNavigationGroup (options: IUseArrowNavigationGroupOptionsProp list): IReactProperty =
        let useArrowNavigationGroup = import "useArrowNavigationGroup" FluentUIv9
        let dataTabster : DataTabster = !!options |> createObj |> useArrowNavigationGroup
        prop.custom ("data-tabster", dataTabster.``data-tabster``)

    /// A hook that returns the necessary tabster attributes to support groupping.
    /// @param options - Options to configure keyboard navigation
    [<Hook>]
    static member inline useFocusableGroup (options: IUseFocusableGroupOptionsProp list): IReactProperty =
        let useFocusableGroup = import "useFocusableGroup" FluentUIv9
        let dataTabster : DataTabster = !!options |> createObj |> useFocusableGroup
        prop.custom ("data-tabster", dataTabster.``data-tabster``)

    /// Returns a set of helper functions that will traverse focusable elements in the context of a root DOM element
    [<Hook>]
    static member inline useFocusFinders (): FocusFinders = import "useFocusFinders" FluentUIv9

    /// Hook to generate a unique ID.
    /// @param prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// @param providedId - Optional id provided by a parent component. Defaults to the provided value if present,
    ///  without conditioning the hook call
    /// @returns The ID
    [<Hook>]
    static member inline useId (prefix: string option, providedId: string option): string = import "useId" FluentUIv9

    //TODO Fable is transpiling the tuple passed to toastController.dispatchToast into a JS array, which is not what the function expects.
    //TODO I have a feeling I need to pass the tuple to dispatchToast using partial application so that it doesn't have the chance to turn it into an array,
    //TODO but I'm not sure how to do that.
    [<Hook>]
    static member inline useToastController (?toasterId: string): ToastController = import "useToastController" FluentUIv9

    static member inline partitionAvatarGroupItems (options: IPartitionAvatarGroupItemsOptionsProp list): PartitionAvatarGroupItems<'T> =
        let partitionAvatarGroupItems = import "partitionAvatarGroupItems" FluentUIv9
        !!options |> createObj |> partitionAvatarGroupItems

    static member inline makeResetStyles (styles: IStyleAttribute list): unit -> string =
        let makeResetStyles : ResizeArray<IStyle> -> unit -> string = import "makeResetStyles" FluentUIv9

        !!styles
        |> createObj
        |> unbox<ResizeArray<IStyle>>
        |> makeResetStyles

    [<Hook>]
    static member inline useOverflowMenu (?id: string option): OverflowMenuOptions = import "useOverflowMenu" FluentUIv9

    /// Number of items that are overflowing
    [<Hook>]
    static member inline useOverflowCount (): int = import "useOverflowCount" FluentUIv9

    /// Param id - unique identifier for the item used by the overflow manager
    /// Teturns visibility state of an overflow item
    [<Hook>]
    static member inline useIsOverflowItemVisible (id: string): bool = import "useIsOverflowItemVisible" FluentUIv9

    /// Param id - unique identifier for a group of overflow items
    /// Returns visibility state of the group
    [<Hook>]
    static member inline useIsOverflowGroupVisible (id: string): OverflowGroupState = import "useIsOverflowGroupVisible" FluentUIv9
    static member inline createFluentIcon (displayName: string, width: string, paths: string array): ReactElement = import "createFluentIcon" FluentIcons //TODO Test
    [<Hook>]
    static member inline bundleIcon (filledIcon: ReactElement, regularIcon: ReactElement): IIconProp list -> ReactElement = import "bundleIcon" FluentIcons //TODO

    /// Helper function to create column definition with defaults
    /// options - column definition options
    /// Returns - column definition with defaults
    [<Hook>]
    static member inline createTableColumn (options: ICreateTableColumnOptionProp list): TableColumnDefinition<'T, 'TKeyType> =
        let createTableColumn = import "createTableColumn" FluentUIv9
        !!options |> createObj |> createTableColumn

    /// React hook that measures virtualized space based on a static size to ensure optimized virtualization length.
    [<Hook>]
    static member inline useStaticVirtualizerMeasure (virtualizerProps: IVirtualizerMeasurePropsProp list): VirtualizerMeasure =
        let useStaticVirtualizerMeasure = import "useStaticVirtualizerMeasure" Virtualizer_unstable
        !!virtualizerProps |> createObj |> useStaticVirtualizerMeasure

    /// React hook that measures virtualized space based on a static size to ensure optimized virtualization length.
    /// This hook is a helper to create modal dialog like experiences. The hook creates accessible focus traps that set aria-hidden. The focus trap can only be activated with explicit HTMLElement.focus() call in javscript code.
    /// The hook returns two sets of attributes to spread to elements. This represents the two concepts of a modal dialog
    /// trigger - button that opens a dialog
    /// modal - the modal dialog surface itself
    /// The hook will also handle reverting focus back to the trigger once the modal dialog is unmounted from DOM.
    /// ⚠️ Do not use this hook without appropriate guidance from your accessibility champ. Focus trap is only one of many requirements to consider when creating a modal dialog. Consider the Dialog and Popover components if you need modal dialog like components.
    [<Hook>]
    static member inline useModalAttributes (options: IUseModalAttributesOptionsProp list): ModalAttributes =
        let useModalAttributes = import "useModalAttributes" FluentUIv9
        let attributes = !!options |> createObj |> useModalAttributes

        {
            modalAttributes = prop.custom("data-tabster", attributes.modalAttributes.``data-tabster``)
            triggerAttributes = prop.custom("data-tabster", attributes.triggerAttributes.``data-tabster``)
        }

    /// The useObservedElement hook assigns a name to an element and should be used alongside useFocusObserved that will actually return the imperative method to focus the element.
    [<Hook>]
    static member inline useObservedElement (name: string): IReactProperty =
        let useObservedElement = import "useObservedElement" FluentUIv9
        let dataTabster : DataTabster = name |> useObservedElement
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// The useObservedElement hook assigns a name to an element and should be used alongside useFocusObserved that will actually return the imperative method to focus the element.
    [<Hook>]
    static member inline useObservedElement (name: string array): IReactProperty =
        let useObservedElement = import "useObservedElement" FluentUIv9
        let dataTabster : DataTabster = name |> useObservedElement
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// this hook provides FlatTree API to manage all required mechanisms to convert a list of items into renderable TreeItems
    /// in multiple scenarios including virtualization.
    /// !!A flat tree is an unofficial spec for tree!!
    /// It should be used on cases where more complex interactions with a Tree is required.
    /// On simple scenarios it is advised to simply use a nested structure instead.
    /// @param props - a list of tree items
    /// @param options - in case control over the internal openItems is required
    [<Hook>]
    static member inline useHeadlessFlatTree (props, ?options): HeadlessFlatTree<'T, 'TEvent> = import "useHeadlessFlatTree_unstable" FluentUIv9

    static member inline useHeadlessFlatTree_unstable (props: IHeadlessTreeItemProp list list, options: IHeadlessFlatTreeOptionsProp list) =
        let props =
            props
            |> List.map (fun p -> !!p |> createObj)
            |> List.toArray

        let options = !!options |> createObj

        Fui.useHeadlessFlatTree(props, options) //Created this helper function because Fable will transpile tuples into JS arrays otherwise
//---------------------------------------------------------------- Components --------------------------------------------------------------------------------
    /// The FluentProvider transforms a passed theme to CSS variables and passes other settings to Fluent UI components.
    static member inline fluentProvider (props: IFluentProviderProp list) = createElement (import "FluentProvider" FluentUIv9) props
    /// An Avatar is a graphical representation of a user, team, or entity.
    /// Avatar can display an image, icon, or initials, and supports various sizes and shapes.
    static member inline avatar (props: IAvatarProp list) = createElement (import "Avatar" FluentUIv9) props
    /// A button triggers an action or event when activated.
    static member inline button (props: IButtonProp list) = createElement (import "Button" FluentUIv9) props
    /// A toggle button is a button that can be checked on and off.
    static member inline toggleButton (props: IToggleButtonProp list) = createElement (import "ToggleButton" FluentUIv9) props
    /// An accordion allows users to toggle the display of content by expanding or collapsing sections.
    static member inline accordion (props: IAccordionProp list) = createElement (import "Accordion" FluentUIv9) props
    static member inline accordionHeader (props: IAccordionHeaderProp list) = createElement (import "AccordionHeader" FluentUIv9) props
    static member inline accordionHeader (text: string) = createElement (import "AccordionHeader" FluentUIv9) [prop.text text]
    static member inline accordionItem (props: IAccordionItemProp list) = createElement (import "AccordionItem" FluentUIv9) props
    static member inline accordionPanel (props: ReactElement list) = Interop.reactElementWithChildren (import "AccordionPanel" FluentUIv9) props
    static member inline accordionPanel (props: IAccordionPanelProp list) = createElement (import "AccordionPanel" FluentUIv9) props
    /// Checkboxes give people a way to select one or more items from a group, or switch between two mutually exclusive options (checked or unchecked).
    static member inline checkbox (props: ICheckboxProp list) = createElement (import "Checkbox" FluentUIv9) props
    /// An image displays graphical content such as a photo or illustration.
    static member inline image (props: IImageProp list) = createElement (import "Image" FluentUIv9) props
    /// A badge is a visual decoration for UI elements.
    /// Badge displays text and/or an icon
    static member inline badge (props: IBadgeProp list) = createElement (import "Badge" FluentUIv9) props
    /// A badge is a visual decoration for UI elements.
    /// CounterBadge displays numerical values
    static member inline counterBadge (props: ICounterBadgeProp list) = createElement (import "CounterBadge" FluentUIv9) props
    /// A badge is a visual decoration for UI elements.
    /// PresenceBadge displays status
    static member inline presenceBadge (props: IPresenceBadgeProp list) = createElement (import "PresenceBadge" FluentUIv9) props
    /// Links allow users to navigate between different locations. They can be used as standalone controls or inline with text.
    static member inline link (props: ILinkProp list) = createElement (import "Link" FluentUIv9) props
    /// A divider visually separates two pieces of content.
    static member inline divider (props: IDividerProp list) = createElement (import "Divider" FluentUIv9) props
    /// Typography and styling abstraction component used to ensure consistency and standardize text throughout your application.
    static member inline text (text:string) = createElement (import "Text" FluentUIv9) [ prop.text text ]
    /// Typography and styling abstraction component used to ensure consistency and standardize text throughout your application.
    static member inline text (props: ITextProp list) = createElement (import "Text" FluentUIv9) props
    /// A label provides a name or title for an input.
    static member inline label (props: ILabelProp list) = createElement (import "Label" FluentUIv9) props
    /// A popover displays content on top of other content.
    /// WARNING: Popover can contain no more than two children including PopoverTrigger and PopoverSurface.
    /// If you try to use more than two children, only the first two you pass to this function will be used.
    /// Alternatively can only contain PopoverSurface if using a custom target.
    static member inline popover (props: ReactElement list) =
        let propsToUse =
            match props |> List.length with
            | l when l <= 2 -> props
            | _ -> props |> List.take 2
        Interop.reactElementWithChildren (import "Popover" FluentUIv9) propsToUse
    /// A popover displays content on top of other content.
    static member inline popover (props: IPopoverProp list) = createElement (import "Popover" FluentUIv9) props
    static member inline popoverTrigger (props: IPopoverTriggerProp list) = createElement (import "PopoverTrigger" FluentUIv9) props
    static member inline popoverSurface (props: ReactElement list) = Interop.reactElementWithChildren (import "PopoverSurface" FluentUIv9) props
    static member inline popoverSurface (props: IPopoverSurfaceProp list) = createElement (import "PopoverSurface" FluentUIv9) props
    static member inline popoverProvider (props: IPopoverProviderProp list) = createElement (import "PopoverProvider" FluentUIv9) props
    /// A tooltip displays additional information about another component. The information is displayed above and near the target component.
    /// Tooltip is not expected to handle interactive content. If this is necessary behavior, an expand/collapse button + popover should be used instead.
    /// Hover or focus the buttons in the examples to see their tooltips.
    static member inline tooltip (props: ITooltipProp list) = createElement (import "Tooltip" FluentUIv9) props
    /// Input allows the user to enter and edit text.
    static member inline input (props: IInputProp list) = createElement (import "Input" FluentUIv9) props
    /// A compound button is a button with an additional slot for secondary textual content.
    /// Since both primary and secondary textual contents are part of a compound button's name they should be kept concise.
    static member inline compoundButton (props: ICompoundButtonProp list) = createElement (import "CompoundButton" FluentUIv9) props
    /// A split button is a button with a primary action and a secondary action primarily used for opening a menu.
    static member inline splitButton (props: ISplitButtonProp list) = createElement (import "SplitButton" FluentUIv9) props
    /// Textarea allows the user to enter and edit multiline text.
    static member inline textArea (props: ITextAreaProp list) = createElement (import "Textarea" FluentUIv9) props
    /// A Slider represents an input that allows user to choose a value from within a specific range.
    static member inline slider (props: ISliderProp list) = createElement (import "Slider" FluentUIv9) props
    /// A switch represents a physical switch that allows someone to choose between two mutually exclusive options. For example, "On/Off" and "Show/Hide". Choosing an option should produce an immediate result.
    static member inline switch (props: ISwitchProp list) = createElement (import "Switch" FluentUIv9) props
    /// Radio is a single item in a RadioGroup. It is strongly recommended to use them inside a RadioGroup or RadioGroupField. However, they can also be used on their own: any Radio items with the same name will be treated as part of the same group.
    static member inline radio (props: IRadioProp list) = createElement (import "Radio" FluentUIv9) props
    /// RadioGroup lets people select a single option from two or more Radio items. Use RadioGroup to present all available choices if there's enough space. For more than 5 choices, consider using a different component such as Dropdown.
    static member inline radioGroup (props: IRadioGroupProp list) = createElement (import "RadioGroup" FluentUIv9) props
    /// A portal renders content outside of a DOM tree, at the end of the document.
    /// This allows content to escape traditional boundaries caused by "overflow: hidden" CSS rules and keeps it on the top without using z-index rules. This is useful for example in Menu and Tooltip scenarios, where the content should always overlay everything else.
    static member inline portal (props: IPortalProp list) = createElement (import "Portal" FluentUIv9) props
    /// A tab list provides single selection from tabs. When a tab is selected, the application displays content associated with the selected tab and hides other content.
    /// Each tab typically contains a text header and often includes an icon.
    static member inline tabList (props: ITabListProp list) = createElement (import "TabList" FluentUIv9) props
    static member inline tab (props: ITabProp list) = createElement (import "Tab" FluentUIv9) props
    /// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
    static member inline spinner (props: ISpinnerProp list) = createElement (import "Spinner" FluentUIv9) props
    /// SpinButtons are used to allow numerical and non-numerical input bounded between minimum and maximum values with buttons to increment and decrement the input value. Values can also be manipulated via the keyboard.
    static member inline spinButton (props: ISpinButtonProp list) = createElement (import "SpinButton" FluentUIv9) props
    /// A Select allows one option to be selected from multiple options. The Select component is a wrapper around the native <select> element.
    static member inline select (props: ISelectProp list) = createElement (import "Select" FluentUIv9) props
    /// A Dropdown is a selection component composed of a button and a list of options. The button displays the current selected item or a placeholder, and the list is visible on demand by clicking the button. Dropdowns are typically used in forms.
    static member inline dropdown (props: IDropdownProp list) = createElement (import "Dropdown" FluentUIv9) props
    static member inline option (props: IOptionProp list) = createElement (import "Option" FluentUIv9) props
    static member inline listbox (props: IListboxProp list) = createElement (import "Listbox" FluentUIv9) props
    /// A Persona is a visual representation of a person or status that showcases an Avatar, PresenceBadge, or an Avatar with a PresenceBadge.
    static member inline persona (props: IPersonaProp list) = createElement (import "Persona" FluentUIv9) props
    /// A combobox (Combobox) combines a text field and a dropdown giving people a way to select an option from a list or enter their own choice.
    static member inline combobox (props: IComboboxProp list) = createElement (import "Combobox" FluentUIv9) props
    /// A Progress provides a visual representation of content being loaded or processed.
    static member inline progressBar (props: IProgressBarProp list) = createElement (import "ProgressBar" FluentUIv9) props
    /// Field adds a label, validation message, and hint text to a control.
    static member inline field (props: IFieldProp list) = createElement (import "Field" FluentUIv9) props
    static member inline optionGroup (props: IOptionGroupProp list) = createElement (import "OptionGroup" FluentUIv9) props
    /// The Skeleton component is a temporary animation placeholder for when a service call takes time to return data and we don't want to block rendering the rest of the UI.
    static member inline skeleton (props: ReactElement list) = Interop.reactElementWithChildren (import "Skeleton" FluentUIv9) props
    /// The Skeleton component is a temporary animation placeholder for when a service call takes time to return data and we don't want to block rendering the rest of the UI.
    static member inline skeleton (props: ISkeletonProp list) = createElement (import "Skeleton" FluentUIv9) props
    static member inline skeletonItem (props: ISkeletonItemProp list) = createElement (import "SkeletonItem" FluentUIv9) props
    /// The Overflow and OverflowItem components, are low level utilities that enable users to create overflow experiences with any component. The components will detect and hide overflowing elements in DOM and manage the overflow state. Additional overflow hooks can be used to handle overflowing items. In the reference examples below the overflowing items are handled using a Menu.
    /// Additional hooks will be needed to create your specific overflow scenario. Please refer to the reference implementations below, which will use the additional utilities:
    /// useOverflowMenu- returns a ref that registers and overflow menu element.
    /// useIsOverflowItemVisible- returns whether an overflow item is visible.
    /// useOverflowCount- returns the number of overflowing items.
    /// useIsOverflowGroupVisible- return the visibility of an overflow group.
    static member inline overflow (props: IOverflowProp list) = createElement (import "Overflow" FluentUIv9) props
    /// The Overflow and OverflowItem components, are low level utilities that enable users to create overflow experiences with any component. The components will detect and hide overflowing elements in DOM and manage the overflow state. Additional overflow hooks can be used to handle overflowing items. In the reference examples below the overflowing items are handled using a Menu.
    /// Additional hooks will be needed to create your specific overflow scenario. Please refer to the reference implementations below, which will use the additional utilities:
    /// useOverflowMenu- returns a ref that registers and overflow menu element.
    /// useIsOverflowItemVisible- returns whether an overflow item is visible.
    /// useOverflowCount- returns the number of overflowing items.
    /// useIsOverflowGroupVisible- return the visibility of an overflow group.
    static member inline overflowItem (props: IOverflowItemProp list) = createElement (import "OverflowItem" FluentUIv9) props
    static member inline overflowDivider (props: IOverflowDividerProp list) = createElement (import "OverflowDivider" FluentUIv9) props
    /// Picking a date can be tough without context. A date picker (DatePicker) offers a popup control that’s optimized for picking a single date from a calendar view where contextual information like the day of the week or fullness of the calendar is important. You can modify the calendar to provide additional context or to limit available dates.
    /// Note: DatePicker is a compat component - its internal architecture does not follow all the principles regular Fluent UI v9 components follow - it is not composed of atomic hooks and it might be more difficult to tweak its appearance and behavior. It however follows Fluent 2 design and uses design tokens, it is production ready and it is stable.
    static member inline datePicker (props: IDatePickerProp list) = createElement (import "DatePicker" DatePickerCompat) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline infoButton (props: IInfoButtonProp list) = createElement (import "InfoButton" InfoButton_unstable) props
    /// An InfoLabel is a Label with an InfoButton at the end, properly handling layout and accessibility properties. It can be used as a drop-in replacement for Label when an InfoButton is also needed.
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline infoLabel (props: IInfoLabelProp list) = createElement (import "InfoLabel" InfoButton_unstable) props
    /// An Alert displays a brief, important message to attract a user's attention without interrupting their current task.
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline alert (props: IAlertProp list) = createElement (import "Alert" Alert_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline virtualizer (props: IVirtualizerProp list) = createElement (import "Virtualizer" Virtualizer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline virtualizerScrollView (props: IVirtualizerScrollViewProp list) = createElement (import "VirtualizerScrollView" Virtualizer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline virtualizerScrollViewDynamic (props: IVirtualizerScrollViewDynamicProp list) = createElement (import "VirtualizerScrollViewDynamic" Virtualizer_unstable) props
    /// The Drawer gives users a quick entry point to configuration and information. It should be used when retaining context is beneficial to users.
    /// There are three main components to represent a Drawer:
    /// DrawerOverlay: Represents an overlay Drawer. This component renders on top of the whole page. By default blocks the screen and will require users full attention. Uses Dialog component under the hood.
    /// DrawerInline: Represents an inline Drawer. This is rendered within a container and can be placed next to any content.
    /// Drawer: It is a combination of DrawerOverlay and DrawerInline. Used when toggling between the two modes is necessary. Often used for responsiveness.
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawer (props: IDrawerProp list) = createElement (import "Drawer" Drawer_unstable) props
    /// Represents an overlay Drawer. This component renders on top of the whole page. By default blocks the screen and will require users full attention. Uses Dialog component under the hood.
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerOverlay (props: IDrawerOverlayProp list) = createElement (import "DrawerOverlay" Drawer_unstable) props
    /// Represents an inline Drawer. This is rendered within a container and can be placed next to any content.
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerInline (props: IDrawerInlineProp list) = createElement (import "DrawerInline" Drawer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerHeader (props: IDrawerHeaderProp list) = createElement (import "DrawerHeader" Drawer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DrawerHeader" Drawer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerHeaderTitle (props: IDrawerHeaderTitleProp list) = createElement (import "DrawerHeaderTitle" Drawer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerHeaderNavigation (props: IDrawerHeaderNavigationProp list) = createElement (import "DrawerHeaderNavigation" Drawer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DrawerBody" Drawer_unstable) props
    /// WARNING: This component is considered unstable by Microsoft. Features and APIs may change before final release.
    static member inline drawerBody (props: IDrawerBodyProp list) = createElement (import "DrawerBody" Drawer_unstable) props
    // Card
    /// A card is a container that holds information and actions related to a single concept or object, like a document or a contact.
    /// Cards can give information prominence and create predictable patterns. While they're very flexible, it's important to use them consistently for particular use cases across experiences.
    static member inline card (props: ReactElement list) = Interop.reactElementWithChildren (import "Card" FluentUIv9) props
    /// A card is a container that holds information and actions related to a single concept or object, like a document or a contact.
    /// Cards can give information prominence and create predictable patterns. While they're very flexible, it's important to use them consistently for particular use cases across experiences.
    static member inline card (props: ICardProp list) = createElement (import "Card" FluentUIv9) props
    /// The CardFooter component, used inside of a Card, uses a flex layout to organize actions the user can take with a Card, like sharing the contents or replying to a message.
    static member inline cardFooter (props: ReactElement list) = Interop.reactElementWithChildren (import "CardFooter" FluentUIv9) props
    /// The CardFooter component, used inside of a Card, uses a flex layout to organize actions the user can take with a Card, like sharing the contents or replying to a message.
    static member inline cardFooter (props: ICardFooterProp list) = createElement (import "CardFooter" FluentUIv9) props
    /// The CardHeader component, used inside of a Card, represents a Fluent UI compliant card header.
    static member inline cardHeader (props: ICardHeaderProp list) = createElement (import "CardHeader" FluentUIv9) props
    /// The CardPreview component, used inside of a Card, allows the user to better visualize what the card's contents are.
    static member inline cardPreview (props: ReactElement list) = Interop.reactElementWithChildren (import "CardPreview" FluentUIv9) props
    /// The CardPreview component, used inside of a Card, allows the user to better visualize what the card's contents are.
    static member inline cardPreview (props: ICardPreviewProp list) = createElement (import "CardPreview" FluentUIv9) props
    // Toast
    /// A Toasts displays temporary content to the user. Toasts are rendered as a separate surface that can be dismissed by user action or a application timeout. Toasts are typically used in the following situations:
    /// Update the user on the status of a task
    /// Display the progress of a task
    /// Notify the user to take an action
    /// Notify the user of an application update
    /// Warn the user of an error
    /// The Fluent UI Toast component uses an imperative API. Once a Toaster has been rendered, you can use the useToastController hook to get access to imperative methods to dispatch a Toast. The Toast component itself is simply a layout component.
    static member inline toast (props: ReactElement list) = Interop.reactElementWithChildren (import "Toast" FluentUIv9) props
    /// A Toasts displays temporary content to the user. Toasts are rendered as a separate surface that can be dismissed by user action or a application timeout. Toasts are typically used in the following situations:
    /// Update the user on the status of a task
    /// Display the progress of a task
    /// Notify the user to take an action
    /// Notify the user of an application update
    /// Warn the user of an error
    /// The Fluent UI Toast component uses an imperative API. Once a Toaster has been rendered, you can use the useToastController hook to get access to imperative methods to dispatch a Toast. The Toast component itself is simply a layout component.
    static member inline toast (props: IToastProp list) = createElement (import "Toast" FluentUIv9) props
    static member inline toastTitle (props: IToastTitleProp list) = createElement (import "ToastTitle" FluentUIv9) props
    static member inline toastBody (props: IToastBodyProp list) = createElement (import "ToastBody" FluentUIv9) props
    static member inline toastFooter (props: ReactElement list) = Interop.reactElementWithChildren (import "ToastFooter" FluentUIv9) props
    static member inline toastFooter (props: IToastFooterProp list) = createElement (import "ToastFooter" FluentUIv9) props
    static member inline toaster (props: IToasterProp list) = createElement (import "Toaster" FluentUIv9) props
    // Dialog
    /// Dialog is a window overlaid on either the primary window or another dialog window. Windows under a modal dialog are inert. That is, users cannot interact with content outside an active dialog window. Inert content outside an active dialog is typically visually obscured or dimmed so it is difficult to discern, and in some implementations, attempts to interact with the inert content cause the dialog to close.
    static member inline dialog (props: IDialogProp list) = createElement (import "Dialog" FluentUIv9) props
    static member inline dialogTrigger (props: IDialogTriggerProp list) = createElement (import "DialogTrigger" FluentUIv9) props
    static member inline dialogSurface (props: ReactElement list) = Interop.reactElementWithChildren (import "DialogSurface" FluentUIv9) props
    static member inline dialogSurface (props: IDialogSurfaceProp list) = createElement (import "DialogSurface" FluentUIv9) props
    static member inline dialogTitle (props: IDialogTitleProp list) = createElement (import "DialogTitle" FluentUIv9) props
    static member inline dialogActions (props: IDialogActionsProp list) = createElement (import "DialogActions" FluentUIv9) props
    static member inline dialogBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DialogBody" FluentUIv9) props
    static member inline dialogBody (props: IDialogBodyProp list) = createElement (import "DialogBody" FluentUIv9) props
    static member inline dialogContent (props: IDialogContentProp list) = createElement (import "DialogContent" FluentUIv9) props
    // AvatarGroup
    /// An AvatarGroup is a graphical representation of multiple people associated with a given entity. AvatarGroup leverages the Avatar component, with each Avatar representing a person and containing their image, initials, or an icon. An AvatarGroup can be represented in a spread, stack, or pie layout.
    static member inline avatarGroup (props: IAvatarGroupProp list) = createElement (import "AvatarGroup" FluentUIv9) props
    static member inline avatarGroupItem (props: IAvatarGroupItemProp list) = createElement (import "AvatarGroupItem" FluentUIv9) props
    static member inline avatarGroupPopover (props: ReactElement list) = Interop.reactElementWithChildren (import "AvatarGroupPopover" FluentUIv9) props
    static member inline avatarGroupPopover (props: IAvatarGroupPopoverProp list) = createElement (import "AvatarGroupPopover" FluentUIv9) props

    // Toolbar
    /// A toolbar is a container for grouping a set of controls, such as buttons, menu buttons, or checkboxes.
    static member inline toolbar (props: IToolbarProp list) = createElement (import "Toolbar" FluentUIv9) props
    static member inline toolbarButton (props: IToolbarButtonProp list) = createElement (import "ToolbarButton" FluentUIv9) props
    static member inline toolbarDivider (props: IToolbarDividerProp list) = createElement (import "ToolbarDivider" FluentUIv9) props
    static member inline toolbarGroup (props: ReactElement list) = Interop.reactElementWithChildren  (import "ToolbarGroup" FluentUIv9) props
    static member inline toolbarGroup (props: IToolbarGroupProp list) = createElement (import "ToolbarGroup" FluentUIv9) props
    static member inline toolbarRadioButton (props: IToolbarRadioButtonProp list) = createElement (import "ToolbarRadioButton" FluentUIv9) props
    static member inline toolbarRadioGroup (props: ReactElement list) = Interop.reactElementWithChildren  (import "ToolbarRadioGroup" FluentUIv9) props
    static member inline toolbarRadioGroup (props: IToolbarRadioGroupProp list) = createElement (import "ToolbarRadioGroup" FluentUIv9) props
    static member inline toolbarToggleButton (props: IToolbarToggleButtonProp list) = createElement (import "ToolbarToggleButton" FluentUIv9) props
    /// A menu button is a button with a chevron icon after the text typically used to trigger a menu.
    static member inline menuButton (props: IMenuButtonProp list) = createElement (import "MenuButton" FluentUIv9) props
    /// A menu displays a list of actions. The Menu component handles the state management of the passed in list of actions.
    /// WARNING: Menu can contain no more than two children including MenuTrigger and MenuPopover.
    /// If you try to use more than two children, only the first two you pass to this function will be used
    /// Alternatively can only contain MenuPopover if using a custom target.
    static member inline menu (props: ReactElement list) =
        let propsToUse =
            match props |> List.length with
            | l when l <= 2 -> props
            | _ -> props |> List.take 2
        Interop.reactElementWithChildren  (import "Menu" FluentUIv9) propsToUse
    /// A menu displays a list of actions. The Menu component handles the state management of the passed in list of actions.
    static member inline menu (props: IMenuProp list) = createElement (import "Menu" FluentUIv9) props
    /// A menu list displays a list of actions. It is usually rendered inside of the Menu component.
    static member inline menuList (props: ReactElement list) = Interop.reactElementWithChildren  (import "MenuList" FluentUIv9) props
    /// A menu list displays a list of actions. It is usually rendered inside of the Menu component.
    static member inline menuList (props: IMenuListProp list) = createElement (import "MenuList" FluentUIv9) props
    static member inline menuItem (text: string) = createElement (import "MenuItem" FluentUIv9) [ prop.text text ]
    static member inline menuItem (props: IMenuItemProp list) = createElement (import "MenuItem" FluentUIv9) props
    static member inline menuItemCheckbox (props: IMenuItemCheckboxProp list) = createElement (import "MenuItemCheckbox" FluentUIv9) props
    static member inline menuItemRadio (props: IMenuItemRadioProp list) = createElement (import "MenuItemRadio" FluentUIv9) props
    static member inline menuPopover (props: ReactElement list) = Interop.reactElementWithChildren  (import "MenuPopover" FluentUIv9) props
    static member inline menuPopover (props: IMenuPopoverProp list) = createElement (import "MenuPopover" FluentUIv9) props
    static member inline menuTrigger (props: IMenuTriggerProp list) = createElement (import "MenuTrigger" FluentUIv9) props
    static member inline menuSplitGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "MenuSplitGroup" FluentUIv9) props
    static member inline menuSplitGroup (props: IMenuSplitGroupProp list) = createElement (import "MenuSplitGroup" FluentUIv9) props
    static member inline menuGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "MenuGroup" FluentUIv9) props
    static member inline menuGroup (props: IMenuGroupProp list) = createElement (import "MenuGroup" FluentUIv9) props
    static member inline menuDivider (props: IMenuDividerProp list) = createElement (import "MenuDivider" FluentUIv9) props
    static member inline menuItemLink (props: IMenuItemLinkProp list) = createElement (import "MenuItemLink" FluentUIv9) props
    // Table
    /// This component is considered low-level and should be used when there is a need for more customization and support for non-standard features. Please check out the DataGrid component if you don't need lots of customization and rely on common features. There is less work involved and you will benefit from first class Microsoft design and accessibility support.
    /// A Table displays sets of two-dimensional data. The primitive components can be fully customized to support different feature sets. The library provides a default useTableFeatures hook that handles the business logic and state management of common features. There is no obligation to use our hook with these components, we've created it for convenience.
    /// The useTableFeatures hook was designed with feature composition in mind. This means that they are composed using plugins hooks such as useTableSort and useTableSelection as a part of useTableFeatures. This means that as the feature set expands, users will not need to pay the bundle size price for features that they do not intend to use. Please consult the usage examples below for more details.
    static member inline table (props: ReactElement list) = Interop.reactElementWithChildren (import "Table" FluentUIv9) props
    /// This component is considered low-level and should be used when there is a need for more customization and support for non-standard features. Please check out the DataGrid component if you don't need lots of customization and rely on common features. There is less work involved and you will benefit from first class Microsoft design and accessibility support.
    /// A Table displays sets of two-dimensional data. The primitive components can be fully customized to support different feature sets. The library provides a default useTableFeatures hook that handles the business logic and state management of common features. There is no obligation to use our hook with these components, we've created it for convenience.
    /// The useTableFeatures hook was designed with feature composition in mind. This means that they are composed using plugins hooks such as useTableSort and useTableSelection as a part of useTableFeatures. This means that as the feature set expands, users will not need to pay the bundle size price for features that they do not intend to use. Please consult the usage examples below for more details.
    static member inline table (props: ITableProp list) = createElement (import "Table" FluentUIv9) props
    static member inline tableHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "TableHeader" FluentUIv9) props
    static member inline tableHeader (props: ITableHeaderProp list) = createElement (import "TableHeader" FluentUIv9) props
    static member inline tableHeaderCell (props: ReactElement list) = Interop.reactElementWithChildren (import "TableHeaderCell" FluentUIv9) props
    static member inline tableHeaderCell (props: ITableHeaderCellProp list) = createElement (import "TableHeaderCell" FluentUIv9) props
    static member inline tableBody (props: ReactElement list) = Interop.reactElementWithChildren (import "TableBody" FluentUIv9) props
    static member inline tableBody (props: ITableBodyProp list) = createElement (import "TableBody" FluentUIv9) props
    static member inline tableRow (props: ReactElement list) = Interop.reactElementWithChildren (import "TableRow" FluentUIv9) props
    static member inline tableRow (props: ITableRowProp list) = createElement (import "TableRow" FluentUIv9) props
    static member inline tableCell (props: ReactElement list) = Interop.reactElementWithChildren (import "TableCell" FluentUIv9) props
    static member inline tableCell (props: ITableCellProp list) = createElement (import "TableCell" FluentUIv9) props
    static member inline tableSelectionCell (props: ITableSelectionCellProp list) = createElement (import "TableSelectionCell" FluentUIv9) props
    static member inline tableCellLayout (props: ReactElement list) = Interop.reactElementWithChildren (import "TableCellLayout" FluentUIv9) props
    static member inline tableCellLayout (props: ITableCellLayoutProp list) = createElement (import "TableCellLayout" FluentUIv9) props
    static member inline tableCellActions (props: ReactElement list) = Interop.reactElementWithChildren (import "TableCellActions" FluentUIv9) props
    static member inline tableResizeHandle (props: ITableResizeHandleProp list) = createElement (import "TableResizeHandle" FluentUIv9) props

    // DataGrid
    /// This component is a higher level extension of the Table primitive components and the useTableFeatures hook. DataGrid is a feature-rich component that uses useTableFeatures internally, so there should always be full feature parity with what can be achieved with primitives. This component is opinionated and this is intentional. If the desired scenario can be achieved easily and does not vary too much from documented examples, it can be very convenient. If the desired scenario varies a lot from the documented examples please use the Table components with useTableFeatures (or another state management solution of choice).
    /// Feature requests will be accepted, but the team will prioritize overall API scalability and extensibility over uncommon features and scenarios.
    static member inline dataGrid (props: IDataGridProp list) = createElement (import "DataGrid" FluentUIv9) props
    static member inline dataGridHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeader" FluentUIv9) props
    static member inline dataGridHeader (props: IDataGridHeaderProp list) = createElement (import "DataGridHeader" FluentUIv9) props
    static member inline dataGridHeaderCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeaderCell" FluentUIv9) props
    static member inline dataGridHeaderCell (props: IDataGridHeaderCellProp list) = createElement (import "DataGridHeaderCell" FluentUIv9) props
    static member inline dataGridRow (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridRow" FluentUIv9) props
    static member inline dataGridRow (props: IDataGridRowProp list) = createElement (import "DataGridRow" FluentUIv9) props
    static member inline dataGridBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridBody" FluentUIv9) props
    static member inline dataGridBody (props: IDataGridBodyProp list) = createElement (import "DataGridBody" FluentUIv9) props
    static member inline dataGridCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridCell" FluentUIv9) props
    static member inline dataGridCell (props: IDataGridCellProp list) = createElement (import "DataGridCell" FluentUIv9) props
    static member inline dataGridSelectionCell (props: IDataGridSelectionCellProp list) = createElement (import "DataGridSelectionCell" FluentUIv9) props

    // Tree
    /// A hierarchical list structure component for displaying data in a collapsible and expandable way
    /// Use this component when you need to present your users with a clear visual structure of content or data, allowing them to efficiently interact and navigate through the information. If the information is less hierarchical or node-based, consider using a list or table instead.
    static member inline tree (props: ReactElement list) = Interop.reactElementWithChildren (import "Tree" FluentUIv9) props
    /// A hierarchical list structure component for displaying data in a collapsible and expandable way
    /// Use this component when you need to present your users with a clear visual structure of content or data, allowing them to efficiently interact and navigate through the information. If the information is less hierarchical or node-based, consider using a list or table instead.
    static member inline tree (props: ITreeProp list) = createElement (import "Tree" FluentUIv9) props
    static member inline flatTree (props: IFlatTreeProp list) = createElement (import "FlatTree" FluentUIv9) props
    static member inline treeItem (props: ITreeItemProp list) = createElement (import "TreeItem" FluentUIv9) props
    static member inline treeItemLayout (props: ReactElement list) = Interop.reactElementWithChildren (import "TreeItemLayout" FluentUIv9) props
    static member inline treeItemLayout (props: ITreeItemLayoutProp list) = createElement (import "TreeItemLayout" FluentUIv9) props
    static member inline treeItemPersonaLayout (props: ITreeItemPersonaLayoutProp list) = createElement (import "TreeItemPersonaLayout" FluentUIv9) props

    // Stack
    static member inline stack (props: IStackProp list) = createElement (import "StackShim" FluentUIMigration) props
    static member inline stackItem (props: IStackItemProp list) = createElement (import "StackItemShim" FluentUIMigration) props

    static member inline typographyStyles: TypographyStyles = import "typographyStyles" FluentUIv9

type [<Erase>] Theme =
    static member inline teamsLight = import "TeamsLightTheme" FluentUIv9 |> unbox<ITheme>
    static member inline teamsDark = import "TeamsDarkTheme" FluentUIv9|> unbox<ITheme>
    static member inline teamsHighContrast = import "TeamsHighContrastTheme" FluentUIv9 |> unbox<ITheme>
    static member inline webLight = import "WebLightTheme" FluentUIv9 |> unbox<ITheme>
    static member inline webDark = import "WebDarkTheme" FluentUIv9 |> unbox<ITheme>
    /// Warning: Although overriding tokens with 'let newTokens = { Theme.tokens with colorBrandStroke1 = "#cbe82e" }' is possible,
    /// it's not recommended-- if the existing tokens do not fulfill your needs, you should create a custom theme instead of overriding tokens.
    static member inline tokens: Tokens = import "tokens" FluentUIv9
    /// Programmatically generates a tokens to css variables mapping object from the keys in a theme.
    /// This helps with ease of use as a user of a custom theme does not have to manually construct this object, but it could
    /// affect tree-shaking since bundlers do not know the shape of the output.
    /// @param theme - Theme from which to get the keys to generate the tokens to css variables mapping object
    /// @returns Tokens to css variables mapping object corresponding to the passed theme
    static member inline themeToTokensObject (theme: ITheme): Tokens = import "themeToTokensObject" FluentUIv9
    /// Creates v9 brand colors from a v8 palette using interpolation
    /// A v8 palette has nine colors and v9 has sixteen colors.
    static member inline createBrandVariants (theme: IPalette, interpolation: Interpolation option): BrandVariants = import "createBrandVariants" FluentUIMigration

module Fui =

    type [<Erase>] text =
        static member inline body1 (text: string) = createElement (import "Body1" FluentUIv9) [prop.text text]
        static member inline body1 (props: ITextProp list) = createElement (import "Body1" FluentUIv9) props
        static member inline body1Strong (text: string) = createElement (import "Body1Strong" FluentUIv9) [prop.text text]
        static member inline body1Strong (props: ITextProp list) = createElement (import "Body1Strong" FluentUIv9) props
        static member inline body1Stronger (text: string) = createElement (import "Body1Stronger" FluentUIv9) [prop.text text]
        static member inline body1Stronger (props: ITextProp list) = createElement (import "Body1Stronger" FluentUIv9) props
        static member inline body2 (text: string) = createElement (import "Body2" FluentUIv9) [prop.text text]
        static member inline body2 (props: ITextProp list) = createElement (import "Body2" FluentUIv9) props
        static member inline caption1 (text: string) = createElement (import "Caption1" FluentUIv9) [prop.text text]
        static member inline caption1 (props: ITextProp list) = createElement (import "Caption1" FluentUIv9) props
        static member inline caption1Strong (text: string) = createElement (import "Caption1Strong" FluentUIv9) [prop.text text]
        static member inline caption1Strong (props: ITextProp list) = createElement (import "Caption1Strong" FluentUIv9) props
        static member inline caption1Stronger (text: string) = createElement (import "Caption1Stronger" FluentUIv9) [prop.text text]
        static member inline caption1Stronger (props: ITextProp list) = createElement (import "Caption1Stronger" FluentUIv9) props
        static member inline caption2 (text: string) = createElement (import "Caption2" FluentUIv9) [prop.text text]
        static member inline caption2 (props: ITextProp list) = createElement (import "Caption2" FluentUIv9) props
        static member inline caption2Strong (text: string) = createElement (import "Caption2Strong" FluentUIv9) [prop.text text]
        static member inline caption2Strong (props: ITextProp list) = createElement (import "Caption2Strong" FluentUIv9) props
        static member inline display (text: string) = createElement (import "Display" FluentUIv9) [prop.text text]
        static member inline display (props: ITextProp list) = createElement (import "Display" FluentUIv9) props
        static member inline largeTitle (text: string) = createElement (import "LargeTitle" FluentUIv9) [prop.text text]
        static member inline largeTitle (props: ITextProp list) = createElement (import "LargeTitle" FluentUIv9) props
        static member inline subtitle1 (text: string) = createElement (import "Subtitle1" FluentUIv9) [prop.text text]
        static member inline subtitle1 (props: ITextProp list) = createElement (import "Subtitle1" FluentUIv9) props
        static member inline subtitle2 (text: string) = createElement (import "Subtitle2" FluentUIv9) [prop.text text]
        static member inline subtitle2 (props: ITextProp list) = createElement (import "Subtitle2" FluentUIv9) props
        static member inline subtitle2Stronger (text: string) = createElement (import "Subtitle2Stronger" FluentUIv9) [prop.text text]
        static member inline subtitle2Stronger (props: ITextProp list) = createElement (import "Subtitle2Stronger" FluentUIv9) props
        static member inline title1 (text: string) = createElement (import "Title1" FluentUIv9) [prop.text text]
        static member inline title1 (props: ITextProp list) = createElement (import "Title1" FluentUIv9) props
        static member inline title2 (text: string) = createElement (import "Title2" FluentUIv9) [prop.text text]
        static member inline title2 (props: ITextProp list) = createElement (import "Title2" FluentUIv9) props
        static member inline title3 (text: string) = createElement (import "Title3" FluentUIv9) [prop.text text]
        static member inline title3 (props: ITextProp list) = createElement (import "Title3" FluentUIv9) props
