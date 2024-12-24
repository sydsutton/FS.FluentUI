module Docs.Router

open Browser.Types
open Feliz.Router
open Fable.Core.JsInterop

type Page =
    | Install
    | FluentProvider
    | MakeStyles
    | MakeResetStyles
    | BundleIcon
    | Tokens
    | TypographyStyles
    | Themes
    | MergeClasses
    | Button
    | CompoundButton
    | MenuButton
    | SplitButton
    | ToggleButton
    | Checkbox
    | Combobox
    | Dropdown
    | Field
    | Input
    | Link
    | Radio
    | Select
    | Slider
    | SpinButton
    | TextArea
    | Switch
    | Icon
    | SearchBox
    | SwatchPicker
    | TagPicker
    | DatePicker
    | Calendar
    | TimePicker
    | DataGrid
    | VirtualizedDataGrid
    | Table
    | Tree
    | FlatTree
    | Accordion
    | Menu
    | TabList
    | Card
    | Dialog
    | Divider
    | Popover
    | Portal
    | Toolbar
    | Toast
    | Skeleton
    | MessageBar
    | Drawer
    | TeachingPopover
    | Carousel
    | Avatar
    | AvatarGroup
    | Badge
    | CounterBadge
    | PresenceBadge
    | Image
    | Persona
    | ProgressBar
    | Spinner
    | TagGroup
    | InteractionTag
    | Text
    | Tooltip
    | InfoLabel
    | InfoButton
    | Breadcrumb
    | Rating
    | Overflow
    | UseArrowNavigationGroup
    | UseFocusableGroup
    | UseFocusFinders
    | UseKeyboardNavAttribute
    | UseModalAttributes
    | UseId
    | CreatePresenceComponent
    | CreateMotionComponent
    | VirtualizerScrollView
    | Nav

