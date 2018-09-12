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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            var f = new ConnectionManagerUI(this);
            //f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
        }

        //public void AddConnection(ConnectionDetail connection)
        //{
        //    var node = ConnectionTree.Nodes.Add(connection.Provider);
        //    node.Tag = connection;

        //    node.Nodes.Add("Tables");
        //    var tables = connection.DataConnection.Tables;

        //    node.Nodes.Add("Views");
        //    node.Nodes.Add("Procedures");
        //    node.Nodes.Add("Functions");

        //}

        public void AddFormToTab(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Visible = true;
            f.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(f.Text);
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(f);
        }


    }
}
