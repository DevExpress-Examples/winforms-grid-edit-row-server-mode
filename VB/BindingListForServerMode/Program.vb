Imports System
Imports DevExpress.Xpo
Imports DevExpress.Skins
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms

Namespace BindingListForServerMode
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			InitDal()
			Application.Run(New MainForm())
		End Sub

		Private Sub InitDal()
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(".\sqlexpress", "ServerModeGridProjects"), AutoCreateOption.None)
		End Sub
	End Module
End Namespace