namespace FS.FluentUI.V8toV9

open Fable.Core

type [<RequireQualifiedAccess>] Interpolation = | pairs | primaryAndEnds


type [<AllowNullLiteral; Erase>] IPalette =
    /// Color code for themeDarker.
    abstract themeDarker: string with get, set
    /// Color code for themeDark.
    abstract themeDark: string with get, set
    /// Color code for themeDarkAlt.
    abstract themeDarkAlt: string with get, set
    /// Color code for themePrimary.
    abstract themePrimary: string with get, set
    /// Color code for themeSecondary.
    abstract themeSecondary: string with get, set
    /// Color code for themeTertiary.
    abstract themeTertiary: string with get, set
    /// Color code for themeLight.
    abstract themeLight: string with get, set
    /// Color code for themeLighter.
    abstract themeLighter: string with get, set
    /// Color code for themeLighterAlt.
    abstract themeLighterAlt: string with get, set
    /// Color code for the strongest color, which is black in the default theme.
    /// This is a very light color in inverted themes.
    abstract black: string with get, set
    /// Color code for blackTranslucent40.
    abstract blackTranslucent40: string with get, set
    /// Color code for neutralDark.
    abstract neutralDark: string with get, set
    /// Color code for neutralPrimary.
    abstract neutralPrimary: string with get, set
    /// Color code for neutralPrimaryAlt.
    abstract neutralPrimaryAlt: string with get, set
    /// Color code for neutralSecondary.
    abstract neutralSecondary: string with get, set
    /// Color code for neutralSecondaryAlt.
    abstract neutralSecondaryAlt: string with get, set
    /// Color code for neutralTertiary.
    abstract neutralTertiary: string with get, set
    /// Color code for neutralTertiaryAlt.
    abstract neutralTertiaryAlt: string with get, set
    /// Color code for neutralQuaternary.
    abstract neutralQuaternary: string with get, set
    /// Color code for neutralQuaternaryAlt.
    abstract neutralQuaternaryAlt: string with get, set
    /// Color code for neutralLight.
    abstract neutralLight: string with get, set
    /// Color code for neutralLighter.
    abstract neutralLighter: string with get, set
    /// Color code for neutralLighterAlt.
    abstract neutralLighterAlt: string with get, set
    /// Color code for the accent.
    abstract accent: string with get, set
    /// Color code for the softest color, which is white in the default theme. This is a very dark color in dark themes.
    /// This is the page background.
    abstract white: string with get, set
    /// Color code for whiteTranslucent40
    abstract whiteTranslucent40: string with get, set
    /// Color code for yellowDark.
    abstract yellowDark: string with get, set
    /// Color code for yellow.
    abstract yellow: string with get, set
    /// Color code for yellowLight.
    abstract yellowLight: string with get, set
    /// Color code for orange.
    abstract orange: string with get, set
    /// Color code for orangeLight.
    abstract orangeLight: string with get, set
    /// Color code for orangeLighter.
    abstract orangeLighter: string with get, set
    /// Color code for redDark.
    abstract redDark: string with get, set
    /// Color code for red.
    abstract red: string with get, set
    /// Color code for magentaDark.
    abstract magentaDark: string with get, set
    /// Color code for magenta.
    abstract magenta: string with get, set
    /// Color code for magentaLight.
    abstract magentaLight: string with get, set
    /// Color code for purpleDark.
    abstract purpleDark: string with get, set
    /// Color code for purple.
    abstract purple: string with get, set
    /// Color code for purpleLight.
    abstract purpleLight: string with get, set
    /// Color code for blueDark.
    abstract blueDark: string with get, set
    /// Color code for blueMid.
    abstract blueMid: string with get, set
    /// Color code for blue.
    abstract blue: string with get, set
    /// Color code for blueLight.
    abstract blueLight: string with get, set
    /// Color code for tealDark.
    abstract tealDark: string with get, set
    /// Color code for teal.
    abstract teal: string with get, set
    /// Color code for tealLight.
    abstract tealLight: string with get, set
    /// Color code for greenDark.
    abstract greenDark: string with get, set
    /// Color code for green.
    abstract green: string with get, set
    /// Color code for greenLight.
    abstract greenLight: string with get, set

