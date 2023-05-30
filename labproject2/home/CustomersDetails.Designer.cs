namespace VP_Project.home
{
    partial class CustomersDetails
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
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.NameLBL = new System.Windows.Forms.Label();
            this.CNICLBL = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.CNICTextBox = new System.Windows.Forms.TextBox();
            this.ViewBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(66, 215);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.RowTemplate.Height = 25;
            this.CustomersDataGridView.Size = new System.Drawing.Size(849, 305);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLBL.Location = new System.Drawing.Point(107, 56);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(91, 38);
            this.NameLBL.TabIndex = 1;
            this.NameLBL.Text = "Name";
            // 
            // CNICLBL
            // 
            this.CNICLBL.AutoSize = true;
            this.CNICLBL.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CNICLBL.Location = new System.Drawing.Point(529, 56);
            this.CNICLBL.Name = "CNICLBL";
            this.CNICLBL.Size = new System.Drawing.Size(79, 38);
            this.CNICLBL.TabIndex = 2;
            this.CNICLBL.Text = "CNIC";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(231, 65);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(204, 27);
            this.NameTextbox.TabIndex = 3;
            // 
            // CNICTextBox
            // 
            this.CNICTextBox.Location = new System.Drawing.Point(656, 65);
            this.CNICTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CNICTextBox.Name = "CNICTextBox";
            this.CNICTextBox.Size = new System.Drawing.Size(204, 27);
            this.CNICTextBox.TabIndex = 4;
            // 
            // ViewBTN
            // 
            this.ViewBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.ViewBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewBTN.ForeColor = System.Drawing.Color.White;
            this.ViewBTN.Location = new System.Drawing.Point(294, 131);
            this.ViewBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ViewBTN.Name = "ViewBTN";
            this.ViewBTN.Size = new System.Drawing.Size(160, 48);
            this.ViewBTN.TabIndex = 5;
            this.ViewBTN.Text = "View";
            this.ViewBTN.UseVisualStyleBackColor = false;
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.deleteBTN.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBTN.ForeColor = System.Drawing.Color.White;
            this.deleteBTN.Location = new System.Drawing.Point(563, 131);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(160, 48);
            this.deleteBTN.TabIndex = 6;
            this.deleteBTN.Text = "View All";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(94, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.ViewBTN);
            this.Controls.Add(this.CNICTextBox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.CNICLBL);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.CustomersDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomersDetails";
            this.Text = "CustomersDetails";
            this.Load += new System.EventHandler(this.CustomersDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView CustomersDataGridView;
        private Label NameLBL;
        private Label CNICLBL;
        private TextBox NameTextbox;
        private TextBox CNICTextBox;
        private Button ViewBTN;
        private Button deleteBTN;
        private Button button1;
    }
}