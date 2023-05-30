namespace VP_Project.home
{
    partial class Transactions
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
            this.label2 = new System.Windows.Forms.Label();
            this.AcountNoLBL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectbankCMB = new System.Windows.Forms.ComboBox();
            this.SelectPurposeOfPaymentCMB = new System.Windows.Forms.ComboBox();
            this.EnterAccountNoTexbox = new System.Windows.Forms.TextBox();
            this.ProceedBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(373, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Transfer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Bank";
            // 
            // AcountNoLBL
            // 
            this.AcountNoLBL.AutoSize = true;
            this.AcountNoLBL.Font = new System.Drawing.Font("Segoe UI", 16.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AcountNoLBL.Location = new System.Drawing.Point(527, 143);
            this.AcountNoLBL.Name = "AcountNoLBL";
            this.AcountNoLBL.Size = new System.Drawing.Size(226, 38);
            this.AcountNoLBL.TabIndex = 2;
            this.AcountNoLBL.Text = "Enter account no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(92, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select purpose of payment";
            // 
            // SelectbankCMB
            // 
            this.SelectbankCMB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectbankCMB.FormattingEnabled = true;
            this.SelectbankCMB.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.SelectbankCMB.Location = new System.Drawing.Point(92, 187);
            this.SelectbankCMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectbankCMB.Name = "SelectbankCMB";
            this.SelectbankCMB.Size = new System.Drawing.Size(342, 39);
            this.SelectbankCMB.TabIndex = 4;
            this.SelectbankCMB.SelectedIndexChanged += new System.EventHandler(this.SelectbankCMB_SelectedIndexChanged);
            // 
            // SelectPurposeOfPaymentCMB
            // 
            this.SelectPurposeOfPaymentCMB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectPurposeOfPaymentCMB.FormattingEnabled = true;
            this.SelectPurposeOfPaymentCMB.Location = new System.Drawing.Point(92, 326);
            this.SelectPurposeOfPaymentCMB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectPurposeOfPaymentCMB.Name = "SelectPurposeOfPaymentCMB";
            this.SelectPurposeOfPaymentCMB.Size = new System.Drawing.Size(342, 39);
            this.SelectPurposeOfPaymentCMB.TabIndex = 5;
            // 
            // EnterAccountNoTexbox
            // 
            this.EnterAccountNoTexbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterAccountNoTexbox.Location = new System.Drawing.Point(527, 187);
            this.EnterAccountNoTexbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterAccountNoTexbox.Name = "EnterAccountNoTexbox";
            this.EnterAccountNoTexbox.Size = new System.Drawing.Size(342, 39);
            this.EnterAccountNoTexbox.TabIndex = 6;
            // 
            // ProceedBTN
            // 
            this.ProceedBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ProceedBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProceedBTN.ForeColor = System.Drawing.Color.White;
            this.ProceedBTN.Location = new System.Drawing.Point(307, 449);
            this.ProceedBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProceedBTN.Name = "ProceedBTN";
            this.ProceedBTN.Size = new System.Drawing.Size(341, 48);
            this.ProceedBTN.TabIndex = 7;
            this.ProceedBTN.Text = "Proceed";
            this.ProceedBTN.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(359, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Reciever\'s Details";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountTextBox.Location = new System.Drawing.Point(527, 326);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(342, 39);
            this.amountTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(527, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Amount";
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProceedBTN);
            this.Controls.Add(this.EnterAccountNoTexbox);
            this.Controls.Add(this.SelectPurposeOfPaymentCMB);
            this.Controls.Add(this.SelectbankCMB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AcountNoLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label AcountNoLBL;
        private Label label4;
        private ComboBox SelectbankCMB;
        private ComboBox SelectPurposeOfPaymentCMB;
        private TextBox EnterAccountNoTexbox;
        private Button ProceedBTN;
        private Label label3;
        private TextBox amountTextBox;
        private Label label5;
    }
}