/// Fluent UI font set.
/// {@docCategory IFontStyles}
type [<Erase>] IFontStyles =
    | Tiny // abstract tiny: IRawStyle with get, set
    | XSmall // abstract xSmall: IRawStyle with get, set
    | Small // abstract small: IRawStyle with get, set
    | SmallPlus // abstract smallPlus: IRawStyle with get, set
    | Medium // abstract medium: IRawStyle with get, set
    | MediumPlus // abstract mediumPlus: IRawStyle with get, set
    | Large // abstract large: IRawStyle with get, set
    | XLarge // abstract xLarge: IRawStyle with get, set
    | XLargePlus // abstract xLargePlus: IRawStyle with get, set
    | XxLarge // abstract xxLarge: IRawStyle with get, set
    | XxLargePlus // abstract xxLargePlus: IRawStyle with get, set
    | SuperLarge // abstract superLarge: IRawStyle with get, set
    | Mega // abstract mega: IRawStyle with get, set

type [<AllowNullLiteral; Erase>] ComponentsStyles = interface end

type [<AllowNullLiteral; Erase>] ISemanticTextColors =
    /// The default color for text.
    abstract bodyText: string with get, set
    /// Checked text color, e.g. selected menu item text.
    abstract bodyTextChecked: string with get, set
    /// De-emphasized text; e.g. metadata, captions, placeholder text.
    abstract bodySubtext: string with get, set
    /// Neutral colored links and links for action buttons.
    abstract actionLink: string with get, set
    /// Hover state for neutral colored links and links for action buttons.
    abstract actionLinkHovered: string with get, set
    /// The color of a link.
    abstract link: string with get, set
    /// The color of a hovered link. Also used when the link is active.
    abstract linkHovered: string with get, set
    /// The default color for disabled text on top of disabledBackground; e.g. text in a disabled text field or
    /// disabled button text.
    abstract disabledText: string with get, set
    /// The default color for disabled text on the default background (bodyBackground).
    abstract disabledBodyText: string with get, set
    /// Disabled de-emphasized text, for use on disabledBackground.
    abstract disabledSubtext: string with get, set
    /// Disabled de-emphasized text, for use on the default background (bodyBackground).
    abstract disabledBodySubtext: string with get, set
    /// The default color of error text on bodyBackground.
    abstract errorText: string with get, set
    /// The default color of text in a message bar.
    abstract messageText: string with get, set
    /// The color of input text.
    abstract inputText: string with get, set
    /// The color of input text on hover.
    abstract inputTextHovered: string with get, set
    /// The color of placeholder text.
    abstract inputPlaceholderText: string with get, set
    /// Color of text in a standard button
    abstract buttonText: string with get, set
    /// Color of text in a hovered standard button
    abstract buttonTextHovered: string with get, set
    /// Color of text in a checked standard button
    abstract buttonTextChecked: string with get, set
    /// Color of text in a checked and hovered standard button
    abstract buttonTextCheckedHovered: string with get, set
    /// Color of text in a pressed standard button; i.e. currently being clicked by mouse
    abstract buttonTextPressed: string with get, set
    /// Color of text in a disabled standard button
    abstract buttonTextDisabled: string with get, set
    /// Color of text in a primary button
    abstract primaryButtonText: string with get, set
    /// Color of text in a hovered primary button
    abstract primaryButtonTextHovered: string with get, set
    /// Color of text in a pressed primary button; i.e. currently being clicked by mouse
    abstract primaryButtonTextPressed: string with get, set
    /// Color of text in a disabled primary button
    abstract primaryButtonTextDisabled: string with get, set
    /// Color of text for accent button (kicker)
    abstract accentButtonText: string with get, set
    /// The default text color for list item titles and text in column fields.
    abstract listText: string with get, set
    abstract listTextColor: string with get, set
    abstract warningText: string with get, set
    abstract successText: string with get, set

