namespace secondproject
{
    partial class frmRandomCom
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
            this.cmbRandom = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.RdoGreaterthan500 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan500 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.RdoGreaterthan50 = new System.Windows.Forms.RadioButton();
            this.RdoLessthan50 = new System.Windows.Forms.RadioButton();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.cmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRandom
            // 
            this.cmbRandom.FormattingEnabled = true;
            this.cmbRandom.Location = new System.Drawing.Point(34, 44);
            this.cmbRandom.Name = "cmbRandom";
            this.cmbRandom.Size = new System.Drawing.Size(121, 31);
            this.cmbRandom.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.RdoGreaterthan500);
            this.groupBox1.Controls.Add(this.RdoLessthan500);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Controls.Add(this.cmbRandom);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz03-AAF19";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(48, 191);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(94, 44);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // RdoGreaterthan500
            // 
            this.RdoGreaterthan500.AutoSize = true;
            this.RdoGreaterthan500.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoGreaterthan500.Location = new System.Drawing.Point(207, 214);
            this.RdoGreaterthan500.Name = "RdoGreaterthan500";
            this.RdoGreaterthan500.Size = new System.Drawing.Size(157, 25);
            this.RdoGreaterthan500.TabIndex = 3;
            this.RdoGreaterthan500.TabStop = true;
            this.RdoGreaterthan500.Text = "Greater than 500";
            this.RdoGreaterthan500.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan500
            // 
            this.RdoLessthan500.AutoSize = true;
            this.RdoLessthan500.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoLessthan500.Location = new System.Drawing.Point(207, 160);
            this.RdoLessthan500.Name = "RdoLessthan500";
            this.RdoLessthan500.Size = new System.Drawing.Size(134, 25);
            this.RdoLessthan500.TabIndex = 2;
            this.RdoLessthan500.TabStop = true;
            this.RdoLessthan500.Text = "Less than 500";
            this.RdoLessthan500.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenerate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.Location = new System.Drawing.Point(207, 44);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(131, 41);
            this.BtnGenerate.TabIndex = 1;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.RdoGreaterthan50);
            this.groupBox2.Controls.Add(this.RdoLessthan50);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Controls.Add(this.cmbRandom2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(430, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 269);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quiz03-EAF19";
            // 
            // BtnReset2
            // 
            this.BtnReset2.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnReset2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset2.Location = new System.Drawing.Point(48, 191);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(94, 44);
            this.BtnReset2.TabIndex = 4;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = false;
            this.BtnReset2.Click += new System.EventHandler(this.BtnReset2_Click);
            // 
            // RdoGreaterthan50
            // 
            this.RdoGreaterthan50.AutoSize = true;
            this.RdoGreaterthan50.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoGreaterthan50.Location = new System.Drawing.Point(207, 214);
            this.RdoGreaterthan50.Name = "RdoGreaterthan50";
            this.RdoGreaterthan50.Size = new System.Drawing.Size(148, 25);
            this.RdoGreaterthan50.TabIndex = 3;
            this.RdoGreaterthan50.TabStop = true;
            this.RdoGreaterthan50.Text = "Greater than 50";
            this.RdoGreaterthan50.UseVisualStyleBackColor = true;
            // 
            // RdoLessthan50
            // 
            this.RdoLessthan50.AutoSize = true;
            this.RdoLessthan50.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoLessthan50.Location = new System.Drawing.Point(207, 160);
            this.RdoLessthan50.Name = "RdoLessthan50";
            this.RdoLessthan50.Size = new System.Drawing.Size(125, 25);
            this.RdoLessthan50.TabIndex = 2;
            this.RdoLessthan50.TabStop = true;
            this.RdoLessthan50.Text = "Less than 50";
            this.RdoLessthan50.UseVisualStyleBackColor = true;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnGenerate2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenerate2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate2.Location = new System.Drawing.Point(207, 44);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(131, 41);
            this.BtnGenerate2.TabIndex = 1;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = false;
            this.BtnGenerate2.Click += new System.EventHandler(this.BtnGenerate2_Click);
            // 
            // cmbRandom2
            // 
            this.cmbRandom2.FormattingEnabled = true;
            this.cmbRandom2.Location = new System.Drawing.Point(34, 44);
            this.cmbRandom2.Name = "cmbRandom2";
            this.cmbRandom2.Size = new System.Drawing.Size(121, 31);
            this.cmbRandom2.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(664, 384);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(124, 54);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmRandomCom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRandomCom";
            this.Text = "frmRandomCom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.RadioButton RdoGreaterthan500;
        private System.Windows.Forms.RadioButton RdoLessthan500;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.RadioButton RdoGreaterthan50;
        private System.Windows.Forms.RadioButton RdoLessthan50;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.ComboBox cmbRandom2;
        private System.Windows.Forms.Button BtnBack;
    }
}