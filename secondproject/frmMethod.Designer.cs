namespace secondproject
{
    partial class frmMethod
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
            this.BtnDeposit = new System.Windows.Forms.Button();
            this.BtnWithdraw = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.BtnCheckBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDeposit
            // 
            this.BtnDeposit.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeposit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeposit.Location = new System.Drawing.Point(100, 48);
            this.BtnDeposit.Name = "BtnDeposit";
            this.BtnDeposit.Size = new System.Drawing.Size(133, 47);
            this.BtnDeposit.TabIndex = 0;
            this.BtnDeposit.Text = "Deposit";
            this.BtnDeposit.UseVisualStyleBackColor = false;
            this.BtnDeposit.Click += new System.EventHandler(this.BtnDeposit_Click);
            // 
            // BtnWithdraw
            // 
            this.BtnWithdraw.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnWithdraw.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWithdraw.Location = new System.Drawing.Point(100, 140);
            this.BtnWithdraw.Name = "BtnWithdraw";
            this.BtnWithdraw.Size = new System.Drawing.Size(133, 47);
            this.BtnWithdraw.TabIndex = 1;
            this.BtnWithdraw.Text = "Withdraw";
            this.BtnWithdraw.UseVisualStyleBackColor = false;
            this.BtnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCalculate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(329, 222);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(110, 47);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(401, 304);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(124, 43);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(329, 71);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(110, 24);
            this.TxtA.TabIndex = 4;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(329, 163);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(110, 24);
            this.TxtB.TabIndex = 5;
            // 
            // BtnCheckBalance
            // 
            this.BtnCheckBalance.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCheckBalance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckBalance.Location = new System.Drawing.Point(100, 222);
            this.BtnCheckBalance.Name = "BtnCheckBalance";
            this.BtnCheckBalance.Size = new System.Drawing.Size(133, 45);
            this.BtnCheckBalance.TabIndex = 6;
            this.BtnCheckBalance.Text = "CheckBalance";
            this.BtnCheckBalance.UseVisualStyleBackColor = false;
            this.BtnCheckBalance.Click += new System.EventHandler(this.BtnCheckBalance_Click);
            // 
            // frmMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(537, 359);
            this.Controls.Add(this.BtnCheckBalance);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnWithdraw);
            this.Controls.Add(this.BtnDeposit);
            this.Name = "frmMethod";
            this.Text = "frmMethod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDeposit;
        private System.Windows.Forms.Button BtnWithdraw;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Button BtnCheckBalance;
    }
}