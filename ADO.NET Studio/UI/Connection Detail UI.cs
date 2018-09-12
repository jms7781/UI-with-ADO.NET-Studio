using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace ADO.NET_Studio
{
    public partial class ConnectionDetailUI : Form
    {
        public ConnectionDetailUI()
        {
            InitializeComponent();
        }

        private ConnectionDetail _cnn;
        public ConnectionDetailUI(ConnectionDetail connectionDetail) : this()
        {
            _cnn = connectionDetail;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var f = new MetadataUI(_cnn);
            f.Text = "Metadata";

            //tabControl1.TabPages.Add(f);

            OpenAsTab(f);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenAsTab(new ObjectBrowserUI(_cnn));
        }

        private void OpenAsTab(Form form)
        {
            //var p = tabControl1.TabPages.Add(form);
            //p.TabIndex = tabControl1.TabPages.Count - 1;

            AddFormToTab(form);


        }

        public void AddFormToTab(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Visible = true;
            f.Dock = DockStyle.Fill;

            tabControl2.TabPages.Add(f.Text);
            tabControl2.TabPages[tabControl2.TabPages.Count - 1].Controls.Add(f);

            tabControl2.SelectedIndex = tabControl2.TabPages.Count - 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var f = new QueryUI(_cnn);
            f.Text = "Query Editor";
            OpenAsTab(f);
        }
    }
}
