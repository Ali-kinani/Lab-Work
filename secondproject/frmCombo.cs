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
    public partial class frmCombo : Form
    {
        public frmCombo()
        {
            InitializeComponent();
            CmbDays.Items.Add("Sundays");
            CmbDays.Items.Add("Monday"); 
            CmbDays.Items.Add("Tuesday"); 
            CmbDays.Items.Add("wendesday");
            CmbDays.Items.Add("thuresday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Satrurday");
            CmbDays.Items.Add("funday");
            CmbDays.Items.Add("Examday");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnShowSelectedMethod1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnShowSelectedMethod2_Click(object sender, EventArgs e)
        {
            var item = CmbDays.SelectedItem;
            MessageBox.Show(item.ToString());
        }

        private void BtnShowSelectedMethod3_Click(object sender, EventArgs e)
        {
            string itemText = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemText); // add if 
        }

        private void BtnRemovebyName_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove("Friday");
        }

        private void BtnRemovebyindex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void BtnRemovelastitem_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1) 
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("can not remove last itenm");
            }

        }

        private void BtnRemove2ndlastitme_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("can not remove last itenm");
            }
        }
    }
}
