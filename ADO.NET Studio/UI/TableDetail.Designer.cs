namespace ADO.NET_Studio
{
    partial class TableDetailUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ColumnTab = new System.Windows.Forms.TabPage();
            this.ColumnGrid = new UI.SearchDataGrid();
            this.DataTab = new System.Windows.Forms.TabPage();
            this.DataGrid = new UI.SearchDataGrid();
            this.IndexTab = new System.Windows.Forms.TabPage();
            this.IndexGrid = new UI.SearchDataGrid();
            this.tabControl1.SuspendLayout();
            this.ColumnTab.SuspendLayout();
            this.DataTab.SuspendLayout();
            this.IndexTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ColumnTab);
            this.tabControl1.Controls.Add(this.DataTab);
            this.tabControl1.Controls.Add(this.IndexTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 384);
            this.tabControl1.TabIndex = 0;
            // 
            // ColumnTab
            // 
            this.ColumnTab.Controls.Add(this.ColumnGrid);
            this.ColumnTab.Location = new System.Drawing.Point(4, 24);
            this.ColumnTab.Name = "ColumnTab";
            this.ColumnTab.Padding = new System.Windows.Forms.Padding(3);
            this.ColumnTab.Size = new System.Drawing.Size(750, 356);
            this.ColumnTab.TabIndex = 0;
            this.ColumnTab.Text = "Columns";
            this.ColumnTab.UseVisualStyleBackColor = true;
            // 
            // ColumnGrid
            // 
            this.ColumnGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ColumnGrid.Location = new System.Drawing.Point(3, 3);
            this.ColumnGrid.Name = "ColumnGrid";
            this.ColumnGrid.Size = new System.Drawing.Size(744, 350);
            this.ColumnGrid.TabIndex = 0;
            // 
            // DataTab
            // 
            this.DataTab.Controls.Add(this.DataGrid);
            this.DataTab.Location = new System.Drawing.Point(4, 24);
            this.DataTab.Name = "DataTab";
            this.DataTab.Padding = new System.Windows.Forms.Padding(3);
            this.DataTab.Size = new System.Drawing.Size(750, 356);
            this.DataTab.TabIndex = 1;
            this.DataTab.Text = "Data";
            this.DataTab.UseVisualStyleBackColor = true;
            // 
            // DataGrid
            // 
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGrid.Location = new System.Drawing.Point(3, 3);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(744, 350);
            this.DataGrid.TabIndex = 0;
            // 
            // IndexTab
            // 
            this.IndexTab.Controls.Add(this.IndexGrid);
            this.IndexTab.Location = new System.Drawing.Point(4, 24);
            this.IndexTab.Name = "IndexTab";
            this.IndexTab.Padding = new System.Windows.Forms.Padding(3);
            this.IndexTab.Size = new System.Drawing.Size(750, 356);
            this.IndexTab.TabIndex = 2;
            this.IndexTab.Text = "Indexes";
            this.IndexTab.UseVisualStyleBackColor = true;
            // 
            // IndexGrid
            // 
            this.IndexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndexGrid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IndexGrid.Location = new System.Drawing.Point(3, 3);
            this.IndexGrid.Name = "IndexGrid";
            this.IndexGrid.Size = new System.Drawing.Size(744, 350);
            this.IndexGrid.TabIndex = 0;
            // 
            // TableDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 384);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TableDetailUI";
            this.Text = "Table Detail";
            this.tabControl1.ResumeLayout(false);
            this.ColumnTab.ResumeLayout(false);
            this.DataTab.ResumeLayout(false);
            this.IndexTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public UI.SearchDataGrid ColumnGrid;
        public UI.SearchDataGrid DataGrid;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage ColumnTab;
        public System.Windows.Forms.TabPage DataTab;
        public System.Windows.Forms.TabPage IndexTab;
        public UI.SearchDataGrid IndexGrid;
    }
}