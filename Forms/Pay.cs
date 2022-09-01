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
            loadPaymentModes();
        }

        private void btnFinishSale_Click(object sender, EventArgs e)
        {
            using (db = new KEntities())
            {
            }

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

        }
    }
}