using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 6;
        public string Model { get; set; } = "F-150";
        public int Wheels { get; set; } = 4;
        public string Make { get; set; } = "Ford";
        public string Name { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"{GetType().Name} now driving forward in four wheel drive.");
            }
            else 
            {
                Console.WriteLine($"{GetType().Name} now driving forward.");
            }
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving in reverse.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void ChangeGears(bool hasChanged)
        {
            HasChangedGears = hasChanged;
        }
    }
}
