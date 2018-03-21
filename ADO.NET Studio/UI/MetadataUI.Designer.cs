using UI;

namespace ADO.NET_Studio
{
    partial class MetadataUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwMetadata = new UI.NativeListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchDataGrid1 = new UI.SearchDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwMetadata);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.searchDataGrid1);
            this.splitContainer2.Size = new System.Drawing.Size(986, 476);
            this.splitContainer2.SplitterDistance = 226;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwMetadata
            // 
            this.lvwMetadata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvwMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMetadata.FullRowSelect = true;
            this.lvwMetadata.Location = new System.Drawing.Point(0, 0);
            this.lvwMetadata.Name = "lvwMetadata";
            this.lvwMetadata.Size = new System.Drawing.Size(226, 476);
            this.lvwMetadata.TabIndex = 0;
            this.lvwMetadata.UseCompatibleStateImageBehavior = false;
            this.lvwMetadata.View = System.Windows.Forms.View.Details;
            this.lvwMetadata.SelectedIndexChanged += new System.EventHandler(this.lvwMetadata_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Metadata";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Items";
            // 
            // searchDataGrid1
            // 
            this.searchDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDataGrid1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.searchDataGrid1.Name = "searchDataGrid1";
            this.searchDataGrid1.Size = new System.Drawing.Size(756, 476);
            this.searchDataGrid1.TabIndex = 0;
            // 
            // MetadataUI
            // 
            this.ClientSize = new System.Drawing.Size(986, 476);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MetadataUI";
            this.Text = "Metadata";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private NativeListView lvwMetadata;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private SearchDataGrid searchDataGrid1;
    }
}