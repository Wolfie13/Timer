using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {
        Utils utils = new Utils();

        private Dictionary<string, AppTime> times = new Dictionary<string, AppTime>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            String AppInUse = utils.GetActiveWindowProcessName();
            lblLastApp.Text = String.Format("Last Application: {0}", AppInUse);

            if (!times.ContainsKey(AppInUse))
            {
                times.Add(AppInUse, new AppTime());
            }

            times[AppInUse].timeSeconds++;

            lblLastAppTime.Text = String.Format("Used For: {0}", times[AppInUse].timeSeconds);

            int totalTime = times.Sum(x => x.Value.timeSeconds);
        }
    }

    class AppTime
    {
        public int timeSeconds;
        public TimeTrackerRow tracker;
    }
}