type [<AllowNullLiteral; Erase>] ISemanticColors =
    inherit ISemanticTextColors
    /// The default color for backgrounds.
    abstract bodyBackground: string with get, set
    /// The default hover color for the backgrounds of interactable elements that don't have their own backgrounds.
    /// e.g. if links had hover backgrounds, they'd use this
    abstract bodyBackgroundHovered: string with get, set
    /// The default background color of selected interactable elements that don't have their own backgrounds.
    /// e.g. indicates in the nav which page you're currently on
    abstract bodyBackgroundChecked: string with get, set
    /// The standout color for highlighted content backgrounds.
    /// For highlighted content when there is no emphasis, use the neutral variant instead.
    /// This should be a shade darker than bodyBackground in light themes, and a shade lighter in inverted themes.
    abstract bodyStandoutBackground: string with get, set
    /// The color for chrome adjacent to an area with bodyBackground.
    /// This can be used to provide visual separation of zones when using stronger colors, when using a divider line
    /// is not desired.
    /// In most themes, this should match the color of bodyBackground.
    /// See also: bodyFrameDivider
    abstract bodyFrameBackground: string with get, set
    /// Used as the border between a zone with bodyFrameBackground and a zone with bodyBackground.
    /// If bodyBackground and bodyFrameBackground are different, this should be the same color as bodyFrameBackground
    /// in order to visually disappear.
    /// See also: bodyFrameBackground
    abstract bodyFrameDivider: string with get, set
    /// Divider lines; e.g. lines that separate sections in a menu, an <HR> element.
    abstract bodyDivider: string with get, set
    /// The default color for backgrounds of disabled controls; e.g. disabled text field.
    abstract disabledBackground: string with get, set
    /// The default color for border of disabled controls; e.g. disabled slider, disabled toggle border.
    abstract disabledBorder: string with get, set
    /// The color of the outline around focused controls that don't already have a border; e.g. menu items
    abstract focusBorder: string with get, set
    /// The background color of a card (or other surface) on a standout background.
    /// Cards usually have shadows, but the variantBorder slots can be used for a solid border.
    /// e.g. cards on a carousel of highlighted articles
    abstract cardStandoutBackground: string with get, set
    /// The default box-shadow for a card. In inverted themes, by default, this is set to `none` since shadows do not work
    /// well on dark backgrounds. If the card could be the same color as the background, it is recommended that
    /// `variantBorder` is used instead, so the card doesn't disappear in inverted themes.
    /// For use with `box-shadow`.
    abstract cardShadow: string with get, set
    /// The default box-shadow when hovering on a card. Generally, this is a deeper shadow than `cardShadow`, to give
    /// the effect that the card is lifting off the page.
    /// In inverted themes, this should be set to a box-shadow that looks like a solid border, because shadows are not
    /// visible on dark themes.
    /// For use with `box-shadow`.
    abstract cardShadowHovered: string with get, set
    /// The color of the border that provides contrast between an element, such as a card, and a standout background.
    abstract variantBorder: string with get, set
    /// Hover color of border that provides contrast between an element, such as a card, and a standout background.
    abstract variantBorderHovered: string with get, set
    /// Background color for default/empty state graphical elements; eg default icons, empty section that
    /// needs user to fill in content, placeholder graphics, empty seats, etc.
    abstract defaultStateBackground: string with get, set
    /// Background for informational messages.
    abstract infoBackground: string with get, set
    /// The background for errors, if necessary, or highlighting the section of the page where the error is present.
    abstract errorBackground: string with get, set
    /// Background for blocking issues, which is more severe than a warning, but not as bad as an error.
    abstract blockingBackground: string with get, set
    /// Background for warning messages.
    abstract warningBackground: string with get, set
    /// Background for severe warning messages.
    abstract severeWarningBackground: string with get, set
    /// Background for success
    abstract successBackground: string with get, set
    /// Color for icons on infoBackground.
    abstract infoIcon: string with get, set
    /// Color for icons on errorBackground.
    abstract errorIcon: string with get, set
    /// Color for icons on blockingBackground.
    abstract blockingIcon: string with get, set
    /// Color for icons on warningBackground.
    abstract warningIcon: string with get, set
    /// Color for icons on severeWarningBackground.
    abstract severeWarningIcon: string with get, set
    /// Color for icons on successBackground.
    abstract successIcon: string with get, set
    /// Color of links within a message.
    abstract messageLink: string with get, set
    /// Color of links within a message when hovered.
    abstract messageLinkHovered: string with get, set
    /// The border of a large input control in its resting, state; e.g. the box of dropdown.
    abstract inputBorder: string with get, set
    /// The border of a small input control in its resting unchecked state; e.g. the box of an unchecked checkbox.
    abstract smallInputBorder: string with get, set
    /// The border color of a large hovered input control, such as textbox.
    abstract inputBorderHovered: string with get, set
    /// The background color of an input, e.g. textbox background.
    abstract inputBackground: string with get, set
    /// The background of a checked control; e.g. checked radio button's dot, checked toggle's background.
    abstract inputBackgroundChecked: string with get, set
    /// The background of a checked and hovered control; e.g. checked checkbox's background color on hover.
    abstract inputBackgroundCheckedHovered: string with get, set
    /// The placeholder background color of a checked control, e.g. slider background, spinner background.
    abstract inputPlaceholderBackgroundChecked: string with get, set
    /// The foreground of a checked control; e.g. checked checkbox's checkmark color, checked toggle's thumb color,
    /// radio button's background color around the dot.
    abstract inputForegroundChecked: string with get, set
    /// The alternate focus border color for elements that already have a border; e.g. text field borders on focus.
    abstract inputFocusBorderAlt: string with get, set
    /// The color for disabled icon ; e.g. SearchBox magnifying glass in disabled state.
    abstract inputIconDisabled: string with get, set
    /// The color for icon ; e.g. SearchBox magnifying glass in rest state.
    abstract inputIcon: string with get, set
    /// The color for hovered icon ; e.g. SearchBox magnifying glass in hovered state.
    abstract inputIconHovered: string with get, set
    /// Background of a standard button
    abstract buttonBackground: string with get, set
    /// Background of a checked standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundChecked: string with get, set
    /// Background of a hovered standard button
    abstract buttonBackgroundHovered: string with get, set
    /// Background of a checked and hovered standard button; e.g. bold/italicize/underline text button in toolbar
    abstract buttonBackgroundCheckedHovered: string with get, set
    /// Background of a disabled standard button
    abstract buttonBackgroundDisabled: string with get, set
    /// Background of a pressed standard button; i.e. currently being clicked by mouse
    abstract buttonBackgroundPressed: string with get, set
    /// Border of a standard button
    abstract buttonBorder: string with get, set
    /// Border of a disabled standard button
    abstract buttonBorderDisabled: string with get, set
    /// Background of a primary button
    abstract primaryButtonBackground: string with get, set
    /// Background of a hovered primary button
    abstract primaryButtonBackgroundHovered: string with get, set
    /// Background of a pressed primary button; i.e. currently being clicked by mouse
    abstract primaryButtonBackgroundPressed: string with get, set
    /// Background of a disabled primary button
    abstract primaryButtonBackgroundDisabled: string with get, set
    /// Border of a primary button
    abstract primaryButtonBorder: string with get, set
    /// Background of an accent button (kicker)
    abstract accentButtonBackground: string with get, set
    /// The background of a menu.
    abstract menuBackground: string with get, set
    /// The divider between menu items.
    abstract menuDivider: string with get, set
    /// The default colors of icons in menus.
    abstract menuIcon: string with get, set
    /// The headers in menus that denote title of a section.
    abstract menuHeader: string with get, set
    /// The background of a hovered menu item.
    abstract menuItemBackgroundHovered: string with get, set
    /// The background of a pressed menu item.
    abstract menuItemBackgroundPressed: string with get, set
    /// The text color of a menu item.
    abstract menuItemText: string with get, set
    /// The text color of a hovered menu item.
    abstract menuItemTextHovered: string with get, set
    /// The background color for the entire list.
    abstract listBackground: string with get, set
    /// The default text color for list item titles and text in column fields.
    abstract listText: string with get, set
    /// The background color of a hovered list item.
    abstract listItemBackgroundHovered: string with get, set
    /// The background color of a checked list item.
    abstract listItemBackgroundChecked: string with get, set
    /// The background color of a checked and hovered list item.
    abstract listItemBackgroundCheckedHovered: string with get, set
    /// The background color for a hovered list header.
    abstract listHeaderBackgroundHovered: string with get, set
    /// The background color for a pressed list header.
    abstract listHeaderBackgroundPressed: string with get, set
    abstract menuItemBackgroundChecked: string with get, set
    abstract warningHighlight: string with get, set

