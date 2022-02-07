
namespace SteerMAR.Views.popupForms
{
    partial class frmPatientVitalsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientVitalsDetails));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseThis = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.calVitalDate = new System.Windows.Forms.MonthCalendar();
            this.dgvVitalHistory = new System.Windows.Forms.DataGridView();
            this.VitalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VitalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVitalHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvVitalHistory);
            this.panel1.Controls.Add(this.calVitalDate);
            this.panel1.Controls.Add(this.btnCloseThis);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 424);
            this.panel1.TabIndex = 1;
            // 
            // btnCloseThis
            // 
            this.btnCloseThis.FlatAppearance.BorderSize = 0;
            this.btnCloseThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseThis.Font = new System.Drawing.Font("Hero", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseThis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCloseThis.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseThis.Image")));
            this.btnCloseThis.Location = new System.Drawing.Point(844, 3);
            this.btnCloseThis.Name = "btnCloseThis";
            this.btnCloseThis.Size = new System.Drawing.Size(22, 26);
            this.btnCloseThis.TabIndex = 68;
            this.btnCloseThis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseThis.UseVisualStyleBackColor = true;
            this.btnCloseThis.Click += new System.EventHandler(this.btnCloseThis_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label50.Location = new System.Drawing.Point(5, 10);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(105, 18);
            this.label50.TabIndex = 69;
            this.label50.Text = "Vital History";
            // 
            // calVitalDate
            // 
            this.calVitalDate.Location = new System.Drawing.Point(17, 48);
            this.calVitalDate.Name = "calVitalDate";
            this.calVitalDate.TabIndex = 70;
            this.calVitalDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calVitalDate_DateChanged);
            // 
            // dgvVitalHistory
            // 
            this.dgvVitalHistory.AllowUserToAddRows = false;
            this.dgvVitalHistory.AllowUserToDeleteRows = false;
            this.dgvVitalHistory.AllowUserToResizeColumns = false;
            this.dgvVitalHistory.AllowUserToResizeRows = false;
            this.dgvVitalHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVitalHistory.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVitalHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvVitalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVitalHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VitalID,
            this.ContactPerson,
            this.VitalTime,
            this.VitalValue});
            this.dgvVitalHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVitalHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvVitalHistory.Location = new System.Drawing.Point(256, 48);
            this.dgvVitalHistory.Name = "dgvVitalHistory";
            this.dgvVitalHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVitalHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvVitalHistory.RowHeadersVisible = false;
            this.dgvVitalHistory.RowHeadersWidth = 20;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Hero Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgvVitalHistory.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvVitalHistory.RowTemplate.Height = 80;
            this.dgvVitalHistory.Size = new System.Drawing.Size(610, 350);
            this.dgvVitalHistory.TabIndex = 71;
            // 
            // VitalID
            // 
            this.VitalID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VitalID.DataPropertyName = "Vital_ID";
            this.VitalID.HeaderText = "VitalID";
            this.VitalID.Name = "VitalID";
            this.VitalID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VitalID.Visible = false;
            this.VitalID.Width = 53;
            // 
            // ContactPerson
            // 
            this.ContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContactPerson.DataPropertyName = "Vital_Name";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ContactPerson.DefaultCellStyle = dataGridViewCellStyle10;
            this.ContactPerson.HeaderText = "Name";
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VitalTime
            // 
            this.VitalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VitalTime.HeaderText = "Time";
            this.VitalTime.Name = "VitalTime";
            this.VitalTime.Width = 65;
            // 
            // VitalValue
            // 
            this.VitalValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VitalValue.HeaderText = "Value";
            this.VitalValue.Name = "VitalValue";
            this.VitalValue.Width = 67;
            // 
            // frmPatientVitalsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 424);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPatientVitalsDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPatientVitalsDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVitalHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseThis;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.MonthCalendar calVitalDate;
        private System.Windows.Forms.DataGridView dgvVitalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn VitalValue;
    }
}