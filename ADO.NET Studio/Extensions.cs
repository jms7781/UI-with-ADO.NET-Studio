using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Text;


namespace ADO.NET_Studio
{
    public static class Extensions
    {
        public static string ToAnsiSql(string tableName, IEnumerable<Column> columns)
        {
            var sb = new StringBuilder($"create table {tableName} (\n");

            var cols = new List<string>();

            foreach (var column in columns)
            {
                if (column.Type.Contains("char") || column.Type.Contains("binary"))
                {
                    //CustomerName varchar(max)
                    var len = column.Length == "-1" ? "max" : column.Length;
                    var c = $"{column.Name} {column.Type}({len}) {column.Nullable}";
                    cols.Add(c);
                }
                else if (column.Type.Contains("decimal"))
                {
                    //CustomerID decimal(10,4)
                    var c = $"{column.Name} + {column.Type}({column.Precision})";
                    cols.Add(c);
                }
                else
                {
                    //CustomerID int
                    var c = $"{column.Name} + {column.Type}";
                    cols.Add(c);
                }
            }

            sb.AppendLine(string.Join(",\n", cols.ToArray()));
            sb.AppendLine(")");
            return sb.ToString();
        }

        public static bool Contains(this string haystack, string needle) => haystack.IndexOf(needle, StringComparison.InvariantCultureIgnoreCase) >= 0;
    }

    public class Column
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Nullable { get; set; }
        public string Precision { get; set; }
        public int Position { get; set; }
        public string Length { get; set; }


    }
}
