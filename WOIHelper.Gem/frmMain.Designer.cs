namespace WOIHelper
{
    partial class frmMain
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStardusts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStardustCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.gemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGemCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuStardusts,
            this.gemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(152, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuStardusts
            // 
            this.mnuStardusts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStardustCalculator});
            this.mnuStardusts.Name = "mnuStardusts";
            this.mnuStardusts.Size = new System.Drawing.Size(67, 20);
            this.mnuStardusts.Text = "Stardusts";
            // 
            // mnuStardustCalculator
            // 
            this.mnuStardustCalculator.Name = "mnuStardustCalculator";
            this.mnuStardustCalculator.Size = new System.Drawing.Size(152, 22);
            this.mnuStardustCalculator.Text = "Calculator";
            this.mnuStardustCalculator.Click += new System.EventHandler(this.mnuStardustCalculator_Click);
            // 
            // gemsToolStripMenuItem
            // 
            this.gemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGemCalculator});
            this.gemsToolStripMenuItem.Name = "gemsToolStripMenuItem";
            this.gemsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.gemsToolStripMenuItem.Text = "Gems";
            // 
            // mnuGemCalculator
            // 
            this.mnuGemCalculator.Name = "mnuGemCalculator";
            this.mnuGemCalculator.Size = new System.Drawing.Size(152, 22);
            this.mnuGemCalculator.Text = "Calculator";
            this.mnuGemCalculator.Click += new System.EventHandler(this.mnuGemCalculator_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 306);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "WOIHelper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuStardusts;
        private System.Windows.Forms.ToolStripMenuItem mnuStardustCalculator;
        private System.Windows.Forms.ToolStripMenuItem gemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGemCalculator;
    }
}