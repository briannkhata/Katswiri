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
        int RoleId;
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
            RoleId = 0;
        }

        private void loadRoles()
        {
            gridControl1.DataSource = db.vwRoles.ToList();
            gridView1.Columns["Deleted"].Visible = false;
            gridView1.Columns["RoleId"].Visible = false;
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
                   
                    if (RoleId > 0)
                        db.Entry(role).State = EntityState.Modified;
                    else
                    {
                        db.Roles.Add(role);
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selectedRows = gridView1.GetSelectedRows();
            var row = ((vwRole)gridView1.GetRow(selectedRows[0]));
            if (row.RoleId != -1)
            {
                RoleId = row.RoleId;
                role = db.Roles.Where(x => x.RoleId == RoleId).FirstOrDefault();
                textEditRole.Text = role.RoleName;
            }
            btnSave.Caption = "Update";
            btnDelete.Enabled = true;
        }

        private void Roles_Load(object sender, EventArgs e)
        {

        }
    }
}