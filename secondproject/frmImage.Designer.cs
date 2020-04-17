namespace secondproject
{
    partial class frmImage
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
            this.BtnImageFromFile = new System.Windows.Forms.Button();
            this.BtnImagefromResorses = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PicTry2 = new System.Windows.Forms.PictureBox();
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnImageFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImageFromFile.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImageFromFile.Location = new System.Drawing.Point(27, 29);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(154, 67);
            this.BtnImageFromFile.TabIndex = 0;
            this.BtnImageFromFile.Text = "Image From File";
            this.BtnImageFromFile.UseVisualStyleBackColor = false;
            this.BtnImageFromFile.Click += new System.EventHandler(this.BtnImageFromFile_Click);
            // 
            // BtnImagefromResorses
            // 
            this.BtnImagefromResorses.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnImagefromResorses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImagefromResorses.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImagefromResorses.Location = new System.Drawing.Point(28, 156);
            this.BtnImagefromResorses.Name = "BtnImagefromResorses";
            this.BtnImagefromResorses.Size = new System.Drawing.Size(152, 72);
            this.BtnImagefromResorses.TabIndex = 1;
            this.BtnImagefromResorses.Text = "Image from Resorses";
            this.BtnImagefromResorses.UseVisualStyleBackColor = false;
            this.BtnImagefromResorses.Click += new System.EventHandler(this.BtnImagefromResorses_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicTry2);
            this.groupBox1.Controls.Add(this.PicTry);
            this.groupBox1.Location = new System.Drawing.Point(219, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // PicTry2
            // 
            this.PicTry2.Location = new System.Drawing.Point(279, 38);
            this.PicTry2.Name = "PicTry2";
            this.PicTry2.Size = new System.Drawing.Size(250, 319);
            this.PicTry2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry2.TabIndex = 1;
            this.PicTry2.TabStop = false;
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(23, 38);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(250, 319);
            this.PicTry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTry.TabIndex = 0;
            this.PicTry.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.Red;
            this.BtnBack.Location = new System.Drawing.Point(635, 443);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(154, 49);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(827, 519);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnImagefromResorses);
            this.Controls.Add(this.BtnImageFromFile);
            this.Name = "frmImage";
            this.Text = "frmImage";
            this.Load += new System.EventHandler(this.frmImage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTry2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.Button BtnImagefromResorses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PicTry2;
        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button BtnBack;
    }
}