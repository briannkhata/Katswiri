
namespace Katswiri.Forms
{
    partial class Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pos));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearCart = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPay = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPause = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton13 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonBackSpace = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.lblTaxValue = new DevExpress.XtraEditors.LabelControl();
            this.lblSubTotal = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Blue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.panelControl1.Controls.Add(this.textSearchProduct);
            this.panelControl1.Location = new System.Drawing.Point(23, 75);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(970, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.AcceptsReturn = true;
            this.textSearchProduct.AcceptsTab = true;
            this.textSearchProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textSearchProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textSearchProduct.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchProduct.Location = new System.Drawing.Point(2, 2);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(966, 60);
            this.textSearchProduct.TabIndex = 0;
            this.textSearchProduct.WordWrap = false;
            this.textSearchProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchProduct_KeyDown);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dateTimePicker1);
            this.panelControl2.Controls.Add(this.lookUpEdit1);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Controls.Add(this.lblTaxValue);
            this.panelControl2.Controls.Add(this.lblSubTotal);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Location = new System.Drawing.Point(999, 13);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(534, 793);
            this.panelControl2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(317, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(17, 18);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(181, 26);
            this.lookUpEdit1.TabIndex = 11;
            // 
            // panelControl4
            // 
            this.panelControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl4.Controls.Add(this.simpleButtonNew);
            this.panelControl4.Controls.Add(this.btnClearCart);
            this.panelControl4.Controls.Add(this.simpleButtonPay);
            this.panelControl4.Controls.Add(this.simpleButtonPause);
            this.panelControl4.Controls.Add(this.simpleButtonDelete);
            this.panelControl4.Controls.Add(this.simpleButton13);
            this.panelControl4.Controls.Add(this.simpleButton12);
            this.panelControl4.Controls.Add(this.simpleButton11);
            this.panelControl4.Controls.Add(this.simpleButton10);
            this.panelControl4.Controls.Add(this.simpleButton9);
            this.panelControl4.Controls.Add(this.simpleButtonBackSpace);
            this.panelControl4.Controls.Add(this.simpleButton6);
            this.panelControl4.Controls.Add(this.simpleButton5);
            this.panelControl4.Controls.Add(this.simpleButton4);
            this.panelControl4.Controls.Add(this.simpleButton3);
            this.panelControl4.Controls.Add(this.simpleButton2);
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 342);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(530, 449);
            this.panelControl4.TabIndex = 10;
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonNew.Appearance.Options.UseFont = true;
            this.simpleButtonNew.Location = new System.Drawing.Point(245, 356);
            this.simpleButtonNew.Name = "simpleButtonNew";
            this.simpleButtonNew.Size = new System.Drawing.Size(270, 78);
            this.simpleButtonNew.TabIndex = 17;
            this.simpleButtonNew.Text = "New Sale";
            // 
            // btnClearCart
            // 
            this.btnClearCart.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.Appearance.Options.UseFont = true;
            this.btnClearCart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClearCart.ImageOptions.SvgImage")));
            this.btnClearCart.Location = new System.Drawing.Point(12, 356);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(227, 78);
            this.btnClearCart.TabIndex = 16;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // simpleButtonPay
            // 
            this.simpleButtonPay.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonPay.Appearance.Options.UseFont = true;
            this.simpleButtonPay.Location = new System.Drawing.Point(245, 271);
            this.simpleButtonPay.Name = "simpleButtonPay";
            this.simpleButtonPay.Size = new System.Drawing.Size(272, 78);
            this.simpleButtonPay.TabIndex = 15;
            this.simpleButtonPay.Text = "Pay";
            this.simpleButtonPay.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // simpleButtonPause
            // 
            this.simpleButtonPause.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonPause.Appearance.Options.UseFont = true;
            this.simpleButtonPause.Location = new System.Drawing.Point(357, 186);
            this.simpleButtonPause.Name = "simpleButtonPause";
            this.simpleButtonPause.Size = new System.Drawing.Size(160, 78);
            this.simpleButtonPause.TabIndex = 14;
            this.simpleButtonPause.Text = "Pause ";
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonDelete.Appearance.Options.UseFont = true;
            this.simpleButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButtonDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonDelete.ImageOptions.SvgImage")));
            this.simpleButtonDelete.Location = new System.Drawing.Point(359, 99);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(160, 78);
            this.simpleButtonDelete.TabIndex = 13;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButton13
            // 
            this.simpleButton13.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton13.Appearance.Options.UseFont = true;
            this.simpleButton13.Location = new System.Drawing.Point(129, 271);
            this.simpleButton13.Name = "simpleButton13";
            this.simpleButton13.Size = new System.Drawing.Size(110, 78);
            this.simpleButton13.TabIndex = 12;
            this.simpleButton13.Text = ".";
            this.simpleButton13.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton12.Appearance.Options.UseFont = true;
            this.simpleButton12.Location = new System.Drawing.Point(13, 272);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(110, 78);
            this.simpleButton12.TabIndex = 11;
            this.simpleButton12.Text = "0";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Location = new System.Drawing.Point(243, 186);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(110, 78);
            this.simpleButton11.TabIndex = 10;
            this.simpleButton11.Text = "9";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Location = new System.Drawing.Point(127, 185);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(110, 78);
            this.simpleButton10.TabIndex = 9;
            this.simpleButton10.Text = "8";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(12, 185);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(110, 78);
            this.simpleButton9.TabIndex = 8;
            this.simpleButton9.Text = "7";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonBackSpace
            // 
            this.simpleButtonBackSpace.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonBackSpace.Appearance.Options.UseFont = true;
            this.simpleButtonBackSpace.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.simpleButtonBackSpace.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonBackSpace.ImageOptions.SvgImage")));
            this.simpleButtonBackSpace.Location = new System.Drawing.Point(357, 12);
            this.simpleButtonBackSpace.Name = "simpleButtonBackSpace";
            this.simpleButtonBackSpace.Size = new System.Drawing.Size(160, 78);
            this.simpleButtonBackSpace.TabIndex = 7;
            this.simpleButtonBackSpace.Text = "BackSpace";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(243, 99);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(110, 78);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "6";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(126, 99);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(110, 78);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "5";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(12, 98);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(110, 78);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "4";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(243, 13);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(110, 78);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "3";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(126, 13);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(110, 78);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 13);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(110, 78);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.lblTotalBill);
            this.panel1.Location = new System.Drawing.Point(10, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 105);
            this.panel1.TabIndex = 9;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBill.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(0, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(508, 105);
            this.lblTotalBill.TabIndex = 0;
            this.lblTotalBill.Text = "0.00";
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxValue.Appearance.Options.UseFont = true;
            this.lblTaxValue.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblTaxValue.LineVisible = true;
            this.lblTaxValue.Location = new System.Drawing.Point(267, 167);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(77, 47);
            this.lblTaxValue.TabIndex = 7;
            this.lblTaxValue.Text = "0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Appearance.Options.UseFont = true;
            this.lblSubTotal.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.lblSubTotal.LineVisible = true;
            this.lblSubTotal.Location = new System.Drawing.Point(267, 108);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 47);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "0.00";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 47);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Sub Total";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl2.LineVisible = true;
            this.labelControl2.Location = new System.Drawing.Point(17, 167);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 47);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "VAT";
            // 
            // panelControl3
            // 
            this.panelControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Location = new System.Drawing.Point(18, 153);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(977, 650);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(973, 646);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyUp);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Pos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1538, 818);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Name - Company";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblSubTotal;
        private DevExpress.XtraEditors.LabelControl lblTaxValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalBill;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonBackSpace;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton13;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPay;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPause;
        private System.Windows.Forms.TextBox textSearchProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
        private DevExpress.XtraEditors.SimpleButton btnClearCart;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}