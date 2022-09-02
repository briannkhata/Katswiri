
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
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lookUpEditSaleType = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonPay2 = new DevExpress.XtraEditors.SimpleButton();
            this.lblChange = new DevExpress.XtraEditors.LabelControl();
            this.textEditTendered = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearCart = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPay = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPause = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEditTxnId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSaleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTendered.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTxnId.Properties)).BeginInit();
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
            this.panelControl2.Controls.Add(this.lblTotalBill);
            this.panelControl2.Controls.Add(this.dateTimePickerSaleDate);
            this.panelControl2.Controls.Add(this.lookUpEditSaleType);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panel1);
            this.panelControl2.Location = new System.Drawing.Point(999, 13);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(534, 793);
            this.panelControl2.TabIndex = 1;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBill.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(14, 64);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(508, 105);
            this.lblTotalBill.TabIndex = 0;
            this.lblTotalBill.Text = "0.00";
            this.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(317, 18);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSaleDate.TabIndex = 12;
            // 
            // lookUpEditSaleType
            // 
            this.lookUpEditSaleType.Location = new System.Drawing.Point(17, 18);
            this.lookUpEditSaleType.Name = "lookUpEditSaleType";
            this.lookUpEditSaleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSaleType.Size = new System.Drawing.Size(181, 26);
            this.lookUpEditSaleType.TabIndex = 11;
            // 
            // panelControl4
            // 
            this.panelControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.panelControl4.Controls.Add(this.textEditTxnId);
            this.panelControl4.Controls.Add(this.simpleButtonPay2);
            this.panelControl4.Controls.Add(this.lblChange);
            this.panelControl4.Controls.Add(this.textEditTendered);
            this.panelControl4.Controls.Add(this.simpleButtonNew);
            this.panelControl4.Controls.Add(this.btnClearCart);
            this.panelControl4.Controls.Add(this.simpleButtonPay);
            this.panelControl4.Controls.Add(this.simpleButtonPause);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 175);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(530, 616);
            this.panelControl4.TabIndex = 10;
            // 
            // simpleButtonPay2
            // 
            this.simpleButtonPay2.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonPay2.Appearance.Options.UseFont = true;
            this.simpleButtonPay2.Location = new System.Drawing.Point(10, 317);
            this.simpleButtonPay2.Name = "simpleButtonPay2";
            this.simpleButtonPay2.Size = new System.Drawing.Size(272, 78);
            this.simpleButtonPay2.TabIndex = 21;
            this.simpleButtonPay2.Text = "Pay";
            this.simpleButtonPay2.Click += new System.EventHandler(this.simpleButtonPay2_Click);
            // 
            // lblChange
            // 
            this.lblChange.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Appearance.Options.UseFont = true;
            this.lblChange.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblChange.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblChange.Location = new System.Drawing.Point(15, 201);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(498, 75);
            this.lblChange.TabIndex = 20;
            // 
            // textEditTendered
            // 
            this.textEditTendered.Location = new System.Drawing.Point(12, 30);
            this.textEditTendered.Name = "textEditTendered";
            this.textEditTendered.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTendered.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textEditTendered.Properties.Appearance.Options.UseFont = true;
            this.textEditTendered.Properties.Appearance.Options.UseForeColor = true;
            this.textEditTendered.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEditTendered.Size = new System.Drawing.Size(505, 54);
            this.textEditTendered.TabIndex = 18;
            this.textEditTendered.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEditTendered_KeyUp);
            // 
            // simpleButtonNew
            // 
            this.simpleButtonNew.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonNew.Appearance.Options.UseFont = true;
            this.simpleButtonNew.Location = new System.Drawing.Point(243, 525);
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
            this.btnClearCart.Location = new System.Drawing.Point(10, 525);
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
            this.simpleButtonPay.Location = new System.Drawing.Point(243, 440);
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
            this.simpleButtonPause.Location = new System.Drawing.Point(10, 440);
            this.simpleButtonPause.Name = "simpleButtonPause";
            this.simpleButtonPause.Size = new System.Drawing.Size(227, 78);
            this.simpleButtonPause.TabIndex = 14;
            this.simpleButtonPause.Text = "Pause ";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(14, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 105);
            this.panel1.TabIndex = 9;
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
            // textEditTxnId
            // 
            this.textEditTxnId.Location = new System.Drawing.Point(10, 141);
            this.textEditTxnId.Name = "textEditTxnId";
            this.textEditTxnId.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTxnId.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textEditTxnId.Properties.Appearance.Options.UseFont = true;
            this.textEditTxnId.Properties.Appearance.Options.UseForeColor = true;
            this.textEditTxnId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEditTxnId.Size = new System.Drawing.Size(505, 54);
            this.textEditTxnId.TabIndex = 22;
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
            this.Shown += new System.EventHandler(this.Pos_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSaleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTendered.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTxnId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSaleType;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonNew;
        private DevExpress.XtraEditors.SimpleButton btnClearCart;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPay;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPause;
        private DevExpress.XtraEditors.LabelControl lblChange;
        private DevExpress.XtraEditors.TextEdit textEditTendered;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPay2;
        private DevExpress.XtraEditors.TextEdit textEditTxnId;
    }
}