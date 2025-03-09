namespace FS.FluentUI

open Fable.React
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open FS.FluentUI
open System

[<AutoOpen>]
module FelizOverloads =
    type prop with

        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// SVG attribute to define the size of the font from baseline to baseline when multiple
        /// lines of text are set solid in a multiline layout environment.
        static member inline fontSize (value: string) = Interop.mkAttr "fontSize" value
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// SVG attribute to define the width of the stroke to be applied to the shape.
        /// This is an overload that accepts Theme.tokens string variables in FS.FluentUI
        static member inline strokeWidth (value: string) = Interop.mkAttr "strokeWidth" value

    type style with
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The zIndex property sets or returns the stack order of a positioned element.
        ///
        /// An element with greater stack order (1) is always in front of another element with lower stack order (0).
        ///
        /// **Tip**: A positioned element is an element with the position property set to: relative, absolute, or fixed.
        ///
        /// **Tip**: This property is useful if you want to create overlapping elements.
        static member inline zIndex (value: string) = Interop.mkStyle "zIndex" value
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Sets the length of time a transition animation should take to complete. By default, the
        /// value is 0s, meaning that no animation will occur.
        static member inline transitionDuration (timespan: string) = Interop.mkStyle "transitionDuration" timespan
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Sets the length of time a transition animation should take to complete. By default, the
        /// value is 0s, meaning that no animation will occur.
        static member inline transitionDurationMilliseconds (value: string) = Interop.mkStyle "transitionDuration" value
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Specifies the duration to wait before starting a property's transition effect when its value changes.
        static member inline transitionDelay (timespan: string) = Interop.mkStyle "transitionDelay" timespan
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Specifies the duration to wait before starting a property's transition effect when its value changes.
        static member inline transitionDelayMilliseconds (value: string) = Interop.mkStyle "transitionDelay" value
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: Styles.ITransitionProperty, duration: string) =
            Interop.mkStyle "transition" (
                unbox<string> property + " " +
                duration
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: string, duration: string) =
            Interop.mkStyle "transition" (
                property + " " +
                duration
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: Styles.ITransitionProperty, duration: string, timingFunction: Styles.ITransitionTimingFunction) =
            Interop.mkStyle "transition" (
                unbox<string> property + " " +
                duration + " " +
                unbox<string> timingFunction
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: string, duration: string, timingFunction: Styles.ITransitionTimingFunction) =
            Interop.mkStyle "transition" (
                property + " " +
                duration + " " +
                unbox<string> timingFunction
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: Styles.ITransitionProperty, durationInMs: string, delayInMs: string) =
            Interop.mkStyle "transition" (
                unbox<string> property + " " +
                durationInMs + " " +
                delayInMs
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: string, durationInMs: string, delayInMs: string) =
            Interop.mkStyle "transition" (
                property + " " +
                durationInMs + " " +
                delayInMs
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: Styles.ITransitionProperty, durationInMs: string, timingFunction: Styles.ITransitionTimingFunction, delayInMs: string) =
            Interop.mkStyle "transition" (
                unbox<string> property + " " +
                durationInMs + " " +
                unbox<string> timingFunction,
                delayInMs
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// The transition property is a shorthand property for transition-property, transition-duration,
        /// transition-timing-function, transition-delay, and transition-behavior.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/transition
        static member inline transition (property: string, durationInMs: string, timingFunction: Styles.ITransitionTimingFunction, delayInMs: string) =
            Interop.mkStyle "transition" (
                property + " " +
                durationInMs + " " +
                unbox<string> timingFunction,
                delayInMs
            )
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Sets the size of the font.
        ///
        /// This property is also used to compute the size of em, ex, and other relative <length> units.
        static member inline fontSize (size: string) = Interop.mkStyle "fontSize" size
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Sets the height of a line box. It's commonly used to set the distance between lines of text.
        /// On block-level elements, it specifies the minimum height of line boxes within the element.
        /// On non-replaced inline elements, it specifies the height that is used to calculate line box height.
        /// https://developer.mozilla.org/en-US/docs/Web/CSS/line-height
        ///
        /// This property is also used to compute the size of em, ex, and other relative <length> units.
        ///
        /// Note: Negative values are not allowed.
        static member inline lineHeight (size: string) = Interop.mkStyle "lineHeight" size
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Rounds the corners of an element's outer border edge. You can set a single radius to make
        /// circular corners, or two radii to make elliptical corners.
        static member inline borderRadius (radius: string) = Interop.mkStyle "borderRadius" radius
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Sets the length of time that an animation takes to complete one cycle.
        static member inline animationDuration (timespan: string) = Interop.mkStyle "animationDuration" timespan
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Sets when an animation starts.
        ///
        /// The animation can start later, immediately from its beginning, or immediately and partway through the animation.
        static member inline animationDelay (timespan: string) = Interop.mkStyle "animationDelay" timespan
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Defines from thin to thick characters. 400 is the same as normal, and 700 is the same as bold.
        static member inline fontWeight (weight: string) = Interop.mkStyle "fontWeight" weight
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Adds shadow effects around an element's frame.
        ///
        /// A box shadow is described by X and Y offsets relative to the element, blur and spread radii, and color.
        static member inline boxShadow (value: string) = Interop.mkStyle "boxShadow" value
        /// *This is a custom overload that accepts a `Theme.tokens` string variable.* <br/>
        /// Specifies extra inter-character space in addition to the default space between characters.
        static member inline letterSpacing (value: string) = Interop.mkStyle "letterSpacing" value

module internal Shorthand =

    let expand (style): obj = import "expand" "./inline-style-expand-shorthand.js"

module internal DateFormat =
    let default': DateFormatting = import "DEFAULT_DATE_FORMATTING" "./DateFormatting.js"

[<AutoOpen; System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)>]
module FuiHelpers =

    let inline reactElement (el: ReactElementType) (props: 'a) : ReactElement = import "createElement" "react"

    let inline createElement (el: ReactElementType) (props: 'ControlProperty list) : ReactElement = reactElement el (!!props |> createObj)

    let [<Literal>] FluentUIv9 = "@fluentui/react-components"
    let [<Literal>] FluentIcons = "@fluentui/react-icons"
    let [<Literal>] DatePickerCompat = "@fluentui/react-datepicker-compat"
    let [<Literal>] CalendarCompat = "@fluentui/react-calendar-compat"
    let [<Literal>] TimepickerCompat = "@fluentui/react-timepicker-compat"
    let [<Literal>] ReactDataGridWindow = "@fluentui-contrib/react-data-grid-react-window"
    let [<Literal>] ReactWindow = "react-window"

    // Preview components
    let [<Literal>] Alert_unstable = "@fluentui/react-alert"
    let [<Literal>] Virtualizer_unstable = "@fluentui/react-virtualizer"
    let [<Literal>] Nav_unstable = "@fluentui/react-nav-preview"

// Added because I need the classNames going into mergeClasses to stay as a tuple.
//TODO Find a way to dynamically create the "jsCode" string without it creating incorrect JS when compiled.
[<RequireQualifiedAccess>]
type [<Erase>] JSTuple =
    static member inline from2Args (args: 'T) = emitJsExpr args "$0[0], $0[1]"
    static member inline from3Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2]"
    static member inline from4Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3]"
    static member inline from5Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4]"
    static member inline from6Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5]"
    static member inline from7Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6]"
    static member inline from8Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6], $0[7]"
    static member inline from9Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6], $0[7], $0[8]"
    static member inline from10Args (args: 'T) = emitJsExpr args "$0[0], $0[1], $0[2], $0[3], $0[4], $0[5], $0[6], $0[7], $0[8], $0[9]"

type [<Erase>] Fui =
//---------------------------------------------------------------- Functions --------------------------------------------------------------------------------

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
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (prefix: string option, providedId: string option): string = import "useId" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (prefix: string): string = import "useId" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (prefix: string, providedId: string): string = import "useId" FluentUIv9

    /// Hook to generate a unique ID.
    /// prefix - Optional prefix for the ID. Defaults to 'fui-'.
    /// providedId - Optional id provided by a parent component. Defaults to the provided value if present, without conditioning the hook call
    [<Hook>]
    static member inline useId (): string = import "useId" FluentUIv9

    /// If an id is provided all imperative methods control that specific toaster
    /// Returns Imperative methods to control toasts
    static member inline useToastController (toasterId: string option): ToastController =
        let controller : ToastController = toasterId |> import "useToastController" FluentUIv9

        {
            dispatchToast = fun (element, options) ->
                let options = !!options |> createObj |> unbox<DispatchToastOptions>
                emitJsExpr (element, options) "$0, $1"
                |> controller.dispatchToast
            dismissToast = fun props -> controller.dismissToast props
            dismissAllToasts = fun props -> controller.dismissAllToasts props
            updateToast = fun props -> !!props |> createObj |> unbox |> controller.updateToast
            pauseToast = fun props -> controller.pauseToast props
            playToast = fun props -> controller.playToast props
        }

    static member inline partitionAvatarGroupItems (options: IPartitionAvatarGroupItemsOptionsProp list): PartitionAvatarGroupItems<'T> =
        let partitionAvatarGroupItems = import "partitionAvatarGroupItems" FluentUIv9
        !!options |> createObj |> partitionAvatarGroupItems


    /// `makeStyles` is used to define style permutations in components and is used for style overrides. It returns a React hook that should be called inside a component.
    /// The call returns an object with classes mapped to these unique identifiers.
    ///
    /// **Note:** When using IStyleAttributes with single numeric values ie: style.width 150, specify the unit of measurement ie: style.width (length.px 150)
    ///
    /// *outside of component*
    /// ```
    ///type Styles = { root: string }
    ///let useStyles = Fui.makeStyles<Styles> [ "root", [ style.width (length.px 200) ] ]
    /// ```
    /// OR
    /// ```
    ///let useStyles: unit -> Styles = Fui.makeStyles [ "root", [ style.width (length.px 200) ] ]
    ///```
    ///
    ///*inside of component*
    ///
    /// ```
    ///let styles = useStyles()
    ///{component}.className styles.root
    /// ```
    static member makeStyles<'T> (stylesBySlots: list<string * list<IStyleAttribute>>): unit -> 'T =
        let makeStyles = import "makeStyles" FluentUIv9

        match stylesBySlots with
        | [] -> fun _ -> {||} |> unbox
        | stylesBySlots ->
            [
                for (name, styles) in stylesBySlots do
                    // Using hard-coded files from inline-style-expand-shorthand. Otherwise you run into an issue where
                    // mixed shorthand and longhand properties are applied in an unexpected way due to the rendering order of CSS classes.
                    name, !!styles |> createObj |> Shorthand.expand
            ]
            |> unbox
            |> createObj
            |> makeStyles

    /// This API works similarly to `makeStyles` and is used to generate styles as a single monolithic class to avoid the "CSS rules explosion" problem.
    ///
    /// **Note:** When using IStyleAttributes with single numeric values ie: style.width 150, specify the unit of measurement ie: style.width (length.px 150)
    ///
    /// **Note:** Only one class generated by `makeResetStyles()` can be applied to an element. Otherwise, behavior will be non-deterministic since styles are not merged and deduplicated, the results will depend on order of insertion.
    ///
    /// We recommend using `makeResetStyles` to define the base styles for a component and use `makeStyles` to override or enhance the base styles at runtime.
    ///
    /// Example:
    ///```
    /// *outside of component*
    ///let componentClassName = Fui.makeResetStyles [ style.display.flex; style.flexDirection.row ]
    ///
    ///*inside of component*
    ///let componentClassName = componentClassName()
    ///{component}.className componentClassName
    /// ```
    static member makeResetStyles (styles: IStyleAttribute list): unit -> string =
        let makeResetStyles = import "makeResetStyles" FluentUIv9

        !!styles
        |> createObj
        |> Shorthand.expand
        |> makeResetStyles

    [<Hook>]
    static member inline useOverflowMenu (id: string option): OverflowMenuOptions<'Element> = import "useOverflowMenu" FluentUIv9

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

    /// The `bundleIcon` method bundles a `filled` and `unfilled` version of an icon and combines them into one icon.
    /// You can also add additional styles to the bundled icon after the method call.
    ///
    /// `let AddIcon = Fui.bundleIcon bundleIcons.addCircle`
    ///
    /// `{component}.icon (AddIcon [ icon.style [ style.color.yellow ] ])`
    static member inline bundleIcon (icons: BundleIcons) (iconProps: IIconProp list): ReactElement =
        !!iconProps |> createObj |> import "bundleIcon" FluentIcons ((icons.Filled, icons.Regular) |> JSTuple.from2Args)

    /// Helper function to create column definition with defaults
    /// options - column definition options
    /// Returns - column definition with defaults
    static member inline createTableColumn (options: ICreateTableColumnOptionProp list): TableColumnDefinition<'T, 'TKeyType> =
        let createTableColumn = import "createTableColumn" FluentUIv9
        !!options |> createObj |> createTableColumn

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

    /// this hook provides FlatTree API to manage all required mechanisms to convert a list of items into renderable TreeItems
    /// in multiple scenarios including virtualization.
    /// !!A flat tree is an unofficial spec for tree!!
    /// It should be used on cases where more complex interactions with a Tree is required.
    /// On simple scenarios it is advised to simply use a nested structure instead.
    /// @param props - a list of tree items
    /// @param options - in case control over the internal openItems is required
    [<Hook>]
    static member inline useHeadlessFlatTree_unstable (props: IHeadlessTreeItemProp list list, options: IHeadlessFlatTreeOptionsProp list) =
        let props =
            props
            |> List.map (fun p -> !!p |> createObj)
            |> List.toArray

        let options = !!options |> createObj

        (props, options) |> JSTuple.from2Args |> import "useHeadlessFlatTree_unstable" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string): string =
        JSTuple.from2Args (v1, v2) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string): string =
        JSTuple.from3Args (v1, v2, v3) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string): string =
        JSTuple.from4Args (v1, v2, v3, v4) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string): string =
        JSTuple.from5Args (v1, v2, v3, v4, v5) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string): string =
        JSTuple.from6Args (v1, v2, v3, v4, v5, v6) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string): string =
        JSTuple.from7Args (v1, v2, v3, v4, v5, v6, v7) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string, v8: string): string =
        JSTuple.from8Args (v1, v2, v3, v4, v5, v6, v7, v8) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string, v8: string, v9: string): string =
        JSTuple.from9Args (v1, v2, v3, v4, v5, v6, v7, v8, v9) |> import "mergeClasses" FluentUIv9

    /// `mergeClasses` joins classes together and deduplicates atomic declarations generated by `makeStyles()`. Handles scoped directional styles. This function can merge up to 10 classnames.
    ///
    /// **NOTE: If using conditional classNames, wrap the condition in parenthesis**.
    static member inline mergeClasses (v1: string, v2: string, v3: string, v4: string, v5: string, v6: string, v7: string, v8: string, v9: string, v10: string): string =
        JSTuple.from10Args (v1, v2, v3, v4, v5, v6, v7, v8, v9, v10) |> import "mergeClasses" FluentUIv9
    /// Returns a date offset from the given date by the specified number of days.
    /// date - The origin date
    /// days - The number of days to offset. 'days' can be negative.
    static member inline addDays (date: System.DateTime, days: int): System.DateTime = import "addDays" CalendarCompat
    /// Returns a date offset from the given date by the specified number of months.
    /// The method tries to preserve the day-of-month; however, if the new month does not have enough days to contain the original day-of-month, we'll use the last day of the new month.
    /// date - The origin date
    /// months - The number of months to offset. 'months' can be negative.
    static member inline addMonths (date: System.DateTime, months: int): System.DateTime = import "addMonths" CalendarCompat
    /// Returns a date offset from the given date by the specified number of weeks.
    /// date - The origin date
    /// weeks - The number of weeks to offset. 'weeks' can be negative.
    static member inline addWeeks (date: System.DateTime, weeks: int): System.DateTime = import "addWeeks" CalendarCompat
    /// Returns a date offset from the given date by the specified number of years.
    /// The method tries to preserve the day-of-month; however, if the new month does not have enough days to contain the original day-of-month, we'll use the last day of the new month.
    /// date - The origin date
    /// years - The number of years to offset. 'years' can be negative.
    static member inline addYears (date: System.DateTime, years: int): System.DateTime = import "addYears" CalendarCompat
    /// Returns a date that is a copy of the given date, aside from the month changing to the given month.
    /// The method tries to preserve the day-of-month; however, if the new month does not have enough days to contain the original day-of-month, we'll use the last day of the new month.
    /// date - The origin date
    /// month - The 0-based index of the month to set on the date.
    static member inline setMonth (date: System.DateTime, month: int): System.DateTime = import "setMonth" CalendarCompat
    /// Checks whether the specified date is in the given date range.
    /// @param date - The origin date
    /// @param dateRange - An array of dates to do the lookup on
    static member inline isInDateRangeArray (date: System.DateTime, dateRange: System.DateTime array): bool = import "isInDateRangeArray" CalendarCompat
    /// Returns a date that is the first day of the year of the provided date.
    /// date - The origin date
    static member inline getYearStart (date: System.DateTime): System.DateTime = import "getYearStart" CalendarCompat
    /// Returns a date that is the last day of the year of the provided date.
    /// date - The origin date
    static member inline getYearEnd (date: System.DateTime): System.DateTime = import "getYearEnd" CalendarCompat
    /// Returns the week number for a date. Week numbers are 1 - 52 (53) in a year
    /// navigatedDate - A date to find the week number for.
    /// firstDayOfWeek - The first day of the week (0-6, Sunday = 0)
    /// firstWeekOfYear - The first week of the year (1-2)
    static member inline getWeekNumbersInMonth (weeksInMonth: int, firstDayOfWeek: System.DayOfWeek, firstWeekOfYear: FirstWeekOfYear, navigatedDate: System.DateTime): int =
        let firstWeekOfYear =
            match firstWeekOfYear with
            | FirstDay -> 0
            | FirstFullWeek -> 1
            | FirstFourDayWeek -> 2
        (weeksInMonth, firstDayOfWeek, firstWeekOfYear, navigatedDate) |> JSTuple.from4Args |> import "getWeekNumbersInMonth" CalendarCompat
    /// Returns the week number for a date. Week numbers are 1 - 52 (53) in a year
    /// date - A date to find the week number for.
    /// firstDayOfWeek - The first day of the week (0-6, Sunday = 0)
    /// firstWeekOfYear - The first week of the year (1-2)
    static member inline getWeekNumber (date: System.DateTime, firstDayOfWeek: System.DayOfWeek, firstWeekOfYear: FirstWeekOfYear): int =
        let firstWeekOfYear =
            match firstWeekOfYear with
            | FirstDay -> 0
            | FirstFullWeek -> 1
            | FirstFourDayWeek -> 2
        (date, firstDayOfWeek, firstWeekOfYear) |> JSTuple.from3Args |> import "getWeekNumber" CalendarCompat
    /// Gets the date for the first day of the week based on the given date assuming the specified first day of the week.
    /// date - The date to find the beginning of the week date for.
    static member inline getStartDateOfWeek (date: System.DateTime, firstDayOfWeek: System.DayOfWeek): System.DateTime = import "getStartDateOfWeek" CalendarCompat
    /// Returns a date that is the first day of the month of the provided date.
    /// date - The origin date
    static member inline getMonthStart (date: System.DateTime): System.DateTime = import "getMonthStart" CalendarCompat
    /// Returns a date that is the last day of the month of the provided date.
    /// date - The origin date
    static member inline getMonthEnd (date: System.DateTime): System.DateTime = import "getMonthEnd" CalendarCompat
    /// Gets the date for the last day of the week based on the given date assuming the specified first day of the week.
    /// date - The date to find the beginning of the week date for.
    static member inline getEndDateOfWeek (date: System.DateTime, firstDayOfWeek: System.DayOfWeek): System.DateTime = import "getEndDateOfWeek" CalendarCompat
    /// Gets the date for the last day of the week based on the given date assuming the specified first day of the week.
    /// date - The date to find the beginning of the week date for.
    static member inline getDateRangeArray (date: System.DateTime, dateRangeType: DateRangeType, firstDayOfWeek: System.DayOfWeek, workWeekDays: System.DayOfWeek array, daysToSelectInDayView: int): System.DateTime array =
        let dateRangeType =
            match dateRangeType with
            | Day -> 0
            | Week -> 1
            | Month -> 2
            | WorkWeek -> 3
        (date, dateRangeType, firstDayOfWeek, workWeekDays, daysToSelectInDayView) |> JSTuple.from5Args |> import "getDateRangeArray" CalendarCompat
    /// Compares two dates, and returns true if the two dates (not accounting for time-of-day) are equal.
    static member inline compareDates (date1: System.DateTime, date2: System.DateTime): bool = import "compareDates" CalendarCompat
    /// Compare the date parts of two dates
    /// date1 - The first date to compare
    /// date2 - The second date to compare
    /// Returns A negative value if date1 is earlier than date2, 0 if the dates are equal, or a positive value if date1 is later than date2.
    static member inline compareDatePart (date1: System.DateTime, date2: System.DateTime): int = import "compareDatePart" CalendarCompat

    /// React hook that measures virtualized space based on a static size to ensure optimized virtualization length.
    [<Hook>]
    static member inline useStaticVirtualizerMeasure (virtualizerProps: IVirtualizerMeasurePropsProp list): VirtualizerMeasure =
        let useStaticVirtualizerMeasure = import "useStaticVirtualizerMeasure" Virtualizer_unstable
        !!virtualizerProps |> createObj |> useStaticVirtualizerMeasure

    /// A hook that returns the visibility status of all items and groups.
    ///
    /// ⚠️ Heads up!
    ///
    /// This hook will cause the component it is in to re-render for every single time an item overflows or becomes
    /// visible - use with caution
    /// Returns visibility status of all items and groups
    [<Hook>]
    static member inline useOverflowVisibility (): OverflowVisibility = import "useOverflowVisibility" FluentUIv9

    /// Designates an area where tabster does not control focus
    /// Returns Attribute to apply to the target element that should be uncontrolled by tabster
    static member inline useUncontrolledFocus (): IReactProperty =
        let useUncontrolledFocus = import "useUncontrolledFocus" FluentUIv9
        let dataTabster : DataTabster = useUncontrolledFocus ()
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// Focus will be restored to the most recent target element when it is lost from a source
    /// Returns Attribute to apply to the element that might lose focus
    [<Hook>]
    static member inline useRestoreFocusSource (): IReactProperty =
        let useRestoreFocusSource = import "useRestoreFocusSource" FluentUIv9
        let dataTabster : DataTabster = useRestoreFocusSource ()
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// Focus will be restored to the most recent target element when it is lost from a source
    /// Returns Attribute to apply to the target element where focus is restored
    [<Hook>]
    static member inline useRestoreFocusTarget (): IReactProperty =
        let useRestoreFocusTarget = import "useRestoreFocusTarget" FluentUIv9
        let dataTabster : DataTabster = useRestoreFocusTarget ()
        prop.custom("data-tabster", dataTabster.``data-tabster``)

    /// A hook to filter the options based on the user-typed string. It can be configured for a custom filter function, custom message, and custom render function.
    /// We recommend using filtering when creating a freeform Combobox.
    ///
    /// **'T must be a type or object that includes `children` and `value` properties. Using a type or object without these properties will cause `Fui.useComboboxFilter` to not filter correctly.**
    ///
    /// **`children` is the text/component that will appear for each option in the dropdown**
    ///
    /// **`value` is the text that will be used for the filtering based on user's input**
    [<Hook>]
    static member inline useComboboxFilter (query: string, options: 'T list, config: IComboboxFilterConfigProp list): ReactElement list =
        let options = options |> List.toArray
        let config = !!config |> createObj

        JSTuple.from3Args (query, options, config) |> import "useComboboxFilter" FluentUIv9

    static member inline useTagPickerFilter (filters: IUseTagPickerFilterProp list): ReactElement list =
        let useTagPickerFilter = import "useTagPickerFilter" FluentUIv9

        !!filters |> createObj |> unbox |> useTagPickerFilter

    static member inline renderSwatchPickerGrid  (filters: ISwatchPickerGridProp list): ReactElement list =
        let renderSwatchPickerGrid  = import "renderSwatchPickerGrid" FluentUIv9

        !!filters |> createObj |> unbox |> renderSwatchPickerGrid

    /// `createPresenceComponent` is a factory function that creates a React component based on the provided presence definition.
    /// This component can be used to animate any element and intended to have a state via the visible prop.
    static member inline createPresenceComponent (value: PresenceMotion) (props: IPresenceComponentProp list): ReactElement =
        let enter = !!value.enter |> createObj |> unbox
        let exit = !!value.exit |> createObj |> unbox

        let newValue = {|
            enter = enter
            exit = exit
        |}

        let comp = newValue |> import "createPresenceComponent" FluentUIv9
        let newProps = !!props |> createObj |> unbox

        newProps |> comp

    /// `createMotionComponent` is a factory function that creates a custom motion component powered by Web Animations API.
    static member inline createMotionComponent (value: IAtomMotionProp list) (props: IPresenceComponentProp list): ReactElement =
        let newValue = !!value |> createObj |> unbox
        let comp = newValue |> import "createMotionComponent" FluentUIv9
        let newProps = !!props |> createObj |> unbox

        newProps |> comp

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

    static member inline defaultDatePickerStrings : CalendarStrings = import "defaultDatePickerStrings" DatePickerCompat
    static member defaultDateFormatting : DateFormatting = DateFormat.default'

    /// As of 10/23/23, this component is not in Microsoft's documentation but is completely usable.
    /// This could be used in place of an InfoLabel component where no label is needed?
    static member inline infoButton (props: IInfoButtonProp list) = createElement (import "InfoButton" "@fluentui/react-infobutton") props
    /// An InfoLabel is a Label with an InfoButton at the end, properly handling layout and accessibility properties. It can be used as a drop-in replacement for Label when an InfoButton is also needed.
    static member inline infoLabel (props: IInfoLabelProp list) = createElement (import "InfoLabel" FluentUIv9) props
    /// An Alert displays a brief, important message to attract a user's attention without interrupting their current task.
    ///
    /// WARNING: This API is deprecated. Please use the Toast or MessageBar component instead.
    [<Obsolete>] static member inline alert (props: IAlertProp list) = createElement (import "Alert" Alert_unstable) props
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
    static member inline drawer (props: IDrawerProp list) = createElement (import "Drawer" FluentUIv9) props
    /// Represents an overlay Drawer. This component renders on top of the whole page. By default blocks the screen and will require users full attention. Uses Dialog component under the hood.
    static member inline overlayDrawer (props: IOverlayDrawerProp list) = createElement (import "OverlayDrawer" FluentUIv9) props
    /// Represents an inline Drawer. This is rendered within a container and can be placed next to any content.
    static member inline inlineDrawer (props: IInlineDrawerProp list) = createElement (import "InlineDrawer" FluentUIv9) props
    static member inline drawerHeader (props: IDrawerHeaderProp list) = createElement (import "DrawerHeader" FluentUIv9) props
    static member inline drawerHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DrawerHeader" FluentUIv9) props
    static member inline drawerHeaderTitle (props: IDrawerHeaderTitleProp list) = createElement (import "DrawerHeaderTitle" FluentUIv9) props
    static member inline drawerHeaderNavigation (props: IDrawerHeaderNavigationProp list) = createElement (import "DrawerHeaderNavigation" FluentUIv9) props
    static member inline drawerBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DrawerBody" FluentUIv9) props
    static member inline drawerBody (props: IDrawerBodyProp list) = createElement (import "DrawerBody" FluentUIv9) props
    static member inline drawerFooter (props : IDrawerFooterProp list) =  createElement (import "DrawerFooter" FluentUIv9) props
    static member inline drawerFooter (props : ReactElement list) =  Interop.reactElementWithChildren (import "DrawerFooter" FluentUIv9) props

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
    static member inline toastTitle (text: string) = createElement (import "ToastTitle" FluentUIv9) [ prop.text text ]
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
    static member inline dialogTitle (text: string) = createElement (import "DialogTitle" FluentUIv9) [ prop.text text ]
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
    static member inline menuItemSwitch (props: IMenuItemSwitchProp list) = createElement (import "MenuItemSwitch" FluentUIv9) props
    // Table
    /// This component is considered low-level and should be used when there is a need for more customization and support for non-standard features. Please check out the DataGrid component if you don't need lots of customization and rely on common features. There is less work involved and you will benefit from first class Microsoft design and accessibility support.
    ///
    /// WARNING: Hooks for this component are incomplete. Please use ```Fui.dataGrid``` instead.
    static member inline table (props: ReactElement list) = Interop.reactElementWithChildren (import "Table" FluentUIv9) props
    /// This component is considered low-level and should be used when there is a need for more customization and support for non-standard features. Please check out the DataGrid component if you don't need lots of customization and rely on common features. There is less work involved and you will benefit from first class Microsoft design and accessibility support.
    ///
    /// WARNING: Hooks for this component are incomplete. Please use ```Fui.dataGrid``` instead.
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
    static member inline tableCellActions (props: ITableCellActionsProp list) = createElement (import "TableCellActions" FluentUIv9) props
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
    // Breadcrumb
    static member inline breadcrumb (props: IBreadcrumbProp list) = createElement (import "Breadcrumb" FluentUIv9) props
    static member inline breadcrumb (props: ReactElement list) = Interop.reactElementWithChildren (import "Breadcrumb" FluentUIv9) props
    static member inline breadcrumbItem (props: IBreadcrumbItemProp list) = createElement (import "BreadcrumbItem" FluentUIv9) props
    static member inline breadcrumbItem (props: ReactElement list) = Interop.reactElementWithChildren (import "BreadcrumbItem" FluentUIv9) props
    static member inline breadcrumbButton (props: IBreadcrumbButtonProp list) = createElement (import "BreadcrumbButton" FluentUIv9) props
    static member inline breadcrumbDivider (props: IBreadcrumbDividerProp list) = createElement (import "BreadcrumbDivider" FluentUIv9) props
    static member inline partitionBreadcrumbItems (options: IPartitionBreadcrumbItemsOptionsProp list): PartitionBreadcrumbItems<'T> =
        let partitionBreadcrumbItems = import "partitionBreadcrumbItems" FluentUIv9

        !!options
        |> createObj
        |> unbox<PartitionBreadcrumbItemsOptions<'T>>
        |> partitionBreadcrumbItems

    static member inline searchBox (props: ISearchBoxProp list) = createElement (import "SearchBox" FluentUIv9) props
    static member inline tag (props: ITagProp list) = createElement (import "Tag" FluentUIv9) props
    static member inline tagGroup (props: ITagGroupProp list) = createElement (import "TagGroup" FluentUIv9) props
    static member inline interactionTag (props: IInteractionTagProp list) = createElement (import "InteractionTag" FluentUIv9) props
    static member inline interactionTag (props: ReactElement list) = Interop.reactElementWithChildren (import "InteractionTag" FluentUIv9) props
    static member inline interactionTagPrimary (props: IInteractionTagPrimaryProp list) = createElement (import "InteractionTagPrimary" FluentUIv9) props
    static member inline interactionTagSecondary (props: IInteractionTagSecondaryProp list) = createElement (import "InteractionTagSecondary" FluentUIv9) props
    // MessageBar
    /// Communicates important information about the state of the entire application or surface. For example, the status of a page, panel, dialog or card.
    /// The information shouldn't require someone to take immediate action, but should persist until the user performs one of the required actions.
    static member inline messageBar (props: IMessageBarProp list) = createElement (import "MessageBar" FluentUIv9) props
    /// Communicates important information about the state of the entire application or surface. For example, the status of a page, panel, dialog or card.
    /// The information shouldn't require someone to take immediate action, but should persist until the user performs one of the required actions.
    static member inline messageBar (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBar" FluentUIv9) props
    static member inline messageBarBody (props: IMessageBarBodyProp list) = createElement (import "MessageBarBody" FluentUIv9) props
    static member inline messageBarBody (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBarBody" FluentUIv9) props
    static member inline messageBarTitle (props: IMessageBarTitleProp list) = createElement (import "MessageBarTitle" FluentUIv9) props
    static member inline messageBarTitle (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBarTitle" FluentUIv9) props
    static member inline messageBarTitle (text: string) = createElement (import "MessageBarTitle" FluentUIv9) [ prop.text text ]
    static member inline messageBarActions (props: IMessageBarActionsProp list) = createElement (import "MessageBarActions" FluentUIv9) props
    static member inline messageBarGroup (props: IMessageBarGroupProp list) = createElement (import "MessageBarGroup" FluentUIv9) props
    static member inline messageBarGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "MessageBarGroup" FluentUIv9) props

    // Calendar
    static member inline calendar (props: ICalendarProp list) = createElement (import "Calendar" CalendarCompat) props

    static member inline timePicker (props: ITimePickerProp list) = createElement (import "TimePicker" TimepickerCompat) props

    static member inline typographyStyles: TypographyStyles = import "typographyStyles" FluentUIv9

    // TeachingPopover
    static member inline teachingPopover (props: ITeachingPopoverProp list) = createElement (import "TeachingPopover" FluentUIv9) props
    static member inline teachingPopover (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopover" FluentUIv9) props
    static member inline teachingPopoverTrigger (props: ReactElement) = createElement (import "TeachingPopoverTrigger" FluentUIv9) [prop.children (props)]
    static member inline teachingPopoverTrigger (props: ITeachingPopoverTriggerProp list) = createElement (import "TeachingPopoverTrigger" FluentUIv9) props
    static member inline teachingPopoverSurface (props: ITeachingPopoverSurfaceProp list) = createElement (import "TeachingPopoverSurface" FluentUIv9) props
    static member inline teachingPopoverSurface (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverSurface" FluentUIv9) props
    static member inline teachingPopoverHeader (props: ITeachingPopoverHeaderProp list) = createElement (import "TeachingPopoverHeader" FluentUIv9) props
    static member inline teachingPopoverHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverHeader" FluentUIv9) props
    static member inline teachingPopoverHeader (text: string) = createElement (import "TeachingPopoverHeader" FluentUIv9) [ prop.text text ]
    static member inline teachingPopoverBody (props: ITeachingPopoverBodyProp list) = createElement (import "TeachingPopoverBody" FluentUIv9) props
    static member inline teachingPopoverTitle (props: ITeachingPopoverTitleProp list) = createElement (import "TeachingPopoverTitle" FluentUIv9) props
    static member inline teachingPopoverTitle (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverTitle" FluentUIv9) props
    static member inline teachingPopoverTitle (text: string) = createElement (import "TeachingPopoverTitle" FluentUIv9) [ prop.text text ]
    static member inline teachingPopoverCarousel (props: ITeachingPopoverCarouselProp list) = createElement (import "TeachingPopoverCarousel" FluentUIv9) props
    static member inline teachingPopoverCarousel (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarousel" FluentUIv9) props
    static member inline teachingPopoverCarouselCard (props: ITeachingPopoverCarouselCardProp list) = createElement (import "TeachingPopoverCarouselCard" FluentUIv9) props
    static member inline teachingPopoverCarouselCard (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarouselCard" FluentUIv9) props
    static member inline teachingPopoverCarouselFooter (props: ITeachingPopoverCarouselFooterProp list) = createElement (import "TeachingPopoverCarouselFooter" FluentUIv9) props
    static member inline teachingPopoverCarouselFooter (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarouselFooter" FluentUIv9) props
    static member inline teachingPopoverCarouselNav (props: ITeachingPopoverCarouselNavProp list) = createElement (import "TeachingPopoverCarouselNav" FluentUIv9) props
    static member inline teachingPopoverCarouselNav (props: ReactElement list) = Interop.reactElementWithChildren (import "TeachingPopoverCarouselNav" FluentUIv9) props
    static member inline teachingPopoverCarouselNavButton (props: ITeachingPopoverCarouselNavButtonProp list) = createElement (import "TeachingPopoverCarouselNavButton" FluentUIv9) props

    static member inline rating (props: IRatingProp list) = createElement (import "Rating" FluentUIv9) props
    static member inline ratingItem (props: IRatingItemProp list) = createElement (import "RatingItem" FluentUIv9) props
    static member inline ratingDisplay (props: IRatingDisplayProp list) = createElement (import "RatingDisplay" FluentUIv9) props

    static member inline tagPicker (props: ITagPickerProp list) = createElement (import "TagPicker" FluentUIv9) props
    static member inline tagPicker (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPicker" FluentUIv9) props
    static member inline tagPickerControl (props: ITagPickerControlProp list) = createElement (import "TagPickerControl" FluentUIv9) props
    static member inline tagPickerControl (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerControl" FluentUIv9) props
    static member inline tagPickerGroup (props: ITagPickerGroupProp list) = createElement (import "TagPickerGroup" FluentUIv9) props
    static member inline tagPickerGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerGroup" FluentUIv9) props
    static member inline tagPickerButton (props: ITagPickerButtonProp list) = createElement (import "TagPickerButton" FluentUIv9) props
    static member inline tagPickerButton (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerButton" FluentUIv9) props
    static member inline tagPickerInput (props: ITagPickerInputProp list) = createElement (import "TagPickerInput" FluentUIv9) props
    static member inline tagPickerInput (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerInput" FluentUIv9) props
    static member inline tagPickerList (props: ITagPickerListProp list) = createElement (import "TagPickerList" FluentUIv9) props
    static member inline tagPickerList (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerList" FluentUIv9) props
    static member inline tagPickerOption (props: ITagPickerOptionProp list) = createElement (import "TagPickerOption" FluentUIv9) props
    static member inline tagPickerOption (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerOption" FluentUIv9) props
    static member inline tagPickerOptionGroup (props: ITagPickerOptionGroupProp list) = createElement (import "TagPickerOptionGroup" FluentUIv9) props
    static member inline tagPickerOptionGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "TagPickerOptionGroup" FluentUIv9) props
    static member inline swatchPicker (props: ISwatchPickerProp list) = createElement (import "SwatchPicker" FluentUIv9) props
    static member inline colorSwatch (props: IColorSwatchProp list) = createElement (import "ColorSwatch" FluentUIv9) props
    static member inline swatchPickerRow (props: ISwatchPickerRowProp list) = createElement (import "SwatchPickerRow" FluentUIv9) props
    static member inline imageSwatch (props: IImageSwatchProp list) = createElement (import "ImageSwatch" FluentUIv9) props
    static member inline emptySwatch (props: IEmptySwatchProp list) = createElement (import "EmptySwatch" FluentUIv9) props
    static member inline carousel (props: ICarouselProp list) = createElement (import "Carousel" FluentUIv9) props
    static member inline carouselButton (props: ICarouselButtonProp list) = createElement (import "CarouselButton" FluentUIv9) props
    static member inline carouselCard (props: ICarouselCardProp list) = createElement (import "CarouselCard" FluentUIv9) props
    static member inline carouselCard (props: ReactElement list) = Interop.reactElementWithChildren (import "CarouselCard" FluentUIv9) props
    static member inline carouselNav (props: ICarouselNavProp list) = createElement (import "CarouselNav" FluentUIv9) props
    static member inline carouselNav (props: ReactElement list) = Interop.reactElementWithChildren (import "CarouselNav" FluentUIv9) props
    static member inline carouselNavButton (props: ICarouselNavButtonProp list) = createElement (import "CarouselNavButton" FluentUIv9) props
    static member inline carouselNavContainer (props: ICarouselNavContainerProp list) = createElement (import "CarouselNavContainer" FluentUIv9) props
    static member inline carouselNavImageButton (props: ICarouselNavImageButtonProp list) = createElement (import "CarouselNavImageButton" FluentUIv9) props
    static member inline carouselSlider (props: ICarouselSliderProp list) = createElement (import "CarouselSlider" FluentUIv9) props
    static member inline carouselSlider (props: ReactElement list) = Interop.reactElementWithChildren (import "CarouselSlider" FluentUIv9) props
    static member inline carouselAutoplayButton (props: ICarouselAutoplayButtonProp list) = createElement (import "CarouselAutoplayButton" FluentUIv9) props
    static member inline carouselViewport (props: ICarouselViewportProp list) = createElement (import "CarouselViewport" FluentUIv9) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline appItem (props: IAppItemProp list) = createElement (import "AppItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline hamburger (props: IHamburgerProp list) = createElement (import "Hamburger" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navCategory (props: INavCategoryProp list) = createElement (import "NavCategory" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navCategoryItem (props: INavCategoryItemProp list) = createElement (import "NavCategoryItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDivider (props: INavDividerProp list) = createElement (import "NavDivider" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawer (props: INavDrawerProp list) = createElement (import "NavDrawer" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerBody (props: INavDrawerBodyProp list) = createElement (import "NavDrawerBody" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerBody (props: ReactElement list) = Interop.reactElementWithChildren (import "NavDrawerBody" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerHeader (props: INavDrawerHeaderProp list) = createElement (import "NavDrawerHeader" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerHeader (props: ReactElement list) =  Interop.reactElementWithChildren (import "NavDrawerHeader" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navItem (props: INavItemProp list) = createElement (import "NavItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSectionHeader (props: INavSectionHeaderProp list) = createElement (import "NavSectionHeader" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSubItem (props: INavSubItemProp list) = createElement (import "NavSubItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSubItemGroup (props: INavSubItemGroupProp list) = createElement (import "NavSubItemGroup" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navSubItemGroup (props: ReactElement list) = Interop.reactElementWithChildren (import "NavSubItemGroup" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline appItemStatic (props: IAppItemStaticProp list) = createElement (import "AppItemStatic" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline splitNavItem (props: ISplitNavItemProp list) = createElement (import "SplitNavItem" Nav_unstable) props
    /// WARNING: This is a preview component and is likely to change. Use caution when implementing in production.
    static member inline navDrawerFooter (props: INavDrawerFooterProp list) = createElement (import "NavDrawerFooter" Nav_unstable) props
    /// The List is a component for rendering set of vertically stacked items (other layouts are being discussed). These items can be focusable, selectable, have one primary action and one or more secondary actions.
    static member inline list (props: IListProp list) = createElement (import "List" FluentUIv9) props
    /// The List is a component for rendering set of vertically stacked items (other layouts are being discussed). These items can be focusable, selectable, have one primary action and one or more secondary actions.
    static member inline list (props: ReactElement list) = Interop.reactElementWithChildren (import "List" FluentUIv9) props
    static member inline listItem (props: IListItemProp list) = createElement (import "ListItem" FluentUIv9) props
    static member inline listItem (props: ReactElement list) = Interop.reactElementWithChildren (import "ListItem" FluentUIv9) props
    /// A virtualized List that's leveraging the react-window package.
    static member inline fixedSizeList (props: IFixedSizeListProp list) = createElement (import "FixedSizeList" ReactWindow) props

type [<Erase>] Theme =
    static member inline teamsLightTheme : Tokens = import "teamsLightTheme" FluentUIv9
    static member inline teamsDarkTheme : Tokens = import "teamsDarkTheme" FluentUIv9
    static member inline teamsHighContrastTheme : Tokens = import "teamsHighContrastTheme" FluentUIv9
    static member inline webLightTheme : Tokens = import "webLightTheme" FluentUIv9
    static member inline webDarkTheme : Tokens = import "webDarkTheme" FluentUIv9
    /// Warning: Although overriding tokens with 'let newTokens = { Theme.tokens with colorBrandStroke1 = "#cbe82e" }' is possible,
    /// it's not recommended-- if the existing tokens do not fulfill your needs, you should create a custom theme instead of overriding tokens.
    static member inline tokens: Tokens = import "tokens" FluentUIv9
    static member inline motionTokens: MotionTokens = import "motionTokens" FluentUIv9
    /// Programmatically generates a tokens to css variables mapping object from the keys in a theme.
    /// This helps with ease of use as a user of a custom theme does not have to manually construct this object, but it could
    /// affect tree-shaking since bundlers do not know the shape of the output.
    /// @param theme - Theme from which to get the keys to generate the tokens to css variables mapping object
    /// @returns Tokens to css variables mapping object corresponding to the passed theme
    static member inline themeToTokensObject (theme: Tokens): Tokens = import "themeToTokensObject" FluentUIv9

module Fui =
    type [<Erase>] virtualized =
        static member inline dataGrid (props: IDataGridProp list) = createElement (import "DataGrid" ReactDataGridWindow) props
        static member inline dataGridHeader (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeader" ReactDataGridWindow) props
        static member inline dataGridHeader (props: IDataGridHeaderProp list) = createElement (import "DataGridHeader" ReactDataGridWindow) props
        static member inline dataGridHeaderCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridHeaderCell" ReactDataGridWindow) props
        static member inline dataGridHeaderCell (props: IDataGridHeaderCellProp list) = createElement (import "DataGridHeaderCell" ReactDataGridWindow) props
        static member inline dataGridRow (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridRow" ReactDataGridWindow) props
        static member inline dataGridRow (props: IDataGridRowProp list) = createElement (import "DataGridRow" ReactDataGridWindow) props
        static member inline dataGridBody (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridBody" ReactDataGridWindow) props
        static member inline dataGridBody (props: IDataGridBodyProp list) = createElement (import "DataGridBody" ReactDataGridWindow) props
        static member inline dataGridCell (props: ReactElement list) = Interop.reactElementWithChildren (import "DataGridCell" ReactDataGridWindow) props
        static member inline dataGridCell (props: IDataGridCellProp list) = createElement (import "DataGridCell" ReactDataGridWindow) props
        static member inline dataGridSelectionCell (props: IDataGridSelectionCellProp list) = createElement (import "DataGridSelectionCell" ReactDataGridWindow) props

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

    type [<Erase>] icon =
        /// Use this function to import a specific FluentUI Icon by name. This is useful when there's an Icon that <u>is</u> in the TS docs
        /// but <u>is not yet</u> in FS.FluentUI.<br/>
        /// Please see <link>https://react.fluentui.dev/?path=/docs/icons-catalog--docs</link> for all FluentUI icons.<br/>
        /// ***WARNING**: Mispelling the iconName or passing an iconName that doesn't exist in the library will cause a runtime error.*
        ///
        /// Usage:
        /// <code>
        /// let icon = Fui.icon.import "BlockBusterLogoFilled" []
        /// </code>
        static member inline import (iconName: string) =
            let icon = import $"{iconName}" FluentIcons
            fun (props: IIconProp list) -> createElement icon props
        static member inline accessTimeFilled (props: IIconProp list) = createElement (import "AccessTimeFilled" FluentIcons) props
        static member inline accessTimeRegular (props: IIconProp list) = createElement (import "AccessTimeRegular" FluentIcons) props
        static member inline accessibilityFilled (props: IIconProp list) = createElement (import "AccessibilityFilled" FluentIcons) props
        static member inline accessibilityRegular (props: IIconProp list) = createElement (import "AccessibilityRegular" FluentIcons) props
        static member inline accessibilityCheckmarkFilled (props: IIconProp list) = createElement (import "AccessibilityCheckmarkFilled" FluentIcons) props
        static member inline accessibilityCheckmarkRegular (props: IIconProp list) = createElement (import "AccessibilityCheckmarkRegular" FluentIcons) props
        static member inline accessibilityErrorFilled (props: IIconProp list) = createElement (import "AccessibilityErrorFilled" FluentIcons) props
        static member inline accessibilityErrorRegular (props: IIconProp list) = createElement (import "AccessibilityErrorRegular" FluentIcons) props
        static member inline accessibilityMoreFilled (props: IIconProp list) = createElement (import "AccessibilityMoreFilled" FluentIcons) props
        static member inline accessibilityMoreRegular (props: IIconProp list) = createElement (import "AccessibilityMoreRegular" FluentIcons) props
        static member inline accessibilityQuestionMarkFilled (props: IIconProp list) = createElement (import "AccessibilityQuestionMarkFilled" FluentIcons) props
        static member inline accessibilityQuestionMarkRegular (props: IIconProp list) = createElement (import "AccessibilityQuestionMarkRegular" FluentIcons) props
        static member inline addFilled (props: IIconProp list) = createElement (import "AddFilled" FluentIcons) props
        static member inline addRegular (props: IIconProp list) = createElement (import "AddRegular" FluentIcons) props
        static member inline addCircleFilled (props: IIconProp list) = createElement (import "AddCircleFilled" FluentIcons) props
        static member inline addCircleRegular (props: IIconProp list) = createElement (import "AddCircleRegular" FluentIcons) props
        static member inline addSquareFilled (props: IIconProp list) = createElement (import "AddSquareFilled" FluentIcons) props
        static member inline addSquareRegular (props: IIconProp list) = createElement (import "AddSquareRegular" FluentIcons) props
        static member inline addSquareMultipleFilled (props: IIconProp list) = createElement (import "AddSquareMultipleFilled" FluentIcons) props
        static member inline addSquareMultipleRegular (props: IIconProp list) = createElement (import "AddSquareMultipleRegular" FluentIcons) props
        static member inline addSubtractCircleFilled (props: IIconProp list) = createElement (import "AddSubtractCircleFilled" FluentIcons) props
        static member inline addSubtractCircleRegular (props: IIconProp list) = createElement (import "AddSubtractCircleRegular" FluentIcons) props
        static member inline airplaneFilled (props: IIconProp list) = createElement (import "AirplaneFilled" FluentIcons) props
        static member inline airplaneRegular (props: IIconProp list) = createElement (import "AirplaneRegular" FluentIcons) props
        static member inline airplaneLandingFilled (props: IIconProp list) = createElement (import "AirplaneLandingFilled" FluentIcons) props
        static member inline airplaneLandingRegular (props: IIconProp list) = createElement (import "AirplaneLandingRegular" FluentIcons) props
        static member inline airplaneTakeOffFilled (props: IIconProp list) = createElement (import "AirplaneTakeOffFilled" FluentIcons) props
        static member inline airplaneTakeOffRegular (props: IIconProp list) = createElement (import "AirplaneTakeOffRegular" FluentIcons) props
        static member inline albumFilled (props: IIconProp list) = createElement (import "AlbumFilled" FluentIcons) props
        static member inline albumRegular (props: IIconProp list) = createElement (import "AlbumRegular" FluentIcons) props
        static member inline albumAddFilled (props: IIconProp list) = createElement (import "AlbumAddFilled" FluentIcons) props
        static member inline albumAddRegular (props: IIconProp list) = createElement (import "AlbumAddRegular" FluentIcons) props
        static member inline alertFilled (props: IIconProp list) = createElement (import "AlertFilled" FluentIcons) props
        static member inline alertRegular (props: IIconProp list) = createElement (import "AlertRegular" FluentIcons) props
        static member inline alertBadgeFilled (props: IIconProp list) = createElement (import "AlertBadgeFilled" FluentIcons) props
        static member inline alertBadgeRegular (props: IIconProp list) = createElement (import "AlertBadgeRegular" FluentIcons) props
        static member inline alertOffFilled (props: IIconProp list) = createElement (import "AlertOffFilled" FluentIcons) props
        static member inline alertOffRegular (props: IIconProp list) = createElement (import "AlertOffRegular" FluentIcons) props
        static member inline alertOnFilled (props: IIconProp list) = createElement (import "AlertOnFilled" FluentIcons) props
        static member inline alertOnRegular (props: IIconProp list) = createElement (import "AlertOnRegular" FluentIcons) props
        static member inline alertSnoozeFilled (props: IIconProp list) = createElement (import "AlertSnoozeFilled" FluentIcons) props
        static member inline alertSnoozeRegular (props: IIconProp list) = createElement (import "AlertSnoozeRegular" FluentIcons) props
        static member inline alertUrgentFilled (props: IIconProp list) = createElement (import "AlertUrgentFilled" FluentIcons) props
        static member inline alertUrgentRegular (props: IIconProp list) = createElement (import "AlertUrgentRegular" FluentIcons) props
        static member inline alignBottomFilled (props: IIconProp list) = createElement (import "AlignBottomFilled" FluentIcons) props
        static member inline alignBottomRegular (props: IIconProp list) = createElement (import "AlignBottomRegular" FluentIcons) props
        static member inline alignCenterHorizontalFilled (props: IIconProp list) = createElement (import "AlignCenterHorizontalFilled" FluentIcons) props
        static member inline alignCenterHorizontalRegular (props: IIconProp list) = createElement (import "AlignCenterHorizontalRegular" FluentIcons) props
        static member inline alignCenterVerticalFilled (props: IIconProp list) = createElement (import "AlignCenterVerticalFilled" FluentIcons) props
        static member inline alignCenterVerticalRegular (props: IIconProp list) = createElement (import "AlignCenterVerticalRegular" FluentIcons) props
        static member inline alignEndHorizontalFilled (props: IIconProp list) = createElement (import "AlignEndHorizontalFilled" FluentIcons) props
        static member inline alignEndHorizontalRegular (props: IIconProp list) = createElement (import "AlignEndHorizontalRegular" FluentIcons) props
        static member inline alignEndVerticalFilled (props: IIconProp list) = createElement (import "AlignEndVerticalFilled" FluentIcons) props
        static member inline alignEndVerticalRegular (props: IIconProp list) = createElement (import "AlignEndVerticalRegular" FluentIcons) props
        static member inline alignLeftFilled (props: IIconProp list) = createElement (import "AlignLeftFilled" FluentIcons) props
        static member inline alignLeftRegular (props: IIconProp list) = createElement (import "AlignLeftRegular" FluentIcons) props
        static member inline alignRightFilled (props: IIconProp list) = createElement (import "AlignRightFilled" FluentIcons) props
        static member inline alignRightRegular (props: IIconProp list) = createElement (import "AlignRightRegular" FluentIcons) props
        static member inline alignSpaceAroundHorizontalFilled (props: IIconProp list) = createElement (import "AlignSpaceAroundHorizontalFilled" FluentIcons) props
        static member inline alignSpaceAroundHorizontalRegular (props: IIconProp list) = createElement (import "AlignSpaceAroundHorizontalRegular" FluentIcons) props
        static member inline alignSpaceAroundVerticalFilled (props: IIconProp list) = createElement (import "AlignSpaceAroundVerticalFilled" FluentIcons) props
        static member inline alignSpaceAroundVerticalRegular (props: IIconProp list) = createElement (import "AlignSpaceAroundVerticalRegular" FluentIcons) props
        static member inline alignSpaceBetweenHorizontalFilled (props: IIconProp list) = createElement (import "AlignSpaceBetweenHorizontalFilled" FluentIcons) props
        static member inline alignSpaceBetweenHorizontalRegular (props: IIconProp list) = createElement (import "AlignSpaceBetweenHorizontalRegular" FluentIcons) props
        static member inline alignSpaceBetweenVerticalFilled (props: IIconProp list) = createElement (import "AlignSpaceBetweenVerticalFilled" FluentIcons) props
        static member inline alignSpaceBetweenVerticalRegular (props: IIconProp list) = createElement (import "AlignSpaceBetweenVerticalRegular" FluentIcons) props
        static member inline alignSpaceEvenlyHorizontalFilled (props: IIconProp list) = createElement (import "AlignSpaceEvenlyHorizontalFilled" FluentIcons) props
        static member inline alignSpaceEvenlyHorizontalRegular (props: IIconProp list) = createElement (import "AlignSpaceEvenlyHorizontalRegular" FluentIcons) props
        static member inline alignSpaceEvenlyVerticalFilled (props: IIconProp list) = createElement (import "AlignSpaceEvenlyVerticalFilled" FluentIcons) props
        static member inline alignSpaceEvenlyVerticalRegular (props: IIconProp list) = createElement (import "AlignSpaceEvenlyVerticalRegular" FluentIcons) props
        static member inline alignSpaceFitVerticalFilled (props: IIconProp list) = createElement (import "AlignSpaceFitVerticalFilled" FluentIcons) props
        static member inline alignSpaceFitVerticalRegular (props: IIconProp list) = createElement (import "AlignSpaceFitVerticalRegular" FluentIcons) props
        static member inline alignStartHorizontalFilled (props: IIconProp list) = createElement (import "AlignStartHorizontalFilled" FluentIcons) props
        static member inline alignStartHorizontalRegular (props: IIconProp list) = createElement (import "AlignStartHorizontalRegular" FluentIcons) props
        static member inline alignStartVerticalFilled (props: IIconProp list) = createElement (import "AlignStartVerticalFilled" FluentIcons) props
        static member inline alignStartVerticalRegular (props: IIconProp list) = createElement (import "AlignStartVerticalRegular" FluentIcons) props
        static member inline alignStraightenFilled (props: IIconProp list) = createElement (import "AlignStraightenFilled" FluentIcons) props
        static member inline alignStraightenRegular (props: IIconProp list) = createElement (import "AlignStraightenRegular" FluentIcons) props
        static member inline alignStretchHorizontalFilled (props: IIconProp list) = createElement (import "AlignStretchHorizontalFilled" FluentIcons) props
        static member inline alignStretchHorizontalRegular (props: IIconProp list) = createElement (import "AlignStretchHorizontalRegular" FluentIcons) props
        static member inline alignStretchVerticalFilled (props: IIconProp list) = createElement (import "AlignStretchVerticalFilled" FluentIcons) props
        static member inline alignStretchVerticalRegular (props: IIconProp list) = createElement (import "AlignStretchVerticalRegular" FluentIcons) props
        static member inline alignTopFilled (props: IIconProp list) = createElement (import "AlignTopFilled" FluentIcons) props
        static member inline alignTopRegular (props: IIconProp list) = createElement (import "AlignTopRegular" FluentIcons) props
        static member inline animalCatFilled (props: IIconProp list) = createElement (import "AnimalCatFilled" FluentIcons) props
        static member inline animalCatRegular (props: IIconProp list) = createElement (import "AnimalCatRegular" FluentIcons) props
        static member inline animalDogFilled (props: IIconProp list) = createElement (import "AnimalDogFilled" FluentIcons) props
        static member inline animalDogRegular (props: IIconProp list) = createElement (import "AnimalDogRegular" FluentIcons) props
        static member inline animalRabbitFilled (props: IIconProp list) = createElement (import "AnimalRabbitFilled" FluentIcons) props
        static member inline animalRabbitRegular (props: IIconProp list) = createElement (import "AnimalRabbitRegular" FluentIcons) props
        static member inline animalRabbitOffFilled (props: IIconProp list) = createElement (import "AnimalRabbitOffFilled" FluentIcons) props
        static member inline animalRabbitOffRegular (props: IIconProp list) = createElement (import "AnimalRabbitOffRegular" FluentIcons) props
        static member inline animalTurtleFilled (props: IIconProp list) = createElement (import "AnimalTurtleFilled" FluentIcons) props
        static member inline animalTurtleRegular (props: IIconProp list) = createElement (import "AnimalTurtleRegular" FluentIcons) props
        static member inline appFolderFilled (props: IIconProp list) = createElement (import "AppFolderFilled" FluentIcons) props
        static member inline appFolderRegular (props: IIconProp list) = createElement (import "AppFolderRegular" FluentIcons) props
        static member inline appGenericFilled (props: IIconProp list) = createElement (import "AppGenericFilled" FluentIcons) props
        static member inline appGenericRegular (props: IIconProp list) = createElement (import "AppGenericRegular" FluentIcons) props
        static member inline appRecentFilled (props: IIconProp list) = createElement (import "AppRecentFilled" FluentIcons) props
        static member inline appRecentRegular (props: IIconProp list) = createElement (import "AppRecentRegular" FluentIcons) props
        static member inline appTitleFilled (props: IIconProp list) = createElement (import "AppTitleFilled" FluentIcons) props
        static member inline appTitleRegular (props: IIconProp list) = createElement (import "AppTitleRegular" FluentIcons) props
        static member inline approvalsAppFilled (props: IIconProp list) = createElement (import "ApprovalsAppFilled" FluentIcons) props
        static member inline approvalsAppRegular (props: IIconProp list) = createElement (import "ApprovalsAppRegular" FluentIcons) props
        static member inline appsFilled (props: IIconProp list) = createElement (import "AppsFilled" FluentIcons) props
        static member inline appsRegular (props: IIconProp list) = createElement (import "AppsRegular" FluentIcons) props
        static member inline appsAddInFilled (props: IIconProp list) = createElement (import "AppsAddInFilled" FluentIcons) props
        static member inline appsAddInRegular (props: IIconProp list) = createElement (import "AppsAddInRegular" FluentIcons) props
        static member inline appsListFilled (props: IIconProp list) = createElement (import "AppsListFilled" FluentIcons) props
        static member inline appsListRegular (props: IIconProp list) = createElement (import "AppsListRegular" FluentIcons) props
        static member inline appsListDetailFilled (props: IIconProp list) = createElement (import "AppsListDetailFilled" FluentIcons) props
        static member inline appsListDetailRegular (props: IIconProp list) = createElement (import "AppsListDetailRegular" FluentIcons) props
        static member inline appsSettingsFilled (props: IIconProp list) = createElement (import "AppsSettingsFilled" FluentIcons) props
        static member inline appsSettingsRegular (props: IIconProp list) = createElement (import "AppsSettingsRegular" FluentIcons) props
        static member inline appsShieldFilled (props: IIconProp list) = createElement (import "AppsShieldFilled" FluentIcons) props
        static member inline appsShieldRegular (props: IIconProp list) = createElement (import "AppsShieldRegular" FluentIcons) props
        static member inline archiveFilled (props: IIconProp list) = createElement (import "ArchiveFilled" FluentIcons) props
        static member inline archiveRegular (props: IIconProp list) = createElement (import "ArchiveRegular" FluentIcons) props
        static member inline archiveArrowBackFilled (props: IIconProp list) = createElement (import "ArchiveArrowBackFilled" FluentIcons) props
        static member inline archiveArrowBackRegular (props: IIconProp list) = createElement (import "ArchiveArrowBackRegular" FluentIcons) props
        static member inline archiveMultipleFilled (props: IIconProp list) = createElement (import "ArchiveMultipleFilled" FluentIcons) props
        static member inline archiveMultipleRegular (props: IIconProp list) = createElement (import "ArchiveMultipleRegular" FluentIcons) props
        static member inline archiveSettingsFilled (props: IIconProp list) = createElement (import "ArchiveSettingsFilled" FluentIcons) props
        static member inline archiveSettingsRegular (props: IIconProp list) = createElement (import "ArchiveSettingsRegular" FluentIcons) props
        static member inline arrowAutofitContentFilled (props: IIconProp list) = createElement (import "ArrowAutofitContentFilled" FluentIcons) props
        static member inline arrowAutofitContentRegular (props: IIconProp list) = createElement (import "ArrowAutofitContentRegular" FluentIcons) props
        static member inline arrowAutofitDownFilled (props: IIconProp list) = createElement (import "ArrowAutofitDownFilled" FluentIcons) props
        static member inline arrowAutofitDownRegular (props: IIconProp list) = createElement (import "ArrowAutofitDownRegular" FluentIcons) props
        static member inline arrowAutofitHeightFilled (props: IIconProp list) = createElement (import "ArrowAutofitHeightFilled" FluentIcons) props
        static member inline arrowAutofitHeightRegular (props: IIconProp list) = createElement (import "ArrowAutofitHeightRegular" FluentIcons) props
        static member inline arrowAutofitHeightDottedFilled (props: IIconProp list) = createElement (import "ArrowAutofitHeightDottedFilled" FluentIcons) props
        static member inline arrowAutofitHeightDottedRegular (props: IIconProp list) = createElement (import "ArrowAutofitHeightDottedRegular" FluentIcons) props
        static member inline arrowAutofitHeightInFilled (props: IIconProp list) = createElement (import "ArrowAutofitHeightInFilled" FluentIcons) props
        static member inline arrowAutofitHeightInRegular (props: IIconProp list) = createElement (import "ArrowAutofitHeightInRegular" FluentIcons) props
        static member inline arrowAutofitUpFilled (props: IIconProp list) = createElement (import "ArrowAutofitUpFilled" FluentIcons) props
        static member inline arrowAutofitUpRegular (props: IIconProp list) = createElement (import "ArrowAutofitUpRegular" FluentIcons) props
        static member inline arrowAutofitWidthFilled (props: IIconProp list) = createElement (import "ArrowAutofitWidthFilled" FluentIcons) props
        static member inline arrowAutofitWidthRegular (props: IIconProp list) = createElement (import "ArrowAutofitWidthRegular" FluentIcons) props
        static member inline arrowAutofitWidthDottedFilled (props: IIconProp list) = createElement (import "ArrowAutofitWidthDottedFilled" FluentIcons) props
        static member inline arrowAutofitWidthDottedRegular (props: IIconProp list) = createElement (import "ArrowAutofitWidthDottedRegular" FluentIcons) props
        static member inline arrowBetweenDownFilled (props: IIconProp list) = createElement (import "ArrowBetweenDownFilled" FluentIcons) props
        static member inline arrowBetweenDownRegular (props: IIconProp list) = createElement (import "ArrowBetweenDownRegular" FluentIcons) props
        static member inline arrowBetweenUpFilled (props: IIconProp list) = createElement (import "ArrowBetweenUpFilled" FluentIcons) props
        static member inline arrowBetweenUpRegular (props: IIconProp list) = createElement (import "ArrowBetweenUpRegular" FluentIcons) props
        static member inline arrowBidirectionalLeftRightFilled (props: IIconProp list) = createElement (import "ArrowBidirectionalLeftRightFilled" FluentIcons) props
        static member inline arrowBidirectionalLeftRightRegular (props: IIconProp list) = createElement (import "ArrowBidirectionalLeftRightRegular" FluentIcons) props
        static member inline arrowBidirectionalUpDownFilled (props: IIconProp list) = createElement (import "ArrowBidirectionalUpDownFilled" FluentIcons) props
        static member inline arrowBidirectionalUpDownRegular (props: IIconProp list) = createElement (import "ArrowBidirectionalUpDownRegular" FluentIcons) props
        static member inline arrowBounceFilled (props: IIconProp list) = createElement (import "ArrowBounceFilled" FluentIcons) props
        static member inline arrowBounceRegular (props: IIconProp list) = createElement (import "ArrowBounceRegular" FluentIcons) props
        static member inline arrowCircleDownFilled (props: IIconProp list) = createElement (import "ArrowCircleDownFilled" FluentIcons) props
        static member inline arrowCircleDownRegular (props: IIconProp list) = createElement (import "ArrowCircleDownRegular" FluentIcons) props
        static member inline arrowCircleDownDoubleFilled (props: IIconProp list) = createElement (import "ArrowCircleDownDoubleFilled" FluentIcons) props
        static member inline arrowCircleDownDoubleRegular (props: IIconProp list) = createElement (import "ArrowCircleDownDoubleRegular" FluentIcons) props
        static member inline arrowCircleDownRightFilled (props: IIconProp list) = createElement (import "ArrowCircleDownRightFilled" FluentIcons) props
        static member inline arrowCircleDownRightRegular (props: IIconProp list) = createElement (import "ArrowCircleDownRightRegular" FluentIcons) props
        static member inline arrowCircleDownSplitFilled (props: IIconProp list) = createElement (import "ArrowCircleDownSplitFilled" FluentIcons) props
        static member inline arrowCircleDownSplitRegular (props: IIconProp list) = createElement (import "ArrowCircleDownSplitRegular" FluentIcons) props
        static member inline arrowCircleDownUpFilled (props: IIconProp list) = createElement (import "ArrowCircleDownUpFilled" FluentIcons) props
        static member inline arrowCircleDownUpRegular (props: IIconProp list) = createElement (import "ArrowCircleDownUpRegular" FluentIcons) props
        static member inline arrowCircleLeftFilled (props: IIconProp list) = createElement (import "ArrowCircleLeftFilled" FluentIcons) props
        static member inline arrowCircleLeftRegular (props: IIconProp list) = createElement (import "ArrowCircleLeftRegular" FluentIcons) props
        static member inline arrowCircleRightFilled (props: IIconProp list) = createElement (import "ArrowCircleRightFilled" FluentIcons) props
        static member inline arrowCircleRightRegular (props: IIconProp list) = createElement (import "ArrowCircleRightRegular" FluentIcons) props
        static member inline arrowCircleUpFilled (props: IIconProp list) = createElement (import "ArrowCircleUpFilled" FluentIcons) props
        static member inline arrowCircleUpRegular (props: IIconProp list) = createElement (import "ArrowCircleUpRegular" FluentIcons) props
        static member inline arrowCircleUpLeftFilled (props: IIconProp list) = createElement (import "ArrowCircleUpLeftFilled" FluentIcons) props
        static member inline arrowCircleUpLeftRegular (props: IIconProp list) = createElement (import "ArrowCircleUpLeftRegular" FluentIcons) props
        static member inline arrowCircleUpRightFilled (props: IIconProp list) = createElement (import "ArrowCircleUpRightFilled" FluentIcons) props
        static member inline arrowCircleUpRightRegular (props: IIconProp list) = createElement (import "ArrowCircleUpRightRegular" FluentIcons) props
        static member inline arrowClockwiseFilled (props: IIconProp list) = createElement (import "ArrowClockwiseFilled" FluentIcons) props
        static member inline arrowClockwiseRegular (props: IIconProp list) = createElement (import "ArrowClockwiseRegular" FluentIcons) props
        static member inline arrowClockwiseDashesFilled (props: IIconProp list) = createElement (import "ArrowClockwiseDashesFilled" FluentIcons) props
        static member inline arrowClockwiseDashesRegular (props: IIconProp list) = createElement (import "ArrowClockwiseDashesRegular" FluentIcons) props
        static member inline arrowCollapseAllFilled (props: IIconProp list) = createElement (import "ArrowCollapseAllFilled" FluentIcons) props
        static member inline arrowCollapseAllRegular (props: IIconProp list) = createElement (import "ArrowCollapseAllRegular" FluentIcons) props
        static member inline arrowCounterclockwiseFilled (props: IIconProp list) = createElement (import "ArrowCounterclockwiseFilled" FluentIcons) props
        static member inline arrowCounterclockwiseRegular (props: IIconProp list) = createElement (import "ArrowCounterclockwiseRegular" FluentIcons) props
        static member inline arrowCounterclockwiseDashesFilled (props: IIconProp list) = createElement (import "ArrowCounterclockwiseDashesFilled" FluentIcons) props
        static member inline arrowCounterclockwiseDashesRegular (props: IIconProp list) = createElement (import "ArrowCounterclockwiseDashesRegular" FluentIcons) props
        static member inline arrowCurveDownLeftFilled (props: IIconProp list) = createElement (import "ArrowCurveDownLeftFilled" FluentIcons) props
        static member inline arrowCurveDownLeftRegular (props: IIconProp list) = createElement (import "ArrowCurveDownLeftRegular" FluentIcons) props
        static member inline arrowCurveDownRightFilled (props: IIconProp list) = createElement (import "ArrowCurveDownRightFilled" FluentIcons) props
        static member inline arrowCurveDownRightRegular (props: IIconProp list) = createElement (import "ArrowCurveDownRightRegular" FluentIcons) props
        static member inline arrowCurveUpLeftFilled (props: IIconProp list) = createElement (import "ArrowCurveUpLeftFilled" FluentIcons) props
        static member inline arrowCurveUpLeftRegular (props: IIconProp list) = createElement (import "ArrowCurveUpLeftRegular" FluentIcons) props
        static member inline arrowCurveUpRightFilled (props: IIconProp list) = createElement (import "ArrowCurveUpRightFilled" FluentIcons) props
        static member inline arrowCurveUpRightRegular (props: IIconProp list) = createElement (import "ArrowCurveUpRightRegular" FluentIcons) props
        static member inline arrowDownFilled (props: IIconProp list) = createElement (import "ArrowDownFilled" FluentIcons) props
        static member inline arrowDownRegular (props: IIconProp list) = createElement (import "ArrowDownRegular" FluentIcons) props
        static member inline arrowDownExclamationFilled (props: IIconProp list) = createElement (import "ArrowDownExclamationFilled" FluentIcons) props
        static member inline arrowDownExclamationRegular (props: IIconProp list) = createElement (import "ArrowDownExclamationRegular" FluentIcons) props
        static member inline arrowDownLeftFilled (props: IIconProp list) = createElement (import "ArrowDownLeftFilled" FluentIcons) props
        static member inline arrowDownLeftRegular (props: IIconProp list) = createElement (import "ArrowDownLeftRegular" FluentIcons) props
        static member inline arrowDownloadFilled (props: IIconProp list) = createElement (import "ArrowDownloadFilled" FluentIcons) props
        static member inline arrowDownloadRegular (props: IIconProp list) = createElement (import "ArrowDownloadRegular" FluentIcons) props
        static member inline arrowDownloadOffFilled (props: IIconProp list) = createElement (import "ArrowDownloadOffFilled" FluentIcons) props
        static member inline arrowDownloadOffRegular (props: IIconProp list) = createElement (import "ArrowDownloadOffRegular" FluentIcons) props
        static member inline arrowEjectFilled (props: IIconProp list) = createElement (import "ArrowEjectFilled" FluentIcons) props
        static member inline arrowEjectRegular (props: IIconProp list) = createElement (import "ArrowEjectRegular" FluentIcons) props
        static member inline arrowEnterFilled (props: IIconProp list) = createElement (import "ArrowEnterFilled" FluentIcons) props
        static member inline arrowEnterRegular (props: IIconProp list) = createElement (import "ArrowEnterRegular" FluentIcons) props
        static member inline arrowEnterLeftFilled (props: IIconProp list) = createElement (import "ArrowEnterLeftFilled" FluentIcons) props
        static member inline arrowEnterLeftRegular (props: IIconProp list) = createElement (import "ArrowEnterLeftRegular" FluentIcons) props
        static member inline arrowEnterUpFilled (props: IIconProp list) = createElement (import "ArrowEnterUpFilled" FluentIcons) props
        static member inline arrowEnterUpRegular (props: IIconProp list) = createElement (import "ArrowEnterUpRegular" FluentIcons) props
        static member inline arrowExitFilled (props: IIconProp list) = createElement (import "ArrowExitFilled" FluentIcons) props
        static member inline arrowExitRegular (props: IIconProp list) = createElement (import "ArrowExitRegular" FluentIcons) props
        static member inline arrowExpandFilled (props: IIconProp list) = createElement (import "ArrowExpandFilled" FluentIcons) props
        static member inline arrowExpandRegular (props: IIconProp list) = createElement (import "ArrowExpandRegular" FluentIcons) props
        static member inline arrowExpandAllFilled (props: IIconProp list) = createElement (import "ArrowExpandAllFilled" FluentIcons) props
        static member inline arrowExpandAllRegular (props: IIconProp list) = createElement (import "ArrowExpandAllRegular" FluentIcons) props
        static member inline arrowExportFilled (props: IIconProp list) = createElement (import "ArrowExportFilled" FluentIcons) props
        static member inline arrowExportRegular (props: IIconProp list) = createElement (import "ArrowExportRegular" FluentIcons) props
        static member inline arrowExportLtrFilled (props: IIconProp list) = createElement (import "ArrowExportLtrFilled" FluentIcons) props
        static member inline arrowExportLtrRegular (props: IIconProp list) = createElement (import "ArrowExportLtrRegular" FluentIcons) props
        static member inline arrowExportRtlFilled (props: IIconProp list) = createElement (import "ArrowExportRtlFilled" FluentIcons) props
        static member inline arrowExportRtlRegular (props: IIconProp list) = createElement (import "ArrowExportRtlRegular" FluentIcons) props
        static member inline arrowExportUpFilled (props: IIconProp list) = createElement (import "ArrowExportUpFilled" FluentIcons) props
        static member inline arrowExportUpRegular (props: IIconProp list) = createElement (import "ArrowExportUpRegular" FluentIcons) props
        static member inline arrowFitFilled (props: IIconProp list) = createElement (import "ArrowFitFilled" FluentIcons) props
        static member inline arrowFitRegular (props: IIconProp list) = createElement (import "ArrowFitRegular" FluentIcons) props
        static member inline arrowFitInFilled (props: IIconProp list) = createElement (import "ArrowFitInFilled" FluentIcons) props
        static member inline arrowFitInRegular (props: IIconProp list) = createElement (import "ArrowFitInRegular" FluentIcons) props
        static member inline arrowFlowDiagonalUpRightFilled (props: IIconProp list) = createElement (import "ArrowFlowDiagonalUpRightFilled" FluentIcons) props
        static member inline arrowFlowDiagonalUpRightRegular (props: IIconProp list) = createElement (import "ArrowFlowDiagonalUpRightRegular" FluentIcons) props
        static member inline arrowFlowUpRightFilled (props: IIconProp list) = createElement (import "ArrowFlowUpRightFilled" FluentIcons) props
        static member inline arrowFlowUpRightRegular (props: IIconProp list) = createElement (import "ArrowFlowUpRightRegular" FluentIcons) props
        static member inline arrowFlowUpRightRectangleMultipleFilled (props: IIconProp list) = createElement (import "ArrowFlowUpRightRectangleMultipleFilled" FluentIcons) props
        static member inline arrowFlowUpRightRectangleMultipleRegular (props: IIconProp list) = createElement (import "ArrowFlowUpRightRectangleMultipleRegular" FluentIcons) props
        static member inline arrowForwardFilled (props: IIconProp list) = createElement (import "ArrowForwardFilled" FluentIcons) props
        static member inline arrowForwardRegular (props: IIconProp list) = createElement (import "ArrowForwardRegular" FluentIcons) props
        static member inline arrowForwardDownLightningFilled (props: IIconProp list) = createElement (import "ArrowForwardDownLightningFilled" FluentIcons) props
        static member inline arrowForwardDownLightningRegular (props: IIconProp list) = createElement (import "ArrowForwardDownLightningRegular" FluentIcons) props
        static member inline arrowForwardDownPersonFilled (props: IIconProp list) = createElement (import "ArrowForwardDownPersonFilled" FluentIcons) props
        static member inline arrowForwardDownPersonRegular (props: IIconProp list) = createElement (import "ArrowForwardDownPersonRegular" FluentIcons) props
        static member inline arrowHookDownLeftFilled (props: IIconProp list) = createElement (import "ArrowHookDownLeftFilled" FluentIcons) props
        static member inline arrowHookDownLeftRegular (props: IIconProp list) = createElement (import "ArrowHookDownLeftRegular" FluentIcons) props
        static member inline arrowHookDownRightFilled (props: IIconProp list) = createElement (import "ArrowHookDownRightFilled" FluentIcons) props
        static member inline arrowHookDownRightRegular (props: IIconProp list) = createElement (import "ArrowHookDownRightRegular" FluentIcons) props
        static member inline arrowHookUpLeftFilled (props: IIconProp list) = createElement (import "ArrowHookUpLeftFilled" FluentIcons) props
        static member inline arrowHookUpLeftRegular (props: IIconProp list) = createElement (import "ArrowHookUpLeftRegular" FluentIcons) props
        static member inline arrowHookUpRightFilled (props: IIconProp list) = createElement (import "ArrowHookUpRightFilled" FluentIcons) props
        static member inline arrowHookUpRightRegular (props: IIconProp list) = createElement (import "ArrowHookUpRightRegular" FluentIcons) props
        static member inline arrowImportFilled (props: IIconProp list) = createElement (import "ArrowImportFilled" FluentIcons) props
        static member inline arrowImportRegular (props: IIconProp list) = createElement (import "ArrowImportRegular" FluentIcons) props
        static member inline arrowJoinFilled (props: IIconProp list) = createElement (import "ArrowJoinFilled" FluentIcons) props
        static member inline arrowJoinRegular (props: IIconProp list) = createElement (import "ArrowJoinRegular" FluentIcons) props
        static member inline arrowLeftFilled (props: IIconProp list) = createElement (import "ArrowLeftFilled" FluentIcons) props
        static member inline arrowLeftRegular (props: IIconProp list) = createElement (import "ArrowLeftRegular" FluentIcons) props
        static member inline arrowMaximizeFilled (props: IIconProp list) = createElement (import "ArrowMaximizeFilled" FluentIcons) props
        static member inline arrowMaximizeRegular (props: IIconProp list) = createElement (import "ArrowMaximizeRegular" FluentIcons) props
        static member inline arrowMaximizeVerticalFilled (props: IIconProp list) = createElement (import "ArrowMaximizeVerticalFilled" FluentIcons) props
        static member inline arrowMaximizeVerticalRegular (props: IIconProp list) = createElement (import "ArrowMaximizeVerticalRegular" FluentIcons) props
        static member inline arrowMinimizeFilled (props: IIconProp list) = createElement (import "ArrowMinimizeFilled" FluentIcons) props
        static member inline arrowMinimizeRegular (props: IIconProp list) = createElement (import "ArrowMinimizeRegular" FluentIcons) props
        static member inline arrowMinimizeVerticalFilled (props: IIconProp list) = createElement (import "ArrowMinimizeVerticalFilled" FluentIcons) props
        static member inline arrowMinimizeVerticalRegular (props: IIconProp list) = createElement (import "ArrowMinimizeVerticalRegular" FluentIcons) props
        static member inline arrowMoveFilled (props: IIconProp list) = createElement (import "ArrowMoveFilled" FluentIcons) props
        static member inline arrowMoveRegular (props: IIconProp list) = createElement (import "ArrowMoveRegular" FluentIcons) props
        static member inline arrowMoveInwardFilled (props: IIconProp list) = createElement (import "ArrowMoveInwardFilled" FluentIcons) props
        static member inline arrowMoveInwardRegular (props: IIconProp list) = createElement (import "ArrowMoveInwardRegular" FluentIcons) props
        static member inline arrowNextFilled (props: IIconProp list) = createElement (import "ArrowNextFilled" FluentIcons) props
        static member inline arrowNextRegular (props: IIconProp list) = createElement (import "ArrowNextRegular" FluentIcons) props
        static member inline arrowOutlineDownLeftFilled (props: IIconProp list) = createElement (import "ArrowOutlineDownLeftFilled" FluentIcons) props
        static member inline arrowOutlineDownLeftRegular (props: IIconProp list) = createElement (import "ArrowOutlineDownLeftRegular" FluentIcons) props
        static member inline arrowOutlineUpRightFilled (props: IIconProp list) = createElement (import "ArrowOutlineUpRightFilled" FluentIcons) props
        static member inline arrowOutlineUpRightRegular (props: IIconProp list) = createElement (import "ArrowOutlineUpRightRegular" FluentIcons) props
        static member inline arrowParagraphFilled (props: IIconProp list) = createElement (import "ArrowParagraphFilled" FluentIcons) props
        static member inline arrowParagraphRegular (props: IIconProp list) = createElement (import "ArrowParagraphRegular" FluentIcons) props
        static member inline arrowPreviousFilled (props: IIconProp list) = createElement (import "ArrowPreviousFilled" FluentIcons) props
        static member inline arrowPreviousRegular (props: IIconProp list) = createElement (import "ArrowPreviousRegular" FluentIcons) props
        static member inline arrowRedoFilled (props: IIconProp list) = createElement (import "ArrowRedoFilled" FluentIcons) props
        static member inline arrowRedoRegular (props: IIconProp list) = createElement (import "ArrowRedoRegular" FluentIcons) props
        static member inline arrowRepeat1Filled (props: IIconProp list) = createElement (import "ArrowRepeat1Filled" FluentIcons) props
        static member inline arrowRepeat1Regular (props: IIconProp list) = createElement (import "ArrowRepeat1Regular" FluentIcons) props
        static member inline arrowRepeatAllFilled (props: IIconProp list) = createElement (import "ArrowRepeatAllFilled" FluentIcons) props
        static member inline arrowRepeatAllRegular (props: IIconProp list) = createElement (import "ArrowRepeatAllRegular" FluentIcons) props
        static member inline arrowRepeatAllOffFilled (props: IIconProp list) = createElement (import "ArrowRepeatAllOffFilled" FluentIcons) props
        static member inline arrowRepeatAllOffRegular (props: IIconProp list) = createElement (import "ArrowRepeatAllOffRegular" FluentIcons) props
        static member inline arrowReplyFilled (props: IIconProp list) = createElement (import "ArrowReplyFilled" FluentIcons) props
        static member inline arrowReplyRegular (props: IIconProp list) = createElement (import "ArrowReplyRegular" FluentIcons) props
        static member inline arrowReplyAllFilled (props: IIconProp list) = createElement (import "ArrowReplyAllFilled" FluentIcons) props
        static member inline arrowReplyAllRegular (props: IIconProp list) = createElement (import "ArrowReplyAllRegular" FluentIcons) props
        static member inline arrowReplyDownFilled (props: IIconProp list) = createElement (import "ArrowReplyDownFilled" FluentIcons) props
        static member inline arrowReplyDownRegular (props: IIconProp list) = createElement (import "ArrowReplyDownRegular" FluentIcons) props
        static member inline arrowResetFilled (props: IIconProp list) = createElement (import "ArrowResetFilled" FluentIcons) props
        static member inline arrowResetRegular (props: IIconProp list) = createElement (import "ArrowResetRegular" FluentIcons) props
        static member inline arrowRightFilled (props: IIconProp list) = createElement (import "ArrowRightFilled" FluentIcons) props
        static member inline arrowRightRegular (props: IIconProp list) = createElement (import "ArrowRightRegular" FluentIcons) props
        static member inline arrowRotateClockwiseFilled (props: IIconProp list) = createElement (import "ArrowRotateClockwiseFilled" FluentIcons) props
        static member inline arrowRotateClockwiseRegular (props: IIconProp list) = createElement (import "ArrowRotateClockwiseRegular" FluentIcons) props
        static member inline arrowRotateCounterclockwiseFilled (props: IIconProp list) = createElement (import "ArrowRotateCounterclockwiseFilled" FluentIcons) props
        static member inline arrowRotateCounterclockwiseRegular (props: IIconProp list) = createElement (import "ArrowRotateCounterclockwiseRegular" FluentIcons) props
        static member inline arrowRoutingFilled (props: IIconProp list) = createElement (import "ArrowRoutingFilled" FluentIcons) props
        static member inline arrowRoutingRegular (props: IIconProp list) = createElement (import "ArrowRoutingRegular" FluentIcons) props
        static member inline arrowRoutingRectangleMultipleFilled (props: IIconProp list) = createElement (import "ArrowRoutingRectangleMultipleFilled" FluentIcons) props
        static member inline arrowRoutingRectangleMultipleRegular (props: IIconProp list) = createElement (import "ArrowRoutingRectangleMultipleRegular" FluentIcons) props
        static member inline arrowShuffleFilled (props: IIconProp list) = createElement (import "ArrowShuffleFilled" FluentIcons) props
        static member inline arrowShuffleRegular (props: IIconProp list) = createElement (import "ArrowShuffleRegular" FluentIcons) props
        static member inline arrowShuffleOffFilled (props: IIconProp list) = createElement (import "ArrowShuffleOffFilled" FluentIcons) props
        static member inline arrowShuffleOffRegular (props: IIconProp list) = createElement (import "ArrowShuffleOffRegular" FluentIcons) props
        static member inline arrowSortFilled (props: IIconProp list) = createElement (import "ArrowSortFilled" FluentIcons) props
        static member inline arrowSortRegular (props: IIconProp list) = createElement (import "ArrowSortRegular" FluentIcons) props
        static member inline arrowSortDownFilled (props: IIconProp list) = createElement (import "ArrowSortDownFilled" FluentIcons) props
        static member inline arrowSortDownRegular (props: IIconProp list) = createElement (import "ArrowSortDownRegular" FluentIcons) props
        static member inline arrowSortDownLinesFilled (props: IIconProp list) = createElement (import "ArrowSortDownLinesFilled" FluentIcons) props
        static member inline arrowSortDownLinesRegular (props: IIconProp list) = createElement (import "ArrowSortDownLinesRegular" FluentIcons) props
        static member inline arrowSortUpFilled (props: IIconProp list) = createElement (import "ArrowSortUpFilled" FluentIcons) props
        static member inline arrowSortUpRegular (props: IIconProp list) = createElement (import "ArrowSortUpRegular" FluentIcons) props
        static member inline arrowSortUpLinesFilled (props: IIconProp list) = createElement (import "ArrowSortUpLinesFilled" FluentIcons) props
        static member inline arrowSortUpLinesRegular (props: IIconProp list) = createElement (import "ArrowSortUpLinesRegular" FluentIcons) props
        static member inline arrowSplitFilled (props: IIconProp list) = createElement (import "ArrowSplitFilled" FluentIcons) props
        static member inline arrowSplitRegular (props: IIconProp list) = createElement (import "ArrowSplitRegular" FluentIcons) props
        static member inline arrowSprintFilled (props: IIconProp list) = createElement (import "ArrowSprintFilled" FluentIcons) props
        static member inline arrowSprintRegular (props: IIconProp list) = createElement (import "ArrowSprintRegular" FluentIcons) props
        static member inline arrowSquareDownFilled (props: IIconProp list) = createElement (import "ArrowSquareDownFilled" FluentIcons) props
        static member inline arrowSquareDownRegular (props: IIconProp list) = createElement (import "ArrowSquareDownRegular" FluentIcons) props
        static member inline arrowSquareUpRightFilled (props: IIconProp list) = createElement (import "ArrowSquareUpRightFilled" FluentIcons) props
        static member inline arrowSquareUpRightRegular (props: IIconProp list) = createElement (import "ArrowSquareUpRightRegular" FluentIcons) props
        static member inline arrowStepBackFilled (props: IIconProp list) = createElement (import "ArrowStepBackFilled" FluentIcons) props
        static member inline arrowStepBackRegular (props: IIconProp list) = createElement (import "ArrowStepBackRegular" FluentIcons) props
        static member inline arrowStepInFilled (props: IIconProp list) = createElement (import "ArrowStepInFilled" FluentIcons) props
        static member inline arrowStepInRegular (props: IIconProp list) = createElement (import "ArrowStepInRegular" FluentIcons) props
        static member inline arrowStepInDiagonalDownLeftFilled (props: IIconProp list) = createElement (import "ArrowStepInDiagonalDownLeftFilled" FluentIcons) props
        static member inline arrowStepInDiagonalDownLeftRegular (props: IIconProp list) = createElement (import "ArrowStepInDiagonalDownLeftRegular" FluentIcons) props
        static member inline arrowStepInLeftFilled (props: IIconProp list) = createElement (import "ArrowStepInLeftFilled" FluentIcons) props
        static member inline arrowStepInLeftRegular (props: IIconProp list) = createElement (import "ArrowStepInLeftRegular" FluentIcons) props
        static member inline arrowStepInRightFilled (props: IIconProp list) = createElement (import "ArrowStepInRightFilled" FluentIcons) props
        static member inline arrowStepInRightRegular (props: IIconProp list) = createElement (import "ArrowStepInRightRegular" FluentIcons) props
        static member inline arrowStepOutFilled (props: IIconProp list) = createElement (import "ArrowStepOutFilled" FluentIcons) props
        static member inline arrowStepOutRegular (props: IIconProp list) = createElement (import "ArrowStepOutRegular" FluentIcons) props
        static member inline arrowStepOverFilled (props: IIconProp list) = createElement (import "ArrowStepOverFilled" FluentIcons) props
        static member inline arrowStepOverRegular (props: IIconProp list) = createElement (import "ArrowStepOverRegular" FluentIcons) props
        static member inline arrowSwapFilled (props: IIconProp list) = createElement (import "ArrowSwapFilled" FluentIcons) props
        static member inline arrowSwapRegular (props: IIconProp list) = createElement (import "ArrowSwapRegular" FluentIcons) props
        static member inline arrowSyncFilled (props: IIconProp list) = createElement (import "ArrowSyncFilled" FluentIcons) props
        static member inline arrowSyncRegular (props: IIconProp list) = createElement (import "ArrowSyncRegular" FluentIcons) props
        static member inline arrowSyncCheckmarkFilled (props: IIconProp list) = createElement (import "ArrowSyncCheckmarkFilled" FluentIcons) props
        static member inline arrowSyncCheckmarkRegular (props: IIconProp list) = createElement (import "ArrowSyncCheckmarkRegular" FluentIcons) props
        static member inline arrowSyncCircleFilled (props: IIconProp list) = createElement (import "ArrowSyncCircleFilled" FluentIcons) props
        static member inline arrowSyncCircleRegular (props: IIconProp list) = createElement (import "ArrowSyncCircleRegular" FluentIcons) props
        static member inline arrowSyncDismissFilled (props: IIconProp list) = createElement (import "ArrowSyncDismissFilled" FluentIcons) props
        static member inline arrowSyncDismissRegular (props: IIconProp list) = createElement (import "ArrowSyncDismissRegular" FluentIcons) props
        static member inline arrowSyncOffFilled (props: IIconProp list) = createElement (import "ArrowSyncOffFilled" FluentIcons) props
        static member inline arrowSyncOffRegular (props: IIconProp list) = createElement (import "ArrowSyncOffRegular" FluentIcons) props
        static member inline arrowTrendingFilled (props: IIconProp list) = createElement (import "ArrowTrendingFilled" FluentIcons) props
        static member inline arrowTrendingRegular (props: IIconProp list) = createElement (import "ArrowTrendingRegular" FluentIcons) props
        static member inline arrowTrendingCheckmarkFilled (props: IIconProp list) = createElement (import "ArrowTrendingCheckmarkFilled" FluentIcons) props
        static member inline arrowTrendingCheckmarkRegular (props: IIconProp list) = createElement (import "ArrowTrendingCheckmarkRegular" FluentIcons) props
        static member inline arrowTrendingDownFilled (props: IIconProp list) = createElement (import "ArrowTrendingDownFilled" FluentIcons) props
        static member inline arrowTrendingDownRegular (props: IIconProp list) = createElement (import "ArrowTrendingDownRegular" FluentIcons) props
        static member inline arrowTrendingLinesFilled (props: IIconProp list) = createElement (import "ArrowTrendingLinesFilled" FluentIcons) props
        static member inline arrowTrendingLinesRegular (props: IIconProp list) = createElement (import "ArrowTrendingLinesRegular" FluentIcons) props
        static member inline arrowTrendingSettingsFilled (props: IIconProp list) = createElement (import "ArrowTrendingSettingsFilled" FluentIcons) props
        static member inline arrowTrendingSettingsRegular (props: IIconProp list) = createElement (import "ArrowTrendingSettingsRegular" FluentIcons) props
        static member inline arrowTrendingSparkleFilled (props: IIconProp list) = createElement (import "ArrowTrendingSparkleFilled" FluentIcons) props
        static member inline arrowTrendingSparkleRegular (props: IIconProp list) = createElement (import "ArrowTrendingSparkleRegular" FluentIcons) props
        static member inline arrowTrendingTextFilled (props: IIconProp list) = createElement (import "ArrowTrendingTextFilled" FluentIcons) props
        static member inline arrowTrendingTextRegular (props: IIconProp list) = createElement (import "ArrowTrendingTextRegular" FluentIcons) props
        static member inline arrowTrendingWrenchFilled (props: IIconProp list) = createElement (import "ArrowTrendingWrenchFilled" FluentIcons) props
        static member inline arrowTrendingWrenchRegular (props: IIconProp list) = createElement (import "ArrowTrendingWrenchRegular" FluentIcons) props
        static member inline arrowTurnBidirectionalDownRightFilled (props: IIconProp list) = createElement (import "ArrowTurnBidirectionalDownRightFilled" FluentIcons) props
        static member inline arrowTurnBidirectionalDownRightRegular (props: IIconProp list) = createElement (import "ArrowTurnBidirectionalDownRightRegular" FluentIcons) props
        static member inline arrowTurnDownLeftFilled (props: IIconProp list) = createElement (import "ArrowTurnDownLeftFilled" FluentIcons) props
        static member inline arrowTurnDownLeftRegular (props: IIconProp list) = createElement (import "ArrowTurnDownLeftRegular" FluentIcons) props
        static member inline arrowTurnDownRightFilled (props: IIconProp list) = createElement (import "ArrowTurnDownRightFilled" FluentIcons) props
        static member inline arrowTurnDownRightRegular (props: IIconProp list) = createElement (import "ArrowTurnDownRightRegular" FluentIcons) props
        static member inline arrowTurnDownUpFilled (props: IIconProp list) = createElement (import "ArrowTurnDownUpFilled" FluentIcons) props
        static member inline arrowTurnDownUpRegular (props: IIconProp list) = createElement (import "ArrowTurnDownUpRegular" FluentIcons) props
        static member inline arrowTurnLeftDownFilled (props: IIconProp list) = createElement (import "ArrowTurnLeftDownFilled" FluentIcons) props
        static member inline arrowTurnLeftDownRegular (props: IIconProp list) = createElement (import "ArrowTurnLeftDownRegular" FluentIcons) props
        static member inline arrowTurnLeftRightFilled (props: IIconProp list) = createElement (import "ArrowTurnLeftRightFilled" FluentIcons) props
        static member inline arrowTurnLeftRightRegular (props: IIconProp list) = createElement (import "ArrowTurnLeftRightRegular" FluentIcons) props
        static member inline arrowTurnLeftUpFilled (props: IIconProp list) = createElement (import "ArrowTurnLeftUpFilled" FluentIcons) props
        static member inline arrowTurnLeftUpRegular (props: IIconProp list) = createElement (import "ArrowTurnLeftUpRegular" FluentIcons) props
        static member inline arrowTurnRightFilled (props: IIconProp list) = createElement (import "ArrowTurnRightFilled" FluentIcons) props
        static member inline arrowTurnRightRegular (props: IIconProp list) = createElement (import "ArrowTurnRightRegular" FluentIcons) props
        static member inline arrowTurnRightDownFilled (props: IIconProp list) = createElement (import "ArrowTurnRightDownFilled" FluentIcons) props
        static member inline arrowTurnRightDownRegular (props: IIconProp list) = createElement (import "ArrowTurnRightDownRegular" FluentIcons) props
        static member inline arrowTurnRightLeftFilled (props: IIconProp list) = createElement (import "ArrowTurnRightLeftFilled" FluentIcons) props
        static member inline arrowTurnRightLeftRegular (props: IIconProp list) = createElement (import "ArrowTurnRightLeftRegular" FluentIcons) props
        static member inline arrowTurnRightUpFilled (props: IIconProp list) = createElement (import "ArrowTurnRightUpFilled" FluentIcons) props
        static member inline arrowTurnRightUpRegular (props: IIconProp list) = createElement (import "ArrowTurnRightUpRegular" FluentIcons) props
        static member inline arrowTurnUpDownFilled (props: IIconProp list) = createElement (import "ArrowTurnUpDownFilled" FluentIcons) props
        static member inline arrowTurnUpDownRegular (props: IIconProp list) = createElement (import "ArrowTurnUpDownRegular" FluentIcons) props
        static member inline arrowTurnUpLeftFilled (props: IIconProp list) = createElement (import "ArrowTurnUpLeftFilled" FluentIcons) props
        static member inline arrowTurnUpLeftRegular (props: IIconProp list) = createElement (import "ArrowTurnUpLeftRegular" FluentIcons) props
        static member inline arrowUndoFilled (props: IIconProp list) = createElement (import "ArrowUndoFilled" FluentIcons) props
        static member inline arrowUndoRegular (props: IIconProp list) = createElement (import "ArrowUndoRegular" FluentIcons) props
        static member inline arrowUpFilled (props: IIconProp list) = createElement (import "ArrowUpFilled" FluentIcons) props
        static member inline arrowUpRegular (props: IIconProp list) = createElement (import "ArrowUpRegular" FluentIcons) props
        static member inline arrowUpExclamationFilled (props: IIconProp list) = createElement (import "ArrowUpExclamationFilled" FluentIcons) props
        static member inline arrowUpExclamationRegular (props: IIconProp list) = createElement (import "ArrowUpExclamationRegular" FluentIcons) props
        static member inline arrowUpLeftFilled (props: IIconProp list) = createElement (import "ArrowUpLeftFilled" FluentIcons) props
        static member inline arrowUpLeftRegular (props: IIconProp list) = createElement (import "ArrowUpLeftRegular" FluentIcons) props
        static member inline arrowUpRightFilled (props: IIconProp list) = createElement (import "ArrowUpRightFilled" FluentIcons) props
        static member inline arrowUpRightRegular (props: IIconProp list) = createElement (import "ArrowUpRightRegular" FluentIcons) props
        static member inline arrowUploadFilled (props: IIconProp list) = createElement (import "ArrowUploadFilled" FluentIcons) props
        static member inline arrowUploadRegular (props: IIconProp list) = createElement (import "ArrowUploadRegular" FluentIcons) props
        static member inline arrowWrapFilled (props: IIconProp list) = createElement (import "ArrowWrapFilled" FluentIcons) props
        static member inline arrowWrapRegular (props: IIconProp list) = createElement (import "ArrowWrapRegular" FluentIcons) props
        static member inline arrowWrapOffFilled (props: IIconProp list) = createElement (import "ArrowWrapOffFilled" FluentIcons) props
        static member inline arrowWrapOffRegular (props: IIconProp list) = createElement (import "ArrowWrapOffRegular" FluentIcons) props
        static member inline arrowsBidirectionalFilled (props: IIconProp list) = createElement (import "ArrowsBidirectionalFilled" FluentIcons) props
        static member inline arrowsBidirectionalRegular (props: IIconProp list) = createElement (import "ArrowsBidirectionalRegular" FluentIcons) props
        static member inline attachFilled (props: IIconProp list) = createElement (import "AttachFilled" FluentIcons) props
        static member inline attachRegular (props: IIconProp list) = createElement (import "AttachRegular" FluentIcons) props
        static member inline attachArrowRightFilled (props: IIconProp list) = createElement (import "AttachArrowRightFilled" FluentIcons) props
        static member inline attachArrowRightRegular (props: IIconProp list) = createElement (import "AttachArrowRightRegular" FluentIcons) props
        static member inline attachTextFilled (props: IIconProp list) = createElement (import "AttachTextFilled" FluentIcons) props
        static member inline attachTextRegular (props: IIconProp list) = createElement (import "AttachTextRegular" FluentIcons) props
        static member inline autoFitHeightFilled (props: IIconProp list) = createElement (import "AutoFitHeightFilled" FluentIcons) props
        static member inline autoFitHeightRegular (props: IIconProp list) = createElement (import "AutoFitHeightRegular" FluentIcons) props
        static member inline autoFitWidthFilled (props: IIconProp list) = createElement (import "AutoFitWidthFilled" FluentIcons) props
        static member inline autoFitWidthRegular (props: IIconProp list) = createElement (import "AutoFitWidthRegular" FluentIcons) props
        static member inline autocorrectFilled (props: IIconProp list) = createElement (import "AutocorrectFilled" FluentIcons) props
        static member inline autocorrectRegular (props: IIconProp list) = createElement (import "AutocorrectRegular" FluentIcons) props
        static member inline autosumFilled (props: IIconProp list) = createElement (import "AutosumFilled" FluentIcons) props
        static member inline autosumRegular (props: IIconProp list) = createElement (import "AutosumRegular" FluentIcons) props
        static member inline backpackFilled (props: IIconProp list) = createElement (import "BackpackFilled" FluentIcons) props
        static member inline backpackRegular (props: IIconProp list) = createElement (import "BackpackRegular" FluentIcons) props
        static member inline backpackAddFilled (props: IIconProp list) = createElement (import "BackpackAddFilled" FluentIcons) props
        static member inline backpackAddRegular (props: IIconProp list) = createElement (import "BackpackAddRegular" FluentIcons) props
        static member inline backspaceFilled (props: IIconProp list) = createElement (import "BackspaceFilled" FluentIcons) props
        static member inline backspaceRegular (props: IIconProp list) = createElement (import "BackspaceRegular" FluentIcons) props
        static member inline badgeFilled (props: IIconProp list) = createElement (import "BadgeFilled" FluentIcons) props
        static member inline badgeRegular (props: IIconProp list) = createElement (import "BadgeRegular" FluentIcons) props
        static member inline balloonFilled (props: IIconProp list) = createElement (import "BalloonFilled" FluentIcons) props
        static member inline balloonRegular (props: IIconProp list) = createElement (import "BalloonRegular" FluentIcons) props
        static member inline barcodeScannerFilled (props: IIconProp list) = createElement (import "BarcodeScannerFilled" FluentIcons) props
        static member inline barcodeScannerRegular (props: IIconProp list) = createElement (import "BarcodeScannerRegular" FluentIcons) props
        static member inline battery0Filled (props: IIconProp list) = createElement (import "Battery0Filled" FluentIcons) props
        static member inline battery0Regular (props: IIconProp list) = createElement (import "Battery0Regular" FluentIcons) props
        static member inline battery10Filled (props: IIconProp list) = createElement (import "Battery10Filled" FluentIcons) props
        static member inline battery10Regular (props: IIconProp list) = createElement (import "Battery10Regular" FluentIcons) props
        static member inline battery1Filled (props: IIconProp list) = createElement (import "Battery1Filled" FluentIcons) props
        static member inline battery1Regular (props: IIconProp list) = createElement (import "Battery1Regular" FluentIcons) props
        static member inline battery2Filled (props: IIconProp list) = createElement (import "Battery2Filled" FluentIcons) props
        static member inline battery2Regular (props: IIconProp list) = createElement (import "Battery2Regular" FluentIcons) props
        static member inline battery3Filled (props: IIconProp list) = createElement (import "Battery3Filled" FluentIcons) props
        static member inline battery3Regular (props: IIconProp list) = createElement (import "Battery3Regular" FluentIcons) props
        static member inline battery4Filled (props: IIconProp list) = createElement (import "Battery4Filled" FluentIcons) props
        static member inline battery4Regular (props: IIconProp list) = createElement (import "Battery4Regular" FluentIcons) props
        static member inline battery5Filled (props: IIconProp list) = createElement (import "Battery5Filled" FluentIcons) props
        static member inline battery5Regular (props: IIconProp list) = createElement (import "Battery5Regular" FluentIcons) props
        static member inline battery6Filled (props: IIconProp list) = createElement (import "Battery6Filled" FluentIcons) props
        static member inline battery6Regular (props: IIconProp list) = createElement (import "Battery6Regular" FluentIcons) props
        static member inline battery7Filled (props: IIconProp list) = createElement (import "Battery7Filled" FluentIcons) props
        static member inline battery7Regular (props: IIconProp list) = createElement (import "Battery7Regular" FluentIcons) props
        static member inline battery8Filled (props: IIconProp list) = createElement (import "Battery8Filled" FluentIcons) props
        static member inline battery8Regular (props: IIconProp list) = createElement (import "Battery8Regular" FluentIcons) props
        static member inline battery9Filled (props: IIconProp list) = createElement (import "Battery9Filled" FluentIcons) props
        static member inline battery9Regular (props: IIconProp list) = createElement (import "Battery9Regular" FluentIcons) props
        static member inline batteryChargeFilled (props: IIconProp list) = createElement (import "BatteryChargeFilled" FluentIcons) props
        static member inline batteryChargeRegular (props: IIconProp list) = createElement (import "BatteryChargeRegular" FluentIcons) props
        static member inline batteryCheckmarkFilled (props: IIconProp list) = createElement (import "BatteryCheckmarkFilled" FluentIcons) props
        static member inline batteryCheckmarkRegular (props: IIconProp list) = createElement (import "BatteryCheckmarkRegular" FluentIcons) props
        static member inline batterySaverFilled (props: IIconProp list) = createElement (import "BatterySaverFilled" FluentIcons) props
        static member inline batterySaverRegular (props: IIconProp list) = createElement (import "BatterySaverRegular" FluentIcons) props
        static member inline batteryWarningFilled (props: IIconProp list) = createElement (import "BatteryWarningFilled" FluentIcons) props
        static member inline batteryWarningRegular (props: IIconProp list) = createElement (import "BatteryWarningRegular" FluentIcons) props
        static member inline beachFilled (props: IIconProp list) = createElement (import "BeachFilled" FluentIcons) props
        static member inline beachRegular (props: IIconProp list) = createElement (import "BeachRegular" FluentIcons) props
        static member inline beakerFilled (props: IIconProp list) = createElement (import "BeakerFilled" FluentIcons) props
        static member inline beakerRegular (props: IIconProp list) = createElement (import "BeakerRegular" FluentIcons) props
        static member inline beakerAddFilled (props: IIconProp list) = createElement (import "BeakerAddFilled" FluentIcons) props
        static member inline beakerAddRegular (props: IIconProp list) = createElement (import "BeakerAddRegular" FluentIcons) props
        static member inline beakerDismissFilled (props: IIconProp list) = createElement (import "BeakerDismissFilled" FluentIcons) props
        static member inline beakerDismissRegular (props: IIconProp list) = createElement (import "BeakerDismissRegular" FluentIcons) props
        static member inline beakerEditFilled (props: IIconProp list) = createElement (import "BeakerEditFilled" FluentIcons) props
        static member inline beakerEditRegular (props: IIconProp list) = createElement (import "BeakerEditRegular" FluentIcons) props
        static member inline beakerOffFilled (props: IIconProp list) = createElement (import "BeakerOffFilled" FluentIcons) props
        static member inline beakerOffRegular (props: IIconProp list) = createElement (import "BeakerOffRegular" FluentIcons) props
        static member inline beakerSettingsFilled (props: IIconProp list) = createElement (import "BeakerSettingsFilled" FluentIcons) props
        static member inline beakerSettingsRegular (props: IIconProp list) = createElement (import "BeakerSettingsRegular" FluentIcons) props
        static member inline bedFilled (props: IIconProp list) = createElement (import "BedFilled" FluentIcons) props
        static member inline bedRegular (props: IIconProp list) = createElement (import "BedRegular" FluentIcons) props
        static member inline benchFilled (props: IIconProp list) = createElement (import "BenchFilled" FluentIcons) props
        static member inline benchRegular (props: IIconProp list) = createElement (import "BenchRegular" FluentIcons) props
        static member inline bezierCurveSquareFilled (props: IIconProp list) = createElement (import "BezierCurveSquareFilled" FluentIcons) props
        static member inline bezierCurveSquareRegular (props: IIconProp list) = createElement (import "BezierCurveSquareRegular" FluentIcons) props
        static member inline binFullFilled (props: IIconProp list) = createElement (import "BinFullFilled" FluentIcons) props
        static member inline binFullRegular (props: IIconProp list) = createElement (import "BinFullRegular" FluentIcons) props
        static member inline binRecycleFilled (props: IIconProp list) = createElement (import "BinRecycleFilled" FluentIcons) props
        static member inline binRecycleRegular (props: IIconProp list) = createElement (import "BinRecycleRegular" FluentIcons) props
        static member inline binRecycleFullFilled (props: IIconProp list) = createElement (import "BinRecycleFullFilled" FluentIcons) props
        static member inline binRecycleFullRegular (props: IIconProp list) = createElement (import "BinRecycleFullRegular" FluentIcons) props
        static member inline binderTriangleFilled (props: IIconProp list) = createElement (import "BinderTriangleFilled" FluentIcons) props
        static member inline binderTriangleRegular (props: IIconProp list) = createElement (import "BinderTriangleRegular" FluentIcons) props
        static member inline bluetoothFilled (props: IIconProp list) = createElement (import "BluetoothFilled" FluentIcons) props
        static member inline bluetoothRegular (props: IIconProp list) = createElement (import "BluetoothRegular" FluentIcons) props
        static member inline bluetoothConnectedFilled (props: IIconProp list) = createElement (import "BluetoothConnectedFilled" FluentIcons) props
        static member inline bluetoothConnectedRegular (props: IIconProp list) = createElement (import "BluetoothConnectedRegular" FluentIcons) props
        static member inline bluetoothDisabledFilled (props: IIconProp list) = createElement (import "BluetoothDisabledFilled" FluentIcons) props
        static member inline bluetoothDisabledRegular (props: IIconProp list) = createElement (import "BluetoothDisabledRegular" FluentIcons) props
        static member inline bluetoothSearchingFilled (props: IIconProp list) = createElement (import "BluetoothSearchingFilled" FluentIcons) props
        static member inline bluetoothSearchingRegular (props: IIconProp list) = createElement (import "BluetoothSearchingRegular" FluentIcons) props
        static member inline blurFilled (props: IIconProp list) = createElement (import "BlurFilled" FluentIcons) props
        static member inline blurRegular (props: IIconProp list) = createElement (import "BlurRegular" FluentIcons) props
        static member inline boardFilled (props: IIconProp list) = createElement (import "BoardFilled" FluentIcons) props
        static member inline boardRegular (props: IIconProp list) = createElement (import "BoardRegular" FluentIcons) props
        static member inline boardGamesFilled (props: IIconProp list) = createElement (import "BoardGamesFilled" FluentIcons) props
        static member inline boardGamesRegular (props: IIconProp list) = createElement (import "BoardGamesRegular" FluentIcons) props
        static member inline boardHeartFilled (props: IIconProp list) = createElement (import "BoardHeartFilled" FluentIcons) props
        static member inline boardHeartRegular (props: IIconProp list) = createElement (import "BoardHeartRegular" FluentIcons) props
        static member inline boardSplitFilled (props: IIconProp list) = createElement (import "BoardSplitFilled" FluentIcons) props
        static member inline boardSplitRegular (props: IIconProp list) = createElement (import "BoardSplitRegular" FluentIcons) props
        static member inline bookFilled (props: IIconProp list) = createElement (import "BookFilled" FluentIcons) props
        static member inline bookRegular (props: IIconProp list) = createElement (import "BookRegular" FluentIcons) props
        static member inline bookAddFilled (props: IIconProp list) = createElement (import "BookAddFilled" FluentIcons) props
        static member inline bookAddRegular (props: IIconProp list) = createElement (import "BookAddRegular" FluentIcons) props
        static member inline bookArrowClockwiseFilled (props: IIconProp list) = createElement (import "BookArrowClockwiseFilled" FluentIcons) props
        static member inline bookArrowClockwiseRegular (props: IIconProp list) = createElement (import "BookArrowClockwiseRegular" FluentIcons) props
        static member inline bookClockFilled (props: IIconProp list) = createElement (import "BookClockFilled" FluentIcons) props
        static member inline bookClockRegular (props: IIconProp list) = createElement (import "BookClockRegular" FluentIcons) props
        static member inline bookCoinsFilled (props: IIconProp list) = createElement (import "BookCoinsFilled" FluentIcons) props
        static member inline bookCoinsRegular (props: IIconProp list) = createElement (import "BookCoinsRegular" FluentIcons) props
        static member inline bookCompassFilled (props: IIconProp list) = createElement (import "BookCompassFilled" FluentIcons) props
        static member inline bookCompassRegular (props: IIconProp list) = createElement (import "BookCompassRegular" FluentIcons) props
        static member inline bookContactsFilled (props: IIconProp list) = createElement (import "BookContactsFilled" FluentIcons) props
        static member inline bookContactsRegular (props: IIconProp list) = createElement (import "BookContactsRegular" FluentIcons) props
        static member inline bookDatabaseFilled (props: IIconProp list) = createElement (import "BookDatabaseFilled" FluentIcons) props
        static member inline bookDatabaseRegular (props: IIconProp list) = createElement (import "BookDatabaseRegular" FluentIcons) props
        static member inline bookDefaultFilled (props: IIconProp list) = createElement (import "BookDefaultFilled" FluentIcons) props
        static member inline bookDismissFilled (props: IIconProp list) = createElement (import "BookDismissFilled" FluentIcons) props
        static member inline bookDismissRegular (props: IIconProp list) = createElement (import "BookDismissRegular" FluentIcons) props
        static member inline bookExclamationMarkFilled (props: IIconProp list) = createElement (import "BookExclamationMarkFilled" FluentIcons) props
        static member inline bookExclamationMarkRegular (props: IIconProp list) = createElement (import "BookExclamationMarkRegular" FluentIcons) props
        static member inline bookGlobeFilled (props: IIconProp list) = createElement (import "BookGlobeFilled" FluentIcons) props
        static member inline bookGlobeRegular (props: IIconProp list) = createElement (import "BookGlobeRegular" FluentIcons) props
        static member inline bookInformationFilled (props: IIconProp list) = createElement (import "BookInformationFilled" FluentIcons) props
        static member inline bookInformationRegular (props: IIconProp list) = createElement (import "BookInformationRegular" FluentIcons) props
        static member inline bookLetterFilled (props: IIconProp list) = createElement (import "BookLetterFilled" FluentIcons) props
        static member inline bookLetterRegular (props: IIconProp list) = createElement (import "BookLetterRegular" FluentIcons) props
        static member inline bookNumberFilled (props: IIconProp list) = createElement (import "BookNumberFilled" FluentIcons) props
        static member inline bookNumberRegular (props: IIconProp list) = createElement (import "BookNumberRegular" FluentIcons) props
        static member inline bookOpenFilled (props: IIconProp list) = createElement (import "BookOpenFilled" FluentIcons) props
        static member inline bookOpenRegular (props: IIconProp list) = createElement (import "BookOpenRegular" FluentIcons) props
        static member inline bookOpenGlobeFilled (props: IIconProp list) = createElement (import "BookOpenGlobeFilled" FluentIcons) props
        static member inline bookOpenGlobeRegular (props: IIconProp list) = createElement (import "BookOpenGlobeRegular" FluentIcons) props
        static member inline bookOpenMicrophoneFilled (props: IIconProp list) = createElement (import "BookOpenMicrophoneFilled" FluentIcons) props
        static member inline bookOpenMicrophoneRegular (props: IIconProp list) = createElement (import "BookOpenMicrophoneRegular" FluentIcons) props
        static member inline bookPulseFilled (props: IIconProp list) = createElement (import "BookPulseFilled" FluentIcons) props
        static member inline bookPulseRegular (props: IIconProp list) = createElement (import "BookPulseRegular" FluentIcons) props
        static member inline bookQuestionMarkFilled (props: IIconProp list) = createElement (import "BookQuestionMarkFilled" FluentIcons) props
        static member inline bookQuestionMarkRegular (props: IIconProp list) = createElement (import "BookQuestionMarkRegular" FluentIcons) props
        static member inline bookQuestionMarkRtlFilled (props: IIconProp list) = createElement (import "BookQuestionMarkRtlFilled" FluentIcons) props
        static member inline bookQuestionMarkRtlRegular (props: IIconProp list) = createElement (import "BookQuestionMarkRtlRegular" FluentIcons) props
        static member inline bookSearchFilled (props: IIconProp list) = createElement (import "BookSearchFilled" FluentIcons) props
        static member inline bookSearchRegular (props: IIconProp list) = createElement (import "BookSearchRegular" FluentIcons) props
        static member inline bookStarFilled (props: IIconProp list) = createElement (import "BookStarFilled" FluentIcons) props
        static member inline bookStarRegular (props: IIconProp list) = createElement (import "BookStarRegular" FluentIcons) props
        static member inline bookTemplateFilled (props: IIconProp list) = createElement (import "BookTemplateFilled" FluentIcons) props
        static member inline bookTemplateRegular (props: IIconProp list) = createElement (import "BookTemplateRegular" FluentIcons) props
        static member inline bookThetaFilled (props: IIconProp list) = createElement (import "BookThetaFilled" FluentIcons) props
        static member inline bookThetaRegular (props: IIconProp list) = createElement (import "BookThetaRegular" FluentIcons) props
        static member inline bookToolboxFilled (props: IIconProp list) = createElement (import "BookToolboxFilled" FluentIcons) props
        static member inline bookToolboxRegular (props: IIconProp list) = createElement (import "BookToolboxRegular" FluentIcons) props
        static member inline bookmarkFilled (props: IIconProp list) = createElement (import "BookmarkFilled" FluentIcons) props
        static member inline bookmarkRegular (props: IIconProp list) = createElement (import "BookmarkRegular" FluentIcons) props
        static member inline bookmarkAddFilled (props: IIconProp list) = createElement (import "BookmarkAddFilled" FluentIcons) props
        static member inline bookmarkAddRegular (props: IIconProp list) = createElement (import "BookmarkAddRegular" FluentIcons) props
        static member inline bookmarkMultipleFilled (props: IIconProp list) = createElement (import "BookmarkMultipleFilled" FluentIcons) props
        static member inline bookmarkMultipleRegular (props: IIconProp list) = createElement (import "BookmarkMultipleRegular" FluentIcons) props
        static member inline bookmarkOffFilled (props: IIconProp list) = createElement (import "BookmarkOffFilled" FluentIcons) props
        static member inline bookmarkOffRegular (props: IIconProp list) = createElement (import "BookmarkOffRegular" FluentIcons) props
        static member inline bookmarkSearchFilled (props: IIconProp list) = createElement (import "BookmarkSearchFilled" FluentIcons) props
        static member inline bookmarkSearchRegular (props: IIconProp list) = createElement (import "BookmarkSearchRegular" FluentIcons) props
        static member inline borderAllFilled (props: IIconProp list) = createElement (import "BorderAllFilled" FluentIcons) props
        static member inline borderAllRegular (props: IIconProp list) = createElement (import "BorderAllRegular" FluentIcons) props
        static member inline borderBottomFilled (props: IIconProp list) = createElement (import "BorderBottomFilled" FluentIcons) props
        static member inline borderBottomRegular (props: IIconProp list) = createElement (import "BorderBottomRegular" FluentIcons) props
        static member inline borderBottomDoubleFilled (props: IIconProp list) = createElement (import "BorderBottomDoubleFilled" FluentIcons) props
        static member inline borderBottomDoubleRegular (props: IIconProp list) = createElement (import "BorderBottomDoubleRegular" FluentIcons) props
        static member inline borderBottomThickFilled (props: IIconProp list) = createElement (import "BorderBottomThickFilled" FluentIcons) props
        static member inline borderBottomThickRegular (props: IIconProp list) = createElement (import "BorderBottomThickRegular" FluentIcons) props
        static member inline borderInsideFilled (props: IIconProp list) = createElement (import "BorderInsideFilled" FluentIcons) props
        static member inline borderInsideRegular (props: IIconProp list) = createElement (import "BorderInsideRegular" FluentIcons) props
        static member inline borderLeftFilled (props: IIconProp list) = createElement (import "BorderLeftFilled" FluentIcons) props
        static member inline borderLeftRegular (props: IIconProp list) = createElement (import "BorderLeftRegular" FluentIcons) props
        static member inline borderLeftRightFilled (props: IIconProp list) = createElement (import "BorderLeftRightFilled" FluentIcons) props
        static member inline borderLeftRightRegular (props: IIconProp list) = createElement (import "BorderLeftRightRegular" FluentIcons) props
        static member inline borderNoneFilled (props: IIconProp list) = createElement (import "BorderNoneFilled" FluentIcons) props
        static member inline borderNoneRegular (props: IIconProp list) = createElement (import "BorderNoneRegular" FluentIcons) props
        static member inline borderOutsideFilled (props: IIconProp list) = createElement (import "BorderOutsideFilled" FluentIcons) props
        static member inline borderOutsideRegular (props: IIconProp list) = createElement (import "BorderOutsideRegular" FluentIcons) props
        static member inline borderOutsideThickFilled (props: IIconProp list) = createElement (import "BorderOutsideThickFilled" FluentIcons) props
        static member inline borderOutsideThickRegular (props: IIconProp list) = createElement (import "BorderOutsideThickRegular" FluentIcons) props
        static member inline borderRightFilled (props: IIconProp list) = createElement (import "BorderRightFilled" FluentIcons) props
        static member inline borderRightRegular (props: IIconProp list) = createElement (import "BorderRightRegular" FluentIcons) props
        static member inline borderTopFilled (props: IIconProp list) = createElement (import "BorderTopFilled" FluentIcons) props
        static member inline borderTopRegular (props: IIconProp list) = createElement (import "BorderTopRegular" FluentIcons) props
        static member inline borderTopBottomFilled (props: IIconProp list) = createElement (import "BorderTopBottomFilled" FluentIcons) props
        static member inline borderTopBottomRegular (props: IIconProp list) = createElement (import "BorderTopBottomRegular" FluentIcons) props
        static member inline borderTopBottomDoubleFilled (props: IIconProp list) = createElement (import "BorderTopBottomDoubleFilled" FluentIcons) props
        static member inline borderTopBottomDoubleRegular (props: IIconProp list) = createElement (import "BorderTopBottomDoubleRegular" FluentIcons) props
        static member inline borderTopBottomThickFilled (props: IIconProp list) = createElement (import "BorderTopBottomThickFilled" FluentIcons) props
        static member inline borderTopBottomThickRegular (props: IIconProp list) = createElement (import "BorderTopBottomThickRegular" FluentIcons) props
        static member inline botFilled (props: IIconProp list) = createElement (import "BotFilled" FluentIcons) props
        static member inline botRegular (props: IIconProp list) = createElement (import "BotRegular" FluentIcons) props
        static member inline botAddFilled (props: IIconProp list) = createElement (import "BotAddFilled" FluentIcons) props
        static member inline botAddRegular (props: IIconProp list) = createElement (import "BotAddRegular" FluentIcons) props
        static member inline botSparkleFilled (props: IIconProp list) = createElement (import "BotSparkleFilled" FluentIcons) props
        static member inline botSparkleRegular (props: IIconProp list) = createElement (import "BotSparkleRegular" FluentIcons) props
        static member inline bowTieFilled (props: IIconProp list) = createElement (import "BowTieFilled" FluentIcons) props
        static member inline bowTieRegular (props: IIconProp list) = createElement (import "BowTieRegular" FluentIcons) props
        static member inline bowlChopsticksFilled (props: IIconProp list) = createElement (import "BowlChopsticksFilled" FluentIcons) props
        static member inline bowlChopsticksRegular (props: IIconProp list) = createElement (import "BowlChopsticksRegular" FluentIcons) props
        static member inline bowlSaladFilled (props: IIconProp list) = createElement (import "BowlSaladFilled" FluentIcons) props
        static member inline bowlSaladRegular (props: IIconProp list) = createElement (import "BowlSaladRegular" FluentIcons) props
        static member inline boxFilled (props: IIconProp list) = createElement (import "BoxFilled" FluentIcons) props
        static member inline boxRegular (props: IIconProp list) = createElement (import "BoxRegular" FluentIcons) props
        static member inline boxArrowLeftFilled (props: IIconProp list) = createElement (import "BoxArrowLeftFilled" FluentIcons) props
        static member inline boxArrowLeftRegular (props: IIconProp list) = createElement (import "BoxArrowLeftRegular" FluentIcons) props
        static member inline boxArrowUpFilled (props: IIconProp list) = createElement (import "BoxArrowUpFilled" FluentIcons) props
        static member inline boxArrowUpRegular (props: IIconProp list) = createElement (import "BoxArrowUpRegular" FluentIcons) props
        static member inline boxCheckmarkFilled (props: IIconProp list) = createElement (import "BoxCheckmarkFilled" FluentIcons) props
        static member inline boxCheckmarkRegular (props: IIconProp list) = createElement (import "BoxCheckmarkRegular" FluentIcons) props
        static member inline boxDismissFilled (props: IIconProp list) = createElement (import "BoxDismissFilled" FluentIcons) props
        static member inline boxDismissRegular (props: IIconProp list) = createElement (import "BoxDismissRegular" FluentIcons) props
        static member inline boxEditFilled (props: IIconProp list) = createElement (import "BoxEditFilled" FluentIcons) props
        static member inline boxEditRegular (props: IIconProp list) = createElement (import "BoxEditRegular" FluentIcons) props
        static member inline boxMultipleFilled (props: IIconProp list) = createElement (import "BoxMultipleFilled" FluentIcons) props
        static member inline boxMultipleRegular (props: IIconProp list) = createElement (import "BoxMultipleRegular" FluentIcons) props
        static member inline boxMultipleArrowLeftFilled (props: IIconProp list) = createElement (import "BoxMultipleArrowLeftFilled" FluentIcons) props
        static member inline boxMultipleArrowLeftRegular (props: IIconProp list) = createElement (import "BoxMultipleArrowLeftRegular" FluentIcons) props
        static member inline boxMultipleArrowRightFilled (props: IIconProp list) = createElement (import "BoxMultipleArrowRightFilled" FluentIcons) props
        static member inline boxMultipleArrowRightRegular (props: IIconProp list) = createElement (import "BoxMultipleArrowRightRegular" FluentIcons) props
        static member inline boxMultipleCheckmarkFilled (props: IIconProp list) = createElement (import "BoxMultipleCheckmarkFilled" FluentIcons) props
        static member inline boxMultipleCheckmarkRegular (props: IIconProp list) = createElement (import "BoxMultipleCheckmarkRegular" FluentIcons) props
        static member inline boxMultipleSearchFilled (props: IIconProp list) = createElement (import "BoxMultipleSearchFilled" FluentIcons) props
        static member inline boxMultipleSearchRegular (props: IIconProp list) = createElement (import "BoxMultipleSearchRegular" FluentIcons) props
        static member inline boxSearchFilled (props: IIconProp list) = createElement (import "BoxSearchFilled" FluentIcons) props
        static member inline boxSearchRegular (props: IIconProp list) = createElement (import "BoxSearchRegular" FluentIcons) props
        static member inline boxToolboxFilled (props: IIconProp list) = createElement (import "BoxToolboxFilled" FluentIcons) props
        static member inline boxToolboxRegular (props: IIconProp list) = createElement (import "BoxToolboxRegular" FluentIcons) props
        static member inline bracesFilled (props: IIconProp list) = createElement (import "BracesFilled" FluentIcons) props
        static member inline bracesRegular (props: IIconProp list) = createElement (import "BracesRegular" FluentIcons) props
        static member inline bracesVariableFilled (props: IIconProp list) = createElement (import "BracesVariableFilled" FluentIcons) props
        static member inline bracesVariableRegular (props: IIconProp list) = createElement (import "BracesVariableRegular" FluentIcons) props
        static member inline brainCircuitFilled (props: IIconProp list) = createElement (import "BrainCircuitFilled" FluentIcons) props
        static member inline brainCircuitRegular (props: IIconProp list) = createElement (import "BrainCircuitRegular" FluentIcons) props
        static member inline branchFilled (props: IIconProp list) = createElement (import "BranchFilled" FluentIcons) props
        static member inline branchRegular (props: IIconProp list) = createElement (import "BranchRegular" FluentIcons) props
        static member inline branchCompareFilled (props: IIconProp list) = createElement (import "BranchCompareFilled" FluentIcons) props
        static member inline branchCompareRegular (props: IIconProp list) = createElement (import "BranchCompareRegular" FluentIcons) props
        static member inline branchForkFilled (props: IIconProp list) = createElement (import "BranchForkFilled" FluentIcons) props
        static member inline branchForkRegular (props: IIconProp list) = createElement (import "BranchForkRegular" FluentIcons) props
        static member inline branchForkHintFilled (props: IIconProp list) = createElement (import "BranchForkHintFilled" FluentIcons) props
        static member inline branchForkHintRegular (props: IIconProp list) = createElement (import "BranchForkHintRegular" FluentIcons) props
        static member inline branchForkLinkFilled (props: IIconProp list) = createElement (import "BranchForkLinkFilled" FluentIcons) props
        static member inline branchForkLinkRegular (props: IIconProp list) = createElement (import "BranchForkLinkRegular" FluentIcons) props
        static member inline branchRequestFilled (props: IIconProp list) = createElement (import "BranchRequestFilled" FluentIcons) props
        static member inline branchRequestRegular (props: IIconProp list) = createElement (import "BranchRequestRegular" FluentIcons) props
        static member inline breakoutRoomFilled (props: IIconProp list) = createElement (import "BreakoutRoomFilled" FluentIcons) props
        static member inline breakoutRoomRegular (props: IIconProp list) = createElement (import "BreakoutRoomRegular" FluentIcons) props
        static member inline briefcaseFilled (props: IIconProp list) = createElement (import "BriefcaseFilled" FluentIcons) props
        static member inline briefcaseRegular (props: IIconProp list) = createElement (import "BriefcaseRegular" FluentIcons) props
        static member inline briefcaseMedicalFilled (props: IIconProp list) = createElement (import "BriefcaseMedicalFilled" FluentIcons) props
        static member inline briefcaseMedicalRegular (props: IIconProp list) = createElement (import "BriefcaseMedicalRegular" FluentIcons) props
        static member inline briefcaseOffFilled (props: IIconProp list) = createElement (import "BriefcaseOffFilled" FluentIcons) props
        static member inline briefcaseOffRegular (props: IIconProp list) = createElement (import "BriefcaseOffRegular" FluentIcons) props
        static member inline briefcaseSearchFilled (props: IIconProp list) = createElement (import "BriefcaseSearchFilled" FluentIcons) props
        static member inline briefcaseSearchRegular (props: IIconProp list) = createElement (import "BriefcaseSearchRegular" FluentIcons) props
        static member inline brightnessHighFilled (props: IIconProp list) = createElement (import "BrightnessHighFilled" FluentIcons) props
        static member inline brightnessHighRegular (props: IIconProp list) = createElement (import "BrightnessHighRegular" FluentIcons) props
        static member inline brightnessLowFilled (props: IIconProp list) = createElement (import "BrightnessLowFilled" FluentIcons) props
        static member inline brightnessLowRegular (props: IIconProp list) = createElement (import "BrightnessLowRegular" FluentIcons) props
        static member inline broadActivityFeedFilled (props: IIconProp list) = createElement (import "BroadActivityFeedFilled" FluentIcons) props
        static member inline broadActivityFeedRegular (props: IIconProp list) = createElement (import "BroadActivityFeedRegular" FluentIcons) props
        static member inline broomFilled (props: IIconProp list) = createElement (import "BroomFilled" FluentIcons) props
        static member inline broomRegular (props: IIconProp list) = createElement (import "BroomRegular" FluentIcons) props
        static member inline bubbleMultipleFilled (props: IIconProp list) = createElement (import "BubbleMultipleFilled" FluentIcons) props
        static member inline bubbleMultipleRegular (props: IIconProp list) = createElement (import "BubbleMultipleRegular" FluentIcons) props
        static member inline bugFilled (props: IIconProp list) = createElement (import "BugFilled" FluentIcons) props
        static member inline bugRegular (props: IIconProp list) = createElement (import "BugRegular" FluentIcons) props
        static member inline bugArrowCounterclockwiseFilled (props: IIconProp list) = createElement (import "BugArrowCounterclockwiseFilled" FluentIcons) props
        static member inline bugArrowCounterclockwiseRegular (props: IIconProp list) = createElement (import "BugArrowCounterclockwiseRegular" FluentIcons) props
        static member inline bugProhibitedFilled (props: IIconProp list) = createElement (import "BugProhibitedFilled" FluentIcons) props
        static member inline bugProhibitedRegular (props: IIconProp list) = createElement (import "BugProhibitedRegular" FluentIcons) props
        static member inline buildingFilled (props: IIconProp list) = createElement (import "BuildingFilled" FluentIcons) props
        static member inline buildingRegular (props: IIconProp list) = createElement (import "BuildingRegular" FluentIcons) props
        static member inline buildingBankFilled (props: IIconProp list) = createElement (import "BuildingBankFilled" FluentIcons) props
        static member inline buildingBankRegular (props: IIconProp list) = createElement (import "BuildingBankRegular" FluentIcons) props
        static member inline buildingBankLinkFilled (props: IIconProp list) = createElement (import "BuildingBankLinkFilled" FluentIcons) props
        static member inline buildingBankLinkRegular (props: IIconProp list) = createElement (import "BuildingBankLinkRegular" FluentIcons) props
        static member inline buildingBankToolboxFilled (props: IIconProp list) = createElement (import "BuildingBankToolboxFilled" FluentIcons) props
        static member inline buildingBankToolboxRegular (props: IIconProp list) = createElement (import "BuildingBankToolboxRegular" FluentIcons) props
        static member inline buildingDesktopFilled (props: IIconProp list) = createElement (import "BuildingDesktopFilled" FluentIcons) props
        static member inline buildingDesktopRegular (props: IIconProp list) = createElement (import "BuildingDesktopRegular" FluentIcons) props
        static member inline buildingFactoryFilled (props: IIconProp list) = createElement (import "BuildingFactoryFilled" FluentIcons) props
        static member inline buildingFactoryRegular (props: IIconProp list) = createElement (import "BuildingFactoryRegular" FluentIcons) props
        static member inline buildingGovernmentFilled (props: IIconProp list) = createElement (import "BuildingGovernmentFilled" FluentIcons) props
        static member inline buildingGovernmentRegular (props: IIconProp list) = createElement (import "BuildingGovernmentRegular" FluentIcons) props
        static member inline buildingGovernmentSearchFilled (props: IIconProp list) = createElement (import "BuildingGovernmentSearchFilled" FluentIcons) props
        static member inline buildingGovernmentSearchRegular (props: IIconProp list) = createElement (import "BuildingGovernmentSearchRegular" FluentIcons) props
        static member inline buildingHomeFilled (props: IIconProp list) = createElement (import "BuildingHomeFilled" FluentIcons) props
        static member inline buildingHomeRegular (props: IIconProp list) = createElement (import "BuildingHomeRegular" FluentIcons) props
        static member inline buildingLighthouseFilled (props: IIconProp list) = createElement (import "BuildingLighthouseFilled" FluentIcons) props
        static member inline buildingLighthouseRegular (props: IIconProp list) = createElement (import "BuildingLighthouseRegular" FluentIcons) props
        static member inline buildingMosqueFilled (props: IIconProp list) = createElement (import "BuildingMosqueFilled" FluentIcons) props
        static member inline buildingMosqueRegular (props: IIconProp list) = createElement (import "BuildingMosqueRegular" FluentIcons) props
        static member inline buildingMultipleFilled (props: IIconProp list) = createElement (import "BuildingMultipleFilled" FluentIcons) props
        static member inline buildingMultipleRegular (props: IIconProp list) = createElement (import "BuildingMultipleRegular" FluentIcons) props
        static member inline buildingPeopleFilled (props: IIconProp list) = createElement (import "BuildingPeopleFilled" FluentIcons) props
        static member inline buildingPeopleRegular (props: IIconProp list) = createElement (import "BuildingPeopleRegular" FluentIcons) props
        static member inline buildingRetailFilled (props: IIconProp list) = createElement (import "BuildingRetailFilled" FluentIcons) props
        static member inline buildingRetailRegular (props: IIconProp list) = createElement (import "BuildingRetailRegular" FluentIcons) props
        static member inline buildingRetailMoneyFilled (props: IIconProp list) = createElement (import "BuildingRetailMoneyFilled" FluentIcons) props
        static member inline buildingRetailMoneyRegular (props: IIconProp list) = createElement (import "BuildingRetailMoneyRegular" FluentIcons) props
        static member inline buildingRetailMoreFilled (props: IIconProp list) = createElement (import "BuildingRetailMoreFilled" FluentIcons) props
        static member inline buildingRetailMoreRegular (props: IIconProp list) = createElement (import "BuildingRetailMoreRegular" FluentIcons) props
        static member inline buildingRetailShieldFilled (props: IIconProp list) = createElement (import "BuildingRetailShieldFilled" FluentIcons) props
        static member inline buildingRetailShieldRegular (props: IIconProp list) = createElement (import "BuildingRetailShieldRegular" FluentIcons) props
        static member inline buildingRetailToolboxFilled (props: IIconProp list) = createElement (import "BuildingRetailToolboxFilled" FluentIcons) props
        static member inline buildingRetailToolboxRegular (props: IIconProp list) = createElement (import "BuildingRetailToolboxRegular" FluentIcons) props
        static member inline buildingShopFilled (props: IIconProp list) = createElement (import "BuildingShopFilled" FluentIcons) props
        static member inline buildingShopRegular (props: IIconProp list) = createElement (import "BuildingShopRegular" FluentIcons) props
        static member inline buildingSkyscraperFilled (props: IIconProp list) = createElement (import "BuildingSkyscraperFilled" FluentIcons) props
        static member inline buildingSkyscraperRegular (props: IIconProp list) = createElement (import "BuildingSkyscraperRegular" FluentIcons) props
        static member inline buildingSwapFilled (props: IIconProp list) = createElement (import "BuildingSwapFilled" FluentIcons) props
        static member inline buildingSwapRegular (props: IIconProp list) = createElement (import "BuildingSwapRegular" FluentIcons) props
        static member inline buildingTownhouseFilled (props: IIconProp list) = createElement (import "BuildingTownhouseFilled" FluentIcons) props
        static member inline buildingTownhouseRegular (props: IIconProp list) = createElement (import "BuildingTownhouseRegular" FluentIcons) props
        static member inline buttonFilled (props: IIconProp list) = createElement (import "ButtonFilled" FluentIcons) props
        static member inline buttonRegular (props: IIconProp list) = createElement (import "ButtonRegular" FluentIcons) props
        static member inline calculatorFilled (props: IIconProp list) = createElement (import "CalculatorFilled" FluentIcons) props
        static member inline calculatorRegular (props: IIconProp list) = createElement (import "CalculatorRegular" FluentIcons) props
        static member inline calculatorArrowClockwiseFilled (props: IIconProp list) = createElement (import "CalculatorArrowClockwiseFilled" FluentIcons) props
        static member inline calculatorArrowClockwiseRegular (props: IIconProp list) = createElement (import "CalculatorArrowClockwiseRegular" FluentIcons) props
        static member inline calculatorMultipleFilled (props: IIconProp list) = createElement (import "CalculatorMultipleFilled" FluentIcons) props
        static member inline calculatorMultipleRegular (props: IIconProp list) = createElement (import "CalculatorMultipleRegular" FluentIcons) props
        static member inline calendarFilled (props: IIconProp list) = createElement (import "CalendarFilled" FluentIcons) props
        static member inline calendarRegular (props: IIconProp list) = createElement (import "CalendarRegular" FluentIcons) props
        static member inline calendar3DayFilled (props: IIconProp list) = createElement (import "Calendar3DayFilled" FluentIcons) props
        static member inline calendar3DayRegular (props: IIconProp list) = createElement (import "Calendar3DayRegular" FluentIcons) props
        static member inline calendarAddFilled (props: IIconProp list) = createElement (import "CalendarAddFilled" FluentIcons) props
        static member inline calendarAddRegular (props: IIconProp list) = createElement (import "CalendarAddRegular" FluentIcons) props
        static member inline calendarAgendaFilled (props: IIconProp list) = createElement (import "CalendarAgendaFilled" FluentIcons) props
        static member inline calendarAgendaRegular (props: IIconProp list) = createElement (import "CalendarAgendaRegular" FluentIcons) props
        static member inline calendarArrowCounterclockwiseFilled (props: IIconProp list) = createElement (import "CalendarArrowCounterclockwiseFilled" FluentIcons) props
        static member inline calendarArrowCounterclockwiseRegular (props: IIconProp list) = createElement (import "CalendarArrowCounterclockwiseRegular" FluentIcons) props
        static member inline calendarArrowDownFilled (props: IIconProp list) = createElement (import "CalendarArrowDownFilled" FluentIcons) props
        static member inline calendarArrowDownRegular (props: IIconProp list) = createElement (import "CalendarArrowDownRegular" FluentIcons) props
        static member inline calendarArrowRightFilled (props: IIconProp list) = createElement (import "CalendarArrowRightFilled" FluentIcons) props
        static member inline calendarArrowRightRegular (props: IIconProp list) = createElement (import "CalendarArrowRightRegular" FluentIcons) props
        static member inline calendarAssistantFilled (props: IIconProp list) = createElement (import "CalendarAssistantFilled" FluentIcons) props
        static member inline calendarAssistantRegular (props: IIconProp list) = createElement (import "CalendarAssistantRegular" FluentIcons) props
        static member inline calendarCancelFilled (props: IIconProp list) = createElement (import "CalendarCancelFilled" FluentIcons) props
        static member inline calendarCancelRegular (props: IIconProp list) = createElement (import "CalendarCancelRegular" FluentIcons) props
        static member inline calendarChatFilled (props: IIconProp list) = createElement (import "CalendarChatFilled" FluentIcons) props
        static member inline calendarChatRegular (props: IIconProp list) = createElement (import "CalendarChatRegular" FluentIcons) props
        static member inline calendarCheckmarkFilled (props: IIconProp list) = createElement (import "CalendarCheckmarkFilled" FluentIcons) props
        static member inline calendarCheckmarkRegular (props: IIconProp list) = createElement (import "CalendarCheckmarkRegular" FluentIcons) props
        static member inline calendarClockFilled (props: IIconProp list) = createElement (import "CalendarClockFilled" FluentIcons) props
        static member inline calendarClockRegular (props: IIconProp list) = createElement (import "CalendarClockRegular" FluentIcons) props
        static member inline calendarDataBarFilled (props: IIconProp list) = createElement (import "CalendarDataBarFilled" FluentIcons) props
        static member inline calendarDataBarRegular (props: IIconProp list) = createElement (import "CalendarDataBarRegular" FluentIcons) props
        static member inline calendarDateFilled (props: IIconProp list) = createElement (import "CalendarDateFilled" FluentIcons) props
        static member inline calendarDateRegular (props: IIconProp list) = createElement (import "CalendarDateRegular" FluentIcons) props
        static member inline calendarDayFilled (props: IIconProp list) = createElement (import "CalendarDayFilled" FluentIcons) props
        static member inline calendarDayRegular (props: IIconProp list) = createElement (import "CalendarDayRegular" FluentIcons) props
        static member inline calendarEditFilled (props: IIconProp list) = createElement (import "CalendarEditFilled" FluentIcons) props
        static member inline calendarEditRegular (props: IIconProp list) = createElement (import "CalendarEditRegular" FluentIcons) props
        static member inline calendarEmptyFilled (props: IIconProp list) = createElement (import "CalendarEmptyFilled" FluentIcons) props
        static member inline calendarEmptyRegular (props: IIconProp list) = createElement (import "CalendarEmptyRegular" FluentIcons) props
        static member inline calendarErrorFilled (props: IIconProp list) = createElement (import "CalendarErrorFilled" FluentIcons) props
        static member inline calendarErrorRegular (props: IIconProp list) = createElement (import "CalendarErrorRegular" FluentIcons) props
        static member inline calendarEyeFilled (props: IIconProp list) = createElement (import "CalendarEyeFilled" FluentIcons) props
        static member inline calendarEyeRegular (props: IIconProp list) = createElement (import "CalendarEyeRegular" FluentIcons) props
        static member inline calendarInfoFilled (props: IIconProp list) = createElement (import "CalendarInfoFilled" FluentIcons) props
        static member inline calendarInfoRegular (props: IIconProp list) = createElement (import "CalendarInfoRegular" FluentIcons) props
        static member inline calendarLockFilled (props: IIconProp list) = createElement (import "CalendarLockFilled" FluentIcons) props
        static member inline calendarLockRegular (props: IIconProp list) = createElement (import "CalendarLockRegular" FluentIcons) props
        static member inline calendarLtrFilled (props: IIconProp list) = createElement (import "CalendarLtrFilled" FluentIcons) props
        static member inline calendarLtrRegular (props: IIconProp list) = createElement (import "CalendarLtrRegular" FluentIcons) props
        static member inline calendarMailFilled (props: IIconProp list) = createElement (import "CalendarMailFilled" FluentIcons) props
        static member inline calendarMailRegular (props: IIconProp list) = createElement (import "CalendarMailRegular" FluentIcons) props
        static member inline calendarMentionFilled (props: IIconProp list) = createElement (import "CalendarMentionFilled" FluentIcons) props
        static member inline calendarMentionRegular (props: IIconProp list) = createElement (import "CalendarMentionRegular" FluentIcons) props
        static member inline calendarMonthFilled (props: IIconProp list) = createElement (import "CalendarMonthFilled" FluentIcons) props
        static member inline calendarMonthRegular (props: IIconProp list) = createElement (import "CalendarMonthRegular" FluentIcons) props
        static member inline calendarMultipleFilled (props: IIconProp list) = createElement (import "CalendarMultipleFilled" FluentIcons) props
        static member inline calendarMultipleRegular (props: IIconProp list) = createElement (import "CalendarMultipleRegular" FluentIcons) props
        static member inline calendarNoteFilled (props: IIconProp list) = createElement (import "CalendarNoteFilled" FluentIcons) props
        static member inline calendarNoteRegular (props: IIconProp list) = createElement (import "CalendarNoteRegular" FluentIcons) props
        static member inline calendarPatternFilled (props: IIconProp list) = createElement (import "CalendarPatternFilled" FluentIcons) props
        static member inline calendarPatternRegular (props: IIconProp list) = createElement (import "CalendarPatternRegular" FluentIcons) props
        static member inline calendarPersonFilled (props: IIconProp list) = createElement (import "CalendarPersonFilled" FluentIcons) props
        static member inline calendarPersonRegular (props: IIconProp list) = createElement (import "CalendarPersonRegular" FluentIcons) props
        static member inline calendarPhoneFilled (props: IIconProp list) = createElement (import "CalendarPhoneFilled" FluentIcons) props
        static member inline calendarPhoneRegular (props: IIconProp list) = createElement (import "CalendarPhoneRegular" FluentIcons) props
        static member inline calendarPlayFilled (props: IIconProp list) = createElement (import "CalendarPlayFilled" FluentIcons) props
        static member inline calendarPlayRegular (props: IIconProp list) = createElement (import "CalendarPlayRegular" FluentIcons) props
        static member inline calendarQuestionMarkFilled (props: IIconProp list) = createElement (import "CalendarQuestionMarkFilled" FluentIcons) props
        static member inline calendarQuestionMarkRegular (props: IIconProp list) = createElement (import "CalendarQuestionMarkRegular" FluentIcons) props
        static member inline calendarRecordFilled (props: IIconProp list) = createElement (import "CalendarRecordFilled" FluentIcons) props
        static member inline calendarRecordRegular (props: IIconProp list) = createElement (import "CalendarRecordRegular" FluentIcons) props
        static member inline calendarReplyFilled (props: IIconProp list) = createElement (import "CalendarReplyFilled" FluentIcons) props
        static member inline calendarReplyRegular (props: IIconProp list) = createElement (import "CalendarReplyRegular" FluentIcons) props
        static member inline calendarRtlFilled (props: IIconProp list) = createElement (import "CalendarRtlFilled" FluentIcons) props
        static member inline calendarRtlRegular (props: IIconProp list) = createElement (import "CalendarRtlRegular" FluentIcons) props
        static member inline calendarSearchFilled (props: IIconProp list) = createElement (import "CalendarSearchFilled" FluentIcons) props
        static member inline calendarSearchRegular (props: IIconProp list) = createElement (import "CalendarSearchRegular" FluentIcons) props
        static member inline calendarSettingsFilled (props: IIconProp list) = createElement (import "CalendarSettingsFilled" FluentIcons) props
        static member inline calendarSettingsRegular (props: IIconProp list) = createElement (import "CalendarSettingsRegular" FluentIcons) props
        static member inline calendarShieldFilled (props: IIconProp list) = createElement (import "CalendarShieldFilled" FluentIcons) props
        static member inline calendarShieldRegular (props: IIconProp list) = createElement (import "CalendarShieldRegular" FluentIcons) props
        static member inline calendarSparkleFilled (props: IIconProp list) = createElement (import "CalendarSparkleFilled" FluentIcons) props
        static member inline calendarSparkleRegular (props: IIconProp list) = createElement (import "CalendarSparkleRegular" FluentIcons) props
        static member inline calendarStarFilled (props: IIconProp list) = createElement (import "CalendarStarFilled" FluentIcons) props
        static member inline calendarStarRegular (props: IIconProp list) = createElement (import "CalendarStarRegular" FluentIcons) props
        static member inline calendarSyncFilled (props: IIconProp list) = createElement (import "CalendarSyncFilled" FluentIcons) props
        static member inline calendarSyncRegular (props: IIconProp list) = createElement (import "CalendarSyncRegular" FluentIcons) props
        static member inline calendarTemplateFilled (props: IIconProp list) = createElement (import "CalendarTemplateFilled" FluentIcons) props
        static member inline calendarTemplateRegular (props: IIconProp list) = createElement (import "CalendarTemplateRegular" FluentIcons) props
        static member inline calendarTodayFilled (props: IIconProp list) = createElement (import "CalendarTodayFilled" FluentIcons) props
        static member inline calendarTodayRegular (props: IIconProp list) = createElement (import "CalendarTodayRegular" FluentIcons) props
        static member inline calendarToolboxFilled (props: IIconProp list) = createElement (import "CalendarToolboxFilled" FluentIcons) props
        static member inline calendarToolboxRegular (props: IIconProp list) = createElement (import "CalendarToolboxRegular" FluentIcons) props
        static member inline calendarVideoFilled (props: IIconProp list) = createElement (import "CalendarVideoFilled" FluentIcons) props
        static member inline calendarVideoRegular (props: IIconProp list) = createElement (import "CalendarVideoRegular" FluentIcons) props
        static member inline calendarWeekNumbersFilled (props: IIconProp list) = createElement (import "CalendarWeekNumbersFilled" FluentIcons) props
        static member inline calendarWeekNumbersRegular (props: IIconProp list) = createElement (import "CalendarWeekNumbersRegular" FluentIcons) props
        static member inline calendarWeekStartFilled (props: IIconProp list) = createElement (import "CalendarWeekStartFilled" FluentIcons) props
        static member inline calendarWeekStartRegular (props: IIconProp list) = createElement (import "CalendarWeekStartRegular" FluentIcons) props
        static member inline calendarWorkWeekFilled (props: IIconProp list) = createElement (import "CalendarWorkWeekFilled" FluentIcons) props
        static member inline calendarWorkWeekRegular (props: IIconProp list) = createElement (import "CalendarWorkWeekRegular" FluentIcons) props
        static member inline callFilled (props: IIconProp list) = createElement (import "CallFilled" FluentIcons) props
        static member inline callRegular (props: IIconProp list) = createElement (import "CallRegular" FluentIcons) props
        static member inline callAddFilled (props: IIconProp list) = createElement (import "CallAddFilled" FluentIcons) props
        static member inline callAddRegular (props: IIconProp list) = createElement (import "CallAddRegular" FluentIcons) props
        static member inline callCheckmarkFilled (props: IIconProp list) = createElement (import "CallCheckmarkFilled" FluentIcons) props
        static member inline callCheckmarkRegular (props: IIconProp list) = createElement (import "CallCheckmarkRegular" FluentIcons) props
        static member inline callConnectingFilled (props: IIconProp list) = createElement (import "CallConnectingFilled" FluentIcons) props
        static member inline callConnectingRegular (props: IIconProp list) = createElement (import "CallConnectingRegular" FluentIcons) props
        static member inline callDismissFilled (props: IIconProp list) = createElement (import "CallDismissFilled" FluentIcons) props
        static member inline callDismissRegular (props: IIconProp list) = createElement (import "CallDismissRegular" FluentIcons) props
        static member inline callEndFilled (props: IIconProp list) = createElement (import "CallEndFilled" FluentIcons) props
        static member inline callEndRegular (props: IIconProp list) = createElement (import "CallEndRegular" FluentIcons) props
        static member inline callExclamationFilled (props: IIconProp list) = createElement (import "CallExclamationFilled" FluentIcons) props
        static member inline callExclamationRegular (props: IIconProp list) = createElement (import "CallExclamationRegular" FluentIcons) props
        static member inline callForwardFilled (props: IIconProp list) = createElement (import "CallForwardFilled" FluentIcons) props
        static member inline callForwardRegular (props: IIconProp list) = createElement (import "CallForwardRegular" FluentIcons) props
        static member inline callInboundFilled (props: IIconProp list) = createElement (import "CallInboundFilled" FluentIcons) props
        static member inline callInboundRegular (props: IIconProp list) = createElement (import "CallInboundRegular" FluentIcons) props
        static member inline callMissedFilled (props: IIconProp list) = createElement (import "CallMissedFilled" FluentIcons) props
        static member inline callMissedRegular (props: IIconProp list) = createElement (import "CallMissedRegular" FluentIcons) props
        static member inline callOutboundFilled (props: IIconProp list) = createElement (import "CallOutboundFilled" FluentIcons) props
        static member inline callOutboundRegular (props: IIconProp list) = createElement (import "CallOutboundRegular" FluentIcons) props
        static member inline callParkFilled (props: IIconProp list) = createElement (import "CallParkFilled" FluentIcons) props
        static member inline callParkRegular (props: IIconProp list) = createElement (import "CallParkRegular" FluentIcons) props
        static member inline callPauseFilled (props: IIconProp list) = createElement (import "CallPauseFilled" FluentIcons) props
        static member inline callPauseRegular (props: IIconProp list) = createElement (import "CallPauseRegular" FluentIcons) props
        static member inline callProhibitedFilled (props: IIconProp list) = createElement (import "CallProhibitedFilled" FluentIcons) props
        static member inline callProhibitedRegular (props: IIconProp list) = createElement (import "CallProhibitedRegular" FluentIcons) props
        static member inline callTransferFilled (props: IIconProp list) = createElement (import "CallTransferFilled" FluentIcons) props
        static member inline callTransferRegular (props: IIconProp list) = createElement (import "CallTransferRegular" FluentIcons) props
        static member inline callWarningFilled (props: IIconProp list) = createElement (import "CallWarningFilled" FluentIcons) props
        static member inline callWarningRegular (props: IIconProp list) = createElement (import "CallWarningRegular" FluentIcons) props
        static member inline calligraphyPenFilled (props: IIconProp list) = createElement (import "CalligraphyPenFilled" FluentIcons) props
        static member inline calligraphyPenRegular (props: IIconProp list) = createElement (import "CalligraphyPenRegular" FluentIcons) props
        static member inline calligraphyPenCheckmarkFilled (props: IIconProp list) = createElement (import "CalligraphyPenCheckmarkFilled" FluentIcons) props
        static member inline calligraphyPenCheckmarkRegular (props: IIconProp list) = createElement (import "CalligraphyPenCheckmarkRegular" FluentIcons) props
        static member inline calligraphyPenErrorFilled (props: IIconProp list) = createElement (import "CalligraphyPenErrorFilled" FluentIcons) props
        static member inline calligraphyPenErrorRegular (props: IIconProp list) = createElement (import "CalligraphyPenErrorRegular" FluentIcons) props
        static member inline calligraphyPenQuestionMarkFilled (props: IIconProp list) = createElement (import "CalligraphyPenQuestionMarkFilled" FluentIcons) props
        static member inline calligraphyPenQuestionMarkRegular (props: IIconProp list) = createElement (import "CalligraphyPenQuestionMarkRegular" FluentIcons) props
        static member inline cameraFilled (props: IIconProp list) = createElement (import "CameraFilled" FluentIcons) props
        static member inline cameraRegular (props: IIconProp list) = createElement (import "CameraRegular" FluentIcons) props
        static member inline cameraAddFilled (props: IIconProp list) = createElement (import "CameraAddFilled" FluentIcons) props
        static member inline cameraAddRegular (props: IIconProp list) = createElement (import "CameraAddRegular" FluentIcons) props
        static member inline cameraArrowUpFilled (props: IIconProp list) = createElement (import "CameraArrowUpFilled" FluentIcons) props
        static member inline cameraArrowUpRegular (props: IIconProp list) = createElement (import "CameraArrowUpRegular" FluentIcons) props
        static member inline cameraDomeFilled (props: IIconProp list) = createElement (import "CameraDomeFilled" FluentIcons) props
        static member inline cameraDomeRegular (props: IIconProp list) = createElement (import "CameraDomeRegular" FluentIcons) props
        static member inline cameraEditFilled (props: IIconProp list) = createElement (import "CameraEditFilled" FluentIcons) props
        static member inline cameraEditRegular (props: IIconProp list) = createElement (import "CameraEditRegular" FluentIcons) props
        static member inline cameraOffFilled (props: IIconProp list) = createElement (import "CameraOffFilled" FluentIcons) props
        static member inline cameraOffRegular (props: IIconProp list) = createElement (import "CameraOffRegular" FluentIcons) props
        static member inline cameraSparklesFilled (props: IIconProp list) = createElement (import "CameraSparklesFilled" FluentIcons) props
        static member inline cameraSparklesRegular (props: IIconProp list) = createElement (import "CameraSparklesRegular" FluentIcons) props
        static member inline cameraSwitchFilled (props: IIconProp list) = createElement (import "CameraSwitchFilled" FluentIcons) props
        static member inline cameraSwitchRegular (props: IIconProp list) = createElement (import "CameraSwitchRegular" FluentIcons) props
        static member inline cardUiFilled (props: IIconProp list) = createElement (import "CardUiFilled" FluentIcons) props
        static member inline cardUiRegular (props: IIconProp list) = createElement (import "CardUiRegular" FluentIcons) props
        static member inline cardUiPortraitFlipFilled (props: IIconProp list) = createElement (import "CardUiPortraitFlipFilled" FluentIcons) props
        static member inline cardUiPortraitFlipRegular (props: IIconProp list) = createElement (import "CardUiPortraitFlipRegular" FluentIcons) props
        static member inline caretDownFilled (props: IIconProp list) = createElement (import "CaretDownFilled" FluentIcons) props
        static member inline caretDownRegular (props: IIconProp list) = createElement (import "CaretDownRegular" FluentIcons) props
        static member inline caretDownRightFilled (props: IIconProp list) = createElement (import "CaretDownRightFilled" FluentIcons) props
        static member inline caretDownRightRegular (props: IIconProp list) = createElement (import "CaretDownRightRegular" FluentIcons) props
        static member inline caretLeftFilled (props: IIconProp list) = createElement (import "CaretLeftFilled" FluentIcons) props
        static member inline caretLeftRegular (props: IIconProp list) = createElement (import "CaretLeftRegular" FluentIcons) props
        static member inline caretRightFilled (props: IIconProp list) = createElement (import "CaretRightFilled" FluentIcons) props
        static member inline caretRightRegular (props: IIconProp list) = createElement (import "CaretRightRegular" FluentIcons) props
        static member inline caretUpFilled (props: IIconProp list) = createElement (import "CaretUpFilled" FluentIcons) props
        static member inline caretUpRegular (props: IIconProp list) = createElement (import "CaretUpRegular" FluentIcons) props
        static member inline cartFilled (props: IIconProp list) = createElement (import "CartFilled" FluentIcons) props
        static member inline cartRegular (props: IIconProp list) = createElement (import "CartRegular" FluentIcons) props
        static member inline castFilled (props: IIconProp list) = createElement (import "CastFilled" FluentIcons) props
        static member inline castRegular (props: IIconProp list) = createElement (import "CastRegular" FluentIcons) props
        static member inline castMultipleFilled (props: IIconProp list) = createElement (import "CastMultipleFilled" FluentIcons) props
        static member inline castMultipleRegular (props: IIconProp list) = createElement (import "CastMultipleRegular" FluentIcons) props
        static member inline catchUpFilled (props: IIconProp list) = createElement (import "CatchUpFilled" FluentIcons) props
        static member inline catchUpRegular (props: IIconProp list) = createElement (import "CatchUpRegular" FluentIcons) props
        static member inline cellular3GFilled (props: IIconProp list) = createElement (import "Cellular3GFilled" FluentIcons) props
        static member inline cellular3GRegular (props: IIconProp list) = createElement (import "Cellular3GRegular" FluentIcons) props
        static member inline cellular4GFilled (props: IIconProp list) = createElement (import "Cellular4GFilled" FluentIcons) props
        static member inline cellular4GRegular (props: IIconProp list) = createElement (import "Cellular4GRegular" FluentIcons) props
        static member inline cellular5GFilled (props: IIconProp list) = createElement (import "Cellular5GFilled" FluentIcons) props
        static member inline cellular5GRegular (props: IIconProp list) = createElement (import "Cellular5GRegular" FluentIcons) props
        static member inline cellularData1Filled (props: IIconProp list) = createElement (import "CellularData1Filled" FluentIcons) props
        static member inline cellularData1Regular (props: IIconProp list) = createElement (import "CellularData1Regular" FluentIcons) props
        static member inline cellularData2Filled (props: IIconProp list) = createElement (import "CellularData2Filled" FluentIcons) props
        static member inline cellularData2Regular (props: IIconProp list) = createElement (import "CellularData2Regular" FluentIcons) props
        static member inline cellularData3Filled (props: IIconProp list) = createElement (import "CellularData3Filled" FluentIcons) props
        static member inline cellularData3Regular (props: IIconProp list) = createElement (import "CellularData3Regular" FluentIcons) props
        static member inline cellularData4Filled (props: IIconProp list) = createElement (import "CellularData4Filled" FluentIcons) props
        static member inline cellularData4Regular (props: IIconProp list) = createElement (import "CellularData4Regular" FluentIcons) props
        static member inline cellularData5Filled (props: IIconProp list) = createElement (import "CellularData5Filled" FluentIcons) props
        static member inline cellularData5Regular (props: IIconProp list) = createElement (import "CellularData5Regular" FluentIcons) props
        static member inline cellularOffFilled (props: IIconProp list) = createElement (import "CellularOffFilled" FluentIcons) props
        static member inline cellularOffRegular (props: IIconProp list) = createElement (import "CellularOffRegular" FluentIcons) props
        static member inline cellularWarningFilled (props: IIconProp list) = createElement (import "CellularWarningFilled" FluentIcons) props
        static member inline cellularWarningRegular (props: IIconProp list) = createElement (import "CellularWarningRegular" FluentIcons) props
        static member inline centerHorizontalFilled (props: IIconProp list) = createElement (import "CenterHorizontalFilled" FluentIcons) props
        static member inline centerHorizontalRegular (props: IIconProp list) = createElement (import "CenterHorizontalRegular" FluentIcons) props
        static member inline centerVerticalFilled (props: IIconProp list) = createElement (import "CenterVerticalFilled" FluentIcons) props
        static member inline centerVerticalRegular (props: IIconProp list) = createElement (import "CenterVerticalRegular" FluentIcons) props
        static member inline certificateFilled (props: IIconProp list) = createElement (import "CertificateFilled" FluentIcons) props
        static member inline certificateRegular (props: IIconProp list) = createElement (import "CertificateRegular" FluentIcons) props
        static member inline channelFilled (props: IIconProp list) = createElement (import "ChannelFilled" FluentIcons) props
        static member inline channelRegular (props: IIconProp list) = createElement (import "ChannelRegular" FluentIcons) props
        static member inline channelAddFilled (props: IIconProp list) = createElement (import "ChannelAddFilled" FluentIcons) props
        static member inline channelAddRegular (props: IIconProp list) = createElement (import "ChannelAddRegular" FluentIcons) props
        static member inline channelAlertFilled (props: IIconProp list) = createElement (import "ChannelAlertFilled" FluentIcons) props
        static member inline channelAlertRegular (props: IIconProp list) = createElement (import "ChannelAlertRegular" FluentIcons) props
        static member inline channelArrowLeftFilled (props: IIconProp list) = createElement (import "ChannelArrowLeftFilled" FluentIcons) props
        static member inline channelArrowLeftRegular (props: IIconProp list) = createElement (import "ChannelArrowLeftRegular" FluentIcons) props
        static member inline channelDismissFilled (props: IIconProp list) = createElement (import "ChannelDismissFilled" FluentIcons) props
        static member inline channelDismissRegular (props: IIconProp list) = createElement (import "ChannelDismissRegular" FluentIcons) props
        static member inline channelShareFilled (props: IIconProp list) = createElement (import "ChannelShareFilled" FluentIcons) props
        static member inline channelShareRegular (props: IIconProp list) = createElement (import "ChannelShareRegular" FluentIcons) props
        static member inline channelSubtractFilled (props: IIconProp list) = createElement (import "ChannelSubtractFilled" FluentIcons) props
        static member inline channelSubtractRegular (props: IIconProp list) = createElement (import "ChannelSubtractRegular" FluentIcons) props
        static member inline chartMultipleFilled (props: IIconProp list) = createElement (import "ChartMultipleFilled" FluentIcons) props
        static member inline chartMultipleRegular (props: IIconProp list) = createElement (import "ChartMultipleRegular" FluentIcons) props
        static member inline chartPersonFilled (props: IIconProp list) = createElement (import "ChartPersonFilled" FluentIcons) props
        static member inline chartPersonRegular (props: IIconProp list) = createElement (import "ChartPersonRegular" FluentIcons) props
        static member inline chatFilled (props: IIconProp list) = createElement (import "ChatFilled" FluentIcons) props
        static member inline chatRegular (props: IIconProp list) = createElement (import "ChatRegular" FluentIcons) props
        static member inline chatAddFilled (props: IIconProp list) = createElement (import "ChatAddFilled" FluentIcons) props
        static member inline chatAddRegular (props: IIconProp list) = createElement (import "ChatAddRegular" FluentIcons) props
        static member inline chatArrowBackFilled (props: IIconProp list) = createElement (import "ChatArrowBackFilled" FluentIcons) props
        static member inline chatArrowBackRegular (props: IIconProp list) = createElement (import "ChatArrowBackRegular" FluentIcons) props
        static member inline chatArrowBackDownFilled (props: IIconProp list) = createElement (import "ChatArrowBackDownFilled" FluentIcons) props
        static member inline chatArrowBackDownRegular (props: IIconProp list) = createElement (import "ChatArrowBackDownRegular" FluentIcons) props
        static member inline chatArrowDoubleBackFilled (props: IIconProp list) = createElement (import "ChatArrowDoubleBackFilled" FluentIcons) props
        static member inline chatArrowDoubleBackRegular (props: IIconProp list) = createElement (import "ChatArrowDoubleBackRegular" FluentIcons) props
        static member inline chatBubblesQuestionFilled (props: IIconProp list) = createElement (import "ChatBubblesQuestionFilled" FluentIcons) props
        static member inline chatBubblesQuestionRegular (props: IIconProp list) = createElement (import "ChatBubblesQuestionRegular" FluentIcons) props
        static member inline chatCursorFilled (props: IIconProp list) = createElement (import "ChatCursorFilled" FluentIcons) props
        static member inline chatCursorRegular (props: IIconProp list) = createElement (import "ChatCursorRegular" FluentIcons) props
        static member inline chatDismissFilled (props: IIconProp list) = createElement (import "ChatDismissFilled" FluentIcons) props
        static member inline chatDismissRegular (props: IIconProp list) = createElement (import "ChatDismissRegular" FluentIcons) props
        static member inline chatEmptyFilled (props: IIconProp list) = createElement (import "ChatEmptyFilled" FluentIcons) props
        static member inline chatEmptyRegular (props: IIconProp list) = createElement (import "ChatEmptyRegular" FluentIcons) props
        static member inline chatHelpFilled (props: IIconProp list) = createElement (import "ChatHelpFilled" FluentIcons) props
        static member inline chatHelpRegular (props: IIconProp list) = createElement (import "ChatHelpRegular" FluentIcons) props
        static member inline chatLockFilled (props: IIconProp list) = createElement (import "ChatLockFilled" FluentIcons) props
        static member inline chatLockRegular (props: IIconProp list) = createElement (import "ChatLockRegular" FluentIcons) props
        static member inline chatMailFilled (props: IIconProp list) = createElement (import "ChatMailFilled" FluentIcons) props
        static member inline chatMailRegular (props: IIconProp list) = createElement (import "ChatMailRegular" FluentIcons) props
        static member inline chatMultipleFilled (props: IIconProp list) = createElement (import "ChatMultipleFilled" FluentIcons) props
        static member inline chatMultipleRegular (props: IIconProp list) = createElement (import "ChatMultipleRegular" FluentIcons) props
        static member inline chatMultipleHeartFilled (props: IIconProp list) = createElement (import "ChatMultipleHeartFilled" FluentIcons) props
        static member inline chatMultipleHeartRegular (props: IIconProp list) = createElement (import "ChatMultipleHeartRegular" FluentIcons) props
        static member inline chatOffFilled (props: IIconProp list) = createElement (import "ChatOffFilled" FluentIcons) props
        static member inline chatOffRegular (props: IIconProp list) = createElement (import "ChatOffRegular" FluentIcons) props
        static member inline chatSettingsFilled (props: IIconProp list) = createElement (import "ChatSettingsFilled" FluentIcons) props
        static member inline chatSettingsRegular (props: IIconProp list) = createElement (import "ChatSettingsRegular" FluentIcons) props
        static member inline chatSparkleFilled (props: IIconProp list) = createElement (import "ChatSparkleFilled" FluentIcons) props
        static member inline chatSparkleRegular (props: IIconProp list) = createElement (import "ChatSparkleRegular" FluentIcons) props
        static member inline chatVideoFilled (props: IIconProp list) = createElement (import "ChatVideoFilled" FluentIcons) props
        static member inline chatVideoRegular (props: IIconProp list) = createElement (import "ChatVideoRegular" FluentIcons) props
        static member inline chatWarningFilled (props: IIconProp list) = createElement (import "ChatWarningFilled" FluentIcons) props
        static member inline chatWarningRegular (props: IIconProp list) = createElement (import "ChatWarningRegular" FluentIcons) props
        static member inline checkFilled (props: IIconProp list) = createElement (import "CheckFilled" FluentIcons) props
        static member inline checkRegular (props: IIconProp list) = createElement (import "CheckRegular" FluentIcons) props
        static member inline checkbox1Filled (props: IIconProp list) = createElement (import "Checkbox1Filled" FluentIcons) props
        static member inline checkbox1Regular (props: IIconProp list) = createElement (import "Checkbox1Regular" FluentIcons) props
        static member inline checkbox2Filled (props: IIconProp list) = createElement (import "Checkbox2Filled" FluentIcons) props
        static member inline checkbox2Regular (props: IIconProp list) = createElement (import "Checkbox2Regular" FluentIcons) props
        static member inline checkboxArrowRightFilled (props: IIconProp list) = createElement (import "CheckboxArrowRightFilled" FluentIcons) props
        static member inline checkboxArrowRightRegular (props: IIconProp list) = createElement (import "CheckboxArrowRightRegular" FluentIcons) props
        static member inline checkboxCheckedFilled (props: IIconProp list) = createElement (import "CheckboxCheckedFilled" FluentIcons) props
        static member inline checkboxCheckedRegular (props: IIconProp list) = createElement (import "CheckboxCheckedRegular" FluentIcons) props
        static member inline checkboxCheckedSyncFilled (props: IIconProp list) = createElement (import "CheckboxCheckedSyncFilled" FluentIcons) props
        static member inline checkboxCheckedSyncRegular (props: IIconProp list) = createElement (import "CheckboxCheckedSyncRegular" FluentIcons) props
        static member inline checkboxIndeterminateFilled (props: IIconProp list) = createElement (import "CheckboxIndeterminateFilled" FluentIcons) props
        static member inline checkboxIndeterminateRegular (props: IIconProp list) = createElement (import "CheckboxIndeterminateRegular" FluentIcons) props
        static member inline checkboxPersonFilled (props: IIconProp list) = createElement (import "CheckboxPersonFilled" FluentIcons) props
        static member inline checkboxPersonRegular (props: IIconProp list) = createElement (import "CheckboxPersonRegular" FluentIcons) props
        static member inline checkboxUncheckedFilled (props: IIconProp list) = createElement (import "CheckboxUncheckedFilled" FluentIcons) props
        static member inline checkboxUncheckedRegular (props: IIconProp list) = createElement (import "CheckboxUncheckedRegular" FluentIcons) props
        static member inline checkboxWarningFilled (props: IIconProp list) = createElement (import "CheckboxWarningFilled" FluentIcons) props
        static member inline checkboxWarningRegular (props: IIconProp list) = createElement (import "CheckboxWarningRegular" FluentIcons) props
        static member inline checkmarkFilled (props: IIconProp list) = createElement (import "CheckmarkFilled" FluentIcons) props
        static member inline checkmarkRegular (props: IIconProp list) = createElement (import "CheckmarkRegular" FluentIcons) props
        static member inline checkmarkCircleFilled (props: IIconProp list) = createElement (import "CheckmarkCircleFilled" FluentIcons) props
        static member inline checkmarkCircleRegular (props: IIconProp list) = createElement (import "CheckmarkCircleRegular" FluentIcons) props
        static member inline checkmarkCircleSquareFilled (props: IIconProp list) = createElement (import "CheckmarkCircleSquareFilled" FluentIcons) props
        static member inline checkmarkCircleSquareRegular (props: IIconProp list) = createElement (import "CheckmarkCircleSquareRegular" FluentIcons) props
        static member inline checkmarkCircleWarningFilled (props: IIconProp list) = createElement (import "CheckmarkCircleWarningFilled" FluentIcons) props
        static member inline checkmarkCircleWarningRegular (props: IIconProp list) = createElement (import "CheckmarkCircleWarningRegular" FluentIcons) props
        static member inline checkmarkLockFilled (props: IIconProp list) = createElement (import "CheckmarkLockFilled" FluentIcons) props
        static member inline checkmarkLockRegular (props: IIconProp list) = createElement (import "CheckmarkLockRegular" FluentIcons) props
        static member inline checkmarkNoteFilled (props: IIconProp list) = createElement (import "CheckmarkNoteFilled" FluentIcons) props
        static member inline checkmarkNoteRegular (props: IIconProp list) = createElement (import "CheckmarkNoteRegular" FluentIcons) props
        static member inline checkmarkSquareFilled (props: IIconProp list) = createElement (import "CheckmarkSquareFilled" FluentIcons) props
        static member inline checkmarkSquareRegular (props: IIconProp list) = createElement (import "CheckmarkSquareRegular" FluentIcons) props
        static member inline checkmarkStarburstFilled (props: IIconProp list) = createElement (import "CheckmarkStarburstFilled" FluentIcons) props
        static member inline checkmarkStarburstRegular (props: IIconProp list) = createElement (import "CheckmarkStarburstRegular" FluentIcons) props
        static member inline checkmarkUnderlineCircleFilled (props: IIconProp list) = createElement (import "CheckmarkUnderlineCircleFilled" FluentIcons) props
        static member inline checkmarkUnderlineCircleRegular (props: IIconProp list) = createElement (import "CheckmarkUnderlineCircleRegular" FluentIcons) props
        static member inline chessFilled (props: IIconProp list) = createElement (import "ChessFilled" FluentIcons) props
        static member inline chessRegular (props: IIconProp list) = createElement (import "ChessRegular" FluentIcons) props
        static member inline chevronCircleDownFilled (props: IIconProp list) = createElement (import "ChevronCircleDownFilled" FluentIcons) props
        static member inline chevronCircleDownRegular (props: IIconProp list) = createElement (import "ChevronCircleDownRegular" FluentIcons) props
        static member inline chevronCircleLeftFilled (props: IIconProp list) = createElement (import "ChevronCircleLeftFilled" FluentIcons) props
        static member inline chevronCircleLeftRegular (props: IIconProp list) = createElement (import "ChevronCircleLeftRegular" FluentIcons) props
        static member inline chevronCircleRightFilled (props: IIconProp list) = createElement (import "ChevronCircleRightFilled" FluentIcons) props
        static member inline chevronCircleRightRegular (props: IIconProp list) = createElement (import "ChevronCircleRightRegular" FluentIcons) props
        static member inline chevronCircleUpFilled (props: IIconProp list) = createElement (import "ChevronCircleUpFilled" FluentIcons) props
        static member inline chevronCircleUpRegular (props: IIconProp list) = createElement (import "ChevronCircleUpRegular" FluentIcons) props
        static member inline chevronDoubleDownFilled (props: IIconProp list) = createElement (import "ChevronDoubleDownFilled" FluentIcons) props
        static member inline chevronDoubleDownRegular (props: IIconProp list) = createElement (import "ChevronDoubleDownRegular" FluentIcons) props
        static member inline chevronDoubleLeftFilled (props: IIconProp list) = createElement (import "ChevronDoubleLeftFilled" FluentIcons) props
        static member inline chevronDoubleLeftRegular (props: IIconProp list) = createElement (import "ChevronDoubleLeftRegular" FluentIcons) props
        static member inline chevronDoubleRightFilled (props: IIconProp list) = createElement (import "ChevronDoubleRightFilled" FluentIcons) props
        static member inline chevronDoubleRightRegular (props: IIconProp list) = createElement (import "ChevronDoubleRightRegular" FluentIcons) props
        static member inline chevronDoubleUpFilled (props: IIconProp list) = createElement (import "ChevronDoubleUpFilled" FluentIcons) props
        static member inline chevronDoubleUpRegular (props: IIconProp list) = createElement (import "ChevronDoubleUpRegular" FluentIcons) props
        static member inline chevronDownFilled (props: IIconProp list) = createElement (import "ChevronDownFilled" FluentIcons) props
        static member inline chevronDownRegular (props: IIconProp list) = createElement (import "ChevronDownRegular" FluentIcons) props
        static member inline chevronDownUpFilled (props: IIconProp list) = createElement (import "ChevronDownUpFilled" FluentIcons) props
        static member inline chevronDownUpRegular (props: IIconProp list) = createElement (import "ChevronDownUpRegular" FluentIcons) props
        static member inline chevronLeftFilled (props: IIconProp list) = createElement (import "ChevronLeftFilled" FluentIcons) props
        static member inline chevronLeftRegular (props: IIconProp list) = createElement (import "ChevronLeftRegular" FluentIcons) props
        static member inline chevronRightFilled (props: IIconProp list) = createElement (import "ChevronRightFilled" FluentIcons) props
        static member inline chevronRightRegular (props: IIconProp list) = createElement (import "ChevronRightRegular" FluentIcons) props
        static member inline chevronUpFilled (props: IIconProp list) = createElement (import "ChevronUpFilled" FluentIcons) props
        static member inline chevronUpRegular (props: IIconProp list) = createElement (import "ChevronUpRegular" FluentIcons) props
        static member inline chevronUpDownFilled (props: IIconProp list) = createElement (import "ChevronUpDownFilled" FluentIcons) props
        static member inline chevronUpDownRegular (props: IIconProp list) = createElement (import "ChevronUpDownRegular" FluentIcons) props
        static member inline circleFilled (props: IIconProp list) = createElement (import "CircleFilled" FluentIcons) props
        static member inline circleRegular (props: IIconProp list) = createElement (import "CircleRegular" FluentIcons) props
        static member inline circleEditFilled (props: IIconProp list) = createElement (import "CircleEditFilled" FluentIcons) props
        static member inline circleEditRegular (props: IIconProp list) = createElement (import "CircleEditRegular" FluentIcons) props
        static member inline circleEraserFilled (props: IIconProp list) = createElement (import "CircleEraserFilled" FluentIcons) props
        static member inline circleEraserRegular (props: IIconProp list) = createElement (import "CircleEraserRegular" FluentIcons) props
        static member inline circleHalfFillFilled (props: IIconProp list) = createElement (import "CircleHalfFillFilled" FluentIcons) props
        static member inline circleHalfFillRegular (props: IIconProp list) = createElement (import "CircleHalfFillRegular" FluentIcons) props
        static member inline circleHighlightFilled (props: IIconProp list) = createElement (import "CircleHighlightFilled" FluentIcons) props
        static member inline circleHighlightRegular (props: IIconProp list) = createElement (import "CircleHighlightRegular" FluentIcons) props
        static member inline circleHintFilled (props: IIconProp list) = createElement (import "CircleHintFilled" FluentIcons) props
        static member inline circleHintRegular (props: IIconProp list) = createElement (import "CircleHintRegular" FluentIcons) props
        static member inline circleHintHalfVerticalFilled (props: IIconProp list) = createElement (import "CircleHintHalfVerticalFilled" FluentIcons) props
        static member inline circleHintHalfVerticalRegular (props: IIconProp list) = createElement (import "CircleHintHalfVerticalRegular" FluentIcons) props
        static member inline circleImageFilled (props: IIconProp list) = createElement (import "CircleImageFilled" FluentIcons) props
        static member inline circleImageRegular (props: IIconProp list) = createElement (import "CircleImageRegular" FluentIcons) props
        static member inline circleLineFilled (props: IIconProp list) = createElement (import "CircleLineFilled" FluentIcons) props
        static member inline circleLineRegular (props: IIconProp list) = createElement (import "CircleLineRegular" FluentIcons) props
        static member inline circleMultipleSubtractCheckmarkFilled (props: IIconProp list) = createElement (import "CircleMultipleSubtractCheckmarkFilled" FluentIcons) props
        static member inline circleMultipleSubtractCheckmarkRegular (props: IIconProp list) = createElement (import "CircleMultipleSubtractCheckmarkRegular" FluentIcons) props
        static member inline circleOffFilled (props: IIconProp list) = createElement (import "CircleOffFilled" FluentIcons) props
        static member inline circleOffRegular (props: IIconProp list) = createElement (import "CircleOffRegular" FluentIcons) props
        static member inline circleShadowFilled (props: IIconProp list) = createElement (import "CircleShadowFilled" FluentIcons) props
        static member inline circleShadowRegular (props: IIconProp list) = createElement (import "CircleShadowRegular" FluentIcons) props
        static member inline circleSmallFilled (props: IIconProp list) = createElement (import "CircleSmallFilled" FluentIcons) props
        static member inline circleSmallRegular (props: IIconProp list) = createElement (import "CircleSmallRegular" FluentIcons) props
        static member inline cityFilled (props: IIconProp list) = createElement (import "CityFilled" FluentIcons) props
        static member inline cityRegular (props: IIconProp list) = createElement (import "CityRegular" FluentIcons) props
        static member inline classFilled (props: IIconProp list) = createElement (import "ClassFilled" FluentIcons) props
        static member inline classRegular (props: IIconProp list) = createElement (import "ClassRegular" FluentIcons) props
        static member inline classificationFilled (props: IIconProp list) = createElement (import "ClassificationFilled" FluentIcons) props
        static member inline classificationRegular (props: IIconProp list) = createElement (import "ClassificationRegular" FluentIcons) props
        static member inline clearFormattingFilled (props: IIconProp list) = createElement (import "ClearFormattingFilled" FluentIcons) props
        static member inline clearFormattingRegular (props: IIconProp list) = createElement (import "ClearFormattingRegular" FluentIcons) props
        static member inline clipboardFilled (props: IIconProp list) = createElement (import "ClipboardFilled" FluentIcons) props
        static member inline clipboardRegular (props: IIconProp list) = createElement (import "ClipboardRegular" FluentIcons) props
        static member inline clipboard3DayFilled (props: IIconProp list) = createElement (import "Clipboard3DayFilled" FluentIcons) props
        static member inline clipboard3DayRegular (props: IIconProp list) = createElement (import "Clipboard3DayRegular" FluentIcons) props
        static member inline clipboardArrowRightFilled (props: IIconProp list) = createElement (import "ClipboardArrowRightFilled" FluentIcons) props
        static member inline clipboardArrowRightRegular (props: IIconProp list) = createElement (import "ClipboardArrowRightRegular" FluentIcons) props
        static member inline clipboardBrushFilled (props: IIconProp list) = createElement (import "ClipboardBrushFilled" FluentIcons) props
        static member inline clipboardBrushRegular (props: IIconProp list) = createElement (import "ClipboardBrushRegular" FluentIcons) props
        static member inline clipboardBulletListFilled (props: IIconProp list) = createElement (import "ClipboardBulletListFilled" FluentIcons) props
        static member inline clipboardBulletListRegular (props: IIconProp list) = createElement (import "ClipboardBulletListRegular" FluentIcons) props
        static member inline clipboardBulletListLtrFilled (props: IIconProp list) = createElement (import "ClipboardBulletListLtrFilled" FluentIcons) props
        static member inline clipboardBulletListLtrRegular (props: IIconProp list) = createElement (import "ClipboardBulletListLtrRegular" FluentIcons) props
        static member inline clipboardBulletListRtlFilled (props: IIconProp list) = createElement (import "ClipboardBulletListRtlFilled" FluentIcons) props
        static member inline clipboardBulletListRtlRegular (props: IIconProp list) = createElement (import "ClipboardBulletListRtlRegular" FluentIcons) props
        static member inline clipboardCheckmarkFilled (props: IIconProp list) = createElement (import "ClipboardCheckmarkFilled" FluentIcons) props
        static member inline clipboardCheckmarkRegular (props: IIconProp list) = createElement (import "ClipboardCheckmarkRegular" FluentIcons) props
        static member inline clipboardClockFilled (props: IIconProp list) = createElement (import "ClipboardClockFilled" FluentIcons) props
        static member inline clipboardClockRegular (props: IIconProp list) = createElement (import "ClipboardClockRegular" FluentIcons) props
        static member inline clipboardCodeFilled (props: IIconProp list) = createElement (import "ClipboardCodeFilled" FluentIcons) props
        static member inline clipboardCodeRegular (props: IIconProp list) = createElement (import "ClipboardCodeRegular" FluentIcons) props
        static member inline clipboardDataBarFilled (props: IIconProp list) = createElement (import "ClipboardDataBarFilled" FluentIcons) props
        static member inline clipboardDataBarRegular (props: IIconProp list) = createElement (import "ClipboardDataBarRegular" FluentIcons) props
        static member inline clipboardDayFilled (props: IIconProp list) = createElement (import "ClipboardDayFilled" FluentIcons) props
        static member inline clipboardDayRegular (props: IIconProp list) = createElement (import "ClipboardDayRegular" FluentIcons) props
        static member inline clipboardEditFilled (props: IIconProp list) = createElement (import "ClipboardEditFilled" FluentIcons) props
        static member inline clipboardEditRegular (props: IIconProp list) = createElement (import "ClipboardEditRegular" FluentIcons) props
        static member inline clipboardErrorFilled (props: IIconProp list) = createElement (import "ClipboardErrorFilled" FluentIcons) props
        static member inline clipboardErrorRegular (props: IIconProp list) = createElement (import "ClipboardErrorRegular" FluentIcons) props
        static member inline clipboardHeartFilled (props: IIconProp list) = createElement (import "ClipboardHeartFilled" FluentIcons) props
        static member inline clipboardHeartRegular (props: IIconProp list) = createElement (import "ClipboardHeartRegular" FluentIcons) props
        static member inline clipboardImageFilled (props: IIconProp list) = createElement (import "ClipboardImageFilled" FluentIcons) props
        static member inline clipboardImageRegular (props: IIconProp list) = createElement (import "ClipboardImageRegular" FluentIcons) props
        static member inline clipboardLetterFilled (props: IIconProp list) = createElement (import "ClipboardLetterFilled" FluentIcons) props
        static member inline clipboardLetterRegular (props: IIconProp list) = createElement (import "ClipboardLetterRegular" FluentIcons) props
        static member inline clipboardLinkFilled (props: IIconProp list) = createElement (import "ClipboardLinkFilled" FluentIcons) props
        static member inline clipboardLinkRegular (props: IIconProp list) = createElement (import "ClipboardLinkRegular" FluentIcons) props
        static member inline clipboardMathFormulaFilled (props: IIconProp list) = createElement (import "ClipboardMathFormulaFilled" FluentIcons) props
        static member inline clipboardMathFormulaRegular (props: IIconProp list) = createElement (import "ClipboardMathFormulaRegular" FluentIcons) props
        static member inline clipboardMonthFilled (props: IIconProp list) = createElement (import "ClipboardMonthFilled" FluentIcons) props
        static member inline clipboardMonthRegular (props: IIconProp list) = createElement (import "ClipboardMonthRegular" FluentIcons) props
        static member inline clipboardMoreFilled (props: IIconProp list) = createElement (import "ClipboardMoreFilled" FluentIcons) props
        static member inline clipboardMoreRegular (props: IIconProp list) = createElement (import "ClipboardMoreRegular" FluentIcons) props
        static member inline clipboardNoteFilled (props: IIconProp list) = createElement (import "ClipboardNoteFilled" FluentIcons) props
        static member inline clipboardNoteRegular (props: IIconProp list) = createElement (import "ClipboardNoteRegular" FluentIcons) props
        static member inline clipboardNumber123Filled (props: IIconProp list) = createElement (import "ClipboardNumber123Filled" FluentIcons) props
        static member inline clipboardNumber123Regular (props: IIconProp list) = createElement (import "ClipboardNumber123Regular" FluentIcons) props
        static member inline clipboardPasteFilled (props: IIconProp list) = createElement (import "ClipboardPasteFilled" FluentIcons) props
        static member inline clipboardPasteRegular (props: IIconProp list) = createElement (import "ClipboardPasteRegular" FluentIcons) props
        static member inline clipboardPulseFilled (props: IIconProp list) = createElement (import "ClipboardPulseFilled" FluentIcons) props
        static member inline clipboardPulseRegular (props: IIconProp list) = createElement (import "ClipboardPulseRegular" FluentIcons) props
        static member inline clipboardSearchFilled (props: IIconProp list) = createElement (import "ClipboardSearchFilled" FluentIcons) props
        static member inline clipboardSearchRegular (props: IIconProp list) = createElement (import "ClipboardSearchRegular" FluentIcons) props
        static member inline clipboardSettingsFilled (props: IIconProp list) = createElement (import "ClipboardSettingsFilled" FluentIcons) props
        static member inline clipboardSettingsRegular (props: IIconProp list) = createElement (import "ClipboardSettingsRegular" FluentIcons) props
        static member inline clipboardTaskFilled (props: IIconProp list) = createElement (import "ClipboardTaskFilled" FluentIcons) props
        static member inline clipboardTaskRegular (props: IIconProp list) = createElement (import "ClipboardTaskRegular" FluentIcons) props
        static member inline clipboardTaskAddFilled (props: IIconProp list) = createElement (import "ClipboardTaskAddFilled" FluentIcons) props
        static member inline clipboardTaskAddRegular (props: IIconProp list) = createElement (import "ClipboardTaskAddRegular" FluentIcons) props
        static member inline clipboardTaskListLtrFilled (props: IIconProp list) = createElement (import "ClipboardTaskListLtrFilled" FluentIcons) props
        static member inline clipboardTaskListLtrRegular (props: IIconProp list) = createElement (import "ClipboardTaskListLtrRegular" FluentIcons) props
        static member inline clipboardTaskListRtlFilled (props: IIconProp list) = createElement (import "ClipboardTaskListRtlFilled" FluentIcons) props
        static member inline clipboardTaskListRtlRegular (props: IIconProp list) = createElement (import "ClipboardTaskListRtlRegular" FluentIcons) props
        static member inline clipboardTextEditFilled (props: IIconProp list) = createElement (import "ClipboardTextEditFilled" FluentIcons) props
        static member inline clipboardTextEditRegular (props: IIconProp list) = createElement (import "ClipboardTextEditRegular" FluentIcons) props
        static member inline clipboardTextLtrFilled (props: IIconProp list) = createElement (import "ClipboardTextLtrFilled" FluentIcons) props
        static member inline clipboardTextLtrRegular (props: IIconProp list) = createElement (import "ClipboardTextLtrRegular" FluentIcons) props
        static member inline clipboardTextRtlFilled (props: IIconProp list) = createElement (import "ClipboardTextRtlFilled" FluentIcons) props
        static member inline clipboardTextRtlRegular (props: IIconProp list) = createElement (import "ClipboardTextRtlRegular" FluentIcons) props
        static member inline clockFilled (props: IIconProp list) = createElement (import "ClockFilled" FluentIcons) props
        static member inline clockRegular (props: IIconProp list) = createElement (import "ClockRegular" FluentIcons) props
        static member inline clockAlarmFilled (props: IIconProp list) = createElement (import "ClockAlarmFilled" FluentIcons) props
        static member inline clockAlarmRegular (props: IIconProp list) = createElement (import "ClockAlarmRegular" FluentIcons) props
        static member inline clockArrowDownloadFilled (props: IIconProp list) = createElement (import "ClockArrowDownloadFilled" FluentIcons) props
        static member inline clockArrowDownloadRegular (props: IIconProp list) = createElement (import "ClockArrowDownloadRegular" FluentIcons) props
        static member inline clockBillFilled (props: IIconProp list) = createElement (import "ClockBillFilled" FluentIcons) props
        static member inline clockBillRegular (props: IIconProp list) = createElement (import "ClockBillRegular" FluentIcons) props
        static member inline clockDismissFilled (props: IIconProp list) = createElement (import "ClockDismissFilled" FluentIcons) props
        static member inline clockDismissRegular (props: IIconProp list) = createElement (import "ClockDismissRegular" FluentIcons) props
        static member inline clockLockFilled (props: IIconProp list) = createElement (import "ClockLockFilled" FluentIcons) props
        static member inline clockLockRegular (props: IIconProp list) = createElement (import "ClockLockRegular" FluentIcons) props
        static member inline clockPauseFilled (props: IIconProp list) = createElement (import "ClockPauseFilled" FluentIcons) props
        static member inline clockPauseRegular (props: IIconProp list) = createElement (import "ClockPauseRegular" FluentIcons) props
        static member inline clockToolboxFilled (props: IIconProp list) = createElement (import "ClockToolboxFilled" FluentIcons) props
        static member inline clockToolboxRegular (props: IIconProp list) = createElement (import "ClockToolboxRegular" FluentIcons) props
        static member inline closedCaptionFilled (props: IIconProp list) = createElement (import "ClosedCaptionFilled" FluentIcons) props
        static member inline closedCaptionRegular (props: IIconProp list) = createElement (import "ClosedCaptionRegular" FluentIcons) props
        static member inline closedCaptionOffFilled (props: IIconProp list) = createElement (import "ClosedCaptionOffFilled" FluentIcons) props
        static member inline closedCaptionOffRegular (props: IIconProp list) = createElement (import "ClosedCaptionOffRegular" FluentIcons) props
        static member inline cloudFilled (props: IIconProp list) = createElement (import "CloudFilled" FluentIcons) props
        static member inline cloudRegular (props: IIconProp list) = createElement (import "CloudRegular" FluentIcons) props
        static member inline cloudAddFilled (props: IIconProp list) = createElement (import "CloudAddFilled" FluentIcons) props
        static member inline cloudAddRegular (props: IIconProp list) = createElement (import "CloudAddRegular" FluentIcons) props
        static member inline cloudArchiveFilled (props: IIconProp list) = createElement (import "CloudArchiveFilled" FluentIcons) props
        static member inline cloudArchiveRegular (props: IIconProp list) = createElement (import "CloudArchiveRegular" FluentIcons) props
        static member inline cloudArrowDownFilled (props: IIconProp list) = createElement (import "CloudArrowDownFilled" FluentIcons) props
        static member inline cloudArrowDownRegular (props: IIconProp list) = createElement (import "CloudArrowDownRegular" FluentIcons) props
        static member inline cloudArrowRightFilled (props: IIconProp list) = createElement (import "CloudArrowRightFilled" FluentIcons) props
        static member inline cloudArrowRightRegular (props: IIconProp list) = createElement (import "CloudArrowRightRegular" FluentIcons) props
        static member inline cloudArrowUpFilled (props: IIconProp list) = createElement (import "CloudArrowUpFilled" FluentIcons) props
        static member inline cloudArrowUpRegular (props: IIconProp list) = createElement (import "CloudArrowUpRegular" FluentIcons) props
        static member inline cloudBeakerFilled (props: IIconProp list) = createElement (import "CloudBeakerFilled" FluentIcons) props
        static member inline cloudBeakerRegular (props: IIconProp list) = createElement (import "CloudBeakerRegular" FluentIcons) props
        static member inline cloudBidirectionalFilled (props: IIconProp list) = createElement (import "CloudBidirectionalFilled" FluentIcons) props
        static member inline cloudBidirectionalRegular (props: IIconProp list) = createElement (import "CloudBidirectionalRegular" FluentIcons) props
        static member inline cloudCheckmarkFilled (props: IIconProp list) = createElement (import "CloudCheckmarkFilled" FluentIcons) props
        static member inline cloudCheckmarkRegular (props: IIconProp list) = createElement (import "CloudCheckmarkRegular" FluentIcons) props
        static member inline cloudCubeFilled (props: IIconProp list) = createElement (import "CloudCubeFilled" FluentIcons) props
        static member inline cloudCubeRegular (props: IIconProp list) = createElement (import "CloudCubeRegular" FluentIcons) props
        static member inline cloudDatabaseFilled (props: IIconProp list) = createElement (import "CloudDatabaseFilled" FluentIcons) props
        static member inline cloudDatabaseRegular (props: IIconProp list) = createElement (import "CloudDatabaseRegular" FluentIcons) props
        static member inline cloudDesktopFilled (props: IIconProp list) = createElement (import "CloudDesktopFilled" FluentIcons) props
        static member inline cloudDesktopRegular (props: IIconProp list) = createElement (import "CloudDesktopRegular" FluentIcons) props
        static member inline cloudDismissFilled (props: IIconProp list) = createElement (import "CloudDismissFilled" FluentIcons) props
        static member inline cloudDismissRegular (props: IIconProp list) = createElement (import "CloudDismissRegular" FluentIcons) props
        static member inline cloudEditFilled (props: IIconProp list) = createElement (import "CloudEditFilled" FluentIcons) props
        static member inline cloudEditRegular (props: IIconProp list) = createElement (import "CloudEditRegular" FluentIcons) props
        static member inline cloudErrorFilled (props: IIconProp list) = createElement (import "CloudErrorFilled" FluentIcons) props
        static member inline cloudErrorRegular (props: IIconProp list) = createElement (import "CloudErrorRegular" FluentIcons) props
        static member inline cloudFlowFilled (props: IIconProp list) = createElement (import "CloudFlowFilled" FluentIcons) props
        static member inline cloudFlowRegular (props: IIconProp list) = createElement (import "CloudFlowRegular" FluentIcons) props
        static member inline cloudLinkFilled (props: IIconProp list) = createElement (import "CloudLinkFilled" FluentIcons) props
        static member inline cloudLinkRegular (props: IIconProp list) = createElement (import "CloudLinkRegular" FluentIcons) props
        static member inline cloudOffFilled (props: IIconProp list) = createElement (import "CloudOffFilled" FluentIcons) props
        static member inline cloudOffRegular (props: IIconProp list) = createElement (import "CloudOffRegular" FluentIcons) props
        static member inline cloudSwapFilled (props: IIconProp list) = createElement (import "CloudSwapFilled" FluentIcons) props
        static member inline cloudSwapRegular (props: IIconProp list) = createElement (import "CloudSwapRegular" FluentIcons) props
        static member inline cloudSyncFilled (props: IIconProp list) = createElement (import "CloudSyncFilled" FluentIcons) props
        static member inline cloudSyncRegular (props: IIconProp list) = createElement (import "CloudSyncRegular" FluentIcons) props
        static member inline cloudWordsFilled (props: IIconProp list) = createElement (import "CloudWordsFilled" FluentIcons) props
        static member inline cloudWordsRegular (props: IIconProp list) = createElement (import "CloudWordsRegular" FluentIcons) props
        static member inline cloverFilled (props: IIconProp list) = createElement (import "CloverFilled" FluentIcons) props
        static member inline cloverRegular (props: IIconProp list) = createElement (import "CloverRegular" FluentIcons) props
        static member inline codeFilled (props: IIconProp list) = createElement (import "CodeFilled" FluentIcons) props
        static member inline codeRegular (props: IIconProp list) = createElement (import "CodeRegular" FluentIcons) props
        static member inline codeBlockFilled (props: IIconProp list) = createElement (import "CodeBlockFilled" FluentIcons) props
        static member inline codeBlockRegular (props: IIconProp list) = createElement (import "CodeBlockRegular" FluentIcons) props
        static member inline codeCircleFilled (props: IIconProp list) = createElement (import "CodeCircleFilled" FluentIcons) props
        static member inline codeCircleRegular (props: IIconProp list) = createElement (import "CodeCircleRegular" FluentIcons) props
        static member inline codeTextFilled (props: IIconProp list) = createElement (import "CodeTextFilled" FluentIcons) props
        static member inline codeTextRegular (props: IIconProp list) = createElement (import "CodeTextRegular" FluentIcons) props
        static member inline codeTextEditFilled (props: IIconProp list) = createElement (import "CodeTextEditFilled" FluentIcons) props
        static member inline codeTextEditRegular (props: IIconProp list) = createElement (import "CodeTextEditRegular" FluentIcons) props
        static member inline coinStackFilled (props: IIconProp list) = createElement (import "CoinStackFilled" FluentIcons) props
        static member inline coinStackRegular (props: IIconProp list) = createElement (import "CoinStackRegular" FluentIcons) props
        static member inline collectionsFilled (props: IIconProp list) = createElement (import "CollectionsFilled" FluentIcons) props
        static member inline collectionsRegular (props: IIconProp list) = createElement (import "CollectionsRegular" FluentIcons) props
        static member inline collectionsAddFilled (props: IIconProp list) = createElement (import "CollectionsAddFilled" FluentIcons) props
        static member inline collectionsAddRegular (props: IIconProp list) = createElement (import "CollectionsAddRegular" FluentIcons) props
        static member inline colorFilled (props: IIconProp list) = createElement (import "ColorFilled" FluentIcons) props
        static member inline colorRegular (props: IIconProp list) = createElement (import "ColorRegular" FluentIcons) props
        static member inline colorBackgroundFilled (props: IIconProp list) = createElement (import "ColorBackgroundFilled" FluentIcons) props
        static member inline colorBackgroundRegular (props: IIconProp list) = createElement (import "ColorBackgroundRegular" FluentIcons) props
        static member inline colorBackgroundAccentRegular (props: IIconProp list) = createElement (import "ColorBackgroundAccentRegular" FluentIcons) props
        static member inline colorFillFilled (props: IIconProp list) = createElement (import "ColorFillFilled" FluentIcons) props
        static member inline colorFillRegular (props: IIconProp list) = createElement (import "ColorFillRegular" FluentIcons) props
        static member inline colorFillAccentRegular (props: IIconProp list) = createElement (import "ColorFillAccentRegular" FluentIcons) props
        static member inline colorLineFilled (props: IIconProp list) = createElement (import "ColorLineFilled" FluentIcons) props
        static member inline colorLineRegular (props: IIconProp list) = createElement (import "ColorLineRegular" FluentIcons) props
        static member inline colorLineAccentRegular (props: IIconProp list) = createElement (import "ColorLineAccentRegular" FluentIcons) props
        static member inline columnFilled (props: IIconProp list) = createElement (import "ColumnFilled" FluentIcons) props
        static member inline columnRegular (props: IIconProp list) = createElement (import "ColumnRegular" FluentIcons) props
        static member inline columnArrowRightFilled (props: IIconProp list) = createElement (import "ColumnArrowRightFilled" FluentIcons) props
        static member inline columnArrowRightRegular (props: IIconProp list) = createElement (import "ColumnArrowRightRegular" FluentIcons) props
        static member inline columnDoubleCompareFilled (props: IIconProp list) = createElement (import "ColumnDoubleCompareFilled" FluentIcons) props
        static member inline columnDoubleCompareRegular (props: IIconProp list) = createElement (import "ColumnDoubleCompareRegular" FluentIcons) props
        static member inline columnEditFilled (props: IIconProp list) = createElement (import "ColumnEditFilled" FluentIcons) props
        static member inline columnEditRegular (props: IIconProp list) = createElement (import "ColumnEditRegular" FluentIcons) props
        static member inline columnSingleCompareFilled (props: IIconProp list) = createElement (import "ColumnSingleCompareFilled" FluentIcons) props
        static member inline columnSingleCompareRegular (props: IIconProp list) = createElement (import "ColumnSingleCompareRegular" FluentIcons) props
        static member inline columnTripleFilled (props: IIconProp list) = createElement (import "ColumnTripleFilled" FluentIcons) props
        static member inline columnTripleRegular (props: IIconProp list) = createElement (import "ColumnTripleRegular" FluentIcons) props
        static member inline columnTripleEditFilled (props: IIconProp list) = createElement (import "ColumnTripleEditFilled" FluentIcons) props
        static member inline columnTripleEditRegular (props: IIconProp list) = createElement (import "ColumnTripleEditRegular" FluentIcons) props
        static member inline commaFilled (props: IIconProp list) = createElement (import "CommaFilled" FluentIcons) props
        static member inline commaRegular (props: IIconProp list) = createElement (import "CommaRegular" FluentIcons) props
        static member inline commentFilled (props: IIconProp list) = createElement (import "CommentFilled" FluentIcons) props
        static member inline commentRegular (props: IIconProp list) = createElement (import "CommentRegular" FluentIcons) props
        static member inline commentAddFilled (props: IIconProp list) = createElement (import "CommentAddFilled" FluentIcons) props
        static member inline commentAddRegular (props: IIconProp list) = createElement (import "CommentAddRegular" FluentIcons) props
        static member inline commentArrowLeftFilled (props: IIconProp list) = createElement (import "CommentArrowLeftFilled" FluentIcons) props
        static member inline commentArrowLeftRegular (props: IIconProp list) = createElement (import "CommentArrowLeftRegular" FluentIcons) props
        static member inline commentArrowRightFilled (props: IIconProp list) = createElement (import "CommentArrowRightFilled" FluentIcons) props
        static member inline commentArrowRightRegular (props: IIconProp list) = createElement (import "CommentArrowRightRegular" FluentIcons) props
        static member inline commentCheckmarkFilled (props: IIconProp list) = createElement (import "CommentCheckmarkFilled" FluentIcons) props
        static member inline commentCheckmarkRegular (props: IIconProp list) = createElement (import "CommentCheckmarkRegular" FluentIcons) props
        static member inline commentDismissFilled (props: IIconProp list) = createElement (import "CommentDismissFilled" FluentIcons) props
        static member inline commentDismissRegular (props: IIconProp list) = createElement (import "CommentDismissRegular" FluentIcons) props
        static member inline commentEditFilled (props: IIconProp list) = createElement (import "CommentEditFilled" FluentIcons) props
        static member inline commentEditRegular (props: IIconProp list) = createElement (import "CommentEditRegular" FluentIcons) props
        static member inline commentErrorFilled (props: IIconProp list) = createElement (import "CommentErrorFilled" FluentIcons) props
        static member inline commentErrorRegular (props: IIconProp list) = createElement (import "CommentErrorRegular" FluentIcons) props
        static member inline commentLightningFilled (props: IIconProp list) = createElement (import "CommentLightningFilled" FluentIcons) props
        static member inline commentLightningRegular (props: IIconProp list) = createElement (import "CommentLightningRegular" FluentIcons) props
        static member inline commentLinkFilled (props: IIconProp list) = createElement (import "CommentLinkFilled" FluentIcons) props
        static member inline commentLinkRegular (props: IIconProp list) = createElement (import "CommentLinkRegular" FluentIcons) props
        static member inline commentMentionFilled (props: IIconProp list) = createElement (import "CommentMentionFilled" FluentIcons) props
        static member inline commentMentionRegular (props: IIconProp list) = createElement (import "CommentMentionRegular" FluentIcons) props
        static member inline commentMultipleFilled (props: IIconProp list) = createElement (import "CommentMultipleFilled" FluentIcons) props
        static member inline commentMultipleRegular (props: IIconProp list) = createElement (import "CommentMultipleRegular" FluentIcons) props
        static member inline commentMultipleCheckmarkFilled (props: IIconProp list) = createElement (import "CommentMultipleCheckmarkFilled" FluentIcons) props
        static member inline commentMultipleCheckmarkRegular (props: IIconProp list) = createElement (import "CommentMultipleCheckmarkRegular" FluentIcons) props
        static member inline commentMultipleLinkFilled (props: IIconProp list) = createElement (import "CommentMultipleLinkFilled" FluentIcons) props
        static member inline commentMultipleLinkRegular (props: IIconProp list) = createElement (import "CommentMultipleLinkRegular" FluentIcons) props
        static member inline commentNoteFilled (props: IIconProp list) = createElement (import "CommentNoteFilled" FluentIcons) props
        static member inline commentNoteRegular (props: IIconProp list) = createElement (import "CommentNoteRegular" FluentIcons) props
        static member inline commentOffFilled (props: IIconProp list) = createElement (import "CommentOffFilled" FluentIcons) props
        static member inline commentOffRegular (props: IIconProp list) = createElement (import "CommentOffRegular" FluentIcons) props
        static member inline communicationFilled (props: IIconProp list) = createElement (import "CommunicationFilled" FluentIcons) props
        static member inline communicationRegular (props: IIconProp list) = createElement (import "CommunicationRegular" FluentIcons) props
        static member inline communicationPersonFilled (props: IIconProp list) = createElement (import "CommunicationPersonFilled" FluentIcons) props
        static member inline communicationPersonRegular (props: IIconProp list) = createElement (import "CommunicationPersonRegular" FluentIcons) props
        static member inline communicationShieldFilled (props: IIconProp list) = createElement (import "CommunicationShieldFilled" FluentIcons) props
        static member inline communicationShieldRegular (props: IIconProp list) = createElement (import "CommunicationShieldRegular" FluentIcons) props
        static member inline compassNorthwestFilled (props: IIconProp list) = createElement (import "CompassNorthwestFilled" FluentIcons) props
        static member inline compassNorthwestRegular (props: IIconProp list) = createElement (import "CompassNorthwestRegular" FluentIcons) props
        static member inline composeFilled (props: IIconProp list) = createElement (import "ComposeFilled" FluentIcons) props
        static member inline composeRegular (props: IIconProp list) = createElement (import "ComposeRegular" FluentIcons) props
        static member inline conferenceRoomFilled (props: IIconProp list) = createElement (import "ConferenceRoomFilled" FluentIcons) props
        static member inline conferenceRoomRegular (props: IIconProp list) = createElement (import "ConferenceRoomRegular" FluentIcons) props
        static member inline connectedFilled (props: IIconProp list) = createElement (import "ConnectedFilled" FluentIcons) props
        static member inline connectedRegular (props: IIconProp list) = createElement (import "ConnectedRegular" FluentIcons) props
        static member inline connectorFilled (props: IIconProp list) = createElement (import "ConnectorFilled" FluentIcons) props
        static member inline connectorRegular (props: IIconProp list) = createElement (import "ConnectorRegular" FluentIcons) props
        static member inline contactCardFilled (props: IIconProp list) = createElement (import "ContactCardFilled" FluentIcons) props
        static member inline contactCardRegular (props: IIconProp list) = createElement (import "ContactCardRegular" FluentIcons) props
        static member inline contactCardGroupFilled (props: IIconProp list) = createElement (import "ContactCardGroupFilled" FluentIcons) props
        static member inline contactCardGroupRegular (props: IIconProp list) = createElement (import "ContactCardGroupRegular" FluentIcons) props
        static member inline contactCardLinkFilled (props: IIconProp list) = createElement (import "ContactCardLinkFilled" FluentIcons) props
        static member inline contactCardLinkRegular (props: IIconProp list) = createElement (import "ContactCardLinkRegular" FluentIcons) props
        static member inline contactCardRibbonFilled (props: IIconProp list) = createElement (import "ContactCardRibbonFilled" FluentIcons) props
        static member inline contactCardRibbonRegular (props: IIconProp list) = createElement (import "ContactCardRibbonRegular" FluentIcons) props
        static member inline contentSettingsFilled (props: IIconProp list) = createElement (import "ContentSettingsFilled" FluentIcons) props
        static member inline contentSettingsRegular (props: IIconProp list) = createElement (import "ContentSettingsRegular" FluentIcons) props
        static member inline contentViewFilled (props: IIconProp list) = createElement (import "ContentViewFilled" FluentIcons) props
        static member inline contentViewRegular (props: IIconProp list) = createElement (import "ContentViewRegular" FluentIcons) props
        static member inline contentViewGalleryFilled (props: IIconProp list) = createElement (import "ContentViewGalleryFilled" FluentIcons) props
        static member inline contentViewGalleryRegular (props: IIconProp list) = createElement (import "ContentViewGalleryRegular" FluentIcons) props
        static member inline contentViewGalleryLightningFilled (props: IIconProp list) = createElement (import "ContentViewGalleryLightningFilled" FluentIcons) props
        static member inline contentViewGalleryLightningRegular (props: IIconProp list) = createElement (import "ContentViewGalleryLightningRegular" FluentIcons) props
        static member inline contractDownLeftFilled (props: IIconProp list) = createElement (import "ContractDownLeftFilled" FluentIcons) props
        static member inline contractDownLeftRegular (props: IIconProp list) = createElement (import "ContractDownLeftRegular" FluentIcons) props
        static member inline contractUpRightFilled (props: IIconProp list) = createElement (import "ContractUpRightFilled" FluentIcons) props
        static member inline contractUpRightRegular (props: IIconProp list) = createElement (import "ContractUpRightRegular" FluentIcons) props
        static member inline controlButtonFilled (props: IIconProp list) = createElement (import "ControlButtonFilled" FluentIcons) props
        static member inline controlButtonRegular (props: IIconProp list) = createElement (import "ControlButtonRegular" FluentIcons) props
        static member inline convertRangeFilled (props: IIconProp list) = createElement (import "ConvertRangeFilled" FluentIcons) props
        static member inline convertRangeRegular (props: IIconProp list) = createElement (import "ConvertRangeRegular" FluentIcons) props
        static member inline cookiesFilled (props: IIconProp list) = createElement (import "CookiesFilled" FluentIcons) props
        static member inline cookiesRegular (props: IIconProp list) = createElement (import "CookiesRegular" FluentIcons) props
        static member inline copyFilled (props: IIconProp list) = createElement (import "CopyFilled" FluentIcons) props
        static member inline copyRegular (props: IIconProp list) = createElement (import "CopyRegular" FluentIcons) props
        static member inline copyAddFilled (props: IIconProp list) = createElement (import "CopyAddFilled" FluentIcons) props
        static member inline copyAddRegular (props: IIconProp list) = createElement (import "CopyAddRegular" FluentIcons) props
        static member inline copyArrowRightFilled (props: IIconProp list) = createElement (import "CopyArrowRightFilled" FluentIcons) props
        static member inline copyArrowRightRegular (props: IIconProp list) = createElement (import "CopyArrowRightRegular" FluentIcons) props
        static member inline copySelectFilled (props: IIconProp list) = createElement (import "CopySelectFilled" FluentIcons) props
        static member inline copySelectRegular (props: IIconProp list) = createElement (import "CopySelectRegular" FluentIcons) props
        static member inline couchFilled (props: IIconProp list) = createElement (import "CouchFilled" FluentIcons) props
        static member inline couchRegular (props: IIconProp list) = createElement (import "CouchRegular" FluentIcons) props
        static member inline creditCardClockFilled (props: IIconProp list) = createElement (import "CreditCardClockFilled" FluentIcons) props
        static member inline creditCardClockRegular (props: IIconProp list) = createElement (import "CreditCardClockRegular" FluentIcons) props
        static member inline creditCardPersonFilled (props: IIconProp list) = createElement (import "CreditCardPersonFilled" FluentIcons) props
        static member inline creditCardPersonRegular (props: IIconProp list) = createElement (import "CreditCardPersonRegular" FluentIcons) props
        static member inline creditCardToolboxFilled (props: IIconProp list) = createElement (import "CreditCardToolboxFilled" FluentIcons) props
        static member inline creditCardToolboxRegular (props: IIconProp list) = createElement (import "CreditCardToolboxRegular" FluentIcons) props
        static member inline cropFilled (props: IIconProp list) = createElement (import "CropFilled" FluentIcons) props
        static member inline cropRegular (props: IIconProp list) = createElement (import "CropRegular" FluentIcons) props
        static member inline cropArrowRotateFilled (props: IIconProp list) = createElement (import "CropArrowRotateFilled" FluentIcons) props
        static member inline cropArrowRotateRegular (props: IIconProp list) = createElement (import "CropArrowRotateRegular" FluentIcons) props
        static member inline cropInterimFilled (props: IIconProp list) = createElement (import "CropInterimFilled" FluentIcons) props
        static member inline cropInterimRegular (props: IIconProp list) = createElement (import "CropInterimRegular" FluentIcons) props
        static member inline cropInterimOffFilled (props: IIconProp list) = createElement (import "CropInterimOffFilled" FluentIcons) props
        static member inline cropInterimOffRegular (props: IIconProp list) = createElement (import "CropInterimOffRegular" FluentIcons) props
        static member inline crownFilled (props: IIconProp list) = createElement (import "CrownFilled" FluentIcons) props
        static member inline crownRegular (props: IIconProp list) = createElement (import "CrownRegular" FluentIcons) props
        static member inline cubeFilled (props: IIconProp list) = createElement (import "CubeFilled" FluentIcons) props
        static member inline cubeRegular (props: IIconProp list) = createElement (import "CubeRegular" FluentIcons) props
        static member inline cubeAddFilled (props: IIconProp list) = createElement (import "CubeAddFilled" FluentIcons) props
        static member inline cubeAddRegular (props: IIconProp list) = createElement (import "CubeAddRegular" FluentIcons) props
        static member inline cubeArrowCurveDownFilled (props: IIconProp list) = createElement (import "CubeArrowCurveDownFilled" FluentIcons) props
        static member inline cubeArrowCurveDownRegular (props: IIconProp list) = createElement (import "CubeArrowCurveDownRegular" FluentIcons) props
        static member inline cubeLinkFilled (props: IIconProp list) = createElement (import "CubeLinkFilled" FluentIcons) props
        static member inline cubeLinkRegular (props: IIconProp list) = createElement (import "CubeLinkRegular" FluentIcons) props
        static member inline cubeMultipleFilled (props: IIconProp list) = createElement (import "CubeMultipleFilled" FluentIcons) props
        static member inline cubeMultipleRegular (props: IIconProp list) = createElement (import "CubeMultipleRegular" FluentIcons) props
        static member inline cubeQuickFilled (props: IIconProp list) = createElement (import "CubeQuickFilled" FluentIcons) props
        static member inline cubeQuickRegular (props: IIconProp list) = createElement (import "CubeQuickRegular" FluentIcons) props
        static member inline cubeRotateFilled (props: IIconProp list) = createElement (import "CubeRotateFilled" FluentIcons) props
        static member inline cubeRotateRegular (props: IIconProp list) = createElement (import "CubeRotateRegular" FluentIcons) props
        static member inline cubeSyncFilled (props: IIconProp list) = createElement (import "CubeSyncFilled" FluentIcons) props
        static member inline cubeSyncRegular (props: IIconProp list) = createElement (import "CubeSyncRegular" FluentIcons) props
        static member inline cubeTreeFilled (props: IIconProp list) = createElement (import "CubeTreeFilled" FluentIcons) props
        static member inline cubeTreeRegular (props: IIconProp list) = createElement (import "CubeTreeRegular" FluentIcons) props
        static member inline currencyDollarEuroFilled (props: IIconProp list) = createElement (import "CurrencyDollarEuroFilled" FluentIcons) props
        static member inline currencyDollarEuroRegular (props: IIconProp list) = createElement (import "CurrencyDollarEuroRegular" FluentIcons) props
        static member inline currencyDollarRupeeFilled (props: IIconProp list) = createElement (import "CurrencyDollarRupeeFilled" FluentIcons) props
        static member inline currencyDollarRupeeRegular (props: IIconProp list) = createElement (import "CurrencyDollarRupeeRegular" FluentIcons) props
        static member inline cursorFilled (props: IIconProp list) = createElement (import "CursorFilled" FluentIcons) props
        static member inline cursorRegular (props: IIconProp list) = createElement (import "CursorRegular" FluentIcons) props
        static member inline cursorClickFilled (props: IIconProp list) = createElement (import "CursorClickFilled" FluentIcons) props
        static member inline cursorClickRegular (props: IIconProp list) = createElement (import "CursorClickRegular" FluentIcons) props
        static member inline cursorHoverFilled (props: IIconProp list) = createElement (import "CursorHoverFilled" FluentIcons) props
        static member inline cursorHoverRegular (props: IIconProp list) = createElement (import "CursorHoverRegular" FluentIcons) props
        static member inline cursorHoverOffFilled (props: IIconProp list) = createElement (import "CursorHoverOffFilled" FluentIcons) props
        static member inline cursorHoverOffRegular (props: IIconProp list) = createElement (import "CursorHoverOffRegular" FluentIcons) props
        static member inline cursorProhibitedFilled (props: IIconProp list) = createElement (import "CursorProhibitedFilled" FluentIcons) props
        static member inline cursorProhibitedRegular (props: IIconProp list) = createElement (import "CursorProhibitedRegular" FluentIcons) props
        static member inline cutFilled (props: IIconProp list) = createElement (import "CutFilled" FluentIcons) props
        static member inline cutRegular (props: IIconProp list) = createElement (import "CutRegular" FluentIcons) props
        static member inline darkThemeFilled (props: IIconProp list) = createElement (import "DarkThemeFilled" FluentIcons) props
        static member inline darkThemeRegular (props: IIconProp list) = createElement (import "DarkThemeRegular" FluentIcons) props
        static member inline dataAreaFilled (props: IIconProp list) = createElement (import "DataAreaFilled" FluentIcons) props
        static member inline dataAreaRegular (props: IIconProp list) = createElement (import "DataAreaRegular" FluentIcons) props
        static member inline dataBarHorizontalFilled (props: IIconProp list) = createElement (import "DataBarHorizontalFilled" FluentIcons) props
        static member inline dataBarHorizontalRegular (props: IIconProp list) = createElement (import "DataBarHorizontalRegular" FluentIcons) props
        static member inline dataBarVerticalFilled (props: IIconProp list) = createElement (import "DataBarVerticalFilled" FluentIcons) props
        static member inline dataBarVerticalRegular (props: IIconProp list) = createElement (import "DataBarVerticalRegular" FluentIcons) props
        static member inline dataBarVerticalAddFilled (props: IIconProp list) = createElement (import "DataBarVerticalAddFilled" FluentIcons) props
        static member inline dataBarVerticalAddRegular (props: IIconProp list) = createElement (import "DataBarVerticalAddRegular" FluentIcons) props
        static member inline dataBarVerticalArrowDownFilled (props: IIconProp list) = createElement (import "DataBarVerticalArrowDownFilled" FluentIcons) props
        static member inline dataBarVerticalArrowDownRegular (props: IIconProp list) = createElement (import "DataBarVerticalArrowDownRegular" FluentIcons) props
        static member inline dataBarVerticalAscendingFilled (props: IIconProp list) = createElement (import "DataBarVerticalAscendingFilled" FluentIcons) props
        static member inline dataBarVerticalAscendingRegular (props: IIconProp list) = createElement (import "DataBarVerticalAscendingRegular" FluentIcons) props
        static member inline dataBarVerticalStarFilled (props: IIconProp list) = createElement (import "DataBarVerticalStarFilled" FluentIcons) props
        static member inline dataBarVerticalStarRegular (props: IIconProp list) = createElement (import "DataBarVerticalStarRegular" FluentIcons) props
        static member inline dataFunnelFilled (props: IIconProp list) = createElement (import "DataFunnelFilled" FluentIcons) props
        static member inline dataFunnelRegular (props: IIconProp list) = createElement (import "DataFunnelRegular" FluentIcons) props
        static member inline dataHistogramFilled (props: IIconProp list) = createElement (import "DataHistogramFilled" FluentIcons) props
        static member inline dataHistogramRegular (props: IIconProp list) = createElement (import "DataHistogramRegular" FluentIcons) props
        static member inline dataLineFilled (props: IIconProp list) = createElement (import "DataLineFilled" FluentIcons) props
        static member inline dataLineRegular (props: IIconProp list) = createElement (import "DataLineRegular" FluentIcons) props
        static member inline dataPieFilled (props: IIconProp list) = createElement (import "DataPieFilled" FluentIcons) props
        static member inline dataPieRegular (props: IIconProp list) = createElement (import "DataPieRegular" FluentIcons) props
        static member inline dataScatterFilled (props: IIconProp list) = createElement (import "DataScatterFilled" FluentIcons) props
        static member inline dataScatterRegular (props: IIconProp list) = createElement (import "DataScatterRegular" FluentIcons) props
        static member inline dataSunburstFilled (props: IIconProp list) = createElement (import "DataSunburstFilled" FluentIcons) props
        static member inline dataSunburstRegular (props: IIconProp list) = createElement (import "DataSunburstRegular" FluentIcons) props
        static member inline dataTreemapFilled (props: IIconProp list) = createElement (import "DataTreemapFilled" FluentIcons) props
        static member inline dataTreemapRegular (props: IIconProp list) = createElement (import "DataTreemapRegular" FluentIcons) props
        static member inline dataTrendingFilled (props: IIconProp list) = createElement (import "DataTrendingFilled" FluentIcons) props
        static member inline dataTrendingRegular (props: IIconProp list) = createElement (import "DataTrendingRegular" FluentIcons) props
        static member inline dataUsageFilled (props: IIconProp list) = createElement (import "DataUsageFilled" FluentIcons) props
        static member inline dataUsageRegular (props: IIconProp list) = createElement (import "DataUsageRegular" FluentIcons) props
        static member inline dataUsageEditFilled (props: IIconProp list) = createElement (import "DataUsageEditFilled" FluentIcons) props
        static member inline dataUsageEditRegular (props: IIconProp list) = createElement (import "DataUsageEditRegular" FluentIcons) props
        static member inline dataUsageSettingsFilled (props: IIconProp list) = createElement (import "DataUsageSettingsFilled" FluentIcons) props
        static member inline dataUsageSettingsRegular (props: IIconProp list) = createElement (import "DataUsageSettingsRegular" FluentIcons) props
        static member inline dataUsageToolboxFilled (props: IIconProp list) = createElement (import "DataUsageToolboxFilled" FluentIcons) props
        static member inline dataUsageToolboxRegular (props: IIconProp list) = createElement (import "DataUsageToolboxRegular" FluentIcons) props
        static member inline dataWaterfallFilled (props: IIconProp list) = createElement (import "DataWaterfallFilled" FluentIcons) props
        static member inline dataWaterfallRegular (props: IIconProp list) = createElement (import "DataWaterfallRegular" FluentIcons) props
        static member inline dataWhiskerFilled (props: IIconProp list) = createElement (import "DataWhiskerFilled" FluentIcons) props
        static member inline dataWhiskerRegular (props: IIconProp list) = createElement (import "DataWhiskerRegular" FluentIcons) props
        static member inline databaseFilled (props: IIconProp list) = createElement (import "DatabaseFilled" FluentIcons) props
        static member inline databaseRegular (props: IIconProp list) = createElement (import "DatabaseRegular" FluentIcons) props
        static member inline databaseArrowDownFilled (props: IIconProp list) = createElement (import "DatabaseArrowDownFilled" FluentIcons) props
        static member inline databaseArrowDownRegular (props: IIconProp list) = createElement (import "DatabaseArrowDownRegular" FluentIcons) props
        static member inline databaseArrowRightFilled (props: IIconProp list) = createElement (import "DatabaseArrowRightFilled" FluentIcons) props
        static member inline databaseArrowRightRegular (props: IIconProp list) = createElement (import "DatabaseArrowRightRegular" FluentIcons) props
        static member inline databaseArrowUpFilled (props: IIconProp list) = createElement (import "DatabaseArrowUpFilled" FluentIcons) props
        static member inline databaseArrowUpRegular (props: IIconProp list) = createElement (import "DatabaseArrowUpRegular" FluentIcons) props
        static member inline databaseLightningFilled (props: IIconProp list) = createElement (import "DatabaseLightningFilled" FluentIcons) props
        static member inline databaseLightningRegular (props: IIconProp list) = createElement (import "DatabaseLightningRegular" FluentIcons) props
        static member inline databaseLinkFilled (props: IIconProp list) = createElement (import "DatabaseLinkFilled" FluentIcons) props
        static member inline databaseLinkRegular (props: IIconProp list) = createElement (import "DatabaseLinkRegular" FluentIcons) props
        static member inline databaseMultipleFilled (props: IIconProp list) = createElement (import "DatabaseMultipleFilled" FluentIcons) props
        static member inline databaseMultipleRegular (props: IIconProp list) = createElement (import "DatabaseMultipleRegular" FluentIcons) props
        static member inline databasePersonFilled (props: IIconProp list) = createElement (import "DatabasePersonFilled" FluentIcons) props
        static member inline databasePersonRegular (props: IIconProp list) = createElement (import "DatabasePersonRegular" FluentIcons) props
        static member inline databasePlugConnectedFilled (props: IIconProp list) = createElement (import "DatabasePlugConnectedFilled" FluentIcons) props
        static member inline databasePlugConnectedRegular (props: IIconProp list) = createElement (import "DatabasePlugConnectedRegular" FluentIcons) props
        static member inline databaseSearchFilled (props: IIconProp list) = createElement (import "DatabaseSearchFilled" FluentIcons) props
        static member inline databaseSearchRegular (props: IIconProp list) = createElement (import "DatabaseSearchRegular" FluentIcons) props
        static member inline databaseSwitchFilled (props: IIconProp list) = createElement (import "DatabaseSwitchFilled" FluentIcons) props
        static member inline databaseSwitchRegular (props: IIconProp list) = createElement (import "DatabaseSwitchRegular" FluentIcons) props
        static member inline databaseWarningFilled (props: IIconProp list) = createElement (import "DatabaseWarningFilled" FluentIcons) props
        static member inline databaseWarningRegular (props: IIconProp list) = createElement (import "DatabaseWarningRegular" FluentIcons) props
        static member inline databaseWindowFilled (props: IIconProp list) = createElement (import "DatabaseWindowFilled" FluentIcons) props
        static member inline databaseWindowRegular (props: IIconProp list) = createElement (import "DatabaseWindowRegular" FluentIcons) props
        static member inline decimalArrowLeftFilled (props: IIconProp list) = createElement (import "DecimalArrowLeftFilled" FluentIcons) props
        static member inline decimalArrowLeftRegular (props: IIconProp list) = createElement (import "DecimalArrowLeftRegular" FluentIcons) props
        static member inline decimalArrowRightFilled (props: IIconProp list) = createElement (import "DecimalArrowRightFilled" FluentIcons) props
        static member inline decimalArrowRightRegular (props: IIconProp list) = createElement (import "DecimalArrowRightRegular" FluentIcons) props
        static member inline deleteFilled (props: IIconProp list) = createElement (import "DeleteFilled" FluentIcons) props
        static member inline deleteRegular (props: IIconProp list) = createElement (import "DeleteRegular" FluentIcons) props
        static member inline deleteArrowBackFilled (props: IIconProp list) = createElement (import "DeleteArrowBackFilled" FluentIcons) props
        static member inline deleteArrowBackRegular (props: IIconProp list) = createElement (import "DeleteArrowBackRegular" FluentIcons) props
        static member inline deleteDismissFilled (props: IIconProp list) = createElement (import "DeleteDismissFilled" FluentIcons) props
        static member inline deleteDismissRegular (props: IIconProp list) = createElement (import "DeleteDismissRegular" FluentIcons) props
        static member inline deleteLinesFilled (props: IIconProp list) = createElement (import "DeleteLinesFilled" FluentIcons) props
        static member inline deleteLinesRegular (props: IIconProp list) = createElement (import "DeleteLinesRegular" FluentIcons) props
        static member inline deleteOffFilled (props: IIconProp list) = createElement (import "DeleteOffFilled" FluentIcons) props
        static member inline deleteOffRegular (props: IIconProp list) = createElement (import "DeleteOffRegular" FluentIcons) props
        static member inline dentistFilled (props: IIconProp list) = createElement (import "DentistFilled" FluentIcons) props
        static member inline dentistRegular (props: IIconProp list) = createElement (import "DentistRegular" FluentIcons) props
        static member inline designIdeasFilled (props: IIconProp list) = createElement (import "DesignIdeasFilled" FluentIcons) props
        static member inline designIdeasRegular (props: IIconProp list) = createElement (import "DesignIdeasRegular" FluentIcons) props
        static member inline deskFilled (props: IIconProp list) = createElement (import "DeskFilled" FluentIcons) props
        static member inline deskRegular (props: IIconProp list) = createElement (import "DeskRegular" FluentIcons) props
        static member inline desktopFilled (props: IIconProp list) = createElement (import "DesktopFilled" FluentIcons) props
        static member inline desktopRegular (props: IIconProp list) = createElement (import "DesktopRegular" FluentIcons) props
        static member inline desktopArrowDownFilled (props: IIconProp list) = createElement (import "DesktopArrowDownFilled" FluentIcons) props
        static member inline desktopArrowDownRegular (props: IIconProp list) = createElement (import "DesktopArrowDownRegular" FluentIcons) props
        static member inline desktopArrowRightFilled (props: IIconProp list) = createElement (import "DesktopArrowRightFilled" FluentIcons) props
        static member inline desktopArrowRightRegular (props: IIconProp list) = createElement (import "DesktopArrowRightRegular" FluentIcons) props
        static member inline desktopCheckmarkFilled (props: IIconProp list) = createElement (import "DesktopCheckmarkFilled" FluentIcons) props
        static member inline desktopCheckmarkRegular (props: IIconProp list) = createElement (import "DesktopCheckmarkRegular" FluentIcons) props
        static member inline desktopCursorFilled (props: IIconProp list) = createElement (import "DesktopCursorFilled" FluentIcons) props
        static member inline desktopCursorRegular (props: IIconProp list) = createElement (import "DesktopCursorRegular" FluentIcons) props
        static member inline desktopEditFilled (props: IIconProp list) = createElement (import "DesktopEditFilled" FluentIcons) props
        static member inline desktopEditRegular (props: IIconProp list) = createElement (import "DesktopEditRegular" FluentIcons) props
        static member inline desktopFlowFilled (props: IIconProp list) = createElement (import "DesktopFlowFilled" FluentIcons) props
        static member inline desktopFlowRegular (props: IIconProp list) = createElement (import "DesktopFlowRegular" FluentIcons) props
        static member inline desktopKeyboardFilled (props: IIconProp list) = createElement (import "DesktopKeyboardFilled" FluentIcons) props
        static member inline desktopKeyboardRegular (props: IIconProp list) = createElement (import "DesktopKeyboardRegular" FluentIcons) props
        static member inline desktopMacFilled (props: IIconProp list) = createElement (import "DesktopMacFilled" FluentIcons) props
        static member inline desktopMacRegular (props: IIconProp list) = createElement (import "DesktopMacRegular" FluentIcons) props
        static member inline desktopOffFilled (props: IIconProp list) = createElement (import "DesktopOffFilled" FluentIcons) props
        static member inline desktopOffRegular (props: IIconProp list) = createElement (import "DesktopOffRegular" FluentIcons) props
        static member inline desktopPulseFilled (props: IIconProp list) = createElement (import "DesktopPulseFilled" FluentIcons) props
        static member inline desktopPulseRegular (props: IIconProp list) = createElement (import "DesktopPulseRegular" FluentIcons) props
        static member inline desktopSignalFilled (props: IIconProp list) = createElement (import "DesktopSignalFilled" FluentIcons) props
        static member inline desktopSignalRegular (props: IIconProp list) = createElement (import "DesktopSignalRegular" FluentIcons) props
        static member inline desktopSpeakerFilled (props: IIconProp list) = createElement (import "DesktopSpeakerFilled" FluentIcons) props
        static member inline desktopSpeakerRegular (props: IIconProp list) = createElement (import "DesktopSpeakerRegular" FluentIcons) props
        static member inline desktopSpeakerOffFilled (props: IIconProp list) = createElement (import "DesktopSpeakerOffFilled" FluentIcons) props
        static member inline desktopSpeakerOffRegular (props: IIconProp list) = createElement (import "DesktopSpeakerOffRegular" FluentIcons) props
        static member inline desktopSyncFilled (props: IIconProp list) = createElement (import "DesktopSyncFilled" FluentIcons) props
        static member inline desktopSyncRegular (props: IIconProp list) = createElement (import "DesktopSyncRegular" FluentIcons) props
        static member inline desktopToolboxFilled (props: IIconProp list) = createElement (import "DesktopToolboxFilled" FluentIcons) props
        static member inline desktopToolboxRegular (props: IIconProp list) = createElement (import "DesktopToolboxRegular" FluentIcons) props
        static member inline desktopTowerFilled (props: IIconProp list) = createElement (import "DesktopTowerFilled" FluentIcons) props
        static member inline desktopTowerRegular (props: IIconProp list) = createElement (import "DesktopTowerRegular" FluentIcons) props
        static member inline developerBoardFilled (props: IIconProp list) = createElement (import "DeveloperBoardFilled" FluentIcons) props
        static member inline developerBoardRegular (props: IIconProp list) = createElement (import "DeveloperBoardRegular" FluentIcons) props
        static member inline developerBoardLightningFilled (props: IIconProp list) = createElement (import "DeveloperBoardLightningFilled" FluentIcons) props
        static member inline developerBoardLightningRegular (props: IIconProp list) = createElement (import "DeveloperBoardLightningRegular" FluentIcons) props
        static member inline developerBoardLightningToolboxFilled (props: IIconProp list) = createElement (import "DeveloperBoardLightningToolboxFilled" FluentIcons) props
        static member inline developerBoardLightningToolboxRegular (props: IIconProp list) = createElement (import "DeveloperBoardLightningToolboxRegular" FluentIcons) props
        static member inline developerBoardSearchFilled (props: IIconProp list) = createElement (import "DeveloperBoardSearchFilled" FluentIcons) props
        static member inline developerBoardSearchRegular (props: IIconProp list) = createElement (import "DeveloperBoardSearchRegular" FluentIcons) props
        static member inline deviceEqFilled (props: IIconProp list) = createElement (import "DeviceEqFilled" FluentIcons) props
        static member inline deviceEqRegular (props: IIconProp list) = createElement (import "DeviceEqRegular" FluentIcons) props
        static member inline deviceMeetingRoomFilled (props: IIconProp list) = createElement (import "DeviceMeetingRoomFilled" FluentIcons) props
        static member inline deviceMeetingRoomRegular (props: IIconProp list) = createElement (import "DeviceMeetingRoomRegular" FluentIcons) props
        static member inline deviceMeetingRoomRemoteFilled (props: IIconProp list) = createElement (import "DeviceMeetingRoomRemoteFilled" FluentIcons) props
        static member inline deviceMeetingRoomRemoteRegular (props: IIconProp list) = createElement (import "DeviceMeetingRoomRemoteRegular" FluentIcons) props
        static member inline diagramFilled (props: IIconProp list) = createElement (import "DiagramFilled" FluentIcons) props
        static member inline diagramRegular (props: IIconProp list) = createElement (import "DiagramRegular" FluentIcons) props
        static member inline dialpadFilled (props: IIconProp list) = createElement (import "DialpadFilled" FluentIcons) props
        static member inline dialpadRegular (props: IIconProp list) = createElement (import "DialpadRegular" FluentIcons) props
        static member inline dialpadOffFilled (props: IIconProp list) = createElement (import "DialpadOffFilled" FluentIcons) props
        static member inline dialpadOffRegular (props: IIconProp list) = createElement (import "DialpadOffRegular" FluentIcons) props
        static member inline dialpadQuestionMarkFilled (props: IIconProp list) = createElement (import "DialpadQuestionMarkFilled" FluentIcons) props
        static member inline dialpadQuestionMarkRegular (props: IIconProp list) = createElement (import "DialpadQuestionMarkRegular" FluentIcons) props
        static member inline diamondFilled (props: IIconProp list) = createElement (import "DiamondFilled" FluentIcons) props
        static member inline diamondRegular (props: IIconProp list) = createElement (import "DiamondRegular" FluentIcons) props
        static member inline directionsFilled (props: IIconProp list) = createElement (import "DirectionsFilled" FluentIcons) props
        static member inline directionsRegular (props: IIconProp list) = createElement (import "DirectionsRegular" FluentIcons) props
        static member inline dishwasherFilled (props: IIconProp list) = createElement (import "DishwasherFilled" FluentIcons) props
        static member inline dishwasherRegular (props: IIconProp list) = createElement (import "DishwasherRegular" FluentIcons) props
        static member inline dismissFilled (props: IIconProp list) = createElement (import "DismissFilled" FluentIcons) props
        static member inline dismissRegular (props: IIconProp list) = createElement (import "DismissRegular" FluentIcons) props
        static member inline dismissCircleFilled (props: IIconProp list) = createElement (import "DismissCircleFilled" FluentIcons) props
        static member inline dismissCircleRegular (props: IIconProp list) = createElement (import "DismissCircleRegular" FluentIcons) props
        static member inline dismissSquareFilled (props: IIconProp list) = createElement (import "DismissSquareFilled" FluentIcons) props
        static member inline dismissSquareRegular (props: IIconProp list) = createElement (import "DismissSquareRegular" FluentIcons) props
        static member inline dismissSquareMultipleFilled (props: IIconProp list) = createElement (import "DismissSquareMultipleFilled" FluentIcons) props
        static member inline dismissSquareMultipleRegular (props: IIconProp list) = createElement (import "DismissSquareMultipleRegular" FluentIcons) props
        static member inline diversityFilled (props: IIconProp list) = createElement (import "DiversityFilled" FluentIcons) props
        static member inline diversityRegular (props: IIconProp list) = createElement (import "DiversityRegular" FluentIcons) props
        static member inline dividerShortFilled (props: IIconProp list) = createElement (import "DividerShortFilled" FluentIcons) props
        static member inline dividerShortRegular (props: IIconProp list) = createElement (import "DividerShortRegular" FluentIcons) props
        static member inline dividerTallFilled (props: IIconProp list) = createElement (import "DividerTallFilled" FluentIcons) props
        static member inline dividerTallRegular (props: IIconProp list) = createElement (import "DividerTallRegular" FluentIcons) props
        static member inline dockFilled (props: IIconProp list) = createElement (import "DockFilled" FluentIcons) props
        static member inline dockRegular (props: IIconProp list) = createElement (import "DockRegular" FluentIcons) props
        static member inline dockRowFilled (props: IIconProp list) = createElement (import "DockRowFilled" FluentIcons) props
        static member inline dockRowRegular (props: IIconProp list) = createElement (import "DockRowRegular" FluentIcons) props
        static member inline doctorFilled (props: IIconProp list) = createElement (import "DoctorFilled" FluentIcons) props
        static member inline doctorRegular (props: IIconProp list) = createElement (import "DoctorRegular" FluentIcons) props
        static member inline document100Filled (props: IIconProp list) = createElement (import "Document100Filled" FluentIcons) props
        static member inline document100Regular (props: IIconProp list) = createElement (import "Document100Regular" FluentIcons) props
        static member inline documentFilled (props: IIconProp list) = createElement (import "DocumentFilled" FluentIcons) props
        static member inline documentRegular (props: IIconProp list) = createElement (import "DocumentRegular" FluentIcons) props
        static member inline documentAddFilled (props: IIconProp list) = createElement (import "DocumentAddFilled" FluentIcons) props
        static member inline documentAddRegular (props: IIconProp list) = createElement (import "DocumentAddRegular" FluentIcons) props
        static member inline documentArrowDownFilled (props: IIconProp list) = createElement (import "DocumentArrowDownFilled" FluentIcons) props
        static member inline documentArrowDownRegular (props: IIconProp list) = createElement (import "DocumentArrowDownRegular" FluentIcons) props
        static member inline documentArrowLeftFilled (props: IIconProp list) = createElement (import "DocumentArrowLeftFilled" FluentIcons) props
        static member inline documentArrowLeftRegular (props: IIconProp list) = createElement (import "DocumentArrowLeftRegular" FluentIcons) props
        static member inline documentArrowRightFilled (props: IIconProp list) = createElement (import "DocumentArrowRightFilled" FluentIcons) props
        static member inline documentArrowRightRegular (props: IIconProp list) = createElement (import "DocumentArrowRightRegular" FluentIcons) props
        static member inline documentArrowUpFilled (props: IIconProp list) = createElement (import "DocumentArrowUpFilled" FluentIcons) props
        static member inline documentArrowUpRegular (props: IIconProp list) = createElement (import "DocumentArrowUpRegular" FluentIcons) props
        static member inline documentBorderFilled (props: IIconProp list) = createElement (import "DocumentBorderFilled" FluentIcons) props
        static member inline documentBorderRegular (props: IIconProp list) = createElement (import "DocumentBorderRegular" FluentIcons) props
        static member inline documentBorderPrintFilled (props: IIconProp list) = createElement (import "DocumentBorderPrintFilled" FluentIcons) props
        static member inline documentBorderPrintRegular (props: IIconProp list) = createElement (import "DocumentBorderPrintRegular" FluentIcons) props
        static member inline documentBriefcaseFilled (props: IIconProp list) = createElement (import "DocumentBriefcaseFilled" FluentIcons) props
        static member inline documentBriefcaseRegular (props: IIconProp list) = createElement (import "DocumentBriefcaseRegular" FluentIcons) props
        static member inline documentBulletListFilled (props: IIconProp list) = createElement (import "DocumentBulletListFilled" FluentIcons) props
        static member inline documentBulletListRegular (props: IIconProp list) = createElement (import "DocumentBulletListRegular" FluentIcons) props
        static member inline documentBulletListArrowLeftFilled (props: IIconProp list) = createElement (import "DocumentBulletListArrowLeftFilled" FluentIcons) props
        static member inline documentBulletListArrowLeftRegular (props: IIconProp list) = createElement (import "DocumentBulletListArrowLeftRegular" FluentIcons) props
        static member inline documentBulletListClockFilled (props: IIconProp list) = createElement (import "DocumentBulletListClockFilled" FluentIcons) props
        static member inline documentBulletListClockRegular (props: IIconProp list) = createElement (import "DocumentBulletListClockRegular" FluentIcons) props
        static member inline documentBulletListCubeFilled (props: IIconProp list) = createElement (import "DocumentBulletListCubeFilled" FluentIcons) props
        static member inline documentBulletListCubeRegular (props: IIconProp list) = createElement (import "DocumentBulletListCubeRegular" FluentIcons) props
        static member inline documentBulletListMultipleFilled (props: IIconProp list) = createElement (import "DocumentBulletListMultipleFilled" FluentIcons) props
        static member inline documentBulletListMultipleRegular (props: IIconProp list) = createElement (import "DocumentBulletListMultipleRegular" FluentIcons) props
        static member inline documentBulletListOffFilled (props: IIconProp list) = createElement (import "DocumentBulletListOffFilled" FluentIcons) props
        static member inline documentBulletListOffRegular (props: IIconProp list) = createElement (import "DocumentBulletListOffRegular" FluentIcons) props
        static member inline documentCatchUpFilled (props: IIconProp list) = createElement (import "DocumentCatchUpFilled" FluentIcons) props
        static member inline documentCatchUpRegular (props: IIconProp list) = createElement (import "DocumentCatchUpRegular" FluentIcons) props
        static member inline documentCheckmarkFilled (props: IIconProp list) = createElement (import "DocumentCheckmarkFilled" FluentIcons) props
        static member inline documentCheckmarkRegular (props: IIconProp list) = createElement (import "DocumentCheckmarkRegular" FluentIcons) props
        static member inline documentChevronDoubleFilled (props: IIconProp list) = createElement (import "DocumentChevronDoubleFilled" FluentIcons) props
        static member inline documentChevronDoubleRegular (props: IIconProp list) = createElement (import "DocumentChevronDoubleRegular" FluentIcons) props
        static member inline documentCopyFilled (props: IIconProp list) = createElement (import "DocumentCopyFilled" FluentIcons) props
        static member inline documentCopyRegular (props: IIconProp list) = createElement (import "DocumentCopyRegular" FluentIcons) props
        static member inline documentCssFilled (props: IIconProp list) = createElement (import "DocumentCssFilled" FluentIcons) props
        static member inline documentCssRegular (props: IIconProp list) = createElement (import "DocumentCssRegular" FluentIcons) props
        static member inline documentCubeFilled (props: IIconProp list) = createElement (import "DocumentCubeFilled" FluentIcons) props
        static member inline documentCubeRegular (props: IIconProp list) = createElement (import "DocumentCubeRegular" FluentIcons) props
        static member inline documentDataFilled (props: IIconProp list) = createElement (import "DocumentDataFilled" FluentIcons) props
        static member inline documentDataRegular (props: IIconProp list) = createElement (import "DocumentDataRegular" FluentIcons) props
        static member inline documentDataLinkFilled (props: IIconProp list) = createElement (import "DocumentDataLinkFilled" FluentIcons) props
        static member inline documentDataLinkRegular (props: IIconProp list) = createElement (import "DocumentDataLinkRegular" FluentIcons) props
        static member inline documentDataLockFilled (props: IIconProp list) = createElement (import "DocumentDataLockFilled" FluentIcons) props
        static member inline documentDataLockRegular (props: IIconProp list) = createElement (import "DocumentDataLockRegular" FluentIcons) props
        static member inline documentDatabaseFilled (props: IIconProp list) = createElement (import "DocumentDatabaseFilled" FluentIcons) props
        static member inline documentDatabaseRegular (props: IIconProp list) = createElement (import "DocumentDatabaseRegular" FluentIcons) props
        static member inline documentDismissFilled (props: IIconProp list) = createElement (import "DocumentDismissFilled" FluentIcons) props
        static member inline documentDismissRegular (props: IIconProp list) = createElement (import "DocumentDismissRegular" FluentIcons) props
        static member inline documentEditFilled (props: IIconProp list) = createElement (import "DocumentEditFilled" FluentIcons) props
        static member inline documentEditRegular (props: IIconProp list) = createElement (import "DocumentEditRegular" FluentIcons) props
        static member inline documentEndnoteFilled (props: IIconProp list) = createElement (import "DocumentEndnoteFilled" FluentIcons) props
        static member inline documentEndnoteRegular (props: IIconProp list) = createElement (import "DocumentEndnoteRegular" FluentIcons) props
        static member inline documentErrorFilled (props: IIconProp list) = createElement (import "DocumentErrorFilled" FluentIcons) props
        static member inline documentErrorRegular (props: IIconProp list) = createElement (import "DocumentErrorRegular" FluentIcons) props
        static member inline documentFitFilled (props: IIconProp list) = createElement (import "DocumentFitFilled" FluentIcons) props
        static member inline documentFitRegular (props: IIconProp list) = createElement (import "DocumentFitRegular" FluentIcons) props
        static member inline documentFlowchartFilled (props: IIconProp list) = createElement (import "DocumentFlowchartFilled" FluentIcons) props
        static member inline documentFlowchartRegular (props: IIconProp list) = createElement (import "DocumentFlowchartRegular" FluentIcons) props
        static member inline documentFolderFilled (props: IIconProp list) = createElement (import "DocumentFolderFilled" FluentIcons) props
        static member inline documentFolderRegular (props: IIconProp list) = createElement (import "DocumentFolderRegular" FluentIcons) props
        static member inline documentFooterFilled (props: IIconProp list) = createElement (import "DocumentFooterFilled" FluentIcons) props
        static member inline documentFooterRegular (props: IIconProp list) = createElement (import "DocumentFooterRegular" FluentIcons) props
        static member inline documentFooterDismissFilled (props: IIconProp list) = createElement (import "DocumentFooterDismissFilled" FluentIcons) props
        static member inline documentFooterDismissRegular (props: IIconProp list) = createElement (import "DocumentFooterDismissRegular" FluentIcons) props
        static member inline documentHeaderFilled (props: IIconProp list) = createElement (import "DocumentHeaderFilled" FluentIcons) props
        static member inline documentHeaderRegular (props: IIconProp list) = createElement (import "DocumentHeaderRegular" FluentIcons) props
        static member inline documentHeaderArrowDownFilled (props: IIconProp list) = createElement (import "DocumentHeaderArrowDownFilled" FluentIcons) props
        static member inline documentHeaderArrowDownRegular (props: IIconProp list) = createElement (import "DocumentHeaderArrowDownRegular" FluentIcons) props
        static member inline documentHeaderDismissFilled (props: IIconProp list) = createElement (import "DocumentHeaderDismissFilled" FluentIcons) props
        static member inline documentHeaderDismissRegular (props: IIconProp list) = createElement (import "DocumentHeaderDismissRegular" FluentIcons) props
        static member inline documentHeaderFooterFilled (props: IIconProp list) = createElement (import "DocumentHeaderFooterFilled" FluentIcons) props
        static member inline documentHeaderFooterRegular (props: IIconProp list) = createElement (import "DocumentHeaderFooterRegular" FluentIcons) props
        static member inline documentHeartFilled (props: IIconProp list) = createElement (import "DocumentHeartFilled" FluentIcons) props
        static member inline documentHeartRegular (props: IIconProp list) = createElement (import "DocumentHeartRegular" FluentIcons) props
        static member inline documentHeartPulseFilled (props: IIconProp list) = createElement (import "DocumentHeartPulseFilled" FluentIcons) props
        static member inline documentHeartPulseRegular (props: IIconProp list) = createElement (import "DocumentHeartPulseRegular" FluentIcons) props
        static member inline documentImageFilled (props: IIconProp list) = createElement (import "DocumentImageFilled" FluentIcons) props
        static member inline documentImageRegular (props: IIconProp list) = createElement (import "DocumentImageRegular" FluentIcons) props
        static member inline documentJavaFilled (props: IIconProp list) = createElement (import "DocumentJavaFilled" FluentIcons) props
        static member inline documentJavaRegular (props: IIconProp list) = createElement (import "DocumentJavaRegular" FluentIcons) props
        static member inline documentJavascriptFilled (props: IIconProp list) = createElement (import "DocumentJavascriptFilled" FluentIcons) props
        static member inline documentJavascriptRegular (props: IIconProp list) = createElement (import "DocumentJavascriptRegular" FluentIcons) props
        static member inline documentKeyFilled (props: IIconProp list) = createElement (import "DocumentKeyFilled" FluentIcons) props
        static member inline documentKeyRegular (props: IIconProp list) = createElement (import "DocumentKeyRegular" FluentIcons) props
        static member inline documentLandscapeFilled (props: IIconProp list) = createElement (import "DocumentLandscapeFilled" FluentIcons) props
        static member inline documentLandscapeRegular (props: IIconProp list) = createElement (import "DocumentLandscapeRegular" FluentIcons) props
        static member inline documentLandscapeDataFilled (props: IIconProp list) = createElement (import "DocumentLandscapeDataFilled" FluentIcons) props
        static member inline documentLandscapeDataRegular (props: IIconProp list) = createElement (import "DocumentLandscapeDataRegular" FluentIcons) props
        static member inline documentLandscapeSplitFilled (props: IIconProp list) = createElement (import "DocumentLandscapeSplitFilled" FluentIcons) props
        static member inline documentLandscapeSplitRegular (props: IIconProp list) = createElement (import "DocumentLandscapeSplitRegular" FluentIcons) props
        static member inline documentLandscapeSplitHintFilled (props: IIconProp list) = createElement (import "DocumentLandscapeSplitHintFilled" FluentIcons) props
        static member inline documentLandscapeSplitHintRegular (props: IIconProp list) = createElement (import "DocumentLandscapeSplitHintRegular" FluentIcons) props
        static member inline documentLightningFilled (props: IIconProp list) = createElement (import "DocumentLightningFilled" FluentIcons) props
        static member inline documentLightningRegular (props: IIconProp list) = createElement (import "DocumentLightningRegular" FluentIcons) props
        static member inline documentLinkFilled (props: IIconProp list) = createElement (import "DocumentLinkFilled" FluentIcons) props
        static member inline documentLinkRegular (props: IIconProp list) = createElement (import "DocumentLinkRegular" FluentIcons) props
        static member inline documentLockFilled (props: IIconProp list) = createElement (import "DocumentLockFilled" FluentIcons) props
        static member inline documentLockRegular (props: IIconProp list) = createElement (import "DocumentLockRegular" FluentIcons) props
        static member inline documentMarginsFilled (props: IIconProp list) = createElement (import "DocumentMarginsFilled" FluentIcons) props
        static member inline documentMarginsRegular (props: IIconProp list) = createElement (import "DocumentMarginsRegular" FluentIcons) props
        static member inline documentMentionFilled (props: IIconProp list) = createElement (import "DocumentMentionFilled" FluentIcons) props
        static member inline documentMentionRegular (props: IIconProp list) = createElement (import "DocumentMentionRegular" FluentIcons) props
        static member inline documentMultipleFilled (props: IIconProp list) = createElement (import "DocumentMultipleFilled" FluentIcons) props
        static member inline documentMultipleRegular (props: IIconProp list) = createElement (import "DocumentMultipleRegular" FluentIcons) props
        static member inline documentMultiplePercentFilled (props: IIconProp list) = createElement (import "DocumentMultiplePercentFilled" FluentIcons) props
        static member inline documentMultiplePercentRegular (props: IIconProp list) = createElement (import "DocumentMultiplePercentRegular" FluentIcons) props
        static member inline documentMultipleProhibitedFilled (props: IIconProp list) = createElement (import "DocumentMultipleProhibitedFilled" FluentIcons) props
        static member inline documentMultipleProhibitedRegular (props: IIconProp list) = createElement (import "DocumentMultipleProhibitedRegular" FluentIcons) props
        static member inline documentMultipleSyncFilled (props: IIconProp list) = createElement (import "DocumentMultipleSyncFilled" FluentIcons) props
        static member inline documentMultipleSyncRegular (props: IIconProp list) = createElement (import "DocumentMultipleSyncRegular" FluentIcons) props
        static member inline documentOnePageFilled (props: IIconProp list) = createElement (import "DocumentOnePageFilled" FluentIcons) props
        static member inline documentOnePageRegular (props: IIconProp list) = createElement (import "DocumentOnePageRegular" FluentIcons) props
        static member inline documentOnePageAddFilled (props: IIconProp list) = createElement (import "DocumentOnePageAddFilled" FluentIcons) props
        static member inline documentOnePageAddRegular (props: IIconProp list) = createElement (import "DocumentOnePageAddRegular" FluentIcons) props
        static member inline documentOnePageColumnsFilled (props: IIconProp list) = createElement (import "DocumentOnePageColumnsFilled" FluentIcons) props
        static member inline documentOnePageColumnsRegular (props: IIconProp list) = createElement (import "DocumentOnePageColumnsRegular" FluentIcons) props
        static member inline documentOnePageLinkFilled (props: IIconProp list) = createElement (import "DocumentOnePageLinkFilled" FluentIcons) props
        static member inline documentOnePageLinkRegular (props: IIconProp list) = createElement (import "DocumentOnePageLinkRegular" FluentIcons) props
        static member inline documentOnePageMultipleFilled (props: IIconProp list) = createElement (import "DocumentOnePageMultipleFilled" FluentIcons) props
        static member inline documentOnePageMultipleRegular (props: IIconProp list) = createElement (import "DocumentOnePageMultipleRegular" FluentIcons) props
        static member inline documentOnePageSparkleFilled (props: IIconProp list) = createElement (import "DocumentOnePageSparkleFilled" FluentIcons) props
        static member inline documentOnePageSparkleRegular (props: IIconProp list) = createElement (import "DocumentOnePageSparkleRegular" FluentIcons) props
        static member inline documentPageBottomCenterFilled (props: IIconProp list) = createElement (import "DocumentPageBottomCenterFilled" FluentIcons) props
        static member inline documentPageBottomCenterRegular (props: IIconProp list) = createElement (import "DocumentPageBottomCenterRegular" FluentIcons) props
        static member inline documentPageBottomLeftFilled (props: IIconProp list) = createElement (import "DocumentPageBottomLeftFilled" FluentIcons) props
        static member inline documentPageBottomLeftRegular (props: IIconProp list) = createElement (import "DocumentPageBottomLeftRegular" FluentIcons) props
        static member inline documentPageBottomRightFilled (props: IIconProp list) = createElement (import "DocumentPageBottomRightFilled" FluentIcons) props
        static member inline documentPageBottomRightRegular (props: IIconProp list) = createElement (import "DocumentPageBottomRightRegular" FluentIcons) props
        static member inline documentPageBreakFilled (props: IIconProp list) = createElement (import "DocumentPageBreakFilled" FluentIcons) props
        static member inline documentPageBreakRegular (props: IIconProp list) = createElement (import "DocumentPageBreakRegular" FluentIcons) props
        static member inline documentPageNumberFilled (props: IIconProp list) = createElement (import "DocumentPageNumberFilled" FluentIcons) props
        static member inline documentPageNumberRegular (props: IIconProp list) = createElement (import "DocumentPageNumberRegular" FluentIcons) props
        static member inline documentPageTopCenterFilled (props: IIconProp list) = createElement (import "DocumentPageTopCenterFilled" FluentIcons) props
        static member inline documentPageTopCenterRegular (props: IIconProp list) = createElement (import "DocumentPageTopCenterRegular" FluentIcons) props
        static member inline documentPageTopLeftFilled (props: IIconProp list) = createElement (import "DocumentPageTopLeftFilled" FluentIcons) props
        static member inline documentPageTopLeftRegular (props: IIconProp list) = createElement (import "DocumentPageTopLeftRegular" FluentIcons) props
        static member inline documentPageTopRightFilled (props: IIconProp list) = createElement (import "DocumentPageTopRightFilled" FluentIcons) props
        static member inline documentPageTopRightRegular (props: IIconProp list) = createElement (import "DocumentPageTopRightRegular" FluentIcons) props
        static member inline documentPdfFilled (props: IIconProp list) = createElement (import "DocumentPdfFilled" FluentIcons) props
        static member inline documentPdfRegular (props: IIconProp list) = createElement (import "DocumentPdfRegular" FluentIcons) props
        static member inline documentPercentFilled (props: IIconProp list) = createElement (import "DocumentPercentFilled" FluentIcons) props
        static member inline documentPercentRegular (props: IIconProp list) = createElement (import "DocumentPercentRegular" FluentIcons) props
        static member inline documentPersonFilled (props: IIconProp list) = createElement (import "DocumentPersonFilled" FluentIcons) props
        static member inline documentPersonRegular (props: IIconProp list) = createElement (import "DocumentPersonRegular" FluentIcons) props
        static member inline documentPillFilled (props: IIconProp list) = createElement (import "DocumentPillFilled" FluentIcons) props
        static member inline documentPillRegular (props: IIconProp list) = createElement (import "DocumentPillRegular" FluentIcons) props
        static member inline documentPrintFilled (props: IIconProp list) = createElement (import "DocumentPrintFilled" FluentIcons) props
        static member inline documentPrintRegular (props: IIconProp list) = createElement (import "DocumentPrintRegular" FluentIcons) props
        static member inline documentProhibitedFilled (props: IIconProp list) = createElement (import "DocumentProhibitedFilled" FluentIcons) props
        static member inline documentProhibitedRegular (props: IIconProp list) = createElement (import "DocumentProhibitedRegular" FluentIcons) props
        static member inline documentQuestionMarkFilled (props: IIconProp list) = createElement (import "DocumentQuestionMarkFilled" FluentIcons) props
        static member inline documentQuestionMarkRegular (props: IIconProp list) = createElement (import "DocumentQuestionMarkRegular" FluentIcons) props
        static member inline documentQueueFilled (props: IIconProp list) = createElement (import "DocumentQueueFilled" FluentIcons) props
        static member inline documentQueueRegular (props: IIconProp list) = createElement (import "DocumentQueueRegular" FluentIcons) props
        static member inline documentQueueAddFilled (props: IIconProp list) = createElement (import "DocumentQueueAddFilled" FluentIcons) props
        static member inline documentQueueAddRegular (props: IIconProp list) = createElement (import "DocumentQueueAddRegular" FluentIcons) props
        static member inline documentQueueMultipleFilled (props: IIconProp list) = createElement (import "DocumentQueueMultipleFilled" FluentIcons) props
        static member inline documentQueueMultipleRegular (props: IIconProp list) = createElement (import "DocumentQueueMultipleRegular" FluentIcons) props
        static member inline documentRibbonFilled (props: IIconProp list) = createElement (import "DocumentRibbonFilled" FluentIcons) props
        static member inline documentRibbonRegular (props: IIconProp list) = createElement (import "DocumentRibbonRegular" FluentIcons) props
        static member inline documentSassFilled (props: IIconProp list) = createElement (import "DocumentSassFilled" FluentIcons) props
        static member inline documentSassRegular (props: IIconProp list) = createElement (import "DocumentSassRegular" FluentIcons) props
        static member inline documentSaveFilled (props: IIconProp list) = createElement (import "DocumentSaveFilled" FluentIcons) props
        static member inline documentSaveRegular (props: IIconProp list) = createElement (import "DocumentSaveRegular" FluentIcons) props
        static member inline documentSearchFilled (props: IIconProp list) = createElement (import "DocumentSearchFilled" FluentIcons) props
        static member inline documentSearchRegular (props: IIconProp list) = createElement (import "DocumentSearchRegular" FluentIcons) props
        static member inline documentSettingsFilled (props: IIconProp list) = createElement (import "DocumentSettingsFilled" FluentIcons) props
        static member inline documentSettingsRegular (props: IIconProp list) = createElement (import "DocumentSettingsRegular" FluentIcons) props
        static member inline documentSignatureFilled (props: IIconProp list) = createElement (import "DocumentSignatureFilled" FluentIcons) props
        static member inline documentSignatureRegular (props: IIconProp list) = createElement (import "DocumentSignatureRegular" FluentIcons) props
        static member inline documentSplitHintFilled (props: IIconProp list) = createElement (import "DocumentSplitHintFilled" FluentIcons) props
        static member inline documentSplitHintRegular (props: IIconProp list) = createElement (import "DocumentSplitHintRegular" FluentIcons) props
        static member inline documentSplitHintOffFilled (props: IIconProp list) = createElement (import "DocumentSplitHintOffFilled" FluentIcons) props
        static member inline documentSplitHintOffRegular (props: IIconProp list) = createElement (import "DocumentSplitHintOffRegular" FluentIcons) props
        static member inline documentSyncFilled (props: IIconProp list) = createElement (import "DocumentSyncFilled" FluentIcons) props
        static member inline documentSyncRegular (props: IIconProp list) = createElement (import "DocumentSyncRegular" FluentIcons) props
        static member inline documentTableFilled (props: IIconProp list) = createElement (import "DocumentTableFilled" FluentIcons) props
        static member inline documentTableRegular (props: IIconProp list) = createElement (import "DocumentTableRegular" FluentIcons) props
        static member inline documentTableArrowRightFilled (props: IIconProp list) = createElement (import "DocumentTableArrowRightFilled" FluentIcons) props
        static member inline documentTableArrowRightRegular (props: IIconProp list) = createElement (import "DocumentTableArrowRightRegular" FluentIcons) props
        static member inline documentTableCheckmarkFilled (props: IIconProp list) = createElement (import "DocumentTableCheckmarkFilled" FluentIcons) props
        static member inline documentTableCheckmarkRegular (props: IIconProp list) = createElement (import "DocumentTableCheckmarkRegular" FluentIcons) props
        static member inline documentTableCubeFilled (props: IIconProp list) = createElement (import "DocumentTableCubeFilled" FluentIcons) props
        static member inline documentTableCubeRegular (props: IIconProp list) = createElement (import "DocumentTableCubeRegular" FluentIcons) props
        static member inline documentTableSearchFilled (props: IIconProp list) = createElement (import "DocumentTableSearchFilled" FluentIcons) props
        static member inline documentTableSearchRegular (props: IIconProp list) = createElement (import "DocumentTableSearchRegular" FluentIcons) props
        static member inline documentTableTruckFilled (props: IIconProp list) = createElement (import "DocumentTableTruckFilled" FluentIcons) props
        static member inline documentTableTruckRegular (props: IIconProp list) = createElement (import "DocumentTableTruckRegular" FluentIcons) props
        static member inline documentTargetFilled (props: IIconProp list) = createElement (import "DocumentTargetFilled" FluentIcons) props
        static member inline documentTargetRegular (props: IIconProp list) = createElement (import "DocumentTargetRegular" FluentIcons) props
        static member inline documentTextFilled (props: IIconProp list) = createElement (import "DocumentTextFilled" FluentIcons) props
        static member inline documentTextRegular (props: IIconProp list) = createElement (import "DocumentTextRegular" FluentIcons) props
        static member inline documentTextClockFilled (props: IIconProp list) = createElement (import "DocumentTextClockFilled" FluentIcons) props
        static member inline documentTextClockRegular (props: IIconProp list) = createElement (import "DocumentTextClockRegular" FluentIcons) props
        static member inline documentTextExtractFilled (props: IIconProp list) = createElement (import "DocumentTextExtractFilled" FluentIcons) props
        static member inline documentTextExtractRegular (props: IIconProp list) = createElement (import "DocumentTextExtractRegular" FluentIcons) props
        static member inline documentTextLinkFilled (props: IIconProp list) = createElement (import "DocumentTextLinkFilled" FluentIcons) props
        static member inline documentTextLinkRegular (props: IIconProp list) = createElement (import "DocumentTextLinkRegular" FluentIcons) props
        static member inline documentTextToolboxFilled (props: IIconProp list) = createElement (import "DocumentTextToolboxFilled" FluentIcons) props
        static member inline documentTextToolboxRegular (props: IIconProp list) = createElement (import "DocumentTextToolboxRegular" FluentIcons) props
        static member inline documentToolboxFilled (props: IIconProp list) = createElement (import "DocumentToolboxFilled" FluentIcons) props
        static member inline documentToolboxRegular (props: IIconProp list) = createElement (import "DocumentToolboxRegular" FluentIcons) props
        static member inline documentWidthFilled (props: IIconProp list) = createElement (import "DocumentWidthFilled" FluentIcons) props
        static member inline documentWidthRegular (props: IIconProp list) = createElement (import "DocumentWidthRegular" FluentIcons) props
        static member inline documentYmlFilled (props: IIconProp list) = createElement (import "DocumentYmlFilled" FluentIcons) props
        static member inline documentYmlRegular (props: IIconProp list) = createElement (import "DocumentYmlRegular" FluentIcons) props
        static member inline doorFilled (props: IIconProp list) = createElement (import "DoorFilled" FluentIcons) props
        static member inline doorRegular (props: IIconProp list) = createElement (import "DoorRegular" FluentIcons) props
        static member inline doorArrowLeftFilled (props: IIconProp list) = createElement (import "DoorArrowLeftFilled" FluentIcons) props
        static member inline doorArrowLeftRegular (props: IIconProp list) = createElement (import "DoorArrowLeftRegular" FluentIcons) props
        static member inline doorArrowRightFilled (props: IIconProp list) = createElement (import "DoorArrowRightFilled" FluentIcons) props
        static member inline doorArrowRightRegular (props: IIconProp list) = createElement (import "DoorArrowRightRegular" FluentIcons) props
        static member inline doorTagFilled (props: IIconProp list) = createElement (import "DoorTagFilled" FluentIcons) props
        static member inline doorTagRegular (props: IIconProp list) = createElement (import "DoorTagRegular" FluentIcons) props
        static member inline doubleSwipeDownFilled (props: IIconProp list) = createElement (import "DoubleSwipeDownFilled" FluentIcons) props
        static member inline doubleSwipeDownRegular (props: IIconProp list) = createElement (import "DoubleSwipeDownRegular" FluentIcons) props
        static member inline doubleSwipeUpFilled (props: IIconProp list) = createElement (import "DoubleSwipeUpFilled" FluentIcons) props
        static member inline doubleSwipeUpRegular (props: IIconProp list) = createElement (import "DoubleSwipeUpRegular" FluentIcons) props
        static member inline doubleTapSwipeDownFilled (props: IIconProp list) = createElement (import "DoubleTapSwipeDownFilled" FluentIcons) props
        static member inline doubleTapSwipeDownRegular (props: IIconProp list) = createElement (import "DoubleTapSwipeDownRegular" FluentIcons) props
        static member inline doubleTapSwipeUpFilled (props: IIconProp list) = createElement (import "DoubleTapSwipeUpFilled" FluentIcons) props
        static member inline doubleTapSwipeUpRegular (props: IIconProp list) = createElement (import "DoubleTapSwipeUpRegular" FluentIcons) props
        static member inline draftsFilled (props: IIconProp list) = createElement (import "DraftsFilled" FluentIcons) props
        static member inline draftsRegular (props: IIconProp list) = createElement (import "DraftsRegular" FluentIcons) props
        static member inline dragFilled (props: IIconProp list) = createElement (import "DragFilled" FluentIcons) props
        static member inline dragRegular (props: IIconProp list) = createElement (import "DragRegular" FluentIcons) props
        static member inline drawImageFilled (props: IIconProp list) = createElement (import "DrawImageFilled" FluentIcons) props
        static member inline drawImageRegular (props: IIconProp list) = createElement (import "DrawImageRegular" FluentIcons) props
        static member inline drawShapeFilled (props: IIconProp list) = createElement (import "DrawShapeFilled" FluentIcons) props
        static member inline drawShapeRegular (props: IIconProp list) = createElement (import "DrawShapeRegular" FluentIcons) props
        static member inline drawTextFilled (props: IIconProp list) = createElement (import "DrawTextFilled" FluentIcons) props
        static member inline drawTextRegular (props: IIconProp list) = createElement (import "DrawTextRegular" FluentIcons) props
        static member inline drawerFilled (props: IIconProp list) = createElement (import "DrawerFilled" FluentIcons) props
        static member inline drawerRegular (props: IIconProp list) = createElement (import "DrawerRegular" FluentIcons) props
        static member inline drawerAddFilled (props: IIconProp list) = createElement (import "DrawerAddFilled" FluentIcons) props
        static member inline drawerAddRegular (props: IIconProp list) = createElement (import "DrawerAddRegular" FluentIcons) props
        static member inline drawerArrowDownloadFilled (props: IIconProp list) = createElement (import "DrawerArrowDownloadFilled" FluentIcons) props
        static member inline drawerArrowDownloadRegular (props: IIconProp list) = createElement (import "DrawerArrowDownloadRegular" FluentIcons) props
        static member inline drawerDismissFilled (props: IIconProp list) = createElement (import "DrawerDismissFilled" FluentIcons) props
        static member inline drawerDismissRegular (props: IIconProp list) = createElement (import "DrawerDismissRegular" FluentIcons) props
        static member inline drawerPlayFilled (props: IIconProp list) = createElement (import "DrawerPlayFilled" FluentIcons) props
        static member inline drawerPlayRegular (props: IIconProp list) = createElement (import "DrawerPlayRegular" FluentIcons) props
        static member inline drawerSubtractFilled (props: IIconProp list) = createElement (import "DrawerSubtractFilled" FluentIcons) props
        static member inline drawerSubtractRegular (props: IIconProp list) = createElement (import "DrawerSubtractRegular" FluentIcons) props
        static member inline drinkBeerFilled (props: IIconProp list) = createElement (import "DrinkBeerFilled" FluentIcons) props
        static member inline drinkBeerRegular (props: IIconProp list) = createElement (import "DrinkBeerRegular" FluentIcons) props
        static member inline drinkBottleFilled (props: IIconProp list) = createElement (import "DrinkBottleFilled" FluentIcons) props
        static member inline drinkBottleRegular (props: IIconProp list) = createElement (import "DrinkBottleRegular" FluentIcons) props
        static member inline drinkBottleOffFilled (props: IIconProp list) = createElement (import "DrinkBottleOffFilled" FluentIcons) props
        static member inline drinkBottleOffRegular (props: IIconProp list) = createElement (import "DrinkBottleOffRegular" FluentIcons) props
        static member inline drinkCoffeeFilled (props: IIconProp list) = createElement (import "DrinkCoffeeFilled" FluentIcons) props
        static member inline drinkCoffeeRegular (props: IIconProp list) = createElement (import "DrinkCoffeeRegular" FluentIcons) props
        static member inline drinkMargaritaFilled (props: IIconProp list) = createElement (import "DrinkMargaritaFilled" FluentIcons) props
        static member inline drinkMargaritaRegular (props: IIconProp list) = createElement (import "DrinkMargaritaRegular" FluentIcons) props
        static member inline drinkToGoFilled (props: IIconProp list) = createElement (import "DrinkToGoFilled" FluentIcons) props
        static member inline drinkToGoRegular (props: IIconProp list) = createElement (import "DrinkToGoRegular" FluentIcons) props
        static member inline drinkWineFilled (props: IIconProp list) = createElement (import "DrinkWineFilled" FluentIcons) props
        static member inline drinkWineRegular (props: IIconProp list) = createElement (import "DrinkWineRegular" FluentIcons) props
        static member inline driveTrainFilled (props: IIconProp list) = createElement (import "DriveTrainFilled" FluentIcons) props
        static member inline driveTrainRegular (props: IIconProp list) = createElement (import "DriveTrainRegular" FluentIcons) props
        static member inline dropFilled (props: IIconProp list) = createElement (import "DropFilled" FluentIcons) props
        static member inline dropRegular (props: IIconProp list) = createElement (import "DropRegular" FluentIcons) props
        static member inline dualScreenFilled (props: IIconProp list) = createElement (import "DualScreenFilled" FluentIcons) props
        static member inline dualScreenRegular (props: IIconProp list) = createElement (import "DualScreenRegular" FluentIcons) props
        static member inline dualScreenAddFilled (props: IIconProp list) = createElement (import "DualScreenAddFilled" FluentIcons) props
        static member inline dualScreenAddRegular (props: IIconProp list) = createElement (import "DualScreenAddRegular" FluentIcons) props
        static member inline dualScreenArrowRightFilled (props: IIconProp list) = createElement (import "DualScreenArrowRightFilled" FluentIcons) props
        static member inline dualScreenArrowRightRegular (props: IIconProp list) = createElement (import "DualScreenArrowRightRegular" FluentIcons) props
        static member inline dualScreenArrowUpFilled (props: IIconProp list) = createElement (import "DualScreenArrowUpFilled" FluentIcons) props
        static member inline dualScreenArrowUpRegular (props: IIconProp list) = createElement (import "DualScreenArrowUpRegular" FluentIcons) props
        static member inline dualScreenClockFilled (props: IIconProp list) = createElement (import "DualScreenClockFilled" FluentIcons) props
        static member inline dualScreenClockRegular (props: IIconProp list) = createElement (import "DualScreenClockRegular" FluentIcons) props
        static member inline dualScreenClosedAlertFilled (props: IIconProp list) = createElement (import "DualScreenClosedAlertFilled" FluentIcons) props
        static member inline dualScreenClosedAlertRegular (props: IIconProp list) = createElement (import "DualScreenClosedAlertRegular" FluentIcons) props
        static member inline dualScreenDesktopFilled (props: IIconProp list) = createElement (import "DualScreenDesktopFilled" FluentIcons) props
        static member inline dualScreenDesktopRegular (props: IIconProp list) = createElement (import "DualScreenDesktopRegular" FluentIcons) props
        static member inline dualScreenDismissFilled (props: IIconProp list) = createElement (import "DualScreenDismissFilled" FluentIcons) props
        static member inline dualScreenDismissRegular (props: IIconProp list) = createElement (import "DualScreenDismissRegular" FluentIcons) props
        static member inline dualScreenGroupFilled (props: IIconProp list) = createElement (import "DualScreenGroupFilled" FluentIcons) props
        static member inline dualScreenGroupRegular (props: IIconProp list) = createElement (import "DualScreenGroupRegular" FluentIcons) props
        static member inline dualScreenHeaderFilled (props: IIconProp list) = createElement (import "DualScreenHeaderFilled" FluentIcons) props
        static member inline dualScreenHeaderRegular (props: IIconProp list) = createElement (import "DualScreenHeaderRegular" FluentIcons) props
        static member inline dualScreenLockFilled (props: IIconProp list) = createElement (import "DualScreenLockFilled" FluentIcons) props
        static member inline dualScreenLockRegular (props: IIconProp list) = createElement (import "DualScreenLockRegular" FluentIcons) props
        static member inline dualScreenMirrorFilled (props: IIconProp list) = createElement (import "DualScreenMirrorFilled" FluentIcons) props
        static member inline dualScreenMirrorRegular (props: IIconProp list) = createElement (import "DualScreenMirrorRegular" FluentIcons) props
        static member inline dualScreenPaginationFilled (props: IIconProp list) = createElement (import "DualScreenPaginationFilled" FluentIcons) props
        static member inline dualScreenPaginationRegular (props: IIconProp list) = createElement (import "DualScreenPaginationRegular" FluentIcons) props
        static member inline dualScreenSettingsFilled (props: IIconProp list) = createElement (import "DualScreenSettingsFilled" FluentIcons) props
        static member inline dualScreenSettingsRegular (props: IIconProp list) = createElement (import "DualScreenSettingsRegular" FluentIcons) props
        static member inline dualScreenSpanFilled (props: IIconProp list) = createElement (import "DualScreenSpanFilled" FluentIcons) props
        static member inline dualScreenSpanRegular (props: IIconProp list) = createElement (import "DualScreenSpanRegular" FluentIcons) props
        static member inline dualScreenSpeakerFilled (props: IIconProp list) = createElement (import "DualScreenSpeakerFilled" FluentIcons) props
        static member inline dualScreenSpeakerRegular (props: IIconProp list) = createElement (import "DualScreenSpeakerRegular" FluentIcons) props
        static member inline dualScreenStatusBarFilled (props: IIconProp list) = createElement (import "DualScreenStatusBarFilled" FluentIcons) props
        static member inline dualScreenStatusBarRegular (props: IIconProp list) = createElement (import "DualScreenStatusBarRegular" FluentIcons) props
        static member inline dualScreenTabletFilled (props: IIconProp list) = createElement (import "DualScreenTabletFilled" FluentIcons) props
        static member inline dualScreenTabletRegular (props: IIconProp list) = createElement (import "DualScreenTabletRegular" FluentIcons) props
        static member inline dualScreenUpdateFilled (props: IIconProp list) = createElement (import "DualScreenUpdateFilled" FluentIcons) props
        static member inline dualScreenUpdateRegular (props: IIconProp list) = createElement (import "DualScreenUpdateRegular" FluentIcons) props
        static member inline dualScreenVerticalScrollFilled (props: IIconProp list) = createElement (import "DualScreenVerticalScrollFilled" FluentIcons) props
        static member inline dualScreenVerticalScrollRegular (props: IIconProp list) = createElement (import "DualScreenVerticalScrollRegular" FluentIcons) props
        static member inline dualScreenVibrateFilled (props: IIconProp list) = createElement (import "DualScreenVibrateFilled" FluentIcons) props
        static member inline dualScreenVibrateRegular (props: IIconProp list) = createElement (import "DualScreenVibrateRegular" FluentIcons) props
        static member inline dumbbellFilled (props: IIconProp list) = createElement (import "DumbbellFilled" FluentIcons) props
        static member inline dumbbellRegular (props: IIconProp list) = createElement (import "DumbbellRegular" FluentIcons) props
        static member inline dustFilled (props: IIconProp list) = createElement (import "DustFilled" FluentIcons) props
        static member inline dustRegular (props: IIconProp list) = createElement (import "DustRegular" FluentIcons) props
        static member inline earthFilled (props: IIconProp list) = createElement (import "EarthFilled" FluentIcons) props
        static member inline earthRegular (props: IIconProp list) = createElement (import "EarthRegular" FluentIcons) props
        static member inline earthLeafFilled (props: IIconProp list) = createElement (import "EarthLeafFilled" FluentIcons) props
        static member inline earthLeafRegular (props: IIconProp list) = createElement (import "EarthLeafRegular" FluentIcons) props
        static member inline editFilled (props: IIconProp list) = createElement (import "EditFilled" FluentIcons) props
        static member inline editRegular (props: IIconProp list) = createElement (import "EditRegular" FluentIcons) props
        static member inline editArrowBackFilled (props: IIconProp list) = createElement (import "EditArrowBackFilled" FluentIcons) props
        static member inline editArrowBackRegular (props: IIconProp list) = createElement (import "EditArrowBackRegular" FluentIcons) props
        static member inline editLineHorizontal3Filled (props: IIconProp list) = createElement (import "EditLineHorizontal3Filled" FluentIcons) props
        static member inline editLineHorizontal3Regular (props: IIconProp list) = createElement (import "EditLineHorizontal3Regular" FluentIcons) props
        static member inline editOffFilled (props: IIconProp list) = createElement (import "EditOffFilled" FluentIcons) props
        static member inline editOffRegular (props: IIconProp list) = createElement (import "EditOffRegular" FluentIcons) props
        static member inline editPersonFilled (props: IIconProp list) = createElement (import "EditPersonFilled" FluentIcons) props
        static member inline editPersonRegular (props: IIconProp list) = createElement (import "EditPersonRegular" FluentIcons) props
        static member inline editProhibitedFilled (props: IIconProp list) = createElement (import "EditProhibitedFilled" FluentIcons) props
        static member inline editProhibitedRegular (props: IIconProp list) = createElement (import "EditProhibitedRegular" FluentIcons) props
        static member inline editSettingsFilled (props: IIconProp list) = createElement (import "EditSettingsFilled" FluentIcons) props
        static member inline editSettingsRegular (props: IIconProp list) = createElement (import "EditSettingsRegular" FluentIcons) props
        static member inline elevatorFilled (props: IIconProp list) = createElement (import "ElevatorFilled" FluentIcons) props
        static member inline elevatorRegular (props: IIconProp list) = createElement (import "ElevatorRegular" FluentIcons) props
        static member inline emojiFilled (props: IIconProp list) = createElement (import "EmojiFilled" FluentIcons) props
        static member inline emojiRegular (props: IIconProp list) = createElement (import "EmojiRegular" FluentIcons) props
        static member inline emojiAddFilled (props: IIconProp list) = createElement (import "EmojiAddFilled" FluentIcons) props
        static member inline emojiAddRegular (props: IIconProp list) = createElement (import "EmojiAddRegular" FluentIcons) props
        static member inline emojiAngryFilled (props: IIconProp list) = createElement (import "EmojiAngryFilled" FluentIcons) props
        static member inline emojiAngryRegular (props: IIconProp list) = createElement (import "EmojiAngryRegular" FluentIcons) props
        static member inline emojiEditFilled (props: IIconProp list) = createElement (import "EmojiEditFilled" FluentIcons) props
        static member inline emojiEditRegular (props: IIconProp list) = createElement (import "EmojiEditRegular" FluentIcons) props
        static member inline emojiHandFilled (props: IIconProp list) = createElement (import "EmojiHandFilled" FluentIcons) props
        static member inline emojiHandRegular (props: IIconProp list) = createElement (import "EmojiHandRegular" FluentIcons) props
        static member inline emojiHintFilled (props: IIconProp list) = createElement (import "EmojiHintFilled" FluentIcons) props
        static member inline emojiHintRegular (props: IIconProp list) = createElement (import "EmojiHintRegular" FluentIcons) props
        static member inline emojiLaughFilled (props: IIconProp list) = createElement (import "EmojiLaughFilled" FluentIcons) props
        static member inline emojiLaughRegular (props: IIconProp list) = createElement (import "EmojiLaughRegular" FluentIcons) props
        static member inline emojiMehFilled (props: IIconProp list) = createElement (import "EmojiMehFilled" FluentIcons) props
        static member inline emojiMehRegular (props: IIconProp list) = createElement (import "EmojiMehRegular" FluentIcons) props
        static member inline emojiMemeFilled (props: IIconProp list) = createElement (import "EmojiMemeFilled" FluentIcons) props
        static member inline emojiMemeRegular (props: IIconProp list) = createElement (import "EmojiMemeRegular" FluentIcons) props
        static member inline emojiMultipleFilled (props: IIconProp list) = createElement (import "EmojiMultipleFilled" FluentIcons) props
        static member inline emojiMultipleRegular (props: IIconProp list) = createElement (import "EmojiMultipleRegular" FluentIcons) props
        static member inline emojiSadFilled (props: IIconProp list) = createElement (import "EmojiSadFilled" FluentIcons) props
        static member inline emojiSadRegular (props: IIconProp list) = createElement (import "EmojiSadRegular" FluentIcons) props
        static member inline emojiSadSlightFilled (props: IIconProp list) = createElement (import "EmojiSadSlightFilled" FluentIcons) props
        static member inline emojiSadSlightRegular (props: IIconProp list) = createElement (import "EmojiSadSlightRegular" FluentIcons) props
        static member inline emojiSmileSlightFilled (props: IIconProp list) = createElement (import "EmojiSmileSlightFilled" FluentIcons) props
        static member inline emojiSmileSlightRegular (props: IIconProp list) = createElement (import "EmojiSmileSlightRegular" FluentIcons) props
        static member inline emojiSparkleFilled (props: IIconProp list) = createElement (import "EmojiSparkleFilled" FluentIcons) props
        static member inline emojiSparkleRegular (props: IIconProp list) = createElement (import "EmojiSparkleRegular" FluentIcons) props
        static member inline emojiSurpriseFilled (props: IIconProp list) = createElement (import "EmojiSurpriseFilled" FluentIcons) props
        static member inline emojiSurpriseRegular (props: IIconProp list) = createElement (import "EmojiSurpriseRegular" FluentIcons) props
        static member inline engineFilled (props: IIconProp list) = createElement (import "EngineFilled" FluentIcons) props
        static member inline engineRegular (props: IIconProp list) = createElement (import "EngineRegular" FluentIcons) props
        static member inline equalCircleFilled (props: IIconProp list) = createElement (import "EqualCircleFilled" FluentIcons) props
        static member inline equalCircleRegular (props: IIconProp list) = createElement (import "EqualCircleRegular" FluentIcons) props
        static member inline equalOffFilled (props: IIconProp list) = createElement (import "EqualOffFilled" FluentIcons) props
        static member inline equalOffRegular (props: IIconProp list) = createElement (import "EqualOffRegular" FluentIcons) props
        static member inline eraserFilled (props: IIconProp list) = createElement (import "EraserFilled" FluentIcons) props
        static member inline eraserRegular (props: IIconProp list) = createElement (import "EraserRegular" FluentIcons) props
        static member inline eraserMediumFilled (props: IIconProp list) = createElement (import "EraserMediumFilled" FluentIcons) props
        static member inline eraserMediumRegular (props: IIconProp list) = createElement (import "EraserMediumRegular" FluentIcons) props
        static member inline eraserSegmentFilled (props: IIconProp list) = createElement (import "EraserSegmentFilled" FluentIcons) props
        static member inline eraserSegmentRegular (props: IIconProp list) = createElement (import "EraserSegmentRegular" FluentIcons) props
        static member inline eraserSmallFilled (props: IIconProp list) = createElement (import "EraserSmallFilled" FluentIcons) props
        static member inline eraserSmallRegular (props: IIconProp list) = createElement (import "EraserSmallRegular" FluentIcons) props
        static member inline eraserToolFilled (props: IIconProp list) = createElement (import "EraserToolFilled" FluentIcons) props
        static member inline eraserToolRegular (props: IIconProp list) = createElement (import "EraserToolRegular" FluentIcons) props
        static member inline errorCircleFilled (props: IIconProp list) = createElement (import "ErrorCircleFilled" FluentIcons) props
        static member inline errorCircleRegular (props: IIconProp list) = createElement (import "ErrorCircleRegular" FluentIcons) props
        static member inline errorCircleSettingsFilled (props: IIconProp list) = createElement (import "ErrorCircleSettingsFilled" FluentIcons) props
        static member inline errorCircleSettingsRegular (props: IIconProp list) = createElement (import "ErrorCircleSettingsRegular" FluentIcons) props
        static member inline expandUpLeftFilled (props: IIconProp list) = createElement (import "ExpandUpLeftFilled" FluentIcons) props
        static member inline expandUpLeftRegular (props: IIconProp list) = createElement (import "ExpandUpLeftRegular" FluentIcons) props
        static member inline expandUpRightFilled (props: IIconProp list) = createElement (import "ExpandUpRightFilled" FluentIcons) props
        static member inline expandUpRightRegular (props: IIconProp list) = createElement (import "ExpandUpRightRegular" FluentIcons) props
        static member inline extendedDockFilled (props: IIconProp list) = createElement (import "ExtendedDockFilled" FluentIcons) props
        static member inline extendedDockRegular (props: IIconProp list) = createElement (import "ExtendedDockRegular" FluentIcons) props
        static member inline eyeFilled (props: IIconProp list) = createElement (import "EyeFilled" FluentIcons) props
        static member inline eyeRegular (props: IIconProp list) = createElement (import "EyeRegular" FluentIcons) props
        static member inline eyeLinesFilled (props: IIconProp list) = createElement (import "EyeLinesFilled" FluentIcons) props
        static member inline eyeLinesRegular (props: IIconProp list) = createElement (import "EyeLinesRegular" FluentIcons) props
        static member inline eyeOffFilled (props: IIconProp list) = createElement (import "EyeOffFilled" FluentIcons) props
        static member inline eyeOffRegular (props: IIconProp list) = createElement (import "EyeOffRegular" FluentIcons) props
        static member inline eyeTrackingFilled (props: IIconProp list) = createElement (import "EyeTrackingFilled" FluentIcons) props
        static member inline eyeTrackingRegular (props: IIconProp list) = createElement (import "EyeTrackingRegular" FluentIcons) props
        static member inline eyeTrackingOffFilled (props: IIconProp list) = createElement (import "EyeTrackingOffFilled" FluentIcons) props
        static member inline eyeTrackingOffRegular (props: IIconProp list) = createElement (import "EyeTrackingOffRegular" FluentIcons) props
        static member inline eyedropperFilled (props: IIconProp list) = createElement (import "EyedropperFilled" FluentIcons) props
        static member inline eyedropperRegular (props: IIconProp list) = createElement (import "EyedropperRegular" FluentIcons) props
        static member inline eyedropperOffFilled (props: IIconProp list) = createElement (import "EyedropperOffFilled" FluentIcons) props
        static member inline eyedropperOffRegular (props: IIconProp list) = createElement (import "EyedropperOffRegular" FluentIcons) props
        static member inline fStopFilled (props: IIconProp list) = createElement (import "FStopFilled" FluentIcons) props
        static member inline fStopRegular (props: IIconProp list) = createElement (import "FStopRegular" FluentIcons) props
        static member inline fastAccelerationFilled (props: IIconProp list) = createElement (import "FastAccelerationFilled" FluentIcons) props
        static member inline fastAccelerationRegular (props: IIconProp list) = createElement (import "FastAccelerationRegular" FluentIcons) props
        static member inline fastForwardFilled (props: IIconProp list) = createElement (import "FastForwardFilled" FluentIcons) props
        static member inline fastForwardRegular (props: IIconProp list) = createElement (import "FastForwardRegular" FluentIcons) props
        static member inline faxFilled (props: IIconProp list) = createElement (import "FaxFilled" FluentIcons) props
        static member inline faxRegular (props: IIconProp list) = createElement (import "FaxRegular" FluentIcons) props
        static member inline feedFilled (props: IIconProp list) = createElement (import "FeedFilled" FluentIcons) props
        static member inline feedRegular (props: IIconProp list) = createElement (import "FeedRegular" FluentIcons) props
        static member inline filmstripFilled (props: IIconProp list) = createElement (import "FilmstripFilled" FluentIcons) props
        static member inline filmstripRegular (props: IIconProp list) = createElement (import "FilmstripRegular" FluentIcons) props
        static member inline filmstripImageFilled (props: IIconProp list) = createElement (import "FilmstripImageFilled" FluentIcons) props
        static member inline filmstripImageRegular (props: IIconProp list) = createElement (import "FilmstripImageRegular" FluentIcons) props
        static member inline filmstripPlayFilled (props: IIconProp list) = createElement (import "FilmstripPlayFilled" FluentIcons) props
        static member inline filmstripPlayRegular (props: IIconProp list) = createElement (import "FilmstripPlayRegular" FluentIcons) props
        static member inline filmstripSplitFilled (props: IIconProp list) = createElement (import "FilmstripSplitFilled" FluentIcons) props
        static member inline filmstripSplitRegular (props: IIconProp list) = createElement (import "FilmstripSplitRegular" FluentIcons) props
        static member inline filterFilled (props: IIconProp list) = createElement (import "FilterFilled" FluentIcons) props
        static member inline filterRegular (props: IIconProp list) = createElement (import "FilterRegular" FluentIcons) props
        static member inline filterAddFilled (props: IIconProp list) = createElement (import "FilterAddFilled" FluentIcons) props
        static member inline filterAddRegular (props: IIconProp list) = createElement (import "FilterAddRegular" FluentIcons) props
        static member inline filterDismissFilled (props: IIconProp list) = createElement (import "FilterDismissFilled" FluentIcons) props
        static member inline filterDismissRegular (props: IIconProp list) = createElement (import "FilterDismissRegular" FluentIcons) props
        static member inline filterSyncFilled (props: IIconProp list) = createElement (import "FilterSyncFilled" FluentIcons) props
        static member inline filterSyncRegular (props: IIconProp list) = createElement (import "FilterSyncRegular" FluentIcons) props
        static member inline fingerprintFilled (props: IIconProp list) = createElement (import "FingerprintFilled" FluentIcons) props
        static member inline fingerprintRegular (props: IIconProp list) = createElement (import "FingerprintRegular" FluentIcons) props
        static member inline fireFilled (props: IIconProp list) = createElement (import "FireFilled" FluentIcons) props
        static member inline fireRegular (props: IIconProp list) = createElement (import "FireRegular" FluentIcons) props
        static member inline fireplaceFilled (props: IIconProp list) = createElement (import "FireplaceFilled" FluentIcons) props
        static member inline fireplaceRegular (props: IIconProp list) = createElement (import "FireplaceRegular" FluentIcons) props
        static member inline fixedWidthFilled (props: IIconProp list) = createElement (import "FixedWidthFilled" FluentIcons) props
        static member inline fixedWidthRegular (props: IIconProp list) = createElement (import "FixedWidthRegular" FluentIcons) props
        static member inline flagFilled (props: IIconProp list) = createElement (import "FlagFilled" FluentIcons) props
        static member inline flagRegular (props: IIconProp list) = createElement (import "FlagRegular" FluentIcons) props
        static member inline flagCheckeredFilled (props: IIconProp list) = createElement (import "FlagCheckeredFilled" FluentIcons) props
        static member inline flagCheckeredRegular (props: IIconProp list) = createElement (import "FlagCheckeredRegular" FluentIcons) props
        static member inline flagClockFilled (props: IIconProp list) = createElement (import "FlagClockFilled" FluentIcons) props
        static member inline flagClockRegular (props: IIconProp list) = createElement (import "FlagClockRegular" FluentIcons) props
        static member inline flagOffFilled (props: IIconProp list) = createElement (import "FlagOffFilled" FluentIcons) props
        static member inline flagOffRegular (props: IIconProp list) = createElement (import "FlagOffRegular" FluentIcons) props
        static member inline flagPrideFilled (props: IIconProp list) = createElement (import "FlagPrideFilled" FluentIcons) props
        static member inline flagPrideIntersexInclusiveProgressFilled (props: IIconProp list) = createElement (import "FlagPrideIntersexInclusiveProgressFilled" FluentIcons) props
        static member inline flagPridePhiladelphiaFilled (props: IIconProp list) = createElement (import "FlagPridePhiladelphiaFilled" FluentIcons) props
        static member inline flagPrideProgressFilled (props: IIconProp list) = createElement (import "FlagPrideProgressFilled" FluentIcons) props
        static member inline flashFilled (props: IIconProp list) = createElement (import "FlashFilled" FluentIcons) props
        static member inline flashRegular (props: IIconProp list) = createElement (import "FlashRegular" FluentIcons) props
        static member inline flashAddFilled (props: IIconProp list) = createElement (import "FlashAddFilled" FluentIcons) props
        static member inline flashAddRegular (props: IIconProp list) = createElement (import "FlashAddRegular" FluentIcons) props
        static member inline flashAutoFilled (props: IIconProp list) = createElement (import "FlashAutoFilled" FluentIcons) props
        static member inline flashAutoRegular (props: IIconProp list) = createElement (import "FlashAutoRegular" FluentIcons) props
        static member inline flashCheckmarkFilled (props: IIconProp list) = createElement (import "FlashCheckmarkFilled" FluentIcons) props
        static member inline flashCheckmarkRegular (props: IIconProp list) = createElement (import "FlashCheckmarkRegular" FluentIcons) props
        static member inline flashFlowFilled (props: IIconProp list) = createElement (import "FlashFlowFilled" FluentIcons) props
        static member inline flashFlowRegular (props: IIconProp list) = createElement (import "FlashFlowRegular" FluentIcons) props
        static member inline flashOffFilled (props: IIconProp list) = createElement (import "FlashOffFilled" FluentIcons) props
        static member inline flashOffRegular (props: IIconProp list) = createElement (import "FlashOffRegular" FluentIcons) props
        static member inline flashPlayFilled (props: IIconProp list) = createElement (import "FlashPlayFilled" FluentIcons) props
        static member inline flashPlayRegular (props: IIconProp list) = createElement (import "FlashPlayRegular" FluentIcons) props
        static member inline flashSettingsFilled (props: IIconProp list) = createElement (import "FlashSettingsFilled" FluentIcons) props
        static member inline flashSettingsRegular (props: IIconProp list) = createElement (import "FlashSettingsRegular" FluentIcons) props
        static member inline flashSparkleFilled (props: IIconProp list) = createElement (import "FlashSparkleFilled" FluentIcons) props
        static member inline flashSparkleRegular (props: IIconProp list) = createElement (import "FlashSparkleRegular" FluentIcons) props
        static member inline flashlightFilled (props: IIconProp list) = createElement (import "FlashlightFilled" FluentIcons) props
        static member inline flashlightRegular (props: IIconProp list) = createElement (import "FlashlightRegular" FluentIcons) props
        static member inline flashlightOffFilled (props: IIconProp list) = createElement (import "FlashlightOffFilled" FluentIcons) props
        static member inline flashlightOffRegular (props: IIconProp list) = createElement (import "FlashlightOffRegular" FluentIcons) props
        static member inline flipHorizontalFilled (props: IIconProp list) = createElement (import "FlipHorizontalFilled" FluentIcons) props
        static member inline flipHorizontalRegular (props: IIconProp list) = createElement (import "FlipHorizontalRegular" FluentIcons) props
        static member inline flipVerticalFilled (props: IIconProp list) = createElement (import "FlipVerticalFilled" FluentIcons) props
        static member inline flipVerticalRegular (props: IIconProp list) = createElement (import "FlipVerticalRegular" FluentIcons) props
        static member inline flowFilled (props: IIconProp list) = createElement (import "FlowFilled" FluentIcons) props
        static member inline flowRegular (props: IIconProp list) = createElement (import "FlowRegular" FluentIcons) props
        static member inline flowchartFilled (props: IIconProp list) = createElement (import "FlowchartFilled" FluentIcons) props
        static member inline flowchartRegular (props: IIconProp list) = createElement (import "FlowchartRegular" FluentIcons) props
        static member inline flowchartCircleFilled (props: IIconProp list) = createElement (import "FlowchartCircleFilled" FluentIcons) props
        static member inline flowchartCircleRegular (props: IIconProp list) = createElement (import "FlowchartCircleRegular" FluentIcons) props
        static member inline fluentFilled (props: IIconProp list) = createElement (import "FluentFilled" FluentIcons) props
        static member inline fluentRegular (props: IIconProp list) = createElement (import "FluentRegular" FluentIcons) props
        static member inline fluidFilled (props: IIconProp list) = createElement (import "FluidFilled" FluentIcons) props
        static member inline fluidRegular (props: IIconProp list) = createElement (import "FluidRegular" FluentIcons) props
        static member inline folderFilled (props: IIconProp list) = createElement (import "FolderFilled" FluentIcons) props
        static member inline folderRegular (props: IIconProp list) = createElement (import "FolderRegular" FluentIcons) props
        static member inline folderAddFilled (props: IIconProp list) = createElement (import "FolderAddFilled" FluentIcons) props
        static member inline folderAddRegular (props: IIconProp list) = createElement (import "FolderAddRegular" FluentIcons) props
        static member inline folderArrowLeftFilled (props: IIconProp list) = createElement (import "FolderArrowLeftFilled" FluentIcons) props
        static member inline folderArrowLeftRegular (props: IIconProp list) = createElement (import "FolderArrowLeftRegular" FluentIcons) props
        static member inline folderArrowRightFilled (props: IIconProp list) = createElement (import "FolderArrowRightFilled" FluentIcons) props
        static member inline folderArrowRightRegular (props: IIconProp list) = createElement (import "FolderArrowRightRegular" FluentIcons) props
        static member inline folderArrowUpFilled (props: IIconProp list) = createElement (import "FolderArrowUpFilled" FluentIcons) props
        static member inline folderArrowUpRegular (props: IIconProp list) = createElement (import "FolderArrowUpRegular" FluentIcons) props
        static member inline folderBriefcaseFilled (props: IIconProp list) = createElement (import "FolderBriefcaseFilled" FluentIcons) props
        static member inline folderBriefcaseRegular (props: IIconProp list) = createElement (import "FolderBriefcaseRegular" FluentIcons) props
        static member inline folderGlobeFilled (props: IIconProp list) = createElement (import "FolderGlobeFilled" FluentIcons) props
        static member inline folderGlobeRegular (props: IIconProp list) = createElement (import "FolderGlobeRegular" FluentIcons) props
        static member inline folderLightningFilled (props: IIconProp list) = createElement (import "FolderLightningFilled" FluentIcons) props
        static member inline folderLightningRegular (props: IIconProp list) = createElement (import "FolderLightningRegular" FluentIcons) props
        static member inline folderLinkFilled (props: IIconProp list) = createElement (import "FolderLinkFilled" FluentIcons) props
        static member inline folderLinkRegular (props: IIconProp list) = createElement (import "FolderLinkRegular" FluentIcons) props
        static member inline folderListFilled (props: IIconProp list) = createElement (import "FolderListFilled" FluentIcons) props
        static member inline folderListRegular (props: IIconProp list) = createElement (import "FolderListRegular" FluentIcons) props
        static member inline folderMailFilled (props: IIconProp list) = createElement (import "FolderMailFilled" FluentIcons) props
        static member inline folderMailRegular (props: IIconProp list) = createElement (import "FolderMailRegular" FluentIcons) props
        static member inline folderOpenFilled (props: IIconProp list) = createElement (import "FolderOpenFilled" FluentIcons) props
        static member inline folderOpenRegular (props: IIconProp list) = createElement (import "FolderOpenRegular" FluentIcons) props
        static member inline folderOpenVerticalFilled (props: IIconProp list) = createElement (import "FolderOpenVerticalFilled" FluentIcons) props
        static member inline folderOpenVerticalRegular (props: IIconProp list) = createElement (import "FolderOpenVerticalRegular" FluentIcons) props
        static member inline folderPeopleFilled (props: IIconProp list) = createElement (import "FolderPeopleFilled" FluentIcons) props
        static member inline folderPeopleRegular (props: IIconProp list) = createElement (import "FolderPeopleRegular" FluentIcons) props
        static member inline folderPersonFilled (props: IIconProp list) = createElement (import "FolderPersonFilled" FluentIcons) props
        static member inline folderPersonRegular (props: IIconProp list) = createElement (import "FolderPersonRegular" FluentIcons) props
        static member inline folderProhibitedFilled (props: IIconProp list) = createElement (import "FolderProhibitedFilled" FluentIcons) props
        static member inline folderProhibitedRegular (props: IIconProp list) = createElement (import "FolderProhibitedRegular" FluentIcons) props
        static member inline folderSearchFilled (props: IIconProp list) = createElement (import "FolderSearchFilled" FluentIcons) props
        static member inline folderSearchRegular (props: IIconProp list) = createElement (import "FolderSearchRegular" FluentIcons) props
        static member inline folderSwapFilled (props: IIconProp list) = createElement (import "FolderSwapFilled" FluentIcons) props
        static member inline folderSwapRegular (props: IIconProp list) = createElement (import "FolderSwapRegular" FluentIcons) props
        static member inline folderSyncFilled (props: IIconProp list) = createElement (import "FolderSyncFilled" FluentIcons) props
        static member inline folderSyncRegular (props: IIconProp list) = createElement (import "FolderSyncRegular" FluentIcons) props
        static member inline folderZipFilled (props: IIconProp list) = createElement (import "FolderZipFilled" FluentIcons) props
        static member inline folderZipRegular (props: IIconProp list) = createElement (import "FolderZipRegular" FluentIcons) props
        static member inline fontDecreaseFilled (props: IIconProp list) = createElement (import "FontDecreaseFilled" FluentIcons) props
        static member inline fontDecreaseRegular (props: IIconProp list) = createElement (import "FontDecreaseRegular" FluentIcons) props
        static member inline fontIncreaseFilled (props: IIconProp list) = createElement (import "FontIncreaseFilled" FluentIcons) props
        static member inline fontIncreaseRegular (props: IIconProp list) = createElement (import "FontIncreaseRegular" FluentIcons) props
        static member inline fontSpaceTrackingInFilled (props: IIconProp list) = createElement (import "FontSpaceTrackingInFilled" FluentIcons) props
        static member inline fontSpaceTrackingInRegular (props: IIconProp list) = createElement (import "FontSpaceTrackingInRegular" FluentIcons) props
        static member inline fontSpaceTrackingOutFilled (props: IIconProp list) = createElement (import "FontSpaceTrackingOutFilled" FluentIcons) props
        static member inline fontSpaceTrackingOutRegular (props: IIconProp list) = createElement (import "FontSpaceTrackingOutRegular" FluentIcons) props
        static member inline foodFilled (props: IIconProp list) = createElement (import "FoodFilled" FluentIcons) props
        static member inline foodRegular (props: IIconProp list) = createElement (import "FoodRegular" FluentIcons) props
        static member inline foodAppleFilled (props: IIconProp list) = createElement (import "FoodAppleFilled" FluentIcons) props
        static member inline foodAppleRegular (props: IIconProp list) = createElement (import "FoodAppleRegular" FluentIcons) props
        static member inline foodCakeFilled (props: IIconProp list) = createElement (import "FoodCakeFilled" FluentIcons) props
        static member inline foodCakeRegular (props: IIconProp list) = createElement (import "FoodCakeRegular" FluentIcons) props
        static member inline foodCarrotFilled (props: IIconProp list) = createElement (import "FoodCarrotFilled" FluentIcons) props
        static member inline foodCarrotRegular (props: IIconProp list) = createElement (import "FoodCarrotRegular" FluentIcons) props
        static member inline foodChickenLegFilled (props: IIconProp list) = createElement (import "FoodChickenLegFilled" FluentIcons) props
        static member inline foodChickenLegRegular (props: IIconProp list) = createElement (import "FoodChickenLegRegular" FluentIcons) props
        static member inline foodEggFilled (props: IIconProp list) = createElement (import "FoodEggFilled" FluentIcons) props
        static member inline foodEggRegular (props: IIconProp list) = createElement (import "FoodEggRegular" FluentIcons) props
        static member inline foodFishFilled (props: IIconProp list) = createElement (import "FoodFishFilled" FluentIcons) props
        static member inline foodFishRegular (props: IIconProp list) = createElement (import "FoodFishRegular" FluentIcons) props
        static member inline foodGrainsFilled (props: IIconProp list) = createElement (import "FoodGrainsFilled" FluentIcons) props
        static member inline foodGrainsRegular (props: IIconProp list) = createElement (import "FoodGrainsRegular" FluentIcons) props
        static member inline foodPizzaFilled (props: IIconProp list) = createElement (import "FoodPizzaFilled" FluentIcons) props
        static member inline foodPizzaRegular (props: IIconProp list) = createElement (import "FoodPizzaRegular" FluentIcons) props
        static member inline foodToastFilled (props: IIconProp list) = createElement (import "FoodToastFilled" FluentIcons) props
        static member inline foodToastRegular (props: IIconProp list) = createElement (import "FoodToastRegular" FluentIcons) props
        static member inline formFilled (props: IIconProp list) = createElement (import "FormFilled" FluentIcons) props
        static member inline formRegular (props: IIconProp list) = createElement (import "FormRegular" FluentIcons) props
        static member inline formMultipleFilled (props: IIconProp list) = createElement (import "FormMultipleFilled" FluentIcons) props
        static member inline formMultipleRegular (props: IIconProp list) = createElement (import "FormMultipleRegular" FluentIcons) props
        static member inline formNewFilled (props: IIconProp list) = createElement (import "FormNewFilled" FluentIcons) props
        static member inline formNewRegular (props: IIconProp list) = createElement (import "FormNewRegular" FluentIcons) props
        static member inline fps120Filled (props: IIconProp list) = createElement (import "Fps120Filled" FluentIcons) props
        static member inline fps120Regular (props: IIconProp list) = createElement (import "Fps120Regular" FluentIcons) props
        static member inline fps124Filled (props: IIconProp list) = createElement (import "Fps124Filled" FluentIcons) props
        static member inline fps124Regular (props: IIconProp list) = createElement (import "Fps124Regular" FluentIcons) props
        static member inline fps240Filled (props: IIconProp list) = createElement (import "Fps240Filled" FluentIcons) props
        static member inline fps240Regular (props: IIconProp list) = createElement (import "Fps240Regular" FluentIcons) props
        static member inline fps30Filled (props: IIconProp list) = createElement (import "Fps30Filled" FluentIcons) props
        static member inline fps30Regular (props: IIconProp list) = createElement (import "Fps30Regular" FluentIcons) props
        static member inline fps60Filled (props: IIconProp list) = createElement (import "Fps60Filled" FluentIcons) props
        static member inline fps60Regular (props: IIconProp list) = createElement (import "Fps60Regular" FluentIcons) props
        static member inline fps960Filled (props: IIconProp list) = createElement (import "Fps960Filled" FluentIcons) props
        static member inline fps960Regular (props: IIconProp list) = createElement (import "Fps960Regular" FluentIcons) props
        static member inline frameFilled (props: IIconProp list) = createElement (import "FrameFilled" FluentIcons) props
        static member inline frameRegular (props: IIconProp list) = createElement (import "FrameRegular" FluentIcons) props
        static member inline fullScreenMaximizeFilled (props: IIconProp list) = createElement (import "FullScreenMaximizeFilled" FluentIcons) props
        static member inline fullScreenMaximizeRegular (props: IIconProp list) = createElement (import "FullScreenMaximizeRegular" FluentIcons) props
        static member inline fullScreenMinimizeFilled (props: IIconProp list) = createElement (import "FullScreenMinimizeFilled" FluentIcons) props
        static member inline fullScreenMinimizeRegular (props: IIconProp list) = createElement (import "FullScreenMinimizeRegular" FluentIcons) props
        static member inline gameChatFilled (props: IIconProp list) = createElement (import "GameChatFilled" FluentIcons) props
        static member inline gameChatRegular (props: IIconProp list) = createElement (import "GameChatRegular" FluentIcons) props
        static member inline gamesFilled (props: IIconProp list) = createElement (import "GamesFilled" FluentIcons) props
        static member inline gamesRegular (props: IIconProp list) = createElement (import "GamesRegular" FluentIcons) props
        static member inline ganttChartFilled (props: IIconProp list) = createElement (import "GanttChartFilled" FluentIcons) props
        static member inline ganttChartRegular (props: IIconProp list) = createElement (import "GanttChartRegular" FluentIcons) props
        static member inline gasFilled (props: IIconProp list) = createElement (import "GasFilled" FluentIcons) props
        static member inline gasRegular (props: IIconProp list) = createElement (import "GasRegular" FluentIcons) props
        static member inline gasPumpFilled (props: IIconProp list) = createElement (import "GasPumpFilled" FluentIcons) props
        static member inline gasPumpRegular (props: IIconProp list) = createElement (import "GasPumpRegular" FluentIcons) props
        static member inline gatherFilled (props: IIconProp list) = createElement (import "GatherFilled" FluentIcons) props
        static member inline gatherRegular (props: IIconProp list) = createElement (import "GatherRegular" FluentIcons) props
        static member inline gaugeFilled (props: IIconProp list) = createElement (import "GaugeFilled" FluentIcons) props
        static member inline gaugeRegular (props: IIconProp list) = createElement (import "GaugeRegular" FluentIcons) props
        static member inline gaugeAddFilled (props: IIconProp list) = createElement (import "GaugeAddFilled" FluentIcons) props
        static member inline gaugeAddRegular (props: IIconProp list) = createElement (import "GaugeAddRegular" FluentIcons) props
        static member inline gavelFilled (props: IIconProp list) = createElement (import "GavelFilled" FluentIcons) props
        static member inline gavelRegular (props: IIconProp list) = createElement (import "GavelRegular" FluentIcons) props
        static member inline gavelProhibitedFilled (props: IIconProp list) = createElement (import "GavelProhibitedFilled" FluentIcons) props
        static member inline gavelProhibitedRegular (props: IIconProp list) = createElement (import "GavelProhibitedRegular" FluentIcons) props
        static member inline gestureFilled (props: IIconProp list) = createElement (import "GestureFilled" FluentIcons) props
        static member inline gestureRegular (props: IIconProp list) = createElement (import "GestureRegular" FluentIcons) props
        static member inline gifFilled (props: IIconProp list) = createElement (import "GifFilled" FluentIcons) props
        static member inline gifRegular (props: IIconProp list) = createElement (import "GifRegular" FluentIcons) props
        static member inline giftFilled (props: IIconProp list) = createElement (import "GiftFilled" FluentIcons) props
        static member inline giftRegular (props: IIconProp list) = createElement (import "GiftRegular" FluentIcons) props
        static member inline giftCardFilled (props: IIconProp list) = createElement (import "GiftCardFilled" FluentIcons) props
        static member inline giftCardRegular (props: IIconProp list) = createElement (import "GiftCardRegular" FluentIcons) props
        static member inline giftCardAddFilled (props: IIconProp list) = createElement (import "GiftCardAddFilled" FluentIcons) props
        static member inline giftCardAddRegular (props: IIconProp list) = createElement (import "GiftCardAddRegular" FluentIcons) props
        static member inline giftCardArrowRightFilled (props: IIconProp list) = createElement (import "GiftCardArrowRightFilled" FluentIcons) props
        static member inline giftCardArrowRightRegular (props: IIconProp list) = createElement (import "GiftCardArrowRightRegular" FluentIcons) props
        static member inline giftCardMoneyFilled (props: IIconProp list) = createElement (import "GiftCardMoneyFilled" FluentIcons) props
        static member inline giftCardMoneyRegular (props: IIconProp list) = createElement (import "GiftCardMoneyRegular" FluentIcons) props
        static member inline giftCardMultipleFilled (props: IIconProp list) = createElement (import "GiftCardMultipleFilled" FluentIcons) props
        static member inline giftCardMultipleRegular (props: IIconProp list) = createElement (import "GiftCardMultipleRegular" FluentIcons) props
        static member inline giftOpenFilled (props: IIconProp list) = createElement (import "GiftOpenFilled" FluentIcons) props
        static member inline giftOpenRegular (props: IIconProp list) = createElement (import "GiftOpenRegular" FluentIcons) props
        static member inline glanceFilled (props: IIconProp list) = createElement (import "GlanceFilled" FluentIcons) props
        static member inline glanceRegular (props: IIconProp list) = createElement (import "GlanceRegular" FluentIcons) props
        static member inline glanceHorizontalFilled (props: IIconProp list) = createElement (import "GlanceHorizontalFilled" FluentIcons) props
        static member inline glanceHorizontalRegular (props: IIconProp list) = createElement (import "GlanceHorizontalRegular" FluentIcons) props
        static member inline glanceHorizontalSparklesFilled (props: IIconProp list) = createElement (import "GlanceHorizontalSparklesFilled" FluentIcons) props
        static member inline glanceHorizontalSparklesRegular (props: IIconProp list) = createElement (import "GlanceHorizontalSparklesRegular" FluentIcons) props
        static member inline glassesFilled (props: IIconProp list) = createElement (import "GlassesFilled" FluentIcons) props
        static member inline glassesRegular (props: IIconProp list) = createElement (import "GlassesRegular" FluentIcons) props
        static member inline glassesOffFilled (props: IIconProp list) = createElement (import "GlassesOffFilled" FluentIcons) props
        static member inline glassesOffRegular (props: IIconProp list) = createElement (import "GlassesOffRegular" FluentIcons) props
        static member inline globeFilled (props: IIconProp list) = createElement (import "GlobeFilled" FluentIcons) props
        static member inline globeRegular (props: IIconProp list) = createElement (import "GlobeRegular" FluentIcons) props
        static member inline globeAddFilled (props: IIconProp list) = createElement (import "GlobeAddFilled" FluentIcons) props
        static member inline globeAddRegular (props: IIconProp list) = createElement (import "GlobeAddRegular" FluentIcons) props
        static member inline globeArrowForwardFilled (props: IIconProp list) = createElement (import "GlobeArrowForwardFilled" FluentIcons) props
        static member inline globeArrowForwardRegular (props: IIconProp list) = createElement (import "GlobeArrowForwardRegular" FluentIcons) props
        static member inline globeArrowUpFilled (props: IIconProp list) = createElement (import "GlobeArrowUpFilled" FluentIcons) props
        static member inline globeArrowUpRegular (props: IIconProp list) = createElement (import "GlobeArrowUpRegular" FluentIcons) props
        static member inline globeClockFilled (props: IIconProp list) = createElement (import "GlobeClockFilled" FluentIcons) props
        static member inline globeClockRegular (props: IIconProp list) = createElement (import "GlobeClockRegular" FluentIcons) props
        static member inline globeDesktopFilled (props: IIconProp list) = createElement (import "GlobeDesktopFilled" FluentIcons) props
        static member inline globeDesktopRegular (props: IIconProp list) = createElement (import "GlobeDesktopRegular" FluentIcons) props
        static member inline globeErrorFilled (props: IIconProp list) = createElement (import "GlobeErrorFilled" FluentIcons) props
        static member inline globeErrorRegular (props: IIconProp list) = createElement (import "GlobeErrorRegular" FluentIcons) props
        static member inline globeLocationFilled (props: IIconProp list) = createElement (import "GlobeLocationFilled" FluentIcons) props
        static member inline globeLocationRegular (props: IIconProp list) = createElement (import "GlobeLocationRegular" FluentIcons) props
        static member inline globePersonFilled (props: IIconProp list) = createElement (import "GlobePersonFilled" FluentIcons) props
        static member inline globePersonRegular (props: IIconProp list) = createElement (import "GlobePersonRegular" FluentIcons) props
        static member inline globeProhibitedFilled (props: IIconProp list) = createElement (import "GlobeProhibitedFilled" FluentIcons) props
        static member inline globeProhibitedRegular (props: IIconProp list) = createElement (import "GlobeProhibitedRegular" FluentIcons) props
        static member inline globeSearchFilled (props: IIconProp list) = createElement (import "GlobeSearchFilled" FluentIcons) props
        static member inline globeSearchRegular (props: IIconProp list) = createElement (import "GlobeSearchRegular" FluentIcons) props
        static member inline globeShieldFilled (props: IIconProp list) = createElement (import "GlobeShieldFilled" FluentIcons) props
        static member inline globeShieldRegular (props: IIconProp list) = createElement (import "GlobeShieldRegular" FluentIcons) props
        static member inline globeStarFilled (props: IIconProp list) = createElement (import "GlobeStarFilled" FluentIcons) props
        static member inline globeStarRegular (props: IIconProp list) = createElement (import "GlobeStarRegular" FluentIcons) props
        static member inline globeSurfaceFilled (props: IIconProp list) = createElement (import "GlobeSurfaceFilled" FluentIcons) props
        static member inline globeSurfaceRegular (props: IIconProp list) = createElement (import "GlobeSurfaceRegular" FluentIcons) props
        static member inline globeSyncFilled (props: IIconProp list) = createElement (import "GlobeSyncFilled" FluentIcons) props
        static member inline globeSyncRegular (props: IIconProp list) = createElement (import "GlobeSyncRegular" FluentIcons) props
        static member inline globeVideoFilled (props: IIconProp list) = createElement (import "GlobeVideoFilled" FluentIcons) props
        static member inline globeVideoRegular (props: IIconProp list) = createElement (import "GlobeVideoRegular" FluentIcons) props
        static member inline globeWarningFilled (props: IIconProp list) = createElement (import "GlobeWarningFilled" FluentIcons) props
        static member inline globeWarningRegular (props: IIconProp list) = createElement (import "GlobeWarningRegular" FluentIcons) props
        static member inline gridFilled (props: IIconProp list) = createElement (import "GridFilled" FluentIcons) props
        static member inline gridRegular (props: IIconProp list) = createElement (import "GridRegular" FluentIcons) props
        static member inline gridDotsFilled (props: IIconProp list) = createElement (import "GridDotsFilled" FluentIcons) props
        static member inline gridDotsRegular (props: IIconProp list) = createElement (import "GridDotsRegular" FluentIcons) props
        static member inline gridKanbanFilled (props: IIconProp list) = createElement (import "GridKanbanFilled" FluentIcons) props
        static member inline gridKanbanRegular (props: IIconProp list) = createElement (import "GridKanbanRegular" FluentIcons) props
        static member inline groupFilled (props: IIconProp list) = createElement (import "GroupFilled" FluentIcons) props
        static member inline groupRegular (props: IIconProp list) = createElement (import "GroupRegular" FluentIcons) props
        static member inline groupDismissFilled (props: IIconProp list) = createElement (import "GroupDismissFilled" FluentIcons) props
        static member inline groupDismissRegular (props: IIconProp list) = createElement (import "GroupDismissRegular" FluentIcons) props
        static member inline groupListFilled (props: IIconProp list) = createElement (import "GroupListFilled" FluentIcons) props
        static member inline groupListRegular (props: IIconProp list) = createElement (import "GroupListRegular" FluentIcons) props
        static member inline groupReturnFilled (props: IIconProp list) = createElement (import "GroupReturnFilled" FluentIcons) props
        static member inline groupReturnRegular (props: IIconProp list) = createElement (import "GroupReturnRegular" FluentIcons) props
        static member inline guardianFilled (props: IIconProp list) = createElement (import "GuardianFilled" FluentIcons) props
        static member inline guardianRegular (props: IIconProp list) = createElement (import "GuardianRegular" FluentIcons) props
        static member inline guestFilled (props: IIconProp list) = createElement (import "GuestFilled" FluentIcons) props
        static member inline guestRegular (props: IIconProp list) = createElement (import "GuestRegular" FluentIcons) props
        static member inline guestAddFilled (props: IIconProp list) = createElement (import "GuestAddFilled" FluentIcons) props
        static member inline guestAddRegular (props: IIconProp list) = createElement (import "GuestAddRegular" FluentIcons) props
        static member inline guitarFilled (props: IIconProp list) = createElement (import "GuitarFilled" FluentIcons) props
        static member inline guitarRegular (props: IIconProp list) = createElement (import "GuitarRegular" FluentIcons) props
        static member inline handDrawFilled (props: IIconProp list) = createElement (import "HandDrawFilled" FluentIcons) props
        static member inline handDrawRegular (props: IIconProp list) = createElement (import "HandDrawRegular" FluentIcons) props
        static member inline handLeftFilled (props: IIconProp list) = createElement (import "HandLeftFilled" FluentIcons) props
        static member inline handLeftRegular (props: IIconProp list) = createElement (import "HandLeftRegular" FluentIcons) props
        static member inline handLeftChatFilled (props: IIconProp list) = createElement (import "HandLeftChatFilled" FluentIcons) props
        static member inline handLeftChatRegular (props: IIconProp list) = createElement (import "HandLeftChatRegular" FluentIcons) props
        static member inline handOpenHeartFilled (props: IIconProp list) = createElement (import "HandOpenHeartFilled" FluentIcons) props
        static member inline handOpenHeartRegular (props: IIconProp list) = createElement (import "HandOpenHeartRegular" FluentIcons) props
        static member inline handPointFilled (props: IIconProp list) = createElement (import "HandPointFilled" FluentIcons) props
        static member inline handPointRegular (props: IIconProp list) = createElement (import "HandPointRegular" FluentIcons) props
        static member inline handRightFilled (props: IIconProp list) = createElement (import "HandRightFilled" FluentIcons) props
        static member inline handRightRegular (props: IIconProp list) = createElement (import "HandRightRegular" FluentIcons) props
        static member inline handRightOffFilled (props: IIconProp list) = createElement (import "HandRightOffFilled" FluentIcons) props
        static member inline handRightOffRegular (props: IIconProp list) = createElement (import "HandRightOffRegular" FluentIcons) props
        static member inline handWaveFilled (props: IIconProp list) = createElement (import "HandWaveFilled" FluentIcons) props
        static member inline handWaveRegular (props: IIconProp list) = createElement (import "HandWaveRegular" FluentIcons) props
        static member inline handshakeFilled (props: IIconProp list) = createElement (import "HandshakeFilled" FluentIcons) props
        static member inline handshakeRegular (props: IIconProp list) = createElement (import "HandshakeRegular" FluentIcons) props
        static member inline hapticStrongFilled (props: IIconProp list) = createElement (import "HapticStrongFilled" FluentIcons) props
        static member inline hapticStrongRegular (props: IIconProp list) = createElement (import "HapticStrongRegular" FluentIcons) props
        static member inline hapticWeakFilled (props: IIconProp list) = createElement (import "HapticWeakFilled" FluentIcons) props
        static member inline hapticWeakRegular (props: IIconProp list) = createElement (import "HapticWeakRegular" FluentIcons) props
        static member inline hardDriveFilled (props: IIconProp list) = createElement (import "HardDriveFilled" FluentIcons) props
        static member inline hardDriveRegular (props: IIconProp list) = createElement (import "HardDriveRegular" FluentIcons) props
        static member inline hatGraduationFilled (props: IIconProp list) = createElement (import "HatGraduationFilled" FluentIcons) props
        static member inline hatGraduationRegular (props: IIconProp list) = createElement (import "HatGraduationRegular" FluentIcons) props
        static member inline hatGraduationAddFilled (props: IIconProp list) = createElement (import "HatGraduationAddFilled" FluentIcons) props
        static member inline hatGraduationAddRegular (props: IIconProp list) = createElement (import "HatGraduationAddRegular" FluentIcons) props
        static member inline hatGraduationSparkleFilled (props: IIconProp list) = createElement (import "HatGraduationSparkleFilled" FluentIcons) props
        static member inline hatGraduationSparkleRegular (props: IIconProp list) = createElement (import "HatGraduationSparkleRegular" FluentIcons) props
        static member inline hdFilled (props: IIconProp list) = createElement (import "HdFilled" FluentIcons) props
        static member inline hdRegular (props: IIconProp list) = createElement (import "HdRegular" FluentIcons) props
        static member inline hdrFilled (props: IIconProp list) = createElement (import "HdrFilled" FluentIcons) props
        static member inline hdrRegular (props: IIconProp list) = createElement (import "HdrRegular" FluentIcons) props
        static member inline hdrOffFilled (props: IIconProp list) = createElement (import "HdrOffFilled" FluentIcons) props
        static member inline hdrOffRegular (props: IIconProp list) = createElement (import "HdrOffRegular" FluentIcons) props
        static member inline headphonesFilled (props: IIconProp list) = createElement (import "HeadphonesFilled" FluentIcons) props
        static member inline headphonesRegular (props: IIconProp list) = createElement (import "HeadphonesRegular" FluentIcons) props
        static member inline headphonesSoundWaveFilled (props: IIconProp list) = createElement (import "HeadphonesSoundWaveFilled" FluentIcons) props
        static member inline headphonesSoundWaveRegular (props: IIconProp list) = createElement (import "HeadphonesSoundWaveRegular" FluentIcons) props
        static member inline headsetFilled (props: IIconProp list) = createElement (import "HeadsetFilled" FluentIcons) props
        static member inline headsetRegular (props: IIconProp list) = createElement (import "HeadsetRegular" FluentIcons) props
        static member inline headsetAddFilled (props: IIconProp list) = createElement (import "HeadsetAddFilled" FluentIcons) props
        static member inline headsetAddRegular (props: IIconProp list) = createElement (import "HeadsetAddRegular" FluentIcons) props
        static member inline headsetVrFilled (props: IIconProp list) = createElement (import "HeadsetVrFilled" FluentIcons) props
        static member inline headsetVrRegular (props: IIconProp list) = createElement (import "HeadsetVrRegular" FluentIcons) props
        static member inline heartFilled (props: IIconProp list) = createElement (import "HeartFilled" FluentIcons) props
        static member inline heartRegular (props: IIconProp list) = createElement (import "HeartRegular" FluentIcons) props
        static member inline heartBrokenFilled (props: IIconProp list) = createElement (import "HeartBrokenFilled" FluentIcons) props
        static member inline heartBrokenRegular (props: IIconProp list) = createElement (import "HeartBrokenRegular" FluentIcons) props
        static member inline heartCircleFilled (props: IIconProp list) = createElement (import "HeartCircleFilled" FluentIcons) props
        static member inline heartCircleRegular (props: IIconProp list) = createElement (import "HeartCircleRegular" FluentIcons) props
        static member inline heartCircleHintFilled (props: IIconProp list) = createElement (import "HeartCircleHintFilled" FluentIcons) props
        static member inline heartCircleHintRegular (props: IIconProp list) = createElement (import "HeartCircleHintRegular" FluentIcons) props
        static member inline heartOffFilled (props: IIconProp list) = createElement (import "HeartOffFilled" FluentIcons) props
        static member inline heartOffRegular (props: IIconProp list) = createElement (import "HeartOffRegular" FluentIcons) props
        static member inline heartPulseFilled (props: IIconProp list) = createElement (import "HeartPulseFilled" FluentIcons) props
        static member inline heartPulseRegular (props: IIconProp list) = createElement (import "HeartPulseRegular" FluentIcons) props
        static member inline heartPulseCheckmarkFilled (props: IIconProp list) = createElement (import "HeartPulseCheckmarkFilled" FluentIcons) props
        static member inline heartPulseCheckmarkRegular (props: IIconProp list) = createElement (import "HeartPulseCheckmarkRegular" FluentIcons) props
        static member inline heartPulseErrorFilled (props: IIconProp list) = createElement (import "HeartPulseErrorFilled" FluentIcons) props
        static member inline heartPulseErrorRegular (props: IIconProp list) = createElement (import "HeartPulseErrorRegular" FluentIcons) props
        static member inline heartPulseWarningFilled (props: IIconProp list) = createElement (import "HeartPulseWarningFilled" FluentIcons) props
        static member inline heartPulseWarningRegular (props: IIconProp list) = createElement (import "HeartPulseWarningRegular" FluentIcons) props
        static member inline hexagonFilled (props: IIconProp list) = createElement (import "HexagonFilled" FluentIcons) props
        static member inline hexagonRegular (props: IIconProp list) = createElement (import "HexagonRegular" FluentIcons) props
        static member inline hexagonSparkleFilled (props: IIconProp list) = createElement (import "HexagonSparkleFilled" FluentIcons) props
        static member inline hexagonSparkleRegular (props: IIconProp list) = createElement (import "HexagonSparkleRegular" FluentIcons) props
        static member inline hexagonThreeFilled (props: IIconProp list) = createElement (import "HexagonThreeFilled" FluentIcons) props
        static member inline hexagonThreeRegular (props: IIconProp list) = createElement (import "HexagonThreeRegular" FluentIcons) props
        static member inline highlightFilled (props: IIconProp list) = createElement (import "HighlightFilled" FluentIcons) props
        static member inline highlightRegular (props: IIconProp list) = createElement (import "HighlightRegular" FluentIcons) props
        static member inline highlightAccentFilled (props: IIconProp list) = createElement (import "HighlightAccentFilled" FluentIcons) props
        static member inline highlightLinkFilled (props: IIconProp list) = createElement (import "HighlightLinkFilled" FluentIcons) props
        static member inline highlightLinkRegular (props: IIconProp list) = createElement (import "HighlightLinkRegular" FluentIcons) props
        static member inline highwayFilled (props: IIconProp list) = createElement (import "HighwayFilled" FluentIcons) props
        static member inline highwayRegular (props: IIconProp list) = createElement (import "HighwayRegular" FluentIcons) props
        static member inline historyFilled (props: IIconProp list) = createElement (import "HistoryFilled" FluentIcons) props
        static member inline historyRegular (props: IIconProp list) = createElement (import "HistoryRegular" FluentIcons) props
        static member inline historyDismissFilled (props: IIconProp list) = createElement (import "HistoryDismissFilled" FluentIcons) props
        static member inline historyDismissRegular (props: IIconProp list) = createElement (import "HistoryDismissRegular" FluentIcons) props
        static member inline homeFilled (props: IIconProp list) = createElement (import "HomeFilled" FluentIcons) props
        static member inline homeRegular (props: IIconProp list) = createElement (import "HomeRegular" FluentIcons) props
        static member inline homeAddFilled (props: IIconProp list) = createElement (import "HomeAddFilled" FluentIcons) props
        static member inline homeAddRegular (props: IIconProp list) = createElement (import "HomeAddRegular" FluentIcons) props
        static member inline homeCheckmarkFilled (props: IIconProp list) = createElement (import "HomeCheckmarkFilled" FluentIcons) props
        static member inline homeCheckmarkRegular (props: IIconProp list) = createElement (import "HomeCheckmarkRegular" FluentIcons) props
        static member inline homeDatabaseFilled (props: IIconProp list) = createElement (import "HomeDatabaseFilled" FluentIcons) props
        static member inline homeDatabaseRegular (props: IIconProp list) = createElement (import "HomeDatabaseRegular" FluentIcons) props
        static member inline homeGarageFilled (props: IIconProp list) = createElement (import "HomeGarageFilled" FluentIcons) props
        static member inline homeGarageRegular (props: IIconProp list) = createElement (import "HomeGarageRegular" FluentIcons) props
        static member inline homeHeartFilled (props: IIconProp list) = createElement (import "HomeHeartFilled" FluentIcons) props
        static member inline homeHeartRegular (props: IIconProp list) = createElement (import "HomeHeartRegular" FluentIcons) props
        static member inline homeMoreFilled (props: IIconProp list) = createElement (import "HomeMoreFilled" FluentIcons) props
        static member inline homeMoreRegular (props: IIconProp list) = createElement (import "HomeMoreRegular" FluentIcons) props
        static member inline homePersonFilled (props: IIconProp list) = createElement (import "HomePersonFilled" FluentIcons) props
        static member inline homePersonRegular (props: IIconProp list) = createElement (import "HomePersonRegular" FluentIcons) props
        static member inline homeSplitFilled (props: IIconProp list) = createElement (import "HomeSplitFilled" FluentIcons) props
        static member inline homeSplitRegular (props: IIconProp list) = createElement (import "HomeSplitRegular" FluentIcons) props
        static member inline hourglassFilled (props: IIconProp list) = createElement (import "HourglassFilled" FluentIcons) props
        static member inline hourglassRegular (props: IIconProp list) = createElement (import "HourglassRegular" FluentIcons) props
        static member inline hourglassHalfFilled (props: IIconProp list) = createElement (import "HourglassHalfFilled" FluentIcons) props
        static member inline hourglassHalfRegular (props: IIconProp list) = createElement (import "HourglassHalfRegular" FluentIcons) props
        static member inline hourglassOneQuarterFilled (props: IIconProp list) = createElement (import "HourglassOneQuarterFilled" FluentIcons) props
        static member inline hourglassOneQuarterRegular (props: IIconProp list) = createElement (import "HourglassOneQuarterRegular" FluentIcons) props
        static member inline hourglassThreeQuarterFilled (props: IIconProp list) = createElement (import "HourglassThreeQuarterFilled" FluentIcons) props
        static member inline hourglassThreeQuarterRegular (props: IIconProp list) = createElement (import "HourglassThreeQuarterRegular" FluentIcons) props
        static member inline iconsFilled (props: IIconProp list) = createElement (import "IconsFilled" FluentIcons) props
        static member inline iconsRegular (props: IIconProp list) = createElement (import "IconsRegular" FluentIcons) props
        static member inline imageFilled (props: IIconProp list) = createElement (import "ImageFilled" FluentIcons) props
        static member inline imageRegular (props: IIconProp list) = createElement (import "ImageRegular" FluentIcons) props
        static member inline imageAddFilled (props: IIconProp list) = createElement (import "ImageAddFilled" FluentIcons) props
        static member inline imageAddRegular (props: IIconProp list) = createElement (import "ImageAddRegular" FluentIcons) props
        static member inline imageAltTextFilled (props: IIconProp list) = createElement (import "ImageAltTextFilled" FluentIcons) props
        static member inline imageAltTextRegular (props: IIconProp list) = createElement (import "ImageAltTextRegular" FluentIcons) props
        static member inline imageArrowBackFilled (props: IIconProp list) = createElement (import "ImageArrowBackFilled" FluentIcons) props
        static member inline imageArrowBackRegular (props: IIconProp list) = createElement (import "ImageArrowBackRegular" FluentIcons) props
        static member inline imageArrowCounterclockwiseFilled (props: IIconProp list) = createElement (import "ImageArrowCounterclockwiseFilled" FluentIcons) props
        static member inline imageArrowCounterclockwiseRegular (props: IIconProp list) = createElement (import "ImageArrowCounterclockwiseRegular" FluentIcons) props
        static member inline imageArrowForwardFilled (props: IIconProp list) = createElement (import "ImageArrowForwardFilled" FluentIcons) props
        static member inline imageArrowForwardRegular (props: IIconProp list) = createElement (import "ImageArrowForwardRegular" FluentIcons) props
        static member inline imageBorderFilled (props: IIconProp list) = createElement (import "ImageBorderFilled" FluentIcons) props
        static member inline imageBorderRegular (props: IIconProp list) = createElement (import "ImageBorderRegular" FluentIcons) props
        static member inline imageCircleFilled (props: IIconProp list) = createElement (import "ImageCircleFilled" FluentIcons) props
        static member inline imageCircleRegular (props: IIconProp list) = createElement (import "ImageCircleRegular" FluentIcons) props
        static member inline imageCopyFilled (props: IIconProp list) = createElement (import "ImageCopyFilled" FluentIcons) props
        static member inline imageCopyRegular (props: IIconProp list) = createElement (import "ImageCopyRegular" FluentIcons) props
        static member inline imageEditFilled (props: IIconProp list) = createElement (import "ImageEditFilled" FluentIcons) props
        static member inline imageEditRegular (props: IIconProp list) = createElement (import "ImageEditRegular" FluentIcons) props
        static member inline imageGlobeFilled (props: IIconProp list) = createElement (import "ImageGlobeFilled" FluentIcons) props
        static member inline imageGlobeRegular (props: IIconProp list) = createElement (import "ImageGlobeRegular" FluentIcons) props
        static member inline imageMultipleFilled (props: IIconProp list) = createElement (import "ImageMultipleFilled" FluentIcons) props
        static member inline imageMultipleRegular (props: IIconProp list) = createElement (import "ImageMultipleRegular" FluentIcons) props
        static member inline imageMultipleOffFilled (props: IIconProp list) = createElement (import "ImageMultipleOffFilled" FluentIcons) props
        static member inline imageMultipleOffRegular (props: IIconProp list) = createElement (import "ImageMultipleOffRegular" FluentIcons) props
        static member inline imageOffFilled (props: IIconProp list) = createElement (import "ImageOffFilled" FluentIcons) props
        static member inline imageOffRegular (props: IIconProp list) = createElement (import "ImageOffRegular" FluentIcons) props
        static member inline imageProhibitedFilled (props: IIconProp list) = createElement (import "ImageProhibitedFilled" FluentIcons) props
        static member inline imageProhibitedRegular (props: IIconProp list) = createElement (import "ImageProhibitedRegular" FluentIcons) props
        static member inline imageReflectionFilled (props: IIconProp list) = createElement (import "ImageReflectionFilled" FluentIcons) props
        static member inline imageReflectionRegular (props: IIconProp list) = createElement (import "ImageReflectionRegular" FluentIcons) props
        static member inline imageSearchFilled (props: IIconProp list) = createElement (import "ImageSearchFilled" FluentIcons) props
        static member inline imageSearchRegular (props: IIconProp list) = createElement (import "ImageSearchRegular" FluentIcons) props
        static member inline imageShadowFilled (props: IIconProp list) = createElement (import "ImageShadowFilled" FluentIcons) props
        static member inline imageShadowRegular (props: IIconProp list) = createElement (import "ImageShadowRegular" FluentIcons) props
        static member inline imageSparkleFilled (props: IIconProp list) = createElement (import "ImageSparkleFilled" FluentIcons) props
        static member inline imageSparkleRegular (props: IIconProp list) = createElement (import "ImageSparkleRegular" FluentIcons) props
        static member inline imageSplitFilled (props: IIconProp list) = createElement (import "ImageSplitFilled" FluentIcons) props
        static member inline imageSplitRegular (props: IIconProp list) = createElement (import "ImageSplitRegular" FluentIcons) props
        static member inline imageStackFilled (props: IIconProp list) = createElement (import "ImageStackFilled" FluentIcons) props
        static member inline imageStackRegular (props: IIconProp list) = createElement (import "ImageStackRegular" FluentIcons) props
        static member inline imageTableFilled (props: IIconProp list) = createElement (import "ImageTableFilled" FluentIcons) props
        static member inline imageTableRegular (props: IIconProp list) = createElement (import "ImageTableRegular" FluentIcons) props
        static member inline immersiveReaderFilled (props: IIconProp list) = createElement (import "ImmersiveReaderFilled" FluentIcons) props
        static member inline immersiveReaderRegular (props: IIconProp list) = createElement (import "ImmersiveReaderRegular" FluentIcons) props
        static member inline importantFilled (props: IIconProp list) = createElement (import "ImportantFilled" FluentIcons) props
        static member inline importantRegular (props: IIconProp list) = createElement (import "ImportantRegular" FluentIcons) props
        static member inline incognitoFilled (props: IIconProp list) = createElement (import "IncognitoFilled" FluentIcons) props
        static member inline incognitoRegular (props: IIconProp list) = createElement (import "IncognitoRegular" FluentIcons) props
        static member inline infoFilled (props: IIconProp list) = createElement (import "InfoFilled" FluentIcons) props
        static member inline infoRegular (props: IIconProp list) = createElement (import "InfoRegular" FluentIcons) props
        static member inline infoShieldFilled (props: IIconProp list) = createElement (import "InfoShieldFilled" FluentIcons) props
        static member inline infoShieldRegular (props: IIconProp list) = createElement (import "InfoShieldRegular" FluentIcons) props
        static member inline inkStrokeFilled (props: IIconProp list) = createElement (import "InkStrokeFilled" FluentIcons) props
        static member inline inkStrokeRegular (props: IIconProp list) = createElement (import "InkStrokeRegular" FluentIcons) props
        static member inline inkStrokeArrowDownFilled (props: IIconProp list) = createElement (import "InkStrokeArrowDownFilled" FluentIcons) props
        static member inline inkStrokeArrowDownRegular (props: IIconProp list) = createElement (import "InkStrokeArrowDownRegular" FluentIcons) props
        static member inline inkStrokeArrowUpDownFilled (props: IIconProp list) = createElement (import "InkStrokeArrowUpDownFilled" FluentIcons) props
        static member inline inkStrokeArrowUpDownRegular (props: IIconProp list) = createElement (import "InkStrokeArrowUpDownRegular" FluentIcons) props
        static member inline inkingToolFilled (props: IIconProp list) = createElement (import "InkingToolFilled" FluentIcons) props
        static member inline inkingToolRegular (props: IIconProp list) = createElement (import "InkingToolRegular" FluentIcons) props
        static member inline inkingToolAccentFilled (props: IIconProp list) = createElement (import "InkingToolAccentFilled" FluentIcons) props
        static member inline inprivateAccountFilled (props: IIconProp list) = createElement (import "InprivateAccountFilled" FluentIcons) props
        static member inline inprivateAccountRegular (props: IIconProp list) = createElement (import "InprivateAccountRegular" FluentIcons) props
        static member inline insertFilled (props: IIconProp list) = createElement (import "InsertFilled" FluentIcons) props
        static member inline insertRegular (props: IIconProp list) = createElement (import "InsertRegular" FluentIcons) props
        static member inline iosChevronRightFilled (props: IIconProp list) = createElement (import "IosChevronRightFilled" FluentIcons) props
        static member inline iosChevronRightRegular (props: IIconProp list) = createElement (import "IosChevronRightRegular" FluentIcons) props
        static member inline iotFilled (props: IIconProp list) = createElement (import "IotFilled" FluentIcons) props
        static member inline iotRegular (props: IIconProp list) = createElement (import "IotRegular" FluentIcons) props
        static member inline iotAlertFilled (props: IIconProp list) = createElement (import "IotAlertFilled" FluentIcons) props
        static member inline iotAlertRegular (props: IIconProp list) = createElement (import "IotAlertRegular" FluentIcons) props
        static member inline javascriptFilled (props: IIconProp list) = createElement (import "JavascriptFilled" FluentIcons) props
        static member inline javascriptRegular (props: IIconProp list) = createElement (import "JavascriptRegular" FluentIcons) props
        static member inline joystickFilled (props: IIconProp list) = createElement (import "JoystickFilled" FluentIcons) props
        static member inline joystickRegular (props: IIconProp list) = createElement (import "JoystickRegular" FluentIcons) props
        static member inline keyFilled (props: IIconProp list) = createElement (import "KeyFilled" FluentIcons) props
        static member inline keyRegular (props: IIconProp list) = createElement (import "KeyRegular" FluentIcons) props
        static member inline keyCommandFilled (props: IIconProp list) = createElement (import "KeyCommandFilled" FluentIcons) props
        static member inline keyCommandRegular (props: IIconProp list) = createElement (import "KeyCommandRegular" FluentIcons) props
        static member inline keyMultipleFilled (props: IIconProp list) = createElement (import "KeyMultipleFilled" FluentIcons) props
        static member inline keyMultipleRegular (props: IIconProp list) = createElement (import "KeyMultipleRegular" FluentIcons) props
        static member inline keyResetFilled (props: IIconProp list) = createElement (import "KeyResetFilled" FluentIcons) props
        static member inline keyResetRegular (props: IIconProp list) = createElement (import "KeyResetRegular" FluentIcons) props
        static member inline keyboard123Filled (props: IIconProp list) = createElement (import "Keyboard123Filled" FluentIcons) props
        static member inline keyboard123Regular (props: IIconProp list) = createElement (import "Keyboard123Regular" FluentIcons) props
        static member inline keyboardFilled (props: IIconProp list) = createElement (import "KeyboardFilled" FluentIcons) props
        static member inline keyboardRegular (props: IIconProp list) = createElement (import "KeyboardRegular" FluentIcons) props
        static member inline keyboardDockFilled (props: IIconProp list) = createElement (import "KeyboardDockFilled" FluentIcons) props
        static member inline keyboardDockRegular (props: IIconProp list) = createElement (import "KeyboardDockRegular" FluentIcons) props
        static member inline keyboardLayoutFloatFilled (props: IIconProp list) = createElement (import "KeyboardLayoutFloatFilled" FluentIcons) props
        static member inline keyboardLayoutFloatRegular (props: IIconProp list) = createElement (import "KeyboardLayoutFloatRegular" FluentIcons) props
        static member inline keyboardLayoutOneHandedLeftFilled (props: IIconProp list) = createElement (import "KeyboardLayoutOneHandedLeftFilled" FluentIcons) props
        static member inline keyboardLayoutOneHandedLeftRegular (props: IIconProp list) = createElement (import "KeyboardLayoutOneHandedLeftRegular" FluentIcons) props
        static member inline keyboardLayoutResizeFilled (props: IIconProp list) = createElement (import "KeyboardLayoutResizeFilled" FluentIcons) props
        static member inline keyboardLayoutResizeRegular (props: IIconProp list) = createElement (import "KeyboardLayoutResizeRegular" FluentIcons) props
        static member inline keyboardLayoutSplitFilled (props: IIconProp list) = createElement (import "KeyboardLayoutSplitFilled" FluentIcons) props
        static member inline keyboardLayoutSplitRegular (props: IIconProp list) = createElement (import "KeyboardLayoutSplitRegular" FluentIcons) props
        static member inline keyboardShiftFilled (props: IIconProp list) = createElement (import "KeyboardShiftFilled" FluentIcons) props
        static member inline keyboardShiftRegular (props: IIconProp list) = createElement (import "KeyboardShiftRegular" FluentIcons) props
        static member inline keyboardShiftUppercaseFilled (props: IIconProp list) = createElement (import "KeyboardShiftUppercaseFilled" FluentIcons) props
        static member inline keyboardShiftUppercaseRegular (props: IIconProp list) = createElement (import "KeyboardShiftUppercaseRegular" FluentIcons) props
        static member inline keyboardTabFilled (props: IIconProp list) = createElement (import "KeyboardTabFilled" FluentIcons) props
        static member inline keyboardTabRegular (props: IIconProp list) = createElement (import "KeyboardTabRegular" FluentIcons) props
        static member inline laptopFilled (props: IIconProp list) = createElement (import "LaptopFilled" FluentIcons) props
        static member inline laptopRegular (props: IIconProp list) = createElement (import "LaptopRegular" FluentIcons) props
        static member inline laptopBriefcaseFilled (props: IIconProp list) = createElement (import "LaptopBriefcaseFilled" FluentIcons) props
        static member inline laptopBriefcaseRegular (props: IIconProp list) = createElement (import "LaptopBriefcaseRegular" FluentIcons) props
        static member inline laptopDismissFilled (props: IIconProp list) = createElement (import "LaptopDismissFilled" FluentIcons) props
        static member inline laptopDismissRegular (props: IIconProp list) = createElement (import "LaptopDismissRegular" FluentIcons) props
        static member inline laptopPersonFilled (props: IIconProp list) = createElement (import "LaptopPersonFilled" FluentIcons) props
        static member inline laptopPersonRegular (props: IIconProp list) = createElement (import "LaptopPersonRegular" FluentIcons) props
        static member inline laptopSettingsFilled (props: IIconProp list) = createElement (import "LaptopSettingsFilled" FluentIcons) props
        static member inline laptopSettingsRegular (props: IIconProp list) = createElement (import "LaptopSettingsRegular" FluentIcons) props
        static member inline laptopShieldFilled (props: IIconProp list) = createElement (import "LaptopShieldFilled" FluentIcons) props
        static member inline laptopShieldRegular (props: IIconProp list) = createElement (import "LaptopShieldRegular" FluentIcons) props
        static member inline laserToolFilled (props: IIconProp list) = createElement (import "LaserToolFilled" FluentIcons) props
        static member inline laserToolRegular (props: IIconProp list) = createElement (import "LaserToolRegular" FluentIcons) props
        static member inline lassoFilled (props: IIconProp list) = createElement (import "LassoFilled" FluentIcons) props
        static member inline lassoRegular (props: IIconProp list) = createElement (import "LassoRegular" FluentIcons) props
        static member inline launcherSettingsFilled (props: IIconProp list) = createElement (import "LauncherSettingsFilled" FluentIcons) props
        static member inline launcherSettingsRegular (props: IIconProp list) = createElement (import "LauncherSettingsRegular" FluentIcons) props
        static member inline layerFilled (props: IIconProp list) = createElement (import "LayerFilled" FluentIcons) props
        static member inline layerRegular (props: IIconProp list) = createElement (import "LayerRegular" FluentIcons) props
        static member inline layerDiagonalFilled (props: IIconProp list) = createElement (import "LayerDiagonalFilled" FluentIcons) props
        static member inline layerDiagonalRegular (props: IIconProp list) = createElement (import "LayerDiagonalRegular" FluentIcons) props
        static member inline layerDiagonalAddFilled (props: IIconProp list) = createElement (import "LayerDiagonalAddFilled" FluentIcons) props
        static member inline layerDiagonalAddRegular (props: IIconProp list) = createElement (import "LayerDiagonalAddRegular" FluentIcons) props
        static member inline layerDiagonalPersonFilled (props: IIconProp list) = createElement (import "LayerDiagonalPersonFilled" FluentIcons) props
        static member inline layerDiagonalPersonRegular (props: IIconProp list) = createElement (import "LayerDiagonalPersonRegular" FluentIcons) props
        static member inline layerDiagonalSparkleFilled (props: IIconProp list) = createElement (import "LayerDiagonalSparkleFilled" FluentIcons) props
        static member inline layerDiagonalSparkleRegular (props: IIconProp list) = createElement (import "LayerDiagonalSparkleRegular" FluentIcons) props
        static member inline layoutCellFourFilled (props: IIconProp list) = createElement (import "LayoutCellFourFilled" FluentIcons) props
        static member inline layoutCellFourRegular (props: IIconProp list) = createElement (import "LayoutCellFourRegular" FluentIcons) props
        static member inline layoutCellFourFocusBottomLeftFilled (props: IIconProp list) = createElement (import "LayoutCellFourFocusBottomLeftFilled" FluentIcons) props
        static member inline layoutCellFourFocusBottomRightFilled (props: IIconProp list) = createElement (import "LayoutCellFourFocusBottomRightFilled" FluentIcons) props
        static member inline layoutCellFourFocusTopLeftFilled (props: IIconProp list) = createElement (import "LayoutCellFourFocusTopLeftFilled" FluentIcons) props
        static member inline layoutCellFourFocusTopRightFilled (props: IIconProp list) = createElement (import "LayoutCellFourFocusTopRightFilled" FluentIcons) props
        static member inline layoutColumnFourFilled (props: IIconProp list) = createElement (import "LayoutColumnFourFilled" FluentIcons) props
        static member inline layoutColumnFourRegular (props: IIconProp list) = createElement (import "LayoutColumnFourRegular" FluentIcons) props
        static member inline layoutColumnFourFocusCenterLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnFourFocusCenterLeftFilled" FluentIcons) props
        static member inline layoutColumnFourFocusCenterRightFilled (props: IIconProp list) = createElement (import "LayoutColumnFourFocusCenterRightFilled" FluentIcons) props
        static member inline layoutColumnFourFocusLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnFourFocusLeftFilled" FluentIcons) props
        static member inline layoutColumnFourFocusRightFilled (props: IIconProp list) = createElement (import "LayoutColumnFourFocusRightFilled" FluentIcons) props
        static member inline layoutColumnOneThirdLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnOneThirdLeftFilled" FluentIcons) props
        static member inline layoutColumnOneThirdLeftRegular (props: IIconProp list) = createElement (import "LayoutColumnOneThirdLeftRegular" FluentIcons) props
        static member inline layoutColumnOneThirdRightFilled (props: IIconProp list) = createElement (import "LayoutColumnOneThirdRightFilled" FluentIcons) props
        static member inline layoutColumnOneThirdRightRegular (props: IIconProp list) = createElement (import "LayoutColumnOneThirdRightRegular" FluentIcons) props
        static member inline layoutColumnOneThirdRightHintFilled (props: IIconProp list) = createElement (import "LayoutColumnOneThirdRightHintFilled" FluentIcons) props
        static member inline layoutColumnOneThirdRightHintRegular (props: IIconProp list) = createElement (import "LayoutColumnOneThirdRightHintRegular" FluentIcons) props
        static member inline layoutColumnThreeFilled (props: IIconProp list) = createElement (import "LayoutColumnThreeFilled" FluentIcons) props
        static member inline layoutColumnThreeRegular (props: IIconProp list) = createElement (import "LayoutColumnThreeRegular" FluentIcons) props
        static member inline layoutColumnThreeFocusCenterFilled (props: IIconProp list) = createElement (import "LayoutColumnThreeFocusCenterFilled" FluentIcons) props
        static member inline layoutColumnThreeFocusLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnThreeFocusLeftFilled" FluentIcons) props
        static member inline layoutColumnThreeFocusRightFilled (props: IIconProp list) = createElement (import "LayoutColumnThreeFocusRightFilled" FluentIcons) props
        static member inline layoutColumnTwoFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoFilled" FluentIcons) props
        static member inline layoutColumnTwoRegular (props: IIconProp list) = createElement (import "LayoutColumnTwoRegular" FluentIcons) props
        static member inline layoutColumnTwoFocusLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoFocusLeftFilled" FluentIcons) props
        static member inline layoutColumnTwoFocusRightFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoFocusRightFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitLeftFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitLeftRegular (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitLeftRegular" FluentIcons) props
        static member inline layoutColumnTwoSplitLeftFocusBottomLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitLeftFocusBottomLeftFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitLeftFocusRightFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitLeftFocusRightFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitLeftFocusTopLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitLeftFocusTopLeftFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitRightFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitRightFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitRightRegular (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitRightRegular" FluentIcons) props
        static member inline layoutColumnTwoSplitRightFocusBottomRightFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitRightFocusBottomRightFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitRightFocusLeftFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitRightFocusLeftFilled" FluentIcons) props
        static member inline layoutColumnTwoSplitRightFocusTopRightFilled (props: IIconProp list) = createElement (import "LayoutColumnTwoSplitRightFocusTopRightFilled" FluentIcons) props
        static member inline layoutRowFourFilled (props: IIconProp list) = createElement (import "LayoutRowFourFilled" FluentIcons) props
        static member inline layoutRowFourRegular (props: IIconProp list) = createElement (import "LayoutRowFourRegular" FluentIcons) props
        static member inline layoutRowFourFocusBottomFilled (props: IIconProp list) = createElement (import "LayoutRowFourFocusBottomFilled" FluentIcons) props
        static member inline layoutRowFourFocusCenterBottomFilled (props: IIconProp list) = createElement (import "LayoutRowFourFocusCenterBottomFilled" FluentIcons) props
        static member inline layoutRowFourFocusCenterTopFilled (props: IIconProp list) = createElement (import "LayoutRowFourFocusCenterTopFilled" FluentIcons) props
        static member inline layoutRowFourFocusTopFilled (props: IIconProp list) = createElement (import "LayoutRowFourFocusTopFilled" FluentIcons) props
        static member inline layoutRowThreeFilled (props: IIconProp list) = createElement (import "LayoutRowThreeFilled" FluentIcons) props
        static member inline layoutRowThreeRegular (props: IIconProp list) = createElement (import "LayoutRowThreeRegular" FluentIcons) props
        static member inline layoutRowThreeFocusBottomFilled (props: IIconProp list) = createElement (import "LayoutRowThreeFocusBottomFilled" FluentIcons) props
        static member inline layoutRowThreeFocusCenterFilled (props: IIconProp list) = createElement (import "LayoutRowThreeFocusCenterFilled" FluentIcons) props
        static member inline layoutRowThreeFocusTopFilled (props: IIconProp list) = createElement (import "LayoutRowThreeFocusTopFilled" FluentIcons) props
        static member inline layoutRowTwoFilled (props: IIconProp list) = createElement (import "LayoutRowTwoFilled" FluentIcons) props
        static member inline layoutRowTwoRegular (props: IIconProp list) = createElement (import "LayoutRowTwoRegular" FluentIcons) props
        static member inline layoutRowTwoFocusBottomFilled (props: IIconProp list) = createElement (import "LayoutRowTwoFocusBottomFilled" FluentIcons) props
        static member inline layoutRowTwoFocusTopFilled (props: IIconProp list) = createElement (import "LayoutRowTwoFocusTopFilled" FluentIcons) props
        static member inline layoutRowTwoFocusTopSettingsFilled (props: IIconProp list) = createElement (import "LayoutRowTwoFocusTopSettingsFilled" FluentIcons) props
        static member inline layoutRowTwoSplitBottomFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitBottomFilled" FluentIcons) props
        static member inline layoutRowTwoSplitBottomRegular (props: IIconProp list) = createElement (import "LayoutRowTwoSplitBottomRegular" FluentIcons) props
        static member inline layoutRowTwoSplitBottomFocusBottomLeftFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitBottomFocusBottomLeftFilled" FluentIcons) props
        static member inline layoutRowTwoSplitBottomFocusBottomRightFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitBottomFocusBottomRightFilled" FluentIcons) props
        static member inline layoutRowTwoSplitBottomFocusTopFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitBottomFocusTopFilled" FluentIcons) props
        static member inline layoutRowTwoSplitTopFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitTopFilled" FluentIcons) props
        static member inline layoutRowTwoSplitTopRegular (props: IIconProp list) = createElement (import "LayoutRowTwoSplitTopRegular" FluentIcons) props
        static member inline layoutRowTwoSplitTopFocusBottomFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitTopFocusBottomFilled" FluentIcons) props
        static member inline layoutRowTwoSplitTopFocusTopLeftFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitTopFocusTopLeftFilled" FluentIcons) props
        static member inline layoutRowTwoSplitTopFocusTopRightFilled (props: IIconProp list) = createElement (import "LayoutRowTwoSplitTopFocusTopRightFilled" FluentIcons) props
        static member inline leafOneFilled (props: IIconProp list) = createElement (import "LeafOneFilled" FluentIcons) props
        static member inline leafOneRegular (props: IIconProp list) = createElement (import "LeafOneRegular" FluentIcons) props
        static member inline leafThreeFilled (props: IIconProp list) = createElement (import "LeafThreeFilled" FluentIcons) props
        static member inline leafThreeRegular (props: IIconProp list) = createElement (import "LeafThreeRegular" FluentIcons) props
        static member inline leafTwoFilled (props: IIconProp list) = createElement (import "LeafTwoFilled" FluentIcons) props
        static member inline leafTwoRegular (props: IIconProp list) = createElement (import "LeafTwoRegular" FluentIcons) props
        static member inline learningAppFilled (props: IIconProp list) = createElement (import "LearningAppFilled" FluentIcons) props
        static member inline learningAppRegular (props: IIconProp list) = createElement (import "LearningAppRegular" FluentIcons) props
        static member inline libraryFilled (props: IIconProp list) = createElement (import "LibraryFilled" FluentIcons) props
        static member inline libraryRegular (props: IIconProp list) = createElement (import "LibraryRegular" FluentIcons) props
        static member inline lightbulbFilled (props: IIconProp list) = createElement (import "LightbulbFilled" FluentIcons) props
        static member inline lightbulbRegular (props: IIconProp list) = createElement (import "LightbulbRegular" FluentIcons) props
        static member inline lightbulbCheckmarkFilled (props: IIconProp list) = createElement (import "LightbulbCheckmarkFilled" FluentIcons) props
        static member inline lightbulbCheckmarkRegular (props: IIconProp list) = createElement (import "LightbulbCheckmarkRegular" FluentIcons) props
        static member inline lightbulbCircleFilled (props: IIconProp list) = createElement (import "LightbulbCircleFilled" FluentIcons) props
        static member inline lightbulbCircleRegular (props: IIconProp list) = createElement (import "LightbulbCircleRegular" FluentIcons) props
        static member inline lightbulbFilamentFilled (props: IIconProp list) = createElement (import "LightbulbFilamentFilled" FluentIcons) props
        static member inline lightbulbFilamentRegular (props: IIconProp list) = createElement (import "LightbulbFilamentRegular" FluentIcons) props
        static member inline lightbulbPersonFilled (props: IIconProp list) = createElement (import "LightbulbPersonFilled" FluentIcons) props
        static member inline lightbulbPersonRegular (props: IIconProp list) = createElement (import "LightbulbPersonRegular" FluentIcons) props
        static member inline likertFilled (props: IIconProp list) = createElement (import "LikertFilled" FluentIcons) props
        static member inline likertRegular (props: IIconProp list) = createElement (import "LikertRegular" FluentIcons) props
        static member inline lineFilled (props: IIconProp list) = createElement (import "LineFilled" FluentIcons) props
        static member inline lineRegular (props: IIconProp list) = createElement (import "LineRegular" FluentIcons) props
        static member inline lineDashesFilled (props: IIconProp list) = createElement (import "LineDashesFilled" FluentIcons) props
        static member inline lineDashesRegular (props: IIconProp list) = createElement (import "LineDashesRegular" FluentIcons) props
        static member inline lineFlowDiagonalUpRightFilled (props: IIconProp list) = createElement (import "LineFlowDiagonalUpRightFilled" FluentIcons) props
        static member inline lineFlowDiagonalUpRightRegular (props: IIconProp list) = createElement (import "LineFlowDiagonalUpRightRegular" FluentIcons) props
        static member inline lineHorizontal1Filled (props: IIconProp list) = createElement (import "LineHorizontal1Filled" FluentIcons) props
        static member inline lineHorizontal1Regular (props: IIconProp list) = createElement (import "LineHorizontal1Regular" FluentIcons) props
        static member inline lineHorizontal1DashesFilled (props: IIconProp list) = createElement (import "LineHorizontal1DashesFilled" FluentIcons) props
        static member inline lineHorizontal1DashesRegular (props: IIconProp list) = createElement (import "LineHorizontal1DashesRegular" FluentIcons) props
        static member inline lineHorizontal2DashesSolidFilled (props: IIconProp list) = createElement (import "LineHorizontal2DashesSolidFilled" FluentIcons) props
        static member inline lineHorizontal2DashesSolidRegular (props: IIconProp list) = createElement (import "LineHorizontal2DashesSolidRegular" FluentIcons) props
        static member inline lineHorizontal3Filled (props: IIconProp list) = createElement (import "LineHorizontal3Filled" FluentIcons) props
        static member inline lineHorizontal3Regular (props: IIconProp list) = createElement (import "LineHorizontal3Regular" FluentIcons) props
        static member inline lineHorizontal4Filled (props: IIconProp list) = createElement (import "LineHorizontal4Filled" FluentIcons) props
        static member inline lineHorizontal4Regular (props: IIconProp list) = createElement (import "LineHorizontal4Regular" FluentIcons) props
        static member inline lineHorizontal4SearchFilled (props: IIconProp list) = createElement (import "LineHorizontal4SearchFilled" FluentIcons) props
        static member inline lineHorizontal4SearchRegular (props: IIconProp list) = createElement (import "LineHorizontal4SearchRegular" FluentIcons) props
        static member inline lineHorizontal5Filled (props: IIconProp list) = createElement (import "LineHorizontal5Filled" FluentIcons) props
        static member inline lineHorizontal5Regular (props: IIconProp list) = createElement (import "LineHorizontal5Regular" FluentIcons) props
        static member inline lineHorizontal5ErrorFilled (props: IIconProp list) = createElement (import "LineHorizontal5ErrorFilled" FluentIcons) props
        static member inline lineHorizontal5ErrorRegular (props: IIconProp list) = createElement (import "LineHorizontal5ErrorRegular" FluentIcons) props
        static member inline lineStyleFilled (props: IIconProp list) = createElement (import "LineStyleFilled" FluentIcons) props
        static member inline lineStyleRegular (props: IIconProp list) = createElement (import "LineStyleRegular" FluentIcons) props
        static member inline lineThicknessFilled (props: IIconProp list) = createElement (import "LineThicknessFilled" FluentIcons) props
        static member inline lineThicknessRegular (props: IIconProp list) = createElement (import "LineThicknessRegular" FluentIcons) props
        static member inline linkFilled (props: IIconProp list) = createElement (import "LinkFilled" FluentIcons) props
        static member inline linkRegular (props: IIconProp list) = createElement (import "LinkRegular" FluentIcons) props
        static member inline linkAddFilled (props: IIconProp list) = createElement (import "LinkAddFilled" FluentIcons) props
        static member inline linkAddRegular (props: IIconProp list) = createElement (import "LinkAddRegular" FluentIcons) props
        static member inline linkDismissFilled (props: IIconProp list) = createElement (import "LinkDismissFilled" FluentIcons) props
        static member inline linkDismissRegular (props: IIconProp list) = createElement (import "LinkDismissRegular" FluentIcons) props
        static member inline linkEditFilled (props: IIconProp list) = createElement (import "LinkEditFilled" FluentIcons) props
        static member inline linkEditRegular (props: IIconProp list) = createElement (import "LinkEditRegular" FluentIcons) props
        static member inline linkMultipleFilled (props: IIconProp list) = createElement (import "LinkMultipleFilled" FluentIcons) props
        static member inline linkMultipleRegular (props: IIconProp list) = createElement (import "LinkMultipleRegular" FluentIcons) props
        static member inline linkPersonFilled (props: IIconProp list) = createElement (import "LinkPersonFilled" FluentIcons) props
        static member inline linkPersonRegular (props: IIconProp list) = createElement (import "LinkPersonRegular" FluentIcons) props
        static member inline linkSquareFilled (props: IIconProp list) = createElement (import "LinkSquareFilled" FluentIcons) props
        static member inline linkSquareRegular (props: IIconProp list) = createElement (import "LinkSquareRegular" FluentIcons) props
        static member inline linkToolboxFilled (props: IIconProp list) = createElement (import "LinkToolboxFilled" FluentIcons) props
        static member inline linkToolboxRegular (props: IIconProp list) = createElement (import "LinkToolboxRegular" FluentIcons) props
        static member inline listFilled (props: IIconProp list) = createElement (import "ListFilled" FluentIcons) props
        static member inline listRegular (props: IIconProp list) = createElement (import "ListRegular" FluentIcons) props
        static member inline listBarFilled (props: IIconProp list) = createElement (import "ListBarFilled" FluentIcons) props
        static member inline listBarRegular (props: IIconProp list) = createElement (import "ListBarRegular" FluentIcons) props
        static member inline listBarTreeFilled (props: IIconProp list) = createElement (import "ListBarTreeFilled" FluentIcons) props
        static member inline listBarTreeRegular (props: IIconProp list) = createElement (import "ListBarTreeRegular" FluentIcons) props
        static member inline listBarTreeOffsetFilled (props: IIconProp list) = createElement (import "ListBarTreeOffsetFilled" FluentIcons) props
        static member inline listBarTreeOffsetRegular (props: IIconProp list) = createElement (import "ListBarTreeOffsetRegular" FluentIcons) props
        static member inline listRtlFilled (props: IIconProp list) = createElement (import "ListRtlFilled" FluentIcons) props
        static member inline listRtlRegular (props: IIconProp list) = createElement (import "ListRtlRegular" FluentIcons) props
        static member inline liveFilled (props: IIconProp list) = createElement (import "LiveFilled" FluentIcons) props
        static member inline liveRegular (props: IIconProp list) = createElement (import "LiveRegular" FluentIcons) props
        static member inline liveOffFilled (props: IIconProp list) = createElement (import "LiveOffFilled" FluentIcons) props
        static member inline liveOffRegular (props: IIconProp list) = createElement (import "LiveOffRegular" FluentIcons) props
        static member inline localLanguageFilled (props: IIconProp list) = createElement (import "LocalLanguageFilled" FluentIcons) props
        static member inline localLanguageRegular (props: IIconProp list) = createElement (import "LocalLanguageRegular" FluentIcons) props
        static member inline locationFilled (props: IIconProp list) = createElement (import "LocationFilled" FluentIcons) props
        static member inline locationRegular (props: IIconProp list) = createElement (import "LocationRegular" FluentIcons) props
        static member inline locationAddFilled (props: IIconProp list) = createElement (import "LocationAddFilled" FluentIcons) props
        static member inline locationAddRegular (props: IIconProp list) = createElement (import "LocationAddRegular" FluentIcons) props
        static member inline locationAddLeftFilled (props: IIconProp list) = createElement (import "LocationAddLeftFilled" FluentIcons) props
        static member inline locationAddLeftRegular (props: IIconProp list) = createElement (import "LocationAddLeftRegular" FluentIcons) props
        static member inline locationAddRightFilled (props: IIconProp list) = createElement (import "LocationAddRightFilled" FluentIcons) props
        static member inline locationAddRightRegular (props: IIconProp list) = createElement (import "LocationAddRightRegular" FluentIcons) props
        static member inline locationAddUpFilled (props: IIconProp list) = createElement (import "LocationAddUpFilled" FluentIcons) props
        static member inline locationAddUpRegular (props: IIconProp list) = createElement (import "LocationAddUpRegular" FluentIcons) props
        static member inline locationArrowFilled (props: IIconProp list) = createElement (import "LocationArrowFilled" FluentIcons) props
        static member inline locationArrowRegular (props: IIconProp list) = createElement (import "LocationArrowRegular" FluentIcons) props
        static member inline locationArrowLeftFilled (props: IIconProp list) = createElement (import "LocationArrowLeftFilled" FluentIcons) props
        static member inline locationArrowLeftRegular (props: IIconProp list) = createElement (import "LocationArrowLeftRegular" FluentIcons) props
        static member inline locationArrowRightFilled (props: IIconProp list) = createElement (import "LocationArrowRightFilled" FluentIcons) props
        static member inline locationArrowRightRegular (props: IIconProp list) = createElement (import "LocationArrowRightRegular" FluentIcons) props
        static member inline locationArrowUpFilled (props: IIconProp list) = createElement (import "LocationArrowUpFilled" FluentIcons) props
        static member inline locationArrowUpRegular (props: IIconProp list) = createElement (import "LocationArrowUpRegular" FluentIcons) props
        static member inline locationDismissFilled (props: IIconProp list) = createElement (import "LocationDismissFilled" FluentIcons) props
        static member inline locationDismissRegular (props: IIconProp list) = createElement (import "LocationDismissRegular" FluentIcons) props
        static member inline locationLiveFilled (props: IIconProp list) = createElement (import "LocationLiveFilled" FluentIcons) props
        static member inline locationLiveRegular (props: IIconProp list) = createElement (import "LocationLiveRegular" FluentIcons) props
        static member inline locationOffFilled (props: IIconProp list) = createElement (import "LocationOffFilled" FluentIcons) props
        static member inline locationOffRegular (props: IIconProp list) = createElement (import "LocationOffRegular" FluentIcons) props
        static member inline locationRippleFilled (props: IIconProp list) = createElement (import "LocationRippleFilled" FluentIcons) props
        static member inline locationRippleRegular (props: IIconProp list) = createElement (import "LocationRippleRegular" FluentIcons) props
        static member inline locationTargetSquareFilled (props: IIconProp list) = createElement (import "LocationTargetSquareFilled" FluentIcons) props
        static member inline locationTargetSquareRegular (props: IIconProp list) = createElement (import "LocationTargetSquareRegular" FluentIcons) props
        static member inline lockClosedFilled (props: IIconProp list) = createElement (import "LockClosedFilled" FluentIcons) props
        static member inline lockClosedRegular (props: IIconProp list) = createElement (import "LockClosedRegular" FluentIcons) props
        static member inline lockClosedKeyFilled (props: IIconProp list) = createElement (import "LockClosedKeyFilled" FluentIcons) props
        static member inline lockClosedKeyRegular (props: IIconProp list) = createElement (import "LockClosedKeyRegular" FluentIcons) props
        static member inline lockMultipleFilled (props: IIconProp list) = createElement (import "LockMultipleFilled" FluentIcons) props
        static member inline lockMultipleRegular (props: IIconProp list) = createElement (import "LockMultipleRegular" FluentIcons) props
        static member inline lockOpenFilled (props: IIconProp list) = createElement (import "LockOpenFilled" FluentIcons) props
        static member inline lockOpenRegular (props: IIconProp list) = createElement (import "LockOpenRegular" FluentIcons) props
        static member inline lockShieldFilled (props: IIconProp list) = createElement (import "LockShieldFilled" FluentIcons) props
        static member inline lockShieldRegular (props: IIconProp list) = createElement (import "LockShieldRegular" FluentIcons) props
        static member inline lotteryFilled (props: IIconProp list) = createElement (import "LotteryFilled" FluentIcons) props
        static member inline lotteryRegular (props: IIconProp list) = createElement (import "LotteryRegular" FluentIcons) props
        static member inline luggageFilled (props: IIconProp list) = createElement (import "LuggageFilled" FluentIcons) props
        static member inline luggageRegular (props: IIconProp list) = createElement (import "LuggageRegular" FluentIcons) props
        static member inline mailFilled (props: IIconProp list) = createElement (import "MailFilled" FluentIcons) props
        static member inline mailRegular (props: IIconProp list) = createElement (import "MailRegular" FluentIcons) props
        static member inline mailAddFilled (props: IIconProp list) = createElement (import "MailAddFilled" FluentIcons) props
        static member inline mailAddRegular (props: IIconProp list) = createElement (import "MailAddRegular" FluentIcons) props
        static member inline mailAlertFilled (props: IIconProp list) = createElement (import "MailAlertFilled" FluentIcons) props
        static member inline mailAlertRegular (props: IIconProp list) = createElement (import "MailAlertRegular" FluentIcons) props
        static member inline mailAllReadFilled (props: IIconProp list) = createElement (import "MailAllReadFilled" FluentIcons) props
        static member inline mailAllReadRegular (props: IIconProp list) = createElement (import "MailAllReadRegular" FluentIcons) props
        static member inline mailAllUnreadFilled (props: IIconProp list) = createElement (import "MailAllUnreadFilled" FluentIcons) props
        static member inline mailAllUnreadRegular (props: IIconProp list) = createElement (import "MailAllUnreadRegular" FluentIcons) props
        static member inline mailArrowClockwiseFilled (props: IIconProp list) = createElement (import "MailArrowClockwiseFilled" FluentIcons) props
        static member inline mailArrowClockwiseRegular (props: IIconProp list) = createElement (import "MailArrowClockwiseRegular" FluentIcons) props
        static member inline mailArrowDoubleBackFilled (props: IIconProp list) = createElement (import "MailArrowDoubleBackFilled" FluentIcons) props
        static member inline mailArrowDoubleBackRegular (props: IIconProp list) = createElement (import "MailArrowDoubleBackRegular" FluentIcons) props
        static member inline mailArrowDownFilled (props: IIconProp list) = createElement (import "MailArrowDownFilled" FluentIcons) props
        static member inline mailArrowDownRegular (props: IIconProp list) = createElement (import "MailArrowDownRegular" FluentIcons) props
        static member inline mailArrowForwardFilled (props: IIconProp list) = createElement (import "MailArrowForwardFilled" FluentIcons) props
        static member inline mailArrowForwardRegular (props: IIconProp list) = createElement (import "MailArrowForwardRegular" FluentIcons) props
        static member inline mailArrowUpFilled (props: IIconProp list) = createElement (import "MailArrowUpFilled" FluentIcons) props
        static member inline mailArrowUpRegular (props: IIconProp list) = createElement (import "MailArrowUpRegular" FluentIcons) props
        static member inline mailAttachFilled (props: IIconProp list) = createElement (import "MailAttachFilled" FluentIcons) props
        static member inline mailAttachRegular (props: IIconProp list) = createElement (import "MailAttachRegular" FluentIcons) props
        static member inline mailCheckmarkFilled (props: IIconProp list) = createElement (import "MailCheckmarkFilled" FluentIcons) props
        static member inline mailCheckmarkRegular (props: IIconProp list) = createElement (import "MailCheckmarkRegular" FluentIcons) props
        static member inline mailClockFilled (props: IIconProp list) = createElement (import "MailClockFilled" FluentIcons) props
        static member inline mailClockRegular (props: IIconProp list) = createElement (import "MailClockRegular" FluentIcons) props
        static member inline mailCopyFilled (props: IIconProp list) = createElement (import "MailCopyFilled" FluentIcons) props
        static member inline mailCopyRegular (props: IIconProp list) = createElement (import "MailCopyRegular" FluentIcons) props
        static member inline mailDismissFilled (props: IIconProp list) = createElement (import "MailDismissFilled" FluentIcons) props
        static member inline mailDismissRegular (props: IIconProp list) = createElement (import "MailDismissRegular" FluentIcons) props
        static member inline mailEditFilled (props: IIconProp list) = createElement (import "MailEditFilled" FluentIcons) props
        static member inline mailEditRegular (props: IIconProp list) = createElement (import "MailEditRegular" FluentIcons) props
        static member inline mailErrorFilled (props: IIconProp list) = createElement (import "MailErrorFilled" FluentIcons) props
        static member inline mailErrorRegular (props: IIconProp list) = createElement (import "MailErrorRegular" FluentIcons) props
        static member inline mailInboxFilled (props: IIconProp list) = createElement (import "MailInboxFilled" FluentIcons) props
        static member inline mailInboxRegular (props: IIconProp list) = createElement (import "MailInboxRegular" FluentIcons) props
        static member inline mailInboxAddFilled (props: IIconProp list) = createElement (import "MailInboxAddFilled" FluentIcons) props
        static member inline mailInboxAddRegular (props: IIconProp list) = createElement (import "MailInboxAddRegular" FluentIcons) props
        static member inline mailInboxAllFilled (props: IIconProp list) = createElement (import "MailInboxAllFilled" FluentIcons) props
        static member inline mailInboxAllRegular (props: IIconProp list) = createElement (import "MailInboxAllRegular" FluentIcons) props
        static member inline mailInboxArrowDownFilled (props: IIconProp list) = createElement (import "MailInboxArrowDownFilled" FluentIcons) props
        static member inline mailInboxArrowDownRegular (props: IIconProp list) = createElement (import "MailInboxArrowDownRegular" FluentIcons) props
        static member inline mailInboxArrowRightFilled (props: IIconProp list) = createElement (import "MailInboxArrowRightFilled" FluentIcons) props
        static member inline mailInboxArrowRightRegular (props: IIconProp list) = createElement (import "MailInboxArrowRightRegular" FluentIcons) props
        static member inline mailInboxArrowUpFilled (props: IIconProp list) = createElement (import "MailInboxArrowUpFilled" FluentIcons) props
        static member inline mailInboxArrowUpRegular (props: IIconProp list) = createElement (import "MailInboxArrowUpRegular" FluentIcons) props
        static member inline mailInboxCheckmarkFilled (props: IIconProp list) = createElement (import "MailInboxCheckmarkFilled" FluentIcons) props
        static member inline mailInboxCheckmarkRegular (props: IIconProp list) = createElement (import "MailInboxCheckmarkRegular" FluentIcons) props
        static member inline mailInboxDismissFilled (props: IIconProp list) = createElement (import "MailInboxDismissFilled" FluentIcons) props
        static member inline mailInboxDismissRegular (props: IIconProp list) = createElement (import "MailInboxDismissRegular" FluentIcons) props
        static member inline mailLinkFilled (props: IIconProp list) = createElement (import "MailLinkFilled" FluentIcons) props
        static member inline mailLinkRegular (props: IIconProp list) = createElement (import "MailLinkRegular" FluentIcons) props
        static member inline mailListFilled (props: IIconProp list) = createElement (import "MailListFilled" FluentIcons) props
        static member inline mailListRegular (props: IIconProp list) = createElement (import "MailListRegular" FluentIcons) props
        static member inline mailMultipleFilled (props: IIconProp list) = createElement (import "MailMultipleFilled" FluentIcons) props
        static member inline mailMultipleRegular (props: IIconProp list) = createElement (import "MailMultipleRegular" FluentIcons) props
        static member inline mailOffFilled (props: IIconProp list) = createElement (import "MailOffFilled" FluentIcons) props
        static member inline mailOffRegular (props: IIconProp list) = createElement (import "MailOffRegular" FluentIcons) props
        static member inline mailOpenPersonFilled (props: IIconProp list) = createElement (import "MailOpenPersonFilled" FluentIcons) props
        static member inline mailOpenPersonRegular (props: IIconProp list) = createElement (import "MailOpenPersonRegular" FluentIcons) props
        static member inline mailPauseFilled (props: IIconProp list) = createElement (import "MailPauseFilled" FluentIcons) props
        static member inline mailPauseRegular (props: IIconProp list) = createElement (import "MailPauseRegular" FluentIcons) props
        static member inline mailProhibitedFilled (props: IIconProp list) = createElement (import "MailProhibitedFilled" FluentIcons) props
        static member inline mailProhibitedRegular (props: IIconProp list) = createElement (import "MailProhibitedRegular" FluentIcons) props
        static member inline mailReadFilled (props: IIconProp list) = createElement (import "MailReadFilled" FluentIcons) props
        static member inline mailReadRegular (props: IIconProp list) = createElement (import "MailReadRegular" FluentIcons) props
        static member inline mailReadMultipleFilled (props: IIconProp list) = createElement (import "MailReadMultipleFilled" FluentIcons) props
        static member inline mailReadMultipleRegular (props: IIconProp list) = createElement (import "MailReadMultipleRegular" FluentIcons) props
        static member inline mailRewindFilled (props: IIconProp list) = createElement (import "MailRewindFilled" FluentIcons) props
        static member inline mailRewindRegular (props: IIconProp list) = createElement (import "MailRewindRegular" FluentIcons) props
        static member inline mailSettingsFilled (props: IIconProp list) = createElement (import "MailSettingsFilled" FluentIcons) props
        static member inline mailSettingsRegular (props: IIconProp list) = createElement (import "MailSettingsRegular" FluentIcons) props
        static member inline mailShieldFilled (props: IIconProp list) = createElement (import "MailShieldFilled" FluentIcons) props
        static member inline mailShieldRegular (props: IIconProp list) = createElement (import "MailShieldRegular" FluentIcons) props
        static member inline mailTemplateFilled (props: IIconProp list) = createElement (import "MailTemplateFilled" FluentIcons) props
        static member inline mailTemplateRegular (props: IIconProp list) = createElement (import "MailTemplateRegular" FluentIcons) props
        static member inline mailUnreadFilled (props: IIconProp list) = createElement (import "MailUnreadFilled" FluentIcons) props
        static member inline mailUnreadRegular (props: IIconProp list) = createElement (import "MailUnreadRegular" FluentIcons) props
        static member inline mailWarningFilled (props: IIconProp list) = createElement (import "MailWarningFilled" FluentIcons) props
        static member inline mailWarningRegular (props: IIconProp list) = createElement (import "MailWarningRegular" FluentIcons) props
        static member inline mailboxFilled (props: IIconProp list) = createElement (import "MailboxFilled" FluentIcons) props
        static member inline mailboxRegular (props: IIconProp list) = createElement (import "MailboxRegular" FluentIcons) props
        static member inline mapFilled (props: IIconProp list) = createElement (import "MapFilled" FluentIcons) props
        static member inline mapRegular (props: IIconProp list) = createElement (import "MapRegular" FluentIcons) props
        static member inline mapDriveFilled (props: IIconProp list) = createElement (import "MapDriveFilled" FluentIcons) props
        static member inline mapDriveRegular (props: IIconProp list) = createElement (import "MapDriveRegular" FluentIcons) props
        static member inline markdownFilled (props: IIconProp list) = createElement (import "MarkdownFilled" FluentIcons) props
        static member inline markdownRegular (props: IIconProp list) = createElement (import "MarkdownRegular" FluentIcons) props
        static member inline matchAppLayoutFilled (props: IIconProp list) = createElement (import "MatchAppLayoutFilled" FluentIcons) props
        static member inline matchAppLayoutRegular (props: IIconProp list) = createElement (import "MatchAppLayoutRegular" FluentIcons) props
        static member inline mathFormatLinearFilled (props: IIconProp list) = createElement (import "MathFormatLinearFilled" FluentIcons) props
        static member inline mathFormatLinearRegular (props: IIconProp list) = createElement (import "MathFormatLinearRegular" FluentIcons) props
        static member inline mathFormatProfessionalFilled (props: IIconProp list) = createElement (import "MathFormatProfessionalFilled" FluentIcons) props
        static member inline mathFormatProfessionalRegular (props: IIconProp list) = createElement (import "MathFormatProfessionalRegular" FluentIcons) props
        static member inline mathFormulaFilled (props: IIconProp list) = createElement (import "MathFormulaFilled" FluentIcons) props
        static member inline mathFormulaRegular (props: IIconProp list) = createElement (import "MathFormulaRegular" FluentIcons) props
        static member inline mathSymbolsFilled (props: IIconProp list) = createElement (import "MathSymbolsFilled" FluentIcons) props
        static member inline mathSymbolsRegular (props: IIconProp list) = createElement (import "MathSymbolsRegular" FluentIcons) props
        static member inline maximizeFilled (props: IIconProp list) = createElement (import "MaximizeFilled" FluentIcons) props
        static member inline maximizeRegular (props: IIconProp list) = createElement (import "MaximizeRegular" FluentIcons) props
        static member inline meetNowFilled (props: IIconProp list) = createElement (import "MeetNowFilled" FluentIcons) props
        static member inline meetNowRegular (props: IIconProp list) = createElement (import "MeetNowRegular" FluentIcons) props
        static member inline megaphoneFilled (props: IIconProp list) = createElement (import "MegaphoneFilled" FluentIcons) props
        static member inline megaphoneRegular (props: IIconProp list) = createElement (import "MegaphoneRegular" FluentIcons) props
        static member inline megaphoneCircleFilled (props: IIconProp list) = createElement (import "MegaphoneCircleFilled" FluentIcons) props
        static member inline megaphoneCircleRegular (props: IIconProp list) = createElement (import "MegaphoneCircleRegular" FluentIcons) props
        static member inline megaphoneLoudFilled (props: IIconProp list) = createElement (import "MegaphoneLoudFilled" FluentIcons) props
        static member inline megaphoneLoudRegular (props: IIconProp list) = createElement (import "MegaphoneLoudRegular" FluentIcons) props
        static member inline megaphoneOffFilled (props: IIconProp list) = createElement (import "MegaphoneOffFilled" FluentIcons) props
        static member inline megaphoneOffRegular (props: IIconProp list) = createElement (import "MegaphoneOffRegular" FluentIcons) props
        static member inline mentionFilled (props: IIconProp list) = createElement (import "MentionFilled" FluentIcons) props
        static member inline mentionRegular (props: IIconProp list) = createElement (import "MentionRegular" FluentIcons) props
        static member inline mentionArrowDownFilled (props: IIconProp list) = createElement (import "MentionArrowDownFilled" FluentIcons) props
        static member inline mentionArrowDownRegular (props: IIconProp list) = createElement (import "MentionArrowDownRegular" FluentIcons) props
        static member inline mentionBracketsFilled (props: IIconProp list) = createElement (import "MentionBracketsFilled" FluentIcons) props
        static member inline mentionBracketsRegular (props: IIconProp list) = createElement (import "MentionBracketsRegular" FluentIcons) props
        static member inline mergeFilled (props: IIconProp list) = createElement (import "MergeFilled" FluentIcons) props
        static member inline mergeRegular (props: IIconProp list) = createElement (import "MergeRegular" FluentIcons) props
        static member inline micFilled (props: IIconProp list) = createElement (import "MicFilled" FluentIcons) props
        static member inline micRegular (props: IIconProp list) = createElement (import "MicRegular" FluentIcons) props
        static member inline micOffFilled (props: IIconProp list) = createElement (import "MicOffFilled" FluentIcons) props
        static member inline micOffRegular (props: IIconProp list) = createElement (import "MicOffRegular" FluentIcons) props
        static member inline micProhibitedFilled (props: IIconProp list) = createElement (import "MicProhibitedFilled" FluentIcons) props
        static member inline micProhibitedRegular (props: IIconProp list) = createElement (import "MicProhibitedRegular" FluentIcons) props
        static member inline micPulseFilled (props: IIconProp list) = createElement (import "MicPulseFilled" FluentIcons) props
        static member inline micPulseRegular (props: IIconProp list) = createElement (import "MicPulseRegular" FluentIcons) props
        static member inline micPulseOffFilled (props: IIconProp list) = createElement (import "MicPulseOffFilled" FluentIcons) props
        static member inline micPulseOffRegular (props: IIconProp list) = createElement (import "MicPulseOffRegular" FluentIcons) props
        static member inline micRecordFilled (props: IIconProp list) = createElement (import "MicRecordFilled" FluentIcons) props
        static member inline micRecordRegular (props: IIconProp list) = createElement (import "MicRecordRegular" FluentIcons) props
        static member inline micSettingsFilled (props: IIconProp list) = createElement (import "MicSettingsFilled" FluentIcons) props
        static member inline micSettingsRegular (props: IIconProp list) = createElement (import "MicSettingsRegular" FluentIcons) props
        static member inline micSparkleFilled (props: IIconProp list) = createElement (import "MicSparkleFilled" FluentIcons) props
        static member inline micSparkleRegular (props: IIconProp list) = createElement (import "MicSparkleRegular" FluentIcons) props
        static member inline micSyncFilled (props: IIconProp list) = createElement (import "MicSyncFilled" FluentIcons) props
        static member inline micSyncRegular (props: IIconProp list) = createElement (import "MicSyncRegular" FluentIcons) props
        static member inline microscopeFilled (props: IIconProp list) = createElement (import "MicroscopeFilled" FluentIcons) props
        static member inline microscopeRegular (props: IIconProp list) = createElement (import "MicroscopeRegular" FluentIcons) props
        static member inline midiFilled (props: IIconProp list) = createElement (import "MidiFilled" FluentIcons) props
        static member inline midiRegular (props: IIconProp list) = createElement (import "MidiRegular" FluentIcons) props
        static member inline mobileOptimizedFilled (props: IIconProp list) = createElement (import "MobileOptimizedFilled" FluentIcons) props
        static member inline mobileOptimizedRegular (props: IIconProp list) = createElement (import "MobileOptimizedRegular" FluentIcons) props
        static member inline moldFilled (props: IIconProp list) = createElement (import "MoldFilled" FluentIcons) props
        static member inline moldRegular (props: IIconProp list) = createElement (import "MoldRegular" FluentIcons) props
        static member inline moleculeFilled (props: IIconProp list) = createElement (import "MoleculeFilled" FluentIcons) props
        static member inline moleculeRegular (props: IIconProp list) = createElement (import "MoleculeRegular" FluentIcons) props
        static member inline moneyFilled (props: IIconProp list) = createElement (import "MoneyFilled" FluentIcons) props
        static member inline moneyRegular (props: IIconProp list) = createElement (import "MoneyRegular" FluentIcons) props
        static member inline moneyCalculatorFilled (props: IIconProp list) = createElement (import "MoneyCalculatorFilled" FluentIcons) props
        static member inline moneyCalculatorRegular (props: IIconProp list) = createElement (import "MoneyCalculatorRegular" FluentIcons) props
        static member inline moneyDismissFilled (props: IIconProp list) = createElement (import "MoneyDismissFilled" FluentIcons) props
        static member inline moneyDismissRegular (props: IIconProp list) = createElement (import "MoneyDismissRegular" FluentIcons) props
        static member inline moneyHandFilled (props: IIconProp list) = createElement (import "MoneyHandFilled" FluentIcons) props
        static member inline moneyHandRegular (props: IIconProp list) = createElement (import "MoneyHandRegular" FluentIcons) props
        static member inline moneyOffFilled (props: IIconProp list) = createElement (import "MoneyOffFilled" FluentIcons) props
        static member inline moneyOffRegular (props: IIconProp list) = createElement (import "MoneyOffRegular" FluentIcons) props
        static member inline moneySettingsFilled (props: IIconProp list) = createElement (import "MoneySettingsFilled" FluentIcons) props
        static member inline moneySettingsRegular (props: IIconProp list) = createElement (import "MoneySettingsRegular" FluentIcons) props
        static member inline moreCircleFilled (props: IIconProp list) = createElement (import "MoreCircleFilled" FluentIcons) props
        static member inline moreCircleRegular (props: IIconProp list) = createElement (import "MoreCircleRegular" FluentIcons) props
        static member inline moreHorizontalFilled (props: IIconProp list) = createElement (import "MoreHorizontalFilled" FluentIcons) props
        static member inline moreHorizontalRegular (props: IIconProp list) = createElement (import "MoreHorizontalRegular" FluentIcons) props
        static member inline moreVerticalFilled (props: IIconProp list) = createElement (import "MoreVerticalFilled" FluentIcons) props
        static member inline moreVerticalRegular (props: IIconProp list) = createElement (import "MoreVerticalRegular" FluentIcons) props
        static member inline mountainLocationBottomFilled (props: IIconProp list) = createElement (import "MountainLocationBottomFilled" FluentIcons) props
        static member inline mountainLocationBottomRegular (props: IIconProp list) = createElement (import "MountainLocationBottomRegular" FluentIcons) props
        static member inline mountainLocationTopFilled (props: IIconProp list) = createElement (import "MountainLocationTopFilled" FluentIcons) props
        static member inline mountainLocationTopRegular (props: IIconProp list) = createElement (import "MountainLocationTopRegular" FluentIcons) props
        static member inline mountainTrailFilled (props: IIconProp list) = createElement (import "MountainTrailFilled" FluentIcons) props
        static member inline mountainTrailRegular (props: IIconProp list) = createElement (import "MountainTrailRegular" FluentIcons) props
        static member inline moviesAndTvFilled (props: IIconProp list) = createElement (import "MoviesAndTvFilled" FluentIcons) props
        static member inline moviesAndTvRegular (props: IIconProp list) = createElement (import "MoviesAndTvRegular" FluentIcons) props
        static member inline multiplier12XFilled (props: IIconProp list) = createElement (import "Multiplier12XFilled" FluentIcons) props
        static member inline multiplier12XRegular (props: IIconProp list) = createElement (import "Multiplier12XRegular" FluentIcons) props
        static member inline multiplier15XFilled (props: IIconProp list) = createElement (import "Multiplier15XFilled" FluentIcons) props
        static member inline multiplier15XRegular (props: IIconProp list) = createElement (import "Multiplier15XRegular" FluentIcons) props
        static member inline multiplier18XFilled (props: IIconProp list) = createElement (import "Multiplier18XFilled" FluentIcons) props
        static member inline multiplier18XRegular (props: IIconProp list) = createElement (import "Multiplier18XRegular" FluentIcons) props
        static member inline multiplier1XFilled (props: IIconProp list) = createElement (import "Multiplier1XFilled" FluentIcons) props
        static member inline multiplier1XRegular (props: IIconProp list) = createElement (import "Multiplier1XRegular" FluentIcons) props
        static member inline multiplier2XFilled (props: IIconProp list) = createElement (import "Multiplier2XFilled" FluentIcons) props
        static member inline multiplier2XRegular (props: IIconProp list) = createElement (import "Multiplier2XRegular" FluentIcons) props
        static member inline multiplier5XFilled (props: IIconProp list) = createElement (import "Multiplier5XFilled" FluentIcons) props
        static member inline multiplier5XRegular (props: IIconProp list) = createElement (import "Multiplier5XRegular" FluentIcons) props
        static member inline multiselectLtrFilled (props: IIconProp list) = createElement (import "MultiselectLtrFilled" FluentIcons) props
        static member inline multiselectLtrRegular (props: IIconProp list) = createElement (import "MultiselectLtrRegular" FluentIcons) props
        static member inline multiselectRtlFilled (props: IIconProp list) = createElement (import "MultiselectRtlFilled" FluentIcons) props
        static member inline multiselectRtlRegular (props: IIconProp list) = createElement (import "MultiselectRtlRegular" FluentIcons) props
        static member inline musicNote1Filled (props: IIconProp list) = createElement (import "MusicNote1Filled" FluentIcons) props
        static member inline musicNote1Regular (props: IIconProp list) = createElement (import "MusicNote1Regular" FluentIcons) props
        static member inline musicNote2Filled (props: IIconProp list) = createElement (import "MusicNote2Filled" FluentIcons) props
        static member inline musicNote2Regular (props: IIconProp list) = createElement (import "MusicNote2Regular" FluentIcons) props
        static member inline musicNote2PlayFilled (props: IIconProp list) = createElement (import "MusicNote2PlayFilled" FluentIcons) props
        static member inline musicNote2PlayRegular (props: IIconProp list) = createElement (import "MusicNote2PlayRegular" FluentIcons) props
        static member inline musicNoteOff1Filled (props: IIconProp list) = createElement (import "MusicNoteOff1Filled" FluentIcons) props
        static member inline musicNoteOff1Regular (props: IIconProp list) = createElement (import "MusicNoteOff1Regular" FluentIcons) props
        static member inline musicNoteOff2Filled (props: IIconProp list) = createElement (import "MusicNoteOff2Filled" FluentIcons) props
        static member inline musicNoteOff2Regular (props: IIconProp list) = createElement (import "MusicNoteOff2Regular" FluentIcons) props
        static member inline myLocationFilled (props: IIconProp list) = createElement (import "MyLocationFilled" FluentIcons) props
        static member inline myLocationRegular (props: IIconProp list) = createElement (import "MyLocationRegular" FluentIcons) props
        static member inline navigationFilled (props: IIconProp list) = createElement (import "NavigationFilled" FluentIcons) props
        static member inline navigationRegular (props: IIconProp list) = createElement (import "NavigationRegular" FluentIcons) props
        static member inline navigationLocationTargetFilled (props: IIconProp list) = createElement (import "NavigationLocationTargetFilled" FluentIcons) props
        static member inline navigationLocationTargetRegular (props: IIconProp list) = createElement (import "NavigationLocationTargetRegular" FluentIcons) props
        static member inline navigationPlayFilled (props: IIconProp list) = createElement (import "NavigationPlayFilled" FluentIcons) props
        static member inline navigationPlayRegular (props: IIconProp list) = createElement (import "NavigationPlayRegular" FluentIcons) props
        static member inline navigationUnreadFilled (props: IIconProp list) = createElement (import "NavigationUnreadFilled" FluentIcons) props
        static member inline navigationUnreadRegular (props: IIconProp list) = createElement (import "NavigationUnreadRegular" FluentIcons) props
        static member inline networkCheckFilled (props: IIconProp list) = createElement (import "NetworkCheckFilled" FluentIcons) props
        static member inline networkCheckRegular (props: IIconProp list) = createElement (import "NetworkCheckRegular" FluentIcons) props
        static member inline newFilled (props: IIconProp list) = createElement (import "NewFilled" FluentIcons) props
        static member inline newRegular (props: IIconProp list) = createElement (import "NewRegular" FluentIcons) props
        static member inline newsFilled (props: IIconProp list) = createElement (import "NewsFilled" FluentIcons) props
        static member inline newsRegular (props: IIconProp list) = createElement (import "NewsRegular" FluentIcons) props
        static member inline nextFilled (props: IIconProp list) = createElement (import "NextFilled" FluentIcons) props
        static member inline nextRegular (props: IIconProp list) = createElement (import "NextRegular" FluentIcons) props
        static member inline nextFrameFilled (props: IIconProp list) = createElement (import "NextFrameFilled" FluentIcons) props
        static member inline nextFrameRegular (props: IIconProp list) = createElement (import "NextFrameRegular" FluentIcons) props
        static member inline noteFilled (props: IIconProp list) = createElement (import "NoteFilled" FluentIcons) props
        static member inline noteRegular (props: IIconProp list) = createElement (import "NoteRegular" FluentIcons) props
        static member inline noteAddFilled (props: IIconProp list) = createElement (import "NoteAddFilled" FluentIcons) props
        static member inline noteAddRegular (props: IIconProp list) = createElement (import "NoteAddRegular" FluentIcons) props
        static member inline noteEditFilled (props: IIconProp list) = createElement (import "NoteEditFilled" FluentIcons) props
        static member inline noteEditRegular (props: IIconProp list) = createElement (import "NoteEditRegular" FluentIcons) props
        static member inline notePinFilled (props: IIconProp list) = createElement (import "NotePinFilled" FluentIcons) props
        static member inline notePinRegular (props: IIconProp list) = createElement (import "NotePinRegular" FluentIcons) props
        static member inline notebookFilled (props: IIconProp list) = createElement (import "NotebookFilled" FluentIcons) props
        static member inline notebookRegular (props: IIconProp list) = createElement (import "NotebookRegular" FluentIcons) props
        static member inline notebookAddFilled (props: IIconProp list) = createElement (import "NotebookAddFilled" FluentIcons) props
        static member inline notebookAddRegular (props: IIconProp list) = createElement (import "NotebookAddRegular" FluentIcons) props
        static member inline notebookArrowCurveDownFilled (props: IIconProp list) = createElement (import "NotebookArrowCurveDownFilled" FluentIcons) props
        static member inline notebookArrowCurveDownRegular (props: IIconProp list) = createElement (import "NotebookArrowCurveDownRegular" FluentIcons) props
        static member inline notebookErrorFilled (props: IIconProp list) = createElement (import "NotebookErrorFilled" FluentIcons) props
        static member inline notebookErrorRegular (props: IIconProp list) = createElement (import "NotebookErrorRegular" FluentIcons) props
        static member inline notebookEyeFilled (props: IIconProp list) = createElement (import "NotebookEyeFilled" FluentIcons) props
        static member inline notebookEyeRegular (props: IIconProp list) = createElement (import "NotebookEyeRegular" FluentIcons) props
        static member inline notebookLightningFilled (props: IIconProp list) = createElement (import "NotebookLightningFilled" FluentIcons) props
        static member inline notebookLightningRegular (props: IIconProp list) = createElement (import "NotebookLightningRegular" FluentIcons) props
        static member inline notebookQuestionMarkFilled (props: IIconProp list) = createElement (import "NotebookQuestionMarkFilled" FluentIcons) props
        static member inline notebookQuestionMarkRegular (props: IIconProp list) = createElement (import "NotebookQuestionMarkRegular" FluentIcons) props
        static member inline notebookSectionFilled (props: IIconProp list) = createElement (import "NotebookSectionFilled" FluentIcons) props
        static member inline notebookSectionRegular (props: IIconProp list) = createElement (import "NotebookSectionRegular" FluentIcons) props
        static member inline notebookSectionArrowRightFilled (props: IIconProp list) = createElement (import "NotebookSectionArrowRightFilled" FluentIcons) props
        static member inline notebookSectionArrowRightRegular (props: IIconProp list) = createElement (import "NotebookSectionArrowRightRegular" FluentIcons) props
        static member inline notebookSubsectionFilled (props: IIconProp list) = createElement (import "NotebookSubsectionFilled" FluentIcons) props
        static member inline notebookSubsectionRegular (props: IIconProp list) = createElement (import "NotebookSubsectionRegular" FluentIcons) props
        static member inline notebookSyncFilled (props: IIconProp list) = createElement (import "NotebookSyncFilled" FluentIcons) props
        static member inline notebookSyncRegular (props: IIconProp list) = createElement (import "NotebookSyncRegular" FluentIcons) props
        static member inline notepadFilled (props: IIconProp list) = createElement (import "NotepadFilled" FluentIcons) props
        static member inline notepadRegular (props: IIconProp list) = createElement (import "NotepadRegular" FluentIcons) props
        static member inline notepadEditFilled (props: IIconProp list) = createElement (import "NotepadEditFilled" FluentIcons) props
        static member inline notepadEditRegular (props: IIconProp list) = createElement (import "NotepadEditRegular" FluentIcons) props
        static member inline notepadPersonFilled (props: IIconProp list) = createElement (import "NotepadPersonFilled" FluentIcons) props
        static member inline notepadPersonRegular (props: IIconProp list) = createElement (import "NotepadPersonRegular" FluentIcons) props
        static member inline notepadSparkleFilled (props: IIconProp list) = createElement (import "NotepadSparkleFilled" FluentIcons) props
        static member inline notepadSparkleRegular (props: IIconProp list) = createElement (import "NotepadSparkleRegular" FluentIcons) props
        static member inline numberCircle0Filled (props: IIconProp list) = createElement (import "NumberCircle0Filled" FluentIcons) props
        static member inline numberCircle0Regular (props: IIconProp list) = createElement (import "NumberCircle0Regular" FluentIcons) props
        static member inline numberCircle1Filled (props: IIconProp list) = createElement (import "NumberCircle1Filled" FluentIcons) props
        static member inline numberCircle1Regular (props: IIconProp list) = createElement (import "NumberCircle1Regular" FluentIcons) props
        static member inline numberCircle2Filled (props: IIconProp list) = createElement (import "NumberCircle2Filled" FluentIcons) props
        static member inline numberCircle2Regular (props: IIconProp list) = createElement (import "NumberCircle2Regular" FluentIcons) props
        static member inline numberCircle3Filled (props: IIconProp list) = createElement (import "NumberCircle3Filled" FluentIcons) props
        static member inline numberCircle3Regular (props: IIconProp list) = createElement (import "NumberCircle3Regular" FluentIcons) props
        static member inline numberCircle4Filled (props: IIconProp list) = createElement (import "NumberCircle4Filled" FluentIcons) props
        static member inline numberCircle4Regular (props: IIconProp list) = createElement (import "NumberCircle4Regular" FluentIcons) props
        static member inline numberCircle5Filled (props: IIconProp list) = createElement (import "NumberCircle5Filled" FluentIcons) props
        static member inline numberCircle5Regular (props: IIconProp list) = createElement (import "NumberCircle5Regular" FluentIcons) props
        static member inline numberCircle6Filled (props: IIconProp list) = createElement (import "NumberCircle6Filled" FluentIcons) props
        static member inline numberCircle6Regular (props: IIconProp list) = createElement (import "NumberCircle6Regular" FluentIcons) props
        static member inline numberCircle7Filled (props: IIconProp list) = createElement (import "NumberCircle7Filled" FluentIcons) props
        static member inline numberCircle7Regular (props: IIconProp list) = createElement (import "NumberCircle7Regular" FluentIcons) props
        static member inline numberCircle8Filled (props: IIconProp list) = createElement (import "NumberCircle8Filled" FluentIcons) props
        static member inline numberCircle8Regular (props: IIconProp list) = createElement (import "NumberCircle8Regular" FluentIcons) props
        static member inline numberCircle9Filled (props: IIconProp list) = createElement (import "NumberCircle9Filled" FluentIcons) props
        static member inline numberCircle9Regular (props: IIconProp list) = createElement (import "NumberCircle9Regular" FluentIcons) props
        static member inline numberRowFilled (props: IIconProp list) = createElement (import "NumberRowFilled" FluentIcons) props
        static member inline numberRowRegular (props: IIconProp list) = createElement (import "NumberRowRegular" FluentIcons) props
        static member inline numberSymbolFilled (props: IIconProp list) = createElement (import "NumberSymbolFilled" FluentIcons) props
        static member inline numberSymbolRegular (props: IIconProp list) = createElement (import "NumberSymbolRegular" FluentIcons) props
        static member inline numberSymbolDismissFilled (props: IIconProp list) = createElement (import "NumberSymbolDismissFilled" FluentIcons) props
        static member inline numberSymbolDismissRegular (props: IIconProp list) = createElement (import "NumberSymbolDismissRegular" FluentIcons) props
        static member inline numberSymbolSquareFilled (props: IIconProp list) = createElement (import "NumberSymbolSquareFilled" FluentIcons) props
        static member inline numberSymbolSquareRegular (props: IIconProp list) = createElement (import "NumberSymbolSquareRegular" FluentIcons) props
        static member inline openFilled (props: IIconProp list) = createElement (import "OpenFilled" FluentIcons) props
        static member inline openRegular (props: IIconProp list) = createElement (import "OpenRegular" FluentIcons) props
        static member inline openFolderFilled (props: IIconProp list) = createElement (import "OpenFolderFilled" FluentIcons) props
        static member inline openFolderRegular (props: IIconProp list) = createElement (import "OpenFolderRegular" FluentIcons) props
        static member inline openOffFilled (props: IIconProp list) = createElement (import "OpenOffFilled" FluentIcons) props
        static member inline openOffRegular (props: IIconProp list) = createElement (import "OpenOffRegular" FluentIcons) props
        static member inline optionsFilled (props: IIconProp list) = createElement (import "OptionsFilled" FluentIcons) props
        static member inline optionsRegular (props: IIconProp list) = createElement (import "OptionsRegular" FluentIcons) props
        static member inline organizationFilled (props: IIconProp list) = createElement (import "OrganizationFilled" FluentIcons) props
        static member inline organizationRegular (props: IIconProp list) = createElement (import "OrganizationRegular" FluentIcons) props
        static member inline organizationHorizontalFilled (props: IIconProp list) = createElement (import "OrganizationHorizontalFilled" FluentIcons) props
        static member inline organizationHorizontalRegular (props: IIconProp list) = createElement (import "OrganizationHorizontalRegular" FluentIcons) props
        static member inline orientationFilled (props: IIconProp list) = createElement (import "OrientationFilled" FluentIcons) props
        static member inline orientationRegular (props: IIconProp list) = createElement (import "OrientationRegular" FluentIcons) props
        static member inline ovalFilled (props: IIconProp list) = createElement (import "OvalFilled" FluentIcons) props
        static member inline ovalRegular (props: IIconProp list) = createElement (import "OvalRegular" FluentIcons) props
        static member inline ovenFilled (props: IIconProp list) = createElement (import "OvenFilled" FluentIcons) props
        static member inline ovenRegular (props: IIconProp list) = createElement (import "OvenRegular" FluentIcons) props
        static member inline paddingDownFilled (props: IIconProp list) = createElement (import "PaddingDownFilled" FluentIcons) props
        static member inline paddingDownRegular (props: IIconProp list) = createElement (import "PaddingDownRegular" FluentIcons) props
        static member inline paddingLeftFilled (props: IIconProp list) = createElement (import "PaddingLeftFilled" FluentIcons) props
        static member inline paddingLeftRegular (props: IIconProp list) = createElement (import "PaddingLeftRegular" FluentIcons) props
        static member inline paddingRightFilled (props: IIconProp list) = createElement (import "PaddingRightFilled" FluentIcons) props
        static member inline paddingRightRegular (props: IIconProp list) = createElement (import "PaddingRightRegular" FluentIcons) props
        static member inline paddingTopFilled (props: IIconProp list) = createElement (import "PaddingTopFilled" FluentIcons) props
        static member inline paddingTopRegular (props: IIconProp list) = createElement (import "PaddingTopRegular" FluentIcons) props
        static member inline pageFitFilled (props: IIconProp list) = createElement (import "PageFitFilled" FluentIcons) props
        static member inline pageFitRegular (props: IIconProp list) = createElement (import "PageFitRegular" FluentIcons) props
        static member inline paintBrushFilled (props: IIconProp list) = createElement (import "PaintBrushFilled" FluentIcons) props
        static member inline paintBrushRegular (props: IIconProp list) = createElement (import "PaintBrushRegular" FluentIcons) props
        static member inline paintBrushArrowDownFilled (props: IIconProp list) = createElement (import "PaintBrushArrowDownFilled" FluentIcons) props
        static member inline paintBrushArrowDownRegular (props: IIconProp list) = createElement (import "PaintBrushArrowDownRegular" FluentIcons) props
        static member inline paintBrushArrowUpFilled (props: IIconProp list) = createElement (import "PaintBrushArrowUpFilled" FluentIcons) props
        static member inline paintBrushArrowUpRegular (props: IIconProp list) = createElement (import "PaintBrushArrowUpRegular" FluentIcons) props
        static member inline paintBrushSparkleFilled (props: IIconProp list) = createElement (import "PaintBrushSparkleFilled" FluentIcons) props
        static member inline paintBrushSparkleRegular (props: IIconProp list) = createElement (import "PaintBrushSparkleRegular" FluentIcons) props
        static member inline paintBrushSubtractFilled (props: IIconProp list) = createElement (import "PaintBrushSubtractFilled" FluentIcons) props
        static member inline paintBrushSubtractRegular (props: IIconProp list) = createElement (import "PaintBrushSubtractRegular" FluentIcons) props
        static member inline paintBucketFilled (props: IIconProp list) = createElement (import "PaintBucketFilled" FluentIcons) props
        static member inline paintBucketRegular (props: IIconProp list) = createElement (import "PaintBucketRegular" FluentIcons) props
        static member inline pairFilled (props: IIconProp list) = createElement (import "PairFilled" FluentIcons) props
        static member inline pairRegular (props: IIconProp list) = createElement (import "PairRegular" FluentIcons) props
        static member inline panelBottomFilled (props: IIconProp list) = createElement (import "PanelBottomFilled" FluentIcons) props
        static member inline panelBottomRegular (props: IIconProp list) = createElement (import "PanelBottomRegular" FluentIcons) props
        static member inline panelBottomContractFilled (props: IIconProp list) = createElement (import "PanelBottomContractFilled" FluentIcons) props
        static member inline panelBottomContractRegular (props: IIconProp list) = createElement (import "PanelBottomContractRegular" FluentIcons) props
        static member inline panelBottomExpandFilled (props: IIconProp list) = createElement (import "PanelBottomExpandFilled" FluentIcons) props
        static member inline panelBottomExpandRegular (props: IIconProp list) = createElement (import "PanelBottomExpandRegular" FluentIcons) props
        static member inline panelLeftFilled (props: IIconProp list) = createElement (import "PanelLeftFilled" FluentIcons) props
        static member inline panelLeftRegular (props: IIconProp list) = createElement (import "PanelLeftRegular" FluentIcons) props
        static member inline panelLeftAddFilled (props: IIconProp list) = createElement (import "PanelLeftAddFilled" FluentIcons) props
        static member inline panelLeftAddRegular (props: IIconProp list) = createElement (import "PanelLeftAddRegular" FluentIcons) props
        static member inline panelLeftContractFilled (props: IIconProp list) = createElement (import "PanelLeftContractFilled" FluentIcons) props
        static member inline panelLeftContractRegular (props: IIconProp list) = createElement (import "PanelLeftContractRegular" FluentIcons) props
        static member inline panelLeftExpandFilled (props: IIconProp list) = createElement (import "PanelLeftExpandFilled" FluentIcons) props
        static member inline panelLeftExpandRegular (props: IIconProp list) = createElement (import "PanelLeftExpandRegular" FluentIcons) props
        static member inline panelLeftFocusRightFilled (props: IIconProp list) = createElement (import "PanelLeftFocusRightFilled" FluentIcons) props
        static member inline panelLeftHeaderFilled (props: IIconProp list) = createElement (import "PanelLeftHeaderFilled" FluentIcons) props
        static member inline panelLeftHeaderRegular (props: IIconProp list) = createElement (import "PanelLeftHeaderRegular" FluentIcons) props
        static member inline panelLeftHeaderAddFilled (props: IIconProp list) = createElement (import "PanelLeftHeaderAddFilled" FluentIcons) props
        static member inline panelLeftHeaderAddRegular (props: IIconProp list) = createElement (import "PanelLeftHeaderAddRegular" FluentIcons) props
        static member inline panelLeftHeaderKeyFilled (props: IIconProp list) = createElement (import "PanelLeftHeaderKeyFilled" FluentIcons) props
        static member inline panelLeftHeaderKeyRegular (props: IIconProp list) = createElement (import "PanelLeftHeaderKeyRegular" FluentIcons) props
        static member inline panelLeftKeyFilled (props: IIconProp list) = createElement (import "PanelLeftKeyFilled" FluentIcons) props
        static member inline panelLeftKeyRegular (props: IIconProp list) = createElement (import "PanelLeftKeyRegular" FluentIcons) props
        static member inline panelLeftTextFilled (props: IIconProp list) = createElement (import "PanelLeftTextFilled" FluentIcons) props
        static member inline panelLeftTextRegular (props: IIconProp list) = createElement (import "PanelLeftTextRegular" FluentIcons) props
        static member inline panelLeftTextAddFilled (props: IIconProp list) = createElement (import "PanelLeftTextAddFilled" FluentIcons) props
        static member inline panelLeftTextAddRegular (props: IIconProp list) = createElement (import "PanelLeftTextAddRegular" FluentIcons) props
        static member inline panelLeftTextDismissFilled (props: IIconProp list) = createElement (import "PanelLeftTextDismissFilled" FluentIcons) props
        static member inline panelLeftTextDismissRegular (props: IIconProp list) = createElement (import "PanelLeftTextDismissRegular" FluentIcons) props
        static member inline panelRightFilled (props: IIconProp list) = createElement (import "PanelRightFilled" FluentIcons) props
        static member inline panelRightRegular (props: IIconProp list) = createElement (import "PanelRightRegular" FluentIcons) props
        static member inline panelRightAddFilled (props: IIconProp list) = createElement (import "PanelRightAddFilled" FluentIcons) props
        static member inline panelRightAddRegular (props: IIconProp list) = createElement (import "PanelRightAddRegular" FluentIcons) props
        static member inline panelRightContractFilled (props: IIconProp list) = createElement (import "PanelRightContractFilled" FluentIcons) props
        static member inline panelRightContractRegular (props: IIconProp list) = createElement (import "PanelRightContractRegular" FluentIcons) props
        static member inline panelRightCursorFilled (props: IIconProp list) = createElement (import "PanelRightCursorFilled" FluentIcons) props
        static member inline panelRightCursorRegular (props: IIconProp list) = createElement (import "PanelRightCursorRegular" FluentIcons) props
        static member inline panelRightExpandFilled (props: IIconProp list) = createElement (import "PanelRightExpandFilled" FluentIcons) props
        static member inline panelRightExpandRegular (props: IIconProp list) = createElement (import "PanelRightExpandRegular" FluentIcons) props
        static member inline panelRightGalleryFilled (props: IIconProp list) = createElement (import "PanelRightGalleryFilled" FluentIcons) props
        static member inline panelRightGalleryRegular (props: IIconProp list) = createElement (import "PanelRightGalleryRegular" FluentIcons) props
        static member inline panelSeparateWindowFilled (props: IIconProp list) = createElement (import "PanelSeparateWindowFilled" FluentIcons) props
        static member inline panelSeparateWindowRegular (props: IIconProp list) = createElement (import "PanelSeparateWindowRegular" FluentIcons) props
        static member inline panelTopContractFilled (props: IIconProp list) = createElement (import "PanelTopContractFilled" FluentIcons) props
        static member inline panelTopContractRegular (props: IIconProp list) = createElement (import "PanelTopContractRegular" FluentIcons) props
        static member inline panelTopExpandFilled (props: IIconProp list) = createElement (import "PanelTopExpandFilled" FluentIcons) props
        static member inline panelTopExpandRegular (props: IIconProp list) = createElement (import "PanelTopExpandRegular" FluentIcons) props
        static member inline panelTopGalleryFilled (props: IIconProp list) = createElement (import "PanelTopGalleryFilled" FluentIcons) props
        static member inline panelTopGalleryRegular (props: IIconProp list) = createElement (import "PanelTopGalleryRegular" FluentIcons) props
        static member inline passwordFilled (props: IIconProp list) = createElement (import "PasswordFilled" FluentIcons) props
        static member inline passwordRegular (props: IIconProp list) = createElement (import "PasswordRegular" FluentIcons) props
        static member inline patchFilled (props: IIconProp list) = createElement (import "PatchFilled" FluentIcons) props
        static member inline patchRegular (props: IIconProp list) = createElement (import "PatchRegular" FluentIcons) props
        static member inline patientFilled (props: IIconProp list) = createElement (import "PatientFilled" FluentIcons) props
        static member inline patientRegular (props: IIconProp list) = createElement (import "PatientRegular" FluentIcons) props
        static member inline pauseFilled (props: IIconProp list) = createElement (import "PauseFilled" FluentIcons) props
        static member inline pauseRegular (props: IIconProp list) = createElement (import "PauseRegular" FluentIcons) props
        static member inline pauseCircleFilled (props: IIconProp list) = createElement (import "PauseCircleFilled" FluentIcons) props
        static member inline pauseCircleRegular (props: IIconProp list) = createElement (import "PauseCircleRegular" FluentIcons) props
        static member inline pauseOffFilled (props: IIconProp list) = createElement (import "PauseOffFilled" FluentIcons) props
        static member inline pauseOffRegular (props: IIconProp list) = createElement (import "PauseOffRegular" FluentIcons) props
        static member inline pauseSettingsFilled (props: IIconProp list) = createElement (import "PauseSettingsFilled" FluentIcons) props
        static member inline pauseSettingsRegular (props: IIconProp list) = createElement (import "PauseSettingsRegular" FluentIcons) props
        static member inline paymentFilled (props: IIconProp list) = createElement (import "PaymentFilled" FluentIcons) props
        static member inline paymentRegular (props: IIconProp list) = createElement (import "PaymentRegular" FluentIcons) props
        static member inline paymentWirelessFilled (props: IIconProp list) = createElement (import "PaymentWirelessFilled" FluentIcons) props
        static member inline paymentWirelessRegular (props: IIconProp list) = createElement (import "PaymentWirelessRegular" FluentIcons) props
        static member inline penFilled (props: IIconProp list) = createElement (import "PenFilled" FluentIcons) props
        static member inline penRegular (props: IIconProp list) = createElement (import "PenRegular" FluentIcons) props
        static member inline penDismissFilled (props: IIconProp list) = createElement (import "PenDismissFilled" FluentIcons) props
        static member inline penDismissRegular (props: IIconProp list) = createElement (import "PenDismissRegular" FluentIcons) props
        static member inline penOffFilled (props: IIconProp list) = createElement (import "PenOffFilled" FluentIcons) props
        static member inline penOffRegular (props: IIconProp list) = createElement (import "PenOffRegular" FluentIcons) props
        static member inline penProhibitedFilled (props: IIconProp list) = createElement (import "PenProhibitedFilled" FluentIcons) props
        static member inline penProhibitedRegular (props: IIconProp list) = createElement (import "PenProhibitedRegular" FluentIcons) props
        static member inline penSparkleFilled (props: IIconProp list) = createElement (import "PenSparkleFilled" FluentIcons) props
        static member inline penSparkleRegular (props: IIconProp list) = createElement (import "PenSparkleRegular" FluentIcons) props
        static member inline pentagonFilled (props: IIconProp list) = createElement (import "PentagonFilled" FluentIcons) props
        static member inline pentagonRegular (props: IIconProp list) = createElement (import "PentagonRegular" FluentIcons) props
        static member inline peopleFilled (props: IIconProp list) = createElement (import "PeopleFilled" FluentIcons) props
        static member inline peopleRegular (props: IIconProp list) = createElement (import "PeopleRegular" FluentIcons) props
        static member inline peopleAddFilled (props: IIconProp list) = createElement (import "PeopleAddFilled" FluentIcons) props
        static member inline peopleAddRegular (props: IIconProp list) = createElement (import "PeopleAddRegular" FluentIcons) props
        static member inline peopleAudienceFilled (props: IIconProp list) = createElement (import "PeopleAudienceFilled" FluentIcons) props
        static member inline peopleAudienceRegular (props: IIconProp list) = createElement (import "PeopleAudienceRegular" FluentIcons) props
        static member inline peopleCallFilled (props: IIconProp list) = createElement (import "PeopleCallFilled" FluentIcons) props
        static member inline peopleCallRegular (props: IIconProp list) = createElement (import "PeopleCallRegular" FluentIcons) props
        static member inline peopleChatFilled (props: IIconProp list) = createElement (import "PeopleChatFilled" FluentIcons) props
        static member inline peopleChatRegular (props: IIconProp list) = createElement (import "PeopleChatRegular" FluentIcons) props
        static member inline peopleCheckmarkFilled (props: IIconProp list) = createElement (import "PeopleCheckmarkFilled" FluentIcons) props
        static member inline peopleCheckmarkRegular (props: IIconProp list) = createElement (import "PeopleCheckmarkRegular" FluentIcons) props
        static member inline peopleCommunityFilled (props: IIconProp list) = createElement (import "PeopleCommunityFilled" FluentIcons) props
        static member inline peopleCommunityRegular (props: IIconProp list) = createElement (import "PeopleCommunityRegular" FluentIcons) props
        static member inline peopleCommunityAddFilled (props: IIconProp list) = createElement (import "PeopleCommunityAddFilled" FluentIcons) props
        static member inline peopleCommunityAddRegular (props: IIconProp list) = createElement (import "PeopleCommunityAddRegular" FluentIcons) props
        static member inline peopleEditFilled (props: IIconProp list) = createElement (import "PeopleEditFilled" FluentIcons) props
        static member inline peopleEditRegular (props: IIconProp list) = createElement (import "PeopleEditRegular" FluentIcons) props
        static member inline peopleErrorFilled (props: IIconProp list) = createElement (import "PeopleErrorFilled" FluentIcons) props
        static member inline peopleErrorRegular (props: IIconProp list) = createElement (import "PeopleErrorRegular" FluentIcons) props
        static member inline peopleEyeFilled (props: IIconProp list) = createElement (import "PeopleEyeFilled" FluentIcons) props
        static member inline peopleEyeRegular (props: IIconProp list) = createElement (import "PeopleEyeRegular" FluentIcons) props
        static member inline peopleListFilled (props: IIconProp list) = createElement (import "PeopleListFilled" FluentIcons) props
        static member inline peopleListRegular (props: IIconProp list) = createElement (import "PeopleListRegular" FluentIcons) props
        static member inline peopleLockFilled (props: IIconProp list) = createElement (import "PeopleLockFilled" FluentIcons) props
        static member inline peopleLockRegular (props: IIconProp list) = createElement (import "PeopleLockRegular" FluentIcons) props
        static member inline peopleMoneyFilled (props: IIconProp list) = createElement (import "PeopleMoneyFilled" FluentIcons) props
        static member inline peopleMoneyRegular (props: IIconProp list) = createElement (import "PeopleMoneyRegular" FluentIcons) props
        static member inline peopleProhibitedFilled (props: IIconProp list) = createElement (import "PeopleProhibitedFilled" FluentIcons) props
        static member inline peopleProhibitedRegular (props: IIconProp list) = createElement (import "PeopleProhibitedRegular" FluentIcons) props
        static member inline peopleQueueFilled (props: IIconProp list) = createElement (import "PeopleQueueFilled" FluentIcons) props
        static member inline peopleQueueRegular (props: IIconProp list) = createElement (import "PeopleQueueRegular" FluentIcons) props
        static member inline peopleSearchFilled (props: IIconProp list) = createElement (import "PeopleSearchFilled" FluentIcons) props
        static member inline peopleSearchRegular (props: IIconProp list) = createElement (import "PeopleSearchRegular" FluentIcons) props
        static member inline peopleSettingsFilled (props: IIconProp list) = createElement (import "PeopleSettingsFilled" FluentIcons) props
        static member inline peopleSettingsRegular (props: IIconProp list) = createElement (import "PeopleSettingsRegular" FluentIcons) props
        static member inline peopleStarFilled (props: IIconProp list) = createElement (import "PeopleStarFilled" FluentIcons) props
        static member inline peopleStarRegular (props: IIconProp list) = createElement (import "PeopleStarRegular" FluentIcons) props
        static member inline peopleSubtractFilled (props: IIconProp list) = createElement (import "PeopleSubtractFilled" FluentIcons) props
        static member inline peopleSubtractRegular (props: IIconProp list) = createElement (import "PeopleSubtractRegular" FluentIcons) props
        static member inline peopleSwapFilled (props: IIconProp list) = createElement (import "PeopleSwapFilled" FluentIcons) props
        static member inline peopleSwapRegular (props: IIconProp list) = createElement (import "PeopleSwapRegular" FluentIcons) props
        static member inline peopleSyncFilled (props: IIconProp list) = createElement (import "PeopleSyncFilled" FluentIcons) props
        static member inline peopleSyncRegular (props: IIconProp list) = createElement (import "PeopleSyncRegular" FluentIcons) props
        static member inline peopleTeamFilled (props: IIconProp list) = createElement (import "PeopleTeamFilled" FluentIcons) props
        static member inline peopleTeamRegular (props: IIconProp list) = createElement (import "PeopleTeamRegular" FluentIcons) props
        static member inline peopleTeamAddFilled (props: IIconProp list) = createElement (import "PeopleTeamAddFilled" FluentIcons) props
        static member inline peopleTeamAddRegular (props: IIconProp list) = createElement (import "PeopleTeamAddRegular" FluentIcons) props
        static member inline peopleTeamDeleteFilled (props: IIconProp list) = createElement (import "PeopleTeamDeleteFilled" FluentIcons) props
        static member inline peopleTeamDeleteRegular (props: IIconProp list) = createElement (import "PeopleTeamDeleteRegular" FluentIcons) props
        static member inline peopleTeamToolboxFilled (props: IIconProp list) = createElement (import "PeopleTeamToolboxFilled" FluentIcons) props
        static member inline peopleTeamToolboxRegular (props: IIconProp list) = createElement (import "PeopleTeamToolboxRegular" FluentIcons) props
        static member inline peopleToolboxFilled (props: IIconProp list) = createElement (import "PeopleToolboxFilled" FluentIcons) props
        static member inline peopleToolboxRegular (props: IIconProp list) = createElement (import "PeopleToolboxRegular" FluentIcons) props
        static member inline personFilled (props: IIconProp list) = createElement (import "PersonFilled" FluentIcons) props
        static member inline personRegular (props: IIconProp list) = createElement (import "PersonRegular" FluentIcons) props
        static member inline person5Filled (props: IIconProp list) = createElement (import "Person5Filled" FluentIcons) props
        static member inline person5Regular (props: IIconProp list) = createElement (import "Person5Regular" FluentIcons) props
        static member inline person6Filled (props: IIconProp list) = createElement (import "Person6Filled" FluentIcons) props
        static member inline person6Regular (props: IIconProp list) = createElement (import "Person6Regular" FluentIcons) props
        static member inline personAccountsFilled (props: IIconProp list) = createElement (import "PersonAccountsFilled" FluentIcons) props
        static member inline personAccountsRegular (props: IIconProp list) = createElement (import "PersonAccountsRegular" FluentIcons) props
        static member inline personAddFilled (props: IIconProp list) = createElement (import "PersonAddFilled" FluentIcons) props
        static member inline personAddRegular (props: IIconProp list) = createElement (import "PersonAddRegular" FluentIcons) props
        static member inline personAlertFilled (props: IIconProp list) = createElement (import "PersonAlertFilled" FluentIcons) props
        static member inline personAlertRegular (props: IIconProp list) = createElement (import "PersonAlertRegular" FluentIcons) props
        static member inline personAlertOffFilled (props: IIconProp list) = createElement (import "PersonAlertOffFilled" FluentIcons) props
        static member inline personAlertOffRegular (props: IIconProp list) = createElement (import "PersonAlertOffRegular" FluentIcons) props
        static member inline personArrowBackFilled (props: IIconProp list) = createElement (import "PersonArrowBackFilled" FluentIcons) props
        static member inline personArrowBackRegular (props: IIconProp list) = createElement (import "PersonArrowBackRegular" FluentIcons) props
        static member inline personArrowLeftFilled (props: IIconProp list) = createElement (import "PersonArrowLeftFilled" FluentIcons) props
        static member inline personArrowLeftRegular (props: IIconProp list) = createElement (import "PersonArrowLeftRegular" FluentIcons) props
        static member inline personArrowRightFilled (props: IIconProp list) = createElement (import "PersonArrowRightFilled" FluentIcons) props
        static member inline personArrowRightRegular (props: IIconProp list) = createElement (import "PersonArrowRightRegular" FluentIcons) props
        static member inline personAvailableFilled (props: IIconProp list) = createElement (import "PersonAvailableFilled" FluentIcons) props
        static member inline personAvailableRegular (props: IIconProp list) = createElement (import "PersonAvailableRegular" FluentIcons) props
        static member inline personBoardFilled (props: IIconProp list) = createElement (import "PersonBoardFilled" FluentIcons) props
        static member inline personBoardRegular (props: IIconProp list) = createElement (import "PersonBoardRegular" FluentIcons) props
        static member inline personCallFilled (props: IIconProp list) = createElement (import "PersonCallFilled" FluentIcons) props
        static member inline personCallRegular (props: IIconProp list) = createElement (import "PersonCallRegular" FluentIcons) props
        static member inline personChatFilled (props: IIconProp list) = createElement (import "PersonChatFilled" FluentIcons) props
        static member inline personChatRegular (props: IIconProp list) = createElement (import "PersonChatRegular" FluentIcons) props
        static member inline personCircleFilled (props: IIconProp list) = createElement (import "PersonCircleFilled" FluentIcons) props
        static member inline personCircleRegular (props: IIconProp list) = createElement (import "PersonCircleRegular" FluentIcons) props
        static member inline personClockFilled (props: IIconProp list) = createElement (import "PersonClockFilled" FluentIcons) props
        static member inline personClockRegular (props: IIconProp list) = createElement (import "PersonClockRegular" FluentIcons) props
        static member inline personDeleteFilled (props: IIconProp list) = createElement (import "PersonDeleteFilled" FluentIcons) props
        static member inline personDeleteRegular (props: IIconProp list) = createElement (import "PersonDeleteRegular" FluentIcons) props
        static member inline personDesktopFilled (props: IIconProp list) = createElement (import "PersonDesktopFilled" FluentIcons) props
        static member inline personDesktopRegular (props: IIconProp list) = createElement (import "PersonDesktopRegular" FluentIcons) props
        static member inline personEditFilled (props: IIconProp list) = createElement (import "PersonEditFilled" FluentIcons) props
        static member inline personEditRegular (props: IIconProp list) = createElement (import "PersonEditRegular" FluentIcons) props
        static member inline personFeedbackFilled (props: IIconProp list) = createElement (import "PersonFeedbackFilled" FluentIcons) props
        static member inline personFeedbackRegular (props: IIconProp list) = createElement (import "PersonFeedbackRegular" FluentIcons) props
        static member inline personHeartFilled (props: IIconProp list) = createElement (import "PersonHeartFilled" FluentIcons) props
        static member inline personHeartRegular (props: IIconProp list) = createElement (import "PersonHeartRegular" FluentIcons) props
        static member inline personHomeFilled (props: IIconProp list) = createElement (import "PersonHomeFilled" FluentIcons) props
        static member inline personHomeRegular (props: IIconProp list) = createElement (import "PersonHomeRegular" FluentIcons) props
        static member inline personInfoFilled (props: IIconProp list) = createElement (import "PersonInfoFilled" FluentIcons) props
        static member inline personInfoRegular (props: IIconProp list) = createElement (import "PersonInfoRegular" FluentIcons) props
        static member inline personKeyFilled (props: IIconProp list) = createElement (import "PersonKeyFilled" FluentIcons) props
        static member inline personKeyRegular (props: IIconProp list) = createElement (import "PersonKeyRegular" FluentIcons) props
        static member inline personLightbulbFilled (props: IIconProp list) = createElement (import "PersonLightbulbFilled" FluentIcons) props
        static member inline personLightbulbRegular (props: IIconProp list) = createElement (import "PersonLightbulbRegular" FluentIcons) props
        static member inline personLightningFilled (props: IIconProp list) = createElement (import "PersonLightningFilled" FluentIcons) props
        static member inline personLightningRegular (props: IIconProp list) = createElement (import "PersonLightningRegular" FluentIcons) props
        static member inline personLinkFilled (props: IIconProp list) = createElement (import "PersonLinkFilled" FluentIcons) props
        static member inline personLinkRegular (props: IIconProp list) = createElement (import "PersonLinkRegular" FluentIcons) props
        static member inline personLockFilled (props: IIconProp list) = createElement (import "PersonLockFilled" FluentIcons) props
        static member inline personLockRegular (props: IIconProp list) = createElement (import "PersonLockRegular" FluentIcons) props
        static member inline personMailFilled (props: IIconProp list) = createElement (import "PersonMailFilled" FluentIcons) props
        static member inline personMailRegular (props: IIconProp list) = createElement (import "PersonMailRegular" FluentIcons) props
        static member inline personMoneyFilled (props: IIconProp list) = createElement (import "PersonMoneyFilled" FluentIcons) props
        static member inline personMoneyRegular (props: IIconProp list) = createElement (import "PersonMoneyRegular" FluentIcons) props
        static member inline personNoteFilled (props: IIconProp list) = createElement (import "PersonNoteFilled" FluentIcons) props
        static member inline personNoteRegular (props: IIconProp list) = createElement (import "PersonNoteRegular" FluentIcons) props
        static member inline personPasskeyFilled (props: IIconProp list) = createElement (import "PersonPasskeyFilled" FluentIcons) props
        static member inline personPasskeyRegular (props: IIconProp list) = createElement (import "PersonPasskeyRegular" FluentIcons) props
        static member inline personPillFilled (props: IIconProp list) = createElement (import "PersonPillFilled" FluentIcons) props
        static member inline personPillRegular (props: IIconProp list) = createElement (import "PersonPillRegular" FluentIcons) props
        static member inline personProhibitedFilled (props: IIconProp list) = createElement (import "PersonProhibitedFilled" FluentIcons) props
        static member inline personProhibitedRegular (props: IIconProp list) = createElement (import "PersonProhibitedRegular" FluentIcons) props
        static member inline personQuestionMarkFilled (props: IIconProp list) = createElement (import "PersonQuestionMarkFilled" FluentIcons) props
        static member inline personQuestionMarkRegular (props: IIconProp list) = createElement (import "PersonQuestionMarkRegular" FluentIcons) props
        static member inline personRibbonFilled (props: IIconProp list) = createElement (import "PersonRibbonFilled" FluentIcons) props
        static member inline personRibbonRegular (props: IIconProp list) = createElement (import "PersonRibbonRegular" FluentIcons) props
        static member inline personRunningFilled (props: IIconProp list) = createElement (import "PersonRunningFilled" FluentIcons) props
        static member inline personRunningRegular (props: IIconProp list) = createElement (import "PersonRunningRegular" FluentIcons) props
        static member inline personSearchFilled (props: IIconProp list) = createElement (import "PersonSearchFilled" FluentIcons) props
        static member inline personSearchRegular (props: IIconProp list) = createElement (import "PersonSearchRegular" FluentIcons) props
        static member inline personSettingsFilled (props: IIconProp list) = createElement (import "PersonSettingsFilled" FluentIcons) props
        static member inline personSettingsRegular (props: IIconProp list) = createElement (import "PersonSettingsRegular" FluentIcons) props
        static member inline personSquareFilled (props: IIconProp list) = createElement (import "PersonSquareFilled" FluentIcons) props
        static member inline personSquareRegular (props: IIconProp list) = createElement (import "PersonSquareRegular" FluentIcons) props
        static member inline personSquareCheckmarkFilled (props: IIconProp list) = createElement (import "PersonSquareCheckmarkFilled" FluentIcons) props
        static member inline personSquareCheckmarkRegular (props: IIconProp list) = createElement (import "PersonSquareCheckmarkRegular" FluentIcons) props
        static member inline personStarFilled (props: IIconProp list) = createElement (import "PersonStarFilled" FluentIcons) props
        static member inline personStarRegular (props: IIconProp list) = createElement (import "PersonStarRegular" FluentIcons) props
        static member inline personStarburstFilled (props: IIconProp list) = createElement (import "PersonStarburstFilled" FluentIcons) props
        static member inline personStarburstRegular (props: IIconProp list) = createElement (import "PersonStarburstRegular" FluentIcons) props
        static member inline personSubtractFilled (props: IIconProp list) = createElement (import "PersonSubtractFilled" FluentIcons) props
        static member inline personSubtractRegular (props: IIconProp list) = createElement (import "PersonSubtractRegular" FluentIcons) props
        static member inline personSupportFilled (props: IIconProp list) = createElement (import "PersonSupportFilled" FluentIcons) props
        static member inline personSupportRegular (props: IIconProp list) = createElement (import "PersonSupportRegular" FluentIcons) props
        static member inline personSwapFilled (props: IIconProp list) = createElement (import "PersonSwapFilled" FluentIcons) props
        static member inline personSwapRegular (props: IIconProp list) = createElement (import "PersonSwapRegular" FluentIcons) props
        static member inline personSyncFilled (props: IIconProp list) = createElement (import "PersonSyncFilled" FluentIcons) props
        static member inline personSyncRegular (props: IIconProp list) = createElement (import "PersonSyncRegular" FluentIcons) props
        static member inline personTagFilled (props: IIconProp list) = createElement (import "PersonTagFilled" FluentIcons) props
        static member inline personTagRegular (props: IIconProp list) = createElement (import "PersonTagRegular" FluentIcons) props
        static member inline personTentativeFilled (props: IIconProp list) = createElement (import "PersonTentativeFilled" FluentIcons) props
        static member inline personTentativeRegular (props: IIconProp list) = createElement (import "PersonTentativeRegular" FluentIcons) props
        static member inline personVoiceFilled (props: IIconProp list) = createElement (import "PersonVoiceFilled" FluentIcons) props
        static member inline personVoiceRegular (props: IIconProp list) = createElement (import "PersonVoiceRegular" FluentIcons) props
        static member inline personWalkingFilled (props: IIconProp list) = createElement (import "PersonWalkingFilled" FluentIcons) props
        static member inline personWalkingRegular (props: IIconProp list) = createElement (import "PersonWalkingRegular" FluentIcons) props
        static member inline personWarningFilled (props: IIconProp list) = createElement (import "PersonWarningFilled" FluentIcons) props
        static member inline personWarningRegular (props: IIconProp list) = createElement (import "PersonWarningRegular" FluentIcons) props
        static member inline personWrenchFilled (props: IIconProp list) = createElement (import "PersonWrenchFilled" FluentIcons) props
        static member inline personWrenchRegular (props: IIconProp list) = createElement (import "PersonWrenchRegular" FluentIcons) props
        static member inline phoneFilled (props: IIconProp list) = createElement (import "PhoneFilled" FluentIcons) props
        static member inline phoneRegular (props: IIconProp list) = createElement (import "PhoneRegular" FluentIcons) props
        static member inline phoneAddFilled (props: IIconProp list) = createElement (import "PhoneAddFilled" FluentIcons) props
        static member inline phoneAddRegular (props: IIconProp list) = createElement (import "PhoneAddRegular" FluentIcons) props
        static member inline phoneArrowRightFilled (props: IIconProp list) = createElement (import "PhoneArrowRightFilled" FluentIcons) props
        static member inline phoneArrowRightRegular (props: IIconProp list) = createElement (import "PhoneArrowRightRegular" FluentIcons) props
        static member inline phoneChatFilled (props: IIconProp list) = createElement (import "PhoneChatFilled" FluentIcons) props
        static member inline phoneChatRegular (props: IIconProp list) = createElement (import "PhoneChatRegular" FluentIcons) props
        static member inline phoneCheckmarkFilled (props: IIconProp list) = createElement (import "PhoneCheckmarkFilled" FluentIcons) props
        static member inline phoneCheckmarkRegular (props: IIconProp list) = createElement (import "PhoneCheckmarkRegular" FluentIcons) props
        static member inline phoneDesktopFilled (props: IIconProp list) = createElement (import "PhoneDesktopFilled" FluentIcons) props
        static member inline phoneDesktopRegular (props: IIconProp list) = createElement (import "PhoneDesktopRegular" FluentIcons) props
        static member inline phoneDesktopAddFilled (props: IIconProp list) = createElement (import "PhoneDesktopAddFilled" FluentIcons) props
        static member inline phoneDesktopAddRegular (props: IIconProp list) = createElement (import "PhoneDesktopAddRegular" FluentIcons) props
        static member inline phoneDismissFilled (props: IIconProp list) = createElement (import "PhoneDismissFilled" FluentIcons) props
        static member inline phoneDismissRegular (props: IIconProp list) = createElement (import "PhoneDismissRegular" FluentIcons) props
        static member inline phoneEditFilled (props: IIconProp list) = createElement (import "PhoneEditFilled" FluentIcons) props
        static member inline phoneEditRegular (props: IIconProp list) = createElement (import "PhoneEditRegular" FluentIcons) props
        static member inline phoneEraserFilled (props: IIconProp list) = createElement (import "PhoneEraserFilled" FluentIcons) props
        static member inline phoneEraserRegular (props: IIconProp list) = createElement (import "PhoneEraserRegular" FluentIcons) props
        static member inline phoneFooterArrowDownFilled (props: IIconProp list) = createElement (import "PhoneFooterArrowDownFilled" FluentIcons) props
        static member inline phoneFooterArrowDownRegular (props: IIconProp list) = createElement (import "PhoneFooterArrowDownRegular" FluentIcons) props
        static member inline phoneHeaderArrowUpFilled (props: IIconProp list) = createElement (import "PhoneHeaderArrowUpFilled" FluentIcons) props
        static member inline phoneHeaderArrowUpRegular (props: IIconProp list) = createElement (import "PhoneHeaderArrowUpRegular" FluentIcons) props
        static member inline phoneKeyFilled (props: IIconProp list) = createElement (import "PhoneKeyFilled" FluentIcons) props
        static member inline phoneKeyRegular (props: IIconProp list) = createElement (import "PhoneKeyRegular" FluentIcons) props
        static member inline phoneLaptopFilled (props: IIconProp list) = createElement (import "PhoneLaptopFilled" FluentIcons) props
        static member inline phoneLaptopRegular (props: IIconProp list) = createElement (import "PhoneLaptopRegular" FluentIcons) props
        static member inline phoneLinkSetupFilled (props: IIconProp list) = createElement (import "PhoneLinkSetupFilled" FluentIcons) props
        static member inline phoneLinkSetupRegular (props: IIconProp list) = createElement (import "PhoneLinkSetupRegular" FluentIcons) props
        static member inline phoneLockFilled (props: IIconProp list) = createElement (import "PhoneLockFilled" FluentIcons) props
        static member inline phoneLockRegular (props: IIconProp list) = createElement (import "PhoneLockRegular" FluentIcons) props
        static member inline phonePageHeaderFilled (props: IIconProp list) = createElement (import "PhonePageHeaderFilled" FluentIcons) props
        static member inline phonePageHeaderRegular (props: IIconProp list) = createElement (import "PhonePageHeaderRegular" FluentIcons) props
        static member inline phonePaginationFilled (props: IIconProp list) = createElement (import "PhonePaginationFilled" FluentIcons) props
        static member inline phonePaginationRegular (props: IIconProp list) = createElement (import "PhonePaginationRegular" FluentIcons) props
        static member inline phoneScreenTimeFilled (props: IIconProp list) = createElement (import "PhoneScreenTimeFilled" FluentIcons) props
        static member inline phoneScreenTimeRegular (props: IIconProp list) = createElement (import "PhoneScreenTimeRegular" FluentIcons) props
        static member inline phoneShakeFilled (props: IIconProp list) = createElement (import "PhoneShakeFilled" FluentIcons) props
        static member inline phoneShakeRegular (props: IIconProp list) = createElement (import "PhoneShakeRegular" FluentIcons) props
        static member inline phoneSpanInFilled (props: IIconProp list) = createElement (import "PhoneSpanInFilled" FluentIcons) props
        static member inline phoneSpanInRegular (props: IIconProp list) = createElement (import "PhoneSpanInRegular" FluentIcons) props
        static member inline phoneSpanOutFilled (props: IIconProp list) = createElement (import "PhoneSpanOutFilled" FluentIcons) props
        static member inline phoneSpanOutRegular (props: IIconProp list) = createElement (import "PhoneSpanOutRegular" FluentIcons) props
        static member inline phoneSpeakerFilled (props: IIconProp list) = createElement (import "PhoneSpeakerFilled" FluentIcons) props
        static member inline phoneSpeakerRegular (props: IIconProp list) = createElement (import "PhoneSpeakerRegular" FluentIcons) props
        static member inline phoneStatusBarFilled (props: IIconProp list) = createElement (import "PhoneStatusBarFilled" FluentIcons) props
        static member inline phoneStatusBarRegular (props: IIconProp list) = createElement (import "PhoneStatusBarRegular" FluentIcons) props
        static member inline phoneTabletFilled (props: IIconProp list) = createElement (import "PhoneTabletFilled" FluentIcons) props
        static member inline phoneTabletRegular (props: IIconProp list) = createElement (import "PhoneTabletRegular" FluentIcons) props
        static member inline phoneUpdateFilled (props: IIconProp list) = createElement (import "PhoneUpdateFilled" FluentIcons) props
        static member inline phoneUpdateRegular (props: IIconProp list) = createElement (import "PhoneUpdateRegular" FluentIcons) props
        static member inline phoneUpdateCheckmarkFilled (props: IIconProp list) = createElement (import "PhoneUpdateCheckmarkFilled" FluentIcons) props
        static member inline phoneUpdateCheckmarkRegular (props: IIconProp list) = createElement (import "PhoneUpdateCheckmarkRegular" FluentIcons) props
        static member inline phoneVerticalScrollFilled (props: IIconProp list) = createElement (import "PhoneVerticalScrollFilled" FluentIcons) props
        static member inline phoneVerticalScrollRegular (props: IIconProp list) = createElement (import "PhoneVerticalScrollRegular" FluentIcons) props
        static member inline phoneVibrateFilled (props: IIconProp list) = createElement (import "PhoneVibrateFilled" FluentIcons) props
        static member inline phoneVibrateRegular (props: IIconProp list) = createElement (import "PhoneVibrateRegular" FluentIcons) props
        static member inline photoFilterFilled (props: IIconProp list) = createElement (import "PhotoFilterFilled" FluentIcons) props
        static member inline photoFilterRegular (props: IIconProp list) = createElement (import "PhotoFilterRegular" FluentIcons) props
        static member inline piFilled (props: IIconProp list) = createElement (import "PiFilled" FluentIcons) props
        static member inline piRegular (props: IIconProp list) = createElement (import "PiRegular" FluentIcons) props
        static member inline pictureInPictureFilled (props: IIconProp list) = createElement (import "PictureInPictureFilled" FluentIcons) props
        static member inline pictureInPictureRegular (props: IIconProp list) = createElement (import "PictureInPictureRegular" FluentIcons) props
        static member inline pictureInPictureEnterFilled (props: IIconProp list) = createElement (import "PictureInPictureEnterFilled" FluentIcons) props
        static member inline pictureInPictureEnterRegular (props: IIconProp list) = createElement (import "PictureInPictureEnterRegular" FluentIcons) props
        static member inline pictureInPictureExitFilled (props: IIconProp list) = createElement (import "PictureInPictureExitFilled" FluentIcons) props
        static member inline pictureInPictureExitRegular (props: IIconProp list) = createElement (import "PictureInPictureExitRegular" FluentIcons) props
        static member inline pillFilled (props: IIconProp list) = createElement (import "PillFilled" FluentIcons) props
        static member inline pillRegular (props: IIconProp list) = createElement (import "PillRegular" FluentIcons) props
        static member inline pinFilled (props: IIconProp list) = createElement (import "PinFilled" FluentIcons) props
        static member inline pinRegular (props: IIconProp list) = createElement (import "PinRegular" FluentIcons) props
        static member inline pinGlobeFilled (props: IIconProp list) = createElement (import "PinGlobeFilled" FluentIcons) props
        static member inline pinGlobeRegular (props: IIconProp list) = createElement (import "PinGlobeRegular" FluentIcons) props
        static member inline pinOffFilled (props: IIconProp list) = createElement (import "PinOffFilled" FluentIcons) props
        static member inline pinOffRegular (props: IIconProp list) = createElement (import "PinOffRegular" FluentIcons) props
        static member inline pipelineFilled (props: IIconProp list) = createElement (import "PipelineFilled" FluentIcons) props
        static member inline pipelineRegular (props: IIconProp list) = createElement (import "PipelineRegular" FluentIcons) props
        static member inline pipelineAddFilled (props: IIconProp list) = createElement (import "PipelineAddFilled" FluentIcons) props
        static member inline pipelineAddRegular (props: IIconProp list) = createElement (import "PipelineAddRegular" FluentIcons) props
        static member inline pipelineArrowCurveDownFilled (props: IIconProp list) = createElement (import "PipelineArrowCurveDownFilled" FluentIcons) props
        static member inline pipelineArrowCurveDownRegular (props: IIconProp list) = createElement (import "PipelineArrowCurveDownRegular" FluentIcons) props
        static member inline pipelinePlayFilled (props: IIconProp list) = createElement (import "PipelinePlayFilled" FluentIcons) props
        static member inline pipelinePlayRegular (props: IIconProp list) = createElement (import "PipelinePlayRegular" FluentIcons) props
        static member inline pivotFilled (props: IIconProp list) = createElement (import "PivotFilled" FluentIcons) props
        static member inline pivotRegular (props: IIconProp list) = createElement (import "PivotRegular" FluentIcons) props
        static member inline plantCattailFilled (props: IIconProp list) = createElement (import "PlantCattailFilled" FluentIcons) props
        static member inline plantCattailRegular (props: IIconProp list) = createElement (import "PlantCattailRegular" FluentIcons) props
        static member inline plantGrassFilled (props: IIconProp list) = createElement (import "PlantGrassFilled" FluentIcons) props
        static member inline plantGrassRegular (props: IIconProp list) = createElement (import "PlantGrassRegular" FluentIcons) props
        static member inline plantRagweedFilled (props: IIconProp list) = createElement (import "PlantRagweedFilled" FluentIcons) props
        static member inline plantRagweedRegular (props: IIconProp list) = createElement (import "PlantRagweedRegular" FluentIcons) props
        static member inline playFilled (props: IIconProp list) = createElement (import "PlayFilled" FluentIcons) props
        static member inline playRegular (props: IIconProp list) = createElement (import "PlayRegular" FluentIcons) props
        static member inline playCircleFilled (props: IIconProp list) = createElement (import "PlayCircleFilled" FluentIcons) props
        static member inline playCircleRegular (props: IIconProp list) = createElement (import "PlayCircleRegular" FluentIcons) props
        static member inline playCircleHintFilled (props: IIconProp list) = createElement (import "PlayCircleHintFilled" FluentIcons) props
        static member inline playCircleHintRegular (props: IIconProp list) = createElement (import "PlayCircleHintRegular" FluentIcons) props
        static member inline playCircleSparkleFilled (props: IIconProp list) = createElement (import "PlayCircleSparkleFilled" FluentIcons) props
        static member inline playCircleSparkleRegular (props: IIconProp list) = createElement (import "PlayCircleSparkleRegular" FluentIcons) props
        static member inline playSettingsFilled (props: IIconProp list) = createElement (import "PlaySettingsFilled" FluentIcons) props
        static member inline playSettingsRegular (props: IIconProp list) = createElement (import "PlaySettingsRegular" FluentIcons) props
        static member inline playingCardsFilled (props: IIconProp list) = createElement (import "PlayingCardsFilled" FluentIcons) props
        static member inline playingCardsRegular (props: IIconProp list) = createElement (import "PlayingCardsRegular" FluentIcons) props
        static member inline plugConnectedFilled (props: IIconProp list) = createElement (import "PlugConnectedFilled" FluentIcons) props
        static member inline plugConnectedRegular (props: IIconProp list) = createElement (import "PlugConnectedRegular" FluentIcons) props
        static member inline plugConnectedAddFilled (props: IIconProp list) = createElement (import "PlugConnectedAddFilled" FluentIcons) props
        static member inline plugConnectedAddRegular (props: IIconProp list) = createElement (import "PlugConnectedAddRegular" FluentIcons) props
        static member inline plugConnectedCheckmarkFilled (props: IIconProp list) = createElement (import "PlugConnectedCheckmarkFilled" FluentIcons) props
        static member inline plugConnectedCheckmarkRegular (props: IIconProp list) = createElement (import "PlugConnectedCheckmarkRegular" FluentIcons) props
        static member inline plugConnectedSettingsFilled (props: IIconProp list) = createElement (import "PlugConnectedSettingsFilled" FluentIcons) props
        static member inline plugConnectedSettingsRegular (props: IIconProp list) = createElement (import "PlugConnectedSettingsRegular" FluentIcons) props
        static member inline plugDisconnectedFilled (props: IIconProp list) = createElement (import "PlugDisconnectedFilled" FluentIcons) props
        static member inline plugDisconnectedRegular (props: IIconProp list) = createElement (import "PlugDisconnectedRegular" FluentIcons) props
        static member inline pointScanFilled (props: IIconProp list) = createElement (import "PointScanFilled" FluentIcons) props
        static member inline pointScanRegular (props: IIconProp list) = createElement (import "PointScanRegular" FluentIcons) props
        static member inline pollFilled (props: IIconProp list) = createElement (import "PollFilled" FluentIcons) props
        static member inline pollRegular (props: IIconProp list) = createElement (import "PollRegular" FluentIcons) props
        static member inline pollHorizontalFilled (props: IIconProp list) = createElement (import "PollHorizontalFilled" FluentIcons) props
        static member inline pollHorizontalRegular (props: IIconProp list) = createElement (import "PollHorizontalRegular" FluentIcons) props
        static member inline pollOffFilled (props: IIconProp list) = createElement (import "PollOffFilled" FluentIcons) props
        static member inline pollOffRegular (props: IIconProp list) = createElement (import "PollOffRegular" FluentIcons) props
        static member inline portHdmiFilled (props: IIconProp list) = createElement (import "PortHdmiFilled" FluentIcons) props
        static member inline portHdmiRegular (props: IIconProp list) = createElement (import "PortHdmiRegular" FluentIcons) props
        static member inline portMicroUsbFilled (props: IIconProp list) = createElement (import "PortMicroUsbFilled" FluentIcons) props
        static member inline portMicroUsbRegular (props: IIconProp list) = createElement (import "PortMicroUsbRegular" FluentIcons) props
        static member inline portUsbAFilled (props: IIconProp list) = createElement (import "PortUsbAFilled" FluentIcons) props
        static member inline portUsbARegular (props: IIconProp list) = createElement (import "PortUsbARegular" FluentIcons) props
        static member inline portUsbCFilled (props: IIconProp list) = createElement (import "PortUsbCFilled" FluentIcons) props
        static member inline portUsbCRegular (props: IIconProp list) = createElement (import "PortUsbCRegular" FluentIcons) props
        static member inline positionBackwardFilled (props: IIconProp list) = createElement (import "PositionBackwardFilled" FluentIcons) props
        static member inline positionBackwardRegular (props: IIconProp list) = createElement (import "PositionBackwardRegular" FluentIcons) props
        static member inline positionForwardFilled (props: IIconProp list) = createElement (import "PositionForwardFilled" FluentIcons) props
        static member inline positionForwardRegular (props: IIconProp list) = createElement (import "PositionForwardRegular" FluentIcons) props
        static member inline positionToBackFilled (props: IIconProp list) = createElement (import "PositionToBackFilled" FluentIcons) props
        static member inline positionToBackRegular (props: IIconProp list) = createElement (import "PositionToBackRegular" FluentIcons) props
        static member inline positionToFrontFilled (props: IIconProp list) = createElement (import "PositionToFrontFilled" FluentIcons) props
        static member inline positionToFrontRegular (props: IIconProp list) = createElement (import "PositionToFrontRegular" FluentIcons) props
        static member inline powerFilled (props: IIconProp list) = createElement (import "PowerFilled" FluentIcons) props
        static member inline powerRegular (props: IIconProp list) = createElement (import "PowerRegular" FluentIcons) props
        static member inline predictionsFilled (props: IIconProp list) = createElement (import "PredictionsFilled" FluentIcons) props
        static member inline predictionsRegular (props: IIconProp list) = createElement (import "PredictionsRegular" FluentIcons) props
        static member inline premiumFilled (props: IIconProp list) = createElement (import "PremiumFilled" FluentIcons) props
        static member inline premiumRegular (props: IIconProp list) = createElement (import "PremiumRegular" FluentIcons) props
        static member inline premiumPersonFilled (props: IIconProp list) = createElement (import "PremiumPersonFilled" FluentIcons) props
        static member inline premiumPersonRegular (props: IIconProp list) = createElement (import "PremiumPersonRegular" FluentIcons) props
        static member inline presenceAvailableFilled (props: IIconProp list) = createElement (import "PresenceAvailableFilled" FluentIcons) props
        static member inline presenceAvailableRegular (props: IIconProp list) = createElement (import "PresenceAvailableRegular" FluentIcons) props
        static member inline presenceAwayFilled (props: IIconProp list) = createElement (import "PresenceAwayFilled" FluentIcons) props
        static member inline presenceAwayRegular (props: IIconProp list) = createElement (import "PresenceAwayRegular" FluentIcons) props
        static member inline presenceBlockedRegular (props: IIconProp list) = createElement (import "PresenceBlockedRegular" FluentIcons) props
        static member inline presenceBusyFilled (props: IIconProp list) = createElement (import "PresenceBusyFilled" FluentIcons) props
        static member inline presenceDndFilled (props: IIconProp list) = createElement (import "PresenceDndFilled" FluentIcons) props
        static member inline presenceDndRegular (props: IIconProp list) = createElement (import "PresenceDndRegular" FluentIcons) props
        static member inline presenceOfflineRegular (props: IIconProp list) = createElement (import "PresenceOfflineRegular" FluentIcons) props
        static member inline presenceOofRegular (props: IIconProp list) = createElement (import "PresenceOofRegular" FluentIcons) props
        static member inline presenceUnknownRegular (props: IIconProp list) = createElement (import "PresenceUnknownRegular" FluentIcons) props
        static member inline presenterFilled (props: IIconProp list) = createElement (import "PresenterFilled" FluentIcons) props
        static member inline presenterRegular (props: IIconProp list) = createElement (import "PresenterRegular" FluentIcons) props
        static member inline presenterOffFilled (props: IIconProp list) = createElement (import "PresenterOffFilled" FluentIcons) props
        static member inline presenterOffRegular (props: IIconProp list) = createElement (import "PresenterOffRegular" FluentIcons) props
        static member inline previewLinkFilled (props: IIconProp list) = createElement (import "PreviewLinkFilled" FluentIcons) props
        static member inline previewLinkRegular (props: IIconProp list) = createElement (import "PreviewLinkRegular" FluentIcons) props
        static member inline previousFilled (props: IIconProp list) = createElement (import "PreviousFilled" FluentIcons) props
        static member inline previousRegular (props: IIconProp list) = createElement (import "PreviousRegular" FluentIcons) props
        static member inline previousFrameFilled (props: IIconProp list) = createElement (import "PreviousFrameFilled" FluentIcons) props
        static member inline previousFrameRegular (props: IIconProp list) = createElement (import "PreviousFrameRegular" FluentIcons) props
        static member inline printFilled (props: IIconProp list) = createElement (import "PrintFilled" FluentIcons) props
        static member inline printRegular (props: IIconProp list) = createElement (import "PrintRegular" FluentIcons) props
        static member inline printAddFilled (props: IIconProp list) = createElement (import "PrintAddFilled" FluentIcons) props
        static member inline printAddRegular (props: IIconProp list) = createElement (import "PrintAddRegular" FluentIcons) props
        static member inline productionFilled (props: IIconProp list) = createElement (import "ProductionFilled" FluentIcons) props
        static member inline productionRegular (props: IIconProp list) = createElement (import "ProductionRegular" FluentIcons) props
        static member inline productionCheckmarkFilled (props: IIconProp list) = createElement (import "ProductionCheckmarkFilled" FluentIcons) props
        static member inline productionCheckmarkRegular (props: IIconProp list) = createElement (import "ProductionCheckmarkRegular" FluentIcons) props
        static member inline prohibitedFilled (props: IIconProp list) = createElement (import "ProhibitedFilled" FluentIcons) props
        static member inline prohibitedRegular (props: IIconProp list) = createElement (import "ProhibitedRegular" FluentIcons) props
        static member inline prohibitedMultipleFilled (props: IIconProp list) = createElement (import "ProhibitedMultipleFilled" FluentIcons) props
        static member inline prohibitedMultipleRegular (props: IIconProp list) = createElement (import "ProhibitedMultipleRegular" FluentIcons) props
        static member inline prohibitedNoteFilled (props: IIconProp list) = createElement (import "ProhibitedNoteFilled" FluentIcons) props
        static member inline prohibitedNoteRegular (props: IIconProp list) = createElement (import "ProhibitedNoteRegular" FluentIcons) props
        static member inline projectionScreenFilled (props: IIconProp list) = createElement (import "ProjectionScreenFilled" FluentIcons) props
        static member inline projectionScreenRegular (props: IIconProp list) = createElement (import "ProjectionScreenRegular" FluentIcons) props
        static member inline projectionScreenDismissFilled (props: IIconProp list) = createElement (import "ProjectionScreenDismissFilled" FluentIcons) props
        static member inline projectionScreenDismissRegular (props: IIconProp list) = createElement (import "ProjectionScreenDismissRegular" FluentIcons) props
        static member inline projectionScreenTextFilled (props: IIconProp list) = createElement (import "ProjectionScreenTextFilled" FluentIcons) props
        static member inline projectionScreenTextRegular (props: IIconProp list) = createElement (import "ProjectionScreenTextRegular" FluentIcons) props
        static member inline promptFilled (props: IIconProp list) = createElement (import "PromptFilled" FluentIcons) props
        static member inline promptRegular (props: IIconProp list) = createElement (import "PromptRegular" FluentIcons) props
        static member inline protocolHandlerFilled (props: IIconProp list) = createElement (import "ProtocolHandlerFilled" FluentIcons) props
        static member inline protocolHandlerRegular (props: IIconProp list) = createElement (import "ProtocolHandlerRegular" FluentIcons) props
        static member inline pulseFilled (props: IIconProp list) = createElement (import "PulseFilled" FluentIcons) props
        static member inline pulseRegular (props: IIconProp list) = createElement (import "PulseRegular" FluentIcons) props
        static member inline pulseSquareFilled (props: IIconProp list) = createElement (import "PulseSquareFilled" FluentIcons) props
        static member inline pulseSquareRegular (props: IIconProp list) = createElement (import "PulseSquareRegular" FluentIcons) props
        static member inline puzzleCubeFilled (props: IIconProp list) = createElement (import "PuzzleCubeFilled" FluentIcons) props
        static member inline puzzleCubeRegular (props: IIconProp list) = createElement (import "PuzzleCubeRegular" FluentIcons) props
        static member inline puzzleCubePieceFilled (props: IIconProp list) = createElement (import "PuzzleCubePieceFilled" FluentIcons) props
        static member inline puzzleCubePieceRegular (props: IIconProp list) = createElement (import "PuzzleCubePieceRegular" FluentIcons) props
        static member inline puzzlePieceFilled (props: IIconProp list) = createElement (import "PuzzlePieceFilled" FluentIcons) props
        static member inline puzzlePieceRegular (props: IIconProp list) = createElement (import "PuzzlePieceRegular" FluentIcons) props
        static member inline puzzlePieceShieldFilled (props: IIconProp list) = createElement (import "PuzzlePieceShieldFilled" FluentIcons) props
        static member inline puzzlePieceShieldRegular (props: IIconProp list) = createElement (import "PuzzlePieceShieldRegular" FluentIcons) props
        static member inline qrCodeFilled (props: IIconProp list) = createElement (import "QrCodeFilled" FluentIcons) props
        static member inline qrCodeRegular (props: IIconProp list) = createElement (import "QrCodeRegular" FluentIcons) props
        static member inline questionFilled (props: IIconProp list) = createElement (import "QuestionFilled" FluentIcons) props
        static member inline questionRegular (props: IIconProp list) = createElement (import "QuestionRegular" FluentIcons) props
        static member inline questionCircleFilled (props: IIconProp list) = createElement (import "QuestionCircleFilled" FluentIcons) props
        static member inline questionCircleRegular (props: IIconProp list) = createElement (import "QuestionCircleRegular" FluentIcons) props
        static member inline quizNewFilled (props: IIconProp list) = createElement (import "QuizNewFilled" FluentIcons) props
        static member inline quizNewRegular (props: IIconProp list) = createElement (import "QuizNewRegular" FluentIcons) props
        static member inline radarFilled (props: IIconProp list) = createElement (import "RadarFilled" FluentIcons) props
        static member inline radarRegular (props: IIconProp list) = createElement (import "RadarRegular" FluentIcons) props
        static member inline radarCheckmarkFilled (props: IIconProp list) = createElement (import "RadarCheckmarkFilled" FluentIcons) props
        static member inline radarCheckmarkRegular (props: IIconProp list) = createElement (import "RadarCheckmarkRegular" FluentIcons) props
        static member inline radarRectangleMultipleFilled (props: IIconProp list) = createElement (import "RadarRectangleMultipleFilled" FluentIcons) props
        static member inline radarRectangleMultipleRegular (props: IIconProp list) = createElement (import "RadarRectangleMultipleRegular" FluentIcons) props
        static member inline radioButtonFilled (props: IIconProp list) = createElement (import "RadioButtonFilled" FluentIcons) props
        static member inline radioButtonRegular (props: IIconProp list) = createElement (import "RadioButtonRegular" FluentIcons) props
        static member inline ramFilled (props: IIconProp list) = createElement (import "RamFilled" FluentIcons) props
        static member inline ramRegular (props: IIconProp list) = createElement (import "RamRegular" FluentIcons) props
        static member inline ratingMatureFilled (props: IIconProp list) = createElement (import "RatingMatureFilled" FluentIcons) props
        static member inline ratingMatureRegular (props: IIconProp list) = createElement (import "RatingMatureRegular" FluentIcons) props
        static member inline ratioOneToOneFilled (props: IIconProp list) = createElement (import "RatioOneToOneFilled" FluentIcons) props
        static member inline ratioOneToOneRegular (props: IIconProp list) = createElement (import "RatioOneToOneRegular" FluentIcons) props
        static member inline reOrderFilled (props: IIconProp list) = createElement (import "ReOrderFilled" FluentIcons) props
        static member inline reOrderRegular (props: IIconProp list) = createElement (import "ReOrderRegular" FluentIcons) props
        static member inline reOrderDotsHorizontalFilled (props: IIconProp list) = createElement (import "ReOrderDotsHorizontalFilled" FluentIcons) props
        static member inline reOrderDotsHorizontalRegular (props: IIconProp list) = createElement (import "ReOrderDotsHorizontalRegular" FluentIcons) props
        static member inline reOrderDotsVerticalFilled (props: IIconProp list) = createElement (import "ReOrderDotsVerticalFilled" FluentIcons) props
        static member inline reOrderDotsVerticalRegular (props: IIconProp list) = createElement (import "ReOrderDotsVerticalRegular" FluentIcons) props
        static member inline readAloudFilled (props: IIconProp list) = createElement (import "ReadAloudFilled" FluentIcons) props
        static member inline readAloudRegular (props: IIconProp list) = createElement (import "ReadAloudRegular" FluentIcons) props
        static member inline readingListFilled (props: IIconProp list) = createElement (import "ReadingListFilled" FluentIcons) props
        static member inline readingListRegular (props: IIconProp list) = createElement (import "ReadingListRegular" FluentIcons) props
        static member inline readingListAddFilled (props: IIconProp list) = createElement (import "ReadingListAddFilled" FluentIcons) props
        static member inline readingListAddRegular (props: IIconProp list) = createElement (import "ReadingListAddRegular" FluentIcons) props
        static member inline readingModeMobileFilled (props: IIconProp list) = createElement (import "ReadingModeMobileFilled" FluentIcons) props
        static member inline readingModeMobileRegular (props: IIconProp list) = createElement (import "ReadingModeMobileRegular" FluentIcons) props
        static member inline realEstateFilled (props: IIconProp list) = createElement (import "RealEstateFilled" FluentIcons) props
        static member inline realEstateRegular (props: IIconProp list) = createElement (import "RealEstateRegular" FluentIcons) props
        static member inline receiptFilled (props: IIconProp list) = createElement (import "ReceiptFilled" FluentIcons) props
        static member inline receiptRegular (props: IIconProp list) = createElement (import "ReceiptRegular" FluentIcons) props
        static member inline receiptAddFilled (props: IIconProp list) = createElement (import "ReceiptAddFilled" FluentIcons) props
        static member inline receiptAddRegular (props: IIconProp list) = createElement (import "ReceiptAddRegular" FluentIcons) props
        static member inline receiptBagFilled (props: IIconProp list) = createElement (import "ReceiptBagFilled" FluentIcons) props
        static member inline receiptBagRegular (props: IIconProp list) = createElement (import "ReceiptBagRegular" FluentIcons) props
        static member inline receiptCubeFilled (props: IIconProp list) = createElement (import "ReceiptCubeFilled" FluentIcons) props
        static member inline receiptCubeRegular (props: IIconProp list) = createElement (import "ReceiptCubeRegular" FluentIcons) props
        static member inline receiptMoneyFilled (props: IIconProp list) = createElement (import "ReceiptMoneyFilled" FluentIcons) props
        static member inline receiptMoneyRegular (props: IIconProp list) = createElement (import "ReceiptMoneyRegular" FluentIcons) props
        static member inline receiptPlayFilled (props: IIconProp list) = createElement (import "ReceiptPlayFilled" FluentIcons) props
        static member inline receiptPlayRegular (props: IIconProp list) = createElement (import "ReceiptPlayRegular" FluentIcons) props
        static member inline receiptSearchFilled (props: IIconProp list) = createElement (import "ReceiptSearchFilled" FluentIcons) props
        static member inline receiptSearchRegular (props: IIconProp list) = createElement (import "ReceiptSearchRegular" FluentIcons) props
        static member inline receiptSparklesFilled (props: IIconProp list) = createElement (import "ReceiptSparklesFilled" FluentIcons) props
        static member inline receiptSparklesRegular (props: IIconProp list) = createElement (import "ReceiptSparklesRegular" FluentIcons) props
        static member inline recordFilled (props: IIconProp list) = createElement (import "RecordFilled" FluentIcons) props
        static member inline recordRegular (props: IIconProp list) = createElement (import "RecordRegular" FluentIcons) props
        static member inline recordStopFilled (props: IIconProp list) = createElement (import "RecordStopFilled" FluentIcons) props
        static member inline recordStopRegular (props: IIconProp list) = createElement (import "RecordStopRegular" FluentIcons) props
        static member inline rectangleLandscapeFilled (props: IIconProp list) = createElement (import "RectangleLandscapeFilled" FluentIcons) props
        static member inline rectangleLandscapeRegular (props: IIconProp list) = createElement (import "RectangleLandscapeRegular" FluentIcons) props
        static member inline rectangleLandscapeHintCopyFilled (props: IIconProp list) = createElement (import "RectangleLandscapeHintCopyFilled" FluentIcons) props
        static member inline rectangleLandscapeHintCopyRegular (props: IIconProp list) = createElement (import "RectangleLandscapeHintCopyRegular" FluentIcons) props
        static member inline rectangleLandscapeSparkleFilled (props: IIconProp list) = createElement (import "RectangleLandscapeSparkleFilled" FluentIcons) props
        static member inline rectangleLandscapeSparkleRegular (props: IIconProp list) = createElement (import "RectangleLandscapeSparkleRegular" FluentIcons) props
        static member inline rectangleLandscapeSyncFilled (props: IIconProp list) = createElement (import "RectangleLandscapeSyncFilled" FluentIcons) props
        static member inline rectangleLandscapeSyncRegular (props: IIconProp list) = createElement (import "RectangleLandscapeSyncRegular" FluentIcons) props
        static member inline rectangleLandscapeSyncOffFilled (props: IIconProp list) = createElement (import "RectangleLandscapeSyncOffFilled" FluentIcons) props
        static member inline rectangleLandscapeSyncOffRegular (props: IIconProp list) = createElement (import "RectangleLandscapeSyncOffRegular" FluentIcons) props
        static member inline rectanglePortraitLocationTargetFilled (props: IIconProp list) = createElement (import "RectanglePortraitLocationTargetFilled" FluentIcons) props
        static member inline rectanglePortraitLocationTargetRegular (props: IIconProp list) = createElement (import "RectanglePortraitLocationTargetRegular" FluentIcons) props
        static member inline recycleFilled (props: IIconProp list) = createElement (import "RecycleFilled" FluentIcons) props
        static member inline recycleRegular (props: IIconProp list) = createElement (import "RecycleRegular" FluentIcons) props
        static member inline remixAddFilled (props: IIconProp list) = createElement (import "RemixAddFilled" FluentIcons) props
        static member inline remixAddRegular (props: IIconProp list) = createElement (import "RemixAddRegular" FluentIcons) props
        static member inline remoteFilled (props: IIconProp list) = createElement (import "RemoteFilled" FluentIcons) props
        static member inline remoteRegular (props: IIconProp list) = createElement (import "RemoteRegular" FluentIcons) props
        static member inline renameFilled (props: IIconProp list) = createElement (import "RenameFilled" FluentIcons) props
        static member inline renameRegular (props: IIconProp list) = createElement (import "RenameRegular" FluentIcons) props
        static member inline reorderFilled (props: IIconProp list) = createElement (import "ReorderFilled" FluentIcons) props
        static member inline reorderRegular (props: IIconProp list) = createElement (import "ReorderRegular" FluentIcons) props
        static member inline replayFilled (props: IIconProp list) = createElement (import "ReplayFilled" FluentIcons) props
        static member inline replayRegular (props: IIconProp list) = createElement (import "ReplayRegular" FluentIcons) props
        static member inline resizeFilled (props: IIconProp list) = createElement (import "ResizeFilled" FluentIcons) props
        static member inline resizeRegular (props: IIconProp list) = createElement (import "ResizeRegular" FluentIcons) props
        static member inline resizeImageFilled (props: IIconProp list) = createElement (import "ResizeImageFilled" FluentIcons) props
        static member inline resizeImageRegular (props: IIconProp list) = createElement (import "ResizeImageRegular" FluentIcons) props
        static member inline resizeLargeFilled (props: IIconProp list) = createElement (import "ResizeLargeFilled" FluentIcons) props
        static member inline resizeLargeRegular (props: IIconProp list) = createElement (import "ResizeLargeRegular" FluentIcons) props
        static member inline resizeSmallFilled (props: IIconProp list) = createElement (import "ResizeSmallFilled" FluentIcons) props
        static member inline resizeSmallRegular (props: IIconProp list) = createElement (import "ResizeSmallRegular" FluentIcons) props
        static member inline resizeTableFilled (props: IIconProp list) = createElement (import "ResizeTableFilled" FluentIcons) props
        static member inline resizeTableRegular (props: IIconProp list) = createElement (import "ResizeTableRegular" FluentIcons) props
        static member inline resizeVideoFilled (props: IIconProp list) = createElement (import "ResizeVideoFilled" FluentIcons) props
        static member inline resizeVideoRegular (props: IIconProp list) = createElement (import "ResizeVideoRegular" FluentIcons) props
        static member inline rewardFilled (props: IIconProp list) = createElement (import "RewardFilled" FluentIcons) props
        static member inline rewardRegular (props: IIconProp list) = createElement (import "RewardRegular" FluentIcons) props
        static member inline rewindFilled (props: IIconProp list) = createElement (import "RewindFilled" FluentIcons) props
        static member inline rewindRegular (props: IIconProp list) = createElement (import "RewindRegular" FluentIcons) props
        static member inline rhombusFilled (props: IIconProp list) = createElement (import "RhombusFilled" FluentIcons) props
        static member inline rhombusRegular (props: IIconProp list) = createElement (import "RhombusRegular" FluentIcons) props
        static member inline ribbonFilled (props: IIconProp list) = createElement (import "RibbonFilled" FluentIcons) props
        static member inline ribbonRegular (props: IIconProp list) = createElement (import "RibbonRegular" FluentIcons) props
        static member inline ribbonAddFilled (props: IIconProp list) = createElement (import "RibbonAddFilled" FluentIcons) props
        static member inline ribbonAddRegular (props: IIconProp list) = createElement (import "RibbonAddRegular" FluentIcons) props
        static member inline ribbonOffFilled (props: IIconProp list) = createElement (import "RibbonOffFilled" FluentIcons) props
        static member inline ribbonOffRegular (props: IIconProp list) = createElement (import "RibbonOffRegular" FluentIcons) props
        static member inline ribbonStarFilled (props: IIconProp list) = createElement (import "RibbonStarFilled" FluentIcons) props
        static member inline ribbonStarRegular (props: IIconProp list) = createElement (import "RibbonStarRegular" FluentIcons) props
        static member inline roadFilled (props: IIconProp list) = createElement (import "RoadFilled" FluentIcons) props
        static member inline roadRegular (props: IIconProp list) = createElement (import "RoadRegular" FluentIcons) props
        static member inline roadConeFilled (props: IIconProp list) = createElement (import "RoadConeFilled" FluentIcons) props
        static member inline roadConeRegular (props: IIconProp list) = createElement (import "RoadConeRegular" FluentIcons) props
        static member inline rocketFilled (props: IIconProp list) = createElement (import "RocketFilled" FluentIcons) props
        static member inline rocketRegular (props: IIconProp list) = createElement (import "RocketRegular" FluentIcons) props
        static member inline rotateLeftFilled (props: IIconProp list) = createElement (import "RotateLeftFilled" FluentIcons) props
        static member inline rotateLeftRegular (props: IIconProp list) = createElement (import "RotateLeftRegular" FluentIcons) props
        static member inline rotateRightFilled (props: IIconProp list) = createElement (import "RotateRightFilled" FluentIcons) props
        static member inline rotateRightRegular (props: IIconProp list) = createElement (import "RotateRightRegular" FluentIcons) props
        static member inline routerFilled (props: IIconProp list) = createElement (import "RouterFilled" FluentIcons) props
        static member inline routerRegular (props: IIconProp list) = createElement (import "RouterRegular" FluentIcons) props
        static member inline rowTripleFilled (props: IIconProp list) = createElement (import "RowTripleFilled" FluentIcons) props
        static member inline rowTripleRegular (props: IIconProp list) = createElement (import "RowTripleRegular" FluentIcons) props
        static member inline rssFilled (props: IIconProp list) = createElement (import "RssFilled" FluentIcons) props
        static member inline rssRegular (props: IIconProp list) = createElement (import "RssRegular" FluentIcons) props
        static member inline rulerFilled (props: IIconProp list) = createElement (import "RulerFilled" FluentIcons) props
        static member inline rulerRegular (props: IIconProp list) = createElement (import "RulerRegular" FluentIcons) props
        static member inline runFilled (props: IIconProp list) = createElement (import "RunFilled" FluentIcons) props
        static member inline runRegular (props: IIconProp list) = createElement (import "RunRegular" FluentIcons) props
        static member inline sanitizeFilled (props: IIconProp list) = createElement (import "SanitizeFilled" FluentIcons) props
        static member inline sanitizeRegular (props: IIconProp list) = createElement (import "SanitizeRegular" FluentIcons) props
        static member inline saveFilled (props: IIconProp list) = createElement (import "SaveFilled" FluentIcons) props
        static member inline saveRegular (props: IIconProp list) = createElement (import "SaveRegular" FluentIcons) props
        static member inline saveArrowRightFilled (props: IIconProp list) = createElement (import "SaveArrowRightFilled" FluentIcons) props
        static member inline saveArrowRightRegular (props: IIconProp list) = createElement (import "SaveArrowRightRegular" FluentIcons) props
        static member inline saveCopyFilled (props: IIconProp list) = createElement (import "SaveCopyFilled" FluentIcons) props
        static member inline saveCopyRegular (props: IIconProp list) = createElement (import "SaveCopyRegular" FluentIcons) props
        static member inline saveEditFilled (props: IIconProp list) = createElement (import "SaveEditFilled" FluentIcons) props
        static member inline saveEditRegular (props: IIconProp list) = createElement (import "SaveEditRegular" FluentIcons) props
        static member inline saveImageFilled (props: IIconProp list) = createElement (import "SaveImageFilled" FluentIcons) props
        static member inline saveImageRegular (props: IIconProp list) = createElement (import "SaveImageRegular" FluentIcons) props
        static member inline saveMultipleFilled (props: IIconProp list) = createElement (import "SaveMultipleFilled" FluentIcons) props
        static member inline saveMultipleRegular (props: IIconProp list) = createElement (import "SaveMultipleRegular" FluentIcons) props
        static member inline saveSearchFilled (props: IIconProp list) = createElement (import "SaveSearchFilled" FluentIcons) props
        static member inline saveSearchRegular (props: IIconProp list) = createElement (import "SaveSearchRegular" FluentIcons) props
        static member inline saveSyncFilled (props: IIconProp list) = createElement (import "SaveSyncFilled" FluentIcons) props
        static member inline saveSyncRegular (props: IIconProp list) = createElement (import "SaveSyncRegular" FluentIcons) props
        static member inline savingsFilled (props: IIconProp list) = createElement (import "SavingsFilled" FluentIcons) props
        static member inline savingsRegular (props: IIconProp list) = createElement (import "SavingsRegular" FluentIcons) props
        static member inline scaleFillFilled (props: IIconProp list) = createElement (import "ScaleFillFilled" FluentIcons) props
        static member inline scaleFillRegular (props: IIconProp list) = createElement (import "ScaleFillRegular" FluentIcons) props
        static member inline scaleFitFilled (props: IIconProp list) = createElement (import "ScaleFitFilled" FluentIcons) props
        static member inline scaleFitRegular (props: IIconProp list) = createElement (import "ScaleFitRegular" FluentIcons) props
        static member inline scalesFilled (props: IIconProp list) = createElement (import "ScalesFilled" FluentIcons) props
        static member inline scalesRegular (props: IIconProp list) = createElement (import "ScalesRegular" FluentIcons) props
        static member inline scanFilled (props: IIconProp list) = createElement (import "ScanFilled" FluentIcons) props
        static member inline scanRegular (props: IIconProp list) = createElement (import "ScanRegular" FluentIcons) props
        static member inline scanCameraFilled (props: IIconProp list) = createElement (import "ScanCameraFilled" FluentIcons) props
        static member inline scanCameraRegular (props: IIconProp list) = createElement (import "ScanCameraRegular" FluentIcons) props
        static member inline scanDashFilled (props: IIconProp list) = createElement (import "ScanDashFilled" FluentIcons) props
        static member inline scanDashRegular (props: IIconProp list) = createElement (import "ScanDashRegular" FluentIcons) props
        static member inline scanObjectFilled (props: IIconProp list) = createElement (import "ScanObjectFilled" FluentIcons) props
        static member inline scanObjectRegular (props: IIconProp list) = createElement (import "ScanObjectRegular" FluentIcons) props
        static member inline scanPersonFilled (props: IIconProp list) = createElement (import "ScanPersonFilled" FluentIcons) props
        static member inline scanPersonRegular (props: IIconProp list) = createElement (import "ScanPersonRegular" FluentIcons) props
        static member inline scanTableFilled (props: IIconProp list) = createElement (import "ScanTableFilled" FluentIcons) props
        static member inline scanTableRegular (props: IIconProp list) = createElement (import "ScanTableRegular" FluentIcons) props
        static member inline scanTextFilled (props: IIconProp list) = createElement (import "ScanTextFilled" FluentIcons) props
        static member inline scanTextRegular (props: IIconProp list) = createElement (import "ScanTextRegular" FluentIcons) props
        static member inline scanThumbUpFilled (props: IIconProp list) = createElement (import "ScanThumbUpFilled" FluentIcons) props
        static member inline scanThumbUpRegular (props: IIconProp list) = createElement (import "ScanThumbUpRegular" FluentIcons) props
        static member inline scanThumbUpOffFilled (props: IIconProp list) = createElement (import "ScanThumbUpOffFilled" FluentIcons) props
        static member inline scanThumbUpOffRegular (props: IIconProp list) = createElement (import "ScanThumbUpOffRegular" FluentIcons) props
        static member inline scanTypeFilled (props: IIconProp list) = createElement (import "ScanTypeFilled" FluentIcons) props
        static member inline scanTypeRegular (props: IIconProp list) = createElement (import "ScanTypeRegular" FluentIcons) props
        static member inline scanTypeCheckmarkFilled (props: IIconProp list) = createElement (import "ScanTypeCheckmarkFilled" FluentIcons) props
        static member inline scanTypeCheckmarkRegular (props: IIconProp list) = createElement (import "ScanTypeCheckmarkRegular" FluentIcons) props
        static member inline scanTypeOffFilled (props: IIconProp list) = createElement (import "ScanTypeOffFilled" FluentIcons) props
        static member inline scanTypeOffRegular (props: IIconProp list) = createElement (import "ScanTypeOffRegular" FluentIcons) props
        static member inline scratchpadFilled (props: IIconProp list) = createElement (import "ScratchpadFilled" FluentIcons) props
        static member inline scratchpadRegular (props: IIconProp list) = createElement (import "ScratchpadRegular" FluentIcons) props
        static member inline screenCutFilled (props: IIconProp list) = createElement (import "ScreenCutFilled" FluentIcons) props
        static member inline screenCutRegular (props: IIconProp list) = createElement (import "ScreenCutRegular" FluentIcons) props
        static member inline screenPersonFilled (props: IIconProp list) = createElement (import "ScreenPersonFilled" FluentIcons) props
        static member inline screenPersonRegular (props: IIconProp list) = createElement (import "ScreenPersonRegular" FluentIcons) props
        static member inline screenSearchFilled (props: IIconProp list) = createElement (import "ScreenSearchFilled" FluentIcons) props
        static member inline screenSearchRegular (props: IIconProp list) = createElement (import "ScreenSearchRegular" FluentIcons) props
        static member inline screenshotFilled (props: IIconProp list) = createElement (import "ScreenshotFilled" FluentIcons) props
        static member inline screenshotRegular (props: IIconProp list) = createElement (import "ScreenshotRegular" FluentIcons) props
        static member inline screenshotRecordFilled (props: IIconProp list) = createElement (import "ScreenshotRecordFilled" FluentIcons) props
        static member inline screenshotRecordRegular (props: IIconProp list) = createElement (import "ScreenshotRecordRegular" FluentIcons) props
        static member inline scriptFilled (props: IIconProp list) = createElement (import "ScriptFilled" FluentIcons) props
        static member inline scriptRegular (props: IIconProp list) = createElement (import "ScriptRegular" FluentIcons) props
        static member inline searchFilled (props: IIconProp list) = createElement (import "SearchFilled" FluentIcons) props
        static member inline searchRegular (props: IIconProp list) = createElement (import "SearchRegular" FluentIcons) props
        static member inline searchInfoFilled (props: IIconProp list) = createElement (import "SearchInfoFilled" FluentIcons) props
        static member inline searchInfoRegular (props: IIconProp list) = createElement (import "SearchInfoRegular" FluentIcons) props
        static member inline searchSettingsFilled (props: IIconProp list) = createElement (import "SearchSettingsFilled" FluentIcons) props
        static member inline searchSettingsRegular (props: IIconProp list) = createElement (import "SearchSettingsRegular" FluentIcons) props
        static member inline searchShieldFilled (props: IIconProp list) = createElement (import "SearchShieldFilled" FluentIcons) props
        static member inline searchShieldRegular (props: IIconProp list) = createElement (import "SearchShieldRegular" FluentIcons) props
        static member inline searchSparkleFilled (props: IIconProp list) = createElement (import "SearchSparkleFilled" FluentIcons) props
        static member inline searchSparkleRegular (props: IIconProp list) = createElement (import "SearchSparkleRegular" FluentIcons) props
        static member inline searchSquareFilled (props: IIconProp list) = createElement (import "SearchSquareFilled" FluentIcons) props
        static member inline searchSquareRegular (props: IIconProp list) = createElement (import "SearchSquareRegular" FluentIcons) props
        static member inline searchVisualFilled (props: IIconProp list) = createElement (import "SearchVisualFilled" FluentIcons) props
        static member inline searchVisualRegular (props: IIconProp list) = createElement (import "SearchVisualRegular" FluentIcons) props
        static member inline seatFilled (props: IIconProp list) = createElement (import "SeatFilled" FluentIcons) props
        static member inline seatRegular (props: IIconProp list) = createElement (import "SeatRegular" FluentIcons) props
        static member inline seatAddFilled (props: IIconProp list) = createElement (import "SeatAddFilled" FluentIcons) props
        static member inline seatAddRegular (props: IIconProp list) = createElement (import "SeatAddRegular" FluentIcons) props
        static member inline selectAllOffFilled (props: IIconProp list) = createElement (import "SelectAllOffFilled" FluentIcons) props
        static member inline selectAllOffRegular (props: IIconProp list) = createElement (import "SelectAllOffRegular" FluentIcons) props
        static member inline selectAllOnFilled (props: IIconProp list) = createElement (import "SelectAllOnFilled" FluentIcons) props
        static member inline selectAllOnRegular (props: IIconProp list) = createElement (import "SelectAllOnRegular" FluentIcons) props
        static member inline selectObjectFilled (props: IIconProp list) = createElement (import "SelectObjectFilled" FluentIcons) props
        static member inline selectObjectRegular (props: IIconProp list) = createElement (import "SelectObjectRegular" FluentIcons) props
        static member inline selectObjectSkewFilled (props: IIconProp list) = createElement (import "SelectObjectSkewFilled" FluentIcons) props
        static member inline selectObjectSkewRegular (props: IIconProp list) = createElement (import "SelectObjectSkewRegular" FluentIcons) props
        static member inline selectObjectSkewDismissFilled (props: IIconProp list) = createElement (import "SelectObjectSkewDismissFilled" FluentIcons) props
        static member inline selectObjectSkewDismissRegular (props: IIconProp list) = createElement (import "SelectObjectSkewDismissRegular" FluentIcons) props
        static member inline selectObjectSkewEditFilled (props: IIconProp list) = createElement (import "SelectObjectSkewEditFilled" FluentIcons) props
        static member inline selectObjectSkewEditRegular (props: IIconProp list) = createElement (import "SelectObjectSkewEditRegular" FluentIcons) props
        static member inline sendFilled (props: IIconProp list) = createElement (import "SendFilled" FluentIcons) props
        static member inline sendRegular (props: IIconProp list) = createElement (import "SendRegular" FluentIcons) props
        static member inline sendBeakerFilled (props: IIconProp list) = createElement (import "SendBeakerFilled" FluentIcons) props
        static member inline sendBeakerRegular (props: IIconProp list) = createElement (import "SendBeakerRegular" FluentIcons) props
        static member inline sendClockFilled (props: IIconProp list) = createElement (import "SendClockFilled" FluentIcons) props
        static member inline sendClockRegular (props: IIconProp list) = createElement (import "SendClockRegular" FluentIcons) props
        static member inline sendCopyFilled (props: IIconProp list) = createElement (import "SendCopyFilled" FluentIcons) props
        static member inline sendCopyRegular (props: IIconProp list) = createElement (import "SendCopyRegular" FluentIcons) props
        static member inline sendPersonFilled (props: IIconProp list) = createElement (import "SendPersonFilled" FluentIcons) props
        static member inline sendPersonRegular (props: IIconProp list) = createElement (import "SendPersonRegular" FluentIcons) props
        static member inline serialPortFilled (props: IIconProp list) = createElement (import "SerialPortFilled" FluentIcons) props
        static member inline serialPortRegular (props: IIconProp list) = createElement (import "SerialPortRegular" FluentIcons) props
        static member inline serverFilled (props: IIconProp list) = createElement (import "ServerFilled" FluentIcons) props
        static member inline serverRegular (props: IIconProp list) = createElement (import "ServerRegular" FluentIcons) props
        static member inline serverLinkFilled (props: IIconProp list) = createElement (import "ServerLinkFilled" FluentIcons) props
        static member inline serverLinkRegular (props: IIconProp list) = createElement (import "ServerLinkRegular" FluentIcons) props
        static member inline serverMultipleFilled (props: IIconProp list) = createElement (import "ServerMultipleFilled" FluentIcons) props
        static member inline serverMultipleRegular (props: IIconProp list) = createElement (import "ServerMultipleRegular" FluentIcons) props
        static member inline serverPlayFilled (props: IIconProp list) = createElement (import "ServerPlayFilled" FluentIcons) props
        static member inline serverPlayRegular (props: IIconProp list) = createElement (import "ServerPlayRegular" FluentIcons) props
        static member inline serviceBellFilled (props: IIconProp list) = createElement (import "ServiceBellFilled" FluentIcons) props
        static member inline serviceBellRegular (props: IIconProp list) = createElement (import "ServiceBellRegular" FluentIcons) props
        static member inline settingsFilled (props: IIconProp list) = createElement (import "SettingsFilled" FluentIcons) props
        static member inline settingsRegular (props: IIconProp list) = createElement (import "SettingsRegular" FluentIcons) props
        static member inline settingsChatFilled (props: IIconProp list) = createElement (import "SettingsChatFilled" FluentIcons) props
        static member inline settingsChatRegular (props: IIconProp list) = createElement (import "SettingsChatRegular" FluentIcons) props
        static member inline settingsCogMultipleFilled (props: IIconProp list) = createElement (import "SettingsCogMultipleFilled" FluentIcons) props
        static member inline settingsCogMultipleRegular (props: IIconProp list) = createElement (import "SettingsCogMultipleRegular" FluentIcons) props
        static member inline shapeExcludeFilled (props: IIconProp list) = createElement (import "ShapeExcludeFilled" FluentIcons) props
        static member inline shapeExcludeRegular (props: IIconProp list) = createElement (import "ShapeExcludeRegular" FluentIcons) props
        static member inline shapeIntersectFilled (props: IIconProp list) = createElement (import "ShapeIntersectFilled" FluentIcons) props
        static member inline shapeIntersectRegular (props: IIconProp list) = createElement (import "ShapeIntersectRegular" FluentIcons) props
        static member inline shapeOrganicFilled (props: IIconProp list) = createElement (import "ShapeOrganicFilled" FluentIcons) props
        static member inline shapeOrganicRegular (props: IIconProp list) = createElement (import "ShapeOrganicRegular" FluentIcons) props
        static member inline shapeSubtractFilled (props: IIconProp list) = createElement (import "ShapeSubtractFilled" FluentIcons) props
        static member inline shapeSubtractRegular (props: IIconProp list) = createElement (import "ShapeSubtractRegular" FluentIcons) props
        static member inline shapeUnionFilled (props: IIconProp list) = createElement (import "ShapeUnionFilled" FluentIcons) props
        static member inline shapeUnionRegular (props: IIconProp list) = createElement (import "ShapeUnionRegular" FluentIcons) props
        static member inline shapesFilled (props: IIconProp list) = createElement (import "ShapesFilled" FluentIcons) props
        static member inline shapesRegular (props: IIconProp list) = createElement (import "ShapesRegular" FluentIcons) props
        static member inline shareFilled (props: IIconProp list) = createElement (import "ShareFilled" FluentIcons) props
        static member inline shareRegular (props: IIconProp list) = createElement (import "ShareRegular" FluentIcons) props
        static member inline shareAndroidFilled (props: IIconProp list) = createElement (import "ShareAndroidFilled" FluentIcons) props
        static member inline shareAndroidRegular (props: IIconProp list) = createElement (import "ShareAndroidRegular" FluentIcons) props
        static member inline shareCloseTrayFilled (props: IIconProp list) = createElement (import "ShareCloseTrayFilled" FluentIcons) props
        static member inline shareCloseTrayRegular (props: IIconProp list) = createElement (import "ShareCloseTrayRegular" FluentIcons) props
        static member inline shareIosFilled (props: IIconProp list) = createElement (import "ShareIosFilled" FluentIcons) props
        static member inline shareIosRegular (props: IIconProp list) = createElement (import "ShareIosRegular" FluentIcons) props
        static member inline shareMultipleFilled (props: IIconProp list) = createElement (import "ShareMultipleFilled" FluentIcons) props
        static member inline shareMultipleRegular (props: IIconProp list) = createElement (import "ShareMultipleRegular" FluentIcons) props
        static member inline shareScreenPersonFilled (props: IIconProp list) = createElement (import "ShareScreenPersonFilled" FluentIcons) props
        static member inline shareScreenPersonRegular (props: IIconProp list) = createElement (import "ShareScreenPersonRegular" FluentIcons) props
        static member inline shareScreenPersonOverlayFilled (props: IIconProp list) = createElement (import "ShareScreenPersonOverlayFilled" FluentIcons) props
        static member inline shareScreenPersonOverlayRegular (props: IIconProp list) = createElement (import "ShareScreenPersonOverlayRegular" FluentIcons) props
        static member inline shareScreenPersonOverlayInsideFilled (props: IIconProp list) = createElement (import "ShareScreenPersonOverlayInsideFilled" FluentIcons) props
        static member inline shareScreenPersonOverlayInsideRegular (props: IIconProp list) = createElement (import "ShareScreenPersonOverlayInsideRegular" FluentIcons) props
        static member inline shareScreenPersonPFilled (props: IIconProp list) = createElement (import "ShareScreenPersonPFilled" FluentIcons) props
        static member inline shareScreenPersonPRegular (props: IIconProp list) = createElement (import "ShareScreenPersonPRegular" FluentIcons) props
        static member inline shareScreenStartFilled (props: IIconProp list) = createElement (import "ShareScreenStartFilled" FluentIcons) props
        static member inline shareScreenStartRegular (props: IIconProp list) = createElement (import "ShareScreenStartRegular" FluentIcons) props
        static member inline shareScreenStopFilled (props: IIconProp list) = createElement (import "ShareScreenStopFilled" FluentIcons) props
        static member inline shareScreenStopRegular (props: IIconProp list) = createElement (import "ShareScreenStopRegular" FluentIcons) props
        static member inline shieldFilled (props: IIconProp list) = createElement (import "ShieldFilled" FluentIcons) props
        static member inline shieldRegular (props: IIconProp list) = createElement (import "ShieldRegular" FluentIcons) props
        static member inline shieldAddFilled (props: IIconProp list) = createElement (import "ShieldAddFilled" FluentIcons) props
        static member inline shieldAddRegular (props: IIconProp list) = createElement (import "ShieldAddRegular" FluentIcons) props
        static member inline shieldBadgeFilled (props: IIconProp list) = createElement (import "ShieldBadgeFilled" FluentIcons) props
        static member inline shieldBadgeRegular (props: IIconProp list) = createElement (import "ShieldBadgeRegular" FluentIcons) props
        static member inline shieldCheckmarkFilled (props: IIconProp list) = createElement (import "ShieldCheckmarkFilled" FluentIcons) props
        static member inline shieldCheckmarkRegular (props: IIconProp list) = createElement (import "ShieldCheckmarkRegular" FluentIcons) props
        static member inline shieldDismissFilled (props: IIconProp list) = createElement (import "ShieldDismissFilled" FluentIcons) props
        static member inline shieldDismissRegular (props: IIconProp list) = createElement (import "ShieldDismissRegular" FluentIcons) props
        static member inline shieldDismissShieldFilled (props: IIconProp list) = createElement (import "ShieldDismissShieldFilled" FluentIcons) props
        static member inline shieldDismissShieldRegular (props: IIconProp list) = createElement (import "ShieldDismissShieldRegular" FluentIcons) props
        static member inline shieldErrorFilled (props: IIconProp list) = createElement (import "ShieldErrorFilled" FluentIcons) props
        static member inline shieldErrorRegular (props: IIconProp list) = createElement (import "ShieldErrorRegular" FluentIcons) props
        static member inline shieldGlobeFilled (props: IIconProp list) = createElement (import "ShieldGlobeFilled" FluentIcons) props
        static member inline shieldGlobeRegular (props: IIconProp list) = createElement (import "ShieldGlobeRegular" FluentIcons) props
        static member inline shieldKeyholeFilled (props: IIconProp list) = createElement (import "ShieldKeyholeFilled" FluentIcons) props
        static member inline shieldKeyholeRegular (props: IIconProp list) = createElement (import "ShieldKeyholeRegular" FluentIcons) props
        static member inline shieldLockFilled (props: IIconProp list) = createElement (import "ShieldLockFilled" FluentIcons) props
        static member inline shieldLockRegular (props: IIconProp list) = createElement (import "ShieldLockRegular" FluentIcons) props
        static member inline shieldPersonFilled (props: IIconProp list) = createElement (import "ShieldPersonFilled" FluentIcons) props
        static member inline shieldPersonRegular (props: IIconProp list) = createElement (import "ShieldPersonRegular" FluentIcons) props
        static member inline shieldPersonAddFilled (props: IIconProp list) = createElement (import "ShieldPersonAddFilled" FluentIcons) props
        static member inline shieldPersonAddRegular (props: IIconProp list) = createElement (import "ShieldPersonAddRegular" FluentIcons) props
        static member inline shieldProhibitedFilled (props: IIconProp list) = createElement (import "ShieldProhibitedFilled" FluentIcons) props
        static member inline shieldProhibitedRegular (props: IIconProp list) = createElement (import "ShieldProhibitedRegular" FluentIcons) props
        static member inline shieldQuestionFilled (props: IIconProp list) = createElement (import "ShieldQuestionFilled" FluentIcons) props
        static member inline shieldQuestionRegular (props: IIconProp list) = createElement (import "ShieldQuestionRegular" FluentIcons) props
        static member inline shieldTaskFilled (props: IIconProp list) = createElement (import "ShieldTaskFilled" FluentIcons) props
        static member inline shieldTaskRegular (props: IIconProp list) = createElement (import "ShieldTaskRegular" FluentIcons) props
        static member inline shiftsFilled (props: IIconProp list) = createElement (import "ShiftsFilled" FluentIcons) props
        static member inline shiftsRegular (props: IIconProp list) = createElement (import "ShiftsRegular" FluentIcons) props
        static member inline shifts30MinutesFilled (props: IIconProp list) = createElement (import "Shifts30MinutesFilled" FluentIcons) props
        static member inline shifts30MinutesRegular (props: IIconProp list) = createElement (import "Shifts30MinutesRegular" FluentIcons) props
        static member inline shiftsActivityFilled (props: IIconProp list) = createElement (import "ShiftsActivityFilled" FluentIcons) props
        static member inline shiftsActivityRegular (props: IIconProp list) = createElement (import "ShiftsActivityRegular" FluentIcons) props
        static member inline shiftsAddFilled (props: IIconProp list) = createElement (import "ShiftsAddFilled" FluentIcons) props
        static member inline shiftsAddRegular (props: IIconProp list) = createElement (import "ShiftsAddRegular" FluentIcons) props
        static member inline shiftsAvailabilityFilled (props: IIconProp list) = createElement (import "ShiftsAvailabilityFilled" FluentIcons) props
        static member inline shiftsAvailabilityRegular (props: IIconProp list) = createElement (import "ShiftsAvailabilityRegular" FluentIcons) props
        static member inline shiftsCheckmarkFilled (props: IIconProp list) = createElement (import "ShiftsCheckmarkFilled" FluentIcons) props
        static member inline shiftsCheckmarkRegular (props: IIconProp list) = createElement (import "ShiftsCheckmarkRegular" FluentIcons) props
        static member inline shiftsDayFilled (props: IIconProp list) = createElement (import "ShiftsDayFilled" FluentIcons) props
        static member inline shiftsDayRegular (props: IIconProp list) = createElement (import "ShiftsDayRegular" FluentIcons) props
        static member inline shiftsOpenFilled (props: IIconProp list) = createElement (import "ShiftsOpenFilled" FluentIcons) props
        static member inline shiftsOpenRegular (props: IIconProp list) = createElement (import "ShiftsOpenRegular" FluentIcons) props
        static member inline shiftsProhibitedFilled (props: IIconProp list) = createElement (import "ShiftsProhibitedFilled" FluentIcons) props
        static member inline shiftsProhibitedRegular (props: IIconProp list) = createElement (import "ShiftsProhibitedRegular" FluentIcons) props
        static member inline shiftsQuestionMarkFilled (props: IIconProp list) = createElement (import "ShiftsQuestionMarkFilled" FluentIcons) props
        static member inline shiftsQuestionMarkRegular (props: IIconProp list) = createElement (import "ShiftsQuestionMarkRegular" FluentIcons) props
        static member inline shiftsTeamFilled (props: IIconProp list) = createElement (import "ShiftsTeamFilled" FluentIcons) props
        static member inline shiftsTeamRegular (props: IIconProp list) = createElement (import "ShiftsTeamRegular" FluentIcons) props
        static member inline shoppingBagFilled (props: IIconProp list) = createElement (import "ShoppingBagFilled" FluentIcons) props
        static member inline shoppingBagRegular (props: IIconProp list) = createElement (import "ShoppingBagRegular" FluentIcons) props
        static member inline shoppingBagAddFilled (props: IIconProp list) = createElement (import "ShoppingBagAddFilled" FluentIcons) props
        static member inline shoppingBagAddRegular (props: IIconProp list) = createElement (import "ShoppingBagAddRegular" FluentIcons) props
        static member inline shoppingBagArrowLeftFilled (props: IIconProp list) = createElement (import "ShoppingBagArrowLeftFilled" FluentIcons) props
        static member inline shoppingBagArrowLeftRegular (props: IIconProp list) = createElement (import "ShoppingBagArrowLeftRegular" FluentIcons) props
        static member inline shoppingBagDismissFilled (props: IIconProp list) = createElement (import "ShoppingBagDismissFilled" FluentIcons) props
        static member inline shoppingBagDismissRegular (props: IIconProp list) = createElement (import "ShoppingBagDismissRegular" FluentIcons) props
        static member inline shoppingBagPauseFilled (props: IIconProp list) = createElement (import "ShoppingBagPauseFilled" FluentIcons) props
        static member inline shoppingBagPauseRegular (props: IIconProp list) = createElement (import "ShoppingBagPauseRegular" FluentIcons) props
        static member inline shoppingBagPercentFilled (props: IIconProp list) = createElement (import "ShoppingBagPercentFilled" FluentIcons) props
        static member inline shoppingBagPercentRegular (props: IIconProp list) = createElement (import "ShoppingBagPercentRegular" FluentIcons) props
        static member inline shoppingBagPlayFilled (props: IIconProp list) = createElement (import "ShoppingBagPlayFilled" FluentIcons) props
        static member inline shoppingBagPlayRegular (props: IIconProp list) = createElement (import "ShoppingBagPlayRegular" FluentIcons) props
        static member inline shoppingBagTagFilled (props: IIconProp list) = createElement (import "ShoppingBagTagFilled" FluentIcons) props
        static member inline shoppingBagTagRegular (props: IIconProp list) = createElement (import "ShoppingBagTagRegular" FluentIcons) props
        static member inline shortpickFilled (props: IIconProp list) = createElement (import "ShortpickFilled" FluentIcons) props
        static member inline shortpickRegular (props: IIconProp list) = createElement (import "ShortpickRegular" FluentIcons) props
        static member inline showerheadFilled (props: IIconProp list) = createElement (import "ShowerheadFilled" FluentIcons) props
        static member inline showerheadRegular (props: IIconProp list) = createElement (import "ShowerheadRegular" FluentIcons) props
        static member inline sidebarSearchLtrFilled (props: IIconProp list) = createElement (import "SidebarSearchLtrFilled" FluentIcons) props
        static member inline sidebarSearchLtrRegular (props: IIconProp list) = createElement (import "SidebarSearchLtrRegular" FluentIcons) props
        static member inline sidebarSearchRtlFilled (props: IIconProp list) = createElement (import "SidebarSearchRtlFilled" FluentIcons) props
        static member inline sidebarSearchRtlRegular (props: IIconProp list) = createElement (import "SidebarSearchRtlRegular" FluentIcons) props
        static member inline signOutFilled (props: IIconProp list) = createElement (import "SignOutFilled" FluentIcons) props
        static member inline signOutRegular (props: IIconProp list) = createElement (import "SignOutRegular" FluentIcons) props
        static member inline signatureFilled (props: IIconProp list) = createElement (import "SignatureFilled" FluentIcons) props
        static member inline signatureRegular (props: IIconProp list) = createElement (import "SignatureRegular" FluentIcons) props
        static member inline simFilled (props: IIconProp list) = createElement (import "SimFilled" FluentIcons) props
        static member inline simRegular (props: IIconProp list) = createElement (import "SimRegular" FluentIcons) props
        static member inline skipBack10Filled (props: IIconProp list) = createElement (import "SkipBack10Filled" FluentIcons) props
        static member inline skipBack10Regular (props: IIconProp list) = createElement (import "SkipBack10Regular" FluentIcons) props
        static member inline skipForward10Filled (props: IIconProp list) = createElement (import "SkipForward10Filled" FluentIcons) props
        static member inline skipForward10Regular (props: IIconProp list) = createElement (import "SkipForward10Regular" FluentIcons) props
        static member inline skipForward30Filled (props: IIconProp list) = createElement (import "SkipForward30Filled" FluentIcons) props
        static member inline skipForward30Regular (props: IIconProp list) = createElement (import "SkipForward30Regular" FluentIcons) props
        static member inline skipForwardTabFilled (props: IIconProp list) = createElement (import "SkipForwardTabFilled" FluentIcons) props
        static member inline skipForwardTabRegular (props: IIconProp list) = createElement (import "SkipForwardTabRegular" FluentIcons) props
        static member inline slashForwardFilled (props: IIconProp list) = createElement (import "SlashForwardFilled" FluentIcons) props
        static member inline slashForwardRegular (props: IIconProp list) = createElement (import "SlashForwardRegular" FluentIcons) props
        static member inline sleepFilled (props: IIconProp list) = createElement (import "SleepFilled" FluentIcons) props
        static member inline sleepRegular (props: IIconProp list) = createElement (import "SleepRegular" FluentIcons) props
        static member inline slideAddFilled (props: IIconProp list) = createElement (import "SlideAddFilled" FluentIcons) props
        static member inline slideAddRegular (props: IIconProp list) = createElement (import "SlideAddRegular" FluentIcons) props
        static member inline slideArrowRightFilled (props: IIconProp list) = createElement (import "SlideArrowRightFilled" FluentIcons) props
        static member inline slideArrowRightRegular (props: IIconProp list) = createElement (import "SlideArrowRightRegular" FluentIcons) props
        static member inline slideEraserFilled (props: IIconProp list) = createElement (import "SlideEraserFilled" FluentIcons) props
        static member inline slideEraserRegular (props: IIconProp list) = createElement (import "SlideEraserRegular" FluentIcons) props
        static member inline slideGridFilled (props: IIconProp list) = createElement (import "SlideGridFilled" FluentIcons) props
        static member inline slideGridRegular (props: IIconProp list) = createElement (import "SlideGridRegular" FluentIcons) props
        static member inline slideHideFilled (props: IIconProp list) = createElement (import "SlideHideFilled" FluentIcons) props
        static member inline slideHideRegular (props: IIconProp list) = createElement (import "SlideHideRegular" FluentIcons) props
        static member inline slideLayoutFilled (props: IIconProp list) = createElement (import "SlideLayoutFilled" FluentIcons) props
        static member inline slideLayoutRegular (props: IIconProp list) = createElement (import "SlideLayoutRegular" FluentIcons) props
        static member inline slideLinkFilled (props: IIconProp list) = createElement (import "SlideLinkFilled" FluentIcons) props
        static member inline slideLinkRegular (props: IIconProp list) = createElement (import "SlideLinkRegular" FluentIcons) props
        static member inline slideMicrophoneFilled (props: IIconProp list) = createElement (import "SlideMicrophoneFilled" FluentIcons) props
        static member inline slideMicrophoneRegular (props: IIconProp list) = createElement (import "SlideMicrophoneRegular" FluentIcons) props
        static member inline slideMultipleFilled (props: IIconProp list) = createElement (import "SlideMultipleFilled" FluentIcons) props
        static member inline slideMultipleRegular (props: IIconProp list) = createElement (import "SlideMultipleRegular" FluentIcons) props
        static member inline slideMultipleArrowRightFilled (props: IIconProp list) = createElement (import "SlideMultipleArrowRightFilled" FluentIcons) props
        static member inline slideMultipleArrowRightRegular (props: IIconProp list) = createElement (import "SlideMultipleArrowRightRegular" FluentIcons) props
        static member inline slideMultipleSearchFilled (props: IIconProp list) = createElement (import "SlideMultipleSearchFilled" FluentIcons) props
        static member inline slideMultipleSearchRegular (props: IIconProp list) = createElement (import "SlideMultipleSearchRegular" FluentIcons) props
        static member inline slidePlayFilled (props: IIconProp list) = createElement (import "SlidePlayFilled" FluentIcons) props
        static member inline slidePlayRegular (props: IIconProp list) = createElement (import "SlidePlayRegular" FluentIcons) props
        static member inline slideRecordFilled (props: IIconProp list) = createElement (import "SlideRecordFilled" FluentIcons) props
        static member inline slideRecordRegular (props: IIconProp list) = createElement (import "SlideRecordRegular" FluentIcons) props
        static member inline slideSearchFilled (props: IIconProp list) = createElement (import "SlideSearchFilled" FluentIcons) props
        static member inline slideSearchRegular (props: IIconProp list) = createElement (import "SlideSearchRegular" FluentIcons) props
        static member inline slideSettingsFilled (props: IIconProp list) = createElement (import "SlideSettingsFilled" FluentIcons) props
        static member inline slideSettingsRegular (props: IIconProp list) = createElement (import "SlideSettingsRegular" FluentIcons) props
        static member inline slideSizeFilled (props: IIconProp list) = createElement (import "SlideSizeFilled" FluentIcons) props
        static member inline slideSizeRegular (props: IIconProp list) = createElement (import "SlideSizeRegular" FluentIcons) props
        static member inline slideTextFilled (props: IIconProp list) = createElement (import "SlideTextFilled" FluentIcons) props
        static member inline slideTextRegular (props: IIconProp list) = createElement (import "SlideTextRegular" FluentIcons) props
        static member inline slideTextCallFilled (props: IIconProp list) = createElement (import "SlideTextCallFilled" FluentIcons) props
        static member inline slideTextCallRegular (props: IIconProp list) = createElement (import "SlideTextCallRegular" FluentIcons) props
        static member inline slideTextCursorFilled (props: IIconProp list) = createElement (import "SlideTextCursorFilled" FluentIcons) props
        static member inline slideTextCursorRegular (props: IIconProp list) = createElement (import "SlideTextCursorRegular" FluentIcons) props
        static member inline slideTextEditFilled (props: IIconProp list) = createElement (import "SlideTextEditFilled" FluentIcons) props
        static member inline slideTextEditRegular (props: IIconProp list) = createElement (import "SlideTextEditRegular" FluentIcons) props
        static member inline slideTextMultipleFilled (props: IIconProp list) = createElement (import "SlideTextMultipleFilled" FluentIcons) props
        static member inline slideTextMultipleRegular (props: IIconProp list) = createElement (import "SlideTextMultipleRegular" FluentIcons) props
        static member inline slideTextPersonFilled (props: IIconProp list) = createElement (import "SlideTextPersonFilled" FluentIcons) props
        static member inline slideTextPersonRegular (props: IIconProp list) = createElement (import "SlideTextPersonRegular" FluentIcons) props
        static member inline slideTextSparkleFilled (props: IIconProp list) = createElement (import "SlideTextSparkleFilled" FluentIcons) props
        static member inline slideTextSparkleRegular (props: IIconProp list) = createElement (import "SlideTextSparkleRegular" FluentIcons) props
        static member inline slideTransitionFilled (props: IIconProp list) = createElement (import "SlideTransitionFilled" FluentIcons) props
        static member inline slideTransitionRegular (props: IIconProp list) = createElement (import "SlideTransitionRegular" FluentIcons) props
        static member inline smartwatchFilled (props: IIconProp list) = createElement (import "SmartwatchFilled" FluentIcons) props
        static member inline smartwatchRegular (props: IIconProp list) = createElement (import "SmartwatchRegular" FluentIcons) props
        static member inline smartwatchDotFilled (props: IIconProp list) = createElement (import "SmartwatchDotFilled" FluentIcons) props
        static member inline smartwatchDotRegular (props: IIconProp list) = createElement (import "SmartwatchDotRegular" FluentIcons) props
        static member inline snoozeFilled (props: IIconProp list) = createElement (import "SnoozeFilled" FluentIcons) props
        static member inline snoozeRegular (props: IIconProp list) = createElement (import "SnoozeRegular" FluentIcons) props
        static member inline soundSourceFilled (props: IIconProp list) = createElement (import "SoundSourceFilled" FluentIcons) props
        static member inline soundSourceRegular (props: IIconProp list) = createElement (import "SoundSourceRegular" FluentIcons) props
        static member inline soundWaveCircleFilled (props: IIconProp list) = createElement (import "SoundWaveCircleFilled" FluentIcons) props
        static member inline soundWaveCircleRegular (props: IIconProp list) = createElement (import "SoundWaveCircleRegular" FluentIcons) props
        static member inline space3DFilled (props: IIconProp list) = createElement (import "Space3DFilled" FluentIcons) props
        static member inline space3DRegular (props: IIconProp list) = createElement (import "Space3DRegular" FluentIcons) props
        static member inline spacebarFilled (props: IIconProp list) = createElement (import "SpacebarFilled" FluentIcons) props
        static member inline spacebarRegular (props: IIconProp list) = createElement (import "SpacebarRegular" FluentIcons) props
        static member inline sparkleFilled (props: IIconProp list) = createElement (import "SparkleFilled" FluentIcons) props
        static member inline sparkleRegular (props: IIconProp list) = createElement (import "SparkleRegular" FluentIcons) props
        static member inline sparkleCircleFilled (props: IIconProp list) = createElement (import "SparkleCircleFilled" FluentIcons) props
        static member inline sparkleCircleRegular (props: IIconProp list) = createElement (import "SparkleCircleRegular" FluentIcons) props
        static member inline spatulaSpoonFilled (props: IIconProp list) = createElement (import "SpatulaSpoonFilled" FluentIcons) props
        static member inline spatulaSpoonRegular (props: IIconProp list) = createElement (import "SpatulaSpoonRegular" FluentIcons) props
        static member inline speaker0Filled (props: IIconProp list) = createElement (import "Speaker0Filled" FluentIcons) props
        static member inline speaker0Regular (props: IIconProp list) = createElement (import "Speaker0Regular" FluentIcons) props
        static member inline speaker1Filled (props: IIconProp list) = createElement (import "Speaker1Filled" FluentIcons) props
        static member inline speaker1Regular (props: IIconProp list) = createElement (import "Speaker1Regular" FluentIcons) props
        static member inline speaker2Filled (props: IIconProp list) = createElement (import "Speaker2Filled" FluentIcons) props
        static member inline speaker2Regular (props: IIconProp list) = createElement (import "Speaker2Regular" FluentIcons) props
        static member inline speakerBluetoothFilled (props: IIconProp list) = createElement (import "SpeakerBluetoothFilled" FluentIcons) props
        static member inline speakerBluetoothRegular (props: IIconProp list) = createElement (import "SpeakerBluetoothRegular" FluentIcons) props
        static member inline speakerBoxFilled (props: IIconProp list) = createElement (import "SpeakerBoxFilled" FluentIcons) props
        static member inline speakerBoxRegular (props: IIconProp list) = createElement (import "SpeakerBoxRegular" FluentIcons) props
        static member inline speakerEditFilled (props: IIconProp list) = createElement (import "SpeakerEditFilled" FluentIcons) props
        static member inline speakerEditRegular (props: IIconProp list) = createElement (import "SpeakerEditRegular" FluentIcons) props
        static member inline speakerMuteFilled (props: IIconProp list) = createElement (import "SpeakerMuteFilled" FluentIcons) props
        static member inline speakerMuteRegular (props: IIconProp list) = createElement (import "SpeakerMuteRegular" FluentIcons) props
        static member inline speakerOffFilled (props: IIconProp list) = createElement (import "SpeakerOffFilled" FluentIcons) props
        static member inline speakerOffRegular (props: IIconProp list) = createElement (import "SpeakerOffRegular" FluentIcons) props
        static member inline speakerSettingsFilled (props: IIconProp list) = createElement (import "SpeakerSettingsFilled" FluentIcons) props
        static member inline speakerSettingsRegular (props: IIconProp list) = createElement (import "SpeakerSettingsRegular" FluentIcons) props
        static member inline speakerUsbFilled (props: IIconProp list) = createElement (import "SpeakerUsbFilled" FluentIcons) props
        static member inline speakerUsbRegular (props: IIconProp list) = createElement (import "SpeakerUsbRegular" FluentIcons) props
        static member inline spinnerIosFilled (props: IIconProp list) = createElement (import "SpinnerIosFilled" FluentIcons) props
        static member inline spinnerIosRegular (props: IIconProp list) = createElement (import "SpinnerIosRegular" FluentIcons) props
        static member inline splitHintFilled (props: IIconProp list) = createElement (import "SplitHintFilled" FluentIcons) props
        static member inline splitHintRegular (props: IIconProp list) = createElement (import "SplitHintRegular" FluentIcons) props
        static member inline splitHorizontalFilled (props: IIconProp list) = createElement (import "SplitHorizontalFilled" FluentIcons) props
        static member inline splitHorizontalRegular (props: IIconProp list) = createElement (import "SplitHorizontalRegular" FluentIcons) props
        static member inline splitVerticalFilled (props: IIconProp list) = createElement (import "SplitVerticalFilled" FluentIcons) props
        static member inline splitVerticalRegular (props: IIconProp list) = createElement (import "SplitVerticalRegular" FluentIcons) props
        static member inline sportFilled (props: IIconProp list) = createElement (import "SportFilled" FluentIcons) props
        static member inline sportRegular (props: IIconProp list) = createElement (import "SportRegular" FluentIcons) props
        static member inline sportAmericanFootballFilled (props: IIconProp list) = createElement (import "SportAmericanFootballFilled" FluentIcons) props
        static member inline sportAmericanFootballRegular (props: IIconProp list) = createElement (import "SportAmericanFootballRegular" FluentIcons) props
        static member inline sportBaseballFilled (props: IIconProp list) = createElement (import "SportBaseballFilled" FluentIcons) props
        static member inline sportBaseballRegular (props: IIconProp list) = createElement (import "SportBaseballRegular" FluentIcons) props
        static member inline sportBasketballFilled (props: IIconProp list) = createElement (import "SportBasketballFilled" FluentIcons) props
        static member inline sportBasketballRegular (props: IIconProp list) = createElement (import "SportBasketballRegular" FluentIcons) props
        static member inline sportHockeyFilled (props: IIconProp list) = createElement (import "SportHockeyFilled" FluentIcons) props
        static member inline sportHockeyRegular (props: IIconProp list) = createElement (import "SportHockeyRegular" FluentIcons) props
        static member inline sportSoccerFilled (props: IIconProp list) = createElement (import "SportSoccerFilled" FluentIcons) props
        static member inline sportSoccerRegular (props: IIconProp list) = createElement (import "SportSoccerRegular" FluentIcons) props
        static member inline squareFilled (props: IIconProp list) = createElement (import "SquareFilled" FluentIcons) props
        static member inline squareRegular (props: IIconProp list) = createElement (import "SquareRegular" FluentIcons) props
        static member inline squareAddFilled (props: IIconProp list) = createElement (import "SquareAddFilled" FluentIcons) props
        static member inline squareAddRegular (props: IIconProp list) = createElement (import "SquareAddRegular" FluentIcons) props
        static member inline squareArrowForwardFilled (props: IIconProp list) = createElement (import "SquareArrowForwardFilled" FluentIcons) props
        static member inline squareArrowForwardRegular (props: IIconProp list) = createElement (import "SquareArrowForwardRegular" FluentIcons) props
        static member inline squareDismissFilled (props: IIconProp list) = createElement (import "SquareDismissFilled" FluentIcons) props
        static member inline squareDismissRegular (props: IIconProp list) = createElement (import "SquareDismissRegular" FluentIcons) props
        static member inline squareDovetailJointFilled (props: IIconProp list) = createElement (import "SquareDovetailJointFilled" FluentIcons) props
        static member inline squareDovetailJointRegular (props: IIconProp list) = createElement (import "SquareDovetailJointRegular" FluentIcons) props
        static member inline squareEraserFilled (props: IIconProp list) = createElement (import "SquareEraserFilled" FluentIcons) props
        static member inline squareEraserRegular (props: IIconProp list) = createElement (import "SquareEraserRegular" FluentIcons) props
        static member inline squareHintFilled (props: IIconProp list) = createElement (import "SquareHintFilled" FluentIcons) props
        static member inline squareHintRegular (props: IIconProp list) = createElement (import "SquareHintRegular" FluentIcons) props
        static member inline squareHintAppsFilled (props: IIconProp list) = createElement (import "SquareHintAppsFilled" FluentIcons) props
        static member inline squareHintAppsRegular (props: IIconProp list) = createElement (import "SquareHintAppsRegular" FluentIcons) props
        static member inline squareHintArrowBackFilled (props: IIconProp list) = createElement (import "SquareHintArrowBackFilled" FluentIcons) props
        static member inline squareHintArrowBackRegular (props: IIconProp list) = createElement (import "SquareHintArrowBackRegular" FluentIcons) props
        static member inline squareHintHexagonFilled (props: IIconProp list) = createElement (import "SquareHintHexagonFilled" FluentIcons) props
        static member inline squareHintHexagonRegular (props: IIconProp list) = createElement (import "SquareHintHexagonRegular" FluentIcons) props
        static member inline squareHintSparklesFilled (props: IIconProp list) = createElement (import "SquareHintSparklesFilled" FluentIcons) props
        static member inline squareHintSparklesRegular (props: IIconProp list) = createElement (import "SquareHintSparklesRegular" FluentIcons) props
        static member inline squareMultipleFilled (props: IIconProp list) = createElement (import "SquareMultipleFilled" FluentIcons) props
        static member inline squareMultipleRegular (props: IIconProp list) = createElement (import "SquareMultipleRegular" FluentIcons) props
        static member inline squareShadowFilled (props: IIconProp list) = createElement (import "SquareShadowFilled" FluentIcons) props
        static member inline squareShadowRegular (props: IIconProp list) = createElement (import "SquareShadowRegular" FluentIcons) props
        static member inline squaresNestedFilled (props: IIconProp list) = createElement (import "SquaresNestedFilled" FluentIcons) props
        static member inline squaresNestedRegular (props: IIconProp list) = createElement (import "SquaresNestedRegular" FluentIcons) props
        static member inline stackFilled (props: IIconProp list) = createElement (import "StackFilled" FluentIcons) props
        static member inline stackRegular (props: IIconProp list) = createElement (import "StackRegular" FluentIcons) props
        static member inline stackAddFilled (props: IIconProp list) = createElement (import "StackAddFilled" FluentIcons) props
        static member inline stackAddRegular (props: IIconProp list) = createElement (import "StackAddRegular" FluentIcons) props
        static member inline stackArrowForwardFilled (props: IIconProp list) = createElement (import "StackArrowForwardFilled" FluentIcons) props
        static member inline stackArrowForwardRegular (props: IIconProp list) = createElement (import "StackArrowForwardRegular" FluentIcons) props
        static member inline stackStarFilled (props: IIconProp list) = createElement (import "StackStarFilled" FluentIcons) props
        static member inline stackStarRegular (props: IIconProp list) = createElement (import "StackStarRegular" FluentIcons) props
        static member inline stackVerticalFilled (props: IIconProp list) = createElement (import "StackVerticalFilled" FluentIcons) props
        static member inline stackVerticalRegular (props: IIconProp list) = createElement (import "StackVerticalRegular" FluentIcons) props
        static member inline starFilled (props: IIconProp list) = createElement (import "StarFilled" FluentIcons) props
        static member inline starRegular (props: IIconProp list) = createElement (import "StarRegular" FluentIcons) props
        static member inline starAddFilled (props: IIconProp list) = createElement (import "StarAddFilled" FluentIcons) props
        static member inline starAddRegular (props: IIconProp list) = createElement (import "StarAddRegular" FluentIcons) props
        static member inline starArrowBackFilled (props: IIconProp list) = createElement (import "StarArrowBackFilled" FluentIcons) props
        static member inline starArrowBackRegular (props: IIconProp list) = createElement (import "StarArrowBackRegular" FluentIcons) props
        static member inline starArrowRightEndFilled (props: IIconProp list) = createElement (import "StarArrowRightEndFilled" FluentIcons) props
        static member inline starArrowRightEndRegular (props: IIconProp list) = createElement (import "StarArrowRightEndRegular" FluentIcons) props
        static member inline starArrowRightStartFilled (props: IIconProp list) = createElement (import "StarArrowRightStartFilled" FluentIcons) props
        static member inline starArrowRightStartRegular (props: IIconProp list) = createElement (import "StarArrowRightStartRegular" FluentIcons) props
        static member inline starCheckmarkFilled (props: IIconProp list) = createElement (import "StarCheckmarkFilled" FluentIcons) props
        static member inline starCheckmarkRegular (props: IIconProp list) = createElement (import "StarCheckmarkRegular" FluentIcons) props
        static member inline starDismissFilled (props: IIconProp list) = createElement (import "StarDismissFilled" FluentIcons) props
        static member inline starDismissRegular (props: IIconProp list) = createElement (import "StarDismissRegular" FluentIcons) props
        static member inline starEditFilled (props: IIconProp list) = createElement (import "StarEditFilled" FluentIcons) props
        static member inline starEditRegular (props: IIconProp list) = createElement (import "StarEditRegular" FluentIcons) props
        static member inline starEmphasisFilled (props: IIconProp list) = createElement (import "StarEmphasisFilled" FluentIcons) props
        static member inline starEmphasisRegular (props: IIconProp list) = createElement (import "StarEmphasisRegular" FluentIcons) props
        static member inline starHalfFilled (props: IIconProp list) = createElement (import "StarHalfFilled" FluentIcons) props
        static member inline starHalfRegular (props: IIconProp list) = createElement (import "StarHalfRegular" FluentIcons) props
        static member inline starLineHorizontal3Filled (props: IIconProp list) = createElement (import "StarLineHorizontal3Filled" FluentIcons) props
        static member inline starLineHorizontal3Regular (props: IIconProp list) = createElement (import "StarLineHorizontal3Regular" FluentIcons) props
        static member inline starOffFilled (props: IIconProp list) = createElement (import "StarOffFilled" FluentIcons) props
        static member inline starOffRegular (props: IIconProp list) = createElement (import "StarOffRegular" FluentIcons) props
        static member inline starOneQuarterFilled (props: IIconProp list) = createElement (import "StarOneQuarterFilled" FluentIcons) props
        static member inline starOneQuarterRegular (props: IIconProp list) = createElement (import "StarOneQuarterRegular" FluentIcons) props
        static member inline starProhibitedFilled (props: IIconProp list) = createElement (import "StarProhibitedFilled" FluentIcons) props
        static member inline starProhibitedRegular (props: IIconProp list) = createElement (import "StarProhibitedRegular" FluentIcons) props
        static member inline starSettingsFilled (props: IIconProp list) = createElement (import "StarSettingsFilled" FluentIcons) props
        static member inline starSettingsRegular (props: IIconProp list) = createElement (import "StarSettingsRegular" FluentIcons) props
        static member inline starThreeQuarterFilled (props: IIconProp list) = createElement (import "StarThreeQuarterFilled" FluentIcons) props
        static member inline starThreeQuarterRegular (props: IIconProp list) = createElement (import "StarThreeQuarterRegular" FluentIcons) props
        static member inline statusFilled (props: IIconProp list) = createElement (import "StatusFilled" FluentIcons) props
        static member inline statusRegular (props: IIconProp list) = createElement (import "StatusRegular" FluentIcons) props
        static member inline stepFilled (props: IIconProp list) = createElement (import "StepFilled" FluentIcons) props
        static member inline stepRegular (props: IIconProp list) = createElement (import "StepRegular" FluentIcons) props
        static member inline stepsFilled (props: IIconProp list) = createElement (import "StepsFilled" FluentIcons) props
        static member inline stepsRegular (props: IIconProp list) = createElement (import "StepsRegular" FluentIcons) props
        static member inline stethoscopeFilled (props: IIconProp list) = createElement (import "StethoscopeFilled" FluentIcons) props
        static member inline stethoscopeRegular (props: IIconProp list) = createElement (import "StethoscopeRegular" FluentIcons) props
        static member inline stickerFilled (props: IIconProp list) = createElement (import "StickerFilled" FluentIcons) props
        static member inline stickerRegular (props: IIconProp list) = createElement (import "StickerRegular" FluentIcons) props
        static member inline stickerAddFilled (props: IIconProp list) = createElement (import "StickerAddFilled" FluentIcons) props
        static member inline stickerAddRegular (props: IIconProp list) = createElement (import "StickerAddRegular" FluentIcons) props
        static member inline stopFilled (props: IIconProp list) = createElement (import "StopFilled" FluentIcons) props
        static member inline stopRegular (props: IIconProp list) = createElement (import "StopRegular" FluentIcons) props
        static member inline storageFilled (props: IIconProp list) = createElement (import "StorageFilled" FluentIcons) props
        static member inline storageRegular (props: IIconProp list) = createElement (import "StorageRegular" FluentIcons) props
        static member inline storeMicrosoftFilled (props: IIconProp list) = createElement (import "StoreMicrosoftFilled" FluentIcons) props
        static member inline storeMicrosoftRegular (props: IIconProp list) = createElement (import "StoreMicrosoftRegular" FluentIcons) props
        static member inline streamFilled (props: IIconProp list) = createElement (import "StreamFilled" FluentIcons) props
        static member inline streamRegular (props: IIconProp list) = createElement (import "StreamRegular" FluentIcons) props
        static member inline streamInputFilled (props: IIconProp list) = createElement (import "StreamInputFilled" FluentIcons) props
        static member inline streamInputRegular (props: IIconProp list) = createElement (import "StreamInputRegular" FluentIcons) props
        static member inline streamInputOutputFilled (props: IIconProp list) = createElement (import "StreamInputOutputFilled" FluentIcons) props
        static member inline streamInputOutputRegular (props: IIconProp list) = createElement (import "StreamInputOutputRegular" FluentIcons) props
        static member inline streamOutputFilled (props: IIconProp list) = createElement (import "StreamOutputFilled" FluentIcons) props
        static member inline streamOutputRegular (props: IIconProp list) = createElement (import "StreamOutputRegular" FluentIcons) props
        static member inline streetSignFilled (props: IIconProp list) = createElement (import "StreetSignFilled" FluentIcons) props
        static member inline streetSignRegular (props: IIconProp list) = createElement (import "StreetSignRegular" FluentIcons) props
        static member inline styleGuideFilled (props: IIconProp list) = createElement (import "StyleGuideFilled" FluentIcons) props
        static member inline styleGuideRegular (props: IIconProp list) = createElement (import "StyleGuideRegular" FluentIcons) props
        static member inline subGridFilled (props: IIconProp list) = createElement (import "SubGridFilled" FluentIcons) props
        static member inline subGridRegular (props: IIconProp list) = createElement (import "SubGridRegular" FluentIcons) props
        static member inline subtitlesFilled (props: IIconProp list) = createElement (import "SubtitlesFilled" FluentIcons) props
        static member inline subtitlesRegular (props: IIconProp list) = createElement (import "SubtitlesRegular" FluentIcons) props
        static member inline subtractFilled (props: IIconProp list) = createElement (import "SubtractFilled" FluentIcons) props
        static member inline subtractRegular (props: IIconProp list) = createElement (import "SubtractRegular" FluentIcons) props
        static member inline subtractCircleFilled (props: IIconProp list) = createElement (import "SubtractCircleFilled" FluentIcons) props
        static member inline subtractCircleRegular (props: IIconProp list) = createElement (import "SubtractCircleRegular" FluentIcons) props
        static member inline subtractCircleArrowBackFilled (props: IIconProp list) = createElement (import "SubtractCircleArrowBackFilled" FluentIcons) props
        static member inline subtractCircleArrowBackRegular (props: IIconProp list) = createElement (import "SubtractCircleArrowBackRegular" FluentIcons) props
        static member inline subtractCircleArrowForwardFilled (props: IIconProp list) = createElement (import "SubtractCircleArrowForwardFilled" FluentIcons) props
        static member inline subtractCircleArrowForwardRegular (props: IIconProp list) = createElement (import "SubtractCircleArrowForwardRegular" FluentIcons) props
        static member inline subtractParenthesesFilled (props: IIconProp list) = createElement (import "SubtractParenthesesFilled" FluentIcons) props
        static member inline subtractParenthesesRegular (props: IIconProp list) = createElement (import "SubtractParenthesesRegular" FluentIcons) props
        static member inline subtractSquareFilled (props: IIconProp list) = createElement (import "SubtractSquareFilled" FluentIcons) props
        static member inline subtractSquareRegular (props: IIconProp list) = createElement (import "SubtractSquareRegular" FluentIcons) props
        static member inline subtractSquareMultipleFilled (props: IIconProp list) = createElement (import "SubtractSquareMultipleFilled" FluentIcons) props
        static member inline subtractSquareMultipleRegular (props: IIconProp list) = createElement (import "SubtractSquareMultipleRegular" FluentIcons) props
        static member inline surfaceEarbudsFilled (props: IIconProp list) = createElement (import "SurfaceEarbudsFilled" FluentIcons) props
        static member inline surfaceEarbudsRegular (props: IIconProp list) = createElement (import "SurfaceEarbudsRegular" FluentIcons) props
        static member inline surfaceHubFilled (props: IIconProp list) = createElement (import "SurfaceHubFilled" FluentIcons) props
        static member inline surfaceHubRegular (props: IIconProp list) = createElement (import "SurfaceHubRegular" FluentIcons) props
        static member inline swimmingPoolFilled (props: IIconProp list) = createElement (import "SwimmingPoolFilled" FluentIcons) props
        static member inline swimmingPoolRegular (props: IIconProp list) = createElement (import "SwimmingPoolRegular" FluentIcons) props
        static member inline swipeDownFilled (props: IIconProp list) = createElement (import "SwipeDownFilled" FluentIcons) props
        static member inline swipeDownRegular (props: IIconProp list) = createElement (import "SwipeDownRegular" FluentIcons) props
        static member inline swipeRightFilled (props: IIconProp list) = createElement (import "SwipeRightFilled" FluentIcons) props
        static member inline swipeRightRegular (props: IIconProp list) = createElement (import "SwipeRightRegular" FluentIcons) props
        static member inline swipeUpFilled (props: IIconProp list) = createElement (import "SwipeUpFilled" FluentIcons) props
        static member inline swipeUpRegular (props: IIconProp list) = createElement (import "SwipeUpRegular" FluentIcons) props
        static member inline symbolsFilled (props: IIconProp list) = createElement (import "SymbolsFilled" FluentIcons) props
        static member inline symbolsRegular (props: IIconProp list) = createElement (import "SymbolsRegular" FluentIcons) props
        static member inline syncOffFilled (props: IIconProp list) = createElement (import "SyncOffFilled" FluentIcons) props
        static member inline syncOffRegular (props: IIconProp list) = createElement (import "SyncOffRegular" FluentIcons) props
        static member inline syringeFilled (props: IIconProp list) = createElement (import "SyringeFilled" FluentIcons) props
        static member inline syringeRegular (props: IIconProp list) = createElement (import "SyringeRegular" FluentIcons) props
        static member inline systemFilled (props: IIconProp list) = createElement (import "SystemFilled" FluentIcons) props
        static member inline systemRegular (props: IIconProp list) = createElement (import "SystemRegular" FluentIcons) props
        static member inline tabFilled (props: IIconProp list) = createElement (import "TabFilled" FluentIcons) props
        static member inline tabRegular (props: IIconProp list) = createElement (import "TabRegular" FluentIcons) props
        static member inline tabAddFilled (props: IIconProp list) = createElement (import "TabAddFilled" FluentIcons) props
        static member inline tabAddRegular (props: IIconProp list) = createElement (import "TabAddRegular" FluentIcons) props
        static member inline tabArrowLeftFilled (props: IIconProp list) = createElement (import "TabArrowLeftFilled" FluentIcons) props
        static member inline tabArrowLeftRegular (props: IIconProp list) = createElement (import "TabArrowLeftRegular" FluentIcons) props
        static member inline tabDesktopFilled (props: IIconProp list) = createElement (import "TabDesktopFilled" FluentIcons) props
        static member inline tabDesktopRegular (props: IIconProp list) = createElement (import "TabDesktopRegular" FluentIcons) props
        static member inline tabDesktopArrowClockwiseFilled (props: IIconProp list) = createElement (import "TabDesktopArrowClockwiseFilled" FluentIcons) props
        static member inline tabDesktopArrowClockwiseRegular (props: IIconProp list) = createElement (import "TabDesktopArrowClockwiseRegular" FluentIcons) props
        static member inline tabDesktopArrowLeftFilled (props: IIconProp list) = createElement (import "TabDesktopArrowLeftFilled" FluentIcons) props
        static member inline tabDesktopArrowLeftRegular (props: IIconProp list) = createElement (import "TabDesktopArrowLeftRegular" FluentIcons) props
        static member inline tabDesktopBottomFilled (props: IIconProp list) = createElement (import "TabDesktopBottomFilled" FluentIcons) props
        static member inline tabDesktopBottomRegular (props: IIconProp list) = createElement (import "TabDesktopBottomRegular" FluentIcons) props
        static member inline tabDesktopClockFilled (props: IIconProp list) = createElement (import "TabDesktopClockFilled" FluentIcons) props
        static member inline tabDesktopClockRegular (props: IIconProp list) = createElement (import "TabDesktopClockRegular" FluentIcons) props
        static member inline tabDesktopCopyFilled (props: IIconProp list) = createElement (import "TabDesktopCopyFilled" FluentIcons) props
        static member inline tabDesktopCopyRegular (props: IIconProp list) = createElement (import "TabDesktopCopyRegular" FluentIcons) props
        static member inline tabDesktopImageFilled (props: IIconProp list) = createElement (import "TabDesktopImageFilled" FluentIcons) props
        static member inline tabDesktopImageRegular (props: IIconProp list) = createElement (import "TabDesktopImageRegular" FluentIcons) props
        static member inline tabDesktopLinkFilled (props: IIconProp list) = createElement (import "TabDesktopLinkFilled" FluentIcons) props
        static member inline tabDesktopLinkRegular (props: IIconProp list) = createElement (import "TabDesktopLinkRegular" FluentIcons) props
        static member inline tabDesktopMultipleFilled (props: IIconProp list) = createElement (import "TabDesktopMultipleFilled" FluentIcons) props
        static member inline tabDesktopMultipleRegular (props: IIconProp list) = createElement (import "TabDesktopMultipleRegular" FluentIcons) props
        static member inline tabDesktopMultipleAddFilled (props: IIconProp list) = createElement (import "TabDesktopMultipleAddFilled" FluentIcons) props
        static member inline tabDesktopMultipleAddRegular (props: IIconProp list) = createElement (import "TabDesktopMultipleAddRegular" FluentIcons) props
        static member inline tabDesktopMultipleBottomFilled (props: IIconProp list) = createElement (import "TabDesktopMultipleBottomFilled" FluentIcons) props
        static member inline tabDesktopMultipleBottomRegular (props: IIconProp list) = createElement (import "TabDesktopMultipleBottomRegular" FluentIcons) props
        static member inline tabDesktopMultipleSparkleFilled (props: IIconProp list) = createElement (import "TabDesktopMultipleSparkleFilled" FluentIcons) props
        static member inline tabDesktopMultipleSparkleRegular (props: IIconProp list) = createElement (import "TabDesktopMultipleSparkleRegular" FluentIcons) props
        static member inline tabDesktopNewPageFilled (props: IIconProp list) = createElement (import "TabDesktopNewPageFilled" FluentIcons) props
        static member inline tabDesktopNewPageRegular (props: IIconProp list) = createElement (import "TabDesktopNewPageRegular" FluentIcons) props
        static member inline tabDesktopSearchFilled (props: IIconProp list) = createElement (import "TabDesktopSearchFilled" FluentIcons) props
        static member inline tabDesktopSearchRegular (props: IIconProp list) = createElement (import "TabDesktopSearchRegular" FluentIcons) props
        static member inline tabGroupFilled (props: IIconProp list) = createElement (import "TabGroupFilled" FluentIcons) props
        static member inline tabGroupRegular (props: IIconProp list) = createElement (import "TabGroupRegular" FluentIcons) props
        static member inline tabInPrivateFilled (props: IIconProp list) = createElement (import "TabInPrivateFilled" FluentIcons) props
        static member inline tabInPrivateRegular (props: IIconProp list) = createElement (import "TabInPrivateRegular" FluentIcons) props
        static member inline tabInprivateAccountFilled (props: IIconProp list) = createElement (import "TabInprivateAccountFilled" FluentIcons) props
        static member inline tabInprivateAccountRegular (props: IIconProp list) = createElement (import "TabInprivateAccountRegular" FluentIcons) props
        static member inline tabProhibitedFilled (props: IIconProp list) = createElement (import "TabProhibitedFilled" FluentIcons) props
        static member inline tabProhibitedRegular (props: IIconProp list) = createElement (import "TabProhibitedRegular" FluentIcons) props
        static member inline tabShieldDismissFilled (props: IIconProp list) = createElement (import "TabShieldDismissFilled" FluentIcons) props
        static member inline tabShieldDismissRegular (props: IIconProp list) = createElement (import "TabShieldDismissRegular" FluentIcons) props
        static member inline tableFilled (props: IIconProp list) = createElement (import "TableFilled" FluentIcons) props
        static member inline tableRegular (props: IIconProp list) = createElement (import "TableRegular" FluentIcons) props
        static member inline tableAddFilled (props: IIconProp list) = createElement (import "TableAddFilled" FluentIcons) props
        static member inline tableAddRegular (props: IIconProp list) = createElement (import "TableAddRegular" FluentIcons) props
        static member inline tableArrowUpFilled (props: IIconProp list) = createElement (import "TableArrowUpFilled" FluentIcons) props
        static member inline tableArrowUpRegular (props: IIconProp list) = createElement (import "TableArrowUpRegular" FluentIcons) props
        static member inline tableBottomRowFilled (props: IIconProp list) = createElement (import "TableBottomRowFilled" FluentIcons) props
        static member inline tableBottomRowRegular (props: IIconProp list) = createElement (import "TableBottomRowRegular" FluentIcons) props
        static member inline tableCalculatorFilled (props: IIconProp list) = createElement (import "TableCalculatorFilled" FluentIcons) props
        static member inline tableCalculatorRegular (props: IIconProp list) = createElement (import "TableCalculatorRegular" FluentIcons) props
        static member inline tableCellEditFilled (props: IIconProp list) = createElement (import "TableCellEditFilled" FluentIcons) props
        static member inline tableCellEditRegular (props: IIconProp list) = createElement (import "TableCellEditRegular" FluentIcons) props
        static member inline tableCellsMergeFilled (props: IIconProp list) = createElement (import "TableCellsMergeFilled" FluentIcons) props
        static member inline tableCellsMergeRegular (props: IIconProp list) = createElement (import "TableCellsMergeRegular" FluentIcons) props
        static member inline tableCellsSplitFilled (props: IIconProp list) = createElement (import "TableCellsSplitFilled" FluentIcons) props
        static member inline tableCellsSplitRegular (props: IIconProp list) = createElement (import "TableCellsSplitRegular" FluentIcons) props
        static member inline tableCheckerFilled (props: IIconProp list) = createElement (import "TableCheckerFilled" FluentIcons) props
        static member inline tableCheckerRegular (props: IIconProp list) = createElement (import "TableCheckerRegular" FluentIcons) props
        static member inline tableColumnTopBottomFilled (props: IIconProp list) = createElement (import "TableColumnTopBottomFilled" FluentIcons) props
        static member inline tableColumnTopBottomRegular (props: IIconProp list) = createElement (import "TableColumnTopBottomRegular" FluentIcons) props
        static member inline tableCopyFilled (props: IIconProp list) = createElement (import "TableCopyFilled" FluentIcons) props
        static member inline tableCopyRegular (props: IIconProp list) = createElement (import "TableCopyRegular" FluentIcons) props
        static member inline tableCursorFilled (props: IIconProp list) = createElement (import "TableCursorFilled" FluentIcons) props
        static member inline tableCursorRegular (props: IIconProp list) = createElement (import "TableCursorRegular" FluentIcons) props
        static member inline tableDeleteColumnFilled (props: IIconProp list) = createElement (import "TableDeleteColumnFilled" FluentIcons) props
        static member inline tableDeleteColumnRegular (props: IIconProp list) = createElement (import "TableDeleteColumnRegular" FluentIcons) props
        static member inline tableDeleteRowFilled (props: IIconProp list) = createElement (import "TableDeleteRowFilled" FluentIcons) props
        static member inline tableDeleteRowRegular (props: IIconProp list) = createElement (import "TableDeleteRowRegular" FluentIcons) props
        static member inline tableDismissFilled (props: IIconProp list) = createElement (import "TableDismissFilled" FluentIcons) props
        static member inline tableDismissRegular (props: IIconProp list) = createElement (import "TableDismissRegular" FluentIcons) props
        static member inline tableEditFilled (props: IIconProp list) = createElement (import "TableEditFilled" FluentIcons) props
        static member inline tableEditRegular (props: IIconProp list) = createElement (import "TableEditRegular" FluentIcons) props
        static member inline tableFreezeColumnFilled (props: IIconProp list) = createElement (import "TableFreezeColumnFilled" FluentIcons) props
        static member inline tableFreezeColumnRegular (props: IIconProp list) = createElement (import "TableFreezeColumnRegular" FluentIcons) props
        static member inline tableFreezeColumnAndRowFilled (props: IIconProp list) = createElement (import "TableFreezeColumnAndRowFilled" FluentIcons) props
        static member inline tableFreezeColumnAndRowRegular (props: IIconProp list) = createElement (import "TableFreezeColumnAndRowRegular" FluentIcons) props
        static member inline tableFreezeRowFilled (props: IIconProp list) = createElement (import "TableFreezeRowFilled" FluentIcons) props
        static member inline tableFreezeRowRegular (props: IIconProp list) = createElement (import "TableFreezeRowRegular" FluentIcons) props
        static member inline tableImageFilled (props: IIconProp list) = createElement (import "TableImageFilled" FluentIcons) props
        static member inline tableImageRegular (props: IIconProp list) = createElement (import "TableImageRegular" FluentIcons) props
        static member inline tableInsertColumnFilled (props: IIconProp list) = createElement (import "TableInsertColumnFilled" FluentIcons) props
        static member inline tableInsertColumnRegular (props: IIconProp list) = createElement (import "TableInsertColumnRegular" FluentIcons) props
        static member inline tableInsertRowFilled (props: IIconProp list) = createElement (import "TableInsertRowFilled" FluentIcons) props
        static member inline tableInsertRowRegular (props: IIconProp list) = createElement (import "TableInsertRowRegular" FluentIcons) props
        static member inline tableLightningFilled (props: IIconProp list) = createElement (import "TableLightningFilled" FluentIcons) props
        static member inline tableLightningRegular (props: IIconProp list) = createElement (import "TableLightningRegular" FluentIcons) props
        static member inline tableLinkFilled (props: IIconProp list) = createElement (import "TableLinkFilled" FluentIcons) props
        static member inline tableLinkRegular (props: IIconProp list) = createElement (import "TableLinkRegular" FluentIcons) props
        static member inline tableLockFilled (props: IIconProp list) = createElement (import "TableLockFilled" FluentIcons) props
        static member inline tableLockRegular (props: IIconProp list) = createElement (import "TableLockRegular" FluentIcons) props
        static member inline tableMoveAboveFilled (props: IIconProp list) = createElement (import "TableMoveAboveFilled" FluentIcons) props
        static member inline tableMoveAboveRegular (props: IIconProp list) = createElement (import "TableMoveAboveRegular" FluentIcons) props
        static member inline tableMoveBelowFilled (props: IIconProp list) = createElement (import "TableMoveBelowFilled" FluentIcons) props
        static member inline tableMoveBelowRegular (props: IIconProp list) = createElement (import "TableMoveBelowRegular" FluentIcons) props
        static member inline tableMoveLeftFilled (props: IIconProp list) = createElement (import "TableMoveLeftFilled" FluentIcons) props
        static member inline tableMoveLeftRegular (props: IIconProp list) = createElement (import "TableMoveLeftRegular" FluentIcons) props
        static member inline tableMoveRightFilled (props: IIconProp list) = createElement (import "TableMoveRightFilled" FluentIcons) props
        static member inline tableMoveRightRegular (props: IIconProp list) = createElement (import "TableMoveRightRegular" FluentIcons) props
        static member inline tableMultipleFilled (props: IIconProp list) = createElement (import "TableMultipleFilled" FluentIcons) props
        static member inline tableMultipleRegular (props: IIconProp list) = createElement (import "TableMultipleRegular" FluentIcons) props
        static member inline tableOffsetFilled (props: IIconProp list) = createElement (import "TableOffsetFilled" FluentIcons) props
        static member inline tableOffsetRegular (props: IIconProp list) = createElement (import "TableOffsetRegular" FluentIcons) props
        static member inline tableOffsetAddFilled (props: IIconProp list) = createElement (import "TableOffsetAddFilled" FluentIcons) props
        static member inline tableOffsetAddRegular (props: IIconProp list) = createElement (import "TableOffsetAddRegular" FluentIcons) props
        static member inline tableOffsetLessThanOrEqualToFilled (props: IIconProp list) = createElement (import "TableOffsetLessThanOrEqualToFilled" FluentIcons) props
        static member inline tableOffsetLessThanOrEqualToRegular (props: IIconProp list) = createElement (import "TableOffsetLessThanOrEqualToRegular" FluentIcons) props
        static member inline tableOffsetSettingsFilled (props: IIconProp list) = createElement (import "TableOffsetSettingsFilled" FluentIcons) props
        static member inline tableOffsetSettingsRegular (props: IIconProp list) = createElement (import "TableOffsetSettingsRegular" FluentIcons) props
        static member inline tableResizeColumnFilled (props: IIconProp list) = createElement (import "TableResizeColumnFilled" FluentIcons) props
        static member inline tableResizeColumnRegular (props: IIconProp list) = createElement (import "TableResizeColumnRegular" FluentIcons) props
        static member inline tableResizeRowFilled (props: IIconProp list) = createElement (import "TableResizeRowFilled" FluentIcons) props
        static member inline tableResizeRowRegular (props: IIconProp list) = createElement (import "TableResizeRowRegular" FluentIcons) props
        static member inline tableSearchFilled (props: IIconProp list) = createElement (import "TableSearchFilled" FluentIcons) props
        static member inline tableSearchRegular (props: IIconProp list) = createElement (import "TableSearchRegular" FluentIcons) props
        static member inline tableSettingsFilled (props: IIconProp list) = createElement (import "TableSettingsFilled" FluentIcons) props
        static member inline tableSettingsRegular (props: IIconProp list) = createElement (import "TableSettingsRegular" FluentIcons) props
        static member inline tableSimpleFilled (props: IIconProp list) = createElement (import "TableSimpleFilled" FluentIcons) props
        static member inline tableSimpleRegular (props: IIconProp list) = createElement (import "TableSimpleRegular" FluentIcons) props
        static member inline tableSimpleCheckmarkFilled (props: IIconProp list) = createElement (import "TableSimpleCheckmarkFilled" FluentIcons) props
        static member inline tableSimpleCheckmarkRegular (props: IIconProp list) = createElement (import "TableSimpleCheckmarkRegular" FluentIcons) props
        static member inline tableSimpleExcludeFilled (props: IIconProp list) = createElement (import "TableSimpleExcludeFilled" FluentIcons) props
        static member inline tableSimpleExcludeRegular (props: IIconProp list) = createElement (import "TableSimpleExcludeRegular" FluentIcons) props
        static member inline tableSimpleIncludeFilled (props: IIconProp list) = createElement (import "TableSimpleIncludeFilled" FluentIcons) props
        static member inline tableSimpleIncludeRegular (props: IIconProp list) = createElement (import "TableSimpleIncludeRegular" FluentIcons) props
        static member inline tableSimpleMultipleFilled (props: IIconProp list) = createElement (import "TableSimpleMultipleFilled" FluentIcons) props
        static member inline tableSimpleMultipleRegular (props: IIconProp list) = createElement (import "TableSimpleMultipleRegular" FluentIcons) props
        static member inline tableSparkleFilled (props: IIconProp list) = createElement (import "TableSparkleFilled" FluentIcons) props
        static member inline tableSparkleRegular (props: IIconProp list) = createElement (import "TableSparkleRegular" FluentIcons) props
        static member inline tableSplitFilled (props: IIconProp list) = createElement (import "TableSplitFilled" FluentIcons) props
        static member inline tableSplitRegular (props: IIconProp list) = createElement (import "TableSplitRegular" FluentIcons) props
        static member inline tableStackAboveFilled (props: IIconProp list) = createElement (import "TableStackAboveFilled" FluentIcons) props
        static member inline tableStackAboveRegular (props: IIconProp list) = createElement (import "TableStackAboveRegular" FluentIcons) props
        static member inline tableStackBelowFilled (props: IIconProp list) = createElement (import "TableStackBelowFilled" FluentIcons) props
        static member inline tableStackBelowRegular (props: IIconProp list) = createElement (import "TableStackBelowRegular" FluentIcons) props
        static member inline tableStackLeftFilled (props: IIconProp list) = createElement (import "TableStackLeftFilled" FluentIcons) props
        static member inline tableStackLeftRegular (props: IIconProp list) = createElement (import "TableStackLeftRegular" FluentIcons) props
        static member inline tableStackRightFilled (props: IIconProp list) = createElement (import "TableStackRightFilled" FluentIcons) props
        static member inline tableStackRightRegular (props: IIconProp list) = createElement (import "TableStackRightRegular" FluentIcons) props
        static member inline tableSwitchFilled (props: IIconProp list) = createElement (import "TableSwitchFilled" FluentIcons) props
        static member inline tableSwitchRegular (props: IIconProp list) = createElement (import "TableSwitchRegular" FluentIcons) props
        static member inline tabletFilled (props: IIconProp list) = createElement (import "TabletFilled" FluentIcons) props
        static member inline tabletRegular (props: IIconProp list) = createElement (import "TabletRegular" FluentIcons) props
        static member inline tabletLaptopFilled (props: IIconProp list) = createElement (import "TabletLaptopFilled" FluentIcons) props
        static member inline tabletLaptopRegular (props: IIconProp list) = createElement (import "TabletLaptopRegular" FluentIcons) props
        static member inline tabletSpeakerFilled (props: IIconProp list) = createElement (import "TabletSpeakerFilled" FluentIcons) props
        static member inline tabletSpeakerRegular (props: IIconProp list) = createElement (import "TabletSpeakerRegular" FluentIcons) props
        static member inline tabsFilled (props: IIconProp list) = createElement (import "TabsFilled" FluentIcons) props
        static member inline tabsRegular (props: IIconProp list) = createElement (import "TabsRegular" FluentIcons) props
        static member inline tagFilled (props: IIconProp list) = createElement (import "TagFilled" FluentIcons) props
        static member inline tagRegular (props: IIconProp list) = createElement (import "TagRegular" FluentIcons) props
        static member inline tagCircleFilled (props: IIconProp list) = createElement (import "TagCircleFilled" FluentIcons) props
        static member inline tagCircleRegular (props: IIconProp list) = createElement (import "TagCircleRegular" FluentIcons) props
        static member inline tagDismissFilled (props: IIconProp list) = createElement (import "TagDismissFilled" FluentIcons) props
        static member inline tagDismissRegular (props: IIconProp list) = createElement (import "TagDismissRegular" FluentIcons) props
        static member inline tagErrorFilled (props: IIconProp list) = createElement (import "TagErrorFilled" FluentIcons) props
        static member inline tagErrorRegular (props: IIconProp list) = createElement (import "TagErrorRegular" FluentIcons) props
        static member inline tagLockFilled (props: IIconProp list) = createElement (import "TagLockFilled" FluentIcons) props
        static member inline tagLockRegular (props: IIconProp list) = createElement (import "TagLockRegular" FluentIcons) props
        static member inline tagLockAccentFilled (props: IIconProp list) = createElement (import "TagLockAccentFilled" FluentIcons) props
        static member inline tagMultipleFilled (props: IIconProp list) = createElement (import "TagMultipleFilled" FluentIcons) props
        static member inline tagMultipleRegular (props: IIconProp list) = createElement (import "TagMultipleRegular" FluentIcons) props
        static member inline tagOffFilled (props: IIconProp list) = createElement (import "TagOffFilled" FluentIcons) props
        static member inline tagOffRegular (props: IIconProp list) = createElement (import "TagOffRegular" FluentIcons) props
        static member inline tagQuestionMarkFilled (props: IIconProp list) = createElement (import "TagQuestionMarkFilled" FluentIcons) props
        static member inline tagQuestionMarkRegular (props: IIconProp list) = createElement (import "TagQuestionMarkRegular" FluentIcons) props
        static member inline tagResetFilled (props: IIconProp list) = createElement (import "TagResetFilled" FluentIcons) props
        static member inline tagResetRegular (props: IIconProp list) = createElement (import "TagResetRegular" FluentIcons) props
        static member inline tagSearchFilled (props: IIconProp list) = createElement (import "TagSearchFilled" FluentIcons) props
        static member inline tagSearchRegular (props: IIconProp list) = createElement (import "TagSearchRegular" FluentIcons) props
        static member inline tapDoubleFilled (props: IIconProp list) = createElement (import "TapDoubleFilled" FluentIcons) props
        static member inline tapDoubleRegular (props: IIconProp list) = createElement (import "TapDoubleRegular" FluentIcons) props
        static member inline tapSingleFilled (props: IIconProp list) = createElement (import "TapSingleFilled" FluentIcons) props
        static member inline tapSingleRegular (props: IIconProp list) = createElement (import "TapSingleRegular" FluentIcons) props
        static member inline targetFilled (props: IIconProp list) = createElement (import "TargetFilled" FluentIcons) props
        static member inline targetRegular (props: IIconProp list) = createElement (import "TargetRegular" FluentIcons) props
        static member inline targetAddFilled (props: IIconProp list) = createElement (import "TargetAddFilled" FluentIcons) props
        static member inline targetAddRegular (props: IIconProp list) = createElement (import "TargetAddRegular" FluentIcons) props
        static member inline targetArrowFilled (props: IIconProp list) = createElement (import "TargetArrowFilled" FluentIcons) props
        static member inline targetArrowRegular (props: IIconProp list) = createElement (import "TargetArrowRegular" FluentIcons) props
        static member inline targetDismissFilled (props: IIconProp list) = createElement (import "TargetDismissFilled" FluentIcons) props
        static member inline targetDismissRegular (props: IIconProp list) = createElement (import "TargetDismissRegular" FluentIcons) props
        static member inline targetEditFilled (props: IIconProp list) = createElement (import "TargetEditFilled" FluentIcons) props
        static member inline targetEditRegular (props: IIconProp list) = createElement (import "TargetEditRegular" FluentIcons) props
        static member inline taskListAddFilled (props: IIconProp list) = createElement (import "TaskListAddFilled" FluentIcons) props
        static member inline taskListAddRegular (props: IIconProp list) = createElement (import "TaskListAddRegular" FluentIcons) props
        static member inline taskListLtrFilled (props: IIconProp list) = createElement (import "TaskListLtrFilled" FluentIcons) props
        static member inline taskListLtrRegular (props: IIconProp list) = createElement (import "TaskListLtrRegular" FluentIcons) props
        static member inline taskListRtlFilled (props: IIconProp list) = createElement (import "TaskListRtlFilled" FluentIcons) props
        static member inline taskListRtlRegular (props: IIconProp list) = createElement (import "TaskListRtlRegular" FluentIcons) props
        static member inline taskListSquareAddFilled (props: IIconProp list) = createElement (import "TaskListSquareAddFilled" FluentIcons) props
        static member inline taskListSquareAddRegular (props: IIconProp list) = createElement (import "TaskListSquareAddRegular" FluentIcons) props
        static member inline taskListSquareDatabaseFilled (props: IIconProp list) = createElement (import "TaskListSquareDatabaseFilled" FluentIcons) props
        static member inline taskListSquareDatabaseRegular (props: IIconProp list) = createElement (import "TaskListSquareDatabaseRegular" FluentIcons) props
        static member inline taskListSquareLtrFilled (props: IIconProp list) = createElement (import "TaskListSquareLtrFilled" FluentIcons) props
        static member inline taskListSquareLtrRegular (props: IIconProp list) = createElement (import "TaskListSquareLtrRegular" FluentIcons) props
        static member inline taskListSquarePersonFilled (props: IIconProp list) = createElement (import "TaskListSquarePersonFilled" FluentIcons) props
        static member inline taskListSquarePersonRegular (props: IIconProp list) = createElement (import "TaskListSquarePersonRegular" FluentIcons) props
        static member inline taskListSquareRtlFilled (props: IIconProp list) = createElement (import "TaskListSquareRtlFilled" FluentIcons) props
        static member inline taskListSquareRtlRegular (props: IIconProp list) = createElement (import "TaskListSquareRtlRegular" FluentIcons) props
        static member inline taskListSquareSettingsFilled (props: IIconProp list) = createElement (import "TaskListSquareSettingsFilled" FluentIcons) props
        static member inline taskListSquareSettingsRegular (props: IIconProp list) = createElement (import "TaskListSquareSettingsRegular" FluentIcons) props
        static member inline tasksAppFilled (props: IIconProp list) = createElement (import "TasksAppFilled" FluentIcons) props
        static member inline tasksAppRegular (props: IIconProp list) = createElement (import "TasksAppRegular" FluentIcons) props
        static member inline teachingFilled (props: IIconProp list) = createElement (import "TeachingFilled" FluentIcons) props
        static member inline teachingRegular (props: IIconProp list) = createElement (import "TeachingRegular" FluentIcons) props
        static member inline teardropBottomRightFilled (props: IIconProp list) = createElement (import "TeardropBottomRightFilled" FluentIcons) props
        static member inline teardropBottomRightRegular (props: IIconProp list) = createElement (import "TeardropBottomRightRegular" FluentIcons) props
        static member inline teddyFilled (props: IIconProp list) = createElement (import "TeddyFilled" FluentIcons) props
        static member inline teddyRegular (props: IIconProp list) = createElement (import "TeddyRegular" FluentIcons) props
        static member inline temperatureFilled (props: IIconProp list) = createElement (import "TemperatureFilled" FluentIcons) props
        static member inline temperatureRegular (props: IIconProp list) = createElement (import "TemperatureRegular" FluentIcons) props
        static member inline tentFilled (props: IIconProp list) = createElement (import "TentFilled" FluentIcons) props
        static member inline tentRegular (props: IIconProp list) = createElement (import "TentRegular" FluentIcons) props
        static member inline tetrisAppFilled (props: IIconProp list) = createElement (import "TetrisAppFilled" FluentIcons) props
        static member inline tetrisAppRegular (props: IIconProp list) = createElement (import "TetrisAppRegular" FluentIcons) props
        static member inline textAddFilled (props: IIconProp list) = createElement (import "TextAddFilled" FluentIcons) props
        static member inline textAddRegular (props: IIconProp list) = createElement (import "TextAddRegular" FluentIcons) props
        static member inline textAddSpaceAfterFilled (props: IIconProp list) = createElement (import "TextAddSpaceAfterFilled" FluentIcons) props
        static member inline textAddSpaceAfterRegular (props: IIconProp list) = createElement (import "TextAddSpaceAfterRegular" FluentIcons) props
        static member inline textAddSpaceBeforeFilled (props: IIconProp list) = createElement (import "TextAddSpaceBeforeFilled" FluentIcons) props
        static member inline textAddSpaceBeforeRegular (props: IIconProp list) = createElement (import "TextAddSpaceBeforeRegular" FluentIcons) props
        static member inline textAddTFilled (props: IIconProp list) = createElement (import "TextAddTFilled" FluentIcons) props
        static member inline textAddTRegular (props: IIconProp list) = createElement (import "TextAddTRegular" FluentIcons) props
        static member inline textAlignCenterFilled (props: IIconProp list) = createElement (import "TextAlignCenterFilled" FluentIcons) props
        static member inline textAlignCenterRegular (props: IIconProp list) = createElement (import "TextAlignCenterRegular" FluentIcons) props
        static member inline textAlignCenterRotate270Filled (props: IIconProp list) = createElement (import "TextAlignCenterRotate270Filled" FluentIcons) props
        static member inline textAlignCenterRotate270Regular (props: IIconProp list) = createElement (import "TextAlignCenterRotate270Regular" FluentIcons) props
        static member inline textAlignCenterRotate90Filled (props: IIconProp list) = createElement (import "TextAlignCenterRotate90Filled" FluentIcons) props
        static member inline textAlignCenterRotate90Regular (props: IIconProp list) = createElement (import "TextAlignCenterRotate90Regular" FluentIcons) props
        static member inline textAlignDistributedFilled (props: IIconProp list) = createElement (import "TextAlignDistributedFilled" FluentIcons) props
        static member inline textAlignDistributedRegular (props: IIconProp list) = createElement (import "TextAlignDistributedRegular" FluentIcons) props
        static member inline textAlignDistributedEvenlyFilled (props: IIconProp list) = createElement (import "TextAlignDistributedEvenlyFilled" FluentIcons) props
        static member inline textAlignDistributedEvenlyRegular (props: IIconProp list) = createElement (import "TextAlignDistributedEvenlyRegular" FluentIcons) props
        static member inline textAlignDistributedVerticalFilled (props: IIconProp list) = createElement (import "TextAlignDistributedVerticalFilled" FluentIcons) props
        static member inline textAlignDistributedVerticalRegular (props: IIconProp list) = createElement (import "TextAlignDistributedVerticalRegular" FluentIcons) props
        static member inline textAlignJustifyFilled (props: IIconProp list) = createElement (import "TextAlignJustifyFilled" FluentIcons) props
        static member inline textAlignJustifyRegular (props: IIconProp list) = createElement (import "TextAlignJustifyRegular" FluentIcons) props
        static member inline textAlignJustifyLowFilled (props: IIconProp list) = createElement (import "TextAlignJustifyLowFilled" FluentIcons) props
        static member inline textAlignJustifyLowRegular (props: IIconProp list) = createElement (import "TextAlignJustifyLowRegular" FluentIcons) props
        static member inline textAlignJustifyLow90Filled (props: IIconProp list) = createElement (import "TextAlignJustifyLow90Filled" FluentIcons) props
        static member inline textAlignJustifyLow90Regular (props: IIconProp list) = createElement (import "TextAlignJustifyLow90Regular" FluentIcons) props
        static member inline textAlignJustifyLowRotate270Filled (props: IIconProp list) = createElement (import "TextAlignJustifyLowRotate270Filled" FluentIcons) props
        static member inline textAlignJustifyLowRotate270Regular (props: IIconProp list) = createElement (import "TextAlignJustifyLowRotate270Regular" FluentIcons) props
        static member inline textAlignJustifyLowRotate90Filled (props: IIconProp list) = createElement (import "TextAlignJustifyLowRotate90Filled" FluentIcons) props
        static member inline textAlignJustifyLowRotate90Regular (props: IIconProp list) = createElement (import "TextAlignJustifyLowRotate90Regular" FluentIcons) props
        static member inline textAlignJustifyRotate270Filled (props: IIconProp list) = createElement (import "TextAlignJustifyRotate270Filled" FluentIcons) props
        static member inline textAlignJustifyRotate270Regular (props: IIconProp list) = createElement (import "TextAlignJustifyRotate270Regular" FluentIcons) props
        static member inline textAlignJustifyRotate90Filled (props: IIconProp list) = createElement (import "TextAlignJustifyRotate90Filled" FluentIcons) props
        static member inline textAlignJustifyRotate90Regular (props: IIconProp list) = createElement (import "TextAlignJustifyRotate90Regular" FluentIcons) props
        static member inline textAlignLeftFilled (props: IIconProp list) = createElement (import "TextAlignLeftFilled" FluentIcons) props
        static member inline textAlignLeftRegular (props: IIconProp list) = createElement (import "TextAlignLeftRegular" FluentIcons) props
        static member inline textAlignLeftRotate270Filled (props: IIconProp list) = createElement (import "TextAlignLeftRotate270Filled" FluentIcons) props
        static member inline textAlignLeftRotate270Regular (props: IIconProp list) = createElement (import "TextAlignLeftRotate270Regular" FluentIcons) props
        static member inline textAlignLeftRotate90Filled (props: IIconProp list) = createElement (import "TextAlignLeftRotate90Filled" FluentIcons) props
        static member inline textAlignLeftRotate90Regular (props: IIconProp list) = createElement (import "TextAlignLeftRotate90Regular" FluentIcons) props
        static member inline textAlignRightFilled (props: IIconProp list) = createElement (import "TextAlignRightFilled" FluentIcons) props
        static member inline textAlignRightRegular (props: IIconProp list) = createElement (import "TextAlignRightRegular" FluentIcons) props
        static member inline textAlignRightRotate270Filled (props: IIconProp list) = createElement (import "TextAlignRightRotate270Filled" FluentIcons) props
        static member inline textAlignRightRotate270Regular (props: IIconProp list) = createElement (import "TextAlignRightRotate270Regular" FluentIcons) props
        static member inline textAlignRightRotate90Filled (props: IIconProp list) = createElement (import "TextAlignRightRotate90Filled" FluentIcons) props
        static member inline textAlignRightRotate90Regular (props: IIconProp list) = createElement (import "TextAlignRightRotate90Regular" FluentIcons) props
        static member inline textArrowDownRightColumnFilled (props: IIconProp list) = createElement (import "TextArrowDownRightColumnFilled" FluentIcons) props
        static member inline textArrowDownRightColumnRegular (props: IIconProp list) = createElement (import "TextArrowDownRightColumnRegular" FluentIcons) props
        static member inline textAsteriskFilled (props: IIconProp list) = createElement (import "TextAsteriskFilled" FluentIcons) props
        static member inline textAsteriskRegular (props: IIconProp list) = createElement (import "TextAsteriskRegular" FluentIcons) props
        static member inline textBaselineFilled (props: IIconProp list) = createElement (import "TextBaselineFilled" FluentIcons) props
        static member inline textBaselineRegular (props: IIconProp list) = createElement (import "TextBaselineRegular" FluentIcons) props
        static member inline textBoldFilled (props: IIconProp list) = createElement (import "TextBoldFilled" FluentIcons) props
        static member inline textBoldRegular (props: IIconProp list) = createElement (import "TextBoldRegular" FluentIcons) props
        static member inline textBoxSettingsFilled (props: IIconProp list) = createElement (import "TextBoxSettingsFilled" FluentIcons) props
        static member inline textBoxSettingsRegular (props: IIconProp list) = createElement (import "TextBoxSettingsRegular" FluentIcons) props
        static member inline textBulletListFilled (props: IIconProp list) = createElement (import "TextBulletListFilled" FluentIcons) props
        static member inline textBulletListRegular (props: IIconProp list) = createElement (import "TextBulletListRegular" FluentIcons) props
        static member inline textBulletList90Filled (props: IIconProp list) = createElement (import "TextBulletList90Filled" FluentIcons) props
        static member inline textBulletList90Regular (props: IIconProp list) = createElement (import "TextBulletList90Regular" FluentIcons) props
        static member inline textBulletListAddFilled (props: IIconProp list) = createElement (import "TextBulletListAddFilled" FluentIcons) props
        static member inline textBulletListAddRegular (props: IIconProp list) = createElement (import "TextBulletListAddRegular" FluentIcons) props
        static member inline textBulletListCheckmarkFilled (props: IIconProp list) = createElement (import "TextBulletListCheckmarkFilled" FluentIcons) props
        static member inline textBulletListCheckmarkRegular (props: IIconProp list) = createElement (import "TextBulletListCheckmarkRegular" FluentIcons) props
        static member inline textBulletListDismissFilled (props: IIconProp list) = createElement (import "TextBulletListDismissFilled" FluentIcons) props
        static member inline textBulletListDismissRegular (props: IIconProp list) = createElement (import "TextBulletListDismissRegular" FluentIcons) props
        static member inline textBulletListLtrFilled (props: IIconProp list) = createElement (import "TextBulletListLtrFilled" FluentIcons) props
        static member inline textBulletListLtrRegular (props: IIconProp list) = createElement (import "TextBulletListLtrRegular" FluentIcons) props
        static member inline textBulletListLtr90Filled (props: IIconProp list) = createElement (import "TextBulletListLtr90Filled" FluentIcons) props
        static member inline textBulletListLtr90Regular (props: IIconProp list) = createElement (import "TextBulletListLtr90Regular" FluentIcons) props
        static member inline textBulletListRtlFilled (props: IIconProp list) = createElement (import "TextBulletListRtlFilled" FluentIcons) props
        static member inline textBulletListRtlRegular (props: IIconProp list) = createElement (import "TextBulletListRtlRegular" FluentIcons) props
        static member inline textBulletListRtl90Filled (props: IIconProp list) = createElement (import "TextBulletListRtl90Filled" FluentIcons) props
        static member inline textBulletListRtl90Regular (props: IIconProp list) = createElement (import "TextBulletListRtl90Regular" FluentIcons) props
        static member inline textBulletListSquareFilled (props: IIconProp list) = createElement (import "TextBulletListSquareFilled" FluentIcons) props
        static member inline textBulletListSquareRegular (props: IIconProp list) = createElement (import "TextBulletListSquareRegular" FluentIcons) props
        static member inline textBulletListSquareClockFilled (props: IIconProp list) = createElement (import "TextBulletListSquareClockFilled" FluentIcons) props
        static member inline textBulletListSquareClockRegular (props: IIconProp list) = createElement (import "TextBulletListSquareClockRegular" FluentIcons) props
        static member inline textBulletListSquareEditFilled (props: IIconProp list) = createElement (import "TextBulletListSquareEditFilled" FluentIcons) props
        static member inline textBulletListSquareEditRegular (props: IIconProp list) = createElement (import "TextBulletListSquareEditRegular" FluentIcons) props
        static member inline textBulletListSquarePersonFilled (props: IIconProp list) = createElement (import "TextBulletListSquarePersonFilled" FluentIcons) props
        static member inline textBulletListSquarePersonRegular (props: IIconProp list) = createElement (import "TextBulletListSquarePersonRegular" FluentIcons) props
        static member inline textBulletListSquareSearchFilled (props: IIconProp list) = createElement (import "TextBulletListSquareSearchFilled" FluentIcons) props
        static member inline textBulletListSquareSearchRegular (props: IIconProp list) = createElement (import "TextBulletListSquareSearchRegular" FluentIcons) props
        static member inline textBulletListSquareSettingsFilled (props: IIconProp list) = createElement (import "TextBulletListSquareSettingsFilled" FluentIcons) props
        static member inline textBulletListSquareSettingsRegular (props: IIconProp list) = createElement (import "TextBulletListSquareSettingsRegular" FluentIcons) props
        static member inline textBulletListSquareShieldFilled (props: IIconProp list) = createElement (import "TextBulletListSquareShieldFilled" FluentIcons) props
        static member inline textBulletListSquareShieldRegular (props: IIconProp list) = createElement (import "TextBulletListSquareShieldRegular" FluentIcons) props
        static member inline textBulletListSquareSparkleFilled (props: IIconProp list) = createElement (import "TextBulletListSquareSparkleFilled" FluentIcons) props
        static member inline textBulletListSquareSparkleRegular (props: IIconProp list) = createElement (import "TextBulletListSquareSparkleRegular" FluentIcons) props
        static member inline textBulletListSquareToolboxFilled (props: IIconProp list) = createElement (import "TextBulletListSquareToolboxFilled" FluentIcons) props
        static member inline textBulletListSquareToolboxRegular (props: IIconProp list) = createElement (import "TextBulletListSquareToolboxRegular" FluentIcons) props
        static member inline textBulletListSquareWarningFilled (props: IIconProp list) = createElement (import "TextBulletListSquareWarningFilled" FluentIcons) props
        static member inline textBulletListSquareWarningRegular (props: IIconProp list) = createElement (import "TextBulletListSquareWarningRegular" FluentIcons) props
        static member inline textBulletListTreeFilled (props: IIconProp list) = createElement (import "TextBulletListTreeFilled" FluentIcons) props
        static member inline textBulletListTreeRegular (props: IIconProp list) = createElement (import "TextBulletListTreeRegular" FluentIcons) props
        static member inline textCaseLowercaseFilled (props: IIconProp list) = createElement (import "TextCaseLowercaseFilled" FluentIcons) props
        static member inline textCaseLowercaseRegular (props: IIconProp list) = createElement (import "TextCaseLowercaseRegular" FluentIcons) props
        static member inline textCaseTitleFilled (props: IIconProp list) = createElement (import "TextCaseTitleFilled" FluentIcons) props
        static member inline textCaseTitleRegular (props: IIconProp list) = createElement (import "TextCaseTitleRegular" FluentIcons) props
        static member inline textCaseUppercaseFilled (props: IIconProp list) = createElement (import "TextCaseUppercaseFilled" FluentIcons) props
        static member inline textCaseUppercaseRegular (props: IIconProp list) = createElement (import "TextCaseUppercaseRegular" FluentIcons) props
        static member inline textChangeCaseFilled (props: IIconProp list) = createElement (import "TextChangeCaseFilled" FluentIcons) props
        static member inline textChangeCaseRegular (props: IIconProp list) = createElement (import "TextChangeCaseRegular" FluentIcons) props
        static member inline textClearFormattingFilled (props: IIconProp list) = createElement (import "TextClearFormattingFilled" FluentIcons) props
        static member inline textClearFormattingRegular (props: IIconProp list) = createElement (import "TextClearFormattingRegular" FluentIcons) props
        static member inline textCollapseFilled (props: IIconProp list) = createElement (import "TextCollapseFilled" FluentIcons) props
        static member inline textCollapseRegular (props: IIconProp list) = createElement (import "TextCollapseRegular" FluentIcons) props
        static member inline textColorFilled (props: IIconProp list) = createElement (import "TextColorFilled" FluentIcons) props
        static member inline textColorRegular (props: IIconProp list) = createElement (import "TextColorRegular" FluentIcons) props
        static member inline textColorAccentFilled (props: IIconProp list) = createElement (import "TextColorAccentFilled" FluentIcons) props
        static member inline textColumnOneFilled (props: IIconProp list) = createElement (import "TextColumnOneFilled" FluentIcons) props
        static member inline textColumnOneRegular (props: IIconProp list) = createElement (import "TextColumnOneRegular" FluentIcons) props
        static member inline textColumnOneNarrowFilled (props: IIconProp list) = createElement (import "TextColumnOneNarrowFilled" FluentIcons) props
        static member inline textColumnOneNarrowRegular (props: IIconProp list) = createElement (import "TextColumnOneNarrowRegular" FluentIcons) props
        static member inline textColumnOneSemiNarrowFilled (props: IIconProp list) = createElement (import "TextColumnOneSemiNarrowFilled" FluentIcons) props
        static member inline textColumnOneSemiNarrowRegular (props: IIconProp list) = createElement (import "TextColumnOneSemiNarrowRegular" FluentIcons) props
        static member inline textColumnOneWideFilled (props: IIconProp list) = createElement (import "TextColumnOneWideFilled" FluentIcons) props
        static member inline textColumnOneWideRegular (props: IIconProp list) = createElement (import "TextColumnOneWideRegular" FluentIcons) props
        static member inline textColumnOneWideLightningFilled (props: IIconProp list) = createElement (import "TextColumnOneWideLightningFilled" FluentIcons) props
        static member inline textColumnOneWideLightningRegular (props: IIconProp list) = createElement (import "TextColumnOneWideLightningRegular" FluentIcons) props
        static member inline textColumnThreeFilled (props: IIconProp list) = createElement (import "TextColumnThreeFilled" FluentIcons) props
        static member inline textColumnThreeRegular (props: IIconProp list) = createElement (import "TextColumnThreeRegular" FluentIcons) props
        static member inline textColumnTwoFilled (props: IIconProp list) = createElement (import "TextColumnTwoFilled" FluentIcons) props
        static member inline textColumnTwoRegular (props: IIconProp list) = createElement (import "TextColumnTwoRegular" FluentIcons) props
        static member inline textColumnTwoLeftFilled (props: IIconProp list) = createElement (import "TextColumnTwoLeftFilled" FluentIcons) props
        static member inline textColumnTwoLeftRegular (props: IIconProp list) = createElement (import "TextColumnTwoLeftRegular" FluentIcons) props
        static member inline textColumnTwoRightFilled (props: IIconProp list) = createElement (import "TextColumnTwoRightFilled" FluentIcons) props
        static member inline textColumnTwoRightRegular (props: IIconProp list) = createElement (import "TextColumnTwoRightRegular" FluentIcons) props
        static member inline textColumnWideFilled (props: IIconProp list) = createElement (import "TextColumnWideFilled" FluentIcons) props
        static member inline textColumnWideRegular (props: IIconProp list) = createElement (import "TextColumnWideRegular" FluentIcons) props
        static member inline textContinuousFilled (props: IIconProp list) = createElement (import "TextContinuousFilled" FluentIcons) props
        static member inline textContinuousRegular (props: IIconProp list) = createElement (import "TextContinuousRegular" FluentIcons) props
        static member inline textDensityFilled (props: IIconProp list) = createElement (import "TextDensityFilled" FluentIcons) props
        static member inline textDensityRegular (props: IIconProp list) = createElement (import "TextDensityRegular" FluentIcons) props
        static member inline textDescriptionFilled (props: IIconProp list) = createElement (import "TextDescriptionFilled" FluentIcons) props
        static member inline textDescriptionRegular (props: IIconProp list) = createElement (import "TextDescriptionRegular" FluentIcons) props
        static member inline textDescriptionLtrFilled (props: IIconProp list) = createElement (import "TextDescriptionLtrFilled" FluentIcons) props
        static member inline textDescriptionLtrRegular (props: IIconProp list) = createElement (import "TextDescriptionLtrRegular" FluentIcons) props
        static member inline textDescriptionRtlFilled (props: IIconProp list) = createElement (import "TextDescriptionRtlFilled" FluentIcons) props
        static member inline textDescriptionRtlRegular (props: IIconProp list) = createElement (import "TextDescriptionRtlRegular" FluentIcons) props
        static member inline textDirectionHorizontalLeftFilled (props: IIconProp list) = createElement (import "TextDirectionHorizontalLeftFilled" FluentIcons) props
        static member inline textDirectionHorizontalLeftRegular (props: IIconProp list) = createElement (import "TextDirectionHorizontalLeftRegular" FluentIcons) props
        static member inline textDirectionHorizontalLtrFilled (props: IIconProp list) = createElement (import "TextDirectionHorizontalLtrFilled" FluentIcons) props
        static member inline textDirectionHorizontalLtrRegular (props: IIconProp list) = createElement (import "TextDirectionHorizontalLtrRegular" FluentIcons) props
        static member inline textDirectionHorizontalRightFilled (props: IIconProp list) = createElement (import "TextDirectionHorizontalRightFilled" FluentIcons) props
        static member inline textDirectionHorizontalRightRegular (props: IIconProp list) = createElement (import "TextDirectionHorizontalRightRegular" FluentIcons) props
        static member inline textDirectionHorizontalRtlFilled (props: IIconProp list) = createElement (import "TextDirectionHorizontalRtlFilled" FluentIcons) props
        static member inline textDirectionHorizontalRtlRegular (props: IIconProp list) = createElement (import "TextDirectionHorizontalRtlRegular" FluentIcons) props
        static member inline textDirectionRotate270RightFilled (props: IIconProp list) = createElement (import "TextDirectionRotate270RightFilled" FluentIcons) props
        static member inline textDirectionRotate270RightRegular (props: IIconProp list) = createElement (import "TextDirectionRotate270RightRegular" FluentIcons) props
        static member inline textDirectionRotate315RightFilled (props: IIconProp list) = createElement (import "TextDirectionRotate315RightFilled" FluentIcons) props
        static member inline textDirectionRotate315RightRegular (props: IIconProp list) = createElement (import "TextDirectionRotate315RightRegular" FluentIcons) props
        static member inline textDirectionRotate45RightFilled (props: IIconProp list) = createElement (import "TextDirectionRotate45RightFilled" FluentIcons) props
        static member inline textDirectionRotate45RightRegular (props: IIconProp list) = createElement (import "TextDirectionRotate45RightRegular" FluentIcons) props
        static member inline textDirectionRotate90LeftFilled (props: IIconProp list) = createElement (import "TextDirectionRotate90LeftFilled" FluentIcons) props
        static member inline textDirectionRotate90LeftRegular (props: IIconProp list) = createElement (import "TextDirectionRotate90LeftRegular" FluentIcons) props
        static member inline textDirectionRotate90LtrFilled (props: IIconProp list) = createElement (import "TextDirectionRotate90LtrFilled" FluentIcons) props
        static member inline textDirectionRotate90LtrRegular (props: IIconProp list) = createElement (import "TextDirectionRotate90LtrRegular" FluentIcons) props
        static member inline textDirectionRotate90RightFilled (props: IIconProp list) = createElement (import "TextDirectionRotate90RightFilled" FluentIcons) props
        static member inline textDirectionRotate90RightRegular (props: IIconProp list) = createElement (import "TextDirectionRotate90RightRegular" FluentIcons) props
        static member inline textDirectionRotate90RtlFilled (props: IIconProp list) = createElement (import "TextDirectionRotate90RtlFilled" FluentIcons) props
        static member inline textDirectionRotate90RtlRegular (props: IIconProp list) = createElement (import "TextDirectionRotate90RtlRegular" FluentIcons) props
        static member inline textDirectionVerticalFilled (props: IIconProp list) = createElement (import "TextDirectionVerticalFilled" FluentIcons) props
        static member inline textDirectionVerticalRegular (props: IIconProp list) = createElement (import "TextDirectionVerticalRegular" FluentIcons) props
        static member inline textEditStyleFilled (props: IIconProp list) = createElement (import "TextEditStyleFilled" FluentIcons) props
        static member inline textEditStyleRegular (props: IIconProp list) = createElement (import "TextEditStyleRegular" FluentIcons) props
        static member inline textEffectsFilled (props: IIconProp list) = createElement (import "TextEffectsFilled" FluentIcons) props
        static member inline textEffectsRegular (props: IIconProp list) = createElement (import "TextEffectsRegular" FluentIcons) props
        static member inline textEffectsSparkleFilled (props: IIconProp list) = createElement (import "TextEffectsSparkleFilled" FluentIcons) props
        static member inline textEffectsSparkleRegular (props: IIconProp list) = createElement (import "TextEffectsSparkleRegular" FluentIcons) props
        static member inline textExpandFilled (props: IIconProp list) = createElement (import "TextExpandFilled" FluentIcons) props
        static member inline textExpandRegular (props: IIconProp list) = createElement (import "TextExpandRegular" FluentIcons) props
        static member inline textFieldFilled (props: IIconProp list) = createElement (import "TextFieldFilled" FluentIcons) props
        static member inline textFieldRegular (props: IIconProp list) = createElement (import "TextFieldRegular" FluentIcons) props
        static member inline textFirstLineFilled (props: IIconProp list) = createElement (import "TextFirstLineFilled" FluentIcons) props
        static member inline textFirstLineRegular (props: IIconProp list) = createElement (import "TextFirstLineRegular" FluentIcons) props
        static member inline textFontFilled (props: IIconProp list) = createElement (import "TextFontFilled" FluentIcons) props
        static member inline textFontRegular (props: IIconProp list) = createElement (import "TextFontRegular" FluentIcons) props
        static member inline textFontInfoFilled (props: IIconProp list) = createElement (import "TextFontInfoFilled" FluentIcons) props
        static member inline textFontInfoRegular (props: IIconProp list) = createElement (import "TextFontInfoRegular" FluentIcons) props
        static member inline textFontSizeFilled (props: IIconProp list) = createElement (import "TextFontSizeFilled" FluentIcons) props
        static member inline textFontSizeRegular (props: IIconProp list) = createElement (import "TextFontSizeRegular" FluentIcons) props
        static member inline textFootnoteFilled (props: IIconProp list) = createElement (import "TextFootnoteFilled" FluentIcons) props
        static member inline textFootnoteRegular (props: IIconProp list) = createElement (import "TextFootnoteRegular" FluentIcons) props
        static member inline textGrammarArrowLeftFilled (props: IIconProp list) = createElement (import "TextGrammarArrowLeftFilled" FluentIcons) props
        static member inline textGrammarArrowLeftRegular (props: IIconProp list) = createElement (import "TextGrammarArrowLeftRegular" FluentIcons) props
        static member inline textGrammarArrowRightFilled (props: IIconProp list) = createElement (import "TextGrammarArrowRightFilled" FluentIcons) props
        static member inline textGrammarArrowRightRegular (props: IIconProp list) = createElement (import "TextGrammarArrowRightRegular" FluentIcons) props
        static member inline textGrammarCheckmarkFilled (props: IIconProp list) = createElement (import "TextGrammarCheckmarkFilled" FluentIcons) props
        static member inline textGrammarCheckmarkRegular (props: IIconProp list) = createElement (import "TextGrammarCheckmarkRegular" FluentIcons) props
        static member inline textGrammarDismissFilled (props: IIconProp list) = createElement (import "TextGrammarDismissFilled" FluentIcons) props
        static member inline textGrammarDismissRegular (props: IIconProp list) = createElement (import "TextGrammarDismissRegular" FluentIcons) props
        static member inline textGrammarErrorFilled (props: IIconProp list) = createElement (import "TextGrammarErrorFilled" FluentIcons) props
        static member inline textGrammarErrorRegular (props: IIconProp list) = createElement (import "TextGrammarErrorRegular" FluentIcons) props
        static member inline textGrammarLightningFilled (props: IIconProp list) = createElement (import "TextGrammarLightningFilled" FluentIcons) props
        static member inline textGrammarLightningRegular (props: IIconProp list) = createElement (import "TextGrammarLightningRegular" FluentIcons) props
        static member inline textGrammarSettingsFilled (props: IIconProp list) = createElement (import "TextGrammarSettingsFilled" FluentIcons) props
        static member inline textGrammarSettingsRegular (props: IIconProp list) = createElement (import "TextGrammarSettingsRegular" FluentIcons) props
        static member inline textGrammarWandFilled (props: IIconProp list) = createElement (import "TextGrammarWandFilled" FluentIcons) props
        static member inline textGrammarWandRegular (props: IIconProp list) = createElement (import "TextGrammarWandRegular" FluentIcons) props
        static member inline textHangingFilled (props: IIconProp list) = createElement (import "TextHangingFilled" FluentIcons) props
        static member inline textHangingRegular (props: IIconProp list) = createElement (import "TextHangingRegular" FluentIcons) props
        static member inline textHeader1Filled (props: IIconProp list) = createElement (import "TextHeader1Filled" FluentIcons) props
        static member inline textHeader1Regular (props: IIconProp list) = createElement (import "TextHeader1Regular" FluentIcons) props
        static member inline textHeader1LinesFilled (props: IIconProp list) = createElement (import "TextHeader1LinesFilled" FluentIcons) props
        static member inline textHeader1LinesRegular (props: IIconProp list) = createElement (import "TextHeader1LinesRegular" FluentIcons) props
        static member inline textHeader1LinesCaretFilled (props: IIconProp list) = createElement (import "TextHeader1LinesCaretFilled" FluentIcons) props
        static member inline textHeader1LinesCaretRegular (props: IIconProp list) = createElement (import "TextHeader1LinesCaretRegular" FluentIcons) props
        static member inline textHeader2Filled (props: IIconProp list) = createElement (import "TextHeader2Filled" FluentIcons) props
        static member inline textHeader2Regular (props: IIconProp list) = createElement (import "TextHeader2Regular" FluentIcons) props
        static member inline textHeader2LinesFilled (props: IIconProp list) = createElement (import "TextHeader2LinesFilled" FluentIcons) props
        static member inline textHeader2LinesRegular (props: IIconProp list) = createElement (import "TextHeader2LinesRegular" FluentIcons) props
        static member inline textHeader2LinesCaretFilled (props: IIconProp list) = createElement (import "TextHeader2LinesCaretFilled" FluentIcons) props
        static member inline textHeader2LinesCaretRegular (props: IIconProp list) = createElement (import "TextHeader2LinesCaretRegular" FluentIcons) props
        static member inline textHeader3Filled (props: IIconProp list) = createElement (import "TextHeader3Filled" FluentIcons) props
        static member inline textHeader3Regular (props: IIconProp list) = createElement (import "TextHeader3Regular" FluentIcons) props
        static member inline textHeader3LinesFilled (props: IIconProp list) = createElement (import "TextHeader3LinesFilled" FluentIcons) props
        static member inline textHeader3LinesRegular (props: IIconProp list) = createElement (import "TextHeader3LinesRegular" FluentIcons) props
        static member inline textHeader3LinesCaretFilled (props: IIconProp list) = createElement (import "TextHeader3LinesCaretFilled" FluentIcons) props
        static member inline textHeader3LinesCaretRegular (props: IIconProp list) = createElement (import "TextHeader3LinesCaretRegular" FluentIcons) props
        static member inline textIndentDecreaseFilled (props: IIconProp list) = createElement (import "TextIndentDecreaseFilled" FluentIcons) props
        static member inline textIndentDecreaseRegular (props: IIconProp list) = createElement (import "TextIndentDecreaseRegular" FluentIcons) props
        static member inline textIndentDecreaseLtrFilled (props: IIconProp list) = createElement (import "TextIndentDecreaseLtrFilled" FluentIcons) props
        static member inline textIndentDecreaseLtrRegular (props: IIconProp list) = createElement (import "TextIndentDecreaseLtrRegular" FluentIcons) props
        static member inline textIndentDecreaseLtr90Filled (props: IIconProp list) = createElement (import "TextIndentDecreaseLtr90Filled" FluentIcons) props
        static member inline textIndentDecreaseLtr90Regular (props: IIconProp list) = createElement (import "TextIndentDecreaseLtr90Regular" FluentIcons) props
        static member inline textIndentDecreaseLtrRotate270Filled (props: IIconProp list) = createElement (import "TextIndentDecreaseLtrRotate270Filled" FluentIcons) props
        static member inline textIndentDecreaseLtrRotate270Regular (props: IIconProp list) = createElement (import "TextIndentDecreaseLtrRotate270Regular" FluentIcons) props
        static member inline textIndentDecreaseRotate270Filled (props: IIconProp list) = createElement (import "TextIndentDecreaseRotate270Filled" FluentIcons) props
        static member inline textIndentDecreaseRotate270Regular (props: IIconProp list) = createElement (import "TextIndentDecreaseRotate270Regular" FluentIcons) props
        static member inline textIndentDecreaseRotate90Filled (props: IIconProp list) = createElement (import "TextIndentDecreaseRotate90Filled" FluentIcons) props
        static member inline textIndentDecreaseRotate90Regular (props: IIconProp list) = createElement (import "TextIndentDecreaseRotate90Regular" FluentIcons) props
        static member inline textIndentDecreaseRtlFilled (props: IIconProp list) = createElement (import "TextIndentDecreaseRtlFilled" FluentIcons) props
        static member inline textIndentDecreaseRtlRegular (props: IIconProp list) = createElement (import "TextIndentDecreaseRtlRegular" FluentIcons) props
        static member inline textIndentDecreaseRtl90Filled (props: IIconProp list) = createElement (import "TextIndentDecreaseRtl90Filled" FluentIcons) props
        static member inline textIndentDecreaseRtl90Regular (props: IIconProp list) = createElement (import "TextIndentDecreaseRtl90Regular" FluentIcons) props
        static member inline textIndentDecreaseRtlRotate270Filled (props: IIconProp list) = createElement (import "TextIndentDecreaseRtlRotate270Filled" FluentIcons) props
        static member inline textIndentDecreaseRtlRotate270Regular (props: IIconProp list) = createElement (import "TextIndentDecreaseRtlRotate270Regular" FluentIcons) props
        static member inline textIndentIncreaseFilled (props: IIconProp list) = createElement (import "TextIndentIncreaseFilled" FluentIcons) props
        static member inline textIndentIncreaseRegular (props: IIconProp list) = createElement (import "TextIndentIncreaseRegular" FluentIcons) props
        static member inline textIndentIncreaseLtrFilled (props: IIconProp list) = createElement (import "TextIndentIncreaseLtrFilled" FluentIcons) props
        static member inline textIndentIncreaseLtrRegular (props: IIconProp list) = createElement (import "TextIndentIncreaseLtrRegular" FluentIcons) props
        static member inline textIndentIncreaseLtr90Filled (props: IIconProp list) = createElement (import "TextIndentIncreaseLtr90Filled" FluentIcons) props
        static member inline textIndentIncreaseLtr90Regular (props: IIconProp list) = createElement (import "TextIndentIncreaseLtr90Regular" FluentIcons) props
        static member inline textIndentIncreaseLtrRotate270Filled (props: IIconProp list) = createElement (import "TextIndentIncreaseLtrRotate270Filled" FluentIcons) props
        static member inline textIndentIncreaseLtrRotate270Regular (props: IIconProp list) = createElement (import "TextIndentIncreaseLtrRotate270Regular" FluentIcons) props
        static member inline textIndentIncreaseRotate270Filled (props: IIconProp list) = createElement (import "TextIndentIncreaseRotate270Filled" FluentIcons) props
        static member inline textIndentIncreaseRotate270Regular (props: IIconProp list) = createElement (import "TextIndentIncreaseRotate270Regular" FluentIcons) props
        static member inline textIndentIncreaseRotate90Filled (props: IIconProp list) = createElement (import "TextIndentIncreaseRotate90Filled" FluentIcons) props
        static member inline textIndentIncreaseRotate90Regular (props: IIconProp list) = createElement (import "TextIndentIncreaseRotate90Regular" FluentIcons) props
        static member inline textIndentIncreaseRtlFilled (props: IIconProp list) = createElement (import "TextIndentIncreaseRtlFilled" FluentIcons) props
        static member inline textIndentIncreaseRtlRegular (props: IIconProp list) = createElement (import "TextIndentIncreaseRtlRegular" FluentIcons) props
        static member inline textIndentIncreaseRtl90Filled (props: IIconProp list) = createElement (import "TextIndentIncreaseRtl90Filled" FluentIcons) props
        static member inline textIndentIncreaseRtl90Regular (props: IIconProp list) = createElement (import "TextIndentIncreaseRtl90Regular" FluentIcons) props
        static member inline textIndentIncreaseRtlRotate270Filled (props: IIconProp list) = createElement (import "TextIndentIncreaseRtlRotate270Filled" FluentIcons) props
        static member inline textIndentIncreaseRtlRotate270Regular (props: IIconProp list) = createElement (import "TextIndentIncreaseRtlRotate270Regular" FluentIcons) props
        static member inline textItalicFilled (props: IIconProp list) = createElement (import "TextItalicFilled" FluentIcons) props
        static member inline textItalicRegular (props: IIconProp list) = createElement (import "TextItalicRegular" FluentIcons) props
        static member inline textLineSpacingFilled (props: IIconProp list) = createElement (import "TextLineSpacingFilled" FluentIcons) props
        static member inline textLineSpacingRegular (props: IIconProp list) = createElement (import "TextLineSpacingRegular" FluentIcons) props
        static member inline textMoreFilled (props: IIconProp list) = createElement (import "TextMoreFilled" FluentIcons) props
        static member inline textMoreRegular (props: IIconProp list) = createElement (import "TextMoreRegular" FluentIcons) props
        static member inline textNumberFormatFilled (props: IIconProp list) = createElement (import "TextNumberFormatFilled" FluentIcons) props
        static member inline textNumberFormatRegular (props: IIconProp list) = createElement (import "TextNumberFormatRegular" FluentIcons) props
        static member inline textNumberListLtrFilled (props: IIconProp list) = createElement (import "TextNumberListLtrFilled" FluentIcons) props
        static member inline textNumberListLtrRegular (props: IIconProp list) = createElement (import "TextNumberListLtrRegular" FluentIcons) props
        static member inline textNumberListLtr90Filled (props: IIconProp list) = createElement (import "TextNumberListLtr90Filled" FluentIcons) props
        static member inline textNumberListLtr90Regular (props: IIconProp list) = createElement (import "TextNumberListLtr90Regular" FluentIcons) props
        static member inline textNumberListLtrRotate270Filled (props: IIconProp list) = createElement (import "TextNumberListLtrRotate270Filled" FluentIcons) props
        static member inline textNumberListLtrRotate270Regular (props: IIconProp list) = createElement (import "TextNumberListLtrRotate270Regular" FluentIcons) props
        static member inline textNumberListRotate270Filled (props: IIconProp list) = createElement (import "TextNumberListRotate270Filled" FluentIcons) props
        static member inline textNumberListRotate270Regular (props: IIconProp list) = createElement (import "TextNumberListRotate270Regular" FluentIcons) props
        static member inline textNumberListRotate90Filled (props: IIconProp list) = createElement (import "TextNumberListRotate90Filled" FluentIcons) props
        static member inline textNumberListRotate90Regular (props: IIconProp list) = createElement (import "TextNumberListRotate90Regular" FluentIcons) props
        static member inline textNumberListRtlFilled (props: IIconProp list) = createElement (import "TextNumberListRtlFilled" FluentIcons) props
        static member inline textNumberListRtlRegular (props: IIconProp list) = createElement (import "TextNumberListRtlRegular" FluentIcons) props
        static member inline textNumberListRtl90Filled (props: IIconProp list) = createElement (import "TextNumberListRtl90Filled" FluentIcons) props
        static member inline textNumberListRtl90Regular (props: IIconProp list) = createElement (import "TextNumberListRtl90Regular" FluentIcons) props
        static member inline textNumberListRtlRotate270Filled (props: IIconProp list) = createElement (import "TextNumberListRtlRotate270Filled" FluentIcons) props
        static member inline textNumberListRtlRotate270Regular (props: IIconProp list) = createElement (import "TextNumberListRtlRotate270Regular" FluentIcons) props
        static member inline textParagraphFilled (props: IIconProp list) = createElement (import "TextParagraphFilled" FluentIcons) props
        static member inline textParagraphRegular (props: IIconProp list) = createElement (import "TextParagraphRegular" FluentIcons) props
        static member inline textParagraphDirectionFilled (props: IIconProp list) = createElement (import "TextParagraphDirectionFilled" FluentIcons) props
        static member inline textParagraphDirectionRegular (props: IIconProp list) = createElement (import "TextParagraphDirectionRegular" FluentIcons) props
        static member inline textParagraphDirectionLeftFilled (props: IIconProp list) = createElement (import "TextParagraphDirectionLeftFilled" FluentIcons) props
        static member inline textParagraphDirectionLeftRegular (props: IIconProp list) = createElement (import "TextParagraphDirectionLeftRegular" FluentIcons) props
        static member inline textParagraphDirectionRightFilled (props: IIconProp list) = createElement (import "TextParagraphDirectionRightFilled" FluentIcons) props
        static member inline textParagraphDirectionRightRegular (props: IIconProp list) = createElement (import "TextParagraphDirectionRightRegular" FluentIcons) props
        static member inline textPeriodAsteriskFilled (props: IIconProp list) = createElement (import "TextPeriodAsteriskFilled" FluentIcons) props
        static member inline textPeriodAsteriskRegular (props: IIconProp list) = createElement (import "TextPeriodAsteriskRegular" FluentIcons) props
        static member inline textPositionBehindFilled (props: IIconProp list) = createElement (import "TextPositionBehindFilled" FluentIcons) props
        static member inline textPositionBehindRegular (props: IIconProp list) = createElement (import "TextPositionBehindRegular" FluentIcons) props
        static member inline textPositionFrontFilled (props: IIconProp list) = createElement (import "TextPositionFrontFilled" FluentIcons) props
        static member inline textPositionFrontRegular (props: IIconProp list) = createElement (import "TextPositionFrontRegular" FluentIcons) props
        static member inline textPositionLineFilled (props: IIconProp list) = createElement (import "TextPositionLineFilled" FluentIcons) props
        static member inline textPositionLineRegular (props: IIconProp list) = createElement (import "TextPositionLineRegular" FluentIcons) props
        static member inline textPositionSquareFilled (props: IIconProp list) = createElement (import "TextPositionSquareFilled" FluentIcons) props
        static member inline textPositionSquareRegular (props: IIconProp list) = createElement (import "TextPositionSquareRegular" FluentIcons) props
        static member inline textPositionSquareLeftFilled (props: IIconProp list) = createElement (import "TextPositionSquareLeftFilled" FluentIcons) props
        static member inline textPositionSquareLeftRegular (props: IIconProp list) = createElement (import "TextPositionSquareLeftRegular" FluentIcons) props
        static member inline textPositionSquareRightFilled (props: IIconProp list) = createElement (import "TextPositionSquareRightFilled" FluentIcons) props
        static member inline textPositionSquareRightRegular (props: IIconProp list) = createElement (import "TextPositionSquareRightRegular" FluentIcons) props
        static member inline textPositionThroughFilled (props: IIconProp list) = createElement (import "TextPositionThroughFilled" FluentIcons) props
        static member inline textPositionThroughRegular (props: IIconProp list) = createElement (import "TextPositionThroughRegular" FluentIcons) props
        static member inline textPositionTightFilled (props: IIconProp list) = createElement (import "TextPositionTightFilled" FluentIcons) props
        static member inline textPositionTightRegular (props: IIconProp list) = createElement (import "TextPositionTightRegular" FluentIcons) props
        static member inline textPositionTopBottomFilled (props: IIconProp list) = createElement (import "TextPositionTopBottomFilled" FluentIcons) props
        static member inline textPositionTopBottomRegular (props: IIconProp list) = createElement (import "TextPositionTopBottomRegular" FluentIcons) props
        static member inline textProofingToolsFilled (props: IIconProp list) = createElement (import "TextProofingToolsFilled" FluentIcons) props
        static member inline textProofingToolsRegular (props: IIconProp list) = createElement (import "TextProofingToolsRegular" FluentIcons) props
        static member inline textQuoteFilled (props: IIconProp list) = createElement (import "TextQuoteFilled" FluentIcons) props
        static member inline textQuoteRegular (props: IIconProp list) = createElement (import "TextQuoteRegular" FluentIcons) props
        static member inline textSortAscendingFilled (props: IIconProp list) = createElement (import "TextSortAscendingFilled" FluentIcons) props
        static member inline textSortAscendingRegular (props: IIconProp list) = createElement (import "TextSortAscendingRegular" FluentIcons) props
        static member inline textSortDescendingFilled (props: IIconProp list) = createElement (import "TextSortDescendingFilled" FluentIcons) props
        static member inline textSortDescendingRegular (props: IIconProp list) = createElement (import "TextSortDescendingRegular" FluentIcons) props
        static member inline textStrikethroughFilled (props: IIconProp list) = createElement (import "TextStrikethroughFilled" FluentIcons) props
        static member inline textStrikethroughRegular (props: IIconProp list) = createElement (import "TextStrikethroughRegular" FluentIcons) props
        static member inline textSubscriptFilled (props: IIconProp list) = createElement (import "TextSubscriptFilled" FluentIcons) props
        static member inline textSubscriptRegular (props: IIconProp list) = createElement (import "TextSubscriptRegular" FluentIcons) props
        static member inline textSuperscriptFilled (props: IIconProp list) = createElement (import "TextSuperscriptFilled" FluentIcons) props
        static member inline textSuperscriptRegular (props: IIconProp list) = createElement (import "TextSuperscriptRegular" FluentIcons) props
        static member inline textTFilled (props: IIconProp list) = createElement (import "TextTFilled" FluentIcons) props
        static member inline textTRegular (props: IIconProp list) = createElement (import "TextTRegular" FluentIcons) props
        static member inline textUnderlineFilled (props: IIconProp list) = createElement (import "TextUnderlineFilled" FluentIcons) props
        static member inline textUnderlineRegular (props: IIconProp list) = createElement (import "TextUnderlineRegular" FluentIcons) props
        static member inline textUnderlineCharacterUFilled (props: IIconProp list) = createElement (import "TextUnderlineCharacterUFilled" FluentIcons) props
        static member inline textUnderlineCharacterURegular (props: IIconProp list) = createElement (import "TextUnderlineCharacterURegular" FluentIcons) props
        static member inline textUnderlineDoubleFilled (props: IIconProp list) = createElement (import "TextUnderlineDoubleFilled" FluentIcons) props
        static member inline textUnderlineDoubleRegular (props: IIconProp list) = createElement (import "TextUnderlineDoubleRegular" FluentIcons) props
        static member inline textWholeWordFilled (props: IIconProp list) = createElement (import "TextWholeWordFilled" FluentIcons) props
        static member inline textWholeWordRegular (props: IIconProp list) = createElement (import "TextWholeWordRegular" FluentIcons) props
        static member inline textWordCountFilled (props: IIconProp list) = createElement (import "TextWordCountFilled" FluentIcons) props
        static member inline textWordCountRegular (props: IIconProp list) = createElement (import "TextWordCountRegular" FluentIcons) props
        static member inline textWrapFilled (props: IIconProp list) = createElement (import "TextWrapFilled" FluentIcons) props
        static member inline textWrapRegular (props: IIconProp list) = createElement (import "TextWrapRegular" FluentIcons) props
        static member inline textWrapOffFilled (props: IIconProp list) = createElement (import "TextWrapOffFilled" FluentIcons) props
        static member inline textWrapOffRegular (props: IIconProp list) = createElement (import "TextWrapOffRegular" FluentIcons) props
        static member inline textboxFilled (props: IIconProp list) = createElement (import "TextboxFilled" FluentIcons) props
        static member inline textboxRegular (props: IIconProp list) = createElement (import "TextboxRegular" FluentIcons) props
        static member inline textboxAlignBottomFilled (props: IIconProp list) = createElement (import "TextboxAlignBottomFilled" FluentIcons) props
        static member inline textboxAlignBottomRegular (props: IIconProp list) = createElement (import "TextboxAlignBottomRegular" FluentIcons) props
        static member inline textboxAlignBottomCenterFilled (props: IIconProp list) = createElement (import "TextboxAlignBottomCenterFilled" FluentIcons) props
        static member inline textboxAlignBottomCenterRegular (props: IIconProp list) = createElement (import "TextboxAlignBottomCenterRegular" FluentIcons) props
        static member inline textboxAlignBottomLeftFilled (props: IIconProp list) = createElement (import "TextboxAlignBottomLeftFilled" FluentIcons) props
        static member inline textboxAlignBottomLeftRegular (props: IIconProp list) = createElement (import "TextboxAlignBottomLeftRegular" FluentIcons) props
        static member inline textboxAlignBottomRightFilled (props: IIconProp list) = createElement (import "TextboxAlignBottomRightFilled" FluentIcons) props
        static member inline textboxAlignBottomRightRegular (props: IIconProp list) = createElement (import "TextboxAlignBottomRightRegular" FluentIcons) props
        static member inline textboxAlignBottomRotate90Filled (props: IIconProp list) = createElement (import "TextboxAlignBottomRotate90Filled" FluentIcons) props
        static member inline textboxAlignBottomRotate90Regular (props: IIconProp list) = createElement (import "TextboxAlignBottomRotate90Regular" FluentIcons) props
        static member inline textboxAlignCenterFilled (props: IIconProp list) = createElement (import "TextboxAlignCenterFilled" FluentIcons) props
        static member inline textboxAlignCenterRegular (props: IIconProp list) = createElement (import "TextboxAlignCenterRegular" FluentIcons) props
        static member inline textboxAlignMiddleFilled (props: IIconProp list) = createElement (import "TextboxAlignMiddleFilled" FluentIcons) props
        static member inline textboxAlignMiddleRegular (props: IIconProp list) = createElement (import "TextboxAlignMiddleRegular" FluentIcons) props
        static member inline textboxAlignMiddleLeftFilled (props: IIconProp list) = createElement (import "TextboxAlignMiddleLeftFilled" FluentIcons) props
        static member inline textboxAlignMiddleLeftRegular (props: IIconProp list) = createElement (import "TextboxAlignMiddleLeftRegular" FluentIcons) props
        static member inline textboxAlignMiddleRightFilled (props: IIconProp list) = createElement (import "TextboxAlignMiddleRightFilled" FluentIcons) props
        static member inline textboxAlignMiddleRightRegular (props: IIconProp list) = createElement (import "TextboxAlignMiddleRightRegular" FluentIcons) props
        static member inline textboxAlignMiddleRotate90Filled (props: IIconProp list) = createElement (import "TextboxAlignMiddleRotate90Filled" FluentIcons) props
        static member inline textboxAlignMiddleRotate90Regular (props: IIconProp list) = createElement (import "TextboxAlignMiddleRotate90Regular" FluentIcons) props
        static member inline textboxAlignTopFilled (props: IIconProp list) = createElement (import "TextboxAlignTopFilled" FluentIcons) props
        static member inline textboxAlignTopRegular (props: IIconProp list) = createElement (import "TextboxAlignTopRegular" FluentIcons) props
        static member inline textboxAlignTopCenterFilled (props: IIconProp list) = createElement (import "TextboxAlignTopCenterFilled" FluentIcons) props
        static member inline textboxAlignTopCenterRegular (props: IIconProp list) = createElement (import "TextboxAlignTopCenterRegular" FluentIcons) props
        static member inline textboxAlignTopLeftFilled (props: IIconProp list) = createElement (import "TextboxAlignTopLeftFilled" FluentIcons) props
        static member inline textboxAlignTopLeftRegular (props: IIconProp list) = createElement (import "TextboxAlignTopLeftRegular" FluentIcons) props
        static member inline textboxAlignTopRightFilled (props: IIconProp list) = createElement (import "TextboxAlignTopRightFilled" FluentIcons) props
        static member inline textboxAlignTopRightRegular (props: IIconProp list) = createElement (import "TextboxAlignTopRightRegular" FluentIcons) props
        static member inline textboxAlignTopRotate90Filled (props: IIconProp list) = createElement (import "TextboxAlignTopRotate90Filled" FluentIcons) props
        static member inline textboxAlignTopRotate90Regular (props: IIconProp list) = createElement (import "TextboxAlignTopRotate90Regular" FluentIcons) props
        static member inline textboxMoreFilled (props: IIconProp list) = createElement (import "TextboxMoreFilled" FluentIcons) props
        static member inline textboxMoreRegular (props: IIconProp list) = createElement (import "TextboxMoreRegular" FluentIcons) props
        static member inline textboxRotate90Filled (props: IIconProp list) = createElement (import "TextboxRotate90Filled" FluentIcons) props
        static member inline textboxRotate90Regular (props: IIconProp list) = createElement (import "TextboxRotate90Regular" FluentIcons) props
        static member inline textboxSettingsFilled (props: IIconProp list) = createElement (import "TextboxSettingsFilled" FluentIcons) props
        static member inline textboxSettingsRegular (props: IIconProp list) = createElement (import "TextboxSettingsRegular" FluentIcons) props
        static member inline thinkingFilled (props: IIconProp list) = createElement (import "ThinkingFilled" FluentIcons) props
        static member inline thinkingRegular (props: IIconProp list) = createElement (import "ThinkingRegular" FluentIcons) props
        static member inline thumbDislikeFilled (props: IIconProp list) = createElement (import "ThumbDislikeFilled" FluentIcons) props
        static member inline thumbDislikeRegular (props: IIconProp list) = createElement (import "ThumbDislikeRegular" FluentIcons) props
        static member inline thumbLikeFilled (props: IIconProp list) = createElement (import "ThumbLikeFilled" FluentIcons) props
        static member inline thumbLikeRegular (props: IIconProp list) = createElement (import "ThumbLikeRegular" FluentIcons) props
        static member inline thumbLikeDislikeFilled (props: IIconProp list) = createElement (import "ThumbLikeDislikeFilled" FluentIcons) props
        static member inline thumbLikeDislikeRegular (props: IIconProp list) = createElement (import "ThumbLikeDislikeRegular" FluentIcons) props
        static member inline ticketDiagonalFilled (props: IIconProp list) = createElement (import "TicketDiagonalFilled" FluentIcons) props
        static member inline ticketDiagonalRegular (props: IIconProp list) = createElement (import "TicketDiagonalRegular" FluentIcons) props
        static member inline ticketHorizontalFilled (props: IIconProp list) = createElement (import "TicketHorizontalFilled" FluentIcons) props
        static member inline ticketHorizontalRegular (props: IIconProp list) = createElement (import "TicketHorizontalRegular" FluentIcons) props
        static member inline timeAndWeatherFilled (props: IIconProp list) = createElement (import "TimeAndWeatherFilled" FluentIcons) props
        static member inline timeAndWeatherRegular (props: IIconProp list) = createElement (import "TimeAndWeatherRegular" FluentIcons) props
        static member inline timePickerFilled (props: IIconProp list) = createElement (import "TimePickerFilled" FluentIcons) props
        static member inline timePickerRegular (props: IIconProp list) = createElement (import "TimePickerRegular" FluentIcons) props
        static member inline timelineFilled (props: IIconProp list) = createElement (import "TimelineFilled" FluentIcons) props
        static member inline timelineRegular (props: IIconProp list) = createElement (import "TimelineRegular" FluentIcons) props
        static member inline timer10Filled (props: IIconProp list) = createElement (import "Timer10Filled" FluentIcons) props
        static member inline timer10Regular (props: IIconProp list) = createElement (import "Timer10Regular" FluentIcons) props
        static member inline timerFilled (props: IIconProp list) = createElement (import "TimerFilled" FluentIcons) props
        static member inline timerRegular (props: IIconProp list) = createElement (import "TimerRegular" FluentIcons) props
        static member inline timer2Filled (props: IIconProp list) = createElement (import "Timer2Filled" FluentIcons) props
        static member inline timer2Regular (props: IIconProp list) = createElement (import "Timer2Regular" FluentIcons) props
        static member inline timer3Filled (props: IIconProp list) = createElement (import "Timer3Filled" FluentIcons) props
        static member inline timer3Regular (props: IIconProp list) = createElement (import "Timer3Regular" FluentIcons) props
        static member inline timerOffFilled (props: IIconProp list) = createElement (import "TimerOffFilled" FluentIcons) props
        static member inline timerOffRegular (props: IIconProp list) = createElement (import "TimerOffRegular" FluentIcons) props
        static member inline toggleLeftFilled (props: IIconProp list) = createElement (import "ToggleLeftFilled" FluentIcons) props
        static member inline toggleLeftRegular (props: IIconProp list) = createElement (import "ToggleLeftRegular" FluentIcons) props
        static member inline toggleMultipleFilled (props: IIconProp list) = createElement (import "ToggleMultipleFilled" FluentIcons) props
        static member inline toggleMultipleRegular (props: IIconProp list) = createElement (import "ToggleMultipleRegular" FluentIcons) props
        static member inline toggleRightFilled (props: IIconProp list) = createElement (import "ToggleRightFilled" FluentIcons) props
        static member inline toggleRightRegular (props: IIconProp list) = createElement (import "ToggleRightRegular" FluentIcons) props
        static member inline toolboxFilled (props: IIconProp list) = createElement (import "ToolboxFilled" FluentIcons) props
        static member inline toolboxRegular (props: IIconProp list) = createElement (import "ToolboxRegular" FluentIcons) props
        static member inline tooltipQuoteFilled (props: IIconProp list) = createElement (import "TooltipQuoteFilled" FluentIcons) props
        static member inline tooltipQuoteRegular (props: IIconProp list) = createElement (import "TooltipQuoteRegular" FluentIcons) props
        static member inline topSpeedFilled (props: IIconProp list) = createElement (import "TopSpeedFilled" FluentIcons) props
        static member inline topSpeedRegular (props: IIconProp list) = createElement (import "TopSpeedRegular" FluentIcons) props
        static member inline translateFilled (props: IIconProp list) = createElement (import "TranslateFilled" FluentIcons) props
        static member inline translateRegular (props: IIconProp list) = createElement (import "TranslateRegular" FluentIcons) props
        static member inline translateAutoFilled (props: IIconProp list) = createElement (import "TranslateAutoFilled" FluentIcons) props
        static member inline translateAutoRegular (props: IIconProp list) = createElement (import "TranslateAutoRegular" FluentIcons) props
        static member inline translateOffFilled (props: IIconProp list) = createElement (import "TranslateOffFilled" FluentIcons) props
        static member inline translateOffRegular (props: IIconProp list) = createElement (import "TranslateOffRegular" FluentIcons) props
        static member inline transmissionFilled (props: IIconProp list) = createElement (import "TransmissionFilled" FluentIcons) props
        static member inline transmissionRegular (props: IIconProp list) = createElement (import "TransmissionRegular" FluentIcons) props
        static member inline transparencySquareFilled (props: IIconProp list) = createElement (import "TransparencySquareFilled" FluentIcons) props
        static member inline transparencySquareRegular (props: IIconProp list) = createElement (import "TransparencySquareRegular" FluentIcons) props
        static member inline trayItemAddFilled (props: IIconProp list) = createElement (import "TrayItemAddFilled" FluentIcons) props
        static member inline trayItemAddRegular (props: IIconProp list) = createElement (import "TrayItemAddRegular" FluentIcons) props
        static member inline trayItemRemoveFilled (props: IIconProp list) = createElement (import "TrayItemRemoveFilled" FluentIcons) props
        static member inline trayItemRemoveRegular (props: IIconProp list) = createElement (import "TrayItemRemoveRegular" FluentIcons) props
        static member inline treeDeciduousFilled (props: IIconProp list) = createElement (import "TreeDeciduousFilled" FluentIcons) props
        static member inline treeDeciduousRegular (props: IIconProp list) = createElement (import "TreeDeciduousRegular" FluentIcons) props
        static member inline treeEvergreenFilled (props: IIconProp list) = createElement (import "TreeEvergreenFilled" FluentIcons) props
        static member inline treeEvergreenRegular (props: IIconProp list) = createElement (import "TreeEvergreenRegular" FluentIcons) props
        static member inline triangleFilled (props: IIconProp list) = createElement (import "TriangleFilled" FluentIcons) props
        static member inline triangleRegular (props: IIconProp list) = createElement (import "TriangleRegular" FluentIcons) props
        static member inline triangleDownFilled (props: IIconProp list) = createElement (import "TriangleDownFilled" FluentIcons) props
        static member inline triangleDownRegular (props: IIconProp list) = createElement (import "TriangleDownRegular" FluentIcons) props
        static member inline triangleLeftFilled (props: IIconProp list) = createElement (import "TriangleLeftFilled" FluentIcons) props
        static member inline triangleLeftRegular (props: IIconProp list) = createElement (import "TriangleLeftRegular" FluentIcons) props
        static member inline triangleRightFilled (props: IIconProp list) = createElement (import "TriangleRightFilled" FluentIcons) props
        static member inline triangleRightRegular (props: IIconProp list) = createElement (import "TriangleRightRegular" FluentIcons) props
        static member inline triangleUpFilled (props: IIconProp list) = createElement (import "TriangleUpFilled" FluentIcons) props
        static member inline triangleUpRegular (props: IIconProp list) = createElement (import "TriangleUpRegular" FluentIcons) props
        static member inline trophyFilled (props: IIconProp list) = createElement (import "TrophyFilled" FluentIcons) props
        static member inline trophyRegular (props: IIconProp list) = createElement (import "TrophyRegular" FluentIcons) props
        static member inline trophyLockFilled (props: IIconProp list) = createElement (import "TrophyLockFilled" FluentIcons) props
        static member inline trophyLockRegular (props: IIconProp list) = createElement (import "TrophyLockRegular" FluentIcons) props
        static member inline trophyOffFilled (props: IIconProp list) = createElement (import "TrophyOffFilled" FluentIcons) props
        static member inline trophyOffRegular (props: IIconProp list) = createElement (import "TrophyOffRegular" FluentIcons) props
        static member inline tvFilled (props: IIconProp list) = createElement (import "TvFilled" FluentIcons) props
        static member inline tvRegular (props: IIconProp list) = createElement (import "TvRegular" FluentIcons) props
        static member inline tvArrowRightFilled (props: IIconProp list) = createElement (import "TvArrowRightFilled" FluentIcons) props
        static member inline tvArrowRightRegular (props: IIconProp list) = createElement (import "TvArrowRightRegular" FluentIcons) props
        static member inline tvUsbFilled (props: IIconProp list) = createElement (import "TvUsbFilled" FluentIcons) props
        static member inline tvUsbRegular (props: IIconProp list) = createElement (import "TvUsbRegular" FluentIcons) props
        static member inline umbrellaFilled (props: IIconProp list) = createElement (import "UmbrellaFilled" FluentIcons) props
        static member inline umbrellaRegular (props: IIconProp list) = createElement (import "UmbrellaRegular" FluentIcons) props
        static member inline uninstallAppFilled (props: IIconProp list) = createElement (import "UninstallAppFilled" FluentIcons) props
        static member inline uninstallAppRegular (props: IIconProp list) = createElement (import "UninstallAppRegular" FluentIcons) props
        static member inline usbPlugFilled (props: IIconProp list) = createElement (import "UsbPlugFilled" FluentIcons) props
        static member inline usbPlugRegular (props: IIconProp list) = createElement (import "UsbPlugRegular" FluentIcons) props
        static member inline usbStickFilled (props: IIconProp list) = createElement (import "UsbStickFilled" FluentIcons) props
        static member inline usbStickRegular (props: IIconProp list) = createElement (import "UsbStickRegular" FluentIcons) props
        static member inline vaultFilled (props: IIconProp list) = createElement (import "VaultFilled" FluentIcons) props
        static member inline vaultRegular (props: IIconProp list) = createElement (import "VaultRegular" FluentIcons) props
        static member inline vehicleBicycleFilled (props: IIconProp list) = createElement (import "VehicleBicycleFilled" FluentIcons) props
        static member inline vehicleBicycleRegular (props: IIconProp list) = createElement (import "VehicleBicycleRegular" FluentIcons) props
        static member inline vehicleBusFilled (props: IIconProp list) = createElement (import "VehicleBusFilled" FluentIcons) props
        static member inline vehicleBusRegular (props: IIconProp list) = createElement (import "VehicleBusRegular" FluentIcons) props
        static member inline vehicleCabFilled (props: IIconProp list) = createElement (import "VehicleCabFilled" FluentIcons) props
        static member inline vehicleCabRegular (props: IIconProp list) = createElement (import "VehicleCabRegular" FluentIcons) props
        static member inline vehicleCableCarFilled (props: IIconProp list) = createElement (import "VehicleCableCarFilled" FluentIcons) props
        static member inline vehicleCableCarRegular (props: IIconProp list) = createElement (import "VehicleCableCarRegular" FluentIcons) props
        static member inline vehicleCarFilled (props: IIconProp list) = createElement (import "VehicleCarFilled" FluentIcons) props
        static member inline vehicleCarRegular (props: IIconProp list) = createElement (import "VehicleCarRegular" FluentIcons) props
        static member inline vehicleCarCollisionFilled (props: IIconProp list) = createElement (import "VehicleCarCollisionFilled" FluentIcons) props
        static member inline vehicleCarCollisionRegular (props: IIconProp list) = createElement (import "VehicleCarCollisionRegular" FluentIcons) props
        static member inline vehicleCarParkingFilled (props: IIconProp list) = createElement (import "VehicleCarParkingFilled" FluentIcons) props
        static member inline vehicleCarParkingRegular (props: IIconProp list) = createElement (import "VehicleCarParkingRegular" FluentIcons) props
        static member inline vehicleCarProfileFilled (props: IIconProp list) = createElement (import "VehicleCarProfileFilled" FluentIcons) props
        static member inline vehicleCarProfileRegular (props: IIconProp list) = createElement (import "VehicleCarProfileRegular" FluentIcons) props
        static member inline vehicleCarProfileLtrFilled (props: IIconProp list) = createElement (import "VehicleCarProfileLtrFilled" FluentIcons) props
        static member inline vehicleCarProfileLtrRegular (props: IIconProp list) = createElement (import "VehicleCarProfileLtrRegular" FluentIcons) props
        static member inline vehicleCarProfileLtrClockFilled (props: IIconProp list) = createElement (import "VehicleCarProfileLtrClockFilled" FluentIcons) props
        static member inline vehicleCarProfileLtrClockRegular (props: IIconProp list) = createElement (import "VehicleCarProfileLtrClockRegular" FluentIcons) props
        static member inline vehicleCarProfileRtlFilled (props: IIconProp list) = createElement (import "VehicleCarProfileRtlFilled" FluentIcons) props
        static member inline vehicleCarProfileRtlRegular (props: IIconProp list) = createElement (import "VehicleCarProfileRtlRegular" FluentIcons) props
        static member inline vehicleMotorcycleFilled (props: IIconProp list) = createElement (import "VehicleMotorcycleFilled" FluentIcons) props
        static member inline vehicleMotorcycleRegular (props: IIconProp list) = createElement (import "VehicleMotorcycleRegular" FluentIcons) props
        static member inline vehicleShipFilled (props: IIconProp list) = createElement (import "VehicleShipFilled" FluentIcons) props
        static member inline vehicleShipRegular (props: IIconProp list) = createElement (import "VehicleShipRegular" FluentIcons) props
        static member inline vehicleSubwayFilled (props: IIconProp list) = createElement (import "VehicleSubwayFilled" FluentIcons) props
        static member inline vehicleSubwayRegular (props: IIconProp list) = createElement (import "VehicleSubwayRegular" FluentIcons) props
        static member inline vehicleSubwayClockFilled (props: IIconProp list) = createElement (import "VehicleSubwayClockFilled" FluentIcons) props
        static member inline vehicleSubwayClockRegular (props: IIconProp list) = createElement (import "VehicleSubwayClockRegular" FluentIcons) props
        static member inline vehicleTractorFilled (props: IIconProp list) = createElement (import "VehicleTractorFilled" FluentIcons) props
        static member inline vehicleTractorRegular (props: IIconProp list) = createElement (import "VehicleTractorRegular" FluentIcons) props
        static member inline vehicleTruckFilled (props: IIconProp list) = createElement (import "VehicleTruckFilled" FluentIcons) props
        static member inline vehicleTruckRegular (props: IIconProp list) = createElement (import "VehicleTruckRegular" FluentIcons) props
        static member inline vehicleTruckBagFilled (props: IIconProp list) = createElement (import "VehicleTruckBagFilled" FluentIcons) props
        static member inline vehicleTruckBagRegular (props: IIconProp list) = createElement (import "VehicleTruckBagRegular" FluentIcons) props
        static member inline vehicleTruckCubeFilled (props: IIconProp list) = createElement (import "VehicleTruckCubeFilled" FluentIcons) props
        static member inline vehicleTruckCubeRegular (props: IIconProp list) = createElement (import "VehicleTruckCubeRegular" FluentIcons) props
        static member inline vehicleTruckProfileFilled (props: IIconProp list) = createElement (import "VehicleTruckProfileFilled" FluentIcons) props
        static member inline vehicleTruckProfileRegular (props: IIconProp list) = createElement (import "VehicleTruckProfileRegular" FluentIcons) props
        static member inline videoFilled (props: IIconProp list) = createElement (import "VideoFilled" FluentIcons) props
        static member inline videoRegular (props: IIconProp list) = createElement (import "VideoRegular" FluentIcons) props
        static member inline video360Filled (props: IIconProp list) = createElement (import "Video360Filled" FluentIcons) props
        static member inline video360Regular (props: IIconProp list) = createElement (import "Video360Regular" FluentIcons) props
        static member inline video360OffFilled (props: IIconProp list) = createElement (import "Video360OffFilled" FluentIcons) props
        static member inline video360OffRegular (props: IIconProp list) = createElement (import "Video360OffRegular" FluentIcons) props
        static member inline videoAddFilled (props: IIconProp list) = createElement (import "VideoAddFilled" FluentIcons) props
        static member inline videoAddRegular (props: IIconProp list) = createElement (import "VideoAddRegular" FluentIcons) props
        static member inline videoBackgroundEffectFilled (props: IIconProp list) = createElement (import "VideoBackgroundEffectFilled" FluentIcons) props
        static member inline videoBackgroundEffectRegular (props: IIconProp list) = createElement (import "VideoBackgroundEffectRegular" FluentIcons) props
        static member inline videoBackgroundEffectHorizontalFilled (props: IIconProp list) = createElement (import "VideoBackgroundEffectHorizontalFilled" FluentIcons) props
        static member inline videoBackgroundEffectHorizontalRegular (props: IIconProp list) = createElement (import "VideoBackgroundEffectHorizontalRegular" FluentIcons) props
        static member inline videoChatFilled (props: IIconProp list) = createElement (import "VideoChatFilled" FluentIcons) props
        static member inline videoChatRegular (props: IIconProp list) = createElement (import "VideoChatRegular" FluentIcons) props
        static member inline videoClipFilled (props: IIconProp list) = createElement (import "VideoClipFilled" FluentIcons) props
        static member inline videoClipRegular (props: IIconProp list) = createElement (import "VideoClipRegular" FluentIcons) props
        static member inline videoClipMultipleFilled (props: IIconProp list) = createElement (import "VideoClipMultipleFilled" FluentIcons) props
        static member inline videoClipMultipleRegular (props: IIconProp list) = createElement (import "VideoClipMultipleRegular" FluentIcons) props
        static member inline videoClipOffFilled (props: IIconProp list) = createElement (import "VideoClipOffFilled" FluentIcons) props
        static member inline videoClipOffRegular (props: IIconProp list) = createElement (import "VideoClipOffRegular" FluentIcons) props
        static member inline videoClipOptimizeFilled (props: IIconProp list) = createElement (import "VideoClipOptimizeFilled" FluentIcons) props
        static member inline videoClipOptimizeRegular (props: IIconProp list) = createElement (import "VideoClipOptimizeRegular" FluentIcons) props
        static member inline videoClipWandFilled (props: IIconProp list) = createElement (import "VideoClipWandFilled" FluentIcons) props
        static member inline videoClipWandRegular (props: IIconProp list) = createElement (import "VideoClipWandRegular" FluentIcons) props
        static member inline videoOffFilled (props: IIconProp list) = createElement (import "VideoOffFilled" FluentIcons) props
        static member inline videoOffRegular (props: IIconProp list) = createElement (import "VideoOffRegular" FluentIcons) props
        static member inline videoPersonFilled (props: IIconProp list) = createElement (import "VideoPersonFilled" FluentIcons) props
        static member inline videoPersonRegular (props: IIconProp list) = createElement (import "VideoPersonRegular" FluentIcons) props
        static member inline videoPersonCallFilled (props: IIconProp list) = createElement (import "VideoPersonCallFilled" FluentIcons) props
        static member inline videoPersonCallRegular (props: IIconProp list) = createElement (import "VideoPersonCallRegular" FluentIcons) props
        static member inline videoPersonClockFilled (props: IIconProp list) = createElement (import "VideoPersonClockFilled" FluentIcons) props
        static member inline videoPersonClockRegular (props: IIconProp list) = createElement (import "VideoPersonClockRegular" FluentIcons) props
        static member inline videoPersonOffFilled (props: IIconProp list) = createElement (import "VideoPersonOffFilled" FluentIcons) props
        static member inline videoPersonOffRegular (props: IIconProp list) = createElement (import "VideoPersonOffRegular" FluentIcons) props
        static member inline videoPersonPulseFilled (props: IIconProp list) = createElement (import "VideoPersonPulseFilled" FluentIcons) props
        static member inline videoPersonPulseRegular (props: IIconProp list) = createElement (import "VideoPersonPulseRegular" FluentIcons) props
        static member inline videoPersonSparkleFilled (props: IIconProp list) = createElement (import "VideoPersonSparkleFilled" FluentIcons) props
        static member inline videoPersonSparkleRegular (props: IIconProp list) = createElement (import "VideoPersonSparkleRegular" FluentIcons) props
        static member inline videoPersonSparkleOffFilled (props: IIconProp list) = createElement (import "VideoPersonSparkleOffFilled" FluentIcons) props
        static member inline videoPersonSparkleOffRegular (props: IIconProp list) = createElement (import "VideoPersonSparkleOffRegular" FluentIcons) props
        static member inline videoPersonStarFilled (props: IIconProp list) = createElement (import "VideoPersonStarFilled" FluentIcons) props
        static member inline videoPersonStarRegular (props: IIconProp list) = createElement (import "VideoPersonStarRegular" FluentIcons) props
        static member inline videoPersonStarOffFilled (props: IIconProp list) = createElement (import "VideoPersonStarOffFilled" FluentIcons) props
        static member inline videoPersonStarOffRegular (props: IIconProp list) = createElement (import "VideoPersonStarOffRegular" FluentIcons) props
        static member inline videoPlayPauseFilled (props: IIconProp list) = createElement (import "VideoPlayPauseFilled" FluentIcons) props
        static member inline videoPlayPauseRegular (props: IIconProp list) = createElement (import "VideoPlayPauseRegular" FluentIcons) props
        static member inline videoProhibitedFilled (props: IIconProp list) = createElement (import "VideoProhibitedFilled" FluentIcons) props
        static member inline videoProhibitedRegular (props: IIconProp list) = createElement (import "VideoProhibitedRegular" FluentIcons) props
        static member inline videoRecordingFilled (props: IIconProp list) = createElement (import "VideoRecordingFilled" FluentIcons) props
        static member inline videoRecordingRegular (props: IIconProp list) = createElement (import "VideoRecordingRegular" FluentIcons) props
        static member inline videoSecurityFilled (props: IIconProp list) = createElement (import "VideoSecurityFilled" FluentIcons) props
        static member inline videoSecurityRegular (props: IIconProp list) = createElement (import "VideoSecurityRegular" FluentIcons) props
        static member inline videoSwitchFilled (props: IIconProp list) = createElement (import "VideoSwitchFilled" FluentIcons) props
        static member inline videoSwitchRegular (props: IIconProp list) = createElement (import "VideoSwitchRegular" FluentIcons) props
        static member inline videoSyncFilled (props: IIconProp list) = createElement (import "VideoSyncFilled" FluentIcons) props
        static member inline videoSyncRegular (props: IIconProp list) = createElement (import "VideoSyncRegular" FluentIcons) props
        static member inline viewDesktopFilled (props: IIconProp list) = createElement (import "ViewDesktopFilled" FluentIcons) props
        static member inline viewDesktopRegular (props: IIconProp list) = createElement (import "ViewDesktopRegular" FluentIcons) props
        static member inline viewDesktopMobileFilled (props: IIconProp list) = createElement (import "ViewDesktopMobileFilled" FluentIcons) props
        static member inline viewDesktopMobileRegular (props: IIconProp list) = createElement (import "ViewDesktopMobileRegular" FluentIcons) props
        static member inline virtualNetworkFilled (props: IIconProp list) = createElement (import "VirtualNetworkFilled" FluentIcons) props
        static member inline virtualNetworkRegular (props: IIconProp list) = createElement (import "VirtualNetworkRegular" FluentIcons) props
        static member inline virtualNetworkToolboxFilled (props: IIconProp list) = createElement (import "VirtualNetworkToolboxFilled" FluentIcons) props
        static member inline virtualNetworkToolboxRegular (props: IIconProp list) = createElement (import "VirtualNetworkToolboxRegular" FluentIcons) props
        static member inline voicemailFilled (props: IIconProp list) = createElement (import "VoicemailFilled" FluentIcons) props
        static member inline voicemailRegular (props: IIconProp list) = createElement (import "VoicemailRegular" FluentIcons) props
        static member inline voicemailArrowBackFilled (props: IIconProp list) = createElement (import "VoicemailArrowBackFilled" FluentIcons) props
        static member inline voicemailArrowBackRegular (props: IIconProp list) = createElement (import "VoicemailArrowBackRegular" FluentIcons) props
        static member inline voicemailArrowForwardFilled (props: IIconProp list) = createElement (import "VoicemailArrowForwardFilled" FluentIcons) props
        static member inline voicemailArrowForwardRegular (props: IIconProp list) = createElement (import "VoicemailArrowForwardRegular" FluentIcons) props
        static member inline voicemailArrowSubtractFilled (props: IIconProp list) = createElement (import "VoicemailArrowSubtractFilled" FluentIcons) props
        static member inline voicemailArrowSubtractRegular (props: IIconProp list) = createElement (import "VoicemailArrowSubtractRegular" FluentIcons) props
        static member inline voicemailShieldFilled (props: IIconProp list) = createElement (import "VoicemailShieldFilled" FluentIcons) props
        static member inline voicemailShieldRegular (props: IIconProp list) = createElement (import "VoicemailShieldRegular" FluentIcons) props
        static member inline voicemailSubtractFilled (props: IIconProp list) = createElement (import "VoicemailSubtractFilled" FluentIcons) props
        static member inline voicemailSubtractRegular (props: IIconProp list) = createElement (import "VoicemailSubtractRegular" FluentIcons) props
        static member inline voteFilled (props: IIconProp list) = createElement (import "VoteFilled" FluentIcons) props
        static member inline voteRegular (props: IIconProp list) = createElement (import "VoteRegular" FluentIcons) props
        static member inline walkieTalkieFilled (props: IIconProp list) = createElement (import "WalkieTalkieFilled" FluentIcons) props
        static member inline walkieTalkieRegular (props: IIconProp list) = createElement (import "WalkieTalkieRegular" FluentIcons) props
        static member inline walletFilled (props: IIconProp list) = createElement (import "WalletFilled" FluentIcons) props
        static member inline walletRegular (props: IIconProp list) = createElement (import "WalletRegular" FluentIcons) props
        static member inline walletCreditCardFilled (props: IIconProp list) = createElement (import "WalletCreditCardFilled" FluentIcons) props
        static member inline walletCreditCardRegular (props: IIconProp list) = createElement (import "WalletCreditCardRegular" FluentIcons) props
        static member inline wallpaperFilled (props: IIconProp list) = createElement (import "WallpaperFilled" FluentIcons) props
        static member inline wallpaperRegular (props: IIconProp list) = createElement (import "WallpaperRegular" FluentIcons) props
        static member inline wandFilled (props: IIconProp list) = createElement (import "WandFilled" FluentIcons) props
        static member inline wandRegular (props: IIconProp list) = createElement (import "WandRegular" FluentIcons) props
        static member inline warningFilled (props: IIconProp list) = createElement (import "WarningFilled" FluentIcons) props
        static member inline warningRegular (props: IIconProp list) = createElement (import "WarningRegular" FluentIcons) props
        static member inline warningShieldFilled (props: IIconProp list) = createElement (import "WarningShieldFilled" FluentIcons) props
        static member inline warningShieldRegular (props: IIconProp list) = createElement (import "WarningShieldRegular" FluentIcons) props
        static member inline washerFilled (props: IIconProp list) = createElement (import "WasherFilled" FluentIcons) props
        static member inline washerRegular (props: IIconProp list) = createElement (import "WasherRegular" FluentIcons) props
        static member inline waterFilled (props: IIconProp list) = createElement (import "WaterFilled" FluentIcons) props
        static member inline waterRegular (props: IIconProp list) = createElement (import "WaterRegular" FluentIcons) props
        static member inline weatherBlowingSnowFilled (props: IIconProp list) = createElement (import "WeatherBlowingSnowFilled" FluentIcons) props
        static member inline weatherBlowingSnowRegular (props: IIconProp list) = createElement (import "WeatherBlowingSnowRegular" FluentIcons) props
        static member inline weatherCloudyFilled (props: IIconProp list) = createElement (import "WeatherCloudyFilled" FluentIcons) props
        static member inline weatherCloudyRegular (props: IIconProp list) = createElement (import "WeatherCloudyRegular" FluentIcons) props
        static member inline weatherDrizzleFilled (props: IIconProp list) = createElement (import "WeatherDrizzleFilled" FluentIcons) props
        static member inline weatherDrizzleRegular (props: IIconProp list) = createElement (import "WeatherDrizzleRegular" FluentIcons) props
        static member inline weatherDuststormFilled (props: IIconProp list) = createElement (import "WeatherDuststormFilled" FluentIcons) props
        static member inline weatherDuststormRegular (props: IIconProp list) = createElement (import "WeatherDuststormRegular" FluentIcons) props
        static member inline weatherFogFilled (props: IIconProp list) = createElement (import "WeatherFogFilled" FluentIcons) props
        static member inline weatherFogRegular (props: IIconProp list) = createElement (import "WeatherFogRegular" FluentIcons) props
        static member inline weatherHailDayFilled (props: IIconProp list) = createElement (import "WeatherHailDayFilled" FluentIcons) props
        static member inline weatherHailDayRegular (props: IIconProp list) = createElement (import "WeatherHailDayRegular" FluentIcons) props
        static member inline weatherHailNightFilled (props: IIconProp list) = createElement (import "WeatherHailNightFilled" FluentIcons) props
        static member inline weatherHailNightRegular (props: IIconProp list) = createElement (import "WeatherHailNightRegular" FluentIcons) props
        static member inline weatherHazeFilled (props: IIconProp list) = createElement (import "WeatherHazeFilled" FluentIcons) props
        static member inline weatherHazeRegular (props: IIconProp list) = createElement (import "WeatherHazeRegular" FluentIcons) props
        static member inline weatherMoonFilled (props: IIconProp list) = createElement (import "WeatherMoonFilled" FluentIcons) props
        static member inline weatherMoonRegular (props: IIconProp list) = createElement (import "WeatherMoonRegular" FluentIcons) props
        static member inline weatherMoonOffFilled (props: IIconProp list) = createElement (import "WeatherMoonOffFilled" FluentIcons) props
        static member inline weatherMoonOffRegular (props: IIconProp list) = createElement (import "WeatherMoonOffRegular" FluentIcons) props
        static member inline weatherPartlyCloudyDayFilled (props: IIconProp list) = createElement (import "WeatherPartlyCloudyDayFilled" FluentIcons) props
        static member inline weatherPartlyCloudyDayRegular (props: IIconProp list) = createElement (import "WeatherPartlyCloudyDayRegular" FluentIcons) props
        static member inline weatherPartlyCloudyNightFilled (props: IIconProp list) = createElement (import "WeatherPartlyCloudyNightFilled" FluentIcons) props
        static member inline weatherPartlyCloudyNightRegular (props: IIconProp list) = createElement (import "WeatherPartlyCloudyNightRegular" FluentIcons) props
        static member inline weatherRainFilled (props: IIconProp list) = createElement (import "WeatherRainFilled" FluentIcons) props
        static member inline weatherRainRegular (props: IIconProp list) = createElement (import "WeatherRainRegular" FluentIcons) props
        static member inline weatherRainShowersDayFilled (props: IIconProp list) = createElement (import "WeatherRainShowersDayFilled" FluentIcons) props
        static member inline weatherRainShowersDayRegular (props: IIconProp list) = createElement (import "WeatherRainShowersDayRegular" FluentIcons) props
        static member inline weatherRainShowersNightFilled (props: IIconProp list) = createElement (import "WeatherRainShowersNightFilled" FluentIcons) props
        static member inline weatherRainShowersNightRegular (props: IIconProp list) = createElement (import "WeatherRainShowersNightRegular" FluentIcons) props
        static member inline weatherRainSnowFilled (props: IIconProp list) = createElement (import "WeatherRainSnowFilled" FluentIcons) props
        static member inline weatherRainSnowRegular (props: IIconProp list) = createElement (import "WeatherRainSnowRegular" FluentIcons) props
        static member inline weatherSnowFilled (props: IIconProp list) = createElement (import "WeatherSnowFilled" FluentIcons) props
        static member inline weatherSnowRegular (props: IIconProp list) = createElement (import "WeatherSnowRegular" FluentIcons) props
        static member inline weatherSnowShowerDayFilled (props: IIconProp list) = createElement (import "WeatherSnowShowerDayFilled" FluentIcons) props
        static member inline weatherSnowShowerDayRegular (props: IIconProp list) = createElement (import "WeatherSnowShowerDayRegular" FluentIcons) props
        static member inline weatherSnowShowerNightFilled (props: IIconProp list) = createElement (import "WeatherSnowShowerNightFilled" FluentIcons) props
        static member inline weatherSnowShowerNightRegular (props: IIconProp list) = createElement (import "WeatherSnowShowerNightRegular" FluentIcons) props
        static member inline weatherSnowflakeFilled (props: IIconProp list) = createElement (import "WeatherSnowflakeFilled" FluentIcons) props
        static member inline weatherSnowflakeRegular (props: IIconProp list) = createElement (import "WeatherSnowflakeRegular" FluentIcons) props
        static member inline weatherSquallsFilled (props: IIconProp list) = createElement (import "WeatherSquallsFilled" FluentIcons) props
        static member inline weatherSquallsRegular (props: IIconProp list) = createElement (import "WeatherSquallsRegular" FluentIcons) props
        static member inline weatherSunnyFilled (props: IIconProp list) = createElement (import "WeatherSunnyFilled" FluentIcons) props
        static member inline weatherSunnyRegular (props: IIconProp list) = createElement (import "WeatherSunnyRegular" FluentIcons) props
        static member inline weatherSunnyHighFilled (props: IIconProp list) = createElement (import "WeatherSunnyHighFilled" FluentIcons) props
        static member inline weatherSunnyHighRegular (props: IIconProp list) = createElement (import "WeatherSunnyHighRegular" FluentIcons) props
        static member inline weatherSunnyLowFilled (props: IIconProp list) = createElement (import "WeatherSunnyLowFilled" FluentIcons) props
        static member inline weatherSunnyLowRegular (props: IIconProp list) = createElement (import "WeatherSunnyLowRegular" FluentIcons) props
        static member inline weatherThunderstormFilled (props: IIconProp list) = createElement (import "WeatherThunderstormFilled" FluentIcons) props
        static member inline weatherThunderstormRegular (props: IIconProp list) = createElement (import "WeatherThunderstormRegular" FluentIcons) props
        static member inline webAssetFilled (props: IIconProp list) = createElement (import "WebAssetFilled" FluentIcons) props
        static member inline webAssetRegular (props: IIconProp list) = createElement (import "WebAssetRegular" FluentIcons) props
        static member inline whiteboardFilled (props: IIconProp list) = createElement (import "WhiteboardFilled" FluentIcons) props
        static member inline whiteboardRegular (props: IIconProp list) = createElement (import "WhiteboardRegular" FluentIcons) props
        static member inline whiteboardOffFilled (props: IIconProp list) = createElement (import "WhiteboardOffFilled" FluentIcons) props
        static member inline whiteboardOffRegular (props: IIconProp list) = createElement (import "WhiteboardOffRegular" FluentIcons) props
        static member inline wifi1Filled (props: IIconProp list) = createElement (import "Wifi1Filled" FluentIcons) props
        static member inline wifi1Regular (props: IIconProp list) = createElement (import "Wifi1Regular" FluentIcons) props
        static member inline wifi2Filled (props: IIconProp list) = createElement (import "Wifi2Filled" FluentIcons) props
        static member inline wifi2Regular (props: IIconProp list) = createElement (import "Wifi2Regular" FluentIcons) props
        static member inline wifi3Filled (props: IIconProp list) = createElement (import "Wifi3Filled" FluentIcons) props
        static member inline wifi3Regular (props: IIconProp list) = createElement (import "Wifi3Regular" FluentIcons) props
        static member inline wifi4Filled (props: IIconProp list) = createElement (import "Wifi4Filled" FluentIcons) props
        static member inline wifi4Regular (props: IIconProp list) = createElement (import "Wifi4Regular" FluentIcons) props
        static member inline wifiLockFilled (props: IIconProp list) = createElement (import "WifiLockFilled" FluentIcons) props
        static member inline wifiLockRegular (props: IIconProp list) = createElement (import "WifiLockRegular" FluentIcons) props
        static member inline wifiOffFilled (props: IIconProp list) = createElement (import "WifiOffFilled" FluentIcons) props
        static member inline wifiOffRegular (props: IIconProp list) = createElement (import "WifiOffRegular" FluentIcons) props
        static member inline wifiSettingsFilled (props: IIconProp list) = createElement (import "WifiSettingsFilled" FluentIcons) props
        static member inline wifiSettingsRegular (props: IIconProp list) = createElement (import "WifiSettingsRegular" FluentIcons) props
        static member inline wifiWarningFilled (props: IIconProp list) = createElement (import "WifiWarningFilled" FluentIcons) props
        static member inline wifiWarningRegular (props: IIconProp list) = createElement (import "WifiWarningRegular" FluentIcons) props
        static member inline windowFilled (props: IIconProp list) = createElement (import "WindowFilled" FluentIcons) props
        static member inline windowRegular (props: IIconProp list) = createElement (import "WindowRegular" FluentIcons) props
        static member inline windowAdFilled (props: IIconProp list) = createElement (import "WindowAdFilled" FluentIcons) props
        static member inline windowAdRegular (props: IIconProp list) = createElement (import "WindowAdRegular" FluentIcons) props
        static member inline windowAdOffFilled (props: IIconProp list) = createElement (import "WindowAdOffFilled" FluentIcons) props
        static member inline windowAdOffRegular (props: IIconProp list) = createElement (import "WindowAdOffRegular" FluentIcons) props
        static member inline windowAdPersonFilled (props: IIconProp list) = createElement (import "WindowAdPersonFilled" FluentIcons) props
        static member inline windowAdPersonRegular (props: IIconProp list) = createElement (import "WindowAdPersonRegular" FluentIcons) props
        static member inline windowAppsFilled (props: IIconProp list) = createElement (import "WindowAppsFilled" FluentIcons) props
        static member inline windowAppsRegular (props: IIconProp list) = createElement (import "WindowAppsRegular" FluentIcons) props
        static member inline windowArrowUpFilled (props: IIconProp list) = createElement (import "WindowArrowUpFilled" FluentIcons) props
        static member inline windowArrowUpRegular (props: IIconProp list) = createElement (import "WindowArrowUpRegular" FluentIcons) props
        static member inline windowBulletListFilled (props: IIconProp list) = createElement (import "WindowBulletListFilled" FluentIcons) props
        static member inline windowBulletListRegular (props: IIconProp list) = createElement (import "WindowBulletListRegular" FluentIcons) props
        static member inline windowBulletListAddFilled (props: IIconProp list) = createElement (import "WindowBulletListAddFilled" FluentIcons) props
        static member inline windowBulletListAddRegular (props: IIconProp list) = createElement (import "WindowBulletListAddRegular" FluentIcons) props
        static member inline windowConsoleFilled (props: IIconProp list) = createElement (import "WindowConsoleFilled" FluentIcons) props
        static member inline windowConsoleRegular (props: IIconProp list) = createElement (import "WindowConsoleRegular" FluentIcons) props
        static member inline windowDatabaseFilled (props: IIconProp list) = createElement (import "WindowDatabaseFilled" FluentIcons) props
        static member inline windowDatabaseRegular (props: IIconProp list) = createElement (import "WindowDatabaseRegular" FluentIcons) props
        static member inline windowDevEditFilled (props: IIconProp list) = createElement (import "WindowDevEditFilled" FluentIcons) props
        static member inline windowDevEditRegular (props: IIconProp list) = createElement (import "WindowDevEditRegular" FluentIcons) props
        static member inline windowDevToolsFilled (props: IIconProp list) = createElement (import "WindowDevToolsFilled" FluentIcons) props
        static member inline windowDevToolsRegular (props: IIconProp list) = createElement (import "WindowDevToolsRegular" FluentIcons) props
        static member inline windowEditFilled (props: IIconProp list) = createElement (import "WindowEditFilled" FluentIcons) props
        static member inline windowEditRegular (props: IIconProp list) = createElement (import "WindowEditRegular" FluentIcons) props
        static member inline windowFingerprintFilled (props: IIconProp list) = createElement (import "WindowFingerprintFilled" FluentIcons) props
        static member inline windowFingerprintRegular (props: IIconProp list) = createElement (import "WindowFingerprintRegular" FluentIcons) props
        static member inline windowHeaderHorizontalFilled (props: IIconProp list) = createElement (import "WindowHeaderHorizontalFilled" FluentIcons) props
        static member inline windowHeaderHorizontalRegular (props: IIconProp list) = createElement (import "WindowHeaderHorizontalRegular" FluentIcons) props
        static member inline windowHeaderHorizontalOffFilled (props: IIconProp list) = createElement (import "WindowHeaderHorizontalOffFilled" FluentIcons) props
        static member inline windowHeaderHorizontalOffRegular (props: IIconProp list) = createElement (import "WindowHeaderHorizontalOffRegular" FluentIcons) props
        static member inline windowHeaderVerticalFilled (props: IIconProp list) = createElement (import "WindowHeaderVerticalFilled" FluentIcons) props
        static member inline windowHeaderVerticalRegular (props: IIconProp list) = createElement (import "WindowHeaderVerticalRegular" FluentIcons) props
        static member inline windowInprivateFilled (props: IIconProp list) = createElement (import "WindowInprivateFilled" FluentIcons) props
        static member inline windowInprivateRegular (props: IIconProp list) = createElement (import "WindowInprivateRegular" FluentIcons) props
        static member inline windowInprivateAccountFilled (props: IIconProp list) = createElement (import "WindowInprivateAccountFilled" FluentIcons) props
        static member inline windowInprivateAccountRegular (props: IIconProp list) = createElement (import "WindowInprivateAccountRegular" FluentIcons) props
        static member inline windowLocationTargetFilled (props: IIconProp list) = createElement (import "WindowLocationTargetFilled" FluentIcons) props
        static member inline windowLocationTargetRegular (props: IIconProp list) = createElement (import "WindowLocationTargetRegular" FluentIcons) props
        static member inline windowMultipleFilled (props: IIconProp list) = createElement (import "WindowMultipleFilled" FluentIcons) props
        static member inline windowMultipleRegular (props: IIconProp list) = createElement (import "WindowMultipleRegular" FluentIcons) props
        static member inline windowMultipleSwapFilled (props: IIconProp list) = createElement (import "WindowMultipleSwapFilled" FluentIcons) props
        static member inline windowMultipleSwapRegular (props: IIconProp list) = createElement (import "WindowMultipleSwapRegular" FluentIcons) props
        static member inline windowNewFilled (props: IIconProp list) = createElement (import "WindowNewFilled" FluentIcons) props
        static member inline windowNewRegular (props: IIconProp list) = createElement (import "WindowNewRegular" FluentIcons) props
        static member inline windowPlayFilled (props: IIconProp list) = createElement (import "WindowPlayFilled" FluentIcons) props
        static member inline windowPlayRegular (props: IIconProp list) = createElement (import "WindowPlayRegular" FluentIcons) props
        static member inline windowSettingsFilled (props: IIconProp list) = createElement (import "WindowSettingsFilled" FluentIcons) props
        static member inline windowSettingsRegular (props: IIconProp list) = createElement (import "WindowSettingsRegular" FluentIcons) props
        static member inline windowShieldFilled (props: IIconProp list) = createElement (import "WindowShieldFilled" FluentIcons) props
        static member inline windowShieldRegular (props: IIconProp list) = createElement (import "WindowShieldRegular" FluentIcons) props
        static member inline windowTextFilled (props: IIconProp list) = createElement (import "WindowTextFilled" FluentIcons) props
        static member inline windowTextRegular (props: IIconProp list) = createElement (import "WindowTextRegular" FluentIcons) props
        static member inline windowWrenchFilled (props: IIconProp list) = createElement (import "WindowWrenchFilled" FluentIcons) props
        static member inline windowWrenchRegular (props: IIconProp list) = createElement (import "WindowWrenchRegular" FluentIcons) props
        static member inline wrenchFilled (props: IIconProp list) = createElement (import "WrenchFilled" FluentIcons) props
        static member inline wrenchRegular (props: IIconProp list) = createElement (import "WrenchRegular" FluentIcons) props
        static member inline wrenchScrewdriverFilled (props: IIconProp list) = createElement (import "WrenchScrewdriverFilled" FluentIcons) props
        static member inline wrenchScrewdriverRegular (props: IIconProp list) = createElement (import "WrenchScrewdriverRegular" FluentIcons) props
        static member inline wrenchSettingsFilled (props: IIconProp list) = createElement (import "WrenchSettingsFilled" FluentIcons) props
        static member inline wrenchSettingsRegular (props: IIconProp list) = createElement (import "WrenchSettingsRegular" FluentIcons) props
        static member inline xboxConsoleFilled (props: IIconProp list) = createElement (import "XboxConsoleFilled" FluentIcons) props
        static member inline xboxConsoleRegular (props: IIconProp list) = createElement (import "XboxConsoleRegular" FluentIcons) props
        static member inline xboxControllerFilled (props: IIconProp list) = createElement (import "XboxControllerFilled" FluentIcons) props
        static member inline xboxControllerRegular (props: IIconProp list) = createElement (import "XboxControllerRegular" FluentIcons) props
        static member inline xboxControllerErrorFilled (props: IIconProp list) = createElement (import "XboxControllerErrorFilled" FluentIcons) props
        static member inline xboxControllerErrorRegular (props: IIconProp list) = createElement (import "XboxControllerErrorRegular" FluentIcons) props
        static member inline xrayFilled (props: IIconProp list) = createElement (import "XrayFilled" FluentIcons) props
        static member inline xrayRegular (props: IIconProp list) = createElement (import "XrayRegular" FluentIcons) props
        static member inline zoomFitFilled (props: IIconProp list) = createElement (import "ZoomFitFilled" FluentIcons) props
        static member inline zoomFitRegular (props: IIconProp list) = createElement (import "ZoomFitRegular" FluentIcons) props
        static member inline zoomInFilled (props: IIconProp list) = createElement (import "ZoomInFilled" FluentIcons) props
        static member inline zoomInRegular (props: IIconProp list) = createElement (import "ZoomInRegular" FluentIcons) props
        static member inline zoomOutFilled (props: IIconProp list) = createElement (import "ZoomOutFilled" FluentIcons) props
        static member inline zoomOutRegular (props: IIconProp list) = createElement (import "ZoomOutRegular" FluentIcons) props
