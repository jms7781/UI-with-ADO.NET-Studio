using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Export_Admin
{
    public partial class Form1 : Form
    {
        private const string cs = @"Server=xps13\sqlexpress;Database=AdventureWorks2014;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            var x = new DataConnection<SqlConnection>(cs);


        }

        private void searchListView1_Load(object sender, EventArgs e)
        {

        }
    }
}
