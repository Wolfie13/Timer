using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class TimeTrackerRow : UserControl
    {
        public TimeTrackerRow()
        {
            InitializeComponent();
        }


        private string name;
        private int progress;
        private int totalSize;

        public string ApplicationName
        {
            set
            {
                name = value;
                lblApplicationName.Text = name;
            }
        }

        public int Progress
        {
            set
            {
                progress = value;
                pbProgressBar.Value = progress;
            }
        }

        public int TotalSize
        {
            set
            {
                totalSize = value;
                pbProgressBar.Maximum = totalSize;
            }
        }
    }
}
