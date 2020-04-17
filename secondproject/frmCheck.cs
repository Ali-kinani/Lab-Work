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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (ChcCoffee.Checked == true)
            {
                msg = ChcCoffee.Text;
            }
            if (ChcDonut.Checked == true)
            {
                msg = msg + " " + ChcDonut.Text;
            }
            if (ChcBrownie.Checked == true)
            {
                msg = msg + " " + ChcBrownie.Text;
            }
            if (msg.Length > 0)
            {
                MessageBox.Show( msg + " orderd ");
            }
            else
            {
                MessageBox.Show("nothing ordered");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
