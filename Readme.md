<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/245001167/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T868102)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Edit the focused row in DataLayoutControl in Server Mode

Server Mode does not work if you bind the GridControl and DataLayoutControl to the same collection, and use the DataLayoutControl as the grid's Edit Form, because the CurrencyManager does not manage [Server Mode Data Sources](https://docs.devexpress.com/WindowsForms/8398/Controls-and-Libraries/Data-Grid/Data-Binding/Large-Data-Sources-Server-and-Instant-Feedback-Modes#server-mode-data-sources). All Server Mode data sources except for [XPServerCollectionSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPServerCollectionSource) are read-only.

This example handles the [FocusedRowChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FocusedRowObjectChanged) event to synchronize the DataLayoutControl's data source ([XPBindingSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPBindingSource) or [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource)) with the focused row in the GridControl.

## Implementation details

1. Bind the `DataLayoutControl` to a data source in the Visual Studio Designer.
  - If your ORM is XPO, add the [XPBindingSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPBindingSource) component from the toolbox.
    1. Rebuild the project.
    2. Select the [XPBindingSource.ObjectClassInfo](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPBindingSource.ObjectClassInfo) property in the Properties window, open the drop-down list, and choose an appropriate XPO class.
    3. Assign `XPBindingSource` to the [DataLayoutControl.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDataLayout.DataLayoutControl.DataSource) property.
  - If your ORM is EF or a different library, add the [BindingSource](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource) component from the toolbox.
    1. Rebuild the project.
    2. Click the **Project > Add New Data Source** menu item.
    3. Choose the Object Data Source Type and click Next.
    4. Choose an appropriate class in the list and click **Finish**.
    5. Assign `BindingSource` to the [DataLayoutControl.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraDataLayout.DataLayoutControl.DataSource) property.
2. [Retrieve data fields](https://docs.devexpress.com/WindowsForms/4921/controls-and-libraries/form-layout-managers/layout-and-data-layout-controls/data-layout-control#step-2-retrieve-fields).
3. Select the `GridView` and subscribe to the [FocusedRowChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FocusedRowObjectChanged) event.
4. Use the `e.Row` property to obtain a data object that corresponds to the focused row and add it to the data source.

### Example: XPBindingSource

```cs
private void GridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
    XPBindingSource.DataSource = Session.GetLoadedObjectByKey<ServerSideGridTest>(e.Row);
}
```

```vb
Private Sub GridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
    XPBindingSource.DataSource = Session.GetLoadedObjectByKey(Of ServerSideGridTest)(e.Row)
End Sub
```

### Example: BindingSource

```cs
private void GridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
    object obj = DbContext.ServerSideGridTests.Single(e.Row);
    BindingSource.Clear();
    BindingSource.Add(obj);
}
```

```vb
Private Sub GridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs)
	Dim obj As Object = DbContext.ServerSideGridTests.Single(e.Row)
	BindingSource.Clear()
	BindingSource.Add(obj)
End Sub
```


## Files to Review

* [MainForm.cs](./CS/BindingListForServerMode/MainForm.cs) (VB: [MainForm.vb](./VB/BindingListForServerMode/MainForm.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-edit-row-server-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-edit-row-server-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
