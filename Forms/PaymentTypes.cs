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
    public partial class PaymentTypes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        public PaymentTypes()
        {
            InitializeComponent();
            loadPaymentTypes();
        }

        private void loadPaymentTypes()
        {
            gridControl1.DataSource = db.PaymentTypes.Where(x => x.Deleted == 0).ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["PaymentTypeId"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }
    }
}