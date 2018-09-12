using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class SearchDataGrid : UserControl
    {
        private string searchCue;
        private ToolStripTextBox searchTextDefault;

        public SearchDataGrid()
        {
            this.Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.DataGrid.SetDoubleBuffered();

            searchCue = SearchText.Text;
            searchTextDefault = SearchText;

            cueFont = new Font(SearchText.Font.FontFamily, SearchText.Font.Size, FontStyle.Italic);
            textFont = new Font(SearchText.Font.FontFamily, SearchText.Font.Size, FontStyle.Regular);

            SearchText.ForeColor = SystemColors.ControlDarkDark;
            SearchText.Font = cueFont;

            FilterOption.SelectedIndex = 0;

            //bs.DataSourceChanged += (s, e) =>
            //{
            //    SearchText.Clear();
            //    bs.RemoveFilter();
            //};

            
        }

        public void ApplyDataTale(DataTable table)
        {
            bs = new BindingSource();

            bs.DataSource = table;
            DataGrid.DataSource = bs;
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            this.toolStripLabel1.Text = $"{DataGrid.Rows.Count} rows";
        }

        private BindingSource bs = new BindingSource();

        private string GetQuickFilterString()
        {
            var criteria = new List<string>();
            var cols = DataGrid.Columns.Cast<DataGridViewColumn>().Select(c => new { c.DataPropertyName, c.ValueType }).ToArray();
            var search = this.SearchText.Text;

            foreach (var col in cols)
            {
                if (col.ValueType == typeof(string))
                {
                    switch (FilterOption.SelectedItem.ToString().ToLowerInvariant())
                    {
                        case "starts with":
                            criteria.Add($"[{col.DataPropertyName}] LIKE '{search}%'");
                            break;
                        case "ends with":
                            criteria.Add($"[{col.DataPropertyName}] LIKE '%{search}'");
                            break;
                        case "contains":
                            criteria.Add($"[{col.DataPropertyName}] LIKE '%{search}%'");
                            break;
                        case "equals":
                            criteria.Add($"[{col.DataPropertyName}] = '{search}'");
                            break;
                    }
                    
                }
                else if (
                    col.ValueType == typeof(int) || 
                    col.ValueType == typeof(decimal) || 
                    col.ValueType == typeof(float) ||
                    col.ValueType == typeof(double) || 
                    col.ValueType == typeof(long) ||
                    col.ValueType == typeof(short) ||
                    col.ValueType == typeof(uint) ||
                    col.ValueType == typeof(ulong) ||
                    col.ValueType == typeof(ushort) ||
                    col.ValueType == typeof(DateTimeOffset) ||
                    col.ValueType == typeof(DateTime)
                )
                {
                    switch (FilterOption.SelectedItem.ToString().ToLowerInvariant())
                    {
                        case "starts with":
                            //criteria.Add($"[{col.DataPropertyName}] LIKE '{search}%'");
                            criteria.Add($"convert({col.DataPropertyName}, 'System.String') LIKE '{search}%'");
                            break;
                        case "ends with":
                            //criteria.Add($"[{col.DataPropertyName}] LIKE '%{search}'");
                            criteria.Add($"convert({col.DataPropertyName}, 'System.String') LIKE '%{search}'");

                            break;
                        case "contains":
                            //criteria.Add($"[{col.DataPropertyName}] LIKE '%{search}%'");
                            criteria.Add($"convert({col.DataPropertyName}, 'System.String') LIKE '%{search}%'");
                            break;
                        case "equals":
                            //criteria.Add($"[{col.DataPropertyName}] = '{search}'");
                            criteria.Add($"convert({col.DataPropertyName}, 'System.String') = {search}");
                            break;
                    }
                }
                else
                {
                    var x = col.ValueType;
                   
                }
            }

            return string.Join(" OR ", criteria.ToArray());
        }



        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            QuickFilter();
        }

        private void QuickFilter()
        {
            if (string.IsNullOrEmpty(SearchText.Text) || SearchText.Text == searchCue)
            {
                bs.RemoveFilter();
                toolStripLabel1.Text = $"{DataGrid.Rows.Count} rows";
                return;
            }

            bs.Filter = GetQuickFilterString();
            toolStripLabel1.Text = $"{ DataGrid.Rows.Count} rows (filtered)";
        }

        private void SearchText_Enter(object sender, EventArgs e)
        {
            ResetCue();   
        }

        private void SearchText_Leave(object sender, EventArgs e)
        {
            SetCue();
        }

        private void SetCue()
        {
            if (string.IsNullOrEmpty(SearchText.Text))
            {
                SearchText.ForeColor = SystemColors.ControlDarkDark;
                SearchText.Text = searchCue;
                SearchText.Font = cueFont;
            }
        }

        private void ResetCue()
        {
            if (SearchText.Text == searchCue)
            {
                SearchText.ForeColor = SystemColors.WindowText;
                SearchText.Text = "";
                SearchText.Font = textFont;
            }
        }

        private Font cueFont;
        private Font textFont;

        private void FilterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuickFilter();
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
