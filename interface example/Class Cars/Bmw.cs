using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Seyed Erfan Noorbakhsh//

namespace interface_example
{
    class Bmw : Icarinterface
    {
        public string GetCarName(string carName)
        {
            return "The car name is: " + carName;
        }

        public int MaximumPassenger(int passenger)
        {
            return passenger;
        }

        private int speed;

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value > 150)
                {
                    Console.WriteLine("Warning!! high speed !");
                    speed = 0;
                }
                else
                {
                    Console.WriteLine("speed is safe");
                }
            }
        }
    }
}