type [<AllowNullLiteral; Erase>] ISpacing =
    abstract s2: string with get, set
    abstract s1: string with get, set
    abstract m: string with get, set
    abstract l1: string with get, set
    abstract l2: string with get, set

/// Decorative styles in a theme
type [<AllowNullLiteral; Erase>] IEffects =
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: cards, grid items
    abstract elevation4: string with get, set
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: menus, command surfaces
    abstract elevation8: string with get, set
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: search result dropdowns, hover cards, tooltips, help bubbles
    abstract elevation16: string with get, set
    /// Used to provide a visual affordance that this element is elevated above the surface it rests on.
    /// This is lower than elevations with a higher value, and higher than elevations with a lower value.
    /// The shadow's color should not change with the theme, because colored shadows look unnatural.
    /// Used for: Panels, Dialogs
    abstract elevation64: string with get, set
    /// Rounded corner value, for use with border-radius. Smaller values indicate less rounding.
    /// Smaller elements should get less rounding than larger elements.
    /// Used for: buttons
    abstract roundedCorner2: string with get, set
    /// Rounded corner value, for use with border-radius. Smaller values indicate less rounding.
    /// Smaller elements should get less rounding than larger elements.
    /// Used for: cards
    abstract roundedCorner4: string with get, set
    /// Rounded corner value, for use with border-radius. Smaller values indicate less rounding.
    /// Smaller elements should get less rounding than larger elements.
    /// Used for: surfaces
    abstract roundedCorner6: string with get, set

