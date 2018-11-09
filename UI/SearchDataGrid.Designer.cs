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
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchText = new System.Windows.Forms.ToolStripTextBox();
            this.FilterOption = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
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
            this.btnRefresh,
            this.btnSave,
            this.btnFilter,
            this.btnSort,
            this.toolStripSeparator3,
            this.SearchText,
            this.FilterOption,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(542, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(37, 22);
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSort
            // 
            this.btnSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(32, 22);
            this.btnSort.Text = "Sort";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 25);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(542, 40);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGrid_DataError);
            // 
            // SearchDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SearchDataGrid";
            this.Size = new System.Drawing.Size(542, 65);
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
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton btnSort;
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
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
