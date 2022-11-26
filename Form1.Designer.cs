namespace _04_OOP_BABankasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateBank = new System.Windows.Forms.Button();
            this.btnCustomerCame = new System.Windows.Forms.Button();
            this.txtIdNo = new System.Windows.Forms.TextBox();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateBank
            // 
            this.btnCreateBank.Location = new System.Drawing.Point(12, 12);
            this.btnCreateBank.Name = "btnCreateBank";
            this.btnCreateBank.Size = new System.Drawing.Size(205, 44);
            this.btnCreateBank.TabIndex = 0;
            this.btnCreateBank.Text = "Banka Oluştur";
            this.btnCreateBank.UseVisualStyleBackColor = true;
            this.btnCreateBank.Click += new System.EventHandler(this.btnCreateBank_Click);
            // 
            // btnCustomerCame
            // 
            this.btnCustomerCame.Location = new System.Drawing.Point(96, 150);
            this.btnCustomerCame.Name = "btnCustomerCame";
            this.btnCustomerCame.Size = new System.Drawing.Size(205, 40);
            this.btnCustomerCame.TabIndex = 0;
            this.btnCustomerCame.Text = "Müşteri Geldi";
            this.btnCustomerCame.UseVisualStyleBackColor = true;
            this.btnCustomerCame.Click += new System.EventHandler(this.btnCustomerCame_Click);
            // 
            // txtIdNo
            // 
            this.txtIdNo.Location = new System.Drawing.Point(96, 55);
            this.txtIdNo.Name = "txtIdNo";
            this.txtIdNo.Size = new System.Drawing.Size(205, 27);
            this.txtIdNo.TabIndex = 1;
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Location = new System.Drawing.Point(96, 100);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(205, 28);
            this.cmbTransactionType.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTransactionType);
            this.groupBox1.Controls.Add(this.lblIdNo);
            this.groupBox1.Controls.Add(this.btnCustomerCame);
            this.groupBox1.Controls.Add(this.txtIdNo);
            this.groupBox1.Controls.Add(this.cmbTransactionType);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Location = new System.Drawing.Point(6, 58);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(52, 20);
            this.lblIdNo.TabIndex = 4;
            this.lblIdNo.Text = "TC No:";
            this.lblIdNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Location = new System.Drawing.Point(6, 103);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(76, 20);
            this.lblTransactionType.TabIndex = 4;
            this.lblTransactionType.Text = "İşlem Tipi:";
            this.lblTransactionType.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreateBank);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCreateBank;
        private Button btnCustomerCame;
        private TextBox txtIdNo;
        private ComboBox cmbTransactionType;
        private GroupBox groupBox1;
        private Label lblIdNo;
        private Label lblTransactionType;
    }
}