namespace UI
{
    partial class ListCompareUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCompareUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LeftCompare = new System.Windows.Forms.TextBox();
            this.RightCompare = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Result = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.ToolStripButton();
            this.btnSplitCompare = new System.Windows.Forms.ToolStripSplitButton();
            this.inBothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.LeftCompare, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RightCompare, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Result, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LeftCompare
            // 
            this.LeftCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftCompare.Location = new System.Drawing.Point(3, 3);
            this.LeftCompare.Multiline = true;
            this.LeftCompare.Name = "LeftCompare";
            this.LeftCompare.Size = new System.Drawing.Size(258, 419);
            this.LeftCompare.TabIndex = 0;
            // 
            // RightCompare
            // 
            this.RightCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightCompare.Location = new System.Drawing.Point(267, 3);
            this.RightCompare.Multiline = true;
            this.RightCompare.Name = "RightCompare";
            this.RightCompare.Size = new System.Drawing.Size(258, 419);
            this.RightCompare.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCompare,
            this.btnSplitCompare});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Result
            // 
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.Location = new System.Drawing.Point(531, 3);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(266, 419);
            this.Result.TabIndex = 2;
            // 
            // btnCompare
            // 
            this.btnCompare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCompare.Image = ((System.Drawing.Image)(resources.GetObject("btnCompare.Image")));
            this.btnCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(60, 22);
            this.btnCompare.Text = "Compare";
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSplitCompare
            // 
            this.btnSplitCompare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSplitCompare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inBothToolStripMenuItem,
            this.leftOnlyToolStripMenuItem,
            this.rightOnlyToolStripMenuItem,
            this.uniqueToolStripMenuItem});
            this.btnSplitCompare.Image = ((System.Drawing.Image)(resources.GetObject("btnSplitCompare.Image")));
            this.btnSplitCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSplitCompare.Name = "btnSplitCompare";
            this.btnSplitCompare.Size = new System.Drawing.Size(72, 22);
            this.btnSplitCompare.Text = "Compare";
            // 
            // inBothToolStripMenuItem
            // 
            this.inBothToolStripMenuItem.Name = "inBothToolStripMenuItem";
            this.inBothToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inBothToolStripMenuItem.Text = "In Both";
            // 
            // leftOnlyToolStripMenuItem
            // 
            this.leftOnlyToolStripMenuItem.Name = "leftOnlyToolStripMenuItem";
            this.leftOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leftOnlyToolStripMenuItem.Text = "Left Only";
            // 
            // rightOnlyToolStripMenuItem
            // 
            this.rightOnlyToolStripMenuItem.Name = "rightOnlyToolStripMenuItem";
            this.rightOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rightOnlyToolStripMenuItem.Text = "Right Only";
            // 
            // uniqueToolStripMenuItem
            // 
            this.uniqueToolStripMenuItem.Name = "uniqueToolStripMenuItem";
            this.uniqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uniqueToolStripMenuItem.Text = "Unique";
            // 
            // ListCompareUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListCompareUI";
            this.Text = "List Compare";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox LeftCompare;
        private System.Windows.Forms.TextBox RightCompare;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCompare;
        private System.Windows.Forms.ToolStripSplitButton btnSplitCompare;
        private System.Windows.Forms.ToolStripMenuItem inBothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniqueToolStripMenuItem;
    }
}