﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Katswiri.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katswiri.Forms
{
    public partial class TaxTypes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        TaxType taxType = new TaxType();
        int TaxTypeId;
        public TaxTypes()
        {
            InitializeComponent();
            clearFields();
            loadTaxTypes();
        }

        private void clearFields()
        {
            TaxTypeNameTextEdit.Text = TaxTypeStatusTextEdit.Text = TaxTypeValueTextEdit.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Caption = "Save";
            TaxTypeId = 0;
        }

        private bool formValid()
        {
            var result = true;
            if (String.IsNullOrEmpty(TaxTypeNameTextEdit.Text))
            {
                result = false;
                TaxTypeNameTextEdit.ErrorText = "Required";
            }
            if (String.IsNullOrEmpty(TaxTypeStatusTextEdit.Text))
            {
                result = false;
                TaxTypeStatusTextEdit.ErrorText = "Required";
            }
            if (String.IsNullOrEmpty(TaxTypeValueTextEdit.Text))
            {
                result = false;
                TaxTypeValueTextEdit.ErrorText = "Required";
            }
            return result;
        }

        private void loadTaxTypes()
        {
            gridControl1.DataSource = db.vwTaxTypes.ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["TaxTypeId"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (formValid())
                {
                    taxType.TaxTypeName = TaxTypeNameTextEdit.Text;
                    taxType.TaxTypeValue = Convert.ToDouble(TaxTypeValueTextEdit.Text);
                    taxType.TaxTypeStatus = TaxTypeStatusTextEdit.Text; 
                    if (TaxTypeId > 0)
                        db.Entry(taxType).State = EntityState.Modified;
                    else
                    {
                        db.TaxTypes.Add(taxType);
                    }
                    db.SaveChanges();
                    clearFields();
                    loadTaxTypes();
                    XtraMessageBox.Show("Unit Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this Record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                taxType.Deleted = 1;
                db.Entry(taxType).State = EntityState.Modified;
                db.SaveChanges();
                clearFields();
                loadTaxTypes();
                XtraMessageBox.Show("Record Deleted Successfully");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();
            var row = ((vwTaxType)gridView1.GetRow(selectedRows[0]));
            if (row.TaxTypeId != -1)
            {
                TaxTypeId = row.TaxTypeId;
                taxType = db.TaxTypes.Where(x => x.TaxTypeId == TaxTypeId).FirstOrDefault();
                TaxTypeNameTextEdit.Text = taxType.TaxTypeName;
                TaxTypeStatusTextEdit.Text = taxType.TaxTypeStatus;
                TaxTypeValueTextEdit.Text = taxType.TaxTypeValue.ToString();
            }
            btnSave.Caption = "Update";
            btnDelete.Enabled = true;
        }

    }
}