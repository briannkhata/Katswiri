﻿
namespace Katswiri.Forms
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.AmountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.katswiriDataSet2 = new Katswiri.katswiriDataSet2();
            this.ExpenseDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ExpenseTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.PaymentTypeId = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForExpenseTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPaymentTypeId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForExpenseDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.expensesTableAdapter = new Katswiri.katswiriDataSet2TableAdapters.ExpensesTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katswiriDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpenseTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpenseDate)).BeginInit();
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
            this.btnRefresh});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
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
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 3;
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.AmountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ExpenseDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ExpenseTypeId);
            this.dataLayoutControl1.Controls.Add(this.PaymentTypeId);
            this.dataLayoutControl1.DataSource = this.expensesBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 232);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1252, 205);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // AmountTextEdit
            // 
            this.AmountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.expensesBindingSource, "Amount", true));
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
            this.AmountTextEdit.TabIndex = 5;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.katswiriDataSet2;
            // 
            // katswiriDataSet2
            // 
            this.katswiriDataSet2.DataSetName = "katswiriDataSet2";
            this.katswiriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ExpenseDateEdit
            // 
            this.ExpenseDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.expensesBindingSource, "ExpenseDate", true));
            this.ExpenseDateEdit.EditValue = null;
            this.ExpenseDateEdit.Location = new System.Drawing.Point(757, 118);
            this.ExpenseDateEdit.MenuManager = this.ribbon;
            this.ExpenseDateEdit.Name = "ExpenseDateEdit";
            this.ExpenseDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpenseDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpenseDateEdit.Size = new System.Drawing.Size(471, 26);
            this.ExpenseDateEdit.StyleController = this.dataLayoutControl1;
            this.ExpenseDateEdit.TabIndex = 8;
            // 
            // ExpenseTypeId
            // 
            this.ExpenseTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.expensesBindingSource, "ExpenseTypeId", true));
            this.ExpenseTypeId.Location = new System.Drawing.Point(370, 118);
            this.ExpenseTypeId.MenuManager = this.ribbon;
            this.ExpenseTypeId.Name = "ExpenseTypeId";
            this.ExpenseTypeId.Properties.Appearance.Options.UseTextOptions = true;
            this.ExpenseTypeId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ExpenseTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpenseTypeId.Properties.NullText = "";
            this.ExpenseTypeId.Size = new System.Drawing.Size(383, 26);
            this.ExpenseTypeId.StyleController = this.dataLayoutControl1;
            this.ExpenseTypeId.TabIndex = 4;
            // 
            // PaymentTypeId
            // 
            this.PaymentTypeId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.expensesBindingSource, "PaymentTypeId", true));
            this.PaymentTypeId.Location = new System.Drawing.Point(24, 118);
            this.PaymentTypeId.MenuManager = this.ribbon;
            this.PaymentTypeId.Name = "PaymentTypeId";
            this.PaymentTypeId.Properties.Appearance.Options.UseTextOptions = true;
            this.PaymentTypeId.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PaymentTypeId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PaymentTypeId.Properties.NullText = "";
            this.PaymentTypeId.Size = new System.Drawing.Size(342, 26);
            this.PaymentTypeId.StyleController = this.dataLayoutControl1;
            this.PaymentTypeId.TabIndex = 7;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1252, 205);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1232, 185);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForExpenseTypeId,
            this.ItemForAmount,
            this.ItemForPaymentTypeId,
            this.ItemForExpenseDate});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1232, 185);
            this.layoutControlGroup2.Text = "Enter Details";
            // 
            // ItemForExpenseTypeId
            // 
            this.ItemForExpenseTypeId.Control = this.ExpenseTypeId;
            this.ItemForExpenseTypeId.Location = new System.Drawing.Point(346, 49);
            this.ItemForExpenseTypeId.Name = "ItemForExpenseTypeId";
            this.ItemForExpenseTypeId.Size = new System.Drawing.Size(387, 86);
            this.ItemForExpenseTypeId.Text = "Expense Type";
            this.ItemForExpenseTypeId.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForExpenseTypeId.TextSize = new System.Drawing.Size(88, 16);
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
            this.ItemForPaymentTypeId.Size = new System.Drawing.Size(346, 86);
            this.ItemForPaymentTypeId.Text = "Payment Type";
            this.ItemForPaymentTypeId.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPaymentTypeId.TextSize = new System.Drawing.Size(88, 16);
            // 
            // ItemForExpenseDate
            // 
            this.ItemForExpenseDate.Control = this.ExpenseDateEdit;
            this.ItemForExpenseDate.Location = new System.Drawing.Point(733, 49);
            this.ItemForExpenseDate.Name = "ItemForExpenseDate";
            this.ItemForExpenseDate.Size = new System.Drawing.Size(475, 86);
            this.ItemForExpenseDate.Text = "Expense Date";
            this.ItemForExpenseDate.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForExpenseDate.TextSize = new System.Drawing.Size(88, 16);
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 452);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1252, 353);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1252, 805);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Expenses";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katswiriDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpenseTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPaymentTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpenseDate)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private katswiriDataSet2 katswiriDataSet2;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private katswiriDataSet2TableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private DevExpress.XtraEditors.TextEdit AmountTextEdit;
        private DevExpress.XtraEditors.DateEdit ExpenseDateEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExpenseTypeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPaymentTypeId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExpenseDate;
        private DevExpress.XtraEditors.LookUpEdit ExpenseTypeId;
        private DevExpress.XtraEditors.LookUpEdit PaymentTypeId;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}