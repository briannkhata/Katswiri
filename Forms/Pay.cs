using DevExpress.XtraEditors;
using Katswiri.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katswiri.Forms
{
    public partial class Pay : DevExpress.XtraEditors.XtraForm
    {
        KEntities db;
        Cart cart = new Cart();
        Sale sale =  new Sale();
        public Pay()
        {
            InitializeComponent();
        }

        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            using (db = new KEntities())
            {
                cart = db.Carts.Where(p => p.UserId == 1).FirstOrDefault();
                sale.ShopId = cart.ShopId;
                sale.DateSold = DateTime.Now;
                sale.DiscountAmount = cart.DiscountAmount;
                sale.DiscountPercent = cart.DiscountPercent;
                sale.SaleTypeId = s;
                sale.SoldBy = cart.ShopId;
                sale.SoldTo = cart.ShopId;
                sale.TotalBill = cart.ShopId;
                sale.TotalChange = cart.ShopId;
                sale.TotalTendered = cart.ShopId;
                sale.TaxAmount = cart.ShopId;
            }


            Application.Exit();
        }

        private void Pay_Load(object sender, EventArgs e)
        {
            using (db = new KEntities())
            { 
                var total = db.Carts.Where(x => x.UserId == 1).Sum(x => x.TotalPrice);
                textBoxTendered.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", total.ToString(), 2);
            }
        }
    }
}