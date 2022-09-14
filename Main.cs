using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Katswiri.Data;
using Katswiri.Forms;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katswiri
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        //private Login formLogin;
        Home home = null;
        Main main = null;
        Products productsForm = null;
        Login formLogin = null;

        User users = new User();

        Units unitsForm = null;

        public Main()
        {
            InitializeComponent();
           this.IsMdiContainer = true;
           versionHi.Caption = $"Version : {Assembly.GetExecutingAssembly().GetName().Version.ToString()}";
           logout.Caption = "Logout";
          // userNameDisplay.Caption = LoginInfo.UserName;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Please Wait", "Loading");
            //showLogin();
        }


        private void showLogin()
        {
            formLogin = new Login();
            ribbon.Enabled = false;
            SplashScreenManager.CloseDefaultSplashScreen();
            if(formLogin.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   InitMainView();
                   ribbon.Enabled = true;
                   logger.Info($"User logged into the system");
                }
                catch (Exception ex)
                {
                    logger.Error(ex, ex.Message);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void ShowHome()
        {
            if (home == null || home.IsDisposed)
            {
                home = new Home();
            }
            home.MdiParent = this;
            home.Activate();
            home.Show();
            home.BringToFront();
        }

    

        private void InitMainView()
        {
            using (var db = new KEntities()) {
                //usernameLabel.Caption = $"{Globals.User.UserName} (<b>{Globals.User.FirstName} {Globals.User.SurName}</b>)";
                userNameDisplay.Caption = $"{LoginInfo.UserName} ({ db.Users.Where(x => x.UserId == LoginInfo.UserId).Single().Name })";
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            //showLogin();
            //user.Caption = $"{logg.User.UserName} (<b>{Globals.User.FirstName} {Globals.User.SurName}</b>)";
            userNameDisplay.Caption = LoginInfo.UserName;
        }

        private void doSignOut()
        {
            try
            {
                //this.closeAllMdiChildren();
                //Globals.User = null;
                //Globals.AuthenticationHeader = null;
                //usernameLabel.Caption = "";
                showLogin();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                Application.Exit();
            }
        }

        private void closeAllMdiChildren()
        {
            var mdiChildren = main.MdiChildren;
            foreach (var item in mdiChildren)
            {
                item.Close();
            }
        }


        private void ribbon_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e)
        {
            ribbon.SelectPage(e.MergedChild.SelectedPage);

        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowHome();
        }


        private void ShowPosFom()
        {
            Pos pos = null;
            if (pos == null || pos.IsDisposed)
            {
                pos = new Pos();
            }
            pos.Activate();
            pos.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you would like to exit Katswiri?", "Katswiri", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            showLogin();
        }

        private void logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            doSignOut();
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Please Wait", "Loading");
            ShowPosFom();
        }
    }
}