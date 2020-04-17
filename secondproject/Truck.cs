using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondproject
{
    class Truck
    {
        int speed = 0;
        public void start()
        {
            speed = 10;
            MessageBox.Show("the Truck has started" + " the Truck speed is: " + speed);
        }
    }
}
