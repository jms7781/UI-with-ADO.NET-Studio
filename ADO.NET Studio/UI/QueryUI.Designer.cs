namespace ADO.NET_Studio
{
    partial class QueryUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryUI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExecute = new System.Windows.Forms.ToolStripButton();
            this.btnToggleResults = new System.Windows.Forms.ToolStripButton();
            this.btnToggleQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.QueryText = new System.Windows.Forms.RichTextBox();
            this.ResultsGrid = new UI.SearchDataGrid();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExecute,
            this.btnToggleResults,
            this.btnToggleQuery,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExecute
            // 
            this.btnExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnExecute.Image")));
            this.btnExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(74, 22);
            this.btnExecute.Text = "Execute (F5)";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnToggleResults
            // 
            this.btnToggleResults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToggleResults.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleResults.Image")));
            this.btnToggleResults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToggleResults.Name = "btnToggleResults";
            this.btnToggleResults.Size = new System.Drawing.Size(138, 22);
            this.btnToggleResults.Text = "Toggle Results (Ctrl + R)";
            this.btnToggleResults.ToolTipText = "Shows or hides the results of the query";
            this.btnToggleResults.Click += new System.EventHandler(this.btnToggleResults_Click);
            // 
            // btnToggleQuery
            // 
            this.btnToggleQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToggleQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleQuery.Image")));
            this.btnToggleQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToggleQuery.Name = "btnToggleQuery";
            this.btnToggleQuery.Size = new System.Drawing.Size(135, 22);
            this.btnToggleQuery.Text = "Toggle Query (Ctrl + Q)";
            this.btnToggleQuery.ToolTipText = "Shows or hides the query window";
            this.btnToggleQuery.Click += new System.EventHandler(this.btnToggleQuery_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(167, 22);
            this.toolStripLabel1.Text = "Query results or error message";
            this.toolStripLabel1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QueryText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResultsGrid);
            this.splitContainer1.Size = new System.Drawing.Size(905, 568);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 1;
            // 
            // QueryText
            // 
            this.QueryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueryText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryText.Location = new System.Drawing.Point(0, 0);
            this.QueryText.Name = "QueryText";
            this.QueryText.Size = new System.Drawing.Size(905, 145);
            this.QueryText.TabIndex = 0;
            this.QueryText.Text = "";
            // 
            // ResultsGrid
            // 
            this.ResultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultsGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResultsGrid.Location = new System.Drawing.Point(0, 0);
            this.ResultsGrid.Name = "ResultsGrid";
            this.ResultsGrid.Size = new System.Drawing.Size(905, 419);
            this.ResultsGrid.TabIndex = 0;
            // 
            // QueryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 593);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QueryUI";
            this.Text = "QueryUI";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExecute;
        private System.Windows.Forms.ToolStripButton btnToggleResults;
        private System.Windows.Forms.ToolStripButton btnToggleQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.RichTextBox QueryText;
        public UI.SearchDataGrid ResultsGrid;
    }
}