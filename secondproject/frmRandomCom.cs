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
    public partial class frmRandomCom : Form
    {
        Random r = new Random();
        public frmRandomCom()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            cmbRandom.ResetText();
            cmbRandom.Items.Clear();
            if (RdoLessthan500.Checked == true)
            {
                for (int i = 0; i < r.Next(1, 50); i++)
                {
                    cmbRandom.Items.Add(r.Next(0, 500));
                }

            }
            else if (RdoGreaterthan500.Checked == true)
            {
                for (int i = 0; i < r.Next(1, 50); i++)
                {
                    cmbRandom.Items.Add(r.Next(500, 9999));
                }

            }
            else
            {
                MessageBox.Show("pleas check one of the boxses");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoGreaterthan500.Checked = false;
            RdoLessthan500.Checked = false;
            cmbRandom.Items.Clear();
            cmbRandom.ResetText();
        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            cmbRandom2.ResetText();
            cmbRandom2.Items.Clear();
            if (RdoLessthan50.Checked == true)
            {
                for (int i = 0; i < r.Next(1, 50); i++)
                {
                    cmbRandom2.Items.Add(r.Next(0, 50));
                }

            }
            else if (RdoGreaterthan50.Checked == true)
            {
                for (int i = 0; i < r.Next(1, 50); i++)
                {
                    cmbRandom2.Items.Add(r.Next(50, 999));
                }

            }
            else
            {
                MessageBox.Show("pleas check one of the boxses");
            }
        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {
            RdoGreaterthan50.Checked = false;
            RdoLessthan50.Checked = false;
            cmbRandom2.Items.Clear();
            cmbRandom2.ResetText();
        }
    }
}
