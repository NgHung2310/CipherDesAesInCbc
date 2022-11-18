namespace CipherDesAesInCbc
{
    partial class FormDesCbc
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
            this.tbxIv = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbInfomation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.btnBrowseOut = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxIv
            // 
            this.tbxIv.Location = new System.Drawing.Point(761, 301);
            this.tbxIv.Name = "tbxIv";
            this.tbxIv.Size = new System.Drawing.Size(253, 26);
            this.tbxIv.TabIndex = 20;
            this.tbxIv.TextChanged += new System.EventHandler(this.tbxIv_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(723, 584);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(294, 46);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbInfomation
            // 
            this.lbInfomation.AutoSize = true;
            this.lbInfomation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfomation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbInfomation.Location = new System.Drawing.Point(720, 177);
            this.lbInfomation.Name = "lbInfomation";
            this.lbInfomation.Size = new System.Drawing.Size(0, 20);
            this.lbInfomation.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Key";
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(720, 365);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(294, 46);
            this.btnGenerateKey.TabIndex = 16;
            this.btnGenerateKey.Text = "Generate key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // rbtnDecrypt
            // 
            this.rbtnDecrypt.AutoSize = true;
            this.rbtnDecrypt.Location = new System.Drawing.Point(613, 317);
            this.rbtnDecrypt.Name = "rbtnDecrypt";
            this.rbtnDecrypt.Size = new System.Drawing.Size(82, 24);
            this.rbtnDecrypt.TabIndex = 5;
            this.rbtnDecrypt.TabStop = true;
            this.rbtnDecrypt.Text = "Decrypt";
            this.rbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // rbtnEncrypt
            // 
            this.rbtnEncrypt.AutoSize = true;
            this.rbtnEncrypt.Checked = true;
            this.rbtnEncrypt.Location = new System.Drawing.Point(613, 295);
            this.rbtnEncrypt.Name = "rbtnEncrypt";
            this.rbtnEncrypt.Size = new System.Drawing.Size(81, 24);
            this.rbtnEncrypt.TabIndex = 4;
            this.rbtnEncrypt.TabStop = true;
            this.rbtnEncrypt.Text = "Encrypt";
            this.rbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(8, 344);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(686, 258);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Output";
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(761, 333);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(253, 26);
            this.tbxKey.TabIndex = 15;
            this.tbxKey.TextChanged += new System.EventHandler(this.tbxKey_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(720, 417);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(294, 46);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "CALCULATOR";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "IV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDecrypt);
            this.groupBox1.Controls.Add(this.rbtnEncrypt);
            this.groupBox1.Controls.Add(this.rtbOutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbInput);
            this.groupBox1.Location = new System.Drawing.Point(10, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(706, 612);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(9, 38);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(686, 258);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            // 
            // btnBrowseOut
            // 
            this.btnBrowseOut.Location = new System.Drawing.Point(720, 128);
            this.btnBrowseOut.Name = "btnBrowseOut";
            this.btnBrowseOut.Size = new System.Drawing.Size(294, 46);
            this.btnBrowseOut.TabIndex = 12;
            this.btnBrowseOut.Text = "Browse file output ...";
            this.btnBrowseOut.UseVisualStyleBackColor = true;
            this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(720, 76);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(294, 46);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse file crypt ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 55);
            this.label5.TabIndex = 22;
            this.label5.Text = "DES in CBC";
            // 
            // FormDesCbc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxIv);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbInfomation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerateKey);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowseOut);
            this.Controls.Add(this.btnBrowse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDesCbc";
            this.Text = "FormDesCbc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIv;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbInfomation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.RadioButton rbtnDecrypt;
        private System.Windows.Forms.RadioButton rbtnEncrypt;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button btnBrowseOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label5;
    }
}