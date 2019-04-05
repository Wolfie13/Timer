using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            if (AppInUse.Length == 0)
            {
                return;
            }

            lblLastApp.Text = String.Format("Last Application: {0}", AppInUse);

            if (!times.ContainsKey(AppInUse))
            {
                times.Add(AppInUse, new AppTime());
            }

            int newTime = ++times[AppInUse].timeSeconds;

            lblLastAppTime.Text = String.Format("Used For: {0}", newTime);

            int totalTime = times.Sum(x => x.Value.timeSeconds);

            StringBuilder sb = new StringBuilder();
            foreach (var thing in times.OrderByDescending(x => x.Value.timeSeconds))
            {
                sb.Append(thing.Key);
                sb.Append(": ");
                sb.AppendLine(SecondsToTimestamp(thing.Value.timeSeconds));
            }

            tbAllTimes.Text = sb.ToString();

            System.IO.File.WriteAllLines(AppInUse + ".time.txt", new string[] { SecondsToTimestamp(newTime) });
        }

        static string SecondsToTimestamp(int seconds)
        {
            int hours = (int)seconds / 3600;
            int remainder = (int)seconds - hours * 3600;
            int mins = remainder / 60;
            remainder = remainder - mins * 60;
            int secs = remainder;

            return String.Format("{0}:{1}:{2}", hours, mins, secs);
        }
    }

    class AppTime
    {
        public int timeSeconds;
    }
}
