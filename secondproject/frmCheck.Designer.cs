namespace secondproject
{
    partial class frmCheck
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChcBrownie = new System.Windows.Forms.CheckBox();
            this.ChcDonut = new System.Windows.Forms.CheckBox();
            this.ChcCoffee = new System.Windows.Forms.CheckBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnShow.Location = new System.Drawing.Point(57, 38);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(122, 42);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.ChcBrownie);
            this.groupBox1.Controls.Add(this.ChcDonut);
            this.groupBox1.Controls.Add(this.ChcCoffee);
            this.groupBox1.Location = new System.Drawing.Point(57, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ChcBrownie
            // 
            this.ChcBrownie.AutoSize = true;
            this.ChcBrownie.Location = new System.Drawing.Point(21, 110);
            this.ChcBrownie.Name = "ChcBrownie";
            this.ChcBrownie.Size = new System.Drawing.Size(78, 21);
            this.ChcBrownie.TabIndex = 2;
            this.ChcBrownie.Text = "Brownie";
            this.ChcBrownie.UseVisualStyleBackColor = true;
            // 
            // ChcDonut
            // 
            this.ChcDonut.AutoSize = true;
            this.ChcDonut.Location = new System.Drawing.Point(21, 70);
            this.ChcDonut.Name = "ChcDonut";
            this.ChcDonut.Size = new System.Drawing.Size(69, 21);
            this.ChcDonut.TabIndex = 1;
            this.ChcDonut.Text = "Donut";
            this.ChcDonut.UseVisualStyleBackColor = true;
            // 
            // ChcCoffee
            // 
            this.ChcCoffee.AutoSize = true;
            this.ChcCoffee.Location = new System.Drawing.Point(21, 28);
            this.ChcCoffee.Name = "ChcCoffee";
            this.ChcCoffee.Size = new System.Drawing.Size(69, 21);
            this.ChcCoffee.TabIndex = 0;
            this.ChcCoffee.Text = "Coffee";
            this.ChcCoffee.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.ForeColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(214, 373);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(112, 45);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnShow);
            this.Name = "frmCheck";
            this.Text = "frmCheck";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.CheckBox ChcBrownie;
        private System.Windows.Forms.CheckBox ChcDonut;
        private System.Windows.Forms.CheckBox ChcCoffee;
    }
}