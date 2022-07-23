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
    public partial class Banks : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        public Banks()
        {
            InitializeComponent();
            loadBanks();
        }

        private void loadBanks()
        {
            gridControl1.DataSource = db.Banks.Where(x => x.Deleted == 0).ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["BankId"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }
    }
}