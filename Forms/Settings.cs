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
        Setting setting = new Setting();
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
                setting = db.Settings.FirstOrDefault();
                if (setting != null)
                {
                    CompanyId = setting.CompanyId;
                    NameTextEdit.Text = setting.Name;
                    PhoneTextEdit.Text = setting.Phone;
                    EmailTextEdit.Text = setting.Email;
                    AddressTextEdit.Text = setting.Address;
                    termsTextEdit.Text = setting.Terms;
                    feeTextEdit.Text = setting.Fee.ToString();
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
                    setting.Name = NameTextEdit.Text?.ToString();
                    setting.Address = AddressTextEdit.Text?.ToString();
                    setting.Phone = PhoneTextEdit.Text?.ToString();
                    setting.Email = EmailTextEdit.Text?.ToString();
                    setting.Fee = Convert.ToDouble(feeTextEdit.Text);
                    setting.Terms = termsTextEdit.Text.ToString();

                    if (CompanyId > 0)
                        db.Entry(setting).State = EntityState.Modified;
                    else
                    {
                        db.Settings.Add(setting);
                    }
                    db.SaveChanges();
                    loadDetails();
                    //XtraMessageBox.Show("Details Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}