using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private const string cs = @"Server=xps13\sqlexpress;Database=AdventureWorks2014;Trusted_Connection=True;";

        public NewConnectionUI()
        {
            
            InitializeComponent();
            this.txtConnectionString.Text = cs;

            cboProviders.Items.AddRange(DataConnection.GetInstalledProviders().ToArray());

            cboProviders.SelectedIndex = cboProviders.Items.IndexOf("System.Data.SqlClient");
        }

        public NewConnectionUI(MainForm f) : this()
        {
            _mdi = f;
        }

        private MainForm _mdi;


        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            var sel = cboProviders.SelectedItem;

            if (sel == null) return;

            var dc = new DataConnection(sel.ToString(), txtConnectionString.Text);

            using (var c = dc.Connection)
            {
                try
                {
                    c.Open();
                    MessageBox.Show(c.ConnectionString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCreateConnection_Click(object sender, EventArgs e)
        {
            var sel = cboProviders.SelectedItem;

            if (sel == null) return;
            if (txtConnectionString.Text == null) return;


            var connectionDetail = new ConnectionDetail(sel.ToString(), txtConnectionString.Text);

            var conn = new ConnectionDetailUI(connectionDetail);
            conn.Text = connectionDetail.Provider;

            _mdi.MdiTab.TabPages.Add(conn);

            _mdi.Show();
            this.Close();
        }
    }
}
