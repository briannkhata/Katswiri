using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Katswiri.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katswiri.Forms
{
    public partial class Pos : DevExpress.XtraEditors.XtraForm
    {
        KEntities db = new KEntities();
        TempSale tempSale = new TempSale();
        Product product = new Product();
        ProductQuantity productQuantity = new ProductQuantity();
        int TempId;

        public Pos()
        {
            InitializeComponent();
            loadCart();
            autoCompleteSearch();
            //clearmyCart();//clear my cart            //lblCompany.Text = db.Settings.FirstOrDefault().Name;
            //lblShop.Text = db.Shops.FirstOrDefault().ShopName;


        }

        private void loadCart()
        {
             gridControl1.DataSource = db.vwTempSales.ToList();
             //gridView1.OptionsBehavior.Editable = false;
             gridView1.Columns["UserId"].Visible = false;
             gridView1.Columns["ShopId"].Visible = false;
             gridView1.Columns["ProductId"].Visible = false;
             gridView1.Columns["DiscountPercent"].Visible = false;
            gridView1.Columns["DiscountAmount"].Visible = false;
            gridView1.Columns["TempId"].Visible = false;

            gridView1.OptionsView.ShowIndicator = false;
             gridView1.Appearance.Row.Font = new Font("Century Gothic", 18f);


            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;

            var total = db.TempSales?.Where(x => x.UserId == 1).Sum(x => x.TotalPrice);
            var tax = db.TempSales?.Where(x => x.UserId == 1).Sum(x => x.TaxValue);
            var sp = db.TempSales?.Where(x => x.UserId == 1).Sum(x => x.SellingPrice);

            if (total != null)
            {
                lblTotalBill.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}",total, 2);
            }

            if (tax != null)
            {
                lblTaxValue.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}",tax, 2);
            }

            if (sp != null)
            {
                lblSubTotal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}",sp, 2);
            }

        }

        private void autoCompleteSearch()
        {
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();
            foreach (Product product in db.Products.ToList() as List<Product>)
            {
                autoText.Add(product.ProductName);
                //autoText.Add(product.ProductCode);
               // autoText.Add(product.BarCode);
            }
            textSearchProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            textSearchProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textSearchProduct.AutoCompleteCustomSource = autoText;
        }

      

        private void Pos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you would like to cancel POS UI?", "Katswiri", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        public void clearmyCart()
        {
            var list = db.TempSales.Where(x => x.UserId == 1).ToList();
            foreach (var rm in list)
            {
                db.TempSales.Remove(rm);
                db.SaveChanges();
            }
            

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you would like to clear this ORDER?", "Katswiri", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //db.Database.ExecuteSqlCommand("TRUNCATE TABLE TempSales");
                clearmyCart();
            }
            gridControl1.DataSource = null;
            loadCart();
            lblTotalBill.Text = "0.00";
            lblTaxValue.Text = "0.00";
            lblSubTotal.Text = "0.00";
        }

     

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            textSearchProduct.Text = textSearchProduct.Text + button.Text;
        }

        private void textSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                //var choice = db.Products.Where(p => p.ProductCode == textSearchProduct.Text | p.BarCode == textSearchProduct.Text).ToList();
                //var choice = db.Products.Where(p => p.ProductName.Contains(textSearchProduct.Text)).ToList();

                product = db.Products.Where(p => p.ProductName ==  textSearchProduct.Text.ToString()).FirstOrDefault();
                var taxValue = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeValue;
                var taxStatus = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeStatus;
                var exists = db.TempSales.Where(x => x.ProductId == product.ProductId).FirstOrDefault();


                if (exists != null)
                {
                    exists.Qty += 1;
                    exists.TaxValue = (product.SellingPrice * (taxValue / 100));
                    exists.TotalPrice = (exists.SellingPrice * exists.Qty) + tempSale.TaxValue;
                    db.Entry(exists).State = EntityState.Modified;
                }
                else {
                    tempSale.ProductId = product.ProductId;
                    tempSale.SellingPrice = product.SellingPrice;
                    tempSale.ShopId = db.Shops.FirstOrDefault().ShopId;
                    tempSale.UserId = 1;
                    tempSale.DiscountAmount = 0;
                    tempSale.DiscountPercent = 0;
                    tempSale.Qty = 1;
                    tempSale.TaxValue = (product.SellingPrice * (taxValue / 100));
                    tempSale.TotalPrice = (tempSale.SellingPrice * tempSale.Qty) + tempSale.TaxValue;
                    db.TempSales.Add(tempSale);
                }
                db.SaveChanges();
                loadCart();

            }
            textSearchProduct.Text = string.Empty;
        }

        //private void gridControl1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var selectedRows = gridView1.GetSelectedRows();
        //        var row = ((vwTempSale)gridView1.GetRow(selectedRows[0]));
        //        if (row.TempId != -1)
        //        {
        //            product = db.Products.Where(p => p.ProductId == row.ProductId).FirstOrDefault();
        //            var taxValue = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeValue;
        //            var taxStatus = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeStatus;

        //            tempSale = db.TempSales.Where(x => x.TempId == row.TempId).FirstOrDefault();
        //            var qty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
        //            tempSale.Qty = qty;
        //            tempSale.TaxValue = (product.SellingPrice * (taxValue / 100));
        //            tempSale.TotalPrice = (tempSale.SellingPrice * tempSale.Qty) + tempSale.TaxValue;
        //            db.Entry(tempSale).State = EntityState.Modified;
        //            db.SaveChanges();
        //        }

        //        loadCart();

        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void gridControl1_TextChanged(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();
            var row = ((vwTempSale)gridView1.GetRow(selectedRows[0]));
            if (row.TempId != -1)
            {
                product = db.Products.Where(p => p.ProductId == row.ProductId).FirstOrDefault();
                var taxValue = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeValue;
                var taxStatus = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeStatus;

                tempSale = db.TempSales.Where(x => x.TempId == row.TempId).FirstOrDefault();
                var qty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
                tempSale.Qty = qty;
                tempSale.TaxValue = (product.SellingPrice * (taxValue / 100));
                tempSale.TotalPrice = (tempSale.SellingPrice * tempSale.Qty) + tempSale.TaxValue;
                //db.Entry(tempSale).State = EntityState.Modified;
                //db.SaveChanges();
                XtraMessageBox.Show(qty.ToString());
            }

        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            XtraMessageBox.Show("22");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();
                var row = ((vwTempSale)gridView1.GetRow(selectedRows[0]));
                if (row.TempId != -1)
                {
                    TempId = row.TempId;
                    product = db.Products.Where(p => p.ProductId == row.ProductId).FirstOrDefault();
                    var taxValue = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeValue;
                    var taxStatus = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeStatus;

                    tempSale = db.TempSales.Where(x => x.TempId == row.TempId).FirstOrDefault();
                    var qty = Convert.ToDouble(gridView1.GetFocusedRowCellValue("Qty"));
                    tempSale.Qty = qty;
                    tempSale.TaxValue = (product.SellingPrice * (taxValue / 100));
                    tempSale.TotalPrice = (tempSale.SellingPrice * tempSale.Qty) + tempSale.TaxValue;
                    //db.Entry(tempSale).State = EntityState.Modified;
                    db.TempSales.Add(tempSale);
                    db.SaveChanges();
                }

                loadCart();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}