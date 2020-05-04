namespace WOIHelper
{
    partial class frmGem
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTargetGemLevel = new System.Windows.Forms.ComboBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.lblSummary = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStartingLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target gem level:";
            // 
            // cboTargetGemLevel
            // 
            this.cboTargetGemLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTargetGemLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetGemLevel.FormattingEnabled = true;
            this.cboTargetGemLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboTargetGemLevel.Location = new System.Drawing.Point(132, 39);
            this.cboTargetGemLevel.Name = "cboTargetGemLevel";
            this.cboTargetGemLevel.Size = new System.Drawing.Size(121, 21);
            this.cboTargetGemLevel.TabIndex = 1;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCalculate.Location = new System.Drawing.Point(108, 67);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 2;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary.Location = new System.Drawing.Point(12, 93);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(260, 177);
            this.lblSummary.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Starting gem level:";
            // 
            // cboStartingLevel
            // 
            this.cboStartingLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStartingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartingLevel.FormattingEnabled = true;
            this.cboStartingLevel.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboStartingLevel.Location = new System.Drawing.Point(132, 12);
            this.cboStartingLevel.Name = "cboStartingLevel";
            this.cboStartingLevel.Size = new System.Drawing.Size(121, 21);
            this.cboStartingLevel.TabIndex = 1;
            // 
            // frmGem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.cboStartingLevel);
            this.Controls.Add(this.cboTargetGemLevel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGem";
            this.Text = "Gem Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTargetGemLevel;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStartingLevel;
    }
}

