namespace FS.FluentUI.V8toV9

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz
open FS.FluentUI.V8toV9

// -------------------------------------------------------------------------- StackItem --------------------------------------------------------------------------------------

type [<Erase>] stackItem =
    inherit FelizProperties.prop<IStackItemProp>
    /// Defines a CSS class name used to style the StackItem.
    static member inline className (value: string) = Interop.mkProperty<IStackItemProp> "className" value
    /// Defines whether the StackItem should be prevented from shrinking. This can be used to prevent a StackItem from shrinking when it is inside of a Stack that has shrinking items.
    static member inline disableShrink (value: bool) = Interop.mkProperty<IStackItemProp> "disableShrink" value
    /// Defines order of the StackItem.
    static member inline order (value: int) = Interop.mkProperty<IStackItemProp> "order" value
    /// Defines order of the StackItem.
    static member inline order (value: float) = Interop.mkProperty<IStackItemProp> "order" value
    /// Defines order of the StackItem.
    static member inline order (value: decimal) = Interop.mkProperty<IStackItemProp> "order" value
    /// Defines order of the StackItem.
    static member inline order (value: string) = Interop.mkProperty<IStackItemProp> "order" value
    /// Defines order of the StackItem.
    static member inline order (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackItemProp> "order" value
    /// Defines whether the StackItem should take up 100% of the height of its parent.
    static member inline verticalFill (value: bool) = Interop.mkProperty<IStackItemProp> "verticalFill" value

module stackItem =

    type [<Erase>] align =
        static member inline auto = Interop.mkProperty<IStackItemProp> "align" "auto"
        static member inline stretch = Interop.mkProperty<IStackItemProp> "align" "stretch"
        static member inline baseline = Interop.mkProperty<IStackItemProp> "align" "baseline"
        static member inline start = Interop.mkProperty<IStackItemProp> "align" "start"
        static member inline center = Interop.mkProperty<IStackItemProp> "align" "center"
        static member inline end' = Interop.mkProperty<IStackItemProp> "align" "end"

    type [<Erase>] grow =
        static member inline inherit' = Interop.mkProperty<IStackItemProp> "grow" "inherit"
        static member inline initial = Interop.mkProperty<IStackItemProp> "grow" "initial"
        static member inline unset = Interop.mkProperty<IStackItemProp> "grow" "unset"
        static member inline true' = Interop.mkProperty<IStackItemProp> "grow" true
        static member inline false' = Interop.mkProperty<IStackItemProp> "grow" false
        static member inline int' (value: int) = Interop.mkProperty<IStackItemProp> "grow" value
        static member inline float (value: float) = Interop.mkProperty<IStackItemProp> "grow" value
        static member inline bool' (value: bool) = Interop.mkProperty<IStackItemProp> "grow" value
        static member inline decimal (value: decimal) = Interop.mkProperty<IStackItemProp> "grow" value

    type [<Erase>] shrink =
        static member inline inherit' = Interop.mkProperty<IStackItemProp> "shrink" "inherit"
        static member inline initial = Interop.mkProperty<IStackItemProp> "shrink" "initial"
        static member inline unset = Interop.mkProperty<IStackItemProp> "shrink" "unset"
        static member inline true' = Interop.mkProperty<IStackItemProp> "shrink" true
        static member inline false' = Interop.mkProperty<IStackItemProp> "shrink" false
        static member inline int' (value: int) = Interop.mkProperty<IStackItemProp> "shrink" value
        static member inline float (value: float) = Interop.mkProperty<IStackItemProp> "shrink" value
        static member inline bool' (value: bool) = Interop.mkProperty<IStackItemProp> "shrink" value
        static member inline decimal (value: decimal) = Interop.mkProperty<IStackItemProp> "shrink" value

// -------------------------------------------------------------------------- Stack --------------------------------------------------------------------------------------
/// No info found
type [<Erase>] stack =
    inherit FelizProperties.prop<IStackProp>
    /// Defines how to render the Stack.
    static member inline as' (value: ReactElementType) = Interop.mkProperty<IStackProp> "as" value
    /// Defines whether Stack children should not shrink to fit the available space.
    static member inline disableShrink (value: bool) = Interop.mkProperty<IStackProp> "disableShrink" value
    ///  Warning  This API is now deprecated. Use tokens.childrenGap instead. Defines the spacing between Stack children. The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'. If 'column gap' is omitted, it's set to the same value as 'row gap'.
    [<Obsolete>] static member inline gap (value: int) = Interop.mkProperty<IStackProp> "gap" value
    ///  Warning  This API is now deprecated. Use tokens.childrenGap instead. Defines the spacing between Stack children. The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'. If 'column gap' is omitted, it's set to the same value as 'row gap'.
    [<Obsolete>] static member inline gap (value: float) = Interop.mkProperty<IStackProp> "gap" value
    ///  Warning  This API is now deprecated. Use tokens.childrenGap instead. Defines the spacing between Stack children. The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'. If 'column gap' is omitted, it's set to the same value as 'row gap'.
    [<Obsolete>] static member inline gap (value: decimal) = Interop.mkProperty<IStackProp> "gap" value
    ///  Warning  This API is now deprecated. Use tokens.childrenGap instead. Defines the spacing between Stack children. The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'. If 'column gap' is omitted, it's set to the same value as 'row gap'.
    [<Obsolete>] static member inline gap (value: string) = Interop.mkProperty<IStackProp> "gap" value
    ///  Warning  This API is now deprecated. Use tokens.childrenGap instead. Defines the spacing between Stack children. The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'. If 'column gap' is omitted, it's set to the same value as 'row gap'.
    [<Obsolete>] static member inline gap (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackProp> "gap" value
    /// Defines whether to render Stack children horizontally.
    static member inline horizontal (value: bool) = Interop.mkProperty<IStackProp> "horizontal" value
    ///  Warning  This API is now deprecated. Use tokens.maxHeight instead. Defines the maximum height that the Stack can take.
    [<Obsolete>] static member inline maxHeight (value: int) = Interop.mkProperty<IStackProp> "maxHeight" value
    ///  Warning  This API is now deprecated. Use tokens.maxHeight instead. Defines the maximum height that the Stack can take.
    [<Obsolete>] static member inline maxHeight (value: float) = Interop.mkProperty<IStackProp> "maxHeight" value
    ///  Warning  This API is now deprecated. Use tokens.maxHeight instead. Defines the maximum height that the Stack can take.
    [<Obsolete>] static member inline maxHeight (value: decimal) = Interop.mkProperty<IStackProp> "maxHeight" value
    ///  Warning  This API is now deprecated. Use tokens.maxHeight instead. Defines the maximum height that the Stack can take.
    [<Obsolete>] static member inline maxHeight (value: string) = Interop.mkProperty<IStackProp> "maxHeight" value
    ///  Warning  This API is now deprecated. Use tokens.maxHeight instead. Defines the maximum height that the Stack can take.
    [<Obsolete>] static member inline maxHeight (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackProp> "maxHeight" value
    ///  Warning  This API is now deprecated. Use tokens.maxWidth instead. Defines the maximum width that the Stack can take.
    [<Obsolete>] static member inline maxWidth (value: int) = Interop.mkProperty<IStackProp> "maxWidth" value
    ///  Warning  This API is now deprecated. Use tokens.maxWidth instead. Defines the maximum width that the Stack can take.
    [<Obsolete>] static member inline maxWidth (value: float) = Interop.mkProperty<IStackProp> "maxWidth" value
    ///  Warning  This API is now deprecated. Use tokens.maxWidth instead. Defines the maximum width that the Stack can take.
    [<Obsolete>] static member inline maxWidth (value: decimal) = Interop.mkProperty<IStackProp> "maxWidth" value
    ///  Warning  This API is now deprecated. Use tokens.maxWidth instead. Defines the maximum width that the Stack can take.
    [<Obsolete>] static member inline maxWidth (value: string) = Interop.mkProperty<IStackProp> "maxWidth" value
    ///  WARNING  This API is now deprecated. Use tokens.maxWidth instead. Defines the maximum width that the Stack can take.
    [<Obsolete>] static member inline maxWidth (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackProp> "maxWidth" value
    ///  WARNING  This API is now deprecated. Use tokens.padding instead. Defines the inner padding of the Stack.
    [<Obsolete>] static member inline padding (value: int) = Interop.mkProperty<IStackProp> "padding" value
    ///  WARNING  This API is now deprecated. Use tokens.padding instead. Defines the inner padding of the Stack.
    [<Obsolete>] static member inline padding (value: float) = Interop.mkProperty<IStackProp> "padding" value
    ///  WARNING  This API is now deprecated. Use tokens.padding instead. Defines the inner padding of the Stack.
    [<Obsolete>] static member inline padding (value: decimal) = Interop.mkProperty<IStackProp> "padding" value
    ///  WARNING  This API is now deprecated. Use tokens.padding instead. Defines the inner padding of the Stack.
    [<Obsolete>] static member inline padding (value: string) = Interop.mkProperty<IStackProp> "padding" value
    ///  WARNING  This API is now deprecated. Use tokens.padding instead. Defines the inner padding of the Stack.
    [<Obsolete>] static member inline padding (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackProp> "padding" value
    /// Defines whether to render Stack children in the opposite direction (bottom-to-top if it's a vertical Stack and right-to-left if it's a horizontal Stack).
    static member inline reversed (value: bool) = Interop.mkProperty<IStackProp> "reversed" value
    /// Defines whether the Stack should take up 100% of the height of its parent. This property is required to be set to true when using the grow flag on children in vertical oriented Stacks. Stacks are rendered as block elements and grow horizontally to the container already.
    static member inline verticalFill (value: bool) = Interop.mkProperty<IStackProp> "verticalFill" value
    /// Defines whether Stack children should wrap onto multiple rows or columns when they are about to overflow the size of the Stack.
    static member inline wrap (value: bool) = Interop.mkProperty<IStackProp> "wrap" value
    /// This prop was hardcoded in. Please look at official documentation.
    static member inline tokens (value: list<IStackTokensProp>) = Interop.mkProperty<IStackProp> "tokens" (!!value |> createObj |> unbox<IStackTokens>)
    /// Defines if scoped style selectors are enabled for the Stack component, which greatly helps in style recalculation
    /// performance, but requires children of the Stack to be able to accept a className prop (excluding Fragments).
    static member inline enableScopedSelectors (value: bool) = Interop.mkProperty<IStackProp> "enableScopedSelectors" value

module stack =

    type [<Erase>] grow =
        static member inline inherit' = Interop.mkProperty<IStackProp> "grow" "inherit"
        static member inline initial = Interop.mkProperty<IStackProp> "grow" "initial"
        static member inline unset = Interop.mkProperty<IStackProp> "grow" "unset"
        static member inline true' = Interop.mkProperty<IStackProp> "grow" true
        static member inline false' = Interop.mkProperty<IStackProp> "grow" false
        static member inline int' (value: int) = Interop.mkProperty<IStackProp> "grow" value
        static member inline float (value: float) = Interop.mkProperty<IStackProp> "grow" value
        static member inline bool' (value: bool) = Interop.mkProperty<IStackProp> "grow" value
        static member inline decimal (value: decimal) = Interop.mkProperty<IStackProp> "grow" value

    type [<Erase>] horizontalAlign =
        static member inline start = Interop.mkProperty<IStackProp> "horizontalAlign" "start"
        static member inline end' = Interop.mkProperty<IStackProp> "horizontalAlign" "end"
        static member inline center = Interop.mkProperty<IStackProp> "horizontalAlign" "center"
        static member inline spaceBetween = Interop.mkProperty<IStackProp> "horizontalAlign" "space-between"
        static member inline spaceAround = Interop.mkProperty<IStackProp> "horizontalAlign" "space-around"
        static member inline spaceEvenly = Interop.mkProperty<IStackProp> "horizontalAlign" "space-evenly"
        static member inline baseline = Interop.mkProperty<IStackProp> "horizontalAlign" "baseline"
        static member inline stretch = Interop.mkProperty<IStackProp> "horizontalAlign" "stretch"

    type [<Erase>] verticalAlign =
        static member inline start = Interop.mkProperty<IStackProp> "verticalAlign" "start"
        static member inline end' = Interop.mkProperty<IStackProp> "verticalAlign" "end"
        static member inline center = Interop.mkProperty<IStackProp> "verticalAlign" "center"
        static member inline spaceBetween = Interop.mkProperty<IStackProp> "verticalAlign" "space-between"
        static member inline spaceAround = Interop.mkProperty<IStackProp> "verticalAlign" "space-around"
        static member inline spaceEvenly = Interop.mkProperty<IStackProp> "verticalAlign" "space-evenly"
        static member inline baseline = Interop.mkProperty<IStackProp> "verticalAlign" "baseline"
        static member inline stretch = Interop.mkProperty<IStackProp> "verticalAlign" "stretch"

    type [<Erase>] tokens =
        /// Defines the spacing between Stack children.
        /// The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'.
        /// If 'column gap' is omitted, it's set to the same value as 'row gap'.
        static member inline childrenGap (value: int) = Interop.mkProperty<IStackTokensProp> "childrenGap" value
        /// Defines the spacing between Stack children.
        /// The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'.
        /// If 'column gap' is omitted, it's set to the same value as 'row gap'.
        static member inline childrenGap (value: float) = Interop.mkProperty<IStackTokensProp> "childrenGap" value
        /// Defines the spacing between Stack children.
        /// The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'.
        /// If 'column gap' is omitted, it's set to the same value as 'row gap'.
        static member inline childrenGap (value: decimal) = Interop.mkProperty<IStackTokensProp> "childrenGap" value
        /// Defines the spacing between Stack children.
        /// The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'.
        /// If 'column gap' is omitted, it's set to the same value as 'row gap'.
        static member inline childrenGap (value: string) = Interop.mkProperty<IStackTokensProp> "childrenGap" value
        /// Defines the spacing between Stack children.
        /// The property is specified as a value for 'row gap', followed optionally by a value for 'column gap'.
        /// If 'column gap' is omitted, it's set to the same value as 'row gap'.
        static member inline childrenGap (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackTokensProp> "childrenGap" value
        /// Defines a maximum height for the Stack.
        static member inline maxHeight (value: int) = Interop.mkProperty<IStackTokensProp> "maxHeight" value
        /// Defines a maximum height for the Stack.
        static member inline maxHeight (value: float) = Interop.mkProperty<IStackTokensProp> "maxHeight" value
        /// Defines a maximum height for the Stack.
        static member inline maxHeight (value: decimal) = Interop.mkProperty<IStackTokensProp> "maxHeight" value
        /// Defines a maximum height for the Stack.
        static member inline maxHeight (value: string) = Interop.mkProperty<IStackTokensProp> "maxHeight" value
        /// Defines a maximum height for the Stack.
        static member inline maxHeight (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackTokensProp> "maxHeight" value
        /// Defines a maximum width for the Stack.
        static member inline maxWidth (value: int) = Interop.mkProperty<IStackTokensProp> "maxWidth" value
        /// Defines a maximum width for the Stack.
        static member inline maxWidth (value: float) = Interop.mkProperty<IStackTokensProp> "maxWidth" value
        /// Defines a maximum width for the Stack.
        static member inline maxWidth (value: decimal) = Interop.mkProperty<IStackTokensProp> "maxWidth" value
        /// Defines a maximum width for the Stack.
        static member inline maxWidth (value: string) = Interop.mkProperty<IStackTokensProp> "maxWidth" value
        /// Defines a maximum width for the Stack.
        static member inline maxWidth (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackTokensProp> "maxWidth" value
        /// Defines the padding to be applied to the Stack contents relative to its border.
        static member inline padding (value: int) = Interop.mkProperty<IStackTokensProp> "padding" value
        /// Defines the padding to be applied to the Stack contents relative to its border.
        static member inline padding (value: float) = Interop.mkProperty<IStackTokensProp> "padding" value
        /// Defines the padding to be applied to the Stack contents relative to its border.
        static member inline padding (value: decimal) = Interop.mkProperty<IStackTokensProp> "padding" value
        /// Defines the padding to be applied to the Stack contents relative to its border.
        static member inline padding (value: string) = Interop.mkProperty<IStackTokensProp> "padding" value
        /// Defines the padding to be applied to the Stack contents relative to its border.
        static member inline padding (value: Feliz.Styles.ICssUnit) = Interop.mkProperty<IStackTokensProp> "padding" value
