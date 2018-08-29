namespace UI
{
    partial class SearchDataGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDataGrid));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SearchText = new System.Windows.Forms.ToolStripTextBox();
            this.FilterOption = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.columnHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCellsExceptHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayedCellsExceptHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayedCellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchText,
            this.FilterOption,
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(358, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SearchText
            // 
            this.SearchText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(185, 25);
            this.SearchText.Text = "Search...";
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // FilterOption
            // 
            this.FilterOption.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.FilterOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterOption.Items.AddRange(new object[] {
            "Starts With",
            "Contains",
            "Ends With",
            "Equals"});
            this.FilterOption.Name = "FilterOption";
            this.FilterOption.Size = new System.Drawing.Size(80, 25);
            this.FilterOption.SelectedIndexChanged += new System.EventHandler(this.FilterOption_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel1.Text = "{0} rows";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 19);
            this.toolStripButton1.Text = "Add Criteria...";
            this.toolStripButton1.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 19);
            this.toolStripButton2.Text = "Add Sort...";
            this.toolStripButton2.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnHeaderToolStripMenuItem,
            this.allCellsExceptHeaderToolStripMenuItem,
            this.allCellsToolStripMenuItem,
            this.displayedCellsExceptHeaderToolStripMenuItem,
            this.displayedCellsToolStripMenuItem,
            this.fillToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(103, 19);
            this.toolStripDropDownButton1.Text = "Resize Columns";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // columnHeaderToolStripMenuItem
            // 
            this.columnHeaderToolStripMenuItem.Name = "columnHeaderToolStripMenuItem";
            this.columnHeaderToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.columnHeaderToolStripMenuItem.Text = "Column Header";
            // 
            // allCellsExceptHeaderToolStripMenuItem
            // 
            this.allCellsExceptHeaderToolStripMenuItem.Name = "allCellsExceptHeaderToolStripMenuItem";
            this.allCellsExceptHeaderToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.allCellsExceptHeaderToolStripMenuItem.Text = "All Cells Except Header";
            // 
            // allCellsToolStripMenuItem
            // 
            this.allCellsToolStripMenuItem.Name = "allCellsToolStripMenuItem";
            this.allCellsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.allCellsToolStripMenuItem.Text = "All Cells";
            // 
            // displayedCellsExceptHeaderToolStripMenuItem
            // 
            this.displayedCellsExceptHeaderToolStripMenuItem.Name = "displayedCellsExceptHeaderToolStripMenuItem";
            this.displayedCellsExceptHeaderToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.displayedCellsExceptHeaderToolStripMenuItem.Text = "Displayed Cells Except Header";
            // 
            // displayedCellsToolStripMenuItem
            // 
            this.displayedCellsToolStripMenuItem.Name = "displayedCellsToolStripMenuItem";
            this.displayedCellsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.displayedCellsToolStripMenuItem.Text = "Displayed Cells";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.fillToolStripMenuItem.Text = "Fill";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.noneToolStripMenuItem.Text = "None";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 25);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(358, 40);
            this.DataGrid.TabIndex = 1;
            // 
            // SearchDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SearchDataGrid";
            this.Size = new System.Drawing.Size(358, 65);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripTextBox SearchText;
        private System.Windows.Forms.ToolStripComboBox FilterOption;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem columnHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCellsExceptHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayedCellsExceptHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayedCellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.DataGridView DataGrid;
    }
}
