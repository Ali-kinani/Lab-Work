using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondproject
{
    public partial class frmMain : Form
    {
        string username = "Ali";
        string myPassword = "1234";
        
        int attempt = 1;
        int MaxAttempts = 3;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

          
            while (attempt <= MaxAttempts)
            {
                if (TxtUser.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (TxtPw.Text != "1234")
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        BtnLogin.Text = "Logout";
                        toolStripStatusLabel1.Text = " your logged in ";
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while

        }

        private void TxtPw_TextChanged(object sender, EventArgs e)
        {
            TxtPw.PasswordChar = '*';
            
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheck frm= new frmCheck();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnRamdomCom_Click(object sender, EventArgs e)
        {
            frmRandomCom frm = new frmRandomCom();
            frm.ShowDialog();
        }

        private void BtnPictureBox_Click(object sender, EventArgs e)
        {
            frmImage frm = new frmImage();
            frm.ShowDialog();
        }

        private void BtnSelifieApp_Click(object sender, EventArgs e)
        {
            frmSelfie frm = new frmSelfie();
            frm.ShowDialog();
        }

        private void BtnGropieApp_Click(object sender, EventArgs e)
        {
            frmGroupie frm = new frmGroupie();
            frm.ShowDialog();
        }

        private void Method_Click(object sender, EventArgs e)
        {
            frmMethod frm = new frmMethod();
            frm.ShowDialog();
        }

        private void Class_Click(object sender, EventArgs e)
        {
            frmClass frm = new frmClass();
            frm.ShowDialog();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Array_Click(object sender, EventArgs e)
        {
            frmArray frm = new frmArray();
            frm.ShowDialog();
        }

        private void BtnPictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
