namespace FS.FluentUI

open Fable.Core

type [<Erase>] IFluentProviderProp = interface end
type [<Erase>] IAvatarProp = interface end
type [<Erase>] IButtonProp = interface end
type [<Erase>] IToggleButtonProp = interface end
type [<Erase>] IAccordionProp = interface end
type [<Erase>] IAccordionHeaderProp = interface end
type [<Erase>] IAccordionItemProp = interface end
type [<Erase>] IAccordionPanelProp = interface end
type [<Erase>] ICheckboxProp = interface end
type [<Erase>] IImageProp = interface end
type [<Erase>] IBadgeProp = interface end
type [<Erase>] ICounterBadgeProp = interface end
type [<Erase>] IPresenceBadgeProp = interface end

type [<Erase>] ITableProp = interface end
type [<Erase>] ITableHeaderProp = interface end
type [<Erase>] ITableHeaderCellProp = interface end
type [<Erase>] ITableBodyProp = interface end
type [<Erase>] ITableRowProp = interface end
type [<Erase>] ITableCellProp = interface end
type [<Erase>] ITableSelectionCellProp = interface end
type [<Erase>] ITableCellLayoutProp = interface end
type [<Erase>] ITableCellActionsProp = interface end
type [<Erase>] ITableResizeHandleProp = interface end
type [<Erase>] ICreateTableColumnOptionProp = interface end
type [<Erase>] IUseTableFeaturesOptionsProp = interface end
type [<Erase>] ITableFeaturesStateProp = interface end
type [<Erase>] ISelectionHookParamProp = interface end
type [<Erase>] ITableColumnSizingOptionsProp = interface end

type [<Erase>] ILinkProp = interface end
type [<Erase>] IDividerProp = interface end
type [<Erase>] ITextProp = interface end
type [<Erase>] IPopoverProp = interface end
type [<Erase>] IPopoverTriggerProp = interface end
type [<Erase>] IPopoverSurfaceProp = interface end
type [<Erase>] IPopoverProviderProp = interface end
type [<Erase>] ITooltipProp = interface end
type [<Erase>] ILabelProp = interface end
type [<Erase>] IInputProp = interface end
type [<Erase>] ICompoundButtonProp = interface end
type [<Erase>] ISplitButtonProp = interface end
type [<Erase>] ITextAreaProp = interface end
type [<Erase>] ISliderProp = interface end
type [<Erase>] ISwitchProp = interface end
type [<Erase>] IRadioProp = interface end
type [<Erase>] IRadioGroupProp = interface end
type [<Erase>] IPortalProp = interface end
type [<Erase>] ITabListProp = interface end
type [<Erase>] ITabProp = interface end
type [<Erase>] ISpinnerProp = interface end
type [<Erase>] ISpinButtonProp = interface end
type [<Erase>] ISelectProp = interface end
type [<Erase>] IDropdownProp = interface end
type [<Erase>] IOptionProp = interface end
type [<Erase>] IListboxProp = interface end
type [<Erase>] IPersonaProp = interface end
type [<Erase>] IComboboxProp = interface end
type [<Erase>] IAvatarGroupProp = interface end
type [<Erase>] IAvatarGroupItemProp = interface end
type [<Erase>] IAvatarGroupPopoverProp = interface end
type [<Erase>] IProgressBarProp = interface end
type [<Erase>] IFieldProp = interface end
type [<Erase>] IOptionGroupProp = interface end
type [<Erase>] ISkeletonProp = interface end
type [<Erase>] ISkeletonItemProp = interface end
type [<Erase>] IOverflowProp = interface end
type [<Erase>] IOverflowItemProp = interface end
type [<Erase>] IOverflowDividerProp = interface end
type [<Erase>] IInfoButtonProp = interface end
type [<Erase>] IInfoLabelProp = interface end
type [<Erase>] IAlertProp = interface end
type [<Erase>] IVirtualizerProp = interface end
type [<Erase>] IVirtualizerScrollViewProp = interface end
type [<Erase>] IVirtualizerScrollViewDynamicProp = interface end

