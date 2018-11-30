using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SSIS
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            cboServer.Text = @"xps13\sqlexpress";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var cnn = new SqlConnection(GetConnection()))
            using (var cmd = cnn.CreateCommand())
            {
                try
                {
                    cnn.Open();
                    cmd.CommandText = sql();
                    var t = new DataTable();
                    t.Load(cmd.ExecuteReader());

                    searchDataGrid1.ApplyDataTale(t);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetConnection()
        {
            return new SqlConnectionStringBuilder()
            {
                DataSource = cboServer.SelectedItem.ToString(),
                IntegratedSecurity = true,
                InitialCatalog = "SSISDB"
            }.ToString();

        }

        private string sql()
        {
            return @"SELECT e.executable_id AS [ID]	, CASE es.execution_result		when 0 then 'Success'		when 1 then 'Failure'		when 2 then 'Completion'		when 3 then 'Cancelled'	  END AS [Status]	, ex.folder_name AS [FolderName]	, ex.project_name AS [ProjectName]	, e.package_name AS [PackageName]	, CONVERT(datetime, es.start_time) AS [StartTime]	, CONVERT(datetime, es.end_time) AS [EndTime]	, CAST(es.execution_duration AS float)/1000 AS [Duration]FROM catalog.executables e INNER JOIN catalog.executable_statistics es	ON e.executable_id = es.executable_id		AND e.execution_id = es.execution_id INNER JOIN catalog.executions ex	ON e.execution_id = ex.execution_id 		AND es.execution_id = ex.execution_id WHERE package_path = '\Package' ORDER BY StartTime DESC";
        }
    }
}
