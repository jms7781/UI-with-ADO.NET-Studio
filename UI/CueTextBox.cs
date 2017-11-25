using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public class CueTextBox : TextBox
    {
        private string cue;

        [Description("The cue banner text"), Category("Appearance"), Browsable(true)]
        public string Cue
        {
            get { return cue; }
            set { cue = value; UpdateCue(); }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateCue();
        }

        private void UpdateCue()
        {
            if (this.IsHandleCreated && cue != null)
            {
                NativeMethods.SendMessage(Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, cue);
            }
        }

    }
}
