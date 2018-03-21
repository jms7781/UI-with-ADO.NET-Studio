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
    public partial class QueryUI : Form
    {
        private const Keys execute = Keys.F5;
        private const Keys toggleResults = Keys.Control | Keys.R;
        private const Keys toggleQuery = Keys.Control | Keys.Q;

        public QueryUI()
        {
            InitializeComponent();
        }

        public QueryUI(ConnectionDetail connectionDetail) : this()
        {
            this.Connection = connectionDetail;
        }

        public ConnectionDetail Connection { get; set; }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case execute:
                    MessageBox.Show("Execute");
                    return true;
                case toggleResults:
                    ToggleResults();
                    return true;
                case toggleQuery:
                    ToggleQuery();
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnToggleResults_Click(object sender, EventArgs e)
        {
            ToggleResults();
        }

        private void ToggleResults()
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        private void btnToggleQuery_Click(object sender, EventArgs e)
        {
            ToggleQuery();
        }

        private void ToggleQuery()
        {
            splitContainer1.Panel1Collapsed = !splitContainer1.Panel1Collapsed;
        }

        private void Execute()
        {
            //get the selected text or the entire box. trim the text
            var sql = QueryText.SelectedText.Length > 0 ? QueryText.SelectedText.Trim() : QueryText.Text.Trim();

            var tokens = new[] { "update", "insert", "delete" };


            //not trying to reinvent ssms, just execute a unidata query without msaccess
            //check if the command starts with one of the tokens
            //obviously not full-proof

            var isExecute = tokens.Any(t => sql.StartsWith(t, StringComparison.InvariantCultureIgnoreCase));

            using (var cnn = new System.Data.SqlClient.SqlConnection(""))
            {
                var cmd = cnn.CreateCommand();
                cmd.CommandText = sql;

                if (isExecute)
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    var t = new DataTable();
                    t.Load(cmd.ExecuteReader());

                }
                


            }


            //apply datatable to datagrid

            //show messages

            //show execution time?

            this.Connection.DataConnection.CommandExecuted += DataConnection_CommandExecuted;
        }

        private void DataConnection_CommandExecuted(object sender, System.Data.Common.DbCommand e)
        {
            throw new NotImplementedException();
        }
    }
}
