using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SearchDataGridDialog : Form
    {
        public SearchDataGridDialog()
        {
            InitializeComponent();
        }

        private SearchDataGrid f;
        //private Action<SearchDataGrid> Action;


        public Action<SearchDataGrid> Action { get; set; }

        public SearchDataGridDialog(SearchDataGrid parent) : this()
        {
            f = parent;

            //Action = (s) => s.ComplexFilterString = DialogText.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (f != null)
            {
                Action(f);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (f != null)
            {
                DialogText.Clear();
                Action(f);
            }
        }
    }
}
