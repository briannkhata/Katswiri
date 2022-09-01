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
    public partial class Pay : DevExpress.XtraEditors.XtraForm
    {
        KEntities db;
        Cart cart = new Cart();
        Sale sale =  new Sale();
        public Pay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(db = new KEntities())
            {
                cart = db.Carts.Where(p => p.UserId == 1).FirstOrDefault();
                sale = new Sale();
            }
        }
    }
}