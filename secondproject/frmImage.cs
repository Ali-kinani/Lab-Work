using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace secondproject
{
    public partial class frmImage : Form
    {
        Assembly assembly ;
        Stream imageStream ;

        public frmImage()
        {
            InitializeComponent();
        }

        private void BtnImageFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                PicTry.Image = Image.FromFile("C:\\Users\\alimk\\Desktop\\IE-332\\H.W1 001.jpg");
            }
            catch
            {
                MessageBox.Show("image not found");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnImagefromResorses_Click(object sender, EventArgs e)
        {
            try
            {
                PicTry2.Image = Image.FromStream(imageStream);
            }
            catch
            {
                MessageBox.Show("image not found");
            }
        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            assembly = Assembly.GetExecutingAssembly();
            imageStream = assembly.GetManifestResourceStream("secondproject.res.engineers_c1.PNG");
        }
    }
}
