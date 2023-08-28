namespace FS.FluentUI

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Feliz

type [<Erase>] style =
    /// Defines from thin to thick characters. 400 is the same as normal, and 700 is the same as bold.
    /// Possible values are [100, 200, 300, 400, 500, 600, 700, 800, 900]
    static member inline fontWeight (weight: int) = Interop.mkStyle "fontWeight" weight
    static member inline fontWeight (weight: string) = Interop.mkStyle "fontWeight" weight
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: int) = Interop.mkStyle "fontSize" (unbox<string> size + "px")
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: float) = Interop.mkStyle "fontSize" (unbox<string> size + "px")
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: Feliz.Styles.ICssUnit) = Interop.mkStyle "fontSize" size
    /// Sets the size of the font.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    static member inline fontSize(size: string) = Interop.mkStyle "fontSize" size
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: int) = Interop.mkStyle "lineHeight" (unbox<string> size + "px")
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: float) = Interop.mkStyle "lineHeight" (unbox<string> size + "px")
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: Feliz.Styles.ICssUnit) = Interop.mkStyle "lineHeight" size
    /// Specifies the height of a text lines.
    ///
    /// This property is also used to compute the size of em, ex, and other relative <length> units.
    ///
    /// Note: Negative values are not allowed.
    static member inline lineHeight(size: string) = Interop.mkStyle "lineHeight" size

// -------------------------------------------------------------------------- FluentProvider --------------------------------------------------------------------------------------
type [<Erase>] fluentProvider =
    inherit FelizProps.prop<IFluentProviderProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IFluentProviderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline applyStylesToPortals (value: bool) = Interop.mkProperty<IFluentProviderProp> "applyStylesToPortals" value
    static member inline targetDocument (value: Document) = Interop.mkProperty<IFluentProviderProp> "targetDocument" value
    static member inline children (value: ReactElement list) = Interop.mkProperty<IFluentProviderProp> "children" value

module fluentProvider =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IFluentProviderProp> "as" "div"

    type [<Erase>] dir =
        static member inline rtl = Interop.mkProperty<IFluentProviderProp> "dir" "rtl"
        static member inline ltr = Interop.mkProperty<IFluentProviderProp> "dir" "ltr"

    type [<Erase>] theme =
        /// To create custom BrandVariants, it's easiest to go to `https://react.fluentui.dev/?path=/docs/theme-theme-designer--page`,
        /// choose your color/theme, then click "Export" and copy the BrandVariants over to use here.
        static member inline createDarkTheme (brand: BrandVariants): ITheme = import "createDarkTheme" "@fluentui/react-components"
        /// To create custom BrandVariants, it's easiest to go to `https://react.fluentui.dev/?path=/docs/theme-theme-designer--page`,
        /// choose your color/theme, then click "Export" and copy the BrandVariants over to use here.
        static member inline createLightTheme (brand: BrandVariants): ITheme = import "createLightTheme" "@fluentui/react-components"
        static member inline createHighContrastTheme (): ITheme = import "createHighContrastTheme" "@fluentui/react-components"
        /// To create custom BrandVariants, it's easiest to go to `https://react.fluentui.dev/?path=/docs/theme-theme-designer--page`,
        /// choose your color/theme, then click "Export" and copy the BrandVariants over to use here.
        static member inline createTeamsDarkTheme (brand: BrandVariants): ITheme = import "createTeamsDarkTheme" "@fluentui/react-components"
        static member inline teamsLight = Interop.mkProperty<IFluentProviderProp> "theme" (import "teamsLightTheme" "@fluentui/react-components")
        static member inline teamsDark = Interop.mkProperty<IFluentProviderProp> "theme" (import "teamsDarkTheme" "@fluentui/react-components")
        static member inline teamsHighContrast =Interop.mkProperty<IFluentProviderProp> "theme" (import "teamsHighContrastTheme" "@fluentui/react-components")
        static member inline webLight = Interop.mkProperty<IFluentProviderProp> "theme" (import "webLightTheme" "@fluentui/react-components")
        static member inline webDark = Interop.mkProperty<IFluentProviderProp> "theme" (import "webDarkTheme" "@fluentui/react-components")
        /// To create custom BrandVariants, it's easiest to go to `https://react.fluentui.dev/?path=/docs/theme-theme-designer--page`,
        /// choose your color/theme, then click "Export" and copy the BrandVariants over to use here.
        static member inline customDarkTheme (value: BrandVariants) = Interop.mkProperty<IFluentProviderProp> "theme" (theme.createDarkTheme value)
        /// To create custom BrandVariants, it's easiest to go to `https://react.fluentui.dev/?path=/docs/theme-theme-designer--page`,
        /// choose your color/theme, then click "Export" and copy the BrandVariants over to use here.
        static member inline customLightTheme (value: BrandVariants) = Interop.mkProperty<IFluentProviderProp> "theme" (theme.createLightTheme value)
        /// To create custom BrandVariants, it's easiest to go to `https://react.fluentui.dev/?path=/docs/theme-theme-designer--page`,
        /// choose your color/theme, then click "Export" and copy the BrandVariants over to use here.
        static member inline customTeamsDarkTheme (value: BrandVariants) = Interop.mkProperty<IFluentProviderProp> "theme" (theme.createTeamsDarkTheme value)

// -------------------------------------------------------------------------- Avatar --------------------------------------------------------------------------------------
type [<Erase>] avatar =

    inherit FelizProps.prop<IAvatarProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAvatarProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Avatar's image.
    static member inline image (value: IReactProperty list) = Interop.mkProperty<IAvatarProp> "image" (!!value |> createObj |> unbox<IReactProperty>)
    /// Custom initials.
    /// It is usually not necessary to specify custom initials; by default they will be derived from the name prop, using the getInitials function.
    /// The initials are displayed when there is no image (including while the image is loading).
    static member inline initials (value: string) = Interop.mkProperty<IAvatarProp> "initials" value
    /// Custom initials.
    /// It is usually not necessary to specify custom initials; by default they will be derived from the `name` prop, using the `getInitials` function.
    /// The initials are displayed when there is no image (including while the image is loading).
    static member inline initials (value: IReactProperty list) = Interop.mkProperty<IAvatarProp> "initials" (!!value |> createObj |> unbox<IReactProperty>)
    /// Takes the src for the image. No need to specifify "src", you just need to pass the string.
    static member inline image (value: IImageProp list) = Interop.mkProperty<IAvatarProp> "image" (!!value |> createObj |> unbox<IImageProp>)
    /// Icon to be displayed when the avatar doesn't have an image or initials.
    static member inline icon (value: ReactElement) = Interop.mkProperty<IAvatarProp> "icon" value
    /// Icon to be displayed when the avatar doesn't have an image or initials.
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<IAvatarProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Badge to show the avatar's presence status.
    static member inline badge (value: ReactElement) = Interop.mkProperty<IAvatarProp> "badge" value
    /// Badge to show the avatar's presence status.
    static member inline badge (value: IPresenceBadgeProp list) = Interop.mkProperty<IAvatarProp> "badge" (!!value |> createObj |> unbox<IPresenceBadgeProp>)
    /// Specify a string to be used instead of the name, to determine which color to use when color="colorful".
    /// Use this when a name is not available, but there is another unique identifier that can be used instead.
    static member inline idForColor (value: string) = Interop.mkProperty<IAvatarProp> "idForColor" value
    /// The name of the person or entity represented by this Avatar. This should always be provided if it is available.
    /// The name is used to determine the initials displayed when there is no image. It is also provided to accessibility tools.
    static member inline name (value: string) = Interop.mkProperty<IAvatarProp> "name" value


module avatar =

    type [<Erase>] as' =
        static member inline span = Interop.mkProperty<IAvatarProp> "as" "span"

    /// The avatar can have a circular or square shape.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IAvatarProp> "shape" "circular"
        static member inline square = Interop.mkProperty<IAvatarProp> "shape" "square"

    /// Optional activity indicator
    type [<Erase>] active =
        ///active: the avatar will be decorated according to activeAppearance
        static member inline active = Interop.mkProperty<IAvatarProp> "active" "active"
        ///inactive: the avatar will be reduced in size and partially transparent
        static member inline inactive = Interop.mkProperty<IAvatarProp> "active" "inactive"
        ///unset: normal display
        static member inline unset = Interop.mkProperty<IAvatarProp> "active" "unset"

    /// The appearance when active="active"
    type [<Erase>] activeAppearance =
        ///active: the avatar will be decorated according to activeAppearance
        static member inline ring = Interop.mkProperty<IAvatarProp> "activeAppearance" "ring"
        ///inactive: the avatar will be reduced in size and partially transparent
        static member inline shadow = Interop.mkProperty<IAvatarProp> "activeAppearance" "shadow"
        ///unset: normal display
        static member inline ringShadow = Interop.mkProperty<IAvatarProp> "activeAppearance" "ring-shadow"

    /// The color when displaying either an icon or initials.
    /// neutral (default): gray
    /// brand: color from the brand palette
    /// colorful: picks a color from a set of pre-defined colors, based on a hash of the name (or idForColor if provided)
    /// specific color from the theme
    type [<Erase>] color =
        static member inline neutral = Interop.mkProperty<IAvatarProp> "color" "neutral"
        static member inline brand = Interop.mkProperty<IAvatarProp> "color" "brand"
        static member inline colorful = Interop.mkProperty<IAvatarProp> "color" "colorful"
        static member inline darkred = Interop.mkProperty<IAvatarProp> "color" "dark"
        static member inline cranberry = Interop.mkProperty<IAvatarProp> "color" "cranberry"
        static member inline red = Interop.mkProperty<IAvatarProp> "color" "red"
        static member inline pumpkin = Interop.mkProperty<IAvatarProp> "color" "pumpkin"
        static member inline peach = Interop.mkProperty<IAvatarProp> "color" "peach"
        static member inline marigold = Interop.mkProperty<IAvatarProp> "color" "marigold"
        static member inline gold = Interop.mkProperty<IAvatarProp> "color" "gold"
        static member inline brass = Interop.mkProperty<IAvatarProp> "color" "brass"
        static member inline brown = Interop.mkProperty<IAvatarProp> "color" "brown"
        static member inline forest = Interop.mkProperty<IAvatarProp> "color" "forest"
        static member inline seafoam = Interop.mkProperty<IAvatarProp> "color" "seafoam"
        static member inline darkgreen = Interop.mkProperty<IAvatarProp> "color" "dark"
        static member inline lightteal = Interop.mkProperty<IAvatarProp> "color" "light"
        static member inline teal = Interop.mkProperty<IAvatarProp> "color" "teal"
        static member inline steel = Interop.mkProperty<IAvatarProp> "color" "steel"
        static member inline blue = Interop.mkProperty<IAvatarProp> "color" "blue"
        static member inline royalblue = Interop.mkProperty<IAvatarProp> "color" "royal"
        static member inline cornflower = Interop.mkProperty<IAvatarProp> "color" "cornflower"
        static member inline navy = Interop.mkProperty<IAvatarProp> "color" "navy"
        static member inline lavender = Interop.mkProperty<IAvatarProp> "color" "lavender"
        static member inline purple = Interop.mkProperty<IAvatarProp> "color" "purple"
        static member inline grape = Interop.mkProperty<IAvatarProp> "color" "grape"
        static member inline lilac = Interop.mkProperty<IAvatarProp> "color" "lilac"
        static member inline pink = Interop.mkProperty<IAvatarProp> "color" "pink"
        static member inline magenta = Interop.mkProperty<IAvatarProp> "color" "magenta"
        static member inline plum = Interop.mkProperty<IAvatarProp> "color" "plum"
        static member inline beige = Interop.mkProperty<IAvatarProp> "color" "beige"
        static member inline mink = Interop.mkProperty<IAvatarProp> "color" "mink"
        static member inline platinum = Interop.mkProperty<IAvatarProp> "color" "platinum"
        static member inline anchor = Interop.mkProperty<IAvatarProp> "color" "anchor"

    /// Size of the Avatar.
    type [<Erase>] size =
        static member inline ``16`` = Interop.mkProperty<IAvatarProp> "size" 16
        static member inline ``20`` = Interop.mkProperty<IAvatarProp> "size" 20
        static member inline ``24`` = Interop.mkProperty<IAvatarProp> "size" 24
        static member inline ``28`` = Interop.mkProperty<IAvatarProp> "size" 28
        static member inline ``32`` = Interop.mkProperty<IAvatarProp> "size" 32
        static member inline ``36`` = Interop.mkProperty<IAvatarProp> "size" 36
        static member inline ``40`` = Interop.mkProperty<IAvatarProp> "size" 40
        static member inline ``48`` = Interop.mkProperty<IAvatarProp> "size" 48
        static member inline ``56`` = Interop.mkProperty<IAvatarProp> "size" 56
        static member inline ``64`` = Interop.mkProperty<IAvatarProp> "size" 64
        static member inline ``72`` = Interop.mkProperty<IAvatarProp> "size" 72
        static member inline ``96`` = Interop.mkProperty<IAvatarProp> "size" 96
        static member inline ``120`` = Interop.mkProperty<IAvatarProp> "size" 120
        static member inline ``128`` = Interop.mkProperty<IAvatarProp> "size" 128

// -------------------------------------------------------------------------- Image --------------------------------------------------------------------------------------

type [<Erase>] image =
    inherit FelizProps.prop<IImageProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IImageProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline block (value: bool) = Interop.mkProperty<IImageProp> "block" value
    static member inline bordered (value: bool) = Interop.mkProperty<IImageProp> "bordered" value
    static member inline shadow (value: bool) = Interop.mkProperty<IImageProp> "shadow" value
    static member inline alt (value: string) = Interop.mkProperty<IImageProp> "alt" value
    static member inline src (value: string) = Interop.mkProperty<IImageProp> "src" value

module image =
    /// An image can set how it should be resized to fit its container.
    type [<Erase>] fit =
        static member inline none = Interop.mkProperty<IImageProp> "fit" "none"
        static member inline center = Interop.mkProperty<IImageProp> "fit" "center"
        static member inline contain = Interop.mkProperty<IImageProp> "fit" "contain"
        static member inline cover = Interop.mkProperty<IImageProp> "fit" "cover"
        static member inline default' = Interop.mkProperty<IImageProp> "fit" "default"

    /// An image can appear square, circular, or rounded.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IImageProp> "shape" "circular"
        static member inline square = Interop.mkProperty<IImageProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<IImageProp> "shape" "rounded"

// -------------------------------------------------------------------------- Button --------------------------------------------------------------------------------------

type [<Erase>] button =
    inherit FelizProps.prop<IButtonProp>
    /// Root of the component that renders as either a `<button>` tag or an `<a>` tag.
    static member inline root (value:  IReactProperty list) = Interop.mkProperty<IButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IButtonProp> "icon" value
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<IButtonProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IButtonProp> "disabledFocusable" value

module button =

    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<IButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<IButtonProp> "as" "button"

    /// A button can have its content and borders styled for greater emphasis or to be subtle.
    type [<Erase>] appearance =
        /// 'subtle': Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<IButtonProp> "appearance" "subtle"
        /// 'outline': Removes background styling.
        static member inline outline = Interop.mkProperty<IButtonProp> "appearance" "outline"
        /// 'secondary' (default): Gives emphasis to the button in such a way that it indicates a secondary action.
        static member inline secondary = Interop.mkProperty<IButtonProp> "appearance" "secondary"
        /// 'primary': Emphasizes the button as a primary action.
        static member inline primary' = Interop.mkProperty<IButtonProp> "appearance" "primary"
        /// 'transparent': Removes background and border styling.
        static member inline transparent = Interop.mkProperty<IButtonProp> "appearance" "transparent"

    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IButtonProp> "shape" "circular"
        static member inline square = Interop.mkProperty<IButtonProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<IButtonProp> "shape" "rounded"

    /// A button can format its icon to appear before or after its content.
    type [<Erase>] iconPosition =
        static member inline before' = Interop.mkProperty<IButtonProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<IButtonProp> "iconPosition" "after"

    /// A button supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IButtonProp> "size" "large"

// -------------------------------------------------------------------------- ToggleButton --------------------------------------------------------------------------------------

type [<Erase>] toggleButton =
    inherit FelizProps.prop<IToggleButtonProp>
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IToggleButtonProp> "icon" value
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IToggleButtonProp> "disabledFocusable" value
    /// Defines the controlled checked state of the ToggleButton. If passed, ToggleButton ignores the defaultChecked property.
    /// This should only be used if the checked state is to be controlled at a higher level and there is a plan to pass the correct value
    /// based on handling onClick events and re-rendering.
    static member inline checked' (value: bool) = Interop.mkProperty<IToggleButtonProp> "checked" value

module toggleButton =

    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<IToggleButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<IToggleButtonProp> "as" "button"

    /// A button can have its content and borders styled for greater emphasis or to be subtle.
    type [<Erase>] appearance =
        /// 'subtle': Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<IToggleButtonProp> "appearance" "subtle"
        /// 'outline': Removes background styling.
        static member inline outline = Interop.mkProperty<IToggleButtonProp> "appearance" "outline"
        /// 'secondary' (default): Gives emphasis to the button in such a way that it indicates a secondary action.
        static member inline secondary = Interop.mkProperty<IToggleButtonProp> "appearance" "secondary"
        /// 'primary': Emphasizes the button as a primary action.
        static member inline primary' = Interop.mkProperty<IToggleButtonProp> "appearance" "primary"
        /// 'transparent': Removes background and border styling.
        static member inline transparent = Interop.mkProperty<IToggleButtonProp> "appearance" "transparent"

    /// A button can format its icon to appear before or after its content.
    type [<Erase>] iconPosition =
        static member inline before' = Interop.mkProperty<IToggleButtonProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<IToggleButtonProp> "iconPosition" "after"

    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IToggleButtonProp> "shape" "circular"
        static member inline square = Interop.mkProperty<IToggleButtonProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<IToggleButtonProp> "shape" "rounded"

    /// A button supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IToggleButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IToggleButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IToggleButtonProp> "size" "large"
// -------------------------------------------------------------------------- Accordian --------------------------------------------------------------------------------------