type [<Erase>] IRawStyle = interface end

type [<AllowNullLiteral; Erase>] IScheme =
    abstract rtl: bool option with get, set
    abstract palette: IPalette with get, set
    abstract fonts: IFontStyles with get, set
    abstract semanticColors: ISemanticColors with get, set
    abstract isInverted: bool with get, set
    /// This setting is for a very narrow use case and you probably don't need to worry about,
    /// unless you share a environment with others that also use fabric.
    /// It is used for disabling global styles on fabric components. This will prevent global
    /// overrides that might have been set by other fabric users from applying to your components.
    /// When you set this setting to `true` on your theme the components in the subtree of your
    /// Customizer will not get the global styles applied to them.
    abstract disableGlobalClassNames: bool with get, set
    abstract spacing: ISpacing with get, set
    abstract effects: IEffects with get, set

//   / {@docCategory Theme}
//   / A partial theme.
type [<AllowNullLiteral; Erase>] IPartialTheme =
    abstract components: ComponentsStyles option with get, set
    abstract palette: IPalette option with get, set
    abstract fonts: IFontStyles option with get, set
    abstract semanticColors: ISemanticColors option with get, set
    abstract isInverted: bool option with get, set
    abstract disableGlobalClassNames: bool option with get, set
    abstract rtl: bool option with get, set
    abstract spacing: ISpacing option with get, set
    abstract effects: IEffects option with get, set
    /// Use this property to specify font property defaults.
    abstract defaultFontStyle: IRawStyle option with get, set
    abstract schemes: IScheme option with get, set
