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
    public partial class frmClass : Form
    {
        Car Mycar = new Car();
        Car HisCar = new Car();
        Truck mytruck = new Truck();


        public frmClass()
        {
            InitializeComponent();
        }

        private void StartMyCar_Click(object sender, EventArgs e)
        {
            Mycar.start();
        }

        private void AccelerateMyCar_Click(object sender, EventArgs e)
        {
            Mycar.Accelerate();
        }

        private void StopMycar_Click(object sender, EventArgs e)
        {
            Mycar.stop();
        }

        private void StartHisCar_Click(object sender, EventArgs e)
        {
            HisCar.start();
        }

        private void AccelerateHisCar_Click(object sender, EventArgs e)
        {
            HisCar.Accelerate();
        }

        private void StopHisCar_Click(object sender, EventArgs e)
        {
            HisCar.stop();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void StartTruck_Click(object sender, EventArgs e)
        {
            mytruck.start();
        }
    }
}
