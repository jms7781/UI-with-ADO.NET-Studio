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
    public partial class SchemaUI : Form
    {
        public SchemaUI()
        {
            this.Font = SystemFonts.MessageBoxFont;

            InitializeComponent();

            this.dataGridView1.SetDoubleBuffered();
        }

        public SchemaUI(MainForm f) : this()
        {
            _mdi = f;
        }

        private MainForm _mdi;

        public SchemaUI(ConnectionDetail connectionDetail) : this()
        {
            _cnn = connectionDetail;
            RefreshSchema();
        }

        private ConnectionDetail _cnn;

        public void RefreshSchema()
        {
            var schemas = _cnn.DataConnection.GetSchema().AsEnumerable().Select(r => r[0].ToString());

            foreach (var schema in schemas)
            {
                var item = new ListViewItem(schema);
                var t = _cnn.DataConnection.GetSchema(schema);
                

                if (t.Rows.Count > 0)
                {
                    item.Tag = t;
                    item.SubItems.Add(t.Rows.Count.ToString());
                    lvwMetadata.Items.Add(item);
                }

                //lvwMetadata.Items.Add(new ListViewItem(schema) {Tag = _cnn.DataConnection.GetSchema(schema)});
            }
        }

        private void lvwMetadata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMetadata.SelectedItems.Count == 0) return;

            var t = lvwMetadata.SelectedItems[0].Tag;

            dataGridView1.DataSource = t;

            //lvwData.ApplyDataSource((DataTable)t);
        }
    }
}
