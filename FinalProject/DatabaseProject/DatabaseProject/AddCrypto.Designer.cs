namespace DatabaseProject
{
    partial class AddCrypto
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
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.cryptoCombo = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select how many crypto to add to your account";
            // 
            // numBox
            // 
            this.numBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBox.Location = new System.Drawing.Point(618, 119);
            this.numBox.Name = "numBox";
            this.numBox.ReadOnly = true;
            this.numBox.Size = new System.Drawing.Size(173, 30);
            this.numBox.TabIndex = 1;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(328, 365);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(173, 86);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(618, 365);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(173, 86);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cryptoCombo
            // 
            this.cryptoCombo.FormattingEnabled = true;
            this.cryptoCombo.Location = new System.Drawing.Point(328, 119);
            this.cryptoCombo.Name = "cryptoCombo";
            this.cryptoCombo.Size = new System.Drawing.Size(173, 24);
            this.cryptoCombo.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(511, 498);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 5;
            // 
            // AddCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cryptoCombo);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label1);
            this.Name = "AddCrypto";
            this.Text = "AddCrypto";
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox cryptoCombo;
        private System.Windows.Forms.Label errorLabel;
    }
}