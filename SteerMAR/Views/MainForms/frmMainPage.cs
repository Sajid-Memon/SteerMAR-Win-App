using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.MainForms
{
    public partial class frmMainPage : Form
    {
        private bool Hidden;
        public frmMainPage()
        {
            Thread t = new Thread(new ThreadStart(StartSplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            btnOpenMenu.Image = SteerMAR.Properties.Resources.openMenu;
            Hidden = true;
            pnlLogin.Visible = false;
            btnOpenMenu.Visible = false;
            btnDashboardCommon.Visible = false;
            btnUserAccount.Visible = false;
            pnlSideBar.Width = 0;
            tblHomePageMenu.Enabled = false;
            btnClockOut.Enabled = false;
        }

        #region [Functions]
        private void StartSplashScreen()
        {
            Application.Run(new frmSplashScreen());
        }
        public static Form activeForm = null;
        //public void OpenActivationPage()
        //{
        //    Hidden = true;
        //    btnOpenMenu.Visible = false;
        //    btnDashboardCommon.Visible = false;
        //    btnUserAccount.Visible = false;
        //    pnlSideBar.Width = 0;
        //    openChildForm(new frmSubscriberCode(CloseSunscriberForm));
        //}
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region [Application Controll Buttons]
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure! You Want To Close This Application?", "Exit Application", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //UserMethods UM = new UserMethods();
                //DataSet ds = UM.UpdateAttendance();
                //if (ds.Tables[0].Rows[0]["Message"].ToString() != string.Empty)
                //{
                //    MessageBox.Show("Your Session has been Ended", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                Application.Exit();
            }
        }
        private void btnMaximizeWindow_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnMinimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pnlTopBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        #region [Dragable Form Code]
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void frmMainPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region [Side Bar Menu open & Close]
        private void btnOpenMenu_Click(object sender, EventArgs e)
        {
            if (Hidden == true)
            {
                btnOpenMenu.Image = SteerMAR.Properties.Resources.closeMenu;
                pnlSideBar.Width = 280;
                btnDashboardCommon.Visible = false;
                Hidden = false;
            }
            else
            {
                btnOpenMenu.Image = SteerMAR.Properties.Resources.openMenu;
                pnlSideBar.Width = 0;
                btnDashboardCommon.Visible = true;
                Hidden = true;
            }
        }

        #endregion

        #endregion

        #region [Dashboard Menu Buttons]       
        private void btnHomeResidents_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeMedPass_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeCRM_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeMedDelivery_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeReports_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeUsers_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeDoctorLogin_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeNurse_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeHomeHealth_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeMissedMed_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeResidentForm_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeTaskManager_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeBilling_Click(object sender, EventArgs e)
        {

        }
        private void btnHomeSwitchALF_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [User Clock IN / OUT Buttons]
        private void btnDashboardCommon_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
        private void btnClockIn_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }
        private void btnClockOut_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void lnkBacktoHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSubscription());
        }
    }
}
