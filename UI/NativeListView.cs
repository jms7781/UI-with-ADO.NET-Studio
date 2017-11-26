using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data;
//using static System.Windows.Forms.ListViewItem;

namespace UI
{
    public class NativeListView : ListView, IComparer
    {
        public NativeListView()
        {
            this.DoubleBuffered = true;
            this.ListViewItemSorter = this;

            this.FullRowSelect = true;
            this.View = View.Details;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            NativeMethods.SetWindowTheme(this.Handle, "explorer", null);
        }

        public int Compare(object x, object y)
        {
            var item1 = (ListViewItem)x;
            var item2 = (ListViewItem)y;

            var text1 = item1.SubItems[this.sortColumn].Text;
            var text2 = item2.SubItems[this.sortColumn].Text;

            int compare;

            double num1, num2;
            bool intParsed = double.TryParse(text1, out num1) & double.TryParse(text2, out num2);

            if (intParsed)
            {
                compare = num1.CompareTo(num2);
            }
            else
            {
                DateTime d1, d2;
                bool dateParsed = DateTime.TryParse(text1, out d1) & DateTime.TryParse(text2, out d2);

                if (dateParsed)
                {
                    compare = d1.CompareTo(d2);
                }
                else
                {
                    compare = string.Compare(text1, text2, StringComparison.CurrentCultureIgnoreCase);
                }
            }
            return sortOrder == SortOrder.Descending ? -compare : compare;
        }

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                this.sortOrder = SortOrder.Ascending;
            }
            else {
                if (this.sortOrder == SortOrder.Ascending)
                    this.sortOrder = SortOrder.Descending;
                else
                    this.sortOrder = SortOrder.Ascending;
            }
            this.Sort();
        }

        protected int sortColumn = 0;
        protected SortOrder sortOrder = SortOrder.Ascending;
        protected List<ListViewItem> listViewItems = new List<ListViewItem>();

        public void ApplyDataSource(DataTable table)
        {
            listViewItems.Clear();

            foreach (DataColumn col in table.Columns)
            {
                var c = new ColumnHeader()
                {
                    Text = col.ColumnName,
                    Width = -2
                };
                Columns.Add(c);
            }

            foreach (DataRow row in table.Rows)
            {
                var item = new ListViewItem(row.IsNull(0) ? "" : row[0].ToString());

                for (int i = 1; i < table.Columns.Count; i++)
                {
                    item.SubItems.Add(row.IsNull(i) ? "" : row[i].ToString());
                }

                listViewItems.Add(item);
            }

            ApplyDataSourceFilter(null);
        }

        public void ApplyDataSource(IEnumerable<string[]> rows)
        {
            listViewItems.Clear();

            foreach (var row in rows)
            {
                listViewItems.Add(new ListViewItem(row));                
            }

            ApplyDataSourceFilter(null);
        }

        public void ApplyDataSourceFilter(string filter)
        {
            if (string.IsNullOrEmpty(filter) || string.IsNullOrWhiteSpace(filter))
            {
                Items.Clear();
                Items.AddRange(listViewItems.ToArray());
                return;
            }

            var term = filter.ToUpperInvariant();

            var results = listViewItems.Where(f => f.Text.ToUpperInvariant().Contains(term) || f.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(s => s.Text.ToUpperInvariant().Contains(term)));
            Items.Clear();
            Items.AddRange(results.ToArray());
        }

        public void ApplyDataSourceFilter(string filter, Func<ListViewItem, bool> predicate)
        {
            if (string.IsNullOrEmpty(filter) || string.IsNullOrWhiteSpace(filter))
            {
                Items.Clear();
                Items.AddRange(listViewItems.ToArray());
                return;
            }

            var term = filter.ToUpperInvariant();

            //var results = listViewItems.Where(f => f.Text.ToUpperInvariant().Contains(term) || f.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(s => s.Text.ToUpperInvariant().Contains(term)));
            Items.Clear();
            Items.AddRange(listViewItems.Where(predicate).ToArray());
        }
    }
}
