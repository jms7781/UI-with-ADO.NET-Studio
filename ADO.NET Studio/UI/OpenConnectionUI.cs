using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_Studio
{
    public partial class OpenConnectionUI : Form
    {
        public OpenConnectionUI()
        {
            InitializeComponent();

            //read connection strings from app.settings

            foreach (var cs in ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>())
            {
                var lvi = new ListViewItem(cs.ProviderName);
                lvi.SubItems.Add(cs.Name);
                lvi.SubItems.Add(cs.ConnectionString);

                nativeListView1.Items.Add(lvi);
            }
        }

        public OpenConnectionUI(MainForm f) : this()
        {
            _mdi = f;
        }

        private MainForm _mdi;

        private void nativeListView1_DoubleClick(object sender, EventArgs e)
        {
            var item = nativeListView1.SelectedItems?[0];

            if (item == null) return;

            var provider = item.Text;
            var cs = item.SubItems[2].Text;

            var connectionDetail = new ConnectionDetail(provider, cs);

            var conn = new ConnectionDetailUI(connectionDetail);
            conn.Text = connectionDetail.Provider;

            _mdi.MdiTab.TabPages.Add(conn);

            _mdi.Show();
            this.Close();
        }
    }
}
