
namespace SteerMAR.Views
{
    partial class frmTestPage
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
            this.CBWeekDays = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CBWeekDays
            // 
            this.CBWeekDays.ColumnWidth = 70;
            this.CBWeekDays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBWeekDays.FormattingEnabled = true;
            this.CBWeekDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.CBWeekDays.Location = new System.Drawing.Point(164, 103);
            this.CBWeekDays.MultiColumn = true;
            this.CBWeekDays.Name = "CBWeekDays";
            this.CBWeekDays.Size = new System.Drawing.Size(152, 64);
            this.CBWeekDays.TabIndex = 0;
            this.CBWeekDays.ThreeDCheckBoxes = true;
            this.CBWeekDays.UseCompatibleTextRendering = true;
            // 
            // frmTestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1149, 611);
            this.Controls.Add(this.CBWeekDays);
            this.Name = "frmTestPage";
            this.Text = "frmTestPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CBWeekDays;
    }
}