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
    public partial class Form1 : Form
    {
        private const string cs = @"Server=xps13\sqlexpress;Database=AdventureWorks2014;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();

            var connectionDetail = new ConnectionDetail("System.Data.SqlClient", cs);

            //tabControl1.TabPages.Add(new ConnectionDetailUI(connectionDetail));

            var bs = new BindingSource();
            bs.DataSource = FakeData();

            dataGridView1.DataSource = bs;

        }

        private DataTable FakeData()
        {
            var t = new DataTable();
            t.Columns.Add("ID", typeof(string));
            var r = t.NewRow();
            r[0] = Guid.NewGuid().ToString();
            return t;
        }
    }
}
