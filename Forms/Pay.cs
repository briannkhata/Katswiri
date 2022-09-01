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
    public partial class Pay : DevExpress.XtraEditors.XtraForm
    {
        KEntities db;
        Cart cart = new Cart();
        Sale sale;
        SaleDetail saleDetail;

        public Pay()
        {
            InitializeComponent();
            loadPaymentModes();
        }

        private void loadPaymentModes()
        {
            using (db = new KEntities())
            {
                lookUpEditPayMode.Properties.DataSource = db.vwPaymentTypes.ToList();
                lookUpEditPayMode.Properties.ValueMember = "PaymentTypeId";
                lookUpEditPayMode.Properties.DisplayMember = "PaymentTypeName";

            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {

            using (db = new KEntities())
            {
                var totalBill = db.Carts?.Where(x => x.UserId == 1).Sum(x => x.TotalPrice);
                textBoxTendered.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", totalBill, 2);
            }
        }

        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            try
            {
                using (db = new KEntities())
                {
                    sale = new Sale()
                    {
                        DateSold = DateTime.Now,
                        //SaleTypeId = (int)lookUpEditPayMode.EditValue,
                        ShopId = 1,
                        SoldBy = 1,
                        SoldTo = 1,
                        TaxAmount = db.Carts.Where(x => x.UserId == 1).Sum(x => x.TaxValue),
                        TotalBill = db.Carts.Where(x => x.UserId == 1).Sum(x => x.TotalPrice),
                        TotalChange = db.Carts.Where(x => x.UserId == 1).Sum(x => x.TotalPrice) - Double.Parse(textBoxTendered.Text),
                        TotalTendered = Double.Parse(textBoxTendered.Text),
                        DiscountAmount = db.Carts.Where(x => x.UserId == 1).Sum(x => x.DiscountAmount),
                        DiscountPercent = db.Carts.Where(x => x.UserId == 1).Sum(x => x.DiscountPercent),
                    };

                    db.Sales.Add(sale);
                    db.SaveChanges();
                    var saleId = sale.SaleId;//get recently inserted id

                    var cart = db.Carts.Where(x => x.UserId == 1).ToList();
                    foreach (var item in cart)
                    {
                        saleDetail = new SaleDetail()
                        {
                            SaleId = saleId,
                            ProductId = item.ProductId,
                            SellingPrice = item.SellingPrice,
                            ShopId = item.ShopId,
                            SoldPrice = item.TotalPrice,
                            Qty = item.Qty,
                            DiscountAmount = item.DiscountAmount,
                            DiscountPercent = item.DiscountPercent,
                            TaxValue = item.TaxValue,
                            UserId = item.UserId,
                            DateSold = DateTime.Now
                        };
                        db.SaleDetails.Add(saleDetail);
                        db.SaveChanges();
                    }

                    var cartToRemove = db.Carts.Where(x => x.UserId == 1).ToList();//delete from cart
                    if (cartToRemove != null)
                    {
                        foreach(var remove in cartToRemove)
                        {
                            db.Carts.Remove(remove);
                            db.SaveChanges();
                        }
                    }
                    this.Close();

                    //Pos pos = new Pos();


                    

                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}