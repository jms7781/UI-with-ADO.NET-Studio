namespace Export_Admin
{
    partial class Form1
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
            this.searchListView1 = new UI.SearchListView();
            this.SuspendLayout();
            // 
            // searchListView1
            // 
            this.searchListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchListView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchListView1.Location = new System.Drawing.Point(0, 0);
            this.searchListView1.Name = "searchListView1";
            this.searchListView1.Size = new System.Drawing.Size(850, 442);
            this.searchListView1.TabIndex = 0;
            this.searchListView1.Load += new System.EventHandler(this.searchListView1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 442);
            this.Controls.Add(this.searchListView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.SearchListView searchListView1;
    }
}

