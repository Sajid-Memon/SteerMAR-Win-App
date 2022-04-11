
namespace SteerMAR.Views.popupForms
{
    partial class frmMedScheduleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedScheduleList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseThis = new System.Windows.Forms.Button();
            this.label50 = new System.Windows.Forms.Label();
            this.dgvTimeList = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvTimeList);
            this.panel1.Controls.Add(this.btnCloseThis);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 250);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseThis
            // 
            this.btnCloseThis.FlatAppearance.BorderSize = 0;
            this.btnCloseThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseThis.Font = new System.Drawing.Font("Hero", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseThis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnCloseThis.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseThis.Image")));
            this.btnCloseThis.Location = new System.Drawing.Point(538, 3);
            this.btnCloseThis.Name = "btnCloseThis";
            this.btnCloseThis.Size = new System.Drawing.Size(22, 26);
            this.btnCloseThis.TabIndex = 76;
            this.btnCloseThis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseThis.UseVisualStyleBackColor = true;
            this.btnCloseThis.Click += new System.EventHandler(this.btnCloseThis_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Hero", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label50.Location = new System.Drawing.Point(3, 8);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(122, 18);
            this.label50.TabIndex = 77;
            this.label50.Text = "Med Schedule";
            // 
            // dgvTimeList
            // 
            this.dgvTimeList.AllowUserToAddRows = false;
            this.dgvTimeList.AllowUserToDeleteRows = false;
            this.dgvTimeList.AllowUserToResizeColumns = false;
            this.dgvTimeList.AllowUserToResizeRows = false;
            this.dgvTimeList.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Qty,
            this.Details,
            this.Week});
            this.dgvTimeList.Location = new System.Drawing.Point(6, 35);
            this.dgvTimeList.Name = "dgvTimeList";
            this.dgvTimeList.RowHeadersVisible = false;
            this.dgvTimeList.Size = new System.Drawing.Size(554, 202);
            this.dgvTimeList.TabIndex = 107;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Time.DataPropertyName = "MedTime";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 65;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 54;
            // 
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Details.DataPropertyName = "Detail";
            this.Details.HeaderText = "Details";
            this.Details.Name = "Details";
            this.Details.Width = 75;
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.DataPropertyName = "Weekdays";
            this.Week.HeaderText = "Week Days";
            this.Week.Name = "Week";
            // 
            // frmMedScheduleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 250);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Hero", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMedScheduleList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMedScheduleList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseThis;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.DataGridView dgvTimeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
    }
}