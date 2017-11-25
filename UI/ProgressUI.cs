using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util.WinForms
{
    public partial class ProgressUI : Form
    {
        public ProgressUI()
        {
            InitializeComponent();
        }

        protected virtual void worker_DoWork(object sender, DoWorkEventArgs e) { }

        protected virtual void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var args = (ProgressArgs)e.UserState;

            lblStatus.Text = args.Message;
            progressBar.Style = args.Style;

            if (args.Style == ProgressBarStyle.Continuous || args.Style == ProgressBarStyle.Blocks)
            {
                progressBar.Minimum = args.Minimum;
                progressBar.Maximum = args.Maximum;
                progressBar.Value = args.Value;
            }
        }

        protected virtual void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.Cancelled)
            {
                MessageBox.Show("The export operation was canceled", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


    }

    public class ProgressArgs : System.EventArgs
    {
        public string Message { get; set; }
        public int Value { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public ProgressBarStyle Style {get; set;}
    }
}
