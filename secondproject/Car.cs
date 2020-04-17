using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace secondproject
{
    class Car
    {
        int speed = 0;
        public void start()
        {
            speed = 10;
            MessageBox.Show("the car has started"+ " the car speed is: " +speed);

        }
        public void Accelerate()
        {
            speed += 30;
            MessageBox.Show("the car has Accelerated" + " the car speed is:" + speed);
        }
        public void stop()
        {
            speed = 0;
            MessageBox.Show("the car has stopped" + " the car speed is: " + speed);

        }
    }
}
