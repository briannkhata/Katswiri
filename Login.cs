﻿using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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

namespace Katswiri
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        KEntities db = new KEntities();
        User users = new User();
        public Login()
        {
            InitializeComponent();
            textEditUserName.Text = "";
            textEditPassWord.Text = "";
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Please Wait", "Authenticating");
            if (formValid())
            {
                var username = textEditUserName.Text.ToLower();
                var password = textEditPassWord.Text;
                var loggedInUser = string.Empty;
                var loggedInRole = string.Empty;
                try
                {  
                        var user = db.Users.Where(x => x.UserName == username && x.PassWord == password).ToList();
                        if (user.Count == 1)
                        {
                            var loggedIn = db.Users.Where(x => x.UserName == username).Single();
                             users.UserName = loggedIn.UserName;
                             users.Role = loggedIn.Role;
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            XtraMessageBox.Show("You don't have any privileges to use this system.", "Insufficient Privileges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                SplashScreenManager.CloseDefaultWaitForm();
            }
            catch (Exception) { }
        }

         private bool formValid()
        {
            var result = true;
            var username = textEditUserName.Text.Trim();
            var password = textEditPassWord.Text.Trim();
            if (String.IsNullOrEmpty(username))
            {
                result = false;
                textEditUserName.ErrorText = "Please provide username";
            }
            if (String.IsNullOrEmpty(password))
            {
                result = false;
                textEditPassWord.ErrorText = "Please provide password";
            }
            return result;
        }
    }
}