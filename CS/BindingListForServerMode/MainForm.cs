using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using ServerModeGridProjects;

namespace BindingListForServerMode {
    public partial class MainForm :XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void GridView_FocusedRowObjectChanged(object sender, FocusedRowObjectChangedEventArgs e) {
            BindingSource.DataSource = Session.GetLoadedObjectByKey<ServerSideGridTest>(e.Row);
        }
    }
}