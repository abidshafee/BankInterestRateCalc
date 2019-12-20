namespace BankInterestRateCalc
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
            this.bankNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeInYeartextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalBalanceTextBox = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bankNameComboBox
            // 
            this.bankNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankNameComboBox.FormattingEnabled = true;
            this.bankNameComboBox.Items.AddRange(new object[] {
            "Please Select Your Bank",
            "SONALI",
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bankNameComboBox.Location = new System.Drawing.Point(237, 72);
            this.bankNameComboBox.Name = "bankNameComboBox";
            this.bankNameComboBox.Size = new System.Drawing.Size(173, 21);
            this.bankNameComboBox.TabIndex = 0;
            this.bankNameComboBox.SelectedIndexChanged += new System.EventHandler(this.bankNameComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Bank Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time In Year: ";
            // 
            // timeInYeartextBox
            // 
            this.timeInYeartextBox.Location = new System.Drawing.Point(237, 108);
            this.timeInYeartextBox.Name = "timeInYeartextBox";
            this.timeInYeartextBox.Size = new System.Drawing.Size(173, 20);
            this.timeInYeartextBox.TabIndex = 3;
            this.timeInYeartextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Balance: ";
            // 
            // totalBalanceTextBox
            // 
            this.totalBalanceTextBox.Location = new System.Drawing.Point(237, 147);
            this.totalBalanceTextBox.Name = "totalBalanceTextBox";
            this.totalBalanceTextBox.Size = new System.Drawing.Size(173, 20);
            this.totalBalanceTextBox.TabIndex = 5;
            this.totalBalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcBtn
            // 
            this.calcBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcBtn.Location = new System.Drawing.Point(285, 185);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(125, 23);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate Interest";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Interest: ";
            // 
            // resultBox
            // 
            this.resultBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.resultBox.Location = new System.Drawing.Point(237, 235);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(173, 20);
            this.resultBox.TabIndex = 8;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 385);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.totalBalanceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeInYeartextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bankNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Bank Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bankNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeInYeartextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalBalanceTextBox;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultBox;
    }
}

