using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace UI
{
    
    public partial class SearchListView : UserControl
    {
        public SearchListView()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            this.ListView.ApplyDataSourceFilter(SearchBox.Text);
        }

        public void ApplyDataSource(DataTable table)
        {
            this.ListView.ApplyDataSource(table);
        }

    }


}
