namespace FS.FluentUI

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

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
    /// Assigns the item to a group, group visibility can be watched.
    static member inline groupId (value: int) = Interop.mkProperty<IOverflowDividerProp> "groupId" value
    /// Assigns the item to a group, group visibility can be watched.
    static member inline groupId (value: float) = Interop.mkProperty<IOverflowDividerProp> "groupId" value
    /// Assigns the item to a group, group visibility can be watched.
    static member inline groupId (value: decimal) = Interop.mkProperty<IOverflowDividerProp> "groupId" value
    /// The single child that has overflow item behavior attached.
    static member inline children (value: ReactElement) = Interop.mkProperty<IOverflowDividerProp> "children" value

// -------------------------------------------------------------------------- DataGrid --------------------------------------------------------------------------------------
type [<Erase>] dataGrid  =
    inherit FelizProps.prop<IDataGridProp>
    /// Render all table elements as divs instead of semantic table elements Using divs no longer uses display: table layout but display: flex
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IDataGridProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Render all table elements as divs instead of semantic table elements Using divs no longer uses display: table layout but display: flex
    static member inline noNativeElements (value: bool) = Interop.mkProperty<IDataGridProp> "noNativeElements" value
    /// Whether the table is sortable
    static member inline sortable (value: bool) = Interop.mkProperty<IDataGridProp> "sortable" value
    static member items (value: #seq<'T>) = Interop.mkProperty<IDataGridProp> "items" (value |> Seq.toArray)
    /// Table columns
    static member inline columns (value: #seq<TableColumnDefinition<'T, 'TKeyType>>) = Interop.mkProperty<IDataGridProp> "columns" (value |> Seq.toArray)
    static member inline getRowId (value: 'T -> string) = Interop.mkProperty<IDataGridProp> "getRowId" (System.Func<_,_> value)
    static member inline getRowId (value: 'T -> int) = Interop.mkProperty<IDataGridProp> "getRowId" (System.Func<_,_> value)
    static member inline getRowId (value: 'T -> float) = Interop.mkProperty<IDataGridProp> "getRowId" (System.Func<_,_> value)
    static member inline getRowId (value: 'T -> decimal) = Interop.mkProperty<IDataGridProp> "getRowId" (System.Func<_,_> value)
    static member inline subtleSelection (value: bool) = Interop.mkProperty<IDataGridProp> "subtleSelection" value
    /// Enables column resizing
    static member inline resizableColumns (value: bool) = Interop.mkProperty<IDataGridProp> "resizableColumns" value
    /// Used to control sorting
    // static member inline sortState (value: SortState<'TKeyType>) = Interop.mkProperty<IDataGridProp> "sortState" value
    static member inline sortState (sortColumn: 'TKeyType option, sortDirection: SortDirection) = Interop.mkProperty<IDataGridProp> "sortState" {| sortColumn = sortColumn; sortDirection = sortDirection |}
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSortState (sortColumn: 'TKeyType option, sortDirection: SortDirection) = Interop.mkProperty<IDataGridProp> "defaultSortState" {| sortColumn = sortColumn; sortDirection = sortDirection |}
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSelectedItems (value: list<string>) = Interop.mkProperty<IDataGridProp> "defaultSelectedItems" value
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSelectedItems (value: list<int>) = Interop.mkProperty<IDataGridProp> "defaultSelectedItems" value
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSelectedItems (value: list<float>) = Interop.mkProperty<IDataGridProp> "defaultSelectedItems" value
    /// Used in uncontrolled mode to set initial sort column and direction on mount
    static member inline defaultSelectedItems (value: list<decimal>) = Interop.mkProperty<IDataGridProp> "defaultSelectedItems" value
    /// Used to control selected items
    static member inline selectedItems (value: list<string>) = Interop.mkProperty<IDataGridProp> "selectedItems" value
    /// Used to control selected items
    static member inline selectedItems (value: list<int>) = Interop.mkProperty<IDataGridProp> "selectedItems" value
    /// Used to control selected items
    static member inline selectedItems (value: list<decimal>) = Interop.mkProperty<IDataGridProp> "selectedItems" value
    /// Used to control selected items
    static member inline selectedItems (value: list<float>) = Interop.mkProperty<IDataGridProp> "selectedItems" value
    static member inline onSortChange (handler: 'TKeyType option * SortDirection -> unit) =
        let newValue = (fun _ (sortState: {| sortColumn: 'TKeyType option; sortDirection: SortDirection |}) -> (sortState.sortColumn, sortState.sortDirection) |> handler)
        Interop.mkProperty<IDataGridProp> "onSortChange" (System.Func<_,_,_> newValue)
    static member inline onSortChange (value: MouseEvent -> ('TKeyType option * SortDirection) -> unit) =
        let newValue = (fun (ev: MouseEvent) (sortState: {| sortColumn: 'TKeyType option; sortDirection: SortDirection |}) -> (sortState.sortColumn, sortState.sortDirection) |> value ev)
        Interop.mkProperty<IDataGridProp> "onSortChange" (System.Func<_,_,_> newValue)
    static member inline onSelectionChange (handler: OnSelectionChangeData<string> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun _ (value: TempSeq<string>) -> handler (TempSeq.mkOnChangeData value)))
    static member inline onSelectionChange (value: MouseEvent -> OnSelectionChangeData<string> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<string>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (value: KeyboardEvent -> OnSelectionChangeData<string> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<string>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (handler: OnSelectionChangeData<int> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun _ (value: TempSeq<int>) -> handler (TempSeq.mkOnChangeData value)))
    static member inline onSelectionChange (value: MouseEvent -> OnSelectionChangeData<int> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<int>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (value: KeyboardEvent -> OnSelectionChangeData<int> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<int>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (handler: OnSelectionChangeData<float> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun _ (value: TempSeq<float>) -> handler (TempSeq.mkOnChangeData value)))
    static member inline onSelectionChange (value: MouseEvent -> OnSelectionChangeData<float> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<float>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (value: KeyboardEvent -> OnSelectionChangeData<float> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<float>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (handler: OnSelectionChangeData<decimal> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun _ (value: TempSeq<decimal>) -> handler (TempSeq.mkOnChangeData value)))
    static member inline onSelectionChange (value: MouseEvent -> OnSelectionChangeData<decimal> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<decimal>) -> (TempSeq.mkOnChangeData v) |> value e))
    static member inline onSelectionChange (value: KeyboardEvent -> OnSelectionChangeData<decimal> -> unit) =
        Interop.mkProperty<IDataGridProp> "onSelectionChange" (System.Func<_,_,_> (fun e (v: TempSeq<decimal>) -> (TempSeq.mkOnChangeData v) |> value e))
    /// Options for column resizing
    static member inline columnSizingOptions (value: list<'TKeyType * ITableColumnSizingOptionsProp list>) =
        let value =
            match value with
            | [] -> {||} |> unbox
            | value ->
                [
                    for (name, sizingOptions) in value do
                        // Using hard-coded files from inline-style-expand-shorthand. Otherwise you run into an issue where
                        // mixed shorthand and longhand properties are applied in an unexpected way due to the rendering order of CSS classes.
                        name, !!sizingOptions |> createObj |> unbox<TableColumnSizingOptions>
                ]
                |> unbox
                |> createObj

        Interop.mkProperty<IDataGridProp> "columnSizingOptions" value
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
    /// Custom options for column resizing.
    static member inline resizableColumnsOptions (value: IResizableColumnsOptionsProp list) = Interop.mkProperty<IDataGridProp> "resizableColumnsOptions" (!!value |> createObj |> unbox)

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


// -------------------------------------------------------------------------- ResizableColumnsOptions --------------------------------------------------------------------------------------
type [<Erase>] resizableColumnsOptions =
    /// If true, columns will be auto-fitted to the container width.
    static member inline autoFitColumns (value: bool) = Interop.mkProperty<IResizableColumnsOptionsProp> "autoFitColumns" value

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
    /// aside content for anything that should be after main content of the table header cell
    static member inline aside (value: IReactProperty list)= Interop.mkProperty<IDataGridHeaderProp> "aside" (!!value |> createObj |> unbox)
    /// Button handles correct narration and interactions for sorting
    static member inline button (value: ReactElement)= Interop.mkProperty<IDataGridHeaderProp> "button" value
    /// Button handles correct narration and interactions for sorting
    static member inline button (value: IReactProperty list)= Interop.mkProperty<IDataGridHeaderProp> "button" (!!value |> createObj |> unbox)
    static member inline sortIcon (value: ReactElement)= Interop.mkProperty<IDataGridHeaderProp> "sortIcon" value
    static member inline sortIcon (value: IReactProperty list)= Interop.mkProperty<IDataGridHeaderProp> "sortIcon" (!!value |> createObj |> unbox)

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
    /// Children render function for rows
    static member inline children (value: TableRowData<'T, 'TKeyType> -> ReactElement)= Interop.mkProperty<IDataGridBodyProp> "children" (System.Func<_,_> value)
    /// Children render function for rows.
    /// The value's tuple reads:
    /// <code>
    /// row: TableRowData<'T, 'TKeyType>,
    /// style: obj,
    /// index: int
    /// </code>
    ///
    /// **This property is mandatory when using virtualized data grids**
    static member inline children (value: TableRowData<'T, 'TKeyType> -> obj -> int -> ReactElement)= Interop.mkProperty<IDataGridBodyProp> "children" (System.Func<_,_,_,_> value)
    /// The size of each row.
    /// **This property is mandatory when using virtualized data grids**
    static member inline itemSize (value: int)= Interop.mkProperty<IDataGridBodyProp> "itemSize" value
    /// The height of the virtualized container.
    /// **This property is mandatory when using virtualized data grids**
    static member inline height (value: int)= Interop.mkProperty<IDataGridBodyProp> "height" value
    /// The width of the virtualized container
    static member inline width (value: int)= Interop.mkProperty<IDataGridBodyProp> "width" value
    /// The width of the virtualized container
    static member inline width (value: string)= Interop.mkProperty<IDataGridBodyProp> "width" value
    /// All virtualized rows must have the [aria-rowindex](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Attributes/aria-rowindex)
    /// attribute for correct screen reader navigation. The default start index is 2 since we assume that there is only
    /// one row in the header. If this is not the case, the start index can be reconfigured through this prop.
    static member inline ariaRowIndexStart (value: int)= Interop.mkProperty<IDataGridBodyProp> "ariaRowIndexStart" value

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
    /// Removes the bottom border of the dataGridRow. Doing this keeps the height of the border but changes the color to transparent.
    ///
    /// *This is a custom property that is not in the Microsoft documentation.*
    static member inline noBottomBorder = Interop.mkProperty<IDataGridRowProp> "style" (createObj ["borderBottomColor", "transparent"])
    /// Specifically added for using virtualized data grids.
    /// **This property is mandatory when using virtualized data grids**
    static member inline style (value: obj) = Interop.mkProperty<IDataGridRowProp> "style" value

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
    /// Selection indicator if selection type is checkbox
    static member inline checkboxIndicator (value: ICheckboxProp list) = Interop.mkProperty<IDataGridSelectionCellProp> "checkboxIndicator" (!!value |> createObj |> unbox<ICheckboxProp>)
    /// Selection indicator if selection type is radio
    static member inline radioIndicator (value: ReactElement)= Interop.mkProperty<IDataGridSelectionCellProp> "radioIndicator" value
    /// Selection indicator if selection type is radio
    static member inline radioIndicator (value: IRadioProp list) = Interop.mkProperty<IDataGridSelectionCellProp> "radioIndicator" (!!value |> createObj |> unbox<IRadioProp>)
    /// Only visible when checked or the parent row is hovered/focused
    static member inline subtle (value: bool)= Interop.mkProperty<IDataGridSelectionCellProp> "subtle" value
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

module icon =
    type [<Erase>] size =
        static member inline ``16`` = Interop.mkProperty<IIconProp> "fontSize" 16
        static member inline ``20`` = Interop.mkProperty<IIconProp> "fontSize" 20
        static member inline ``24`` = Interop.mkProperty<IIconProp> "fontSize" 24
        static member inline ``28`` = Interop.mkProperty<IIconProp> "fontSize" 28
        static member inline ``32`` = Interop.mkProperty<IIconProp> "fontSize" 32
        static member inline ``48`` = Interop.mkProperty<IIconProp> "fontSize" 48


// -------------------------------------------------------------------------- InfoButton --------------------------------------------------------------------------------------
type [<Erase>] infoButton =
    inherit FelizProps.prop<IInfoButtonProp>
    static member inline root (value: IReactProperty list)= Interop.mkProperty<IInfoButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The Popover element that wraps the info and root slots. Use this slot to pass props to the Popover.
    static member inline popover (value: ReactElement)= Interop.mkProperty<IInfoButtonProp> "popover" value
    /// The Popover element that wraps the info and root slots. Use this slot to pass props to the Popover.
    static member inline popover (value: IPopoverProp list)= Interop.mkProperty<IInfoButtonProp> "popover" (!!value |> createObj |> unbox<IPopoverProp>)
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: string)= Interop.mkProperty<IInfoButtonProp> "info" value
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: ReactElement)= Interop.mkProperty<IInfoButtonProp> "info" value
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: IPopoverSurfaceProp list)= Interop.mkProperty<IInfoButtonProp> "info" (!!value |> createObj |> unbox<IPopoverSurfaceProp>)
    /// Whether the InfoButton should be rendered inline or on a Portal.
    static member inline inline' (value: bool)= Interop.mkProperty<IInfoButtonProp> "inline" value

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
    static member inline info (value: ReactElement)= Interop.mkProperty<IInfoLabelProp> "info" value
    /// The information to be displayed in the PopoverSurface when the button is pressed.
    static member inline info (value: IPopoverSurfaceProp list)= Interop.mkProperty<IInfoLabelProp> "info" (!!value |> createObj |> unbox<IPopoverSurfaceProp>)
    /// Displays an indicator that the label is for a required field. The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: bool)= Interop.mkProperty<IInfoLabelProp> "required" value
    /// Displays an indicator that the label is for a required field. The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: ReactElement)= Interop.mkProperty<IInfoLabelProp> "required" value
    /// Displays an indicator that the label is for a required field. The required prop can be set to true to display an asterisk (*). Or it can be set to a string or jsx content to display a different indicator.
    static member inline required (value: IReactProperty list)= Interop.mkProperty<IInfoLabelProp> "required" (!!value |> createObj |> unbox)

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
    /// WARNING: Virtualizer only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children (value: Fable.React.ReactElement) = Interop.mkProperty<IVirtualizerProp> "children" value
    /// WARNING: Virtualizer only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) = Interop.mkProperty<IVirtualizerProp> "children" (Interop.reactApi.Children.toArray elems)
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
    /// WARNING: VirtualizerScrollView only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children (value: Fable.React.ReactElement) = Interop.mkProperty<IVirtualizerScrollViewProp> "children" value
    /// WARNING: VirtualizerScrollView only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) = Interop.mkProperty<IVirtualizerScrollViewProp> "children" (Interop.reactApi.Children.toArray elems)
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
    /// Imperative ref contains our scrollTo index functionality for user control.
    static member inline enablePagination (value: bool) = Interop.mkProperty<IVirtualizerScrollViewProp> "enablePagination" value

module virtualizerScrollView =
    /// The scroll direction
    type [<Erase>] axis =
        static member inline vertical = Interop.mkProperty<IVirtualizerScrollViewProp> "axis" "vertical"
        static member inline horizontal = Interop.mkProperty<IVirtualizerScrollViewProp> "axis" "horizontal"

// -------------------------------------------------------------------------- VirtualizerScrollViewDynamic --------------------------------------------------------------------------------------
type [<Erase>] virtualizerScrollViewDynamic =
    inherit FelizProps.prop<IVirtualizerScrollViewDynamicProp>
    /// WARNING: VirtualizerScrollViewDynamic only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children (value: Fable.React.ReactElement) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "children" value
    /// WARNING: VirtualizerScrollViewDynamic only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "children" (Interop.reactApi.Children.toArray elems)
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
    static member inline virtualizerContext (value: IVirtualizerContextProp list) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "virtualizerContext" (!!value |> createObj |> unbox<VirtualizerContextProps>)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: int -> unit) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: float -> unit) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Callback for notifying when a flagged index has been rendered
    static member inline onRenderedFlaggedIndex (value: decimal -> unit) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "onRenderedFlaggedIndex" (System.Func<_,_> value)
    /// Imperative ref contains our scrollTo index functionality for user control.
    static member inline imperativeVirtualizerRef (value: RefObject<VirtualizerDataRef>) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "imperativeVirtualizerRef" value
    /// Imperative ref contains our scrollTo index functionality for user control.
    static member inline enablePagination (value: bool) = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "enablePagination" value

module virtualizerScrollViewDynamic =
    /// The scroll direction
    type [<Erase>] axis =
        static member inline vertical = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "axis" "vertical"
        static member inline horizontal = Interop.mkProperty<IVirtualizerScrollViewDynamicProp> "axis" "horizontal"

// -------------------------------------------------------------------------- Drawer --------------------------------------------------------------------------------------
type [<Erase>] drawer =
    inherit FelizProps.prop<IDrawerProp>
    static member inline root (value: IOverlayDrawerProp list) = Interop.mkProperty<IDrawerProp> "root" (!!value |> createObj |> unbox<IOverlayDrawerProp>)
    static member inline root (value: IInlineDrawerProp list) = Interop.mkProperty<IDrawerProp> "root" (!!value |> createObj |> unbox<IInlineDrawerProp>)
    /// Controls the open state of the Drawer
    static member inline open' (value: bool) = Interop.mkProperty<IDrawerProp> "open" value
    /// Default value for the uncontrolled open state of the dialog.
    static member inline defaultOpen (value: bool) = Interop.mkProperty<IDrawerProp> "defaultOpen" value
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<IDrawerProp> "inertTrapFocus" value
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling. This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: IReactProperty list) = Interop.mkProperty<IDrawerProp> "backdrop" (!!value |> createObj |> unbox<IReactProperty>)
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling. This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: ReactElement) = Interop.mkProperty<IDrawerProp> "backdrop" value
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
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IDrawerProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IDrawerProp> "mountNode" value

module drawer =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IDrawerProp> "as" "div"

    /// Type of the drawer.
    type [<Erase>] type' =
        static member inline inline' = Interop.mkProperty<IDrawerProp> "type" "inline"
        static member inline overlay = Interop.mkProperty<IDrawerProp> "type" "overlay"

    /// Position of the drawer.
    type [<Erase>] position =
        static member inline start = Interop.mkProperty<IDrawerProp> "position" "start"
        static member inline end' = Interop.mkProperty<IDrawerProp> "position" "end"
        static member inline bottom = Interop.mkProperty<IDrawerProp> "position" "bottom"

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

// -------------------------------------------------------------------------- OverlayDrawer --------------------------------------------------------------------------------------
type [<Erase>] overlayDrawer =
    inherit FelizProps.prop<IOverlayDrawerProp>
    static member inline root (value: IDialogSurfaceProp list) = Interop.mkProperty<IOverlayDrawerProp> "root" (!!value |> createObj |> unbox<IDialogSurfaceProp>)
    /// Controls the open state of the Drawer
    static member inline open' (value: bool) = Interop.mkProperty<IOverlayDrawerProp> "open" value
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<IOverlayDrawerProp> "inertTrapFocus" value
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling. This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: IReactProperty list) = Interop.mkProperty<IOverlayDrawerProp> "backdrop" (!!value |> createObj |> unbox<IReactProperty>)
    /// Dimmed background of dialog. The default backdrop is rendered as a <div> with styling. This slot expects a <div> element which will replace the default backdrop. The backdrop should have aria-hidden="true".
    static member inline backdrop (value: ReactElement) = Interop.mkProperty<IOverlayDrawerProp> "backdrop" value
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IOverlayDrawerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IOverlayDrawerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: MouseEvent -> DialogOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<IOverlayDrawerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: KeyboardEvent -> DialogOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<IOverlayDrawerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<IOverlayDrawerProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<IOverlayDrawerProp> "mountNode" value

module overlayDrawer =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IOverlayDrawerProp> "as" "div"

    /// Position of the drawer.
    type [<Erase>] position =
        static member inline start = Interop.mkProperty<IOverlayDrawerProp> "position" "start"
        static member inline end' = Interop.mkProperty<IOverlayDrawerProp> "position" "end"
        static member inline bottom = Interop.mkProperty<IOverlayDrawerProp> "position" "bottom"

    /// Size of the drawer.
    type [<Erase>] size =
        /// Drawer is 320px wide.
        static member inline small = Interop.mkProperty<IOverlayDrawerProp> "size" "small"
        /// Drawer is 592px wide.
        static member inline medium = Interop.mkProperty<IOverlayDrawerProp> "size" "medium"
        /// Drawer is 940px wide.
        static member inline large = Interop.mkProperty<IOverlayDrawerProp> "size" "large"
        /// Drawer is 100vw wide.
        static member inline full = Interop.mkProperty<IOverlayDrawerProp> "size" "full"

    /// Dialog variations.
    type [<Erase>] modalType =
        /// A special type of modal dialogs that interrupts the user's workflow to communicate an important message or ask for a decision. Unlike a typical modal dialog, the user must take an action through the options given to dismiss the dialog, and it cannot be dismissed through the dimmed background or escape key.
        static member inline alert = Interop.mkProperty<IOverlayDrawerProp> "modalType" "alert"
        /// When this type of dialog is open, the rest of the page is dimmed out and cannot be interacted with. The tab sequence is kept within the dialog and moving the focus outside the dialog will imply closing it. This is the default type of the component.
        static member inline modal = Interop.mkProperty<IOverlayDrawerProp> "modalType" "modal"
        /// When a non-modal dialog is open, the rest of the page is not dimmed out and users can interact with the rest of the page. This also implies that the tab focus can move outside the dialog when it reaches the last focusable element.
        static member inline nonModal = Interop.mkProperty<IOverlayDrawerProp> "modalType" "non-modal"

// -------------------------------------------------------------------------- InlineDrawer --------------------------------------------------------------------------------------
type [<Erase>] inlineDrawer =
    inherit FelizProps.prop<IInlineDrawerProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IInlineDrawerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Controls the open state of the Drawer
    static member inline open' (value: bool) = Interop.mkProperty<IInlineDrawerProp> "open" value
    /// Whether the drawer has a separator line.
    static member inline separator (value: bool) = Interop.mkProperty<IInlineDrawerProp> "separator" value

module inlineDrawer =

    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IInlineDrawerProp> "as" "div"

    /// Position of the drawer.
    type [<Erase>] position =
        static member inline start = Interop.mkProperty<IInlineDrawerProp> "position" "start"
        static member inline end' = Interop.mkProperty<IInlineDrawerProp> "position" "end"
        static member inline bottom = Interop.mkProperty<IInlineDrawerProp> "position" "bottom"

    /// Size of the drawer.
    type [<Erase>] size =
        /// Drawer is 320px wide.
        static member inline small = Interop.mkProperty<IInlineDrawerProp> "size" "small"
        /// Drawer is 592px wide.
        static member inline medium = Interop.mkProperty<IInlineDrawerProp> "size" "medium"
        /// Drawer is 940px wide.
        static member inline large = Interop.mkProperty<IInlineDrawerProp> "size" "large"
        /// Drawer is 100vw wide.
        static member inline full = Interop.mkProperty<IInlineDrawerProp> "size" "full"

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
    static member inline onOpenChange (handler: TreeItemOpenChangeData<'T, 'TEvent> -> unit) = Interop.mkProperty<ITreeItemProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onOpenChange (value: 'TEvent -> TreeItemOpenChangeData<'T, 'TEvent> -> unit)= Interop.mkProperty<ITreeItemProp> "onOpenChange" (System.Func<_,_,_> value)

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

// -------------------------------------------------------------------------- Positioning --------------------------------------------------------------------------------------

type [<Erase>] positioning =
    /// An imperative handle to Popper methods.
    static member inline positioningRef (value: IRefValue<PositioningImperativeRef option>) = Interop.mkProperty<IPositioningProp> "positioningRef" value
    /// Manual override for the target element. Useful for scenarios where a component accepts user prop to override target
    static member inline target (value: Element option) = Interop.mkProperty<IPositioningProp> "target" value
    /// Lets you displace a positioned element from its reference element.
    /// This can be useful if you need to apply some margin between them or if you need to fine tune the
    /// position according to some custom logic.
    static member inline offset (value: IOffsetProp list) = Interop.mkProperty<IPositioningProp> "offset" (!!value |> createObj |> unbox<OffsetObject>)
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
    static member inline overflowBoundaryPadding (value: IOverflowBoundaryPaddingProp list) = Interop.mkProperty<IPositioningProp> "overflowBoundaryPadding" (!!value |> createObj |> unbox<OverflowBoundaryPadding>)
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
    /// Called when a position update has finished. Multiple position updates can happen in a single render, since positioning happens outside of the React lifecycle.
    static member inline onPositioningEnd (value: unit -> unit) = Interop.mkProperty<IPositioningProp> "onPositioningEnd" (System.Func<_,_> value)
    /// Disables the resize observer that updates position on target or dimension change
    static member inline disableUpdateOnResize (value: bool) = Interop.mkProperty<IPositioningProp> "disableUpdateOnResize" value

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

    /// When set, the positioned element matches the chosen dimension(s) of the target element
    type [<Erase>] matchTargetSize =
        static member inline width = Interop.mkProperty<IPositioningProp> "matchTargetSize" "width"

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
    static member inline ignoreDefaultKeydown (value: IIgnoreKeyDownProp list) = Interop.mkProperty<IUseArrowNavigationGroupOptionsProp> "ignoreDefaultKeydown" (!!value |> createObj |> unbox<IgnoreKeyDown>)
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
    static member inline ignoreDefaultKeydown (value: IIgnoreKeyDownProp list) = Interop.mkProperty<IUseFocusableGroupOptionsProp> "ignoreDefaultKeydown" (!!value |> createObj |> unbox)

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
        static member inline vertical = Interop.mkProperty<IVirtualizerMeasurePropsProp> "direction" "vertical"

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
    static member inline defaultCheckedItems (value: 'T list) = Interop.mkProperty<IHeadlessFlatTreeOptionsProp> "defaultCheckedItems" value

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
    type [<Erase>] position =
        static member inline topEnd = Interop.mkProperty<IDispatchToastOptionsProp> "position" "top-end"
        static member inline topStart = Interop.mkProperty<IDispatchToastOptionsProp> "position" "top-start"
        static member inline bottomEnd = Interop.mkProperty<IDispatchToastOptionsProp> "position" "bottom-end"
        static member inline bottomStart = Interop.mkProperty<IDispatchToastOptionsProp> "position" "bottom-start"
        static member inline top = Interop.mkProperty<IDispatchToastOptionsProp> "position" "top"
        static member inline bottom = Interop.mkProperty<IDispatchToastOptionsProp> "position" "bottom"

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
    type [<Erase>] position =
        static member inline topEnd = Interop.mkProperty<IUpdateToastOptionsProp> "position" "top-end"
        static member inline topStart = Interop.mkProperty<IUpdateToastOptionsProp> "position" "top-start"
        static member inline bottomEnd = Interop.mkProperty<IUpdateToastOptionsProp> "position" "bottom-end"
        static member inline bottomStart = Interop.mkProperty<IUpdateToastOptionsProp> "position" "bottom-start"
        static member inline top = Interop.mkProperty<IUpdateToastOptionsProp> "position" "top"
        static member inline bottom = Interop.mkProperty<IUpdateToastOptionsProp> "position" "bottom"

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

// -------------------------------------------------------------------------- Breadcrumb --------------------------------------------------------------------------------------
type [<Erase>] breadcrumb =
    inherit FelizProps.prop<IBreadcrumbProp>
    /// Root element of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IBreadcrumbProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Ordered list which contains items.
    static member inline list (value: IReactProperty list) = Interop.mkProperty<IBreadcrumbProp> "list" (!!value |> createObj |> unbox<IReactProperty>)
    /// Ordered list which contains items.
    static member inline list (value: ReactElement) = Interop.mkProperty<IBreadcrumbProp> "list" value

module breadcrumb =
    type [<Erase>] as' =
        static member inline nav = Interop.mkProperty<IBreadcrumbProp> "as" "nav"

    /// Sets the focus behavior for the Breadcrumb.
    type [<Erase>] focusMode =
        /// This behaviour will cycle through all elements inside of the Breadcrumb when pressing the Tab key and then release focus after the last inner element.
        static member inline tab = Interop.mkProperty<IBreadcrumbProp> "focusMode" "tab"
        /// This behaviour will cycle through all elements inside of the Breadcrumb when pressing the Arrow key.
        static member inline arrow = Interop.mkProperty<IBreadcrumbProp> "focusMode" "arrow"

    /// Controls size of Breadcrumb items and dividers.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IBreadcrumbProp> "size" "small"
        static member inline medium = Interop.mkProperty<IBreadcrumbProp> "size" "medium"
        static member inline large = Interop.mkProperty<IBreadcrumbProp> "size" "large"

// -------------------------------------------------------------------------- BreadcrumbItem --------------------------------------------------------------------------------------
type [<Erase>] breadcrumbItem =
    inherit FelizProps.prop<IBreadcrumbItemProp>
    /// Root element of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IBreadcrumbItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module breadcrumbItem =

    type [<Erase>] as' =
        static member inline li = Interop.mkProperty<IBreadcrumbItemProp> "as" "li"
    /// Controls size of Breadcrumb items and dividers.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IBreadcrumbItemProp> "size" "small"
        static member inline medium = Interop.mkProperty<IBreadcrumbItemProp> "size" "medium"
        static member inline large = Interop.mkProperty<IBreadcrumbItemProp> "size" "large"

// -------------------------------------------------------------------------- BreadcrumbDivider --------------------------------------------------------------------------------------
type [<Erase>] breadcrumbDivider =
    inherit FelizProps.prop<IBreadcrumbDividerProp>
    /// Root element of the component.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IBreadcrumbDividerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module breadcrumbDivider =
    type [<Erase>] as' =
        static member inline li = Interop.mkProperty<IBreadcrumbDividerProp> "as" "li"
// -------------------------------------------------------------------------- BreadcrumbButton --------------------------------------------------------------------------------------
type [<Erase>] breadcrumbButton =
    inherit FelizProps.prop<IBreadcrumbButtonProp>
    /// Root of the component that renders as either a `<button>` tag or an `<a>` tag.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IBreadcrumbButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon that renders either before or after the `children` as specified by the `iconPosition` prop.
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<IBreadcrumbButtonProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon that renders either before or after the `children` as specified by the `iconPosition` prop.
    static member inline icon (value: ReactElement) = Interop.mkProperty<IBreadcrumbButtonProp> "icon" value
    /// Defines current sate of BreadcrumbButton.
    static member inline current (value: bool) = Interop.mkProperty<IBreadcrumbButtonProp> "current" value
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<IBreadcrumbButtonProp> "disabledFocusable" value

module breadcrumbButton =
    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<IBreadcrumbButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<IBreadcrumbButtonProp> "as" "button"

    /// Controls size of Breadcrumb items and dividers.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IBreadcrumbButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<IBreadcrumbButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<IBreadcrumbButtonProp> "size" "large"


// -------------------------------------------------------------------------- PartitionBreadcrumbItemsOptions --------------------------------------------------------------------------------------
type [<Erase>] partitionBreadcrumbItemsOptions =
    static member inline items (value: #seq<'T>) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "items" value
    static member inline maxDisplayedItems (value: int) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "maxDisplayedItems" value
    static member inline maxDisplayedItems (value: float) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "maxDisplayedItems" value
    static member inline maxDisplayedItems (value: decimal) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "maxDisplayedItems" value
    static member inline overflowIndex (value: int) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "overflowIndex" value
    static member inline overflowIndex (value: float) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "overflowIndex" value
    static member inline overflowIndex (value: decimal) = Interop.mkProperty<IPartitionBreadcrumbItemsOptionsProp> "overflowIndex" value

// -------------------------------------------------------------------------- Searchbox --------------------------------------------------------------------------------------
type [<Erase>] searchBox =
    inherit FelizProps.prop<ISearchBoxProp>
    /// WARNING: Searchbox doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children (value: ReactElement) = Interop.mkProperty<ICheckboxProp> "children" value
    /// WARNING: Searchbox doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: ReactElement seq) = Interop.mkProperty<ICheckboxProp> "children" (Interop.reactApi.Children.toArray elems)
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ISearchBoxProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Hidden input that handles the checkbox's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on <Input> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: ReactElement) = Interop.mkProperty<ISearchBoxProp> "input" value
    /// Hidden input that handles the checkbox's functionality.
    /// This is the PRIMARY slot: all native properties specified directly on <Input> will be applied to this slot, except className and style, which remain on the root slot.
    static member inline input (value: IReactProperty list) = Interop.mkProperty<ISearchBoxProp> "input" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element before the input text, within the input border
    static member inline contentBefore (value: ReactElement) = Interop.mkProperty<ISearchBoxProp> "contentBefore" value
    /// Element before the input text, within the input border
    static member inline contentBefore (value: IReactProperty list) = Interop.mkProperty<ISearchBoxProp> "contentBefore" (!!value |> createObj |> unbox<IReactProperty>)
    /// Element after the input text, within the input border
    static member inline contentAfter (value: ReactElement) = Interop.mkProperty<ISearchBoxProp> "contentAfter" value
    /// Element after the input text, within the input border
    static member inline contentAfter (value: IReactProperty list) = Interop.mkProperty<ISearchBoxProp> "contentAfter" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline dismiss (value: IReactProperty list) = Interop.mkProperty<ISearchBoxProp> "dismiss" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline dismiss (value: ReactElement) = Interop.mkProperty<ISearchBoxProp> "dismiss" value
    /// Default value of the input. Provide this if the input should be an uncontrolled component which tracks its current state internally; otherwise, use value.
    /// (This prop is mutually exclusive with value.)
    static member inline defaultValue (value: string) = Interop.mkProperty<ISearchBoxProp> "defaultValue" value
    /// Current value of the input. Provide this if the input is a controlled component where you are maintaining its current state; otherwise, use defaultValue.
    /// (This prop is mutually exclusive with defaultValue.)
    static member inline value (value: string) = Interop.mkProperty<ISearchBoxProp> "value" value
    /// Custom onChange callback.
    /// Will be traditionally supplied with a React.ChangeEvent<HTMLInputElement> for usual character entry.
    /// When the dismiss button is clicked, this will be called with an event of type React.MouseEvent<HTMLSpanElement>
    /// and an empty string as the `value` property of the data parameter
    static member inline onChange (handler: ValueProp<string> -> unit) = Interop.mkProperty<ISearchBoxProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Custom onChange callback.
    /// Will be traditionally supplied with a React.ChangeEvent<HTMLInputElement> for usual character entry.
    /// When the dismiss button is clicked, this will be called with an event of type React.MouseEvent<HTMLSpanElement>
    /// and an empty string as the `value` property of the data parameter
    static member inline onChange (value: ChangeEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ISearchBoxProp> "onChange" (System.Func<_,_,_> value)

module searchBox =
    /// Size of the input (changes the font size and spacing).
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ISearchBoxProp> "size" "small"
        static member inline medium = Interop.mkProperty<ISearchBoxProp> "size" "medium"
        static member inline large = Interop.mkProperty<ISearchBoxProp> "size" "large"

    /// Controls the colors and borders of the input.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<ISearchBoxProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ISearchBoxProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<ISearchBoxProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ISearchBoxProp> "appearance" "filled-lighter"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledDarkerShadow = Interop.mkProperty<ISearchBoxProp> "appearance" "filled-darker-shadow"
        /// WARNING: 'filled-darker-shadow' and 'filled-lighter-shadow' are deprecated and will be removed in the future.
        [<Obsolete>] static member inline filledLighterShadow = Interop.mkProperty<ISearchBoxProp> "appearance" "filled-lighter-shadow"

  /// An input can have different text-based types based on the type of value the user will enter.
    /// Note that no custom styling is currently applied for alternative types, and some types may activate browser-default styling which does not match the Fluent design language.
    type [<Erase>] type' =
        static member inline number = Interop.mkProperty<ISearchBoxProp> "type" "number"
        static member inline time = Interop.mkProperty<ISearchBoxProp> "type" "time"
        static member inline text = Interop.mkProperty<ISearchBoxProp> "type" "text"
        static member inline search = Interop.mkProperty<ISearchBoxProp> "type" "search"
        static member inline tel = Interop.mkProperty<ISearchBoxProp> "type" "tel"
        static member inline url = Interop.mkProperty<ISearchBoxProp> "type" "url"
        static member inline email = Interop.mkProperty<ISearchBoxProp> "type" "email"
        static member inline date = Interop.mkProperty<ISearchBoxProp> "type" "date"
        static member inline datetimeLocal = Interop.mkProperty<ISearchBoxProp> "type" "datetime-local"
        static member inline month = Interop.mkProperty<ISearchBoxProp> "type" "month"
        static member inline password = Interop.mkProperty<ISearchBoxProp> "type" "password"
        static member inline week = Interop.mkProperty<ISearchBoxProp> "type" "week"

// -------------------------------------------------------------------------- Tag --------------------------------------------------------------------------------------
type [<Erase>] tag =
    inherit FelizProps.prop<ITagProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITagProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Slot for an icon or other visual element
    static member inline media (value:  ReactElement) = Interop.mkProperty<ITagProp> "media" value
    /// Slot for an icon or other visual element
    static member inline media (value:  IReactProperty list) = Interop.mkProperty<ITagProp> "media"  (!!value |> createObj |> unbox<IReactProperty>)
    static member inline icon (value:  ReactElement) = Interop.mkProperty<ITagProp> "icon" value
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<ITagProp> "icon"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Main text for the Tag. Children of the root slot are automatically rendered here
    static member inline primaryText (value: string) = Interop.mkProperty<ITagProp> "primaryText" value
    /// Main text for the Tag. Children of the root slot are automatically rendered here
    static member inline primaryText (value: ReactElement) = Interop.mkProperty<ITagProp> "primaryText" value
    /// Main text for the Tag. Children of the root slot are automatically rendered here
    static member inline primaryText (value: IReactProperty list) = Interop.mkProperty<ITagProp> "primaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// Secondary text that describes or complements the main text
    static member inline secondaryText (value: string) = Interop.mkProperty<ITagProp> "secondaryText" value
    /// Secondary text that describes or complements the main text
    static member inline secondaryText (value: ReactElement) = Interop.mkProperty<ITagProp> "secondaryText" value
    /// Secondary text that describes or complements the main text
    static member inline secondaryText (value: IReactProperty list) = Interop.mkProperty<ITagProp> "secondaryText" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline dismissIcon (value: ReactElement) = Interop.mkProperty<ITagProp> "dismissIcon" value
    static member inline dismissIcon (value: IReactProperty list) = Interop.mkProperty<ITagProp> "dismissIcon" (!!value |> createObj |> unbox<IReactProperty>)
    /// A Tag can be dismissible
    static member inline dismissible (value: bool) = Interop.mkProperty<ITagProp> "dismissible" value
    /// Unique value identifying the tag within a TagGroup
    static member inline value (value: string) = Interop.mkProperty<ITagProp> "value" value

module tag =
    type [<Erase>] as' =
        static member inline button = Interop.mkProperty<ITagProp> "as" "button"
        static member inline span = Interop.mkProperty<ITagProp> "as" "span"

    /// A Tag can have filled, outlined or brand experience.
    type [<Erase>] appearance =
        static member inline brand = Interop.mkProperty<ITagProp> "appearance" "brand"
        static member inline filled = Interop.mkProperty<ITagProp> "appearance" "filled"
        static member inline outline = Interop.mkProperty<ITagProp> "appearance" "outline"

    /// A Tag can have rounded or circular shape.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<ITagProp> "shape" "circular"
        static member inline rounded = Interop.mkProperty<ITagProp> "shape" "rounded"

    /// A Tag has three sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITagProp> "size" "small"
        static member inline extraSmall = Interop.mkProperty<ITagProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<ITagProp> "size" "medium"


// -------------------------------------------------------------------------- TagGroup --------------------------------------------------------------------------------------
type [<Erase>] tagGroup =
    inherit FelizProps.prop<ITagGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITagGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Callback for when a tag is dismissed
    static member inline onDismiss (handler: ValueProp<string> -> unit) = Interop.mkProperty<ITagGroupProp> "onDismiss" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback for when a tag is dismissed
    static member inline onDismiss (value: MouseEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ITagGroupProp> "onDismiss" (System.Func<_,_,_> value)
    /// Callback for when a tag is dismissed
    static member inline onDismiss (value: KeyboardEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ITagGroupProp> "onDismiss" (System.Func<_,_,_> value)
    static member inline dismissible (value: bool) = Interop.mkProperty<ITagGroupProp> "dismissible" value

module tagGroup =
    /// A Tag has three sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITagGroupProp> "size" "small"
        static member inline extraSmall = Interop.mkProperty<ITagGroupProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<ITagGroupProp> "size" "medium"

    type [<Erase>] appearance =
        static member inline brand = Interop.mkProperty<ITagGroupProp> "appearance" "brand"
        static member inline filled = Interop.mkProperty<ITagGroupProp> "appearance" "filled"
        static member inline outline = Interop.mkProperty<ITagGroupProp> "appearance" "outline"
// -------------------------------------------------------------------------- interactionTag --------------------------------------------------------------------------------------
type [<Erase>] interactionTag =
    inherit FelizProps.prop<IInteractionTagProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IInteractionTagProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Unique value identifying the tag within a TagGroup
    static member inline value (value: string) = Interop.mkProperty<IInteractionTagProp> "value" value

module interactionTag =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IInteractionTagProp> "as" "div"

    /// A Tag can have filled, outlined or brand experience.
    type [<Erase>] appearance =
        static member inline brand = Interop.mkProperty<IInteractionTagProp> "appearance" "brand"
        static member inline filled = Interop.mkProperty<IInteractionTagProp> "appearance" "filled"
        static member inline outline = Interop.mkProperty<IInteractionTagProp> "appearance" "outline"

    /// A Tag can have rounded or circular shape.
    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<IInteractionTagProp> "shape" "circular"
        static member inline rounded = Interop.mkProperty<IInteractionTagProp> "shape" "rounded"

    /// A Tag has three sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IInteractionTagProp> "size" "small"
        static member inline extraSmall = Interop.mkProperty<IInteractionTagProp> "size" "extra-small"
        static member inline medium = Interop.mkProperty<IInteractionTagProp> "size" "medium"

// -------------------------------------------------------------------------- InteractionTagPrimary --------------------------------------------------------------------------------------
type [<Erase>] interactionTagPrimary =
    inherit FelizProps.prop<IInteractionTagPrimaryProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IInteractionTagPrimaryProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Slot for an icon or other visual element
    static member inline media (value:  ReactElement) = Interop.mkProperty<IInteractionTagPrimaryProp> "media" value
    /// Slot for an icon or other visual element
    static member inline media (value:  IReactProperty list) = Interop.mkProperty<IInteractionTagPrimaryProp> "media"  (!!value |> createObj |> unbox<IReactProperty>)
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IInteractionTagPrimaryProp> "icon" value
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<IInteractionTagPrimaryProp> "icon"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Main text for the InteractionTagPrimary button. Children of the root slot are automatically rendered here
    static member inline primaryText (value: string) = Interop.mkProperty<IInteractionTagPrimaryProp> "primaryText" value
    /// Main text for the InteractionTagPrimary button. Children of the root slot are automatically rendered here
    static member inline primaryText (value: ReactElement) = Interop.mkProperty<IInteractionTagPrimaryProp> "primaryText" value
    /// Main text for the InteractionTagPrimary button. Children of the root slot are automatically rendered here
    static member inline primaryText (value: IReactProperty list) = Interop.mkProperty<IInteractionTagPrimaryProp> "primaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// Secondary text that describes or complements the main text
    static member inline secondaryText (value: string) = Interop.mkProperty<IInteractionTagPrimaryProp> "secondaryText" value
    /// Secondary text that describes or complements the main text
    static member inline secondaryText (value: ReactElement) = Interop.mkProperty<IInteractionTagPrimaryProp> "secondaryText" value
    /// Secondary text that describes or complements the main text
    static member inline secondaryText (value: IReactProperty list) = Interop.mkProperty<IInteractionTagPrimaryProp> "secondaryText" (!!value |> createObj |> unbox<IReactProperty>)
    /// Whether the InteractionTag component has a Secondary component that provides an secondary action. If true, the InteractionTagPrimary component will adjust its styles to accommodate the Secondary component.
    static member inline hasSecondaryAction (value: bool) = Interop.mkProperty<IInteractionTagPrimaryProp> "hasSecondaryAction" value

module interactionTagPrimary =
    type [<Erase>] as' =
        static member inline button = Interop.mkProperty<IInteractionTagPrimaryProp> "as" "button"

// -------------------------------------------------------------------------- InteractionTagSecondary --------------------------------------------------------------------------------------
type [<Erase>] interactionTagSecondary =
    inherit FelizProps.prop<IInteractionTagSecondaryProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IInteractionTagSecondaryProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module interactionTagSecondary =
    type [<Erase>] as' =
        static member inline button = Interop.mkProperty<IInteractionTagSecondaryProp> "as" "button"
// -------------------------------------------------------------------------- TableColumnSizingOptions --------------------------------------------------------------------------------------
type [<Erase>] tableColumnSizingOptions =
    static member inline minWidth (value: int) = Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" value
    static member inline minWidth (value: float) = Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" value
    static member inline minWidth (value: decimal) = Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" value
    static member inline idealWidth (value: int) = Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" value
    static member inline idealWidth (value: float) = Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" value
    static member inline idealWidth (value: decimal) = Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" value
    static member inline padding (value: int) = Interop.mkProperty<ITableColumnSizingOptionsProp> "padding" value
    static member inline padding (value: float) = Interop.mkProperty<ITableColumnSizingOptionsProp> "padding" value
    static member inline padding (value: decimal) = Interop.mkProperty<ITableColumnSizingOptionsProp> "padding" value
    static member inline defaultWidth (value: int) = Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" value
    static member inline defaultWidth (value: float) = Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" value
    static member inline defaultWidth (value: decimal) = Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" value
    /// Using this property is the same as setting the minWidth, defaultWidth, and idealWidth to all be the same number.
    /// This is a custom helper property to make setting columns widths easier and more user friendly.
    ///
    /// **NOTE**: Without setting `dataGrid.resizeableColumns true`, this property won't do anything.
    ///
    /// **NOTE**: For this column's width to truly be static, use this property for every column. Otherwise, the user can still resize the surrounding columns.
    static member inline staticColumnWidth (columnId: 'TKeyType, columnWidth: int) : 'TKeyType * ITableColumnSizingOptionsProp list =
        columnId, [
            Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" columnWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" columnWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" columnWidth
        ]
    /// Using this property is the same as setting the minWidth, defaultWidth, and idealWidth to all be the same number.
    /// This is a custom helper property to make setting columns widths easier and more user friendly.
    ///
    /// **NOTE**: Without setting `dataGrid.resizeableColumns true`, this property won't do anything.
    ///
    /// **NOTE**: For this column's width to truly be static, use this property for every column. Otherwise, the user can still resize the surrounding columns.
    static member inline staticColumnWidth (columnId: 'TKeyType, columnWidth: float) : 'TKeyType * ITableColumnSizingOptionsProp list =
        columnId, [
            Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" columnWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" columnWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" columnWidth
        ]
    /// Using this property is the same as setting the minWidth, defaultWidth, and idealWidth to all be the same number.
    /// This is a custom helper property to make setting columns widths easier and more user friendly.
    ///
    /// **NOTE**: Without setting `dataGrid.resizeableColumns true`, this property won't do anything.
    ///
    /// **NOTE**: For this column's width to truly be static, use this property for every column. Otherwise, the user can still resize the surrounding columns.
    static member inline staticColumnWidth (columnId: 'TKeyType, columnWidth: decimal) : 'TKeyType * ITableColumnSizingOptionsProp list =
        columnId, [
            Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" columnWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" columnWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" columnWidth
        ]
    /// Used to set the minWidth, defaultWidth, and idealWidth of the specified column.
    /// This is a custom helper property to make setting columns widths easier.
    ///
    /// **NOTE**: Without setting `dataGrid.resizeableColumns true`, this property won't do anything.
    static member inline resizeableColumnWidth (columnId: 'TKeyType, minWidth: int, defaultWidth: int, idealWidth: int) : 'TKeyType * ITableColumnSizingOptionsProp list =
        columnId, [
            Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" minWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" defaultWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" idealWidth
        ]
    /// Used to set the minWidth, defaultWidth, and idealWidth of the specified column.
    /// This is a custom helper property to make setting columns widths easier.
    ///
    /// **NOTE**: Without setting `dataGrid.resizeableColumns true`, this property won't do anything.
    static member inline resizeableColumnWidth (columnId: 'TKeyType, minWidth: float, defaultWidth: float, idealWidth: float) : 'TKeyType * ITableColumnSizingOptionsProp list =
        columnId, [
            Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" minWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" defaultWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" idealWidth
        ]
    /// Used to set the minWidth, defaultWidth, and idealWidth of the specified column.
    /// This is a custom helper property to make setting columns widths easier.
    ///
    /// **NOTE**: Without setting `dataGrid.resizeableColumns true`, this property won't do anything.
    static member inline resizeableColumnWidth (columnId: 'TKeyType, minWidth: decimal, defaultWidth: decimal, idealWidth: decimal) : 'TKeyType * ITableColumnSizingOptionsProp list =
        columnId, [
            Interop.mkProperty<ITableColumnSizingOptionsProp> "minWidth" minWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "defaultWidth" defaultWidth
            Interop.mkProperty<ITableColumnSizingOptionsProp> "idealWidth" idealWidth
        ]

// -------------------------------------------------------------------------- IgnoreKeyDown --------------------------------------------------------------------------------------
type [<Erase>] ignoreKeyDown =
    static member inline tab (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "Tab" value
    static member inline escape (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "Escape" value
    static member inline enter (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "Enter" value
    static member inline arrowUp (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "ArrowUp" value
    static member inline arrowDown (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "ArrowDown" value
    static member inline arrowLeft (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "ArrowLeft" value
    static member inline arrowRight (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "ArrowRight" value
    static member inline pageUp (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "PageUp" value
    static member inline pageDown (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "PageDown" value
    static member inline end' (value: bool) = Interop.mkProperty<IIgnoreKeyDownProp> "End" value

// -------------------------------------------------------------------------- OverflowBoundaryPadding --------------------------------------------------------------------------------------
type [<Erase>] overflowBoundaryPadding =
    static member inline top (value: int) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "top" value
    static member inline top (value: float) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "top" value
    static member inline top (value: decimal) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "top" value
    static member inline end' (value: int) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "end" value
    static member inline end' (value: float) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "end" value
    static member inline end' (value: decimal) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "end" value
    static member inline bottom (value: int) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "bottom" value
    static member inline bottom (value: float) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "bottom" value
    static member inline bottom (value: decimal) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "bottom" value
    static member inline start (value: int) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "start" value
    static member inline start (value: float) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "start" value
    static member inline start (value: decimal) = Interop.mkProperty<IOverflowBoundaryPaddingProp> "start" value

// -------------------------------------------------------------------------- Offset --------------------------------------------------------------------------------------
type [<Erase>] offset =
    static member inline crossAxis (value: int) = Interop.mkProperty<IOffsetProp> "crossAxis" value
    static member inline crossAxis (value: decimal) = Interop.mkProperty<IOffsetProp> "crossAxis" value
    static member inline crossAxis (value: float) = Interop.mkProperty<IOffsetProp> "crossAxis" value
    static member inline mainAxis (value: int) = Interop.mkProperty<IOffsetProp> "mainAxis" value
    static member inline mainAxis (value: decimal) = Interop.mkProperty<IOffsetProp> "mainAxis" value
    static member inline mainAxis (value: float) = Interop.mkProperty<IOffsetProp> "mainAxis" value

// -------------------------------------------------------------------------- VirtualizerContext --------------------------------------------------------------------------------------
type [<Erase>] virtualizerContextProps =
    static member inline contextIndex (value: int) = Interop.mkProperty<IVirtualizerContextProp> "contextIndex" value
    static member inline contextIndex (value: decimal) = Interop.mkProperty<IVirtualizerContextProp> "contextIndex" value
    static member inline contextIndex (value: float) = Interop.mkProperty<IVirtualizerContextProp> "contextIndex" value
    static member inline setContextIndex (value: int -> unit) = Interop.mkProperty<IVirtualizerContextProp> "setContextIndex" (System.Func<_,_> value)
    static member inline setContextIndex (value: decimal -> unit) = Interop.mkProperty<IVirtualizerContextProp> "setContextIndex" (System.Func<_,_> value)
    static member inline setContextIndex (value: float -> unit) = Interop.mkProperty<IVirtualizerContextProp> "setContextIndex" (System.Func<_,_> value)

// -------------------------------------------------------------------------- MessageBar --------------------------------------------------------------------------------------
type [<Erase>] messageBar =
    inherit FelizProps.prop<IMessageBarProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMessageBarProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline icon (value:  ReactElement) = Interop.mkProperty<IMessageBarProp> "icon" value
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<IMessageBarProp> "icon"  (!!value |> createObj |> unbox<IReactProperty>)
    /// Rendered when the component is in multiline layout to guarantee correct spacing even if no actions are rendered. When actions are rendered, the default actions grid area will render over this element
    static member inline bottomReflowSpacer (value:  ReactElement) = Interop.mkProperty<IMessageBarProp> "bottomReflowSpacer" value
    /// Rendered when the component is in multiline layout to guarantee correct spacing even if no actions are rendered. When actions are rendered, the default actions grid area will render over this element
    static member inline bottomReflowSpacer (value:  IReactProperty list) = Interop.mkProperty<IMessageBarProp> "bottomReflowSpacer"  (!!value |> createObj |> unbox<IReactProperty>)

module messageBar =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IMessageBarProp> "as"  "div"
    type [<Erase>] layout =
        static member inline multiline = Interop.mkProperty<IMessageBarProp> "layout"  "multiline"
        static member inline singleline = Interop.mkProperty<IMessageBarProp> "layout"  "singleline"
        static member inline auto = Interop.mkProperty<IMessageBarProp> "layout"  "auto"
    /// Default designs announcement presets
    type [<Erase>] intent =
        static member inline info = Interop.mkProperty<IMessageBarProp> "intent"  "info"
        static member inline success = Interop.mkProperty<IMessageBarProp> "intent"  "success"
        static member inline warning = Interop.mkProperty<IMessageBarProp> "intent"  "warning"
        static member inline error = Interop.mkProperty<IMessageBarProp> "intent"  "error"
    /// See https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Live_Regions
    type [<Erase>] politeness =
        static member inline assertive = Interop.mkProperty<IMessageBarProp> "politeness"  "assertive"
        static member inline polite = Interop.mkProperty<IMessageBarProp> "politeness"  "polite"
    /// Use square for page level messages and rounded for component level messages
    type [<Erase>] shape =
        static member inline square = Interop.mkProperty<IMessageBarProp> "shape"  "square"
        static member inline rounded = Interop.mkProperty<IMessageBarProp> "shape"  "rounded"

// -------------------------------------------------------------------------- MessageBarBody --------------------------------------------------------------------------------------
type [<Erase>] messageBarBody =
    inherit FelizProps.prop<IMessageBarBodyProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMessageBarBodyProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module messageBarBody =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IMessageBarBodyProp> "as"  "div"
// -------------------------------------------------------------------------- MessageBarTitle --------------------------------------------------------------------------------------
type [<Erase>] messageBarTitle =
    inherit FelizProps.prop<IMessageBarTitleProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMessageBarTitleProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

module messageBarTitle =
    type [<Erase>] as' =
        static member inline span = Interop.mkProperty<IMessageBarTitleProp> "as"  "span"
// -------------------------------------------------------------------------- MessageBarActions --------------------------------------------------------------------------------------
type [<Erase>] messageBarActions =
    inherit FelizProps.prop<IMessageBarActionsProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMessageBarActionsProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Generally the 'Dismiss' button for the MessageBar
    static member inline containerAction (value: ReactElement) = Interop.mkProperty<IMessageBarActionsProp> "containerAction" value
    /// Generally the 'Dismiss' button for the MessageBar
    static member inline containerAction (value: IReactProperty list) = Interop.mkProperty<IMessageBarActionsProp> "containerAction" (!!value |> createObj |> unbox<IReactProperty>)

module messageBarActions =
    type [<Erase>] as' =
        static member inline div = Interop.mkProperty<IMessageBarActionsProp> "as"  "div"
// -------------------------------------------------------------------------- MessageBarGroup --------------------------------------------------------------------------------------
type [<Erase>] messageBarGroup =
    inherit FelizProps.prop<IMessageBarGroupProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<IMessageBarGroupProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
module messageBarGroup =
    type [<Erase>] animate =
        static member inline exitOnly = Interop.mkProperty<IMessageBarGroupProp> "animate" "exit-only"
        static member inline both = Interop.mkProperty<IMessageBarGroupProp> "animate" "both"
// -------------------------------------------------------------------------- TimePicker --------------------------------------------------------------------------------------
type [<Erase>] timePicker =
    inherit FelizProps.prop<ITimePickerProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITimePickerProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline listbox (value: ReactElement) = Interop.mkProperty<ITimePickerProp> "listbox" value
    static member inline listbox (value: IListboxProp list) = Interop.mkProperty<ITimePickerProp> "listbox" (!!value |> createObj |> unbox<IListboxProp>)
    static member inline input (value: ReactElement) = Interop.mkProperty<ITimePickerProp> "input" value
    static member inline input (value: IReactProperty list) = Interop.mkProperty<ITimePickerProp> "input" (!!value |> createObj |> unbox)
    static member inline expandIcon (value: ReactElement) = Interop.mkProperty<ITimePickerProp> "expandIcon" value
    static member inline expandIcon (value: IReactProperty list) = Interop.mkProperty<ITimePickerProp> "expandIcon" (!!value |> createObj |> unbox)
    static member inline clearIcon (value: ReactElement) = Interop.mkProperty<ITimePickerProp> "clearIcon" value
    static member inline clearIcon (value: IReactProperty list) = Interop.mkProperty<ITimePickerProp> "clearIcon" (!!value |> createObj |> unbox)
    /// Time increment, in minutes, of the options in the dropdown.
    static member inline increment (value: int) = Interop.mkProperty<ITimePickerProp> "increment" value
    /// Time increment, in minutes, of the options in the dropdown.
    static member inline increment (value: decimal) = Interop.mkProperty<ITimePickerProp> "increment" value
    /// Time increment, in minutes, of the options in the dropdown.
    static member inline increment (value: float) = Interop.mkProperty<ITimePickerProp> "increment" value
    /// The date in which all dropdown options are based off of.
    static member inline dateAnchor (value: DateTime) = Interop.mkProperty<ITimePickerProp> "dateAnchor" value
    /// Currently selected time in the TimePicker.
    static member inline selectedTime (value: DateTime option) = Interop.mkProperty<ITimePickerProp> "selectedTime" value
    /// Default selected time in the TimePicker, for uncontrolled scenarios.
    static member inline defaultSelectedTime (value: DateTime) = Interop.mkProperty<ITimePickerProp> "defaultSelectedTime" value
    /// The default open state when open is uncontrolled
    static member inline defaultOpen (value: bool) = Interop.mkProperty<ITimePickerProp> "defaultOpen" value
    /// The default value displayed in the trigger input or button when the combobox's value is uncontrolled
    static member inline defaultValue (value: string) = Interop.mkProperty<ITimePickerProp> "defaultValue" value
    /// Render the combobox's popup inline in the DOM. This has accessibility benefits, particularly for touch screen readers.
    static member inline inlinePopup (value: bool) = Interop.mkProperty<ITimePickerProp> "inlinePopup" value
    /// Sets the open/closed state of the dropdown. Use together with onOpenChange to fully control the dropdown's visibility.
    static member inline open' (value: bool) = Interop.mkProperty<ITimePickerProp> "open" value
    /// Configure the positioning of the combobox dropdown
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<ITimePickerProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)
    /// The value displayed by the Combobox. Use this with `onOptionSelect` to directly control the displayed value string.
    static member inline value (value: string list) = Interop.mkProperty<ITimePickerProp> "value" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<ITimePickerProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<ITimePickerProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline freeform (value: bool) = Interop.mkProperty<ITimePickerProp> "freeform" value
    /// If true, show seconds in the dropdown options and consider seconds for default validation purposes.
    static member inline showSeconds (value: bool) = Interop.mkProperty<ITimePickerProp> "showSeconds" value
    /// Callback for when a time selection is made.
    static member inline onTimeChange (handler: TimeSelectionData -> unit) = Interop.mkProperty<ITimePickerProp> "onTimeChange" (System.Func<_,_,_> (fun _ value -> handler (value |> TimeSelectionData.parse)))
    /// Callback for when a time selection is made.
    static member inline onTimeChange (value: MouseEvent -> TimeSelectionData -> unit) = Interop.mkProperty<ITimePickerProp> "onTimeChange" (System.Func<_,_,_> (fun ev data -> value ev (data |> TimeSelectionData.parse)))
    /// Callback for when a time selection is made.
    static member inline onTimeChange (value: KeyboardEvent -> TimeSelectionData -> unit) = Interop.mkProperty<ITimePickerProp> "onTimeChange" (System.Func<_,_,_> (fun ev data -> value ev (data |> TimeSelectionData.parse)))
    /// Callback for when a time selection is made.
    static member inline onTimeChange (value: FocusEvent -> TimeSelectionData -> unit) = Interop.mkProperty<ITimePickerProp> "onTimeChange" (System.Func<_,_,_> (fun ev data -> value ev (data |> TimeSelectionData.parse)))
    /// Customizes the formatting of date strings displayed in dropdown options.
    static member inline formatDateToTimeString (value: DateTime -> string) = Interop.mkProperty<ITimePickerProp> "formatDateToTimeString" (System.Func<_,_> value)
    /// In the freeform TimePicker, customizes the parsing from the input time string into a Date and provides custom validation.
    static member inline parseTimeStringToDate (value: string option -> TimeStringValidationResult) = Interop.mkProperty<ITimePickerProp> "parseTimeStringToDate" (System.Func<_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (handler: OpenProp -> unit) = Interop.mkProperty<ITimePickerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: MouseEvent -> OpenProp -> unit) = Interop.mkProperty<ITimePickerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: KeyboardEvent -> OpenProp -> unit) = Interop.mkProperty<ITimePickerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback when the open/closed state of the dropdown changes
    static member inline onOpenChange (value: FocusEvent -> OpenProp -> unit) = Interop.mkProperty<ITimePickerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// If set, the timepicker will show an icon to clear the current value.
    static member inline clearable (value: bool) = Interop.mkProperty<ITimePickerProp> "clearable" value

module timePicker =

    type [<Erase>] as' =
        static member inline input = Interop.mkProperty<ITimePickerProp> "as" "input"

    /// Controls the colors and borders of the combobox trigger.
    type [<Erase>] appearance =
        static member inline outline = Interop.mkProperty<ITimePickerProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ITimePickerProp> "appearance" "underline"
        static member inline filledDarker = Interop.mkProperty<ITimePickerProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ITimePickerProp> "appearance" "filled-lighter"

    /// Controls the size of the combobox faceplate
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITimePickerProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITimePickerProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITimePickerProp> "size" "large"

    /// A string value indicating whether the 12-hour format ("h11", "h12") or the 24-hour format ("h23", "h24") should be used.
    type [<Erase>] hourCycle =
        /// 'h11' and 'h23' start with hour 0 and go up to 11 and 23 respectively.
        static member inline h11 = Interop.mkProperty<ITimePickerProp> "hourCycle" "h11"
        /// 'h12' and 'h24' start with hour 1 and go up to 12 and 24 respectively.
        static member inline h12 = Interop.mkProperty<ITimePickerProp> "hourCycle" "h12"
        /// 'h11' and 'h23' start with hour 0 and go up to 11 and 23 respectively.
        static member inline h23 = Interop.mkProperty<ITimePickerProp> "hourCycle" "h23"
        /// 'h12' and 'h24' start with hour 1 and go up to 12 and 24 respectively.
        static member inline h24 = Interop.mkProperty<ITimePickerProp> "hourCycle" "h24"

    /// Start hour (inclusive) for the time range, 0-24.
    type [<Erase>] startHour =
        static member inline ``0`` = Interop.mkProperty<ITimePickerProp> "startHour" "0"
        static member inline ``1`` = Interop.mkProperty<ITimePickerProp> "startHour" "1"
        static member inline ``2`` = Interop.mkProperty<ITimePickerProp> "startHour" "2"
        static member inline ``3`` = Interop.mkProperty<ITimePickerProp> "startHour" "3"
        static member inline ``4`` = Interop.mkProperty<ITimePickerProp> "startHour" "4"
        static member inline ``5`` = Interop.mkProperty<ITimePickerProp> "startHour" "5"
        static member inline ``6`` = Interop.mkProperty<ITimePickerProp> "startHour" "6"
        static member inline ``7`` = Interop.mkProperty<ITimePickerProp> "startHour" "7"
        static member inline ``8`` = Interop.mkProperty<ITimePickerProp> "startHour" "8"
        static member inline ``9`` = Interop.mkProperty<ITimePickerProp> "startHour" "9"
        static member inline ``10`` = Interop.mkProperty<ITimePickerProp> "startHour" "10"
        static member inline ``11`` = Interop.mkProperty<ITimePickerProp> "startHour" "11"
        static member inline ``12`` = Interop.mkProperty<ITimePickerProp> "startHour" "12"
        static member inline ``13`` = Interop.mkProperty<ITimePickerProp> "startHour" "13"
        static member inline ``14`` = Interop.mkProperty<ITimePickerProp> "startHour" "14"
        static member inline ``15`` = Interop.mkProperty<ITimePickerProp> "startHour" "15"
        static member inline ``16`` = Interop.mkProperty<ITimePickerProp> "startHour" "16"
        static member inline ``17`` = Interop.mkProperty<ITimePickerProp> "startHour" "17"
        static member inline ``18`` = Interop.mkProperty<ITimePickerProp> "startHour" "18"
        static member inline ``19`` = Interop.mkProperty<ITimePickerProp> "startHour" "19"
        static member inline ``20`` = Interop.mkProperty<ITimePickerProp> "startHour" "20"
        static member inline ``21`` = Interop.mkProperty<ITimePickerProp> "startHour" "21"
        static member inline ``22`` = Interop.mkProperty<ITimePickerProp> "startHour" "22"
        static member inline ``23`` = Interop.mkProperty<ITimePickerProp> "startHour" "23"
        static member inline ``24`` = Interop.mkProperty<ITimePickerProp> "startHour" "24"

    /// End hour (exclusive) for the time range, 0-24.
    type [<Erase>] endHour =
        static member inline ``0`` = Interop.mkProperty<ITimePickerProp> "endHour" "0"
        static member inline ``1`` = Interop.mkProperty<ITimePickerProp> "endHour" "1"
        static member inline ``2`` = Interop.mkProperty<ITimePickerProp> "endHour" "2"
        static member inline ``3`` = Interop.mkProperty<ITimePickerProp> "endHour" "3"
        static member inline ``4`` = Interop.mkProperty<ITimePickerProp> "endHour" "4"
        static member inline ``5`` = Interop.mkProperty<ITimePickerProp> "endHour" "5"
        static member inline ``6`` = Interop.mkProperty<ITimePickerProp> "endHour" "6"
        static member inline ``7`` = Interop.mkProperty<ITimePickerProp> "endHour" "7"
        static member inline ``8`` = Interop.mkProperty<ITimePickerProp> "endHour" "8"
        static member inline ``9`` = Interop.mkProperty<ITimePickerProp> "endHour" "9"
        static member inline ``10`` = Interop.mkProperty<ITimePickerProp> "endHour" "10"
        static member inline ``11`` = Interop.mkProperty<ITimePickerProp> "endHour" "11"
        static member inline ``12`` = Interop.mkProperty<ITimePickerProp> "endHour" "12"
        static member inline ``13`` = Interop.mkProperty<ITimePickerProp> "endHour" "13"
        static member inline ``14`` = Interop.mkProperty<ITimePickerProp> "endHour" "14"
        static member inline ``15`` = Interop.mkProperty<ITimePickerProp> "endHour" "15"
        static member inline ``16`` = Interop.mkProperty<ITimePickerProp> "endHour" "16"
        static member inline ``17`` = Interop.mkProperty<ITimePickerProp> "endHour" "17"
        static member inline ``18`` = Interop.mkProperty<ITimePickerProp> "endHour" "18"
        static member inline ``19`` = Interop.mkProperty<ITimePickerProp> "endHour" "19"
        static member inline ``20`` = Interop.mkProperty<ITimePickerProp> "endHour" "20"
        static member inline ``21`` = Interop.mkProperty<ITimePickerProp> "endHour" "21"
        static member inline ``22`` = Interop.mkProperty<ITimePickerProp> "endHour" "22"
        static member inline ``23`` = Interop.mkProperty<ITimePickerProp> "endHour" "23"
        static member inline ``24`` = Interop.mkProperty<ITimePickerProp> "endHour" "24"

    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<ITimePickerProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<ITimePickerProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<ITimePickerProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<ITimePickerProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<ITimePickerProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<ITimePickerProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<ITimePickerProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<ITimePickerProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<ITimePickerProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<ITimePickerProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<ITimePickerProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<ITimePickerProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- TeachingPopover --------------------------------------------------------------------------------------
type [<Erase>] teachingPopover =
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: HTMLElement option) = Interop.mkProperty<ITeachingPopoverProp> "mountNode" value
    /// Where the portal children are mounted on DOM
    static member inline mountNode (value: MountNode) = Interop.mkProperty<ITeachingPopoverProp> "mountNode" value
    /// Can contain two children including PopoverTrigger and PopoverSurface. Alternatively can only contain PopoverSurface if using a custom target.
    static member inline children (value: ReactElement) = Interop.mkProperty<ITeachingPopoverProp> "children" value
    /// WARNING: Can contain no more than two children including PopoverTrigger and PopoverSurface.
    /// If you try to use more than two children, only the first two you pass to this function will be used.
    /// Alternatively can only contain PopoverSurface if using a custom target.
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l <= 2 -> elems
            | _ -> elems |> Seq.take 2
        Interop.mkProperty<ITeachingPopoverProp> "children" (Interop.reactApi.Children.toArray elemsToUse)
    /// Close when scroll outside of it
    static member inline closeOnScroll (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "closeOnScroll" value
    /// Used to set the initial open state of the Popover in uncontrolled mode
    static member inline defaultOpen (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "defaultOpen" value
    /// Popovers are rendered out of DOM order on document.body by default, use this to render the popover in DOM order
    static member inline' (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "inline" value
    /// Sets the delay for closing popover on mouse leave
    static member inline mouseLeaveDelay (value: int) = Interop.mkProperty<ITeachingPopoverProp> "mouseLeaveDelay" value
    /// Display an arrow pointing to the target.
    static member inline withArrow (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "withArrow" value
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (handler: OpenProp -> unit) = Interop.mkProperty<ITeachingPopoverProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: MouseEvent -> OpenProp -> unit) = Interop.mkProperty<ITeachingPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: TouchEvent -> OpenProp -> unit) = Interop.mkProperty<ITeachingPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: FocusEvent -> OpenProp -> unit) = Interop.mkProperty<ITeachingPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Call back when the component requests to change value The open value is used as a hint when directly controlling the component
    static member inline onOpenChange (value: KeyboardEvent -> OpenProp -> unit) = Interop.mkProperty<ITeachingPopoverProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Controls the opening of the Popover
    static member inline open' (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "open" value
    /// Flag to open the Popover as a context menu. Disables all other interactions
    static member inline openOnContext (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "openOnContext" value
    /// Flag to open the Popover by hovering the trigger
    static member inline openOnHover (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "openOnHover" value
    // Should trap focus
    static member inline trapFocus (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "trapFocus" value
    /// Must be used with the trapFocus prop Enables older Fluent UI focus trap behavior where the user cannot tab into the window outside of the document.
    /// This is now non-standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert.
    static member inline legacyTrapFocus (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "legacyTrapFocus" value
    /// Enables standard behavior according to the HTML dialog spec where the focus trap involves setting outside elements inert,
    /// making navigation leak from the trapped area back to the browser toolbar and vice-versa.
    static member inline inertTrapFocus (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "inertTrapFocus" value
    /// By default Popover focuses the first focusable element in PopoverSurface on open. Specify disableAutoFocus to prevent this behavior.
    static member inline unstable_disableAutoFocus (value: bool) = Interop.mkProperty<ITeachingPopoverProp> "unstable_disableAutoFocus" value
    /// Configures the positioned popover
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<ITeachingPopoverProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)

module teachingPopover =
    type [<Erase>] appearance =
        static member inline brand = Interop.mkProperty<ITeachingPopoverProp> "appearance" "brand"
        static member inline inverted = Interop.mkProperty<ITeachingPopoverProp> "appearance" "inverted"

    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITeachingPopoverProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITeachingPopoverProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITeachingPopoverProp> "size" "large"

    /// Configures the positioned popover
    type [<Erase>] positioning =
        static member inline above = Interop.mkProperty<ITeachingPopoverProp> "positioning" "above"
        static member inline aboveStart = Interop.mkProperty<ITeachingPopoverProp> "positioning" "above-start"
        static member inline aboveEnd = Interop.mkProperty<ITeachingPopoverProp> "positioning" "above-end"
        static member inline below = Interop.mkProperty<ITeachingPopoverProp> "positioning" "below"
        static member inline belowStart = Interop.mkProperty<ITeachingPopoverProp> "positioning" "below-start"
        static member inline belowEnd = Interop.mkProperty<ITeachingPopoverProp> "positioning" "below-end"
        static member inline before = Interop.mkProperty<ITeachingPopoverProp> "positioning" "before"
        static member inline beforeTop = Interop.mkProperty<ITeachingPopoverProp> "positioning" "before-top"
        static member inline beforeBottom = Interop.mkProperty<ITeachingPopoverProp> "positioning" "before-bottom"
        static member inline after = Interop.mkProperty<ITeachingPopoverProp> "positioning" "after"
        static member inline afterTop = Interop.mkProperty<ITeachingPopoverProp> "positioning" "after-top"
        static member inline afterBottom = Interop.mkProperty<ITeachingPopoverProp> "positioning" "after-bottom"

// -------------------------------------------------------------------------- TeachingPopoverTrigger --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverTrigger =
    static member inline children (value: ReactElement) = Interop.mkProperty<ITeachingPopoverTriggerProp> "children" value
    static member inline children (value: PopoverTriggerChildProps -> ReactElement) = Interop.mkProperty<ITeachingPopoverTriggerProp> "children" (System.Func<_,_> value)
    /// Disables internal trigger mechanism that ensures a child provided will be a compliant ARIA button.
    static member inline disableButtonEnhancement (value: bool) = Interop.mkProperty<ITeachingPopoverTriggerProp> "disableButtonEnhancement" value

// -------------------------------------------------------------------------- TeachingPopoverSurface --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverSurface =
    inherit FelizProps.prop<ITeachingPopoverSurfaceProp>
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverSurfaceProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- TeachingPopoverHeader --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverHeader =
    inherit FelizProps.prop<ITeachingPopoverHeaderProp>
    /// The element wrapping the text and close button. By default this is an h3, but can be a div.
    /// Be sure to include role and aria heading level if div is used.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverHeaderProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The element wrapping the text and close button. By default this is an h3, but can be a div.
    /// Be sure to include role and aria heading level if div is used.
    static member inline root (value: ReactElement) = Interop.mkProperty<ITeachingPopoverHeaderProp> "root" value
    /// The component to be used as close button in heading
    static member inline dismissButton (value: ReactElement) = Interop.mkProperty<ITeachingPopoverHeaderProp> "dismissButton" value
    /// The component to be used as close button in heading
    static member inline dismissButton (value: IButtonProp list) = Interop.mkProperty<ITeachingPopoverHeaderProp> "dismissButton" (!!value |> createObj |> unbox)
    /// The component to be used as close button in heading
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverHeaderProp> "icon" (!!value |> createObj |> unbox)
    /// The component to be used as close button in heading
    static member inline icon (value: ReactElement) = Interop.mkProperty<ITeachingPopoverHeaderProp> "icon" value

// -------------------------------------------------------------------------- TeachingPopoverBody --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverBody =
    inherit FelizProps.prop<ITeachingPopoverBodyProp>
    /// The element wrapping the buttons.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverBodyProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Optional Media Content.
    static member inline media (value: ReactElement) = Interop.mkProperty<ITeachingPopoverBodyProp> "media" value
    /// Optional Media Content.
    static member inline media (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverBodyProp> "media" (!!value |> createObj |> unbox<ITeachingPopoverBodyProp>)

    type [<Erase>] mediaLength =
        static member inline short = Interop.mkProperty<ITeachingPopoverBodyProp> "mediaLength" "short"
        static member inline medium = Interop.mkProperty<ITeachingPopoverBodyProp> "mediaLength" "medium"
        static member inline tall = Interop.mkProperty<ITeachingPopoverBodyProp> "mediaLength" "tall"

// -------------------------------------------------------------------------- TeachingPopoverTitle --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverTitle =
    inherit FelizProps.prop<ITeachingPopoverTitleProp>
    /// Title for teaching bubble
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverTitleProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Title for teaching bubble
    static member inline dismissButton (value: ReactElement) = Interop.mkProperty<ITeachingPopoverTitleProp> "dismissButton" value
    /// An alternate close button path if not placed in the TeachingPopoverHeader
    static member inline dismissButton (value: IButtonProp list) = Interop.mkProperty<ITeachingPopoverTitleProp> "dismissButton" (!!value |> createObj |> unbox)

// -------------------------------------------------------------------------- TeachingPopoverCarouselFooter --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverCarouselFooter =
    inherit FelizProps.prop<ITeachingPopoverCarouselFooterProp>
    /// Title for teaching bubble
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The previous button slot.
    static member inline previous (value: ITeachingPopoverCarouselFooterButtonProp list) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "previous" (!!value |> createObj |> unbox)
    /// The previous button slot.
    static member inline previous (value: string) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "previous" value
    /// The previous button slot.
    static member inline previous (value: ReactElement) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "previous" value
    /// The next button slot.
    static member inline next (value: ITeachingPopoverCarouselFooterButtonProp list) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "next" (!!value |> createObj |> unbox)
    /// The next button slot.
    static member inline next (value: string) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "next" value
    /// The next button slot.
    static member inline next (value: ReactElement) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "next" value
    /// The text to be displayed on the initial step of carousel
    static member inline initialStepText (value: string) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "initialStepText" value
    /// The text to be displayed on the final step of carousel
    static member inline finalStepText (value: string) = Interop.mkProperty<ITeachingPopoverCarouselFooterProp> "finalStepText" value

module teachingPopoverCarouselFooter =
    type [<Erase>] layout =
        static member inline offset = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "layout" "offset"
        static member inline centered = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "layout" "centered"

// -------------------------------------------------------------------------- TeachingPopoverCarouselFooterButton --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverCarouselFooterButton =
    inherit FelizProps.prop<ITeachingPopoverCarouselFooterButtonProp>
    /// Title for teaching bubble
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The ReactNode provided to the button when it is on it's first (navType 'prev') or last (navType 'next') step
    static member inline altText (value: ReactElement) = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "altText" value
    /// The ReactNode provided to the button when it is on it's first (navType 'prev') or last (navType 'next') step
    static member inline altText (value: string) = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "altText" value
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value:  ReactElement) = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "icon" value
    /// Icon that renders either before or after the children as specified by the iconPosition prop.
    static member inline icon (value:  IReactProperty list) = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "icon" (!!value |> createObj |> unbox<IReactProperty>)
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    /// When set, allows the button to be focusable even when it has been disabled.
    /// This is used in scenarios where it is important to keep a consistent tab order for screen reader and keyboard users.
    /// The primary example of this pattern is when the disabled button is in a menu or a commandbar and is seldom used for standalone buttons.
    static member inline disabledFocusable (value: bool) = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "disabledFocusable" value

module teachingPopoverCarouselFooterButton =

    type [<Erase>] as' =
        static member inline a = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "as" "a"
        static member inline button = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "as" "button"

    /// A button can have its content and borders styled for greater emphasis or to be subtle.
    type [<Erase>] appearance =
        /// 'subtle': Minimizes emphasis to blend into the background until hovered or focused.
        static member inline subtle = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "appearance" "subtle"
        /// 'outline': Removes background styling.
        static member inline outline = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "appearance" "outline"
        /// 'secondary' (default): Gives emphasis to the button in such a way that it indicates a secondary action.
        static member inline secondary = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "appearance" "secondary"
        /// 'primary': Emphasizes the button as a primary action.
        static member inline primary = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "appearance" "primary"
        /// 'transparent': Removes background and border styling.
        static member inline transparent = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "appearance" "transparent"

    type [<Erase>] shape =
        static member inline circular = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "shape" "circular"
        static member inline square = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "shape" "square"
        static member inline rounded = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "shape" "rounded"

    /// A button can format its icon to appear before or after its content.
    type [<Erase>] iconPosition =
        static member inline before = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "iconPosition" "before"
        static member inline after = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "iconPosition" "after"

    /// A button supports different sizes.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "size" "large"

    /// Defines whether the button should be next or previous type - used for both styling and functionality.
    type [<Erase>] navType =
        static member inline next = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "navType" "next"
        static member inline prev = Interop.mkProperty<ITeachingPopoverCarouselFooterButtonProp> "navType" "prev"

// -------------------------------------------------------------------------- TeachingPopoverCarouselNav --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverCarouselNav =
    inherit FelizProps.prop<ITeachingPopoverCarouselNavProp>
    /// The element wrapping the carousel pagination. By default this is a div, it may contain icons or text depending on TeachingPopoverCarouselNavStyle
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverCarouselNavProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// WARNING: TeachingPopoverCarouselNav only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children (value: Fable.React.ReactElement) = Interop.mkProperty<ITeachingPopoverCarouselNavProp> "children" value
    /// WARNING: TeachingPopoverCarouselNav only takes a render function as children. Using this will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) = Interop.mkProperty<ITeachingPopoverCarouselNavProp> "children" (Interop.reactApi.Children.toArray elems)
    /// WARNING: TeachingPopoverCarouselNav only takes a render function as children. Using this will cause runtime errors.
    static member inline children (value: string -> ReactElement) = Interop.mkProperty<ITeachingPopoverCarouselNavProp> "children" (System.Func<_,_> value)

// -------------------------------------------------------------------------- TeachingPopoverCarouselNavButton --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverCarouselNavButton =
    inherit FelizProps.prop<ITeachingPopoverCarouselNavButtonProp>
    /// ARIA compliant nav buttons used to jump to pages
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverCarouselNavButtonProp> "root" (!!value |> createObj |> unbox<IReactProperty>)

// -------------------------------------------------------------------------- TeachingPopoverCarousel --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverCarousel =
    inherit FelizProps.prop<ITeachingPopoverCarouselProp>
    /// The element wrapping the text and close button. By default this is a div, but can be a heading.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ITeachingPopoverCarouselProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The initial page to display in uncontrolled mode.
    static member inline defaultValue (value: string) = Interop.mkProperty<ITeachingPopoverCarouselProp> "defaultValue" value
    /// The value of the currently active page.
    static member inline value (value: string) = Interop.mkProperty<ITeachingPopoverCarouselProp> "value" value
    ///  Callback to notify a page change.
    static member inline onValueChange (handler: ValueProp<string> -> unit) = Interop.mkProperty<ITeachingPopoverCarouselProp> "onValueChange" (System.Func<_,_,_> (fun _ value -> handler value))
    ///  Callback to notify a page change.
    static member inline onValueChange (value: MouseEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ITeachingPopoverCarouselProp> "onValueChange" (System.Func<_,_,_> value)
    /// Callback to notify when the final button step of a carousel has been activated.
    static member inline onFinish (handler: ValueProp<string> -> unit) = Interop.mkProperty<ITeachingPopoverCarouselProp> "onFinish" (System.Func<_,_> (fun _ value -> handler value))
    /// Callback to notify when the final button step of a carousel has been activated.
    static member inline onFinish (value: MouseEvent -> ValueProp<string> -> unit) = Interop.mkProperty<ITeachingPopoverCarouselProp> "onFinish" (System.Func<_,_,_> value)

// -------------------------------------------------------------------------- TeachingPopoverCarouselCard --------------------------------------------------------------------------------------
type [<Erase>] teachingPopoverCarouselCard =
    inherit FelizProps.prop<ITeachingPopoverCarouselCardProp>
    /// The element wrapping the buttons.
    static member inline root (value: ICarouselItemProp list) = Interop.mkProperty<ITeachingPopoverCarouselCardProp> "root" (!!value |> createObj |> unbox)
    static member inline value (value: string) = Interop.mkProperty<ITeachingPopoverCarouselCardProp> "value" value

// -------------------------------------------------------------------------- CarouselItem --------------------------------------------------------------------------------------
type [<Erase>] carouselItem =
    inherit FelizProps.prop<ICarouselItemProp>
    /// The element wrapping the buttons.
    static member inline root (value: IReactProperty list) = Interop.mkProperty<ICarouselItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// The value used to identify a page, it should be unique and is necessary for pagination
    static member inline value (value: string) = Interop.mkProperty<ICarouselItemProp> "value" value

// -------------------------------------------------------------------------- Rating --------------------------------------------------------------------------------------
type [<Erase>] rating =
    inherit FelizProps.prop<IRatingProp>
    static member inline root (value:  IReactProperty list) = Interop.mkProperty<IRatingProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Default value of the Rating
    static member inline defaultValue (value: int) = Interop.mkProperty<IRatingProp> "defaultValue" value
    /// Default value of the Rating
    static member inline defaultValue (value: float) = Interop.mkProperty<IRatingProp> "defaultValue" value
    /// Default value of the Rating
    static member inline defaultValue (value: decimal) = Interop.mkProperty<IRatingProp> "defaultValue" value
    /// The icon to display when the rating value is greater than or equal to the item's value.
    static member inline iconFilled (value: BundleIcon) = Interop.mkProperty<IRatingProp> "iconFilled" value
    /// The icon to display when the rating value is less than the item's value.
    static member inline iconOutline (value: BundleIcon) = Interop.mkProperty<IRatingProp> "iconOutline" value
    /// The max value of the rating. This controls the number of rating items displayed.
    /// Must be a whole number greater than 1.
    static member inline max (value: int) = Interop.mkProperty<IRatingProp> "max" value
    /// Name for the Radio inputs. If not provided, one will be automatically generated
    static member inline name (value: string) = Interop.mkProperty<IRatingProp> "name" value
    /// Callback when the rating value is changed by the user.
    static member inline onChange (value: Event -> RatingOnChangeEventData<int> -> unit) = Interop.mkProperty<IRatingProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when the rating value is changed by the user.
    static member inline onChange (handler: RatingOnChangeEventData<int> -> unit) = Interop.mkProperty<IRatingProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when the rating value is changed by the user.
    static member inline onChange (value: Event -> RatingOnChangeEventData<decimal> -> unit) = Interop.mkProperty<IRatingProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when the rating value is changed by the user.
    static member inline onChange (handler: RatingOnChangeEventData<decimal> -> unit) = Interop.mkProperty<IRatingProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback when the rating value is changed by the user.
    static member inline onChange (value: Event -> RatingOnChangeEventData<float> -> unit) = Interop.mkProperty<IRatingProp> "onChange" (System.Func<_,_,_> value)
    /// Callback when the rating value is changed by the user.
    static member inline onChange (handler: RatingOnChangeEventData<float> -> unit) = Interop.mkProperty<IRatingProp> "onChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// The value of the rating
    static member inline value (value: int) = Interop.mkProperty<IRatingProp> "value" value
    /// The value of the rating
    static member inline value (value: decimal) = Interop.mkProperty<IRatingProp> "value" value
    /// The value of the rating
    static member inline value (value: float) = Interop.mkProperty<IRatingProp> "value" value
    /// Prop to generate the aria-label for the rating inputs.
    static member inline itemLabel (value: int -> string) = Interop.mkProperty<IRatingProp> "itemLabel" (System.Func<_,_> value)
    /// Prop to generate the aria-label for the rating inputs.
    static member inline itemLabel (value: decimal -> string) = Interop.mkProperty<IRatingProp> "itemLabel" (System.Func<_,_> value)
    /// Prop to generate the aria-label for the rating inputs.
    static member inline itemLabel (value: float -> string) = Interop.mkProperty<IRatingProp> "itemLabel" (System.Func<_,_> value)

module rating =
    /// Sets the size of the Rating items.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IRatingProp> "size" "small"
        static member inline medium = Interop.mkProperty<IRatingProp> "size" "medium"
        static member inline large = Interop.mkProperty<IRatingProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<IRatingProp> "size" "extra-large"

    /// Controls the appearance of the Rating.
    type [<Erase>] color =
        static member inline brand = Interop.mkProperty<IRatingProp> "color" "brand"
        static member inline marigold = Interop.mkProperty<IRatingProp> "color" "marigold"
        static member inline neutral = Interop.mkProperty<IRatingProp> "color" "neutral"

    /// Sets the precision to allow half-filled shapes in Rating
    type [<Erase>] step =
        static member inline ``0.5`` = Interop.mkProperty<IRatingProp> "step" 0.5
        static member inline ``1`` = Interop.mkProperty<IRatingProp> "step" 1

// -------------------------------------------------------------------------- RatingItem --------------------------------------------------------------------------------------
type [<Erase>] ratingItem =
    inherit FelizProps.prop<IRatingItemProp>
    /// The root slot of the RatingItem.
    static member inline root (value:  IReactProperty list) = Interop.mkProperty<IRatingItemProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    /// Icon displayed when the rating value is greater than or equal to the item's value.
    static member inline selectedIcon (value: IReactProperty list) = Interop.mkProperty<IRatingItemProp> "selectedIcon" (!!value |> createObj)
    /// Icon displayed when the rating value is greater than or equal to the item's value.
    static member inline selectedIcon (value: ReactElement) = Interop.mkProperty<IRatingItemProp> "selectedIcon" value
    /// Icon displayed when the rating value is less than the item's value.
    static member inline unselectedIcon (value: IReactProperty list) = Interop.mkProperty<IRatingItemProp> "unselectedFilledIcon" (!!value |> createObj)
    /// Icon displayed when the rating value is less than the item's value.
    static member inline unselectedIcon (value: ReactElement) = Interop.mkProperty<IRatingItemProp> "unselectedIcon" value
    /// Radio input slot used for half star precision
    static member inline halfValueInput (value: IReactProperty list) = Interop.mkProperty<IRatingItemProp> "halfValueInput" (!!value |> createObj)
    /// Radio input slot used for half star precision
    static member inline halfValueInput (value: ReactElement) = Interop.mkProperty<IRatingItemProp> "halfValueInput" value
    /// Radio input slot used for full star precision
    static member inline fullValueInput (value: IReactProperty list) = Interop.mkProperty<IRatingItemProp> "fullValueInput" (!!value |> createObj)
    /// Radio input slot used for full star precision
    static member inline fullValueInput (value: ReactElement) = Interop.mkProperty<IRatingItemProp> "fullValueInput" value
    /// The positive whole number value that is displayed by this RatingItem
    static member inline value (value: int) = Interop.mkProperty<IRatingItemProp> "value" value

// -------------------------------------------------------------------------- ComboboxFilterConfig --------------------------------------------------------------------------------------
type [<Erase>] comboboxFilterConfig =
    /// Provides a custom filter for the option
    ///
    /// The first string is the value set in `optionToText`, or by default the option's `value`
    ///
    /// The second string is the user's input
    static member inline filter (value:  string -> string -> bool) = Interop.mkProperty<IComboboxFilterConfigProp> "filter" (System.Func<_,_,_> value)
    /// Provides a custom message to display when there are no options
    static member inline noOptionsMessage (value: string) = Interop.mkProperty<IComboboxFilterConfigProp> "noOptionsMessage" value
    /// Provides a custom message to display when there are no options
    static member inline noOptionsMessage (value: ReactElement) = Interop.mkProperty<IComboboxFilterConfigProp> "noOptionsMessage" value
    /// Provides a way to map an option object to a React key. By default, "value" is used.
    ///
    /// **'T must be a type or object that includes `children` and `value` properties. Using a type or object without these properties will cause `Fui.useComboboxFilter` to not filter correctly.**
    ///
    /// **`children` is the text/component that will appear for each option in the dropdown**
    ///
    /// **`value` is the text that will be used for the filtering based on user's input**
    static member inline optionToReactKey (value: 'T -> string) = Interop.mkProperty<IComboboxFilterConfigProp> "optionToReactKey" (System.Func<_,_> value)
    /// Provides a way to map an option object to a text used for search. By default, "value" is used.
    ///
    /// **'T must be a type or object that includes `children` and `value` properties. Using a type or object without these properties will cause `Fui.useComboboxFilter` to not filter correctly.**
    ///
    /// **`children` is the text/component that will appear for each option in the dropdown**
    ///
    /// **`value` is the text that will be used for the filtering based on user's input**
    static member inline optionToText (value: 'T -> string) = Interop.mkProperty<IComboboxFilterConfigProp> "optionToText" (System.Func<_,_> value)
    /// Provides a custom render for the option.
    ///
    /// **'T must be a type or object that includes `children` and `value` properties. Using a type or object without these properties will cause `Fui.useComboboxFilter` to not filter correctly.**
    ///
    /// **`children` is the text/component that will appear for each option in the dropdown**
    ///
    /// **`value` is the text that will be used for the filtering based on user's input**
    static member inline renderOption (value: 'T -> ReactElement) = Interop.mkProperty<IComboboxFilterConfigProp> "renderOption" (System.Func<_,_> value)

// -------------------------------------------------------------------------- RatingDisplay --------------------------------------------------------------------------------------
type [<Erase>] ratingDisplay =
    inherit FelizProps.prop<IRatingDisplayProp>
    static member inline root (value:  IReactProperty list) = Interop.mkProperty<IRatingDisplayProp> "root" (!!value |> createObj |> unbox<IReactProperty>)
    static member inline valueText (value: IReactProperty list) = Interop.mkProperty<IRatingDisplayProp> "valueText" (!!value |> createObj)
    static member inline valueText (value: ReactElement) = Interop.mkProperty<IRatingDisplayProp> "valueText" value
    static member inline valueText (value: string) = Interop.mkProperty<IRatingDisplayProp> "valueText" value
    static member inline countText (value: IReactProperty list) = Interop.mkProperty<IRatingDisplayProp> "countText" (!!value |> createObj)
    static member inline countText (value: ReactElement) = Interop.mkProperty<IRatingDisplayProp> "countText" value
    static member inline countText (value: string) = Interop.mkProperty<IRatingDisplayProp> "countText" value
    /// The icon used for rating items.
    static member inline icon (value: BundleIcon) = Interop.mkProperty<IRatingDisplayProp> "icon" value
    /// The max value of the rating. This controls the number of rating items displayed.
    /// Must be a whole number greater than 1.
    static member inline max (value: int) = Interop.mkProperty<IRatingDisplayProp> "max" value
    /// The value of the rating
    static member inline value (value: int) = Interop.mkProperty<IRatingDisplayProp> "value" value
    /// The value of the rating
    static member inline value (value: decimal) = Interop.mkProperty<IRatingDisplayProp> "value" value
    /// The value of the rating
    static member inline value (value: float) = Interop.mkProperty<IRatingDisplayProp> "value" value
    /// The number of ratings represented by the rating value.
    /// This will be formatted with a thousands separator (if applicable) and displayed next to the value.
    static member inline count (value: int) = Interop.mkProperty<IRatingDisplayProp> "count" value
    /// The number of ratings represented by the rating value.
    /// This will be formatted with a thousands separator (if applicable) and displayed next to the value.
    static member inline count (value: decimal) = Interop.mkProperty<IRatingDisplayProp> "count" value
    /// The number of ratings represented by the rating value.
    /// This will be formatted with a thousands separator (if applicable) and displayed next to the value.
    static member inline count (value: float) = Interop.mkProperty<IRatingDisplayProp> "count" value
    /// Renders a single filled star, with the value written next to it.
    static member inline compact (value: bool) = Interop.mkProperty<IRatingDisplayProp> "compact" value

module ratingDisplay =
    /// Sets the size of the Rating items.
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<IRatingDisplayProp> "size" "small"
        static member inline medium = Interop.mkProperty<IRatingDisplayProp> "size" "medium"
        static member inline large = Interop.mkProperty<IRatingDisplayProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<IRatingDisplayProp> "size" "extra-large"

    /// Controls the appearance of the Rating.
    type [<Erase>] color =
        static member inline brand = Interop.mkProperty<IRatingDisplayProp> "color" "brand"
        static member inline marigold = Interop.mkProperty<IRatingDisplayProp> "color" "marigold"
        static member inline neutral = Interop.mkProperty<IRatingDisplayProp> "color" "neutral"

// -------------------------------------------------------------------------- TagPicker --------------------------------------------------------------------------------------
type [<Erase>] tagPicker =
    inherit FelizProps.prop<ITagPickerProp>
    /// Configure the positioning of the combobox dropdown
    static member inline positioning (value: IPositioningProp list) = Interop.mkProperty<ITagPickerProp> "positioning" (!!value |> createObj |> unbox<IPositioningProp>)
    static member inline disabled (value: bool) = Interop.mkProperty<ITagPickerProp> "disabled" value
    /// The default open state when open is uncontrolled
    static member inline defaultOpen (value: bool) = Interop.mkProperty<ITagPickerProp> "defaultOpen" value
    /// An array of selected option keys. Use this with `onOptionSelect` to directly control the selected option(s). If this is set, the `value` prop MUST also be controlled.
    static member inline selectedOptions (value: string list) = Interop.mkProperty<ITagPickerProp> "selectedOptions" (value |> List.toArray)
    /// Sets the open/closed state of the dropdown.
    /// Use together with onOpenChange to fully control the dropdown's visibility
    static member inline open' (value: bool) = Interop.mkProperty<ITagPickerProp> "open" value
    /// TagPickers are rendered out of DOM order on `document.body` by default, use this to render the popover in DOM order
    static member inline inline' (value: bool) = Interop.mkProperty<ITagPickerProp> "inline" value
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: TagPickerOnOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (handler: TagPickerOnOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOpenChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: MouseEvent -> TagPickerOnOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOpenChange" (System.Func<_,_,_> value)
    /// Callback fired when the component changes value from open state.
    static member inline onOpenChange (value: KeyboardEvent -> TagPickerOnOpenChangeData<KeyboardEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOpenChange" (System.Func<_,_,_> value)
    static member inline onOptionSelect (handler: TagPickerOnOptionSelectData<MouseEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOptionSelect" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onOptionSelect (handler: TagPickerOnOptionSelectData<KeyboardEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOptionSelect" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline onOptionSelect (value: MouseEvent -> TagPickerOnOpenChangeData<MouseEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOptionSelect" (System.Func<_,_,_> value)
    static member inline onOptionSelect (value: KeyboardEvent -> TagPickerOnOptionSelectData<KeyboardEvent> -> unit) = Interop.mkProperty<ITagPickerProp> "onOptionSelect" (System.Func<_,_,_> value)
    /// Can contain two children including a trigger and a popover.
    static member inline children (value: ReactElement) = Interop.mkProperty<ITagPickerProp> "children" value
    /// WARNING: TagPicker can contain no more than two children including a trigger and a popover.
    /// If you try to use more than two children, only the first two you pass to this function will be used
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l <= 2 -> elems
            | _ -> elems |> Seq.take 2
        Interop.mkProperty<ITagPickerProp> "children" (Interop.reactApi.Children.toArray elemsToUse)

module tagPicker =
    type [<Erase>] size =
        static member inline medium = Interop.mkProperty<ITagPickerProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITagPickerProp> "size" "large"
        static member inline extraLarge = Interop.mkProperty<ITagPickerProp> "size" "extra-large"

    /// Controls the colors and borders of the combobox trigger.
    type [<Erase>] appearance =
        static member inline filledDarker = Interop.mkProperty<ITagPickerProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ITagPickerProp> "appearance" "filled-lighter"
        static member inline outline = Interop.mkProperty<ITagPickerProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ITagPickerProp> "appearance" "underline"

// -------------------------------------------------------------------------- TagPickerControl --------------------------------------------------------------------------------------
type [<Erase>] tagPickerControl =
    inherit FelizProps.prop<ITagPickerControlProp>
    /// A secondary action should be a button-like element to be rendered right after the trigger responsible for opening/closing the tag picker popover.
    static member inline secondaryAction (value: ReactElement) = Interop.mkProperty<ITagPickerControlProp> "secondaryAction" value
    /// A secondary action should be a button-like element to be rendered right after the trigger responsible for opening/closing the tag picker popover.
    static member inline secondaryAction (value: IReactProperty list) = Interop.mkProperty<ITagPickerControlProp> "secondaryAction" (!!value |> createObj |> unbox)
    static member inline expandIcon (value: ReactElement) = Interop.mkProperty<ITagPickerControlProp> "expandIcon" value
    static member inline expandIcon (value: IReactProperty list) = Interop.mkProperty<ITagPickerControlProp> "expandIcon" (!!value |> createObj |> unbox)

// -------------------------------------------------------------------------- TagPickerGroup --------------------------------------------------------------------------------------
type [<Erase>] tagPickerGroup = FelizProps.prop<ITagPickerGroupProp>

// -------------------------------------------------------------------------- TagPickerButton --------------------------------------------------------------------------------------
type [<Erase>] tagPickerButton = FelizProps.prop<ITagPickerButtonProp>

module tagPickerButton =
    type [<Erase>] size =
        static member inline small = Interop.mkProperty<ITagPickerButtonProp> "size" "small"
        static member inline medium = Interop.mkProperty<ITagPickerButtonProp> "size" "medium"
        static member inline large = Interop.mkProperty<ITagPickerButtonProp> "size" "large"

    /// Controls the colors and borders of the combobox trigger.
    type [<Erase>] appearance =
        static member inline filledDarker = Interop.mkProperty<ITagPickerButtonProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ITagPickerButtonProp> "appearance" "filled-lighter"
        static member inline outline = Interop.mkProperty<ITagPickerButtonProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ITagPickerButtonProp> "appearance" "underline"

// -------------------------------------------------------------------------- TagPickerInput --------------------------------------------------------------------------------------
type [<Erase>] tagPickerInput =
    inherit FelizProps.prop<ITagPickerInputProp>
    /// If set, the combobox will show an icon to clear the current value.
    static member inline clearable (value: bool) = Interop.mkProperty<ITagPickerInputProp> "clearable" value
    /// WARNING: TagPickerInput doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children (value: ReactElement) = Interop.mkProperty<ITagPickerInputProp> "children" value
    /// WARNING: TagPickerInput doesn't support children. Using this prop will cause runtime errors.
    [<Obsolete>] static member inline children ([<ParamList>] elems: ReactElement seq) = Interop.mkProperty<ITagPickerInputProp> "children" (Interop.reactApi.Children.toArray elems)

module tagPickerInput =

    /// Controls the colors and borders of the combobox trigger.
    type [<Erase>] appearance =
        static member inline filledDarker = Interop.mkProperty<ITagPickerInputProp> "appearance" "filled-darker"
        static member inline filledLighter = Interop.mkProperty<ITagPickerInputProp> "appearance" "filled-lighter"
        static member inline outline = Interop.mkProperty<ITagPickerInputProp> "appearance" "outline"
        static member inline underline = Interop.mkProperty<ITagPickerInputProp> "appearance" "underline"

// -------------------------------------------------------------------------- TagPickerList --------------------------------------------------------------------------------------
type [<Erase>] tagPickerList = FelizProps.prop<ITagPickerListProp>

// -------------------------------------------------------------------------- TagPickerOption --------------------------------------------------------------------------------------
type [<Erase>] tagPickerOption =
    inherit FelizProps.prop<ITagPickerOptionProp>
    /// A secondary action should be a button-like element to be rendered right after the trigger responsible for opening/closing the tag picker popover.
    static member inline media (value: ReactElement) = Interop.mkProperty<ITagPickerOptionProp> "media" value
    /// A secondary action should be a button-like element to be rendered right after the trigger responsible for opening/closing the tag picker popover.
    static member inline media (value: IReactProperty list) = Interop.mkProperty<ITagPickerOptionProp> "media" (!!value |> createObj |> unbox)
    static member inline secondaryContent (value: ReactElement) = Interop.mkProperty<ITagPickerOptionProp> "secondaryContent" value
    static member inline secondaryContent (value: IReactProperty list) = Interop.mkProperty<ITagPickerOptionProp> "secondaryContent" (!!value |> createObj |> unbox)
    /// Can contain one child.
    static member inline children (value: string) = Interop.mkProperty<ITagPickerOptionProp> "children" value
    /// Can contain one child.
    static member inline children (value: ReactElement) = Interop.mkProperty<ITagPickerOptionProp> "children" value
    /// WARNING: TagPickerOption can contain no more than one child.
    /// If you try to use more than one children, only the first you pass to this function will be used
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l = 1 -> elems
            | _ -> elems |> Seq.take 1
        Interop.mkProperty<ITagPickerOptionProp> "children" (Interop.reactApi.Children.toArray elemsToUse)

// -------------------------------------------------------------------------- TagPickerOptionGroup --------------------------------------------------------------------------------------
type [<Erase>] tagPickerOptionGroup =
    inherit FelizProps.prop<ITagPickerOptionGroupProp>
    /// A secondary action should be a button-like element to be rendered right after the trigger responsible for opening/closing the tag picker popover.
    static member inline label (value: ReactElement) = Interop.mkProperty<ITagPickerOptionGroupProp> "label" value
    /// A secondary action should be a button-like element to be rendered right after the trigger responsible for opening/closing the tag picker popover.
    static member inline label (value: IReactProperty list) = Interop.mkProperty<ITagPickerOptionGroupProp> "label" (!!value |> createObj |> unbox)

// -------------------------------------------------------------------------- UseTagPickerFilter --------------------------------------------------------------------------------------
type [<Erase>] useTagPickerFilter =
    static member inline query (value: string) = Interop.mkProperty<IUseTagPickerFilterProp> "query" value
    static member inline options (value: string list) = Interop.mkProperty<IUseTagPickerFilterProp> "options" (value |> List.toArray)
    /// Provides a custom filter for the option.
    /// The int in the tuple is the index
    static member inline filter (value: (string * int) -> bool) = Interop.mkProperty<IUseTagPickerFilterProp> "filter" (System.Func<_,_> value)
    /// Provides a custom filter for the option.
    static member inline filter (value: string -> bool) = Interop.mkProperty<IUseTagPickerFilterProp> "filter" (System.Func<_,_> value)
    /// Provides an element to be displayed when there are no options.
    static member inline noOptionsElement (value: ReactElement) = Interop.mkProperty<IUseTagPickerFilterProp> "noOptionsElement" value
    /// Provides a custom render for the option.
    static member inline renderOption (value: string -> ReactElement) = Interop.mkProperty<IUseTagPickerFilterProp> "renderOption" (System.Func<_,_> value)

// -------------------------------------------------------------------------- SwatchPickerGrid --------------------------------------------------------------------------------------
type [<Erase>] swatchPickerGrid =
    static member inline items (value: 'T list) = Interop.mkProperty<ISwatchPickerGridProp> "items" (value |> List.toArray)
    static member inline columnCount (value: int) = Interop.mkProperty<ISwatchPickerGridProp> "columnCount" value
    static member inline columnCount (value: decimal) = Interop.mkProperty<ISwatchPickerGridProp> "columnCount" value
    static member inline columnCount (value: float) = Interop.mkProperty<ISwatchPickerGridProp> "columnCount" value
    static member inline renderRow (value: RenderRowData<int> -> ReactElement) = Interop.mkProperty<ISwatchPickerGridProp> "renderRow" (System.Func<_,_> value)
    static member inline renderRow (value: RenderRowData<string> -> ReactElement) = Interop.mkProperty<ISwatchPickerGridProp> "renderRow" (System.Func<_,_> value)
    static member inline renderSwatch (value: 'T -> ReactElement) = Interop.mkProperty<ISwatchPickerGridProp> "renderSwatch" (System.Func<_,_> value)

// -------------------------------------------------------------------------- ColorSwatch --------------------------------------------------------------------------------------
type [<Erase>] colorSwatch =
    inherit FelizProps.prop<IColorSwatchProp>
    static member inline icon (value: ReactElement) = Interop.mkProperty<IColorSwatchProp> "icon" value
    static member inline icon (value: IReactProperty list) = Interop.mkProperty<IColorSwatchProp> "icon" (!!value |> createObj |> unbox)
    static member inline disabledIcon (value: ReactElement) = Interop.mkProperty<IColorSwatchProp> "disabledIcon" value
    static member inline disabledIcon (value: IReactProperty list) = Interop.mkProperty<IColorSwatchProp> "disabledIcon" (!!value |> createObj |> unbox)
    /// Border color when contrast is low
    static member inline borderColor (value: string) = Interop.mkProperty<IColorSwatchProp> "borderColor" value
    /// Swatch color
    static member inline color (value: string) = Interop.mkProperty<IColorSwatchProp> "color" value

module colorSwatch =
    /// Swatch size
    type [<Erase>] size =
        static member inline extraSmall = Interop.mkProperty<IColorSwatchProp> "size" "extra-small"
        static member inline small = Interop.mkProperty<IColorSwatchProp> "size" "small"
        static member inline medium = Interop.mkProperty<IColorSwatchProp> "size" "medium"
        static member inline large = Interop.mkProperty<IColorSwatchProp> "size" "large"

    /// Swatch shape
    type [<Erase>] shape =
        static member inline rounded = Interop.mkProperty<IColorSwatchProp> "shape" "rounded"
        static member inline square = Interop.mkProperty<IColorSwatchProp> "shape" "square"
        static member inline circular = Interop.mkProperty<IColorSwatchProp> "shape" "circular"

// -------------------------------------------------------------------------- EmptySwatch --------------------------------------------------------------------------------------
type [<Erase>] emptySwatch = FelizProps.prop<IEmptySwatchProp>
module emptySwatch =
    /// Swatch size
    type [<Erase>] size =
        static member inline extraSmall = Interop.mkProperty<IEmptySwatchProp> "size" "extra-small"
        static member inline small = Interop.mkProperty<IEmptySwatchProp> "size" "small"
        static member inline medium = Interop.mkProperty<IEmptySwatchProp> "size" "medium"
        static member inline large = Interop.mkProperty<IEmptySwatchProp> "size" "large"

    /// Swatch shape
    type [<Erase>] shape =
        static member inline rounded = Interop.mkProperty<IEmptySwatchProp> "shape" "rounded"
        static member inline square = Interop.mkProperty<IEmptySwatchProp> "shape" "square"
        static member inline circular = Interop.mkProperty<IEmptySwatchProp> "shape" "circular"

// -------------------------------------------------------------------------- ImageSwatch --------------------------------------------------------------------------------------
type [<Erase>] imageSwatch =
    inherit FelizProps.prop<IImageSwatchProp>
    static member inline src (value: string) = Interop.mkProperty<IImageSwatchProp> "src" value

module ImageSwatch =
    /// Swatch size
    type [<Erase>] size =
        static member inline extraSmall = Interop.mkProperty<IImageSwatchProp> "size" "extra-small"
        static member inline small = Interop.mkProperty<IImageSwatchProp> "size" "small"
        static member inline medium = Interop.mkProperty<IImageSwatchProp> "size" "medium"
        static member inline large = Interop.mkProperty<IImageSwatchProp> "size" "large"

    /// Swatch shape
    type [<Erase>] shape =
        static member inline rounded = Interop.mkProperty<IImageSwatchProp> "shape" "rounded"
        static member inline square = Interop.mkProperty<IImageSwatchProp> "shape" "square"
        static member inline circular = Interop.mkProperty<IImageSwatchProp> "shape" "circular"

// -------------------------------------------------------------------------- SwatchPicker --------------------------------------------------------------------------------------
type [<Erase>] swatchPicker =
    inherit FelizProps.prop<ISwatchPickerProp>
    static member inline defaultSelectedValue (value: string) = Interop.mkProperty<ISwatchPickerProp> "defaultSelectedValue" value
    static member inline selectedValue (value: string) = Interop.mkProperty<ISwatchPickerProp> "selectedValue" value
    /// Triggers a callback when the value has been changed
    static member inline onSelectionChange (handler: SwatchPickerOnSelectionChangeData -> unit) = Interop.mkProperty<ISwatchPickerProp> "onSelectionChange" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Triggers a callback when the value has been changed
    static member inline onSelectionChange (value: MouseEvent -> SwatchPickerOnSelectionChangeData -> unit) = Interop.mkProperty<ISwatchPickerProp> "onSelectionChange" (System.Func<_,_,_> value)

module swatchPicker =
    /// Swatch size
    type [<Erase>] size =
        static member inline extraSmall = Interop.mkProperty<ISwatchPickerProp> "size" "extra-small"
        static member inline small = Interop.mkProperty<ISwatchPickerProp> "size" "small"
        static member inline medium = Interop.mkProperty<ISwatchPickerProp> "size" "medium"
        static member inline large = Interop.mkProperty<ISwatchPickerProp> "size" "large"

    /// Swatch shape
    type [<Erase>] shape =
        static member inline rounded = Interop.mkProperty<ISwatchPickerProp> "shape" "rounded"
        static member inline square = Interop.mkProperty<ISwatchPickerProp> "shape" "square"
        static member inline circular = Interop.mkProperty<ISwatchPickerProp> "shape" "circular"

    /// Swatch shape
    type [<Erase>] layout =
        static member inline row = Interop.mkProperty<ISwatchPickerProp> "layout" "row"
        static member inline grid = Interop.mkProperty<ISwatchPickerProp> "layout" "grid"

    /// Swatch shape
    type [<Erase>] spacing =
        static member inline small = Interop.mkProperty<ISwatchPickerProp> "spacing" "small"
        static member inline medium = Interop.mkProperty<ISwatchPickerProp> "spacing" "medium"

// -------------------------------------------------------------------------- SwatchPickerRow --------------------------------------------------------------------------------------
type [<Erase>] swatchPickerRow = FelizProps.prop<ISwatchPickerRowProp>

// -------------------------------------------------------------------------- PresenceComponent --------------------------------------------------------------------------------------
type [<Erase>] presenceComponent =
    /// By default, the child component won't execute the "enter" motion when it initially mounts, regardless of the value of "visible". If you desire this behavior, ensure both "appear" and "visible" are set to "true".
    static member inline appear (value: bool) = Interop.mkProperty<IPresenceComponentProp> "appear" value
    /// A React element that will be cloned and will have motion effects applied to it.
    static member inline children (value: ReactElement) = Interop.mkProperty<IPresenceComponentProp> "children" value
    /// WARNING: PresenceComponent can contain no more than one child.
    /// If you try to use more than one children, only the first you pass to this function will be used
    static member inline children ([<ParamList>] elems: Fable.React.ReactElement seq) =
        let elemsToUse =
            match elems |> Seq.length with
            | l when l = 1 -> elems
            | _ -> elems |> Seq.take 1
        Interop.mkProperty<IPresenceComponentProp> "children" (elemsToUse |> Seq.head)
    /// Provides imperative controls for the animation.
    static member inline imperativeRef (value: IRefValue<MotionImperativeRef option>) = Interop.mkProperty<IPresenceComponentProp> "imperativeRef" value
    /// Callback that is called when the whole motion finishes.
    /// A motion definition can contain multiple animations and therefore multiple "finish" events. The callback is triggered once all animations have finished with "null" instead of an event object to avoid ambiguity.
    static member inline onMotionFinish (handler: OnMotionData -> unit) = Interop.mkProperty<IPresenceComponentProp> "onMotionFinish" (System.Func<_,_,_> (fun _ value -> handler value))
     /// Callback that is called when the whole motion starts.
     /// A motion definition can contain multiple animations and therefore multiple "start" events. The callback is
     /// triggered when the first animation is started. There is no official "start" event with the Web Animations API, so the callback is triggered with "null".
    static member inline onMotionStart (handler: OnMotionData -> unit) = Interop.mkProperty<IPresenceComponentProp> "onMotionStart" (System.Func<_,_,_> (fun _ value -> handler value))
    /// Callback that is called when the whole motion is cancelled. When a motion is cancelled it does not emit a finish event but a specific cancel event.
    /// A motion definition can contain multiple animations and therefore multiple "finish" events. The callback is
    /// triggered once all animations have finished with "null" instead of an event object to avoid ambiguity.
    static member inline onMotionCancel (handler: OnMotionData -> unit) = Interop.mkProperty<IPresenceComponentProp> "onMotionCancel" (System.Func<_,_,_> (fun _ value -> handler value))
    static member inline visible (value: bool) = Interop.mkProperty<IPresenceComponentProp> "visible" value
    /// By default, the child component remains mounted after it reaches the "finished" state. Set "unmountOnExit" if you prefer to unmount the component after it finishes exiting.
    static member inline unmountOnExit (value: bool) = Interop.mkProperty<IPresenceComponentProp> "unmountOnExit" value
    static member inline key (value: string) = Interop.mkProperty<IPresenceComponentProp> "key" value
    static member inline key (value: int) = Interop.mkProperty<IPresenceComponentProp> "key" value

// -------------------------------------------------------------------------- AtomMotion --------------------------------------------------------------------------------------
type [<Erase>] atomMotion =
    static member inline keyframes (value: IStyleAttribute list list) = Interop.mkProperty<IAtomMotionProp> "keyframes" (value |> List.map (fun kf -> !!kf |> createObj |> unbox))
    static member inline duration (value: int) = Interop.mkProperty<IAtomMotionProp> "duration" value
    static member inline duration (value: string) = Interop.mkProperty<IAtomMotionProp> "duration" value
    static member inline easing (value: string) = Interop.mkProperty<IAtomMotionProp> "easing" value
    static member inline iterations (value: int) = Interop.mkProperty<IAtomMotionProp> "iterations" value

module atomMotion =
    type [<Erase>] iterations =
        static member inline infinity = Interop.mkProperty<IAtomMotionProp> "iterations" "Infinity"

