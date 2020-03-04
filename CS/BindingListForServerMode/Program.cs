using System;
using DevExpress.Xpo;
using DevExpress.Skins;
using DevExpress.Xpo.DB;
using System.Windows.Forms;

namespace BindingListForServerMode {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            InitDal();
            Application.Run(new MainForm());
        }

        static void InitDal() {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(@".\sqlexpress", "ServerModeGridProjects"),
                AutoCreateOption.None);
        }
    }
}