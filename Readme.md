<!-- default file list -->
*Files to look at*:

* **[MainForm.cs](./CS/BindingListForServerMode/MainForm.cs) (VB: [MainForm.vb](./VB/BindingListForServerMode/MainForm.vb))**
<!-- default file list end -->
# Server Mode - How to edit a focused GridView row in DataLayotControl

The standard approach (binding the GridControl and DataLayoutControl to the same collection) does not work in this scenario, because CurrencyManager does not manage [Server Mode Data Sources](https://docs.devexpress.com/WindowsForms/8398/Controls-and-Libraries/Data-Grid/Data-Binding/Large-Data-Sources-Server-and-Instant-Feedback-Modes#server-mode-data-sources). In addition, all [Server Mode Data Sources](https://docs.devexpress.com/WindowsForms/8398/Controls-and-Libraries/Data-Grid/Data-Binding/Large-Data-Sources-Server-and-Instant-Feedback-Modes#server-mode-data-sources) except for [XPServerCollectionSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPServerCollectionSource) are read-only.

This example demonstrates how to use the [FocusedRowChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FocusedRowObjectChanged) event to synchronize the DataLayoutControl's data source ([XPBindingSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPBindingSource) or [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)) with a focused row.

## Implementation details

1. Bind DataLayoutControl to a data source in the visual designer.
  - If your ORM is XPO, add the [XPBindingSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPBindingSource) component from the toolbox.
    1. Rebuild the project.
    2. Select the [XPBindingSource.ObjectClassInfo](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPBindingSource.ObjectClassInfo) property in the Properties window, open the drop-down list, and choose an appropriate XPO class.
    3. Assign XPBindingSource to the [DataLayoutControl.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDataLayout.DataLayoutControl.DataSource) property.
  - If your ORM is EF or a different library, add the [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource) component from the toolbox.
    1. Rebuild the project.
    2. Click the **Project>Add New Data Source** menu item.
    3. Choose the Object Data Source Type and click Next.
    4. Choose an appropriate class in the list and click Finish.
    5. Assign BindingSource to the [DataLayoutControl.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDataLayout.DataLayoutControl.DataSource) property.
2. [Retrieve fields](https://docs.devexpress.com/WindowsForms/4921/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/data-layout-control#step-2-retrieve-fields).
3. Select GridView and subscribe to the [FocusedRowChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FocusedRowObjectChanged) event.
4. Use the **FocusedRowChangedEventArgs.Row** property value to retrieve a focused object and add it to the data source.

### A code example for XPBindingSource

<details>
    <summary>C#</summary>

```cs
private void GridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
    XPBindingSource.DataSource = Session.GetLoadedObjectByKey<ServerSideGridTest>(e.Row);
}
```
</details>
<details>
    <summary>VB.NET</summary>

```vb
Private Sub GridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
    XPBindingSource.DataSource = Session.GetLoadedObjectByKey(Of ServerSideGridTest)(e.Row)
End Sub
```
</details>

### A code example for BindingSource

<details>
    <summary>C#</summary>

```cs
private void GridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
    object obj = DbContext.ServerSideGridTests.Single(e.Row);
    BindingSource.Clear();
    BindingSource.Add(obj);
}
```
</details>
<details>
    <summary>VB.NET</summary>

```vb
Private Sub GridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
	Dim obj As Object = DbContext.ServerSideGridTests.Single(e.Row)
	BindingSource.Clear()
	BindingSource.Add(obj)
End Sub
```
</details>
