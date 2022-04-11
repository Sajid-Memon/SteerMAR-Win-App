using SteerMAR.App_Code.BusinessLogics;
using SteerMAR.Views.MedPassForms;
using SteerMAR.Views.popupForms;
using SteerMAR.Views.ResidentsForms;
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
using static SteerMAR.App_Code.DataAccess.SetupModels;

namespace SteerMAR.Views.MainForms
{
    public delegate void NotifyEvent();
    public partial class frmMainPage : Form
    {
        public NotifyEvent OpenPatientDetails;
        public NotifyEvent OpenPatientListForMedPass;
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

            #region NotifyEvents
            OpenPatientDetails += new NotifyEvent(OpenPatientDetailsForm);
            OpenPatientListForMedPass += new NotifyEvent(OpenPatientListForm);
            #endregion
        }

        #region [NotifyEvents]
        public void OpenPatientDetailsForm()
        {
            openChildForm(new frmResidentsDetails());
        }
        public void OpenPatientListForm()
        {
            openChildForm(new frmResidentListForMedPass());
        }
        public void OpenMedPassFormBasedOnTime()
        {
            openChildForm(new frmMedPass());
        }
        #endregion

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
                UserMethods UM = new UserMethods();
                DataSet ds = UM.UpdateAttendance();
                if (ds.Tables[0].Rows[0]["Message"].ToString() != string.Empty)
                {
                    MessageBox.Show("Your Session has been Ended", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            openChildForm(new frmResidentsList(OpenPatientDetails));
        }
        private void btnHomeMedPass_Click(object sender, EventArgs e)
        {
            frmSelectMedPass SMP = new frmSelectMedPass(OpenPatientListForMedPass);
            SMP.ShowDialog();
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

        #region [Side Menu Button]       
        private void btnSideResidentList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmResidentsList(OpenPatientDetails));
        }
        private void btnMedPass_Click(object sender, EventArgs e)
        {
            frmSelectMedPass SMP = new frmSelectMedPass(OpenPatientListForMedPass);
            SMP.ShowDialog();            
        }
        #endregion

        #region [User Clock IN / OUT Buttons]
        private void btnDashboardCommon_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
        private void btnSideDashboard_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
        private void btnClockIn_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }
        private void btnClockOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you Sure! You Want To End your Current Session?", "Clock Out Session", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserMethods UM = new UserMethods();
                DataSet ds = UM.UpdateAttendance();
                if (ds.Tables[0].Rows[0]["Message"].ToString() != string.Empty)
                {
                    MessageBox.Show("Your Session has been Ended", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnOpenMenu.Visible = false;
                    btnDashboardCommon.Visible = false;
                    btnUserAccount.Visible = false;
                    pnlSideBar.Width = 0;
                    tblHomePageMenu.Enabled = false;
                    pnlLogin.Visible = false;
                    btnClockIn.Enabled = true;
                    btnClockOut.Enabled = false;
                }
            }
        }
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            if (txtPinNo.Text == "" || txtPinNo.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your PIN !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == "" || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Your Password !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserModel userModel = new UserModel();
                userModel.PIN_No = txtPinNo.Text.Trim();
                userModel.User_Password = txtPassword.Text.Trim();
                UserMethods UM = new UserMethods();
                DataSet ds = UM.UserLogin(userModel);
                if (ds.Tables[0].Rows[0]["Message"].ToString() != string.Empty)
                {
                    if (ds.Tables[0].Rows[0]["Message"].ToString() == "Creadantials")
                    {
                        MessageBox.Show("Invalid Cradantials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ds.Tables[0].Rows[0]["Message"].ToString() == "shift")
                    {
                        MessageBox.Show("you are trying to Login in another Shift.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Clocked IN Success", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.LoggedUser = ds.Tables[0].Rows[0]["User_ID"].ToString();
                        pnlLogin.Visible = false;
                        btnOpenMenu.Visible = true;
                        btnDashboardCommon.Visible = true;
                        btnUserAccount.Visible = true;
                        tblHomePageMenu.Enabled = true;
                        btnClockIn.Enabled = false;
                        btnClockOut.Enabled = true;
                    }
                }
            }
            //pnlLogin.Visible = false;
            //btnOpenMenu.Visible = true;
            //btnDashboardCommon.Visible = true;
            //btnUserAccount.Visible = true;
            //tblHomePageMenu.Enabled = true;
            //btnClockIn.Enabled = false;
            //btnClockOut.Enabled = true;
        }
        private void lnkBacktoHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlLogin.Visible = false;
        }
        #endregion        
    }
}
