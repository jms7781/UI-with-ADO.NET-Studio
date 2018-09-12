namespace ADO.NET_Studio
{
    partial class ConnectionManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionManagerUI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewConnection = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.nativeListView1 = new UI.NativeListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewConnection,
            this.toolStripSeparator1,
            this.btnEdit,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnTest,
            this.toolStripSeparator4,
            this.btnOpen,
            this.toolStripSeparator5,
            this.btnCopy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnNewConnection.Image")));
            this.btnNewConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(35, 22);
            this.btnNewConnection.Text = "New";
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 22);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEditConnection_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnTest
            // 
            this.btnTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(32, 22);
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 22);
            this.btnOpen.Text = "Open";
            // 
            // nativeListView1
            // 
            this.nativeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.nativeListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nativeListView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nativeListView1.FullRowSelect = true;
            this.nativeListView1.Location = new System.Drawing.Point(0, 25);
            this.nativeListView1.Name = "nativeListView1";
            this.nativeListView1.Size = new System.Drawing.Size(887, 307);
            this.nativeListView1.TabIndex = 0;
            this.nativeListView1.UseCompatibleStateImageBehavior = false;
            this.nativeListView1.View = System.Windows.Forms.View.Details;
            this.nativeListView1.DoubleClick += new System.EventHandler(this.nativeListView1_DoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 217;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Provider";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Connection String";
            this.columnHeader3.Width = 431;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 22);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // ConnectionManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 332);
            this.Controls.Add(this.nativeListView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ConnectionManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Manager";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.NativeListView nativeListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewConnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnCopy;
    }
}