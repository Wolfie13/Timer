namespace Timer
{
    partial class TimeTrackerRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.pbProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Location = new System.Drawing.Point(0, 5);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(107, 13);
            this.lblApplicationName.TabIndex = 0;
            this.lblApplicationName.Text = "ApplicationName.exe";
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.Location = new System.Drawing.Point(114, 0);
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.Size = new System.Drawing.Size(163, 23);
            this.pbProgressBar.TabIndex = 1;
            this.pbProgressBar.Value = 30;
            // 
            // TimeTrackerRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbProgressBar);
            this.Controls.Add(this.lblApplicationName);
            this.Name = "TimeTrackerRow";
            this.Size = new System.Drawing.Size(280, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.ProgressBar pbProgressBar;
    }
}
