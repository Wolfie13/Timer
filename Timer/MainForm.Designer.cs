namespace Timer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.lblLastApp = new System.Windows.Forms.Label();
            this.TimeTrackerLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLastAppTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Interval = 1000;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // lblLastApp
            // 
            this.lblLastApp.AutoSize = true;
            this.lblLastApp.Location = new System.Drawing.Point(13, 13);
            this.lblLastApp.Name = "lblLastApp";
            this.lblLastApp.Size = new System.Drawing.Size(85, 13);
            this.lblLastApp.TabIndex = 0;
            this.lblLastApp.Text = "Last Application:";
            // 
            // TimeTrackerLayout
            // 
            this.TimeTrackerLayout.Location = new System.Drawing.Point(16, 60);
            this.TimeTrackerLayout.Name = "TimeTrackerLayout";
            this.TimeTrackerLayout.Size = new System.Drawing.Size(256, 189);
            this.TimeTrackerLayout.TabIndex = 1;
            // 
            // lblLastAppTime
            // 
            this.lblLastAppTime.AutoSize = true;
            this.lblLastAppTime.Location = new System.Drawing.Point(12, 26);
            this.lblLastAppTime.Name = "lblLastAppTime";
            this.lblLastAppTime.Size = new System.Drawing.Size(56, 13);
            this.lblLastAppTime.TabIndex = 2;
            this.lblLastAppTime.Text = "Used For: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLastAppTime);
            this.Controls.Add(this.TimeTrackerLayout);
            this.Controls.Add(this.lblLastApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Ticker;
        private System.Windows.Forms.Label lblLastApp;
        private System.Windows.Forms.FlowLayoutPanel TimeTrackerLayout;
        private System.Windows.Forms.Label lblLastAppTime;
    }
}