[<RequireQualifiedAccess>]
module Page =
    let defaultPage = Page.Install

    let parseFromUrlSegments = function
        | [ "install" ] -> Page.Install
        | [ "fluentprovider" ] -> Page.FluentProvider
        | [ "makestyles" ] -> Page.MakeStyles
        | [ "makeresetstyles" ] -> Page.MakeResetStyles
        | [ "bundleicon" ] -> Page.BundleIcon
        | [ "tokens" ] -> Page.Tokens
        | [ "typographystyles" ] -> Page.TypographyStyles
        | [ "themes" ] -> Page.Themes
        | [ "mergeclasses" ] -> Page.MergeClasses
        | [ "button" ] -> Page.Button
        | [ "compoundbutton" ] -> Page.CompoundButton
        | [ "menubutton" ] -> Page.MenuButton
        | [ "splitbutton" ] -> Page.SplitButton
        | [ "togglebutton" ] -> Page.ToggleButton
        | [ "checkbox" ] -> Page.Checkbox
        | [ "combobox" ] -> Page.Combobox
        | [ "dropdown" ] -> Page.Dropdown
        | [ "field" ] -> Page.Field
        | [ "input" ] -> Page.Input
        | [ "link" ] -> Page.Link
        | [ "radio" ] -> Page.Radio
        | [ "select" ] -> Page.Select
        | [ "slider" ] -> Page.Slider
        | [ "spinbutton" ] -> Page.SpinButton
        | [ "textarea" ] -> Page.TextArea
        | [ "switch" ] -> Page.Switch
        | [ "icon" ] -> Page.Icon
        | [ "searchbox" ] -> Page.SearchBox
        | [ "swatchpicker" ] -> Page.SwatchPicker
        | [ "tagpicker" ] -> Page.TagPicker
        | [ "datepicker" ] -> Page.DatePicker
        | [ "calendar" ] -> Page.Calendar
        | [ "timepicker" ] -> Page.TimePicker
        | [ "datagrid" ] -> Page.DataGrid
        | [ "virtualizeddatagrid" ] -> Page.VirtualizedDataGrid
        | [ "table" ] -> Page.Table
        | [ "tree" ] -> Page.Tree
        | [ "flattree" ] -> Page.FlatTree
        | [ "accordion" ] -> Page.Accordion
        | [ "menu" ] -> Page.Menu
        | [ "tablist" ] -> Page.TabList
        | [ "card" ] -> Page.Card
        | [ "dialog" ] -> Page.Dialog
        | [ "divider" ] -> Page.Divider
        | [ "popover" ] -> Page.Popover
        | [ "portal" ] -> Page.Portal
        | [ "toolbar" ] -> Page.Toolbar
        | [ "toast" ] -> Page.Toast
        | [ "skeleton" ] -> Page.Skeleton
        | [ "messagebar" ] -> Page.MessageBar
        | [ "drawer" ] -> Page.Drawer
        | [ "teachingpopover" ] -> Page.TeachingPopover
        | [ "carousel" ] -> Page.Carousel
        | [ "avatar" ] -> Page.Avatar
        | [ "avatargroup" ] -> Page.AvatarGroup
        | [ "badge" ] -> Page.Badge
        | [ "counterbadge" ] -> Page.CounterBadge
        | [ "presencebadge" ] -> Page.PresenceBadge
        | [ "image" ] -> Page.Image
        | [ "persona" ] -> Page.Persona
        | [ "progressbar" ] -> Page.ProgressBar
        | [ "spinner" ] -> Page.Spinner
        | [ "taggroup" ] -> Page.TagGroup
        | [ "interactiontag" ] -> Page.InteractionTag
        | [ "text" ] -> Page.Text
        | [ "tooltip" ] -> Page.Tooltip
        | [ "infolabel" ] -> Page.InfoLabel
        | [ "infobutton" ] -> Page.InfoButton
        | [ "breadcrumb" ] -> Page.Breadcrumb
        | [ "rating" ] -> Page.Rating
        | [ "overflow" ] -> Page.Overflow
        | [ "usearrownavigationgroup" ] -> Page.UseArrowNavigationGroup
        | [ "usefocusablegroup" ] -> Page.UseFocusableGroup
        | [ "usefocusfinders" ] -> Page.UseFocusFinders
        | [ "usekeyboardnavattribute" ] -> Page.UseKeyboardNavAttribute
        | [ "usemodalattributes" ] -> Page.UseModalAttributes
        | [ "useid" ] -> Page.UseId
        | [ "createpresencecomponent" ] -> Page.CreatePresenceComponent
        | [ "createmotioncomponent" ] -> Page.CreateMotionComponent
        | [ "virtualizerscrollview" ] -> Page.VirtualizerScrollView
        | [ "nav" ] -> Page.Nav
        | _ -> defaultPage

    let noQueryString segments : string list * (string * string) list = segments, []

    let toUrlSegments = function
        | Page.Install -> [ "install" ] |> noQueryString
        | Page.FluentProvider -> [ "fluentprovider" ] |> noQueryString
        | Page.MakeStyles -> [ "makestyles" ] |> noQueryString
        | Page.MakeResetStyles -> [ "makeresetstyles" ] |> noQueryString
        | Page.BundleIcon -> [ "bundleicon" ] |> noQueryString
        | Page.Tokens -> [ "tokens" ] |> noQueryString
        | Page.TypographyStyles -> [ "typographystyles" ] |> noQueryString
        | Page.Themes -> [ "themes" ] |> noQueryString
        | Page.MergeClasses -> [ "mergeclasses" ] |> noQueryString
        | Page.Button -> [ "button" ] |> noQueryString
        | Page.CompoundButton -> [ "compoundbutton" ] |> noQueryString
        | Page.MenuButton -> [ "menubutton" ] |> noQueryString
        | Page.SplitButton -> [ "splitbutton" ] |> noQueryString
        | Page.ToggleButton -> [ "togglebutton" ] |> noQueryString
        | Page.Checkbox -> [ "checkbox" ] |> noQueryString
        | Page.Combobox -> [ "combobox" ] |> noQueryString
        | Page.Dropdown -> [ "dropdown" ] |> noQueryString
        | Page.Field -> [ "field" ] |> noQueryString
        | Page.Input -> [ "input" ] |> noQueryString
        | Page.Link -> [ "link" ] |> noQueryString
        | Page.Radio -> [ "radio" ] |> noQueryString
        | Page.Select -> [ "select" ] |> noQueryString
        | Page.Slider -> [ "slider" ] |> noQueryString
        | Page.SpinButton -> [ "spinbutton" ] |> noQueryString
        | Page.TextArea -> [ "textarea" ] |> noQueryString
        | Page.Switch -> [ "switch" ] |> noQueryString
        | Page.Icon -> [ "icon" ] |> noQueryString
        | Page.SearchBox -> [ "searchbox" ] |> noQueryString
        | Page.SwatchPicker -> [ "swatchpicker" ] |> noQueryString
        | Page.TagPicker -> [ "tagpicker" ] |> noQueryString
        | Page.DatePicker -> [ "datepicker" ] |> noQueryString
        | Page.Calendar -> [ "calendar" ] |> noQueryString
        | Page.TimePicker -> [ "timepicker" ] |> noQueryString
        | Page.DataGrid -> [ "datagrid" ] |> noQueryString
        | Page.VirtualizedDataGrid -> [ "virtualizeddatagrid" ] |> noQueryString
        | Page.Table -> [ "table" ] |> noQueryString
        | Page.Tree -> [ "tree" ] |> noQueryString
        | Page.FlatTree -> [ "flattree" ] |> noQueryString
        | Page.Accordion -> [ "accordion" ] |> noQueryString
        | Page.Menu -> [ "menu" ] |> noQueryString
        | Page.TabList -> [ "tablist" ] |> noQueryString
        | Page.Card -> [ "card" ] |> noQueryString
        | Page.Dialog -> [ "dialog" ] |> noQueryString
        | Page.Divider -> [ "divider" ] |> noQueryString
        | Page.Popover -> [ "popover" ] |> noQueryString
        | Page.Portal -> [ "portal" ] |> noQueryString
        | Page.Toolbar -> [ "toolbar" ] |> noQueryString
        | Page.Toast -> [ "toast" ] |> noQueryString
        | Page.Skeleton -> [ "skeleton" ] |> noQueryString
        | Page.MessageBar -> [ "messagebar" ] |> noQueryString
        | Page.Drawer -> [ "drawer" ] |> noQueryString
        | Page.TeachingPopover -> [ "teachingpopover" ] |> noQueryString
        | Page.Carousel -> [ "carousel" ] |> noQueryString
        | Page.Avatar -> [ "avatar" ] |> noQueryString
        | Page.AvatarGroup -> [ "avatargroup" ] |> noQueryString
        | Page.Badge -> [ "badge" ] |> noQueryString
        | Page.CounterBadge -> [ "counterbadge" ] |> noQueryString
        | Page.PresenceBadge -> [ "presencebadge" ] |> noQueryString
        | Page.Image -> [ "image" ] |> noQueryString
        | Page.Persona -> [ "persona" ] |> noQueryString
        | Page.ProgressBar -> [ "progressbar" ] |> noQueryString
        | Page.Spinner -> [ "spinner" ] |> noQueryString
        | Page.TagGroup -> [ "taggroup" ] |> noQueryString
        | Page.InteractionTag -> [ "interactiontag" ] |> noQueryString
        | Page.Text -> [ "text" ] |> noQueryString
        | Page.Tooltip -> [ "tooltip" ] |> noQueryString
        | Page.InfoLabel -> [ "infolabel" ] |> noQueryString
        | Page.InfoButton -> [ "infobutton" ] |> noQueryString
        | Page.Breadcrumb -> [ "breadcrumb" ] |> noQueryString
        | Page.Rating -> [ "rating" ] |> noQueryString
        | Page.Overflow -> [ "overflow" ] |> noQueryString
        | Page.UseArrowNavigationGroup -> [ "usearrownavigationgroup" ] |> noQueryString
        | Page.UseFocusableGroup -> [ "usefocusablegroup" ] |> noQueryString
        | Page.UseFocusFinders -> [ "usefocusfinders" ] |> noQueryString
        | Page.UseKeyboardNavAttribute -> [ "usekeyboardnavattribute" ] |> noQueryString
        | Page.UseModalAttributes -> [ "usemodalattributes" ] |> noQueryString
        | Page.UseId -> [ "useid" ] |> noQueryString
        | Page.CreatePresenceComponent -> [ "createpresencecomponent" ] |> noQueryString
        | Page.CreateMotionComponent -> [ "createmotioncomponent" ] |> noQueryString
        | Page.VirtualizerScrollView -> [ "virtualizerscrollview" ] |> noQueryString
        | Page.Nav -> [ "nav" ] |> noQueryString

[<RequireQualifiedAccess>]
module Router =
    let goToUrl (e: MouseEvent) =
        e.preventDefault()
        let href : string = !!e.currentTarget?attributes?href?value
        Router.navigate href

    let navigatePage (p:Page) = p |> Page.toUrlSegments |> Router.navigate

[<RequireQualifiedAccess>]
module Cmd =
    let navigatePage (p:Page) = p |> Page.toUrlSegments |> Cmd.navigate
