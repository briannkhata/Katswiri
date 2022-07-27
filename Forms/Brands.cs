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
    public partial class Brands : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        Brand brand = new Brand();
        int BrandId;
        public Brands()
        {
            InitializeComponent();
            clearFields();
            loadBrands();
        }

        private void clearFields()
        {
            BrandDescriptionTextEdit.Text = BrandNameTextEdit.Text = BrandTagTextEdit.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Caption = "Save";
            BrandId = 0;
        }

        private void loadBrands()
        {
            gridControl1.DataSource = db.vwBrands.ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["BrandId"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private bool formValid()
        {
            var result = true;
            if (String.IsNullOrEmpty(BrandNameTextEdit.Text))
            {
                result = false;
                BrandNameTextEdit.ErrorText = "Required";
            }
            if (String.IsNullOrEmpty(BrandDescriptionTextEdit.Text))
            {
                result = false;
                BrandDescriptionTextEdit.ErrorText = "Required";
            }
            if (String.IsNullOrEmpty(BrandTagTextEdit.Text))
            {
                result = false;
                BrandTagTextEdit.ErrorText = "Required";
            }
            return result;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (formValid())
                {
                    brand.BrandName = BrandNameTextEdit.Text;
                    brand.BrandTag = BrandTagTextEdit.Text;
                    brand.BrandDescription = BrandDescriptionTextEdit.Text;
                    if (BrandId > 0)
                        db.Entry(brand).State = EntityState.Modified;
                    else
                    {
                        db.Brands.Add(brand);
                    }
                    db.SaveChanges();
                    clearFields();
                    loadBrands();
                    XtraMessageBox.Show("Tax Type Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                brand.Deleted = 1;
                db.Entry(brand).State = EntityState.Modified;
                db.SaveChanges();
                clearFields();
                loadBrands();
                XtraMessageBox.Show("Record Deleted Successfully");
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();
            var row = ((vwBrand)gridView1.GetRow(selectedRows[0]));
            if (row.BrandId != -1)
            {
                BrandId = row.BrandId;
                brand = db.Brands.Where(x => x.BrandId == BrandId).FirstOrDefault();
                BrandDescriptionTextEdit.Text = brand.BrandDescription;
                BrandNameTextEdit.Text = brand.BrandName;
                BrandTagTextEdit.Text = brand.BrandTag;
            }
            btnSave.Caption = "Update";
            btnDelete.Enabled = true;
        }
    }
}