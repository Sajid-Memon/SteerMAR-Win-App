
namespace SteerMAR.Views.popupForms
{
    partial class frmAddPatientVitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPatientVitals));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.btnCloseThis = new System.Windows.Forms.Button();
            this.drpVitals = new System.Windows.Forms.ComboBox();
            this.btnSaveContact = new SteerMAR.CustomControlls.RoundedButton();
            this.txtVitalValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSaveContact);
            this.panel1.Controls.Add(this.txtVitalValue);
            this.panel1.Controls.Add(this.drpVitals);
            this.panel1.Controls.Add(this.btnCloseThis);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 248);
            this.panel1.TabIndex = 0;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label50.Location = new System.Drawing.Point(1, 5);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(105, 18);
            this.label50.TabIndex = 69;
            this.label50.Text = "Vital History";
            // 
            // btnCloseThis
            // 
            this.btnCloseThis.FlatAppearance.BorderSize = 0;
            this.btnCloseThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseThis.Font = new System.Drawing.Font("Hero", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseThis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCloseThis.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseThis.Image")));
            this.btnCloseThis.Location = new System.Drawing.Point(395, 0);
            this.btnCloseThis.Name = "btnCloseThis";
            this.btnCloseThis.Size = new System.Drawing.Size(22, 26);
            this.btnCloseThis.TabIndex = 68;
            this.btnCloseThis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseThis.UseVisualStyleBackColor = true;
            this.btnCloseThis.Click += new System.EventHandler(this.btnCloseThis_Click);
            // 
            // drpVitals
            // 
            this.drpVitals.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpVitals.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpVitals.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpVitals.FormattingEnabled = true;
            this.drpVitals.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Brother",
            "Sister",
            "Wife",
            "Husband",
            "Son",
            "Daughter",
            ""});
            this.drpVitals.Location = new System.Drawing.Point(25, 63);
            this.drpVitals.Name = "drpVitals";
            this.drpVitals.Size = new System.Drawing.Size(369, 27);
            this.drpVitals.TabIndex = 70;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(141)))), ((int)(((byte)(238)))));
            this.btnSaveContact.BorderRadius = 3;
            this.btnSaveContact.FlatAppearance.BorderSize = 0;
            this.btnSaveContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveContact.Font = new System.Drawing.Font("Hero Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContact.ForeColor = System.Drawing.Color.White;
            this.btnSaveContact.Location = new System.Drawing.Point(276, 173);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(118, 39);
            this.btnSaveContact.TabIndex = 71;
            this.btnSaveContact.Text = "SAVE";
            this.btnSaveContact.UseVisualStyleBackColor = false;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // txtVitalValue
            // 
            this.txtVitalValue.Font = new System.Drawing.Font("Hero", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitalValue.Location = new System.Drawing.Point(25, 128);
            this.txtVitalValue.Name = "txtVitalValue";
            this.txtVitalValue.Size = new System.Drawing.Size(369, 27);
            this.txtVitalValue.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "Vital Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Vital Value";
            // 
            // frmAddPatientVitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 248);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddPatientVitals";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddPatientVitals";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseThis;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox drpVitals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControlls.RoundedButton btnSaveContact;
        private System.Windows.Forms.TextBox txtVitalValue;
    }
}