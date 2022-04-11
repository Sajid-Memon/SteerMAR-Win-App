using SteerMAR.Views.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.popupForms
{
    public partial class frmSelectMedPass : Form
    {
        NotifyEvent GoToList;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public frmSelectMedPass(NotifyEvent openList)
        {
            InitializeComponent();
            GoToList = openList;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 350, 350));
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            GoToList.Invoke();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            GoToList.Invoke();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            GoToList.Invoke();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            GoToList.Invoke();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            GoToList.Invoke();
        }
    }
}
