using System;
namespace FactoryPattern
{
    public class Default : IVehicle
    {
        public Default()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Sorry to say we do not have a vehicle for you.");
        }

    }
}
