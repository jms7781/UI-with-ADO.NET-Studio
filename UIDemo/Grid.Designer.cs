﻿namespace UIDemo
{
    partial class Grid
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
            this.searchDataGrid1 = new UI.SearchDataGrid();
            this.SuspendLayout();
            // 
            // searchDataGrid1
            // 
            this.searchDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchDataGrid1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.searchDataGrid1.Name = "searchDataGrid1";
            this.searchDataGrid1.Size = new System.Drawing.Size(764, 419);
            this.searchDataGrid1.TabIndex = 0;
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 419);
            this.Controls.Add(this.searchDataGrid1);
            this.Name = "Grid";
            this.Text = "Grid";
            this.ResumeLayout(false);

        }

        #endregion

        public UI.SearchDataGrid searchDataGrid1;
    }
}