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
    public partial class NewConnectionUI : Form
    {
        private AppConfigWrapper appConfig = new AppConfigWrapper();

        public NewConnectionUI()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            cboProvider.Items.AddRange(DataConnection.GetInstalledProviders().ToArray());
        }

        public NewConnectionUI(string name, string provider, string connectionString) : this()
        {
            txtName.Text = name;
            cboProvider.Text = provider;
            txtCS.Text = connectionString;
        }

        public ConnectionManagerUI ConnectionForm { get; set; }

        private void UpdateConnectionForm()
        {
            if (ConnectionForm != null)
            {
                ConnectionForm.RefreshListView();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            var cs = txtCS.Text.Trim();
            var provider = cboProvider.SelectedItem.ToString();

                     

            appConfig.AddOrUpdateConnection(name, provider, cs);

            UpdateConnectionForm();
            this.Close();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            var mgr = new DataConnection(cboProvider.Text, txtCS.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
