using DevExpress.XtraBars;
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
    public partial class Products : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        Product product = new Product();
        int ProductId;
        public Products()
        {
            InitializeComponent();
            clearFields();
            loadProducts();
        }

        private void clearFields()
        {
            throw new NotImplementedException();
        }

        private void loadProducts()
        {
            gridControlProducts.DataSource = db.Products.Where(x => x.Deleted == 0).ToList();
            gridControlProducts.Dock = DockStyle.Fill;
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["ProductId"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControlProducts.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}