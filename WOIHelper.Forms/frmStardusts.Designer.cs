namespace WOIHelper
{
    partial class frmStardusts
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
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStardusts = new System.Windows.Forms.ComboBox();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.chkGathered = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount:";
            // 
            // txtAmt
            // 
            this.txtAmt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAmt.Location = new System.Drawing.Point(108, 48);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(61, 20);
            this.txtAmt.TabIndex = 3;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmdCalculate.Location = new System.Drawing.Point(109, 97);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 4;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stardust:";
            // 
            // cboStardusts
            // 
            this.cboStardusts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboStardusts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStardusts.FormattingEnabled = true;
            this.cboStardusts.Location = new System.Drawing.Point(108, 21);
            this.cboStardusts.Name = "cboStardusts";
            this.cboStardusts.Size = new System.Drawing.Size(132, 21);
            this.cboStardusts.TabIndex = 1;
            // 
            // lblRequirements
            // 
            this.lblRequirements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRequirements.Location = new System.Drawing.Point(12, 123);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(269, 129);
            this.lblRequirements.TabIndex = 5;
            this.lblRequirements.Text = "Requirements here";
            this.lblRequirements.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkGathered
            // 
            this.chkGathered.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkGathered.AutoSize = true;
            this.chkGathered.Location = new System.Drawing.Point(106, 74);
            this.chkGathered.Name = "chkGathered";
            this.chkGathered.Size = new System.Drawing.Size(94, 17);
            this.chkGathered.TabIndex = 7;
            this.chkGathered.Text = "Gathered Only";
            this.chkGathered.UseVisualStyleBackColor = true;
            // 
            // frmStardusts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 261);
            this.Controls.Add(this.chkGathered);
            this.Controls.Add(this.lblRequirements);
            this.Controls.Add(this.cboStardusts);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(309, 300);
            this.Name = "frmStardusts";
            this.Text = "Stardusts";
            this.Load += new System.EventHandler(this.frmStardusts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStardusts;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.CheckBox chkGathered;
    }
}