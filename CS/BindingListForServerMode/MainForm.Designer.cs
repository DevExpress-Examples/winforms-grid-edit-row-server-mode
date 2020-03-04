namespace BindingListForServerMode {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Session = new DevExpress.Xpo.Session(this.components);
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.SubjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.BindingSource = new DevExpress.Xpo.XPBindingSource(this.components);
            this.FromTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.SizeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.HasAttachmentCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSubject = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFrom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSent = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForHasAttachment = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.Session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HasAttachmentCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHasAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // xpServerCollectionSource1
            // 
            this.xpServerCollectionSource1.DisplayableProperties = "Subject;From;Sent;Size;HasAttachment";
            this.xpServerCollectionSource1.ObjectType = typeof(ServerModeGridProjects.ServerSideGridTest);
            this.xpServerCollectionSource1.Session = this.Session;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpServerCollectionSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.GridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(387, 268);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView});
            // 
            // GridView
            // 
            this.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubject,
            this.colFrom,
            this.colSent,
            this.colSize,
            this.colHasAttachment});
            this.GridView.DetailHeight = 284;
            this.GridView.GridControl = this.gridControl1;
            this.GridView.Name = "GridView";
            this.GridView.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.GridView_FocusedRowObjectChanged);
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.MinWidth = 17;
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 0;
            this.colSubject.Width = 64;
            // 
            // colFrom
            // 
            this.colFrom.FieldName = "From";
            this.colFrom.MinWidth = 17;
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 1;
            this.colFrom.Width = 64;
            // 
            // colSent
            // 
            this.colSent.FieldName = "Sent";
            this.colSent.MinWidth = 17;
            this.colSent.Name = "colSent";
            this.colSent.Visible = true;
            this.colSent.VisibleIndex = 2;
            this.colSent.Width = 64;
            // 
            // colSize
            // 
            this.colSize.FieldName = "Size";
            this.colSize.MinWidth = 17;
            this.colSize.Name = "colSize";
            this.colSize.Visible = true;
            this.colSize.VisibleIndex = 3;
            this.colSize.Width = 64;
            // 
            // colHasAttachment
            // 
            this.colHasAttachment.FieldName = "HasAttachment";
            this.colHasAttachment.MinWidth = 17;
            this.colHasAttachment.Name = "colHasAttachment";
            this.colHasAttachment.Visible = true;
            this.colHasAttachment.VisibleIndex = 4;
            this.colHasAttachment.Width = 64;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(824, 268);
            this.splitContainerControl1.SplitterPosition = 387;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.SubjectTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FromTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SentDateEdit);
            this.dataLayoutControl1.Controls.Add(this.SizeSpinEdit);
            this.dataLayoutControl1.Controls.Add(this.HasAttachmentCheckEdit);
            this.dataLayoutControl1.DataSource = this.BindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(427, 268);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // SubjectTextEdit
            // 
            this.SubjectTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BindingSource, "Subject", true));
            this.SubjectTextEdit.Location = new System.Drawing.Point(51, 12);
            this.SubjectTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubjectTextEdit.Name = "SubjectTextEdit";
            this.SubjectTextEdit.Size = new System.Drawing.Size(364, 20);
            this.SubjectTextEdit.StyleController = this.dataLayoutControl1;
            this.SubjectTextEdit.TabIndex = 4;
            // 
            // BindingSource
            // 
            this.BindingSource.DisplayableProperties = "Subject;From;Sent;Size;HasAttachment";
            this.BindingSource.ObjectType = typeof(ServerModeGridProjects.ServerSideGridTest);
            // 
            // FromTextEdit
            // 
            this.FromTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BindingSource, "From", true));
            this.FromTextEdit.Location = new System.Drawing.Point(51, 36);
            this.FromTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromTextEdit.Name = "FromTextEdit";
            this.FromTextEdit.Size = new System.Drawing.Size(364, 20);
            this.FromTextEdit.StyleController = this.dataLayoutControl1;
            this.FromTextEdit.TabIndex = 5;
            // 
            // SentDateEdit
            // 
            this.SentDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BindingSource, "Sent", true));
            this.SentDateEdit.EditValue = null;
            this.SentDateEdit.Location = new System.Drawing.Point(51, 60);
            this.SentDateEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SentDateEdit.Name = "SentDateEdit";
            this.SentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SentDateEdit.Size = new System.Drawing.Size(161, 20);
            this.SentDateEdit.StyleController = this.dataLayoutControl1;
            this.SentDateEdit.TabIndex = 6;
            // 
            // SizeSpinEdit
            // 
            this.SizeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BindingSource, "Size", true));
            this.SizeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SizeSpinEdit.Location = new System.Drawing.Point(255, 60);
            this.SizeSpinEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SizeSpinEdit.Name = "SizeSpinEdit";
            this.SizeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.SizeSpinEdit.Size = new System.Drawing.Size(160, 20);
            this.SizeSpinEdit.StyleController = this.dataLayoutControl1;
            this.SizeSpinEdit.TabIndex = 7;
            // 
            // HasAttachmentCheckEdit
            // 
            this.HasAttachmentCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.BindingSource, "HasAttachment", true));
            this.HasAttachmentCheckEdit.Location = new System.Drawing.Point(12, 84);
            this.HasAttachmentCheckEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HasAttachmentCheckEdit.Name = "HasAttachmentCheckEdit";
            this.HasAttachmentCheckEdit.Properties.Caption = "Has Attachment";
            this.HasAttachmentCheckEdit.Size = new System.Drawing.Size(200, 20);
            this.HasAttachmentCheckEdit.StyleController = this.dataLayoutControl1;
            this.HasAttachmentCheckEdit.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(427, 268);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSubject,
            this.ItemForFrom,
            this.ItemForSent,
            this.ItemForHasAttachment,
            this.ItemForSize,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(407, 248);
            // 
            // ItemForSubject
            // 
            this.ItemForSubject.Control = this.SubjectTextEdit;
            this.ItemForSubject.CustomizationFormText = "Subject";
            this.ItemForSubject.Location = new System.Drawing.Point(0, 0);
            this.ItemForSubject.Name = "ItemForSubject";
            this.ItemForSubject.Size = new System.Drawing.Size(407, 24);
            this.ItemForSubject.Text = "Subject";
            this.ItemForSubject.TextSize = new System.Drawing.Size(36, 13);
            // 
            // ItemForFrom
            // 
            this.ItemForFrom.Control = this.FromTextEdit;
            this.ItemForFrom.CustomizationFormText = "From";
            this.ItemForFrom.Location = new System.Drawing.Point(0, 24);
            this.ItemForFrom.Name = "ItemForFrom";
            this.ItemForFrom.Size = new System.Drawing.Size(407, 24);
            this.ItemForFrom.Text = "From";
            this.ItemForFrom.TextSize = new System.Drawing.Size(36, 13);
            // 
            // ItemForSent
            // 
            this.ItemForSent.Control = this.SentDateEdit;
            this.ItemForSent.CustomizationFormText = "Sent";
            this.ItemForSent.Location = new System.Drawing.Point(0, 48);
            this.ItemForSent.Name = "ItemForSent";
            this.ItemForSent.Size = new System.Drawing.Size(204, 24);
            this.ItemForSent.Text = "Sent";
            this.ItemForSent.TextSize = new System.Drawing.Size(36, 13);
            // 
            // ItemForHasAttachment
            // 
            this.ItemForHasAttachment.Control = this.HasAttachmentCheckEdit;
            this.ItemForHasAttachment.CustomizationFormText = "Has Attachment";
            this.ItemForHasAttachment.Location = new System.Drawing.Point(0, 72);
            this.ItemForHasAttachment.Name = "ItemForHasAttachment";
            this.ItemForHasAttachment.Size = new System.Drawing.Size(204, 24);
            this.ItemForHasAttachment.Text = "Has Attachment";
            this.ItemForHasAttachment.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForHasAttachment.TextVisible = false;
            // 
            // ItemForSize
            // 
            this.ItemForSize.Control = this.SizeSpinEdit;
            this.ItemForSize.CustomizationFormText = "Size";
            this.ItemForSize.Location = new System.Drawing.Point(204, 48);
            this.ItemForSize.Name = "ItemForSize";
            this.ItemForSize.Size = new System.Drawing.Size(203, 24);
            this.ItemForSize.Text = "Size";
            this.ItemForSize.TextSize = new System.Drawing.Size(36, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(407, 152);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(204, 72);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(203, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 268);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HasAttachmentCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHasAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Xpo.Session Session;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSent;
        private DevExpress.XtraGrid.Columns.GridColumn colSize;
        private DevExpress.XtraGrid.Columns.GridColumn colHasAttachment;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit SubjectTextEdit;
        private DevExpress.XtraEditors.TextEdit FromTextEdit;
        private DevExpress.XtraEditors.DateEdit SentDateEdit;
        private DevExpress.XtraEditors.SpinEdit SizeSpinEdit;
        private DevExpress.XtraEditors.CheckEdit HasAttachmentCheckEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSubject;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFrom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSent;
        private DevExpress.XtraLayout.LayoutControlItem ItemForHasAttachment;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSize;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.Xpo.XPBindingSource BindingSource;
    }
}

