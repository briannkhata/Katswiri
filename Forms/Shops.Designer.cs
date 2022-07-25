﻿
namespace Katswiri.Forms
{
    partial class Shops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shops));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ShopNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.shopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopDataSet = new Katswiri.shopDataSet();
            this.PhoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CurrencyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhone = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShopName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrency = new DevExpress.XtraLayout.LayoutControlItem();
            this.shopsTableAdapter = new Katswiri.shopDataSetTableAdapters.ShopsTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShopNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShopName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).BeginInit();
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
            this.dataLayoutControl1.Controls.Add(this.ShopNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CurrencyTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AddressTextEdit);
            this.dataLayoutControl1.DataSource = this.shopsBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 232);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1252, 277);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // ShopNameTextEdit
            // 
            this.ShopNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shopsBindingSource, "ShopName", true));
            this.ShopNameTextEdit.Location = new System.Drawing.Point(24, 69);
            this.ShopNameTextEdit.MenuManager = this.ribbon;
            this.ShopNameTextEdit.Name = "ShopNameTextEdit";
            this.ShopNameTextEdit.Size = new System.Drawing.Size(1204, 26);
            this.ShopNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ShopNameTextEdit.TabIndex = 5;
            // 
            // shopsBindingSource
            // 
            this.shopsBindingSource.DataMember = "Shops";
            this.shopsBindingSource.DataSource = this.shopDataSet;
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhoneTextEdit
            // 
            this.PhoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shopsBindingSource, "Phone", true));
            this.PhoneTextEdit.Location = new System.Drawing.Point(24, 118);
            this.PhoneTextEdit.MenuManager = this.ribbon;
            this.PhoneTextEdit.Name = "PhoneTextEdit";
            this.PhoneTextEdit.Size = new System.Drawing.Size(329, 26);
            this.PhoneTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneTextEdit.TabIndex = 6;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shopsBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(357, 118);
            this.EmailTextEdit.MenuManager = this.ribbon;
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(433, 26);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 7;
            // 
            // CurrencyTextEdit
            // 
            this.CurrencyTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shopsBindingSource, "Currency", true));
            this.CurrencyTextEdit.Location = new System.Drawing.Point(794, 118);
            this.CurrencyTextEdit.MenuManager = this.ribbon;
            this.CurrencyTextEdit.Name = "CurrencyTextEdit";
            this.CurrencyTextEdit.Size = new System.Drawing.Size(434, 26);
            this.CurrencyTextEdit.StyleController = this.dataLayoutControl1;
            this.CurrencyTextEdit.TabIndex = 10;
            // 
            // AddressTextEdit
            // 
            this.AddressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.shopsBindingSource, "Address", true));
            this.AddressTextEdit.Location = new System.Drawing.Point(24, 167);
            this.AddressTextEdit.MenuManager = this.ribbon;
            this.AddressTextEdit.Name = "AddressTextEdit";
            this.AddressTextEdit.Size = new System.Drawing.Size(1204, 26);
            this.AddressTextEdit.StyleController = this.dataLayoutControl1;
            this.AddressTextEdit.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1252, 277);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1232, 257);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForAddress,
            this.ItemForPhone,
            this.ItemForShopName,
            this.ItemForEmail,
            this.ItemForCurrency});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1232, 257);
            this.layoutControlGroup2.Text = "Enter Details";
            // 
            // ItemForAddress
            // 
            this.ItemForAddress.Control = this.AddressTextEdit;
            this.ItemForAddress.Location = new System.Drawing.Point(0, 98);
            this.ItemForAddress.Name = "ItemForAddress";
            this.ItemForAddress.Size = new System.Drawing.Size(1208, 109);
            this.ItemForAddress.Text = "Address";
            this.ItemForAddress.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForAddress.TextSize = new System.Drawing.Size(72, 16);
            // 
            // ItemForPhone
            // 
            this.ItemForPhone.Control = this.PhoneTextEdit;
            this.ItemForPhone.Location = new System.Drawing.Point(0, 49);
            this.ItemForPhone.Name = "ItemForPhone";
            this.ItemForPhone.Size = new System.Drawing.Size(333, 49);
            this.ItemForPhone.Text = "Phone";
            this.ItemForPhone.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPhone.TextSize = new System.Drawing.Size(72, 16);
            // 
            // ItemForShopName
            // 
            this.ItemForShopName.Control = this.ShopNameTextEdit;
            this.ItemForShopName.Location = new System.Drawing.Point(0, 0);
            this.ItemForShopName.Name = "ItemForShopName";
            this.ItemForShopName.Size = new System.Drawing.Size(1208, 49);
            this.ItemForShopName.Text = "Shop Name";
            this.ItemForShopName.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForShopName.TextSize = new System.Drawing.Size(72, 16);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(333, 49);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(437, 49);
            this.ItemForEmail.Text = "Email";
            this.ItemForEmail.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForEmail.TextSize = new System.Drawing.Size(72, 16);
            // 
            // ItemForCurrency
            // 
            this.ItemForCurrency.Control = this.CurrencyTextEdit;
            this.ItemForCurrency.Location = new System.Drawing.Point(770, 49);
            this.ItemForCurrency.Name = "ItemForCurrency";
            this.ItemForCurrency.Size = new System.Drawing.Size(438, 49);
            this.ItemForCurrency.Text = "Currency";
            this.ItemForCurrency.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForCurrency.TextSize = new System.Drawing.Size(72, 16);
            // 
            // shopsTableAdapter
            // 
            this.shopsTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 515);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1252, 290);
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
            // Shops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 805);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shops";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shops";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShopNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShopName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrency)).EndInit();
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
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource shopsBindingSource;
        private shopDataSetTableAdapters.ShopsTableAdapter shopsTableAdapter;
        private DevExpress.XtraEditors.TextEdit ShopNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.TextEdit CurrencyTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShopName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhone;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit AddressTextEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrency;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}