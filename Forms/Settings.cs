using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Katswiri.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katswiri.Forms
{
    public partial class Settings : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        Company company = new Company();
        int CompanyId;
        public Settings()
        {
            InitializeComponent();
            loadDetails();
        }

        public void loadDetails()
        {
            try
            {
                company = db.Company.FirstOrDefault();
                if (company != null)
                {
                    CompanyId = company.CompanyId;
                    NameTextEdit.Text = company.Name;
                    PhoneTextEdit.Text = company.Phone;
                    EmailTextEdit.Text = company.Email;
                    AddressTextEdit.Text = company.Address;
                    termsTextEdit.Text = company.Terms;
                    feeTextEdit.Text = company.Fee;
                }
            } 
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool formValid()
        {
            var result = true;
            if (String.IsNullOrEmpty(NameTextEdit.Text))
            {
                result = false;
                NameTextEdit.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(EmailTextEdit.Text))
            {
                result = false;
                EmailTextEdit.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(PhoneTextEdit.Text))
            {
                result = false;
                PhoneTextEdit.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(termsTextEdit.Text))
            {
                result = false;
                termsTextEdit.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(feeTextEdit.Text))
            {
                result = false;
                feeTextEdit.ErrorText = "Required";
            }

            if (String.IsNullOrEmpty(AddressTextEdit.Text))
            {
                result = false;
                AddressTextEdit.ErrorText = "Required";
            }
            return result;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (formValid())
                {
                    company.Name = NameTextEdit.Text.ToString();
                    company.Address = AddressTextEdit.Text.ToString();
                    company.Phone = PhoneTextEdit.Text.ToString();
                    company.Email = EmailTextEdit.Text.ToString();
                    company.Fee = feeTextEdit.Text;
                    company.Terms = termsTextEdit.Text.ToString();

                    if (CompanyId > 0)
                        db.Entry(company).State = EntityState.Modified;
                    else
                    {
                        db.Company.Add(company);
                    }
                    db.SaveChanges();
                    loadDetails();
                    XtraMessageBox.Show("Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}