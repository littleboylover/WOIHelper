namespace WOIHelper
{
    partial class frmPacks
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvPackDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboPack = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.lvItemPacks = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(408, 311);
            this.tabMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvPackDetails);
            this.tabPage1.Controls.Add(this.cboPack);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pack Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvPackDetails
            // 
            this.lvPackDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPackDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPackDetails.FullRowSelect = true;
            this.lvPackDetails.Location = new System.Drawing.Point(9, 44);
            this.lvPackDetails.MultiSelect = false;
            this.lvPackDetails.Name = "lvPackDetails";
            this.lvPackDetails.Size = new System.Drawing.Size(385, 235);
            this.lvPackDetails.TabIndex = 2;
            this.lvPackDetails.UseCompatibleStateImageBehavior = false;
            this.lvPackDetails.View = System.Windows.Forms.View.Details;
            this.lvPackDetails.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPackDetails_ColumnClick);
            this.lvPackDetails.DoubleClick += new System.EventHandler(this.lvPackDetails_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate";
            this.columnHeader2.Width = 92;
            // 
            // cboPack
            // 
            this.cboPack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPack.FormattingEnabled = true;
            this.cboPack.Location = new System.Drawing.Point(177, 16);
            this.cboPack.Name = "cboPack";
            this.cboPack.Size = new System.Drawing.Size(121, 21);
            this.cboPack.TabIndex = 1;
            this.cboPack.SelectedIndexChanged += new System.EventHandler(this.cboPack_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Pack:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cboItemName);
            this.tabPage2.Controls.Add(this.lvItemPacks);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboItemName
            // 
            this.cboItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Location = new System.Drawing.Point(85, 7);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(189, 21);
            this.cboItemName.TabIndex = 4;
            this.cboItemName.SelectedIndexChanged += new System.EventHandler(this.cboItemName_SelectedIndexChanged);
            // 
            // lvItemPacks
            // 
            this.lvItemPacks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItemPacks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvItemPacks.FullRowSelect = true;
            this.lvItemPacks.Location = new System.Drawing.Point(85, 34);
            this.lvItemPacks.MultiSelect = false;
            this.lvItemPacks.Name = "lvItemPacks";
            this.lvItemPacks.Size = new System.Drawing.Size(309, 245);
            this.lvItemPacks.TabIndex = 3;
            this.lvItemPacks.UseCompatibleStateImageBehavior = false;
            this.lvItemPacks.View = System.Windows.Forms.View.Details;
            this.lvItemPacks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvItemPacks_ColumnClick);
            this.lvItemPacks.DoubleClick += new System.EventHandler(this.lvItemPacks_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pack";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appears in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Name:";
            // 
            // frmPacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 336);
            this.Controls.Add(this.tabMain);
            this.Name = "frmPacks";
            this.Text = "Pack details";
            this.Load += new System.EventHandler(this.frmPacks_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboPack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPackDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvItemPacks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cboItemName;
    }
}