type [<Erase>] accordion =
    inherit FelizProps.prop<IAccordionProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAccordionProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Default value for the uncontrolled state of the panel.
    /// If using a single value, wrap it in a list, array, or seq.
    static member inline defaultOpenItems (value: #seq<'T>) = Interop.mkProperty<IAccordionProp> "defaultOpenItems" (ResizeArray<_> value)
    /// Controls the state of the panel.
    /// If using a single value, wrap it in a list, array, or seq.
    static member inline openItems (value: #seq<'T>) = Interop.mkProperty<IAccordionProp> "openItems" (ResizeArray<_> value)
    /// Indicates if Accordion support multiple Panels closed at the same time.
    static member inline collapsible (value: bool) = Interop.mkProperty<IAccordionProp> "collapsible" value
    /// Indicates if Accordion support multiple Panels opened at the same time.
    static member inline multiple (value: bool) = Interop.mkProperty<IAccordionProp> "multiple" value
    /// Callback to be called when the opened items change.
    static member inline onToggle (handler: (ValueProp<'T> -> unit)) = Interop.mkProperty<IAccordionProp> "onToggle" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback to be called when the opened items change.
    static member inline onToggle (value: (MouseEvent -> ValueProp<'T> -> unit)) = Interop.mkProperty<IAccordionProp> "onToggle" (System.Func<_,_,_> value)
    /// Callback to be called when the opened items change.
    static member inline onToggle (value: (KeyboardEvent -> ValueProp<'T> -> unit)) = Interop.mkProperty<IAccordionProp> "onToggle" (System.Func<_,_,_> value)

module accordion =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IAccordionProp> "as" "div"

    type [<Erase>] navigation =
        static member inline linear = Interop.mkProperty<IAccordionProp> "navigation" "linear"
        static member inline circular = Interop.mkProperty<IAccordionProp> "navigation" "circular"

type [<Erase>] accordionItem =
    inherit FelizProps.prop<IAccordionItemProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAccordionItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Disables opening/closing of panel.
    static member inline disabled (value: bool) = Interop.mkProperty<IAccordionItemProp> "disabled" value
    /// Required value that identifies this item inside an Accordion component.
    static member inline value (value: 'T) = Interop.mkProperty<IAccordionItemProp> "value" value

type [<Erase>] accordionHeader =
    inherit FelizProps.prop<IAccordionHeaderProp>
    /// The element wrapping the button. By default this is a div, but can be a heading.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAccordionHeaderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Expand icon slot rendered before (or after) children content in heading.
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IAccordionHeaderProp> "icon" value
    /// Expand icon slot rendered before (or after) children content in heading.
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<IAccordionHeaderProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Expand icon slot rendered before (or after) children content in heading.
    static member inline expandIcon (value:  ReactElement) = Interop.mkProperty<IAccordionHeaderProp> "expandIcon" value
    /// Expand icon slot rendered before (or after) children content in heading.
    static member inline expandIcon (value:  IReactProperty list) = Interop.mkProperty<IAccordionHeaderProp> "expandIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// The component to be used as button in heading
    static member inline button (value:  ReactElement) = Interop.mkProperty<IAccordionHeaderProp> "button" value
    /// The component to be used as button in heading
    static member inline button (value:  IReactProperty list) = Interop.mkProperty<IAccordionHeaderProp> "button" (!!value |> createObj |> unbox<IReactProperty>)

module accordionHeader =
    /// The position of the expand  icon slot in heading.
    type [<Erase>] expandIconPosition =
        static member inline start = Interop.mkProperty<IAccordionHeaderProp> "expandIconPosition" "start"
        static member inline end' = Interop.mkProperty<IAccordionHeaderProp> "expandIconPosition" "end"

    /// Size of spacing in the heading.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IAccordionHeaderProp> "size" "small"
        static member inline medium = Interop.mkProperty<IAccordionHeaderProp> "size" "medium"
        static member inline large = Interop.mkProperty<IAccordionHeaderProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<IAccordionHeaderProp> "size" "extra-large"

type [<Erase>] accordionPanel =
    inherit FelizProps.prop<IAccordionPanelProp>
    static member inline root (value: ReactElement)= Interop.mkProperty<IAccordionPanelProp> "root" value
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IAccordionPanelProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Internal open state, provided by context.
    static member inline open' (value: bool)= Interop.mkProperty<IAccordionPanelProp> "open" value

// -------------------------------------------------------------------------- Checkbox --------------------------------------------------------------------------------------

type [<Erase>] checkbox =
    /// WARNING: Checkbox doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children (value: ReactElement) = Interop.mkProperty<ICheckboxProp> "children" value
    /// WARNING: Checkbox doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: ReactElement seq) = Interop.mkProperty<ICheckboxProp> "children" (Interop.reactApi.Children.toArray elems)
    /// The root element of the Checkbox.
    /// The root slot receives the className and style specified directly on the <Checkbox>. All other native props will be applied to the primary slot: input
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ICheckboxProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Hidden input that handles the checkbox's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on <Checkbox> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: ReactElement) = Interop.mkProperty<ICheckboxProp> "input" value
    /// Hidden input that handles the checkbox's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on <Checkbox> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<ICheckboxProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Checkbox's label.
    static member inline label (value: string) = Interop.mkProperty<ICheckboxProp> "label" value
    /// The Checkbox's label.
    static member inline label (value: ReactElement) = Interop.mkProperty<ICheckboxProp> "label" value
    /// The Checkbox's label.
    static member inline label (value: ILabelProp list) = Interop.mkProperty<ICheckboxProp> "label" (!!value |> createObj |> unbox<ILabelProp>)
    /// The checkbox, with the checkmark icon as its child when checked.
    static member inline indicator (value: ReactElement) = Interop.mkProperty<ICheckboxProp> "indicator" value
    /// The checkbox, with the checkmark icon as its child when checked.
    static member inline indicator (value: IReactProperty list) = Interop.mkProperty<ICheckboxProp> "indicator" (!!value |> createObj |> unbox<IReactProperty>)
    /// The controlled value for the checkbox.
    static member inline checked' (value: string) = Interop.mkProperty<ICheckboxProp> "checked" value
    /// The controlled value for the checkbox.
    static member inline checked' (value: bool) = Interop.mkProperty<ICheckboxProp> "checked" value
    /// The controlled value for the checkbox.
    static member inline checked' (value: CheckState) =
        match value with
        | Checked -> Interop.mkProperty<ICheckboxProp> "checked" true
        | Unchecked -> Interop.mkProperty<ICheckboxProp> "checked" false
        | Mixed -> Interop.mkProperty<ICheckboxProp> "checked" "mixed"

    /// Whether the checkbox should be rendered as checked by default.
    static member inline defaultChecked (value: bool) = Interop.mkProperty<ICheckboxProp> "defaultChecked" value
    /// Whether the checkbox should be rendered as checked by default.
    static member inline defaultChecked (value: string) = Interop.mkProperty<ICheckboxProp> "defaultChecked" value
    /// Whether the checkbox should be rendered as checked by default.
    static member inline defaultChecked (value: CheckState) =
        match value with
        | Checked -> Interop.mkProperty<ICheckboxProp> "defaultChecked" true
        | Unchecked -> Interop.mkProperty<ICheckboxProp> "defaultChecked" false
        | Mixed -> Interop.mkProperty<ICheckboxProp> "defaultChecked" "mixed"
    static member inline onChange (value: (CheckState -> unit)) = Interop.mkProperty<ICheckboxProp> "onChange" (System.Func<_,_,_> (fun _ c -> c |> CheckState.fromData |> value))
    static member inline onChange (value: (MouseEvent -> CheckState -> unit)) = Interop.mkProperty<ICheckboxProp> "onChange" (System.Func<_,_,_> (fun ev c -> c |> CheckState.fromData |> value ev ))

module checkbox =
    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<ICheckboxProp> "as" "input"

    type [<Erase>] checked' =
        static member inline mixed = Interop.mkProperty<ICheckboxProp> "checked" "mixed"

    /// Whether the checkbox should be rendered as checked by default.
    type [<Erase>] defaultChecked =
        static member inline mixed = Interop.mkProperty<ICheckboxProp> "defaultChecked" "mixed"

    /// The position of the label relative to the checkbox indicator.
    type [<Erase>] labelPosition =
        static member inline before = Interop.mkProperty<ICheckboxProp> "labelPosition" "before"
        static member inline after = Interop.mkProperty<ICheckboxProp> "labelPosition" "after"

    /// The shape of the checkbox indicator.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<ICheckboxProp> "shape" "circular"
        static member inline square = Interop.mkProperty<ICheckboxProp> "shape" "square"

    /// The size of the checkbox indicator.
    type [<Erase>] size =
        static member inline medium = Interop.mkProperty<ICheckboxProp> "size" "medium"
        static member inline large = Interop.mkProperty<ICheckboxProp> "size" "large"

// -------------------------------------------------------------------------- StackItem --------------------------------------------------------------------------------------

type [<Erase>] stackItem =
    inherit FelizProps.prop<IStackItemProp>
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
    inherit FelizProps.prop<IStackProp>
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
    static member inline styles (properties: #IStyleAttribute list) = Interop.mkProperty<IStackProp> "styles" (!!properties |> createObj)//TODO
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

// -------------------------------------------------------------------------- Badge --------------------------------------------------------------------------------------

type [<Erase>] badge =
    static member inline root (value:  IReactProperty list) = Interop.mkProperty<IBadgeProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IBadgeProp> "icon" value
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<IBadgeProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)

module badge =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IBadgeProp> "as" "div"

    /// A Badge can be filled, outline, ghost, inverted
    type [<Erase>] appearance =
        static member inline filled = Interop.mkProperty<IBadgeProp> "appearance" "filled"
        static member inline ghost = Interop.mkProperty<IBadgeProp> "appearance" "ghost"
        static member inline outline = Interop.mkProperty<IBadgeProp> "appearance" "outline"
        static member inline tint = Interop.mkProperty<IBadgeProp> "appearance" "tint"

    /// A Badge can be one of preset colors
    type [<Erase>] color =
        static member inline brand = Interop.mkProperty<IBadgeProp> "color" "brand"
        static member inline danger = Interop.mkProperty<IBadgeProp> "color" "danger"
        static member inline important = Interop.mkProperty<IBadgeProp> "color" "important"
        static member inline informative = Interop.mkProperty<IBadgeProp> "color" "informative"
        static member inline severe = Interop.mkProperty<IBadgeProp> "color" "severe"
        static member inline subtle = Interop.mkProperty<IBadgeProp> "color" "subtle"
        static member inline success = Interop.mkProperty<IBadgeProp> "color" "success"
        static member inline warning = Interop.mkProperty<IBadgeProp> "color" "warning"

    /// A Badge can position the icon before or after the content.
    type [<Erase>] iconPosition =
        static member inline before = Interop.mkProperty<IBadgeProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<IBadgeProp> "iconPosition" "after"

    /// A Badge can be square, circular or rounded.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IBadgeProp> "shape" "circular"
        static member inline square = Interop.mkProperty<IBadgeProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<IBadgeProp> "shape" "rounded"

    /// A Badge can be on of several preset sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IBadgeProp> "size" "small"
        static member inline tiny = Interop.mkProperty<IBadgeProp> "size" "tiny"
        static member inline extraSmall = Interop.mkProperty<IBadgeProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<IBadgeProp> "size" "medium"
        static member inline large = Interop.mkProperty<IBadgeProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<IBadgeProp> "size" "extra-large"

// -------------------------------------------------------------------------- CounterBadge --------------------------------------------------------------------------------------

type [<Erase>] counterBadge =
    /// Value displayed by the Badge
    static member inline count (value: int) = Interop.mkProperty<ICounterBadgeProp> "count" value
    /// Value displayed by the Badge
    static member inline count (value: float) = Interop.mkProperty<ICounterBadgeProp> "count" value
    /// Value displayed by the Badge
    static member inline count (value: decimal) = Interop.mkProperty<ICounterBadgeProp> "count" value
    static member inline icon (value:  ReactElement) = Interop.mkProperty<ICounterBadgeProp> "icon" value
    /// If a dot should be displayed without the count
    static member inline dot (value: bool) = Interop.mkProperty<ICounterBadgeProp> "dot" value
    /// Max number to be displayed
    static member inline overflowCount (value: int) = Interop.mkProperty<ICounterBadgeProp> "overflowCount" value
    /// Max number to be displayed
    static member inline overflowCount (value: float) = Interop.mkProperty<ICounterBadgeProp> "overflowCount" value
    /// Max number to be displayed
    static member inline overflowCount (value: decimal) = Interop.mkProperty<ICounterBadgeProp> "overflowCount" value
    /// If the badge should be shown when count is 0
    static member inline showZero (value: bool) = Interop.mkProperty<ICounterBadgeProp> "showZero" value

module counterBadge =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ICounterBadgeProp> "as" "div"
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ICounterBadgeProp> "size" "small"
        static member inline tiny = Interop.mkProperty<ICounterBadgeProp> "size" "tiny"
        static member inline extraSmall = Interop.mkProperty<ICounterBadgeProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<ICounterBadgeProp> "size" "medium"
        static member inline large = Interop.mkProperty<ICounterBadgeProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<ICounterBadgeProp> "size" "extra-large"

    type [<Erase>] iconPosition =
        static member inline before = Interop.mkProperty<ICounterBadgeProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<ICounterBadgeProp> "iconPosition" "after"

    /// A Badge can have different appearances that emphasize certain parts of it:
    type [<Erase>] appearance =
        /// The default appearance if one is not specified. The badge background is filled with color with a contrasting foreground text to match.
        static member inline filled = Interop.mkProperty<ICounterBadgeProp> "appearance" "filled"
        /// The badge background is transparent, with the foreground text taking color to emphasize it.
        static member inline ghost = Interop.mkProperty<ICounterBadgeProp> "appearance" "ghost"

    /// Semantic colors for a counter badge
    type [<Erase>] color =
        static member inline brand = Interop.mkProperty<ICounterBadgeProp> "color" "brand"
        static member inline danger = Interop.mkProperty<ICounterBadgeProp> "color" "danger"
        static member inline important = Interop.mkProperty<ICounterBadgeProp> "color" "important"
        static member inline informative = Interop.mkProperty<ICounterBadgeProp> "color" "informative"

    /// A Badge can be circular or rounded
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<ICounterBadgeProp> "shape" "circular"
        static member inline rounded = Interop.mkProperty<ICounterBadgeProp> "shape" "rounded"

// -------------------------------------------------------------------------- PresenceBadge --------------------------------------------------------------------------------------

type [<Erase>] presenceBadge =
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IPresenceBadgeProp> "icon" value
    /// Modifies the display to indicate that the user is out of office. This can be combined with any status to display an out-of-office version of that status
    static member inline outOfOffice (value: bool) = Interop.mkProperty<IPresenceBadgeProp> "outOfOffice" value

module presenceBadge =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IPresenceBadgeProp> "as" "div"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IPresenceBadgeProp> "size" "small"
        static member inline tiny = Interop.mkProperty<IPresenceBadgeProp> "size" "tiny"
        static member inline extraSmall = Interop.mkProperty<IPresenceBadgeProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<IPresenceBadgeProp> "size" "medium"
        static member inline large = Interop.mkProperty<IPresenceBadgeProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<IPresenceBadgeProp> "size" "extra-large"

    type [<Erase>] status =
        static member inline unknown = Interop.mkProperty<IPresenceBadgeProp> "status" "unknown"
        static member inline offline = Interop.mkProperty<IPresenceBadgeProp> "status" "offline"
        static member inline busy = Interop.mkProperty<IPresenceBadgeProp> "status" "busy"
        static member inline outOfOffice = Interop.mkProperty<IPresenceBadgeProp> "status" "out-of-office"
        static member inline away = Interop.mkProperty<IPresenceBadgeProp> "status" "away"
        static member inline available = Interop.mkProperty<IPresenceBadgeProp> "status" "available"
        static member inline doNotDisturb = Interop.mkProperty<IPresenceBadgeProp> "status" "do-not-disturb"
        static member inline blocked = Interop.mkProperty<IPresenceBadgeProp> "status" "blocked"

// -------------------------------------------------------------------------- Table --------------------------------------------------------------------------------------

type [<Erase>] table =
    inherit FelizProps.prop<ITableProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Render all table elements as divs instead of semantic table elements Using divs no longer uses display: table layout but display: flex
    static member inline noNativeElements (value: bool) = Interop.mkProperty<ITableProp> "noNativeElements" value
    /// Whether the table is sortable
    static member inline sortable (value: bool) = Interop.mkProperty<ITableProp> "sortable" value
    static member inline children (value: ReactElement list) = Interop.mkProperty<ITableProp> "children" value

module table =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableProp> "as" "div"
        static member inline table = Interop.mkProperty<ITableProp> "as" "table"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITableProp> "size" "small"
        static member inline extraSmall = Interop.mkProperty<ITableProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<ITableProp> "size" "medium"

// -------------------------------------------------------------------------- TableHeader --------------------------------------------------------------------------------------

/// No info found
type [<Erase>] tableHeader =
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableHeaderProp> "root"  (!!value |> createObj |> unbox<IReactProperty>)
    static member inline children (value: ReactElement list) = Interop.mkProperty<ITableHeaderProp> "children" value

module tableHeader =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableHeaderProp> "as" "div"
        static member inline thead = Interop.mkProperty<ITableHeaderProp> "as" "thead"

// -------------------------------------------------------------------------- TableHeaderCell --------------------------------------------------------------------------------------

/// No info found
type [<Erase>] tableHeaderCell =
    inherit FelizProps.prop<ITableHeaderCellProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableHeaderCellProp> "root"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Aside content for anything that should be after main content of the table header cell
    static member inline aside (value: ReactElement) = Interop.mkProperty<ITableHeaderCellProp> "aside" value
    /// Aside content for anything that should be after main content of the table header cell
    static member inline aside (value: IReactProperty list) = Interop.mkProperty<ITableHeaderCellProp> "aside"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Button handles correct narration and interactions for sorting
    static member inline button (value: IButtonProp list) = Interop.mkProperty<ITableHeaderCellProp> "button"  (!!value |> createObj |> unbox<IButtonProp>)
    /// Button handles correct narration and interactions for sorting
    static member inline button (value: IReactProperty list) = Interop.mkProperty<ITableHeaderCellProp> "button"  (!!value |> createObj |> unbox<IReactProperty>)
    static member inline sortIcon (value: ReactElement) = Interop.mkProperty<ITableHeaderCellProp> "sortIcon" value
    static member inline sortIcon (value: IReactProperty list) = Interop.mkProperty<ITableHeaderCellProp> "sortIcon"  (!!value |> createObj |> unbox<IReactProperty>)

module tableHeaderCell =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableHeaderCellProp> "as" "div"
        static member inline th = Interop.mkProperty<ITableHeaderCellProp> "as" "th"

    type [<Erase>] sortDirection =
        static member inline ascending = Interop.mkProperty<ITableHeaderCellProp> "sortDirection" "ascending"
        static member inline descending = Interop.mkProperty<ITableHeaderCellProp> "sortDirection" "descending"

// -------------------------------------------------------------------------- TableBody --------------------------------------------------------------------------------------

type [<Erase>] tableBody =
    inherit FelizProps.prop<ITableBodyProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableBodyProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
module tableBody =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableBodyProp> "as" "div"
        static member inline tbody = Interop.mkProperty<ITableBodyProp> "as" "tbody"

// -------------------------------------------------------------------------- TableResizeHandle --------------------------------------------------------------------------------------

type [<Erase>] tableResizeHandle =
    inherit FelizProps.prop<ITableResizeHandleProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableResizeHandleProp> "root" (!!value |> createObj |> unbox<IReactProperty>)


// -------------------------------------------------------------------------- TableRow --------------------------------------------------------------------------------------

/// No info found
type [<Erase>] tableRow =
    inherit FelizProps.prop<ITableRowProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableRowProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline children (value: ReactElement list) = Interop.mkProperty<ITableRowProp> "children" value

module tableRow =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableRowProp> "as" "div"
        static member inline tr = Interop.mkProperty<ITableRowProp> "as" "tr"
    type [<Erase>] appearance =
        static member inline none = Interop.mkProperty<ITableRowProp> "appearance" "none"
        static member inline neutral = Interop.mkProperty<ITableRowProp> "appearance" "neutral"
        static member inline brand = Interop.mkProperty<ITableRowProp> "appearance" "brand"

// -------------------------------------------------------------------------- TableCell --------------------------------------------------------------------------------------

type [<Erase>] tableCell =
    inherit FelizProps.prop<ITableCellProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableCellProp> "root"  (!!value |> createObj |> unbox<IReactProperty>)
    static member inline children (value: ReactElement list) = Interop.mkProperty<ITableCellProp> "children" value

module tableCell =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableCellProp> "as" "div"
        static member inline td = Interop.mkProperty<ITableCellProp> "as" "td"

// -------------------------------------------------------------------------- TableCellActions --------------------------------------------------------------------------------------

type [<Erase>] tableCellActions =
    inherit FelizProps.prop<ITableCellActionsProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableCellActionsProp> "root" (!!value |> createObj |> unbox<IReactProperty>)


// -------------------------------------------------------------------------- TableSelectionCell --------------------------------------------------------------------------------------

type [<Erase>] tableSelectionCell =
    /// Selection indicator if selection type is checkbox
    static member inline checkboxIndicator (value: ReactElement) = Interop.mkProperty<ITableSelectionCellProp> "checkboxIndicator" value
    /// Selection indicator if selection type is checkbox
    static member inline checkboxIndicator (value: ICheckboxProp list) = Interop.mkProperty<ITableSelectionCellProp> "checkboxIndicator" (!!value |> createObj |> unbox<ICheckboxProp>)
    /// Selection indicator if selection type is radio
    static member inline radioIndicator (value: ReactElement) = Interop.mkProperty<ITableSelectionCellProp> "radioIndicator" value
    /// Selection indicator if selection type is radio
    static member inline radioIndicator (value: IRadioProp list) = Interop.mkProperty<ITableSelectionCellProp> "radioIndicator" (!!value |> createObj |> unbox<IRadioProp>)
    static member inline checked' (value: bool) = Interop.mkProperty<ITableSelectionCellProp> "checked" value
    static member inline checked' (value: string) = Interop.mkProperty<ITableSelectionCellProp> "checked" value
    static member inline checked' (value: CheckState) =
        match value with
        | Checked -> Interop.mkProperty<ITableSelectionCellProp> "checked" true
        | Unchecked -> Interop.mkProperty<ITableSelectionCellProp> "checked" false
        | Mixed -> Interop.mkProperty<ITableSelectionCellProp> "checked" "mixed"
    /// Only visible when checked or the parent row is hovered/focused
    static member inline subtle (value: bool) = Interop.mkProperty<ITableSelectionCellProp> "subtle" value
    static member inline ariaLabel (value: string) = Interop.mkProperty<ITableSelectionCellProp> "aria-label" value

module tableSelectionCell =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableSelectionCellProp> "as" "div"
        static member inline td = Interop.mkProperty<ITableSelectionCellProp> "as" "td"
    type [<Erase>] type' =
        static member inline checkbox = Interop.mkProperty<ITableSelectionCellProp> "type" "checkbox"
        static member inline radio = Interop.mkProperty<ITableSelectionCellProp> "type" "radio"

// -------------------------------------------------------------------------- TableCellLayout --------------------------------------------------------------------------------------

type [<Erase>] tableCellLayout =
    inherit FelizProps.prop<ITableCellLayoutProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITableCellLayoutProp> "root"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Main text for the table cell. Children of the root slot are automatically rendered here
    static member inline main (value: string) = Interop.mkProperty<ITableCellLayoutProp> "main" value
    /// Main text for the table cell. Children of the root slot are automatically rendered here
    static member inline main (value: ReactElement) = Interop.mkProperty<ITableCellLayoutProp> "main" value
    /// Main text for the table cell. Children of the root slot are automatically rendered here
    static member inline main (value: IReactProperty list) = Interop.mkProperty<ITableCellLayoutProp> "main"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Secondary text that describes or complements the main text
    static member inline description (value: string) = Interop.mkProperty<ITableCellLayoutProp> "description" value
    /// Secondary text that describes or complements the main text
    static member inline description (value: ReactElement) = Interop.mkProperty<ITableCellLayoutProp> "description" value
    /// Secondary text that describes or complements the main text
    static member inline description (value: IReactProperty list) = Interop.mkProperty<ITableCellLayoutProp> "description"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Slot for an icon or other visual element
    static member inline media (value:  ReactElement) = Interop.mkProperty<ITableCellLayoutProp> "media" value
    /// Slot for an icon or other visual element
    static member inline media (value:  IReactProperty list) = Interop.mkProperty<ITableCellLayoutProp> "media"  (!!value |> createObj |> unbox<IReactProperty>)
    /// A layout wrapper for the main and description slots
    static member inline content (value: ReactElement) = Interop.mkProperty<ITableCellLayoutProp> "content" value
    /// A layout wrapper for the main and description slots
    static member inline content (value: IReactProperty list) = Interop.mkProperty<ITableCellLayoutProp> "content"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Renders content with overflow: hidden and text-overflow: ellipsis
    static member inline truncate (value: bool) = Interop.mkProperty<ITableCellLayoutProp> "truncate" value
    static member inline children (value: ReactElement list) = Interop.mkProperty<ITableCellLayoutProp> "children" value

module tableCellLayout =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITableCellLayoutProp> "as" "div"
    type [<Erase>] appearance =
        /// Renders design variants of the table cell
        static member inline primary = Interop.mkProperty<ITableCellLayoutProp> "appearance" "primary"


// -------------------------------------------------------------------------- Link --------------------------------------------------------------------------------------

type [<Erase>] link =
    inherit FelizProps.prop<ILinkProp>
    /// Root of the component that renders as either an <a> or a <button> tag.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ILinkProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Whether the link is disabled.
    static member inline disabled (value: bool) = Interop.mkProperty<ILinkProp> "disabled" value
    /// When set, allows the link to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<ILinkProp> "disabledFocusable" value
    /// If true, changes styling when the link is being used alongside other text content.
    static member inline inline' (value: bool) = Interop.mkProperty<ILinkProp> "inline" value

module link =
    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<ILinkProp> "as" "a"
        static member inline button = Interop.mkProperty<ILinkProp> "as" "button"
    /// A link can appear either with its default style or subtle. If not specified, the link appears with its default styling.
    type [<Erase>] appearance =
        static member inline subtle = Interop.mkProperty<ILinkProp> "appearance" "subtle"
        static member inline default' = Interop.mkProperty<ILinkProp> "appearance" "default"

// -------------------------------------------------------------------------- Divider --------------------------------------------------------------------------------------

type [<Erase>] divider =
    inherit FelizProps.prop<IDividerProp>
    /// Root of the component that renders as a `<div>` tag.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDividerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Accessibility wrapper for content when presented.
    static member inline wrapper (value: ReactElement) = Interop.mkProperty<IDividerProp> "wrapper" value
    /// Accessibility wrapper for content when presented.
    static member inline wrapper (value: IReactProperty list) = Interop.mkProperty<IDividerProp> "wrapper" (!!value |> createObj |> unbox<IReactProperty>)
    /// Adds padding to the beginning and end of the divider.
    static member inline inset (value: bool) = Interop.mkProperty<IDividerProp> "inset" value
    /// A divider can be horizontal (default) or vertical.
    static member inline vertical (value: bool) = Interop.mkProperty<IDividerProp> "vertical" value

module divider =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDividerProp> "as" "div"
    /// A divider can have one of the preset appearances. When not specified, the divider has its default appearance.
    type [<Erase>] appearance =
        static member inline strong = Interop.mkProperty<IDividerProp> "appearance" "strong"
        static member inline brand = Interop.mkProperty<IDividerProp> "appearance" "brand"
        static member inline subtle = Interop.mkProperty<IDividerProp> "appearance" "subtle"
        static member inline default' = Interop.mkProperty<IDividerProp> "appearance" "default"

// -------------------------------------------------------------------------- Text --------------------------------------------------------------------------------------

type [<Erase>] text =
    inherit FelizProps.prop<ITextProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITextProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Applies a block display for the content.
    static member inline block (value: bool) = Interop.mkProperty<ITextProp> "block" value
    /// Applies the italic font style to the content.
    static member inline italic (value: bool) = Interop.mkProperty<ITextProp> "italic" value
    /// Applies the strikethrough text decoration to the content.
    static member inline strikeThrough (value: bool) = Interop.mkProperty<ITextProp> "strikethrough" value
    /// Truncate overflowing text for block displays.
    static member inline truncate (value: bool) = Interop.mkProperty<ITextProp> "truncate" value
    /// Applies the underline text decoration to the content.
    static member inline underline (value: bool) = Interop.mkProperty<ITextProp> "underline" value
    /// Wraps the text content on white spaces.
    static member inline wrap (value: bool) = Interop.mkProperty<ITextProp> "wrap" value

module text =
    type [<Erase>] as' =
        static member inline h1 = Interop.mkProperty<ITextProp> "as" "h1"
        static member inline h2 = Interop.mkProperty<ITextProp> "as" "h2"
        static member inline h3 = Interop.mkProperty<ITextProp> "as" "h3"
        static member inline h4 = Interop.mkProperty<ITextProp> "as" "h4"
        static member inline h5 = Interop.mkProperty<ITextProp> "as" "h5"
        static member inline h6 = Interop.mkProperty<ITextProp> "as" "h6"
        static member inline p = Interop.mkProperty<ITextProp> "as" "p"
        static member inline pre = Interop.mkProperty<ITextProp> "as" "pre"
        static member inline span = Interop.mkProperty<ITextProp> "as" "span"

    /// Aligns text based on the parent container.
    type [<Erase>] align =
        static member inline center = Interop.mkProperty<ITextProp> "align" "center"
        static member inline start = Interop.mkProperty<ITextProp> "align" "start"
        static member inline justify = Interop.mkProperty<ITextProp> "align" "justify"
        static member inline end' = Interop.mkProperty<ITextProp> "align" "end"

    /// Applies the font family to the content.
    type [<Erase>] font =
        static member inline base' = Interop.mkProperty<ITextProp> "font" "base"
        static member inline numeric = Interop.mkProperty<ITextProp> "font" "numeric"
        static member inline monospace = Interop.mkProperty<ITextProp> "font" "monospace"

    /// Applies font size and line height based on the theme typography tokens.
    type [<Erase>] size =
        static member inline ``100`` = Interop.mkProperty<ITextProp> "size" 100
        static member inline ``200``= Interop.mkProperty<ITextProp> "size" 200
        static member inline ``300``= Interop.mkProperty<ITextProp> "size" 300
        static member inline ``400``= Interop.mkProperty<ITextProp> "size" 400
        static member inline ``500``= Interop.mkProperty<ITextProp> "size" 500
        static member inline ``600``= Interop.mkProperty<ITextProp> "size" 600
        static member inline ``700``= Interop.mkProperty<ITextProp> "size" 700
        static member inline ``800``= Interop.mkProperty<ITextProp> "size" 800
        static member inline ``900``= Interop.mkProperty<ITextProp> "size" 900
        static member inline ``1000`` = Interop.mkProperty<ITextProp> "size" 1000

    /// Applies font weight to the content.
    type [<Erase>] weight =
        static member inline medium = Interop.mkProperty<ITextProp> "weight" "medium"
        static member inline regular = Interop.mkProperty<ITextProp> "weight" "regular"
        static member inline semibold = Interop.mkProperty<ITextProp> "weight" "semibold"
        static member inline bold = Interop.mkProperty<ITextProp> "weight" "bold"

// -------------------------------------------------------------------------- MenuButton --------------------------------------------------------------------------------------

type [<Erase>] menuButton =
    inherit FelizProps.prop<IMenuButtonProp>
    /// Icon that renders either before or after the children.
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IMenuButtonProp> "icon" value
    /// Icon that renders either before or after the children.
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<IMenuButtonProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Menu icon that indicates that this button has a menu that can be expanded.
    static member inline menuIcon (value:  ReactElement) = Interop.mkProperty<IMenuButtonProp> "menuIcon" value
    /// Menu icon that indicates that this button has a menu that can be expanded.
    static member inline menuIcon (value:  IReactProperty list) = Interop.mkProperty<IMenuButtonProp> "menuIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu
    /// or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IMenuButtonProp> "disabledFocusable" value

module menuButton =
    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<IMenuButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<IMenuButtonProp> "as" "button"
    /// A button can have its content and borders styled for greater emphasis or to be subtle.
    type [<Erase>] appearance =
        /// 'subtle': Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<IMenuButtonProp> "appearance" "subtle"
        /// 'outline': Removes background styling.
        static member inline outline = Interop.mkProperty<IMenuButtonProp> "appearance" "outline"
        /// 'secondary' (default): Gives emphasis to the button in such a way that it indicates a secondary action.
        static member inline secondary = Interop.mkProperty<IMenuButtonProp> "appearance" "secondary"
        /// 'primary': Emphasizes the button as a primary action.
        static member inline primary' = Interop.mkProperty<IMenuButtonProp> "appearance" "primary"
        /// 'transparent': Removes background and border styling.
        static member inline transparent = Interop.mkProperty<IMenuButtonProp> "appearance" "transparent"

    /// A button can be rounded, circular, or square.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IMenuButtonProp> "shape" "circular"
        static member inline square = Interop.mkProperty<IMenuButtonProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<IMenuButtonProp> "shape" "rounded"

    /// A button supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IButtonProp> "size" "large"

// -------------------------------------------------------------------------- Menu --------------------------------------------------------------------------------------

type [<Erase>] menu =
    inherit FelizProps.prop<IMenuProp>
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IMenuProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IMenuProp> "mountNode" value
    /// Record of all checked values
    ///
    /// <para>Usage: You must use an anonymous record, or create your own record type, for this property.</para>
    ///
    /// <code>let checkedItems, setCheckedItems = React.useState({| edit = [| "cut" |]; apply = [| |] |})
    /// menu.checkedValues checkedItems
    /// menu.onCheckedValueChange (fun (d:MenuCheckedValueChangeData) -> setCheckedItems({| edit = d.checkedItems; apply = d.checkedItems |}))</code>
    ///
    /// ("edit" and "apply" and the names of the different MenuItemCheckboxes. "cut" is the value of one of them.)
    static member inline checkedValues (value: 'T) = Interop.mkProperty<IMenuProp> "checkedValues" value
    /// Default values to be checked on mount
    ///
    /// <para>Usage: You must use an anonymous record, or create your own record type, for this property.</para>
    ///
    /// <code>menu.defaultCheckedValues ({| edit = [| "cut"; "paste" |]; apply = [| |] |})</code>
    ///
    /// ("edit" and "apply" and the names of the different MenuItemCheckboxes. "cut" and "paste" are the values of the ones to be checked on mount.)
    static member inline defaultCheckedValues (value: 'T) = Interop.mkProperty<IMenuProp> "defaultCheckedValues" value
    /// States that menu items can contain selectable items and reserve slots for item alignment
    static member inline hasCheckmarks (value: bool) = Interop.mkProperty<IMenuProp> "hasCheckmarks" value
    /// States that menu items can contain icons and reserve slots for item alignment
    static member inline hasIcons (value: bool) = Interop.mkProperty<IMenuProp> "hasIcons" value
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (handler: (MenuCheckedValueChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onCheckedValueChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (value: (MouseEvent -> MenuCheckedValueChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onCheckedValueChange" (System.Func<_,_,_> value)
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (value: (KeyboardEvent -> MenuCheckedValueChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onCheckedValueChange" (System.Func<_,_,_> value)
    /// Can contain two children including MenuTrigger and MenuPopover. Alternatively can only contain MenuPopove if using a custom target.
    static member inline children (value: ReactElement) = Interop.mkProperty<IMenuProp> "children" value
    /// WARNING: Menu can contain no more than two children including MenuTrigger and MenuPopover.
    /// If you try to use more than two children, only the first two you pass to this function will be used
    /// Alternatively can only contain MenuPopover if using a custom target.
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l <= 2 -> elems
            | _ -> elems |> Seq.take 2
        Interop.mkProperty<IMenuProp> "children" (Interop.reactApi.Children.toArray elemsToUse)
    /// Sets the delay for mouse open/close for the popover one mouse enter/leave
    static member inline hoverDelay (value: int) = Interop.mkProperty<IMenuProp> "hoverDelay" value
    /// Root menus are rendered out of DOM order on document.body, use this to render the menu in DOM order This option is disregarded for submenus
    static member inline inline' (value: bool) = Interop.mkProperty<IMenuProp> "inline" value
    /// Callback when checked items change for value with a name
    static member inline onOpenChange (handler: (MenuOpenChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when checked items change for value with a name
    static member inline onOpenChange (value: (MouseEvent -> MenuOpenChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when checked items change for value with a name
    static member inline onOpenChange (value: (KeyboardEvent -> MenuOpenChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when checked items change for value with a name
    static member inline onOpenChange (value: (TouchEvent -> MenuOpenChangeData -> unit)) = Interop.mkProperty<IMenuProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Whether the popup is open
    static member inline open' (value: bool) = Interop.mkProperty<IMenuProp> "open" value
    /// Whether the popup is open by default
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IMenuProp> "defaultOpen" value
    /// Opens the menu on right click (context menu), removes all other menu open interactions
    static member inline openOnContext (value: bool) = Interop.mkProperty<IMenuProp> "openOnContext" value
    /// Opens the menu on hover
    static member inline openOnHover (value: bool) = Interop.mkProperty<IMenuProp> "openOnHover" value
    /// Do not dismiss the menu when a menu item is clicked
    static member inline persistOnItemClick (value: bool) = Interop.mkProperty<IMenuProp> "persistOnItemClick" value
    /// Close when scroll outside of it
    static member inline closeOnScroll (value: bool) = Interop.mkProperty<IMenuProp> "closeOnScroll" value
    /// Configures the positioned menu
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<IMenuProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)

module menu =
    /// Configures the positioned menu
    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<IMenuProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<IMenuProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<IMenuProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<IMenuProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<IMenuProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<IMenuProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<IMenuProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<IMenuProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<IMenuProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<IMenuProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<IMenuProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<IMenuProp> "positioning" "after-bottom"



// -------------------------------------------------------------------------- MenuList --------------------------------------------------------------------------------------

type [<Erase>] menuList =
    inherit FelizProps.prop<IMenuListProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuListProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Record of all checked values.
    ///
    /// <para>Usage: You must use an anonymous record, or create your own record type, for this property.</para>
    ///
    /// <code>let checkedItems, setCheckedItems = React.useState({| edit = [| "cut" |]; apply = [| |] |})
    /// menu.checkedValues checkedItems
    /// menu.onCheckedValueChange (fun (d:MenuCheckedValueChangeData) -> setCheckedItems({| edit = d.checkedItems; apply = d.checkedItems |}))</code>
    ///
    /// ("edit" and "apply" and the names of the different MenuItemCheckboxes. "cut" is the value of one of them.)
    static member inline checkedValues (value: 'T) = Interop.mkProperty<IMenuListProp> "checkedValues" value
    /// Default values to be checked on mount.
    ///
    /// <para>Usage: You must use an anonymous record, or create your own record type, for this property.</para>
    ///
    /// <code>menu.defaultCheckedValues ({| edit = [| "cut"; "paste" |]; apply = [| |] |})</code>
    ///
    /// ("edit" and "apply" and the names of the different MenuItemCheckboxes. "cut" and "paste" are the values of the ones to be checked on mount.)
    static member inline defaultCheckedValues (value: 'T) = Interop.mkProperty<IMenuListProp> "defaultCheckedValues" value
    /// States that menu items can contain selectable items and reserve slots for item alignment
    static member inline hasCheckmarks (value: bool) = Interop.mkProperty<IMenuListProp> "hasCheckmarks" value
    /// States that menu items can contain icons and reserve slots for item alignment
    static member inline hasIcons (value: bool) = Interop.mkProperty<IMenuListProp> "hasIcons" value
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (handler: (MenuCheckedValueChangeData -> unit)) = Interop.mkProperty<IMenuListProp> "onCheckedValueChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (value: (MouseEvent -> MenuCheckedValueChangeData -> unit)) = Interop.mkProperty<IMenuListProp> "onCheckedValueChange" (System.Func<_,_,_> value)
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (value: (KeyboardEvent -> MenuCheckedValueChangeData -> unit)) = Interop.mkProperty<IMenuListProp> "onCheckedValueChange" (System.Func<_,_,_> value)

module menuList =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IMenuListProp> "as" "div"
// -------------------------------------------------------------------------- MenuItem --------------------------------------------------------------------------------------
type [<Erase>] menuItem =
    inherit FelizProps.prop<IMenuItemProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline icon (value: ReactElement) = Interop.mkProperty<IMenuItemProp> "icon" value
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<IMenuItemProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline checkmark (value: ReactElement) = Interop.mkProperty<IMenuItemProp> "checkmark" value
    static member inline checkmark (value: IReactProperty list) = Interop.mkProperty<IMenuItemProp> "checkmark" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline submenuIndicator (value: ReactElement) = Interop.mkProperty<IMenuItemProp> "submenuIndicator" value
    static member inline submenuIndicator (value: IReactProperty list) = Interop.mkProperty<IMenuItemProp> "submenuIndicator" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline content (value: ReactElement) = Interop.mkProperty<IMenuItemProp> "content" value
    static member inline content (value: IReactProperty list) = Interop.mkProperty<IMenuItemProp> "content" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline secondaryContent (value: ReactElement) = Interop.mkProperty<IMenuItemProp> "secondaryContent" value
    static member inline secondaryContent (value: IReactProperty list) = Interop.mkProperty<IMenuItemProp> "secondaryContent" (!!value |> createObj |> unbox<IReactProperty>)
    /// If the menu item is a trigger for a submenu
    static member inline hasSubmenu (value: bool) = Interop.mkProperty<IMenuItemProp> "hasSubmenu" value
    /// Clicking on the menu item will not dismiss an open menu
    static member inline persistOnClick (value: bool) = Interop.mkProperty<IMenuItemProp> "persistOnClick" value
    static member inline disabled (value: bool) = Interop.mkProperty<IMenuItemProp> "disabled" value
    /// @deprecated this property does nothing.
    /// disabled focusable is by default by simply using `disabled` property
    [<Obsolete>] static member inline disabledFocusable (value: bool) = Interop.mkProperty<IMenuItemProp> "disabledFocusable" value

// -------------------------------------------------------------------------- MenuItemLink --------------------------------------------------------------------------------------
type [<Erase>] menuItemLink =
    inherit FelizProps.prop<IMenuItemLinkProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuItemLinkProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline icon (value: ReactElement) = Interop.mkProperty<IMenuItemLinkProp> "icon" value
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<IMenuItemLinkProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline checkmark (value: ReactElement) = Interop.mkProperty<IMenuItemLinkProp> "checkmark" value
    static member inline checkmark (value: IReactProperty list) = Interop.mkProperty<IMenuItemLinkProp> "checkmark" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline content (value: ReactElement) = Interop.mkProperty<IMenuItemLinkProp> "content" value
    static member inline content (value: IReactProperty list) = Interop.mkProperty<IMenuItemLinkProp> "content" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline secondaryContent (value: ReactElement) = Interop.mkProperty<IMenuItemLinkProp> "secondaryContent" value
    static member inline secondaryContent (value: IReactProperty list) = Interop.mkProperty<IMenuItemLinkProp> "secondaryContent" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- MenuItemCheckbox --------------------------------------------------------------------------------------
type [<Erase>] menuItemCheckbox =
    inherit FelizProps.prop<IMenuItemCheckboxProp>
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IMenuItemCheckboxProp> "icon" value
    /// If the menu item is a trigger for a submenu
    static member inline hasSubmenu (value: bool) = Interop.mkProperty<IMenuItemCheckboxProp> "hasSubmenu" value
    /// Clicking on the menu item will not dismiss an open menu
    static member inline persistOnClick (value: bool) = Interop.mkProperty<IMenuItemCheckboxProp> "persistOnClick" value
    static member inline disabled (value: bool) = Interop.mkProperty<IMenuItemCheckboxProp> "disabled" value
    /// @deprecated this property does nothing.
    /// disabled focusable is by default by simply using `disabled` property
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IMenuItemCheckboxProp> "disabledFocusable" value
    /// Follows input convention https://www.w3schools.com/jsref/prop_checkbox_name.asp
    static member inline name (value: string) = Interop.mkProperty<IMenuItemCheckboxProp> "name" value
    /// Follows input convention https://www.w3schools.com/jsref/prop_checkbox_value.asp
    static member inline value (value: string) = Interop.mkProperty<IMenuItemCheckboxProp> "value" value

// -------------------------------------------------------------------------- MenuItemRadio --------------------------------------------------------------------------------------
type [<Erase>] menuItemRadio =
    inherit FelizProps.prop<IMenuItemRadioProp>
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IMenuItemRadioProp> "icon" value
    /// If the menu item is a trigger for a submenu
    static member inline hasSubmenu (value: bool) = Interop.mkProperty<IMenuItemRadioProp> "hasSubmenu" value
    /// Clicking on the menu item will not dismiss an open menu
    static member inline persistOnClick (value: bool) = Interop.mkProperty<IMenuItemRadioProp> "persistOnClick" value
    static member inline disabled (value: bool) = Interop.mkProperty<IMenuItemRadioProp> "disabled" value
    /// @deprecated this property does nothing.
    /// disabled focusable is by default by simply using `disabled` property
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IMenuItemRadioProp> "disabledFocusable" value
    /// Follows input convention https://www.w3schools.com/jsref/prop_checkbox_name.asp
    static member inline name (value: string) = Interop.mkProperty<IMenuItemRadioProp> "name" value
    /// Follows input convention https://www.w3schools.com/jsref/prop_checkbox_value.asp
    static member inline value (value: string) = Interop.mkProperty<IMenuItemRadioProp> "value" value

// -------------------------------------------------------------------------- MenuPopover --------------------------------------------------------------------------------------
type [<Erase>] menuPopover =
    inherit FelizProps.prop<IMenuPopoverProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuItemCheckboxProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- MenuTrigger --------------------------------------------------------------------------------------
type [<Erase>] menuTrigger =
    static member inline children (value: ReactElement) = Interop.mkProperty<IMenuTriggerProp> "children" value
    static member inline children (value: MenuTriggerChildProps -> ReactElement) = Interop.mkProperty<IMenuTriggerProp> "children" (System.Func<_,_> value)
    static member inline disableButtonEnhancement (value: bool) = Interop.mkProperty<IMenuTriggerProp> "disableButtonEnhancement" value

// -------------------------------------------------------------------------- MenuSplitGroup --------------------------------------------------------------------------------------
type [<Erase>] menuSplitGroup =
    inherit FelizProps.prop<IMenuSplitGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuSplitGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- MenuGroup --------------------------------------------------------------------------------------
type [<Erase>] menuGroup =
    inherit FelizProps.prop<IMenuGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- MenuGroupHeader --------------------------------------------------------------------------------------
type [<Erase>] menuGroupHeader =
    inherit FelizProps.prop<IMenuGroupHeaderProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuGroupHeaderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- MenuDivider --------------------------------------------------------------------------------------
type [<Erase>] menuDivider =
    inherit FelizProps.prop<IMenuDividerProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMenuDividerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- Popover --------------------------------------------------------------------------------------
type [<Erase>] popover =
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IPopoverProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IPopoverProp> "mountNode" value
    /// Can contain two children including PopoverTrigger and PopoverSurface. Alternatively can only contain PopoverSurface if using a custom target.
    static member inline children (value: ReactElement) = Interop.mkProperty<IPopoverProp> "children" value
    /// WARNING: Popover can contain no more than two children including PopoverTrigger and PopoverSurface.
    /// If you try to use more than two children, only the first two you pass to this function will be used.
    /// Alternatively can only contain PopoverSurface if using a custom target.
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l <= 2 -> elems
            | _ -> elems |> Seq.take 2
        Interop.mkProperty<IPopoverProp> "children" (Interop.reactApi.Children.toArray elemsToUse)
    /// Close when scroll outside of it
    static member inline closeOnScroll (value: bool) = Interop.mkProperty<IPopoverProp> "closeOnScroll" value
    /// Used to set the initial open state of the Popover in uncontrolled mode
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IPopoverProp> "defaultOpen" value
    /// Popovers are rendered out of DOM order on document.body by default, use this to render the popover in DOM order
    static member inline' (value: bool) = Interop.mkProperty<IPopoverProp> "inline" value
    /// Sets the delay for closing popover on mouse leave
    static member inline mouseLeaveDelay (value: int) = Interop.mkProperty<IPopoverProp> "mouseLeaveDelay" value
    /// Display an arrow pointing to the target.
    static member inline withArrow (value: bool) = Interop.mkProperty<IPopoverProp> "withArrow" value
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (handler: OpenProp -> unit) = Interop.mkProperty<IPopoverProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: MouseEvent -> OpenProp -> unit) = Interop.mkProperty<IPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: TouchEvent -> OpenProp -> unit) = Interop.mkProperty<IPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: FocusEvent -> OpenProp -> unit) = Interop.mkProperty<IPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: KeyboardEvent -> OpenProp -> unit) = Interop.mkProperty<IPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Controls the opening of the Popover
    static member inline open' (value: bool) = Interop.mkProperty<IPopoverProp> "open" value
    /// Flag to open the Popover as a context menu. Disables all other interactions
    static member inline openOnContext (value: bool) = Interop.mkProperty<IPopoverProp> "openOnContext" value
    /// Flag to open the Popover by hovering the trigger
    static member inline openOnHover (value: bool) = Interop.mkProperty<IPopoverProp> "openOnHover" value
    // Should trap focus
    static member inline trapFocus (value: bool) = Interop.mkProperty<IPopoverProp> "trapFocus" value
    /// Must be used with the trapFocus prop Enables older Fluent UI focus trap behavior where the user cannot tab into the window outside of the document.
    /// This is now non-standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline legacyTrapFocus (value: bool) = Interop.mkProperty<IPopoverProp> "legacyTrapFocus" value
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert,
    /// making navigation leak from the trapped area back to the browser toolbar and vice-versa.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<IPopoverProp> "inertTrapFocus" value
    /// By default Popover focuses the first focusable element in PopoverSurface on open. Specify disableAutoFocus to prevent this behavior.
    static member inline unstable_disableAutoFocus (value: bool) = Interop.mkProperty<IPopoverProp> "unstable_disableAutoFocus" value
    /// Configures the positioned popover
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<IPopoverProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)

module popover =
    type [<Erase>] appearance =
        static member inline brand = Interop.mkProperty<IPopoverProp> "appearance" "brand"
        static member inline inverted = Interop.mkProperty<IPopoverProp> "appearance" "inverted"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IPopoverProp> "size" "small"
        static member inline medium = Interop.mkProperty<IPopoverProp> "size" "medium"
        static member inline large = Interop.mkProperty<IPopoverProp> "size" "large"

    /// Configures the positioned popover
    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<IPopoverProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<IPopoverProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<IPopoverProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<IPopoverProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<IPopoverProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<IPopoverProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<IPopoverProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<IPopoverProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<IPopoverProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<IPopoverProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<IPopoverProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<IPopoverProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- PopoverTrigger --------------------------------------------------------------------------------------
type [<Erase>] popoverTrigger =
    static member inline children (value: ReactElement) = Interop.mkProperty<IPopoverTriggerProp> "children" value
    static member inline children (value: PopoverTriggerChildProps -> ReactElement) = Interop.mkProperty<IPopoverTriggerProp> "children" (System.Func<_,_> value)
    /// Disables internal trigger mechanism that ensures a child provided will be a compliant ARIA button.
    static member inline disableButtonEnhancement (value: bool) = Interop.mkProperty<IPopoverTriggerProp> "disableButtonEnhancement" value

// -------------------------------------------------------------------------- PopoverSurface --------------------------------------------------------------------------------------
type [<Erase>] popoverSurface =
    inherit FelizProps.prop<IPopoverSurfaceProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IPopoverSurfaceProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module popoverSurface =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IPopoverSurfaceProp> "as" "div"

// -------------------------------------------------------------------------- Tooltip --------------------------------------------------------------------------------------
type [<Erase>] tooltip =
    /// The text or JSX content of the tooltip.
    static member inline content (value: string) = Interop.mkProperty<ITooltipProp> "content" value
    /// The text or JSX content of the tooltip.
    static member inline content (value: ReactElement) = Interop.mkProperty<ITooltipProp> "content" value
    /// The text or JSX content of the tooltip.
    static member inline content (value: IReactProperty list) = Interop.mkProperty<ITooltipProp> "content" (!!value |> createObj |> unbox<IReactProperty>)
    /// WARNING: Only pass a single React Element as children as opposed to a list of React Elements
    static member inline children (value: ReactElement) = Interop.mkProperty<ITooltipProp> "children" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<ITooltipProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<ITooltipProp> "mountNode" value
    /// Delay before the tooltip is hidden, in milliseconds.
    static member inline hideDelay (value: int) = Interop.mkProperty<ITooltipProp> "hideDelay" value
    static member inline onVisibleChange (handler: OnVisibleChangeData -> unit) = Interop.mkProperty<ITooltipProp> "onVisibleChange" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onVisibleChange (value: PointerEvent -> OnVisibleChangeData -> unit) = Interop.mkProperty<ITooltipProp> "onVisibleChange" (System.Func<_,_,_> value)
    static member inline onVisibleChange (value: FocusEvent -> OnVisibleChangeData -> unit) = Interop.mkProperty<ITooltipProp> "onVisibleChange" (System.Func<_,_,_> value)
    /// Delay before the tooltip is shown, in milliseconds.
    static member inline showDelay (value: int) = Interop.mkProperty<ITooltipProp> "showDelay" value
    /// Control the tooltip's visibility programatically.
    /// This can be used in conjunction with onVisibleChange to modify the tooltip's show and hide behavior.
    /// If not provided, the visibility will be controlled by the tooltip itself, based on hover and focus events on the trigger (child) element.
    static member inline visible (value: bool) = Interop.mkProperty<ITooltipProp> "visible" value
    /// Render an arrow pointing to the target element
    static member inline withArrow (value: bool) = Interop.mkProperty<ITooltipProp> "withArrow" value
    static member inline ref (value: IRefValue<'T> option) = Interop.mkProperty<ITooltipProp> "ref" value
    static member inline key (value: string) = Interop.mkProperty<ITooltipProp> "key" value
    static member inline key (value: int) = Interop.mkProperty<ITooltipProp> "key" value
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<ITooltipProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)


module tooltip =
    /// The tooltip's visual appearance.
    type [<Erase>] appearance =
        /// Higher contrast variant that uses the theme's inverted colors.
        static member inline inverted = Interop.mkProperty<ITooltipProp> "appearance" "inverted"
        /// Uses the theme's background and text colors.
        static member inline normal = Interop.mkProperty<ITooltipProp> "appearance" "normal"

    /// (Required) Specifies whether this tooltip is acting as the description or label of its trigger element.
    type [<Erase>] relationship =
        /// The tooltip sets the trigger's aria-label or aria-labelledby attribute. This is useful for buttons displaying only an icon, for example.
        static member inline label = Interop.mkProperty<ITooltipProp> "relationship" "label"
        /// The tooltip sets the trigger's aria-description or aria-describedby attribute.
        static member inline description = Interop.mkProperty<ITooltipProp> "relationship" "description"
        /// No aria attributes are set on the trigger. This makes the tooltip's content inaccessible to screen readers, and should only be used if the tooltip's text is available by some other means.
        static member inline inaccessible = Interop.mkProperty<ITooltipProp> "relationship" "inaccessible"

    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<ITooltipProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<ITooltipProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<ITooltipProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<ITooltipProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<ITooltipProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<ITooltipProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<ITooltipProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<ITooltipProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<ITooltipProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<ITooltipProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<ITooltipProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<ITooltipProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- Label --------------------------------------------------------------------------------------
type [<Erase>] label =
    inherit FelizProps.prop<ILabelProp>
    /// Renders the label as disabled
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ILabelProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Renders the label as disabled
    static member inline disabled (value: bool) = Interop.mkProperty<ILabelProp> "disabled" value
    /// Displays an indicator that the label is for a required field.
    /// The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: bool) = Interop.mkProperty<ILabelProp> "required" value
    /// Displays an indicator that the label is for a required field.
    /// The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: string) = Interop.mkProperty<ILabelProp> "required" value
    /// Displays an indicator that the label is for a required field.
    /// The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: ReactElement) = Interop.mkProperty<ILabelProp> "required" value
    /// Displays an indicator that the label is for a required field.
    /// The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: IReactProperty list) = Interop.mkProperty<ILabelProp> "required" (!!value |> createObj |> unbox<IReactProperty>)

module label =
    type [<Erase>] as' =
        static member inline label = Interop.mkProperty<ILabelProp> "as" "label"
    /// A label supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ILabelProp> "size" "small"
        static member inline medium = Interop.mkProperty<ILabelProp> "size" "medium"
        static member inline large = Interop.mkProperty<ILabelProp> "size" "large"

    /// A label supports regular and semibold fontweight.
    type [<Erase>] weight =
        static member inline regular = Interop.mkProperty<ILabelProp> "weight" "regular"
        static member inline semibold = Interop.mkProperty<ILabelProp> "weight" "semibold"

// -------------------------------------------------------------------------- Input --------------------------------------------------------------------------------------
type [<Erase>] input =
    inherit FelizProps.prop<IInputProp>
    /// WARNING: Input doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children (value: ReactElement) = Interop.mkProperty<IInputProp> "children" value
    /// WARNING: Input doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: ReactElement seq) = Interop.mkProperty<IInputProp> "children" (Interop.reactApi.Children.toArray elems)
    /// Wrapper element which visually appears to be the input and is used for borders, focus styling, etc.
    /// (A wrapper is needed to properly position contentBefore and contentAfter relative to input.)
    /// The root slot receives the className and style specified directly on the <Input>. All other top-level native props will be applied to the primary slot, input.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IInputProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The actual <input> element. type="text" will be automatically applied unless overridden.
    /// This is the "primary" slot, so native props specified directly on the <Input> will go here (except className and style, which go to the root slot).
    /// The top-level ref will also go here.
    static member inline input (value: ReactElement) = Interop.mkProperty<IInputProp> "input" value
    /// The actual <input> element. type="text" will be automatically applied unless overridden.
    /// This is the "primary" slot, so native props specified directly on the <Input> will go here (except className and style, which go to the root slot).
    /// The top-level ref will also go here.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<IInputProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element before the input text, within the input border
    static member inline contentBefore (value: ReactElement) = Interop.mkProperty<IInputProp> "contentBefore" value
    /// Element before the input text, within the input border
    static member inline contentBefore (value: IReactProperty list) = Interop.mkProperty<IInputProp> "contentBefore" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element after the input text, within the input border
    static member inline contentAfter (value: ReactElement) = Interop.mkProperty<IInputProp> "contentAfter" value
    /// Element after the input text, within the input border
    static member inline contentAfter (value: IReactProperty list) = Interop.mkProperty<IInputProp> "contentAfter" (!!value |> createObj |> unbox<IReactProperty>)
    /// Default value of the input. Provide this if the input should be an uncontrolled component which tracks its current state internally; otherwise, use value.
    static member inline defaultValue (value: string) = Interop.mkProperty<IInputProp> "defaultValue" value
    /// Current value of the input. Provide this if the input is a controlled component where you are maintaining its current state; otherwise, use defaultValue.
    /// (This prop is mutually exclusive with defaultValue.)
    static member inline value (value: string) = Interop.mkProperty<IInputProp> "value" value
    /// Called when the user changes the input's value.
    static member inline onChange (handler: InputOnChangeData -> unit) = Interop.mkProperty<IInputProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Called when the user changes the input's value.
    static member inline onChange (value: MouseEvent -> InputOnChangeData -> unit) = Interop.mkProperty<IInputProp> "onChange" (System.Func<_,_,_> value)
    /// Called when the user changes the input's value.
    static member inline onChange (value: KeyboardEvent -> InputOnChangeData -> unit) = Interop.mkProperty<IInputProp> "onChange" (System.Func<_,_,_> value)
    /// Called when the user changes the input's value.
    static member inline onChange (value: TouchEvent -> InputOnChangeData -> unit) = Interop.mkProperty<IInputProp> "onChange" (System.Func<_,_,_> value)
    /// Placeholder text for the input. If using this instead of a label (which is not recommended), be sure to provide an aria-label for screen reader users.
    static member inline placeholder (value: string) = Interop.mkProperty<IInputProp> "placeholder" value
    /// Whether the input is disabled
    static member inline disabled (value: string) = Interop.mkProperty<IInputProp> "disabled" value

module input =
    /// Size of the input (changes the font size and spacing).
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IInputProp> "size" "small"
        static member inline medium = Interop.mkProperty<IInputProp> "size" "medium"
        static member inline large = Interop.mkProperty<IInputProp> "size" "large"

    /// Controls the colors and borders of the input.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<IInputProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<IInputProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<IInputProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<IInputProp> "appearance" "filled-lighter"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledDarkerShadow = Interop.mkProperty<IInputProp> "appearance" "filled-darker-shadow"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledLighterShadow = Interop.mkProperty<IInputProp> "appearance" "filled-lighter-shadow"

    /// An input can have different text-based types based on the type of value the user will enter.
    /// Note that no custom styling is currently applied for alternative types, and some types may activate browser-default styling which does not match the Fluent design language.
    type [<Erase>] type' =
        static member inline number = Interop.mkProperty<IInputProp> "type" "number"
        static member inline time = Interop.mkProperty<IInputProp> "type" "time"
        static member inline text = Interop.mkProperty<IInputProp> "type" "text"
        static member inline search = Interop.mkProperty<IInputProp> "type" "search"
        static member inline tel = Interop.mkProperty<IInputProp> "type" "tel"
        static member inline url = Interop.mkProperty<IInputProp> "type" "url"
        static member inline email = Interop.mkProperty<IInputProp> "type" "email"
        static member inline date = Interop.mkProperty<IInputProp> "type" "date"
        static member inline datetimeLocal = Interop.mkProperty<IInputProp> "type" "datetime-local"
        static member inline month = Interop.mkProperty<IInputProp> "type" "month"
        static member inline password = Interop.mkProperty<IInputProp> "type" "password"
        static member inline week = Interop.mkProperty<IInputProp> "type" "week"

// -------------------------------------------------------------------------- CompoundButton --------------------------------------------------------------------------------------
type [<Erase>] compoundButton =
    inherit FelizProps.prop<ICompoundButtonProp>
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member icon (value: ReactElement) = Interop.mkProperty<ICompoundButtonProp> "icon" value
    /// Second line of text that describes the action this button takes.
    static member inline secondaryContent (value: string) = Interop.mkProperty<ICompoundButtonProp> "secondaryContent" value
    /// Second line of text that describes the action this button takes.
    static member inline secondaryContent (value: ReactElement) = Interop.mkProperty<ICompoundButtonProp> "secondaryContent" value
    /// Second line of text that describes the action this button takes.
    static member inline secondaryContent (value: IReactProperty list) = Interop.mkProperty<ICompoundButtonProp> "secondaryContent" (!!value |> createObj |> unbox<IReactProperty>)
    /// Container that wraps the children and the secondaryContent slot.
    static member inline contentContainer (value: ReactElement) = Interop.mkProperty<ICompoundButtonProp> "contentContainer" value
    /// Container that wraps the children and the secondaryContent slot.
    static member inline contentContainer (value: IReactProperty list) = Interop.mkProperty<ICompoundButtonProp> "contentContainer" (!!value |> createObj |> unbox<IReactProperty>)
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<ICompoundButtonProp> "disabledFocusable" value

module compoundButton =
    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<ICompoundButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<ICompoundButtonProp> "as" "button"

    /// A button can have its content and borders styled for greater emphasis or to be subtle.
    type [<Erase>] appearance =
        /// 'subtle': Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<ICompoundButtonProp> "appearance" "subtle"
        /// 'outline': Removes background styling.
        static member inline outline = Interop.mkProperty<ICompoundButtonProp> "appearance" "outline"
        /// 'secondary' (default): Gives emphasis to the button in such a way that it indicates a secondary action.
        static member inline secondary = Interop.mkProperty<ICompoundButtonProp> "appearance" "secondary"
        /// 'primary': Emphasizes the button as a primary action.
        static member inline primary' = Interop.mkProperty<ICompoundButtonProp> "appearance" "primary"
        /// 'transparent': Removes background and border styling.
        static member inline transparent = Interop.mkProperty<ICompoundButtonProp> "appearance" "transparent"

    /// A button supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ICompoundButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<ICompoundButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<ICompoundButtonProp> "size" "large"

    /// A button can be rounded, circular, or square.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<ICompoundButtonProp> "shape" "circular"
        static member inline square = Interop.mkProperty<ICompoundButtonProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<ICompoundButtonProp> "shape" "rounded"

    /// A button can format its icon to appear before or after its content.
    type [<Erase>] iconPosition =
        static member inline before = Interop.mkProperty<ICompoundButtonProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<ICompoundButtonProp> "iconPosition" "after"

// -------------------------------------------------------------------------- SplitButton --------------------------------------------------------------------------------------
type [<Erase>] splitButton =
    inherit FelizProps.prop<ISplitButtonProp>
    /// Root of the component that wraps the primary action button and menu button.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISplitButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Button that opens menu with secondary actions in SplitButton.
    static member inline menuButton (value: MenuTriggerChildProps) = Interop.mkProperty<ISplitButtonProp> "menuButton" value
    /// Button that opens menu with secondary actions in SplitButton.
    static member inline menuButton (value: ReactElement) = Interop.mkProperty<ISplitButtonProp> "menuButton" value
    /// Button that opens menu with secondary actions in SplitButton.
    static member inline menuButton (value: IMenuButtonProp list) = Interop.mkProperty<ISplitButtonProp> "menuButton" (!!value |> createObj |> unbox<IMenuButtonProp>)
    /// Button to perform primary action in SplitButton.
    static member inline primaryActionButton (value: ReactElement) = Interop.mkProperty<ISplitButtonProp> "primaryActionButton" value
    /// Button to perform primary action in SplitButton.
    static member inline primaryActionButton (value: IButtonProp list) = Interop.mkProperty<ISplitButtonProp> "primaryActionButton" (!!value |> createObj |> unbox<IButtonProp>)
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member icon (value: ReactElement) = Interop.mkProperty<ISplitButtonProp> "icon" value
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<ISplitButtonProp> "disabledFocusable" value
    /// Menu icon that indicates that this button has a menu that can be expanded.
    static member inline menuIcon (value: ReactElement) = Interop.mkProperty<ISplitButtonProp> "menuIcon" value

module splitButton =
    type [<Erase>] as' =
        static member inline undefined = Interop.mkProperty<ISplitButtonProp> "as" "undefined"

    /// A button can have its content and borders styled for greater emphasis or to be subtle.
    type [<Erase>] appearance =
        /// 'subtle': Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<ISplitButtonProp> "appearance" "subtle"
        /// 'outline': Removes background styling.
        static member inline outline = Interop.mkProperty<ISplitButtonProp> "appearance" "outline"
        /// 'secondary' (default): Gives emphasis to the button in such a way that it indicates a secondary action.
        static member inline secondary = Interop.mkProperty<ISplitButtonProp> "appearance" "secondary"
        /// 'primary': Emphasizes the button as a primary action.
        static member inline primary' = Interop.mkProperty<ISplitButtonProp> "appearance" "primary"
        /// 'transparent': Removes background and border styling.
        static member inline transparent = Interop.mkProperty<ISplitButtonProp> "appearance" "transparent"

    /// A button supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ISplitButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<ISplitButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<ISplitButtonProp> "size" "large"

    /// A button can be rounded, circular, or square.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<ISplitButtonProp> "shape" "circular"
        static member inline square = Interop.mkProperty<ISplitButtonProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<ISplitButtonProp> "shape" "rounded"

    /// A button can format its icon to appear before or after its content.
    type [<Erase>] iconPosition =
        static member inline before = Interop.mkProperty<ISplitButtonProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<ISplitButtonProp> "iconPosition" "after"

// -------------------------------------------------------------------------- TextArea --------------------------------------------------------------------------------------
type [<Erase>] textArea =
    inherit FelizProps.prop<ITextAreaProp>
    /// Wrapper element used for displaying the borders for Textarea. This wrapper is needed due to the focus indicator border animation. For more information, see Spec.md
    /// The root only receives className and style. All other props are applied to the textarea slot.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITextAreaProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The <textarea> element. This is the primary slot, all native props and ref are applied to this slot.
    static member inline textArea (value: ReactElement) = Interop.mkProperty<ITextAreaProp> "textarea" value
    /// The <textarea> element. This is the primary slot, all native props and ref are applied to this slot.
    static member inline textArea (value: IReactProperty list) = Interop.mkProperty<ITextAreaProp> "textarea" (!!value |> createObj |> unbox<IReactProperty>)
    /// The default value of the Textarea.
    static member inline defaultValue (value: string) = Interop.mkProperty<ITextAreaProp> "defaultValue" value
    /// The default value of the Textarea.
    static member inline onChange (handler: TextareaOnChangeData -> unit) = Interop.mkProperty<ITextAreaProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// The default value of the Textarea.
    static member inline onChange (value: KeyboardEvent -> TextareaOnChangeData -> unit) = Interop.mkProperty<ITextAreaProp> "onChange" (System.Func<_,_,_> value)
    /// The value of the Textarea.
    static member inline value (value: string) = Interop.mkProperty<ITextAreaProp> "value" value

module textArea =
    type [<Erase>] as' =
        static member inline textarea = Interop.mkProperty<ITextAreaProp> "as" "textarea"
    /// Styling the Textarea should use.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<ITextAreaProp> "appearance" "outline"
        static member inline filledDarker = Interop.mkProperty<ITextAreaProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ITextAreaProp> "appearance" "filled-lighter"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledDarkerShadow = Interop.mkProperty<ITextAreaProp> "appearance" "filled-darker-shadow"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledLighterShadow = Interop.mkProperty<ITextAreaProp> "appearance" "filled-lighter-shadow"

    /// Which direction the Textarea is allowed to be resized.
    type [<Erase>] resize =
        static member inline none = Interop.mkProperty<ITextAreaProp> "resize" "none"
        static member inline both = Interop.mkProperty<ITextAreaProp> "resize" "both"
        static member inline horizontal = Interop.mkProperty<ITextAreaProp> "resize" "horizontal"
        static member inline vertical = Interop.mkProperty<ITextAreaProp> "resize" "vertical"

    /// Size of the Textarea.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITextAreaProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITextAreaProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITextAreaProp> "size" "large"

// -------------------------------------------------------------------------- Slider --------------------------------------------------------------------------------------
type [<Erase>] slider =
    inherit FelizProps.prop<ISliderProp>
    /// The root of the Slider. The root slot receives the className and style specified directly on the <Slider>.
    /// All other native props will be applied to the primary slot, input.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISliderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The hidden input for the Slider. This is the PRIMARY slot: all native properties specified directly on <Slider> will be applied
    /// to this slot, except className and style, which remain on the root slot.
    static member inline input (value: ReactElement) = Interop.mkProperty<ISliderProp> "input" value
    /// The hidden input for the Slider. This is the PRIMARY slot: all native properties specified directly on <Slider> will be applied
    /// to this slot, except className and style, which remain on the root slot.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<ISliderProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Slider's base. It is used to visibly display the min and max selectable values
    static member inline rail (value: ReactElement) = Interop.mkProperty<ISliderProp> "rail" value
    /// The Slider's base. It is used to visibly display the min and max selectable values
    static member inline rail (value: IReactProperty list) = Interop.mkProperty<ISliderProp> "rail" (!!value |> createObj |> unbox<IReactProperty>)
    /// The draggable icon used to select a given value from the Slider. This is the element containing role = 'slider'.
    static member inline thumb (value: ReactElement) = Interop.mkProperty<ISliderProp> "thumb" value
    /// The draggable icon used to select a given value from the Slider. This is the element containing role = 'slider'.
    static member inline thumb (value: IReactProperty list) = Interop.mkProperty<ISliderProp> "thumb" (!!value |> createObj |> unbox<IReactProperty>)
    /// The starting value for an uncontrolled Slider. Mutually exclusive with value prop.
    static member inline defaultValue (value: int) = Interop.mkProperty<ISliderProp> "defaultValue" value
    /// The starting value for an uncontrolled Slider. Mutually exclusive with value prop.
    static member inline defaultValue (value: float) = Interop.mkProperty<ISliderProp> "defaultValue" value
    /// The starting value for an uncontrolled Slider. Mutually exclusive with value prop.
    static member inline defaultValue (value: decimal) = Interop.mkProperty<ISliderProp> "defaultValue" value
    /// The current value of the controlled Slider. Mutually exclusive with defaultValue prop.
    static member inline value (value: int) = Interop.mkProperty<ISliderProp> "value" value
    /// The current value of the controlled Slider. Mutually exclusive with defaultValue prop.
    static member inline value (value: float) = Interop.mkProperty<ISliderProp> "value" value
    /// The current value of the controlled Slider. Mutually exclusive with defaultValue prop.
    static member inline value (value: decimal) = Interop.mkProperty<ISliderProp> "value" value
    /// Render the Slider in a vertical orientation, smallest value on the bottom.
    static member inline vertical (value: bool) = Interop.mkProperty<ISliderProp> "vertical" value
    /// The max value of the Slider.
    static member inline max (value: int) = Interop.mkProperty<ISliderProp> "max" value
    /// The max value of the Slider.
    static member inline max (value: float) = Interop.mkProperty<ISliderProp> "max" value
    /// The max value of the Slider.
    static member inline max (value: decimal) = Interop.mkProperty<ISliderProp> "max" value
    /// The min value of the Slider.
    static member inline min (value: int) = Interop.mkProperty<ISliderProp> "min" value
    /// The min value of the Slider.
    static member inline min (value: float) = Interop.mkProperty<ISliderProp> "min" value
    /// The min value of the Slider.
    static member inline min (value: decimal) = Interop.mkProperty<ISliderProp> "min" value
    /// The number of steps that the Slider's `value` will increment upon change. When provided, the Slider
    /// will snap to the closest available value. This must be a positive value.
    /// @default 1
    static member inline step (value: int) = Interop.mkProperty<ISliderProp> "step" value
    /// The number of steps that the Slider's `value` will increment upon change. When provided, the Slider
    /// will snap to the closest available value. This must be a positive value.
    /// @default 1
    static member inline step (value: float) = Interop.mkProperty<ISliderProp> "step" value
    /// The number of steps that the Slider's `value` will increment upon change. When provided, the Slider
    /// will snap to the closest available value. This must be a positive value.
    /// @default 1
    static member inline step (value: decimal) = Interop.mkProperty<ISliderProp> "step" value
    /// Triggers a callback when the value has been changed. This will be called on every individual step.
    static member inline onChange (handler: SliderOnChangeData -> unit) = Interop.mkProperty<ISliderProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Triggers a callback when the value has been changed. This will be called on every individual step.
    static member inline onChange (value: MouseEvent -> SliderOnChangeData -> unit) = Interop.mkProperty<ISliderProp> "onChange" (System.Func<_,_,_> value)
    /// Triggers a callback when the value has been changed. This will be called on every individual step.
    static member inline onChange (value: TouchEvent -> SliderOnChangeData -> unit) = Interop.mkProperty<ISliderProp> "onChange" (System.Func<_,_,_> value)
    /// Triggers a callback when the value has been changed. This will be called on every individual step.
    static member inline onChange (value: DragEvent -> SliderOnChangeData -> unit) = Interop.mkProperty<ISliderProp> "onChange" (System.Func<_,_,_> value)

module slider =
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ISliderProp> "size" "small"
        static member inline medium = Interop.mkProperty<ISliderProp> "size" "medium"

// -------------------------------------------------------------------------- Switch --------------------------------------------------------------------------------------
type [<Erase>] switch =
    inherit FelizProps.prop<ISwitchProp>
    /// The root element of the Switch.
    /// The root slot receives the className and style specified directly on the <Switch> tag. All other native props will be applied to the primary slot: input.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISwitchProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Hidden input that handles the Switch's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on the <Switch> tag will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: ReactElement) = Interop.mkProperty<ISwitchProp> "input" value
    /// Hidden input that handles the Switch's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on the <Switch> tag will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<ISwitchProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Switch's label.
    static member inline label (value: string) = Interop.mkProperty<ISwitchProp> "label" value
    /// The Switch's label.
    static member inline label (value: ReactElement) = Interop.mkProperty<ISwitchProp> "label" value
    /// The Switch's label.
    static member inline label (value: ILabelProp list) = Interop.mkProperty<ISwitchProp> "label" (!!value |> createObj |> unbox<ILabelProp>)
    /// The track and the thumb sliding over it indicating the on and off status of the Switch.
    static member inline indicator (value: ReactElement) = Interop.mkProperty<ISwitchProp> "indicator" value
    /// The track and the thumb sliding over it indicating the on and off status of the Switch.
    static member inline indicator (value: IReactProperty list) = Interop.mkProperty<ISwitchProp> "indicator" (!!value |> createObj |> unbox<IReactProperty>)
    /// Defines the controlled checked state of the Switch. If passed, Switch ignores the defaultChecked property.
    /// This should only be used if the checked state is to be controlled at a higher level and
    /// there is a plan to pass the correct value based on handling onChange events and re-rendering.
    static member inline checked' (value: bool) = Interop.mkProperty<ISwitchProp> "checked" value
    /// Defines whether the Switch is initially in a checked state or not when rendered.
    static member inline defaultChecked (value: bool) = Interop.mkProperty<ISwitchProp> "defaultChecked" value
    /// Callback to be called when the checked state value changes.
    static member inline onChange (handler: SwitchOnChangeData -> unit) = Interop.mkProperty<ISwitchProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback to be called when the checked state value changes.
    static member inline onChange (value: MouseEvent -> SwitchOnChangeData -> unit) = Interop.mkProperty<ISwitchProp> "onChange" (System.Func<_,_,_> value)
    /// Callback to be called when the checked state value changes.
    static member inline onChange (value: TouchEvent -> SwitchOnChangeData -> unit) = Interop.mkProperty<ISwitchProp> "onChange" (System.Func<_,_,_> value)
    /// Callback to be called when the checked state value changes.
    static member inline onChange (value: KeyboardEvent -> SwitchOnChangeData -> unit) = Interop.mkProperty<ISwitchProp> "onChange" (System.Func<_,_,_> value)

module switch =
    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<ISwitchProp> "as" "input"
    type [<Erase>] labelPosition =
        static member inline before = Interop.mkProperty<ISwitchProp> "labelPosition" "before"
        static member inline after = Interop.mkProperty<ISwitchProp> "labelPosition" "after"
        static member inline above = Interop.mkProperty<ISwitchProp> "labelPosition" "above"

// -------------------------------------------------------------------------- Radio --------------------------------------------------------------------------------------
type [<Erase>] radio =
    inherit FelizProps.prop<IRadioProp>
    /// The root element of the Radio.
    /// The root slot receives the className and style specified directly on the <Radio>. All other native props will be applied to the primary slot: input
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IRadioProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Hidden input that handles the radio's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on <Radio> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: ReactElement) = Interop.mkProperty<IRadioProp> "input" value
    /// Hidden input that handles the radio's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on <Radio> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<IRadioProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Radio's label.
    static member inline label (value: string) = Interop.mkProperty<IRadioProp> "label" value
    /// The Radio's label.
    static member inline label (value: ReactElement) = Interop.mkProperty<IRadioProp> "label" value
    /// The Radio's label.
    static member inline label (value: ILabelProp list) = Interop.mkProperty<IRadioProp> "label" (!!value |> createObj |> unbox<ILabelProp>)
    /// A circle outline, with a filled circle icon inside when the Radio is checked.
    static member inline indicator (value: ReactElement) = Interop.mkProperty<IRadioProp> "indicator" value
    /// A circle outline, with a filled circle icon inside when the Radio is checked.
    static member inline indicator (value: IReactProperty list) = Interop.mkProperty<IRadioProp> "indicator" (!!value |> createObj |> unbox<IReactProperty>)
    /// The value of the RadioGroup when this Radio item is selected.
    static member inline value (value: string) = Interop.mkProperty<IRadioProp> "value" value
    /// Callback when this Radio is selected in its group.
    /// Note: onChange is NOT called when this Radio is deselected. Use RadioGroup's onChange event to determine when the selection in the group changes.
    static member inline onChange (handler: RadioOnChangeData -> unit) = Interop.mkProperty<IRadioProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when this Radio is selected in its group.
    /// Note: onChange is NOT called when this Radio is deselected. Use RadioGroup's onChange event to determine when the selection in the group changes.
    static member inline onChange (value: MouseEvent -> RadioOnChangeData -> unit) = Interop.mkProperty<IRadioProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when this Radio is selected in its group.
    /// Note: onChange is NOT called when this Radio is deselected. Use RadioGroup's onChange event to determine when the selection in the group changes.
    static member inline onChange (value: TouchEvent -> RadioOnChangeData -> unit) = Interop.mkProperty<IRadioProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when this Radio is selected in its group.
    /// Note: onChange is NOT called when this Radio is deselected. Use RadioGroup's onChange event to determine when the selection in the group changes.
    static member inline onChange (value: KeyboardEvent -> RadioOnChangeData -> unit) = Interop.mkProperty<IRadioProp> "onChange" (System.Func<_,_,_> value)

module radio =
    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<IRadioProp> "as" "input"
    /// The position of the label relative to the radio indicator.
    type [<Erase>] labelPosition =
        static member inline after = Interop.mkProperty<IRadioProp> "labelPosition" "after"
        static member inline below = Interop.mkProperty<IRadioProp> "labelPosition" "below"

// -------------------------------------------------------------------------- RadioGroup --------------------------------------------------------------------------------------

type [<Erase>] radioGroup =
    inherit FelizProps.prop<IRadioGroupProp>
    /// The radio group root.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IRadioGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The selected Radio item in this group.
    /// This should be the value prop of one of the Radio items inside this group.
    static member inline value (value: string) = Interop.mkProperty<IRadioGroupProp> "value" value
    /// The default selected Radio item in this group.
    /// This should be the `value` prop of one of the Radio items inside this group.
    static member inline defaultValue (value: string) = Interop.mkProperty<IRadioGroupProp> "defaultValue" value
    /// Callback when the selected Radio item changes.
    static member inline onChange (handler: ValueProp<string> -> unit) = Interop.mkProperty<IRadioGroupProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when the selected Radio item changes.
    static member inline onChange (value: MouseEvent -> ValueProp<string> -> unit) = Interop.mkProperty<IRadioGroupProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when the selected Radio item changes.
    static member inline onChange (value: KeyboardEvent -> ValueProp<string> -> unit) = Interop.mkProperty<IRadioGroupProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when the selected Radio item changes.
    static member inline onChange (value: TouchEvent -> ValueProp<string> -> unit) = Interop.mkProperty<IRadioGroupProp> "onChange" (System.Func<_,_,_> value)
    /// Disable all Radio items in this group.
    static member inline disabled (value: bool) = Interop.mkProperty<IRadioGroupProp> "disabled" value
    /// Require a selection in this group. Adds the required prop to all child Radio items.
    static member inline required (value: bool) = Interop.mkProperty<IRadioGroupProp> "required" value

module radioGroup =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IRadioGroupProp> "as" "div"
    /// How the radio items are laid out in the group.
    type [<Erase>] layout =
        static member inline horizontal = Interop.mkProperty<IRadioGroupProp> "layout" "horizontal"
        static member inline vertical = Interop.mkProperty<IRadioGroupProp> "layout" "vertical"
        static member inline horizontalStacked = Interop.mkProperty<IRadioGroupProp> "layout" "horizontal-stacked"

// -------------------------------------------------------------------------- Portal --------------------------------------------------------------------------------------

type [<Erase>] portal =
    /// React children
    static member inline children (value: ReactElement list) = Interop.mkProperty<IPortalProp> "children" value
    /// Where the portal children are mounted on DOM
    /// Default: a new element on document.body without any styling
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IPortalProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    /// Default: a new element on document.body without any styling
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IPortalProp> "mountNode" value

// -------------------------------------------------------------------------- TabList --------------------------------------------------------------------------------------

type [<Erase>] tabList =
    inherit FelizProps.prop<ITabListProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITabListProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Tab size may change between unselected and selected states. The default scenario is a selected tab has bold text.
    /// When true, this property requests tabs be the same size whether unselected or selected.
    static member inline reserveSelectedTabSpace (value: bool) = Interop.mkProperty<ITabListProp> "reserveSelectedTabSpace" value
    /// The value of the tab to be selected by default. Typically useful when the selectedValue is uncontrolled.
    static member inline defaultSelectedValue (value: 'T) = Interop.mkProperty<ITabListProp> "defaultSelectedValue" value
    /// A tab list can be set to disable interaction.
    static member inline disabled (value: bool) = Interop.mkProperty<ITabListProp> "disabled" value
    /// Raised when a tab is selected.
    static member inline onTabSelect (handler: ValueProp<'T> -> unit) = Interop.mkProperty<ITabListProp> "onTabSelect" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Raised when a tab is selected.
    static member inline onTabSelect (value: MouseEvent -> ValueProp<'T> -> unit) = Interop.mkProperty<ITabListProp> "onTabSelect" (System.Func<_,_,_> value)
    /// Raised when a tab is selected.
    static member inline onTabSelect (value: KeyboardEvent -> ValueProp<'T> -> unit) = Interop.mkProperty<ITabListProp> "onTabSelect" (System.Func<_,_,_> value)
    /// The value of the currently selected tab.
    static member inline selectedValue (value: 'T) = Interop.mkProperty<ITabListProp> "selectedValue" value
    /// A tab list can arrange its tabs vertically.
    static member inline vertical (value: bool) = Interop.mkProperty<ITabListProp> "vertical" value

module tabList =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITabListProp> "as" "div"
    /// A tab list can supports 'transparent' and 'subtle' appearance.
    type [<Erase>] appearance =
        /// Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<ITabListProp> "appearance" "subtle"
        /// No background and border styling The appearance affects each of the contained tabs
        static member inline transparent = Interop.mkProperty<ITabListProp> "appearance" "transparent"

    /// A tab list can be either 'small', 'medium', or 'large' size. The size affects each of the contained tabs.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITabListProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITabListProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITabListProp> "size" "large"

// -------------------------------------------------------------------------- Tab --------------------------------------------------------------------------------------

type [<Erase>] tab =
    inherit FelizProps.prop<ITabProp>
    /// Root of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITabProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon that renders before the content.
    static member inline icon (value: ReactElement) = Interop.mkProperty<ITabProp> "icon" value
    /// Icon that renders before the content.
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<ITabProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Component children are placed in this slot
    /// Avoid using the `children` property in this slot in favour of Component children whenever possible.
    static member inline content (value: ReactElement) = Interop.mkProperty<ITabProp> "content" value
    /// Component children are placed in this slot
    /// Avoid using the `children` property in this slot in favour of Component children whenever possible.
    static member inline content (value: IReactProperty list) = Interop.mkProperty<ITabProp> "content" (!!value |> createObj |> unbox<IReactProperty>)
    /// A tab can be set to disable interaction.
    /// @default false
    static member inline disabled (value: bool) = Interop.mkProperty<ITabProp> "disabled" value
    /// The value that identifies this tab when selected.
    static member inline value (value: 'T) = Interop.mkProperty<ITabProp> "value" value

// -------------------------------------------------------------------------- Spinner --------------------------------------------------------------------------------------

type [<Erase>] spinner =
    inherit FelizProps.prop<ISpinnerProp>
    /// The root of the Spinner. The root slot receives the `className` and `style` specified directly on the `<Spinner>`.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISpinnerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The label of the Slider. The label slot receives the styling related to the text associated with the Spinner.
    static member inline label (value: string) = Interop.mkProperty<ISpinnerProp> "label" value
    /// The label of the Slider. The label slot receives the styling related to the text associated with the Spinner.
    static member inline label (value: ReactElement) = Interop.mkProperty<ISpinnerProp> "label" value
    /// The label of the Slider. The label slot receives the styling related to the text associated with the Spinner.
    static member inline label (value: ILabelProp list) = Interop.mkProperty<ISpinnerProp> "label" (!!value |> createObj |> unbox<ILabelProp>)
    /// The slot for the animated svg. The spinner slot receives the className and style that handles the spinning animation.
    /// An svg is also rendered as a child of this slot
    static member inline spinner (value: ReactElement) = Interop.mkProperty<ISpinnerProp> "spinner" value
    /// The slot for the animated svg. The spinner slot receives the className and style that handles the spinning animation.
    /// An svg is also rendered as a child of this slot
    static member inline spinner (value: IReactProperty list) = Interop.mkProperty<ISpinnerProp> "spinner" (!!value |> createObj |> unbox<IReactProperty>)
    /// Time in milliseconds after component mount before spinner is visible.
    static member inline delay (value: int) = Interop.mkProperty<ISpinnerProp> "delay" value

module spinner =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ISpinnerProp> "as" "div"
    /// The appearance of the Spinner.
    type [<Erase>] appearance =
        static member inline primary = Interop.mkProperty<ISpinnerProp> "appearance" "primary"
        static member inline inverted = Interop.mkProperty<ISpinnerProp> "appearance" "inverted"

    /// Where the label is positioned relative to the Spinner
    type [<Erase>] labelPosition =
        static member inline before = Interop.mkProperty<ISpinnerProp> "labelPosition" "before"
        static member inline after = Interop.mkProperty<ISpinnerProp> "labelPosition" "after"
        static member inline above = Interop.mkProperty<ISpinnerProp> "labelPosition" "above"
        static member inline below = Interop.mkProperty<ISpinnerProp> "labelPosition" "below"

    /// The size of the spinner.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ISpinnerProp> "size" "small"
        static member inline tiny = Interop.mkProperty<ISpinnerProp> "size" "tiny"
        static member inline extraSmall = Interop.mkProperty<ISpinnerProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<ISpinnerProp> "size" "medium"
        static member inline large = Interop.mkProperty<ISpinnerProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<ISpinnerProp> "size" "extra-large"
        static member inline huge = Interop.mkProperty<ISpinnerProp> "size" "huge"
        static member inline extraTiny = Interop.mkProperty<ISpinnerProp> "size" "extra-tiny"

// -------------------------------------------------------------------------- SpinButton --------------------------------------------------------------------------------------

type [<Erase>] spinButton =
    inherit FelizProps.prop<ISpinButtonProp>
    /// The root element of SpinButton is a container <div>. The root slot receives the className and style specified on the <SpinButton>.
    /// All other native props are applied to the primary slot: input.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISpinButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Input that displays the current value and accepts direct input from the user. Displayed value is formatted.
    /// This is the primary slot.
    static member inline input (value: ReactElement) = Interop.mkProperty<ISpinButtonProp> "input" value
    /// Input that displays the current value and accepts direct input from the user. Displayed value is formatted.
    /// This is the primary slot.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<ISpinButtonProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// Renders the increment control.
    static member inline incrementButton (value: ReactElement) = Interop.mkProperty<ISpinButtonProp> "incrementButton" value
    /// Renders the increment control.
    static member inline incrementButton (value: IButtonProp list) = Interop.mkProperty<ISpinButtonProp> "incrementButton" (!!value |> createObj |> unbox<IButtonProp>)
    /// Renders the decrement control.
    static member inline decrementButton (value: ReactElement) = Interop.mkProperty<ISpinButtonProp> "decrementButton" value
    /// Renders the decrement control.
    static member inline decrementButton (value: IButtonProp list) = Interop.mkProperty<ISpinButtonProp> "decrementButton" (!!value |> createObj |> unbox<IButtonProp>)
    /// Initial value of the control (assumed to be valid). Updates to this prop will not be respected.
    /// Use this if you intend for the SpinButton to be an uncontrolled component which maintains its own value. For a controlled component, use value instead. (Mutually exclusive with value.)
    /// Use None to indicate the control has no value.
    static member inline defaultValue (value: int option) = Interop.mkProperty<ISpinButtonProp> "defaultValue" value
    /// Initial value of the control (assumed to be valid). Updates to this prop will not be respected.
    /// Use this if you intend for the SpinButton to be an uncontrolled component which maintains its own value. For a controlled component, use value instead. (Mutually exclusive with value.)
    /// Use None to indicate the control has no value.
    static member inline defaultValue (value: float option) = Interop.mkProperty<ISpinButtonProp> "defaultValue" value
    /// Initial value of the control (assumed to be valid). Updates to this prop will not be respected.
    /// Use this if you intend for the SpinButton to be an uncontrolled component which maintains its own value. For a controlled component, use value instead. (Mutually exclusive with value.)
    /// Use None to indicate the control has no value.
    static member inline defaultValue (value: decimal option) = Interop.mkProperty<ISpinButtonProp> "defaultValue" value
    /// String representation of value.
    /// Use this when displaying the value to users as something other than a plain number. For example, when displaying currency values this might be "$1.00" when value is 1.
    /// Only provide this if the SpinButton is a controlled component where you are maintaining its current state and passing updates based on change events.
    /// When SpinButton is used as an uncontrolled component this prop is ignored.
    static member inline displayValue (value: string) = Interop.mkProperty<ISpinButtonProp> "displayValue" value
    /// Callback for when the committed value changes.
    /// User presses the up/down buttons (on single press or every spin)
    /// User presses the up/down arrow keys (on single press or every spin)
    /// User commits edits to the input text by focusing away (blurring) or pressing enter. Note that this is NOT called for every key press while the user is editing.
    static member inline onChange (handler: SpinButtonOnChangeData -> unit) = Interop.mkProperty<ISpinButtonProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback for when the committed value changes.
    /// User presses the up/down buttons (on single press or every spin)
    /// User presses the up/down arrow keys (on single press or every spin)
    /// User commits edits to the input text by focusing away (blurring) or pressing enter. Note that this is NOT called for every key press while the user is editing.
    static member inline onChange (value: MouseEvent -> SpinButtonOnChangeData -> unit) = Interop.mkProperty<ISpinButtonProp> "onChange" (System.Func<_,_,_> value)
    /// Callback for when the committed value changes.
    /// User presses the up/down buttons (on single press or every spin)
    /// User presses the up/down arrow keys (on single press or every spin)
    /// User commits edits to the input text by focusing away (blurring) or pressing enter. Note that this is NOT called for every key press while the user is editing.
    static member inline onChange (value: KeyboardEvent -> SpinButtonOnChangeData -> unit) = Interop.mkProperty<ISpinButtonProp> "onChange" (System.Func<_,_,_> value)
    /// Callback for when the committed value changes.
    /// User presses the up/down buttons (on single press or every spin)
    /// User presses the up/down arrow keys (on single press or every spin)
    /// User commits edits to the input text by focusing away (blurring) or pressing enter. Note that this is NOT called for every key press while the user is editing.
    static member inline onChange (value: TouchEvent -> SpinButtonOnChangeData -> unit) = Interop.mkProperty<ISpinButtonProp> "onChange" (System.Func<_,_,_> value)
    /// How many decimal places the value should be rounded to.
    /// The default is calculated based on the precision of step: i.e. if step = 1, precision = 0. step = 0.0089, precision = 4. step = 300, precision = 2. step = 23.00, precision = 2.
    static member inline precision (value: int) = Interop.mkProperty<ISpinButtonProp> "precision" value
    /// How many decimal places the value should be rounded to.
    /// The default is calculated based on the precision of step: i.e. if step = 1, precision = 0. step = 0.0089, precision = 4. step = 300, precision = 2. step = 23.00, precision = 2.
    static member inline precision (value: float) = Interop.mkProperty<ISpinButtonProp> "precision" value
    /// How many decimal places the value should be rounded to.
    /// The default is calculated based on the precision of step: i.e. if step = 1, precision = 0. step = 0.0089, precision = 4. step = 300, precision = 2. step = 23.00, precision = 2.
    static member inline precision (value: decimal) = Interop.mkProperty<ISpinButtonProp> "precision" value
    /// Large difference between two values. This should be greater than step and is used when users hit the Page Up or Page Down keys.
    static member inline stepPage (value: int) = Interop.mkProperty<ISpinButtonProp> "stepPage" value
    /// Large difference between two values. This should be greater than step and is used when users hit the Page Up or Page Down keys.
    static member inline stepPage (value: float) = Interop.mkProperty<ISpinButtonProp> "stepPage" value
    /// Large difference between two values. This should be greater than step and is used when users hit the Page Up or Page Down keys.
    static member inline stepPage (value: decimal) = Interop.mkProperty<ISpinButtonProp> "stepPage" value
    /// Current value of the control (assumed to be valid).
    /// Only provide this if the SpinButton is a controlled component where you are maintaining its current state and passing updates based on change events; otherwise, use the defaultValue property.
    /// Use null to indicate the control has no value.
    /// Mutually exclusive with defaultValue.
    static member inline value (value: int option) = Interop.mkProperty<ISpinButtonProp> "value" value
    /// Current value of the control (assumed to be valid).
    /// Only provide this if the SpinButton is a controlled component where you are maintaining its current state and passing updates based on change events; otherwise, use the defaultValue property.
    /// Use null to indicate the control has no value.
    /// Mutually exclusive with defaultValue.
    static member inline value (value: float option) = Interop.mkProperty<ISpinButtonProp> "value" value
    /// Current value of the control (assumed to be valid).
    /// Only provide this if the SpinButton is a controlled component where you are maintaining its current state and passing updates based on change events; otherwise, use the defaultValue property.
    /// Use null to indicate the control has no value.
    /// Mutually exclusive with defaultValue.
    static member inline value (value: decimal option) = Interop.mkProperty<ISpinButtonProp> "value" value
    /// Max value of the control. If not provided, the control has no maximum value.
    static member inline max (value: int) = Interop.mkProperty<ISpinButtonProp> "max" value
    /// Max value of the control. If not provided, the control has no maximum value.
    static member inline max (value: float) = Interop.mkProperty<ISpinButtonProp> "max" value
    /// Max value of the control. If not provided, the control has no maximum value.
    static member inline max (value: decimal) = Interop.mkProperty<ISpinButtonProp> "max" value
    /// Min value of the control. If not provided, the control has no minimum value.
    static member inline min (value: int) = Interop.mkProperty<ISpinButtonProp> "min" value
    /// Min value of the control. If not provided, the control has no minimum value.
    static member inline min (value: float) = Interop.mkProperty<ISpinButtonProp> "min" value
    /// Min value of the control. If not provided, the control has no minimum value.
    static member inline min (value: decimal) = Interop.mkProperty<ISpinButtonProp> "min" value
    /// Difference between two adjacent values of the control.
    /// This value is used to calculate the precision of the input if no `precision` is given.
    /// The precision calculated this way will always be greater than or equal 0.
    /// @default 1
    static member inline step (value: int) = Interop.mkProperty<ISpinButtonProp> "step" value
    /// Difference between two adjacent values of the control.
    /// This value is used to calculate the precision of the input if no `precision` is given.
    /// The precision calculated this way will always be greater than or equal 0.
    /// @default 1
    static member inline step (value: float) = Interop.mkProperty<ISpinButtonProp> "step" value
    /// Difference between two adjacent values of the control.
    /// This value is used to calculate the precision of the input if no `precision` is given.
    /// The precision calculated this way will always be greater than or equal 0.
    /// @default 1
    static member inline step (value: decimal) = Interop.mkProperty<ISpinButtonProp> "step" value


module spinButton =
    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<ISpinButtonProp> "as" "input"
    /// Controls the colors and borders of the input.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<ISpinButtonProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ISpinButtonProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<ISpinButtonProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ISpinButtonProp> "appearance" "filled-lighter"

    /// Size of the input.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ISpinButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<ISpinButtonProp> "size" "medium"

// -------------------------------------------------------------------------- Select --------------------------------------------------------------------------------------

type [<Erase>] select =
    inherit FelizProps.prop<ISelectProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISelectProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Primary slot: the actual <select> element
    static member inline select (value: ReactElement) = Interop.mkProperty<ISelectProp> "select" value
    /// Primary slot: the actual <select> element
    static member inline select (value: IReactProperty list) = Interop.mkProperty<ISelectProp> "select" (!!value |> createObj |> unbox<IReactProperty>)
    /// the icon, typically a down arrow
    static member inline icon (value: ReactElement) = Interop.mkProperty<ISelectProp> "icon" value
    /// the icon, typically a down arrow
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<ISelectProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Called when the user changes the select element's value by selecting an option.
    static member inline onChange (handler: ValueProp<string> -> unit) = Interop.mkProperty<ISelectProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Called when the user changes the select element's value by selecting an option.
    static member inline onChange (value: MouseEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ISelectProp> "onChange" (System.Func<_,_,_> value)
    /// Called when the user changes the select element's value by selecting an option.
    static member inline onChange (value: KeyboardEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ISelectProp> "onChange" (System.Func<_,_,_> value)

module select =
    type [<Erase>] as' =
        static member inline select = Interop.mkProperty<ISelectProp> "as" "select"
    /// Controls the colors and borders of the Select.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<ISelectProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ISelectProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<ISelectProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ISelectProp> "appearance" "filled-lighter"

    /// Matches the Input sizes
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ISelectProp> "size" "small"
        static member inline medium = Interop.mkProperty<ISelectProp> "size" "medium"
        static member inline large = Interop.mkProperty<ISelectProp> "size" "large"

// -------------------------------------------------------------------------- Dropdown --------------------------------------------------------------------------------------

type [<Erase>] dropdown =
    inherit FelizProps.prop<IDropdownProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDropdownProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline button (value: ReactElement) = Interop.mkProperty<IDropdownProp> "button" value
    static member inline button (value: IReactProperty list) = Interop.mkProperty<IDropdownProp> "button" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline listbox (value: ReactElement) = Interop.mkProperty<IDropdownProp> "listbox" value
    static member inline listbox (value: IListboxProp list) = Interop.mkProperty<IDropdownProp> "listbox" (!!value |> createObj |> unbox<IListboxProp>)
    static member inline expandIcon (value: ReactElement) = Interop.mkProperty<IDropdownProp> "expandIcon" value
    static member inline expandIcon (value: IReactProperty list) = Interop.mkProperty<IDropdownProp> "expandIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// For an uncontrolled component, sets the initial selection. If this is set, the defaultValue prop MUST also be set.
    static member inline defaultSelectedOptions (value: array<string>) = Interop.mkProperty<IDropdownProp> "defaultSelectedOptions" value
    /// Sets the selection type to multiselect. Set this to true for multiselect, even if fully controlling selection state. This enables styles and accessibility properties to be set.
    static member inline multiselect (value: bool) = Interop.mkProperty<IDropdownProp> "multiselect" value
    static member inline onOptionSelect (handler: OptionOnSelectData -> unit) = Interop.mkProperty<IDropdownProp> "onOptionSelect" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onOptionSelect (value: MouseEvent -> OptionOnSelectData -> unit) = Interop.mkProperty<IDropdownProp> "onOptionSelect" (System.Func<_,_,_> value)
    static member inline onOptionSelect (value: KeyboardEvent -> OptionOnSelectData -> unit) = Interop.mkProperty<IDropdownProp> "onOptionSelect" (System.Func<_,_,_> value)
    /// An array of selected option keys. Use this with onOptionSelect to directly control the selected option(s) If this is set, the value prop MUST also be controlled.
    static member inline selectedOptions (value: array<string>) = Interop.mkProperty<IDropdownProp> "selectedOptions" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IDropdownProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IDropdownProp> "mountNode" value
    /// The default open state when open is uncontrolled
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDropdownProp> "defaultOpen" value
    /// Render the Dropdown's popup inline in the DOM. This has accessibility benefits, particularly for touch screen readers.
    static member inline inlinePopup (value: bool) = Interop.mkProperty<IDropdownProp> "inlinePopup" value
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (handler: OpenProp -> unit) = Interop.mkProperty<IDropdownProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: MouseEvent -> OpenProp -> unit) = Interop.mkProperty<IDropdownProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: KeyboardEvent -> OpenProp -> unit) = Interop.mkProperty<IDropdownProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: FocusEvent -> OpenProp -> unit) = Interop.mkProperty<IDropdownProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Sets the open/closed state of the dropdown. Use together with onOpenChange to fully control the dropdown's visibility
    static member inline open' (value: bool) = Interop.mkProperty<IDropdownProp> "open" value
    /// The default value displayed in the trigger input or button when the Dropdown's value is uncontrolled
    static member inline defaultValue (value: string) = Interop.mkProperty<IDropdownProp> "defaultValue" value
    /// The value displayed by the Dropdown.
    /// Use this with `onOptionSelect` to directly control the displayed value string
    static member inline value (value: string) = Interop.mkProperty<IDropdownProp> "value" value
    /// Configures the positioned dropdown
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<IDropdownProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)

module dropdown =

    type [<Erase>] as' =
        static member inline button = Interop.mkProperty<IDropdownProp> "as" "button"
    /// Controls the colors and borders of the Dropdown trigger.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<IDropdownProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<IDropdownProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<IDropdownProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<IDropdownProp> "appearance" "filled-lighter"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IDropdownProp> "size" "small"
        static member inline medium = Interop.mkProperty<IDropdownProp> "size" "medium"
        static member inline large = Interop.mkProperty<IDropdownProp> "size" "large"

    /// Configures the positioned dropdown
    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<IDropdownProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<IDropdownProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<IDropdownProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<IDropdownProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<IDropdownProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<IDropdownProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<IDropdownProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<IDropdownProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<IDropdownProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<IDropdownProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<IDropdownProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<IDropdownProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- Option --------------------------------------------------------------------------------------

type [<Erase>] option =
    inherit FelizProps.prop<IOptionProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IOptionProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline checkIcon (value: ReactElement) = Interop.mkProperty<IOptionProp> "checkIcon" value
    static member inline checkIcon (value: IReactProperty list) = Interop.mkProperty<IOptionProp> "checkIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Sets an option to the disabled state. Disabled options cannot be selected, but are still keyboard navigable
    static member inline disabled (value: bool) = Interop.mkProperty<IOptionProp> "disabled" value
    static member inline value (value: string) = Interop.mkProperty<IOptionProp> "value" value
    /// An optional override the string value of the Option's display text, defaulting to the Option's child content.
    /// This is used as the Dropdown button's or Combobox input's value when the option is selected, and as the comparison for type-to-find keyboard functionality.
    /// The string value of the Option's display text when the Option's children are not a string.
    /// This is used as the Dropdown button's or Combobox input's value when the option is selected, and as the comparison for type-to-find keyboard functionality
    static member inline text (value: string) = Interop.mkProperty<IOptionProp> "text" value

module option =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IOptionProp> "as" "div"
// -------------------------------------------------------------------------- Listbox --------------------------------------------------------------------------------------

type [<Erase>] listbox =
    inherit FelizProps.prop<IListboxProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IListboxProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline defaultSelectedOptions (value: array<string>) = Interop.mkProperty<IListboxProp> "defaultSelectedOptions" value
    /// Sets the selection type to multiselect. Set this to true for multiselect, even if fully controlling selection state. This enables styles and accessibility properties to be set.
    static member inline multiselect (value: bool) = Interop.mkProperty<IListboxProp> "multiselect" value
    static member inline onOptionSelect (handler: OptionOnSelectData -> unit) = Interop.mkProperty<IListboxProp> "onOptionSelect" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onOptionSelect (value: MouseEvent -> OptionOnSelectData -> unit) = Interop.mkProperty<IListboxProp> "onOptionSelect" (System.Func<_,_,_> value)
    static member inline onOptionSelect (value: KeyboardEvent -> OptionOnSelectData -> unit) = Interop.mkProperty<IListboxProp> "onOptionSelect" (System.Func<_,_,_> value)
    /// An array of selected option keys. Use this with onOptionSelect to directly control the selected option(s) If this is set, the value prop MUST also be controlled.
    static member inline selectedOptions (value: array<string>) = Interop.mkProperty<IListboxProp> "selectedOptions" value

module listbox =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IListboxProp> "as" "div"
// -------------------------------------------------------------------------- Persona --------------------------------------------------------------------------------------
type [<Erase>] persona =

    inherit FelizProps.prop<IPersonaProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IPersonaProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Avatar to display. If a PresenceBadge and an Avatar are provided, the Avatar will display the PresenceBadge as its presence.
    static member inline avatar (value: ReactElement) = Interop.mkProperty<IPersonaProp> "avatar" value
    /// Avatar to display. If a PresenceBadge and an Avatar are provided, the Avatar will display the PresenceBadge as its presence.
    static member inline avatar (value: IAvatarProp list) = Interop.mkProperty<IPersonaProp> "avatar" (!!value |> createObj |> unbox<IAvatarProp>)
    /// Avatar to display. If a PresenceBadge and an Avatar are provided, the Avatar will display the PresenceBadge as its presence.
    static member inline presence (value: ReactElement) = Interop.mkProperty<IPersonaProp> "presence" value
    /// Avatar to display. If a PresenceBadge and an Avatar are provided, the Avatar will display the PresenceBadge as its presence.
    static member inline presence (value: IPresenceBadgeProp list) = Interop.mkProperty<IPersonaProp> "presence" (!!value |> createObj |> unbox<IPresenceBadgeProp>)
    /// The first line of text in the Persona, larger than the rest of the lines.
    /// primaryText defaults to the name prop. We recomend to only use name, use primaryText when the text is different than the name prop.
    static member inline primaryText (value: string) = Interop.mkProperty<IPersonaProp> "primaryText" value
    /// The first line of text in the Persona, larger than the rest of the lines.
    /// primaryText defaults to the name prop. We recomend to only use name, use primaryText when the text is different than the name prop.
    static member inline primaryText (value: ReactElement) = Interop.mkProperty<IPersonaProp> "primaryText" value
    /// The first line of text in the Persona, larger than the rest of the lines.
    /// primaryText defaults to the name prop. We recomend to only use name, use primaryText when the text is different than the name prop.
    static member inline primaryText (value: IReactProperty list) = Interop.mkProperty<IPersonaProp> "primaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// The second line of text in the Persona.
    static member inline secondaryText (value: string) = Interop.mkProperty<IPersonaProp> "secondaryText" value
    /// The second line of text in the Persona.
    static member inline secondaryText (value: ReactElement) = Interop.mkProperty<IPersonaProp> "secondaryText" value
    /// The second line of text in the Persona.
    static member inline secondaryText (value: IReactProperty list) = Interop.mkProperty<IPersonaProp> "secondaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// The third line of text in the Persona.
    static member inline tertiaryText (value: string) = Interop.mkProperty<IPersonaProp> "tertiaryText" value
    /// The third line of text in the Persona.
    static member inline tertiaryText (value: ReactElement) = Interop.mkProperty<IPersonaProp> "tertiaryText" value
    /// The third line of text in the Persona.
    static member inline tertiaryText (value: IReactProperty list) = Interop.mkProperty<IPersonaProp> "tertiaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// The fourth line of text in the Persona.
    static member inline quaternaryText (value: string) = Interop.mkProperty<IPersonaProp> "quaternaryText" value
    /// The fourth line of text in the Persona.
    static member inline quaternaryText (value: ReactElement) = Interop.mkProperty<IPersonaProp> "quaternaryText" value
    /// The fourth line of text in the Persona.
    static member inline quaternaryText (value: IReactProperty list) = Interop.mkProperty<IPersonaProp> "quaternaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// The name of the person or entity represented by the Persona.
    /// When primaryText is not provided, this will be used as the default value for primaryText.
    static member inline name (value: string) = Interop.mkProperty<IPersonaProp> "name" value
    /// Whether to display only the presence.
    static member inline presenceOnly (value: bool) = Interop.mkProperty<IPersonaProp> "presenceOnly" value

module persona =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IPersonaProp> "as" "div"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IPersonaProp> "size" "small"
        static member inline extraSmall = Interop.mkProperty<IPersonaProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<IPersonaProp> "size" "medium"
        static member inline large = Interop.mkProperty<IPersonaProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<IPersonaProp> "size" "extra-large"
        static member inline huge = Interop.mkProperty<IPersonaProp> "size" "huge"

    type [<Erase>] textPosition =
        static member inline before = Interop.mkProperty<IPersonaProp> "textPosition" "before"
        static member inline after = Interop.mkProperty<IPersonaProp> "textPosition" "after"
        static member inline below = Interop.mkProperty<IPersonaProp> "textPosition" "below"

    type [<Erase>] textAlignment =
        static member inline center = Interop.mkProperty<IPersonaProp> "textAlignment" "center"
        static member inline start = Interop.mkProperty<IPersonaProp> "textAlignment" "start"

// -------------------------------------------------------------------------- Combobox --------------------------------------------------------------------------------------
type [<Erase>] combobox =
    inherit FelizProps.prop<IComboboxProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IComboboxProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline button (value: ReactElement) = Interop.mkProperty<IComboboxProp> "button" value
    static member inline listbox (value: ReactElement) = Interop.mkProperty<IComboboxProp> "listbox" value
    static member inline listbox (value: IListboxProp list) = Interop.mkProperty<IComboboxProp> "listbox" (!!value |> createObj |> unbox<IListboxProp>)
    static member inline input (value: ReactElement) = Interop.mkProperty<IComboboxProp> "input" value
    static member inline input (value: IReactProperty list) = Interop.mkProperty<IComboboxProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline expandIcon (value: ReactElement) = Interop.mkProperty<IComboboxProp> "expandIcon" value
    static member inline expandIcon (value: IReactProperty list) = Interop.mkProperty<IComboboxProp> "expandIcon" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline defaultSelectedOptions (value: array<string>) = Interop.mkProperty<IComboboxProp> "defaultSelectedOptions" value
    static member inline multiselect (value: bool) = Interop.mkProperty<IComboboxProp> "multiselect" value
    static member inline onOptionSelect (handler: OptionOnSelectData -> unit) = Interop.mkProperty<IComboboxProp> "onOptionSelect" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onOptionSelect (value: MouseEvent -> OptionOnSelectData -> unit) = Interop.mkProperty<IComboboxProp> "onOptionSelect" (System.Func<_,_,_> value)
    static member inline onOptionSelect (value: KeyboardEvent -> OptionOnSelectData -> unit) = Interop.mkProperty<IComboboxProp> "onOptionSelect" (System.Func<_,_,_> value)
    /// An array of selected option keys. Use this with onOptionSelect to directly control the selected option(s) If this is set, the value prop MUST also be controlled.
    static member inline selectedOptions (value: array<string>) = Interop.mkProperty<IComboboxProp> "selectedOptions" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IComboboxProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IComboboxProp> "mountNode" value
    /// The default open state when open is uncontrolled
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IComboboxProp> "defaultOpen" value
    /// Render the combobox's popup inline in the DOM. This has accessibility benefits, particularly for touch screen readers.
    static member inline inlinePopup (value: bool) = Interop.mkProperty<IComboboxProp> "inlinePopup" value
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (handler: (OpenProp -> unit)) = Interop.mkProperty<IComboboxProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: (MouseEvent -> OpenProp -> unit)) = Interop.mkProperty<IComboboxProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: (KeyboardEvent -> OpenProp -> unit)) = Interop.mkProperty<IComboboxProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: (TouchEvent -> OpenProp -> unit)) = Interop.mkProperty<IComboboxProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Sets the open/closed state of the dropdown. Use together with onOpenChange to fully control the dropdown's visibility
    static member inline open' (value: bool) = Interop.mkProperty<IComboboxProp> "open" value
    static member inline freeform (value: bool) = Interop.mkProperty<IComboboxProp> "freeform" value
    /// The default value displayed in the trigger input or button when the combobox's value is uncontrolled
    static member inline defaultValue (value: string) = Interop.mkProperty<IComboboxProp> "defaultValue" value
    /// The value displayed by the Combobox.
    /// Use this with `onOptionSelect` to directly control the displayed value string
    static member inline value (value: string) = Interop.mkProperty<IComboboxProp> "value" value
    /// Configure the positioning of the combobox dropdown
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<IComboboxProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)

module combobox =
    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<IComboboxProp> "as" "input"

    /// Controls the colors and borders of the combobox trigger.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<IComboboxProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<IComboboxProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<IComboboxProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<IComboboxProp> "appearance" "filled-lighter"

    /// Controls the size of the combobox faceplate
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IComboboxProp> "size" "small"
        static member inline medium = Interop.mkProperty<IComboboxProp> "size" "medium"
        static member inline large = Interop.mkProperty<IComboboxProp> "size" "large"

    /// Configure the positioning of the combobox dropdown
    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<IComboboxProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<IComboboxProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<IComboboxProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<IComboboxProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<IComboboxProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<IComboboxProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<IComboboxProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<IComboboxProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<IComboboxProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<IComboboxProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<IComboboxProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<IComboboxProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- Toolbar --------------------------------------------------------------------------------------
type [<Erase>] toolbar =
    inherit FelizProps.prop<IToolbarProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToolbarProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Toolbar can be vertical styled
    static member inline vertical (value: bool) = Interop.mkProperty<IToolbarProp> "vertical" value
    /// Record of all checked values.
    ///
    /// <para>Usage: You must use an anonymous record, or create your own record type, for this property.</para>
    ///
    /// <code>let checkedItems, setCheckedItems = React.useState({| edit = [| "cut" |]; apply = [| |] |})
    /// toolbar.checkedValues checkedItems
    /// toolbar.onCheckedValueChange (fun (d:MenuCheckedValueChangeData) -> setCheckedItems({| edit = d.checkedItems; apply = d.checkedItems |}))</code>
    ///
    /// ("edit" and "apply" and the names of the different MenuItemCheckboxes. "cut" is the value of one of them.)
    static member inline checkedValues (value: 'T) = Interop.mkProperty<IToolbarProp> "checkedValues" value
    /// Default values to be checked on mount.
    ///
    /// <para>Usage: You must use an anonymous record, or create your own record type, for this property.</para>
    ///
    /// <code>toolbar.defaultCheckedValues ({| edit = [| "cut"; "paste" |]; apply = [| |] |})</code>
    ///
    /// ("edit" and "apply" and the names of the different MenuItemCheckboxes. "cut" and "paste" are the values of the ones to be checked on mount.)
    static member inline defaultCheckedValues (value: 'T) = Interop.mkProperty<IToolbarProp> "defaultCheckedValues" value
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (handler: (ToolbarCheckedValueChangeData -> unit)) = Interop.mkProperty<IToolbarProp> "onCheckedValueChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (value: (MouseEvent -> ToolbarCheckedValueChangeData -> unit)) = Interop.mkProperty<IToolbarProp> "onCheckedValueChange" (System.Func<_,_,_> value)
    /// Callback when checked items change for value with a name
    static member inline onCheckedValueChange (value: (KeyboardEvent -> ToolbarCheckedValueChangeData -> unit)) = Interop.mkProperty<IToolbarProp> "onCheckedValueChange" (System.Func<_,_,_> value)

module toolbar =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToolbarProp> "as" "div"
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IToolbarProp> "size" "small"
        static member inline medium = Interop.mkProperty<IToolbarProp> "size" "medium"
        static member inline large = Interop.mkProperty<IToolbarProp> "size" "large"

// -------------------------------------------------------------------------- ToolbarButton --------------------------------------------------------------------------------------
type [<Erase>] toolbarButton =
    inherit FelizProps.prop<IToolbarButtonProp>
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value: ReactElement) = Interop.mkProperty<IToolbarButtonProp> "icon" value
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IToolbarButtonProp> "disabledFocusable" value
    static member inline vertical (value: bool) = Interop.mkProperty<IToolbarButtonProp> "vertical" value

module toolbarButton =
    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<IToolbarButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<IToolbarButtonProp> "as" "button"
    type [<Erase>] appearance =
        static member inline subtle = Interop.mkProperty<IToolbarButtonProp> "appearance" "subtle"
        static member inline primary = Interop.mkProperty<IToolbarButtonProp> "appearance" "primary"

// -------------------------------------------------------------------------- ToolbarDivider --------------------------------------------------------------------------------------
type [<Erase>] toolbarDivider =
    inherit FelizProps.prop<IToolbarDividerProp>
    /// Accessibility wrapper for content when presented.
    static member inline wrapper (value: ReactElement) = Interop.mkProperty<IToolbarDividerProp> "wrapper" value
    /// A divider can be horizontal or vertical (default).
    static member inline vertical (value: bool) = Interop.mkProperty<IToolbarDividerProp> "vertical" value

module toolbarDivider =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToolbarDividerProp> "as" "div"
// -------------------------------------------------------------------------- ToolbarGroup --------------------------------------------------------------------------------------
type [<Erase>] toolbarGroup =
    inherit FelizProps.prop<IToolbarGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToolbarGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module toolbarGroup =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToolbarGroupProp> "as" "div"

// -------------------------------------------------------------------------- ToolbarRadioButton --------------------------------------------------------------------------------------
type [<Erase>] toolbarRadioButton =
    inherit FelizProps.prop<IToolbarRadioButtonProp>
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value: ReactElement) = Interop.mkProperty<IToolbarRadioButtonProp> "icon" value
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IToolbarRadioButtonProp> "disabledFocusable" value

module toolbarRadioButton =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToolbarRadioButtonProp> "as" "div"
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IToolbarRadioButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IToolbarRadioButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IToolbarRadioButtonProp> "size" "large"

    type [<Erase>] appearance =
        static member inline subtle = Interop.mkProperty<IToolbarRadioButtonProp> "appearance" "subtle"
        static member inline primary = Interop.mkProperty<IToolbarRadioButtonProp> "appearance" "primary"

// -------------------------------------------------------------------------- ToolbarRadioGroup --------------------------------------------------------------------------------------
type [<Erase>] toolbarRadioGroup =
    inherit FelizProps.prop<IToolbarRadioGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToolbarRadioGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
module toolbarRadioGroup =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToolbarRadioGroupProp> "as" "div"

// -------------------------------------------------------------------------- ToolbarToggleButton --------------------------------------------------------------------------------------
type [<Erase>] toolbarToggleButton =
    inherit FelizProps.prop<IToolbarToggleButtonProp>
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value: ReactElement) = Interop.mkProperty<IToolbarToggleButtonProp> "icon" value
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IToolbarToggleButtonProp> "disabledFocusable" value

module toolbarToggleButton =
    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<IToolbarToggleButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<IToolbarToggleButtonProp> "as" "button"
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IToolbarToggleButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IToolbarToggleButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IToolbarToggleButtonProp> "size" "large"

    type [<Erase>] appearance =
        static member inline subtle = Interop.mkProperty<IToolbarToggleButtonProp> "appearance" "subtle"
        static member inline primary = Interop.mkProperty<IToolbarToggleButtonProp> "appearance" "primary"

// -------------------------------------------------------------------------- AvatarGroup --------------------------------------------------------------------------------------
type [<Erase>] avatarGroup =
    inherit FelizProps.prop<IAvatarGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAvatarGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module avatarGroup =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IAvatarGroupProp> "as" "div"
    /// Layout the AvatarGroupItems should be displayed as.
    type [<Erase>] layout =
        static member inline spread = Interop.mkProperty<IAvatarGroupProp> "layout" "spread"
        static member inline stack = Interop.mkProperty<IAvatarGroupProp> "layout" "stack"
        static member inline pie = Interop.mkProperty<IAvatarGroupProp> "layout" "pie"
    /// Size of the AvatarGroupItems.
    type [<Erase>] size =
        static member inline ``16`` = Interop.mkProperty<IAvatarGroupProp> "size" 16
        static member inline ``20`` = Interop.mkProperty<IAvatarGroupProp> "size" 20
        static member inline ``24`` = Interop.mkProperty<IAvatarGroupProp> "size" 24
        static member inline ``28`` = Interop.mkProperty<IAvatarGroupProp> "size" 28
        static member inline ``32`` = Interop.mkProperty<IAvatarGroupProp> "size" 32
        static member inline ``36`` = Interop.mkProperty<IAvatarGroupProp> "size" 36
        static member inline ``40`` = Interop.mkProperty<IAvatarGroupProp> "size" 40
        static member inline ``48`` = Interop.mkProperty<IAvatarGroupProp> "size" 48
        static member inline ``56`` = Interop.mkProperty<IAvatarGroupProp> "size" 56
        static member inline ``64`` = Interop.mkProperty<IAvatarGroupProp> "size" 64
        static member inline ``72`` = Interop.mkProperty<IAvatarGroupProp> "size" 72
        static member inline ``96`` = Interop.mkProperty<IAvatarGroupProp> "size" 96
        static member inline ``120`` = Interop.mkProperty<IAvatarGroupProp> "size" 120
        static member inline ``128`` = Interop.mkProperty<IAvatarGroupProp> "size" 128

// -------------------------------------------------------------------------- AvatarGroupItem --------------------------------------------------------------------------------------
type [<Erase>] avatarGroupItem =
    inherit FelizProps.prop<IAvatarGroupItemProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAvatarGroupItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Avatar that represents a person or entity.
    static member inline avatar (value: ReactElement) = Interop.mkProperty<IAvatarGroupItemProp> "avatar" value
    /// Avatar that represents a person or entity.
    static member inline avatar (value: IAvatarProp list) = Interop.mkProperty<IAvatarGroupItemProp> "avatar" (!!value |> createObj |> unbox<IAvatarProp>)
    /// Label used for the name of the AvatarGroupItem when rendered as an overflow item.
    /// The content of the label, by default, is the `name` prop from the `avatar` slot.
    static member inline overflowLabel (value: ReactElement) = Interop.mkProperty<IAvatarGroupItemProp> "overflowLabel" value
    /// The content of the label, by default, is the `name` prop from the `avatar` slot.
    static member inline overflowLabel (value: IReactProperty list) = Interop.mkProperty<IAvatarGroupItemProp> "overflowLabel" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- AvatarGroupPopover --------------------------------------------------------------------------------------
type [<Erase>] avatarGroupPopover =
    inherit FelizProps.prop<IAvatarGroupPopoverProp>
    /// Number of AvatarGroupItems that will be rendered.
    /// Note: AvatarGroupPopover handles counting the number of children, but when using a react fragment to wrap the
    /// children, this is not possible and therefore it has do be added manually.
    static member inline count (value: int) = Interop.mkProperty<IAvatarGroupPopoverProp> "count" value
    /// Number of AvatarGroupItems that will be rendered.
    /// Note: AvatarGroupPopover handles counting the number of children, but when using a react fragment to wrap the
    /// children, this is not possible and therefore it has do be added manually.
    static member inline count (value: float) = Interop.mkProperty<IAvatarGroupPopoverProp> "count" value
    /// Number of AvatarGroupItems that will be rendered.
    /// Note: AvatarGroupPopover handles counting the number of children, but when using a react fragment to wrap the
    /// children, this is not possible and therefore it has do be added manually.
    static member inline count (value: decimal) = Interop.mkProperty<IAvatarGroupPopoverProp> "count" value
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAvatarGroupPopoverProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Button that triggers the Popover.
    static member inline triggerButton (value: ReactElement) = Interop.mkProperty<IAvatarGroupPopoverProp> "triggerButton" value
    /// Button that triggers the Popover.
    static member inline triggerButton (value: IReactProperty list) = Interop.mkProperty<IAvatarGroupPopoverProp> "triggerButton" (!!value |> createObj |> unbox<IReactProperty>)
    /// List that contains the overflowed AvatarGroupItems.
    static member inline content (value: ReactElement) = Interop.mkProperty<IAvatarGroupPopoverProp> "content" value
    /// List that contains the overflowed AvatarGroupItems.
    static member inline content (value: IReactProperty list) = Interop.mkProperty<IAvatarGroupPopoverProp> "content" (!!value |> createObj |> unbox<IReactProperty>)
    /// PopoverSurface that contains the content.
    static member inline popoverSurface (value: ReactElement) = Interop.mkProperty<IAvatarGroupPopoverProp> "popoverSurface" value
    /// PopoverSurface that contains the content.
    static member inline popoverSurface (value: IPopoverSurfaceProp list) = Interop.mkProperty<IAvatarGroupPopoverProp> "popoverSurface" (!!value |> createObj |> unbox<IPopoverSurfaceProp>)
    /// Tooltip shown when triggerButton is hovered.
    static member inline tooltip (value: ReactElement) = Interop.mkProperty<IAvatarGroupPopoverProp> "tooltip" value
    /// Tooltip shown when triggerButton is hovered.
    static member inline tooltip (value: ITooltipProp list) = Interop.mkProperty<IAvatarGroupPopoverProp> "tooltip" (!!value |> createObj |> unbox<ITooltipProp>)
    /// WARNING: AvatarGroupPopover only allows one child. If you try to use more than one child, only the first ReactElement passed to "children" will be used.
    [<Obsolete>] static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
                    let elemToUse =
                        match elems |> Seq.length with
                        | l when l = 1 -> elems
                        | _ -> elems |> Seq.take 1
                    Interop.mkProperty<IAvatarGroupPopoverProp> "children" (Interop.reactApi.Children.toArray elemToUse)

module avatarGroupPopover =
    /// Whether the triggerButton should render an icon instead of the number of overflowed AvatarGroupItems.
    /// Note: The indicator will default to `icon` when the size is less than 24.
    /// @default count
    ///
    type [<Erase>] indicator =
        static member inline count = Interop.mkProperty<IAvatarGroupPopoverProp> "indicator" "count"
        static member inline icon = Interop.mkProperty<IAvatarGroupPopoverProp> "indicator" "icon"

// -------------------------------------------------------------------------- PartitionAvatarGroupItemsOptions --------------------------------------------------------------------------------------
type [<Erase>] partitionAvatarGroupItemsOptions =
    static member inline items (value: #seq<'T>) = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "items" value
    static member inline maxInlineItems (value: int) = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "maxInlineItems" value
    static member inline maxInlineItems (value: float) = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "maxInlineItems" value
    static member inline maxInlineItems (value: decimal) = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "maxInlineItems" value

module partitionAvatarGroupItemsOptions =
    type [<Erase>] layout =
        static member inline spread = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "layout" "spread"
        static member inline stack = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "layout" "stack"
        static member inline pie = Interop.mkProperty<IPartitionAvatarGroupItemsOptionsProp> "layout" "pie"

// -------------------------------------------------------------------------- ProgressBar --------------------------------------------------------------------------------------
type [<Erase>] progressBar =
    inherit FelizProps.prop<IProgressBarProp>
    /// The track behind the ProgressBar bar
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IProgressBarProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The filled portion of the ProgressBar bar. Animated in the indeterminate state, when no value is provided.
    static member inline bar (value: ReactElement) = Interop.mkProperty<IProgressBarProp> "bar" value
    /// The filled portion of the ProgressBar bar. Animated in the indeterminate state, when no value is provided.
    static member inline bar (value: IReactProperty list) = Interop.mkProperty<IProgressBarProp> "bar" (!!value |> createObj |> unbox<IReactProperty>)
    /// A decimal number between 0 and 1 (or between 0 and max if given), which specifies how much of the task has been completed.
    /// If undefined (default), the ProgressBar will display an indeterminate state.
    static member inline value (value: int) = Interop.mkProperty<IProgressBarProp> "value" value
    /// A decimal number between 0 and 1 (or between 0 and max if given), which specifies how much of the task has been completed.
    /// If undefined (default), the ProgressBar will display an indeterminate state.
    static member inline value (value: float) = Interop.mkProperty<IProgressBarProp> "value" value
    /// A decimal number between 0 and 1 (or between 0 and max if given), which specifies how much of the task has been completed.
    /// If undefined (default), the ProgressBar will display an indeterminate state.
    static member inline value (value: decimal) = Interop.mkProperty<IProgressBarProp> "value" value
    /// The maximum value, which indicates the task is complete. The ProgressBar bar will be full when value equals max.
    static member inline max (value: int) = Interop.mkProperty<IProgressBarProp> "max" value
    /// The maximum value, which indicates the task is complete. The ProgressBar bar will be full when value equals max.
    static member inline max (value: float) = Interop.mkProperty<IProgressBarProp> "max" value
    /// The maximum value, which indicates the task is complete. The ProgressBar bar will be full when value equals max.
    static member inline max (value: decimal) = Interop.mkProperty<IProgressBarProp> "max" value

module progressBar =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IProgressBarProp> "as" "div"
    /// The shape of the bar and track.
    type [<Erase>] shape =
        static member inline square = Interop.mkProperty<IProgressBarProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<IProgressBarProp> "shape" "rounded"

    /// The thickness of the ProgressBar bar
    type [<Erase>] thickness =
        static member inline medium = Interop.mkProperty<IProgressBarProp> "thickness" "medium"
        static member inline large = Interop.mkProperty<IProgressBarProp> "thickness" "large"

    /// The status of the ProgressBar bar. Changes the color of the bar.
    type [<Erase>] color =
        static member inline brand = Interop.mkProperty<IProgressBarProp> "color" "brand"
        static member inline success = Interop.mkProperty<IProgressBarProp> "color" "success"
        static member inline warning = Interop.mkProperty<IProgressBarProp> "color" "warning"
        static member inline error = Interop.mkProperty<IProgressBarProp> "color" "error"

// -------------------------------------------------------------------------- Field --------------------------------------------------------------------------------------
type [<Erase>] field =
    inherit FelizProps.prop<IFieldProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IFieldProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The label associated with the field.
    static member inline label (value: string) = Interop.mkProperty<IFieldProp> "label" value
    /// The label associated with the field.
    static member inline label (value: ReactElement) = Interop.mkProperty<IFieldProp> "label" value
    /// The label associated with the field.
    static member inline label (value: ILabelProp list) = Interop.mkProperty<IFieldProp> "label" (!!value |> createObj |> unbox<ILabelProp>)
    /// A message about the validation state. By default, this is an error message, but it can be a success, warning, or custom message by setting validationState.
    static member inline validationMessage (value: string) = Interop.mkProperty<IFieldProp> "validationMessage" value
    /// A message about the validation state. By default, this is an error message, but it can be a success, warning, or custom message by setting validationState.
    static member inline validationMessage (value: ReactElement) = Interop.mkProperty<IFieldProp> "validationMessage" value
    /// A message about the validation state. By default, this is an error message, but it can be a success, warning, or custom message by setting validationState.
    static member inline validationMessage (value: IReactProperty list) = Interop.mkProperty<IFieldProp> "validationMessage" (!!value |> createObj |> unbox<IReactProperty>)
    /// The icon associated with the validationMessage. This will only be displayed if validationMessage is set.
    /// The default depends on validationState:
    /// error: <ErrorCircle12Filled />
    /// warning: <Warning12Filled />
    /// success: <CheckmarkCircle12Filled />
    /// none: null
    static member inline validationMessageIcon (value: ReactElement) = Interop.mkProperty<IFieldProp> "validationMessageIcon" value
    /// The icon associated with the validationMessage. This will only be displayed if validationMessage is set.
    /// The default depends on validationState:
    /// error: <ErrorCircle12Filled />
    /// warning: <Warning12Filled />
    /// success: <CheckmarkCircle12Filled />
    /// none: null
    static member inline validationMessageIcon (value: IReactProperty list) = Interop.mkProperty<IFieldProp> "validationMessageIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Additional hint text below the field.
    static member inline hint (value: string) = Interop.mkProperty<IFieldProp> "hint" value
    /// Additional hint text below the field.
    static member inline hint (value: ReactElement) = Interop.mkProperty<IFieldProp> "hint" value
    /// Additional hint text below the field.
    static member inline hint (value: IReactProperty list) = Interop.mkProperty<IFieldProp> "hint" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Field's child can be a single form control, or a render function that takes the props that should be spread on a form control.
    /// All form controls in this library can be used directly as children (such as <Input> or <RadioGroup>).
    static member inline children (value: ReactElement) = Interop.mkProperty<IFieldProp> "children" value
    /// The Field's child can be a single form control, or a render function that takes the props that should be spread on a form control.
    /// All form controls in this library can be used directly as children (such as <Input> or <RadioGroup>).
    static member inline children (value: IReactProperty list -> ReactElement) = Interop.mkProperty<IFieldProp> "children" (System.Func<_,_> value)
    /// Marks the Field as required. If true, an asterisk will be appended to the label, and aria-required will be set on the Field's child.
    static member inline required (value: bool) = Interop.mkProperty<IFieldProp> "required" value

module field =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IFieldProp> "as" "div"

    /// The orientation of the label relative to the field component. This only affects the label, and not the validationMessage or hint (which always appear below the field component).
    type [<Erase>] orientation =
        static member inline horizontal = Interop.mkProperty<IFieldProp> "orientation" "horizontal"
        static member inline vertical = Interop.mkProperty<IFieldProp> "orientation" "vertical"

    /// The size of the Field's label
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IFieldProp> "size" "small"
        static member inline medium = Interop.mkProperty<IFieldProp> "size" "medium"
        static member inline large = Interop.mkProperty<IFieldProp> "size" "large"

    /// The `validationState` affects the display of the `validationMessage` and `validationMessageIcon`.
    /// * error: (default) The validation message has a red error icon and red text, with `role="alert"` so it is
    ///     announced by screen readers. Additionally, the control inside the field has `aria-invalid` set, which adds a
    ///     red border to some field components (such as `Input`).
    /// * success: The validation message has a green checkmark icon and gray text.
    /// * warning: The validation message has a yellow exclamation icon and gray text.
    /// * none: The validation message has no icon and gray text.
    /// @default error when validationMessage is set; none otherwise.
    type [<Erase>] validationState =
        static member inline error = Interop.mkProperty<IFieldProp> "validationState" "error"
        static member inline warning = Interop.mkProperty<IFieldProp> "validationState" "warning"
        static member inline success = Interop.mkProperty<IFieldProp> "validationState" "success"
        static member inline none = Interop.mkProperty<IFieldProp> "validationState" "none"

// -------------------------------------------------------------------------- OptionGroup --------------------------------------------------------------------------------------
type [<Erase>] optionGroup =
    inherit FelizProps.prop<IOptionGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IOptionGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline label (value: string) = Interop.mkProperty<IOptionGroupProp> "label" value
    static member inline label (value: ReactElement) = Interop.mkProperty<IOptionGroupProp> "label" value
    static member inline label (value: IReactProperty list) = Interop.mkProperty<IOptionGroupProp> "label" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- Dialog --------------------------------------------------------------------------------------
type [<Erase>] dialog =
    inherit FelizProps.prop<IDialogProp>
    /// Controls the open state of the dialog
    static member inline open' (value: bool) = Interop.mkProperty<IDialogProp> "open" value
    /// Default value for the uncontrolled open state of the dialog.
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDialogProp> "defaultOpen" value
    /// Can contain two children including DialogTrigger and DialogSurface.
    /// Alternatively can only contain DialogSurface if using trigger outside dialog, or controlling state.
    static member inline children (value: ReactElement) = Interop.mkProperty<IDialogProp> "children" value
    /// WARNING: Dialog can contain no more than two children including DialogTrigger and DialogSurface.
    /// If you try to use more than two children, only the first two you pass to this function will be used
    /// Alternatively can only contain DialogSurface if using trigger outside dialog, or controlling state.
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l <= 2 -> elems
            | _ -> elems |> Seq.take 2
        Interop.mkProperty<IDialogProp> "children" (Interop.reactApi.Children.toArray elemsToUse)
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IDialogProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IDialogProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: MouseEvent -> DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IDialogProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: KeyboardEvent -> DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IDialogProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<IDialogProp> "inertTrapFocus" value

module dialog =
    /// Dialog variations.
    type [<Erase>] modalType =
        /// A special type of modal dialogs that interrupts the user's workflow to communicate an important message or ask for a decision.
        /// Unlike a typical modal dialog, the user must take an action through the options given to dismiss the dialog, and it cannot be dismissed through the dimmed background or escape key.
        static member inline alert = Interop.mkProperty<IDialogProp> "modalType" "alert"
        /// When this type of dialog is open, the rest of the page is dimmed out and cannot be interacted with.
        /// The tab sequence is kept within the dialog and moving the focus outside the dialog will imply closing it. This is the default type of the component.
        static member inline modal = Interop.mkProperty<IDialogProp> "modalType" "modal"
        /// When a non-modal dialog is open, the rest of the page is not dimmed out and users can interact with the rest of the page.
        /// This also implies that the tab focus can move outside the dialog when it reaches the last focusable element.
        static member inline nonModal = Interop.mkProperty<IDialogProp> "modalType" "non-modal"

// -------------------------------------------------------------------------- DialogTrigger --------------------------------------------------------------------------------------
type [<Erase>] dialogTrigger =
    /// Explicitly declare if the trigger is responsible for opening or closing a Dialog visibility state.
    /// If DialogTrigger is outside DialogSurface then it'll be open by default
    /// If DialogTrigger is inside DialogSurface then it'll be close by default
    static member inline action (value: DialogTriggerAction) = Interop.mkProperty<IDialogTriggerProp> "action" value
    /// Disables internal trigger mechanism that ensures a child provided will be a compliant ARIA button.
    static member inline disableButtonEnhancement (value: bool) = Interop.mkProperty<IDialogTriggerProp> "disableButtonEnhancement" value
    static member inline children (value: ReactElement) = Interop.mkProperty<IDialogTriggerProp> "children" value

// -------------------------------------------------------------------------- DialogSurface --------------------------------------------------------------------------------------
type [<Erase>] dialogSurface =
    inherit FelizProps.prop<IDialogSurfaceProp>
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling.
    /// This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: ReactElement) = Interop.mkProperty<IDialogSurfaceProp> "backdrop" value
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling.
    /// This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: IReactProperty list) = Interop.mkProperty<IDialogSurfaceProp> "backdrop" (!!value |> createObj |> unbox<IReactProperty>)
    /// This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDialogSurfaceProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module dialogSurface =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDialogSurfaceProp> "as" "div"
// -------------------------------------------------------------------------- DialogTitle --------------------------------------------------------------------------------------
type [<Erase>] dialogTitle =
    inherit FelizProps.prop<IDialogTitleProp>
    /// By default this is a h2, but can be any heading or div,
    /// if `div` is provided do not forget to also provide proper `role="heading"` and `aria-level` attributes
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDialogTitleProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// By default a Dialog with modalType='non-modal' will have a close button action
    static member inline action (value: ReactElement) = Interop.mkProperty<IDialogTitleProp> "action" value
    /// By default a Dialog with modalType='non-modal' will have a close button action
    static member inline action (value: IReactProperty list) = Interop.mkProperty<IDialogTitleProp> "action" (!!value |> createObj |> unbox<IReactProperty>)

module dialogTitle =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDialogTitleProp> "as" "div"
        static member inline h1 = Interop.mkProperty<IDialogTitleProp> "as" "h1"
        static member inline h2 = Interop.mkProperty<IDialogTitleProp> "as" "h2"
        static member inline h3 = Interop.mkProperty<IDialogTitleProp> "as" "h3"
        static member inline h4 = Interop.mkProperty<IDialogTitleProp> "as" "h4"
        static member inline h5 = Interop.mkProperty<IDialogTitleProp> "as" "h5"
        static member inline h6 = Interop.mkProperty<IDialogTitleProp> "as" "h6"

// -------------------------------------------------------------------------- DialogActions --------------------------------------------------------------------------------------
type [<Erase>] dialogActions =
    inherit FelizProps.prop<IDialogActionsProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDialogActionsProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Makes the actions expand the entire width of the DialogBody
    static member inline fluid (value: bool) = Interop.mkProperty<IDialogActionsProp> "fluid" value

module dialogActions =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDialogActionsProp> "as" "div"
    /// Defines the position on the dialog grid of the actions
    type [<Erase>] position =
        static member inline start = Interop.mkProperty<IDialogActionsProp> "position" "start"
        static member inline end' = Interop.mkProperty<IDialogActionsProp> "position" "end"

// -------------------------------------------------------------------------- DialogBody --------------------------------------------------------------------------------------
type [<Erase>] dialogBody =
    inherit FelizProps.prop<IDialogBodyProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDialogBodyProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- DialogContent --------------------------------------------------------------------------------------
type [<Erase>] dialogContent =
    inherit FelizProps.prop<IDialogContentProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDialogContentProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- Toast --------------------------------------------------------------------------------------
type [<Erase>] toast =
    inherit FelizProps.prop<IToastProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToastProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module toast =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToastProp> "as" "div"
    type [<Erase>] appearance =
        static member inline inverted = Interop.mkProperty<IToastProp> "appearance" "inverted"

// -------------------------------------------------------------------------- ToastTitle --------------------------------------------------------------------------------------
type [<Erase>] toastTitle =
    inherit FelizProps.prop<IToastTitleProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToastTitleProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline action (value: ReactElement) = Interop.mkProperty<IToastTitleProp> "action" value
    static member inline action (value: IReactProperty list) = Interop.mkProperty<IToastTitleProp> "action" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline media (value: ReactElement) = Interop.mkProperty<IToastTitleProp> "media" value
    static member inline media (value: IReactProperty list) = Interop.mkProperty<IToastTitleProp> "media" (!!value |> createObj |> unbox<IReactProperty>)

module toastTitle =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToastTitleProp> "as" "div"

// -------------------------------------------------------------------------- ToastBody --------------------------------------------------------------------------------------
type [<Erase>] toastBody =
    inherit FelizProps.prop<IToastBodyProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToastBodyProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline subtitle (value: string) = Interop.mkProperty<IToastBodyProp> "subtitle" value
    static member inline subtitle (value: ReactElement) = Interop.mkProperty<IToastBodyProp> "subtitle" value
    static member inline subtitle (value: IReactProperty list) = Interop.mkProperty<IToastBodyProp> "subtitle" (!!value |> createObj |> unbox<IReactProperty>)

module toastBody =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToastBodyProp> "as" "div"

// -------------------------------------------------------------------------- ToastFooter --------------------------------------------------------------------------------------
type [<Erase>] toastFooter =
    inherit FelizProps.prop<IToastFooterProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IToastFooterProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module toastFooter =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToastFooterProp> "as" "div"

// -------------------------------------------------------------------------- Toaster --------------------------------------------------------------------------------------
type [<Erase>] toaster =
    inherit FelizProps.prop<IToasterProp>

    static member inline root (value: IReactProperty list) = Interop.mkProperty<IToasterProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline offset (value: ToastOffset) = Interop.mkProperty<IToasterProp> "offset" value
    static member inline toastId (value: 'TId) = Interop.mkProperty<IToasterProp> "toastId" value
    static member inline toasterId (value: string) = Interop.mkProperty<IToasterProp> "toasterId" value
    static member inline toasterId (value: string option) = Interop.mkProperty<IToasterProp> "toasterId" value
    static member inline limit (value: int) = Interop.mkProperty<IToasterProp> "limit" value
    static member inline limit (value: float) = Interop.mkProperty<IToasterProp> "limit" value
    static member inline limit (value: decimal) = Interop.mkProperty<IToasterProp> "limit" value
    static member inline shortcuts (value: ToasterShortcuts) = Interop.mkProperty<IToasterProp> "shortcuts" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: int) = Interop.mkProperty<IToasterProp> "priority" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: float) = Interop.mkProperty<IToasterProp> "priority" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: decimal) = Interop.mkProperty<IToasterProp> "priority" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: int) = Interop.mkProperty<IToasterProp> "timeout" value
    /// Toast timeout pauses while focus is on another window
    static member inline pauseOnWindowBlur (value: bool) = Interop.mkProperty<IToasterProp> "pauseOnWindowBlur" value
    /// Toast timeout pauses while user cursor is on the toast
    static member inline pauseOnHover (value: bool) = Interop.mkProperty<IToasterProp> "pauseOnHover" value
    /// User override API for aria-live narration for toasts
    static member inline announce (value: string -> AnnounceOptions -> unit) = Interop.mkProperty<IToasterProp> "announce" (System.Func<_,_,_> value)
    /// Toast content
    static member inline content (value: ReactElement) = Interop.mkProperty<IToasterProp> "content" value
    /// Additional data that needs to be passed to the toast
    static member inline data (value: 'T) = Interop.mkProperty<IToasterProp> "data" value //TODO
    /// Reports changes to the Toast lifecycle
    static member inline onStatusChange (handler: (ToastChangeData -> unit) option) =
        match handler with
        | Some handler -> Interop.mkProperty<IToasterProp> "onStatusChange" (System.Func<_,_,_> (fun _ value -> handler value))
        | None -> Interop.mkProperty<IToasterProp> "onStatusChange" ()
    /// Reports changes to the Toast lifecycle
    static member inline onStatusChange (value: (MouseEvent -> ToastChangeData -> unit) option) =
        match value with
        | Some value -> Interop.mkProperty<IToasterProp> "onStatusChange" (System.Func<_,_,_> value)
        | None -> Interop.mkProperty<IToasterProp> "onStatusChange" ()
    /// Reports changes to the Toast lifecycle
    static member inline onStatusChange (value: (KeyboardEvent -> ToastChangeData -> unit) option) =
        match value with
        | Some value -> Interop.mkProperty<IToasterProp> "onStatusChange" (System.Func<_,_,_> value)
        | None -> Interop.mkProperty<IToasterProp> "onStatusChange" ()

module toaster =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IToasterProp> "as" "div"

    type [<Erase>] intent =
        static member inline success = Interop.mkProperty<IToasterProp> "intent" "success"
        static member inline warning = Interop.mkProperty<IToasterProp> "intent" "warning"
        static member inline error = Interop.mkProperty<IToasterProp> "intent" "error"
        static member inline info = Interop.mkProperty<IToasterProp> "intent" "info"

    type [<Erase>] position =
        static member inline topEnd = Interop.mkProperty<IToasterProp> "position" "top-end"
        static member inline topStart = Interop.mkProperty<IToasterProp> "position" "top-start"
        static member inline bottomEnd = Interop.mkProperty<IToasterProp> "position" "bottom-end"
        static member inline bottomStart = Interop.mkProperty<IToasterProp> "position" "bottom-start"

    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    type [<Erase>] politeness =
        static member inline assertive = Interop.mkProperty<IToasterProp> "politeness" "assertive"
        static member inline polite = Interop.mkProperty<IToasterProp> "politeness" "polite"

// -------------------------------------------------------------------------- Card --------------------------------------------------------------------------------------
type [<Erase>] card =
    inherit FelizProps.prop<ICardProp>
    /// The internal checkbox element that renders when the card is selectable.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ICardProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The internal checkbox element that renders when the card is selectable.
    static member inline checkbox (value: ReactElement) = Interop.mkProperty<ICardProp> "checkbox" value
    /// The internal checkbox element that renders when the card is selectable.
    static member inline checkbox (value: IReactProperty list) = Interop.mkProperty<ICardProp> "checkbox" (!!value |> createObj |> unbox<IReactProperty>)
    /// Floating action that can be rendered on the top-right of a card. Often used together with selected, defaultSelected, and onSelectionChange props
    static member inline floatingAction (value: ReactElement) = Interop.mkProperty<ICardProp> "floatingAction" value
    /// Floating action that can be rendered on the top-right of a card. Often used together with selected, defaultSelected, and onSelectionChange props
    static member inline floatingAction (value: IReactProperty list) = Interop.mkProperty<ICardProp> "floatingAction" (!!value |> createObj |> unbox<IReactProperty>)
    /// Defines the controlled selected state of the card.
    static member inline selected (value: bool) = Interop.mkProperty<ICardProp> "selected" value
    /// Defines whether the card is initially in a selected state when rendered.
    static member inline defaultSelected (value: bool) = Interop.mkProperty<ICardProp> "defaultSelected" value
    /// Callback to be called when the selected state value changes.
    static member inline onSelectionChange (handler: SelectedProp -> unit) = Interop.mkProperty<ICardProp> "onSelectionChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback to be called when the selected state value changes.
    static member inline onSelectionChange (value: MouseEvent -> SelectedProp -> unit) = Interop.mkProperty<ICardProp> "onSelectionChange" (System.Func<_,_,_> value)
    /// Callback to be called when the selected state value changes.
    static member inline onSelectionChange (value: KeyboardEvent -> SelectedProp -> unit) = Interop.mkProperty<ICardProp> "onSelectionChange" (System.Func<_,_,_> value)

module card =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ICardProp> "as" "div"

    /// Sets the appearance of the card.
    type [<Erase>] appearance =
        /// The card will have a shadow, border and background color.
        static member inline filled = Interop.mkProperty<ICardProp> "appearance" "filled"
        /// This appearance is similar to filled, but the background color will be a little darker.
        static member inline filledAlternative = Interop.mkProperty<ICardProp> "appearance" "filled-alternative"
        /// This appearance is similar to filled, but the background color will be transparent and no shadow applied.
        static member inline outline = Interop.mkProperty<ICardProp> "appearance" "outline"
        /// This appearance is similar to filled-alternative, but no border is applied.
        static member inline subtle = Interop.mkProperty<ICardProp> "appearance" "subtle"

    /// Sets the focus behavior for the card.
    type [<Erase>] focusMode =
        /// The card will not focusable.
        static member inline off = Interop.mkProperty<ICardProp> "focusMode" "off"
        /// This behaviour traps the focus inside of the Card when pressing the Enter key and will only release focus when pressing the Escape key.
        static member inline noTab = Interop.mkProperty<ICardProp> "focusMode" "no-tab"
        /// This behaviour traps the focus inside of the Card when pressing the Enter key but will release focus when pressing the Tab key on the last inner element.
        static member inline tabExit = Interop.mkProperty<ICardProp> "focusMode" "tab-exit"
        /// This behaviour will cycle through all elements inside of the Card when pressing the Tab key and then release focus after the last inner element.
        static member inline tabOnly = Interop.mkProperty<ICardProp> "focusMode" "tab-only"

    /// Defines the orientation of the card.
    type [<Erase>] orientation =
        static member inline horizontal = Interop.mkProperty<ICardProp> "orientation" "horizontal"
        static member inline vertical = Interop.mkProperty<ICardProp> "orientation" "vertical"

    /// Controls the card's border radius and padding between inner elements.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ICardProp> "size" "small"
        static member inline medium = Interop.mkProperty<ICardProp> "size" "medium"
        static member inline large = Interop.mkProperty<ICardProp> "size" "large"

// -------------------------------------------------------------------------- CardFooter --------------------------------------------------------------------------------------
type [<Erase>] cardFooter =
    inherit FelizProps.prop<ICardFooterProp>
    /// Root element of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ICardFooterProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Container that renders on the far end of the footer, used for action buttons.
    static member inline action (value: ReactElement) = Interop.mkProperty<ICardFooterProp> "action" value
    /// Container that renders on the far end of the footer, used for action buttons.
    static member inline action (value: IReactProperty list) = Interop.mkProperty<ICardFooterProp> "action" (!!value |> createObj |> unbox<IReactProperty>)

module cardFooter =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ICardFooterProp> "as" "div"

// -------------------------------------------------------------------------- CardHeader --------------------------------------------------------------------------------------
type [<Erase>] cardHeader =
    inherit FelizProps.prop<ICardHeaderProp>
    /// Root element of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ICardHeaderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element used to render the main header title.
    static member inline header (value: string) = Interop.mkProperty<ICardHeaderProp> "header" value
    /// Element used to render the main header title.
    static member inline header (value: ReactElement) = Interop.mkProperty<ICardHeaderProp> "header" value
    /// Element used to render the main header title.
    static member inline header (value: IReactProperty list) = Interop.mkProperty<ICardHeaderProp> "header" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element used to render an image or avatar related to the card.
    static member inline image (value: IReactProperty list) = Interop.mkProperty<ICardHeaderProp> "image" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element used to render an image or avatar related to the card.
    static member inline image (value: ReactElement) = Interop.mkProperty<ICardHeaderProp> "image" value
    /// Container that renders on the far end of the footer, used for action buttons.
    static member inline action (value: ReactElement) = Interop.mkProperty<ICardHeaderProp> "action" value
    /// Container that renders on the far end of the footer, used for action buttons.
    static member inline action (value: IReactProperty list) = Interop.mkProperty<ICardHeaderProp> "action" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element used to render short descriptions related to the title..
    static member inline description (value: string) = Interop.mkProperty<ICardHeaderProp> "description" value
    /// Element used to render short descriptions related to the title..
    static member inline description (value: ReactElement) = Interop.mkProperty<ICardHeaderProp> "description" value
    /// Element used to render short descriptions related to the title..
    static member inline description (value: IReactProperty list) = Interop.mkProperty<ICardHeaderProp> "description" (!!value |> createObj |> unbox<IReactProperty>)

module cardHeader =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ICardHeaderProp> "as" "div"

// -------------------------------------------------------------------------- CardPreview --------------------------------------------------------------------------------------
type [<Erase>] cardPreview  =
    inherit FelizProps.prop<ICardPreviewProp>
    /// Root element of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ICardPreviewProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Container that holds a logo related to the image preview provided.
    static member inline logo (value: ReactElement) = Interop.mkProperty<ICardPreviewProp> "logo" value
    /// Container that holds a logo related to the image preview provided.
    static member inline logo (value: IReactProperty list) = Interop.mkProperty<ICardPreviewProp> "logo" (!!value |> createObj |> unbox<IReactProperty>)

module cardPreview  =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ICardPreviewProp> "as" "div"

// -------------------------------------------------------------------------- Skeleton --------------------------------------------------------------------------------------
type [<Erase>] skeleton  =
    inherit FelizProps.prop<ISkeletonProp>
    /// The root slot of the `Skeleton` is the container that will contain the slots that make up a `Skeleton`
    /// and any data that the `Skeleton` will load. The default html element is a `div`.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISkeletonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Sets the width value of the skeleton wrapper.
    static member inline width (value: string) = Interop.mkProperty<ISkeletonProp> "width" value
    /// Sets the width value of the skeleton wrapper.
    static member inline width (value: int) = Interop.mkProperty<ISkeletonProp> "width" value
    /// Sets the width value of the skeleton wrapper.
    static member inline width (value: float) = Interop.mkProperty<ISkeletonProp> "width" value
    /// Sets the width value of the skeleton wrapper.
    static member inline width (value: decimal) = Interop.mkProperty<ISkeletonProp> "width" value

module skeleton  =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ISkeletonProp> "as" "div"

    /// The animation type for the Skeleton
    type [<Erase>] animation =
        static member inline wave = Interop.mkProperty<ISkeletonProp> "animation" "wave"
        static member inline pulse = Interop.mkProperty<ISkeletonProp> "animation" "pulse"

    /// Sets the appearance of the Skeleton.
    type [<Erase>] appearance =
        static member inline opaque = Interop.mkProperty<ISkeletonProp> "appearance" "opaque"
        static member inline translucent = Interop.mkProperty<ISkeletonProp> "appearance" "translucent"

// -------------------------------------------------------------------------- SkeletonItem --------------------------------------------------------------------------------------
type [<Erase>] skeletonItem  =
    inherit FelizProps.prop<ISkeletonItemProp>
        static member inline root (value: IReactProperty list) = Interop.mkProperty<ISkeletonItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module skeletonItem =
    /// Sets the animation of the SkeletonItem
    type [<Erase>] animation =
        static member inline wave = Interop.mkProperty<ISkeletonItemProp> "animation" "wave"
        static member inline pulse = Interop.mkProperty<ISkeletonItemProp> "animation" "pulse"

    /// Sets the appearance of the SkeletonItem.
    type [<Erase>] appearance =
        static member inline opaque = Interop.mkProperty<ISkeletonItemProp> "appearance" "opaque"
        static member inline translucent = Interop.mkProperty<ISkeletonItemProp> "appearance" "translucent"

    /// Sets the size of the SkeletonItem in pixels.
    /// Size is restricted to a limited set of values recommended for most uses(see SkeletonItemSize).
    /// To set a non-supported size, set `width` and `height` to override the rendered size.
    /// @default 16
    type [<Erase>] size =
        static member inline ``8`` = Interop.mkProperty<ISkeletonItemProp> "size" 8
        static member inline ``12`` = Interop.mkProperty<ISkeletonItemProp> "size" 12
        static member inline ``16`` = Interop.mkProperty<ISkeletonItemProp> "size" 16
        static member inline ``20`` = Interop.mkProperty<ISkeletonItemProp> "size" 20
        static member inline ``24`` = Interop.mkProperty<ISkeletonItemProp> "size" 24
        static member inline ``28`` = Interop.mkProperty<ISkeletonItemProp> "size" 28
        static member inline ``32`` = Interop.mkProperty<ISkeletonItemProp> "size" 32
        static member inline ``36`` = Interop.mkProperty<ISkeletonItemProp> "size" 36
        static member inline ``40`` = Interop.mkProperty<ISkeletonItemProp> "size" 40
        static member inline ``48`` = Interop.mkProperty<ISkeletonItemProp> "size" 48
        static member inline ``56`` = Interop.mkProperty<ISkeletonItemProp> "size" 56
        static member inline ``64`` = Interop.mkProperty<ISkeletonItemProp> "size" 64
        static member inline ``72`` = Interop.mkProperty<ISkeletonItemProp> "size" 72
        static member inline ``96`` = Interop.mkProperty<ISkeletonItemProp> "size" 96
        static member inline ``120`` = Interop.mkProperty<ISkeletonItemProp> "size" 120
        static member inline ``128`` = Interop.mkProperty<ISkeletonItemProp> "size" 128

    /// Sets the shape of the SkeletonItem.
    type [<Erase>] shape =
        static member inline circle = Interop.mkProperty<ISkeletonItemProp> "shape" "circle"
        static member inline square = Interop.mkProperty<ISkeletonItemProp> "shape" "square"
        static member inline rectangle = Interop.mkProperty<ISkeletonItemProp> "shape" "rectangle"

// -------------------------------------------------------------------------- DatePicker --------------------------------------------------------------------------------------
type [<Erase>] datePicker  =
    inherit FelizProps.prop<IDatePickerProp>
    /// Wrapper element which visually appears to be the input and is used for borders, focus styling, etc.
    /// (A wrapper is needed to properly position contentBefore and contentAfter relative to input.)
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDatePickerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The actual <input> element. type="text" will be automatically applied unless overridden.
    /// This is the "primary" slot, so native props specified directly on the <Input> will go here (except className and style, which go to the root slot).
    /// The top-level ref will also go here.
    static member inline input (value: ReactElement) = Interop.mkProperty<IDatePickerProp> "input" value
    /// WARNING: DatePicker doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children (value: ReactElement) = Interop.mkProperty<IDatePickerProp> "children" value
    /// WARNING: DatePicker doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: ReactElement seq) = Interop.mkProperty<IDatePickerProp> "children" (Interop.reactApi.Children.toArray elems)
    /// Called when the user changes the input's value.
    static member inline onChange (handler: ValueProp<string> -> unit) = Interop.mkProperty<IDatePickerProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Called when the user changes the input's value.
    static member inline onChange (value: MouseEvent -> ValueProp<string> -> unit) = Interop.mkProperty<IDatePickerProp> "onChange" (System.Func<_,_,_> value)
    /// Called when the user changes the input's value.
    static member inline onChange (value: KeyboardEvent -> ValueProp<string> -> unit) = Interop.mkProperty<IDatePickerProp> "onChange" (System.Func<_,_,_> value)
    /// Element before the input text, within the input border
    static member inline contentBefore (value: ReactElement) = Interop.mkProperty<IDatePickerProp> "contentBefore" value
    /// Element after the input text, within the input border
    static member inline contentAfter (value: ReactElement) = Interop.mkProperty<IDatePickerProp> "contentAfter" value
    static member inline calendar (value: ICalendarProp list) = Interop.mkProperty<IDatePickerProp> "calendar" (!!value |> createObj |> unbox<ICalendarProp>)
    static member inline popupSurface (value: ReactElement) = Interop.mkProperty<IDatePickerProp> "popupSurface" value
    static member inline popupSurface (value: IReactProperty list) = Interop.mkProperty<IDatePickerProp> "popupSurface" (!!value |> createObj |> unbox<IReactProperty>)
    /// Callback issued when a date is selected
    static member inline onSelectDate (value: DateTime option -> unit) = Interop.mkProperty<IDatePickerProp> "onSelectDate" (System.Func<_,_> value)
    /// Whether or not the Input of the DatePicker is underlined.
    static member inline underlined (value: bool) = Interop.mkProperty<IDatePickerProp> "underlined" value
    /// Whether the month picker is shown beside the day picker or hidden.
    static member inline isMonthPickerVisible (value: bool) = Interop.mkProperty<IDatePickerProp> "isMonthPickerVisible" value
    /// Show month picker on top of date picker when visible.
    static member inline showMonthPickerAsOverlay (value: bool) = Interop.mkProperty<IDatePickerProp> "showMonthPickerAsOverlay" value
    /// Whether the DatePicker allows input a date string directly or not
    static member inline allowTextInput (value: bool) = Interop.mkProperty<IDatePickerProp> "allowTextInput" value
    /// Whether the DatePicker should open automatically when the control is focused
    ///
    /// WARNING: setting this to false creates an accessibility violation and is not recommended
    static member inline disableAutoFocus (value: bool) = Interop.mkProperty<IDatePickerProp> "disableAutoFocus" value
    /// Whether the DatePicker should open when the input is clicked
    static member inline openOnClick (value: bool) = Interop.mkProperty<IDatePickerProp> "openOnClick" value
    /// Whether the DatePicker should be open by default
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDatePickerProp> "defaultOpen" value
    /// Whether the DatePicker is open or not
    static member inline open' (value: bool) = Interop.mkProperty<IDatePickerProp> "open" value
    /// Callback to run when the DatePicker's open state changes
    static member inline onOpenChange (value: OpenProp -> unit) = Interop.mkProperty<IDatePickerProp> "onOpenChange" (System.Func<_,_> value)
    /// Callback to run after the DatePicker's input has been validated
    static member inline onValidationResult (value: DatePickerValidationResultData -> unit) = Interop.mkProperty<IDatePickerProp> "onValidationResult" (System.Func<_,_> value)
    /// Whether the DatePicker should render the popup as inline or in a portal
    static member inline inlinePopup (value: bool) = Interop.mkProperty<IDatePickerProp> "inlinePopup" value
    /// Value of today. If unspecified, current time in client machine will be used.
    static member inline today (value: DateTime) = Interop.mkProperty<IDatePickerProp> "today" value
    /// Default value of the DatePicker, if any
    /// When the component is controlled, null should be used instead of undefined to avoid controlled vs. uncontrolled ambiguity.
    static member inline value (value: DateTime option) = Interop.mkProperty<IDatePickerProp> "value" value
    /// Optional method to format the chosen date to a string to display in the DatePicker
    static member inline formatDate (value: DateTime option -> string) = Interop.mkProperty<IDatePickerProp> "formatDate" (System.Func<_,_> value)
    /// Optional method to format the chosen date to a string to display in the DatePicker
    static member inline parseDateFromString (value: string -> DateTime option) = Interop.mkProperty<IDatePickerProp> "parseDateFromString" (System.Func<_,_> value)
    /// Whether the month picker should highlight the current month
    static member inline highlightCurrentMonth (value: bool) = Interop.mkProperty<IDatePickerProp> "highlightCurrentMonth" value
    /// Whether the month picker should highlight the selected month
    static member inline highlightSelectedMonth (value: bool) = Interop.mkProperty<IDatePickerProp> "highlightSelectedMonth" value
    /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
    static member inline showWeekNumbers (value: bool) = Interop.mkProperty<IDatePickerProp> "showWeekNumbers" value
    /// Whether the "Go to today" link should be shown or not
    static member inline showGoToToday (value: bool) = Interop.mkProperty<IDatePickerProp> "showGoToToday" value
    /// Determines if the DatePicker has a border.
    static member inline borderless (value: bool) = Interop.mkProperty<IDatePickerProp> "borderless" value
    /// <para>Apply additional formatting to dates, for example localized date formatting.
    /// You can either pass your own DateFormatting type, or use the *default'* type in the DateFormatting module.</para>
    ///
    /// Usage:
    /// <code>datePicker.dateTimeFormatter { DateFormatting.default' with formatYear = (fun d -> sprintf "%A A.D." d.Year) }</code>
    static member inline dateTimeFormatter (value: DateFormatting) = Interop.mkProperty<IDatePickerProp> "dateTimeFormatter" value  //TODO should be a list of props?
    /// Determines if the DatePicker has a border.
    static member inline minDate (value: DateTime) = Interop.mkProperty<IDatePickerProp> "minDate" value
    /// Determines if the DatePicker has a border.
    static member inline maxDate (value: DateTime) = Interop.mkProperty<IDatePickerProp> "maxDate" value
    /// The initially highlighted date.
    static member inline initialPickerDate (value: DateTime) = Interop.mkProperty<IDatePickerProp> "initialPickerDate" value
    /// Allows all elements to be focused, including disabled ones
    static member inline allFocusable (value: bool) = Interop.mkProperty<IDatePickerProp> "allFocusable" value
    /// Whether the CalendarDay close button should be shown or not.
    static member inline showCloseButton (value: bool) = Interop.mkProperty<IDatePickerProp> "showCloseButton" value
    /// Configure the positioning of the datepicker
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<IDatePickerProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)

module datePicker =
    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<IDatePickerProp> "as" "input"

    /// Size of the input (changes the font size and spacing).
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IDatePickerProp> "size" "small"
        static member inline medium = Interop.mkProperty<IDatePickerProp> "size" "medium"
        static member inline large = Interop.mkProperty<IDatePickerProp> "size" "large"

    /// Controls the colors and borders of the input.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<IDatePickerProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<IDatePickerProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<IDatePickerProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<IDatePickerProp> "appearance" "filled-lighter"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledDarkerShadow = Interop.mkProperty<IDatePickerProp> "appearance" "filled-darker-shadow"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledLighterShadow = Interop.mkProperty<IDatePickerProp> "appearance" "filled-lighter-shadow"

    /// An input can have different text-based types based on the type of value the user will enter.
    /// Note that no custom styling is currently applied for alternative types, and some types may activate browser-default styling which does not match the Fluent design language.
    /// (For non-text-based types such as button or checkbox, use the appropriate component or an <input> element instead.)
    type [<Erase>] type' =
        static member inline number = Interop.mkProperty<IDatePickerProp> "type" "number"
        static member inline time = Interop.mkProperty<IDatePickerProp> "type" "time"
        static member inline text = Interop.mkProperty<IDatePickerProp> "type" "text"
        static member inline search = Interop.mkProperty<IDatePickerProp> "type" "search"
        static member inline tel = Interop.mkProperty<IDatePickerProp> "type" "tel"
        static member inline url = Interop.mkProperty<IDatePickerProp> "type" "url"
        static member inline email = Interop.mkProperty<IDatePickerProp> "type" "email"
        static member inline date = Interop.mkProperty<IDatePickerProp> "type" "date"
        static member inline datetimeLocal = Interop.mkProperty<IDatePickerProp> "type" "datetime-local"
        static member inline month = Interop.mkProperty<IDatePickerProp> "type" "month"
        static member inline password = Interop.mkProperty<IDatePickerProp> "type" "password"
        static member inline week = Interop.mkProperty<IDatePickerProp> "type" "week"

    type [<Erase>] firstDayOfWeek =
        static member inline sunday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 0
        static member inline monday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 1
        static member inline tuesday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 2
        static member inline wednesday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 3
        static member inline thursday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 4
        static member inline friday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 5
        static member inline saturday = Interop.mkProperty<IDatePickerProp> "firstDayOfWeek" 6

    type [<Erase>] firstWeekOfYear =
        static member inline firstDay = Interop.mkProperty<IDatePickerProp> "firstWeekOfYear" 0
        static member inline firstFullWeek = Interop.mkProperty<IDatePickerProp> "firstWeekOfYear" 1
        static member inline firstFourDayWeek = Interop.mkProperty<IDatePickerProp> "firstWeekOfYear" 2

    /// Configure the positioning of the datepicker
    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<IDatePickerProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<IDatePickerProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<IDatePickerProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<IDatePickerProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<IDatePickerProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<IDatePickerProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<IDatePickerProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<IDatePickerProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<IDatePickerProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<IDatePickerProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<IDatePickerProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<IDatePickerProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- Calendar --------------------------------------------------------------------------------------
type [<Erase>] calendar  =
    /// Optional callback to access the ICalendar interface. Use this instead of ref for accessing the public methods and properties of the component.
    static member inline componentRef (value: IRefValue<FocusProp>) = Interop.mkProperty<ICalendarProp> "componentRef" value
    /// Customized props for the calendar day
    static member inline calendarDayProps (value: ICalendarDayProp list) = Interop.mkProperty<ICalendarProp> "calendarDayProps" (!!value |> createObj |> unbox<ICalendarDayProp>)
    /// Customized props for the calendar month
    static member inline calendarMonthProps (value: ICalendarMonthProp list) = Interop.mkProperty<ICalendarProp> "calendarMonthProps" (!!value |> createObj |> unbox<ICalendarMonthProp>)
    /// Optional class name to add to the root element.
    static member inline className (value: string) = Interop.mkProperty<ICalendarProp> "className" value
    /// Callback for when a date is selected
    /// @param date - The date the user selected
    /// @param selectedDateRangeArray - The resultant list of dates that are selected based on the date range type set for the component.
    static member inline onSelectDate (value: {| date: DateTime; selectedDateRangeArray: array<DateTime> option |} -> unit) = Interop.mkProperty<ICalendarProp> "onSelectDate" (System.Func<_,_> value)
    /// Callback for when calendar is closed
    static member inline onDismiss (value: unit -> unit) = Interop.mkProperty<ICalendarProp> "onDismiss" (System.Func<_,_> value)
    /// ID for the calendar
    static member id (value: string) = Interop.mkProperty<ICalendarProp> "id" value
    /// Default value of the Calendar, if any
    static member inline value (value: DateTime) = Interop.mkProperty<ICalendarProp> "value" value
    /// Value of today. If unspecified, current time in client machine will be used.
    static member inline today (value: DateTime) = Interop.mkProperty<ICalendarProp> "today" value
    /// Whether the month picker is shown beside the day picker or hidden.
    static member isMonthPickerVisible (value: bool) = Interop.mkProperty<ICalendarProp> "isMonthPickerVisible" value
    /// Whether the day picker is shown beside the month picker or hidden.
    static member isDayPickerVisible (value: bool) = Interop.mkProperty<ICalendarProp> "isDayPickerVisible" value
    /// Show month picker on top of date picker when visible.
    static member inline showMonthPickerAsOverlay (value: bool) = Interop.mkProperty<ICalendarProp> "showMonthPickerAsOverlay" value
    /// Whether the "Go to today" link should be shown or not
    static member inline showGoToToday (value: bool) = Interop.mkProperty<ICalendarProp> "showGoToToday" value
    /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
    static member inline showWeekNumbers (value: bool) = Interop.mkProperty<ICalendarProp> "showWeekNumbers" value
    /// <para>Localized strings to use in the Calendar
    /// You can either pass your own CalendarStrings type, or use the *default'* type in the CalendarStrings module.</para>
    ///
    /// Usage:
    /// <code>calendar.strings ( {CalendarStrings.default' with goToToday = "Pick Today"} )</code>
    static member inline strings (value: CalendarStrings) = Interop.mkProperty<ICalendarProp> "strings" value
    /// If set the Calendar will not allow navigation to or selection of a date earlier than this value.
    static member inline minDate (value: DateTime) = Interop.mkProperty<ICalendarProp> "minDate" value
    /// If set the Calendar will not allow navigation to or selection of a date later than this value.
    static member inline maxDate (value: DateTime) = Interop.mkProperty<ICalendarProp> "maxDate" value
    /// If set the Calendar will not allow selection of dates in this array.
    static member inline restrictedDates (value: DateTime array) = Interop.mkProperty<ICalendarProp> "restrictedDates" value
    /// Whether the calendar should show 6 weeks by default.
    static member inline showSixWeeksByDefault (value: bool) = Interop.mkProperty<ICalendarProp> "showSixWeeksByDefault" value
    /// The days that are selectable when `dateRangeType` is `WorkWeek`.
    /// If `dateRangeType` is not `WorkWeek` this property does nothing.
    /// @default [Monday,Tuesday,Wednesday,Thursday,Friday]
    static member inline workWeekDays (value: System.DayOfWeek array) =
        let daysToInts = value |> Array.map (fun d ->
            match d with
            | DayOfWeek.Sunday -> 0
            | DayOfWeek.Monday -> 1
            | DayOfWeek.Tuesday -> 2
            | DayOfWeek.Wednesday -> 3
            | DayOfWeek.Thursday -> 4
            | DayOfWeek.Friday -> 5
            | DayOfWeek.Saturday -> 6
            | _ -> 0
        )
        Interop.mkProperty<ICalendarProp> "workWeekDays" daysToInts
    /// Whether the month picker should highlight the current month
    static member inline highlightCurrentMonth (value: bool) = Interop.mkProperty<ICalendarProp> "highlightCurrentMonth" value
    /// Whether the month picker should highlight the selected month
    static member inline highlightSelectedMonth (value: bool) = Interop.mkProperty<ICalendarProp> "highlightSelectedMonth" value
    /// Whether the close button should be shown or not
    static member inline showCloseButton (value: bool) = Interop.mkProperty<ICalendarProp> "showCloseButton" value
    /// Allows all dates and buttons to be focused, including disabled ones
    static member inline allFocusable (value: bool) = Interop.mkProperty<ICalendarProp> "allFocusable" value

module calendar =
    /// The date range type indicating how many days should be selected as the user selects days
    /// @default DateRangeType.Day
    type [<Erase>] dateRangeType =
        static member inline day = Interop.mkProperty<ICalendarProp> "dateRangeType" 0
        static member inline week = Interop.mkProperty<ICalendarProp> "dateRangeType" 1
        static member inline month = Interop.mkProperty<ICalendarProp> "dateRangeType" 2
        static member inline workWeek = Interop.mkProperty<ICalendarProp> "dateRangeType" 3

    /// The first day of the week for your locale.
    /// @default DayOfWeek.Sunday
    type [<Erase>] firstDayOfWeek =
        static member inline sunday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 0
        static member inline monday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 1
        static member inline tuesday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 2
        static member inline wednesday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 3
        static member inline thursday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 4
        static member inline friday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 5
        static member inline saturday = Interop.mkProperty<ICalendarProp> "firstDayOfWeek" 6

    /// Defines when the first week of the year should start.
    /// @default FirstWeekOfYear.FirstDay
    type [<Erase>] firstWeekOfYear =
        static member inline firstDay = Interop.mkProperty<ICalendarProp> "firstWeekOfYear" 0
        static member inline firstFullWeek = Interop.mkProperty<ICalendarProp> "firstWeekOfYear" 1
        static member inline firstFourDayWeek = Interop.mkProperty<ICalendarProp> "firstWeekOfYear" 2

// -------------------------------------------------------------------------- CalendarDay --------------------------------------------------------------------------------------
type [<Erase>] calendarDay  =
    /// Optional callback to access the ICalendarDay interface. Use this instead of ref for accessing the public methods and properties of the component.
    static member inline componentRef (value: IRefValue<FocusProp>) = Interop.mkProperty<ICalendarDayProp> "componentRef" value
    /// Additional CSS class(es) to apply to the CalendarDay.
    static member inline className (value: string) = Interop.mkProperty<ICalendarDayProp> "className" value
    /// Localized strings to use in the Calendar
    /// You can either pass your own CalendarStrings type, or use the *default'* type in the CalendarStrings module.</para>
    ///
    /// Usage:
    /// <code>calendarDay.strings ( {CalendarStrings.default' with goToToday = "Pick Today"} )</code>
    static member inline strings (value: CalendarStrings) = Interop.mkProperty<ICalendarDayProp> "strings" value
    /// The currently navigated date
    static member inline navigatedDate (value: DateTime) = Interop.mkProperty<ICalendarDayProp> "navigatedDate" value
    /// Callback issued when a date in the calendar is navigated
    /// @param date - The date that is navigated to
    /// @param focusOnNavigatedDay - Whether to set the focus to the navigated date.
    static member inline onNavigateDate (value: DateTime * bool -> unit) = Interop.mkProperty<ICalendarDayProp> "onNavigateDate" value
    /// Callback issued when calendar day is closed
    static member inline onDismiss (value: unit -> unit) = Interop.mkProperty<ICalendarDayProp> "onDismiss" (System.Func<_,_> value)
    /// Callback function when the header is selected
    static member inline onHeaderSelect (value: unit -> unit) = Interop.mkProperty<ICalendarDayProp> "onHeaderSelect" (System.Func<_,_> value)
    /// Whether the calendar should show the week number (weeks 1 to 53) before each week row
    static member inline showWeekNumbers (value: bool) = Interop.mkProperty<ICalendarDayProp> "showWeekNumbers" value
    /// <para>Apply additional formatting to dates, for example localized date formatting.
    /// You can either pass your own DateFormatting type, or use the *default'* type in the DateFormatting module.</para>
    ///
    /// Usage:
    /// <code>calendarDay.dateTimeFormatter { DateFormatting.default' with formatYear = (fun d -> sprintf "%A A.D." d.Year) }</code>
    static member inline dateTimeFormatter (value: DateFormatting) = Interop.mkProperty<ICalendarDayProp> "dateTimeFormatter" value //TODO should be a list of props?
    /// Whether the calendar should show 6 weeks by default.
    static member inline showSixWeeksByDefault (value: bool) = Interop.mkProperty<ICalendarDayProp> "showSixWeeksByDefault" value
    /// If set the Calendar will not allow navigation to or selection of a date earlier than this value.
    static member inline minDate (value: DateTime) = Interop.mkProperty<ICalendarDayProp> "minDate" value
    /// If set the Calendar will not allow navigation to or selection of a date later than this value.
    static member inline maxDate (value: DateTime) = Interop.mkProperty<ICalendarDayProp> "maxDate" value
    /// If set the Calendar will not allow selection of dates in this array.
    static member inline restrictedDates (value: DateTime array) = Interop.mkProperty<ICalendarDayProp> "restrictedDates" value
    /// Whether the close button should be shown or not
    static member inline showCloseButton (value: bool) = Interop.mkProperty<ICalendarDayProp> "showCloseButton" value
    /// Allows all dates and buttons to be focused, including disabled ones
    static member inline allFocusable (value: bool) = Interop.mkProperty<ICalendarDayProp> "allFocusable" value


// -------------------------------------------------------------------------- CalendarMonth --------------------------------------------------------------------------------------
type [<Erase>] calendarMonth  =
    /// Optional callback to access the ICalendarMonth interface. Use this instead of ref for accessing the public methods and properties of the component.
    static member inline componentRef (value: IRefValue<FocusProp>) = Interop.mkProperty<ICalendarMonthProp> "componentRef" value
    /// Localized strings to use in the Calendar
    /// You can either pass your own CalendarStrings type, or use the *default'* type in the CalendarStrings module.</para>
    ///
    /// Usage:
    /// <code>calendarMonth.strings ( {CalendarStrings.default' with goToToday = "Pick Today"} )</code>
    static member inline strings (value: CalendarStrings) = Interop.mkProperty<ICalendarMonthProp> "strings" value
    /// The currently selected date
    static member inline selectedDate (value: DateTime) = Interop.mkProperty<ICalendarMonthProp> "selectedDate" value
    /// The currently navigated date
    static member inline navigatedDate (value: DateTime) = Interop.mkProperty<ICalendarMonthProp> "navigatedDate" value
    /// Callback issued when a month is selected
    /// @param date - The date the user selected
    /// @param selectedDateRangeArray - The resultant list of dates that are selected based on the date range type set for the component.
    static member inline onSelectDate (value: {| date: DateTime; selectedDateRangeArray: DateTime array |} -> unit) = Interop.mkProperty<ICalendarMonthProp> "onSelectDate" (System.Func<_,_> value)
    /// Callback issued when the year is navigated
    /// @param date - The date that is navigated to
    /// @param focusOnNavigatedDay - Whether to set the focus to the navigated date.
    static member inline onNavigateDate (value: {| date: DateTime; focusOnNavigatedDay: bool |} -> unit) = Interop.mkProperty<ICalendarMonthProp> "onNavigateDate" (System.Func<_,_> value)
    /// Value of today. If unspecified, current time in client machine will be used.
    static member inline today (value: DateTime) = Interop.mkProperty<ICalendarMonthProp> "today" value
    /// Value of today. If unspecified, current time in client machine will be used.
    static member inline onHeaderSelect (value: unit -> unit) = Interop.mkProperty<ICalendarMonthProp> "onHeaderSelect" (System.Func<_,_> value)
    /// <para>Apply additional formatting to dates, for example localized date formatting.
    /// You can either pass your own DateFormatting type, or use the *default'* type in the DateFormatting module.</para>
    ///
    /// Usage:
    /// <code>calendarMonth.dateTimeFormatter { DateFormatting.default' with formatYear = (fun d -> sprintf "%A A.D." d.Year) }</code>
    static member inline dateTimeFormatter (value: DateFormatting) = Interop.mkProperty<ICalendarMonthProp> "dateTimeFormatter" value  //TODO should be a list of props?
    /// If set the Calendar will not allow navigation to or selection of a date earlier than this value.
    static member inline minDate (value: DateTime) = Interop.mkProperty<ICalendarMonthProp> "minDate" value
    /// If set the Calendar will not allow navigation to or selection of a date later than this value.
    static member inline maxDate (value: DateTime) = Interop.mkProperty<ICalendarMonthProp> "maxDate" value
    /// Whether the month picker should highlight the current month
    static member inline highlightCurrentMonth (value: bool) = Interop.mkProperty<ICalendarMonthProp> "highlightCurrentMonth" value
    /// Whether the month picker should highlight the selected month
    static member inline highlightSelectedMonth (value: bool) = Interop.mkProperty<ICalendarMonthProp> "highlightSelectedMonth" value
    /// Allows all dates and buttons to be focused, including disabled ones
    static member inline allFocusable (value: bool) = Interop.mkProperty<ICalendarMonthProp> "allFocusable" value
    /// Additional CSS class(es) to apply to the CalendarMonth.
    static member inline className (value: string) = Interop.mkProperty<ICalendarMonthProp> "className" value
    /// Whether the year picker is hidden
    static member inline yearPickerHidden (value: bool) = Interop.mkProperty<ICalendarMonthProp> "yearPickerHidden" value

module calendarMonth =
    /// The cardinal directions for animation to occur during transitions, either horizontal or veritcal
    type [<Erase>] animationDirection =
        static member inline horizontal = Interop.mkProperty<ICalendarMonthProp> "animationDirection" 0
        static member inline vertical = Interop.mkProperty<ICalendarMonthProp> "animationDirection" 1

// -------------------------------------------------------------------------- Overflow --------------------------------------------------------------------------------------
type [<Erase>] overflow  =
    /// Padding (in px) at the end of the container before overflow occurs Useful to account for extra elements (i.e. dropdown menu) or to account for any kinds of margins between items which are hard to measure with JS
    static member inline padding (value: int) = Interop.mkProperty<IOverflowProp> "padding" value
    /// Padding (in px) at the end of the container before overflow occurs Useful to account for extra elements (i.e. dropdown menu) or to account for any kinds of margins between items which are hard to measure with JS
    static member inline padding (value: float) = Interop.mkProperty<IOverflowProp> "padding" value
    /// Padding (in px) at the end of the container before overflow occurs Useful to account for extra elements (i.e. dropdown menu) or to account for any kinds of margins between items which are hard to measure with JS
    static member inline padding (value: decimal) = Interop.mkProperty<IOverflowProp> "padding" value
    /// The minimum number of visible items
    static member inline minimumVisible (value: int) = Interop.mkProperty<IOverflowProp> "minimumVisible" value
    /// The minimum number of visible items
    static member inline minimumVisible (value: float) = Interop.mkProperty<IOverflowProp> "minimumVisible" value
    /// The minimum number of visible items
    static member inline minimumVisible (value: decimal) = Interop.mkProperty<IOverflowProp> "minimumVisible" value
    static member inline children (value: ReactElement) = Interop.mkProperty<IOverflowProp> "children" value

module overflow =
    /// Horizontal or vertical overflow
    type [<Erase>] overflowAxis =
        static member inline horizontal = Interop.mkProperty<IOverflowProp> "overflowAxis" "horizontal"
        static member inline vertical = Interop.mkProperty<IOverflowProp> "overflowAxis" "vertical"

    /// Direction where items are removed when overflow occurs
    type [<Erase>] overflowDirection =
        static member inline start = Interop.mkProperty<IOverflowProp> "overflowDirection" "start"
        static member inline end' = Interop.mkProperty<IOverflowProp> "overflowDirection" "end"

// -------------------------------------------------------------------------- OverflowItem --------------------------------------------------------------------------------------
type [<Erase>] overflowItem  =
    /// The unique identifier for the item used by the overflow manager.
    static member id (value: string) = Interop.mkProperty<IOverflowItemProp> "id" value
    /// The unique identifier for the item used by the overflow manager.
    static member inline key (value: string) = Interop.mkProperty<IOverflowItemProp> "key" value
    /// Assigns the item to a group, group visibility can be watched.
    static member inline groupId (value: string) = Interop.mkProperty<IOverflowItemProp> "groupId" value
    /// A higher priority means the item overflows later.
    static member inline priority (value: int) = Interop.mkProperty<IOverflowItemProp> "priority" value
    /// A higher priority means the item overflows later.
    static member inline priority (value: float) = Interop.mkProperty<IOverflowItemProp> "priority" value
    /// A higher priority means the item overflows later.
    static member inline priority (value: decimal) = Interop.mkProperty<IOverflowItemProp> "priority" value
    /// The single child that has overflow item behavior attached.
    static member inline children (value: ReactElement) = Interop.mkProperty<IOverflowItemProp> "children" value

// -------------------------------------------------------------------------- OverflowDivider --------------------------------------------------------------------------------------
type [<Erase>] overflowDivider  =
    /// Assigns the item to a group, group visibility can be watched.
    static member inline groupId (value: string) = Interop.mkProperty<IOverflowDividerProp> "groupId" value
    /// The single child that has overflow item behavior attached.
    static member inline children (value: ReactElement) = Interop.mkProperty<IOverflowDividerProp> "children" value

// -------------------------------------------------------------------------- DataGrid --------------------------------------------------------------------------------------
type [<Erase>] dataGrid  =
    inherit FelizProps.prop<IDataGridProp>
    /// Render all table elements as divs instead of semantic table elements Using divs no longer uses display: table layout but display: flex
    static member inline root (value: IReactProperty) = Interop.mkProperty<IDataGridProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Render all table elements as divs instead of semantic table elements Using divs no longer uses display: table layout but display: flex
    static member inline noNativeElements (value: bool) = Interop.mkProperty<IDataGridProp> "noNativeElements" value
    /// Whether the table is sortable
    static member inline sortable (value: bool) = Interop.mkProperty<IDataGridProp> "sortable" value
    static member items (value: #seq<'T>) = Interop.mkProperty<IDataGridProp> "items" (value |> Seq.toArray)
    /// Table columns
    static member inline columns (value: #seq<TableColumnDefinition<'T, 'TKeyType>>) = Interop.mkProperty<IDataGridProp> "columns" (value |> Seq.toArray)
    static member inline getRowId (value: 'T -> 'TKeyType) = Interop.mkProperty<IDataGridProp> "getRowId" (System.Func<_,_> value) //TODO
    static member inline subtleSelection (value: bool) = Interop.mkProperty<IDataGridProp> "subtleSelection" value
    /// Enables column resizing
    static member inline resizableColumns (value: bool) = Interop.mkProperty<IDataGridProp> "resizableColumns" value
    /// Used to control sorting
    static member inline sortState (value: SortState<'TKeyType>) = Interop.mkProperty<IDataGridProp> "sortState" value
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSortState (value: SortState<'TKeyType>) = Interop.mkProperty<IDataGridProp> "defaultSortState" value
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSelectedItems (value: #seq<'TKeyType>) = Interop.mkProperty<IDataGridProp> "defaultSelectedItems" value
    /// Used to control selected items
    static member inline selectedItems (value: #seq<'TKeyType>) = Interop.mkProperty<IDataGridProp> "selectedItems" value
    static member inline onSortChange (handler: SortState<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onSortChange" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onSortChange (value: MouseEvent -> SortState<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onSortChange" (System.Func<_,_,_> value)
    static member inline onSortChange (value: KeyboardEvent -> SortState<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onSortChange" (System.Func<_,_,_> value)
    static member inline onSelectionChange (handler: {| selectedItems: Set<'T> |} -> unit) = Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onSelectionChange (value: MouseEvent -> {| selectedItems: Set<'T> |} -> unit) = Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> value)
    static member inline onSelectionChange (value: KeyboardEvent -> {| selectedItems: Set<'T> |} -> unit) = Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> value)
    /// Options for column resizing
    static member inline columnSizingOptions (value: TableColumnSizingOptions<'TKeyType>) = Interop.mkProperty<IDataGridProp> "columnSizingOptions" value
    /// A callback triggered when a column is resized.
    static member inline onColumnResize (handler: ColumnResizeData<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onColumnResize" (System.Func<_,_,_> (fun _ value -> handler value))
    /// A callback triggered when a column is resized.
    static member inline onColumnResize (value: MouseEvent -> ColumnResizeData<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onColumnResize" (System.Func<_,_,_> value)
    /// A callback triggered when a column is resized.
    static member inline onColumnResize (value: KeyboardEvent -> ColumnResizeData<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onColumnResize" (System.Func<_,_,_> value)
    /// A callback triggered when a column is resized.
    static member inline onColumnResize (value: TouchEvent -> ColumnResizeData<'TKeyType> -> unit) = Interop.mkProperty<IDataGridProp> "onColumnResize" (System.Func<_,_,_> value)
    /// For column resizing. Allows for a container size to be adjusted by a number of pixels, to make sure the columns don't overflow the table. By default, this value is calculated internally based on other props, but can be overriden.
    static member inline containerWidthOffset (value: int) = Interop.mkProperty<IDataGridProp> "containerWidthOffset" value
    /// For column resizing. Allows for a container size to be adjusted by a number of pixels, to make sure the columns don't overflow the table. By default, this value is calculated internally based on other props, but can be overriden.
    static member inline containerWidthOffset (value: float) = Interop.mkProperty<IDataGridProp> "containerWidthOffset" value
    /// For column resizing. Allows for a container size to be adjusted by a number of pixels, to make sure the columns don't overflow the table. By default, this value is calculated internally based on other props, but can be overriden.
    static member inline containerWidthOffset (value: decimal) = Interop.mkProperty<IDataGridProp> "containerWidthOffset" value

module dataGrid =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridProp> "as" "div"
        static member inline table = Interop.mkProperty<IDataGridProp> "as" "table"

    /// Affects the sizes of all table subcomponents
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IDataGridProp> "size" "small"
        static member inline extraSmall = Interop.mkProperty<IDataGridProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<IDataGridProp> "size" "medium"

    /// How focus navigation will work in the datagrid
    type [<Erase>] focusMode =
        static member inline cell = Interop.mkProperty<IDataGridProp> "focusMode" "cell"
        static member inline none = Interop.mkProperty<IDataGridProp> "focusMode" "none"
        static member inline rowUnstable = Interop.mkProperty<IDataGridProp> "focusMode" "row_unstable" //TODO
        static member inline composite = Interop.mkProperty<IDataGridProp> "focusMode" "composite"

    /// Row appearance when selected
    type [<Erase>] selectionAppearance =
        static member inline none = Interop.mkProperty<IDataGridProp> "selectionAppearance" "none"
        static member inline neutral = Interop.mkProperty<IDataGridProp> "selectionAppearance" "neutral"
        static member inline brand = Interop.mkProperty<IDataGridProp> "selectionAppearance" "brand"

    /// Enables row selection and sets the selection mode
    type [<Erase>] selectionMode =
        static member inline multiselect = Interop.mkProperty<IDataGridProp> "selectionMode" "multiselect"
        static member inline single = Interop.mkProperty<IDataGridProp> "selectionMode" "single"

// -------------------------------------------------------------------------- DataGridHeader --------------------------------------------------------------------------------------
type [<Erase>] dataGridHeader = FelizProps.prop<IDataGridHeaderProp>

module dataGridHeader =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridHeaderProp> "as" "div"
        static member inline thead = Interop.mkProperty<IDataGridHeaderProp> "as" "thead"

// -------------------------------------------------------------------------- DataGridHeaderCell --------------------------------------------------------------------------------------
type [<Erase>] dataGridHeaderCell =
    inherit FelizProps.prop<IDataGridHeaderCellProp>
    /// aside content for anything that should be after main content of the table header cell
    static member inline aside (value: ReactElement)= Interop.mkProperty<IDataGridHeaderProp> "aside" value
    /// Button handles correct narration and interactions for sorting
    static member inline button (value: ReactElement)= Interop.mkProperty<IDataGridHeaderProp> "button" value
    static member inline sortIcon (value: ReactElement)= Interop.mkProperty<IDataGridHeaderProp> "sortIcon" value

module dataGridHeaderCell =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridHeaderCellProp> "as" "div"
        static member inline th = Interop.mkProperty<IDataGridHeaderCellProp> "as" "th"
    type [<Erase>] sortDirection =
        static member inline ascending = Interop.mkProperty<IDataGridHeaderCellProp> "sortDirection" "ascending"
        static member inline descending = Interop.mkProperty<IDataGridHeaderCellProp> "sortDirection" "descending"

// -------------------------------------------------------------------------- DataGridBody --------------------------------------------------------------------------------------
type [<Erase>] dataGridBody =
    inherit FelizProps.prop<IDataGridBodyProp>
    static member inline children (value: TableRowData<'T, 'TKeyType> -> int -> ReactElement)= Interop.mkProperty<IDataGridBodyProp> "children" (System.Func<_,_,_> value) //TODO

module dataGridBody =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridBodyProp> "as" "div"
        static member inline tbody = Interop.mkProperty<IDataGridBodyProp> "as" "tbody"

// -------------------------------------------------------------------------- DataGridRow --------------------------------------------------------------------------------------
type [<Erase>] dataGridRow =
    inherit FelizProps.prop<IDataGridRowProp>
    /// When selection is enabled on the DataGrid, all rows will render the selection cell.
    static member inline selectionCell (value: ReactElement) = Interop.mkProperty<IDataGridRowProp> "selectionCell" value
    /// When selection is enabled on the DataGrid, all rows will render the selection cell.
    static member inline selectionCell (value: ITableSelectionCellProp list) = Interop.mkProperty<IDataGridRowProp> "selectionCell" (!!value |> createObj |> unbox<ITableSelectionCellProp>)
    static member inline children (value: TableColumnDefinition<'T, 'TKeyType> -> DataGridContextValue -> ReactElement) = Interop.mkProperty<IDataGridRowProp> "children" (System.Func<_,_,_> value)

module dataGridRow =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridRowProp> "as" "div"
        static member inline tr = Interop.mkProperty<IDataGridRowProp> "as" "tr"

    /// A table row can have different variants. These appearances are intended to be used with selection.
    type [<Erase>] appearance =
        static member inline none = Interop.mkProperty<IDataGridRowProp> "appearance" "none"
        static member inline neutral = Interop.mkProperty<IDataGridRowProp> "appearance" "neutral"
        static member inline brand = Interop.mkProperty<IDataGridRowProp> "appearance" "brand"

// -------------------------------------------------------------------------- DataGridCell --------------------------------------------------------------------------------------
type [<Erase>] dataGridCell = FelizProps.prop<IDataGridCellProp>

module dataGridCell =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridCellProp> "as" "div"
        static member inline td = Interop.mkProperty<IDataGridCellProp> "as" "td"

    /// Used when there are nested focusble elements inside a focusable cell
    type [<Erase>] focusMode =
        /// The cell is focusable - if there are focusable elements in the cell use group
        static member inline cell = Interop.mkProperty<IDataGridCellProp> "focusMode" "cell"
        /// Enter keypress moves focus inside the cell, focus is trapped inside the cell until Escape keypress
        static member inline group = Interop.mkProperty<IDataGridCellProp> "focusMode" "group"
        /// The cell is not focusable
        static member inline none = Interop.mkProperty<IDataGridCellProp> "focusMode" "none"

// -------------------------------------------------------------------------- DataGridSelectionCell --------------------------------------------------------------------------------------
type [<Erase>] dataGridSelectionCell =
    inherit FelizProps.prop<IDataGridSelectionCellProp>
    /// Selection indicator if selection type is checkbox
    static member inline checkboxIndicator (value: ReactElement)= Interop.mkProperty<IDataGridSelectionCellProp> "checkboxIndicator" value
    /// Selection indicator if selection type is radio
    static member inline radioIndicator (value: ReactElement)= Interop.mkProperty<IDataGridSelectionCellProp> "radioIndicator" value
    /// Only visible when checked or the parent row is hovered/focused
    static member inline subtle (value: bool)= Interop.mkProperty<IDataGridSelectionCellProp> "subtle" value
    static member inline checked' (value: string) = Interop.mkProperty<IDataGridSelectionCellProp> "checked" value
    static member inline checked' (value: bool) = Interop.mkProperty<IDataGridSelectionCellProp> "checked" value
    static member inline checked' (value: CheckState) =
        match value with
        | Checked -> Interop.mkProperty<IDataGridSelectionCellProp> "checked" true
        | Unchecked -> Interop.mkProperty<IDataGridSelectionCellProp> "checked" false
        | Mixed -> Interop.mkProperty<IDataGridSelectionCellProp> "checked" "mixed"

module dataGridSelectionCell =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDataGridSelectionCellProp> "as" "div"
        static member inline td = Interop.mkProperty<IDataGridSelectionCellProp> "as" "td"

    /// A table can have two kinds of selection modes.
    type [<Erase>] type' =
        static member inline checkbox = Interop.mkProperty<IDataGridSelectionCellProp> "type" "checkbox"
        static member inline radio = Interop.mkProperty<IDataGridSelectionCellProp> "type" "radio"


// -------------------------------------------------------------------------- Icon --------------------------------------------------------------------------------------
type [<Erase>] icon =
    inherit FelizProps.prop<IIconProp>
    static member inline primaryFill (value: string)= Interop.mkProperty<IIconProp> "primaryFill" value
    static member inline filled (value: bool)= Interop.mkProperty<IIconProp> "filled" value
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IIconProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline visible (value: IReactProperty list)= Interop.mkProperty<IIconProp> "visible" (!!value |> createObj |> unbox<IReactProperty>)


// -------------------------------------------------------------------------- InfoButton --------------------------------------------------------------------------------------
type [<Erase>] infoButton =
    inherit FelizProps.prop<IInfoButtonProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IInfoButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Popover element that wraps the info and root slots. Use this slot to pass props to the Popover.
    static member inline popover (value: ReactElement)= Interop.mkProperty<IInfoButtonProp> "popover" value
    /// The Popover element that wraps the info and root slots. Use this slot to pass props to the Popover.
    static member inline popover (value: IPopoverProp list)= Interop.mkProperty<IInfoButtonProp> "popover" (!!value |> createObj |> unbox<IPopoverProp>)
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: ReactElement)= Interop.mkProperty<IInfoButtonProp> "info" value
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: IPopoverSurfaceProp list)= Interop.mkProperty<IInfoButtonProp> "info" (!!value |> createObj |> unbox<IPopoverSurfaceProp>)

module infoButton =
    type [<Erase>] as' =
        static member inline button = Interop.mkProperty<IInfoButtonProp> "as" "button"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IInfoButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IInfoButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IInfoButtonProp> "size" "large"

// -------------------------------------------------------------------------- InfoLabel --------------------------------------------------------------------------------------
type [<Erase>] infoLabel =
    inherit FelizProps.prop<IInfoLabelProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IInfoLabelProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Label component.
    /// It is not typically necessary to use this prop. The label text is the child of the <InfoLabel>, and other props such as size and required should be set directly on the InfoLabel.
    /// This is the PRIMARY slot: all native properties specified directly on <InfoLabel> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline label (value: ReactElement)= Interop.mkProperty<IInfoLabelProp> "label" value
    /// The Label component.
    /// It is not typically necessary to use this prop. The label text is the child of the <InfoLabel>, and other props such as size and required should be set directly on the InfoLabel.
    /// This is the PRIMARY slot: all native properties specified directly on <InfoLabel> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline label (value: ILabelProp list)= Interop.mkProperty<IInfoLabelProp> "label" (!!value |> createObj |> unbox<ILabelProp>)
    /// The InfoButton component.
    /// It is not typically necessary to use this prop. The content can be set using the info prop of the InfoLabel.
    static member inline infoButton (value: ReactElement)= Interop.mkProperty<IInfoLabelProp> "infoButton" value
    /// The InfoButton component.
    /// It is not typically necessary to use this prop. The content can be set using the info prop of the InfoLabel.
    static member inline infoButton (value: IInfoButtonProp list)= Interop.mkProperty<IInfoLabelProp> "infoButton" (!!value |> createObj |> unbox<IInfoButtonProp>)
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: string)= Interop.mkProperty<IInfoLabelProp> "info" value
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: IPopoverSurfaceProp list)= Interop.mkProperty<IInfoLabelProp> "info" (!!value |> createObj |> unbox<IPopoverSurfaceProp>)

module infoLabel =
    type [<Erase>] as' =
        static member inline label = Interop.mkProperty<IInfoLabelProp> "as" "label"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IInfoLabelProp> "size" "small"
        static member inline medium = Interop.mkProperty<IInfoLabelProp> "size" "medium"
        static member inline large = Interop.mkProperty<IInfoLabelProp> "size" "large"

    type [<Erase>] weight =
        static member inline regular = Interop.mkProperty<IInfoLabelProp> "weight" "regular"
        static member inline semibold = Interop.mkProperty<IInfoLabelProp> "weight" "semibold"

// -------------------------------------------------------------------------- Alert --------------------------------------------------------------------------------------
type [<Erase>] alert =
    inherit FelizProps.prop<IAlertProp>
    /// The root slot is the top level container for the alert component
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IAlertProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The icon slot renders the icon determined by the `icon` or `intent` prop
    static member inline icon (value: ReactElement) = Interop.mkProperty<IAlertProp> "icon" value
    /// The icon slot renders the icon determined by the `icon` or `intent` prop
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<IAlertProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// The action slot renders a button that prompts the user to take action on the alert
    static member inline action (value: string) = Interop.mkProperty<IAlertProp> "action" value
    /// The action slot renders a button that prompts the user to take action on the alert
    static member inline action (value: ReactElement) = Interop.mkProperty<IAlertProp> "action" value
    /// The action slot renders a button that prompts the user to take action on the alert
    static member inline action (value: IButtonProp list) = Interop.mkProperty<IAlertProp> "action" (!!value |> createObj |> unbox<IButtonProp>)
    /// The avatar slot renders an avatar before the contents of the alert
    static member inline avatar (value: ReactElement) = Interop.mkProperty<IAlertProp> "avatar" value
    /// The avatar slot renders an avatar before the contents of the alert
    static member inline avatar (value: IAvatarProp list) = Interop.mkProperty<IAlertProp> "avatar" (!!value |> createObj |> unbox<IAvatarProp>)

module alert =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IAlertProp> "as" "div"

    /// The intent prop, if present, determines the icon to be rendered in the icon slot. The icon prop overrides the intent prop
    type [<Erase>] intent =
        static member inline success = Interop.mkProperty<IAlertProp> "intent" "success"
        static member inline warning = Interop.mkProperty<IAlertProp> "intent" "warning"
        static member inline error = Interop.mkProperty<IAlertProp> "intent" "error"
        static member inline info = Interop.mkProperty<IAlertProp> "intent" "info"

    /// The appearance of the Alert.
    type [<Erase>] appearance =
        static member inline primary = Interop.mkProperty<IAlertProp> "appearance" "primary"
        static member inline inverted = Interop.mkProperty<IAlertProp> "appearance" "inverted"

// -------------------------------------------------------------------------- Virtualizer --------------------------------------------------------------------------------------
type [<Erase>] virtualizer =
    inherit FelizProps.prop<IVirtualizerProp>
    /// The intersection observed 'before' element will detect when scrolling towards the beginning.
    static member inline before (value: ReactElement) = Interop.mkProperty<IVirtualizerProp> "before" value
    /// The intersection observed 'before' element will detect when scrolling towards the beginning.
    static member inline before (value: IReactProperty list) = Interop.mkProperty<IVirtualizerProp> "before" (!!value |> createObj |> unbox<IReactProperty>)
    /// A block place holding whitespace at the beginning of current DOM children.
    static member inline beforeContainer (value: ReactElement) = Interop.mkProperty<IVirtualizerProp> "beforeContainer" value
    /// A block place holding whitespace at the beginning of current DOM children.
    static member inline beforeContainer (value: IReactProperty list) = Interop.mkProperty<IVirtualizerProp> "beforeContainer" (!!value |> createObj |> unbox<IReactProperty>)
    /// The intersection observed 'after' element will detect when scrolling towards the end.
    static member inline after (value: ReactElement) = Interop.mkProperty<IVirtualizerProp> "after" value
    /// The intersection observed 'after' element will detect when scrolling towards the end.
    static member inline after (value: IReactProperty list) = Interop.mkProperty<IVirtualizerProp> "after" (!!value |> createObj |> unbox<IReactProperty>)
    /// A block place holding whitespace after the end of current DOM children.
    static member inline afterContainer (value: ReactElement) = Interop.mkProperty<IVirtualizerProp> "afterContainer" value
    /// A block place holding whitespace after the end of current DOM children.
    static member inline afterContainer (value: IReactProperty list) = Interop.mkProperty<IVirtualizerProp> "afterContainer" (!!value |> createObj |> unbox<IReactProperty>)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: int -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerProp> "children" (System.Func<_,_,_> value)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: float -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerProp> "children" (System.Func<_,_,_> value)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: decimal -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerProp> "children" (System.Func<_,_,_> value)
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: int) = Interop.mkProperty<IVirtualizerProp> "itemSize" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: float) = Interop.mkProperty<IVirtualizerProp> "itemSize" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: decimal) = Interop.mkProperty<IVirtualizerProp> "itemSize" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: int) = Interop.mkProperty<IVirtualizerProp> "numItems" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: float) = Interop.mkProperty<IVirtualizerProp> "numItems" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: decimal) = Interop.mkProperty<IVirtualizerProp> "numItems" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport
    ///   and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: int) = Interop.mkProperty<IVirtualizerProp> "virtualizerLength" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport
    ///   and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: float) = Interop.mkProperty<IVirtualizerProp> "virtualizerLength" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport
    ///   and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: decimal) = Interop.mkProperty<IVirtualizerProp> "virtualizerLength" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: int) = Interop.mkProperty<IVirtualizerProp> "bufferItems" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: float) = Interop.mkProperty<IVirtualizerProp> "bufferItems" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: decimal) = Interop.mkProperty<IVirtualizerProp> "bufferItems" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: int) = Interop.mkProperty<IVirtualizerProp> "bufferSize" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: float) = Interop.mkProperty<IVirtualizerProp> "bufferSize" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: decimal) = Interop.mkProperty<IVirtualizerProp> "bufferSize" value
    /// Enables users to override the intersectionObserverRoot.
    static member inline scrollViewRef (value: MutableRefObject<HTMLElement option>) = Interop.mkProperty<IVirtualizerProp> "scrollViewRef" value
    /// Tells the virtualizer to measure in the reverse direction (for column-reverse order etc.)
    /// This value should be flipped in RTL implementation (TBD whether automate RTL).
    static member inline reversed (value: bool) = Interop.mkProperty<IVirtualizerProp> "reversed" value
    /// Callback for acquiring size of individual items
    /// @param index - the index of the requested size's child
    static member inline getItemSize (value: int -> int) = Interop.mkProperty<IVirtualizerProp> "getItemSize" (System.Func<_,_> value)
    /// Callback for acquiring size of individual items
    /// @param index - the index of the requested size's child
    static member inline getItemSize (value: float -> float) = Interop.mkProperty<IVirtualizerProp> "getItemSize" (System.Func<_,_> value)
    /// Callback for acquiring size of individual items
    /// @param index - the index of the requested size's child
    static member inline getItemSize (value: decimal -> decimal) = Interop.mkProperty<IVirtualizerProp> "getItemSize" (System.Func<_,_> value)
    /// Virtualizer context can be passed as a prop for extended class use
    static member inline virtualizerContext (value: VirtualizerContextProps) = Interop.mkProperty<IVirtualizerProp> "virtualizerContext" value
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: int -> unit) = Interop.mkProperty<IVirtualizerProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: float -> unit) = Interop.mkProperty<IVirtualizerProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: decimal -> unit) = Interop.mkProperty<IVirtualizerProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    static member inline flaggedIndex (value: MutableRefObject<int option>) = Interop.mkProperty<IVirtualizerProp> "flaggedIndex" value
    /// Imperative ref contains our scrollTo index functionality for user control.
    static member inline imperativeVirtualizerRef (value: RefObject<VirtualizerDataRef>) = Interop.mkProperty<IVirtualizerProp> "imperativeVirtualizerRef" value

module virtualizer =
    /// The scroll direction
    type [<Erase>] axis =
        static member inline vertical = Interop.mkProperty<IVirtualizerProp> "axis" "vertical"
        static member inline horizontal = Interop.mkProperty<IVirtualizerProp> "axis" "horizontal"

// -------------------------------------------------------------------------- VirtualizerScrollView --------------------------------------------------------------------------------------
type [<Erase>] virtualizerScrollView =
    inherit FelizProps.prop<IVirtualizerScrollViewProp>
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: int -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "children" (System.Func<_,_,_> value)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: float -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "children" (System.Func<_,_,_> value)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: decimal -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "children" (System.Func<_,_,_> value)
    /// The root container that provides embedded scrolling.
    static member inline container (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "container" value
    /// The root container that provides embedded scrolling.
    static member inline container (value: IReactProperty list) = Interop.mkProperty<IVirtualizerScrollViewProp> "container" (!!value |> createObj |> unbox<IReactProperty>)
    /// The intersection observed 'before' element will detect when scrolling towards the beginning.
    static member inline before (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "before" value
    /// A block place holding whitespace at the beginning of current DOM children.
    static member inline beforeContainer (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "beforeContainer" value
    /// The intersection observed 'after' element will detect when scrolling towards the end.
    static member inline after (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "after" value
    /// A block place holding whitespace after the end of current DOM children.
    static member inline afterContainer (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "afterContainer" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: int) = Interop.mkProperty<IVirtualizerScrollViewProp> "numItems" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: float) = Interop.mkProperty<IVirtualizerScrollViewProp> "numItems" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewProp> "numItems" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: int) = Interop.mkProperty<IVirtualizerScrollViewProp> "itemSize" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: float) = Interop.mkProperty<IVirtualizerScrollViewProp> "itemSize" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewProp> "itemSize" value
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline imperativeRef (value: RefObject<ScrollToInterface>) = Interop.mkProperty<IVirtualizerScrollViewProp> "itemSize" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport
    ///   and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: int) = Interop.mkProperty<IVirtualizerScrollViewProp> "virtualizerLength" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport
    ///   and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: float) = Interop.mkProperty<IVirtualizerScrollViewProp> "virtualizerLength" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport
    ///   and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewProp> "virtualizerLength" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: int) = Interop.mkProperty<IVirtualizerScrollViewProp> "bufferItems" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: float) = Interop.mkProperty<IVirtualizerScrollViewProp> "bufferItems" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewProp> "bufferItems" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: int) = Interop.mkProperty<IVirtualizerScrollViewProp> "bufferSize" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: float) = Interop.mkProperty<IVirtualizerScrollViewProp> "bufferSize" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewProp> "bufferSize" value
    /// Enables users to override the intersectionObserverRoot.
    static member inline scrollViewRef (value: MutableRefObject<HTMLElement option>) = Interop.mkProperty<IVirtualizerScrollViewProp> "scrollViewRef" value
    /// Tells the virtualizer to measure in the reverse direction (for column-reverse order etc.)
    /// This value should be flipped in RTL implementation (TBD whether automate RTL).
    static member inline reversed (value: bool) = Interop.mkProperty<IVirtualizerScrollViewProp> "reversed" value
    /// Virtualizer context can be passed as a prop for extended class use
    static member inline virtualizerContext (value: VirtualizerContextProps) = Interop.mkProperty<IVirtualizerScrollViewProp> "virtualizerContext" value
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: int -> unit) = Interop.mkProperty<IVirtualizerScrollViewProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: float -> unit) = Interop.mkProperty<IVirtualizerScrollViewProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: decimal -> unit) = Interop.mkProperty<IVirtualizerScrollViewProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)

module virtualizerScrollView =
    /// The scroll direction
    type [<Erase>] axis =
        static member inline vertical = Interop.mkProperty<IVirtualizerScrollViewProp> "axis" "vertical"
        static member inline horizontal = Interop.mkProperty<IVirtualizerScrollViewProp> "axis" "horizontal"

// -------------------------------------------------------------------------- VirtualizerScrollViewDynamic --------------------------------------------------------------------------------------
type [<Erase>] virtualizerScrollViewDynamic =
    inherit FelizProps.prop<IVirtualizerScrollViewDynamicProp>
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: int -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "children" (System.Func<_,_,_> value)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: float -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "children" (System.Func<_,_,_> value)
    /// Child render function.
    /// Iteratively called to return current virtualizer DOM children.
    /// Will act as a row or column indexer depending on Virtualizer settings.
    /// Can be used dynamically.
    static member inline children (value: decimal -> bool -> ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "children" (System.Func<_,_,_> value)
    /// The root container that provides embedded scrolling.
    static member inline container (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "container" value
    /// The root container that provides embedded scrolling.
    static member inline container (value: IReactProperty list) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "container" (!!value |> createObj |> unbox<IReactProperty>)
    /// The intersection observed 'before' element will detect when scrolling towards the beginning.
    static member inline before (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "before" value
    /// A block place holding whitespace at the beginning of current DOM children.
    static member inline beforeContainer (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "beforeContainer" value
    /// The intersection observed 'after' element will detect when scrolling towards the end.
    static member inline after (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "after" value
    /// A block place holding whitespace after the end of current DOM children.
    static member inline afterContainer (value: ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "afterContainer" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: int) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "numItems" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: float) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "numItems" value
    /// The total number of items to be virtualized.
    static member inline numItems (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "numItems" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: int) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "itemSize" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: float) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "itemSize" value
    /// Default cell size to use if no custom callback provided.
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline itemSize (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "itemSize" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: int) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "virtualizerLength" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: float) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "virtualizerLength" value
    /// Number of children to render in the DOM during virtualization.
    /// Constraints:
    /// - Large enough that the items rendered in DOM cover the viewport and intersection observer buffers (buffersize) at both ends.
    static member inline virtualizerLength (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "virtualizerLength" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: int) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "bufferItems" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: float) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "bufferItems" value
    /// Defaults to 1/4th of virtualizerLength.
    /// Controls the number of elements rendered before the current index entering the virtualized viewport.
    /// Constraints:
    /// - Large enough to cover bufferSize (prevents buffers intersecting into the viewport during rest state).
    /// - Small enough that the end buffer and end index (start index + virtualizerLength) is not within viewport at rest.
    static member inline bufferItems (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "bufferItems" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: int) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "bufferSize" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: float) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "bufferSize" value
    /// Defaults to half of bufferItems size (in pixels).
    /// The length (in pixels) before the end/start DOM index where the virtualizer recalculation will be triggered.
    /// Increasing this reduces whitespace on ultra-fast scroll, as additional elements
    /// are buffered to appear while virtualization recalculates.
    /// Constraints:
    /// - At least 1px - although this will only trigger the recalculation after bookends (whitespace) enter viewport.
    /// - BufferSize must be smaller than bufferItems pixel size, as it prevents bookends entering viewport at rest.
    static member inline bufferSize (value: decimal) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "bufferSize" value
    /// If implementing `getItemSize` this should be the initial and ideally minimum cell size.
    static member inline imperativeRef (value: RefObject<ScrollToInterface>) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "itemSize" value
    /// Callback for acquiring size of individual items
    /// @param index - the index of the requested size's child
    static member inline getItemSize (value: int -> int) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "getItemSize" (System.Func<_,_> value)
    /// Callback for acquiring size of individual items
    /// @param index - the index of the requested size's child
    static member inline getItemSize (value: float -> float) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "getItemSize" (System.Func<_,_> value)
    /// Callback for acquiring size of individual items
    /// @param index - the index of the requested size's child
    static member inline getItemSize (value: decimal -> decimal) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "getItemSize" (System.Func<_,_> value)
    /// Enables users to override the intersectionObserverRoot.
    static member inline scrollViewRef (value: MutableRefObject<HTMLElement option>) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "scrollViewRef" value
    /// Tells the virtualizer to measure in the reverse direction (for column-reverse order etc.)
    /// This value should be flipped in RTL implementation (TBD whether automate RTL).
    static member inline reversed (value: bool) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "reversed" value
    /// Virtualizer context can be passed as a prop for extended class use
    static member inline virtualizerContext (value: VirtualizerContextProps) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "virtualizerContext" value
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: int -> unit) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: float -> unit) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: decimal -> unit) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Imperative ref contains our scrollTo index functionality for user control.
    static member inline imperativeVirtualizerRef (value: RefObject<VirtualizerDataRef>) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "imperativeVirtualizerRef" value

module virtualizerScrollViewDynamic =
    /// The scroll direction
    type [<Erase>] axis =
        static member inline vertical = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "axis" "vertical"
        static member inline horizontal = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "axis" "horizontal"

// -------------------------------------------------------------------------- Drawer --------------------------------------------------------------------------------------
type [<Erase>] drawer =
    inherit FelizProps.prop<IDrawerProp>
    static member inline root (value: IDrawerOverlayProp list) = Interop.mkProperty<IDrawerProp> "root" (!!value |> createObj |> unbox<IDrawerOverlayProp>)
    static member inline root (value: IDrawerInlineProp list) = Interop.mkProperty<IDrawerProp> "root" (!!value |> createObj |> unbox<IDrawerInlineProp>)
    /// Controls the open state of the Drawer
    static member inline open' (value: bool) = Interop.mkProperty<IDrawerProp> "open" value
    /// Default value for the uncontrolled open state of the Drawer.
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDrawerProp> "defaultOpen" value
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<IDrawerProp> "inertTrapFocus" value
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling. This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: ReactElement) = Interop.mkProperty<IDrawerProp> "backdrop" value //TODO
    /// Whether the drawer has a separator line.
    static member inline separator (value: bool) = Interop.mkProperty<IDrawerProp> "separator" value
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IDrawerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IDrawerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: MouseEvent -> DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IDrawerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: KeyboardEvent -> DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IDrawerProp> "onOpenChange" (System.Func<_,_,_> value)

module drawer =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDrawerProp> "as" "div"

    /// Type of the drawer.
    type [<Erase>] type' =
        static member inline inline' = Interop.mkProperty<IDrawerProp> "type" "inline"
        static member inline overlay = Interop.mkProperty<IDrawerProp> "type" "overlay"

    /// Position of the drawer.
    type [<Erase>] position =
        static member inline left = Interop.mkProperty<IDrawerProp> "position" "left"
        static member inline right = Interop.mkProperty<IDrawerProp> "position" "right"

    /// Size of the drawer.
    type [<Erase>] size =
        /// Drawer is 320px wide.
        static member inline small = Interop.mkProperty<IDrawerProp> "size" "small"
        /// Drawer is 592px wide.
        static member inline medium = Interop.mkProperty<IDrawerProp> "size" "medium"
        /// Drawer is 940px wide.
        static member inline large = Interop.mkProperty<IDrawerProp> "size" "large"
        /// Drawer is 100vw wide.
        static member inline full = Interop.mkProperty<IDrawerProp> "size" "full"

    /// Dialog variations.
    type [<Erase>] modalType =
        /// A special type of modal dialogs that interrupts the user's workflow to communicate an important message or ask for a decision. Unlike a typical modal dialog, the user must take an action through the options given to dismiss the dialog, and it cannot be dismissed through the dimmed background or escape key.
        static member inline alert = Interop.mkProperty<IDrawerProp> "modalType" "alert"
        /// When this type of dialog is open, the rest of the page is dimmed out and cannot be interacted with. The tab sequence is kept within the dialog and moving the focus outside the dialog will imply closing it. This is the default type of the component.
        static member inline modal = Interop.mkProperty<IDrawerProp> "modalType" "modal"
        /// When a non-modal dialog is open, the rest of the page is not dimmed out and users can interact with the rest of the page. This also implies that the tab focus can move outside the dialog when it reaches the last focusable element.
        static member inline nonModal = Interop.mkProperty<IDrawerProp> "modalType" "non-modal"

// -------------------------------------------------------------------------- DrawerOverlay --------------------------------------------------------------------------------------
type [<Erase>] drawerOverlay =
    inherit FelizProps.prop<IDrawerOverlayProp>
    static member inline root (value: IDialogSurfaceProp list) = Interop.mkProperty<IDrawerOverlayProp> "root" (!!value |> createObj |> unbox<IDialogSurfaceProp>)
    /// Controls the open state of the Drawer
    static member inline open' (value: bool) = Interop.mkProperty<IDrawerOverlayProp> "open" value
    /// Default value for the uncontrolled open state of the Drawer.
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDrawerOverlayProp> "defaultOpen" value
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<IDrawerOverlayProp> "inertTrapFocus" value
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling. This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: ReactElement) = Interop.mkProperty<IDrawerOverlayProp> "backdrop" value //TODO
    /// Whether the drawer has a separator line.
    static member inline separator (value: bool) = Interop.mkProperty<IDrawerOverlayProp> "separator" value
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IDrawerOverlayProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IDrawerOverlayProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: MouseEvent -> DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IDrawerOverlayProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: KeyboardEvent -> DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IDrawerOverlayProp> "onOpenChange" (System.Func<_,_,_> value)

module drawerOverlay =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDrawerOverlayProp> "as" "div"

    /// Type of the drawer.
    type [<Erase>] type' =
        static member inline inline' = Interop.mkProperty<IDrawerOverlayProp> "type" "inline"
        static member inline overlay = Interop.mkProperty<IDrawerOverlayProp> "type" "overlay"

    /// Position of the drawer.
    type [<Erase>] position =
        static member inline left = Interop.mkProperty<IDrawerOverlayProp> "position" "left"
        static member inline right = Interop.mkProperty<IDrawerOverlayProp> "position" "right"

    /// Size of the drawer.
    type [<Erase>] size =
        /// Drawer is 320px wide.
        static member inline small = Interop.mkProperty<IDrawerOverlayProp> "size" "small"
        /// Drawer is 592px wide.
        static member inline medium = Interop.mkProperty<IDrawerOverlayProp> "size" "medium"
        /// Drawer is 940px wide.
        static member inline large = Interop.mkProperty<IDrawerOverlayProp> "size" "large"
        /// Drawer is 100vw wide.
        static member inline full = Interop.mkProperty<IDrawerOverlayProp> "size" "full"

    /// Dialog variations.
    type [<Erase>] modalType =
        /// A special type of modal dialogs that interrupts the user's workflow to communicate an important message or ask for a decision. Unlike a typical modal dialog, the user must take an action through the options given to dismiss the dialog, and it cannot be dismissed through the dimmed background or escape key.
        static member inline alert = Interop.mkProperty<IDrawerOverlayProp> "modalType" "alert"
        /// When this type of dialog is open, the rest of the page is dimmed out and cannot be interacted with. The tab sequence is kept within the dialog and moving the focus outside the dialog will imply closing it. This is the default type of the component.
        static member inline modal = Interop.mkProperty<IDrawerOverlayProp> "modalType" "modal"
        /// When a non-modal dialog is open, the rest of the page is not dimmed out and users can interact with the rest of the page. This also implies that the tab focus can move outside the dialog when it reaches the last focusable element.
        static member inline nonModal = Interop.mkProperty<IDrawerOverlayProp> "modalType" "non-modal"

// -------------------------------------------------------------------------- DrawerInline --------------------------------------------------------------------------------------
type [<Erase>] drawerInline =
    inherit FelizProps.prop<IDrawerInlineProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDrawerInlineProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Controls the open state of the Drawer
    static member inline open' (value: bool) = Interop.mkProperty<IDrawerInlineProp> "open" value
    /// Default value for the uncontrolled open state of the Drawer.
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDrawerInlineProp> "defaultOpen" value
    /// Whether the drawer has a separator line.
    static member inline separator (value: bool) = Interop.mkProperty<IDrawerInlineProp> "separator" value

module drawerInline =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDrawerInlineProp> "as" "div"

    /// Type of the drawer.
    type [<Erase>] type' =
        static member inline inline' = Interop.mkProperty<IDrawerInlineProp> "type" "inline"
        static member inline overlay = Interop.mkProperty<IDrawerInlineProp> "type" "overlay"

    /// Position of the drawer.
    type [<Erase>] position =
        static member inline left = Interop.mkProperty<IDrawerInlineProp> "position" "left"
        static member inline right = Interop.mkProperty<IDrawerInlineProp> "position" "right"

    /// Size of the drawer.
    type [<Erase>] size =
        /// Drawer is 320px wide.
        static member inline small = Interop.mkProperty<IDrawerInlineProp> "size" "small"
        /// Drawer is 592px wide.
        static member inline medium = Interop.mkProperty<IDrawerInlineProp> "size" "medium"
        /// Drawer is 940px wide.
        static member inline large = Interop.mkProperty<IDrawerInlineProp> "size" "large"
        /// Drawer is 100vw wide.
        static member inline full = Interop.mkProperty<IDrawerInlineProp> "size" "full"

// -------------------------------------------------------------------------- DrawerHeader --------------------------------------------------------------------------------------
type [<Erase>] drawerHeader =
    inherit FelizProps.prop<IDrawerHeaderProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDrawerHeaderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module drawerHeader =

    type [<Erase>] as' =
        static member inline header = Interop.mkProperty<IDrawerHeaderProp> "as" "header"

// -------------------------------------------------------------------------- DrawerHeaderTitle --------------------------------------------------------------------------------------
type [<Erase>] drawerHeaderTitle =
    inherit FelizProps.prop<IDrawerHeaderTitleProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDrawerHeaderTitleProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// By default this is a h2, but can be any heading or div. If div is provided do not forget to also provide proper role="heading" and aria-level attributes
    static member inline heading (value: string) = Interop.mkProperty<IDrawerHeaderTitleProp> "heading" value
    /// By default this is a h2, but can be any heading or div. If div is provided do not forget to also provide proper role="heading" and aria-level attributes
    static member inline heading (value: ReactElement) = Interop.mkProperty<IDrawerHeaderTitleProp> "heading" value
    /// By default this is a h2, but can be any heading or div. If div is provided do not forget to also provide proper role="heading" and aria-level attributes
    static member inline heading (value: IReactProperty list) = Interop.mkProperty<IDrawerHeaderTitleProp> "heading" (!!value |> createObj |> unbox<IReactProperty>)
    /// Action slot for the close button
    static member inline action (value: ReactElement) = Interop.mkProperty<IDrawerHeaderTitleProp> "action" value
    /// Action slot for the close button
    static member inline action (value: IReactProperty list) = Interop.mkProperty<IDrawerHeaderTitleProp> "action" (!!value |> createObj |> unbox<IReactProperty>)

module drawerHeaderTitle =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDrawerHeaderTitleProp> "as" "div"

// -------------------------------------------------------------------------- DrawerHeaderNavigation --------------------------------------------------------------------------------------
type [<Erase>] drawerHeaderNavigation = FelizProps.prop<IDrawerHeaderNavigationProp>

module drawerHeaderNavigation =

    type [<Erase>] as' =
        static member inline nav = Interop.mkProperty<IDrawerHeaderNavigationProp> "as" "nav"

// -------------------------------------------------------------------------- DrawerBody --------------------------------------------------------------------------------------
type [<Erase>] drawerBody = FelizProps.prop<IDrawerBodyProp>

module drawerBody =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDrawerBodyProp> "as" "div"

// -------------------------------------------------------------------------- Tree --------------------------------------------------------------------------------------
type [<Erase>] tree =
    inherit FelizProps.prop<ITreeProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<ITreeProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// This refers to a list of ids of opened tree items. Controls the state of the open tree items. These property is ignored for subtrees.
    static member inline openItems (value: #seq<'T>)= Interop.mkProperty<ITreeProp> "openItems" value

    /// This refers to a list of ids of default opened items. This property is ignored for subtrees.
    static member inline defaultOpenItems (value: #seq<'T>)= Interop.mkProperty<ITreeProp> "defaultOpenItems" value
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onOpenChange (handler: TreeOpenChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onOpenChange (value: 'TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onNavigation (handler: TreeNavigationData_unstable<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeProp> "onNavigation" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onNavigation (value: 'TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeProp> "onNavigation" (System.Func<_,_,_> value)
    /// This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state. Controls the state of the checked tree items. These property is ignored for subtrees.
    static member inline checkedItems (value: #seq<'T>)= Interop.mkProperty<ITreeProp> "checkedItems" value
    /// Callback fired when the component changes value from checked state. These property is ignored for subtrees.
    static member inline onCheckedChange (handler: TreeCheckedChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeProp> "onCheckedChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from checked state. These property is ignored for subtrees.
    static member inline onCheckedChange (value: 'TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeProp> "onCheckedChange" (System.Func<_,_,_> value)

module tree =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITreeProp> "as" "div"

    type [<Erase>] appearance =
        /// The default tree item styles.
        static member inline subtle = Interop.mkProperty<ITreeProp> "appearance" "subtle"
        /// Removes background color.
        static member inline transparent = Interop.mkProperty<ITreeProp> "appearance" "transparent"
        /// Minimizes emphasis on hovered or focused states.
        static member inline subtleAlpha = Interop.mkProperty<ITreeProp> "appearance" "subtle-alpha"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITreeProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITreeProp> "size" "medium"

    /// This refers to the selection mode of the tree.
    type [<Erase>] selectionMode =
        /// No selection can be done.
        static member inline none = Interop.mkProperty<ITreeProp> "selectionMode" "undefined"
        /// Multiple tree items can be selected, checkboxes are rendered.
        static member inline multiselect = Interop.mkProperty<ITreeProp> "selectionMode" "multiselect"
        /// Only one tree item can be selected, radio buttons are rendered.
        static member inline single = Interop.mkProperty<ITreeProp> "selectionMode" "single"


// -------------------------------------------------------------------------- FlatTree --------------------------------------------------------------------------------------
type [<Erase>] flatTree =
    inherit FelizProps.prop<IFlatTreeProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IFlatTreeProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// This refers to a list of ids of opened tree items. Controls the state of the open tree items. These property is ignored for subtrees.
    static member inline openItems (value: #seq<'T>)= Interop.mkProperty<IFlatTreeProp> "openItems" value
    static member inline selectionMode (value: string)= Interop.mkProperty<IFlatTreeProp> "selectionMode" value
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onOpenChange (handler: TreeOpenChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<IFlatTreeProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onOpenChange (value: 'TEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<IFlatTreeProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onNavigation (handler: TreeNavigationData_unstable<'T, 'TEvent> -> unit)= Interop.mkProperty<IFlatTreeProp> "onNavigation" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    /// These property is ignored for subtrees.
    static member inline onNavigation (value: 'TEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit)= Interop.mkProperty<IFlatTreeProp> "onNavigation" (System.Func<_,_,_> value)
    /// This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state. Controls the state of the checked tree items. These property is ignored for subtrees.
    static member inline checkedItems (value: #seq<'T>)= Interop.mkProperty<IFlatTreeProp> "checkedItems" value
    /// Callback fired when the component changes value from checked state. These property is ignored for subtrees.
    static member inline onCheckedChange (handler: TreeCheckedChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<IFlatTreeProp> "onCheckedChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from checked state. These property is ignored for subtrees.
    static member inline onCheckedChange (value: 'TEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<IFlatTreeProp> "onCheckedChange" (System.Func<_,_,_> value)
module flatTree =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IFlatTreeProp> "as" "div"

    type [<Erase>] appearance =
        /// The default tree item styles.
        static member inline subtle = Interop.mkProperty<IFlatTreeProp> "appearance" "subtle"
        /// Removes background color.
        static member inline transparent = Interop.mkProperty<IFlatTreeProp> "appearance" "transparent"
        /// Minimizes emphasis on hovered or focused states.
        static member inline subtleAlpha = Interop.mkProperty<IFlatTreeProp> "appearance" "subtle-alpha"

    type [<Erase>] size =

        static member inline small = Interop.mkProperty<IFlatTreeProp> "size" "small"
        static member inline medium = Interop.mkProperty<IFlatTreeProp> "size" "medium"

    /// This refers to the selection mode of the tree.
    type [<Erase>] selectionMode =
        /// No selection can be done.
        static member inline none = Interop.mkProperty<IFlatTreeProp> "selectionMode" "undefined"
        /// Multiple tree items can be selected, checkboxes are rendered.
        static member inline multiselect = Interop.mkProperty<IFlatTreeProp> "selectionMode" "multiselect"
        /// Only one tree item can be selected, radio buttons are rendered.
        static member inline single = Interop.mkProperty<IFlatTreeProp> "selectionMode" "single"

    let getProps (options: HeadlessFlatTreeOptions<'T, 'TEvent>) =

        let selectionMode =
            match options.selectionMode with
            | "multiselect" -> selectionMode.multiselect
            | "single" -> selectionMode.single
            | _ -> selectionMode.none

        [
            flatTree.onOpenChange options.onOpenChange
            flatTree.onNavigation options.onNavigation
            selectionMode
            flatTree.onCheckedChange options.onCheckedChange
            flatTree.openItems options.openItems
            flatTree.checkedItems options.checkedItems
        ]
// -------------------------------------------------------------------------- TreeItem --------------------------------------------------------------------------------------
type [<Erase>] treeItem =
    inherit FelizProps.prop<ITreeItemProp>
    static member inline itemType (value: TreeItemType)= Interop.mkProperty<ITreeItemProp> "itemType" value
    static member inline value (value: string)= Interop.mkProperty<ITreeItemProp> "value" value
    static member inline parentValue (value: string option)= Interop.mkProperty<ITreeItemProp> "parentValue" value

module treeItem =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<ITreeItemProp> "as" "div"

    /// A tree item can be a leaf or a branch
    type [<Erase>] itemType =
        static member inline leaf = Interop.mkProperty<ITreeItemProp> "itemType" "leaf"
        static member inline branch = Interop.mkProperty<ITreeItemProp> "itemType" "branch"

    let getProps (options: HeadlessTreeItemProps<string>) = [
        treeItem.value options.value
        treeItem.itemType options.itemType
        treeItem.parentValue options.parentValue
        treeItem.ariaLevel options.``aria-level``
        treeItem.ariaSetSize options.``aria-setsize``
        treeItem.ariaPosInSet options.``aria-posinset``
    ]


// -------------------------------------------------------------------------- TreeItemLayout --------------------------------------------------------------------------------------
type [<Erase>] treeItemLayout =
    inherit FelizProps.prop<ITreeItemLayoutProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Content. Children of the root slot are automatically rendered here
    static member inline main (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "main" value
    /// Content. Children of the root slot are automatically rendered here
    static member inline main (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "main" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon slot that renders right before main content
    static member inline iconBefore (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "iconBefore" value
    /// Icon slot that renders right before main content
    static member inline iconBefore (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "iconBefore" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon slot that renders right after main content
    static member inline iconAfter (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "iconAfter" value
    /// Icon slot that renders right after main content
    static member inline iconAfter (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "iconAfter" (!!value |> createObj |> unbox<IReactProperty>)
    /// Expand icon slot, by default renders a chevron icon to indicate opening and closing
    static member inline expandIcon (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "expandIcon" value
    /// Expand icon slot, by default renders a chevron icon to indicate opening and closing
    static member inline expandIcon (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "expandIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Aside content is normally used to render a badge or other non-actionable content
    /// It is aria-hidden by default and is only meant to be used as visual aid.
    static member inline aside (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "aside" value
    /// Aside content is normally used to render a badge or other non-actionable content
    /// It is aria-hidden by default and is only meant to be used as visual aid.
    static member inline aside (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "aside" (!!value |> createObj |> unbox<IReactProperty>)
    /// Actionable elements are normally buttons, menus, or other focusable elements.
    /// Those elements are only visibly available if the given tree item is currently active.
    /// `actions` and `aside` slots are positioned on the exact same spot,
    /// so they won't be visible at the same time.
    /// `aside` slot is visible by default meanwhile `actions` slot are only visible when the tree item is active.
    /// `actions` slot supports a `visible` prop to force visibility of the actions.
    static member inline actions (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "actions" value
    /// Actionable elements are normally buttons, menus, or other focusable elements.
    /// Those elements are only visibly available if the given tree item is currently active.
    /// `actions` and `aside` slots are positioned on the exact same spot,
    /// so they won't be visible at the same time.
    /// `aside` slot is visible by default meanwhile `actions` slot are only visible when the tree item is active.
    /// `actions` slot supports a `visible` prop to force visibility of the actions.
    static member inline actions (value: IReactProperty list)= Interop.mkProperty<ITreeItemLayoutProp> "actions" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline selector (value: ReactElement)= Interop.mkProperty<ITreeItemLayoutProp> "selector" value
    static member inline selector (value: ICheckboxProp list)= Interop.mkProperty<ITreeItemLayoutProp> "selector" (!!value |> createObj |> unbox<ICheckboxProp>)
    static member inline selector (value: IRadioProp list)= Interop.mkProperty<ITreeItemLayoutProp> "selector" (!!value |> createObj |> unbox<IRadioProp>)

module treeItemLayout =

    type [<Erase>] actions =
        static member inline visible (value: bool)= Interop.mkProperty<ITreeItemLayoutProp> "visible" value

// -------------------------------------------------------------------------- TreeItemPersonaLayout --------------------------------------------------------------------------------------
type [<Erase>] treeItemPersonaLayout =
    inherit FelizProps.prop<ITreeItemPersonaLayoutProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Content. Children of the root slot are automatically rendered here
    static member inline main (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "main" value
    /// Content. Children of the root slot are automatically rendered here
    static member inline main (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "main" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon slot that renders right before main content
    static member inline media (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "media" value
    /// Icon slot that renders right before main content
    static member inline media (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "media" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon slot that renders right after main content
    static member inline description (value: string)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "description" value
    /// Icon slot that renders right after main content
    static member inline description (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "description" value
    /// Icon slot that renders right after main content
    static member inline description (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "description" (!!value |> createObj |> unbox<IReactProperty>)
    /// Expand icon slot, by default renders a chevron icon to indicate opening and closing
    static member inline expandIcon (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "expandIcon" value
    /// Expand icon slot, by default renders a chevron icon to indicate opening and closing
    static member inline expandIcon (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "expandIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Aside content is normally used to render a badge or other non-actionable content
    /// It is aria-hidden by default and is only meant to be used as visual aid.
    static member inline aside (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "aside" value
    /// Aside content is normally used to render a badge or other non-actionable content
    /// It is aria-hidden by default and is only meant to be used as visual aid.
    static member inline aside (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "aside" (!!value |> createObj |> unbox<IReactProperty>)
    /// Actionable elements are normally buttons, menus, or other focusable elements.
    /// Those elements are only visibly available if the given tree item is currently active.
    /// `actions` and `aside` slots are positioned on the exact same spot,
    /// so they won't be visible at the same time.
    /// `aside` slot is visible by default meanwhile `actions` slot are only visible when the tree item is active.
    /// `actions` slot supports a `visible` prop to force visibility of the actions.
    static member inline actions (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "actions" value
    /// Actionable elements are normally buttons, menus, or other focusable elements.
    /// Those elements are only visibly available if the given tree item is currently active.
    /// `actions` and `aside` slots are positioned on the exact same spot,
    /// so they won't be visible at the same time.
    /// `aside` slot is visible by default meanwhile `actions` slot are only visible when the tree item is active.
    /// `actions` slot supports a `visible` prop to force visibility of the actions.
    static member inline actions (value: IReactProperty list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "actions" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline selector (value: ReactElement)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "selector" value
    static member inline selector (value: ICheckboxProp list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "selector" (!!value |> createObj |> unbox<ICheckboxProp>)
    static member inline selector (value: IRadioProp list)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "selector" (!!value |> createObj |> unbox<IRadioProp>)

module treeItemPersonaLayout =

    type [<Erase>] actions =
        static member inline visible (value: bool)= Interop.mkProperty<ITreeItemPersonaLayoutProp> "visible" value

// -------------------------------------------------------------------------- Positioning --------------------------------------------------------------------------------------

type [<Erase>] positioning =
    /// An imperative handle to Popper methods.
    static member inline positioningRef (value: IRefValue<PositioningImperativeRef>) = Interop.mkProperty<IPositioningProp> "positioningRef" value
    /// Manual override for the target element. Useful for scenarios where a component accepts user prop to override target
    static member inline target (value: Element option) = Interop.mkProperty<IPositioningProp> "target" value
    /// Lets you displace a positioned element from its reference element.
    /// This can be useful if you need to apply some margin between them or if you need to fine tune the
    /// position according to some custom logic.
    static member inline offset (value: OffsetObject) = Interop.mkProperty<IPositioningProp> "offset" value
    /// Lets you displace a positioned element from its reference element.
    /// This can be useful if you need to apply some margin between them or if you need to fine tune the
    /// position according to some custom logic.
    static member inline offset (value: int) = Interop.mkProperty<IPositioningProp> "offset" value
    /// Lets you displace a positioned element from its reference element.
    /// This can be useful if you need to apply some margin between them or if you need to fine tune the
    /// position according to some custom logic.
    static member inline offset (value: float) = Interop.mkProperty<IPositioningProp> "offset" value
    /// Lets you displace a positioned element from its reference element.
    /// This can be useful if you need to apply some margin between them or if you need to fine tune the
    /// position according to some custom logic.
    static member inline offset (value: decimal) = Interop.mkProperty<IPositioningProp> "offset" value
    /// The element which will define the boundaries of the positioned element for the flip behavior.
    static member inline flipBoundary (value: Element option) = Interop.mkProperty<IPositioningProp> "flipBoundary" value
    /// The element which will define the boundaries of the positioned element for the flip behavior.
    static member inline flipBoundary (value: (Element array) option) = Interop.mkProperty<IPositioningProp> "flipBoundary" value
    /// The element which will define the boundaries of the positioned element for the overflow behavior.
    static member inline overflowBoundary (value: Element option) = Interop.mkProperty<IPositioningProp> "overflowBoundary" value
    /// The element which will define the boundaries of the positioned element for the overflow behavior.
    static member inline overflowBoundary (value: (Element array) option) = Interop.mkProperty<IPositioningProp> "overflowBoundary" value
    /// Applies a padding to the overflow bounadry, so that overflow is detected earlier before the
    /// positioned surface hits the overflow boundary.
    static member inline overflowBoundaryPadding (value: OverflowBoundaryPadding) = Interop.mkProperty<IPositioningProp> "overflowBoundaryPadding" value
    /// Applies a padding to the overflow bounadry, so that overflow is detected earlier before the
    /// positioned surface hits the overflow boundary.
    static member inline overflowBoundaryPadding (value: int) = Interop.mkProperty<IPositioningProp> "overflowBoundaryPadding" value
    /// Applies a padding to the overflow bounadry, so that overflow is detected earlier before the
    /// positioned surface hits the overflow boundary.
    static member inline overflowBoundaryPadding (value: float) = Interop.mkProperty<IPositioningProp> "overflowBoundaryPadding" value
    /// Applies a padding to the overflow bounadry, so that overflow is detected earlier before the
    /// positioned surface hits the overflow boundary.
    static member inline overflowBoundaryPadding (value: decimal) = Interop.mkProperty<IPositioningProp> "overflowBoundaryPadding" value
    /// Enables the position element to be positioned with 'fixed' (default value is position: 'absolute')
    static member inline positionFixed (value: bool) = Interop.mkProperty<IPositioningProp> "positionFixed" value
    /// Defines padding between the corner of the popup element and the arrow.
    /// Use to prevent the arrow from overlapping a rounded corner, for example.
    static member inline arrowPadding (value: int) = Interop.mkProperty<IPositioningProp> "arrowPadding" value
    /// Defines padding between the corner of the popup element and the arrow.
    /// Use to prevent the arrow from overlapping a rounded corner, for example.
    static member inline arrowPadding (value: float) = Interop.mkProperty<IPositioningProp> "arrowPadding" value
    /// Defines padding between the corner of the popup element and the arrow.
    /// Use to prevent the arrow from overlapping a rounded corner, for example.
    static member inline arrowPadding (value: decimal) = Interop.mkProperty<IPositioningProp> "arrowPadding" value
    /// Modifies position and alignment to cover the target
    static member inline coverTarget (value: bool) = Interop.mkProperty<IPositioningProp> "coverTarget" value
    /// Disables automatic repositioning of the component; it will always be placed according to the values of `align` and
    /// `position` props, regardless of the size of the component, the reference element or the viewport.
    static member inline pinned (value: bool) = Interop.mkProperty<IPositioningProp> "pinned" value
    /// Modifies whether popover is positioned using transform.
    static member inline useTransform (value: bool) = Interop.mkProperty<IPositioningProp> "useTransform" value
    static member inline unstable_disableTether (value: bool) = Interop.mkProperty<IPositioningProp> "unstable_disableTether" value
    static member inline autoSize (value: bool) = Interop.mkProperty<IPositioningProp> "autoSize" value

module positioning =
    type [<Erase>] position =
        static member inline above = Interop.mkProperty<IPositioningProp> "position" "above"
        static member inline below = Interop.mkProperty<IPositioningProp> "position" "below"
        static member inline before = Interop.mkProperty<IPositioningProp> "position" "before"
        static member inline after = Interop.mkProperty<IPositioningProp> "position" "after"

    type [<Erase>] align =
        /// Alignment for the component. Only has an effect if used with the position option
        static member inline top = Interop.mkProperty<IPositioningProp> "align" "top"
        /// Alignment for the component. Only has an effect if used with the position option
        static member inline bottom = Interop.mkProperty<IPositioningProp> "align" "bottom"
        /// Alignment for the component. Only has an effect if used with the position option
        static member inline start = Interop.mkProperty<IPositioningProp> "align" "start"
        /// Alignment for the component. Only has an effect if used with the position option
        static member inline end' = Interop.mkProperty<IPositioningProp> "align" "end"
        /// Alignment for the component. Only has an effect if used with the position option
        static member inline center = Interop.mkProperty<IPositioningProp> "align" "center"

    /// Specifies the type of CSS position property to use.
    type [<Erase>] strategy =
        static member inline absolute = Interop.mkProperty<IPositioningProp> "strategy" "absolute"
        static member inline fixed' = Interop.mkProperty<IPositioningProp> "strategy" "fixed"

    /// Applies styles on the positioned element to fit it within the available space in viewport.
    /// Note that options 'always'/'height-always'/'width-always' are now obsolete, and equivalent to true/'height'/'width'.
    type [<Erase>] autoSize =
        /// Set styles for max height.
        static member inline height = Interop.mkProperty<IPositioningProp> "autoSize" "height"
        /// Set styles for max width.
        static member inline width = Interop.mkProperty<IPositioningProp> "autoSize" "width"
        [<Obsolete>] static member inline heightAlways = Interop.mkProperty<IPositioningProp> "autoSize" "height-always"
        [<Obsolete>] static member inline widthAlways = Interop.mkProperty<IPositioningProp> "autoSize" "width-always"
        [<Obsolete>] static member inline always = Interop.mkProperty<IPositioningProp> "autoSize" "always"

    type [<Erase>] unstable_disableTether =
        static member inline all = Interop.mkProperty<IPositioningProp> "unstable_disableTether" "all"

// -------------------------------------------------------------------------- CreateTableColumnOption --------------------------------------------------------------------------------------

type [<Erase>] createTableColumnOption =
    static member inline columnId (value: string) = Interop.mkProperty<ICreateTableColumnOptionProp> "columnId" value
    static member inline columnId (value: int) = Interop.mkProperty<ICreateTableColumnOptionProp> "columnId" value
    static member inline columnId (value: float) = Interop.mkProperty<ICreateTableColumnOptionProp> "columnId" value
    static member inline columnId (value: decimal) = Interop.mkProperty<ICreateTableColumnOptionProp> "columnId" value
    static member inline renderCell (value: 'T -> ReactElement) = Interop.mkProperty<ICreateTableColumnOptionProp> "renderCell" (System.Func<_,_> value)
    static member inline renderCell (value: 'T -> string) = Interop.mkProperty<ICreateTableColumnOptionProp> "renderCell" (System.Func<_,_> value)
    static member inline renderHeaderCell (value: unit -> ReactElement) = Interop.mkProperty<ICreateTableColumnOptionProp> "renderHeaderCell" (System.Func<_,_> value)
    static member inline renderHeaderCell (value: unit -> string) = Interop.mkProperty<ICreateTableColumnOptionProp> "renderHeaderCell" (System.Func<_,_> value)
    static member inline compare (value: 'T -> 'T -> int) = Interop.mkProperty<ICreateTableColumnOptionProp> "compare" (System.Func<_,_,_> value)
    static member inline compare (value: 'T -> 'T -> float) = Interop.mkProperty<ICreateTableColumnOptionProp> "compare" (System.Func<_,_,_> value)
    static member inline compare (value: 'T -> 'T -> decimal) = Interop.mkProperty<ICreateTableColumnOptionProp> "compare" (System.Func<_,_,_> value)


// -------------------------------------------------------------------------- UseArrowNavigationGroupOptions --------------------------------------------------------------------------------------

type [<Erase>] useArrowNavigationGroupOptions =
    /// Focus will cycle to the first/last elements of the group without stopping
    static member inline circular (value: bool) = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "circular" value
    /// Last focused element in the group will be remembered and focused (if still available) when tabbing from outside of the group
    static member inline memorizeCurrent (value: bool) = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "memorizeCurrent" value
    /// Allow tabbing within the arrow navigation group items.
    static member inline tabbable (value: bool) = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "tabbable" value
    /// Tabster should ignore default handling of keydown events
    static member inline ignoreDefaultKeydown (value: IgnoreKeyDown) = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "ignoreDefaultKeydown" value
    /// The default focusable item in the group will be an element with Focusable.isDefault property.
    /// Note that there is no way in \@fluentui/react-tabster to set default focusable element, and this option is currently for internal testing purposes only.
    static member inline unstable_hasDefault (value: bool) = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "unstable_hasDefault" value

module useArrowNavigationGroupOptions =
    /// Focus will navigate vertically, horizontally or in both directions (grid), defaults to horizontally
    /// DefaultValue: vertical
    type [<Erase>] axis =
        static member inline vertical = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "axis" "vertical"
        static member inline horizontal = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "axis" "horizontal"
        static member inline grid = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "axis" "grid"
        static member inline gridLinear = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "axis" "grid-linear"
        static member inline both = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "axis" "both"

// -------------------------------------------------------------------------- useFocusableGroupOptions --------------------------------------------------------------------------------------

type [<Erase>] useFocusableGroupOptions =
    /// Tabster can ignore default handling of keydown events
    static member inline ignoreDefaultKeydown (value: IgnoreKeyDown) = Interop.mkProperty<IUseFocusableGroupOptionsProp> "ignoreDefaultKeydown" value

module useFocusableGroupOptions =
    /// Behavior for the Tab key.
    type [<Erase>] tabBehavior =
        static member inline unlimited = Interop.mkProperty<IUseFocusableGroupOptionsProp> "tabBehavior" "unlimited"
        static member inline limited = Interop.mkProperty<IUseFocusableGroupOptionsProp> "tabBehavior" "limited"
        static member inline limitedTrapFocus = Interop.mkProperty<IUseFocusableGroupOptionsProp> "tabBehavior" "limited-trap-focus"

// -------------------------------------------------------------------------- VirtualizerMeasureProps --------------------------------------------------------------------------------------

type [<Erase>] virtualizerMeasureProps =
    static member inline defaultItemSize (value: int) = Interop.mkProperty<IVirtualizerMeasurePropsProp> "defaultItemSize" value
    static member inline defaultItemSize (value: float) = Interop.mkProperty<IVirtualizerMeasurePropsProp> "defaultItemSize" value
    static member inline defaultItemSize (value: decimal) = Interop.mkProperty<IVirtualizerMeasurePropsProp> "defaultItemSize" value

module virtualizerMeasureProps =

    type [<Erase>] direction =
        static member inline horizontal = Interop.mkProperty<IVirtualizerMeasurePropsProp> "direction" "horizontal"
        static member inline vertical = Interop.mkProperty<IVirtualizerMeasurePropsProp> "direction" "limited"

// -------------------------------------------------------------------------- useModalAttributesOptions --------------------------------------------------------------------------------------

type [<Erase>] useModalAttributesOptions =
    /// Traps focus inside the elements the attributes are applied.
    /// Prefer this to `legacyTrapFocus` it forbids users to tab out of the focus trap into the actual browser.
    static member inline trapFocus (value: bool) = Interop.mkProperty<IUseModalAttributesOptionsProp> "trapFocus" value
    /// Traps focus inside the elements the attributes are applied.
    /// This prop enables legacy behavior to match previous versions of Fluent and is not
    /// recommended for general use.
    /// Enabling `legacyTrapFocus` prevents users from tabbing out of the focus trap and into
    /// the actual browser. Prefer using `trapFocus` instead of this prop.
    static member inline legacyTrapFocus (value: bool) = Interop.mkProperty<IUseModalAttributesOptionsProp> "legacyTrapFocus" value
    /// Always reachabled in Tab order
    static member inline alwaysFocusable (value: bool) = Interop.mkProperty<IUseModalAttributesOptionsProp> "alwaysFocusable" value
    /// Id to use for the modalizer. An id will be generated if not provided.
    static member inline id (value: string) = Interop.mkProperty<IUseModalAttributesOptionsProp> "id" value

// -------------------------------------------------------------------------- HeadlessTreeItem --------------------------------------------------------------------------------------

type [<Erase>] headlessTreeItem =
    inherit FelizProps.prop<IHeadlessTreeItemProp>

    static member inline value (value: string) = Interop.mkProperty<IHeadlessTreeItemProp> "value" value
    static member inline value (value: int) = Interop.mkProperty<IHeadlessTreeItemProp> "value" value
    static member inline value (value: float) = Interop.mkProperty<IHeadlessTreeItemProp> "value" value
    static member inline value (value: decimal) = Interop.mkProperty<IHeadlessTreeItemProp> "value" value
    static member inline parentValue (value: string) = Interop.mkProperty<IHeadlessTreeItemProp> "parentValue" value
    static member inline parentValue (value: int) = Interop.mkProperty<IHeadlessTreeItemProp> "parentValue" value
    static member inline parentValue (value: float) = Interop.mkProperty<IHeadlessTreeItemProp> "parentValue" value
    static member inline parentValue (value: decimal) = Interop.mkProperty<IHeadlessTreeItemProp> "parentValue" value

module headlessTreeItem =
    type [<Erase>] itemType =
        static member inline leaf = Interop.mkProperty<IHeadlessTreeItemProp> "itemType" "leaf"
        static member inline branch = Interop.mkProperty<IHeadlessTreeItemProp> "itemType" "branch"

// -------------------------------------------------------------------------- HeadlessFlatTreeOptions --------------------------------------------------------------------------------------

type [<Erase>] headlessFlatTreeOptions =
    inherit FelizProps.prop<IHeadlessFlatTreeOptionsProp>
    static member inline content (value: string) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "content" value
    // Callback fired when the component changes value from open state.
    // These property is ignored for subtrees.
    // Event - a React's Synthetic event
    // Data - A data object with relevant information,
    // such as open value and type of interaction that created the event.
    static member inline onOpenChange (handler: TreeOpenChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    // Callback fired when the component changes value from open state.
    // These property is ignored for subtrees.
    // Event - a React's Synthetic event
    // Data - A data object with relevant information,
    // such as open value and type of interaction that created the event.
    static member inline onOpenChange (value: MouseEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onOpenChange" (System.Func<_,_,_> value)
    // Callback fired when the component changes value from open state.
    // These property is ignored for subtrees.
    // Event - a React's Synthetic event
    // Data - A data object with relevant information,
    // such as open value and type of interaction that created the event.
    static member inline onOpenChange (value: KeyboardEvent -> TreeOpenChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onOpenChange" (System.Func<_,_,_> value)
    // Callback fired when the component changes value from checked state.
    // These property is ignored for subtrees.
    // Event - a React's Synthetic event
    // Data - A data object with relevant information, such as checked value and type of interaction that created the event.
    static member inline onCheckedChange (handler: TreeCheckedChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onCheckedChange" (System.Func<_,_,_> (fun _ value -> handler value))
    // Callback fired when the component changes value from checked state.
    // These property is ignored for subtrees.
    // Event - a React's Synthetic event
    // Data - A data object with relevant information, such as checked value and type of interaction that created the event.
    static member inline onCheckedChange (value: MouseEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onCheckedChange" (System.Func<_,_,_> value)
    // Callback fired when the component changes value from checked state.
    // These property is ignored for subtrees.
    // Event - a React's Synthetic event
    // Data - A data object with relevant information, such as checked value and type of interaction that created the event.
    static member inline onCheckedChange (value: KeyboardEvent -> TreeCheckedChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onCheckedChange" (System.Func<_,_,_> value)
    //  Callback fired when navigation happens inside the component.
    //  These property is ignored for subtrees.
    //  FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information,
    static member inline onNavigation (value: MouseEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onNavigation" (System.Func<_,_,_> value)
    //  Callback fired when navigation happens inside the component.
    //  These property is ignored for subtrees.
    //  FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information,
    static member inline onNavigation (value: KeyboardEvent -> TreeNavigationData_unstable<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onNavigation" (System.Func<_,_,_> value)
    //  Callback fired when navigation happens inside the component.
    //  These property is ignored for subtrees.
    //  FIXME: This method is not ideal, as navigation should be handled internally by tabster.
    //  Event - a React's Synthetic event
    //  Data - A data object with relevant information,
    static member inline onNavigation (handler: TreeNavigationData_unstable<'T, 'TEvent> -> unit) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "onNavigation" (System.Func<_,_,_> (fun _ value -> handler value))
    // This refers to a list of ids of opened tree items.
    // Controls the state of the open tree items.
    // These property is ignored for subtrees.
    static member inline openItems (value: #seq<'T> ) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "openItems" value
    // This refers to a list of ids of default opened items.
    // This property is ignored for subtrees.
    static member inline defaultOpenItems (value: #seq<'T> ) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "defaultOpenItems" value
    // This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    // Controls the state of the checked tree items.
    // These property is ignored for subtrees.
    static member inline checkedItems (value: 'T list) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "checkedItems" value
    // This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    // Controls the state of the checked tree items.
    // These property is ignored for subtrees.
    // static member inline checkedItems (value: ('T * CheckState) list ) =
    //     let parsedValue = value |> List.map (fun _ cs ->
    //         match cs with
    //         | Checked -> "true"
    //         | Unchecked -> "false"
    //         | Mixed -> "mixed"
    //     )
    //     Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "checkedItems" parsedValue
    // This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    // Controls the state of the checked tree items.
    // These property is ignored for subtrees.
    static member inline defaultCheckedItems (value: 'T list) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "defaultCheckedItems" value
    // // This refers to a list of ids of checked tree items, or a list of tuples of ids and checked state.
    // // Controls the state of the checked tree items.
    // // These property is ignored for subtrees.
    // static member inline defaultCheckedItems (value: ('T * CheckState) list ) = //TODO
    //     let parsedValue = value |> List.map (fun _ cs ->
    //         match cs with
    //         | Checked -> "true"
    //         | Unchecked -> "false"
    //         | Mixed -> "mixed"
    //     )
    //     Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "defaultCheckedItems" parsedValue

module headlessFlatTreeOptions =
    /// This refers to the selection mode of the tree.
    type [<Erase>] selectionMode =
        /// Only one tree item can be selected, radio buttons are rendered.
        static member inline single = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "selectionMode" "single"
        /// Multiple tree items can be selected, checkboxes are rendered.
        static member inline multiselect = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "selectionMode" "multiselect"
        /// No selection can be done.
        static member inline none = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "selectionMode" "undefined"

// -------------------------------------------------------------------------- DispatchToastOptions --------------------------------------------------------------------------------------

type [<Erase>] dispatchToastOptions =
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDispatchToastOptionsProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Uniquely identifies a toast, used for update and dismiss operations
    static member inline toastId (value: string) = Interop.mkProperty<IDispatchToastOptionsProp> "toastId" value
    /// Toast content
    static member inline content (value: ReactElement) = Interop.mkProperty<IDispatchToastOptionsProp> "content" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: int) = Interop.mkProperty<IDispatchToastOptionsProp> "timeout" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: float) = Interop.mkProperty<IDispatchToastOptionsProp> "timeout" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: decimal) = Interop.mkProperty<IDispatchToastOptionsProp> "timeout" value
    /// Toast timeout pauses while focus is on another window
    static member inline pauseOnWindowBlur (value: bool) = Interop.mkProperty<IDispatchToastOptionsProp> "pauseOnWindowBlur" value
    /// Toast timeout pauses while user cursor is on the toast
    static member inline pauseOnHover (value: bool) = Interop.mkProperty<IDispatchToastOptionsProp> "pauseOnHover" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: int) = Interop.mkProperty<IDispatchToastOptionsProp> "priority" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: float) = Interop.mkProperty<IDispatchToastOptionsProp> "priority" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: decimal) = Interop.mkProperty<IDispatchToastOptionsProp> "priority" value
    /// Additional data that needs to be passed to the toast
    static member inline data (value: obj) = Interop.mkProperty<IDispatchToastOptionsProp> "data" value
    /// Reports changes to the Toast lifecycle
    static member inline onStatusChange (handler: ToastChangeData -> unit) = Interop.mkProperty<IDispatchToastOptionsProp> "onStatusChange" (System.Func<_,_,_> (fun _ value -> handler value))

module dispatchToastOptions =
    /// The position the toast should render to
    type [<Erase>] toastPosition =
        static member inline topEnd = Interop.mkProperty<IDispatchToastOptionsProp> "toastPosition" "top-end"
        static member inline topStart = Interop.mkProperty<IDispatchToastOptionsProp> "toastPosition" "top-start"
        static member inline bottomEnd = Interop.mkProperty<IDispatchToastOptionsProp> "toastPosition" "bottom-end"
        static member inline bottomStart = Interop.mkProperty<IDispatchToastOptionsProp> "toastPosition" "bottom-start"

    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    type [<Erase>] politeness =
        static member inline assertive = Interop.mkProperty<IDispatchToastOptionsProp> "politeness" "assertive"
        static member inline polite = Interop.mkProperty<IDispatchToastOptionsProp> "politeness" "polite"

    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    type [<Erase>] intent =
        static member inline info = Interop.mkProperty<IDispatchToastOptionsProp> "intent" "info"
        static member inline success = Interop.mkProperty<IDispatchToastOptionsProp> "intent" "success"
        static member inline error = Interop.mkProperty<IDispatchToastOptionsProp> "intent" "error"
        static member inline warning = Interop.mkProperty<IDispatchToastOptionsProp> "intent" "warning"

    let toType (dispatchOptions: IDispatchToastOptionsProp list)=
        !!dispatchOptions |> createObj |> unbox<DispatchToastOptions>

// -------------------------------------------------------------------------- UpdateToastOptions --------------------------------------------------------------------------------------

type [<Erase>] updateToastOptions =
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IUpdateToastOptionsProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Uniquely identifies a toast, used for update and dismiss operations
    static member inline toastId (value: string) = Interop.mkProperty<IUpdateToastOptionsProp> "toastId" value
    /// Uniquely identifies a toast, used for update and dismiss operations
    static member inline toasterId (value: string) = Interop.mkProperty<IUpdateToastOptionsProp> "toasterId" value
    /// Uniquely identifies a toast, used for update and dismiss operations
    static member inline toasterId (value: string option) = Interop.mkProperty<IUpdateToastOptionsProp> "toasterId" value
    /// Toast content
    static member inline content (value: ReactElement) = Interop.mkProperty<IUpdateToastOptionsProp> "content" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: int) = Interop.mkProperty<IUpdateToastOptionsProp> "timeout" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: float) = Interop.mkProperty<IUpdateToastOptionsProp> "timeout" value
    /// Auto dismiss timeout in milliseconds
    static member inline timeout (value: decimal) = Interop.mkProperty<IUpdateToastOptionsProp> "timeout" value
    /// Toast timeout pauses while focus is on another window
    static member inline pauseOnWindowBlur (value: bool) = Interop.mkProperty<IUpdateToastOptionsProp> "pauseOnWindowBlur" value
    /// Toast timeout pauses while user cursor is on the toast
    static member inline pauseOnHover (value: bool) = Interop.mkProperty<IUpdateToastOptionsProp> "pauseOnHover" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: int) = Interop.mkProperty<IUpdateToastOptionsProp> "priority" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: float) = Interop.mkProperty<IUpdateToastOptionsProp> "priority" value
    /// Higher priority toasts will be rendered before lower priority toasts
    static member inline priority (value: decimal) = Interop.mkProperty<IUpdateToastOptionsProp> "priority" value
    /// Additional data that needs to be passed to the toast
    static member inline data (value: obj) = Interop.mkProperty<IUpdateToastOptionsProp> "data" value
    /// Reports changes to the Toast lifecycle
    static member inline onStatusChange (handler: ToastChangeData -> unit) = Interop.mkProperty<IUpdateToastOptionsProp> "onStatusChange" (System.Func<_,_,_> (fun _ value -> handler value))

module updateToastOptions =
    /// The position the toast should render to
    type [<Erase>] toastPosition =
        static member inline topEnd = Interop.mkProperty<IUpdateToastOptionsProp> "toastPosition" "top-end"
        static member inline topStart = Interop.mkProperty<IUpdateToastOptionsProp> "toastPosition" "top-start"
        static member inline bottomEnd = Interop.mkProperty<IUpdateToastOptionsProp> "toastPosition" "bottom-end"
        static member inline bottomStart = Interop.mkProperty<IUpdateToastOptionsProp> "toastPosition" "bottom-start"

    /// Used to determine [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// This will override the intent prop
    type [<Erase>] politeness =
        static member inline assertive = Interop.mkProperty<IUpdateToastOptionsProp> "politeness" "assertive"
        static member inline polite = Interop.mkProperty<IUpdateToastOptionsProp> "politeness" "polite"

    /// Default toast types that determine the urgency or [aria-live](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions) narration
    /// The UI layer may use these intents to apply specific styling.
    type [<Erase>] intent =
        static member inline info = Interop.mkProperty<IUpdateToastOptionsProp> "intent" "info"
        static member inline success = Interop.mkProperty<IUpdateToastOptionsProp> "intent" "success"
        static member inline error = Interop.mkProperty<IUpdateToastOptionsProp> "intent" "error"
        static member inline warning = Interop.mkProperty<IUpdateToastOptionsProp> "intent" "warning"

    let toType (updateOptions: IUpdateToastOptionsProp list)=
        !!updateOptions |> createObj |> unbox<UpdateToastOptions>
