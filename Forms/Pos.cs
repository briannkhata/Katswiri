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
    public partial class Pos : DevExpress.XtraEditors.XtraForm
    {
        KEntities db = new KEntities();
        public Pos()
        {
            InitializeComponent();
            loadCart();
        }

        private void loadCart()
        {
             gridControl1.DataSource = db.vwTempSales.ToList();
             //gridView1.OptionsBehavior.Editable = false;
             gridView1.Columns["UserId"].Visible = false;
             gridView1.Columns["ShopId"].Visible = false;
             //gridView1.Columns["AddedBy"].Visible = false;
             gridView1.OptionsView.ShowIndicator = false;
             gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}