using DevExpress.XtraBars;
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
    public partial class Shops : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        Shop shop = new Shop();
        int ShopId;
        public Shops()
        {
            InitializeComponent();
            clearFields();
            loadShops();
        }

        private void clearFields()
        {
            ShopNameTextEdit.Text = textEditCountry.Text = CurrencyTextEdit.Text = textEditLocation.Text  = textEditLocation.Text = textEditDistrict.Text = string.Empty;
            btnDelete.Enabled = false;
        }

        private void loadShops()
        {
            gridControl1.DataSource = db.vwShops.ToList();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["ShopId"].Visible = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private bool formValid()
        {
            var result = true;
            if (String.IsNullOrEmpty(ShopNameTextEdit.Text))
            {
                result = false;
                ShopNameTextEdit.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(textEditLocation.Text))
            {
                result = false;
                textEditLocation.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(textEditCountry.Text))
            {
                result = false;
                textEditCountry.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(textEditDistrict.Text))
            {
                result = false;
                textEditDistrict.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(CurrencyTextEdit.Text))
            {
                result = false;
                CurrencyTextEdit.ErrorText = "Required";
            }
            return result;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (formValid())
                {
                    shop.Location = textEditLocation.Text;
                    shop.District = textEditDistrict.Text;
                    shop.Country = textEditCountry.Text;
                    shop.Currency = CurrencyTextEdit.Text;
                    shop.ShopName = ShopNameTextEdit.Text;
                    shop.CompanyId = db.Settings.SingleOrDefault().CompanyId;
                    if (ShopId > 0)
                        db.Entry(shop).State = EntityState.Modified;
                    else
                    {
                        db.Shops.Add(shop);
                    }
                    db.SaveChanges();
                    clearFields();
                    loadShops();
                    XtraMessageBox.Show("Shop Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                shop.Deleted = 1;
                db.Entry(shop).State = EntityState.Modified;
                db.SaveChanges();
                clearFields();
                loadShops();
                XtraMessageBox.Show("Record Deleted Successfully");
            }
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            clearFields();
            loadShops();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();
                var row = ((vwShop)gridView1.GetRow(selectedRows[0]));
                if (row.ShopId != -1)
                {
                    ShopId = row.ShopId;
                    shop = db.Shops.Where(x => x.ShopId == ShopId).FirstOrDefault();
                    ShopNameTextEdit.Text = shop.ShopName;
                    textEditDistrict.Text = shop.District;
                    textEditCountry.Text = shop.Country;
                    textEditLocation.Text = shop.Location;
                    CurrencyTextEdit.Text = shop.Currency;
                }
                btnSave.Caption = "Update";
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}