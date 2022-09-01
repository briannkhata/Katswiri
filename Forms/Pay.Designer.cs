
namespace Katswiri.Forms
{
    partial class Pay
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
            this.textBoxTendered = new System.Windows.Forms.TextBox();
            this.btnFinishSale = new System.Windows.Forms.Button();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditPaymentMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPaymentMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTendered
            // 
            this.textBoxTendered.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTendered.Location = new System.Drawing.Point(10, 254);
            this.textBoxTendered.Name = "textBoxTendered";
            this.textBoxTendered.Size = new System.Drawing.Size(539, 53);
            this.textBoxTendered.TabIndex = 0;
            // 
            // btnFinishSale
            // 
            this.btnFinishSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishSale.Location = new System.Drawing.Point(11, 467);
            this.btnFinishSale.Name = "btnFinishSale";
            this.btnFinishSale.Size = new System.Drawing.Size(539, 69);
            this.btnFinishSale.TabIndex = 3;
            this.btnFinishSale.Text = "FINISH SALE";
            this.btnFinishSale.UseVisualStyleBackColor = true;
            this.btnFinishSale.Click += new System.EventHandler(this.btnFinishSale_Click);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(11, 389);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(539, 53);
            this.textBoxDiscount.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 205);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 38);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "AMOUNT";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 336);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 38);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "DISCOUNT";
            // 
            // comboBoxEditPaymentMode
            // 
            this.comboBoxEditPaymentMode.Location = new System.Drawing.Point(11, 130);
            this.comboBoxEditPaymentMode.Name = "comboBoxEditPaymentMode";
            this.comboBoxEditPaymentMode.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditPaymentMode.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditPaymentMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPaymentMode.Size = new System.Drawing.Size(538, 52);
            this.comboBoxEditPaymentMode.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 38);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "MODE";
            // 
            // Pay
            // 
            this.AcceptButton = this.btnFinishSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 556);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.comboBoxEditPaymentMode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.btnFinishSale);
            this.Controls.Add(this.textBoxTendered);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPaymentMode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTendered;
        private System.Windows.Forms.Button btnFinishSale;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPaymentMode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}