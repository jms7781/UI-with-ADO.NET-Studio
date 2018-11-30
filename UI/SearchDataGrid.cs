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

        private IDbDataAdapter adapter;
        private DataSet adapterDataSet;



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
            bs.DataSource = table;
            DataGrid.DataSource = bs;
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            this.toolStripLabel1.Text = $"{DataGrid.Rows.Count} rows";
        }

        public void ApplyDataAdapter(IDbDataAdapter data)
        {
            adapter = data;
            adapterDataSet = new DataSet();

            RefreshDataAdapter();
        }

        private void RefreshDataAdapter()
        {
            if (adapter == null) return;

            this.adapter.FillSchema(adapterDataSet, SchemaType.Source);
            this.adapter.Fill(adapterDataSet);

            bs.DataSource = adapterDataSet.Tables[0];
            DataGrid.DataSource = bs;
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            this.toolStripLabel1.Text = $"{DataGrid.Rows.Count} rows";
        }

        string complexFilterString;
        public string ComplexFilterString
        {
            get
            {
                return complexFilterString;
            }
            set
            {
                var sql = value?.Trim();

                if (sql == complexFilterString)
                    return;

                complexFilterString = value;

                ApplyFilter();
            }
        }


        string sortCriteria;
        public string SortCriteria
        {
            get
            {
                return sortCriteria;
            }

            set
            {
                if (value == sortCriteria)
                    return;

                sortCriteria = value;

                ApplySort();
            }


        }

        private BindingSource bs = new BindingSource();

        private string GetQuickFilterString()
        {
            if (SearchText.Text == "Search...")
                return "";

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
                //else if (
                //    col.ValueType == typeof(int) || 
                //    col.ValueType == typeof(decimal) || 
                //    col.ValueType == typeof(float) ||
                //    col.ValueType == typeof(double) || 
                //    col.ValueType == typeof(long) ||
                //    col.ValueType == typeof(short) ||
                //    col.ValueType == typeof(uint) ||
                //    col.ValueType == typeof(ulong) ||
                //    col.ValueType == typeof(ushort) ||
                //    col.ValueType == typeof(DateTimeOffset) ||
                //    col.ValueType == typeof(DateTime)
                //)
                //{
                //    //switch (FilterOption.SelectedItem.ToString().ToLowerInvariant())
                //    //{
                //    //    case "starts with":
                //    //        //criteria.Add($"[{col.DataPropertyName}] LIKE '{search}%'");
                //    //        criteria.Add($"convert({col.DataPropertyName}, 'System.String') LIKE '{search}%'");
                //    //        break;
                //    //    case "ends with":
                //    //        //criteria.Add($"[{col.DataPropertyName}] LIKE '%{search}'");
                //    //        criteria.Add($"convert({col.DataPropertyName}, 'System.String') LIKE '%{search}'");

                //    //        break;
                //    //    case "contains":
                //    //        //criteria.Add($"[{col.DataPropertyName}] LIKE '%{search}%'");
                //    //        criteria.Add($"convert({col.DataPropertyName}, 'System.String') LIKE '%{search}%'");
                //    //        break;
                //    //    case "equals":
                //    //        //criteria.Add($"[{col.DataPropertyName}] = '{search}'");
                //    //        criteria.Add($"convert({col.DataPropertyName}, 'System.String') = {search}");
                //    //        break;
                //    //}
                //}
                else
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
            }

            return string.Join(" OR ", criteria.ToArray());
        }

        private string GetFilterString()
        {
            var simple = GetQuickFilterString();
            var complex = this.ComplexFilterString;

            bool hasSimple = !string.IsNullOrEmpty(simple);
            bool hasComplex = !string.IsNullOrEmpty(complex);

            if (hasSimple && hasComplex)
            {
                return $"({simple}) AND ({complex})";
            }

            if (hasSimple)
            {
                return simple;
            }

            if (hasComplex)
            {
                return complex;
            }

            return "";
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        public void ApplyFilter()
        {
            var filter = GetFilterString();

            if (string.IsNullOrEmpty(filter))
            {
                bs.RemoveFilter();
                toolStripLabel1.Text = $"{DataGrid.Rows.Count} rows";
                return;
            }

            bs.Filter = filter;
            toolStripLabel1.Text = $"{ DataGrid.Rows.Count} rows (filtered)";
        }

        public void ApplySort()
        {
            bs.Sort = sortCriteria;
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
            ApplyFilter();
        }

        private void DataGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                adapter.Update(adapterDataSet);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataAdapter();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var f = new SearchDataGridDialog(this)
            {
                Text = "Filter",
                StartPosition = FormStartPosition.CenterScreen
            };

            f.DialogText.Text = ComplexFilterString;
            f.Action = (s) => s.ComplexFilterString = f.DialogText.Text;
            
            f.Show(this);
        }

        private void LaunchForm(string title, string content, Action<SearchDataGrid> action)
        {
            var f = new SearchDataGridDialog(this)
            {
                Text = title,
            };

            f.DialogText.Text = content;
            f.Action = action;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show(this);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var f = new SearchDataGridDialog(this)
            {
                Text = "Sort",
                StartPosition = FormStartPosition.CenterScreen
            };

            f.DialogText.Text = SortCriteria;
            f.Action = (s) => s.SortCriteria = f.DialogText.Text;

            f.Show(this);
        }

        private void columnHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
        }

        private void allCellsExceptHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void allCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void displayedCellsExceptHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader);
        }

        private void displayedCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.None);
        }
    }
}