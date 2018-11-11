namespace DatabaseProject
{
    partial class UserWallet
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
            this.walletInfoBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.userLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addCryptoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // walletInfoBtn
            // 
            this.walletInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletInfoBtn.Location = new System.Drawing.Point(12, 12);
            this.walletInfoBtn.Name = "walletInfoBtn";
            this.walletInfoBtn.Size = new System.Drawing.Size(375, 90);
            this.walletInfoBtn.TabIndex = 0;
            this.walletInfoBtn.Text = "Show wallet info";
            this.walletInfoBtn.UseVisualStyleBackColor = true;
            this.walletInfoBtn.Click += new System.EventHandler(this.walletInfoBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(79, 497);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 2;
            // 
            // userGrid
            // 
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Location = new System.Drawing.Point(192, 174);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RowTemplate.Height = 24;
            this.userGrid.Size = new System.Drawing.Size(734, 280);
            this.userGrid.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(538, 128);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 17);
            this.userLabel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(402, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 90);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show user balance and total amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addCryptoBtn
            // 
            this.addCryptoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCryptoBtn.Location = new System.Drawing.Point(795, 12);
            this.addCryptoBtn.Name = "addCryptoBtn";
            this.addCryptoBtn.Size = new System.Drawing.Size(375, 90);
            this.addCryptoBtn.TabIndex = 6;
            this.addCryptoBtn.Text = "Add Crypto";
            this.addCryptoBtn.UseVisualStyleBackColor = true;
            this.addCryptoBtn.Click += new System.EventHandler(this.addCryptoBtn_Click);
            // 
            // UserWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.addCryptoBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.walletInfoBtn);
            this.Name = "UserWallet";
            this.Text = "UserWallet";
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button walletInfoBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addCryptoBtn;
    }
}