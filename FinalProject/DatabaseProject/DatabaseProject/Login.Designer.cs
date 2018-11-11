namespace DatabaseProject
{
    partial class Login
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
            this.signInBtn = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(234, 327);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(129, 50);
            this.signInBtn.TabIndex = 0;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // userTxt
            // 
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxt.Location = new System.Drawing.Point(207, 137);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(167, 30);
            this.userTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(417, 327);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(129, 50);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(29, 201);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(134, 31);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(207, 204);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(167, 30);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(507, 54);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 31);
            this.errorLabel.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.signInBtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label errorLabel;
    }
}