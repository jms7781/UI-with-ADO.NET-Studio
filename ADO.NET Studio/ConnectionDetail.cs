using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_Studio
{
    public class ConnectionDetail
    {
        public ConnectionDetail() {}

        public ConnectionDetail(string provider, string connectionString)
        {
            Provider = provider;
            ConnectionString = connectionString;
            DataConnection = new DataConnection(provider, connectionString);
        }

        public string Provider { get; set; }
        public string ConnectionString { get; set; }
        public DataConnection DataConnection { get; set; }

        private DataSet ds;
        public DataSet Schema
        {
            get
            {
                if (ds == null)
                {
                    var schemas = DataConnection.GetSchema().AsEnumerable().Select(r => r[0].ToString());
                    ds = new DataSet("Schema");

                    foreach (var schema in schemas)
                    {
                        var t = DataConnection.GetSchema(schema);
                        ds.Tables.Add(t);
                    }
                }
                return ds;
            }
        }

        public DataTable Tables
        {
            get { return Schema.Tables["Tables"]; }
        }

        public DataTable Views
        {
            get { return Schema.Tables["Views"]; }
        }

        public DataTable Columns
        {
            get { return Schema.Tables["Columns"]; }
        }

        public DataTable DataTypes
        {
            get { return Schema.Tables["DataTypes"]; }
        }
    }
}
