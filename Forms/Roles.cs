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
    public partial class Roles : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        KEntities db = new KEntities();
        Role role = new Role();
        string Role;
        public Roles()
        {
            InitializeComponent();
            clearFields();
            loadRoles();
        }

        private void clearFields()
        {
            textEditRole.Text = string.Empty;
            btnDelete.Enabled = false;
            btnSave.Caption = "Save";
            Role = "";
        }

        private void loadRoles()
        {
            gridControl1.DataSource = db.Roles.ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
        }

        private bool formValid()
        {
            var result = true;
            if (String.IsNullOrEmpty(textEditRole.Text))
            {
                result = false;
                textEditRole.ErrorText = "Required";
            }
            return result;
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (formValid())
                {
                    role.RoleName = textEditRole.Text;
                   
                    if (Role !="")
                        db.Entry(role).State = EntityState.Modified;
                    else
                    {
                        var exits = db.Roles.Where(x => x.RoleName == Role).Count();
                        if (exits > 0){
                            XtraMessageBox.Show("Role Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            db.Roles.Add(role);
                        }
                    }
                    db.SaveChanges();
                    clearFields();
                    loadRoles();
                    XtraMessageBox.Show("Tax Type Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this Record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                role.Deleted = 1;
                db.Entry(role).State = EntityState.Modified;
                db.SaveChanges();
                clearFields();
                loadRoles ();
                XtraMessageBox.Show("Record Deleted Successfully");
            }
        }
    }
}