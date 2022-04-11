using SteerMAR.Views.popupForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.MedPassForms
{
    public partial class frmMedPass : Form
    {
        public frmMedPass()
        {
            InitializeComponent();
        }

        private void frmMedPass_Load(object sender, EventArgs e)
        {
            foreach (TabPage tp in tabControl1.TabPages) tp.Text = tp.Text.Replace("\\n", "\n");
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
