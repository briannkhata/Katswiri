﻿
namespace Katswiri.Forms
{
    partial class Incomes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomes));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katswiriDataSet = new Katswiri.katswiriDataSet();
            this.IncomeDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.PaymentTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.IncomeTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaymentTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIncomeTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIncomeDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katswiriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIncomeTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIncomeDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSave,
            this.btnDelete,
            this.barEditItem1,
            this.barEditItem2,
            this.btnRefresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3});
            this.ribbon.Size = new System.Drawing.Size(1252, 232);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 3;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = this.repositoryItemComboBox3;
            this.barEditItem2.Id = 5;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 6;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tools";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IncomeDateEdit);
            this.dataLayoutControl1.Controls.Add(this.PaymentTypeId);
            this.dataLayoutControl1.Controls.Add(this.IncomeTypeId);
            this.dataLayoutControl1.DataSource = this.incomesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 232);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1252, 260);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incomesBindingSource, "Amount", true));
            this.AmountTextEdit.Location = new System.Drawing.Point(24, 69);
            this.AmountTextEdit.MenuManager = this.ribbon;
            this.AmountTextEdit.Name = "AmountTextEdit";
            this.AmountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.AmountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.AmountTextEdit.Properties.Mask.EditMask = "F";
            this.AmountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.AmountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.AmountTextEdit.Size = new System.Drawing.Size(1204, 26);
            this.AmountTextEdit.StyleController = this.dataLayoutControl1;
            this.AmountTextEdit.TabIndex = 0;
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "Incomes";
            this.incomesBindingSource.DataSource = this.katswiriDataSet;
            // 
            // katswiriDataSet
            // 
            this.katswiriDataSet.DataSetName = "katswiriDataSet";
            this.katswiriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IncomeDateEdit
            // 
            this.IncomeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incomesBindingSource, "IncomeDate", true));
            this.IncomeDateEdit.EditValue = null;
            this.IncomeDateEdit.Location = new System.Drawing.Point(735, 118);
            this.IncomeDateEdit.MenuManager = this.ribbon;
            this.IncomeDateEdit.Name = "IncomeDateEdit";
            this.IncomeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IncomeDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IncomeDateEdit.Size = new System.Drawing.Size(493, 26);
            this.IncomeDateEdit.StyleController = this.dataLayoutControl1;
            this.IncomeDateEdit.TabIndex = 4;
            // 
            // PaymentTypeId
            // 
            this.PaymentTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incomesBindingSource, "PaymentTypeId", true));
            this.PaymentTypeId.Location = new System.Drawing.Point(24, 118);
            this.PaymentTypeId.MenuManager = this.ribbon;
            this.PaymentTypeId.Name = "PaymentTypeId";
            this.PaymentTypeId.Properties.Appearance.Options.UseTextOptions = true;
            this.PaymentTypeId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PaymentTypeId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.PaymentTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PaymentTypeId.Properties.NullText = "";
            this.PaymentTypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.PaymentTypeId.Size = new System.Drawing.Size(390, 28);
            this.PaymentTypeId.StyleController = this.dataLayoutControl1;
            this.PaymentTypeId.TabIndex = 2;
            // 
            // IncomeTypeId
            // 
            this.IncomeTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.incomesBindingSource, "IncomeTypeId", true));
            this.IncomeTypeId.EditValue = false;
            this.IncomeTypeId.Location = new System.Drawing.Point(418, 118);
            this.IncomeTypeId.MenuManager = this.ribbon;
            this.IncomeTypeId.Name = "IncomeTypeId";
            this.IncomeTypeId.Properties.Appearance.Options.UseTextOptions = true;
            this.IncomeTypeId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IncomeTypeId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.IncomeTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IncomeTypeId.Properties.NullText = "";
            this.IncomeTypeId.Properties.PopupSizeable = false;
            this.IncomeTypeId.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.IncomeTypeId.Size = new System.Drawing.Size(313, 28);
            this.IncomeTypeId.StyleController = this.dataLayoutControl1;
            this.IncomeTypeId.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1252, 260);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1232, 240);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAmount,
            this.ItemForPaymentTypeId,
            this.ItemForIncomeTypeId,
            this.ItemForIncomeDate});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1232, 240);
            this.layoutControlGroup2.Text = "Enter Details";
            // 
            // ItemForAmount
            // 
            this.ItemForAmount.Control = this.AmountTextEdit;
            this.ItemForAmount.Location = new System.Drawing.Point(0, 0);
            this.ItemForAmount.Name = "ItemForAmount";
            this.ItemForAmount.Size = new System.Drawing.Size(1208, 49);
            this.ItemForAmount.Text = "Amount";
            this.ItemForAmount.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForAmount.TextSize = new System.Drawing.Size(88, 16);
            // 
            // ItemForPaymentTypeId
            // 
            this.ItemForPaymentTypeId.Control = this.PaymentTypeId;
            this.ItemForPaymentTypeId.Location = new System.Drawing.Point(0, 49);
            this.ItemForPaymentTypeId.Name = "ItemForPaymentTypeId";
            this.ItemForPaymentTypeId.Size = new System.Drawing.Size(394, 141);
            this.ItemForPaymentTypeId.Text = "Payment Type";
            this.ItemForPaymentTypeId.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPaymentTypeId.TextSize = new System.Drawing.Size(88, 16);
            // 
            // ItemForIncomeTypeId
            // 
            this.ItemForIncomeTypeId.Control = this.IncomeTypeId;
            this.ItemForIncomeTypeId.Location = new System.Drawing.Point(394, 49);
            this.ItemForIncomeTypeId.Name = "ItemForIncomeTypeId";
            this.ItemForIncomeTypeId.Size = new System.Drawing.Size(317, 141);
            this.ItemForIncomeTypeId.Text = "Income Type";
            this.ItemForIncomeTypeId.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForIncomeTypeId.TextSize = new System.Drawing.Size(88, 16);
            // 
            // ItemForIncomeDate
            // 
            this.ItemForIncomeDate.Control = this.IncomeDateEdit;
            this.ItemForIncomeDate.Location = new System.Drawing.Point(711, 49);
            this.ItemForIncomeDate.Name = "ItemForIncomeDate";
            this.ItemForIncomeDate.Size = new System.Drawing.Size(497, 141);
            this.ItemForIncomeDate.Text = "Income Date";
            this.ItemForIncomeDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForIncomeDate.TextSize = new System.Drawing.Size(88, 16);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.gridControl1.Location = new System.Drawing.Point(0, 498);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1252, 307);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Incomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 805);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Incomes";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incomes";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katswiriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIncomeTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIncomeDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private katswiriDataSet katswiriDataSet;
        private System.Windows.Forms.BindingSource incomesBindingSource;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.DateEdit IncomeDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaymentTypeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIncomeTypeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIncomeDate;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit PaymentTypeId;
        private DevExpress.XtraEditors.LookUpEdit IncomeTypeId;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}