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
using System.Data.Entity;
using DevExpress.XtraSplashScreen;

namespace Katswiri.Forms
{
    public partial class Categories : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        public Categories()
        {
            InitializeComponent();
            btnDelete.Enabled = false;
            loadCategories();
        }

        private void loadCategories()
        {
            gridControlCategories.DataSource = db.Categories.Where(x => x.Deleted == 0).ToList();
            gridView2.Columns["Deleted"].Visible = false;
            gridView2.Columns["CategoryId"].Visible = false;
            gridView2.OptionsBehavior.Editable = false;
            gridControlCategories.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

       


        private void GetCategory()
        {
            //var selectedRows = gridView1.GetSelectedRows();
            //if (selectedRows.Count() == 1)
            //{
            //    var row = (vwApplicant)gridView1.GetRow(selectedRows[0]);
            //    if (row is vwApplicant)
            //    {
            //        var applicantID = ((vwApplicant)row).Applicant_ID;
            //        var formmode = FormMode.Viewonly;
            //        ViewpaymentsbarButtonItem.Enabled = false;
            //        if (row.ApplicationStatusId >= approvedStatusCode)
            //        {
            //            formmode = FormMode.ViewAssessed;
            //        }
            //        SplashScreenManager.ShowDefaultWaitForm();
            //        var applicantForm = new ApplicantForm(applicantID, formmode);
            //        var result = applicantForm.ShowDialog();
            //        if (result == DialogResult.OK)
            //        {
            //            loadApplications();
            //        }
            //    }
            //}
        }

        
    }
}