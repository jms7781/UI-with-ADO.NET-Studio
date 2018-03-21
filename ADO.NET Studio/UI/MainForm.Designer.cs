using UI;

namespace ADO.NET_Studio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewConnection = new System.Windows.Forms.ToolStripButton();
            this.ConnectionTree = new UI.NativeTreeView();
            this.MdiTab = new MdiTabControl.TabControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewConnection});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1161, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnNewConnection.Image")));
            this.btnNewConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(109, 22);
            this.btnNewConnection.Text = "New Connection...";
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // ConnectionTree
            // 
            this.ConnectionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionTree.Location = new System.Drawing.Point(0, 0);
            this.ConnectionTree.Name = "ConnectionTree";
            this.ConnectionTree.Size = new System.Drawing.Size(387, 572);
            this.ConnectionTree.TabIndex = 0;
            // 
            // MdiTab
            // 
            this.MdiTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MdiTab.Location = new System.Drawing.Point(0, 25);
            this.MdiTab.MenuRenderer = null;
            this.MdiTab.Name = "MdiTab";
            this.MdiTab.Size = new System.Drawing.Size(1161, 594);
            this.MdiTab.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.MdiTab.TabBorderEnhanced = true;
            this.MdiTab.TabCloseButtonImage = null;
            this.MdiTab.TabCloseButtonImageDisabled = null;
            this.MdiTab.TabCloseButtonImageHot = null;
            this.MdiTab.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(132, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(130, 62);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 619);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MdiTab);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADO.NET Studio";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private NativeTreeView ConnectionTree;
        public MdiTabControl.TabControl MdiTab;
        public System.Windows.Forms.ToolStripButton btnNewConnection;
        public System.Windows.Forms.TabControl tabControl1;
    }
}

