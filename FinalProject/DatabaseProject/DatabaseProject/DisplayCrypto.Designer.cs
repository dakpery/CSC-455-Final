namespace DatabaseProject
{
    partial class DisplayCrypto
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
            this.cartesianBtn = new System.Windows.Forms.Button();
            this.platMarketCapBtn = new System.Windows.Forms.Button();
            this.twoYearsBtn = new System.Windows.Forms.Button();
            this.cryptoGrid = new System.Windows.Forms.DataGridView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.avgSupplyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianBtn
            // 
            this.cartesianBtn.Location = new System.Drawing.Point(34, 12);
            this.cartesianBtn.Name = "cartesianBtn";
            this.cartesianBtn.Size = new System.Drawing.Size(300, 100);
            this.cartesianBtn.TabIndex = 0;
            this.cartesianBtn.Text = "Cartesian Cryptos";
            this.cartesianBtn.UseVisualStyleBackColor = true;
            this.cartesianBtn.Click += new System.EventHandler(this.cartesianBtn_Click);
            // 
            // platMarketCapBtn
            // 
            this.platMarketCapBtn.Location = new System.Drawing.Point(349, 12);
            this.platMarketCapBtn.Name = "platMarketCapBtn";
            this.platMarketCapBtn.Size = new System.Drawing.Size(246, 100);
            this.platMarketCapBtn.TabIndex = 1;
            this.platMarketCapBtn.Text = "Platform Market Cap";
            this.platMarketCapBtn.UseVisualStyleBackColor = true;
            this.platMarketCapBtn.Click += new System.EventHandler(this.platMarketCapBtn_Click);
            // 
            // twoYearsBtn
            // 
            this.twoYearsBtn.Location = new System.Drawing.Point(870, 12);
            this.twoYearsBtn.Name = "twoYearsBtn";
            this.twoYearsBtn.Size = new System.Drawing.Size(300, 100);
            this.twoYearsBtn.TabIndex = 2;
            this.twoYearsBtn.Text = "Cryptos Released Within 2 Years";
            this.twoYearsBtn.UseVisualStyleBackColor = true;
            this.twoYearsBtn.Click += new System.EventHandler(this.twoYearsBtn_Click);
            // 
            // cryptoGrid
            // 
            this.cryptoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cryptoGrid.Location = new System.Drawing.Point(69, 139);
            this.cryptoGrid.Name = "cryptoGrid";
            this.cryptoGrid.ReadOnly = true;
            this.cryptoGrid.RowTemplate.Height = 24;
            this.cryptoGrid.Size = new System.Drawing.Size(1024, 330);
            this.cryptoGrid.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(248, 510);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(74, 17);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "errorLabel";
            // 
            // avgSupplyBtn
            // 
            this.avgSupplyBtn.Location = new System.Drawing.Point(617, 12);
            this.avgSupplyBtn.Name = "avgSupplyBtn";
            this.avgSupplyBtn.Size = new System.Drawing.Size(234, 100);
            this.avgSupplyBtn.TabIndex = 5;
            this.avgSupplyBtn.Text = "Average Circulating Supply";
            this.avgSupplyBtn.UseVisualStyleBackColor = true;
            this.avgSupplyBtn.Click += new System.EventHandler(this.avgSupplyBtn_Click);
            // 
            // DisplayCrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.avgSupplyBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cryptoGrid);
            this.Controls.Add(this.twoYearsBtn);
            this.Controls.Add(this.platMarketCapBtn);
            this.Controls.Add(this.cartesianBtn);
            this.Name = "DisplayCrypto";
            this.Text = "DisplayCrypto";
            ((System.ComponentModel.ISupportInitialize)(this.cryptoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cartesianBtn;
        private System.Windows.Forms.Button platMarketCapBtn;
        private System.Windows.Forms.Button twoYearsBtn;
        private System.Windows.Forms.DataGridView cryptoGrid;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button avgSupplyBtn;
    }
}