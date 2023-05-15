
//Seyed Erfan Noorbakhsh//
namespace interface_example.Class_Cars
{

    class Pride : Icarinterface
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

        public int Speed {
            get
            {
                return speed;
            }
            set
            {
                if (value > 130)
                {
                    Console.WriteLine("Warning!! high speed !");
                    speed = value;
                    
                }
                else
                {
                    Console.WriteLine("speed is safe");
                }
            }
        }


    }
}