type [<Erase>] IDialogProp = interface end
type [<Erase>] IDialogTriggerProp = interface end
type [<Erase>] IDialogSurfaceProp = interface end
type [<Erase>] IDialogTitleProp = interface end
type [<Erase>] IDialogActionsProp = interface end
type [<Erase>] IDialogBodyProp = interface end
type [<Erase>] IDialogContentProp = interface end

type [<Erase>] IToolbarProp = interface end
type [<Erase>] IToolbarButtonProp = interface end
type [<Erase>] IToolbarDividerProp = interface end
type [<Erase>] IToolbarGroupProp = interface end
type [<Erase>] IToolbarRadioButtonProp = interface end
type [<Erase>] IToolbarRadioGroupProp = interface end
type [<Erase>] IToolbarToggleButtonProp = interface end

type [<Erase>] IMenuButtonProp = interface end
type [<Erase>] IMenuProp = interface end
type [<Erase>] IMenuListProp = interface end
type [<Erase>] IMenuItemProp = interface end
type [<Erase>] IMenuItemCheckboxProp = interface end
type [<Erase>] IMenuItemRadioProp = interface end
type [<Erase>] IMenuPopoverProp = interface end
type [<Erase>] IMenuTriggerProp = interface end
type [<Erase>] IMenuSplitGroupProp = interface end
type [<Erase>] IMenuGroupProp = interface end
type [<Erase>] IMenuGroupHeaderProp = interface end
type [<Erase>] IMenuDividerProp = interface end
type [<Erase>] IMenuItemLinkProp = interface end
type [<Erase>] IMenuItemSwitchProp = interface end

type [<Erase>] IToastProp = interface end
type [<Erase>] IToastTitleProp = interface end
type [<Erase>] IToastBodyProp = interface end
type [<Erase>] IToastFooterProp = interface end
type [<Erase>] IToasterProp = interface end
type [<Erase>] IToastOffsetProp = interface end

type [<Erase>] ICardProp = interface end
type [<Erase>] ICardFooterProp = interface end
type [<Erase>] ICardHeaderProp = interface end
type [<Erase>] ICardPreviewProp = interface end

type [<Erase>] IDatePickerProp = interface end
type [<Erase>] ICalendarProp = interface end
type [<Erase>] ICalendarDayProp = interface end
type [<Erase>] ICalendarMonthProp = interface end

type [<Erase>] IDateGridStringsProp = interface end
type [<Erase>] IDateFormattingProp = interface end

type [<Erase>] IDataGridProp = interface end
type [<Erase>] IDataGridHeaderProp = interface end
type [<Erase>] IDataGridHeaderCellProp = interface end
type [<Erase>] IDataGridBodyProp = interface end
type [<Erase>] IDataGridRowProp = interface end
type [<Erase>] IDataGridCellProp = interface end
type [<Erase>] IDataGridSelectionCellProp = interface end
type [<Erase>] IResizableColumnsOptionsProp = interface end

type [<Erase>] IDrawerProp = interface end
type [<Erase>] IOverlayDrawerProp = interface end
type [<Erase>] IInlineDrawerProp = interface end
type [<Erase>] IDrawerHeaderProp = interface end
type [<Erase>] IDrawerHeaderTitleProp = interface end
type [<Erase>] IDrawerHeaderNavigationProp = interface end
type [<Erase>] IDrawerBodyProp = interface end

type [<Erase>] ITreeProp = interface end
type [<Erase>] IFlatTreeProp = interface end
type [<Erase>] ITreeItemProp = interface end
type [<Erase>] ITreeItemLayoutProp = interface end
type [<Erase>] ITreeItemPersonaLayoutProp = interface end
type [<Erase>] IHeadlessTreeItemProp = interface end
type [<Erase>] IHeadlessFlatTreeOptionsProp = interface end

type [<Erase>] IIconProp = interface end
type [<Erase>] IPositioningProp = interface end
type [<Erase>] IPartitionAvatarGroupItemsOptionsProp = interface end
type [<Erase>] IUseArrowNavigationGroupOptionsProp = interface end
type [<Erase>] IUseFocusableGroupOptionsProp = interface end
type [<Erase>] IVirtualizerMeasurePropsProp = interface end
type [<Erase>] IUseModalAttributesOptionsProp = interface end

