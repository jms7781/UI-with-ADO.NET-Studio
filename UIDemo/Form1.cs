using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessWrapper;
using System.Data.SqlClient;
using System.Data;

namespace UIDemo
{
    public partial class Form1 : Form
    {
        private const string cs = @"Server=xps13\sqlexpress;Database=AdventureWorks2014;Trusted_Connection=True;";
        private DataConnection<SqlConnection> db;

        public Form1()
        {
            InitializeComponent();

            db = new DataConnection<SqlConnection>(cs);

            var schema = db.GetSchema();

            foreach (DataRow row in schema.Rows)
            {
                var f = new Grid();
                

                var name = row[0].ToString();
                //f.searchListView1.ApplyDataSource(db.GetSchema(name));
                f.searchDataGrid1.ApplyDataTale(db.GetSchema(name));
                f.Text = name;

                AddNewTab(f);
                //f.Show();
            }

        }

        private void AddNewTab(Form frm)
        {

            TabPage tab = new TabPage(frm.Text);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ShowInTaskbar = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = tab;

            frm.Visible = true;

            tabControl1.TabPages.Add(tab);

            //frm.Location = new Point((tab.Width - frm.Width) / 2, (tab.Height - frm.Height) / 2);

            tabControl1.SelectedTab = tab;
            frm.Show();

        }
    }
}
