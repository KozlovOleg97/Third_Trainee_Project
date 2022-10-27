using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Trainee_Project
{
    internal abstract class Car : IVehicle
    {
        public int _rasho { get; private set; }
        public int _benz { get; private set; }

        public Car(int rasho)
        {
            _rasho = rasho;
        }

        public void Drive(int distance)
        {
            int litr = distance * _rasho;
            

            if (litr < _benz)
            {
                Console.WriteLine("not enough");
                return;
            }
            else
            {
                Console.WriteLine("Start");
            }

            _benz = _benz - litr;
        }

        public void Refuel(int benz)
        {
            _benz =  _benz + benz;
        }
    }
}