type [<Erase>] IBreadcrumbProp = interface end
type [<Erase>] IBreadcrumbItemProp = interface end
type [<Erase>] IBreadcrumbDividerProp = interface end
type [<Erase>] IBreadcrumbButtonProp = interface end
type [<Erase>] IPartitionBreadcrumbItemsOptionsProp = interface end

type [<Erase>] ISearchBoxProp = interface end

type [<Erase>] ITagProp = interface end
type [<Erase>] ITagGroupProp = interface end
type [<Erase>] IInteractionTagProp = interface end
type [<Erase>] IInteractionTagPrimaryProp = interface end
type [<Erase>] IInteractionTagSecondaryProp = interface end

type [<Erase>] IMessageBarProp = interface end
type [<Erase>] IMessageBarBodyProp = interface end
type [<Erase>] IMessageBarTitleProp = interface end
type [<Erase>] IMessageBarActionsProp = interface end
type [<Erase>] IMessageBarGroupProp = interface end

type [<Erase>] IIgnoreKeyDownProp = interface end
type [<Erase>] IOverflowBoundaryPaddingProp = interface end
type [<Erase>] IOffsetProp = interface end
type [<Erase>] IVirtualizerContextProp = interface end
type [<Erase>] IMotionStateProp = interface end
type [<Erase>] IMotionOptionsProp = interface end
type [<Erase>] ITimePickerProp = interface end

type [<Erase>] ITeachingPopoverProp = interface end
type [<Erase>] ITeachingPopoverTriggerProp = interface end
type [<Erase>] ITeachingPopoverSurfaceProp = interface end
type [<Erase>] ITeachingPopoverHeaderProp = interface end
type [<Erase>] ITeachingPopoverBodyProp = interface end
type [<Erase>] ITeachingPopoverTitleProp = interface end
type [<Erase>] ITeachingPopoverCarouselProp = interface end
type [<Erase>] ITeachingPopoverCarouselCardProp  = interface end
type [<Erase>] ICarouselItemProp  = interface end
type [<Erase>] ITeachingPopoverCarouselFooterProp  = interface end
type [<Erase>] ITeachingPopoverCarouselFooterButtonProp  = interface end
type [<Erase>] ITeachingPopoverCarouselNavProp  = interface end
type [<Erase>] ITeachingPopoverCarouselNavButtonProp  = interface end

type [<Erase>] IRatingProp = interface end
type [<Erase>] IRatingItemProp = interface end
type [<Erase>] IRatingDisplayProp = interface end

type [<Erase>] ITagPickerProp = interface end
type [<Erase>] ITagPickerControlProp = interface end
type [<Erase>] ITagPickerGroupProp = interface end
type [<Erase>] ITagPickerButtonProp = interface end
type [<Erase>] ITagPickerInputProp = interface end
type [<Erase>] ITagPickerListProp = interface end
type [<Erase>] ITagPickerOptionProp = interface end
type [<Erase>] ITagPickerOptionGroupProp = interface end
type [<Erase>] IUseTagPickerFilterProp = interface end

type [<Erase>] ISwatchPickerProp = interface end
type [<Erase>] IColorSwatchProp = interface end
type [<Erase>] ISwatchPickerRowProp = interface end
type [<Erase>] IImageSwatchProp = interface end
type [<Erase>] IEmptySwatchProp = interface end
type [<Erase>] ISwatchPickerGridProp = interface end

type [<Erase>] IPresenceComponentProp = interface end

type [<Erase>] IComboboxFilterConfigProp = interface end
type [<Erase>] ICalendarNavigationIconsProp = interface end

type [<AllowNullLiteral; Erase>] IStyle = interface end
type [<AllowNullLiteral; Erase>] ITheme = interface end

type [<AllowNullLiteral; Erase>] BundleIcon = interface end

[<RequireQualifiedAccess>]
type Interop =
    static member inline mkProperty<'ControlProperty> (key:string) (value:obj) : 'ControlProperty = unbox (key, value)
