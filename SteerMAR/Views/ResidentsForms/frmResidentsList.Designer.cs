
namespace SteerMAR.Views.ResidentsForms
{
    partial class frmResidentsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResidentsList));
            this.rptPatientsList = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnSearch = new SteerMAR.CustomControlls.RoundedButton();
            this.roundedPanel2 = new SteerMAR.CustomControlls.RoundedPanel();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPatientPhoto = new System.Windows.Forms.PictureBox();
            this.rptPatientsList.ItemTemplate.SuspendLayout();
            this.rptPatientsList.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // rptPatientsList
            // 
            this.rptPatientsList.AllowUserToAddItems = false;
            this.rptPatientsList.AllowUserToDeleteItems = false;
            this.rptPatientsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptPatientsList.ItemHeaderVisible = false;
            // 
            // rptPatientsList.ItemTemplate
            // 
            this.rptPatientsList.ItemTemplate.Controls.Add(this.roundedPanel2);
            this.rptPatientsList.ItemTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rptPatientsList.ItemTemplate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.rptPatientsList.ItemTemplate.Size = new System.Drawing.Size(852, 102);
            this.rptPatientsList.Location = new System.Drawing.Point(12, 83);
            this.rptPatientsList.Name = "rptPatientsList";
            this.rptPatientsList.Size = new System.Drawing.Size(860, 466);
            this.rptPatientsList.TabIndex = 1;
            this.rptPatientsList.Text = "dataRepeater1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hero New Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type here to Search";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtSearchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchText.Font = new System.Drawing.Font("Hero", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchText.ForeColor = System.Drawing.Color.White;
            this.txtSearchText.Location = new System.Drawing.Point(12, 39);
            this.txtSearchText.Multiline = true;
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(793, 38);
            this.txtSearchText.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Hero Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(811, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 38);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BorderColor = System.Drawing.Color.Green;
            this.roundedPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel2.Controls.Add(this.lblPatientName);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Controls.Add(this.pbPatientPhoto);
            this.roundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel2.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 20;
            this.roundedPanel2.Size = new System.Drawing.Size(848, 87);
            this.roundedPanel2.TabIndex = 0;
            this.roundedPanel2.Thickness = 5F;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Hero New Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPatientName.Location = new System.Drawing.Point(94, 47);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(130, 22);
            this.lblPatientName.TabIndex = 3;
            this.lblPatientName.Text = "Riquetti, Peter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hero New Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(95, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT / RESIDENT";
            // 
            // pbPatientPhoto
            // 
            this.pbPatientPhoto.Location = new System.Drawing.Point(18, 12);
            this.pbPatientPhoto.Name = "pbPatientPhoto";
            this.pbPatientPhoto.Size = new System.Drawing.Size(71, 63);
            this.pbPatientPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatientPhoto.TabIndex = 0;
            this.pbPatientPhoto.TabStop = false;
            // 
            // frmResidentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptPatientsList);
            this.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmResidentsList";
            this.Text = "frmResidentsList";
            this.rptPatientsList.ItemTemplate.ResumeLayout(false);
            this.rptPatientsList.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.DataRepeater rptPatientsList;
        private CustomControlls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.PictureBox pbPatientPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label label1;
        private CustomControlls.RoundedButton btnSearch;
    }
}