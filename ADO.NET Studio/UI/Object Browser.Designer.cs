namespace ADO.NET_Studio
{
    partial class ObjectBrowserUI
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TableName");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tables", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ViewName1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Views", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nativeTreeView1 = new UI.NativeTreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nativeTreeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 596);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 0;
            // 
            // nativeTreeView1
            // 
            this.nativeTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nativeTreeView1.Location = new System.Drawing.Point(0, 0);
            this.nativeTreeView1.Name = "nativeTreeView1";
            treeNode1.Name = "nodeableName";
            treeNode1.Text = "TableName";
            treeNode2.Name = "nodeTables";
            treeNode2.Text = "Tables";
            treeNode3.Name = "Node3";
            treeNode3.Text = "ViewName1";
            treeNode4.Name = "nodeViews";
            treeNode4.Text = "Views";
            this.nativeTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            this.nativeTreeView1.ShowLines = false;
            this.nativeTreeView1.Size = new System.Drawing.Size(206, 596);
            this.nativeTreeView1.TabIndex = 0;
            this.nativeTreeView1.Click += new System.EventHandler(this.nativeTreeView1_Click);
            this.nativeTreeView1.DoubleClick += new System.EventHandler(this.nativeTreeView1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // ObjectBrowserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 596);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ObjectBrowserUI";
            this.Text = "Object Browser";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UI.NativeTreeView nativeTreeView1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}