using DevExpress.XtraEditors;
using Katswiri.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Katswiri.Forms
{
    public partial class Pos : DevExpress.XtraEditors.XtraForm
    {
        KEntities db;
        Cart cart = new Cart();
        Product product;
        ProductQuantity productQuantity = new ProductQuantity();
        int CartId;

        public Pos()
        {
            InitializeComponent();
            clearGrid();
            loadCart();
            autoCompleteSearch();
            //clearmyCart();//clear my cart            
            //lblCompany.Text = db.Settings.FirstOrDefault().Name;
            //lblShop.Text = db.Shops.FirstOrDefault().ShopName;

            //simpleButtonBackSpace.Enabled = false;
            //simpleButtonDelete.Enabled = false;
            //simpleButtonPay.Enabled = false;

        }
        public void clearGrid()
        {
            gridControl1.DataSource = null;
            lblTotalBill.Text = "0.00";
            lblTaxValue.Text = "0.00";
            lblSubTotal.Text = "0.00";

        }
        public void loadCart()
        {
            using (db = new KEntities())
            {
                gridControl1.DataSource = null;
                gridControl1.DataSource = db.vwCarts.Where(x => x.UserId == 1).ToList();
                //gridView1.OptionsBehavior.Editable = false;
                gridView1.Columns["UserId"].Visible = false;
                gridView1.Columns["ShopId"].Visible = false;
                gridView1.Columns["ProductId"].Visible = false;
                //gridView1.Columns["DiscountPercent"].Visible = false;
                gridView1.Columns["DiscountAmount"].Visible = false;
                gridView1.Columns["CartId"].Visible = false;

                //TotalPrice
                //colModelPrice.DisplayFormat.FormatType = Utils.FormatType.Numeric;
                gridView1.Columns.ColumnByFieldName("ProductName").OptionsColumn.ReadOnly = true;
                gridView1.Columns.ColumnByFieldName("ProductName").OptionsColumn.AllowEdit = false;

                gridView1.Columns.ColumnByFieldName("TotalPrice").OptionsColumn.ReadOnly = true;
                gridView1.Columns.ColumnByFieldName("TotalPrice").OptionsColumn.AllowEdit = false;

                gridView1.Columns.ColumnByFieldName("TaxValue").OptionsColumn.ReadOnly = false;
                gridView1.Columns.ColumnByFieldName("TaxValue").OptionsColumn.AllowEdit = false;
                gridView1.FocusedColumn = gridView1.Columns["Qty"];
                gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(255, 255, 192);

                gridView1.OptionsView.ShowIndicator = false;
                gridView1.Appearance.Row.Font = new Font("Century Gothic", 18f);


                gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;

                var total = db.Carts?.Where(x => x.UserId == 1).Sum(x => x.TotalPrice);
                var tax = db.Carts?.Where(x => x.UserId == 1).Sum(x => x.TaxValue);
                var sp = db.Carts?.Where(x => x.UserId == 1).Sum(x => x.SellingPrice);

                if (total != null)
                {
                    lblTotalBill.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", total, 2);
                }

                if (tax != null)
                {
                    lblTaxValue.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", tax, 2);
                }

                if (sp != null)
                {
                    lblSubTotal.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", sp, 2);
                }
            }

        }

        private void autoCompleteSearch()
        {
            using (db = new KEntities())
            {
                AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();
                foreach (Product product in db.Products.ToList() as List<Product>)
                {
                    autoText.Add(product.ProductName);
                    //autoText.Add(product.ProductCode);
                    // autoText.Add(product.BarCode);
                }
                textSearchProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textSearchProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textSearchProduct.AutoCompleteCustomSource = autoText;
            }
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
            using (var db = new KEntities())
            {
                var list = db.Carts.Where(x => x.UserId == 1).ToList();
                foreach (var rm in list)
                {
                    db.Carts.Remove(rm);
                    db.SaveChanges();
                }
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you would like to clear this ORDER?", "Katswiri", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                //db.Database.ExecuteSqlCommand("TRUNCATE TABLE Carts");
                clearmyCart();
            }
            //gridControl1.DataSource = null;
            loadCart();
            lblTotalBill.Text = "0.00";
            lblTaxValue.Text = "0.00";
            lblSubTotal.Text = "0.00";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            textSearchProduct.Text += button.Text;
        }

        private void textSearchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
                {
                    using (var db = new KEntities())
                    {
                        //var choice = db.Products.Where(p => p.ProductCode == textSearchProduct.Text | p.BarCode == textSearchProduct.Text).ToList();
                        //var choice = db.Products.Where(p => p.ProductName.Contains(textSearchProduct.Text)).ToList();
                        var product = db.Products.Where(p => p.ProductName == textSearchProduct.Text.ToString()).FirstOrDefault();
                        var taxValue = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeValue;
                        var taxStatus = db.TaxTypes.Where(x => x.TaxTypeId == product.TaxTypeId).SingleOrDefault().TaxTypeStatus;
                        var exists = db.Carts.Where(x => x.ProductId == product.ProductId).FirstOrDefault();

                        if (exists != null)
                        {
                            exists.Qty += 1;
                            exists.TaxValue = (product.SellingPrice * (taxValue / 100));
                            exists.TotalPrice = (exists.SellingPrice * exists.Qty) + cart.TaxValue;
                            db.Entry(exists).State = EntityState.Modified;
                            db.SaveChanges();
                            clearGrid();
                        }

                        if (exists == null)
                        {
                            cart.ProductId = product.ProductId;
                            cart.SellingPrice = product.SellingPrice;
                            cart.ShopId = db.Shops.FirstOrDefault().ShopId;
                            cart.UserId = 1;
                            cart.DiscountAmount = 0;
                            cart.DiscountPercent = 0;
                            cart.Qty = 1;
                            cart.TaxValue = (product.SellingPrice * (taxValue / 100));
                            cart.TotalPrice = (cart.SellingPrice * cart.Qty) + cart.TaxValue;
                            db.Carts.Add(cart);
                            db.SaveChanges();
                            clearGrid();
                        }
                        loadCart();
                        gridView1.RefreshData();

                    }
                }
            }
            catch
            {

            }
            textSearchProduct.Text = string.Empty;
        }
      
        public void refreshCart()
        {
            try
            {
                //Cart cart = new Cart();
                var selectedRows = gridView1.GetSelectedRows();
                var row = ((vwCart)gridView1.GetRow(selectedRows[0]));
                using (var db = new KEntities())
                {
                    if (row.CartId != -1)
                    {
                        var taxTypeId = db.Products.Where(x => x.ProductId == row.ProductId).SingleOrDefault().TaxTypeId;
                        var taxValue = db.TaxTypes.Where(x => x.TaxTypeId == taxTypeId).SingleOrDefault().TaxTypeValue;
                        //var taxStatus = db.TaxTypes.Where(x => x.TaxTypeId == product1.TaxTypeId).SingleOrDefault().TaxTypeStatus;
                        cart.CartId = row.CartId;
                        cart.UserId = row.UserId;
                        cart.ShopId = row.ShopId;
                        cart.DiscountAmount = 0;
                        cart.DiscountPercent = 0;
                        cart.ProductId = row.ProductId;
                        cart.SellingPrice = row.SellingPrice;
                        cart.Qty = row.Qty;
                        cart.TaxValue = (row.SellingPrice * (taxValue / 100));
                        cart.TotalPrice = (row.SellingPrice * row.Qty) + row.TaxValue;
                        db.Entry(cart).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                    loadCart();
                }
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void gridControl1_KeyUp(object sender, KeyEventArgs e)
        {
            refreshCart();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = gridView1.GetSelectedRows();
                var row = ((vwCart)gridView1.GetRow(selectedRows[0]));
                using (var db = new KEntities())
                {
                    var cart = db.Carts.Find(row.CartId);
                    db.Carts.Remove(cart);
                    db.SaveChanges();
                }
                loadCart();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowDefaultWaitForm("Please Wait", "Loading");
            ShowPayFom();
        }

        private void ShowPayFom()
        {

                Pay pay = null;
                if (pay == null || pay.IsDisposed)
                {
                pay = new Pay();
                }
                pay.Activate();
                pay.ShowDialog();

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.gridView1.IsLastVisibleRow)
                    this.gridView1.MoveNext();
                else
                    this.gridView1.MoveFirst();

            }
            loadCart();
        }
    }
}