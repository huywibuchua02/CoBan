namespace donet_python
{
    partial class frmDotNet_Python
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.cmdTalk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSource.Location = new System.Drawing.Point(11, 32);
            this.txtSource.Margin = new System.Windows.Forms.Padding(2);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(616, 85);
            this.txtSource.TabIndex = 0;
            // 
            // cmdTalk
            // 
            this.cmdTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTalk.Location = new System.Drawing.Point(489, 126);
            this.cmdTalk.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTalk.Name = "cmdTalk";
            this.cmdTalk.Size = new System.Drawing.Size(138, 43);
            this.cmdTalk.TabIndex = 1;
            this.cmdTalk.Text = "Gen Mp3 -> Play";
            this.cmdTalk.UseVisualStyleBackColor = true;
            this.cmdTalk.Click += new System.EventHandler(this.cmdTalk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập văn bản:";
            // 
            // txtLang
            // 
            this.txtLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLang.Location = new System.Drawing.Point(556, 5);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(71, 22);
            this.txtLang.TabIndex = 5;
            this.txtLang.Text = "vi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngôn ngữ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 139);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(47, 16);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Status:";
            // 
            // cboLang
            // 
            this.cboLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Location = new System.Drawing.Point(386, 4);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(164, 24);
            this.cboLang.TabIndex = 8;
            // 
            // frmDotNet_Python
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(639, 175);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdTalk);
            this.Controls.Add(this.txtSource);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(478, 175);
            this.Name = "frmDotNet_Python";
            this.Text = "Gen Audio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button cmdTalk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox cboLang;
    }
}

