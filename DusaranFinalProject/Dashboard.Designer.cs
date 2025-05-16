namespace DusaranFinalProject
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterFileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterFilesToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barrowsToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // barrowsToolStripMenuItem
            // 
            this.barrowsToolStripMenuItem.Name = "barrowsToolStripMenuItem";
            this.barrowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barrowsToolStripMenuItem.Text = "Transaction History";
            this.barrowsToolStripMenuItem.Click += new System.EventHandler(this.barrowsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrowReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // borrowReportToolStripMenuItem
            // 
            this.borrowReportToolStripMenuItem.Name = "borrowReportToolStripMenuItem";
            this.borrowReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.borrowReportToolStripMenuItem.Text = "Report";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // masterFilesToolStripMenuItem
            // 
            this.masterFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterFileManagerToolStripMenuItem});
            this.masterFilesToolStripMenuItem.Name = "masterFilesToolStripMenuItem";
            this.masterFilesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.masterFilesToolStripMenuItem.Text = "Master Files";
            // 
            // masterFileManagerToolStripMenuItem
            // 
            this.masterFileManagerToolStripMenuItem.Name = "masterFileManagerToolStripMenuItem";
            this.masterFileManagerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.masterFileManagerToolStripMenuItem.Text = "Master File Manager";
            this.masterFileManagerToolStripMenuItem.Click += new System.EventHandler(this.masterFileManagerToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterFileManagerToolStripMenuItem;
    }
}