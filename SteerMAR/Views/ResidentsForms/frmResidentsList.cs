using SteerMAR.App_Code.BusinessLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteerMAR.Views.ResidentsForms
{
    public partial class frmResidentsList : Form
    {
        public frmResidentsList()
        {
            InitializeComponent();           
        }

        private void txtSearchText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchText.Text != null && txtSearchText.Text != string.Empty)
            {                
                PatientMethods PM = new PatientMethods();
                DataSet ds = PM.SelectResidentListBySearch(txtSearchText.Text.Trim());
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["Patient_Image"] != DBNull.Value)
                    {
                        MemoryStream msLogo = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Patient_Image"]);
                        if (msLogo != null && msLogo.Length > 0)
                        {
                            pbPatientPhoto.Image = new Bitmap(msLogo);
                        }
                    }
                    string PatientName = ds.Tables[0].Rows[0]["First_Name"].ToString() + "," + ds.Tables[0].Rows[0]["Last_Name"].ToString();
                    lblPatientName.DataBindings.Clear();
                    lblPatientName.DataBindings.Add("Text", PatientName, "PatientName");
                    rptPatientsList.DataSource = ds.Tables[0];
                }
            }
            else
            {
                MessageBox.Show("Please Enter Patient Code eigther Patient Name for Search");
            }
        }
    }
}
