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
    public partial class ConnectionManagerUI : Form
    {
       

        public ConnectionManagerUI()
        {
            InitializeComponent();

            //read connection strings from app.settings

            RefreshListView();

            var h = Screen.PrimaryScreen.WorkingArea.Height / 2;
            var w = Screen.PrimaryScreen.WorkingArea.Width / 2;

            this.Height = h;
            this.Width = w;
        }

        public void RefreshListView()
        {
            nativeListView1.Items.Clear();

            foreach (var cs in ConfigurationManager.ConnectionStrings.Cast<ConnectionStringSettings>())
            {
                var lvi = new ListViewItem(cs.Name);
                lvi.SubItems.Add(cs.ProviderName);
                lvi.SubItems.Add(cs.ConnectionString);

                nativeListView1.Items.Add(lvi);
            }
        }

        public ConnectionManagerUI(MainForm f) : this()
        {
            _mdi = f;
        }

        private MainForm _mdi;

        private void nativeListView1_DoubleClick(object sender, EventArgs e)
        {
            var item = nativeListView1.SelectedItems?[0];

            if (item == null) return;

            var name = item.Text;
            var provider = item.SubItems[1].Text;
            var cs = item.SubItems[2].Text;

            var connectionDetail = new ConnectionDetail(provider, cs);

            

            var conn = new ConnectionDetailUI(connectionDetail);
            conn.Text = connectionDetail.Provider;

            _mdi.MdiTab.TabPages.Add(conn);

            _mdi.Show();
            this.Close();
        }

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            (OpenConnectionManagerUI()).Show();

            //this.RefreshListView();
        }

        private void btnEditConnection_Click(object sender, EventArgs e)
        {
            if (nativeListView1.SelectedItems.Count == 0) return;

            var lvi = nativeListView1.SelectedItems[0];

            (OpenConnectionManagerUI(lvi.Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text)).Show();

            //this.RefreshListView();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nativeListView1.SelectedItems.Count == 0) return;

            var lvi = nativeListView1.SelectedItems[0];

            var result = MessageBox.Show($"Are you sure you want to delete '{lvi.Text}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result != DialogResult.OK) return;

            var config = new AppConfigWrapper();
            config.DeleteConnectionString(lvi.Text);

            this.RefreshListView();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (nativeListView1.SelectedItems.Count == 0) return;

            var lvi = nativeListView1.SelectedItems[0];

            var mgr = new DataConnection(lvi.SubItems[1].Text, lvi.SubItems[2].Text);

            try
            {
                using (var c = mgr.Connection)
                {
                    c.Open();


                    var msg = $"Data Source: {c.DataSource}\nDatabase: {c.Database}\nConnection String: {c.ConnectionString}";

                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private NewConnectionUI OpenConnectionManagerUI(string name = "", string provider = "", string connectionString = "")
        {
            return new NewConnectionUI(name, provider, connectionString)
            {
                ConnectionForm = this
            };
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (nativeListView1.SelectedItems.Count == 0) return;

            var lvi = nativeListView1.SelectedItems[0];

            (OpenConnectionManagerUI(lvi.Text + " - Copy", lvi.SubItems[1].Text, lvi.SubItems[2].Text)).Show();
        }

        private void ConnectionManagerUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
