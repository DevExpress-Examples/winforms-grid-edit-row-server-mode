Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports ServerModeGridProjects

Namespace BindingListForServerMode
	Partial Public Class MainForm
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub GridView_FocusedRowObjectChanged(ByVal sender As Object, ByVal e As FocusedRowObjectChangedEventArgs) Handles GridView.FocusedRowObjectChanged
			BindingSource.DataSource = Session.GetLoadedObjectByKey(Of ServerSideGridTest)(e.Row)
		End Sub
	End Class
End Namespace