using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using Katswiri.Data;
using Katswiri.Enums;
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
    public partial class CreateCategory : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        private FormMode _formMode;

        public FormMode formMode
        {
            get
            {
                return _formMode;
            }

            set
            {

                switch (value)
                {
                    case FormMode.New:
                        enableControls();
                        break;
                    case FormMode.Update:
                        enableControls(); ;
                        break;
                    case FormMode.View:
                        disableControls();
                        break;
                    default:
                        break;
                }

                _formMode = value;
            }
        }

        private void disableControls()
        {
            foreach (BaseLayoutItem item in dataLayoutControl1.Items)
                {
                    if (item is LayoutControlItem)
                    {
                        var x = (LayoutControlItem)item;
                        x.Enabled = false;
                    }
                }
            textEdit1.Enabled = false;
            memoEdit1.Enabled = false;
            barButtonItem1.Enabled = false;
        }

        private void enableControls()
        {
            foreach (BaseLayoutItem item in dataLayoutControl1.Items)
            {
                if (item is LayoutControlItem)
                {
                    var x = (LayoutControlItem)item;
                    x.Enabled = true;
                }
            }
            textEdit1.Enabled = true;
            memoEdit1.Enabled = true;
            barButtonItem1.Enabled = true;
        }

        public CreateCategory()
        {
            InitializeComponent();
            //applicantDtoBindingSource.DataSource = new ApplicantDto()
            //{
            //    Id = "(Auto)",
            //    CapturedBy = Globals.User.Username,
            //    DateCaptured = DateTime.Now,
            //    ApplicationStatusId = NEW_APPLICATION_FORM_STATUS,
            //    StationCode = Globals.User.StationCode
            //};
        
            formMode = FormMode.New;
            //hideErrors();
            //labelControl1.Visible = false;
            //labelControl2.Visible = false;
            //applicantNumberLabelControl.Visible = false;
            // Add statements to hide other labels
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isValid())
            {
                try
                {
                    Category category = new Category();
                    category.CategoryName = textEdit1.Text;
                    db.Categories.Add(category);
                    db.SaveChanges();
                    XtraMessageBox.Show("Category Saved Sucecssfully", "Success Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearFields();
                }
            }
        }

        public void clearFields()
        {
            textEdit1.Text = "";
            memoEdit1.Text = "";
        }

        private bool isValid()
        {
            int errors = 0;
            if (String.IsNullOrEmpty(textEdit1.Text))
            {
                textEdit1.ErrorText = "Required";
                errors++;
            }
            if (String.IsNullOrEmpty(memoEdit1.Text))
            {
                memoEdit1.ErrorText = "Required";
                errors++;
            }
            return errors == 0;
        }

        private void textEdit_KeyUp(object sender, KeyPressEventArgs e)
        {
            (sender as TextEdit).ErrorText = "";
        }

    }
}