using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Katswiri.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katswiri.Forms
{
    public partial class Pos : DevExpress.XtraEditors.XtraForm
    {
        KEntities db = new KEntities();
        TempSale TempSale = new TempSale();
        Product product = new Product();
        ProductQuantity productQuantity = new ProductQuantity();

        public Pos()
        {
            InitializeComponent();
            loadCart();
            autoCompleteSearch();
        }

        private void loadCart()
        {
             gridControl1.DataSource = db.vwTempSales.ToList();
             gridView1.OptionsBehavior.Editable = false;
             gridView1.Columns["UserId"].Visible = false;
             gridView1.Columns["ShopId"].Visible = false;
             gridView1.Columns["ProductId"].Visible = false;
             gridView1.OptionsView.ShowIndicator = false;
             gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
       
        }

        private void autoCompleteSearch()
        {
            textSearchProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            textSearchProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection autoText = new AutoCompleteStringCollection();
            //autoText.Add(db.Products.SingleOrDefault().ProductName);
            textSearchProduct.AutoCompleteCustomSource = autoText;
        }

      

        private void Pos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (XtraMessageBox.Show("Are you sure you would like to cancel POS UI?", "Katswiri", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you would remove clear this ORDER?", "Katswiri", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE TempSales");
            }
        }
    }
}