using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace UI
{
    public static class Extensions
    {
        public static void SetDoubleBuffered(this Control c)
        {
            if (SystemInformation.TerminalServerSession) return;

            PropertyInfo propInfo = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            propInfo.SetValue(c, true, null);
        }

        public static void SafeUpdateUI(this Control control, Action code)
        {
            if (control.InvokeRequired)
            {
                control.BeginInvoke(code);
            }
            else
            {
                code.Invoke();
            }
        }

        public static void CreateTabPageForm(this TabControl tab, Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Visible = true;
            f.Dock = DockStyle.Fill;

            tab.TabPages.Add(f.Text);
            tab.TabPages[tab.TabPages.Count - 1].Controls.Add(f);
        }

        public static IEnumerable<ListViewItem> ToListViewItem(this DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row.IsNull(0) ? "" : row[0].ToString());

                for (int i = 1; i < table.Columns.Count; i++)
                {
                    item.SubItems.Add(row.IsNull(i) ? "" : row[i].ToString());
                }

                yield return item;
            }
        }

        public static IEnumerable<ListViewItem> Filter(this IEnumerable<ListViewItem> source, string searchTerm)
        {
            ListViewItem.ListViewSubItem x = source.First().SubItems[0];

            foreach (var item in source)
            {
                if (item.Text.Contains(searchTerm) || item.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(s => s.Text.Contains(searchTerm)))
                    yield return item;
            }
        }

        public static IEnumerable<ColumnHeader> ToColumnHeader(this DataTable table)
        {
            foreach (DataColumn col in table.Columns)
            {
                yield return new ColumnHeader() { Text = col.ColumnName };
            }
        }

        public static Form DataGridForm(this DataTable table)
        {
            var f = new Form();
            f.Font = SystemFonts.MessageBoxFont;
            var grid = new DataGridView();
            grid.DataSource = table;
            grid.Dock = DockStyle.Fill;
            grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grid.RowHeadersVisible = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;

            f.Controls.Add(grid);
            return f;
        }

        /// <summary>
        /// Resizes the column widths on the datagrid based on the number of cells. Only the displayed cells will resize if the number of cells exceeds 1000
        /// </summary>
        /// <param name="grid"></param>
        public static void AutoSizeSmart(this DataGridView grid)
        {
            var cellCount = grid.ColumnCount * grid.RowCount;

            if (cellCount > 1000)
            {
                grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
            else
            {
                grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

        }
    }
}
