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
    public partial class ObjectBrowserUI : Form
    {
        public ObjectBrowserUI()
        {
            InitializeComponent();
        }

        private void LoadSchema()
        {
            nativeTreeView1.Nodes.Clear();

            //root node
            var root = nativeTreeView1.Nodes.Add(_cnn.DataConnection.Connection.DataSource);

            var schemas = _cnn.DataConnection.GetSchema().AsEnumerable().Select(r => r[0].ToString()).ToList();

            //schemas
            foreach (var schema in schemas)
            {
                var node = root.Nodes.Add(schema);

                var results = _cnn.DataConnection.GetSchema(schema);

                foreach (DataRow row in results.Rows)
                {
                    node.Nodes.Add(row[0].ToString());
                    System.Diagnostics.Debug.Print(row.ToString());
                }
            }


        }

        private ConnectionDetail _cnn;
        public ObjectBrowserUI(ConnectionDetail connectionDetail) : this()
        {
            _cnn = connectionDetail;

            LoadSchema();

            ////load tree

            //TableNode.Nodes.Clear();
            //ViewNode.Nodes.Clear();

            //var tables = _cnn.Tables.AsEnumerable()
            //            .Where(r => r["table_type"].ToString() == "BASE TABLE")
            //            .Select(s => s["table_schema"].ToString() + "." + s["table_name"].ToString())
            //            .OrderBy(o => o);

            //var views = _cnn.Tables.AsEnumerable()
            //            .Where(r => r["table_type"].ToString() == "VIEW")
            //            .Select(s => s["table_schema"].ToString() + "." + s["table_name"].ToString())
            //            .OrderBy(o => o);


            //foreach (var table in tables)
            //{
            //    TableNode.Nodes.Add(table);
            //}

            //foreach (var view in views)
            //{
            //    ViewNode.Nodes.Add(view);
            //}
        }

        private TreeNode TableNode
        {
            get { return nativeTreeView1.Nodes[0]; }
        }

        private TreeNode ViewNode
        {
            get { return nativeTreeView1.Nodes[1]; }
        }

        private void nativeTreeView1_DoubleClick(object sender, EventArgs e)
        {

            var sel = nativeTreeView1.SelectedNode;

            if (sel == null || sel.Parent == null) return;

            var parent = sel.Parent;
            var name = sel.Text;

            var td = new TableDetailUI();
            td.Text = name;

            var ts = name.Split('.');

            var tableSchema = name.Split('.')[0];
            var tableName = name.Split('.')[1];

            var cols = _cnn.Columns.Select($"TABLE_NAME = '{tableName}' and TABLE_SCHEMA = '{tableSchema}'").CopyToDataTable();
            var schema = cols.Rows[0]["TABLE_SCHEMA"].ToString();

            td.ColumnGrid.ApplyDataTale(cols);
            td.ColumnGrid.DataGrid.Columns[0].Visible = false;
            td.ColumnGrid.DataGrid.Columns[1].Visible = false;
            td.ColumnGrid.DataGrid.Columns[2].Visible = false;

            td.ColumnGrid.DataGrid.AutoSizeSmart();

            tabControl1.CreateTabPageForm(td);

            var p = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
            tabControl1.SelectedTab = p;

            td.tabControl1.Selected += (s, args) =>
            {
                if (args.TabPage.Name == "DataTab")
                {
                    var adapter = _cnn.DataConnection.QueryDataAdapter($"select * from {tableSchema}.{tableName}");
                    
                    td.DataGrid.ApplyDataAdapter(adapter);

                    //using (var cnn = _cnn.DataConnection.Connection)
                    //using (var cmd = cnn.CreateCommand())
                    //{
                    //    cmd.CommandText = $"select * from {tableSchema}.{tableName}";
                    //    cnn.Open();

                    //    //var t = new DataTable();
                    //    //t.Load(cmd.ExecuteReader());
                    //    //td.DataGrid.ApplyDataTale(t);

                       
                        
                    //}

                    
                }
                else if(args.TabPage.Name == "IndexTab")
                {
                    var ix = _cnn.Schema.Tables["Indexes"];
                    var ixc = _cnn.Schema.Tables["IndexColumns"];

                    td.IndexGrid.ApplyDataTale(ix);
                }
            };

        }

        private void nativeTreeView1_Click(object sender, EventArgs e)
        {
            
            
        }


    }
}
