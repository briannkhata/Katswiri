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
    public partial class Incomes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        public Incomes()
        {
            InitializeComponent();
            loadIncomes();
        }
        private void loadIncomes()
        {
            gridControl1.DataSource = db.Incomes.Where(x => x.Deleted == 0).ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["IncomeId"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private void Incomes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'katswiriDataSet1.PaymentTypes' table. You can move, or remove it, as needed.
            //this.paymentTypesTableAdapter.Fill(this.katswiriDataSet1.PaymentTypes);
            // TODO: This line of code loads data into the 'katswiriDataSet.Incomes' table. You can move, or remove it, as needed.
            //this.incomesTableAdapter.Fill(this.katswiriDataSet.Incomes);

        }
    }
}