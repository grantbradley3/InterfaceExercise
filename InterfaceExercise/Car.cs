using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public double EngineSize { get; set; } = 5;
        public string Model { get; set; } = "Camry";
        public int Wheels { get; set; } = 4;
        public string Make { get; set; } = "Toyota";
        public string Name { get; set; } = "Toyota";
        public string Motto { get; set; } = "Let's go places";
        public bool HasChangedGears { get; set; }   
        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward.");
        }
        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving in reverse.");
                HasChangedGears= false;
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
                HasChangedGears= false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears= isChanged;
        }
    }
}
