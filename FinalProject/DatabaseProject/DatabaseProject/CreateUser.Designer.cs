namespace DatabaseProject
{
    partial class CreateUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.UserViewBtn = new System.Windows.Forms.Button();
            this.userGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter a user name:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(472, 196);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(100, 22);
            this.PasswordTxt.TabIndex = 2;
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(472, 102);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(100, 22);
            this.UserTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please enter a password:";
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateUserBtn.Location = new System.Drawing.Point(59, 302);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(208, 63);
            this.CreateUserBtn.TabIndex = 4;
            this.CreateUserBtn.Text = "Create User";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(364, 302);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(208, 63);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(216, 413);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.ErrorLabel.TabIndex = 6;
            // 
            // UserViewBtn
            // 
            this.UserViewBtn.Location = new System.Drawing.Point(844, 476);
            this.UserViewBtn.Name = "UserViewBtn";
            this.UserViewBtn.Size = new System.Drawing.Size(246, 23);
            this.UserViewBtn.TabIndex = 7;
            this.UserViewBtn.Text = "See all usernames in use";
            this.UserViewBtn.UseVisualStyleBackColor = true;
            this.UserViewBtn.Click += new System.EventHandler(this.UserViewBtn_Click);
            // 
            // userGrid
            // 
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.Location = new System.Drawing.Point(768, 122);
            this.userGrid.Name = "userGrid";
            this.userGrid.ReadOnly = true;
            this.userGrid.RowTemplate.Height = 24;
            this.userGrid.Size = new System.Drawing.Size(157, 153);
            this.userGrid.TabIndex = 8;
            // 
            // CreateUser
            // 
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.userGrid);
            this.Controls.Add(this.UserViewBtn);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label2);
            this.Name = "CreateUser";
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button UserViewBtn;
        private System.Windows.Forms.DataGridView userGrid;
    }
}